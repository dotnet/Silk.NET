#nowarn "9"

open Microsoft.FSharp.NativeInterop

open System
open System.Drawing

open Silk.NET.Windowing
open Silk.NET.Windowing.Common
open Silk.NET.OpenGL
open Silk.NET.Input
open Silk.NET.Input.Common

let VertexShaderSource = """#version 330 core
layout (location = 0) in vec3 aPos;
void main() {
    gl_Position = vec4(aPos, 1.0);
}
"""
let aPosLocation = 0u

let FragmentShaderSource = """#version 330 core
out vec4 FragColor;
void main() {
    FragColor = vec4(1.0f, 0.5f, 0.2f, 1.0f);
}
"""

// This function is called for both the vertex and fragment shaders
let createShader (gl: GL) (shaderType: GLEnum) source =
    let shader = gl.CreateShader(shaderType)
    gl.ShaderSource(shader, source)
    gl.CompileShader(shader)
    if gl.GetShader(shader, GLEnum.CompileStatus) = 1 then
        shader
    else
        let info = gl.GetShaderInfoLog(shader)
        gl.DeleteShader(shader)
        failwith (sprintf "Error creating shader: %A" info)

[<EntryPoint>]
let main _ =
    // Setup some options and create a Window
    let mutable options = WindowOptions.Default
    options.Size <- Size(800, 600)
    options.Title <- "LearnOpenGL with Silk.NET"
    let mutable window = Window.Create(options)
    let mutable gl = null
    let mutable vao = 0u
    let mutable shaderProgram = 0u

    // Our Key Down handler
    let onKeyDown = Action<IKeyboard, Key, int>(fun _ key _ ->
        match key with
        | Key.Escape -> window.Close()
        | _ -> ()
    )

    // Here we initialize OpenGL with our scene
    window.add_Load (fun () -> 
        // Wait for Window to load before we can get a handle to OpenGL
        gl <- GL.GetApi()

        // Add a key down handler on any keyboard we find
        let input = window.GetInput()
        input.Keyboards
        |> Seq.iter (fun keyboard -> keyboard.add_KeyDown onKeyDown)


        // Build and compile our shader program
        let vertexShader = createShader gl GLEnum.VertexShader VertexShaderSource
        let fragmentShader = createShader gl GLEnum.FragmentShader FragmentShaderSource
        shaderProgram <- gl.CreateProgram()
        gl.AttachShader(shaderProgram, vertexShader)
        gl.AttachShader(shaderProgram, fragmentShader)
        gl.LinkProgram(shaderProgram)
        
        // We're done with the shaders so they can be removed
        gl.DetachShader(shaderProgram, fragmentShader)
        gl.DetachShader(shaderProgram, vertexShader)
        gl.DeleteShader(vertexShader)
        gl.DeleteShader(fragmentShader)

        // Complete our shader program by linking it
        if gl.GetProgram(shaderProgram, GLEnum.LinkStatus) <> 1 then
            let info = gl.GetProgramInfoLog(shaderProgram)
            failwith (sprintf "Error linking program %A" info)

        // Vertices in Counter-clockwise order
        let vertices = [|
            -0.5f; -0.5f; 0.0f // left  
            0.5f; -0.5f; 0.0f // right 
            0.0f;  0.5f; 0.0f  // top    
        |]

        // VAO stores our vertex state
        vao <- gl.GenVertexArray()
        let vbo = gl.GenBuffer()

        gl.BindVertexArray(vao)
        gl.BindBuffer(GLEnum.ArrayBuffer, vbo)

        // gl.BufferData requires the data to be passed as a void pointer.
        // We get a pointer to the vertex array and convert it to
        // a void pointer.
        use verticesPtr = fixed vertices
        let voidPtr = verticesPtr |> NativePtr.toVoidPtr
        let size = uint32 (vertices.Length * sizeof<float32>)
        gl.BufferData(GLEnum.ArrayBuffer, size, voidPtr, GLEnum.StaticDraw)

        // Set how the vertex data will be used
        gl.VertexAttribPointer(aPosLocation, 3, GLEnum.Float, false, 3u * uint32 sizeof<float32>, 0)

        // All attribute arrays must be enabled before first use
        gl.EnableVertexAttribArray(aPosLocation)

        // Unbind our vao and vbo
        gl.BindBuffer(GLEnum.ArrayBuffer, 0u)
        gl.BindVertexArray(0u)
    )

    window.add_Render (fun _ ->
        // Set a background color and clear the screen with that color
        gl.ClearColor(0.2f, 0.3f, 0.3f, 1.0f)
        gl.Clear(uint32 GLEnum.ColorBufferBit)

        // We want to use the shader program we setup on load
        // along with the vao that holds info about the vertices and
        // how they'll be used
        gl.UseProgram(shaderProgram)
        gl.BindVertexArray(vao)

        // Finally, our draw call renders 3u vertices starting at index 0
        gl.DrawArrays(GLEnum.Triangles, 0, 3u)
    )

    // We'll need to tell OpenGL to resize if the user resizes the window
    window.add_Resize (fun (size: Size) -> gl.Viewport(size))

    window.Run()

    0
