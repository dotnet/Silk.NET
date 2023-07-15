// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFExtendedCameraIntrinsic_IntrinsicModel.xml' path='doc/member[@name="MFExtendedCameraIntrinsic_IntrinsicModel"]/*'/>
public partial struct MFExtendedCameraIntrinsic_IntrinsicModel
{
    /// <include file='MFExtendedCameraIntrinsic_IntrinsicModel.xml' path='doc/member[@name="MFExtendedCameraIntrinsic_IntrinsicModel.Width"]/*'/>
    [NativeTypeName("UINT32")]
    public uint Width;
    /// <include file='MFExtendedCameraIntrinsic_IntrinsicModel.xml' path='doc/member[@name="MFExtendedCameraIntrinsic_IntrinsicModel.Height"]/*'/>
    [NativeTypeName("UINT32")]
    public uint Height;
    /// <include file='MFExtendedCameraIntrinsic_IntrinsicModel.xml' path='doc/member[@name="MFExtendedCameraIntrinsic_IntrinsicModel.SplitFrameId"]/*'/>
    [NativeTypeName("UINT32")]
    public uint SplitFrameId;
    /// <include file='MFExtendedCameraIntrinsic_IntrinsicModel.xml' path='doc/member[@name="MFExtendedCameraIntrinsic_IntrinsicModel.CameraModel"]/*'/>
    public MFCameraIntrinsic_CameraModel CameraModel;
}