// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DEBUGHOOKINFO"/> struct.</summary>
public static unsafe partial class DEBUGHOOKINFOTests
{
    /// <summary>Validates that the <see cref = "DEBUGHOOKINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DEBUGHOOKINFO>(), Is.EqualTo(sizeof(DEBUGHOOKINFO)));
    }

    /// <summary>Validates that the <see cref = "DEBUGHOOKINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DEBUGHOOKINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DEBUGHOOKINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DEBUGHOOKINFO), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(DEBUGHOOKINFO), Is.EqualTo(20));
        }
    }
}