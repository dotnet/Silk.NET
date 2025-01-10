// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC
{
    public DXGI_FORMAT Format;
    public DXGI_COLOR_SPACE_TYPE ColorSpace;
    public D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE AlphaFillMode;
    public uint AlphaFillModeSourceStreamIndex;

    [NativeTypeName("FLOAT[4]")]
    public _BackgroundColor_e__FixedBuffer BackgroundColor;
    public DXGI_RATIONAL FrameRate;
    public BOOL EnableStereo;

    [InlineArray(4)]
    public partial struct _BackgroundColor_e__FixedBuffer
    {
        public float e0;
    }
}
