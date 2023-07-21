// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DML_ELEMENT_WISE_DIVIDE_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_DIVIDE_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_ELEMENT_WISE_DIVIDE_OPERATOR_DESC
{
    /// <include file='DML_ELEMENT_WISE_DIVIDE_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_DIVIDE_OPERATOR_DESC.ATensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* ATensor;

    /// <include file='DML_ELEMENT_WISE_DIVIDE_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_DIVIDE_OPERATOR_DESC.BTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BTensor;

    /// <include file='DML_ELEMENT_WISE_DIVIDE_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_DIVIDE_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;
}
