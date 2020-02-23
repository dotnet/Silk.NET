#version 330 core
layout (location = 0) in vec3 vPos;
layout (location = 1) in vec2 vUv;

uniform mat4 uModel;
uniform mat4 uView;
uniform mat4 uPerspective;

out vec2 fUv;

void main()
{
    gl_Position = uPerspective * uView * vec4(vPos, 1.0);
    fUv = vUv;
}