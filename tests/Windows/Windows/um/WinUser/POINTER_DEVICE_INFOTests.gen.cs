// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "POINTER_DEVICE_INFO"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class POINTER_DEVICE_INFOTests
{
    /// <summary>Validates that the <see cref = "POINTER_DEVICE_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<POINTER_DEVICE_INFO>(), Is.EqualTo(sizeof(POINTER_DEVICE_INFO)));
    }

    /// <summary>Validates that the <see cref = "POINTER_DEVICE_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(POINTER_DEVICE_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "POINTER_DEVICE_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(POINTER_DEVICE_INFO), Is.EqualTo(1080));
        }
        else
        {
            Assert.That(sizeof(POINTER_DEVICE_INFO), Is.EqualTo(1064));
        }
    }
}