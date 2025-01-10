// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CAUH"/> struct.</summary>
public static unsafe partial class CAUHTests
{
    /// <summary>Validates that the <see cref = "CAUH"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CAUH>(), Is.EqualTo(sizeof(CAUH)));
    }

    /// <summary>Validates that the <see cref = "CAUH"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CAUH).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CAUH"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CAUH), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(CAUH), Is.EqualTo(8));
        }
    }
}
