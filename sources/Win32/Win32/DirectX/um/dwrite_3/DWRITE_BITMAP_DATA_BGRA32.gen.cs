// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DWRITE_BITMAP_DATA_BGRA32
{
    [NativeTypeName("UINT32")]
    public uint width;

    [NativeTypeName("UINT32")]
    public uint height;

    [NativeTypeName("UINT32 *")]
    public uint* pixels;
}
