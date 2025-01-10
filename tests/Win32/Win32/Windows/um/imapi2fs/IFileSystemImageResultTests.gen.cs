// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IFileSystemImageResult"/> struct.</summary>
public static unsafe partial class IFileSystemImageResultTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IFileSystemImageResult"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IFileSystemImageResult).GUID, Is.EqualTo(IID_IFileSystemImageResult));
    }

    /// <summary>Validates that the <see cref = "IFileSystemImageResult"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IFileSystemImageResult>(),
            Is.EqualTo(sizeof(IFileSystemImageResult))
        );
    }

    /// <summary>Validates that the <see cref = "IFileSystemImageResult"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IFileSystemImageResult).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IFileSystemImageResult"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IFileSystemImageResult), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IFileSystemImageResult), Is.EqualTo(4));
        }
    }
}
