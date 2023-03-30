//Specifying the version like in our vertex shader.
#version 330 core
//The input variables, again prefixed with an f as they are the input variables of our fragment shader.
//These have to share name for now even though there is a way around this later on.
in vec2 fUv;
  
//The output of our fragment shader, this just has to be a vec3 or a vec4, containing the color information about
//each "fragment" or pixel of our geometry.
out vec4 FragColor;

//This is how we declare a uniform, they can be used in all our shaders and share the same name.
//This is prefixed with a u as it's our uniform.
uniform sampler2D uTexture;

void main()
{
    //Here we are setting our output variable, for which the name is not important.
    FragColor = texture(uTexture, fUv);
}
