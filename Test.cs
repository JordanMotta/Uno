using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uno
{
    public partial class Test : Form
    {
        
        public Test()
        {
            InitializeComponent();
            
        }

        public void sendCard(Object sender, EventArgs e)
        {
            UButton b = (UButton)sender;
            Deck2.Text = b.Text;
            Deck2.BackColor = b.BackColor;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            UButton button = new UButton();
            Card card = new Card();
            card.color = System.Drawing.Color.Yellow;
            card.name = "2";
            button.drawCard(card);
            button.Click += sendCard;
            Hand.Controls.Add(button);
        }
    }
}
