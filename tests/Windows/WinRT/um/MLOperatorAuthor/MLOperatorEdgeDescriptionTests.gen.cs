// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "MLOperatorEdgeDescription"/> struct.</summary>
public static unsafe partial class MLOperatorEdgeDescriptionTests
{
    /// <summary>Validates that the <see cref = "MLOperatorEdgeDescription"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MLOperatorEdgeDescription>(), Is.EqualTo(sizeof(MLOperatorEdgeDescription)));
    }

    /// <summary>Validates that the <see cref = "MLOperatorEdgeDescription"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MLOperatorEdgeDescription).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MLOperatorEdgeDescription"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MLOperatorEdgeDescription), Is.EqualTo(16));
    }
}