# Troubleshooting

## Common exceptions

### `PlatformNotSupportedException: Couldn't find a suitable windowing platform.`
When attempting to call Window.Create, a `PlatformNotSupportedException` is thrown with a message indicating that the windowing system couldn't find a windowing platform.

**Cause:** \
There are multiple causes for this particular exception, however the most common are:

- The underlying windowing API could not be loaded;
- The underlying windowing API does not support the current platform;
- Resolution;

**How to fix:**
- Ensure you have the Microsoft Visual C++ Redisributables installed;
- Ensure the underlying API is present on the system

Silk.NET should do a good job of copying the appropriate native libraries upon build by default, and will search your PATH for them if not present in the output directory.

However, in some environments this system is not reliable and you will need to provide the binaries yourself. To do so:

Download or build your chosen native API (you will be able to find instructions on how to do this in their repositories):

GLFW: https://github.com/glfw/glfw \
SDL: https://github.com/libsdl-org/SDL

Retreive the resultant binary files and place them in your program's output directory.
Ensure the file names match what Silk.NET expects, as illustrated by the table below:

| Platform      | Underlying API     | File Name       |
|---------------|--------------------|-----------------|
| Windows       | GLFW 3.3           | glfw3.dll       |
| Linux         | GLFW 3.3           | libglfw.so.3    |
| MacOS         | GLFW 3.3           | libglfw.3.dylib |
| Android       | SDL 2.0.14         | libSDL2.so      |
| iOS           | SDL 2.0.14         | libSDL2.a       |

Ensure the underlying API supports the current platform
You should be using a version of Silk.NET and an appropriate windowing backend that support the platform you are trying to run on. See the below table for first-party support.

| Silk.NET Version | Underlying API | Supported platforms   | Packages                    |
|------------------|----------------|-----------------------|-----------------------------|
| 1.X              | GLFW 3.3       | Windows, MacOS, Linux | Silk.NET.Windowing.Desktop  |
| 2.X              | GLFW 3.3       | Windows, MacOS, Linux | Silk.NET.Windowing.Glfw     |
| 2.X              | GLFW 3.3       | Android, iOS[1]       | Silk.NET.Windowing.Sdl      |

[1] Please note that while Windows, MacOS, and Linux support is available using the SDL windowing backend, this is not something the Silk.NET team actively supports.

