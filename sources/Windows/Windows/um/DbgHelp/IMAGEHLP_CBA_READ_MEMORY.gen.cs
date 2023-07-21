// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGEHLP_CBA_READ_MEMORY.xml' path='doc/member[@name="IMAGEHLP_CBA_READ_MEMORY"]/*' />
public unsafe partial struct IMAGEHLP_CBA_READ_MEMORY
{
    /// <include file='IMAGEHLP_CBA_READ_MEMORY.xml' path='doc/member[@name="IMAGEHLP_CBA_READ_MEMORY.addr"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong addr;

    /// <include file='IMAGEHLP_CBA_READ_MEMORY.xml' path='doc/member[@name="IMAGEHLP_CBA_READ_MEMORY.buf"]/*' />
    [NativeTypeName("PVOID")]
    public void* buf;

    /// <include file='IMAGEHLP_CBA_READ_MEMORY.xml' path='doc/member[@name="IMAGEHLP_CBA_READ_MEMORY.bytes"]/*' />
    [NativeTypeName("DWORD")]
    public uint bytes;

    /// <include file='IMAGEHLP_CBA_READ_MEMORY.xml' path='doc/member[@name="IMAGEHLP_CBA_READ_MEMORY.bytesread"]/*' />
    [NativeTypeName("DWORD *")]
    public uint* bytesread;
}
