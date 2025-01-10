// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3DLOCKED_RECT"/> struct.</summary>
public static unsafe partial class D3DLOCKED_RECTTests
{
    /// <summary>Validates that the <see cref = "D3DLOCKED_RECT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3DLOCKED_RECT>(), Is.EqualTo(sizeof(D3DLOCKED_RECT)));
    }

    /// <summary>Validates that the <see cref = "D3DLOCKED_RECT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3DLOCKED_RECT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3DLOCKED_RECT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3DLOCKED_RECT), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(D3DLOCKED_RECT), Is.EqualTo(8));
        }
    }
}
