// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IPV6_MREQ"/> struct.</summary>
public static unsafe partial class IPV6_MREQTests
{
    /// <summary>Validates that the <see cref = "IPV6_MREQ"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPV6_MREQ>(), Is.EqualTo(sizeof(IPV6_MREQ)));
    }

    /// <summary>Validates that the <see cref = "IPV6_MREQ"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPV6_MREQ).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPV6_MREQ"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IPV6_MREQ), Is.EqualTo(20));
    }
}