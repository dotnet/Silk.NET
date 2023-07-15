// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IDLDESC"/> struct.</summary>
public static unsafe partial class IDLDESCTests
{
    /// <summary>Validates that the <see cref = "IDLDESC"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDLDESC>(), Is.EqualTo(sizeof(IDLDESC)));
    }

    /// <summary>Validates that the <see cref = "IDLDESC"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDLDESC).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDLDESC"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDLDESC), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(IDLDESC), Is.EqualTo(8));
        }
    }
}