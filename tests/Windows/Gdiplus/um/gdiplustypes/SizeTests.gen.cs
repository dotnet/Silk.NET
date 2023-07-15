// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Gdiplus.UnitTests;
/// <summary>Provides validation of the <see cref = "Size"/> struct.</summary>
public static unsafe partial class SizeTests
{
    /// <summary>Validates that the <see cref = "Size"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Size>(), Is.EqualTo(sizeof(Size)));
    }

    /// <summary>Validates that the <see cref = "Size"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Size).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "Size"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Size), Is.EqualTo(8));
    }
}