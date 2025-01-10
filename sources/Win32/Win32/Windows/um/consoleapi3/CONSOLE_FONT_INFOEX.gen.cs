// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/consoleapi3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CONSOLE_FONT_INFOEX
{
    [NativeTypeName("ULONG")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint nFont;
    public COORD dwFontSize;
    public uint FontFamily;
    public uint FontWeight;

    [NativeTypeName("WCHAR[32]")]
    public _FaceName_e__FixedBuffer FaceName;

    [InlineArray(32)]
    public partial struct _FaceName_e__FixedBuffer
    {
        public ushort e0;
    }
}
