// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HELPWININFOW"/> struct.</summary>
public static unsafe partial class HELPWININFOWTests
{
    /// <summary>Validates that the <see cref = "HELPWININFOW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HELPWININFOW>(), Is.EqualTo(sizeof(HELPWININFOW)));
    }

    /// <summary>Validates that the <see cref = "HELPWININFOW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HELPWININFOW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HELPWININFOW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HELPWININFOW), Is.EqualTo(28));
    }
}