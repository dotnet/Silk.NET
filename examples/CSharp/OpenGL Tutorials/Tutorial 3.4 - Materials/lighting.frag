#version 330 core
in vec3 fNormal;
in vec3 fPos;

struct Material {
    vec3 ambient;
    vec3 diffuse;
    vec3 specular;
    float shininess;
};

struct Light {
    vec3 position;
    vec3 ambient;
    vec3 diffuse;
    vec3 specular;
};

uniform Material material;
uniform Light light;
uniform vec3 viewPos;

out vec4 FragColor;

void main()
{
      vec3 ambient = light.ambient * material.ambient;

      vec3 norm = normalize(fNormal);
      vec3 lightDirection = normalize(light.position - fPos);
      float diff = max(dot(norm, lightDirection), 0.0);
      vec3 diffuse = light.diffuse * (diff * material.diffuse);

      vec3 viewDirection = normalize(viewPos - fPos);
      vec3 reflectDirection = reflect(-lightDirection, norm);
      float spec = pow(max(dot(viewDirection, reflectDirection), 0.0), material.shininess);
      vec3 specular = light.specular * (spec * material.specular);

      //The resulting colour should be the amount of ambient colour + the amount of additional colour provided by the diffuse of the lamp + the specular amount
      vec3 result = ambient + diffuse + specular;

      FragColor = vec4(result, 1.0);
}