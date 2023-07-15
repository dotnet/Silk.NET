// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DDCOLORCONTROL"/> struct.</summary>
public static unsafe partial class DDCOLORCONTROLTests
{
    /// <summary>Validates that the <see cref = "DDCOLORCONTROL"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DDCOLORCONTROL>(), Is.EqualTo(sizeof(DDCOLORCONTROL)));
    }

    /// <summary>Validates that the <see cref = "DDCOLORCONTROL"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DDCOLORCONTROL).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DDCOLORCONTROL"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DDCOLORCONTROL), Is.EqualTo(40));
    }
}