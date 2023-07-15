// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDMLDevice"/> struct.</summary>
public static unsafe partial class IDMLDeviceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDMLDevice"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDMLDevice).GUID, Is.EqualTo(IID_IDMLDevice));
    }

    /// <summary>Validates that the <see cref = "IDMLDevice"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDMLDevice>(), Is.EqualTo(sizeof(IDMLDevice)));
    }

    /// <summary>Validates that the <see cref = "IDMLDevice"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDMLDevice).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDMLDevice"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDMLDevice), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDMLDevice), Is.EqualTo(4));
        }
    }
}