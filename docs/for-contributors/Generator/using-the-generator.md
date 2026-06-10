# Using the Generator

**Warning: The generator is still in heavy development and will likely be subject to frequent breaking changes.**
This will likely be the case until we are a few previews in.

SilkTouch is Silk 3's bindings generator, which works by taking the output of ClangSharpPInvokeGenerator, which itself
is its own bindings generator, and modifying the output with a set of mods. These mods apply transformations such as
renaming identifiers, creating types such as handle structs or enums, and adding method overloads.

In other words, ClangSharpPInvokeGenerator acts as the input to the SilkTouch generator and SilkTouch works to improve
on that input. Other inputs to the SilkTouch generator will likely be available in the future to cover APIs such as
Metal.

**Also note that only C bindings are supported right now. COM will be available later.**

## Generator Overview

There are two main things to configure:

1. Silk 3 - This is the [`generator.json`](https://github.com/dotnet/Silk.NET/blob/develop/3.0/generator.json) file.

2. ClangSharpPInvokeGenerator - This is the [`eng/silktouch`](https://github.com/dotnet/Silk.NET/tree/develop/3.0/eng/silktouch) folder.

Both are organized by native API.

Note: For the average C API, SDL's generator configuration would be the best configuration to reference. Most options
used for the SDL bindings should be applicable after replacing the SDL-specific paths and values to suit the C API that
you are binding.

## SilkTouch Configuration

Silk defines the configuration for SilkTouch in the
[`generator.json`](https://github.com/dotnet/Silk.NET/blob/develop/3.0/generator.json) file. This file defines the
different bindings jobs and the list of mods to run for each job.

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

(TODO: Not sure how to set up bindings test projects. This refers to the `TestProject` property in `generator.json`.)

## ClangSharpPInvokeGenerator Configuration

Due to SilkTouch using ClangSharpPInvokeGenerator as an input, ClangSharpPInvokeGenerator must also be configured.
Silk stores its configuration for ClangSharpPInvokeGenerator in the
[`eng/silktouch`](https://github.com/dotnet/Silk.NET/tree/develop/3.0/eng/silktouch) folder as `.rsp` files (response
files). These response files store command line arguments to be passed into ClangSharpPInvokeGenerator.

Note that these files can be stored anywhere since the SilkTouch configuration lets you configure where the SilkTouch
generator looks for these response files.

> To read more about ClangSharpPInvokeGenerator's command line arguments, a good option is to install the tool directly
> and use `--help` to display its command line documentation.
>
> ```sh
> dotnet tool install --global ClangSharpPInvokeGenerator
> ClangSharpPInvokeGenerator --help
> ClangSharpPInvokeGenerator --config help
> ```

Aside from simply storing the command line arguments to be passed into ClangSharpPInvokeGenerator, response files can
also import other response files using the `@path` syntax. For example: `@../settings.rsp`.

Silk commonly uses these import paths to share settings between different sets of bindings, such as the
[common.rsp](https://github.com/dotnet/Silk.NET/blob/develop/3.0/eng/silktouch/common.rsp) file for general shared
settings and the [remap-stdint.rsp](https://github.com/dotnet/Silk.NET/blob/develop/3.0/eng/silktouch/remap-stdint.rsp)
file used to ensure that the `stdint.h` types behave consistently between Windows and Linux.

Please note that these paths are relative to the response file specified in the generator and **not** relative to the
response file the `@path` directive is actually defined in.

For example, Silk's SDL bindings sets `ClangSharpResponseFiles` to be `eng/silktouch/sdl/**/generate.rsp`. Therefore,
any import paths used in the response files, including transitively imported response files, must be relative to
the matched `generate.rsp` file.

### Example Response File Folder Structure

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

The following is the folder structure used for Silk's SDL bindings. You do not have to structure it the way Silk does.
Silk's structure focuses on keeping consistency in its response file organization, regardless of whether the API makes
use of profiles or not.

```
eng
- silktouch
  - sdl
    - SDL3
      - generate.rsp <-- The main settings file. Used as the entrypoint. All import paths must be relative to this file.
      - header.txt
      - sdl-SDL.h <-- Handwritten header file that #includes the relevant headers of the library you want to bind.
    - remap.rsp
    - settings.rsp <-- Shared settings for all profiles.
```

### Example ClangSharpPInvokeGenerator Configuration

This section will now focus on how to actually create the response files, starting with the `sdl-SDL.h`, `generate.rsp`,
and `settings.rsp` files. The snippets below will only contain the most important sections of those files for brevity.

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

#### Relevant Options from `generate.rsp`:

- `--file` specifies the header file to use as the entrypoint. This should be the custom header you defined.

- `--traverse` specifies which header files contribute towards the output.

This separation is because while header files, such as system headers, may be required to compile the library, we do not
want to include those headers as part of the final set of generated bindings.

- `--output` should point to the same `Jobs.JOB_NAME.SourceProject` path you defined in `generator.json`.

- `--methodClassName` specifies which C# class contains the generated methods/constants.

- `--namespace` specifies the C# namespace of the generated files.

- `--exclude` allows you exclude types/functions/constants from the output. These usually are APIs that are not useful,
  do not generate correctly, or are platform-specific.

#### Relevant options from `settings.rsp`:

- `--headerFile` specifies the header file appended to the top of every generated file. Silk uses this to inject its
  copyright headers.

- `--include-directory` specifies the include directories to be used. This affects all headers included, such as
  `sdl-SDL.h`.

- `--with-librarypath` is the name of the native library without prefixes/suffixes. If the library name differs outside
  of the usual `lib` prefix or `.dll`/`.so`/`.dylib` suffixes, the way to handle this is to add `UseAlternativeName` in
  the generated bindings. An example with Vulkan can be found in
  [`sources/Vulkan/Vulkan/Vk.cs`](https://github.com/dotnet/Silk.NET/blob/develop/3.0/sources/Vulkan/Vulkan/Vk.cs),
  which is a manually written file.

```cs
static Vk()
{
    LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
    LoaderInterface.RegisterAlternativeName("vulkan", "vulkan-1");
    LoaderInterface.RegisterAlternativeName("vulkan", "MoltenVK");
}
```

### Generated Bindings Output

All generated binding will be output to the `Jobs.JOB_NAME.SourceProject` path defined in `generator.json`.

These generated files all have the `.gen.cs` suffix and most of them are partial type declarations.
This means by creating a similarly named `.cs` file and using the `partial` C# keyword, you can add to the type.

Do not modify the `.gen.cs` files since running the generator again will overwrite those changes.

### Packing the Generated Bindings

(TODO: This section needs verification.)

`dotnet pack` should simply work here.

If you are contributing to Silk's repository, Silk automatically packs and pushes changes made during a pull request
to its experimental NuGet feed. More information on how to access this feed is available in the
[Experimental Feed](../../silk.net/experimental-feed.md) documentation.
