// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IDxcBlob"/> struct.</summary>
public static unsafe partial class IDxcBlobTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDxcBlob"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcBlob).GUID, Is.EqualTo(IID_IDxcBlob));
    }

    /// <summary>Validates that the <see cref = "IDxcBlob"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcBlob>(), Is.EqualTo(sizeof(IDxcBlob)));
    }

    /// <summary>Validates that the <see cref = "IDxcBlob"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcBlob).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDxcBlob"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcBlob), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcBlob), Is.EqualTo(4));
        }
    }
}
