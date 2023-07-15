// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CERT_FORTEZZA_DATA_PROP"/> struct.</summary>
public static unsafe partial class CERT_FORTEZZA_DATA_PROPTests
{
    /// <summary>Validates that the <see cref = "CERT_FORTEZZA_DATA_PROP"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CERT_FORTEZZA_DATA_PROP>(), Is.EqualTo(sizeof(CERT_FORTEZZA_DATA_PROP)));
    }

    /// <summary>Validates that the <see cref = "CERT_FORTEZZA_DATA_PROP"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CERT_FORTEZZA_DATA_PROP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CERT_FORTEZZA_DATA_PROP"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CERT_FORTEZZA_DATA_PROP), Is.EqualTo(48));
    }
}