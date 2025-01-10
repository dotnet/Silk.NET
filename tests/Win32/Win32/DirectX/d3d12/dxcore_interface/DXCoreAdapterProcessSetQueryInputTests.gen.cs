// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DXCoreAdapterProcessSetQueryInput"/> struct.</summary>
public static unsafe partial class DXCoreAdapterProcessSetQueryInputTests
{
    /// <summary>Validates that the <see cref = "DXCoreAdapterProcessSetQueryInput"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DXCoreAdapterProcessSetQueryInput>(),
            Is.EqualTo(sizeof(DXCoreAdapterProcessSetQueryInput))
        );
    }

    /// <summary>Validates that the <see cref = "DXCoreAdapterProcessSetQueryInput"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXCoreAdapterProcessSetQueryInput).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXCoreAdapterProcessSetQueryInput"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DXCoreAdapterProcessSetQueryInput), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(DXCoreAdapterProcessSetQueryInput), Is.EqualTo(8));
        }
    }
}
