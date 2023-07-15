// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDWriteTextRenderer1"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IDWriteTextRenderer1Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDWriteTextRenderer1"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWriteTextRenderer1).GUID, Is.EqualTo(IID_IDWriteTextRenderer1));
    }

    /// <summary>Validates that the <see cref = "IDWriteTextRenderer1"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWriteTextRenderer1>(), Is.EqualTo(sizeof(IDWriteTextRenderer1)));
    }

    /// <summary>Validates that the <see cref = "IDWriteTextRenderer1"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWriteTextRenderer1).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDWriteTextRenderer1"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWriteTextRenderer1), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWriteTextRenderer1), Is.EqualTo(4));
        }
    }
}