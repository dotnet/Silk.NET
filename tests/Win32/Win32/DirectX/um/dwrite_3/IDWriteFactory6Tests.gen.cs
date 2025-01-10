// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IDWriteFactory6"/> struct.</summary>
[SupportedOSPlatform("windows10.0.19043.0")]
public static unsafe partial class IDWriteFactory6Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDWriteFactory6"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWriteFactory6).GUID, Is.EqualTo(IID_IDWriteFactory6));
    }

    /// <summary>Validates that the <see cref = "IDWriteFactory6"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWriteFactory6>(), Is.EqualTo(sizeof(IDWriteFactory6)));
    }

    /// <summary>Validates that the <see cref = "IDWriteFactory6"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWriteFactory6).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDWriteFactory6"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWriteFactory6), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWriteFactory6), Is.EqualTo(4));
        }
    }
}
