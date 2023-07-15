// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITfSource"/> struct.</summary>
public static unsafe partial class ITfSourceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITfSource"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITfSource).GUID, Is.EqualTo(IID_ITfSource));
    }

    /// <summary>Validates that the <see cref = "ITfSource"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITfSource>(), Is.EqualTo(sizeof(ITfSource)));
    }

    /// <summary>Validates that the <see cref = "ITfSource"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfSource).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITfSource"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfSource), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfSource), Is.EqualTo(4));
        }
    }
}