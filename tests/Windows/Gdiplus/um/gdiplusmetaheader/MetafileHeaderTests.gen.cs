// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Gdiplus.UnitTests;
/// <summary>Provides validation of the <see cref = "MetafileHeader"/> struct.</summary>
public static unsafe partial class MetafileHeaderTests
{
    /// <summary>Validates that the <see cref = "MetafileHeader"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MetafileHeader>(), Is.EqualTo(sizeof(MetafileHeader)));
    }

    /// <summary>Validates that the <see cref = "MetafileHeader"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MetafileHeader).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MetafileHeader"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MetafileHeader), Is.EqualTo(140));
    }
}