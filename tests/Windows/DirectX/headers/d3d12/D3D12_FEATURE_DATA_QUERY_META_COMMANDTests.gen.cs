// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "D3D12_FEATURE_DATA_QUERY_META_COMMAND"/> struct.</summary>
public static unsafe partial class D3D12_FEATURE_DATA_QUERY_META_COMMANDTests
{
    /// <summary>Validates that the <see cref = "D3D12_FEATURE_DATA_QUERY_META_COMMAND"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D12_FEATURE_DATA_QUERY_META_COMMAND>(), Is.EqualTo(sizeof(D3D12_FEATURE_DATA_QUERY_META_COMMAND)));
    }

    /// <summary>Validates that the <see cref = "D3D12_FEATURE_DATA_QUERY_META_COMMAND"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12_FEATURE_DATA_QUERY_META_COMMAND).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D3D12_FEATURE_DATA_QUERY_META_COMMAND"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3D12_FEATURE_DATA_QUERY_META_COMMAND), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(D3D12_FEATURE_DATA_QUERY_META_COMMAND), Is.EqualTo(36));
        }
    }
}