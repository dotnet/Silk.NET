// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME"]/*'/>
public unsafe partial struct DISPLAYCONFIG_TARGET_DEVICE_NAME
{
    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.header"]/*'/>
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.flags"]/*'/>
    public DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS flags;
    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.outputTechnology"]/*'/>
    public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;
    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.edidManufactureId"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort edidManufactureId;
    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.edidProductCodeId"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort edidProductCodeId;
    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.connectorInstance"]/*'/>
    [NativeTypeName("UINT32")]
    public uint connectorInstance;
    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.monitorFriendlyDeviceName"]/*'/>
    [NativeTypeName("WCHAR[64]")]
    public fixed ushort monitorFriendlyDeviceName[64];
    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME.monitorDevicePath"]/*'/>
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort monitorDevicePath[128];
}