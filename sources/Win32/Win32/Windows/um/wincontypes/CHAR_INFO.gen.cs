// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CHAR_INFO
{
    [NativeTypeName("__AnonymousRecord_wincontypes_L144_C5")]
    public _Char_e__Union Char;

    [NativeTypeName("WORD")]
    public ushort Attributes;

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Char_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("WCHAR")]
        public ushort UnicodeChar;

        [FieldOffset(0)]
        [NativeTypeName("CHAR")]
        public sbyte AsciiChar;
    }
}
