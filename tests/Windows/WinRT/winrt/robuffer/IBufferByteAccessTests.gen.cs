// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/robuffer.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IBufferByteAccess"/> struct.</summary>
public static unsafe partial class IBufferByteAccessTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IBufferByteAccess"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IBufferByteAccess).GUID, Is.EqualTo(IID_IBufferByteAccess));
    }

    /// <summary>Validates that the <see cref = "IBufferByteAccess"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IBufferByteAccess>(), Is.EqualTo(sizeof(IBufferByteAccess)));
    }

    /// <summary>Validates that the <see cref = "IBufferByteAccess"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IBufferByteAccess).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IBufferByteAccess"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IBufferByteAccess), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IBufferByteAccess), Is.EqualTo(4));
        }
    }
}