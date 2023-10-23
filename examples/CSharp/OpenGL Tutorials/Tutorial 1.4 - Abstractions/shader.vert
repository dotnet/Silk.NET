//Here we specify the version of our shader.
#version 330 core
//These lines specify the location and type of our attributes,
//the attributes here are prefixed with a "v" as they are our inputs to the vertex shader
//this isn't strictly necessary though, but a good habit.
layout (location = 0) in vec3 vPos;
layout (location = 1) in vec2 vUv;

//This is our output variable, notice that this is prefixed with an f as it's the input of our fragment shader.
out vec2 fUv;

void main()
{
    //gl_Position, is a built-in variable on all vertex shaders that will specify the position of our vertex.
    gl_Position = vec4(vPos, 1.0);
    //The rest of this code looks like plain old c (almost c#)
    fUv = vUv;
}
