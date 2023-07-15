// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IO_IRP_EXT_TRACK_OFFSET_HEADER"/> struct.</summary>
public static unsafe partial class IO_IRP_EXT_TRACK_OFFSET_HEADERTests
{
    /// <summary>Validates that the <see cref = "IO_IRP_EXT_TRACK_OFFSET_HEADER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IO_IRP_EXT_TRACK_OFFSET_HEADER>(), Is.EqualTo(sizeof(IO_IRP_EXT_TRACK_OFFSET_HEADER)));
    }

    /// <summary>Validates that the <see cref = "IO_IRP_EXT_TRACK_OFFSET_HEADER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IO_IRP_EXT_TRACK_OFFSET_HEADER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IO_IRP_EXT_TRACK_OFFSET_HEADER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IO_IRP_EXT_TRACK_OFFSET_HEADER), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(IO_IRP_EXT_TRACK_OFFSET_HEADER), Is.EqualTo(8));
        }
    }
}