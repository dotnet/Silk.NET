// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.DirectX;

namespace Silk.NET.Windows;
/// <include file='VMRALLOCATIONINFO.xml' path='doc/member[@name="VMRALLOCATIONINFO"]/*'/>
public unsafe partial struct VMRALLOCATIONINFO
{
    /// <include file='VMRALLOCATIONINFO.xml' path='doc/member[@name="VMRALLOCATIONINFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='VMRALLOCATIONINFO.xml' path='doc/member[@name="VMRALLOCATIONINFO.lpHdr"]/*'/>
    [NativeTypeName("LPBITMAPINFOHEADER")]
    public BITMAPINFOHEADER* lpHdr;
    /// <include file='VMRALLOCATIONINFO.xml' path='doc/member[@name="VMRALLOCATIONINFO.lpPixFmt"]/*'/>
    [NativeTypeName("LPDDPIXELFORMAT")]
    public DDPIXELFORMAT* lpPixFmt;
    /// <include file='VMRALLOCATIONINFO.xml' path='doc/member[@name="VMRALLOCATIONINFO.szAspectRatio"]/*'/>
    public SIZE szAspectRatio;
    /// <include file='VMRALLOCATIONINFO.xml' path='doc/member[@name="VMRALLOCATIONINFO.dwMinBuffers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinBuffers;
    /// <include file='VMRALLOCATIONINFO.xml' path='doc/member[@name="VMRALLOCATIONINFO.dwMaxBuffers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxBuffers;
    /// <include file='VMRALLOCATIONINFO.xml' path='doc/member[@name="VMRALLOCATIONINFO.dwInterlaceFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInterlaceFlags;
    /// <include file='VMRALLOCATIONINFO.xml' path='doc/member[@name="VMRALLOCATIONINFO.szNativeSize"]/*'/>
    public SIZE szNativeSize;
}