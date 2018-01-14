using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AfterLCD_client.Service;

namespace AfterLCD_client
{

    public partial class MainWindow : Window
    {
        public MAHM M;
        public Timer t;

        public MainWindow()
        {
            InitializeComponent();
            ScanPorts();

            CurrentURI.Text = "http://MSIAfterburner:abc123@localhost:8282";
            CurrentURI.TextWrapping = TextWrapping.NoWrap;
            /*if (CurrentSerialPort.Text == "" || CurrentURI.Text == "")
            {
                StartButton.IsEnabled = false;
            }*/
        }

        private void ScanPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string p in ports)
            {
                ComboBoxItem a = new ComboBoxItem
                {
                    Content = p
                };
                CurrentSerialPort.Items.Add(a);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Init services
            MAHM.Instance = new MAHM(CurrentURI.Text);
            ArduinoSerial.Instance = new ArduinoSerial(CurrentSerialPort.Text, 115200);

            if (MAHM.Instance.ping())
            {
                t = new Timer();
                t.Interval = 300;
                t.Elapsed += T_Elapsed1;
                t.Start();
            }
        }

        private void T_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Update();
        }

        private void Update()
        {
            var xx = MAHM.Instance.Get();

            double cpu_usage = Math.Round(xx.HardwareMonitorEntries.FirstOrDefault(x => x.srcId == 144).data, 0);
            double cpu_temp = Math.Round(xx.HardwareMonitorEntries.FirstOrDefault(x => x.srcId == 128).data, 0);
            double gpu_usage = Math.Round(xx.HardwareMonitorEntries.FirstOrDefault(x => x.srcId == 48).data, 0);
            double gpu_temp = Math.Round(xx.HardwareMonitorEntries.FirstOrDefault(x => x.srcId == 0).data, 0);
            double fps = Math.Round(xx.HardwareMonitorEntries.FirstOrDefault(x => x.srcId == 80).data, 0);

            string cu, ct, gu, gt, fp;

            if (cpu_usage >= 100)
                cpu_usage = 99;
            cu = cpu_usage.ToString("00");

            if (cpu_temp >= 100)
                cpu_temp = 99;
            ct = cpu_temp.ToString("00");

            if (gpu_usage >= 100)
                gpu_usage = 99;
            gu = gpu_usage.ToString("00");

            if (gpu_temp >= 100)
                gpu_temp = 99;
            gt = gpu_temp.ToString("00");

            if (fps >= 1000)
                fps = 999;
            fp = fps.ToString("000");

            ArduinoSerial.Instance.Test($"CPU {cu}% {ct}C  FPS", $"GPU {gu}% {gt}C  {fp}");
        }
    }
}
