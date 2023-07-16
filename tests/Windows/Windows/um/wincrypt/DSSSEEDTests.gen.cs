// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DSSSEED"/> struct.</summary>
public static unsafe partial class DSSSEEDTests
{
    /// <summary>Validates that the <see cref = "DSSSEED"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DSSSEED>(), Is.EqualTo(sizeof(DSSSEED)));
    }

    /// <summary>Validates that the <see cref = "DSSSEED"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DSSSEED).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DSSSEED"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DSSSEED), Is.EqualTo(24));
    }
}