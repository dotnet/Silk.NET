// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDCompositionRotateTransform"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IDCompositionRotateTransformTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDCompositionRotateTransform"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDCompositionRotateTransform).GUID, Is.EqualTo(IID_IDCompositionRotateTransform));
    }

    /// <summary>Validates that the <see cref = "IDCompositionRotateTransform"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDCompositionRotateTransform>(), Is.EqualTo(sizeof(IDCompositionRotateTransform)));
    }

    /// <summary>Validates that the <see cref = "IDCompositionRotateTransform"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDCompositionRotateTransform).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDCompositionRotateTransform"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDCompositionRotateTransform), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDCompositionRotateTransform), Is.EqualTo(4));
        }
    }
}