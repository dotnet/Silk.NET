// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='VALENTW.xml' path='doc/member[@name="VALENTW"]/*' />
public unsafe partial struct VALENTW
{
    /// <include file='VALENTW.xml' path='doc/member[@name="VALENTW.ve_valuename"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* ve_valuename;

    /// <include file='VALENTW.xml' path='doc/member[@name="VALENTW.ve_valuelen"]/*' />
    [NativeTypeName("DWORD")]
    public uint ve_valuelen;

    /// <include file='VALENTW.xml' path='doc/member[@name="VALENTW.ve_valueptr"]/*' />
    [NativeTypeName("DWORD_PTR")]
    public nuint ve_valueptr;

    /// <include file='VALENTW.xml' path='doc/member[@name="VALENTW.ve_type"]/*' />
    [NativeTypeName("DWORD")]
    public uint ve_type;
}
