using System.IO;

namespace Logging
{
    public class FlatFileLogger : ILogListener
    {
        public static FileInfo TargetLogFile { get; private set; }
        public static DirectoryInfo TargetDirectory { get { return TargetLogFile.Directory; } }
        private bool _disposed = false;
        
        public FlatFileLogger(FileInfo targetLogFile)
        {
            TargetLogFile = targetLogFile;
            VerifyTargetDirectory();
        }

        public void Log(LogMessage log)
        {
            var message = log.ToString();

            if (!string.IsNullOrEmpty(message))
            {
                VerifyTargetDirectory();
                File.AppendAllText(TargetLogFile.FullName, message);  
            }
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        private static void VerifyTargetDirectory()
        {
            if (TargetDirectory == null)
            {
                throw new DirectoryNotFoundException("Target logging directory not found.");
            }

            TargetDirectory.Refresh();
            if (!TargetDirectory.Exists)
            {
                TargetDirectory.Create();
            }
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _disposed = true;
            }
        }
    }
}
