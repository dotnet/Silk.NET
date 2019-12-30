#nowarn "9"

open Microsoft.FSharp.NativeInterop

open System
open System.Drawing

open Silk.NET.Windowing
open Silk.NET.Windowing.Common
open Silk.NET.OpenGL
open Silk.NET.Input
open Silk.NET.Input.Common

let aPosLocation = 0u
let aColorLocation = 1u


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

        // Create our shader program
        shaderProgram <- Shader.create gl

        // Vertices in Counter-clockwise order
        let vertices = [|
            // positions         colors
            -0.5f; -0.5f; 0.0f;  1.0f; 0.0f; 0.0f // bottom left  
            0.5f; -0.5f; 0.0f;   0.0f; 1.0f; 0.0f // bottom right 
            0.0f;  0.5f; 0.0f;   0.0f; 0.0f; 1.0f // top    
        |]

        // VAO stores our vertex state
        vao <- gl.GenVertexArray()
        let vbo = gl.GenBuffer()

        gl.BindVertexArray(vao)
        gl.BindBuffer(GLEnum.ArrayBuffer, vbo)

        // gl.BufferData requires the data to be passed as a void pointer.
        // We get a pointer to the vertex array and convert it.
        use verticesPtr = fixed vertices
        let voidPtr = verticesPtr |> NativePtr.toVoidPtr
        let size = uint32 (vertices.Length * sizeof<float32>)
        gl.BufferData(GLEnum.ArrayBuffer, size, voidPtr, GLEnum.StaticDraw)

        // Position attribute
        gl.VertexAttribPointer(aPosLocation, 3, GLEnum.Float, false, 6u * uint32 sizeof<float32>, 0)
        gl.EnableVertexAttribArray(aPosLocation)

        // Color attribute
        gl.VertexAttribPointer(aColorLocation, 3, GLEnum.Float, false, 6u * uint32 sizeof<float32>, 3 * sizeof<float32>)
        gl.EnableVertexAttribArray(aColorLocation)

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
