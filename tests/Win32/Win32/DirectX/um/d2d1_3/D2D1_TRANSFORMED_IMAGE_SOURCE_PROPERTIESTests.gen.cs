// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES"/> struct.</summary>
public static unsafe partial class D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIESTests
{
    /// <summary>Validates that the <see cref = "D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES>(),
            Is.EqualTo(sizeof(D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES))
        );
    }

    /// <summary>Validates that the <see cref = "D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES), Is.EqualTo(20));
    }
}
