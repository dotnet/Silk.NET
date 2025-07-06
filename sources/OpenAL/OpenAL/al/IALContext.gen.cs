// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Generated using the OpenAL Soft headers and corresponding dependencies.
// Original source is licensed under the LGPL 2.0 license. Please note that while bindings are able to be MIT due to
// being header-derived only, implementations of the headers may have a less permissive license.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenAL;

public unsafe partial interface IALContext
{
    public partial interface Static
    {
        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
        static abstract sbyte CaptureCloseDevice(DeviceHandle device);

        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        static abstract DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] int format,
            [NativeTypeName("ALCsizei")] int buffersize
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
        static abstract DeviceHandle CaptureOpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
            [NativeTypeName("ALCuint")] uint frequency,
            [NativeTypeName("ALCenum")] int format,
            [NativeTypeName("ALCsizei")] int buffersize
        );

        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        static abstract void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] void* buffer,
            [NativeTypeName("ALCsizei")] int samples
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
        static abstract void CaptureSamples(
            DeviceHandle device,
            [NativeTypeName("ALCvoid *")] Ref buffer,
            [NativeTypeName("ALCsizei")] int samples
        );

        [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
        static abstract void CaptureStart(DeviceHandle device);

        [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
        static abstract void CaptureStop(DeviceHandle device);

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
        static abstract sbyte CloseDevice(DeviceHandle device);

        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        static abstract ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] int* attrlist
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcCreateContext")]
        static abstract ContextHandle CreateContext(
            DeviceHandle device,
            [NativeTypeName("const ALCint *")] Ref<int> attrlist
        );

        [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
        static abstract void DestroyContext(ContextHandle context);

        [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
        static abstract DeviceHandle GetContextsDevice(ContextHandle context);

        [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
        static abstract ContextHandle GetCurrentContext();

        [return: NativeTypeName("ALCenum")]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        static abstract int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* enumname
        );

        [return: NativeTypeName("ALCenum")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
        static abstract int GetEnumValue(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> enumname
        );

        [return: NativeTypeName("ALCenum")]
        [NativeFunction("openal", EntryPoint = "alcGetError")]
        static abstract int GetError(DeviceHandle device);

        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        static abstract void GetIntegerv(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] int* values
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
        static abstract void GetIntegerv(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1,
            [NativeTypeName("ALCsizei")] int size,
            [NativeTypeName("ALCint *")] Ref<int> values
        );

        [return: NativeTypeName("ALCvoid *")]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        static abstract void* GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* funcname
        );

        [return: NativeTypeName("ALCvoid *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
        static abstract Ptr GetProcAddress(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> funcname
        );

        [return: NativeTypeName("const ALCchar *")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        static abstract Ptr<sbyte> GetString(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1
        );

        [return: NativeTypeName("const ALCchar *")]
        [NativeFunction("openal", EntryPoint = "alcGetString")]
        static abstract sbyte* GetStringRaw(
            DeviceHandle device,
            [NativeTypeName("ALCenum")] int param1
        );

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        static abstract sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] sbyte* extname
        );

        [return: NativeTypeName("ALCboolean")]
        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
        static abstract sbyte IsExtensionPresent(
            DeviceHandle device,
            [NativeTypeName("const ALCchar *")] Ref<sbyte> extname
        );

        [return: NativeTypeName("ALCboolean")]
        [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
        static abstract sbyte MakeContextCurrent(ContextHandle context);

        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        static abstract DeviceHandle OpenDevice(
            [NativeTypeName("const ALCchar *")] sbyte* devicename
        );

        [Transformed]
        [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
        static abstract DeviceHandle OpenDevice(
            [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename
        );

        [NativeFunction("openal", EntryPoint = "alcProcessContext")]
        static abstract void ProcessContext(ContextHandle context);

        [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
        static abstract void SuspendContext(ContextHandle context);
    }

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcCaptureCloseDevice")]
    sbyte CaptureCloseDevice(DeviceHandle device);

    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    DeviceHandle CaptureOpenDevice(
        [NativeTypeName("const ALCchar *")] sbyte* devicename,
        [NativeTypeName("ALCuint")] uint frequency,
        [NativeTypeName("ALCenum")] int format,
        [NativeTypeName("ALCsizei")] int buffersize
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCaptureOpenDevice")]
    DeviceHandle CaptureOpenDevice(
        [NativeTypeName("const ALCchar *")] Ref<sbyte> devicename,
        [NativeTypeName("ALCuint")] uint frequency,
        [NativeTypeName("ALCenum")] int format,
        [NativeTypeName("ALCsizei")] int buffersize
    );

    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    void CaptureSamples(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] void* buffer,
        [NativeTypeName("ALCsizei")] int samples
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCaptureSamples")]
    void CaptureSamples(
        DeviceHandle device,
        [NativeTypeName("ALCvoid *")] Ref buffer,
        [NativeTypeName("ALCsizei")] int samples
    );

    [NativeFunction("openal", EntryPoint = "alcCaptureStart")]
    void CaptureStart(DeviceHandle device);

    [NativeFunction("openal", EntryPoint = "alcCaptureStop")]
    void CaptureStop(DeviceHandle device);

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcCloseDevice")]
    sbyte CloseDevice(DeviceHandle device);

    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    ContextHandle CreateContext(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] int* attrlist
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcCreateContext")]
    ContextHandle CreateContext(
        DeviceHandle device,
        [NativeTypeName("const ALCint *")] Ref<int> attrlist
    );

    [NativeFunction("openal", EntryPoint = "alcDestroyContext")]
    void DestroyContext(ContextHandle context);

    [NativeFunction("openal", EntryPoint = "alcGetContextsDevice")]
    DeviceHandle GetContextsDevice(ContextHandle context);

    [NativeFunction("openal", EntryPoint = "alcGetCurrentContext")]
    ContextHandle GetCurrentContext();

    [return: NativeTypeName("ALCenum")]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    int GetEnumValue(DeviceHandle device, [NativeTypeName("const ALCchar *")] sbyte* enumname);

    [return: NativeTypeName("ALCenum")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetEnumValue")]
    int GetEnumValue(DeviceHandle device, [NativeTypeName("const ALCchar *")] Ref<sbyte> enumname);

    [return: NativeTypeName("ALCenum")]
    [NativeFunction("openal", EntryPoint = "alcGetError")]
    int GetError(DeviceHandle device);

    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    void GetIntegerv(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] int* values
    );

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetIntegerv")]
    void GetIntegerv(
        DeviceHandle device,
        [NativeTypeName("ALCenum")] int param1,
        [NativeTypeName("ALCsizei")] int size,
        [NativeTypeName("ALCint *")] Ref<int> values
    );

    [return: NativeTypeName("ALCvoid *")]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    void* GetProcAddress(DeviceHandle device, [NativeTypeName("const ALCchar *")] sbyte* funcname);

    [return: NativeTypeName("ALCvoid *")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetProcAddress")]
    Ptr GetProcAddress(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> funcname
    );

    [return: NativeTypeName("const ALCchar *")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    Ptr<sbyte> GetString(DeviceHandle device, [NativeTypeName("ALCenum")] int param1);

    [return: NativeTypeName("const ALCchar *")]
    [NativeFunction("openal", EntryPoint = "alcGetString")]
    sbyte* GetStringRaw(DeviceHandle device, [NativeTypeName("ALCenum")] int param1);

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    sbyte IsExtensionPresent(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] sbyte* extname
    );

    [return: NativeTypeName("ALCboolean")]
    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcIsExtensionPresent")]
    sbyte IsExtensionPresent(
        DeviceHandle device,
        [NativeTypeName("const ALCchar *")] Ref<sbyte> extname
    );

    [return: NativeTypeName("ALCboolean")]
    [NativeFunction("openal", EntryPoint = "alcMakeContextCurrent")]
    sbyte MakeContextCurrent(ContextHandle context);

    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    DeviceHandle OpenDevice([NativeTypeName("const ALCchar *")] sbyte* devicename);

    [Transformed]
    [NativeFunction("openal", EntryPoint = "alcOpenDevice")]
    DeviceHandle OpenDevice([NativeTypeName("const ALCchar *")] Ref<sbyte> devicename);

    [NativeFunction("openal", EntryPoint = "alcProcessContext")]
    void ProcessContext(ContextHandle context);

    [NativeFunction("openal", EntryPoint = "alcSuspendContext")]
    void SuspendContext(ContextHandle context);
}
