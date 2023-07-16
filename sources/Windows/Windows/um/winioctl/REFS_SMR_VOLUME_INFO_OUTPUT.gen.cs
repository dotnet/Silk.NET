// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='REFS_SMR_VOLUME_INFO_OUTPUT.xml' path='doc/member[@name="REFS_SMR_VOLUME_INFO_OUTPUT"]/*'/>
public unsafe partial struct REFS_SMR_VOLUME_INFO_OUTPUT
{
    /// <include file='REFS_SMR_VOLUME_INFO_OUTPUT.xml' path='doc/member[@name="REFS_SMR_VOLUME_INFO_OUTPUT.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='REFS_SMR_VOLUME_INFO_OUTPUT.xml' path='doc/member[@name="REFS_SMR_VOLUME_INFO_OUTPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='REFS_SMR_VOLUME_INFO_OUTPUT.xml' path='doc/member[@name="REFS_SMR_VOLUME_INFO_OUTPUT.SizeOfRandomlyWritableTier"]/*'/>
    public LARGE_INTEGER SizeOfRandomlyWritableTier;
    /// <include file='REFS_SMR_VOLUME_INFO_OUTPUT.xml' path='doc/member[@name="REFS_SMR_VOLUME_INFO_OUTPUT.FreeSpaceInRandomlyWritableTier"]/*'/>
    public LARGE_INTEGER FreeSpaceInRandomlyWritableTier;
    /// <include file='REFS_SMR_VOLUME_INFO_OUTPUT.xml' path='doc/member[@name="REFS_SMR_VOLUME_INFO_OUTPUT.SizeofSMRTier"]/*'/>
    public LARGE_INTEGER SizeofSMRTier;
    /// <include file='REFS_SMR_VOLUME_INFO_OUTPUT.xml' path='doc/member[@name="REFS_SMR_VOLUME_INFO_OUTPUT.FreeSpaceInSMRTier"]/*'/>
    public LARGE_INTEGER FreeSpaceInSMRTier;
    /// <include file='REFS_SMR_VOLUME_INFO_OUTPUT.xml' path='doc/member[@name="REFS_SMR_VOLUME_INFO_OUTPUT.UsableFreeSpaceInSMRTier"]/*'/>
    public LARGE_INTEGER UsableFreeSpaceInSMRTier;
    /// <include file='REFS_SMR_VOLUME_INFO_OUTPUT.xml' path='doc/member[@name="REFS_SMR_VOLUME_INFO_OUTPUT.VolumeGcState"]/*'/>
    public REFS_SMR_VOLUME_GC_STATE VolumeGcState;
    /// <include file='REFS_SMR_VOLUME_INFO_OUTPUT.xml' path='doc/member[@name="REFS_SMR_VOLUME_INFO_OUTPUT.VolumeGcLastStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint VolumeGcLastStatus;
    /// <include file='REFS_SMR_VOLUME_INFO_OUTPUT.xml' path='doc/member[@name="REFS_SMR_VOLUME_INFO_OUTPUT.CurrentGcBandFillPercentage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CurrentGcBandFillPercentage;
    /// <include file='REFS_SMR_VOLUME_INFO_OUTPUT.xml' path='doc/member[@name="REFS_SMR_VOLUME_INFO_OUTPUT.Unused"]/*'/>
    [NativeTypeName("DWORDLONG[6]")]
    public fixed ulong Unused[6];
}