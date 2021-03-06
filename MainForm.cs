﻿using Mirage_Security.Artifacts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mirage_Security
{
    public partial class MainForm : Form
    {
        Artifact driver;
        Artifact fs;
        Artifact mutex;
        Artifact process;
        Artifact registry;

        public MainForm()
        {
            InitializeComponent();

            driver = new Driver();
            fs = new Filesystem();
            mutex = new Mutex();
            process = new Process();
            registry = new Registry();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

            driver.remove();
            fs.remove();
            mutex.remove();
            process.remove();
            registry.remove();

            this.Close();
        }

        private void updateStatus(Guna.UI2.WinForms.Guna2Button button, Guna.UI2.WinForms.Guna2CirclePictureBox statusMarker, int status)
        {
            switch (status)
            {
                case 1:
                    statusMarker.BeginInvoke(new Action(() => statusMarker.FillColor = Color.Green));
                    button.BeginInvoke(new Action(() => { button.Text = "Disable"; button.Enabled = true; }));
                    break;
                case 2:
                    statusMarker.BeginInvoke(new Action(() => statusMarker.FillColor = Color.Yellow));
                    button.BeginInvoke(new Action(() => { button.Text = "Loading"; button.Enabled = false; }));
                    break;
                case 3:
                    statusMarker.BeginInvoke(new Action(() => statusMarker.FillColor = Color.Red));
                    button.BeginInvoke(new Action(() => { button.Text = "Enable"; button.Enabled = true; }));
                    break;
                default:
                    break;
            }
            
        }

        private void doButtonWork(Guna.UI2.WinForms.Guna2Button button, Guna.UI2.WinForms.Guna2CirclePictureBox statusMarker, Artifact a)
        {
            updateStatus(button, statusMarker, 2);

            if (button.Checked)
            {
                Task.Factory.StartNew(() =>
                {
                    a.create();
                    updateStatus(button, statusMarker, 1);
                });
            }
            else
            {
                Task.Factory.StartNew(() =>
                {
                    a.remove();
                    updateStatus(button, statusMarker, 3);
                });
            }
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            doButtonWork(fileButton, fileStatus, fs);
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            doButtonWork(processButton, processStatus, process);
        }

        private void registryButton_Click(object sender, EventArgs e)
        {
            doButtonWork(registryButton, registryStatus, registry);
        }

        private void driverButton_Click(object sender, EventArgs e)
        {
            doButtonWork(driverButton, driverStatus, driver);
        }

        private void mutexButton_Click(object sender, EventArgs e)
        {
            doButtonWork(mutexButton, mutexStatus, mutex);
        }
    }
}
