// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MFCameraIntrinsic_DistortionModel6KT
{
    public float Radial_k1;
    public float Radial_k2;
    public float Radial_k3;
    public float Radial_k4;
    public float Radial_k5;
    public float Radial_k6;
    public float Tangential_p1;
    public float Tangential_p2;
}
