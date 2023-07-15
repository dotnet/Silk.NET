// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MFCameraIntrinsic_PinholeCameraModel.xml' path='doc/member[@name="MFCameraIntrinsic_PinholeCameraModel"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct MFCameraIntrinsic_PinholeCameraModel
{
    /// <include file='MFCameraIntrinsic_PinholeCameraModel.xml' path='doc/member[@name="MFCameraIntrinsic_PinholeCameraModel.FocalLength"]/*'/>
    public MF_FLOAT2 FocalLength;
    /// <include file='MFCameraIntrinsic_PinholeCameraModel.xml' path='doc/member[@name="MFCameraIntrinsic_PinholeCameraModel.PrincipalPoint"]/*'/>
    public MF_FLOAT2 PrincipalPoint;
}