// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IProcessAudioFrameContext"/> struct.</summary>
public static unsafe partial class IProcessAudioFrameContextTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IProcessAudioFrameContext"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IProcessAudioFrameContext).GUID,
            Is.EqualTo(IID_IProcessAudioFrameContext)
        );
    }

    /// <summary>Validates that the <see cref = "IProcessAudioFrameContext"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IProcessAudioFrameContext>(),
            Is.EqualTo(sizeof(IProcessAudioFrameContext))
        );
    }

    /// <summary>Validates that the <see cref = "IProcessAudioFrameContext"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IProcessAudioFrameContext).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IProcessAudioFrameContext"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IProcessAudioFrameContext), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IProcessAudioFrameContext), Is.EqualTo(4));
        }
    }
}
