// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IO_STATUS_BLOCK"/> struct.</summary>
public static unsafe partial class IO_STATUS_BLOCKTests
{
    /// <summary>Validates that the <see cref = "IO_STATUS_BLOCK"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IO_STATUS_BLOCK>(), Is.EqualTo(sizeof(IO_STATUS_BLOCK)));
    }

    /// <summary>Validates that the <see cref = "IO_STATUS_BLOCK"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IO_STATUS_BLOCK).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IO_STATUS_BLOCK"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IO_STATUS_BLOCK), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(IO_STATUS_BLOCK), Is.EqualTo(8));
        }
    }
}