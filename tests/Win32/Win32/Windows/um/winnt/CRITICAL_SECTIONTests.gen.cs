// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CRITICAL_SECTION"/> struct.</summary>
public static unsafe partial class CRITICAL_SECTIONTests
{
    /// <summary>Validates that the <see cref = "CRITICAL_SECTION"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CRITICAL_SECTION>(), Is.EqualTo(sizeof(CRITICAL_SECTION)));
    }

    /// <summary>Validates that the <see cref = "CRITICAL_SECTION"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CRITICAL_SECTION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CRITICAL_SECTION"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CRITICAL_SECTION), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(CRITICAL_SECTION), Is.EqualTo(24));
        }
    }
}
