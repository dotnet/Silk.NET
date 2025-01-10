// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "WINHTTP_WEB_SOCKET_ASYNC_RESULT"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class WINHTTP_WEB_SOCKET_ASYNC_RESULTTests
{
    /// <summary>Validates that the <see cref = "WINHTTP_WEB_SOCKET_ASYNC_RESULT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<WINHTTP_WEB_SOCKET_ASYNC_RESULT>(),
            Is.EqualTo(sizeof(WINHTTP_WEB_SOCKET_ASYNC_RESULT))
        );
    }

    /// <summary>Validates that the <see cref = "WINHTTP_WEB_SOCKET_ASYNC_RESULT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WINHTTP_WEB_SOCKET_ASYNC_RESULT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WINHTTP_WEB_SOCKET_ASYNC_RESULT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WINHTTP_WEB_SOCKET_ASYNC_RESULT), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(WINHTTP_WEB_SOCKET_ASYNC_RESULT), Is.EqualTo(12));
        }
    }
}
