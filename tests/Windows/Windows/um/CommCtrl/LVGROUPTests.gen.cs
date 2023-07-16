// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "LVGROUP"/> struct.</summary>
public static unsafe partial class LVGROUPTests
{
    /// <summary>Validates that the <see cref = "LVGROUP"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<LVGROUP>(), Is.EqualTo(sizeof(LVGROUP)));
    }

    /// <summary>Validates that the <see cref = "LVGROUP"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(LVGROUP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "LVGROUP"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(LVGROUP), Is.EqualTo(152));
        }
        else
        {
            Assert.That(sizeof(LVGROUP), Is.EqualTo(96));
        }
    }
}