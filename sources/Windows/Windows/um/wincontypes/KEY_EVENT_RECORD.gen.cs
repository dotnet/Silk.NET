// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='KEY_EVENT_RECORD.xml' path='doc/member[@name="KEY_EVENT_RECORD"]/*'/>
public partial struct KEY_EVENT_RECORD
{
    /// <include file='KEY_EVENT_RECORD.xml' path='doc/member[@name="KEY_EVENT_RECORD.bKeyDown"]/*'/>
    public BOOL bKeyDown;
    /// <include file='KEY_EVENT_RECORD.xml' path='doc/member[@name="KEY_EVENT_RECORD.wRepeatCount"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wRepeatCount;
    /// <include file='KEY_EVENT_RECORD.xml' path='doc/member[@name="KEY_EVENT_RECORD.wVirtualKeyCode"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wVirtualKeyCode;
    /// <include file='KEY_EVENT_RECORD.xml' path='doc/member[@name="KEY_EVENT_RECORD.wVirtualScanCode"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wVirtualScanCode;
    /// <include file='KEY_EVENT_RECORD.xml' path='doc/member[@name="KEY_EVENT_RECORD.uChar"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincontypes_L53_C5")]
    public _uChar_e__Union uChar;
    /// <include file='KEY_EVENT_RECORD.xml' path='doc/member[@name="KEY_EVENT_RECORD.dwControlKeyState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwControlKeyState;
    /// <include file='_uChar_e__Union.xml' path='doc/member[@name="_uChar_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _uChar_e__Union
    {
        /// <include file='_uChar_e__Union.xml' path='doc/member[@name="_uChar_e__Union.UnicodeChar"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("WCHAR")]
        public ushort UnicodeChar;
        /// <include file='_uChar_e__Union.xml' path='doc/member[@name="_uChar_e__Union.AsciiChar"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("CHAR")]
        public sbyte AsciiChar;
    }
}