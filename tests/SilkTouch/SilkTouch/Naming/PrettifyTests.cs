// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.UnitTests.Naming;

public class PrettifyTests
{
    [Theory]
    [TestCase("HelloWorld", ExpectedResult = "HelloWorld")]
    [TestCase("HelloWorld123", ExpectedResult = "HelloWorld123")]
    [TestCase("HelloWorld_123", ExpectedResult = "HelloWorld123")]
    [TestCase("Hello_World", ExpectedResult = "HelloWorld")]
    [TestCase("_Hello__World_", ExpectedResult = "HelloWorld")]
    [TestCase("_HELLO__WORLD_", ExpectedResult = "HelloWorld")]
    [TestCase("LONGACRONYM", 4, ExpectedResult = "Longacronym")]
    [TestCase("LONG_ACRONYM", 4, ExpectedResult = "LongAcronym")]
    [TestCase(
        "LONG_ACRONYM",
        5,
        ExpectedResult = "LONGAcronym",
        Description = "LONG is short enough to be uppercased"
    )]
    [TestCase("LONG_Acronym", 5, ExpectedResult = "LONGAcronym")]
    [TestCase(
        "LONG_ACRONYM",
        10,
        ExpectedResult = "LongAcronym",
        Description = "Both should be uppercased, but since they are adjacent, they conflict and revert back to lowercase"
    )]
    [TestCase(
        "123",
        ExpectedResult = "X123",
        Description = "C# identifiers cannot start with a number"
    )]
    public string CommonCases(string input, int longAcronymThreshold = 0) =>
        input.Prettify(new NameUtils.NameTransformer(longAcronymThreshold));

    [Test]
    public void IsNotAffectedBy_TrailingUnderscore()
    {
        var nameTransformer = new NameUtils.NameTransformer(4);
        var withoutUnderscore = "RGB32F".Prettify(nameTransformer);
        var withUnderscore = "RGB32F_".Prettify(nameTransformer);

        Assert.That(withUnderscore, Is.EqualTo(withoutUnderscore));
    }

    [Test]
    public void Capital_AfterNumber_DoesNotAffect_PreviousWord()
    {
        var nameTransformer = new NameUtils.NameTransformer(4);

        using (Assert.EnterMultipleScope())
        {
            Assert.That("RGB16".Prettify(nameTransformer), Is.EqualTo("Rgb16"));
            Assert.That("RGB16F".Prettify(nameTransformer), Is.EqualTo("Rgb16F"));

            Assert.That("MONO16".Prettify(nameTransformer), Is.EqualTo("Mono16"));
            Assert.That("MONO16F".Prettify(nameTransformer), Is.EqualTo("Mono16F"));
        }
    }
}
