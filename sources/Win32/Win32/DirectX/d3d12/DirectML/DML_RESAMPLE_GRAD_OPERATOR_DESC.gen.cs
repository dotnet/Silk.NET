// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DML_RESAMPLE_GRAD_OPERATOR_DESC
{
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputGradientTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputGradientTensor;
    public DML_INTERPOLATION_MODE InterpolationMode;
    public uint DimensionCount;

    [NativeTypeName("const FLOAT *")]
    public float* Scales;

    [NativeTypeName("const FLOAT *")]
    public float* InputPixelOffsets;

    [NativeTypeName("const FLOAT *")]
    public float* OutputPixelOffsets;
}
