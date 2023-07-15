// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.media.core.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IVideoFrameNativeFactory"/> struct.</summary>
public static unsafe partial class IVideoFrameNativeFactoryTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IVideoFrameNativeFactory"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IVideoFrameNativeFactory).GUID, Is.EqualTo(IID_IVideoFrameNativeFactory));
    }

    /// <summary>Validates that the <see cref = "IVideoFrameNativeFactory"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IVideoFrameNativeFactory>(), Is.EqualTo(sizeof(IVideoFrameNativeFactory)));
    }

    /// <summary>Validates that the <see cref = "IVideoFrameNativeFactory"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IVideoFrameNativeFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IVideoFrameNativeFactory"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IVideoFrameNativeFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IVideoFrameNativeFactory), Is.EqualTo(4));
        }
    }
}