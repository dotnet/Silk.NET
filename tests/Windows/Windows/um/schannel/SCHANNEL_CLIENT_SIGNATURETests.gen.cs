// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SCHANNEL_CLIENT_SIGNATURE"/> struct.</summary>
public static unsafe partial class SCHANNEL_CLIENT_SIGNATURETests
{
    /// <summary>Validates that the <see cref = "SCHANNEL_CLIENT_SIGNATURE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SCHANNEL_CLIENT_SIGNATURE>(), Is.EqualTo(sizeof(SCHANNEL_CLIENT_SIGNATURE)));
    }

    /// <summary>Validates that the <see cref = "SCHANNEL_CLIENT_SIGNATURE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SCHANNEL_CLIENT_SIGNATURE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SCHANNEL_CLIENT_SIGNATURE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SCHANNEL_CLIENT_SIGNATURE), Is.EqualTo(68));
    }
}