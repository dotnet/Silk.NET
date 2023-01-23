---
{
    "TableOfContents": {
        "Name": "Announcing the Silk.NET Community",
        "Url": "silkcommunity.html",
        "Metadata": {
            "AuthorGitHub": "Perksey",
            "DateTimeWritten": "02/01/2022 20:00",
            "PreviewImage": "images/blog/jan-2022/silkcommunity.png"
        }
    }
}
---

# Announcing the Silk.NET Community program

Over the years, Silk.NET has grown in many directions into many different shapes and sizes. With this, came an influx of a variety of users using Silk.NET for all sorts of brilliant use cases. We do our best to cater for everyone, but we're always watching out for scope creep and maintenance cost. As a result, in some cases we just can't provide for some users in Silk.NET itself, which is meant to be general-purpose and is a large enough library as-is.

This leads the community whip up their own libraries to cater for their needs, but more often than not someone else comes along with similar needs uncatered for by Silk.NET itself. We point them at the community's library, but they choose not to adopt it due to lack of perceived maturity, popularity, or whatever else.

To solve this problem, we are introducing a new facet to the Silk.NET project: The Silk.NET Community - a home for useful community-maintained extensions for the Silk.NET library recognised by the official Silk.NET maintenance team.

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

With the launch of the Silk.NET Community, we have already brought two projects on-board for the "pilot". These are:

## TrippyGL

TrippyGL is a graphics library that aims to make OpenGL easier to use. It provides a set of functionality similar to libraries like MonoGame, while allowing you greater control of your application and the graphics system by focusing on OpenGL.

TrippyGL is built for .NET Standard 2.1, which means you can run this on any .NET Standard 2.1 compliant platform such as .NET Core!

Checkout TrippyGL here: [https://github.com/SilkCommunity/TrippyGL](https://github.com/SilkCommunity/TrippyGL)

## SilkyNvg

SilkyNvg is a C#-ified port of Mikko Memononen's popular vector graphics C library NanoVG. It tries to remain close to the original API while also adapting to fit in better with C# code (e.g. the interface is completely safe). It is built to have easily interchangeable rendering pipelines (including your own custom renderers), with OpenGL and Vulkan renderers built with Silk.NET provided out-of-the-box.

SilkyNvg exists because the NanoVG library is likely the best vector-graphics API currently available, yet it's use outside of C/C++ has generally been difficult with ports mostly depending on bindings and providing your own native DLLs. Instead, SilkyNvg is written purely in C# using .NET 5 to enable simple cross-platform use (no extra native dependencies!).

Checkout SilkyNvg here: [https://github.com/SilkCommunity/SilkyNvg](https://github.com/SilkCommunity/SilkyNvg)

## Get your project involved!

We'd love your help in growing the Silk.NET Community to be the one source for as many useful extensions to Silk.NET as humanly possible! If you have a library that builds on top of Silk.NET or interacts with Silk.NET in some way (be it a model loader, abstraction over many Silk.NET APIs, or whatever else), we'd love to hear from you! Simply [open a submission issue on GitHub](https://github.com/SilkCommunity/SilkCommunity/issues/new?assignees=Perksey%2C+ThomasMiz%2C+HurricanKai&labels=project+submission&template=project-submission.md&title=Project+Submission%3A+) and we'll get back to you. If you're unsure, open one anyway and we'll let you know!
