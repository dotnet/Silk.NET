// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MFCameraIntrinsic_DistortionModel.xml' path='doc/member[@name="MFCameraIntrinsic_DistortionModel"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct MFCameraIntrinsic_DistortionModel
{
    /// <include file='MFCameraIntrinsic_DistortionModel.xml' path='doc/member[@name="MFCameraIntrinsic_DistortionModel.Radial_k1"]/*' />
    public float Radial_k1;

    /// <include file='MFCameraIntrinsic_DistortionModel.xml' path='doc/member[@name="MFCameraIntrinsic_DistortionModel.Radial_k2"]/*' />
    public float Radial_k2;

    /// <include file='MFCameraIntrinsic_DistortionModel.xml' path='doc/member[@name="MFCameraIntrinsic_DistortionModel.Radial_k3"]/*' />
    public float Radial_k3;

    /// <include file='MFCameraIntrinsic_DistortionModel.xml' path='doc/member[@name="MFCameraIntrinsic_DistortionModel.Tangential_p1"]/*' />
    public float Tangential_p1;

    /// <include file='MFCameraIntrinsic_DistortionModel.xml' path='doc/member[@name="MFCameraIntrinsic_DistortionModel.Tangential_p2"]/*' />
    public float Tangential_p2;
}
