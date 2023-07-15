// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "OUTLINETEXTMETRICW"/> struct.</summary>
public static unsafe partial class OUTLINETEXTMETRICWTests
{
    /// <summary>Validates that the <see cref = "OUTLINETEXTMETRICW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<OUTLINETEXTMETRICW>(), Is.EqualTo(sizeof(OUTLINETEXTMETRICW)));
    }

    /// <summary>Validates that the <see cref = "OUTLINETEXTMETRICW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OUTLINETEXTMETRICW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "OUTLINETEXTMETRICW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(OUTLINETEXTMETRICW), Is.EqualTo(232));
        }
        else
        {
            Assert.That(sizeof(OUTLINETEXTMETRICW), Is.EqualTo(216));
        }
    }
}