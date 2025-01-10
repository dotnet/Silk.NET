// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct LOGFONTW
{
    [NativeTypeName("LONG")]
    public int lfHeight;

    [NativeTypeName("LONG")]
    public int lfWidth;

    [NativeTypeName("LONG")]
    public int lfEscapement;

    [NativeTypeName("LONG")]
    public int lfOrientation;

    [NativeTypeName("LONG")]
    public int lfWeight;
    public byte lfItalic;
    public byte lfUnderline;
    public byte lfStrikeOut;
    public byte lfCharSet;
    public byte lfOutPrecision;
    public byte lfClipPrecision;
    public byte lfQuality;
    public byte lfPitchAndFamily;

    [NativeTypeName("WCHAR[32]")]
    public _lfFaceName_e__FixedBuffer lfFaceName;

    [InlineArray(32)]
    public partial struct _lfFaceName_e__FixedBuffer
    {
        public ushort e0;
    }
}
