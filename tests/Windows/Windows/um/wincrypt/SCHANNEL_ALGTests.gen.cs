// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SCHANNEL_ALG"/> struct.</summary>
public static unsafe partial class SCHANNEL_ALGTests
{
    /// <summary>Validates that the <see cref = "SCHANNEL_ALG"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SCHANNEL_ALG>(), Is.EqualTo(sizeof(SCHANNEL_ALG)));
    }

    /// <summary>Validates that the <see cref = "SCHANNEL_ALG"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SCHANNEL_ALG).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SCHANNEL_ALG"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SCHANNEL_ALG), Is.EqualTo(20));
    }
}