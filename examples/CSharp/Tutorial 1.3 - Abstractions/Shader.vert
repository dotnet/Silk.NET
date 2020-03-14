#version 330 core
layout (location = 0) in vec3 vPos;
layout (location = 1) in vec4 vColor;

uniform float uBlue;

out vec4 fColor;

void main()
{
    gl_Position = vec4(vPos, 1.0);
    vec4 color = vec4(vColor.rb / 2, uBlue, vColor.a); //Swizzling and constructors in glsl.
    fColor = color;
}