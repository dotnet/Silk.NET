// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.UnitTests.Naming;

public class NameUtilsTests
{
    [Test]
    public void RegressionNamespacePrefixDetermination() =>
        Assert.That(
            NameUtils.FindCommonPrefix(["Silk.NET.SDL", "Silk.NET.SDL"], true, false, true),
            Is.EqualTo("Silk.NET.SDL")
        );
}
