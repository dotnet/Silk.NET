// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ROOT_INFO_LUID"/> struct.</summary>
public static unsafe partial class ROOT_INFO_LUIDTests
{
    /// <summary>Validates that the <see cref = "ROOT_INFO_LUID"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ROOT_INFO_LUID>(), Is.EqualTo(sizeof(ROOT_INFO_LUID)));
    }

    /// <summary>Validates that the <see cref = "ROOT_INFO_LUID"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ROOT_INFO_LUID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ROOT_INFO_LUID"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ROOT_INFO_LUID), Is.EqualTo(8));
    }
}
