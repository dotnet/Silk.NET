# Static vs Input Bindings

## Overview

Silk.NET has multiple ways to access the underlying APIs, either through a static method (e.g. `GL.GenBuffers`) or
through an "API object" (e.g. created with `GL.Create` and then accessed as `gl.GenBuffers`). Not all APIs are the
same, and some are better accessed through one method or the other. Note that Silk.NET does make both available however,
so if you're prefer consistency feel free to pick one method and stick to it, though you may result in some minor
inefficiencies.

All native APIs are accessed using a "function pointer" - a location in memory at which the native code resides.
This is typically fetched using `DllImport`, but some APIs require custom mechanisms. An example in OpenGL, where you
must use a "context API" (e.g. WGL, GLX, EGL, etc) to create a context and, after setting up that context state, use a
function provided by that context API to get the function pointers for OpenGL (e.g. `wglGetProcAddress`). We refer to
these as "stateful APIs" in this document. Note that OpenGL is not the only stateful API, this will be elaborated later.

Stateless APIs are those where the function pointers aren't contingent on any other state, and they're effectively
accessed as if they were static functions. For these, the function pointers are typically retrieved through `DllImport`,
but this needn't preclude other APIs from having bespoke mechanisms to statelessly retrieve function pointers (though,
there are no examples of this today).

When using a stateful API, you should use API objects if possible i.e. `API.Create`, and dispose of that object when you
are done using that API. When using a stateless API, you should use the static functions exposed directly on the API
class.

> [!NOTE]
> Future releases of Silk.NET are intended to contain analysers to indicate the correct access method.

Below is a description of the stateful APIs. All other APIs not listed here are, or can be treated as, stateless.

## OpenGL

OpenGL is a stateful API because it requires a context to be created and "made current" on that thread before function
pointers can be retrieved. Typically, this context is created using Silk.NET.Windowing, and the functions would be
retrieved using `surface.OpenGL.GetProcAddress` in that example.

To create an API object, our OpenGL bindings provide a utility function `CreateOpenGL`:
```csharp
IGL gl = null!;
surface.Created += _ =>
{
    gl = surface.CreateOpenGL();
    // Use gl functions here...
    gl.Flush();
}
surface.Render += _ =>
{
    // Use gl functions here...
    gl.Clear(ClearBufferMask.ColorBufferBit);
}
```

If you'd prefer to use static methods despite OpenGL being stateful, the static functions on `GL` will forward to
`GL.ThisThread`, which essentially forwards to a thread-specific `IGL` instance. You can change the `IGL` instance used
by a thread using `GL.ThisThread.MakeCurrent`, which will also implicitly make the `IGLContext` you pass it current
(if applicable). Note that Silk.NET.Windowing will implicitly call this, so you can use the static OpenGL functions in
the obvious way, albeit with the implied indirection through `GL.ThisThread`:
```csharp
surface.Created += _ =>
{
    GL.Flush();
}
surface.Render += _ =>
{
    GL.Clear(ClearBufferMask.ColorBufferBit);
}
```

> [!CAUTION]
> TODO: Silk.NET.Windowing does not currently do this! `surface.MakeCurrent()` must be used in `surface.Created` to make
> this happen.

## Vulkan

Vulkan is a stateful API because its function pointers are dependent on the `InstanceHandle` and `DeviceHandle` being
used. Our Vulkan bindings intercept calls to `Vk.CreateInstance` and `Vk.CreateDevice`, and set `CurrentInstance` and
`CurrentDevice` respectively on the Vulkan API object for later use with `Vk.GetDeviceProcAddr` and
`Vk.GetInstanceProcAddr`.

The Vulkan API object will first try `vkGetDeviceProcAddr` to load a function pointer (where the value for `device` is
as in `CurrentDevice`), followed by `vkGetInstanceProcAddr` (where the value for `instance` is as in `CurrentInstance`).
For `vkGetInstanceProcAddr` itself, `DllImport` is used.

`CurrentInstance` is set upon a successful call to `vkCreateInstance`, and `CurrentDevice` is set upon a successful call
to `vkCreateDevice`. Note that it is illegal to change these values on an API object if they're already set, if you have
scenarios requiring multiple instance-device combinations you must create multiple API objects.

> [!TIP]
> In cases where you have one instance from which multiple devices are created, simply clone the `IVk` object using
> `IVk.Clone()` prior to **any device** being created. This will reuse the function pointers already loaded for that
> instance.

If you'd prefer to use static methods despite Vulkan being stateful, the static functions on `Vk` will forward to
`Vk.ThisThread`, which essentially forwards to a thread-specific `IVk` instance. You can change the `IVk` instance used
by a thread using `Vk.ThisThread.MakeCurrent`. The static functions, much like using a single `IVk` instance, will throw
if multiple instance-device combinations are used on the same thread without changing the `IVk` object being used.

## OpenXR

OpenXR has the same caveats as Vulkan but with `CurrentInstance` only.

## OpenAL

OpenAL has the same caveats as OpenGL, with the exception that `alGetProcAddress` is made available to retrieve the
function pointers. This still has the requirement of a thread-specific context, however, which can be made current using
`AL.ThisThread.MakeCurrent`.

Unlike OpenGL, OpenAL has an official context API: OpenAL Context (ALC). `alcMakeContextCurrent` will implicitly call
`AL.ThisThread.MakeCurrent` meaning that the static OpenAL functions are made available in the obvious way:

```csharp
// NOTE: We are making use of ALContext's static functions here as well.
// The same applies as if `ALContext.Create` were used.
DeviceHandle device = ALContext.OpenDevice("");
if (device == nullptr) throw new("failed to create device");

ContextHandle context = ALContext.CreateContext(device, nullptr);
if (context == nullptr) throw new("failed to create context");

// Now make the context current. This implicitly calls AL.ThisThread.MakeCurrent
ALContext.MakeContextCurrent(context);

// Static functions now just work.
var source = AL.GenSource();
```

## OpenAL Context (ALContext/ALC)

ALC has the same caveats as Vulkan, given that the ALC function pointers are tied to a specific device. As a result,
`alcOpenDevice` is intercepted to set the value of `CurrentDevice` to then be fed into `alcGetProcAddress` (or
`alcGetProcAddress2` if available).
