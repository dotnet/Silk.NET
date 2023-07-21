// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='ACTIVATEOPTIONS.xml' path='doc/member[@name="ACTIVATEOPTIONS"]/*' />
[Flags]
public enum ACTIVATEOPTIONS
{
    /// <include file='ACTIVATEOPTIONS.xml' path='doc/member[@name="ACTIVATEOPTIONS.AO_NONE"]/*' />
    AO_NONE = 0,

    /// <include file='ACTIVATEOPTIONS.xml' path='doc/member[@name="ACTIVATEOPTIONS.AO_DESIGNMODE"]/*' />
    AO_DESIGNMODE = 0x1,

    /// <include file='ACTIVATEOPTIONS.xml' path='doc/member[@name="ACTIVATEOPTIONS.AO_NOERRORUI"]/*' />
    AO_NOERRORUI = 0x2,

    /// <include file='ACTIVATEOPTIONS.xml' path='doc/member[@name="ACTIVATEOPTIONS.AO_NOSPLASHSCREEN"]/*' />
    AO_NOSPLASHSCREEN = 0x4,

    /// <include file='ACTIVATEOPTIONS.xml' path='doc/member[@name="ACTIVATEOPTIONS.AO_PRELAUNCH"]/*' />
    AO_PRELAUNCH = 0x2000000,
}
