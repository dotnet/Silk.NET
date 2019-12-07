open System
open System.Drawing

open Silk.NET.Windowing
open Silk.NET.Windowing.Common
open Silk.NET.OpenGL
open Silk.NET.Input
open Silk.NET.Input.Common

[<EntryPoint>]
let main _ =
    let mutable options = WindowOptions.Default
    options.Size <- Size(800, 600)
    options.Title <- "LearnOpenGL with Silk.NET"
    let mutable window = Window.Create(options)
    let mutable gl = null

    let onKeyboardKey = Action<IKeyboard, Key, int>(fun _ key _ ->
        match key with
        | Key.Escape -> window.Close()
        | _ -> ()
    )

    window.add_Load (fun () -> 
        gl <- GL.GetApi()
        let input = window.GetInput()
        input.Keyboards
        |> Seq.iter (fun keyboard -> keyboard.add_KeyDown onKeyboardKey)
    )
    window.add_Resize (fun (size: Size) -> gl.Viewport(size))

    window.Run()
    0
