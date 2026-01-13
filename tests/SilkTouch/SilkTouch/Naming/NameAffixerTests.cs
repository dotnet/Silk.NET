// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.UnitTests.Naming;

public class NameAffixerTests
{
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
