// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FORMAT_EX_PARAMETERS"/> struct.</summary>
public static unsafe partial class FORMAT_EX_PARAMETERSTests
{
    /// <summary>Validates that the <see cref = "FORMAT_EX_PARAMETERS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FORMAT_EX_PARAMETERS>(), Is.EqualTo(sizeof(FORMAT_EX_PARAMETERS)));
    }

    /// <summary>Validates that the <see cref = "FORMAT_EX_PARAMETERS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FORMAT_EX_PARAMETERS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FORMAT_EX_PARAMETERS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FORMAT_EX_PARAMETERS), Is.EqualTo(28));
    }
}