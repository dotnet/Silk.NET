// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "INHERITED_FROMA"/> struct.</summary>
public static unsafe partial class INHERITED_FROMATests
{
    /// <summary>Validates that the <see cref = "INHERITED_FROMA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<INHERITED_FROMA>(), Is.EqualTo(sizeof(INHERITED_FROMA)));
    }

    /// <summary>Validates that the <see cref = "INHERITED_FROMA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INHERITED_FROMA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "INHERITED_FROMA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(INHERITED_FROMA), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(INHERITED_FROMA), Is.EqualTo(8));
        }
    }
}