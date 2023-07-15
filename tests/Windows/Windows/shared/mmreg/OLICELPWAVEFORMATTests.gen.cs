// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "OLICELPWAVEFORMAT"/> struct.</summary>
public static unsafe partial class OLICELPWAVEFORMATTests
{
    /// <summary>Validates that the <see cref = "OLICELPWAVEFORMAT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<OLICELPWAVEFORMAT>(), Is.EqualTo(sizeof(OLICELPWAVEFORMAT)));
    }

    /// <summary>Validates that the <see cref = "OLICELPWAVEFORMAT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OLICELPWAVEFORMAT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "OLICELPWAVEFORMAT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(OLICELPWAVEFORMAT), Is.EqualTo(18));
    }
}