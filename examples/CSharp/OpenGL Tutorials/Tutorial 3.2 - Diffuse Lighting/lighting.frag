#version 330 core
in vec3 fNormal;
in vec3 fPos;

uniform vec3 objectColor;
uniform vec3 lightColor;
uniform vec3 lightPos;

out vec4 FragColor;

void main()
{
      float ambientStrength = 0.1;
      vec3 ambient = ambientStrength * lightColor;

      vec3 norm = normalize(fNormal);
      vec3 lightDirection = normalize(lightPos - fPos);
      float diff = max(dot(norm, lightDirection), 0.0);
      vec3 diffuse = diff * lightColor;

      //The resulting colour should be the amount of ambient colour + the amount of additional colour provided by the diffuse of the lamp
      vec3 result = (ambient + diffuse) * objectColor;

      FragColor = vec4(result, 1.0);
}