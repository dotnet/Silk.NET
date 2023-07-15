// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NMLVSCROLL"/> struct.</summary>
public static unsafe partial class NMLVSCROLLTests
{
    /// <summary>Validates that the <see cref = "NMLVSCROLL"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NMLVSCROLL>(), Is.EqualTo(sizeof(NMLVSCROLL)));
    }

    /// <summary>Validates that the <see cref = "NMLVSCROLL"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NMLVSCROLL).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NMLVSCROLL"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NMLVSCROLL), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(NMLVSCROLL), Is.EqualTo(20));
        }
    }
}