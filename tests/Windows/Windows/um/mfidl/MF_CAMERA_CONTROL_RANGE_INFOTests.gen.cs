// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MF_CAMERA_CONTROL_RANGE_INFO"/> struct.</summary>
public static unsafe partial class MF_CAMERA_CONTROL_RANGE_INFOTests
{
    /// <summary>Validates that the <see cref = "MF_CAMERA_CONTROL_RANGE_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MF_CAMERA_CONTROL_RANGE_INFO>(), Is.EqualTo(sizeof(MF_CAMERA_CONTROL_RANGE_INFO)));
    }

    /// <summary>Validates that the <see cref = "MF_CAMERA_CONTROL_RANGE_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MF_CAMERA_CONTROL_RANGE_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MF_CAMERA_CONTROL_RANGE_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MF_CAMERA_CONTROL_RANGE_INFO), Is.EqualTo(16));
    }
}