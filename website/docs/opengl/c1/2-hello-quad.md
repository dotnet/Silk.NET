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
<?# Info "You can view the source code for this tutorial [here.](https://github.com/dotnet/Silk.NET/blob/main/examples/CSharp/OpenGL%20Tutorials/Tutorial%201.2%20-%20Hello%20quad/Program.cs) This tutorial builds on the previous tutorial. If you haven't read it, you can do so [here.](1-hello-window.html)" /?>

Let's draw something on-screen! In this tutorial, you'll learn:

* How to initialize OpenGL.
* How to clear the window.
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
_gl = _window.CreateOpenGL();
```

What are we doing here? Silk.NET requires you to keep a **reference** to the OpenGL API. If you've used or seen OpenGL in C, you'll notice that this is different to the way that it is done there. This is done so that you can more easily keep track of multiple contexts. If you don't know what that is, don't worry about it for now, we won't be using it in these tutorials.

<?# Info "If you take a look at the source in the Silk.NET samples repository, you will notice that it uses `_gl = GL.GetApi(_window)`. This is another way to get the GL API, however when using Silk.NET windowing, it's recommended that you use `_window.CreateOpenGL()` instead." /?>

Now, run your application again. If all is good, you should see no change. Awesome! Let's do our first steps in OpenGL: Clearing the window.

## Clearing the window
Before we start this, let's take a look at what makes up an OpenGL window. 

A window consists of several **framebuffers**. A framebuffer is essentially a texture that can be drawn to by OpenGL. An OpenGL window will consist of the following framebuffers:

* Color buffer
* Depth stencil buffer

On top of this, a window will often contain at least two of these buffers. This is known as **double-buffering** and is imperitive for VSync to work properly. One buffer is displayed, while another is rendered to. 

This is what makes up the **swapchain**, which, if you've ever looked into Direct3D, you should be familliar with. OpenGL does not use the term, nor does it allow you to manage this yourself, however it is still in the background, and it is helpful to know this.

Now that we know this, we can get on with clearing the window.

Add the following using directive to the top of your file:

```cs
using System.Drawing;
```

Then, in your `OnLoad` method, underneath `GetApi()`, add the following:

```cs
_gl.ClearColor(Color.CornflowerBlue);
```

You may notice that this function contains various **overloads**, including ones for a Vector4, and 4 floats. We'll be using the overload that takes `System.Drawing.Color`, because it is the most readable for this example.

If you run your application now, you'll notice that the window is still black. That's because we've set the clear *color*, but not actually told OpenGL to clear the window.

In your `OnRender` method, add the following:

```cs
_gl.Clear(ClearBufferMask.ColorBufferBit);
```

Run your application again, and you should see a lovely sky blue window!

![Sky blue window](../../../images/opengl/chapter1/cornflower-window.png)

Congrats! You've done your first thing in OpenGL! Didn't work? Check the [source code](../sources/1.2.2-clear-window.html) for this section here.

But - how does OpenGL know to color the window blue? Sure, we've told it we want blue - but we only did that once... How does it know to keep using blue?

Well, this is because OpenGL is a **state machine**.

## OpenGL: The state machine
Before we can continue further, you'll have to get used to the concept that OpenGL is a **state machine**. It's really hard to understand OpenGL if you don't understand this, so read closely.

### What is a state machine?
At its core, a state machine holds... state. You set the state of something, and it retains that state until you change it.

This is exactly how OpenGL works. Once you set something, it will remain set until you change it. This counts for everything in OpenGL. Clear color, binding objects, etc etc, everything goes through the state machine. You can *manipulate* the current state, however you have to be wary at all times of what part of the state you are changing. Change the wrong thing and suddenly you program might not work!

So, this explains why clearing the window works. You set the clear color, and it remains *as* the clear color until you change it.

Now that we've got that, let's move on!

## Vertex Array Objects (VAOs)
A unique feature that modern OpenGL has is what is known as a Vertex Array Object, or VAO. It stores the state of various parameters, such as which buffers you wish to use, and the shader inputs.

This is a required feature of modern OpenGL. You **must** have a VAO bound, otherwise your application won't work.

Let's create the VAO!

At the top of your class, add the following:

```cs
private static uint _vao;
```

Then, in your `OnLoad` method, add:

```cs
_vao = _gl.GenVertexArray();
_gl.BindVertexArray(_vao);
```

What's going on here? First, we generate the VAO. Then, before we can use, or update it, we need to **bind** it.

Binding is a term you will hear a lot with OpenGL, and in these tutorials too. Binding essentially means updating the current OpenGL state with the given object. So, in this example, when we bind the VAO, we update OpenGL's state so that the VAO we are currently using is now the VAO we have just created. If you don't bind an object before updating/using it, you will use or update the previously bound object instead, which can cause problems and headaches later.

We're now ready to give the VAO some data. But first, we need a **vertex buffer**.

## Vertex Buffer Objects (VBOs)
Here is the part where we actually give the GPU some data it can work with. For 95% of graphics applications, a vertex buffer is **required** to display anything on screen.

### What is a vertex buffer?
Before we can continue, it's handy to know what a vertex buffer is, and what it does.

Let's define both vertex, and buffer.

* Vertex - A point where two lines, or edges meet.
* Buffer - A region in memory that can be accessed to be written to, or read from.

Knowing these definitions should give us a good idea of what a vertex buffer is. It's a region of memory, on the GPU, that stores points, which will get **rasterized** on-screen (usually in the form of triangles).

### Vertex data
Let's create the data that we will fill the vertex buffer with!

In your `OnLoad` function, just after you call `_gl.BindVertexArray()`, add the following:

```cs
float[] vertices =
{
     0.5f,  0.5f, 0.0f,
     0.5f, -0.5f, 0.0f,
    -0.5f, -0.5f, 0.0f,
    -0.5f,  0.5f, 0.5f
}
```

### What makes up a quad?
In modern graphics programming, you are expected to use triangles. While you may see options for quads, or lines, these are mostly deprecated.

Therefore, a quad is made of two right-angle triangles. This can best be seen if we view the result in **wireframe** mode.

![Wireframe quad](../../../images/opengl/chapter1/wireframe-quad.png)

In the image, you can also see where the four vertices go in relation to the quad. While you won't *usually* be defining vertices yourself, it's still handy to know how it works.

### Creating the buffer
Now that we've got our vertex data, let's create the buffer!

At the top of your class, add the following:

```cs
private static uint _vbo;
```

Then, in your `OnLoad` method, under where the vertices are defined, add:

```
_vbo = _gl.GenBuffer();
_gl.BindBuffer(BufferTargetARB.ArrayBuffer, _vbo);
```

Much like the VAO, we need to first generate the buffer, and then bind it. Unlike vertex arrays, however, buffers need to be bound to a **target**. Some of the more common targets include:

* `ArrayBuffer` - The vertex buffer target (which is what we're using here).
* `ElementArrayBuffer` - The index buffer target (which you'll see later).
* `UniformBuffer` - A uniform buffer, not used in this tutorial, but we'll get to it in a later tutorial.

In this case, we're binding to `ArrayBuffer` since we're creating a vertex buffer.

### Filling our buffer with data
Let's fill our buffer with some data! Before we do that though, you need to be aware of `unsafe` in C#.

#### Unsafe C#
Silk.NET heavily uses `unsafe` code. Don't worry, this won't make your computer explode, however it does exit out of the "safe" managed environment of C#, and enters a realm where undefined behaviour, segmentation faults, and strange results are more likely to occur if you are not careful.

<?# Info "If you wish to use `Span` instead, and remain in `safe` mode, Silk.NET does support these too. However, I will be using `unsafe` in this tutorial instead, as this is both what I personally use, as well as what the samples use." /?>

