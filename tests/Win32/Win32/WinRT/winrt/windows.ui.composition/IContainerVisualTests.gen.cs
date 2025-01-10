// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IContainerVisual"/> struct.</summary>
public static unsafe partial class IContainerVisualTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IContainerVisual"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IContainerVisual).GUID, Is.EqualTo(IID_IContainerVisual));
    }

    /// <summary>Validates that the <see cref = "IContainerVisual"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IContainerVisual>(), Is.EqualTo(sizeof(IContainerVisual)));
    }

    /// <summary>Validates that the <see cref = "IContainerVisual"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IContainerVisual).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IContainerVisual"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IContainerVisual), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IContainerVisual), Is.EqualTo(4));
        }
    }
}
