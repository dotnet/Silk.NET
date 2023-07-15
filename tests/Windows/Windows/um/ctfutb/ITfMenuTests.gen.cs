// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITfMenu"/> struct.</summary>
public static unsafe partial class ITfMenuTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITfMenu"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITfMenu).GUID, Is.EqualTo(IID_ITfMenu));
    }

    /// <summary>Validates that the <see cref = "ITfMenu"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITfMenu>(), Is.EqualTo(sizeof(ITfMenu)));
    }

    /// <summary>Validates that the <see cref = "ITfMenu"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfMenu).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITfMenu"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfMenu), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfMenu), Is.EqualTo(4));
        }
    }
}