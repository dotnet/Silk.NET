// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO
{
    public D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION TransformationType;

    [NativeTypeName("INT[8]")]
    public _TransformationMatrix_e__FixedBuffer TransformationMatrix;
    public BOOL InvalidAffineSet;

    [InlineArray(8)]
    public partial struct _TransformationMatrix_e__FixedBuffer
    {
        public int e0;
    }
}
