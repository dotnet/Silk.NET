// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MFCameraIntrinsic_PinholeCameraModel"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class MFCameraIntrinsic_PinholeCameraModelTests
{
    /// <summary>Validates that the <see cref = "MFCameraIntrinsic_PinholeCameraModel"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<MFCameraIntrinsic_PinholeCameraModel>(),
            Is.EqualTo(sizeof(MFCameraIntrinsic_PinholeCameraModel))
        );
    }

    /// <summary>Validates that the <see cref = "MFCameraIntrinsic_PinholeCameraModel"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFCameraIntrinsic_PinholeCameraModel).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MFCameraIntrinsic_PinholeCameraModel"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MFCameraIntrinsic_PinholeCameraModel), Is.EqualTo(16));
    }
}
