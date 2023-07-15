// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FAT_STATISTICS.xml' path='doc/member[@name="FAT_STATISTICS"]/*'/>
public partial struct FAT_STATISTICS
{
    /// <include file='FAT_STATISTICS.xml' path='doc/member[@name="FAT_STATISTICS.CreateHits"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CreateHits;
    /// <include file='FAT_STATISTICS.xml' path='doc/member[@name="FAT_STATISTICS.SuccessfulCreates"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SuccessfulCreates;
    /// <include file='FAT_STATISTICS.xml' path='doc/member[@name="FAT_STATISTICS.FailedCreates"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FailedCreates;
    /// <include file='FAT_STATISTICS.xml' path='doc/member[@name="FAT_STATISTICS.NonCachedReads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NonCachedReads;
    /// <include file='FAT_STATISTICS.xml' path='doc/member[@name="FAT_STATISTICS.NonCachedReadBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NonCachedReadBytes;
    /// <include file='FAT_STATISTICS.xml' path='doc/member[@name="FAT_STATISTICS.NonCachedWrites"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NonCachedWrites;
    /// <include file='FAT_STATISTICS.xml' path='doc/member[@name="FAT_STATISTICS.NonCachedWriteBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NonCachedWriteBytes;
    /// <include file='FAT_STATISTICS.xml' path='doc/member[@name="FAT_STATISTICS.NonCachedDiskReads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NonCachedDiskReads;
    /// <include file='FAT_STATISTICS.xml' path='doc/member[@name="FAT_STATISTICS.NonCachedDiskWrites"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NonCachedDiskWrites;
}