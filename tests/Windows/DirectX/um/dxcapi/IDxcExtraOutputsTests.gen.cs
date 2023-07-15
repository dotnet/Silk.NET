// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDxcExtraOutputs"/> struct.</summary>
public static unsafe partial class IDxcExtraOutputsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDxcExtraOutputs"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcExtraOutputs).GUID, Is.EqualTo(IID_IDxcExtraOutputs));
    }

    /// <summary>Validates that the <see cref = "IDxcExtraOutputs"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcExtraOutputs>(), Is.EqualTo(sizeof(IDxcExtraOutputs)));
    }

    /// <summary>Validates that the <see cref = "IDxcExtraOutputs"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcExtraOutputs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDxcExtraOutputs"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcExtraOutputs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcExtraOutputs), Is.EqualTo(4));
        }
    }
}