// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "INPUT_TRANSFORM"/> struct.</summary>
public static unsafe partial class INPUT_TRANSFORMTests
{
    /// <summary>Validates that the <see cref = "INPUT_TRANSFORM"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<INPUT_TRANSFORM>(), Is.EqualTo(sizeof(INPUT_TRANSFORM)));
    }

    /// <summary>Validates that the <see cref = "INPUT_TRANSFORM"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INPUT_TRANSFORM).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "INPUT_TRANSFORM"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(INPUT_TRANSFORM), Is.EqualTo(64));
    }
}