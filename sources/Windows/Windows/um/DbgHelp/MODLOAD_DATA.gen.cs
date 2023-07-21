// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MODLOAD_DATA.xml' path='doc/member[@name="MODLOAD_DATA"]/*' />
public unsafe partial struct MODLOAD_DATA
{
    /// <include file='MODLOAD_DATA.xml' path='doc/member[@name="MODLOAD_DATA.ssize"]/*' />
    [NativeTypeName("DWORD")]
    public uint ssize;

    /// <include file='MODLOAD_DATA.xml' path='doc/member[@name="MODLOAD_DATA.ssig"]/*' />
    [NativeTypeName("DWORD")]
    public uint ssig;

    /// <include file='MODLOAD_DATA.xml' path='doc/member[@name="MODLOAD_DATA.data"]/*' />
    [NativeTypeName("PVOID")]
    public void* data;

    /// <include file='MODLOAD_DATA.xml' path='doc/member[@name="MODLOAD_DATA.size"]/*' />
    [NativeTypeName("DWORD")]
    public uint size;

    /// <include file='MODLOAD_DATA.xml' path='doc/member[@name="MODLOAD_DATA.flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint flags;
}
