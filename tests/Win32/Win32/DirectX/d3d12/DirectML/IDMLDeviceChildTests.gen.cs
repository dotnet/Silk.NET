// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IDMLDeviceChild"/> struct.</summary>
public static unsafe partial class IDMLDeviceChildTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDMLDeviceChild"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDMLDeviceChild).GUID, Is.EqualTo(IID_IDMLDeviceChild));
    }

    /// <summary>Validates that the <see cref = "IDMLDeviceChild"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDMLDeviceChild>(), Is.EqualTo(sizeof(IDMLDeviceChild)));
    }

    /// <summary>Validates that the <see cref = "IDMLDeviceChild"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDMLDeviceChild).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDMLDeviceChild"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDMLDeviceChild), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDMLDeviceChild), Is.EqualTo(4));
        }
    }
}
