// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PARAMDESCEX"/> struct.</summary>
public static unsafe partial class PARAMDESCEXTests
{
    /// <summary>Validates that the <see cref = "PARAMDESCEX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PARAMDESCEX>(), Is.EqualTo(sizeof(PARAMDESCEX)));
    }

    /// <summary>Validates that the <see cref = "PARAMDESCEX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PARAMDESCEX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PARAMDESCEX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PARAMDESCEX), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(PARAMDESCEX), Is.EqualTo(24));
        }
    }
}