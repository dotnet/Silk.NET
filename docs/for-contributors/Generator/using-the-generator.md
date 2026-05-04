(This needs clean up before merging. This was originally meant to be a Discord message, but I figured it's a good start to having proper docs.)

Okay, so short guide (by Exanite):

Note that this is from my perspective as a new contributor/maintainer. I'm guessing at how some of this stuff works. :sweat_smile:

The way that Silk 3 works is by taking the output of ClangSharpPInvokeGenerator and modifying the output with a set of mods.
These mods do things such as renaming identifiers, creating types such as handle structs or enums, and adding method overloads.

**Do note that Silk 3 is in heavy development and things can change without warning.**
This is probably the case until we're a few previews in.

**Also note that only C bindings are supported right now. COM will be available later.**

## Generator overview

There are two main things to configure:
1. Silk 3 - This is the [`generator.json`](https://github.com/dotnet/Silk.NET/blob/develop/3.0/generator.json) file.
2. ClangSharpPInvokeGenerator - This is the [`eng/silktouch`](https://github.com/dotnet/Silk.NET/tree/develop/3.0/eng/silktouch) folder.

Both are organized by library.

I suggest referencing the SDL configuration since it best represents your average C library.
Most options there should be applicable after you replace the SDL specific types/paths/etc.

### `generator.json`

This defines which mods to run.
- `AddIncludes` adds system header files. You want this.
- `ClangScraper` runs ClangSharpPInvokeGenerator. Only including this is equivalent to running ClangSharpPInvokeGenerator directly.
- The rest do a bunch of other transformations that I won't cover here. Ask if you're interested please.

One way to learn about the mods and debug them is to add them one by one.
Mods run in the order you define them and work off the output of each other.

However, you can probably get by just copying the mod order from SDL verbatim.

Things to note:
- I'm unfamiliar with the test project config. You probably can ignore it.
- Bool types are only transformed for functions. Bool types in structs will likely be left as`int` or similar.

### `eng/silktouch`

This folder contains a bunch of `.rsp` files, which hold command line arguments for ClangSharpPInvokeGenerator.

> To read more about ClangSharpPInvokeGenerator's command line arguments, I recommend installing the tool and using its help options.
>
> ```sh
> dotnet tool install --global ClangSharpPInvokeGenerator
> ClangSharpPInvokeGenerator --help
> ClangSharpPInvokeGenerator -c help
> ```

These rsp files can import other rsp files using the `@path` syntax.
Eg: `@../settings.rsp`

Note that these paths are relative to the `generate.rsp` file (I think... or at least the folder containing that file).

`@../../remap-stdint.rsp` is my addition that ensures that stdint types behave consistently between Windows and Linux.

This is the general structure of the `eng/silktouch` folder:

```
eng
- silktouch
  - opengl <-- This level contains folders per library
    - glcompat <-- This level contains folders for each "profile" (I think that's the term) for each variant of the library
    - glcore
    - gles1
    - gles2
  - sdl
    - SDL3
```

You likely don't need to worry about profiles, so we'll just keep focusing on the SDL case.

This is the structure of the SDL rsps.
Note that you don't necessarily have to structure it this way.

```
eng
- silktouch
  - sdl
    - SDL3
      - generate.rsp <-- The main settings file
      - header.txt
      - sdl-SDL.h <-- Hand written header file that includes the relevant headers of the library you want to bind
    - remap.rsp
    - settings.rsp <-- Shared settings for all profiles. Technically can be merged into generate.rsp.
```

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
