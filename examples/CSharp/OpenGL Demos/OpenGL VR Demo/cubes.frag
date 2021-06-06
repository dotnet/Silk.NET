#version 330 core
#extension GL_ARB_explicit_uniform_location : require
layout(location = 0) out vec4 FragColor;
layout(location = 1) uniform vec3 uniformColor;
in vec2 vertexColor;
void main() {
	FragColor = (uniformColor.x < 0.01 && uniformColor.y < 0.01 && uniformColor.z < 0.01)
        ? vec4(vertexColor, 1.0, 1.0)
        : vec4(uniformColor, 1.0);
}
