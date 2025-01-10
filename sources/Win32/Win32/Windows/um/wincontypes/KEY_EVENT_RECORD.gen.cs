// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct KEY_EVENT_RECORD
{
    public BOOL bKeyDown;

    [NativeTypeName("WORD")]
    public ushort wRepeatCount;

    [NativeTypeName("WORD")]
    public ushort wVirtualKeyCode;

    [NativeTypeName("WORD")]
    public ushort wVirtualScanCode;

    [NativeTypeName("__AnonymousRecord_wincontypes_L53_C5")]
    public _uChar_e__Union uChar;

    [NativeTypeName("DWORD")]
    public uint dwControlKeyState;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _uChar_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("WCHAR")]
        public ushort UnicodeChar;

        [FieldOffset(0)]
        [NativeTypeName("CHAR")]
        public sbyte AsciiChar;
    }
}
