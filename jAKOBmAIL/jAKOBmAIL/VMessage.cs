using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jAKOBmAIL
{
    public class VMessage
    {
        public void SendEmail(Message message, bool isHTML)
        {
            if (isHTML)
                message.Body = ConvertBodyToHTML(message.Body);
        }

        private string ConvertBodyToHTML(string plainText)
        {
            return "<html><body>" + plainText + "</body></html>";
        }
    }
}
