// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MOUSE_EVENT_RECORD.xml' path='doc/member[@name="MOUSE_EVENT_RECORD"]/*'/>
public partial struct MOUSE_EVENT_RECORD
{
    /// <include file='MOUSE_EVENT_RECORD.xml' path='doc/member[@name="MOUSE_EVENT_RECORD.dwMousePosition"]/*'/>
    public COORD dwMousePosition;
    /// <include file='MOUSE_EVENT_RECORD.xml' path='doc/member[@name="MOUSE_EVENT_RECORD.dwButtonState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwButtonState;
    /// <include file='MOUSE_EVENT_RECORD.xml' path='doc/member[@name="MOUSE_EVENT_RECORD.dwControlKeyState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwControlKeyState;
    /// <include file='MOUSE_EVENT_RECORD.xml' path='doc/member[@name="MOUSE_EVENT_RECORD.dwEventFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwEventFlags;
}