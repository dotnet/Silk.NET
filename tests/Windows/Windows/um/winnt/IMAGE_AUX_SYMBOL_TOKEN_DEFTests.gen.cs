// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMAGE_AUX_SYMBOL_TOKEN_DEF"/> struct.</summary>
public static unsafe partial class IMAGE_AUX_SYMBOL_TOKEN_DEFTests
{
    /// <summary>Validates that the <see cref = "IMAGE_AUX_SYMBOL_TOKEN_DEF"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMAGE_AUX_SYMBOL_TOKEN_DEF>(), Is.EqualTo(sizeof(IMAGE_AUX_SYMBOL_TOKEN_DEF)));
    }

    /// <summary>Validates that the <see cref = "IMAGE_AUX_SYMBOL_TOKEN_DEF"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGE_AUX_SYMBOL_TOKEN_DEF).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMAGE_AUX_SYMBOL_TOKEN_DEF"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGE_AUX_SYMBOL_TOKEN_DEF), Is.EqualTo(18));
    }
}