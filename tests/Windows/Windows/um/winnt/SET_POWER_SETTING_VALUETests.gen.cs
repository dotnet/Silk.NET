// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SET_POWER_SETTING_VALUE"/> struct.</summary>
public static unsafe partial class SET_POWER_SETTING_VALUETests
{
    /// <summary>Validates that the <see cref = "SET_POWER_SETTING_VALUE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SET_POWER_SETTING_VALUE>(), Is.EqualTo(sizeof(SET_POWER_SETTING_VALUE)));
    }

    /// <summary>Validates that the <see cref = "SET_POWER_SETTING_VALUE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SET_POWER_SETTING_VALUE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SET_POWER_SETTING_VALUE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SET_POWER_SETTING_VALUE), Is.EqualTo(32));
    }
}