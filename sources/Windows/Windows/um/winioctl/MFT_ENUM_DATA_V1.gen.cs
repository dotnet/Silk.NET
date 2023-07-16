// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFT_ENUM_DATA_V1.xml' path='doc/member[@name="MFT_ENUM_DATA_V1"]/*'/>
public partial struct MFT_ENUM_DATA_V1
{
    /// <include file='MFT_ENUM_DATA_V1.xml' path='doc/member[@name="MFT_ENUM_DATA_V1.StartFileReferenceNumber"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong StartFileReferenceNumber;
    /// <include file='MFT_ENUM_DATA_V1.xml' path='doc/member[@name="MFT_ENUM_DATA_V1.LowUsn"]/*'/>
    [NativeTypeName("USN")]
    public long LowUsn;
    /// <include file='MFT_ENUM_DATA_V1.xml' path='doc/member[@name="MFT_ENUM_DATA_V1.HighUsn"]/*'/>
    [NativeTypeName("USN")]
    public long HighUsn;
    /// <include file='MFT_ENUM_DATA_V1.xml' path='doc/member[@name="MFT_ENUM_DATA_V1.MinMajorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MinMajorVersion;
    /// <include file='MFT_ENUM_DATA_V1.xml' path='doc/member[@name="MFT_ENUM_DATA_V1.MaxMajorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MaxMajorVersion;
}