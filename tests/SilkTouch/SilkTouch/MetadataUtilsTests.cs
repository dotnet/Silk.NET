// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Mods.Metadata;
using Throws = NUnit.Framework.Throws;

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
        TestCase("const int a", 0),
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
        TestCase("int a", 0, new[] { true }, 0),
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

    [Test]
    public void HandlesSimpleSymbols()
    {
        // OpenXR's XML uses constants to specify array sizes
        // Normally this isn't an issue because ClangSharp resolves these for us
        // This test ensures that we can handle simple symbols (naive lookup) for this case
        Span<bool> mutability = stackalloc bool[2];
        MetadataUtils.GetTypeDetails(
            "charbuffer[XR_MAX_RESULT_STRING_SIZE]",
            mutability,
            out var outerCount,
            new Dictionary<string, string>() { { "XR_MAX_RESULT_STRING_SIZE", "64" } }
        );

        Assert.That(mutability[0], Is.True);
        Assert.That(mutability[1], Is.True);
        Assert.That(outerCount, Is.EqualTo(64));
    }

    [Test]
    public void SymbolLookupThrowsForInfiniteLoop()
    {
        // Implementation should throw for cycles
        // Naive detection is fine since this is an unlikely case
        Assert.That(
            () =>
            {
                Span<bool> mutability = stackalloc bool[2];
                MetadataUtils.GetTypeDetails(
                    "charbuffer[XR_MAX_RESULT_STRING_SIZE]",
                    mutability,
                    out _,
                    new Dictionary<string, string>()
                    {
                        { "XR_MAX_RESULT_STRING_SIZE", "XR_MAX_RESULT_STRING_SIZE_2" },
                        { "XR_MAX_RESULT_STRING_SIZE_2", "XR_MAX_RESULT_STRING_SIZE" },
                    }
                );
            },
            Throws.InvalidOperationException
        );
    }
}
