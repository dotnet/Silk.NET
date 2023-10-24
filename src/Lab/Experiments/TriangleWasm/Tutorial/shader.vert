#version 300 es

precision highp float;

in vec3 vPos;
in vec3 vNormal;
in vec2 vTexCoords;

uniform mat4 uModel;
uniform mat4 uView;
uniform mat4 uProjection;

out vec3 fNormal;
out vec3 fPos;
out vec2 fTexCoords;

void main()
{
    //Multiplying our uniform with the vertex position, the multiplication order here does matter.
    gl_Position = uProjection * uView * uModel * vec4(vPos, 1.0);
    //We want to know the fragment's position in World space, so we multiply ONLY by uModel and not uView or uProjection
    fPos = vec3(uModel * vec4(vPos, 1.0));
    //The Normal needs to be in World space too, but needs to account for Scaling of the object
    fNormal = mat3(transpose(inverse(uModel))) * vNormal;
    //Pass the texture coordinates straight through to the fragment shader
    fTexCoords = vTexCoords;
}
