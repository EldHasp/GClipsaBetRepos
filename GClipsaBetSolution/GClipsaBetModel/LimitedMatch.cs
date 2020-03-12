namespace GClipsaBetModel
{
    public class LimitedMatch : Match
    {
        public LimitedMatch()
            : base("limited")
        { }

        public int ID { get; set; }
        public int Cost { get; set; }

        public static LimitedMatch Parse(string source)
        {
            string[] arr = source.Split(':');
            return new LimitedMatch()
            {
                ID =int.Parse(arr[1]),
                Global = Global.Parse(arr[2]),
                Cost = int.Parse(arr[3])
            };
        }
    }
}
