using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1.Common
{
    class MessClass
    {
        
        public void ErrorMessage(string messeage, string title)
        {
            System.Windows.MessageBox.Show(messeage, title, MessageBoxButton.OK,MessageBoxImage.Error);
        }
        public void InfoMessage(string message, string title)
        {
            System.Windows.MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
