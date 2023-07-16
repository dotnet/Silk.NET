// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SPPHRASE_50"/> struct.</summary>
public static unsafe partial class SPPHRASE_50Tests
{
    /// <summary>Validates that the <see cref = "SPPHRASE_50"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SPPHRASE_50>(), Is.EqualTo(sizeof(SPPHRASE_50)));
    }

    /// <summary>Validates that the <see cref = "SPPHRASE_50"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SPPHRASE_50).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SPPHRASE_50"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SPPHRASE_50), Is.EqualTo(160));
        }
        else
        {
            Assert.That(sizeof(SPPHRASE_50), Is.EqualTo(120));
        }
    }
}