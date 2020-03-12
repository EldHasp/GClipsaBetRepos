using Common;

namespace GClipsaBetModel
{
    public class Match : OnPropertyChangedClass
    {
        private bool _isSelected;

        public string Type { get; }
        public Global Global { get; set; }

        public Match(string type) => Type = type;

        public bool IsSelected { get => _isSelected; set => SetProperty(ref _isSelected , value); }
    }
}
