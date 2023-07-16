// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.media.core.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IAudioFrameNative"/> struct.</summary>
public static unsafe partial class IAudioFrameNativeTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAudioFrameNative"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAudioFrameNative).GUID, Is.EqualTo(IID_IAudioFrameNative));
    }

    /// <summary>Validates that the <see cref = "IAudioFrameNative"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAudioFrameNative>(), Is.EqualTo(sizeof(IAudioFrameNative)));
    }

    /// <summary>Validates that the <see cref = "IAudioFrameNative"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAudioFrameNative).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAudioFrameNative"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAudioFrameNative), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAudioFrameNative), Is.EqualTo(4));
        }
    }
}