using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Model
{
    public class ToolsModel
    {
        private int _number = 0;

        public int Number 
        {
            get { return _number;}
            set { _number = value; }
        }

        public int Number1 
        {
            get { return _number + 1 ; }
        }

        public int Number2
        {
            get { return _number + 2; }
        }


        public int Number3
        {
            get { return _number + 3; }
        }


        public int Number4
        {
            get { return _number + 4; }
        }
        public int Number5
        {
            get { return _number + 5; }
        }



    }
}
