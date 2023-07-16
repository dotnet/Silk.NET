// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CACHE_RELATIONSHIP"/> struct.</summary>
public static unsafe partial class CACHE_RELATIONSHIPTests
{
    /// <summary>Validates that the <see cref = "CACHE_RELATIONSHIP"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CACHE_RELATIONSHIP>(), Is.EqualTo(sizeof(CACHE_RELATIONSHIP)));
    }

    /// <summary>Validates that the <see cref = "CACHE_RELATIONSHIP"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CACHE_RELATIONSHIP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CACHE_RELATIONSHIP"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CACHE_RELATIONSHIP), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(CACHE_RELATIONSHIP), Is.EqualTo(44));
        }
    }
}