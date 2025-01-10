// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MFExtendedCameraIntrinsic_IntrinsicModel
{
    [NativeTypeName("UINT32")]
    public uint Width;

    [NativeTypeName("UINT32")]
    public uint Height;

    [NativeTypeName("UINT32")]
    public uint SplitFrameId;
    public MFCameraIntrinsic_CameraModel CameraModel;
}
