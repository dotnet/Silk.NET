#version 430 core

in vec2 frag_texCoord;

out vec4 out_color;

layout (binding = 2) uniform sampler2D Texture;

void main()
{
    out_color = texture(Texture, frag_texCoord);
}
