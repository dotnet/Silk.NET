// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "HTTP_QUIC_CONNECTION_API_TIMINGS"/> struct.</summary>
public static unsafe partial class HTTP_QUIC_CONNECTION_API_TIMINGSTests
{
    /// <summary>Validates that the <see cref = "HTTP_QUIC_CONNECTION_API_TIMINGS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<HTTP_QUIC_CONNECTION_API_TIMINGS>(),
            Is.EqualTo(sizeof(HTTP_QUIC_CONNECTION_API_TIMINGS))
        );
    }

    /// <summary>Validates that the <see cref = "HTTP_QUIC_CONNECTION_API_TIMINGS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTTP_QUIC_CONNECTION_API_TIMINGS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTTP_QUIC_CONNECTION_API_TIMINGS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTTP_QUIC_CONNECTION_API_TIMINGS), Is.EqualTo(240));
    }
}
