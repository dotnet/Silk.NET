#version 430 core

layout (location = 0) in vec3 aPosition;
layout (location = 1) in vec2 aTexCoord;

out vec2 frag_texCoord;

layout (std140, binding = 0) uniform CameraInfo
{
    mat4 ProjectionMatrix;
    mat4 ViewMatrix;
};

layout (std140, binding = 1) uniform DrawInfo
{
    mat4 ModelMatrix;
};

void main()
{
    gl_Position = ProjectionMatrix * ViewMatrix * ModelMatrix * vec4(aPosition, 1.0);
    frag_texCoord = aTexCoord;
}
