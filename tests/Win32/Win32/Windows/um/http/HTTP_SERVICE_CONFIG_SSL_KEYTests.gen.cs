// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "HTTP_SERVICE_CONFIG_SSL_KEY"/> struct.</summary>
public static unsafe partial class HTTP_SERVICE_CONFIG_SSL_KEYTests
{
    /// <summary>Validates that the <see cref = "HTTP_SERVICE_CONFIG_SSL_KEY"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<HTTP_SERVICE_CONFIG_SSL_KEY>(),
            Is.EqualTo(sizeof(HTTP_SERVICE_CONFIG_SSL_KEY))
        );
    }

    /// <summary>Validates that the <see cref = "HTTP_SERVICE_CONFIG_SSL_KEY"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTTP_SERVICE_CONFIG_SSL_KEY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTTP_SERVICE_CONFIG_SSL_KEY"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(HTTP_SERVICE_CONFIG_SSL_KEY), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(HTTP_SERVICE_CONFIG_SSL_KEY), Is.EqualTo(4));
        }
    }
}
