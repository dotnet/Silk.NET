#Summary
I was turned away from OpenGL Because of the Complexity of the API. It takes 100+ lines of code to draw a triangle on screen, and I want to bring that down to under 50. 
I want to Propose a Optional Libary to Abstract OpenGL into Classes Like [OpenGL4Sharp](https://github.com/giawa/opengl4csharp) or [ObjectTK](https://github.com/opentk/ObjectTK)
The goal of this is to create a easier way to learn OpenGL and to make repetative suff easier.
#Current Status
# Current Status
- [ ] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented
#Proposed API
##Classes
```cs
class GLObject{
VBO vbo; //These Can be a uint, The abstractions from the examples, etc.
VAO vao;
Shader shader;
	void CreateResources(float[] verts, float[] indices){
	shader = new Shader("Path to vertex shader", "Path To frag shader");
	vbo = new VBO(verts, indices, Gl);
	vao = new VAO();
	}
	void render(){	
	vao.Bind();
	Shader.Bind();
	Gl.DrawElements();
	}
	void Dispose(){
	Shader.Dispose();
	vao.Dispose();
	vbo.Dispose();
	}
}