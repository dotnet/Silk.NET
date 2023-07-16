// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shimgdata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IShellImageData"/> struct.</summary>
public static unsafe partial class IShellImageDataTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IShellImageData"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IShellImageData).GUID, Is.EqualTo(IID_IShellImageData));
    }

    /// <summary>Validates that the <see cref = "IShellImageData"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IShellImageData>(), Is.EqualTo(sizeof(IShellImageData)));
    }

    /// <summary>Validates that the <see cref = "IShellImageData"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IShellImageData).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IShellImageData"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IShellImageData), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IShellImageData), Is.EqualTo(4));
        }
    }
}