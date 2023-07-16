// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDxcIncludeHandler"/> struct.</summary>
public static unsafe partial class IDxcIncludeHandlerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDxcIncludeHandler"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDxcIncludeHandler).GUID, Is.EqualTo(IID_IDxcIncludeHandler));
    }

    /// <summary>Validates that the <see cref = "IDxcIncludeHandler"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDxcIncludeHandler>(), Is.EqualTo(sizeof(IDxcIncludeHandler)));
    }

    /// <summary>Validates that the <see cref = "IDxcIncludeHandler"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDxcIncludeHandler).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDxcIncludeHandler"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDxcIncludeHandler), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDxcIncludeHandler), Is.EqualTo(4));
        }
    }
}