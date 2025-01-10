// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "STORAGE_PREDICT_FAILURE"/> struct.</summary>
public static unsafe partial class STORAGE_PREDICT_FAILURETests
{
    /// <summary>Validates that the <see cref = "STORAGE_PREDICT_FAILURE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<STORAGE_PREDICT_FAILURE>(),
            Is.EqualTo(sizeof(STORAGE_PREDICT_FAILURE))
        );
    }

    /// <summary>Validates that the <see cref = "STORAGE_PREDICT_FAILURE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_PREDICT_FAILURE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STORAGE_PREDICT_FAILURE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_PREDICT_FAILURE), Is.EqualTo(516));
    }
}
