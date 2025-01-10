// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IDXCoreAdapterFactory"/> property is correct.</summary>

    [Test]
    public static void IID_IDXCoreAdapterFactoryTest()
    {
        Assert.That(
            IID_IDXCoreAdapterFactory,
            Is.EqualTo(
                new Guid(0x78ee5945, 0xc36e, 0x4b13, 0xa6, 0x69, 0x00, 0x5d, 0xd1, 0x1c, 0x0f, 0x06)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXCoreAdapterFactory1"/> property is correct.</summary>

    [Test]
    public static void IID_IDXCoreAdapterFactory1Test()
    {
        Assert.That(
            IID_IDXCoreAdapterFactory1,
            Is.EqualTo(
                new Guid(0xd5682e19, 0x6d21, 0x401c, 0x82, 0x7a, 0x9a, 0x51, 0xa4, 0xea, 0x35, 0xd7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXCoreAdapterList"/> property is correct.</summary>

    [Test]
    public static void IID_IDXCoreAdapterListTest()
    {
        Assert.That(
            IID_IDXCoreAdapterList,
            Is.EqualTo(
                new Guid(0x526c7776, 0x40e9, 0x459b, 0xb7, 0x11, 0xf3, 0x2a, 0xd7, 0x6d, 0xfc, 0x28)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXCoreAdapter"/> property is correct.</summary>

    [Test]
    public static void IID_IDXCoreAdapterTest()
    {
        Assert.That(
            IID_IDXCoreAdapter,
            Is.EqualTo(
                new Guid(0xf0db4c7f, 0xfe5a, 0x42a2, 0xbd, 0x62, 0xf2, 0xa6, 0xcf, 0x6f, 0xc8, 0x3e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXCoreAdapter1"/> property is correct.</summary>

    [Test]
    public static void IID_IDXCoreAdapter1Test()
    {
        Assert.That(
            IID_IDXCoreAdapter1,
            Is.EqualTo(
                new Guid(0xa0783366, 0xcfa3, 0x43be, 0x9d, 0x79, 0x55, 0xb2, 0xda, 0x97, 0xc6, 0x3c)
            )
        );
    }
}
