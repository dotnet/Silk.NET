// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFT_ENUM_DATA_V0.xml' path='doc/member[@name="MFT_ENUM_DATA_V0"]/*'/>
public partial struct MFT_ENUM_DATA_V0
{
    /// <include file='MFT_ENUM_DATA_V0.xml' path='doc/member[@name="MFT_ENUM_DATA_V0.StartFileReferenceNumber"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong StartFileReferenceNumber;
    /// <include file='MFT_ENUM_DATA_V0.xml' path='doc/member[@name="MFT_ENUM_DATA_V0.LowUsn"]/*'/>
    [NativeTypeName("USN")]
    public long LowUsn;
    /// <include file='MFT_ENUM_DATA_V0.xml' path='doc/member[@name="MFT_ENUM_DATA_V0.HighUsn"]/*'/>
    [NativeTypeName("USN")]
    public long HighUsn;
}