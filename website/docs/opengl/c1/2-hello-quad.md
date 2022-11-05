---
{
    "TableOfContents": {
        "Name": "1.2 - Hello Quad",
        "Url": "2-hello-quad.html",
        "Metadata": {
            "AuthorGitHub": "ohtrobinson",
            "DateTimeWritten": "02/11/2022 12:00",
            "PreviewImage": ""
        }
    }
}
---

# 1.2 - Hello Quad
> [!Note]
> You can view the source code for this tutorial [here.](https://github.com/dotnet/Silk.NET/blob/main/examples/CSharp/OpenGL%20Tutorials/Tutorial%201.2%20-%20Hello%20quad/Program.cs) This tutorial builds on the previous tutorial. If you haven't read it, you can do so [here.](1-hello-window.html)

Let's draw something on-screen! In this tutorial, you'll learn:
* How to initialize OpenGL.
* What vertex array objects, vertex buffers, and element array buffers are, and how to use them.
* How to create and use shaders.
* How the OpenGL pipeline works.

This tutorial will feature a lot of content and new info, so we'll take it slow and with lots of explanations.

## Initializing OpenGL
The first thing we need to do before we can issue OpenGL commands, is to initialize it. Fortunately, Silk.NET windowing does most of the hard part for us, and we only have to get the GL api.

Add the following using directive to the top of your file, you'll need this to use OpenGL:

```cs
using Silk.NET.OpenGL;
```

Then, at the top of your class, add the following:

```cs
private static GL _gl;
```

Finally, in your `OnLoad` method, add the following:

```cs
_gl = GL.GetApi(_window);
```

What are we doing here? Silk.NET requires you to keep a **reference** to the OpenGL API. If you've used or seen OpenGL in C, you'll notice that this is different to the way that it is done there. This is done so that you can more easily keep track of multiple contexts. If you don't know what that is, don't worry about it for now, we won't be using it in these tutorials.

> [!Warning]
> You may think you can call `GL.GetApi()` in each class that uses OpenGL, but you can't. `GetApi()` returns a **new** instance of the OpenGL API, and you are instead expected to pass around the existing GL reference. In essence, unless you are creating multiple contexts, you should only call `GL.GetApi()` **once** per application.

