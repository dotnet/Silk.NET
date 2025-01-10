// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES
{
    [NativeTypeName("UINT64")]
    public ulong RowCount;

    [NativeTypeName("UINT64")]
    public ulong ColCount;

    [NativeTypeName("UINT64[64]")]
    public _RowHeights_e__FixedBuffer RowHeights;

    [NativeTypeName("UINT64[64]")]
    public _ColWidths_e__FixedBuffer ColWidths;

    [NativeTypeName("UINT64")]
    public ulong ContextUpdateTileId;

    [InlineArray(64)]
    public partial struct _RowHeights_e__FixedBuffer
    {
        public ulong e0;
    }

    [InlineArray(64)]
    public partial struct _ColWidths_e__FixedBuffer
    {
        public ulong e0;
    }
}
