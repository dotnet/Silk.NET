---
{
    "TableOfContents": {
        "Name": "Silk.NET, .NET 6, and the Sunsetting of Xamarin Support",
        "Url": "xamarin-deprecation.html",
        "Metadata": {
            "AuthorGitHub": "Perksey",
            "DateTimeWritten": "12/11/2021 23:00",
            "PreviewImage": "images/blog/nov-2021/dotnet-bot-selfie-stick.png"
        }
    }
}
---

# Silk.NET, .NET 6, and the Sunsetting of Xamarin Support

Silk.NET is coming up on 2.5 years old now, and a lot has happened during that time. Silk.NET has released 2 major updates, in addition to 25 other patches and 5 previews in that time. Furthermore, across all of our packages we have amassed just over 1,000,000 downloads, we've joined the .NET Foundation, we've seen use in multiple sizeable games and game engines, we've had users who worked for Blizzard, Microsoft, HP; and so much more that's happened over the past 2.5 years that to list all of it you'd be reading for quite a while.

One of the things Silk.NET prides itself in is keeping up with the times. We have monthly updates which regenerate all of our bindings against the latest versions of their respective headers and specifications, to ensure we're always bringing you the latest and greatest features exposed by the native APIs we bind to. In addition, we're always quick to adopt new platform features as soon as possible.

For example, Silk.NET adopted C# 9 Source Generators before they were in general availability, as well as C# 9 Function Pointers and C# 9 native integers. We first started on .NET Core 2.1, and since then we've seen the release of .NET Core 3, .NET 5, and now .NET 6; and with every new .NET version we've taken the opportunity to improve at least *something* using the new features added in that particular update, be it loader improvements, performance enhancements, or whatever else.

Which brings us now to .NET 6.

## .NET 6

.NET 6 is the largest, final step towards the ecosystem unification that .NET 5 originally aimed to achieve: instead of having a .NET Framework, .NET Core, Xamarin iOS, Xamarin Android, etc; why can't we just have one: ".NET"? As of .NET 6, that dream is pretty much complete. Other than UWP, which Silk.NET didn't support anyway, we now have all platforms at our disposal with one target framework, one Base Class Library (BCL), one SDK, and one build system (`dotnet build`).

Today, **Silk.NET supports the release .NET 6 SDK**, and its Windowing and Input abstractions have officially supported Android and experimentally supported iOS for some time now, both through .NET 6 and Xamarin. However, because of how different Xamarin is to modern .NET mobile, we have had to write and maintain a lot of code for this.

## Silk.NET 2.X's Maintainability

Throughout the last 2.5 years, we have been learning as we went. This little corner of the ecosystem is very fast-moving, and it's hard to keep with what the "best practice" is considering by the time the community has decided on one, we had already written our code. As a result, a lot of the Silk.NET code (particularly our two generators BuildTools and SilkTouch) have grown in very strange ways, with the codebases being very large, meandering, and very hard to maintain. This doesn't help when, as mentioned before, we'd frequently added special cases and different generation paths; be it for Xamarin, a new feature we're trying out, or so on... While this complexity only leaked out to users in extremely rare cases, it's a massive blocker for contributors and us maintainers.

We've been putting lots of thought into the design of Silk.NET 3.0, the future of Silk.NET and our upcoming planned full rewrite of the library (compared to 2.X which was just a partial rewrite & evolution of 1.X) and work on designing this to be the best library we can be continues to this day, but until then we're still stuck maintaining 2.X in all its complexity.

As such, anywhere we can start chipping away at this codebase can help us massively for the (hopefully shorter than we think) time in which we need to keep maintaining 2.X before 3.0 is fully out-the-door. 

## Sunsetting of Legacy Xamarin Support

Shortly before Silk.NET 2.9 released, we announced in our Discord server that to encourage our users to move to .NET 6, as well as to reduce a significant amount of maintenance overhead and contributor friction, the last update before the .NET 6 LTS release (2.10) will be the last to support Legacy Xamarin. Since then, Silk.NET 2.10 has released.

Back when .NET 6 was first announced, the idea was that its Android and iOS support were going to be generally available with the SDK itself, and the similar (but different) MAUI plans remaining in preview while the Xamarin team ported over everything from Xamarin Forms into MAUI. These plans have now slipped, with .NET 6 Android and .NET 6 iOS still being in preview today.

Nonetheless, the majority of our users who are using Silk.NET on Android and iOS are using .NET 6, and the maintainence cost of having support for Android and iOS via both legacy Xamarin and modern .NET 6 is too significant to justify supporting the minority of users who aren't using .NET 6.

Given this, as well as the excellent stability of .NET 6 Android and iOS insofar, we are sticking to our original plans to **remove support for legacy Xamarin** despite .NET 6 Android and iOS still technically being in preview.

We apologise for the inconvenience this might cause for some of you, but please understand that we're all maintaining this in our free time and if there's something blocking us from using that limited free time in the most efficient & effective way without significant reason for it doing so, chances are it needs to go. 

**Please move your Silk.NET mobile applications to .NET 6**. 2.11 will only officially support mobile on .NET 6, and all code in our Windowing and Input abstractions to support legacy Xamarin will be removed.

Thank you for your continued support.

<sub>
Note: This does not change the "experimental" status of our iOS support. We still only officially support Android today, despite iOS working in some capacity.
</sub>
