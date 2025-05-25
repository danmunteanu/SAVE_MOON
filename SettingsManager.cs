using System.Collections.Generic;
using System.Text.Json;
using Config.Net;

namespace SaveFolders
{
    public static class SettingsManager
    {
        private static readonly string configPath = "settings.json";

        public static string ConfigPath { get; set; } = configPath;

        public static ISettings Settings { get; } = new ConfigurationBuilder<ISettings>()
            .UseJsonFile(configPath)
            .Build();

        public static void SaveFolderList(List<SaveFolderInfo> folders)
        {
            string json = JsonSerializer.Serialize(folders);
            Settings.SaveFoldersJson = json;
        }

        public static List<SaveFolderInfo> LoadFolderList()
        {
            string json = Settings.SaveFoldersJson;
            return string.IsNullOrWhiteSpace(json)
                ? new List<SaveFolderInfo>()
                : JsonSerializer.Deserialize<List<SaveFolderInfo>>(json) ?? new List<SaveFolderInfo>();
        }
    }
}
