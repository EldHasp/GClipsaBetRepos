using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GClipsaBetModel
{
    public class ParseData
    {

        private readonly  string ConnectString;
        public ParseData(string connectString)
            => ConnectString = connectString;

        public IEnumerable<Match> GetALLMatches ()
        {
            string source =
"free:nophoto,Noname1,nophoto,Noname2:<26,[10%],[15%],[12%],nophoto,nophoto,nophoto;<26,[10%],[15%],[12%],nophoto,nophoto,nophoto;<26,[10%],[15%],[12%],nophoto,nophoto,nophoto" +
"=limited:12345678:nophoto,Noname1,nophoto,Noname2:100" +
"=free:nophoto,Noname1,nophoto,Noname2:<26,[10%],[15%],[12%],nophoto,nophoto,nophoto;<26,[10%],[15%],[12%],nophoto,nophoto,nophoto;<26,[10%],[15%],[12%],nophoto,nophoto,nophoto";

            return ParseLines(source.Split('='));

        }

        //        free:nophoto,Noname1,nophoto,Noname2:<26,[10%],[15%],[12%],nophoto,nophoto,nophoto;<26,[10%],[15%],[12%],nophoto,nophoto,nophoto,<26,[10%],[15%],[12%],nophoto,nophoto,nophoto
        //        limited:12345678:nophoto,Noname1,nophoto,Noname2:<26,[10%],[15%],[12%],nophoto,nophoto,nophoto,<26,[10%],[15%],[12%],nophoto,nophoto,nophoto,<26,[10%],[15%],[12%],nophoto,nophoto,nophoto:100:0
        /// <summary>Метод прасинга отдельных строк</summary>
        /// <param name="lines">Последовательность строк</param>
        public static IEnumerable<Match> ParseLines(IEnumerable<string> lines)
        {
            List<Match> list = new List<Match>();

            foreach (string line in lines)
            {
                if (line.StartsWith("limited"))
                {
                    list.Add(LimitedMatch.Parse(line));
                }
                else if (line.StartsWith("free"))
                {
                    list.Add(FreeMatch.Parse(line));
                }
            }

            return list;
        }
    }
}
