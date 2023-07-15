// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct POINTER_TOUCH_INFO
{
    /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO.pointerInfo"]/*'/>
    public POINTER_INFO pointerInfo;
    /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO.touchFlags"]/*'/>
    [NativeTypeName("TOUCH_FLAGS")]
    public uint touchFlags;
    /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO.touchMask"]/*'/>
    [NativeTypeName("TOUCH_MASK")]
    public uint touchMask;
    /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO.rcContact"]/*'/>
    public RECT rcContact;
    /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO.rcContactRaw"]/*'/>
    public RECT rcContactRaw;
    /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO.orientation"]/*'/>
    [NativeTypeName("UINT32")]
    public uint orientation;
    /// <include file='POINTER_TOUCH_INFO.xml' path='doc/member[@name="POINTER_TOUCH_INFO.pressure"]/*'/>
    [NativeTypeName("UINT32")]
    public uint pressure;
}