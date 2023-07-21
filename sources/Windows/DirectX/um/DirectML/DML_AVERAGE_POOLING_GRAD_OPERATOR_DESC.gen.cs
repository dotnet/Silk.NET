// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC
{
    /// <include file='DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.InputGradientTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputGradientTensor;

    /// <include file='DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.OutputGradientTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputGradientTensor;

    /// <include file='DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.DimensionCount"]/*' />
    public uint DimensionCount;

    /// <include file='DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.Strides"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* Strides;

    /// <include file='DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.WindowSize"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* WindowSize;

    /// <include file='DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.StartPadding"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* StartPadding;

    /// <include file='DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.EndPadding"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* EndPadding;

    /// <include file='DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_AVERAGE_POOLING_GRAD_OPERATOR_DESC.IncludePadding"]/*' />
    public BOOL IncludePadding;
}
