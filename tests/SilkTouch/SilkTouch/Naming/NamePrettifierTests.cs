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
    public string SimplePascalCase(string input, int longAcronymThreshold = 0) =>
        new NamePrettifier(longAcronymThreshold).Prettify(input);

    [Theory]
    [TestCase("Hello_World", ExpectedResult = "HelloWorld")]
    [TestCase("HelloWorld_123", ExpectedResult = "HelloWorld123")]
    [TestCase("_Hello__World_", ExpectedResult = "HelloWorld")]
    [TestCase("_HELLO__WORLD_", ExpectedResult = "HelloWorld")]
    public string RemoveUnderscores(string input, int longAcronymThreshold = 0) =>
        new NamePrettifier(longAcronymThreshold).Prettify(input);

    [Theory]
    // Note the long acronym threshold
    // GUI is too long so it becomes Gui
    [TestCase("HelloUI", 2, ExpectedResult = "HelloUI")]
    [TestCase("HelloGUI", 2, ExpectedResult = "HelloGui")]
    [TestCase("UIHello", 2, ExpectedResult = "UIHello")]
    [TestCase("GUIHello", 2, ExpectedResult = "GuiHello")]
    [TestCase("Hello_UI", 2, ExpectedResult = "HelloUI")]
    [TestCase("Hello_GUI", 2, ExpectedResult = "HelloGui")]
    [TestCase("UI_Hello", 2, ExpectedResult = "UIHello")]
    [TestCase("GUI_Hello", 2, ExpectedResult = "GuiHello")]
    public string SimpleAcronyms(string input, int longAcronymThreshold = 0) =>
        new NamePrettifier(longAcronymThreshold).Prettify(input);

    [Theory]
    [TestCase("StdVideoAV1FilmGrain", 4, ExpectedResult = "StdVideoAV1FilmGrain")]
    // The 3 is considered part of the acronym so the acronym's length is 4, exceeding the threshold of 3
    [TestCase("XYZ3", 3, ExpectedResult = "Xyz3")]
    // The D is not part of the acronym
    [TestCase("N3D", 2, ExpectedResult = "N3D")]
    public string AcronymsWithNumbers(string input, int longAcronymThreshold = 0) =>
        new NamePrettifier(longAcronymThreshold).Prettify(input);

    [Theory]
    [TestCase("R", 2, ExpectedResult = "R")]
    // This usually becomes Rg since allow all caps is usually false
    [TestCase("RG", 2, ExpectedResult = "RG")]
    [TestCase("R8", 2, ExpectedResult = "R8")]
    [TestCase("RG8", 2, ExpectedResult = "Rg8")]
    [TestCase("RGB", 2, ExpectedResult = "Rgb")]
    public string AcronymsWithNumbers2(string input, int longAcronymThreshold = 0) =>
        new NamePrettifier(longAcronymThreshold).Prettify(input, true);

    // "Hello" in the following tests is used to ensure acronym identification is enabled
    [Theory]
    // Both want to be uppercased, but conflict, so both revert back to pascal case
    [TestCase("ABC_XYZ_Hello", 4, ExpectedResult = "AbcXyzHello")]
    [TestCase("ABC_XYZ_IJK_Hello", 4, ExpectedResult = "AbcXyzIjkHello")]
    // Single capitals are still treated as acronyms when checking for conflicts
    [TestCase("G_UI_Hello", 2, ExpectedResult = "GUiHello")]
    // XYZ is allowed to be uppercased since the first is too long
    [TestCase("ABCDEFG_XYZ_Hello", 3, ExpectedResult = "AbcdefgXYZHello")]
    // 123 is considered part of acronyms for the purposes of preserving acronyms,
    // but not for whether consecutive acronyms conflict
    [TestCase("ABC123_XYZ_Hello", 3, ExpectedResult = "Abc123XYZHello")]
    [TestCase("ABC123_XYZ456_IJK789_Hello", 6, ExpectedResult = "ABC123XYZ456IJK789Hello")]
    public string ConsecutiveAcronyms(string input, int longAcronymThreshold = 0) =>
        new NamePrettifier(longAcronymThreshold).Prettify(input);

    [Theory]
    // C# identifiers cannot start with numbers
    [TestCase("123", ExpectedResult = "X123")]
    [TestCase("123Hello", ExpectedResult = "X123Hello")]
    public string StartsWithNumber(string input, int longAcronymThreshold = 0) =>
        new NamePrettifier(longAcronymThreshold).Prettify(input);

    [Theory]
    // Add x between numbers to maintain separation
    [TestCase("123_123_123", ExpectedResult = "X123x123x123")]
    [TestCase("Hello123_123_123", ExpectedResult = "Hello123x123x123")]
    public string ConsecutiveNumbers(string input, int longAcronymThreshold = 0) =>
        new NamePrettifier(longAcronymThreshold).Prettify(input);

    [Theory]
    [TestCase("A123f123", ExpectedResult = "A123F123")]
    [TestCase("A123_f123", ExpectedResult = "A123F123")]
    [TestCase("Hello_123a", ExpectedResult = "Hello123A")]
    [TestCase("Hello_123a_hello", ExpectedResult = "Hello123AHello")]
    public string LowercaseWords(string input, int longAcronymThreshold = 0) =>
        new NamePrettifier(longAcronymThreshold).Prettify(input);

    [Theory]
    // If the name is all caps, then we cannot safely identify acronyms (many false positives)
    [TestCase("CANNOT_IDENTIFY_ABC_XYZ", 3, ExpectedResult = "CannotIdentifyAbcXyz")]
    public string AllUppercaseCannotIdentifyAcronyms(string input, int longAcronymThreshold = 0) =>
        new NamePrettifier(longAcronymThreshold).Prettify(input);

    [Theory]
    // This set of tests checks for how the following case is handled:
    // 1. The name is all uppercase
    // 2. The name is short (less than or equal to acronym threshold)
    // 3. There is 1 word after the name has been split
    // Note that these names typically become Pascal cased anyway
    // since allow all caps is usually false.
    [TestCase("RGB", 4, ExpectedResult = "RGB")]
    [TestCase("RGBA", 4, ExpectedResult = "RGBA")]
    public string ShortUppercasedNames_ThatCanBeAcronyms(
        string input,
        int longAcronymThreshold = 0
    ) =>
        // Note the allow all caps
        new NamePrettifier(longAcronymThreshold).Prettify(input, true);

    [Theory]
    // This set of tests checks for how the following case is handled:
    // 1. The name is all uppercase (ignoring numbers)
    // 2. The name is short (less than or equal to acronym threshold)
    // 3. There are multiple words after the name has been split
    [TestCase("SN3D", 4, ExpectedResult = "Sn3D")]
    [TestCase("AUX0", 4, ExpectedResult = "Aux0")]
    [TestCase("I_TO_I", 4, ExpectedResult = "IToI")]
    [TestCase("REG0", 4, ExpectedResult = "Reg0")]
    [TestCase("REG_0", 4, ExpectedResult = "Reg0")]
    public string ShortUppercasedNames_ThatCannotBeAcronyms(
        string input,
        int longAcronymThreshold = 0
    ) =>
        // Note the allow all caps
        new NamePrettifier(longAcronymThreshold).Prettify(input, true);

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
    public void Lowercase_AfterNumber_IsPartOf_NewWord()
    {
        var nameTransformer = new NamePrettifier(4);

        using (Assert.EnterMultipleScope())
        {
            Assert.That(nameTransformer.Prettify("RGB16"), Is.EqualTo("Rgb16"));
            Assert.That(nameTransformer.Prettify("RGB16f"), Is.EqualTo("Rgb16F"));

            Assert.That(nameTransformer.Prettify("MONO16"), Is.EqualTo("Mono16"));
            Assert.That(nameTransformer.Prettify("MONO16f"), Is.EqualTo("Mono16F"));
        }
    }
}
