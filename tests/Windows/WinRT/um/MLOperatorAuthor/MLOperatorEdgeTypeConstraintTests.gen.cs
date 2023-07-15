// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "MLOperatorEdgeTypeConstraint"/> struct.</summary>
public static unsafe partial class MLOperatorEdgeTypeConstraintTests
{
    /// <summary>Validates that the <see cref = "MLOperatorEdgeTypeConstraint"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MLOperatorEdgeTypeConstraint>(), Is.EqualTo(sizeof(MLOperatorEdgeTypeConstraint)));
    }

    /// <summary>Validates that the <see cref = "MLOperatorEdgeTypeConstraint"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MLOperatorEdgeTypeConstraint).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MLOperatorEdgeTypeConstraint"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MLOperatorEdgeTypeConstraint), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(MLOperatorEdgeTypeConstraint), Is.EqualTo(12));
        }
    }
}