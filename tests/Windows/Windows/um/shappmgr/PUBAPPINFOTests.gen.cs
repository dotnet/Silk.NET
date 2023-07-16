// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PUBAPPINFO"/> struct.</summary>
public static unsafe partial class PUBAPPINFOTests
{
    /// <summary>Validates that the <see cref = "PUBAPPINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PUBAPPINFO>(), Is.EqualTo(sizeof(PUBAPPINFO)));
    }

    /// <summary>Validates that the <see cref = "PUBAPPINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PUBAPPINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PUBAPPINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PUBAPPINFO), Is.EqualTo(80));
        }
        else
        {
            Assert.That(sizeof(PUBAPPINFO), Is.EqualTo(76));
        }
    }
}