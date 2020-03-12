namespace GClipsaBetModel
{
    /*<26,[10%],[15%],[12%],nophoto,nophoto,nophoto,<26,[10%],[15%],[12%],nophoto,nophoto,nophoto,<26,[10%],[15%],[12%],nophoto,nophoto,nophoto*/
    public class Info
    {
        /// <summary></summary>
        public string Total { get; set; }
        public string BetMap { get; set; }
        public string BetPist1 { get; set; }
        public string BetPist2 { get; set; }
        public string TeamMap { get; set; }
        public string TeamPist1 { get; set; }
        public string TeamPist2 { get; set; }
        public static Info Parse(string source)
        {
            string[] arr = source.Split(',');
            return new Info()
            {
                Total = arr[0],
                BetMap = arr[1],
                BetPist1 = arr[2],
                BetPist2 = arr[3],
                TeamMap = arr[4],
                TeamPist1 = arr[5],
                TeamPist2 = arr[6]
            };
        }
    }
}
