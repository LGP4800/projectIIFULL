﻿using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;

namespace Led
{
    public partial class Form1 : Form
    {
        SerialPort port;
        Thread tempStatusThread;

        int setPoint;
        byte[] command = new byte[1];
        public Form1()
        {
          
            InitializeComponent();
            SetLabel(setPoint.ToString());
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            if (port == null)
            {
                port = new SerialPort("COM3", 115200);//Set your board COM
                port.Open();

                tempStatusThread = new Thread(readTemp); // creez un nou Thread pentru metoda care citeste temperatura odata la 0.5 secunde de pe port 
                tempStatusThread.Start(); // starting thread

            }
        }
        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
        }
        void SetLabel(string text)
        {
            labelSetPoint.Text = text;
        }

        void readTemp()
        {
            while (true)
            {

                //port.DiscardInBuffer();
                while ((byte) port.ReadByte() != 0xFE);
                byte temp = (byte) port.ReadByte();
                byte setPoint = (byte)port.ReadByte();
                byte status = (byte)port.ReadByte();
                byte crc = (byte)port.ReadByte();
                int a = Convert.ToInt32(temp);

                if ((byte)port.ReadByte() == 0xFF)
                {
                   Debug.WriteLine("Primit Enf of Frame");
                }
                else
                {
                    Debug.WriteLine("EOF nok");
                }

                if ((byte)(temp + setPoint + status) == crc)
                {
                    Debug.WriteLine("crc is ok");
                }
                else
                {
                    Debug.WriteLine("crc is nok");
                }

                this.Invoke(new MethodInvoker(delegate ()
                 {
                     labelTemp.Text = " " + temp;
                 }));
                this.Invoke(new MethodInvoker(delegate ()
                {
                    labelSetPoint.Text = " " + setPoint;
                }));
                this.Invoke(new MethodInvoker(delegate ()
                {
                          labelStatus.Text = " " + status;
                }));// nu pot modifica formul din al thread decat cel care l-a creat. pentru asta se foloseste begin invoke 
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\DB\AppDB.mdf;Integrated Security=True;Connect Timeout=30"); //schimba location cu path-ul bazei tale de date create. LoginTable e tabel cu id, username, password
                string now = DateTime.Now.ToString("F", CultureInfo.CreateSpecificCulture("en-US"));
                SqlCommand comm = new SqlCommand("insert into LogTemp1 values (' " + a + "', '" + now + "')", conn);
                SqlDataAdapter sda = new SqlDataAdapter(comm);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                Thread.Sleep(500);
            }
        }




        private void button3_Click(object sender, EventArgs e)//SetPlus
        {
       
            command[0] = 3;
            PortWrite(command);
            setPoint++;
            SetLabel(setPoint.ToString());
        }
        private void button1_Click(object sender, EventArgs e)//SetMinus
        {
           
            command[0] = 4;
            PortWrite(command);
            setPoint--;
            SetLabel(setPoint.ToString());
        }


        private void PortWrite(byte[] message)
        {
            port.Write(message, 0, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            command[0] = 0xFF;
            PortWrite(command);
            this.Close();
        }
    }
}