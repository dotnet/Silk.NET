// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TS_SELECTION_ANCHOR"/> struct.</summary>
public static unsafe partial class TS_SELECTION_ANCHORTests
{
    /// <summary>Validates that the <see cref = "TS_SELECTION_ANCHOR"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TS_SELECTION_ANCHOR>(), Is.EqualTo(sizeof(TS_SELECTION_ANCHOR)));
    }

    /// <summary>Validates that the <see cref = "TS_SELECTION_ANCHOR"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TS_SELECTION_ANCHOR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TS_SELECTION_ANCHOR"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TS_SELECTION_ANCHOR), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(TS_SELECTION_ANCHOR), Is.EqualTo(16));
        }
    }
}