// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFCameraIntrinsic_DistortionModelArcTan.xml' path='doc/member[@name="MFCameraIntrinsic_DistortionModelArcTan"]/*' />
public partial struct MFCameraIntrinsic_DistortionModelArcTan
{
    /// <include file='MFCameraIntrinsic_DistortionModelArcTan.xml' path='doc/member[@name="MFCameraIntrinsic_DistortionModelArcTan.Radial_k0"]/*' />
    public float Radial_k0;

    /// <include file='MFCameraIntrinsic_DistortionModelArcTan.xml' path='doc/member[@name="MFCameraIntrinsic_DistortionModelArcTan.DistortionCenter_x"]/*' />
    public float DistortionCenter_x;

    /// <include file='MFCameraIntrinsic_DistortionModelArcTan.xml' path='doc/member[@name="MFCameraIntrinsic_DistortionModelArcTan.DistortionCenter_y"]/*' />
    public float DistortionCenter_y;

    /// <include file='MFCameraIntrinsic_DistortionModelArcTan.xml' path='doc/member[@name="MFCameraIntrinsic_DistortionModelArcTan.Tangential_x"]/*' />
    public float Tangential_x;

    /// <include file='MFCameraIntrinsic_DistortionModelArcTan.xml' path='doc/member[@name="MFCameraIntrinsic_DistortionModelArcTan.Tangential_y"]/*' />
    public float Tangential_y;
}
