using System.Collections.Generic;

namespace ResourceReader.Buisness.ResourceReader
{
    public interface IResourcerRepository
    {
        
        FolderOpener FolderOpener { get; }

        Dictionary<string, Resource> Run(File file, string pathToFolder);
    }
}