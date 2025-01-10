// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "FaceRectInfoBlobHeader"/> struct.</summary>
public static unsafe partial class FaceRectInfoBlobHeaderTests
{
    /// <summary>Validates that the <see cref = "FaceRectInfoBlobHeader"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<FaceRectInfoBlobHeader>(),
            Is.EqualTo(sizeof(FaceRectInfoBlobHeader))
        );
    }

    /// <summary>Validates that the <see cref = "FaceRectInfoBlobHeader"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FaceRectInfoBlobHeader).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FaceRectInfoBlobHeader"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FaceRectInfoBlobHeader), Is.EqualTo(8));
    }
}
