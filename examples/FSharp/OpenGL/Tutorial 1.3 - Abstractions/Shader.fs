namespace Tutorial

open System.IO
open Silk.NET.OpenGL

type Shader = {
    gl: GL
    handle: uint32
}

module Shader =
    let Created = 1
    let NotFound = -1

    // Load and compile the vertex and fragment shaders
    let private load (gl: GL) (shaderType: ShaderType) path =
        let shader = gl.CreateShader(shaderType)
        let source = File.ReadAllText(path)

        // Load and compile the shader
        gl.ShaderSource(shader, source)
        gl.CompileShader(shader)

        // Throw an exception if compiling the shader failed
        // The info log will tell us what line the shader failed on
        // so we can inspect the source.
        if gl.GetShader(shader, GLEnum.CompileStatus) <> Created then
            let info = gl.GetShaderInfoLog(shader)
            gl.DeleteShader(shader)
            failwithf "Error creating shader: %A" info

        shader


    let create (gl: GL) vertexPath fragmentPath =
        // Load and compile the shaders
        let vertexShader = load gl ShaderType.VertexShader vertexPath 
        let fragmentShader = load gl ShaderType.FragmentShader fragmentPath

        // Link the vertex and fragment shaders into a shader program
        let handle = gl.CreateProgram()
        gl.AttachShader(handle, vertexShader)
        gl.AttachShader(handle, fragmentShader)
        gl.LinkProgram(handle)

        // We're done with the shaders so they can be removed to free memory
        gl.DetachShader(handle, fragmentShader)
        gl.DetachShader(handle, vertexShader)
        gl.DeleteShader(vertexShader)
        gl.DeleteShader(fragmentShader)

        // Throw an exception if linking has failed
        if gl.GetProgram(handle, GLEnum.LinkStatus) <> Created then
            gl.GetProgramInfoLog(handle)
            |> failwithf "Error linking program %A"

        {
            gl = gl
            handle = handle
        }


    let activate (shader: Shader) =
        shader.gl.UseProgram(shader.handle)


    let setUniform (name: string) value (shader: Shader) =
        // Setting a uniform on a shader using a name
        let location = shader.gl.GetUniformLocation(shader.handle, name)
        if location = NotFound then
            failwithf "%s uniform not found on shader." name

        activate shader

        match box value with
        | :? int as i -> shader.gl.Uniform1(location, i)
        | :? float32 as f -> shader.gl.Uniform1(location, f)
        | _ -> failwithf "SetUniform cannot set value of type %A" (value.GetType())


    let destroy (shader: Shader) =
        shader.gl.DeleteProgram(shader.handle)

