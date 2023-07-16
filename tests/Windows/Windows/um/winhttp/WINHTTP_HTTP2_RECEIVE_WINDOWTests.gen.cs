// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WINHTTP_HTTP2_RECEIVE_WINDOW"/> struct.</summary>
public static unsafe partial class WINHTTP_HTTP2_RECEIVE_WINDOWTests
{
    /// <summary>Validates that the <see cref = "WINHTTP_HTTP2_RECEIVE_WINDOW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WINHTTP_HTTP2_RECEIVE_WINDOW>(), Is.EqualTo(sizeof(WINHTTP_HTTP2_RECEIVE_WINDOW)));
    }

    /// <summary>Validates that the <see cref = "WINHTTP_HTTP2_RECEIVE_WINDOW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WINHTTP_HTTP2_RECEIVE_WINDOW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WINHTTP_HTTP2_RECEIVE_WINDOW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WINHTTP_HTTP2_RECEIVE_WINDOW), Is.EqualTo(8));
    }
}