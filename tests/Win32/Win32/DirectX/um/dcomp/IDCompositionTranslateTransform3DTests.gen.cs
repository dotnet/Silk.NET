// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IDCompositionTranslateTransform3D"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IDCompositionTranslateTransform3DTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDCompositionTranslateTransform3D"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IDCompositionTranslateTransform3D).GUID,
            Is.EqualTo(IID_IDCompositionTranslateTransform3D)
        );
    }

    /// <summary>Validates that the <see cref = "IDCompositionTranslateTransform3D"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IDCompositionTranslateTransform3D>(),
            Is.EqualTo(sizeof(IDCompositionTranslateTransform3D))
        );
    }

    /// <summary>Validates that the <see cref = "IDCompositionTranslateTransform3D"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDCompositionTranslateTransform3D).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDCompositionTranslateTransform3D"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDCompositionTranslateTransform3D), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDCompositionTranslateTransform3D), Is.EqualTo(4));
        }
    }
}
