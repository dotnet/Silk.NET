---
{
    "TableOfContents": {
        "Name": "Announcing Silk.NET 2.0 Preview 3",
        "Url": "silk20pre3.html",
        "Metadata": {
            "AuthorGitHub": "Perksey",
            "PreviewImage": "images/blog/nov-2020/triangledroid.jpg",
            "DateTimeWritten": "17/11/2020 21:52"
        }
    }
}
---

# Announcing Silk.NET 2.0 Preview 3

Woah, this is different. A dedicated blog for Silk.NET and other development news? This is new. I guess now I have to get used to talking about releases instead of that boilerplate Discord announcement we do every now and then. Whether that's a good thing or a bad thing is up to you, but it gives me a chance to talk about all the great things we've been working on for Preview 3.

Today, we’re releasing Silk.NET 2.0 Preview 3. It contains a lot of the bigger features that will define the 2.0 release that are a first for Silk.NET. Please install Preview 3, and test any workloads you can with it!
You can download Silk.NET 2.0 Preview 3 from NuGet: https://nuget.org/packages/Silk.NET/2.0.0-preview3.

## Patch notes at a glance
Don't need the full scoop? No worries, here's a summary of what's been going on:

1. Experimental Android support
1. Experimental iOS support
1. Add static linking support to SilkTouch
1. Surface API improvements
1. SilkTouch improvements
1. OpenCL and OpenAL improvements
1. Other miscellaneous bug fixes and improvements

This update was a bear to get out, but it was worth taking the extra time to get it all fully working before getting it in your hands. We apologise for the delays, however, and for any inconvenience caused by them.

Let's look at some of the new Silk.NET features and improvements in 2.0 Preview 3.

## Mobile support

![A triangle on an Android phone with a plant behind it.](/images/blog/nov-2020/triangledroid.jpg)

_(The plant's name is frank)_

Many have been waiting for this for a long time, a windowing and OpenGL bindings library that truly is cross-platform. Now we're happy to be making steps towards this with one of Preview 3's largest features: experimental Android and iOS support. Currently, we have successfully ran an amalgamation of our Triangle and InputTest lab applications on Android and iOS simulators, as well as on an Android device to great avail pictured above.

In Silk.NET 1.x, we used a third-party library called the Graphics Library Framework (GLFW) to handle windowing and input across multiple desktop platforms, over which we wrote an abstraction that you have come to know and love as Silk.NET.Windowing.

Originally, this led to questions such as "why make an abstraction if there's only one platform?". This is because we've always known there'll be more than one platform. GLFW is modern, but only supports Windows, macOS, and Linux. To help us expand further to these mobile platforms we're using an older library called Simple DirectMedia Layer (SDL). This library is a lot clunkier, but at the same time it's battle-tested (most notably in Valve's amazing line-up of games) and has a much wider range of platforms it supports.

Now, before you get ahead of yourself, our mobile support is experimental! This is to make sure I, and our other lovely developers, don't have to rock themselves to sleep every night thinking about the maintenance nightmare that marking these as ready would ensue. But feel free to have a play around with them in a non-production environment! You can find our Android and iOS applications in the Silk.NET Lab.

## Native AOT support
Prior to Preview 3, Silk.NET used a lot of reflection magic which meant that in most cases, it just worked! For example, Silk.NET.Windowing wouldn't know whether Silk.NET.Windowing.Glfw exists at compile-time, so at runtime it does a check for it using reflection. This means that you only have to reference and ship the packages you actually use.

However, when we embarked on a Silk.NET Lab project to get Silk.NET running on Microsoft's experimental Native AOT runtime (formerly known as CoreRT), we hit a bump because reflection is notoriously inconsistent in ahead-of-time compiled scenarios such as Native AOT.

In most of these scenarios, however, we realised that despite Silk.NET.Windowing not knowing about the Glfw package, the Glfw package knew about the Windowing package and, more importantly, the actual application knows about both. This means that, at your command, you're able to tell Glfw to tell Windowing that it exists all without reflection, using a simple one liner like so:

```cs
GlfwWindowing.RegisterPlatform();
GlfwInput.RegisterPlatform();
```

After doing that at the beginning of your program, Silk.NET won't need to touch reflection at all and everything else should fall into place.

## Closing
Silk.NET 2.0 Preview 3 is a massive feature update and is recommended for any existing users of the 2.0 previews. As the 2.0 preview cycle goes on, we hope to bring Silk.NET a number of new features and by extension opportunities, which we can't wait to see you take advantage of. You can download Silk.NET 2.0 Preview 3, as you always have, from NuGet.
