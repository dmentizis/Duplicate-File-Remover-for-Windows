using DuplicateRemover.Objects;
using System.CodeDom;
using System.Diagnostics;
using System.IO;
using System.Security.Policy;

namespace DuplicateRemover
{
    public static class LogicMethods
    {
        #region Basic Methods
        public static string ComputeFileHash(string filePath)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {

            }

            return string.Empty;
        }

        public static String[] ScanFolder(string Dir, bool ScanSubFolders)
        {

            if (!string.IsNullOrWhiteSpace(Dir))
                throw new Exception("Directory path is invalid");

            if (!Directory.Exists(Dir))
                throw new Exception("Directory does no longer exist");

            if (ScanSubFolders)
                return Directory.GetFiles(Dir, "*", SearchOption.AllDirectories);
            else
                return Directory.GetFiles(Dir);
        }

        public static List<FileInfo> GetFileInfos(String[] FilePaths)
        {
            List<FileInfo> fileInfos = new List<FileInfo>();

            foreach (var filePath in FilePaths)
                fileInfos.Add(GetFileInfo(filePath));

            return fileInfos;
        }

        public static FileInfo GetFileInfo(string FilePath)
        {
            return new FileInfo(FilePath);
        }

        public static string GetFileExtension(string FilePath)
        {
            return Path.GetExtension(FilePath);
        }

        public static void DeleteFiles(List<string> FilePaths)
        {
            foreach (var filePath in FilePaths)
            {
                DeleteFile(filePath);
            }
        }

        public static void DeleteFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
        }
        #endregion

        #region Business Logic Methods
        // Add business logic methods here in the future
        public static List<PhysicalFile> GetPhysicalFiles(String[] FilePaths)
        {
            List<PhysicalFile> physicalFiles = new List<PhysicalFile>();
            foreach (var filePath in FilePaths)
            {
                PhysicalFile physicalFile = new PhysicalFile
                {
                    Path = filePath,
                    Hash = ComputeFileHash(filePath),
                    SizeInBytes = GetFileInfo(filePath).Length
                };
                physicalFiles.Add(physicalFile);
            }
            return physicalFiles;
        }

        public static void AutoCleanList(List<UniqueFile> UniqueFiles)
        {
            if(UniqueFiles.Count == 0)
            {
                throw new Exception("File list is empty");
            }

            foreach(UniqueFile file in UniqueFiles)
            {
                if(file.Paths.Count <= 1)
                    continue;
                else
                    file.Paths.Sort();

                if (file.Paths.Count > 1)
                    foreach (string filePath in file.Paths)
                        DeleteFile(filePath);
            }    
        }

        public static void KeepOnlySelectedFile(UniqueFile UniqueFile, string FilePath)
        {
            UniqueFile.Paths.Remove(FilePath);
            
            if (UniqueFile.Paths.Count <= 1)
                return;

            DeleteFiles(UniqueFile.Paths);            
        }

        public static void KeepOnlyFirstFile(UniqueFile UniqueFile)
        {
            UniqueFile.Paths.Sort();
            
            if (UniqueFile.Paths.Count <= 1)
                return;

            UniqueFile.Paths.RemoveAt(0);

            DeleteFiles(UniqueFile.Paths);
        }

        public static void OpenFileLocation(String FilePath)
        {
            if (File.Exists(FilePath))
            {
                Process.Start("explorer.exe", FilePath);
            }
        }
        #endregion

    }
}
