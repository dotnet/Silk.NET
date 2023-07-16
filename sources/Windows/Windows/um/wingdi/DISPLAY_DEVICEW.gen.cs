// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPLAY_DEVICEW.xml' path='doc/member[@name="DISPLAY_DEVICEW"]/*'/>
public unsafe partial struct DISPLAY_DEVICEW
{
    /// <include file='DISPLAY_DEVICEW.xml' path='doc/member[@name="DISPLAY_DEVICEW.cb"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cb;
    /// <include file='DISPLAY_DEVICEW.xml' path='doc/member[@name="DISPLAY_DEVICEW.DeviceName"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort DeviceName[32];
    /// <include file='DISPLAY_DEVICEW.xml' path='doc/member[@name="DISPLAY_DEVICEW.DeviceString"]/*'/>
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort DeviceString[128];
    /// <include file='DISPLAY_DEVICEW.xml' path='doc/member[@name="DISPLAY_DEVICEW.StateFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StateFlags;
    /// <include file='DISPLAY_DEVICEW.xml' path='doc/member[@name="DISPLAY_DEVICEW.DeviceID"]/*'/>
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort DeviceID[128];
    /// <include file='DISPLAY_DEVICEW.xml' path='doc/member[@name="DISPLAY_DEVICEW.DeviceKey"]/*'/>
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort DeviceKey[128];
}