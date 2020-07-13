// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

open Expecto;
open Hopac
open Logary
open Logary.Configuration
open Logary.Adapters.Facade
open Logary.Targets
open Silk.NET.Maths.Tests

[<EntryPoint>]
let main argv =
  let logary =
    Config.create "Silk.NET.Maths.Tests" "localhost"
    |> Config.targets [ LiterateConsole.create LiterateConsole.empty "console" ]
    |> Config.processing (Events.events |> Events.sink ["console";])
    |> Config.build
    |> run
  LogaryFacadeAdapter.initialise<Expecto.Logging.Logger> logary

  // Invoke Expecto:
  runTestsInAssemblyWithCLIArgs [] argv