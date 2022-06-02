using MYDEMOPROJ.Debugging;

namespace MYDEMOPROJ
{
    public class MYDEMOPROJConsts
    {
        public const string LocalizationSourceName = "MYDEMOPROJ";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a2e0d18d36e645c8848ff6a7bdb97b75";
    }
}
