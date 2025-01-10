// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "WINHTTP_REQUEST_STATS"/> struct.</summary>
[SupportedOSPlatform("windows10.0.18362.0")]
public static unsafe partial class WINHTTP_REQUEST_STATSTests
{
    /// <summary>Validates that the <see cref = "WINHTTP_REQUEST_STATS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<WINHTTP_REQUEST_STATS>(),
            Is.EqualTo(sizeof(WINHTTP_REQUEST_STATS))
        );
    }

    /// <summary>Validates that the <see cref = "WINHTTP_REQUEST_STATS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WINHTTP_REQUEST_STATS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WINHTTP_REQUEST_STATS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WINHTTP_REQUEST_STATS), Is.EqualTo(272));
    }
}
