// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DXGI_HDR_METADATA_HDR10PLUS"/> struct.</summary>
public static unsafe partial class DXGI_HDR_METADATA_HDR10PLUSTests
{
    /// <summary>Validates that the <see cref = "DXGI_HDR_METADATA_HDR10PLUS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DXGI_HDR_METADATA_HDR10PLUS>(), Is.EqualTo(sizeof(DXGI_HDR_METADATA_HDR10PLUS)));
    }

    /// <summary>Validates that the <see cref = "DXGI_HDR_METADATA_HDR10PLUS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXGI_HDR_METADATA_HDR10PLUS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXGI_HDR_METADATA_HDR10PLUS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DXGI_HDR_METADATA_HDR10PLUS), Is.EqualTo(72));
    }
}