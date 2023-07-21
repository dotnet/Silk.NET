// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SFVM_HELPTOPIC_DATA.xml' path='doc/member[@name="SFVM_HELPTOPIC_DATA"]/*' />
public unsafe partial struct SFVM_HELPTOPIC_DATA
{
    /// <include file='SFVM_HELPTOPIC_DATA.xml' path='doc/member[@name="SFVM_HELPTOPIC_DATA.wszHelpFile"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort wszHelpFile[260];

    /// <include file='SFVM_HELPTOPIC_DATA.xml' path='doc/member[@name="SFVM_HELPTOPIC_DATA.wszHelpTopic"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort wszHelpTopic[260];
}
