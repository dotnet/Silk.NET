// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC
{
    /// <include file='DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.ATensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* ATensor;

    /// <include file='DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.AScaleTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* AScaleTensor;

    /// <include file='DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.AZeroPointTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* AZeroPointTensor;

    /// <include file='DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.BTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BTensor;

    /// <include file='DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.BScaleTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BScaleTensor;

    /// <include file='DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.BZeroPointTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BZeroPointTensor;

    /// <include file='DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.OutputScaleTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputScaleTensor;

    /// <include file='DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.OutputZeroPointTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputZeroPointTensor;

    /// <include file='DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.xml' path='doc/member[@name="DML_QUANTIZED_LINEAR_MATRIX_MULTIPLY_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;
}
