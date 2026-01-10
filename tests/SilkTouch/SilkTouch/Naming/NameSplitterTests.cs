// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.UnitTests.Naming;

public class NameSplitterTests
{
    [Test]
    public void SplitNumberOtherNumberPattern()
    {
        Assert.That(NamePrettifier.BreakIntoWords("8x8"), Is.EqualTo(["8", "x", "8"]));
        Assert.That(NamePrettifier.BreakIntoWords("8X8"), Is.EqualTo(["8", "X", "8"]));
    }
}
