using GClipsaBetModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GClipsaBetViewModel
{
    public class ViewModel
    {
        public ObservableCollection<Match> Matches { get; } = new ObservableCollection<Match>();

        private readonly ParseData Model;

        public ViewModel(ParseData model)
        {
            Model = model;
            foreach (Match match in Model.GetALLMatches())
            {
                Matches.Add(match);
            }
        }

        public ViewModel()
        {
            string source =
@"free:nophoto,Noname1,nophoto,Noname2:<26,[10%],[15%],[12%],nophoto,nophoto,nophoto;<26,[10%],[15%],[12%],nophoto,nophoto,nophoto;<26,[10%],[15%],[12%],nophoto,nophoto,nophoto=limited:12345678:nophoto,Noname1,nophoto,Noname2:100";

            var list = ParseData.ParseLines(source.Split('='));

            foreach (Match match in list)
            {
                Matches.Add(match);
            }

        }

    }
}
