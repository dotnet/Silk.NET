// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "ISwapChainPanelNative2"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class ISwapChainPanelNative2Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISwapChainPanelNative2"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISwapChainPanelNative2).GUID, Is.EqualTo(IID_ISwapChainPanelNative2));
    }

    /// <summary>Validates that the <see cref = "ISwapChainPanelNative2"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISwapChainPanelNative2>(), Is.EqualTo(sizeof(ISwapChainPanelNative2)));
    }

    /// <summary>Validates that the <see cref = "ISwapChainPanelNative2"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISwapChainPanelNative2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISwapChainPanelNative2"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISwapChainPanelNative2), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISwapChainPanelNative2), Is.EqualTo(4));
        }
    }
}