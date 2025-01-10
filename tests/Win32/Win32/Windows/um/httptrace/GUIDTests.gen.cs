// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httptrace.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.GUID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "GUID"/> class.</summary>
public static partial class GUIDTests
{
    /// <summary>Validates that the value of the <see cref = "GUID_IIS_ALL_TRACE_PROVIDERS"/> property is correct.</summary>

    [Test]
    public static void GUID_IIS_ALL_TRACE_PROVIDERSTest()
    {
        Assert.That(
            GUID_IIS_ALL_TRACE_PROVIDERS,
            Is.EqualTo(
                new Guid(0x00000000, 0x0000, 0x0000, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_IIS_WWW_SERVER_TRACE_PROVIDER"/> property is correct.</summary>

    [Test]
    public static void GUID_IIS_WWW_SERVER_TRACE_PROVIDERTest()
    {
        Assert.That(
            GUID_IIS_WWW_SERVER_TRACE_PROVIDER,
            Is.EqualTo(
                new Guid(0x3a2a4e84, 0x4c21, 0x4981, 0xae, 0x10, 0x3f, 0xda, 0x0d, 0x9b, 0x0f, 0x83)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_IIS_WWW_SERVER_V2_TRACE_PROVIDER"/> property is correct.</summary>

    [Test]
    public static void GUID_IIS_WWW_SERVER_V2_TRACE_PROVIDERTest()
    {
        Assert.That(
            GUID_IIS_WWW_SERVER_V2_TRACE_PROVIDER,
            Is.EqualTo(
                new Guid(0xde4649c9, 0x15e8, 0x4fea, 0x9d, 0x85, 0x1c, 0xdd, 0xa5, 0x20, 0xc3, 0x34)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_IIS_ASPNET_TRACE_PROVIDER"/> property is correct.</summary>

    [Test]
    public static void GUID_IIS_ASPNET_TRACE_PROVIDERTest()
    {
        Assert.That(
            GUID_IIS_ASPNET_TRACE_PROVIDER,
            Is.EqualTo(
                new Guid(0xAFF081FE, 0x0247, 0x4275, 0x9C, 0x4E, 0x02, 0x1F, 0x3D, 0xC1, 0xDA, 0x35)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_IIS_ASP_TRACE_TRACE_PROVIDER"/> property is correct.</summary>

    [Test]
    public static void GUID_IIS_ASP_TRACE_TRACE_PROVIDERTest()
    {
        Assert.That(
            GUID_IIS_ASP_TRACE_TRACE_PROVIDER,
            Is.EqualTo(
                new Guid(0x06b94d9a, 0xb15e, 0x456e, 0xa4, 0xef, 0x37, 0xc9, 0x84, 0xa2, 0xcb, 0x4b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_IIS_WWW_GLOBAL_TRACE_PROVIDER"/> property is correct.</summary>

    [Test]
    public static void GUID_IIS_WWW_GLOBAL_TRACE_PROVIDERTest()
    {
        Assert.That(
            GUID_IIS_WWW_GLOBAL_TRACE_PROVIDER,
            Is.EqualTo(
                new Guid(0xd55d3bc9, 0xcba9, 0x44df, 0x82, 0x7e, 0x13, 0x2d, 0x3a, 0x45, 0x96, 0xc2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "GUID_IIS_ISAPI_TRACE_PROVIDER"/> property is correct.</summary>

    [Test]
    public static void GUID_IIS_ISAPI_TRACE_PROVIDERTest()
    {
        Assert.That(
            GUID_IIS_ISAPI_TRACE_PROVIDER,
            Is.EqualTo(
                new Guid(0xa1c2040e, 0x8840, 0x4c31, 0xba, 0x11, 0x98, 0x71, 0x03, 0x1a, 0x19, 0xea)
            )
        );
    }
}
