// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "TBBUTTONINFOA"/> struct.</summary>
public static unsafe partial class TBBUTTONINFOATests
{
    /// <summary>Validates that the <see cref = "TBBUTTONINFOA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TBBUTTONINFOA>(), Is.EqualTo(sizeof(TBBUTTONINFOA)));
    }

    /// <summary>Validates that the <see cref = "TBBUTTONINFOA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TBBUTTONINFOA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TBBUTTONINFOA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TBBUTTONINFOA), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(TBBUTTONINFOA), Is.EqualTo(32));
        }
    }
}
