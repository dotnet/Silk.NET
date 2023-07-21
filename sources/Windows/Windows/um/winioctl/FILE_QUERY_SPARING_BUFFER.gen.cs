// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FILE_QUERY_SPARING_BUFFER.xml' path='doc/member[@name="FILE_QUERY_SPARING_BUFFER"]/*' />
public partial struct FILE_QUERY_SPARING_BUFFER
{
    /// <include file='FILE_QUERY_SPARING_BUFFER.xml' path='doc/member[@name="FILE_QUERY_SPARING_BUFFER.SparingUnitBytes"]/*' />
    [NativeTypeName("DWORD")]
    public uint SparingUnitBytes;

    /// <include file='FILE_QUERY_SPARING_BUFFER.xml' path='doc/member[@name="FILE_QUERY_SPARING_BUFFER.SoftwareSparing"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte SoftwareSparing;

    /// <include file='FILE_QUERY_SPARING_BUFFER.xml' path='doc/member[@name="FILE_QUERY_SPARING_BUFFER.TotalSpareBlocks"]/*' />
    [NativeTypeName("DWORD")]
    public uint TotalSpareBlocks;

    /// <include file='FILE_QUERY_SPARING_BUFFER.xml' path='doc/member[@name="FILE_QUERY_SPARING_BUFFER.FreeSpareBlocks"]/*' />
    [NativeTypeName("DWORD")]
    public uint FreeSpareBlocks;
}
