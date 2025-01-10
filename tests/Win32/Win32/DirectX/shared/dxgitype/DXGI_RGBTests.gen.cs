// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DXGI_RGB"/> struct.</summary>
public static unsafe partial class DXGI_RGBTests
{
    /// <summary>Validates that the <see cref = "DXGI_RGB"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DXGI_RGB>(), Is.EqualTo(sizeof(DXGI_RGB)));
    }

    /// <summary>Validates that the <see cref = "DXGI_RGB"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXGI_RGB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXGI_RGB"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DXGI_RGB), Is.EqualTo(12));
    }
}
