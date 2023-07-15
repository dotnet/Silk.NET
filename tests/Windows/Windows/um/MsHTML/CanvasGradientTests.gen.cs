// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CanvasGradient"/> struct.</summary>
public static unsafe partial class CanvasGradientTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "CanvasGradient"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(CanvasGradient).GUID, Is.EqualTo(IID_CanvasGradient));
    }

    /// <summary>Validates that the <see cref = "CanvasGradient"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CanvasGradient>(), Is.EqualTo(sizeof(CanvasGradient)));
    }

    /// <summary>Validates that the <see cref = "CanvasGradient"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CanvasGradient).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CanvasGradient"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CanvasGradient), Is.EqualTo(1));
    }
}