// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IDXGIDevice3"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIDevice3Test()
    {
        Assert.That(
            IID_IDXGIDevice3,
            Is.EqualTo(
                new Guid(0x6007896c, 0x3244, 0x4afd, 0xbf, 0x18, 0xa6, 0xd3, 0xbe, 0xda, 0x50, 0x23)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGISwapChain2"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGISwapChain2Test()
    {
        Assert.That(
            IID_IDXGISwapChain2,
            Is.EqualTo(
                new Guid(0xa8be2ac4, 0x199f, 0x4946, 0xb3, 0x31, 0x79, 0x59, 0x9f, 0xb9, 0x8d, 0xe7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIOutput2"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIOutput2Test()
    {
        Assert.That(
            IID_IDXGIOutput2,
            Is.EqualTo(
                new Guid(0x595e39d1, 0x2724, 0x4663, 0x99, 0xb1, 0xda, 0x96, 0x9d, 0xe2, 0x83, 0x64)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIFactory3"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIFactory3Test()
    {
        Assert.That(
            IID_IDXGIFactory3,
            Is.EqualTo(
                new Guid(0x25483823, 0xcd46, 0x4c7d, 0x86, 0xca, 0x47, 0xaa, 0x95, 0xb8, 0x37, 0xbd)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIDecodeSwapChain"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIDecodeSwapChainTest()
    {
        Assert.That(
            IID_IDXGIDecodeSwapChain,
            Is.EqualTo(
                new Guid(0x2633066b, 0x4514, 0x4c7a, 0x8f, 0xd8, 0x12, 0xea, 0x98, 0x05, 0x9d, 0x18)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIFactoryMedia"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIFactoryMediaTest()
    {
        Assert.That(
            IID_IDXGIFactoryMedia,
            Is.EqualTo(
                new Guid(0x41e7d1f2, 0xa591, 0x4f7b, 0xa2, 0xe5, 0xfa, 0x9c, 0x84, 0x3e, 0x1c, 0x12)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGISwapChainMedia"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGISwapChainMediaTest()
    {
        Assert.That(
            IID_IDXGISwapChainMedia,
            Is.EqualTo(
                new Guid(0xdd95b90b, 0xf05f, 0x4f6a, 0xbd, 0x65, 0x25, 0xbf, 0xb2, 0x64, 0xbd, 0x84)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIOutput3"/> property is correct.</summary>

    [Test]
    public static void IID_IDXGIOutput3Test()
    {
        Assert.That(
            IID_IDXGIOutput3,
            Is.EqualTo(
                new Guid(0x8a6bb301, 0x7e7e, 0x41F4, 0xa8, 0xe0, 0x5b, 0x32, 0xf7, 0xf9, 0x9b, 0x18)
            )
        );
    }
}
