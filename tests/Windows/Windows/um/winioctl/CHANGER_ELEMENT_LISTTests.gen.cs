// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CHANGER_ELEMENT_LIST"/> struct.</summary>
public static unsafe partial class CHANGER_ELEMENT_LISTTests
{
    /// <summary>Validates that the <see cref = "CHANGER_ELEMENT_LIST"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CHANGER_ELEMENT_LIST>(), Is.EqualTo(sizeof(CHANGER_ELEMENT_LIST)));
    }

    /// <summary>Validates that the <see cref = "CHANGER_ELEMENT_LIST"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CHANGER_ELEMENT_LIST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CHANGER_ELEMENT_LIST"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CHANGER_ELEMENT_LIST), Is.EqualTo(12));
    }
}