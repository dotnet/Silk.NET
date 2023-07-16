// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DIPROPHEADER"/> struct.</summary>
public static unsafe partial class DIPROPHEADERTests
{
    /// <summary>Validates that the <see cref = "DIPROPHEADER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DIPROPHEADER>(), Is.EqualTo(sizeof(DIPROPHEADER)));
    }

    /// <summary>Validates that the <see cref = "DIPROPHEADER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DIPROPHEADER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DIPROPHEADER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DIPROPHEADER), Is.EqualTo(16));
    }
}