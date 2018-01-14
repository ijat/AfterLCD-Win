using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using AfterLCD_client.Model;

namespace AfterLCD_client.Service
{
        public class MAHM
    {
        private static MAHM _instance;
        public static MAHM Instance
        {
            get
            {
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public string uri { get; set; }
        public string port { get; set; }
        public string host { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public MAHM(string t)
        {
            uri = t + "/mahm";

            Match match = Regex.Match(uri, @":([0-9]+)/", RegexOptions.IgnoreCase);
            if (match.Success)
                port = match.Groups[1].Value;
            else
                throw new Exception();

            match = Regex.Match(uri, @"@([a-zA-Z]*):", RegexOptions.IgnoreCase);
            if (match.Success)
                host = match.Groups[1].Value;
            else
                throw new Exception();

            match = Regex.Match(uri, @"//(\w*):", RegexOptions.IgnoreCase);
            if (match.Success)
                username = match.Groups[1].Value;
            else
                throw new Exception();

            match = Regex.Match(uri, @":(\w*)@", RegexOptions.IgnoreCase);
            if (match.Success)
                password = match.Groups[1].Value;
            else
                throw new Exception();

        }

        public bool ping()
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    tcpClient.Connect(host, int.Parse(port));
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public HardwareMonitor Get()
        {

            string x;

            CredentialCache credsCache = new CredentialCache();

            NetworkCredential myCred = new NetworkCredential(username, password);
            credsCache.Add(new Uri($"http://{host}:{port}/mahm"), "Basic", myCred);

            WebRequest request = WebRequest.Create($"http://{host}:{port}/mahm");
            request.Credentials = credsCache;

            //request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                x = reader.ReadToEnd();
            }

            XmlSerializer serializer = new XmlSerializer(typeof(HardwareMonitor));
            StringReader rdr = new StringReader(x);
            HardwareMonitor resultingMessage = (HardwareMonitor)serializer.Deserialize(rdr);
            return resultingMessage;

        }
    }
}
