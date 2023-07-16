// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tvout.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "VIDEOPARAMETERS"/> struct.</summary>
public static unsafe partial class VIDEOPARAMETERSTests
{
    /// <summary>Validates that the <see cref = "VIDEOPARAMETERS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VIDEOPARAMETERS>(), Is.EqualTo(sizeof(VIDEOPARAMETERS)));
    }

    /// <summary>Validates that the <see cref = "VIDEOPARAMETERS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VIDEOPARAMETERS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "VIDEOPARAMETERS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(VIDEOPARAMETERS), Is.EqualTo(356));
    }
}