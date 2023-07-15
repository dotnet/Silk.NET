// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CABSTRBLOB"/> struct.</summary>
public static unsafe partial class CABSTRBLOBTests
{
    /// <summary>Validates that the <see cref = "CABSTRBLOB"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CABSTRBLOB>(), Is.EqualTo(sizeof(CABSTRBLOB)));
    }

    /// <summary>Validates that the <see cref = "CABSTRBLOB"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CABSTRBLOB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CABSTRBLOB"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CABSTRBLOB), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(CABSTRBLOB), Is.EqualTo(8));
        }
    }
}