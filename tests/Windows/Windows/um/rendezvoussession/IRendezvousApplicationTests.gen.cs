// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IRendezvousApplication"/> struct.</summary>
public static unsafe partial class IRendezvousApplicationTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IRendezvousApplication"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IRendezvousApplication).GUID, Is.EqualTo(IID_IRendezvousApplication));
    }

    /// <summary>Validates that the <see cref = "IRendezvousApplication"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IRendezvousApplication>(), Is.EqualTo(sizeof(IRendezvousApplication)));
    }

    /// <summary>Validates that the <see cref = "IRendezvousApplication"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IRendezvousApplication).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IRendezvousApplication"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IRendezvousApplication), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IRendezvousApplication), Is.EqualTo(4));
        }
    }
}