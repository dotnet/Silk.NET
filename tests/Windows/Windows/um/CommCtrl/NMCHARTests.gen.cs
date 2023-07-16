// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NMCHAR"/> struct.</summary>
public static unsafe partial class NMCHARTests
{
    /// <summary>Validates that the <see cref = "NMCHAR"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NMCHAR>(), Is.EqualTo(sizeof(NMCHAR)));
    }

    /// <summary>Validates that the <see cref = "NMCHAR"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NMCHAR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NMCHAR"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NMCHAR), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(NMCHAR), Is.EqualTo(24));
        }
    }
}