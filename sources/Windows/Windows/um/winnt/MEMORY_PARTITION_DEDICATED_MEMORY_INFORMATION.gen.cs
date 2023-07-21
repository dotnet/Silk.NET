// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.xml' path='doc/member[@name="MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION"]/*' />
public partial struct MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION
{
    /// <include file='MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.xml' path='doc/member[@name="MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.NextEntryOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint NextEntryOffset;

    /// <include file='MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.xml' path='doc/member[@name="MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.SizeOfInformation"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfInformation;

    /// <include file='MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.xml' path='doc/member[@name="MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.xml' path='doc/member[@name="MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.AttributesOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint AttributesOffset;

    /// <include file='MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.xml' path='doc/member[@name="MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.AttributeCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint AttributeCount;

    /// <include file='MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.xml' path='doc/member[@name="MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.xml' path='doc/member[@name="MEMORY_PARTITION_DEDICATED_MEMORY_INFORMATION.TypeId"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong TypeId;
}
