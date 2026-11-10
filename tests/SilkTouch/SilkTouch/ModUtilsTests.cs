using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.UnitTests;

public class ModUtilsTests
{
    private static readonly (
        string Input,
        string EffectiveName,
        string Directory,
        string Remainder
    )[] GetEffectiveNameTests =
    [
        ("hello/GL.gen.cs", "GL", "hello/", ".gen.cs"),
        ("hello/GL.Manual.cs", "GL.Manual", "hello/", ".cs"),
        ("hello/GL.Interfaces.gen.cs", "GL.Interfaces", "hello/", ".gen.cs"),
    ];

    [Test]
    public void GetEffectiveName(
        [ValueSource(nameof(GetEffectiveNameTests))]
            (string Input, string EffectiveName, string Directory, string Remainder) testData
    )
    {
        testData.Input.GetEffectiveName(
            out var effectiveName,
            out var directory,
            out var remainder
        );

        Assert.That(effectiveName.ToString(), Is.EqualTo(testData.EffectiveName));
        Assert.That(directory.ToString(), Is.EqualTo(testData.Directory));
        Assert.That(remainder.ToString(), Is.EqualTo(testData.Remainder));
    }

    [Test]
    // Single values are never [Flags] - Safe since no other values to boolean op with
    [TestCase(false, new long[] { 0 })]
    [TestCase(false, new long[] { 1 })]
    [TestCase(false, new long[] { -1 })]
    [TestCase(false, new long[] { int.MaxValue })]
    [TestCase(false, new long[] { uint.MaxValue })]
    // Signed enums containing negative values are never [Flags]
    [TestCase(false, new long[] { -1, 0, 1, 2, 4, 8, 16 }, true)]
    // All 1 bit
    [TestCase(true, new long[] { 1, 2, 4 })]
    [TestCase(true, new long[] { 1, 2, 4, 8 })]
    [TestCase(true, new long[] { 1, 2, 4, 8, 16 })]
    [TestCase(true, new long[] { 1, 2, 4, 8, 16, 32 })]
    // All 1 bit or ignored (0 and MaxValues)
    [TestCase(true, new long[] { 0, 1, 2, 4 })]
    [TestCase(true, new long[] { 0, 1, 2, 4, 8 })]
    [TestCase(true, new long[] { 0, 1, 2, 4, 8, 16 })]
    [TestCase(true, new long[] { 0, 1, 2, 4, 8, 16, 32 })]
    [TestCase(true, new long[] { 1, 2, 4, int.MaxValue })]
    [TestCase(true, new long[] { 1, 2, 4, 8, int.MaxValue })]
    [TestCase(true, new long[] { 1, 2, 4, 8, 16, int.MaxValue })]
    [TestCase(true, new long[] { 1, 2, 4, 8, 16, 32, int.MaxValue })]
    [TestCase(true, new long[] { 0, 1, 2, 4, int.MaxValue })]
    [TestCase(true, new long[] { 0, 1, 2, 4, 8, int.MaxValue })]
    [TestCase(true, new long[] { 0, 1, 2, 4, 8, 16, int.MaxValue })]
    [TestCase(true, new long[] { 0, 1, 2, 4, 8, 16, 32, int.MaxValue })]
    // All 1 bit except for 1
    [TestCase(true, new long[] { 1, 2, 4, 8, 123 })]
    [TestCase(true, new long[] { 1, 2, 4, 8, 16, 123 })]
    [TestCase(true, new long[] { 1, 2, 4, 8, 16, 32, 123 })]
    // Sequential
    [TestCase(false, new long[] { 1, 2, 3, 4 })]
    [TestCase(false, new long[] { 1, 2, 3, 4, 5 })]
    [TestCase(false, new long[] { 2, 3, 4, 5 })]
    [TestCase(false, new long[] { 3, 4, 5, 6 })]
    // Seemingly sequential
    [TestCase(false, new long[] { 1, 2, 3, 4, 8 })]
    // Scattered
    [TestCase(false, new long[] { 3, 7, 11, 13 })]
    [TestCase(false, new long[] { 12, 24, 36, 48 })]
    // Inconclusive cases
    // [1, 2, 3] is non-conclusive (1 | 2 is 3, which can represent all bits set, but is also sequential)
    // Example would be [None, Read, Write, All] for some sort of Access enum
    // Similarly, [1, 2] is the same, but without the All member
    [TestCase(null, new long[] { 1, 2 })]
    [TestCase(null, new long[] { 1, 2, 3 })]
    public void IsProbablyFlags(bool? expected, long[] members, bool isSigned = false) =>
        Assert.That(ModUtils.IsProbablyFlags(members, isSigned), Is.EqualTo(expected));
}
