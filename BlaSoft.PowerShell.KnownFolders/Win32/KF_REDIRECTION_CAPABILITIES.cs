﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlaSoft.PowerShell.KnownFolders.Win32
{
    [Flags]
    enum KF_REDIRECTION_CAPABILITIES : uint
    {
        KF_REDIRECTION_CAPABILITIES_NONE = 0,
        KF_REDIRECTION_CAPABILITIES_ALLOW_ALL = 0x000000FF,
        KF_REDIRECTION_CAPABILITIES_REDIRECTABLE = 0x00000001,
        KF_REDIRECTION_CAPABILITIES_DENY_ALL = 0x000FFF00,
        KF_REDIRECTION_CAPABILITIES_DENY_POLICY_REDIRECTED = 0x00000100,
        KF_REDIRECTION_CAPABILITIES_DENY_POLICY = 0x00000200,
        KF_REDIRECTION_CAPABILITIES_DENY_PERMISSIONS = 0x00000400
    }
}
