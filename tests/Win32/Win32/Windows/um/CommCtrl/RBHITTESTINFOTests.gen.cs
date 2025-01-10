// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "RBHITTESTINFO"/> struct.</summary>
public static unsafe partial class RBHITTESTINFOTests
{
    /// <summary>Validates that the <see cref = "RBHITTESTINFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RBHITTESTINFO>(), Is.EqualTo(sizeof(RBHITTESTINFO)));
    }

    /// <summary>Validates that the <see cref = "RBHITTESTINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RBHITTESTINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RBHITTESTINFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RBHITTESTINFO), Is.EqualTo(16));
    }
}
