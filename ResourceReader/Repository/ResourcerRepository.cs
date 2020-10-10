using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResourceReader.Buisness.ResourceReader
{
    public class ResourcerRepository : ViewModelBase, IResourcerRepository
    {
        
        private FolderOpener folderOpener;
    

        public FolderOpener FolderOpener
        {
            get => GetProperty(() => folderOpener);
            private set => SetProperty(() => folderOpener, value);
        }

        public ResourcerRepository(FolderOpener folderOpener)
        {
            FolderOpener = folderOpener;
        }


        public Dictionary<string, Resource> Run(File file, string pathToFolder)
        {
            var files = FolderOpener.GetFileInFolders(pathToFolder, file);
            var dictionary = new Dictionary<string, Resource>();
            foreach (var currentFile in files)
            {
                var temp = new Dictionary<string, Resource>().GetResource(currentFile);
                foreach (var item in temp)
                {
                    dictionary[item.Key] = item.Value;
                }
            }
            return dictionary;
        }


    }
}
