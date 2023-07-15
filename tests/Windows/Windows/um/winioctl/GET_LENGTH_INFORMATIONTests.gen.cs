// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "GET_LENGTH_INFORMATION"/> struct.</summary>
public static unsafe partial class GET_LENGTH_INFORMATIONTests
{
    /// <summary>Validates that the <see cref = "GET_LENGTH_INFORMATION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<GET_LENGTH_INFORMATION>(), Is.EqualTo(sizeof(GET_LENGTH_INFORMATION)));
    }

    /// <summary>Validates that the <see cref = "GET_LENGTH_INFORMATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GET_LENGTH_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GET_LENGTH_INFORMATION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(GET_LENGTH_INFORMATION), Is.EqualTo(8));
    }
}