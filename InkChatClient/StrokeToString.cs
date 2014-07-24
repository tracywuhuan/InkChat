using System;
using System.Windows.Ink;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkChatClient
{
    public class StrokeToString
    {
        public static string SaveToBase64String(StrokeCollection arg)
        {
            string result = null;
            using (var ms = new MemoryStream())
            {
                arg.Save(ms);
                result = Convert.ToBase64String(ms.GetBuffer());
            }
            return result;
        }

        public static StrokeCollection LoadFromBase64String(string base64string)
        {
            try
            {
                var ms = new MemoryStream(Convert.FromBase64String(base64string));
                return new StrokeCollection(ms);
            }
            catch (Exception)
            {

                //throw;
                return null;
            }

        }
    }
}
