// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DEVICE_LOCATION"/> struct.</summary>
public static unsafe partial class DEVICE_LOCATIONTests
{
    /// <summary>Validates that the <see cref = "DEVICE_LOCATION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DEVICE_LOCATION>(), Is.EqualTo(sizeof(DEVICE_LOCATION)));
    }

    /// <summary>Validates that the <see cref = "DEVICE_LOCATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DEVICE_LOCATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DEVICE_LOCATION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DEVICE_LOCATION), Is.EqualTo(24));
    }
}