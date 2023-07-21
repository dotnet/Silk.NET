// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='REGISTERWORDW.xml' path='doc/member[@name="REGISTERWORDW"]/*' />
public unsafe partial struct REGISTERWORDW
{
    /// <include file='REGISTERWORDW.xml' path='doc/member[@name="REGISTERWORDW.lpReading"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpReading;

    /// <include file='REGISTERWORDW.xml' path='doc/member[@name="REGISTERWORDW.lpWord"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpWord;
}
