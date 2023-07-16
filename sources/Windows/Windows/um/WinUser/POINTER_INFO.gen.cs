// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct POINTER_INFO
{
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.pointerType"]/*'/>
    [NativeTypeName("POINTER_INPUT_TYPE")]
    public uint pointerType;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.pointerId"]/*'/>
    [NativeTypeName("UINT32")]
    public uint pointerId;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.frameId"]/*'/>
    [NativeTypeName("UINT32")]
    public uint frameId;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.pointerFlags"]/*'/>
    [NativeTypeName("POINTER_FLAGS")]
    public uint pointerFlags;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.sourceDevice"]/*'/>
    public HANDLE sourceDevice;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.hwndTarget"]/*'/>
    public HWND hwndTarget;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.ptPixelLocation"]/*'/>
    public POINT ptPixelLocation;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.ptHimetricLocation"]/*'/>
    public POINT ptHimetricLocation;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.ptPixelLocationRaw"]/*'/>
    public POINT ptPixelLocationRaw;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.ptHimetricLocationRaw"]/*'/>
    public POINT ptHimetricLocationRaw;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.dwTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwTime;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.historyCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint historyCount;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.InputData"]/*'/>
    [NativeTypeName("INT32")]
    public int InputData;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.dwKeyStates"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwKeyStates;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.PerformanceCount"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong PerformanceCount;
    /// <include file='POINTER_INFO.xml' path='doc/member[@name="POINTER_INFO.ButtonChangeType"]/*'/>
    public POINTER_BUTTON_CHANGE_TYPE ButtonChangeType;
}