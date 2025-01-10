// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DXCoreAdapterEngineIndex"/> struct.</summary>
public static unsafe partial class DXCoreAdapterEngineIndexTests
{
    /// <summary>Validates that the <see cref = "DXCoreAdapterEngineIndex"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DXCoreAdapterEngineIndex>(),
            Is.EqualTo(sizeof(DXCoreAdapterEngineIndex))
        );
    }

    /// <summary>Validates that the <see cref = "DXCoreAdapterEngineIndex"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXCoreAdapterEngineIndex).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXCoreAdapterEngineIndex"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DXCoreAdapterEngineIndex), Is.EqualTo(8));
    }
}
