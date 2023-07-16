// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "COLOR"/> struct.</summary>
public static unsafe partial class COLORTests
{
    /// <summary>Validates that the <see cref = "COLOR"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<COLOR>(), Is.EqualTo(sizeof(COLOR)));
    }

    /// <summary>Validates that the <see cref = "COLOR"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(COLOR).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref = "COLOR"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(COLOR), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(COLOR), Is.EqualTo(8));
        }
    }
}