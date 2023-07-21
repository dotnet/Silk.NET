// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DML_ROI_ALIGN_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_ROI_ALIGN_OPERATOR_DESC
{
    /// <include file='DML_ROI_ALIGN_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_ROI_ALIGN_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_OPERATOR_DESC.ROITensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* ROITensor;

    /// <include file='DML_ROI_ALIGN_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_OPERATOR_DESC.BatchIndicesTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BatchIndicesTensor;

    /// <include file='DML_ROI_ALIGN_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_ROI_ALIGN_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_OPERATOR_DESC.ReductionFunction"]/*' />
    public DML_REDUCE_FUNCTION ReductionFunction;

    /// <include file='DML_ROI_ALIGN_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_OPERATOR_DESC.InterpolationMode"]/*' />
    public DML_INTERPOLATION_MODE InterpolationMode;

    /// <include file='DML_ROI_ALIGN_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_OPERATOR_DESC.SpatialScaleX"]/*' />
    public float SpatialScaleX;

    /// <include file='DML_ROI_ALIGN_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_OPERATOR_DESC.SpatialScaleY"]/*' />
    public float SpatialScaleY;

    /// <include file='DML_ROI_ALIGN_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_OPERATOR_DESC.OutOfBoundsInputValue"]/*' />
    public float OutOfBoundsInputValue;

    /// <include file='DML_ROI_ALIGN_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_OPERATOR_DESC.MinimumSamplesPerOutput"]/*' />
    public uint MinimumSamplesPerOutput;

    /// <include file='DML_ROI_ALIGN_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_OPERATOR_DESC.MaximumSamplesPerOutput"]/*' />
    public uint MaximumSamplesPerOutput;
}
