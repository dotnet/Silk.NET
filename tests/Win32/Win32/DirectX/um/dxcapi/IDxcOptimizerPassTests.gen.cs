// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IDxcOptimizerPass"/> struct.</summary>
public static unsafe partial class IDxcOptimizerPassTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDxcOptimizerPass"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcOptimizerPass).GUID, Is.EqualTo(IID_IDxcOptimizerPass));
    }

    /// <summary>Validates that the <see cref = "IDxcOptimizerPass"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcOptimizerPass>(), Is.EqualTo(sizeof(IDxcOptimizerPass)));
    }

    /// <summary>Validates that the <see cref = "IDxcOptimizerPass"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcOptimizerPass).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDxcOptimizerPass"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcOptimizerPass), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcOptimizerPass), Is.EqualTo(4));
        }
    }
}
