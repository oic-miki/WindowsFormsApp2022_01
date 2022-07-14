using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2022_01
{
    public class DTOMockObject
    {

        private static DTOMockObject self = new DTOMockObject();

        private DTOMockObject()
        {

        }

        public static DTOMockObject getInstance()
        {

            return self;

        }

        public int getInt()
        {

            return 101;

        }

        public String getString()
        {

            return "変ったよ！";

        }

    }
}
