// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HIDP_KEYBOARD_MODIFIER_STATE"/> struct.</summary>
public static unsafe partial class HIDP_KEYBOARD_MODIFIER_STATETests
{
    /// <summary>Validates that the <see cref = "HIDP_KEYBOARD_MODIFIER_STATE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HIDP_KEYBOARD_MODIFIER_STATE>(), Is.EqualTo(sizeof(HIDP_KEYBOARD_MODIFIER_STATE)));
    }

    /// <summary>Validates that the <see cref = "HIDP_KEYBOARD_MODIFIER_STATE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HIDP_KEYBOARD_MODIFIER_STATE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HIDP_KEYBOARD_MODIFIER_STATE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HIDP_KEYBOARD_MODIFIER_STATE), Is.EqualTo(4));
    }
}