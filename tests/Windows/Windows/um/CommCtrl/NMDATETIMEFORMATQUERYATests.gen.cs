// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NMDATETIMEFORMATQUERYA"/> struct.</summary>
public static unsafe partial class NMDATETIMEFORMATQUERYATests
{
    /// <summary>Validates that the <see cref = "NMDATETIMEFORMATQUERYA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NMDATETIMEFORMATQUERYA>(), Is.EqualTo(sizeof(NMDATETIMEFORMATQUERYA)));
    }

    /// <summary>Validates that the <see cref = "NMDATETIMEFORMATQUERYA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NMDATETIMEFORMATQUERYA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NMDATETIMEFORMATQUERYA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NMDATETIMEFORMATQUERYA), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(NMDATETIMEFORMATQUERYA), Is.EqualTo(24));
        }
    }
}