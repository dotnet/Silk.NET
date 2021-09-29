---
{
    "TableOfContents": {
        "Name": "Go live with Silk.NET 2.0 Preview 4",
        "Url": "silk20pre4.html",
        "Metadata": {
            "AuthorGitHub": "Perksey",
            "DateTimeWritten": "08/12/2020 21:00",
            "PreviewImage": "images/blog/dec-2020/Silk20TeaseSmaller-pre4.png"
        }
    }
}
---

# Go live with Silk.NET 2.0 Preview 4

DirectX, Maths, and more. Silk.NET 2.0 Preview 4 is a big leap for Silk.NET as it's the first time we're confident enough to class 2.0 as production-ready. All that and more, happening now.

Today, we’re releasing Silk.NET 2.0 Preview 4. It contains the last of our new feature additions we're adding for 2.0's initial release date. Please install Preview 4, and test any workloads you can with it!

You can download Silk.NET 2.0 Preview 4 from NuGet: [https://nuget.org/packages/Silk.NET/2.0.0-preview4](https://nuget.org/packages/Silk.NET/2.0.0-preview4).

## Patch notes at a glance
Don't need the full scoop? No worries, here's a summary of what's been going on:
1. A generic, flexible maths library to fill in the holes left by System.Numerics
1. An initial set of Microsoft DirectX bindings
1. Miscellaenous fixes and improvements

Let's look at some of the new Silk.NET features and improvements in 2.0 Preview 4.

## Go live
Silk.NET 2.0 Preview 4 is our first 2.0 preview that we're classing as production-ready, meaning that you can use it in live production workloads if you so wish. We're working with some partners to port some massive projects over to Silk.NET 2.0 as part of the brand new "Silk Advanced Technology Group" in hopes we can streamline the process and document any "gotchas" for your benefit, as well as it being a testament to our confidence in the readiness of this preview.

We've done our best to get any breaking changes done for this preview so that once you've ported over, you most likely won't encounter any breaks when keeping up-to-date with the 2.0 preview cycle into release to manufacturing (RTM).

## Silk.NET December 2020 Final Update (v1.9.0)
Today, we're also announcing the final release of Silk.NET 1.x. I know, as if we've tucked it all the way in here among all the 2.0 noise! The fact of the matter is, there's not really that many changes left for 1.x. The patch notes are:
1. Update to the latest specifications
1. Miscellaneous bug fixes and improvements

Now, enough meta jibber jabber. Let's take a look at what's new for Preview 4:

## DirectX bindings
At long last, Silk.NET is endevouring into the Windows SDK world! This has been of popular demand since Silk.NET's inception, both internally and externally, so that developers can wield the power of DirectX and get a little performance boost on Microsoft platforms.

This initial iteration has Direct3D 9, Direct3D 11, Direct3D 12, DXGI, XAudio, and XInput bindings. However, in the future we want to expand this to the entire DirectX lineup and, eventually, more of the Windows SDK.

It's only a small initial set for now, however it fills in the little hole left by SharpDX, the previous leader in this space, which now unfortunately is obsolete and no longer receiving updates.

With Preview 4, we're starting to cast our net a lot wider with regards to our coverage of graphics and compute workloads. My hope is that one day Silk.NET will be the one and only library you absolutely need for all graphics and compute workloads in .NET, and with DirectX this preview and Metal on the way post-2.0, it may not be just a dream for long.

## Mathematics
In Silk.NET 1.x, we opted for System.Numerics because of its ability to use SIMD hardware intrinsics such as x86's Advanced Vector eXtensions and Streaming Simd Extensions. However, we quickly realised throughout the the 1.x lifecycle that they're just too limited - being single-precision only and exposing a thin API surface, they're not suitable for every use of Silk.NET.

Our first attempt at solving this problem was proposing a set of API proposals on the .NET Runtime. These were recently approved, but the .NET Runtime is a massive project and due to the team's scheduling issues, the new API set wasn't prioritized so close to .NET 5's release.

So we decided to bite the bullet, and whip up our own maths library. We historically avoided this due to only the runtime being able to access SIMD hardware intrinsics. However, thanks to the new System.Runtime.Intrinsics repo, we can wield the true power of your CPU from within our maths library (we're not in this preview, but just know that it's a key target of future updates). 

The new maths library supports **every numeric type** in the .NET BCL, including half-precision floats. This means that no matter what your scenario is, you should be able to use Silk.NET.Maths for your project. I don't want to go too in-depth about this as a little birdie told me that there might be a dedicated blog series on maths in the new year, so stay tuned for that ;)

## Closing

Silk.NET 2.0 Preview 4 is the last big feature update for the 2.x preview cycle and is recommended for anyone using Silk.NET - new users or existing users. As the 2.0 preview cycle comes to a close, we hope to smooth out the last wrinkles, if any, in 2.0 - the largest Silk.NET feature release to date. You can, as you always have, get Silk.NET 2.0 Preview 4 from NuGet.

###### Afterword
<p style="font-size: 0.75rem">Unfortunately we've made the decision to postpone our Metal and FEMFX bindings. There isn't significant enough demand such that we should delay the 2.0 preview cycle further, as such these bindings will be a target for 2.x.</p>
