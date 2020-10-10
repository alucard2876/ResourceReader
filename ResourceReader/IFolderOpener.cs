namespace ResourceReader.Buisness.ResourceReader
{
    public interface IFolderOpener
    {
        string[] GetFileInFolders(string pathToFolder, File fileToOpen);
    }
}