// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MFCameraIntrinsic_DistortionModel"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class MFCameraIntrinsic_DistortionModelTests
{
    /// <summary>Validates that the <see cref = "MFCameraIntrinsic_DistortionModel"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MFCameraIntrinsic_DistortionModel>(), Is.EqualTo(sizeof(MFCameraIntrinsic_DistortionModel)));
    }

    /// <summary>Validates that the <see cref = "MFCameraIntrinsic_DistortionModel"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFCameraIntrinsic_DistortionModel).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MFCameraIntrinsic_DistortionModel"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MFCameraIntrinsic_DistortionModel), Is.EqualTo(20));
    }
}