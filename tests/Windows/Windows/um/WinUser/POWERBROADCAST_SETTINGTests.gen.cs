// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "POWERBROADCAST_SETTING"/> struct.</summary>
public static unsafe partial class POWERBROADCAST_SETTINGTests
{
    /// <summary>Validates that the <see cref = "POWERBROADCAST_SETTING"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<POWERBROADCAST_SETTING>(), Is.EqualTo(sizeof(POWERBROADCAST_SETTING)));
    }

    /// <summary>Validates that the <see cref = "POWERBROADCAST_SETTING"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(POWERBROADCAST_SETTING).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "POWERBROADCAST_SETTING"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(POWERBROADCAST_SETTING), Is.EqualTo(24));
    }
}