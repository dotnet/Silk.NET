// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12Downlevel in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D12CommandQueueDownlevel"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12CommandQueueDownlevelTest()
    {
        Assert.That(IID_ID3D12CommandQueueDownlevel, Is.EqualTo(new Guid(0x38a8c5ef, 0x7ccb, 0x4e81, 0x91, 0x4f, 0xa6, 0xe9, 0xd0, 0x72, 0xc4, 0x94)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12DeviceDownlevel"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12DeviceDownlevelTest()
    {
        Assert.That(IID_ID3D12DeviceDownlevel, Is.EqualTo(new Guid(0x74eaee3f, 0x2f4b, 0x476d, 0x82, 0xba, 0x2b, 0x85, 0xcb, 0x49, 0xe3, 0x10)));
    }
}