// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DML_RNN_OPERATOR_DESC.xml' path='doc/member[@name="DML_RNN_OPERATOR_DESC"]/*'/>
public unsafe partial struct DML_RNN_OPERATOR_DESC
{
    /// <include file='DML_RNN_OPERATOR_DESC.xml' path='doc/member[@name="DML_RNN_OPERATOR_DESC.InputTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;
    /// <include file='DML_RNN_OPERATOR_DESC.xml' path='doc/member[@name="DML_RNN_OPERATOR_DESC.WeightTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* WeightTensor;
    /// <include file='DML_RNN_OPERATOR_DESC.xml' path='doc/member[@name="DML_RNN_OPERATOR_DESC.RecurrenceTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* RecurrenceTensor;
    /// <include file='DML_RNN_OPERATOR_DESC.xml' path='doc/member[@name="DML_RNN_OPERATOR_DESC.BiasTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BiasTensor;
    /// <include file='DML_RNN_OPERATOR_DESC.xml' path='doc/member[@name="DML_RNN_OPERATOR_DESC.HiddenInitTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* HiddenInitTensor;
    /// <include file='DML_RNN_OPERATOR_DESC.xml' path='doc/member[@name="DML_RNN_OPERATOR_DESC.SequenceLengthsTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* SequenceLengthsTensor;
    /// <include file='DML_RNN_OPERATOR_DESC.xml' path='doc/member[@name="DML_RNN_OPERATOR_DESC.OutputSequenceTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputSequenceTensor;
    /// <include file='DML_RNN_OPERATOR_DESC.xml' path='doc/member[@name="DML_RNN_OPERATOR_DESC.OutputSingleTensor"]/*'/>
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputSingleTensor;
    /// <include file='DML_RNN_OPERATOR_DESC.xml' path='doc/member[@name="DML_RNN_OPERATOR_DESC.ActivationDescCount"]/*'/>
    public uint ActivationDescCount;
    /// <include file='DML_RNN_OPERATOR_DESC.xml' path='doc/member[@name="DML_RNN_OPERATOR_DESC.ActivationDescs"]/*'/>
    [NativeTypeName("const DML_OPERATOR_DESC *")]
    public DML_OPERATOR_DESC* ActivationDescs;
    /// <include file='DML_RNN_OPERATOR_DESC.xml' path='doc/member[@name="DML_RNN_OPERATOR_DESC.Direction"]/*'/>
    public DML_RECURRENT_NETWORK_DIRECTION Direction;
}