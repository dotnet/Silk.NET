// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IVMRDeinterlaceControl"/> struct.</summary>
public static unsafe partial class IVMRDeinterlaceControlTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IVMRDeinterlaceControl"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IVMRDeinterlaceControl).GUID, Is.EqualTo(IID_IVMRDeinterlaceControl));
    }

    /// <summary>Validates that the <see cref = "IVMRDeinterlaceControl"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IVMRDeinterlaceControl>(), Is.EqualTo(sizeof(IVMRDeinterlaceControl)));
    }

    /// <summary>Validates that the <see cref = "IVMRDeinterlaceControl"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IVMRDeinterlaceControl).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IVMRDeinterlaceControl"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IVMRDeinterlaceControl), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IVMRDeinterlaceControl), Is.EqualTo(4));
        }
    }
}