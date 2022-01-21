#version 300 es
// OpenGLES shaders are almost identical to regular OpenGL ones.
// Main difference is of course the #version line, and now we also need to specify
// precision used for floating point operations. See: https://forum.defold.com/t/opengl-es-shader-precision-modifiers-lowp-mediump-highp/52368

precision mediump float;

layout (location = 0) in vec3 vPos;
layout (location = 1) in vec2 vUv;

out vec2 fUv;

void main()
{
    gl_Position = vec4(vPos, 1.0);
    //Setting the uv coordinates on the vertices will mean they get correctly divided out amongst the fragments.
    fUv = vUv;
}