namespace SaveFolders
{
    public class SaveFolderInfo
    {
        public string Label { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;

        public SaveFolderInfo(string path, string label)
        {
            Path = path;
            Label = label;
        }
    }
}
