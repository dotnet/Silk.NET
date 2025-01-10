// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IDirectInput8A"/> struct.</summary>
public static unsafe partial class IDirectInput8ATests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDirectInput8A"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDirectInput8A).GUID, Is.EqualTo(IID_IDirectInput8A));
    }

    /// <summary>Validates that the <see cref = "IDirectInput8A"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDirectInput8A>(), Is.EqualTo(sizeof(IDirectInput8A)));
    }

    /// <summary>Validates that the <see cref = "IDirectInput8A"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDirectInput8A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDirectInput8A"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDirectInput8A), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDirectInput8A), Is.EqualTo(4));
        }
    }
}
