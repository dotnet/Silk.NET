// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='POINTER_DEVICE_TYPE.xml' path='doc/member[@name="POINTER_DEVICE_TYPE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum POINTER_DEVICE_TYPE
{
    /// <include file='POINTER_DEVICE_TYPE.xml' path='doc/member[@name="POINTER_DEVICE_TYPE.POINTER_DEVICE_TYPE_INTEGRATED_PEN"]/*'/>
    POINTER_DEVICE_TYPE_INTEGRATED_PEN = 0x00000001,
    /// <include file='POINTER_DEVICE_TYPE.xml' path='doc/member[@name="POINTER_DEVICE_TYPE.POINTER_DEVICE_TYPE_EXTERNAL_PEN"]/*'/>
    POINTER_DEVICE_TYPE_EXTERNAL_PEN = 0x00000002,
    /// <include file='POINTER_DEVICE_TYPE.xml' path='doc/member[@name="POINTER_DEVICE_TYPE.POINTER_DEVICE_TYPE_TOUCH"]/*'/>
    POINTER_DEVICE_TYPE_TOUCH = 0x00000003,
    /// <include file='POINTER_DEVICE_TYPE.xml' path='doc/member[@name="POINTER_DEVICE_TYPE.POINTER_DEVICE_TYPE_TOUCH_PAD"]/*'/>
    POINTER_DEVICE_TYPE_TOUCH_PAD = 0x00000004,
    /// <include file='POINTER_DEVICE_TYPE.xml' path='doc/member[@name="POINTER_DEVICE_TYPE.POINTER_DEVICE_TYPE_MAX"]/*'/>
    POINTER_DEVICE_TYPE_MAX = unchecked((int)(0xFFFFFFFF)),
}