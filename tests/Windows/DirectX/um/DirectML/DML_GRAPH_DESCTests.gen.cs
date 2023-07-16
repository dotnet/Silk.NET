// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DML_GRAPH_DESC"/> struct.</summary>
public static unsafe partial class DML_GRAPH_DESCTests
{
    /// <summary>Validates that the <see cref = "DML_GRAPH_DESC"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DML_GRAPH_DESC>(), Is.EqualTo(sizeof(DML_GRAPH_DESC)));
    }

    /// <summary>Validates that the <see cref = "DML_GRAPH_DESC"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DML_GRAPH_DESC).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DML_GRAPH_DESC"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DML_GRAPH_DESC), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(DML_GRAPH_DESC), Is.EqualTo(40));
        }
    }
}