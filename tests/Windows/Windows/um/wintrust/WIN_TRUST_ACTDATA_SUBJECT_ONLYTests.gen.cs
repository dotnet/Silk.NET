// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WIN_TRUST_ACTDATA_SUBJECT_ONLY"/> struct.</summary>
public static unsafe partial class WIN_TRUST_ACTDATA_SUBJECT_ONLYTests
{
    /// <summary>Validates that the <see cref = "WIN_TRUST_ACTDATA_SUBJECT_ONLY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WIN_TRUST_ACTDATA_SUBJECT_ONLY>(), Is.EqualTo(sizeof(WIN_TRUST_ACTDATA_SUBJECT_ONLY)));
    }

    /// <summary>Validates that the <see cref = "WIN_TRUST_ACTDATA_SUBJECT_ONLY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WIN_TRUST_ACTDATA_SUBJECT_ONLY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WIN_TRUST_ACTDATA_SUBJECT_ONLY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WIN_TRUST_ACTDATA_SUBJECT_ONLY), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(WIN_TRUST_ACTDATA_SUBJECT_ONLY), Is.EqualTo(8));
        }
    }
}