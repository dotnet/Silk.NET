// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DML_TOP_K1_OPERATOR_DESC.xml' path='doc/member[@name="DML_TOP_K1_OPERATOR_DESC"]/*'/>
public unsafe partial struct DML_TOP_K1_OPERATOR_DESC
{
    /// <include file='DML_TOP_K1_OPERATOR_DESC.xml' path='doc/member[@name="DML_TOP_K1_OPERATOR_DESC.InputTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;
    /// <include file='DML_TOP_K1_OPERATOR_DESC.xml' path='doc/member[@name="DML_TOP_K1_OPERATOR_DESC.OutputValueTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputValueTensor;
    /// <include file='DML_TOP_K1_OPERATOR_DESC.xml' path='doc/member[@name="DML_TOP_K1_OPERATOR_DESC.OutputIndexTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputIndexTensor;
    /// <include file='DML_TOP_K1_OPERATOR_DESC.xml' path='doc/member[@name="DML_TOP_K1_OPERATOR_DESC.Axis"]/*'/>
    public uint Axis;
    /// <include file='DML_TOP_K1_OPERATOR_DESC.xml' path='doc/member[@name="DML_TOP_K1_OPERATOR_DESC.K"]/*'/>
    public uint K;
    /// <include file='DML_TOP_K1_OPERATOR_DESC.xml' path='doc/member[@name="DML_TOP_K1_OPERATOR_DESC.AxisDirection"]/*'/>
    public DML_AXIS_DIRECTION AxisDirection;
}