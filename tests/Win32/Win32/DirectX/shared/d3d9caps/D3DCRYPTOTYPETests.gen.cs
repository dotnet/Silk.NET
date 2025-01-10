// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.DirectX.D3DCRYPTOTYPE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3DCRYPTOTYPE"/> class.</summary>
public static partial class D3DCRYPTOTYPETests
{
    /// <summary>Validates that the value of the <see cref = "D3DCRYPTOTYPE_AES128_CTR"/> property is correct.</summary>

    [Test]
    public static void D3DCRYPTOTYPE_AES128_CTRTest()
    {
        Assert.That(
            D3DCRYPTOTYPE_AES128_CTR,
            Is.EqualTo(
                new Guid(0x9b6bd711, 0x4f74, 0x41c9, 0x9e, 0x7b, 0xb, 0xe2, 0xd7, 0xd9, 0x3b, 0x4f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DCRYPTOTYPE_PROPRIETARY"/> property is correct.</summary>

    [Test]
    public static void D3DCRYPTOTYPE_PROPRIETARYTest()
    {
        Assert.That(
            D3DCRYPTOTYPE_PROPRIETARY,
            Is.EqualTo(
                new Guid(0xab4e9afd, 0x1d1c, 0x46e6, 0xa7, 0x2f, 0x8, 0x69, 0x91, 0x7b, 0xd, 0xe8)
            )
        );
    }
}
