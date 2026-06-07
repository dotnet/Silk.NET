# Using the Generator

The way that Silk 3 works is by taking the output of ClangSharpPInvokeGenerator, which itself is its own bindings
generator, and modifying the output with a set of mods. These mods apply transformations such as renaming identifiers,
creating types such as handle structs or enums, and adding method overloads.

In other words, ClangSharpPInvokeGenerator acts as the input to the SilkTouch generator. Other inputs to the SilkTouch
generator will likely be available in the future to cover APIs such as Metal.

**Do note that Silk 3 is in heavy development and things can change without warning.**
This is probably the case until we are a few previews in.

**Also note that only C bindings are supported right now. COM will be available later.**

## Generator overview

There are two main things to configure:

1. Silk 3 - This is the [`generator.json`](https://github.com/dotnet/Silk.NET/blob/develop/3.0/generator.json) file.

2. ClangSharpPInvokeGenerator - This is the [`eng/silktouch`](https://github.com/dotnet/Silk.NET/tree/develop/3.0/eng/silktouch) folder.

Both are organized by native API.

Note: For the average C API, SDL's generator configuration would be the best configuration to reference. Most options
used for the SDL bindings should be applicable after replacing the SDL-specific paths and values to suit the C API that
you are binding.

## `generator.json`

This file defines the different bindings jobs and defines which mods to run for each of them.

For example, when binding to a C API:

- `AddIncludes` tells `ClangScraper` where to find the system header files. You likely want to include this.

- `ClangScraper` runs ClangSharpPInvokeGenerator. Including this mod on its own is equivalent to running
  ClangSharpPInvokeGenerator directly.

- The rest of the mods apply different transformations to the output of `ClangScraper`. Documentation for the other mods
  can be found in the [Generator Mods](generator-mods.md) documentation.

Aside from reading documentation, some other ways to learn about the mods are to:

- Read through the tests. The tests act as examples for specific behaviors expected by each mod, with configurations,
  inputs, and expected outputs provided for each case.

- Add them one by one. Mods run in the order you define them and work off the output of the previous mod.

(TODO: Not sure how to set up the bindings test projects. See the `TestProject` property in `generator.json`.)

## `eng/silktouch`

This folder stores `.rsp` files that hold command line arguments for ClangSharpPInvokeGenerator. While these `.rsp`
files can be stored anywhere in relation to the `generator.json` file, Silk stores its own `.rsp` files in the
[`eng/silktouch`](https://github.com/dotnet/Silk.NET/tree/develop/3.0/eng/silktouch) folder.

> To read more about ClangSharpPInvokeGenerator's command line arguments, a good option is to install the tool directly
> and use `--help` to display its command line documentation.
>
> ```sh
> dotnet tool install --global ClangSharpPInvokeGenerator
> ClangSharpPInvokeGenerator --help
> ClangSharpPInvokeGenerator --config help
> ```

Aside from simply storing the command line arguments to be passed into ClangSharpPInvokeGenerator, these `.rsp` files
can also import other `.rsp` files using the `@path` syntax. For example: `@../settings.rsp`.

Silk commonly uses these import paths to share settings between different sets of bindings, such as the
[common.rsp](https://github.com/dotnet/Silk.NET/blob/develop/3.0/eng/silktouch/common.rsp) file for general shared
settings and the [remap-stdint.rsp](https://github.com/dotnet/Silk.NET/blob/develop/3.0/eng/silktouch/remap-stdint.rsp)
file used to ensure that the `stdint.h` types behave consistently between Windows and Linux.

Please note that these paths are relative to the `.rsp` file specified in the generator and **not** relative to the
`.rsp` file the directive is actually defined in.

For example, Silk's SDL bindings sets `ClangSharpResponseFiles` to be `eng/silktouch/sdl/**/generate.rsp`. Therefore,
any import paths used in any `.rsp` file reference, including transitively imported `.rsp files`, must be relative to
the matched `generate.rsp` file.

### `eng/silktouch` - Folder Structure

This is the general structure of the `eng/silktouch` folder:

```
eng
- silktouch
  - opengl <-- This level contains folders per native API.
    - glcompat <-- This level contains folders for each "profile", which represent variants of the API.
    - glcore
    - gles1
    - gles2
  - sdl
    - SDL3
```

Profiles likely will not be relevent for most C APIs, so the examples here will keep focusing on the SDL case.

The following is the folder structure used for Silk's SDL bindings. Note that you do not necessarily have to structure
it this way. Silk's structure focuses on keeping consistency in its `.rsp` file organization, regardless of whether the
API makes use of profiles or not.

```
eng
- silktouch
  - sdl
    - SDL3
      - generate.rsp <-- The main settings file.
      - header.txt
      - sdl-SDL.h <-- Handwritten header file that #includes the relevant headers of the library you want to bind.
    - remap.rsp
    - settings.rsp <-- Shared settings for all profiles.
```

(TODO)

Let's take a look at the `sdl-SDL.h` file and the `generate.rsp` and `settings.rsp` files.
I'll only include the important parts of the config here.

`sdl-SDL.h`:
```h
#include <SDL3/SDL.h>
#include <SDL3/SDL_main.h>
#include <SDL3/SDL_vulkan.h>
```

`generate.rsp`:
```rsp
@../settings.rsp
@../remap.rsp
--exclude
SDL_SetX11EventHook
SDL_SetWindowsMessageHook
SDL_FILE
SDL_LINE
--file
sdl-SDL.h
--methodClassName
Sdl
--namespace
Silk.NET.SDL
--output
../../../../sources/SDL/SDL3
--traverse
../../../submodules/sdl/include/SDL3/SDL_assert.h
../../../submodules/sdl/include/SDL3/SDL_atomic.h
../../../submodules/sdl/include/SDL3/SDL_audio.h
```

`settings.rsp`:
```rsp
@../../common.rsp
--define-macro
TODO_DEFINE_MACROS=HERE
--headerFile
header.txt
--include-directory
../../../submodules/sdl/include
--with-callconv
*=Winapi
--with-librarypath
*=SDL3
```

#### Relevant options from `generate.rsp`:

`--file` specifies the header file that we first look through.
`--traverse` specifies which header files actually contribute towards the output. (Not sure if you can glob or similar here)

This separation is because while we need certain header files such as the system headers to compile the library, we don't want to include the system headers as part of our generated bindings.

`--output` should point to the same `Jobs.JOB_NAME.SourceProject` path you defined in `generator.json`.

`--methodClassName` specifies which C# class contains the generated methods/constants.
`--namespace` specifies the C# namespace of the generated files.

`--exclude` allows you exclude types/functions/constants from the output. Usually these are things that aren't useful, don't generate correctly, or are platform-specific.

#### Relevant options from `settings.rsp`:

`--headerFile` specifies the header file appended to the top of every generated file.

`--include-directory` specifies the include directories. This affects all of the headers included, such as in `sdl-SDL.h`.

`--with-librarypath` is the name of the native library without prefixes/suffixes. If the library name differs outside of the usual `lib` prefix or `.dll`/`.so`/`.dylib` suffixes, the way to handle this is to add `UseAlternativeName` in the generated bindings. An example with Vulkan can be found at `sources/Vulkan/Vulkan/Vk.cs`.

```cs
static Vk()
{
    LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
    LoaderInterface.RegisterAlternativeName("vulkan", "vulkan-1");
    LoaderInterface.RegisterAlternativeName("vulkan", "MoltenVK");
}
```

### Generated bindings output

All generated binding will be output to the `Jobs.JOB_NAME.SourceProject` path you defined in `generator.json`.

These generated files all have the `.gen.cs` suffix and most of them are partial type declarations.
This means by creating a similarly named `.cs` file and using the `partial` C# keyword, you can add to the type.

Do not modify the `.gen.cs` files manually since rerunning the generator will overwrite those changes.

### Packing the generated bindings

Haven't done this myself so I'll leave this section as WIP.
I imagine that `dotnet pack` or similar will just work though.
