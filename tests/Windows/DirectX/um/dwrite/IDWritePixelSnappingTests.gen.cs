// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDWritePixelSnapping"/> struct.</summary>
public static unsafe partial class IDWritePixelSnappingTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDWritePixelSnapping"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWritePixelSnapping).GUID, Is.EqualTo(IID_IDWritePixelSnapping));
    }

    /// <summary>Validates that the <see cref = "IDWritePixelSnapping"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWritePixelSnapping>(), Is.EqualTo(sizeof(IDWritePixelSnapping)));
    }

    /// <summary>Validates that the <see cref = "IDWritePixelSnapping"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWritePixelSnapping).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDWritePixelSnapping"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWritePixelSnapping), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWritePixelSnapping), Is.EqualTo(4));
        }
    }
}