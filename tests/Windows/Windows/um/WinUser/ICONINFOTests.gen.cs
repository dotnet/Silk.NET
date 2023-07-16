// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ICONINFO"/> struct.</summary>
public static unsafe partial class ICONINFOTests
{
    /// <summary>Validates that the <see cref = "ICONINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICONINFO>(), Is.EqualTo(sizeof(ICONINFO)));
    }

    /// <summary>Validates that the <see cref = "ICONINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICONINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICONINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICONINFO), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(ICONINFO), Is.EqualTo(20));
        }
    }
}