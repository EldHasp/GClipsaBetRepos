using System.Linq;

namespace GClipsaBetModel
{
    public class FreeMatch : Match
    {
        public FreeMatch()
            : base("free")
        { }
        public Info[] Infos { get; set; }

        public static FreeMatch Parse(string source)
        {
            string[] arr = source.Split(':');
            return new FreeMatch()
            {
                Global = Global.Parse(arr[1]),
                Infos = arr[2].Split(';').Select(Info.Parse).ToArray()
            };
        }
    }
}
