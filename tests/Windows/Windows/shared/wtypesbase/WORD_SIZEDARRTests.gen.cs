// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WORD_SIZEDARR"/> struct.</summary>
public static unsafe partial class WORD_SIZEDARRTests
{
    /// <summary>Validates that the <see cref = "WORD_SIZEDARR"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WORD_SIZEDARR>(), Is.EqualTo(sizeof(WORD_SIZEDARR)));
    }

    /// <summary>Validates that the <see cref = "WORD_SIZEDARR"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WORD_SIZEDARR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WORD_SIZEDARR"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WORD_SIZEDARR), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(WORD_SIZEDARR), Is.EqualTo(8));
        }
    }
}