module Shader

open System
open Silk.NET.OpenGL

// Used to load and compile the vertex and fragment shaders
let private createShader (gl: GL) (shaderType: GLEnum) path =
    let shader = gl.CreateShader(shaderType)
    let source = IO.File.ReadAllText(path)

    // Load and compile the shader
    gl.ShaderSource(shader, source)
    gl.CompileShader(shader)

    // Throw an exception if compiling the shader failed
    // The info log will tell us what line the shader failed on
    // so we can inspect the source.
    if gl.GetShader(shader, GLEnum.CompileStatus) <> 1 then
        let info = gl.GetShaderInfoLog(shader)
        gl.DeleteShader(shader)
        failwith (sprintf "Error creating shader: %A" info)

    shader


let create (gl: GL) =
    // Load and compile our vertex and fragment shaders
    let vertexShader = createShader gl GLEnum.VertexShader "shader.vert"
    let fragmentShader = createShader gl GLEnum.FragmentShader "shader.frag"

    // Link the vertex and fragment shaders into a shader program
    let shaderProgram = gl.CreateProgram()
    gl.AttachShader(shaderProgram, vertexShader)
    gl.AttachShader(shaderProgram, fragmentShader)
    gl.LinkProgram(shaderProgram)
    
    // We're done with the shaders so they can be removed to free memory
    gl.DetachShader(shaderProgram, fragmentShader)
    gl.DetachShader(shaderProgram, vertexShader)
    gl.DeleteShader(vertexShader)
    gl.DeleteShader(fragmentShader)

    // Throw an exception if linking has failed
    if gl.GetProgram(shaderProgram, GLEnum.LinkStatus) <> 1 then
        let info = gl.GetProgramInfoLog(shaderProgram)
        failwith (sprintf "Error linking program %A" info)

    shaderProgram
