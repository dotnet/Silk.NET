// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT"]/*'/>
public unsafe partial struct SCRUB_DATA_OUTPUT
{
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.Status"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Status;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.ErrorFileOffset"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ErrorFileOffset;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.ErrorLength"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ErrorLength;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.NumberOfBytesRepaired"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong NumberOfBytesRepaired;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.NumberOfBytesFailed"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong NumberOfBytesFailed;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.InternalFileReference"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong InternalFileReference;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.ResumeContextLength"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ResumeContextLength;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.ParityExtentDataOffset"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ParityExtentDataOffset;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.Reserved"]/*'/>
    [NativeTypeName("DWORD[9]")]
    public fixed uint Reserved[9];
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.NumberOfMetadataBytesProcessed"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong NumberOfMetadataBytesProcessed;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.NumberOfDataBytesProcessed"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong NumberOfDataBytesProcessed;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.TotalNumberOfMetadataBytesInUse"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong TotalNumberOfMetadataBytesInUse;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.TotalNumberOfDataBytesInUse"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong TotalNumberOfDataBytesInUse;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.DataBytesSkippedDueToNoAllocation"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesSkippedDueToNoAllocation;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.DataBytesSkippedDueToInvalidRun"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesSkippedDueToInvalidRun;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.DataBytesSkippedDueToIntegrityStream"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesSkippedDueToIntegrityStream;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.DataBytesSkippedDueToRegionBeingClean"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesSkippedDueToRegionBeingClean;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.DataBytesSkippedDueToLockConflict"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesSkippedDueToLockConflict;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.DataBytesSkippedDueToNoScrubDataFlag"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesSkippedDueToNoScrubDataFlag;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.DataBytesSkippedDueToNoScrubNonIntegrityStreamFlag"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesSkippedDueToNoScrubNonIntegrityStreamFlag;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.DataBytesScrubbed"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong DataBytesScrubbed;
    /// <include file='SCRUB_DATA_OUTPUT.xml' path='doc/member[@name="SCRUB_DATA_OUTPUT.ResumeContext"]/*'/>
    [NativeTypeName("BYTE[1040]")]
    public fixed byte ResumeContext[1040];
}