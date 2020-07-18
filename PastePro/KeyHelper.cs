using System.Collections.Generic;
using System.Windows.Forms;

namespace PastePro
{
    public class KeyHelper
    {
        public static Dictionary<Keys, int> ModKeys => new Dictionary<Keys, int>
        {
            {Keys.Control, 2},
            {Keys.Shift, 4},
            {Keys.Alt, 1}
        };
    }
}
