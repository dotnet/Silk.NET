// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3D10_COUNTER_INFO"/> struct.</summary>
public static unsafe partial class D3D10_COUNTER_INFOTests
{
    /// <summary>Validates that the <see cref = "D3D10_COUNTER_INFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D10_COUNTER_INFO>(), Is.EqualTo(sizeof(D3D10_COUNTER_INFO)));
    }

    /// <summary>Validates that the <see cref = "D3D10_COUNTER_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D10_COUNTER_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D10_COUNTER_INFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D10_COUNTER_INFO), Is.EqualTo(12));
    }
}
