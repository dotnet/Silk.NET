// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DXGI_INFO_QUEUE_FILTER"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class DXGI_INFO_QUEUE_FILTERTests
{
    /// <summary>Validates that the <see cref = "DXGI_INFO_QUEUE_FILTER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DXGI_INFO_QUEUE_FILTER>(), Is.EqualTo(sizeof(DXGI_INFO_QUEUE_FILTER)));
    }

    /// <summary>Validates that the <see cref = "DXGI_INFO_QUEUE_FILTER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXGI_INFO_QUEUE_FILTER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DXGI_INFO_QUEUE_FILTER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DXGI_INFO_QUEUE_FILTER), Is.EqualTo(96));
        }
        else
        {
            Assert.That(sizeof(DXGI_INFO_QUEUE_FILTER), Is.EqualTo(48));
        }
    }
}