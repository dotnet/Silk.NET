// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HistogramGrid"/> struct.</summary>
public static unsafe partial class HistogramGridTests
{
    /// <summary>Validates that the <see cref = "HistogramGrid"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HistogramGrid>(), Is.EqualTo(sizeof(HistogramGrid)));
    }

    /// <summary>Validates that the <see cref = "HistogramGrid"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HistogramGrid).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HistogramGrid"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HistogramGrid), Is.EqualTo(24));
    }
}