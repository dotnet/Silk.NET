// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DDBLTFX"/> struct.</summary>
public static unsafe partial class DDBLTFXTests
{
    /// <summary>Validates that the <see cref = "DDBLTFX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DDBLTFX>(), Is.EqualTo(sizeof(DDBLTFX)));
    }

    /// <summary>Validates that the <see cref = "DDBLTFX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DDBLTFX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DDBLTFX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DDBLTFX), Is.EqualTo(128));
        }
        else
        {
            Assert.That(sizeof(DDBLTFX), Is.EqualTo(100));
        }
    }
}