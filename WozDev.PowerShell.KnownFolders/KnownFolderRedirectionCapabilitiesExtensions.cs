using WozDev.PowerShell.KnownFolders.Win32;

namespace WozDev.PowerShell.KnownFolders
{
    internal static class KnownFolderRedirectionCapabilitiesExtensions
    {
        public static bool HasMask(this KF_REDIRECTION_CAPABILITIES caps, KF_REDIRECTION_CAPABILITIES mask)
        {
            return (caps & mask) != 0;
        }
    }
}
