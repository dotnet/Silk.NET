// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "WS_REQUEST_SECURITY_TOKEN_PROPERTY_CONSTRAINT"/> struct.</summary>
public static unsafe partial class WS_REQUEST_SECURITY_TOKEN_PROPERTY_CONSTRAINTTests
{
    /// <summary>Validates that the <see cref = "WS_REQUEST_SECURITY_TOKEN_PROPERTY_CONSTRAINT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<WS_REQUEST_SECURITY_TOKEN_PROPERTY_CONSTRAINT>(),
            Is.EqualTo(sizeof(WS_REQUEST_SECURITY_TOKEN_PROPERTY_CONSTRAINT))
        );
    }

    /// <summary>Validates that the <see cref = "WS_REQUEST_SECURITY_TOKEN_PROPERTY_CONSTRAINT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(WS_REQUEST_SECURITY_TOKEN_PROPERTY_CONSTRAINT).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "WS_REQUEST_SECURITY_TOKEN_PROPERTY_CONSTRAINT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WS_REQUEST_SECURITY_TOKEN_PROPERTY_CONSTRAINT), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(WS_REQUEST_SECURITY_TOKEN_PROPERTY_CONSTRAINT), Is.EqualTo(24));
        }
    }
}
