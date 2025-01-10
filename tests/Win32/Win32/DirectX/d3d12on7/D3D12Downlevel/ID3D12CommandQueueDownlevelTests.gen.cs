// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12Downlevel in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "ID3D12CommandQueueDownlevel"/> struct.</summary>
public static unsafe partial class ID3D12CommandQueueDownlevelTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID3D12CommandQueueDownlevel"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(ID3D12CommandQueueDownlevel).GUID,
            Is.EqualTo(IID_ID3D12CommandQueueDownlevel)
        );
    }

    /// <summary>Validates that the <see cref = "ID3D12CommandQueueDownlevel"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ID3D12CommandQueueDownlevel>(),
            Is.EqualTo(sizeof(ID3D12CommandQueueDownlevel))
        );
    }

    /// <summary>Validates that the <see cref = "ID3D12CommandQueueDownlevel"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3D12CommandQueueDownlevel).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID3D12CommandQueueDownlevel"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3D12CommandQueueDownlevel), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3D12CommandQueueDownlevel), Is.EqualTo(4));
        }
    }
}
