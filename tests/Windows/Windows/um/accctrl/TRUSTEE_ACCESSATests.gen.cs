// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TRUSTEE_ACCESSA"/> struct.</summary>
public static unsafe partial class TRUSTEE_ACCESSATests
{
    /// <summary>Validates that the <see cref = "TRUSTEE_ACCESSA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TRUSTEE_ACCESSA>(), Is.EqualTo(sizeof(TRUSTEE_ACCESSA)));
    }

    /// <summary>Validates that the <see cref = "TRUSTEE_ACCESSA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TRUSTEE_ACCESSA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TRUSTEE_ACCESSA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TRUSTEE_ACCESSA), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(TRUSTEE_ACCESSA), Is.EqualTo(16));
        }
    }
}