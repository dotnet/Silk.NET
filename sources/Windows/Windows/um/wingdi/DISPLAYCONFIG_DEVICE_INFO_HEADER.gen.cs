// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPLAYCONFIG_DEVICE_INFO_HEADER.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_HEADER"]/*'/>
public partial struct DISPLAYCONFIG_DEVICE_INFO_HEADER
{
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_HEADER.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_HEADER.type"]/*'/>
    public DISPLAYCONFIG_DEVICE_INFO_TYPE type;
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_HEADER.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_HEADER.size"]/*'/>
    [NativeTypeName("UINT32")]
    public uint size;
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_HEADER.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_HEADER.adapterId"]/*'/>
    public LUID adapterId;
    /// <include file='DISPLAYCONFIG_DEVICE_INFO_HEADER.xml' path='doc/member[@name="DISPLAYCONFIG_DEVICE_INFO_HEADER.id"]/*'/>
    [NativeTypeName("UINT32")]
    public uint id;
}