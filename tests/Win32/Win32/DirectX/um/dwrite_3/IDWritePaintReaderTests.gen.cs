// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IDWritePaintReader"/> struct.</summary>
public static unsafe partial class IDWritePaintReaderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDWritePaintReader"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWritePaintReader).GUID, Is.EqualTo(IID_IDWritePaintReader));
    }

    /// <summary>Validates that the <see cref = "IDWritePaintReader"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWritePaintReader>(), Is.EqualTo(sizeof(IDWritePaintReader)));
    }

    /// <summary>Validates that the <see cref = "IDWritePaintReader"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWritePaintReader).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDWritePaintReader"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWritePaintReader), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWritePaintReader), Is.EqualTo(4));
        }
    }
}
