using GClipsaBetModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GClipsaBetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParseData model = new ParseData();
            string source =
@"free:nophoto,Noname1,nophoto,Noname2:<26,[10%],[15%],[12%],nophoto,nophoto,nophoto;<26,[10%],[15%],[12%],nophoto,nophoto,nophoto;<26,[10%],[15%],[12%],nophoto,nophoto,nophoto=limited:12345678:nophoto,Noname1,nophoto,Noname2:100";

            var list = ParseData.ParseLines(source.Split('='));
        }
    }
}
