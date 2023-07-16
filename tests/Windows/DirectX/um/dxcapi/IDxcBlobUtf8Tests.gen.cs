// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDxcBlobUtf8"/> struct.</summary>
public static unsafe partial class IDxcBlobUtf8Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDxcBlobUtf8"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcBlobUtf8).GUID, Is.EqualTo(IID_IDxcBlobUtf8));
    }

    /// <summary>Validates that the <see cref = "IDxcBlobUtf8"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcBlobUtf8>(), Is.EqualTo(sizeof(IDxcBlobUtf8)));
    }

    /// <summary>Validates that the <see cref = "IDxcBlobUtf8"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcBlobUtf8).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDxcBlobUtf8"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcBlobUtf8), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcBlobUtf8), Is.EqualTo(4));
        }
    }
}