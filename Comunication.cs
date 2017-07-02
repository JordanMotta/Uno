using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    public interface Comunication
    {
        void connect();
        Boolean isOpen();
        void send(string msg);
        string listen();
        void close();
    }
}
