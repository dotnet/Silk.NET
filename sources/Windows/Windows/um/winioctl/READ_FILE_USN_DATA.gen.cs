// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='READ_FILE_USN_DATA.xml' path='doc/member[@name="READ_FILE_USN_DATA"]/*'/>
public partial struct READ_FILE_USN_DATA
{
    /// <include file='READ_FILE_USN_DATA.xml' path='doc/member[@name="READ_FILE_USN_DATA.MinMajorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MinMajorVersion;
    /// <include file='READ_FILE_USN_DATA.xml' path='doc/member[@name="READ_FILE_USN_DATA.MaxMajorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MaxMajorVersion;
}