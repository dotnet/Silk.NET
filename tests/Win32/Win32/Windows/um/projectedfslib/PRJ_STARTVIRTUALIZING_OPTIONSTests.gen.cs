// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "PRJ_STARTVIRTUALIZING_OPTIONS"/> struct.</summary>
[SupportedOSPlatform("windows10.0.17763.0")]
public static unsafe partial class PRJ_STARTVIRTUALIZING_OPTIONSTests
{
    /// <summary>Validates that the <see cref = "PRJ_STARTVIRTUALIZING_OPTIONS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PRJ_STARTVIRTUALIZING_OPTIONS>(),
            Is.EqualTo(sizeof(PRJ_STARTVIRTUALIZING_OPTIONS))
        );
    }

    /// <summary>Validates that the <see cref = "PRJ_STARTVIRTUALIZING_OPTIONS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PRJ_STARTVIRTUALIZING_OPTIONS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PRJ_STARTVIRTUALIZING_OPTIONS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PRJ_STARTVIRTUALIZING_OPTIONS), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(PRJ_STARTVIRTUALIZING_OPTIONS), Is.EqualTo(20));
        }
    }
}
