// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='POINTER_DEVICE_CURSOR_INFO.xml' path='doc/member[@name="POINTER_DEVICE_CURSOR_INFO"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct POINTER_DEVICE_CURSOR_INFO
{
    /// <include file='POINTER_DEVICE_CURSOR_INFO.xml' path='doc/member[@name="POINTER_DEVICE_CURSOR_INFO.cursorId"]/*'/>
    [NativeTypeName("UINT32")]
    public uint cursorId;
    /// <include file='POINTER_DEVICE_CURSOR_INFO.xml' path='doc/member[@name="POINTER_DEVICE_CURSOR_INFO.cursor"]/*'/>
    public POINTER_DEVICE_CURSOR_TYPE cursor;
}