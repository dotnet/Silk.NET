// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DML_CONVOLUTION_OPERATOR_DESC
{
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* FilterTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BiasTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;
    public DML_CONVOLUTION_MODE Mode;
    public DML_CONVOLUTION_DIRECTION Direction;
    public uint DimensionCount;

    [NativeTypeName("const UINT *")]
    public uint* Strides;

    [NativeTypeName("const UINT *")]
    public uint* Dilations;

    [NativeTypeName("const UINT *")]
    public uint* StartPadding;

    [NativeTypeName("const UINT *")]
    public uint* EndPadding;

    [NativeTypeName("const UINT *")]
    public uint* OutputPadding;
    public uint GroupCount;

    [NativeTypeName("const DML_OPERATOR_DESC *")]
    public DML_OPERATOR_DESC* FusedActivation;
}
