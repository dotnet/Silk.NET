// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DML_FEATURE_DATA_FEATURE_LEVELS"/> struct.</summary>
public static unsafe partial class DML_FEATURE_DATA_FEATURE_LEVELSTests
{
    /// <summary>Validates that the <see cref = "DML_FEATURE_DATA_FEATURE_LEVELS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DML_FEATURE_DATA_FEATURE_LEVELS>(), Is.EqualTo(sizeof(DML_FEATURE_DATA_FEATURE_LEVELS)));
    }

    /// <summary>Validates that the <see cref = "DML_FEATURE_DATA_FEATURE_LEVELS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DML_FEATURE_DATA_FEATURE_LEVELS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DML_FEATURE_DATA_FEATURE_LEVELS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DML_FEATURE_DATA_FEATURE_LEVELS), Is.EqualTo(4));
    }
}