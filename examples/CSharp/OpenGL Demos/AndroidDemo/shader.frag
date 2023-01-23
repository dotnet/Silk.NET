#version 300 es

precision mediump float;

in vec2 fUv;

//A uniform of the type sampler2D will have the storage value of our texture.
uniform sampler2D uTexture0;

out vec4 FragColor;

void main()
{
    //Here we sample the texture based on the Uv coordinates of the fragment
    FragColor = texture(uTexture0, fUv);
}