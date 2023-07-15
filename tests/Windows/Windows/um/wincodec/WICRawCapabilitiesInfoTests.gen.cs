// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WICRawCapabilitiesInfo"/> struct.</summary>
public static unsafe partial class WICRawCapabilitiesInfoTests
{
    /// <summary>Validates that the <see cref = "WICRawCapabilitiesInfo"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WICRawCapabilitiesInfo>(), Is.EqualTo(sizeof(WICRawCapabilitiesInfo)));
    }

    /// <summary>Validates that the <see cref = "WICRawCapabilitiesInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WICRawCapabilitiesInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WICRawCapabilitiesInfo"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WICRawCapabilitiesInfo), Is.EqualTo(72));
    }
}