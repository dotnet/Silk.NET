// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='POINTER_DEVICE_INFO.xml' path='doc/member[@name="POINTER_DEVICE_INFO"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct POINTER_DEVICE_INFO
{
    /// <include file='POINTER_DEVICE_INFO.xml' path='doc/member[@name="POINTER_DEVICE_INFO.displayOrientation"]/*'/>
    [NativeTypeName("DWORD")]
    public uint displayOrientation;
    /// <include file='POINTER_DEVICE_INFO.xml' path='doc/member[@name="POINTER_DEVICE_INFO.device"]/*'/>
    public HANDLE device;
    /// <include file='POINTER_DEVICE_INFO.xml' path='doc/member[@name="POINTER_DEVICE_INFO.pointerDeviceType"]/*'/>
    public POINTER_DEVICE_TYPE pointerDeviceType;
    /// <include file='POINTER_DEVICE_INFO.xml' path='doc/member[@name="POINTER_DEVICE_INFO.monitor"]/*'/>
    public HMONITOR monitor;
    /// <include file='POINTER_DEVICE_INFO.xml' path='doc/member[@name="POINTER_DEVICE_INFO.startingCursorId"]/*'/>
    [NativeTypeName("ULONG")]
    public uint startingCursorId;
    /// <include file='POINTER_DEVICE_INFO.xml' path='doc/member[@name="POINTER_DEVICE_INFO.maxActiveContacts"]/*'/>
    public ushort maxActiveContacts;
    /// <include file='POINTER_DEVICE_INFO.xml' path='doc/member[@name="POINTER_DEVICE_INFO.productString"]/*'/>
    [NativeTypeName("WCHAR[520]")]
    public fixed ushort productString[520];
}