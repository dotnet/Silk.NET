// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DML_SCALAR_UNION"/> struct.</summary>
public static unsafe partial class DML_SCALAR_UNIONTests
{
    /// <summary>Validates that the <see cref = "DML_SCALAR_UNION"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DML_SCALAR_UNION>(), Is.EqualTo(sizeof(DML_SCALAR_UNION)));
    }

    /// <summary>Validates that the <see cref = "DML_SCALAR_UNION"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(DML_SCALAR_UNION).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref = "DML_SCALAR_UNION"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DML_SCALAR_UNION), Is.EqualTo(8));
    }
}
