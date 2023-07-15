// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SUBSCRIBE_GENERIC_TLS_EXTENSION"/> struct.</summary>
public static unsafe partial class SUBSCRIBE_GENERIC_TLS_EXTENSIONTests
{
    /// <summary>Validates that the <see cref = "SUBSCRIBE_GENERIC_TLS_EXTENSION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SUBSCRIBE_GENERIC_TLS_EXTENSION>(), Is.EqualTo(sizeof(SUBSCRIBE_GENERIC_TLS_EXTENSION)));
    }

    /// <summary>Validates that the <see cref = "SUBSCRIBE_GENERIC_TLS_EXTENSION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SUBSCRIBE_GENERIC_TLS_EXTENSION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SUBSCRIBE_GENERIC_TLS_EXTENSION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SUBSCRIBE_GENERIC_TLS_EXTENSION), Is.EqualTo(12));
    }
}