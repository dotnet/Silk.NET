// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDirectDrawPalette"/> struct.</summary>
public static unsafe partial class IDirectDrawPaletteTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDirectDrawPalette"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDirectDrawPalette).GUID, Is.EqualTo(IID_IDirectDrawPalette));
    }

    /// <summary>Validates that the <see cref = "IDirectDrawPalette"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDirectDrawPalette>(), Is.EqualTo(sizeof(IDirectDrawPalette)));
    }

    /// <summary>Validates that the <see cref = "IDirectDrawPalette"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDirectDrawPalette).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDirectDrawPalette"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDirectDrawPalette), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDirectDrawPalette), Is.EqualTo(4));
        }
    }
}