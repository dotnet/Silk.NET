// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DEVICE_DATA_SET_RANGE"/> struct.</summary>
public static unsafe partial class DEVICE_DATA_SET_RANGETests
{
    /// <summary>Validates that the <see cref = "DEVICE_DATA_SET_RANGE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DEVICE_DATA_SET_RANGE>(), Is.EqualTo(sizeof(DEVICE_DATA_SET_RANGE)));
    }

    /// <summary>Validates that the <see cref = "DEVICE_DATA_SET_RANGE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DEVICE_DATA_SET_RANGE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DEVICE_DATA_SET_RANGE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DEVICE_DATA_SET_RANGE), Is.EqualTo(16));
    }
}