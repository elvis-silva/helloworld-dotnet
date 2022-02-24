namespace HelloWorld.Helper
{
    public class FileHelper
    {
        public void ListDirectories(string path) 
        {
            var directories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

            foreach(var directory in directories) 
            {
                System.Console.WriteLine(directory);
            }
        }

        public void ListFiles(string path) 
        {
            var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            foreach(var file in files) 
            {
                System.Console.WriteLine(file);
            }
        }

        public void CreateDirectory(string path)
        {
            var directory = Directory.CreateDirectory(path);
            System.Console.WriteLine(directory.FullName);
        }

        public void DeleteDirectory(string path)
        {
            Directory.Delete(path, true);

        }

        public void CreateFileTxt(string path, string fileContent)
        {
            if(!File.Exists(path)) {
                File.WriteAllText(path, fileContent);
            }
        }

        public void AppendContentToFileTxt(string path, string fileContent)
        {
            File.AppendAllText(path, fileContent);
        }

        public void CreateStreamFileTxt(string path, List<string> fileContent)
        {
            using(var stream = File.CreateText(path))
            {
                foreach(var line in fileContent)
                {
                    stream.WriteLine(line);
                }
            }
        }

        public void AppendStreamFileTxt(string path, List<string> fileContent)
        {
            using(var stream = File.AppendText(path))
            {
                foreach(var line in fileContent)
                {
                    stream.WriteLine(line);
                }
            }
        }

        public void ReadFileTxt(string path)
        {
            var fileContent = File.ReadAllLines(path);
            foreach(var line in fileContent) 
            {
                System.Console.WriteLine(line);
            }
        }

        public void ReadStreamFileTxt(string path)
        {
            var line = string.Empty;
            using (var stream = File.OpenText(path))
            {
                while ((line = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                }
            }
        }

        public void MoveFile(string sourceFileName, string destFileName) 
        {
            File.Move(sourceFileName, destFileName);
        }

        public void CopyFile(string sourceFile, string newFile, bool overwrite)
        {
            File.Copy(sourceFile, newFile, overwrite);
        }

        public void DeleteFile(string path)
        {
            File.Delete(path);
        }
    }
}