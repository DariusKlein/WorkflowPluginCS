using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarRaider.SdTools;
using com.darius.workflow.forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WorkflowPlugin.services;
using Microsoft.VisualBasic;

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
                instance.CheckedIn = false;
                instance.CheckInDate = DateTime.Now;
                instance.CurrentCheckIn = 0;
                return instance;
            }

            [FilenameProperty]
            [JsonProperty(PropertyName = "checkIn")]
            public bool CheckedIn { get; set; }

            [JsonProperty(PropertyName = "CheckInDate")]
            public DateTime CheckInDate { get; set; }
            
            [JsonProperty(PropertyName = "currentCheckIn")]
            public int CurrentCheckIn { get; set; }
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
                Connection.SetStateAsync(Convert.ToUInt16(this.settings.CheckedIn));
            }
        }

        public override void Dispose()
        {
            Logger.Instance.LogMessage(TracingLevel.INFO, $"Destructor called");
        }

        public override async void KeyPressed(KeyPayload payload)
        {
            CheckInForm checkIn = new CheckInForm();
            var checkedIn = this.settings.CheckedIn;
            var name = "";
            var type = "";
            if (checkedIn)
            {
                name = "check out";
                type = "check_out";
                this.settings.CheckedIn = false;
            }
            else
            {
                name = "check in";
                type = "check_in";
                this.settings.CheckedIn = true;
                checkIn.ShowDialog();
                
                var checkInJson = new { gevoel = checkIn.GevoelText, planned = checkIn.PlannedText };
                
                JObject response = JObject.Parse(await Api.CreateCheckIn(checkInJson));

                this.settings.CurrentCheckIn = (int)response["id"];
            }

            var eventJson = new { name, type };
            
            await Api.Events(eventJson);
            await Connection.SetTitleAsync(name);
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