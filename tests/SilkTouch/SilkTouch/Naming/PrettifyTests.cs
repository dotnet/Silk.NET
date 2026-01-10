// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.UnitTests.Naming;

public class PrettifyTests
{
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
