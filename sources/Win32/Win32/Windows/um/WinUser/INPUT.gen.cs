// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct INPUT
{
    [NativeTypeName("DWORD")]
    public uint type;

    [NativeTypeName("__AnonymousRecord_winuser_L6145_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref MOUSEINPUT mi
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.mi; }
    }

    [UnscopedRef]
    public ref KEYBDINPUT ki
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ki; }
    }

    [UnscopedRef]
    public ref HARDWAREINPUT hi
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.hi; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public MOUSEINPUT mi;

        [FieldOffset(0)]
        public KEYBDINPUT ki;

        [FieldOffset(0)]
        public HARDWAREINPUT hi;
    }

    [NativeTypeName("#define INPUT_MOUSE 0")]
    public const int INPUT_MOUSE = 0;

    [NativeTypeName("#define INPUT_KEYBOARD 1")]
    public const int INPUT_KEYBOARD = 1;

    [NativeTypeName("#define INPUT_HARDWARE 2")]
    public const int INPUT_HARDWARE = 2;
}
