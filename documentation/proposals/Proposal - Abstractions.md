#Summary
I was turned away from OpenGL Because of the Complexity of the API. It takes 100+ lines of code to draw a triangle on screen, and I want to try to bring that down to under 50. 
I want to Propose a Optional Libary to Abstract OpenGL into Classes Like [OpenGL4Sharp](https://github.com/giawa/opengl4csharp/tree/dotnetcore/OpenGL/Constructs) or [ObjectTK](https://github.com/opentk/ObjectTK)
The goal of this is to create a easier way to learn OpenGL and to make repetative suff easier.
# Contributors
- wholesomeisland/Silk.NET Contributors
- Dylan P, Ultz Limited
# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented
#Proposed API
##Classes
### GLObject
```cs
class GLObject {
VBO vbo; //These Can be a uint, The abstractions from the examples, etc.
VAO vao;
Shader shader;
	///<summary>
    ///creates and initalizes the VBO, VAO and Shader.
    ///</summary>
	void CreateResources(float[] verts, float[] indices);
	///<summary>
    ///renders the object.
    ///</summary>
	void render();
	///<summary>
    ///disposes the VBO, VAO and Shader.
    ///</summary>
	void Dispose();
}
```
##Shader or ShaderProgram
```cs
///<summary>
///This class does not need to be implemented. it is an abstraction for a shader program.
///People may be confused if its named Shader so maybe it could be ShaderProgram instead?
///</summary>
class Shader {
    uint handle;
    void Create(string Pathtovertex, string pathtofrag);
    void Use();
    void Dispose();
}
```
##VAO
```cs
class VAO {
    uint handle;
    void Create();
    void Bind();
    void Dispose();
}
```
##Vertex Object
```cs
///<summary>
///a class simaller to the one in the tutorial. optional, and it maybe better to seperate the VBO and EBO into seprate classes so its easier for the end user.
///</summary>
class VO {
    uint handle;
    void Create();
    void Bind();
    void Dispose();
}
```
##Interfaces

```cs
//There are none, but maybe we could add some for people to make their own custom abstractions?
```