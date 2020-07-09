#version 330 core
layout (location = 0) in vec3 vPos;
layout (location = 1) in vec2 vUv;

uniform mat4 uModel;
uniform mat4 uView;
uniform mat4 uProjection;

out vec2 fUv;

void main()
{
    //Multiplying our uniform with the vertex position, the multiplication order here does matter.
    gl_Position = uProjection * uView * uModel * vec4(vPos, 1.0);
    fUv = vUv;
}