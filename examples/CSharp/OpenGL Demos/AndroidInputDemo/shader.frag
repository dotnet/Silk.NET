#version 300 es

precision mediump float;

//The input variables, again prefixed with an f as they are the input variables of our fragment shader.
//These have to share name for now even though there is a way around this later on.
in vec4 fColor;
  
//The output of our fragment shader, this just has to be a vec3 or a vec4, containing the color information about
//each "fragment" or pixel of our geometry.
out vec4 FragColor;

void main()
{
    //Here we are setting our output variable, for which the name is not important.
    FragColor = fColor;
}