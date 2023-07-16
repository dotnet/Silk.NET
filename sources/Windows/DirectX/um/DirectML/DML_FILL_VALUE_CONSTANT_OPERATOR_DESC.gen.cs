// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DML_FILL_VALUE_CONSTANT_OPERATOR_DESC.xml' path='doc/member[@name="DML_FILL_VALUE_CONSTANT_OPERATOR_DESC"]/*'/>
public unsafe partial struct DML_FILL_VALUE_CONSTANT_OPERATOR_DESC
{
    /// <include file='DML_FILL_VALUE_CONSTANT_OPERATOR_DESC.xml' path='doc/member[@name="DML_FILL_VALUE_CONSTANT_OPERATOR_DESC.OutputTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;
    /// <include file='DML_FILL_VALUE_CONSTANT_OPERATOR_DESC.xml' path='doc/member[@name="DML_FILL_VALUE_CONSTANT_OPERATOR_DESC.ValueDataType"]/*'/>
    public DML_TENSOR_DATA_TYPE ValueDataType;
    /// <include file='DML_FILL_VALUE_CONSTANT_OPERATOR_DESC.xml' path='doc/member[@name="DML_FILL_VALUE_CONSTANT_OPERATOR_DESC.Value"]/*'/>
    public DML_SCALAR_UNION Value;
}