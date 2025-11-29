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

public unsafe partial struct Lresult
{
    public static explicit operator Lresult(void* value) => new Lresult((nint)(value));

    public static implicit operator void*(Lresult value) => (void*)(value.Value);

    public static explicit operator Lresult(MaybeBoolInt value) => new Lresult(value.Value);

    public static explicit operator MaybeBoolInt(Lresult value) =>
        new MaybeBoolInt((int)(value.Value));

    public static explicit operator Lresult(Handle value) => new Lresult((nint)(value.Value));

    public static explicit operator Handle(Lresult value) => new Handle((void*)(value.Value));

    public static explicit operator Lresult(Hbrush value) => new Lresult((nint)(value.Value));

    public static explicit operator Hbrush(Lresult value) => new Hbrush((void*)(value.Value));

    public static explicit operator Lresult(Hcursor value) => new Lresult((nint)(value.Value));

    public static explicit operator Hcursor(Lresult value) => new Hcursor((void*)(value.Value));

    public static explicit operator Lresult(HDC value) => new Lresult((nint)(value.Value));

    public static explicit operator HDC(Lresult value) => new HDC((void*)(value.Value));

    public static explicit operator Lresult(Hdrop value) => new Lresult((nint)(value.Value));

    public static explicit operator Hdrop(Lresult value) => new Hdrop((void*)(value.Value));

    public static explicit operator Lresult(Hfont value) => new Lresult((nint)(value.Value));

    public static explicit operator Hfont(Lresult value) => new Hfont((void*)(value.Value));

    public static explicit operator Lresult(Hgdiobj value) => new Lresult((nint)(value.Value));

    public static explicit operator Hgdiobj(Lresult value) => new Hgdiobj((void*)(value.Value));

    public static explicit operator Lresult(Hglobal value) => new Lresult((nint)(value.Value));

    public static explicit operator Hglobal(Lresult value) => new Hglobal((void*)(value.Value));

    public static explicit operator Lresult(Hicon value) => new Lresult((nint)(value.Value));

    public static explicit operator Hicon(Lresult value) => new Hicon((void*)(value.Value));

    public static explicit operator Lresult(Hinstance value) => new Lresult((nint)(value.Value));

    public static explicit operator Hinstance(Lresult value) => new Hinstance((void*)(value.Value));

    public static explicit operator Lresult(Hlocal value) => new Lresult((nint)(value.Value));

    public static explicit operator Hlocal(Lresult value) => new Hlocal((void*)(value.Value));

    public static explicit operator Lresult(Hmenu value) => new Lresult((nint)(value.Value));

    public static explicit operator Hmenu(Lresult value) => new Hmenu((void*)(value.Value));

    public static explicit operator Lresult(HModule value) => new Lresult((nint)(value.Value));

    public static explicit operator HModule(Lresult value) => new HModule((void*)(value.Value));

    public static explicit operator Lresult(Hpalette value) => new Lresult((nint)(value.Value));

    public static explicit operator Hpalette(Lresult value) => new Hpalette((void*)(value.Value));

    public static explicit operator Lresult(HPEN value) => new Lresult((nint)(value.Value));

    public static explicit operator HPEN(Lresult value) => new HPEN((void*)(value.Value));

    public static explicit operator Lresult(HRGN value) => new Lresult((nint)(value.Value));

    public static explicit operator HRGN(Lresult value) => new HRGN((void*)(value.Value));

    public static explicit operator Lresult(HWND value) => new Lresult((nint)(value.Value));

    public static explicit operator HWND(Lresult value) => new HWND((void*)(value.Value));

    public static explicit operator Lresult(Lparam value) => new Lresult(value.Value);

    public static explicit operator Lresult(Wparam value) => new Lresult((nint)(value.Value));
}
