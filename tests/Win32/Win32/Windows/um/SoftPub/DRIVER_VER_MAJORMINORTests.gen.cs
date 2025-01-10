// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "DRIVER_VER_MAJORMINOR"/> struct.</summary>
public static unsafe partial class DRIVER_VER_MAJORMINORTests
{
    /// <summary>Validates that the <see cref = "DRIVER_VER_MAJORMINOR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DRIVER_VER_MAJORMINOR>(),
            Is.EqualTo(sizeof(DRIVER_VER_MAJORMINOR))
        );
    }

    /// <summary>Validates that the <see cref = "DRIVER_VER_MAJORMINOR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DRIVER_VER_MAJORMINOR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DRIVER_VER_MAJORMINOR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DRIVER_VER_MAJORMINOR), Is.EqualTo(8));
    }
}
