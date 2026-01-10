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
            Assert.That(
                NamePrettifier.BreakIntoWords("HelloWorld"),
                Is.EqualTo(["Hello", "World"])
            );
        }
    }

    [Test]
    public void SplitBySeparator()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(
                NamePrettifier.BreakIntoWords("Hello_World"),
                Is.EqualTo(["Hello", "World"])
            );
            Assert.That(
                NamePrettifier.BreakIntoWords("_Hello_World_"),
                Is.EqualTo(["Hello", "World"])
            );
        }
    }

    [Test]
    public void PreserveAcronym()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(NamePrettifier.BreakIntoWords("HelloUI"), Is.EqualTo(["Hello", "UI"]));
            Assert.That(NamePrettifier.BreakIntoWords("HelloGUI"), Is.EqualTo(["Hello", "GUI"]));
            Assert.That(NamePrettifier.BreakIntoWords("GUIHello"), Is.EqualTo(["GUI", "Hello"]));
            Assert.That(NamePrettifier.BreakIntoWords("GUI_Hello"), Is.EqualTo(["GUI", "Hello"]));
            Assert.That(
                NamePrettifier.BreakIntoWords("ABC_XYZ_Hello"),
                Is.EqualTo(["ABC", "XYZ", "Hello"])
            );
        }
    }

    [Test]
    public void SplitByNumber()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(NamePrettifier.BreakIntoWords("123"), Is.EqualTo(["123"]));
            Assert.That(NamePrettifier.BreakIntoWords("A123A"), Is.EqualTo(["A", "123", "A"]));
            Assert.That(NamePrettifier.BreakIntoWords("a123a"), Is.EqualTo(["a", "123", "a"]));
        }
    }

    [Test]
    public void SplitNumberOtherNumberPattern()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(NamePrettifier.BreakIntoWords("8x8"), Is.EqualTo(["8", "x", "8"]));
            Assert.That(NamePrettifier.BreakIntoWords("8X8"), Is.EqualTo(["8", "X", "8"]));
        }
    }
}
