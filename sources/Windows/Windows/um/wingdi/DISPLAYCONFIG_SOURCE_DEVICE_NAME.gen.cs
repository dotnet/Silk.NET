// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPLAYCONFIG_SOURCE_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_SOURCE_DEVICE_NAME"]/*'/>
public unsafe partial struct DISPLAYCONFIG_SOURCE_DEVICE_NAME
{
    /// <include file='DISPLAYCONFIG_SOURCE_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_SOURCE_DEVICE_NAME.header"]/*'/>
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
    /// <include file='DISPLAYCONFIG_SOURCE_DEVICE_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_SOURCE_DEVICE_NAME.viewGdiDeviceName"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort viewGdiDeviceName[32];
}