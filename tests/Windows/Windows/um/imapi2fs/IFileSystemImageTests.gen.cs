// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IFileSystemImage"/> struct.</summary>
public static unsafe partial class IFileSystemImageTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IFileSystemImage"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IFileSystemImage).GUID, Is.EqualTo(IID_IFileSystemImage));
    }

    /// <summary>Validates that the <see cref = "IFileSystemImage"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IFileSystemImage>(), Is.EqualTo(sizeof(IFileSystemImage)));
    }

    /// <summary>Validates that the <see cref = "IFileSystemImage"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IFileSystemImage).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IFileSystemImage"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IFileSystemImage), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IFileSystemImage), Is.EqualTo(4));
        }
    }
}