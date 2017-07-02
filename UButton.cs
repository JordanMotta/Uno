using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class UButton : System.Windows.Forms.Button
    {
        private Card card;
        public void drawCard(Card card)
        {
            this.card = card;
            Text = card.name;
            BackColor = card.color;
        }
    }
}
