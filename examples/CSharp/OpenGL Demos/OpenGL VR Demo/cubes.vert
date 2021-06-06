#version 330 core
#extension GL_ARB_explicit_uniform_location : require
layout(location = 0) in vec3 aPos;
layout(location = 2) uniform mat4 model;
layout(location = 3) uniform mat4 view;
layout(location = 4) uniform mat4 proj;
layout(location = 5) in vec2 aColor;
out vec2 vertexColor;
void main() {
    gl_Position = proj * view * model * vec4(aPos.x, aPos.y, aPos.z, 1.0);
    vertexColor = aColor;
}
