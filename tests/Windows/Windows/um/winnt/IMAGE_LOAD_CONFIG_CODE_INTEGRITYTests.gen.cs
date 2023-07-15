// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMAGE_LOAD_CONFIG_CODE_INTEGRITY"/> struct.</summary>
public static unsafe partial class IMAGE_LOAD_CONFIG_CODE_INTEGRITYTests
{
    /// <summary>Validates that the <see cref = "IMAGE_LOAD_CONFIG_CODE_INTEGRITY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMAGE_LOAD_CONFIG_CODE_INTEGRITY>(), Is.EqualTo(sizeof(IMAGE_LOAD_CONFIG_CODE_INTEGRITY)));
    }

    /// <summary>Validates that the <see cref = "IMAGE_LOAD_CONFIG_CODE_INTEGRITY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGE_LOAD_CONFIG_CODE_INTEGRITY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMAGE_LOAD_CONFIG_CODE_INTEGRITY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGE_LOAD_CONFIG_CODE_INTEGRITY), Is.EqualTo(12));
    }
}