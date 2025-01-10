// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "PACKAGE_VERSION"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class PACKAGE_VERSIONTests
{
    /// <summary>Validates that the <see cref = "PACKAGE_VERSION"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PACKAGE_VERSION>(), Is.EqualTo(sizeof(PACKAGE_VERSION)));
    }

    /// <summary>Validates that the <see cref = "PACKAGE_VERSION"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PACKAGE_VERSION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PACKAGE_VERSION"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PACKAGE_VERSION), Is.EqualTo(8));
    }
}
