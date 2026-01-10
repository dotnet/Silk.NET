// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.UnitTests.Naming;

public class NamePrettifierTests
{
    [Theory]
    [TestCase("helloWorld", ExpectedResult = "HelloWorld")]
    [TestCase("HelloWorld", ExpectedResult = "HelloWorld")]
    [TestCase("HelloWorld123", ExpectedResult = "HelloWorld123")]
    [TestCase("HelloWorld_123", ExpectedResult = "HelloWorld123")]
    [TestCase("Hello_World", ExpectedResult = "HelloWorld")]
    [TestCase("HelloUI", 2, ExpectedResult = "HelloUI")]
    [TestCase("HelloGUI", 2, ExpectedResult = "HelloGui")]
    [TestCase("UIHello", 2, ExpectedResult = "UIHello")]
    [TestCase("GUIHello", 2, ExpectedResult = "GuiHello")]
    [TestCase("Hello_UI", 2, ExpectedResult = "HelloUI")]
    [TestCase("Hello_GUI", 2, ExpectedResult = "HelloGui")]
    [TestCase("UI_Hello", 2, ExpectedResult = "UIHello")]
    [TestCase("GUI_Hello", 2, ExpectedResult = "GuiHello")]
    [TestCase(
        "G_UI_Hello",
        2,
        ExpectedResult = "GUiHello",
        Description = "Both should be uppercased, but since they are adjacent, they conflict and revert back to pascal case"
    )]
    [TestCase("_Hello__World_", ExpectedResult = "HelloWorld")]
    [TestCase("_HELLO__WORLD_", ExpectedResult = "HelloWorld")]
    [TestCase("LONGACRONYM", 4, ExpectedResult = "Longacronym")]
    [TestCase("LONG_ACRONYM", 3, ExpectedResult = "LongAcronym")]
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
        Description = "Both should be uppercased, but since they are adjacent, they conflict and revert back to pascal case"
    )]
    [TestCase(
        "123",
        ExpectedResult = "X123",
        Description = "C# identifiers cannot start with a number"
    )]
    [TestCase("123_123_123", ExpectedResult = "X123x123x123")]
    [TestCase("Hello123_123_123", ExpectedResult = "Hello123x123x123")]
    [TestCase("A123f123", ExpectedResult = "A123f123")]
    public string CoreFunctionality(string input, int longAcronymThreshold = 0) =>
        new NamePrettifier(longAcronymThreshold).Prettify(input);

    [Test]
    public void IsNotAffectedBy_TrailingUnderscore()
    {
        var nameTransformer = new NamePrettifier(4);
        var withoutUnderscore = nameTransformer.Prettify("RGB32F");
        var withUnderscore = nameTransformer.Prettify("RGB32F_");

        Assert.That(withUnderscore, Is.EqualTo(withoutUnderscore));
    }

    [Test]
    public void Uppercase_AfterNumber_DoesNotAffect_PreviousWord()
    {
        var nameTransformer = new NamePrettifier(4);

        using (Assert.EnterMultipleScope())
        {
            Assert.That(nameTransformer.Prettify("RGB16"), Is.EqualTo("Rgb16"));
            Assert.That(nameTransformer.Prettify("RGB16F"), Is.EqualTo("Rgb16F"));

            Assert.That(nameTransformer.Prettify("MONO16"), Is.EqualTo("Mono16"));
            Assert.That(nameTransformer.Prettify("MONO16F"), Is.EqualTo("Mono16F"));
        }
    }

    [Test]
    public void Lowercase_AfterNumber_IsPartOf_PreviousWord()
    {
        var nameTransformer = new NamePrettifier(4);

        using (Assert.EnterMultipleScope())
        {
            Assert.That(nameTransformer.Prettify("RGB16"), Is.EqualTo("Rgb16"));
            Assert.That(nameTransformer.Prettify("RGB16f"), Is.EqualTo("Rgb16f"));

            Assert.That(nameTransformer.Prettify("MONO16"), Is.EqualTo("Mono16"));
            Assert.That(nameTransformer.Prettify("MONO16f"), Is.EqualTo("Mono16f"));
        }
    }
}
