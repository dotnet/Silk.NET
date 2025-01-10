// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ICompositionMipmapSurface"/> struct.</summary>
public static unsafe partial class ICompositionMipmapSurfaceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICompositionMipmapSurface"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(ICompositionMipmapSurface).GUID,
            Is.EqualTo(IID_ICompositionMipmapSurface)
        );
    }

    /// <summary>Validates that the <see cref = "ICompositionMipmapSurface"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ICompositionMipmapSurface>(),
            Is.EqualTo(sizeof(ICompositionMipmapSurface))
        );
    }

    /// <summary>Validates that the <see cref = "ICompositionMipmapSurface"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICompositionMipmapSurface).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICompositionMipmapSurface"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICompositionMipmapSurface), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICompositionMipmapSurface), Is.EqualTo(4));
        }
    }
}
