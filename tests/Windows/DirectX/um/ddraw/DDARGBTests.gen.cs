// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DDARGB"/> struct.</summary>
public static unsafe partial class DDARGBTests
{
    /// <summary>Validates that the <see cref = "DDARGB"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DDARGB>(), Is.EqualTo(sizeof(DDARGB)));
    }

    /// <summary>Validates that the <see cref = "DDARGB"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DDARGB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DDARGB"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DDARGB), Is.EqualTo(4));
    }
}