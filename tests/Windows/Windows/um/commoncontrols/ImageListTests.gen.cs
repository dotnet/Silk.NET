// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/commoncontrols.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ImageList"/> struct.</summary>
public static unsafe partial class ImageListTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ImageList"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ImageList).GUID, Is.EqualTo(IID_ImageList));
    }

    /// <summary>Validates that the <see cref = "ImageList"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ImageList>(), Is.EqualTo(sizeof(ImageList)));
    }

    /// <summary>Validates that the <see cref = "ImageList"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ImageList).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ImageList"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ImageList), Is.EqualTo(1));
    }
}