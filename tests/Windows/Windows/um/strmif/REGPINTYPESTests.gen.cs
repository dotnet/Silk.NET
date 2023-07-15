// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "REGPINTYPES"/> struct.</summary>
public static unsafe partial class REGPINTYPESTests
{
    /// <summary>Validates that the <see cref = "REGPINTYPES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<REGPINTYPES>(), Is.EqualTo(sizeof(REGPINTYPES)));
    }

    /// <summary>Validates that the <see cref = "REGPINTYPES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(REGPINTYPES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "REGPINTYPES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(REGPINTYPES), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(REGPINTYPES), Is.EqualTo(8));
        }
    }
}