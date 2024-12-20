using System;
using System.Runtime.InteropServices;

namespace WozDev.PSKnownFolders.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct FOLDERTYPEID
    {
        public Guid value;
    }
}
