// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ICoreTextLayoutRequest"/> struct.</summary>
public static unsafe partial class ICoreTextLayoutRequestTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICoreTextLayoutRequest"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ICoreTextLayoutRequest).GUID, Is.EqualTo(IID_ICoreTextLayoutRequest));
    }

    /// <summary>Validates that the <see cref = "ICoreTextLayoutRequest"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ICoreTextLayoutRequest>(),
            Is.EqualTo(sizeof(ICoreTextLayoutRequest))
        );
    }

    /// <summary>Validates that the <see cref = "ICoreTextLayoutRequest"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICoreTextLayoutRequest).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICoreTextLayoutRequest"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICoreTextLayoutRequest), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICoreTextLayoutRequest), Is.EqualTo(4));
        }
    }
}
