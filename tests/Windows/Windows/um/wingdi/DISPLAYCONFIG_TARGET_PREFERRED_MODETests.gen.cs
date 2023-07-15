// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DISPLAYCONFIG_TARGET_PREFERRED_MODE"/> struct.</summary>
public static unsafe partial class DISPLAYCONFIG_TARGET_PREFERRED_MODETests
{
    /// <summary>Validates that the <see cref = "DISPLAYCONFIG_TARGET_PREFERRED_MODE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DISPLAYCONFIG_TARGET_PREFERRED_MODE>(), Is.EqualTo(sizeof(DISPLAYCONFIG_TARGET_PREFERRED_MODE)));
    }

    /// <summary>Validates that the <see cref = "DISPLAYCONFIG_TARGET_PREFERRED_MODE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DISPLAYCONFIG_TARGET_PREFERRED_MODE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DISPLAYCONFIG_TARGET_PREFERRED_MODE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DISPLAYCONFIG_TARGET_PREFERRED_MODE), Is.EqualTo(80));
    }
}