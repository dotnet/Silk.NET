// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='POINTER_PEN_INFO.xml' path='doc/member[@name="POINTER_PEN_INFO"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct POINTER_PEN_INFO
{
    /// <include file='POINTER_PEN_INFO.xml' path='doc/member[@name="POINTER_PEN_INFO.pointerInfo"]/*'/>
    public POINTER_INFO pointerInfo;
    /// <include file='POINTER_PEN_INFO.xml' path='doc/member[@name="POINTER_PEN_INFO.penFlags"]/*'/>
    [NativeTypeName("PEN_FLAGS")]
    public uint penFlags;
    /// <include file='POINTER_PEN_INFO.xml' path='doc/member[@name="POINTER_PEN_INFO.penMask"]/*'/>
    [NativeTypeName("PEN_MASK")]
    public uint penMask;
    /// <include file='POINTER_PEN_INFO.xml' path='doc/member[@name="POINTER_PEN_INFO.pressure"]/*'/>
    [NativeTypeName("UINT32")]
    public uint pressure;
    /// <include file='POINTER_PEN_INFO.xml' path='doc/member[@name="POINTER_PEN_INFO.rotation"]/*'/>
    [NativeTypeName("UINT32")]
    public uint rotation;
    /// <include file='POINTER_PEN_INFO.xml' path='doc/member[@name="POINTER_PEN_INFO.tiltX"]/*'/>
    [NativeTypeName("INT32")]
    public int tiltX;
    /// <include file='POINTER_PEN_INFO.xml' path='doc/member[@name="POINTER_PEN_INFO.tiltY"]/*'/>
    [NativeTypeName("INT32")]
    public int tiltY;
}