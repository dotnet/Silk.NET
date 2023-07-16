// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FORMAT_EX_PARAMETERS.xml' path='doc/member[@name="FORMAT_EX_PARAMETERS"]/*'/>
public unsafe partial struct FORMAT_EX_PARAMETERS
{
    /// <include file='FORMAT_EX_PARAMETERS.xml' path='doc/member[@name="FORMAT_EX_PARAMETERS.MediaType"]/*'/>
    public MEDIA_TYPE MediaType;
    /// <include file='FORMAT_EX_PARAMETERS.xml' path='doc/member[@name="FORMAT_EX_PARAMETERS.StartCylinderNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StartCylinderNumber;
    /// <include file='FORMAT_EX_PARAMETERS.xml' path='doc/member[@name="FORMAT_EX_PARAMETERS.EndCylinderNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EndCylinderNumber;
    /// <include file='FORMAT_EX_PARAMETERS.xml' path='doc/member[@name="FORMAT_EX_PARAMETERS.StartHeadNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StartHeadNumber;
    /// <include file='FORMAT_EX_PARAMETERS.xml' path='doc/member[@name="FORMAT_EX_PARAMETERS.EndHeadNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EndHeadNumber;
    /// <include file='FORMAT_EX_PARAMETERS.xml' path='doc/member[@name="FORMAT_EX_PARAMETERS.FormatGapLength"]/*'/>
    [NativeTypeName("WORD")]
    public ushort FormatGapLength;
    /// <include file='FORMAT_EX_PARAMETERS.xml' path='doc/member[@name="FORMAT_EX_PARAMETERS.SectorsPerTrack"]/*'/>
    [NativeTypeName("WORD")]
    public ushort SectorsPerTrack;
    /// <include file='FORMAT_EX_PARAMETERS.xml' path='doc/member[@name="FORMAT_EX_PARAMETERS.SectorNumber"]/*'/>
    [NativeTypeName("WORD[1]")]
    public fixed ushort SectorNumber[1];
}