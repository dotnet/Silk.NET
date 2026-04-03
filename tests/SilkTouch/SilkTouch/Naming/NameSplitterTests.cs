// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.UnitTests.Naming;

public class NameSplitterTests
{
    [Test]
    public void SplitByCasing()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(NameSplitter.SplitIntoWords("HelloWorld"), Is.EqualTo(["Hello", "World"]));
        }
    }

    [Test]
    public void SplitBySeparator()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(NameSplitter.SplitIntoWords("Hello_World"), Is.EqualTo(["Hello", "World"]));
            Assert.That(
                NameSplitter.SplitIntoWords("_Hello_World_"),
                Is.EqualTo(["Hello", "World"])
            );
        }
    }

    [Test]
    public void PreserveAcronym()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(NameSplitter.SplitIntoWords("HelloUI"), Is.EqualTo(["Hello", "UI"]));
            Assert.That(NameSplitter.SplitIntoWords("HelloGUI"), Is.EqualTo(["Hello", "GUI"]));
            Assert.That(NameSplitter.SplitIntoWords("GUIHello"), Is.EqualTo(["GUI", "Hello"]));
            Assert.That(NameSplitter.SplitIntoWords("GUI_Hello"), Is.EqualTo(["GUI", "Hello"]));
            Assert.That(
                NameSplitter.SplitIntoWords("ABC_XYZ_Hello"),
                Is.EqualTo(["ABC", "XYZ", "Hello"])
            );
        }
    }

    [Test]
    public void SplitByNumber()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(NameSplitter.SplitIntoWords("Image2D"), Is.EqualTo(["Image", "2", "D"]));
            Assert.That(NameSplitter.SplitIntoWords("123"), Is.EqualTo(["123"]));
            Assert.That(NameSplitter.SplitIntoWords("A123A"), Is.EqualTo(["A", "123", "A"]));
            Assert.That(NameSplitter.SplitIntoWords("a123a"), Is.EqualTo(["a", "123", "a"]));
        }
    }

    [Test]
    public void SplitNumberOtherNumberPattern()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(NameSplitter.SplitIntoWords("8x8"), Is.EqualTo(["8", "x", "8"]));
            Assert.That(NameSplitter.SplitIntoWords("8X8"), Is.EqualTo(["8", "X", "8"]));
        }
    }

    [Test]
    public void ComplexCases()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(
                NameSplitter.SplitIntoWords("SpvImageFormatR32ui"),
                Is.EqualTo(["Spv", "Image", "Format", "R", "32", "ui"])
            );
        }
    }
}
