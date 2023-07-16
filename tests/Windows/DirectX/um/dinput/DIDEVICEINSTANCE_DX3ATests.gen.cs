// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DIDEVICEINSTANCE_DX3A"/> struct.</summary>
public static unsafe partial class DIDEVICEINSTANCE_DX3ATests
{
    /// <summary>Validates that the <see cref = "DIDEVICEINSTANCE_DX3A"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DIDEVICEINSTANCE_DX3A>(), Is.EqualTo(sizeof(DIDEVICEINSTANCE_DX3A)));
    }

    /// <summary>Validates that the <see cref = "DIDEVICEINSTANCE_DX3A"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DIDEVICEINSTANCE_DX3A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DIDEVICEINSTANCE_DX3A"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DIDEVICEINSTANCE_DX3A), Is.EqualTo(560));
    }
}