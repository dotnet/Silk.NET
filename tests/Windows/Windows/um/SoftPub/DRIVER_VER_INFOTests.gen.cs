// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DRIVER_VER_INFO"/> struct.</summary>
public static unsafe partial class DRIVER_VER_INFOTests
{
    /// <summary>Validates that the <see cref = "DRIVER_VER_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DRIVER_VER_INFO>(), Is.EqualTo(sizeof(DRIVER_VER_INFO)));
    }

    /// <summary>Validates that the <see cref = "DRIVER_VER_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DRIVER_VER_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DRIVER_VER_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DRIVER_VER_INFO), Is.EqualTo(1104));
        }
        else
        {
            Assert.That(sizeof(DRIVER_VER_INFO), Is.EqualTo(1088));
        }
    }
}