// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FileSystemImageResult"/> struct.</summary>
public static unsafe partial class FileSystemImageResultTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "FileSystemImageResult"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(FileSystemImageResult).GUID, Is.EqualTo(CLSID_FileSystemImageResult));
    }

    /// <summary>Validates that the <see cref = "FileSystemImageResult"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FileSystemImageResult>(), Is.EqualTo(sizeof(FileSystemImageResult)));
    }

    /// <summary>Validates that the <see cref = "FileSystemImageResult"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FileSystemImageResult).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FileSystemImageResult"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FileSystemImageResult), Is.EqualTo(1));
    }
}