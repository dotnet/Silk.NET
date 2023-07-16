// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMAGE_HOT_PATCH_INFO"/> struct.</summary>
public static unsafe partial class IMAGE_HOT_PATCH_INFOTests
{
    /// <summary>Validates that the <see cref = "IMAGE_HOT_PATCH_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMAGE_HOT_PATCH_INFO>(), Is.EqualTo(sizeof(IMAGE_HOT_PATCH_INFO)));
    }

    /// <summary>Validates that the <see cref = "IMAGE_HOT_PATCH_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGE_HOT_PATCH_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMAGE_HOT_PATCH_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGE_HOT_PATCH_INFO), Is.EqualTo(28));
    }
}