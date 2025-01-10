// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3DOVERLAYCAPS"/> struct.</summary>
public static unsafe partial class D3DOVERLAYCAPSTests
{
    /// <summary>Validates that the <see cref = "D3DOVERLAYCAPS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3DOVERLAYCAPS>(), Is.EqualTo(sizeof(D3DOVERLAYCAPS)));
    }

    /// <summary>Validates that the <see cref = "D3DOVERLAYCAPS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3DOVERLAYCAPS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3DOVERLAYCAPS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3DOVERLAYCAPS), Is.EqualTo(12));
    }
}
