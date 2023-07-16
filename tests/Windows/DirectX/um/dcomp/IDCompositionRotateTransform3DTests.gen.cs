// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDCompositionRotateTransform3D"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IDCompositionRotateTransform3DTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDCompositionRotateTransform3D"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDCompositionRotateTransform3D).GUID, Is.EqualTo(IID_IDCompositionRotateTransform3D));
    }

    /// <summary>Validates that the <see cref = "IDCompositionRotateTransform3D"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDCompositionRotateTransform3D>(), Is.EqualTo(sizeof(IDCompositionRotateTransform3D)));
    }

    /// <summary>Validates that the <see cref = "IDCompositionRotateTransform3D"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDCompositionRotateTransform3D).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDCompositionRotateTransform3D"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDCompositionRotateTransform3D), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDCompositionRotateTransform3D), Is.EqualTo(4));
        }
    }
}