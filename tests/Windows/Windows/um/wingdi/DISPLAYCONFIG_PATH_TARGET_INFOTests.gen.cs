// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DISPLAYCONFIG_PATH_TARGET_INFO"/> struct.</summary>
public static unsafe partial class DISPLAYCONFIG_PATH_TARGET_INFOTests
{
    /// <summary>Validates that the <see cref = "DISPLAYCONFIG_PATH_TARGET_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DISPLAYCONFIG_PATH_TARGET_INFO>(), Is.EqualTo(sizeof(DISPLAYCONFIG_PATH_TARGET_INFO)));
    }

    /// <summary>Validates that the <see cref = "DISPLAYCONFIG_PATH_TARGET_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DISPLAYCONFIG_PATH_TARGET_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DISPLAYCONFIG_PATH_TARGET_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DISPLAYCONFIG_PATH_TARGET_INFO), Is.EqualTo(48));
    }
}