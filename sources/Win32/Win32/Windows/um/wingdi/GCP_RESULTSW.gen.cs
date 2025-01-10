// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct GCP_RESULTSW
{
    [NativeTypeName("DWORD")]
    public uint lStructSize;

    [NativeTypeName("LPWSTR")]
    public ushort* lpOutString;
    public uint* lpOrder;
    public int* lpDx;
    public int* lpCaretPos;

    [NativeTypeName("LPSTR")]
    public sbyte* lpClass;

    [NativeTypeName("LPWSTR")]
    public ushort* lpGlyphs;
    public uint nGlyphs;
    public int nMaxFit;
}
