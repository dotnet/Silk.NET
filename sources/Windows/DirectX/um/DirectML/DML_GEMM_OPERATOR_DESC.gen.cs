// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_GEMM_OPERATOR_DESC
{
    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.ATensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* ATensor;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.BTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BTensor;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.CTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* CTensor;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.TransA"]/*' />
    public DML_MATRIX_TRANSFORM TransA;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.TransB"]/*' />
    public DML_MATRIX_TRANSFORM TransB;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.Alpha"]/*' />
    public float Alpha;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.Beta"]/*' />
    public float Beta;

    /// <include file='DML_GEMM_OPERATOR_DESC.xml' path='doc/member[@name="DML_GEMM_OPERATOR_DESC.FusedActivation"]/*' />
    [NativeTypeName("const DML_OPERATOR_DESC *")]
    public DML_OPERATOR_DESC* FusedActivation;
}
