// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MFCameraExtrinsic_CalibratedTransform.xml' path='doc/member[@name="MFCameraExtrinsic_CalibratedTransform"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct MFCameraExtrinsic_CalibratedTransform
{
    /// <include file='MFCameraExtrinsic_CalibratedTransform.xml' path='doc/member[@name="MFCameraExtrinsic_CalibratedTransform.CalibrationId"]/*'/>
    public Guid CalibrationId;
    /// <include file='MFCameraExtrinsic_CalibratedTransform.xml' path='doc/member[@name="MFCameraExtrinsic_CalibratedTransform.Position"]/*'/>
    public MF_FLOAT3 Position;
    /// <include file='MFCameraExtrinsic_CalibratedTransform.xml' path='doc/member[@name="MFCameraExtrinsic_CalibratedTransform.Orientation"]/*'/>
    public MF_QUATERNION Orientation;
}