namespace SaveFolders
{
    public class SaveFolderInfo
    {
        public string Desc { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;

        public SaveFolderInfo(string path, string desc)
        {
            Path = path;
            Desc = desc;
        }
    }
}
