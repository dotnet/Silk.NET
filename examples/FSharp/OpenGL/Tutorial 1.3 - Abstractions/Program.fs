module Tutorial.Main

#nowarn "9"

open Microsoft.FSharp.NativeInterop

open System
open System.Drawing

open Silk.NET.Windowing
open Silk.NET.Windowing.Common
open Silk.NET.OpenGL
open Silk.NET.Input
open Silk.NET.Input.Common


type State = {
    gl: GL
    vbo: BufferObject
    ebo: BufferObject
    vao: VertexArrayObject
    shader: Shader
}


let Vertices = [|
    // X    Y      Z     R     G     B     A
     0.5f;  0.5f;  0.0f; 1.0f; 0.0f; 0.0f; 0.0f
     0.5f;  -0.5f; 0.0f; 0.0f; 0.0f; 0.0f; 0.0f
     -0.5f; -0.5f; 0.0f; 0.0f; 0.0f; 1.0f; 0.0f
     -0.5f; 0.5f;  0.5f; 0.0f; 0.0f; 0.0f; 0.0f
|]


let Indices = [|
    0; 1; 3
    1; 2; 3
|]


[<EntryPoint>]
let main _ =
    // Setup some options and create a Window
    let mutable options = WindowOptions.Default
    options.Size <- Size(800, 600)
    options.Title <- "LearnOpenGL with Silk.NET"

    let mutable state = None
    let mutable window = Window.Create(options)


    let onKeyDown = Action<IKeyboard, Key, int>(fun _ key _ ->
        match key with
        | Key.Escape -> window.Close()
        | _ -> ()
    )
    

    window.add_Load (fun () -> 
        let input = window.GetInput()
        input.Keyboards
        |> Seq.iter (fun keyboard -> keyboard.add_KeyDown onKeyDown)

        let gl = GL.GetApi()
        let vbo = BufferObject.create gl Vertices GLEnum.ArrayBuffer
        let ebo = BufferObject.create gl Indices GLEnum.ElementArrayBuffer
        let vao = VertexArrayObject.create gl vbo ebo

        VertexArrayObject.attributePointer 0u 3 GLEnum.Float 7u 0 vao
        VertexArrayObject.attributePointer 1u 4 GLEnum.Float 7u 3 vao

        state <- Some {
            gl = gl
            vbo = vbo
            ebo = ebo
            vao = vao
            shader = Shader.create gl "Shader.vert" "Shader.frag"
        }
    )


    let cycleColor () =
        float32 (sin(float DateTime.Now.Millisecond / 1000.0 * Math.PI))


    window.add_Render (fun _ ->
        match state with
        | Some s ->
            let gl = s.gl

            gl.Clear(uint32 GLEnum.ColorBufferBit)

            VertexArrayObject.bind s.vao
            Shader.activate s.shader

            Shader.setUniform "uBlue" (cycleColor ()) s.shader

            gl.DrawElements(GLEnum.Triangles, uint32 Indices.Length, GLEnum.UnsignedInt, 0)
        | None -> ()
    )


    // Free up memmory when we're done
    window.add_Closing (fun () -> 
        match state with
        | Some s ->
            BufferObject.destroy s.vbo
            BufferObject.destroy s.ebo
            VertexArrayObject.destroy s.vao
            Shader.destroy s.shader
        | None -> ()
    )

    window.Run()

    0
