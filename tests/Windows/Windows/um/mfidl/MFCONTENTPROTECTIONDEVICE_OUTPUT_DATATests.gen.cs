// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class MFCONTENTPROTECTIONDEVICE_OUTPUT_DATATests
{
    /// <summary>Validates that the <see cref = "MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA>(), Is.EqualTo(sizeof(MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA)));
    }

    /// <summary>Validates that the <see cref = "MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MFCONTENTPROTECTIONDEVICE_OUTPUT_DATA), Is.EqualTo(40));
    }
}