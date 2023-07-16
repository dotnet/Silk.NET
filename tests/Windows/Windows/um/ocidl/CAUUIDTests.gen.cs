// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CAUUID"/> struct.</summary>
public static unsafe partial class CAUUIDTests
{
    /// <summary>Validates that the <see cref = "CAUUID"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CAUUID>(), Is.EqualTo(sizeof(CAUUID)));
    }

    /// <summary>Validates that the <see cref = "CAUUID"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CAUUID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CAUUID"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CAUUID), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(CAUUID), Is.EqualTo(8));
        }
    }
}