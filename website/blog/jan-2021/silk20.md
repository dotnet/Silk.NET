---
{
    "TableOfContents": {
        "Name": "Announcing Silk.NET 2.0: The Largest Update To Date",
        "Url": "silk20.html",
        "Metadata": {
            "AuthorGitHub": "Perksey",
            "DateTimeWritten": "02/01/2021 18:17",
            "PreviewImage": "images/blog/jan-2021/sn20.png"
        }
    }
}
---

# Announcing Silk.NET 2.0: The Largest Update To Date

Source generators, .NET Foundation membership, mobile support, and a whole lot of bindings. There's something for everyone in Silk.NET 2.0, the largest Silk.NET update to date. Find out what's new in 2.0!

Today, we’re releasing Silk.NET 2.0, and we're not kidding when we say it's the largest Silk.NET update to date. Full stop. Period. Yep, even bigger than that 1.1 release we did a while back. Silk.NET 2.0 is the culmination of just shy of 9 months of work by lots of people, and we're super happy to finally be able to get it in your hands in all its glory!

You can download Silk.NET 2.0 from NuGet: [https://nuget.org/packages/Silk.NET/2.0.0](https://nuget.org/packages/Silk.NET/2.0.0)

## Patch notes at a glance
Don't need the full scoop? No worries, here's a summary of what's been going on:

1. Adds Assimp bindings
1. Adds SDL bindings
1. Adds a SDL windowing backend
1. Adds a new, AOT-friendly interop system (SilkTouch)
1. Adds Android support
1. Adds a generic, flexible maths library to fill in the holes left by System.Numerics
1. Adds an initial set of Microsoft DirectX bindings
1. Adds improved function pointer support
1. Adds more OpenGL framebuffer bit-depth options
1. Adds shared OpenGL contexts
1. (EXPERIMENTAL!) Adds OpenXR bindings
1. (EXPERIMENTAL!) Adds iOS support
1. Massive performance improvements
1. GLFW fixes
1. Windowing and Input fixes/refactorings
1. OpenCL and OpenAL improvements
1. Vulkan bug fixes
1. Miscellaneous bug fixes and improvements 

Once again, this update was a nightmare to get out but it's finally finished, working, and tested. Apologies for the 1 day delay, but there's no way we're giving you untested production builds...

## SilkTouch
This wasn't one of the first things we worked on for 2.0, but it's perhaps the most significant of all. In Silk.NET 2.0, we're introducing a new native library interoperability mechanism called SilkTouch. And no, we're not on about the stuff you put on your pickaxes in Minecraft.

SilkTouch is a brand new Roslyn Source Generator which replaces our clunky runtime interop IL generators such as AdvancedDLSupport (used from 1.0 Preview 1 to 1.0 Preview 3) and SuperInvoke (used from 1.0 Preview 4 to 2.0 Preview 2) which really drove up start-up time, with a new plaintext C# generator which runs at build time.

Because this runs at build time, we're really happy to bring an insane amount of massive performance improvements to Silk.NET 2.0! There are lots of benefits to the Roslyn Source Generator approach, but I'll let[] Phillip Carter from the .NET team fill you in on how they work](https://devblogs.microsoft.com/dotnet/introducing-c-source-generators/), and Kai Jellinghaus - arguably the best gift the Silk.NET maintenance team has ever received since since 1.0 released - tell you more about SilkTouch [in a new blog series on this very site](../nov-2020/silktouch-invokes-marshalling.html).

## .NET Foundation membership
Another massive development in Silk.NET isn't actually a programmatical development, but rather an organizational one. The Silk.NET team are proud to announce that the .NET Foundation has selected us to become an official project under its benevolent umbrella consisting of lots of prestigous projects, such as ImageSharp, Xamarin, and the .NET runtime itself! We'll give this a dedicated blog post later on in this quarter once we have more to share (turns out this onboarding stuff takes a while!) but this is a massive step to ensure that Silk.NET remains alive, happy, and in good hands.

## Assimp bindings
Arguably one of the most useful utilities in a graphics programmer's toolkit is a model loading library such as the Open Asset Importer library (or Assimp, yes they know how colourful the name sounds). Assimp allows you to load in dozens of model formats through one simple API! We're happy to present a new C# API surface for this, and has already been used in some cool applications such as [Voltium](https://github.com/john-h-k/Voltium), a render engine written by [John Kelly](https://github.com/john-h-k).

## Experimental OpenXR bindings
This is still experimental, but I wanted to briefly touch upon it. We've recently added support for Khronos' new extended reality (XR) platform called OpenXR. This means that you can bring your Silk.NET games and applications to new mediums such as VR and AR, with astounding industry support from Oculus/Facebook, Valve, and Microsoft. Again, still experimental because we need to play around with it more ourselves, but let us know how you get on with this if you do try it out!

## SDL bindings, windowing, and input
In Silk.NET 1.x, we used a third-party library called the Graphics Library Framework (GLFW) to handle windowing and input across multiple desktop platforms, over which we wrote an abstraction that you have come to know and love as Silk.NET.Windowing.

Originally, this led to questions such as "why make an abstraction if there's only one platform?". This is because we've always known there'll be more than one platform. GLFW is modern, but only supports Windows, macOS, and Linux.

To help us expand further to these mobile platforms we're releasing bindings and a windowing backend for an older library called Simple DirectMedia Layer (SDL). This library is a lot clunkier, but at the same time it's battle-tested (most notably in Valve's amazing line-up of games) and has a much wider range of platforms it supports. Which leads directly onto my next point...

## Mobile support

![A triangle on an Android phone with a plant behind it.](/images/blog/nov-2020/triangledroid.jpg)

_(The plant's name is frank)_

Many have been waiting for this for a long time, a windowing and OpenGL bindings library that truly is cross-platform. Now we're happy to be making steps towards this with one of 2.0's largest features: Android and experimental iOS support. Currently, we have successfully ran an amalgamation of our Triangle and InputTest lab applications on Android and iOS simulators, as well as on an Android device to great avail pictured above. This is new territory for Silk.NET, so it may have some early teething issues, but if anything that should encourage you more to play around with our Android support! Our iOS support is still experimental, but that's because we're waiting for an iOS guru to come along and help drive our iOS backend home. If this is you, join our Discord server!

If you do encounter bugs, let us know and we'll continue improving upon our mobile support as part of the Monthly Update Promise.

## Native AOT support
Prior to 2.0, Silk.NET used a lot of reflection magic which meant that in most cases, it just worked! For example, Silk.NET.Windowing wouldn't know whether Silk.NET.Windowing.Glfw exists at compile-time, so at runtime it does a check for it using reflection. This means that you only have to reference and ship the packages you actually use.

However, when we embarked on a Silk.NET Lab project to get Silk.NET running on Microsoft's experimental Native AOT runtime (formerly known as CoreRT), we hit a bump because reflection is notoriously inconsistent in ahead-of-time compiled scenarios such as Native AOT.

In most of these scenarios, however, we realised that despite Silk.NET.Windowing not knowing about the Glfw package, the Glfw package knew about the Windowing package and, more importantly, the actual application knows about both. This means that, at your command, you're able to tell Glfw to tell Windowing that it exists all without reflection, using a simple one liner like so:

```cs
GlfwWindowing.RegisterPlatform();
GlfwInput.RegisterPlatform();
```

After doing that at the beginning of your program, Silk.NET won't need to touch reflection at all and everything else should fall into place.

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
Silk.NET 2.0 is a massive feature update and is recommended for any existing users. It's worth taking the time to port over to the latest and greatest Silk.NET update no matter what your project is or how long it's been around for. Now that 2.0 is out, we'll be working with some partners on moving some massive projects over to make sure that we can really battle test this version over the next couple of months, as well as to identify possible issues when migrating from different Silk.NET versions or even different libraries. We plan to release a migration guide soon for your convenience, however Silk.NET 1.x is out of support now so if you need help moving over hop on over to our Discord server where we're happy to assist you.

You can download Silk.NET 2.0, as you always have, from NuGet.
