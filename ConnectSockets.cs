using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Uno
{
    public partial class ConnectSockets : Form
    {
        USocket socket;
        public ConnectSockets(USocket com)
        {
            socket = com;
            InitializeComponent();
        }

        private void ListenerPortButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(socket.connectServer));
            thread.Start(ListenerPortText.Text);
        }

        private void SenderPortButton_Click(object sender, EventArgs e)
        {
            socket.connectSender(SenderPortText.Text);
            this.Close();
        }
    }
}
