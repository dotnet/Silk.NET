// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TAPE_GET_DRIVE_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_DRIVE_PARAMETERS"]/*'/>
public partial struct TAPE_GET_DRIVE_PARAMETERS
{
    /// <include file='TAPE_GET_DRIVE_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_DRIVE_PARAMETERS.ECC"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ECC;
    /// <include file='TAPE_GET_DRIVE_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_DRIVE_PARAMETERS.Compression"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Compression;
    /// <include file='TAPE_GET_DRIVE_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_DRIVE_PARAMETERS.DataPadding"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte DataPadding;
    /// <include file='TAPE_GET_DRIVE_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_DRIVE_PARAMETERS.ReportSetmarks"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ReportSetmarks;
    /// <include file='TAPE_GET_DRIVE_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_DRIVE_PARAMETERS.DefaultBlockSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DefaultBlockSize;
    /// <include file='TAPE_GET_DRIVE_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_DRIVE_PARAMETERS.MaximumBlockSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaximumBlockSize;
    /// <include file='TAPE_GET_DRIVE_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_DRIVE_PARAMETERS.MinimumBlockSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MinimumBlockSize;
    /// <include file='TAPE_GET_DRIVE_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_DRIVE_PARAMETERS.MaximumPartitionCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaximumPartitionCount;
    /// <include file='TAPE_GET_DRIVE_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_DRIVE_PARAMETERS.FeaturesLow"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FeaturesLow;
    /// <include file='TAPE_GET_DRIVE_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_DRIVE_PARAMETERS.FeaturesHigh"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FeaturesHigh;
    /// <include file='TAPE_GET_DRIVE_PARAMETERS.xml' path='doc/member[@name="TAPE_GET_DRIVE_PARAMETERS.EOTWarningZoneSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EOTWarningZoneSize;
}