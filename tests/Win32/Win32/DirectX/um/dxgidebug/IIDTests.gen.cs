// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IDXGIInfoQueue"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIInfoQueueTest()
    {
        Assert.That(
            IID_IDXGIInfoQueue,
            Is.EqualTo(
                new Guid(0xD67441C7, 0x672A, 0x476f, 0x9E, 0x82, 0xCD, 0x55, 0xB4, 0x49, 0x49, 0xCE)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIDebug"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIDebugTest()
    {
        Assert.That(
            IID_IDXGIDebug,
            Is.EqualTo(
                new Guid(0x119E7452, 0xDE9E, 0x40fe, 0x88, 0x06, 0x88, 0xF9, 0x0C, 0x12, 0xB4, 0x41)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIDebug1"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIDebug1Test()
    {
        Assert.That(
            IID_IDXGIDebug1,
            Is.EqualTo(
                new Guid(0xc5a05f0c, 0x16f2, 0x4adf, 0x9f, 0x4d, 0xa8, 0xc4, 0xd5, 0x8a, 0xc5, 0x50)
            )
        );
    }
}
