#version 300 es

precision mediump float;

//These lines specify the location and type of our attributes,
//the attributes here are prefixed with a "v" as they are our inputs to the vertex shader
//this isn't strictly necessary though, but a good habit.
layout (location = 0) in vec3 vPos;
layout (location = 1) in vec4 vColor;


//This is our output variable, notice that this is prefixed with an f as it's the input of our fragment shader.
out vec4 fColor;

void main()
{
    gl_Position = vec4(vPos, 1.0);

    fColor = vColor;
    gl_PointSize = 10.0;
}