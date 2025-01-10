// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DWRITE_GLYPH_RUN_DESCRIPTION
{
    [NativeTypeName("const WCHAR *")]
    public ushort* localeName;

    [NativeTypeName("const WCHAR *")]
    public ushort* @string;

    [NativeTypeName("UINT32")]
    public uint stringLength;

    [NativeTypeName("const UINT16 *")]
    public ushort* clusterMap;

    [NativeTypeName("UINT32")]
    public uint textPosition;
}
