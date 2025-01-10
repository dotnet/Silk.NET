// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D2D1_RESOURCE_TEXTURE_PROPERTIES
{
    [NativeTypeName("const UINT32 *")]
    public uint* extents;

    [NativeTypeName("UINT32")]
    public uint dimensions;
    public D2D1_BUFFER_PRECISION bufferPrecision;
    public D2D1_CHANNEL_DEPTH channelDepth;
    public D2D1_FILTER filter;

    [NativeTypeName("const D2D1_EXTEND_MODE *")]
    public D2D1_EXTEND_MODE* extendModes;
}
