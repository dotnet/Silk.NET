// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MFRR_COMPONENTS"/> struct.</summary>
public static unsafe partial class MFRR_COMPONENTSTests
{
    /// <summary>Validates that the <see cref = "MFRR_COMPONENTS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MFRR_COMPONENTS>(), Is.EqualTo(sizeof(MFRR_COMPONENTS)));
    }

    /// <summary>Validates that the <see cref = "MFRR_COMPONENTS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFRR_COMPONENTS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MFRR_COMPONENTS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MFRR_COMPONENTS), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(MFRR_COMPONENTS), Is.EqualTo(12));
        }
    }
}