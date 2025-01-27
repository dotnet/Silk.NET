---
title: "Introducing JackCS to the Silk.NET Community"
authors: [Perksey]
tags: []
image: /images/blog/jan-2022/silkcommunity.png
date: 2023-03-12T18:30
---

# Introducing JackCS to the Silk.NET Community

Over the years, Silk.NET has grown in many directions into many different shapes and sizes. With this, came an influx of a variety of users using Silk.NET for all sorts of brilliant use cases. We do our best to cater for everyone, but we're always watching out for scope creep and maintenance cost. As a result, in some cases we just can't provide for some users in Silk.NET itself, which is meant to be general-purpose and is a large enough library as-is.

{/* truncate */}

This leads the community whip up their own libraries to cater for their needs, but more often than not someone else comes along with similar needs uncatered for by Silk.NET itself. We point them at the community's library, but they choose not to adopt it due to lack of perceived maturity, popularity, or whatever else.

To solve this problem, we introduced a new facet to the Silk.NET project: The Silk.NET Community - a home for useful community-maintained extensions for the Silk.NET library recognised by the official Silk.NET maintenance team.

We created the Silk.NET Community to give extra recognition to projects the Silk.NET team deem useful and trustworthy, and to serve as a single location for community projects endorsed by the Silk.NET team.

Benefits for the user:
- A single location for add-ons to Silk.NET - no need to go hunting!
- Readily-available access to mature projects that can be trusted and are endorsed by the Silk.NET team

Benefits to the community project maintainers:
- More exposure to more users
- Greater user buy-in given the "Trusted by the Silk.NET Team" image

Benefits for the Silk.NET maintainers:
- No need to envelop these projects into the main library, as a result:
    - Less work to maintain the Silk.NET library
    - Less risk of scope creep

Today we are announcing the third project to join the Silk.NET Community program: [JackCS](https://github.com/SilkCommunity/JackCS), sitting alongside the [TrippyGL](https://github.com/SilkCommunity/TrippyGL) and [SilkyNvg](https://github.com/SilkCommunity/SilkyNvg) projects that joined as part of the program's pilot.

## JackCS

JackCS provides cross-platform [Jack](https://github.com/jackaudio/jack2/) bindings for C#, generated directly from the official headers, allowing low-latency audio playback from C# code. JackCS is generated using Silk.NET's bespoke generator, so the bindings will feel right at home with all the other Silk.NET libraries you're using.

JACK Audio Connection Kit (or JACK) is a professional sound server API and pair of daemon implementations to provide real-time, low-latency connections for both audio and MIDI data between applications.

Have you ever wanted to take the audio output of one piece of software and send it to another? How about taking the output of that same program and send it to two others, then record the result in the first program? Or maybe you’re a programmer who writes real-time audio and music applications and who is looking for a cross-platform API that enables not only device sharing but also inter-application audio routing, and is incredibly easy to learn and use? If so, JACK and by extension [JackCS](https://github.com/SilkCommunity/JackCS) may be what you’ve been looking for.

- Checkout JackCS on GitHub: [https://github.com/SilkCommunity/JackCS](https://github.com/SilkCommunity/JackCS)
- Checkout JackCS on NuGet: [https://www.nuget.org/packages/JackCS](https://www.nuget.org/packages/JackCS)

JackCS is built for .NET 6 and .NET 7, providing a single framework to run on all desktop and mobile platforms supported by .NET.

## Get your project involved!

We'd love your help in growing the Silk.NET Community to be the one source for as many useful extensions to Silk.NET as humanly possible! If you have a library that builds on top of Silk.NET or interacts with Silk.NET in some way (be it a model loader, abstraction over many Silk.NET APIs, or whatever else), we'd love to hear from you! Simply [open a submission issue on GitHub](https://github.com/SilkCommunity/SilkCommunity/issues/new?assignees=Perksey%2C+ThomasMiz%2C+HurricanKai&labels=project+submission&template=project-submission.md&title=Project+Submission%3A+) and we'll get back to you. If you're unsure, open one anyway and we'll let you know!
