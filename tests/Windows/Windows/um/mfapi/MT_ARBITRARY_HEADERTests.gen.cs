// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MT_ARBITRARY_HEADER"/> struct.</summary>
public static unsafe partial class MT_ARBITRARY_HEADERTests
{
    /// <summary>Validates that the <see cref = "MT_ARBITRARY_HEADER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MT_ARBITRARY_HEADER>(), Is.EqualTo(sizeof(MT_ARBITRARY_HEADER)));
    }

    /// <summary>Validates that the <see cref = "MT_ARBITRARY_HEADER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MT_ARBITRARY_HEADER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MT_ARBITRARY_HEADER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MT_ARBITRARY_HEADER), Is.EqualTo(60));
    }
}