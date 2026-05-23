// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.UnitTests.Naming;

public class NameAffixerTests
{
    [Test]
    public void GetAffixes()
    {
        var member = ParseMemberDeclaration(
            """
            [NameAffix("Prefix", "SharedPrefix", "al")]
            [NameAffix("Suffix", "KhronosFunctionDataType", "v")]
            [NameAffix("Suffix", "KhronosNonVendor", "Direct")]
            [NameAffix("Suffix", "KhronosVendor", "SOFT")]
            public void alGetBufferPtrvDirectSOFT() { }
            """
        );

        var affixes = member!.AttributeLists.GetNameAffixes();

        Assert.That(
            affixes,
            Is.EqualTo(
                [
                    new NameAffix(NameAffixType.Prefix, "SharedPrefix", "al", 0),
                    new NameAffix(NameAffixType.Suffix, "KhronosFunctionDataType", "v", 1),
                    new NameAffix(NameAffixType.Suffix, "KhronosNonVendor", "Direct", 2),
                    new NameAffix(NameAffixType.Suffix, "KhronosVendor", "SOFT", 3),
                ]
            )
        );
    }

    [Test]
    public void ApplyAffixes_AddsAffixes()
    {
        Assert.Multiple(() =>
        {
            Assert.That(NameAffixer.ApplyAffixes("Name", []), Is.EqualTo("Name"));

            Assert.That(
                NameAffixer.ApplyAffixes(
                    "PresentMode",
                    [
                        new NameAffix(NameAffixType.Prefix, "Category", "Vk", 0),
                        new NameAffix(NameAffixType.Suffix, "Category", "KHR", 1),
                    ]
                ),
                Is.EqualTo("VkPresentModeKHR")
            );

            Assert.That(
                NameAffixer.ApplyAffixes(
                    "GetBufferPtr",
                    [
                        new NameAffix(NameAffixType.Prefix, "Category", "al", 0),
                        new NameAffix(NameAffixType.Suffix, "Category", "v", 1),
                        new NameAffix(NameAffixType.Suffix, "Category", "Direct", 2),
                        new NameAffix(NameAffixType.Suffix, "Category", "SOFT", 3),
                    ]
                ),
                Is.EqualTo("alGetBufferPtrvDirectSOFT")
            );
        });
    }

    [Test]
    public void StripAffixes_RemovesAffixes()
    {
        Assert.Multiple(() =>
        {
            Assert.That(NameAffixer.StripAffixes("Name", []), Is.EqualTo("Name"));

            Assert.That(
                NameAffixer.StripAffixes(
                    "VkPresentModeKHR",
                    [
                        new NameAffix(NameAffixType.Prefix, "Category", "Vk", 0),
                        new NameAffix(NameAffixType.Suffix, "Category", "KHR", 1),
                    ]
                ),
                Is.EqualTo("PresentMode")
            );

            Assert.That(
                NameAffixer.StripAffixes(
                    "alGetBufferPtrvDirectSOFT",
                    [
                        new NameAffix(NameAffixType.Prefix, "Category", "al", 0),
                        new NameAffix(NameAffixType.Suffix, "Category", "v", 1),
                        new NameAffix(NameAffixType.Suffix, "Category", "Direct", 2),
                        new NameAffix(NameAffixType.Suffix, "Category", "SOFT", 3),
                    ]
                ),
                Is.EqualTo("GetBufferPtr")
            );
        });
    }
}
