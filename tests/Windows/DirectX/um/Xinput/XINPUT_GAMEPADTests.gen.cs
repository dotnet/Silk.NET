// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "XINPUT_GAMEPAD"/> struct.</summary>
public static unsafe partial class XINPUT_GAMEPADTests
{
    /// <summary>Validates that the <see cref = "XINPUT_GAMEPAD"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<XINPUT_GAMEPAD>(), Is.EqualTo(sizeof(XINPUT_GAMEPAD)));
    }

    /// <summary>Validates that the <see cref = "XINPUT_GAMEPAD"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XINPUT_GAMEPAD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "XINPUT_GAMEPAD"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(XINPUT_GAMEPAD), Is.EqualTo(12));
    }
}