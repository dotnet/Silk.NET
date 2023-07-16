// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DXGI_QUERY_VIDEO_MEMORY_INFO"/> struct.</summary>
public static unsafe partial class DXGI_QUERY_VIDEO_MEMORY_INFOTests
{
    /// <summary>Validates that the <see cref = "DXGI_QUERY_VIDEO_MEMORY_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DXGI_QUERY_VIDEO_MEMORY_INFO>(), Is.EqualTo(sizeof(DXGI_QUERY_VIDEO_MEMORY_INFO)));
    }

    /// <summary>Validates that the <see cref = "DXGI_QUERY_VIDEO_MEMORY_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXGI_QUERY_VIDEO_MEMORY_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXGI_QUERY_VIDEO_MEMORY_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DXGI_QUERY_VIDEO_MEMORY_INFO), Is.EqualTo(32));
    }
}