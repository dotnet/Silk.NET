// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EXFAT_STATISTICS.xml' path='doc/member[@name="EXFAT_STATISTICS"]/*'/>
public partial struct EXFAT_STATISTICS
{
    /// <include file='EXFAT_STATISTICS.xml' path='doc/member[@name="EXFAT_STATISTICS.CreateHits"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CreateHits;
    /// <include file='EXFAT_STATISTICS.xml' path='doc/member[@name="EXFAT_STATISTICS.SuccessfulCreates"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SuccessfulCreates;
    /// <include file='EXFAT_STATISTICS.xml' path='doc/member[@name="EXFAT_STATISTICS.FailedCreates"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FailedCreates;
    /// <include file='EXFAT_STATISTICS.xml' path='doc/member[@name="EXFAT_STATISTICS.NonCachedReads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NonCachedReads;
    /// <include file='EXFAT_STATISTICS.xml' path='doc/member[@name="EXFAT_STATISTICS.NonCachedReadBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NonCachedReadBytes;
    /// <include file='EXFAT_STATISTICS.xml' path='doc/member[@name="EXFAT_STATISTICS.NonCachedWrites"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NonCachedWrites;
    /// <include file='EXFAT_STATISTICS.xml' path='doc/member[@name="EXFAT_STATISTICS.NonCachedWriteBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NonCachedWriteBytes;
    /// <include file='EXFAT_STATISTICS.xml' path='doc/member[@name="EXFAT_STATISTICS.NonCachedDiskReads"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NonCachedDiskReads;
    /// <include file='EXFAT_STATISTICS.xml' path='doc/member[@name="EXFAT_STATISTICS.NonCachedDiskWrites"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NonCachedDiskWrites;
}