// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "sockaddr_in6_old"/> struct.</summary>
public static unsafe partial class sockaddr_in6_oldTests
{
    /// <summary>Validates that the <see cref = "sockaddr_in6_old"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<sockaddr_in6_old>(), Is.EqualTo(sizeof(sockaddr_in6_old)));
    }

    /// <summary>Validates that the <see cref = "sockaddr_in6_old"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(sockaddr_in6_old).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "sockaddr_in6_old"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(sockaddr_in6_old), Is.EqualTo(24));
    }
}