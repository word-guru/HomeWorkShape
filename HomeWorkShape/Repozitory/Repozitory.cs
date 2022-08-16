using HomeWorkShape.Model;
using HomeWorkShape.Repozitory.Interface;

namespace HomeWorkShape.Repozitory
{
    public class Repozitory : IRepozitory
    {
        private readonly IEnumerable<IShape> _shapes;

        private List<string> listName { get; set; }
        private List<string> listPicture { get; set; }

        public Repozitory(IEnumerable<IShape> shape)
        {

            _shapes = shape;
        }

        public List<string> GetName()
        {
            listName = new List<string>();
            foreach (var name in _shapes)
            {
                listName.Add(name.Name);
            }
            return listName;
        }

        public List<string> GetPicture()
        {
            listPicture = new List<string>();
            foreach (var name in _shapes)
            {
                listPicture.Add(name.Picture);
            }
            return listPicture;
        }
    }
}
