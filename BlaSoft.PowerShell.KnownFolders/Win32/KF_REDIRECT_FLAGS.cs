﻿namespace BlaSoft.PowerShell.KnownFolders.Win32
{
    internal enum KF_REDIRECT_FLAGS
    {
        KF_REDIRECT_NONE = 0,
        KF_REDIRECT_USER_EXCLUSIVE = 0x00000001,
        KF_REDIRECT_COPY_SOURCE_DACL = 0x00000002,
        KF_REDIRECT_OWNER_USER = 0x00000004,
        KF_REDIRECT_SET_OWNER_EXPLICIT = 0x00000008,
        KF_REDIRECT_CHECK_ONLY = 0x00000010,
        KF_REDIRECT_WITH_UI = 0x00000020,
        KF_REDIRECT_UNPIN = 0x00000040,
        KF_REDIRECT_PIN = 0x00000080,
        KF_REDIRECT_COPY_CONTENTS = 0x00000200,
        KF_REDIRECT_DEL_SOURCE_CONTENTS = 0x00000400,
        KF_REDIRECT_EXCLUDE_ALL_KNOWN_SUBFOLDERS = 0x00000800
    }
}
