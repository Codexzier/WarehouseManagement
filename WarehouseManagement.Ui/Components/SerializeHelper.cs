using Newtonsoft.Json;
using System;
using WarehouseManagement.Ui.Components.UserSettings;

namespace WarehouseManagement.Ui.Components
{
    public static class SerializeHelper
    {
        public static Func<CustomSettingsFile, string> Serialize = JsonConvert.SerializeObject;
        public static Func<string, CustomSettingsFile> Deserialize = JsonConvert.DeserializeObject<CustomSettingsFile>;
    }
}