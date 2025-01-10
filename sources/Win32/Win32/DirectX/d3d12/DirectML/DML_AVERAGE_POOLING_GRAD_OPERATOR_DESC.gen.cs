// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC
{
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputGradientTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputGradientTensor;
    public uint DimensionCount;

    [NativeTypeName("const UINT *")]
    public uint* Strides;

    [NativeTypeName("const UINT *")]
    public uint* WindowSize;

    [NativeTypeName("const UINT *")]
    public uint* StartPadding;

    [NativeTypeName("const UINT *")]
    public uint* EndPadding;
    public BOOL IncludePadding;
}
