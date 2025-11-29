// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public unsafe partial struct Wparam
{
    public static explicit operator Wparam(void* value) => new Wparam((nuint)(value));

    public static implicit operator void*(Wparam value) => (void*)(value.Value);

    public static explicit operator Wparam(MaybeBoolInt value) => new Wparam((nuint)(value.Value));

    public static explicit operator MaybeBoolInt(Wparam value) =>
        new MaybeBoolInt((int)(value.Value));

    public static explicit operator Wparam(Handle value) => new Wparam((nuint)(value.Value));

    public static explicit operator Handle(Wparam value) => new Handle((void*)(value.Value));

    public static explicit operator Wparam(Hbrush value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hbrush(Wparam value) => new Hbrush((void*)(value.Value));

    public static explicit operator Wparam(Hcursor value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hcursor(Wparam value) => new Hcursor((void*)(value.Value));

    public static explicit operator Wparam(HDC value) => new Wparam((nuint)(value.Value));

    public static explicit operator HDC(Wparam value) => new HDC((void*)(value.Value));

    public static explicit operator Wparam(Hdrop value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hdrop(Wparam value) => new Hdrop((void*)(value.Value));

    public static explicit operator Wparam(Hfont value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hfont(Wparam value) => new Hfont((void*)(value.Value));

    public static explicit operator Wparam(Hgdiobj value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hgdiobj(Wparam value) => new Hgdiobj((void*)(value.Value));

    public static explicit operator Wparam(Hglobal value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hglobal(Wparam value) => new Hglobal((void*)(value.Value));

    public static explicit operator Wparam(Hicon value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hicon(Wparam value) => new Hicon((void*)(value.Value));

    public static explicit operator Wparam(Hinstance value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hinstance(Wparam value) => new Hinstance((void*)(value.Value));

    public static explicit operator Wparam(Hlocal value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hlocal(Wparam value) => new Hlocal((void*)(value.Value));

    public static explicit operator Wparam(Hmenu value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hmenu(Wparam value) => new Hmenu((void*)(value.Value));

    public static explicit operator Wparam(HModule value) => new Wparam((nuint)(value.Value));

    public static explicit operator HModule(Wparam value) => new HModule((void*)(value.Value));

    public static explicit operator Wparam(Hpalette value) => new Wparam((nuint)(value.Value));

    public static explicit operator Hpalette(Wparam value) => new Hpalette((void*)(value.Value));

    public static explicit operator Wparam(HPEN value) => new Wparam((nuint)(value.Value));

    public static explicit operator HPEN(Wparam value) => new HPEN((void*)(value.Value));

    public static explicit operator Wparam(HRGN value) => new Wparam((nuint)(value.Value));

    public static explicit operator HRGN(Wparam value) => new HRGN((void*)(value.Value));

    public static explicit operator Wparam(HWND value) => new Wparam((nuint)(value.Value));

    public static explicit operator HWND(Wparam value) => new HWND((void*)(value.Value));

    public static explicit operator Wparam(Lparam value) => new Wparam((nuint)(value.Value));

    public static explicit operator Wparam(Lresult value) => new Wparam((nuint)(value.Value));
}
