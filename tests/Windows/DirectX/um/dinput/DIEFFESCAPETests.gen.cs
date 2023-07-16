// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DIEFFESCAPE"/> struct.</summary>
public static unsafe partial class DIEFFESCAPETests
{
    /// <summary>Validates that the <see cref = "DIEFFESCAPE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DIEFFESCAPE>(), Is.EqualTo(sizeof(DIEFFESCAPE)));
    }

    /// <summary>Validates that the <see cref = "DIEFFESCAPE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DIEFFESCAPE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DIEFFESCAPE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DIEFFESCAPE), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(DIEFFESCAPE), Is.EqualTo(24));
        }
    }
}