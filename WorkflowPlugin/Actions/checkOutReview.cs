using System;
using System.Threading.Tasks;
using BarRaider.SdTools;
using com.darius.workflow.forms;
using Newtonsoft.Json.Linq;
using WorkflowPlugin.services;

namespace com.darius.workflow.Actions
{
    [PluginActionId("com.darius.workflow.checkOutReview")]
    public class CheckOutReviewAction : KeypadBase
    {
        private class PluginSettings
        {
            public static PluginSettings CreateDefaultSettings()
            {
                PluginSettings instance = new PluginSettings();
                return instance;
            }

        }

        #region Private Members

        private PluginSettings settings;

        #endregion
        public CheckOutReviewAction(SDConnection connection, InitialPayload payload) : base(connection, payload)
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
            await Connection.SetTitleAsync("test");
            CheckOutReviewForm checkOutReview = new CheckOutReviewForm();
            
            checkOutReview.ShowDialog();
            
            var checkOutJson = new
            {
                id = checkOutReview.CheckInId,
                gevoel = checkOutReview.GevoelText,
                planned = checkOutReview.PlannedText,
                completed = checkOutReview.CompletedText,
                learned = checkOutReview.LearnedText,
                inSciron = checkOutReview.Scorion
            };
                    
            await Api.UpdateCheckIn(checkOutJson);
            
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