// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DDSCAPS2"/> struct.</summary>
public static unsafe partial class DDSCAPS2Tests
{
    /// <summary>Validates that the <see cref = "DDSCAPS2"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DDSCAPS2>(), Is.EqualTo(sizeof(DDSCAPS2)));
    }

    /// <summary>Validates that the <see cref = "DDSCAPS2"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DDSCAPS2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DDSCAPS2"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DDSCAPS2), Is.EqualTo(16));
    }
}