// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HTMLAppFlag.xml' path='doc/member[@name="HTMLAppFlag"]/*' />
public enum HTMLAppFlag
{
    /// <include file='HTMLAppFlag.xml' path='doc/member[@name="HTMLAppFlag.HTMLAppFlagNo"]/*' />
    HTMLAppFlagNo = 0,

    /// <include file='HTMLAppFlag.xml' path='doc/member[@name="HTMLAppFlag.HTMLAppFlagOff"]/*' />
    HTMLAppFlagOff = 0,

    /// <include file='HTMLAppFlag.xml' path='doc/member[@name="HTMLAppFlag.HTMLAppFlag0"]/*' />
    HTMLAppFlag0 = 0,

    /// <include file='HTMLAppFlag.xml' path='doc/member[@name="HTMLAppFlag.HTMLAppFlagYes"]/*' />
    HTMLAppFlagYes = 1,

    /// <include file='HTMLAppFlag.xml' path='doc/member[@name="HTMLAppFlag.HTMLAppFlagOn"]/*' />
    HTMLAppFlagOn = 1,

    /// <include file='HTMLAppFlag.xml' path='doc/member[@name="HTMLAppFlag.HTMLAppFlag1"]/*' />
    HTMLAppFlag1 = 1,

    /// <include file='HTMLAppFlag.xml' path='doc/member[@name="HTMLAppFlag.HTMLAppFlag_Max"]/*' />
    HTMLAppFlag_Max = 2147483647,
}
