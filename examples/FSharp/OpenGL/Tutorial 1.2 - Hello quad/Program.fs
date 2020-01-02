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
    let mutable vbo = 0u
    let mutable ebo = 0u
    let mutable vao = 0u
    let mutable shader = 0u

    // Vertices in Counter-clockwise order
    // Uploaded to the VBO.
    let Vertices = [|
        // X   Y       Z
         0.5f;  0.5f;  0.0f
         0.5f;  -0.5f; 0.0f
         -0.5f; -0.5f; 0.0f
         -0.5f; 0.5f;  0.5f
    |]

    let Indices = [|
        0; 1; 3
        1; 2; 3
    |]


    // Our Keyboard handler
    let onKeyDown = Action<IKeyboard, Key, int>(fun _ key _ ->
        match key with
        | Key.Escape -> window.Close()
        | _ -> ()
    )
    

    // Here we initialize OpenGL with our scene
    window.add_Load (fun () -> 
        // Add a key down handler on any keyboard we find
        let input = window.GetInput()
        input.Keyboards
        |> Seq.iter (fun keyboard -> keyboard.add_KeyDown onKeyDown)

        // Wait for Window to load before we can get a handle to OpenGL
        gl <- GL.GetApi()

        // Build and compile our shader program
        let vertexShader = createShader gl GLEnum.VertexShader VertexShaderSource
        let fragmentShader = createShader gl GLEnum.FragmentShader FragmentShaderSource
        shader <- gl.CreateProgram()
        gl.AttachShader(shader, vertexShader)
        gl.AttachShader(shader, fragmentShader)
        gl.LinkProgram(shader)
        
        // We're done with the shaders so they can be removed
        gl.DetachShader(shader, fragmentShader)
        gl.DetachShader(shader, vertexShader)
        gl.DeleteShader(vertexShader)
        gl.DeleteShader(fragmentShader)

        // Complete our shader program by linking it
        if gl.GetProgram(shader, GLEnum.LinkStatus) <> 1 then
            let info = gl.GetProgramInfoLog(shader)
            failwith (sprintf "Error linking program %A" info)


        // VAO stores our vertex state
        vao <- gl.GenVertexArray()
        vbo <- gl.GenBuffer()
        ebo <- gl.GenBuffer()

        gl.BindVertexArray(vao)
        gl.BindBuffer(GLEnum.ArrayBuffer, vbo)

        // gl.BufferData requires the data to be passed as a void pointer.
        // We get a pointer to the vertex array and convert it to
        // a void pointer.
        use verticesPtr = fixed Vertices
        let voidPtr = verticesPtr |> NativePtr.toVoidPtr
        let size = uint32 (Vertices.Length * sizeof<float32>)
        gl.BufferData(GLEnum.ArrayBuffer, size, voidPtr, GLEnum.StaticDraw)

        // Set how the vertex data will be used
        gl.VertexAttribPointer(aPosLocation, 3, GLEnum.Float, false, 3u * uint32 sizeof<float32>, 0)

        // Setup Element Buffer
        gl.BindBuffer(GLEnum.ElementArrayBuffer, ebo)
        use elementPtr = fixed Indices
        let voidPtr = elementPtr |> NativePtr.toVoidPtr
        let size = uint32 (Indices.Length * sizeof<float32>)
        gl.BufferData(GLEnum.ElementArrayBuffer, size, voidPtr, GLEnum.StaticDraw)


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
        gl.UseProgram(shader)
        gl.BindVertexArray(vao)

        // Finally, our draw call renders 6 indices
        gl.DrawElements(GLEnum.Triangles, uint32 Indices.Length, GLEnum.UnsignedInt, 0)
    )

    // We'll need to tell OpenGL to resize if the user resizes the window
    window.add_Resize (fun (size: Size) -> gl.Viewport(size))

    // Free up memmory when we're done
    window.add_Closing (fun () -> 
        gl.DeleteBuffer(vbo)
        gl.DeleteBuffer(ebo)
        gl.DeleteVertexArray(vao)
        gl.DeleteProgram(shader)
    )

    window.Run()

    0
