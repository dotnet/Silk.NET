// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HIBERFILE_BUCKET.xml' path='doc/member[@name="HIBERFILE_BUCKET"]/*'/>
public unsafe partial struct HIBERFILE_BUCKET
{
    /// <include file='HIBERFILE_BUCKET.xml' path='doc/member[@name="HIBERFILE_BUCKET.MaxPhysicalMemory"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong MaxPhysicalMemory;
    /// <include file='HIBERFILE_BUCKET.xml' path='doc/member[@name="HIBERFILE_BUCKET.PhysicalMemoryPercent"]/*'/>
    [NativeTypeName("DWORD[3]")]
    public fixed uint PhysicalMemoryPercent[3];
}