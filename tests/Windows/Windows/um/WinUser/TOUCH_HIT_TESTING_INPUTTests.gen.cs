// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TOUCH_HIT_TESTING_INPUT"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class TOUCH_HIT_TESTING_INPUTTests
{
    /// <summary>Validates that the <see cref = "TOUCH_HIT_TESTING_INPUT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TOUCH_HIT_TESTING_INPUT>(), Is.EqualTo(sizeof(TOUCH_HIT_TESTING_INPUT)));
    }

    /// <summary>Validates that the <see cref = "TOUCH_HIT_TESTING_INPUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TOUCH_HIT_TESTING_INPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TOUCH_HIT_TESTING_INPUT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TOUCH_HIT_TESTING_INPUT), Is.EqualTo(48));
    }
}