using NUnit.Framework;
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
        ModUtils.GetEffectiveName(
            testData.Input,
            out var effectiveName,
            out var directory,
            out var remainder
        );
        Assert.That(effectiveName.ToString(), Is.EqualTo(testData.EffectiveName));
        Assert.That(directory.ToString(), Is.EqualTo(testData.Directory));
        Assert.That(remainder.ToString(), Is.EqualTo(testData.Remainder));
    }
}
