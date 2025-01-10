// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DML_ELEMENT_WISE_BIT_OR_OPERATOR_DESC"/> struct.</summary>
public static unsafe partial class DML_ELEMENT_WISE_BIT_OR_OPERATOR_DESCTests
{
    /// <summary>Validates that the <see cref = "DML_ELEMENT_WISE_BIT_OR_OPERATOR_DESC"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DML_ELEMENT_WISE_BIT_OR_OPERATOR_DESC>(),
            Is.EqualTo(sizeof(DML_ELEMENT_WISE_BIT_OR_OPERATOR_DESC))
        );
    }

    /// <summary>Validates that the <see cref = "DML_ELEMENT_WISE_BIT_OR_OPERATOR_DESC"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DML_ELEMENT_WISE_BIT_OR_OPERATOR_DESC).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DML_ELEMENT_WISE_BIT_OR_OPERATOR_DESC"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DML_ELEMENT_WISE_BIT_OR_OPERATOR_DESC), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(DML_ELEMENT_WISE_BIT_OR_OPERATOR_DESC), Is.EqualTo(12));
        }
    }
}
