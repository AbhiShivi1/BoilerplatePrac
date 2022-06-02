using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MYDEMOPROJ.Localization
{
    public static class MYDEMOPROJLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MYDEMOPROJConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MYDEMOPROJLocalizationConfigurer).GetAssembly(),
                        "MYDEMOPROJ.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
