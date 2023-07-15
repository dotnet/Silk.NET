// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='RID_DEVICE_INFO_KEYBOARD.xml' path='doc/member[@name="RID_DEVICE_INFO_KEYBOARD"]/*'/>
public partial struct RID_DEVICE_INFO_KEYBOARD
{
    /// <include file='RID_DEVICE_INFO_KEYBOARD.xml' path='doc/member[@name="RID_DEVICE_INFO_KEYBOARD.dwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwType;
    /// <include file='RID_DEVICE_INFO_KEYBOARD.xml' path='doc/member[@name="RID_DEVICE_INFO_KEYBOARD.dwSubType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSubType;
    /// <include file='RID_DEVICE_INFO_KEYBOARD.xml' path='doc/member[@name="RID_DEVICE_INFO_KEYBOARD.dwKeyboardMode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwKeyboardMode;
    /// <include file='RID_DEVICE_INFO_KEYBOARD.xml' path='doc/member[@name="RID_DEVICE_INFO_KEYBOARD.dwNumberOfFunctionKeys"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumberOfFunctionKeys;
    /// <include file='RID_DEVICE_INFO_KEYBOARD.xml' path='doc/member[@name="RID_DEVICE_INFO_KEYBOARD.dwNumberOfIndicators"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumberOfIndicators;
    /// <include file='RID_DEVICE_INFO_KEYBOARD.xml' path='doc/member[@name="RID_DEVICE_INFO_KEYBOARD.dwNumberOfKeysTotal"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwNumberOfKeysTotal;
}