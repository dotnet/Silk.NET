// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "WINHTTP_FAST_FORWARDING_STATUS"/> struct.</summary>
public static unsafe partial class WINHTTP_FAST_FORWARDING_STATUSTests
{
    /// <summary>Validates that the <see cref = "WINHTTP_FAST_FORWARDING_STATUS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<WINHTTP_FAST_FORWARDING_STATUS>(),
            Is.EqualTo(sizeof(WINHTTP_FAST_FORWARDING_STATUS))
        );
    }

    /// <summary>Validates that the <see cref = "WINHTTP_FAST_FORWARDING_STATUS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WINHTTP_FAST_FORWARDING_STATUS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WINHTTP_FAST_FORWARDING_STATUS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WINHTTP_FAST_FORWARDING_STATUS), Is.EqualTo(24));
    }
}
