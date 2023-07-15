// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PHYSICAL_ELEMENT_STATUS_REQUEST"/> struct.</summary>
public static unsafe partial class PHYSICAL_ELEMENT_STATUS_REQUESTTests
{
    /// <summary>Validates that the <see cref = "PHYSICAL_ELEMENT_STATUS_REQUEST"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PHYSICAL_ELEMENT_STATUS_REQUEST>(), Is.EqualTo(sizeof(PHYSICAL_ELEMENT_STATUS_REQUEST)));
    }

    /// <summary>Validates that the <see cref = "PHYSICAL_ELEMENT_STATUS_REQUEST"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PHYSICAL_ELEMENT_STATUS_REQUEST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PHYSICAL_ELEMENT_STATUS_REQUEST"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PHYSICAL_ELEMENT_STATUS_REQUEST), Is.EqualTo(16));
    }
}