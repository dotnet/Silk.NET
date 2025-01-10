// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NT_CONSOLE_PROPS
{
    public DATABLOCK_HEADER dbh;

    [NativeTypeName("WORD")]
    public ushort wFillAttribute;

    [NativeTypeName("WORD")]
    public ushort wPopupFillAttribute;
    public COORD dwScreenBufferSize;
    public COORD dwWindowSize;
    public COORD dwWindowOrigin;

    [NativeTypeName("DWORD")]
    public uint nFont;

    [NativeTypeName("DWORD")]
    public uint nInputBufferSize;
    public COORD dwFontSize;
    public uint uFontFamily;
    public uint uFontWeight;

    [NativeTypeName("WCHAR[32]")]
    public _FaceName_e__FixedBuffer FaceName;
    public uint uCursorSize;
    public BOOL bFullScreen;
    public BOOL bQuickEdit;
    public BOOL bInsertMode;
    public BOOL bAutoPosition;
    public uint uHistoryBufferSize;
    public uint uNumberOfHistoryBuffers;
    public BOOL bHistoryNoDup;

    [NativeTypeName("COLORREF[16]")]
    public _ColorTable_e__FixedBuffer ColorTable;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _FaceName_e__FixedBuffer
    {
        public ushort e0;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(16)]
    public partial struct _ColorTable_e__FixedBuffer
    {
        public COLORREF e0;
    }
}
