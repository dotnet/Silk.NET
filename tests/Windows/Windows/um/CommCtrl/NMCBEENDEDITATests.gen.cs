// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NMCBEENDEDITA"/> struct.</summary>
public static unsafe partial class NMCBEENDEDITATests
{
    /// <summary>Validates that the <see cref = "NMCBEENDEDITA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NMCBEENDEDITA>(), Is.EqualTo(sizeof(NMCBEENDEDITA)));
    }

    /// <summary>Validates that the <see cref = "NMCBEENDEDITA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NMCBEENDEDITA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NMCBEENDEDITA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NMCBEENDEDITA), Is.EqualTo(296));
        }
        else
        {
            Assert.That(sizeof(NMCBEENDEDITA), Is.EqualTo(284));
        }
    }
}