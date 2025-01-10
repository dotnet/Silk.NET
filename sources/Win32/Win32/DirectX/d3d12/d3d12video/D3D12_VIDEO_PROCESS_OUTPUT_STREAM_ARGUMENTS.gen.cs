// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS
{
    [NativeTypeName("D3D12_VIDEO_PROCESS_OUTPUT_STREAM[2]")]
    public _OutputStream_e__FixedBuffer OutputStream;

    [NativeTypeName("D3D12_RECT")]
    public RECT TargetRectangle;

    [InlineArray(2)]
    public partial struct _OutputStream_e__FixedBuffer
    {
        public D3D12_VIDEO_PROCESS_OUTPUT_STREAM e0;
    }
}
