// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using NUnit.Framework;
using static Silk.NET.DirectX.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DirectX"/> class.</summary>
public static partial class DirectXTests
{
    /// <summary>Validates that the value of the <see cref = "WKPDID_D3DAutoDebugObjectNameW"/> property is correct.</summary>

    [Test]
    public static void WKPDID_D3DAutoDebugObjectNameWTest()
    {
        Assert.That(
            WKPDID_D3DAutoDebugObjectNameW,
            Is.EqualTo(
                new Guid(0xd4902e36, 0x757a, 0x4942, 0x95, 0x94, 0xb6, 0x76, 0x9a, 0xfa, 0x43, 0xcd)
            )
        );
    }
}
