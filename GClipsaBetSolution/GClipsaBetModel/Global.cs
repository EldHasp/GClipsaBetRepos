namespace GClipsaBetModel
{
    // nophoto,Noname1,nophoto,Noname2
    /// <summary>Тип для данных секции Глобал</summary>
    public class Global
    {
        public string ImageLeft { get; set; }
        public string ImageRight { get; set; }

        public string TeamLeft { get; set; }
        public string TeamRight { get; set; }

        public static Global Parse(string source)
        {
            string[] arr = source.Split(',');
            return new Global()
            {
                ImageLeft = arr[0],
                TeamLeft = arr[1],
                ImageRight = arr[2],
                TeamRight = arr[3]
            };
        }
    }
}
