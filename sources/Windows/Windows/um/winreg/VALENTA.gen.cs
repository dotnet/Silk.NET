// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='VALENTA.xml' path='doc/member[@name="VALENTA"]/*' />
public unsafe partial struct VALENTA
{
    /// <include file='VALENTA.xml' path='doc/member[@name="VALENTA.ve_valuename"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* ve_valuename;

    /// <include file='VALENTA.xml' path='doc/member[@name="VALENTA.ve_valuelen"]/*' />
    [NativeTypeName("DWORD")]
    public uint ve_valuelen;

    /// <include file='VALENTA.xml' path='doc/member[@name="VALENTA.ve_valueptr"]/*' />
    [NativeTypeName("DWORD_PTR")]
    public nuint ve_valueptr;

    /// <include file='VALENTA.xml' path='doc/member[@name="VALENTA.ve_type"]/*' />
    [NativeTypeName("DWORD")]
    public uint ve_type;
}
