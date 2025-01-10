// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MF_LEAKY_BUCKET_PAIR"/> struct.</summary>
public static unsafe partial class MF_LEAKY_BUCKET_PAIRTests
{
    /// <summary>Validates that the <see cref = "MF_LEAKY_BUCKET_PAIR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<MF_LEAKY_BUCKET_PAIR>(),
            Is.EqualTo(sizeof(MF_LEAKY_BUCKET_PAIR))
        );
    }

    /// <summary>Validates that the <see cref = "MF_LEAKY_BUCKET_PAIR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MF_LEAKY_BUCKET_PAIR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MF_LEAKY_BUCKET_PAIR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MF_LEAKY_BUCKET_PAIR), Is.EqualTo(8));
    }
}
