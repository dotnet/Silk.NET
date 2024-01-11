---
{
    "TableOfContents": {
        "Name": "1.3 - Hello Texture",
        "Url": "3-hello-Texture.html",
        "Metadata": {
            "AuthorGitHub": "lumi2021",
            "DateTimeWritten": "11/01/2024 16:00",
            "PreviewImage": ""
        }
    }
}
---

# 1.3 - Hello Texture
<?# Info "You can view the source code for this tutorial [here](../sources/1.3-final-result.html). This tutorial builds on the previous tutorial. If you haven't read it, you can do so [here](1-hello-window.html)." /?>

After a good time of work we can finaly see what we want in the screen, but obviously we need a lot to can create a good program!

Another very important thing in graphics programming is the hability to draw images. In this tutorial, you'll learn:

* What is a texture.
* How to send more data to shaders.
* How to use texture coordinates.
* How import images as textures.
* How shaders handle images.

like as before, this tutorial will feature a lot of new content and info, so we'll take it slowand good explained.

## What is a texture
Technically, textures are multidimensional objects that stores color data.

Mainly, textures store 2D data of the pixels of an image like a 2D array.
This data can be used to be sanded to a shader, in an easy away for it can read.

<?# Info "there's 1D or 3D texture objects, but we will focus on 2D" /?>

But don't think texturing objects is easily as a simple drag-and-drop! Textures needs some information to can be drawned.
The most important information that we need to send to the texture to see it on the screen is the texture coordinates.
The texture coordinate are the position of the texture in the specific vertex and at first, we will learn how to create
and read it using the shader.


## Sending more data to shaders
Having it as our next objective, let's learn how to recive more data to shaders,in the way to use it as our texture coordinates.

texture coordinates are type of data that can be easly manipulated just by the vertex, so this is the way that we use to send the
coordinates.

Let's back on our `OnLoad` function. let's update our `vertices` Array to the following:
```c#
// The quad vertices data. Now with Texture coordinates!
float[] vertices =
{
//       aPosition     | aTexCoords
     0.5f,  0.5f, 0.0f,  1.0f, 1.0f,
     0.5f, -0.5f, 0.0f,  1.0f, 0.0f,
    -0.5f, -0.5f, 0.0f,  0.0f, 0.0f,
    -0.5f,  0.5f, 0.0f,  0.0f, 1.0f
};
```

In this way, we can use the same Float Array `vertices` to store both vertex and texture coordinates, easly and fast.

If we try to run our program now...

![A really messed up quad!](../../../images/opengl/chapter1/leasson3/messed-up-quad.png)

"Oh no! We messed up with everything!" is what you should be thinking. And in the reality, yes, we do. But it's simple, we just
forgot to update the vertex position atribute pointer.

In our `VertexAttribPointer`, we declarated a size of 3 and a stride of 3 for the `aPosition` atribute.
Because of this, our Buffer is being read like this:
![Buffer reading wrong data](../../../images/opengl/chapter1/leasson3/wrong-pointers.png)

To fix this little idsue, we just need to back to our `VertexAttribPointer()`, below our shader compiling section, and
change it to:
```c#
//                                        3 position + 2 texture coordinates! \/
_gl.VertexAttribPointer(positionLoc, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), (void*)0);
```

And if we run the program now, we can see our quad back!

## Using texture coordinates
Now, we just need to prepare the shader to recive the texture coodenate values. For that we need to modify both our shaders.

Vertex Shader:
```
#version 330 core

layout (location = 0) in vec3 aPosition;
layout (location = 1) in vec2 aTextureCoord;    // < Add it

out vec2 frag_texCoords;                        // < It
//This line stores the data that we want to be recived by the fragment

void main()
{
    gl_Position = vec4(aPosition, 1.0);
    frag_texCoords = aTextureCoord;             // < And more it
    // Remember to assigin the data!
}";
```z

Fragment Shader:
```
#version 330 core

in vec2 frag_texCoords; // < Add it
// frag_texCoords come from vertex shader!

out vec4 out_color;

void main()
{
    // This will allow us to see the texture coords in action!
    out_color = vec4(frag_texCoords.x, frag_texCoords.y, 0, 1.0);
}
```

Now we just need to assigin the correct pointer to `aTextureCoord`. You should add these lines below our first atribution:

```c#
const uint texCoordLoc = 1;
_gl.EnableVertexAttribArray(texCoordLoc);
_gl.VertexAttribPointer(texCoordLoc, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), (void*)(3 * sizeof(float)));
```

Pay attention in the last parameter, the pointer! It represents the size of bytes that that should be jumped in the start of
each stride. It means GL will add 3 indexes after stride and pick the consecutive 2 values.
if you did everything right, you will see this result!

![Quad with UVs](../../../images/opengl/chapter1/leasson3/quad-with-uvs.png)


## importing images as textures

## handling texture data in shader


## Wrapping up
You've just completed your first Silk.NET tutorial! Here's some next steps you can take:
* Move on to the [next tutorial](2-hello-quad.html), where you'll learn how to create a GL context and display a quad on the screen.
* View the full tutorial source code on the [Silk.NET git repository](https://github.com/dotnet/Silk.NET/tree/main/examples/CSharp/OpenGL%20Tutorials/Tutorial%201.1%20-%20Hello%20Window).
* Join the [Discord server](https://discord.gg/DTHHXRt), where you can ask questions, show your stuff, and chat with everyone there.
