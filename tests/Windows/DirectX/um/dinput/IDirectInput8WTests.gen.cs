// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDirectInput8W"/> struct.</summary>
public static unsafe partial class IDirectInput8WTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDirectInput8W"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDirectInput8W).GUID, Is.EqualTo(IID_IDirectInput8W));
    }

    /// <summary>Validates that the <see cref = "IDirectInput8W"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDirectInput8W>(), Is.EqualTo(sizeof(IDirectInput8W)));
    }

    /// <summary>Validates that the <see cref = "IDirectInput8W"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDirectInput8W).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDirectInput8W"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDirectInput8W), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDirectInput8W), Is.EqualTo(4));
        }
    }
}