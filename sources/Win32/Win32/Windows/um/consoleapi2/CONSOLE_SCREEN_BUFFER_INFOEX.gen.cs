// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/consoleapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CONSOLE_SCREEN_BUFFER_INFOEX
{
    [NativeTypeName("ULONG")]
    public uint cbSize;
    public COORD dwSize;
    public COORD dwCursorPosition;

    [NativeTypeName("WORD")]
    public ushort wAttributes;
    public SMALL_RECT srWindow;
    public COORD dwMaximumWindowSize;

    [NativeTypeName("WORD")]
    public ushort wPopupAttributes;
    public BOOL bFullscreenSupported;

    [NativeTypeName("COLORREF[16]")]
    public _ColorTable_e__FixedBuffer ColorTable;

    [InlineArray(16)]
    public partial struct _ColorTable_e__FixedBuffer
    {
        public COLORREF e0;
    }
}
