// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SVGTransformList"/> struct.</summary>
public static unsafe partial class SVGTransformListTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "SVGTransformList"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SVGTransformList).GUID, Is.EqualTo(IID_SVGTransformList));
    }

    /// <summary>Validates that the <see cref = "SVGTransformList"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SVGTransformList>(), Is.EqualTo(sizeof(SVGTransformList)));
    }

    /// <summary>Validates that the <see cref = "SVGTransformList"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SVGTransformList).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SVGTransformList"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SVGTransformList), Is.EqualTo(1));
    }
}