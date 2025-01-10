// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "DWM_BLURBEHIND"/> struct.</summary>
public static unsafe partial class DWM_BLURBEHINDTests
{
    /// <summary>Validates that the <see cref = "DWM_BLURBEHIND"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DWM_BLURBEHIND>(), Is.EqualTo(sizeof(DWM_BLURBEHIND)));
    }

    /// <summary>Validates that the <see cref = "DWM_BLURBEHIND"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DWM_BLURBEHIND).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DWM_BLURBEHIND"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DWM_BLURBEHIND), Is.EqualTo(20));
        }
        else
        {
            Assert.That(sizeof(DWM_BLURBEHIND), Is.EqualTo(16));
        }
    }
}
