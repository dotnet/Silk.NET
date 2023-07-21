// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='USEROBJECTFLAGS.xml' path='doc/member[@name="USEROBJECTFLAGS"]/*' />
public partial struct USEROBJECTFLAGS
{
    /// <include file='USEROBJECTFLAGS.xml' path='doc/member[@name="USEROBJECTFLAGS.fInherit"]/*' />
    public BOOL fInherit;

    /// <include file='USEROBJECTFLAGS.xml' path='doc/member[@name="USEROBJECTFLAGS.fReserved"]/*' />
    public BOOL fReserved;

    /// <include file='USEROBJECTFLAGS.xml' path='doc/member[@name="USEROBJECTFLAGS.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}
