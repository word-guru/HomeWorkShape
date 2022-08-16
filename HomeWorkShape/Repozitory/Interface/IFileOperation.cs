namespace HomeWorkShape.Repozitory.Interface
{
    public interface IFileOperation
    {
        void SaveFile(string text);
        Dictionary<string, string> LoadFile(IFormFile uploadedFile);
    }
}
