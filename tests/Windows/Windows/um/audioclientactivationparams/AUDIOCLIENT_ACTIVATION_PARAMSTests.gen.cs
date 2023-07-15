// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audioclientactivationparams.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "AUDIOCLIENT_ACTIVATION_PARAMS"/> struct.</summary>
[SupportedOSPlatform("windows10.0.19043.0")]
public static unsafe partial class AUDIOCLIENT_ACTIVATION_PARAMSTests
{
    /// <summary>Validates that the <see cref = "AUDIOCLIENT_ACTIVATION_PARAMS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AUDIOCLIENT_ACTIVATION_PARAMS>(), Is.EqualTo(sizeof(AUDIOCLIENT_ACTIVATION_PARAMS)));
    }

    /// <summary>Validates that the <see cref = "AUDIOCLIENT_ACTIVATION_PARAMS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AUDIOCLIENT_ACTIVATION_PARAMS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AUDIOCLIENT_ACTIVATION_PARAMS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AUDIOCLIENT_ACTIVATION_PARAMS), Is.EqualTo(12));
    }
}