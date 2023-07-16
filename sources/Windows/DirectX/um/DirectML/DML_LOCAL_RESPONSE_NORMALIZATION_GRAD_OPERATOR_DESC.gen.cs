// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC"]/*'/>
public unsafe partial struct DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC
{
    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.InputTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;
    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.InputGradientTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputGradientTensor;
    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.OutputGradientTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputGradientTensor;
    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.CrossChannel"]/*'/>
    public BOOL CrossChannel;
    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.LocalSize"]/*'/>
    public uint LocalSize;
    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.Alpha"]/*'/>
    public float Alpha;
    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.Beta"]/*'/>
    public float Beta;
    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.Bias"]/*'/>
    public float Bias;
}