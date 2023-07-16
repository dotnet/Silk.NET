// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CSV_NAMESPACE_INFO.xml' path='doc/member[@name="CSV_NAMESPACE_INFO"]/*'/>
public partial struct CSV_NAMESPACE_INFO
{
    /// <include file='CSV_NAMESPACE_INFO.xml' path='doc/member[@name="CSV_NAMESPACE_INFO.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='CSV_NAMESPACE_INFO.xml' path='doc/member[@name="CSV_NAMESPACE_INFO.DeviceNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DeviceNumber;
    /// <include file='CSV_NAMESPACE_INFO.xml' path='doc/member[@name="CSV_NAMESPACE_INFO.StartingOffset"]/*'/>
    public LARGE_INTEGER StartingOffset;
    /// <include file='CSV_NAMESPACE_INFO.xml' path='doc/member[@name="CSV_NAMESPACE_INFO.SectorSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SectorSize;
}