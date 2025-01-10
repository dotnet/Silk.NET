// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MFExtendedCameraIntrinsic_IntrinsicModel"/> struct.</summary>
public static unsafe partial class MFExtendedCameraIntrinsic_IntrinsicModelTests
{
    /// <summary>Validates that the <see cref = "MFExtendedCameraIntrinsic_IntrinsicModel"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<MFExtendedCameraIntrinsic_IntrinsicModel>(),
            Is.EqualTo(sizeof(MFExtendedCameraIntrinsic_IntrinsicModel))
        );
    }

    /// <summary>Validates that the <see cref = "MFExtendedCameraIntrinsic_IntrinsicModel"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFExtendedCameraIntrinsic_IntrinsicModel).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MFExtendedCameraIntrinsic_IntrinsicModel"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MFExtendedCameraIntrinsic_IntrinsicModel), Is.EqualTo(28));
    }
}
