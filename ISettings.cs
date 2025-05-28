namespace SaveFolders
{
    public interface ISettings
    {
        string SaveFoldersJson { get; set; }
        int SelectedFolderIndex { get; set; }
    }
}