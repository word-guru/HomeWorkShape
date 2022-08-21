using HomeWorkShape.Repozitory.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWorkShape.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepozitory _repozitory;
        private readonly IFileOperation _fileOperation;
        public Dictionary<List<string>, List<string>> shape;
        public Dictionary<string, string> shape2 = new Dictionary<string, string>();

        public IndexModel(IRepozitory repozitory, IFileOperation fileOperations)
        {
            _repozitory = repozitory;
            shape = new Dictionary<List<string>, List<string>>();
            _fileOperation = fileOperations;
        }

        public void OnGet()
        {
            shape.Add(_repozitory.GetName(), _repozitory.GetPicture());
        }

        public void OnPostSaveFile()
        {
            shape.Add(_repozitory.GetName(), _repozitory.GetPicture());
            string res = "";
            foreach(var a in shape)
            {
                for(int i = 0; i < a.Key.Count; i++)
                {
                    res += a.Key[i] + " : " + a.Value[i] + Environment.NewLine;

                }
            }
           
            _fileOperation.SaveFile(res);
        }

        public void OnPostLoadFile()
        {
            shape2 = _fileOperation.LoadFile();
        }
    }
}