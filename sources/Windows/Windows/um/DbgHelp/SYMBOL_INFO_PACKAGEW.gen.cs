// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYMBOL_INFO_PACKAGEW.xml' path='doc/member[@name="SYMBOL_INFO_PACKAGEW"]/*' />
public unsafe partial struct SYMBOL_INFO_PACKAGEW
{
    /// <include file='SYMBOL_INFO_PACKAGEW.xml' path='doc/member[@name="SYMBOL_INFO_PACKAGEW.si"]/*' />
    public SYMBOL_INFOW si;

    /// <include file='SYMBOL_INFO_PACKAGEW.xml' path='doc/member[@name="SYMBOL_INFO_PACKAGEW.name"]/*' />
    [NativeTypeName("WCHAR[2001]")]
    public fixed ushort name[2001];
}
