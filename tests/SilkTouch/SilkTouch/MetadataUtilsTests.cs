// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using NUnit.Framework;
using Silk.NET.SilkTouch.Mods.Metadata;

namespace Silk.NET.SilkTouch.UnitTests;

public class MetadataUtilsTests
{
    [
        Test,
        TestCase("const int*", 1),
        TestCase("const int* const*", 2),
        TestCase("const int* const* const*", 3),
        TestCase("const int* const* const*[16]", 4),
        TestCase("const int* const* const* a[16]", 4),
        TestCase("const int* const* const* a[2][8]", 4),
        TestCase("const int a", 0)
    ]
    public void GetIndirectionLevels(string type, int expectedIndirection) =>
        Assert.That(MetadataUtils.GetIndirectionLevels(type), Is.EqualTo(expectedIndirection));

    [
        Test,
        TestCase("const int*", 1, new[] { true, false }, 0),
        TestCase("const int* const*", 2, new[] { true, false, false }, 0),
        TestCase("const int* const* const a", 2, new[] { false, false, false }, 0),
        TestCase("const int* const* const*", 3, new[] { true, false, false, false }, 0),
        TestCase("const int* const* const*[16]", 4, new[] { true, true, false, false, false }, 16),
        TestCase(
            "const int* const* const* a[16]",
            4,
            new[] { true, true, false, false, false },
            16
        ),
        TestCase(
            "const int* const* const* a[2][8]",
            4,
            new[] { true, true, false, false, false },
            16
        ),
        TestCase("const int a", 0, new[] { false }, 0),
        TestCase("int*", 1, new[] { true, true }, 0),
        TestCase("int* const*", 2, new[] { true, false, true }, 0),
        TestCase("int* const* const*", 3, new[] { true, false, false, true }, 0),
        TestCase("int* const* const*[16]", 4, new[] { true, false, false, true, true }, 16),
        TestCase("int* const* const* a[16]", 4, new[] { true, false, false, true, true }, 16),
        TestCase("int* const* const* a[2][8]", 4, new[] { true, false, false, true, true }, 16),
        TestCase("int**", 2, new[] { true, true, true }, 0),
        TestCase("int** const*", 3, new[] { true, false, true, true }, 0),
        TestCase("int** const*[16]", 4, new[] { true, true, false, true, true }, 16),
        TestCase("int** const* a[16]", 4, new[] { true, true, false, true, true }, 16),
        TestCase("int** const* a[2][8]", 4, new[] { true, true, false, true, true }, 16),
        TestCase("int a", 0, new[] { true }, 0)
    ]
    public void GetMutability(
        string type,
        int indirection,
        bool[] expectedMutability,
        int expectedOuterCount
    )
    {
        var mutability = new bool[indirection + 1];
        MetadataUtils.GetTypeDetails(type, mutability, out var outerCount);
        Assert.Multiple(() =>
        {
            Assert.That(outerCount, Is.EqualTo(expectedOuterCount));
            Assert.That(mutability, Is.EquivalentTo(expectedMutability));
        });
    }
}
