// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES"/> struct.</summary>
[SupportedOSPlatform("windows10.0.22621.0")]
public static unsafe partial class INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIESTests
{
    /// <summary>Validates that the <see cref = "INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES>(), Is.EqualTo(sizeof(INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES)));
    }

    /// <summary>Validates that the <see cref = "INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES), Is.EqualTo(11));
    }
}