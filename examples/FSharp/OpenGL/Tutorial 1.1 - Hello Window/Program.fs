open System
open System.Drawing

open Silk.NET.Windowing
open Silk.NET.Windowing.Common
open Silk.NET.OpenGL
open Silk.NET.Input
open Silk.NET.Input.Common

[<EntryPoint>]
let main _ =
    // Setup some options and create a Window
    let mutable options = WindowOptions.Default
    options.Size <- Size(800, 600)
    options.Title <- "LearnOpenGL with Silk.NET"
    let mutable window = Window.Create(options)
    let mutable gl = null

    // Our Key Down handler
    let onKeyDown = Action<IKeyboard, Key, int>(fun _ key _ ->
        match key with
        | Key.Escape -> window.Close()
        | _ -> ()
    )

    window.add_Load (fun () -> 
        // Wait for Window to load before we can get a handle to OpenGL
        gl <- GL.GetApi()

        // Add a key down handler on any keyboard we find
        let input = window.GetInput()
        input.Keyboards
        |> Seq.iter (fun keyboard -> keyboard.add_KeyDown onKeyDown)
    )

    // We'll need to tell OpenGL to resize if the user resizes the window
    window.add_Resize (fun (size: Size) -> gl.Viewport(size))

    window.Run()

    0
