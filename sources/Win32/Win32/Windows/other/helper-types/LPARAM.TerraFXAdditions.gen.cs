// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct Lparam
{
    public static explicit operator Lparam(void* value) => new Lparam((nint)(value));

    public static implicit operator void*(Lparam value) => (void*)(value.Value);

    public static explicit operator Lparam(MaybeBoolInt value) => new Lparam(value.Value);

    public static explicit operator MaybeBoolInt(Lparam value) =>
        new MaybeBoolInt((int)(value.Value));

    public static explicit operator Lparam(Handle value) => new Lparam((nint)(value.Value));

    public static explicit operator Handle(Lparam value) => new Handle((void*)(value.Value));

    public static explicit operator Lparam(Hbrush value) => new Lparam((nint)(value.Value));

    public static explicit operator Hbrush(Lparam value) => new Hbrush((void*)(value.Value));

    public static explicit operator Lparam(Hcursor value) => new Lparam((nint)(value.Value));

    public static explicit operator Hcursor(Lparam value) => new Hcursor((void*)(value.Value));

    public static explicit operator Lparam(HDC value) => new Lparam((nint)(value.Value));

    public static explicit operator HDC(Lparam value) => new HDC((void*)(value.Value));

    public static explicit operator Lparam(Hdrop value) => new Lparam((nint)(value.Value));

    public static explicit operator Hdrop(Lparam value) => new Hdrop((void*)(value.Value));

    public static explicit operator Lparam(Hfont value) => new Lparam((nint)(value.Value));

    public static explicit operator Hfont(Lparam value) => new Hfont((void*)(value.Value));

    public static explicit operator Lparam(Hgdiobj value) => new Lparam((nint)(value.Value));

    public static explicit operator Hgdiobj(Lparam value) => new Hgdiobj((void*)(value.Value));

    public static explicit operator Lparam(Hglobal value) => new Lparam((nint)(value.Value));

    public static explicit operator Hglobal(Lparam value) => new Hglobal((void*)(value.Value));

    public static explicit operator Lparam(Hicon value) => new Lparam((nint)(value.Value));

    public static explicit operator Hicon(Lparam value) => new Hicon((void*)(value.Value));

    public static explicit operator Lparam(Hinstance value) => new Lparam((nint)(value.Value));

    public static explicit operator Hinstance(Lparam value) => new Hinstance((void*)(value.Value));

    public static explicit operator Lparam(Hlocal value) => new Lparam((nint)(value.Value));

    public static explicit operator Hlocal(Lparam value) => new Hlocal((void*)(value.Value));

    public static explicit operator Lparam(Hmenu value) => new Lparam((nint)(value.Value));

    public static explicit operator Hmenu(Lparam value) => new Hmenu((void*)(value.Value));

    public static explicit operator Lparam(HModule value) => new Lparam((nint)(value.Value));

    public static explicit operator HModule(Lparam value) => new HModule((void*)(value.Value));

    public static explicit operator Lparam(Hpalette value) => new Lparam((nint)(value.Value));

    public static explicit operator Hpalette(Lparam value) => new Hpalette((void*)(value.Value));

    public static explicit operator Lparam(HPEN value) => new Lparam((nint)(value.Value));

    public static explicit operator HPEN(Lparam value) => new HPEN((void*)(value.Value));

    public static explicit operator Lparam(HRGN value) => new Lparam((nint)(value.Value));

    public static explicit operator HRGN(Lparam value) => new HRGN((void*)(value.Value));

    public static explicit operator Lparam(HWND value) => new Lparam((nint)(value.Value));

    public static explicit operator HWND(Lparam value) => new HWND((void*)(value.Value));

    public static explicit operator Lparam(Lresult value) => new Lparam(value.Value);

    public static explicit operator Lparam(Wparam value) => new Lparam((nint)(value.Value));
}
