// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "OPENFILENAME_NT4W"/> struct.</summary>
public static unsafe partial class OPENFILENAME_NT4WTests
{
    /// <summary>Validates that the <see cref = "OPENFILENAME_NT4W"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<OPENFILENAME_NT4W>(), Is.EqualTo(sizeof(OPENFILENAME_NT4W)));
    }

    /// <summary>Validates that the <see cref = "OPENFILENAME_NT4W"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OPENFILENAME_NT4W).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "OPENFILENAME_NT4W"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(OPENFILENAME_NT4W), Is.EqualTo(136));
        }
        else
        {
            Assert.That(sizeof(OPENFILENAME_NT4W), Is.EqualTo(76));
        }
    }
}