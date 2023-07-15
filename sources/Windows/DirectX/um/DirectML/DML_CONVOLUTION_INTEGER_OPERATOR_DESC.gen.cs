// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DML_CONVOLUTION_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_CONVOLUTION_INTEGER_OPERATOR_DESC"]/*'/>
public unsafe partial struct DML_CONVOLUTION_INTEGER_OPERATOR_DESC
{
    /// <include file='DML_CONVOLUTION_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_CONVOLUTION_INTEGER_OPERATOR_DESC.InputTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;
    /// <include file='DML_CONVOLUTION_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_CONVOLUTION_INTEGER_OPERATOR_DESC.InputZeroPointTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputZeroPointTensor;
    /// <include file='DML_CONVOLUTION_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_CONVOLUTION_INTEGER_OPERATOR_DESC.FilterTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* FilterTensor;
    /// <include file='DML_CONVOLUTION_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_CONVOLUTION_INTEGER_OPERATOR_DESC.FilterZeroPointTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* FilterZeroPointTensor;
    /// <include file='DML_CONVOLUTION_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_CONVOLUTION_INTEGER_OPERATOR_DESC.OutputTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;
    /// <include file='DML_CONVOLUTION_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_CONVOLUTION_INTEGER_OPERATOR_DESC.DimensionCount"]/*'/>
    public uint DimensionCount;
    /// <include file='DML_CONVOLUTION_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_CONVOLUTION_INTEGER_OPERATOR_DESC.Strides"]/*'/>
    [NativeTypeName("const UINT *")]
    public uint* Strides;
    /// <include file='DML_CONVOLUTION_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_CONVOLUTION_INTEGER_OPERATOR_DESC.Dilations"]/*'/>
    [NativeTypeName("const UINT *")]
    public uint* Dilations;
    /// <include file='DML_CONVOLUTION_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_CONVOLUTION_INTEGER_OPERATOR_DESC.StartPadding"]/*'/>
    [NativeTypeName("const UINT *")]
    public uint* StartPadding;
    /// <include file='DML_CONVOLUTION_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_CONVOLUTION_INTEGER_OPERATOR_DESC.EndPadding"]/*'/>
    [NativeTypeName("const UINT *")]
    public uint* EndPadding;
    /// <include file='DML_CONVOLUTION_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_CONVOLUTION_INTEGER_OPERATOR_DESC.GroupCount"]/*'/>
    public uint GroupCount;
}