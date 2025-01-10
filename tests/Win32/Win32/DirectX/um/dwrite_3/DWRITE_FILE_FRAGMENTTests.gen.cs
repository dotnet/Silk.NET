// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DWRITE_FILE_FRAGMENT"/> struct.</summary>
public static unsafe partial class DWRITE_FILE_FRAGMENTTests
{
    /// <summary>Validates that the <see cref = "DWRITE_FILE_FRAGMENT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DWRITE_FILE_FRAGMENT>(),
            Is.EqualTo(sizeof(DWRITE_FILE_FRAGMENT))
        );
    }

    /// <summary>Validates that the <see cref = "DWRITE_FILE_FRAGMENT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DWRITE_FILE_FRAGMENT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DWRITE_FILE_FRAGMENT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DWRITE_FILE_FRAGMENT), Is.EqualTo(16));
    }
}
