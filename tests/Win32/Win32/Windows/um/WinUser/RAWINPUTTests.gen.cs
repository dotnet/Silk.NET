// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "RAWINPUT"/> struct.</summary>
public static unsafe partial class RAWINPUTTests
{
    /// <summary>Validates that the <see cref = "RAWINPUT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RAWINPUT>(), Is.EqualTo(sizeof(RAWINPUT)));
    }

    /// <summary>Validates that the <see cref = "RAWINPUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RAWINPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RAWINPUT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(RAWINPUT), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(RAWINPUT), Is.EqualTo(40));
        }
    }
}
