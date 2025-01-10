// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "EC_VARIANT"/> struct.</summary>
public static unsafe partial class EC_VARIANTTests
{
    /// <summary>Validates that the <see cref = "EC_VARIANT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EC_VARIANT>(), Is.EqualTo(sizeof(EC_VARIANT)));
    }

    /// <summary>Validates that the <see cref = "EC_VARIANT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EC_VARIANT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EC_VARIANT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EC_VARIANT), Is.EqualTo(16));
    }
}
