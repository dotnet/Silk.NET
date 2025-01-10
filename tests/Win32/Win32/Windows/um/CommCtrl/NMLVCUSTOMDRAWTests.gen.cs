// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "NMLVCUSTOMDRAW"/> struct.</summary>
public static unsafe partial class NMLVCUSTOMDRAWTests
{
    /// <summary>Validates that the <see cref = "NMLVCUSTOMDRAW"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NMLVCUSTOMDRAW>(), Is.EqualTo(sizeof(NMLVCUSTOMDRAW)));
    }

    /// <summary>Validates that the <see cref = "NMLVCUSTOMDRAW"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NMLVCUSTOMDRAW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NMLVCUSTOMDRAW"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NMLVCUSTOMDRAW), Is.EqualTo(136));
        }
        else
        {
            Assert.That(sizeof(NMLVCUSTOMDRAW), Is.EqualTo(104));
        }
    }
}
