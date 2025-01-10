// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IDiaSymbol3"/> struct.</summary>
public static unsafe partial class IDiaSymbol3Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDiaSymbol3"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDiaSymbol3).GUID, Is.EqualTo(IID_IDiaSymbol3));
    }

    /// <summary>Validates that the <see cref = "IDiaSymbol3"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDiaSymbol3>(), Is.EqualTo(sizeof(IDiaSymbol3)));
    }

    /// <summary>Validates that the <see cref = "IDiaSymbol3"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDiaSymbol3).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDiaSymbol3"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDiaSymbol3), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDiaSymbol3), Is.EqualTo(4));
        }
    }
}
