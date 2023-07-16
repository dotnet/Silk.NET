// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDirectInput7W"/> struct.</summary>
public static unsafe partial class IDirectInput7WTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDirectInput7W"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDirectInput7W).GUID, Is.EqualTo(IID_IDirectInput7W));
    }

    /// <summary>Validates that the <see cref = "IDirectInput7W"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDirectInput7W>(), Is.EqualTo(sizeof(IDirectInput7W)));
    }

    /// <summary>Validates that the <see cref = "IDirectInput7W"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDirectInput7W).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDirectInput7W"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDirectInput7W), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDirectInput7W), Is.EqualTo(4));
        }
    }
}