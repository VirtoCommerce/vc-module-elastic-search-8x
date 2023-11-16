using VirtoCommerce.Platform.Core.Settings;
using ModuleSettings = VirtoCommerce.ElasticSearch8.Core.ModuleConstants.Settings.General;

namespace VirtoCommerce.ElasticSearch8.Data.Extensions
{
    public static class SettingsExtensions
    {
        public static int GetFieldsLimit(this ISettingsManager settingsManager)
        {
            return settingsManager.GetValue<int>(ModuleSettings.IndexTotalFieldsLimit);
        }

        public static string GetTokenFilterName(this ISettingsManager settingsManager)
        {
            return settingsManager.GetValue<string>(ModuleSettings.TokenFilter);
        }

        public static int GetMinGram(this ISettingsManager settingsManager)
        {
            return settingsManager.GetValue<int>(ModuleSettings.MinGram);
        }

        public static int GetMaxGram(this ISettingsManager settingsManager)
        {
            return settingsManager.GetValue<int>(ModuleSettings.MaxGram);
        }

        public static bool GetSemanticSearchEnabled(this ISettingsManager settingsManager)
        {
            return settingsManager.GetValue<bool>(ModuleSettings.EnableSemanticSearch);
        }

        public static string GetPipelineName(this ISettingsManager settingsManager)
        {
            return settingsManager.GetValue<string>(ModuleSettings.SemanticPipelineName);
        }

        public static string GetModelId(this ISettingsManager settingsManager)
        {
            return settingsManager.GetValue<string>(ModuleSettings.SemanticModelId);
        }

        public static string GetModelFieldName(this ISettingsManager settingsManager)
        {
            return settingsManager.GetValue<string>(ModuleSettings.SemanticFieldName);
        }
    }
}
