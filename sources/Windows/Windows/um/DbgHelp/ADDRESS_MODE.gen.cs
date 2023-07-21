// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ADDRESS_MODE.xml' path='doc/member[@name="ADDRESS_MODE"]/*' />
public enum ADDRESS_MODE
{
    /// <include file='ADDRESS_MODE.xml' path='doc/member[@name="ADDRESS_MODE.AddrMode1616"]/*' />
    AddrMode1616,

    /// <include file='ADDRESS_MODE.xml' path='doc/member[@name="ADDRESS_MODE.AddrMode1632"]/*' />
    AddrMode1632,

    /// <include file='ADDRESS_MODE.xml' path='doc/member[@name="ADDRESS_MODE.AddrModeReal"]/*' />
    AddrModeReal,

    /// <include file='ADDRESS_MODE.xml' path='doc/member[@name="ADDRESS_MODE.AddrModeFlat"]/*' />
    AddrModeFlat,
}
