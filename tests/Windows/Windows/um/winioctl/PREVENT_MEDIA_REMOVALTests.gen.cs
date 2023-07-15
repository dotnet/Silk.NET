// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PREVENT_MEDIA_REMOVAL"/> struct.</summary>
public static unsafe partial class PREVENT_MEDIA_REMOVALTests
{
    /// <summary>Validates that the <see cref = "PREVENT_MEDIA_REMOVAL"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PREVENT_MEDIA_REMOVAL>(), Is.EqualTo(sizeof(PREVENT_MEDIA_REMOVAL)));
    }

    /// <summary>Validates that the <see cref = "PREVENT_MEDIA_REMOVAL"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PREVENT_MEDIA_REMOVAL).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PREVENT_MEDIA_REMOVAL"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PREVENT_MEDIA_REMOVAL), Is.EqualTo(1));
    }
}