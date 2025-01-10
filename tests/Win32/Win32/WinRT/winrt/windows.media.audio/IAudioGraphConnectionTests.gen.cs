// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IAudioGraphConnection"/> struct.</summary>
public static unsafe partial class IAudioGraphConnectionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAudioGraphConnection"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAudioGraphConnection).GUID, Is.EqualTo(IID_IAudioGraphConnection));
    }

    /// <summary>Validates that the <see cref = "IAudioGraphConnection"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IAudioGraphConnection>(),
            Is.EqualTo(sizeof(IAudioGraphConnection))
        );
    }

    /// <summary>Validates that the <see cref = "IAudioGraphConnection"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAudioGraphConnection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAudioGraphConnection"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAudioGraphConnection), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAudioGraphConnection), Is.EqualTo(4));
        }
    }
}
