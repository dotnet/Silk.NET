// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DXGI_DISPLAY_COLOR_SPACE"/> struct.</summary>
public static unsafe partial class DXGI_DISPLAY_COLOR_SPACETests
{
    /// <summary>Validates that the <see cref = "DXGI_DISPLAY_COLOR_SPACE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DXGI_DISPLAY_COLOR_SPACE>(),
            Is.EqualTo(sizeof(DXGI_DISPLAY_COLOR_SPACE))
        );
    }

    /// <summary>Validates that the <see cref = "DXGI_DISPLAY_COLOR_SPACE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXGI_DISPLAY_COLOR_SPACE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXGI_DISPLAY_COLOR_SPACE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DXGI_DISPLAY_COLOR_SPACE), Is.EqualTo(192));
    }
}
