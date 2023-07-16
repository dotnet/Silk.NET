// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MFPinholeCameraIntrinsic_IntrinsicModel.xml' path='doc/member[@name="MFPinholeCameraIntrinsic_IntrinsicModel"]/*'/>
[SupportedOSPlatform("windows10.0")]
public partial struct MFPinholeCameraIntrinsic_IntrinsicModel
{
    /// <include file='MFPinholeCameraIntrinsic_IntrinsicModel.xml' path='doc/member[@name="MFPinholeCameraIntrinsic_IntrinsicModel.Width"]/*'/>
    [NativeTypeName("UINT32")]
    public uint Width;
    /// <include file='MFPinholeCameraIntrinsic_IntrinsicModel.xml' path='doc/member[@name="MFPinholeCameraIntrinsic_IntrinsicModel.Height"]/*'/>
    [NativeTypeName("UINT32")]
    public uint Height;
    /// <include file='MFPinholeCameraIntrinsic_IntrinsicModel.xml' path='doc/member[@name="MFPinholeCameraIntrinsic_IntrinsicModel.CameraModel"]/*'/>
    public MFCameraIntrinsic_PinholeCameraModel CameraModel;
    /// <include file='MFPinholeCameraIntrinsic_IntrinsicModel.xml' path='doc/member[@name="MFPinholeCameraIntrinsic_IntrinsicModel.DistortionModel"]/*'/>
    public MFCameraIntrinsic_DistortionModel DistortionModel;
}