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
};
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

Much like the VAO, we need to first generate the buffer, and then bind it. Unlike vertex arrays, however, buffers need to be bound to a **target**. This allows you to bind buffers to different targets at the same time. Some of the more common targets include:

* `ArrayBuffer` - The vertex buffer target (which is what we're using here).
* `ElementArrayBuffer` - The element array buffer target (which you'll see later).
* `UniformBuffer` - A uniform buffer, not used in this tutorial, but we'll get to it in a later tutorial.

In this case, we're binding to `ArrayBuffer` since we're creating a vertex buffer.

### Filling our buffer with data
Let's fill our buffer with some data! Before we do that though, you need to be aware of `unsafe` in C#.

#### Unsafe C#
Silk.NET heavily uses `unsafe` code. Don't worry, this won't make your computer explode, however it does exit out of the "safe" managed environment of C#, and enters a realm where undefined behaviour, segmentation faults, and strange results are more likely to occur if you are not careful.

<?# Info "If you wish to use `Span` instead, and remain in `safe` mode, Silk.NET does support these too. However, I will be using `unsafe` in this tutorial instead, as this is both what I personally use, as well as what the samples use." /?>

Unsafe mode is not enabled by default, so we need to enable it. To enable it, add `<AllowUnsafeBlocks>true</AllowUnsafeBlocks>` to the `PropertyGroup` in your project's `.csproj` file.

Now let's fill the buffer!

Add the following after you create the buffer:

```cs
fixed (float* buf = vertices)
    _gl.BufferData(BufferTargetARB.ArrayBuffer, (nuint) vertices.Length, buf, BufferUsageARB.StaticDraw);
```

Let's go over what's going on here. First, we `fix` the vertices data. This prevents the garbage collector from moving it around, so we can take a pointer to the data. We tell it the target we want, the `ArrayBuffer` in this case, give it the data length, the buffer pointer, and we choose `StaticDraw` for our usage.

Now, run the program again, and if you get the same blue window, you've set the buffer data successfully!

Now, let's create the **element buffer object**.

## Element Buffer Objects (EBOs)
Unlike a vertex buffer, an element buffer is not *strictly* required to display something on screen, however not using it will require making your vertex buffer a lot larger, with a lot more duplicate data.

For those familliar with Direct3D terms, EBOs are more commonly referred to as **index buffers**, which is what this tutorial will refer to them from now on.

Take a look at the `vertices` array we defined earlier. You may have noticed that it only has four different points in it. Great! That's how you make a quad. But remember - that's not how this works. As mentioned earlier, a quad is made up of two triangles. But wait - that's six points... But we've only defined four. What's going on?

Well, that's where index buffers come in! An index buffer simply tells the GPU which points in the vertex buffer to use for each triangle.

Add the following to your `OnLoad` method:

```cs
uint[] indices =
{
    0u, 1u, 3u,
    1u, 2u, 3u
};
```

Now, you may be looking at this thinking "what is this?". Don't worry, once you know what it's doing it's quite easy to wrap your head around.

You'll notice that it contains 6 values. These values correspond to an index in our vertex buffer (notice how the maximum value is 3, which is the maximum index in our vertex buffer.)

Take a look at the [image you saw earlier](#what-makes-up-a-quad). The points are representitive of a value in the vertex buffer. If you trace each point, you'll see it's in clockwise order (top left is the first point, bottom left is the last point). Assign each of these an incrementing value from 0-3. Then, trace out the indices we defined above. You may notice that you'll trace out two triangles, making up our quad. 

Great! Hopefully you now have a better understanding of how index buffers allow you to reduce the amount of duplicate data in the vertex buffer. If we didn't use an index buffer, we'd have to define the top left, and bottom left points twice!

### Creating the buffer
Creating the EBO is very similar to creating a vertex buffer.

First, we must create and bind the buffer itself. Add the following to your `OnLoad` method:

```cs
_ebo = _gl.GenBuffer();
_gl.BindBuffer(BufferTargetARB.ElementArrayBuffer, _ebo);
```

Then, we fill the buffer with data, much in the same way as we did with the vertex buffer.

Again, add the following to your `OnLoad` method:

```cs
fixed (uint* buf = indices)
    _gl.BufferData(BufferTargetARB.ArrayBuffer, (nuint) vertices.Length, buf, BufferUsageARB.StaticDraw);
```

And that's it! In OpenGL, this is the common way you'll **create** buffers, from VBOs, to EBOs, to UBOs.

Run the program again, and if you still see the blue window, you've successfully created the EBO!

Now we can move onto the **shader**.

## Shaders
This tutorial won't go fully into detail about what shaders are and how they work, instead we'll leave that for a later tutorial, but in essence, a shader is a small program that runs on your GPU, that tells it how to process and display the data in our buffers.

There are many different types of shaders:
* Vertex
* Fragment (or Pixel, as used by Direct3D)
* Geometry
* Compute
* Tessellation

These shaders all serve different purposes, however the most commonly used shaders are the **vertex** and **fragment** shaders, and we will be using those in this tutorial.

A vertex shader is run (invoked) for every vertex in the vertex buffer. The vertex buffer is where you perform transformations, such as world and camera matrices (which we'll get into in a later tutorial).

The fragment shader is invoked for every fragment of every vertex on screen. A fragment is essentially a pixel, and Direct3D even calls them pixel shaders. As you may expect, these shaders are a lot more intensive than vertex shaders, and can often be the cause of GPU slowdowns. Fragment shaders is where you perform the stuff that gets displayed on screen, such as texturing and many forms of lighting.

For the moment, this is all you need to know about shaders. You will learn more about shaders as we progress further in this tutorial, as knowing how shaders work and operate is a vital thing to know when it comes to modern graphics programming. The sky is the limit! (Or in our case, an endless cornflower blue void...)

### The shader code
Before we can create our shader objects, we need some shader code. OpenGL uses **GLSL** (Open**GL** **S**hading **L**anguage). Syntactically, it is quite similar to C. Don't worry though, there are no pointers in sight.

#### Creating the vertex shader

Add the following to your `OnLoad` method:

```cs
const string vertexCode = @"
#version 330 core

layout (location = 0) in vec3 aPosition;

void main()
{
    gl_Position = vec4(aPosition, 1.0);
}";
```

This is our vertex shader! Let's go through it line-by-line.

First, we must tell it which GLSL version we wish to use. Since OpenGL 3.3 (the version we are using), the GLSL version corresponds to the OpenGL version. We tell it we want `core`, as we are using Core OpenGL 3.3, rather than compatibility.

Next, we define our **shader attributes**. In our example, we only have one, which is the position we defined in the vertex buffer. Remember - the vertex buffer is executed *for each* vertex in the vertex buffer, which is why we only need one value at a time. We define it at a manual "location", 0. While this is not necessary, we will be using it in this tutorial, as certain drivers (such as intel) like to use random locations if you do not specify one, which can cause many problems if you are not careful.

Much like C, we define our entry point, the `main` function. In it, we set the value of `gl_Position` to the vertex position. As we are not performing any transformations, we simply set the input value directly to the output value. `gl_Position`, which is a built-in shader variable, only accepts a `vec4` value though, so we must convert `aPosition` to `vec4` first. You may notice we use `1.0` instead of `0.0` though. While in this case it does not matter, it's a habit you should get into, as this will become very important when we start using matrices and transformations.

#### Creating the fragment shader
Our fragment shader for this example is very simple.

Add the following to your `OnLoad` method:

```cs
const string fragmentCode = @"
#version 330 core

out vec4 out_color;

void main()
{
    out_color = vec4(1.0, 0.5, 0.2, 1.0);
}";
```

In our fragment shader, we simply output a single color per vertex, in this case a reddish-orange.

Because our fragment shader is so simple, we don't use any `in` attributes for this example. However, unlike a vertex shader, a fragment shader must **always** have at least one `out` attribute. This attribute is the output color of the fragment shader itself, and must always be assigned a value. (We'll get more into this in a later tutorial). The output color is in the RGBA format. In OpenGL, the output color in the fragment shader is a **normalized** 32-bit float. Therefore, each of the RGBA values must be between 0 and 1. This is also true for our clear color too, however Silk.NET handily accepts a `System.Drawing.Color`, which we are using in this tutorial.

#### Creating the shader objects
Let's create the shader objects!

Add the following to your `OnLoad` method:

```cs
uint vertexShader = _gl.CreateShader(ShaderType.VertexShader);
_gl.ShaderSource(vertexShader, vertexCode);
```

First, we create the shader object itself. Each shader object must be assigned a **type**, in this case the vertex shader. Then we simply give the shader the code we defined earlier.

Now we need to **compile** the shader.

Add the following to your `OnLoad` method:

```cs
_gl.CompileShader(vertexShader);

_gl.GetShader(vertexShader, ShaderParameterName.CompileStatus, out int status);
if (status != (int) GLEnum.True)
    throw new Exception("Vertex shader failed to compile: " + _gl.GetShaderInfoLog(vertexShader));
```

First, we compile the shader. Then, we need to check to make sure it has compiled correctly, and if it hasn't, it needs to let us know what our error is. `glGetShader` can give us a lot of different parameters, some of which we'll be using in later tutorials. For now, we are just interested in the compile status.

The compile status returns `1` if successful, and `0` if not. If it's not successful, we throw an exception. `glGetShaderInfoLog` gets the error string for the shader, and we output that in our exception. You don't *have* to throw an exception though, you can do whatever you wish with this result. Just don't try to continue further, as you will get a link error! (We'll get to this in a minute).

We've now successfully created and compiled our vertex shader. To compile our fragment shader, simply copy and paste the code you just wrote. Just make sure to change the `ShaderType` to `FragmentShader`!

#### Creating the program
Finally, we can create the **shader program**. In OpenGL, shaders are stored in a single **program** object.

First, add the following to the top of your file:

```cs
private static uint _program;
```

Then, add the following to your `OnLoad` method:

```cs
_program = _gl.CreateProgram();
```

Now that we've created the program, we now need to attach the shaders to it and **link** them to the program.

Add the following to your `OnLoad` method:

```cs
_gl.AttachShader(_program, vertexShader);
_gl.AttachShader(_program, fragmentShader);

_gl.LinkProgram(_program);

_gl.GetProgram(_program, ProgramPropertyARB.LinkStatus, out int lStatus);
if (lStatus != (int) GLEnum.True)
    throw new Exception("Program failed to link: " + _gl.GetProgramInfoLog(_program));
```

Much like before, we must check to make sure that the program has linked correctly. Link errors are rare, most often caused by attempting to link with a shader that has failed to compile, which, assuming you implemented the checks earlier, should basically never happen.

Now that we have linked the program, it can now function by itself, and we no longer need the shader objects. Therefore, we can **detach and delete** them, freeing a bit of GPU memory.

Add the following to your `OnLoad` method:

```cs
_gl.DetachShader(_program, vertexShader);
_gl.DetachShader(_program, fragmentShader);
_gl.DeleteShader(vertexShader);
_gl.DeleteShader(fragmentShader);
```

Now, run your program again. If you get no errors, this has all worked successfully!

### Setting up the attributes
The last thing we need to do before we can begin drawing our quad to the screen is to set up the attributes. By default, OpenGL does not know how to send the data to our shader, so we must tell it.

<?# Warning "While fragment shaders (and other shaders) can have `in` attributes, the only ones you can directly set *outside* of a shader are the ones going into the vertex shader. The only way to set attributes in the fragment shader is to pass them through the vertex shader. Therefore, the attribute setup only affects the vertex shader and vertex buffer, not any other shader." /?>

Add the following to your `OnLoad` method:

```cs
_gl.UseProgram(_program);

const uint positionLoc = 0;
_gl.EnableVertexAttribArray(positionLoc);
_gl.VertexAttribPointer(positionLoc, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), (void*) 0);
```

First, we tell OpenGL to use the shader program we just created. While this is not strictly necessary, some drivers require you to use the program for the attribute setup to work properly.

`positionLoc` simply refers to the `aPosition` attribute we defined in our vertex shader earlier. Since we explicitly stated we wanted it at position 0, we must also use that here. If you decided against explicitly giving a location in your shader, you can replace the `0` with `_gl.GetAttribLocation("aPosition");` (just remember to remove the `const` too...)

Before we can use the attribute, we must first enable it. Then, we tell it what part of the data to look at.

First, we tell it the size of the attribute's data type. Since we're using a `vec3`, we tell it that the size is 3. Next up, we tell it that we're using floats. This is the most common pointer type used. The `false` tells it we don't want to normalize the values. If we did normalize them, OpenGL would convert them to between 0 and 1. Finally, we have the **stride** and **offset**.

The stride tells OpenGL the size (in bytes) of a *single* vertex. The offset tells OpenGL the offset *within* the stride of the attribute.

This diagram gives a visual explanation of what stride and offset do (credit to LearnOpenGL):

![stride and offset](../../../images/opengl/chapter1/vertex_attribute_pointer.png)

In our example, the only things we define per vertex is the position of the vertex itself, which is 3 values per vertex. Therefore, our stride is just `3 * sizeof(float)` (remember, stride is in **bytes**, so we must multiply by the size of the float primitive). Since we are only defining one attribute, we don't need to have any offset. Therefore, we can just use `0`. OpenGL expects a `void` pointer, so we must cast it to `void*`.

### Cleaning up
We're nearly there. The last thing we should do is to unbind the various buffers. While you don't *need* to do this, it will help to reduce the risk of changing a value for the wrong buffer.

Add the following code to your `OnLoad` method:

```
_gl.BindVertexArray(0);
_gl.BindBuffer(BufferTargetARB.ArrayBuffer, 0);
_gl.BindBuffer(BufferTargetARB.ElementArrayBuffer, 0);
```

Doing this means we've "un-bound" everything, so calling something like `BufferData` won't affect the buffers we've just created.

<?# Warning "You **MUST** unbind the vertex array first, before unbinding the other buffers. If you forget to do it in this order, the buffer will be unbound from the vertex buffer, meaning you'll see incorrect results when you render the object." /?>

## Drawing to the screen
It's finally time to draw to the screen! That was a lot of setup work we just did there. While it may seem like a lot to understand at first, the resulting code is actually relatively small, and 