// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.effects.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IGraphicsEffectD2D1Interop"/> struct.</summary>
public static unsafe partial class IGraphicsEffectD2D1InteropTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IGraphicsEffectD2D1Interop"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IGraphicsEffectD2D1Interop).GUID, Is.EqualTo(IID_IGraphicsEffectD2D1Interop));
    }

    /// <summary>Validates that the <see cref = "IGraphicsEffectD2D1Interop"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IGraphicsEffectD2D1Interop>(), Is.EqualTo(sizeof(IGraphicsEffectD2D1Interop)));
    }

    /// <summary>Validates that the <see cref = "IGraphicsEffectD2D1Interop"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IGraphicsEffectD2D1Interop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IGraphicsEffectD2D1Interop"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IGraphicsEffectD2D1Interop), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IGraphicsEffectD2D1Interop), Is.EqualTo(4));
        }
    }
}