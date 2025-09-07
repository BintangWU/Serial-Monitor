using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace SerialMonitor
{
    public partial class Form1 : Form
    {
        private SerialPort _serialPort;
        private StringBuilder _dataBuffer;
        private bool _autoScroll = true;
        private bool _isConnected = false;

        public Form1()
        {
            InitializeComponent();

            this.MaximizeBox = false;

            _serialPort = new SerialPort();
            _serialPort.DataReceived += _serialPort_DataReceived;
            tb_baud.KeyPress += TextBoxNumeric.NumericOnly_KeyPress;
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int bytesToRead = _serialPort.BytesToRead;  
                byte[] buffer = new byte[bytesToRead];
                _serialPort.Read(buffer, 0, bytesToRead);

                this.Invoke(new Action(() =>
                {
                    string receivedData = Encoding.ASCII.GetString(buffer);
                    tb_debugging.AppendText(receivedData);
                    if (_autoScroll)
                    {
                        tb_debugging.SelectionStart = tb_debugging.Text.Length;
                        tb_debugging.ScrollToCaret();
                    }
                }));
            }
            catch (Exception ex)
            {
            }
        }

        private void ScanComPorts()
        {
            cbo_comPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cbo_comPort.Items.AddRange(ports);
            if (ports.Length > 0)
            {
                cbo_comPort.SelectedIndex = 0;
            }
        }

        private bool SerialConnect()
        {
            try
            {
                _serialPort.PortName = cbo_comPort.SelectedItem.ToString();
                _serialPort.BaudRate = int.TryParse(tb_baud.Text, out int baud) ? baud : 9600;  
                _serialPort.DataBits = 8;
                _serialPort.Parity = Parity.None;
                _serialPort.StopBits = StopBits.One;
                _serialPort.Handshake = Handshake.XOnXOff;

                _serialPort.Open();
                return true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error opening Serial Port[{cbo_comPort.SelectedItem.ToString()}]: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void SerialDisconnect()
        {
            try
            {
                if (_serialPort.IsOpen && _isConnected)
                {
                    _serialPort.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void SendMessage()
        {
            if (!_isConnected && !_serialPort.IsOpen)
            {
                MessageBox.Show("Serial Port is not connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string message = tb_message.Text.ToString();
                if (!string.IsNullOrEmpty(message))
                {
                    _serialPort.Write(message + "\r\n");
                    tb_message.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ScanComPorts();
            tb_baud.Text = "9600";
        }

        private void btn_scan_Click(object sender, EventArgs e)
        {
            ScanComPorts();            
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!_isConnected && SerialConnect())
            {
                _isConnected = true;
                btn_connect.Text = "CLOSE";
                btn_scan.Enabled = false;
                cbo_comPort.Enabled = false;
                tb_baud.Enabled = false;
            }
            else
            {
                SerialDisconnect();

                _isConnected = false;
                btn_connect.Text = "OPEN";
                btn_scan.Enabled = true;
                cbo_comPort.Enabled = true;
                tb_baud.Enabled = true;   
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_debugging.Clear();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void tb_message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; 
                SendMessage();
            }   
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SerialConnect();
        }

    }
}
