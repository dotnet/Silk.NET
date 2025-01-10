// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "XAUDIO2FX_REVERB_PARAMETERS"/> struct.</summary>
public static unsafe partial class XAUDIO2FX_REVERB_PARAMETERSTests
{
    /// <summary>Validates that the <see cref = "XAUDIO2FX_REVERB_PARAMETERS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<XAUDIO2FX_REVERB_PARAMETERS>(),
            Is.EqualTo(sizeof(XAUDIO2FX_REVERB_PARAMETERS))
        );
    }

    /// <summary>Validates that the <see cref = "XAUDIO2FX_REVERB_PARAMETERS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XAUDIO2FX_REVERB_PARAMETERS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "XAUDIO2FX_REVERB_PARAMETERS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(XAUDIO2FX_REVERB_PARAMETERS), Is.EqualTo(57));
    }
}
