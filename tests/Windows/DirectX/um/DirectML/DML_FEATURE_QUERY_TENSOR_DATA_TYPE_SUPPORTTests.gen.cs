// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DML_FEATURE_QUERY_TENSOR_DATA_TYPE_SUPPORT"/> struct.</summary>
public static unsafe partial class DML_FEATURE_QUERY_TENSOR_DATA_TYPE_SUPPORTTests
{
    /// <summary>Validates that the <see cref = "DML_FEATURE_QUERY_TENSOR_DATA_TYPE_SUPPORT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DML_FEATURE_QUERY_TENSOR_DATA_TYPE_SUPPORT>(), Is.EqualTo(sizeof(DML_FEATURE_QUERY_TENSOR_DATA_TYPE_SUPPORT)));
    }

    /// <summary>Validates that the <see cref = "DML_FEATURE_QUERY_TENSOR_DATA_TYPE_SUPPORT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DML_FEATURE_QUERY_TENSOR_DATA_TYPE_SUPPORT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DML_FEATURE_QUERY_TENSOR_DATA_TYPE_SUPPORT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DML_FEATURE_QUERY_TENSOR_DATA_TYPE_SUPPORT), Is.EqualTo(4));
    }
}