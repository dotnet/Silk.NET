// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Windows.Graphics.Capture.Interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IGraphicsCaptureItemInterop"/> struct.</summary>
[SupportedOSPlatform("windows10.0.19043.0")]
public static unsafe partial class IGraphicsCaptureItemInteropTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IGraphicsCaptureItemInterop"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IGraphicsCaptureItemInterop).GUID,
            Is.EqualTo(IID_IGraphicsCaptureItemInterop)
        );
    }

    /// <summary>Validates that the <see cref = "IGraphicsCaptureItemInterop"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IGraphicsCaptureItemInterop>(),
            Is.EqualTo(sizeof(IGraphicsCaptureItemInterop))
        );
    }

    /// <summary>Validates that the <see cref = "IGraphicsCaptureItemInterop"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IGraphicsCaptureItemInterop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IGraphicsCaptureItemInterop"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IGraphicsCaptureItemInterop), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IGraphicsCaptureItemInterop), Is.EqualTo(4));
        }
    }
}
