// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "LVITEMA"/> struct.</summary>
public static unsafe partial class LVITEMATests
{
    /// <summary>Validates that the <see cref = "LVITEMA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<LVITEMA>(), Is.EqualTo(sizeof(LVITEMA)));
    }

    /// <summary>Validates that the <see cref = "LVITEMA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(LVITEMA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "LVITEMA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(LVITEMA), Is.EqualTo(88));
        }
        else
        {
            Assert.That(sizeof(LVITEMA), Is.EqualTo(60));
        }
    }
}