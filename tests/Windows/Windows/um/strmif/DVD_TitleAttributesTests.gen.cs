// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DVD_TitleAttributes"/> struct.</summary>
public static unsafe partial class DVD_TitleAttributesTests
{
    /// <summary>Validates that the <see cref = "DVD_TitleAttributes"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DVD_TitleAttributes>(), Is.EqualTo(sizeof(DVD_TitleAttributes)));
    }

    /// <summary>Validates that the <see cref = "DVD_TitleAttributes"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DVD_TitleAttributes).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DVD_TitleAttributes"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DVD_TitleAttributes), Is.EqualTo(3208));
    }
}