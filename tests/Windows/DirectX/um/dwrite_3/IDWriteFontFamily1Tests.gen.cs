// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDWriteFontFamily1"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class IDWriteFontFamily1Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDWriteFontFamily1"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWriteFontFamily1).GUID, Is.EqualTo(IID_IDWriteFontFamily1));
    }

    /// <summary>Validates that the <see cref = "IDWriteFontFamily1"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWriteFontFamily1>(), Is.EqualTo(sizeof(IDWriteFontFamily1)));
    }

    /// <summary>Validates that the <see cref = "IDWriteFontFamily1"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWriteFontFamily1).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDWriteFontFamily1"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWriteFontFamily1), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWriteFontFamily1), Is.EqualTo(4));
        }
    }
}