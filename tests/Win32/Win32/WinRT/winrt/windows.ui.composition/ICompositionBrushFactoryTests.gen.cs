// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ICompositionBrushFactory"/> struct.</summary>
public static unsafe partial class ICompositionBrushFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICompositionBrushFactory"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(ICompositionBrushFactory).GUID,
            Is.EqualTo(IID_ICompositionBrushFactory)
        );
    }

    /// <summary>Validates that the <see cref = "ICompositionBrushFactory"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ICompositionBrushFactory>(),
            Is.EqualTo(sizeof(ICompositionBrushFactory))
        );
    }

    /// <summary>Validates that the <see cref = "ICompositionBrushFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICompositionBrushFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICompositionBrushFactory"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICompositionBrushFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICompositionBrushFactory), Is.EqualTo(4));
        }
    }
}
