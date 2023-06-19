using System;
using System.Threading.Tasks;
using BarRaider.SdTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WorkflowPlugin.services;


namespace com.darius.workflow.Actions
{
    [PluginActionId("com.darius.workflow.checkin")]
    public class CheckInAction : KeypadBase
    {
        private class PluginSettings
        {
            public static PluginSettings CreateDefaultSettings()
            {
                PluginSettings instance = new PluginSettings();
                instance.CheckIn = false;
                instance.CheckInDate = DateTime.Now;
                return instance;
            }

            [FilenameProperty]
            [JsonProperty(PropertyName = "checkIn")]
            public bool CheckIn { get; set; }

            [JsonProperty(PropertyName = "CheckInDate")]
            public DateTime CheckInDate { get; set; }
        }

        #region Private Members

        private PluginSettings settings;

        #endregion
        public CheckInAction(SDConnection connection, InitialPayload payload) : base(connection, payload)
        {
            if (payload.Settings == null || payload.Settings.Count == 0)
            {
                this.settings = PluginSettings.CreateDefaultSettings();
                SaveSettings();
            }
            else
            {
                this.settings = payload.Settings.ToObject<PluginSettings>();
            }
        }

        public override void Dispose()
        {
            Logger.Instance.LogMessage(TracingLevel.INFO, $"Destructor called");
        }

        public override async void KeyPressed(KeyPayload payload)
        {
            var jsonData = new { name = "Dev test", type = "check_in" };
            await Connection.SetTitleAsync( await Api.Events(jsonData));
            await Connection.SetTitleAsync( await Api.Debug(payload.Settings.ToString()));
            Logger.Instance.LogMessage(TracingLevel.INFO, "Key Pressed");
        }

        public override void KeyReleased(KeyPayload payload) { }

        public override void OnTick() { }

        public override async void ReceivedSettings(ReceivedSettingsPayload payload)
        {
            Tools.AutoPopulateSettings(settings, payload.Settings);
            await SaveSettings();
        }

        public override void ReceivedGlobalSettings(ReceivedGlobalSettingsPayload payload) { }

        #region Private Methods

        private Task SaveSettings()
        {
            return Connection.SetSettingsAsync(JObject.FromObject(settings));
        }

        #endregion
    }
}