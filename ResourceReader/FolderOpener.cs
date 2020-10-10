using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ResourceReader.Buisness.ResourceReader
{
    public class FolderOpener : IFolderOpener
    {
        public string[] GetFileInFolders(string pathToFolder, File fileToOpen)
            => Directory.GetFiles(pathToFolder, fileToOpen.ToString(), SearchOption.AllDirectories);
    }
}
