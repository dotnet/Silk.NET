// For more information on how shaders work, check out the web version of this tutorial
// I'll include a simpler summary here.

// First non-comment line should always be a #version statement; this just tells the GLSL compiler what version it should use
#version 330 core

// GLSL's syntax is somewhat like C, but it has a few differences.

// There are four different types of variables in GLSL: input, output, uniform, and internal.
// Input variables are sent from the buffer, in a way defined by GL.VertexAttribPointer.
// Output variables are sent from this shader to the next one in the chain (which will be the fragment shader most of the time)
// Uniforms will be touched on in the next tutorial
// Internal variables are defined in the shader file and only used there.


// The vertex shader is run once for every vertex. In C# pseudocode, it might look something like:
// foreach(var vertex in vertices)
//   shader(vertex)


// This defines our input variable, aPosition.
// It starts with the line "layout(location = 0)". This defines where this input variable will be located, which is needed for GL.VertexAttribPointer
// However, you can omit it, and replace this with just "in vec3 aPosition". If you do that, you'll have to replace the 0 in GL.VertexAttribPointer with
//   a call to GL.GetAttribLocation(shaderHandle, attributeName)
// Next, the keyword "in" defines this as an input variable. We'll have an example of the "out" keyword in the next tutorial.
// Then, the keyword "vec3" means this is a vector with 3 floats inside.

layout(location = 0) in vec3 aPosition;


// Like C, we have an entrypoint function. In this case, it takes void and returns void, and must be named main.
// You can do all sorts of calculations here to modify your vertices, but right now, we don't need to do any of that.
// gl_Position is the final vertex position; pass a vec4 to it and you're done.
// Keep in mind that we only pass a vec3 to this shader; the fourth component of a vertex is known as "w".
// It's only used in some more advanced OpenGL functions; it's not needed here.
// so with a call to the vec4 function, we just give it a constant value of 1.0

void main(void)
{
    gl_Position = vec4(aPosition, 1.0);
}