// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MFCameraExtrinsic_CalibratedTransform"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class MFCameraExtrinsic_CalibratedTransformTests
{
    /// <summary>Validates that the <see cref = "MFCameraExtrinsic_CalibratedTransform"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<MFCameraExtrinsic_CalibratedTransform>(),
            Is.EqualTo(sizeof(MFCameraExtrinsic_CalibratedTransform))
        );
    }

    /// <summary>Validates that the <see cref = "MFCameraExtrinsic_CalibratedTransform"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFCameraExtrinsic_CalibratedTransform).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MFCameraExtrinsic_CalibratedTransform"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MFCameraExtrinsic_CalibratedTransform), Is.EqualTo(44));
    }
}
