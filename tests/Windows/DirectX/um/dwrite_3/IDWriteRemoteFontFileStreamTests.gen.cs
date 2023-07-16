// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDWriteRemoteFontFileStream"/> struct.</summary>
public static unsafe partial class IDWriteRemoteFontFileStreamTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDWriteRemoteFontFileStream"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWriteRemoteFontFileStream).GUID, Is.EqualTo(IID_IDWriteRemoteFontFileStream));
    }

    /// <summary>Validates that the <see cref = "IDWriteRemoteFontFileStream"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWriteRemoteFontFileStream>(), Is.EqualTo(sizeof(IDWriteRemoteFontFileStream)));
    }

    /// <summary>Validates that the <see cref = "IDWriteRemoteFontFileStream"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWriteRemoteFontFileStream).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDWriteRemoteFontFileStream"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWriteRemoteFontFileStream), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWriteRemoteFontFileStream), Is.EqualTo(4));
        }
    }
}