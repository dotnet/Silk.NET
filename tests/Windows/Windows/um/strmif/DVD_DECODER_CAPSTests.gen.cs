// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DVD_DECODER_CAPS"/> struct.</summary>
public static unsafe partial class DVD_DECODER_CAPSTests
{
    /// <summary>Validates that the <see cref = "DVD_DECODER_CAPS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DVD_DECODER_CAPS>(), Is.EqualTo(sizeof(DVD_DECODER_CAPS)));
    }

    /// <summary>Validates that the <see cref = "DVD_DECODER_CAPS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DVD_DECODER_CAPS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DVD_DECODER_CAPS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DVD_DECODER_CAPS), Is.EqualTo(72));
    }
}