// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFCameraIntrinsic_CameraModel.xml' path='doc/member[@name="MFCameraIntrinsic_CameraModel"]/*'/>
public partial struct MFCameraIntrinsic_CameraModel
{
    /// <include file='MFCameraIntrinsic_CameraModel.xml' path='doc/member[@name="MFCameraIntrinsic_CameraModel.FocalLength_x"]/*'/>
    public float FocalLength_x;
    /// <include file='MFCameraIntrinsic_CameraModel.xml' path='doc/member[@name="MFCameraIntrinsic_CameraModel.FocalLength_y"]/*'/>
    public float FocalLength_y;
    /// <include file='MFCameraIntrinsic_CameraModel.xml' path='doc/member[@name="MFCameraIntrinsic_CameraModel.PrincipalPoint_x"]/*'/>
    public float PrincipalPoint_x;
    /// <include file='MFCameraIntrinsic_CameraModel.xml' path='doc/member[@name="MFCameraIntrinsic_CameraModel.PrincipalPoint_y"]/*'/>
    public float PrincipalPoint_y;
}