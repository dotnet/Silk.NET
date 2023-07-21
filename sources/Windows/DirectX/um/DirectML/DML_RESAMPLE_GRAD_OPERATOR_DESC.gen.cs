// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_RESAMPLE_GRAD_OPERATOR_DESC
{
    /// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC.InputGradientTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputGradientTensor;

    /// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC.OutputGradientTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputGradientTensor;

    /// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC.InterpolationMode"]/*' />
    public DML_INTERPOLATION_MODE InterpolationMode;

    /// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC.DimensionCount"]/*' />
    public uint DimensionCount;

    /// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC.Scales"]/*' />
    [NativeTypeName("const FLOAT *")]
    public float* Scales;

    /// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC.InputPixelOffsets"]/*' />
    [NativeTypeName("const FLOAT *")]
    public float* InputPixelOffsets;

    /// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC.OutputPixelOffsets"]/*' />
    [NativeTypeName("const FLOAT *")]
    public float* OutputPixelOffsets;
}
