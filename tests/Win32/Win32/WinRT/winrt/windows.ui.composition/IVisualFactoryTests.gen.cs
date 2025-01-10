// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IVisualFactory"/> struct.</summary>
public static unsafe partial class IVisualFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IVisualFactory"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IVisualFactory).GUID, Is.EqualTo(IID_IVisualFactory));
    }

    /// <summary>Validates that the <see cref = "IVisualFactory"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IVisualFactory>(), Is.EqualTo(sizeof(IVisualFactory)));
    }

    /// <summary>Validates that the <see cref = "IVisualFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IVisualFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IVisualFactory"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IVisualFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IVisualFactory), Is.EqualTo(4));
        }
    }
}
