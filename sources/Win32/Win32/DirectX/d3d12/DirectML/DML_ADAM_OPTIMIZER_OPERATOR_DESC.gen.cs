// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DML_ADAM_OPTIMIZER_OPERATOR_DESC
{
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputParametersTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputFirstMomentTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputSecondMomentTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* GradientTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* TrainingStepTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputParametersTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputFirstMomentTensor;

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputSecondMomentTensor;
    public float LearningRate;
    public float Beta1;
    public float Beta2;
    public float Epsilon;
}
