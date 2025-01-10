// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DICOLORSET
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("D3DCOLOR")]
    public uint cTextFore;

    [NativeTypeName("D3DCOLOR")]
    public uint cTextHighlight;

    [NativeTypeName("D3DCOLOR")]
    public uint cCalloutLine;

    [NativeTypeName("D3DCOLOR")]
    public uint cCalloutHighlight;

    [NativeTypeName("D3DCOLOR")]
    public uint cBorder;

    [NativeTypeName("D3DCOLOR")]
    public uint cControlFill;

    [NativeTypeName("D3DCOLOR")]
    public uint cHighlightFill;

    [NativeTypeName("D3DCOLOR")]
    public uint cAreaFill;
}
