// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SOURCE_MEDIA_W"/> struct.</summary>
public static unsafe partial class SOURCE_MEDIA_WTests
{
    /// <summary>Validates that the <see cref = "SOURCE_MEDIA_W"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SOURCE_MEDIA_W>(), Is.EqualTo(sizeof(SOURCE_MEDIA_W)));
    }

    /// <summary>Validates that the <see cref = "SOURCE_MEDIA_W"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SOURCE_MEDIA_W).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SOURCE_MEDIA_W"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SOURCE_MEDIA_W), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(SOURCE_MEDIA_W), Is.EqualTo(24));
        }
    }
}
