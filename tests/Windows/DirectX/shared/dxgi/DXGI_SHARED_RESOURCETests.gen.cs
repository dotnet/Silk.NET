// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DXGI_SHARED_RESOURCE"/> struct.</summary>
public static unsafe partial class DXGI_SHARED_RESOURCETests
{
    /// <summary>Validates that the <see cref = "DXGI_SHARED_RESOURCE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DXGI_SHARED_RESOURCE>(), Is.EqualTo(sizeof(DXGI_SHARED_RESOURCE)));
    }

    /// <summary>Validates that the <see cref = "DXGI_SHARED_RESOURCE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXGI_SHARED_RESOURCE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXGI_SHARED_RESOURCE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DXGI_SHARED_RESOURCE), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DXGI_SHARED_RESOURCE), Is.EqualTo(4));
        }
    }
}