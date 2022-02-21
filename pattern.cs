using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace murzaev_mvc
{
    class pattern
    {
        static int one = 0;
        static int two = 0;
        public static List<string> operList = new List<string> { "+", "-", "*", "/" };
        static int operId = 0;

        public static TextBox tbPerviy;
        public static TextBox tbVtoroy;
        public static TextBox tbItogoviy;

        public static int One
        {
            set
            {
                one = value;
            }
        }
        public static int Two
        {
            set
            {
                two = value;
            }
        }
        public static int cbMoove
        {
            set
            {
                operId = value;
            }
        }
        public static string Rez
        {
            get
            {
                switch (operId)
                {
                    case 0:
                        return tbItogoviy.Text = (one + two).ToString();
                    case 1:
                        return tbItogoviy.Text = (one - two).ToString();
                    case 2:
                        return tbItogoviy.Text = (one * two).ToString();
                    case 3:
                        return tbItogoviy.Text = (one / two).ToString();
                    default:
                        return "!!!";
                }
            }
        }
    }
}
