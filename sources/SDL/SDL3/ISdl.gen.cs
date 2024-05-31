// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.SDL.ChromaLocation;
using static Silk.NET.SDL.ColorPrimaries;
using static Silk.NET.SDL.ColorRange;
using static Silk.NET.SDL.ColorType;
using static Silk.NET.SDL.MatrixCoefficients;
using static Silk.NET.SDL.PenAxis;
using static Silk.NET.SDL.Scancode;
using static Silk.NET.SDL.TransferCharacteristics;

namespace Silk.NET.SDL;

public unsafe partial interface ISdl
{
    public partial interface Static
    {
        [NativeFunction("SDL3", EntryPoint = "SDL_AcquireCameraFrame")]
        static abstract Surface* AcquireCameraFrame(
            CameraHandle camera,
            [NativeTypeName("Uint64 *")] ulong* timestampNS
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AcquireCameraFrame")]
        static abstract Ptr<Surface> AcquireCameraFrame(
            CameraHandle camera,
            [NativeTypeName("Uint64 *")] Ref<ulong> timestampNS
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_AddEventWatch")]
        static abstract int AddEventWatch(
            [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddEventWatch")]
        static abstract int AddEventWatch(
            [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMapping")]
        static abstract int AddGamepadMapping([NativeTypeName("const char *")] sbyte* mapping);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMapping")]
        static abstract int AddGamepadMapping([NativeTypeName("const char *")] Ref<sbyte> mapping);

        [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromFile")]
        static abstract int AddGamepadMappingsFromFile(
            [NativeTypeName("const char *")] sbyte* file
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromFile")]
        static abstract int AddGamepadMappingsFromFile(
            [NativeTypeName("const char *")] Ref<sbyte> file
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromIO")]
        static abstract int AddGamepadMappingsFromIO(
            IOStreamHandle src,
            [NativeTypeName("SDL_bool")] int closeio
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromIO")]
        static abstract int AddGamepadMappingsFromIO(
            IOStreamHandle src,
            [NativeTypeName("SDL_bool")] MaybeBool<int> closeio
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_AddHintCallback")]
        static abstract int AddHintCallback(
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("SDL_HintCallback")]
                delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void> callback,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddHintCallback")]
        static abstract int AddHintCallback(
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("SDL_HintCallback")]
                delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void> callback,
            Ref userdata
        );

        [return: NativeTypeName("SDL_TimerID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddTimer")]
        static abstract uint AddTimer(
            [NativeTypeName("Uint32")] uint interval,
            [NativeTypeName("SDL_TimerCallback")] delegate* unmanaged<uint, void*, uint> callback,
            void* param2
        );

        [return: NativeTypeName("SDL_TimerID")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddTimer")]
        static abstract uint AddTimer(
            [NativeTypeName("Uint32")] uint interval,
            [NativeTypeName("SDL_TimerCallback")] delegate* unmanaged<uint, void*, uint> callback,
            Ref param2
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_AddVulkanRenderSemaphores")]
        static abstract int AddVulkanRenderSemaphores(
            RendererHandle renderer,
            [NativeTypeName("Uint32")] uint wait_stage_mask,
            [NativeTypeName("Sint64")] long wait_semaphore,
            [NativeTypeName("Sint64")] long signal_semaphore
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AllocateEventMemory")]
        static abstract Ptr AllocateEventMemory([NativeTypeName("size_t")] nuint size);

        [NativeFunction("SDL3", EntryPoint = "SDL_AllocateEventMemory")]
        static abstract void* AllocateEventMemoryRaw([NativeTypeName("size_t")] nuint size);

        [NativeFunction("SDL3", EntryPoint = "SDL_AtomicAdd")]
        static abstract int AtomicAdd(AtomicInt* a, int v);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AtomicAdd")]
        static abstract int AtomicAdd(Ref<AtomicInt> a, int v);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AtomicCompareAndSwap")]
        static abstract int AtomicCompareAndSwap(AtomicInt* a, int oldval, int newval);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AtomicCompareAndSwap")]
        static abstract MaybeBool<int> AtomicCompareAndSwap(
            Ref<AtomicInt> a,
            int oldval,
            int newval
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AtomicCompareAndSwapPointer")]
        static abstract int AtomicCompareAndSwapPointer(void** a, void* oldval, void* newval);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AtomicCompareAndSwapPointer")]
        static abstract MaybeBool<int> AtomicCompareAndSwapPointer(Ref2D a, Ref oldval, Ref newval);

        [NativeFunction("SDL3", EntryPoint = "SDL_AtomicGet")]
        static abstract int AtomicGet(AtomicInt* a);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AtomicGet")]
        static abstract int AtomicGet(Ref<AtomicInt> a);

        [NativeFunction("SDL3", EntryPoint = "SDL_AtomicGetPtr")]
        static abstract void* AtomicGetPtr(void** a);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AtomicGetPtr")]
        static abstract Ptr AtomicGetPtr(Ref2D a);

        [NativeFunction("SDL3", EntryPoint = "SDL_AtomicSet")]
        static abstract int AtomicSet(AtomicInt* a, int v);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AtomicSet")]
        static abstract int AtomicSet(Ref<AtomicInt> a, int v);

        [NativeFunction("SDL3", EntryPoint = "SDL_AtomicSetPtr")]
        static abstract void* AtomicSetPtr(void** a, void* v);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AtomicSetPtr")]
        static abstract Ptr AtomicSetPtr(Ref2D a, Ref v);

        [return: NativeTypeName("SDL_JoystickID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AttachVirtualJoystick")]
        static abstract uint AttachVirtualJoystick(
            JoystickType type,
            int naxes,
            int nbuttons,
            int nhats
        );

        [return: NativeTypeName("SDL_JoystickID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AttachVirtualJoystickEx")]
        static abstract uint AttachVirtualJoystickEx(
            [NativeTypeName("const SDL_VirtualJoystickDesc *")] VirtualJoystickDesc* desc
        );

        [return: NativeTypeName("SDL_JoystickID")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AttachVirtualJoystickEx")]
        static abstract uint AttachVirtualJoystickEx(
            [NativeTypeName("const SDL_VirtualJoystickDesc *")] Ref<VirtualJoystickDesc> desc
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AudioDevicePaused")]
        static abstract MaybeBool<int> AudioDevicePaused(
            [NativeTypeName("SDL_AudioDeviceID")] uint dev
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AudioDevicePaused")]
        static abstract int AudioDevicePausedRaw([NativeTypeName("SDL_AudioDeviceID")] uint dev);

        [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStream")]
        static abstract int BindAudioStream(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            AudioStreamHandle stream
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStreams")]
        static abstract int BindAudioStreams(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            AudioStreamHandle* streams,
            int num_streams
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStreams")]
        static abstract int BindAudioStreams(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            Ref<AudioStreamHandle> streams,
            int num_streams
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface")]
        static abstract int BlitSurface(
            Surface* src,
            [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
            Surface* dst,
            Rect* dstrect
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface")]
        static abstract int BlitSurface(
            Ref<Surface> src,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
            Ref<Surface> dst,
            Ref<Rect> dstrect
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceScaled")]
        static abstract int BlitSurfaceScaled(
            Surface* src,
            [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
            Surface* dst,
            Rect* dstrect,
            ScaleMode scaleMode
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceScaled")]
        static abstract int BlitSurfaceScaled(
            Ref<Surface> src,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
            Ref<Surface> dst,
            Ref<Rect> dstrect,
            ScaleMode scaleMode
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUnchecked")]
        static abstract int BlitSurfaceUnchecked(
            Surface* src,
            [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* dstrect
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUnchecked")]
        static abstract int BlitSurfaceUnchecked(
            Ref<Surface> src,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUncheckedScaled")]
        static abstract int BlitSurfaceUncheckedScaled(
            Surface* src,
            [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* dstrect,
            ScaleMode scaleMode
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUncheckedScaled")]
        static abstract int BlitSurfaceUncheckedScaled(
            Ref<Surface> src,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect,
            ScaleMode scaleMode
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BroadcastCondition")]
        static abstract int BroadcastCondition(ConditionHandle cond);

        [NativeFunction("SDL3", EntryPoint = "SDL_CaptureMouse")]
        static abstract int CaptureMouse([NativeTypeName("SDL_bool")] int enabled);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CaptureMouse")]
        static abstract int CaptureMouse([NativeTypeName("SDL_bool")] MaybeBool<int> enabled);

        [NativeFunction("SDL3", EntryPoint = "SDL_CleanupTLS")]
        static abstract void CleanupTLS();

        [NativeFunction("SDL3", EntryPoint = "SDL_ClearAudioStream")]
        static abstract int ClearAudioStream(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_ClearClipboardData")]
        static abstract int ClearClipboardData();

        [NativeFunction("SDL3", EntryPoint = "SDL_ClearComposition")]
        static abstract void ClearComposition();

        [NativeFunction("SDL3", EntryPoint = "SDL_ClearError")]
        static abstract void ClearError();

        [NativeFunction("SDL3", EntryPoint = "SDL_ClearProperty")]
        static abstract int ClearProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearProperty")]
        static abstract int ClearProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CloseAudioDevice")]
        static abstract void CloseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [NativeFunction("SDL3", EntryPoint = "SDL_CloseCamera")]
        static abstract void CloseCamera(CameraHandle camera);

        [NativeFunction("SDL3", EntryPoint = "SDL_CloseGamepad")]
        static abstract void CloseGamepad(GamepadHandle gamepad);

        [NativeFunction("SDL3", EntryPoint = "SDL_CloseHaptic")]
        static abstract void CloseHaptic(HapticHandle haptic);

        [NativeFunction("SDL3", EntryPoint = "SDL_CloseIO")]
        static abstract int CloseIO(IOStreamHandle context);

        [NativeFunction("SDL3", EntryPoint = "SDL_CloseJoystick")]
        static abstract void CloseJoystick(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_CloseSensor")]
        static abstract void CloseSensor(SensorHandle sensor);

        [NativeFunction("SDL3", EntryPoint = "SDL_CloseStorage")]
        static abstract int CloseStorage(StorageHandle storage);

        [NativeFunction("SDL3", EntryPoint = "SDL_ComposeCustomBlendMode")]
        static abstract BlendMode ComposeCustomBlendMode(
            BlendFactor srcColorFactor,
            BlendFactor dstColorFactor,
            BlendOperation colorOperation,
            BlendFactor srcAlphaFactor,
            BlendFactor dstAlphaFactor,
            BlendOperation alphaOperation
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertAudioSamples")]
        static abstract int ConvertAudioSamples(
            [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* src_spec,
            [NativeTypeName("const Uint8 *")] byte* src_data,
            int src_len,
            [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* dst_spec,
            [NativeTypeName("Uint8 **")] byte** dst_data,
            int* dst_len
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertAudioSamples")]
        static abstract int ConvertAudioSamples(
            [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> src_spec,
            [NativeTypeName("const Uint8 *")] Ref<byte> src_data,
            int src_len,
            [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> dst_spec,
            [NativeTypeName("Uint8 **")] Ref2D<byte> dst_data,
            Ref<int> dst_len
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertEventToRenderCoordinates")]
        static abstract int ConvertEventToRenderCoordinates(RendererHandle renderer, Event* @event);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertEventToRenderCoordinates")]
        static abstract int ConvertEventToRenderCoordinates(
            RendererHandle renderer,
            Ref<Event> @event
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixels")]
        static abstract int ConvertPixels(
            int width,
            int height,
            PixelFormatEnum src_format,
            [NativeTypeName("const void *")] void* src,
            int src_pitch,
            PixelFormatEnum dst_format,
            void* dst,
            int dst_pitch
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixels")]
        static abstract int ConvertPixels(
            int width,
            int height,
            PixelFormatEnum src_format,
            [NativeTypeName("const void *")] Ref src,
            int src_pitch,
            PixelFormatEnum dst_format,
            Ref dst,
            int dst_pitch
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixelsAndColorspace")]
        static abstract int ConvertPixelsAndColorspace(
            int width,
            int height,
            PixelFormatEnum src_format,
            Colorspace src_colorspace,
            [NativeTypeName("SDL_PropertiesID")] uint src_properties,
            [NativeTypeName("const void *")] void* src,
            int src_pitch,
            PixelFormatEnum dst_format,
            Colorspace dst_colorspace,
            [NativeTypeName("SDL_PropertiesID")] uint dst_properties,
            void* dst,
            int dst_pitch
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixelsAndColorspace")]
        static abstract int ConvertPixelsAndColorspace(
            int width,
            int height,
            PixelFormatEnum src_format,
            Colorspace src_colorspace,
            [NativeTypeName("SDL_PropertiesID")] uint src_properties,
            [NativeTypeName("const void *")] Ref src,
            int src_pitch,
            PixelFormatEnum dst_format,
            Colorspace dst_colorspace,
            [NativeTypeName("SDL_PropertiesID")] uint dst_properties,
            Ref dst,
            int dst_pitch
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurface")]
        static abstract Surface* ConvertSurface(
            Surface* surface,
            [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurface")]
        static abstract Ptr<Surface> ConvertSurface(
            Ref<Surface> surface,
            [NativeTypeName("const SDL_PixelFormat *")] Ref<PixelFormat> format
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceFormat")]
        static abstract Surface* ConvertSurfaceFormat(
            Surface* surface,
            PixelFormatEnum pixel_format
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceFormat")]
        static abstract Ptr<Surface> ConvertSurfaceFormat(
            Ref<Surface> surface,
            PixelFormatEnum pixel_format
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceFormatAndColorspace")]
        static abstract Surface* ConvertSurfaceFormatAndColorspace(
            Surface* surface,
            PixelFormatEnum pixel_format,
            Colorspace colorspace,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceFormatAndColorspace")]
        static abstract Ptr<Surface> ConvertSurfaceFormatAndColorspace(
            Ref<Surface> surface,
            PixelFormatEnum pixel_format,
            Colorspace colorspace,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CopyProperties")]
        static abstract int CopyProperties(
            [NativeTypeName("SDL_PropertiesID")] uint src,
            [NativeTypeName("SDL_PropertiesID")] uint dst
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateAudioStream")]
        static abstract AudioStreamHandle CreateAudioStream(
            [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* src_spec,
            [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* dst_spec
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateAudioStream")]
        static abstract AudioStreamHandle CreateAudioStream(
            [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> src_spec,
            [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> dst_spec
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateColorCursor")]
        static abstract CursorHandle CreateColorCursor(Surface* surface, int hot_x, int hot_y);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateColorCursor")]
        static abstract CursorHandle CreateColorCursor(Ref<Surface> surface, int hot_x, int hot_y);

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateCondition")]
        static abstract ConditionHandle CreateCondition();

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateCursor")]
        static abstract CursorHandle CreateCursor(
            [NativeTypeName("const Uint8 *")] byte* data,
            [NativeTypeName("const Uint8 *")] byte* mask,
            int w,
            int h,
            int hot_x,
            int hot_y
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateCursor")]
        static abstract CursorHandle CreateCursor(
            [NativeTypeName("const Uint8 *")] Ref<byte> data,
            [NativeTypeName("const Uint8 *")] Ref<byte> mask,
            int w,
            int h,
            int hot_x,
            int hot_y
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateDirectory")]
        static abstract int CreateDirectory([NativeTypeName("const char *")] sbyte* path);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateDirectory")]
        static abstract int CreateDirectory([NativeTypeName("const char *")] Ref<sbyte> path);

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateHapticEffect")]
        static abstract int CreateHapticEffect(
            HapticHandle haptic,
            [NativeTypeName("const SDL_HapticEffect *")] HapticEffect* effect
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateHapticEffect")]
        static abstract int CreateHapticEffect(
            HapticHandle haptic,
            [NativeTypeName("const SDL_HapticEffect *")] Ref<HapticEffect> effect
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateMutex")]
        static abstract MutexHandle CreateMutex();

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreatePalette")]
        static abstract Ptr<Palette> CreatePalette(int ncolors);

        [NativeFunction("SDL3", EntryPoint = "SDL_CreatePalette")]
        static abstract Palette* CreatePaletteRaw(int ncolors);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreatePixelFormat")]
        static abstract Ptr<PixelFormat> CreatePixelFormat(PixelFormatEnum pixel_format);

        [NativeFunction("SDL3", EntryPoint = "SDL_CreatePixelFormat")]
        static abstract PixelFormat* CreatePixelFormatRaw(PixelFormatEnum pixel_format);

        [NativeFunction("SDL3", EntryPoint = "SDL_CreatePopupWindow")]
        static abstract WindowHandle CreatePopupWindow(
            WindowHandle parent,
            int offset_x,
            int offset_y,
            int w,
            int h,
            [NativeTypeName("SDL_WindowFlags")] uint flags
        );

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateProperties")]
        static abstract uint CreateProperties();

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateRenderer")]
        static abstract RendererHandle CreateRenderer(
            WindowHandle window,
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("Uint32")] uint flags
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateRenderer")]
        static abstract RendererHandle CreateRenderer(
            WindowHandle window,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("Uint32")] uint flags
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateRendererWithProperties")]
        static abstract RendererHandle CreateRendererWithProperties(
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateRWLock")]
        static abstract RWLockHandle CreateRWLock();

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSemaphore")]
        static abstract SemaphoreHandle CreateSemaphore(
            [NativeTypeName("Uint32")] uint initial_value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSoftwareRenderer")]
        static abstract RendererHandle CreateSoftwareRenderer(Surface* surface);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSoftwareRenderer")]
        static abstract RendererHandle CreateSoftwareRenderer(Ref<Surface> surface);

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateStorageDirectory")]
        static abstract int CreateStorageDirectory(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateStorageDirectory")]
        static abstract int CreateStorageDirectory(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurface")]
        static abstract Ptr<Surface> CreateSurface(int width, int height, PixelFormatEnum format);

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfaceFrom")]
        static abstract Surface* CreateSurfaceFrom(
            void* pixels,
            int width,
            int height,
            int pitch,
            PixelFormatEnum format
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfaceFrom")]
        static abstract Ptr<Surface> CreateSurfaceFrom(
            Ref pixels,
            int width,
            int height,
            int pitch,
            PixelFormatEnum format
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurface")]
        static abstract Surface* CreateSurfaceRaw(int width, int height, PixelFormatEnum format);

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSystemCursor")]
        static abstract CursorHandle CreateSystemCursor(SystemCursor id);

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTexture")]
        static abstract TextureHandle CreateTexture(
            RendererHandle renderer,
            PixelFormatEnum format,
            int access,
            int w,
            int h
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureFromSurface")]
        static abstract TextureHandle CreateTextureFromSurface(
            RendererHandle renderer,
            Surface* surface
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureFromSurface")]
        static abstract TextureHandle CreateTextureFromSurface(
            RendererHandle renderer,
            Ref<Surface> surface
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureWithProperties")]
        static abstract TextureHandle CreateTextureWithProperties(
            RendererHandle renderer,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateThread")]
        static abstract ThreadHandle CreateThread(
            [NativeTypeName("SDL_ThreadFunction")] delegate* unmanaged<void*, int> fn,
            [NativeTypeName("const char *")] sbyte* name,
            void* data
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateThread")]
        static abstract ThreadHandle CreateThread(
            [NativeTypeName("SDL_ThreadFunction")] delegate* unmanaged<void*, int> fn,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            Ref data
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadWithStackSize")]
        static abstract ThreadHandle CreateThreadWithStackSize(
            [NativeTypeName("SDL_ThreadFunction")] delegate* unmanaged<void*, int> fn,
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("const size_t")] nuint stacksize,
            void* data
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadWithStackSize")]
        static abstract ThreadHandle CreateThreadWithStackSize(
            [NativeTypeName("SDL_ThreadFunction")] delegate* unmanaged<void*, int> fn,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("const size_t")] nuint stacksize,
            Ref data
        );

        [return: NativeTypeName("SDL_TLSID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTLS")]
        static abstract uint CreateTLS();

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindow")]
        static abstract WindowHandle CreateWindow(
            [NativeTypeName("const char *")] sbyte* title,
            int w,
            int h,
            [NativeTypeName("SDL_WindowFlags")] uint flags
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindow")]
        static abstract WindowHandle CreateWindow(
            [NativeTypeName("const char *")] Ref<sbyte> title,
            int w,
            int h,
            [NativeTypeName("SDL_WindowFlags")] uint flags
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowAndRenderer")]
        static abstract int CreateWindowAndRenderer(
            [NativeTypeName("const char *")] sbyte* title,
            int width,
            int height,
            [NativeTypeName("SDL_WindowFlags")] uint window_flags,
            WindowHandle* window,
            RendererHandle* renderer
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowAndRenderer")]
        static abstract int CreateWindowAndRenderer(
            [NativeTypeName("const char *")] Ref<sbyte> title,
            int width,
            int height,
            [NativeTypeName("SDL_WindowFlags")] uint window_flags,
            Ref<WindowHandle> window,
            Ref<RendererHandle> renderer
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowWithProperties")]
        static abstract WindowHandle CreateWindowWithProperties(
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CursorVisible")]
        static abstract MaybeBool<int> CursorVisible();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CursorVisible")]
        static abstract int CursorVisibleRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_DateTimeToTime")]
        static abstract int DateTimeToTime(
            [NativeTypeName("const SDL_DateTime *")] DateTime* dt,
            [NativeTypeName("SDL_Time *")] long* ticks
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DateTimeToTime")]
        static abstract int DateTimeToTime(
            [NativeTypeName("const SDL_DateTime *")] Ref<DateTime> dt,
            [NativeTypeName("SDL_Time *")] Ref<long> ticks
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_Delay")]
        static abstract void Delay([NativeTypeName("Uint32")] uint ms);

        [NativeFunction("SDL3", EntryPoint = "SDL_DelayNS")]
        static abstract void DelayNS([NativeTypeName("Uint64")] ulong ns);

        [NativeFunction("SDL3", EntryPoint = "SDL_DelEventWatch")]
        static abstract void DelEventWatch(
            [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DelEventWatch")]
        static abstract void DelEventWatch(
            [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_DelHintCallback")]
        static abstract void DelHintCallback(
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("SDL_HintCallback")]
                delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void> callback,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DelHintCallback")]
        static abstract void DelHintCallback(
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("SDL_HintCallback")]
                delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void> callback,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyAudioStream")]
        static abstract void DestroyAudioStream(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyCondition")]
        static abstract void DestroyCondition(ConditionHandle cond);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyCursor")]
        static abstract void DestroyCursor(CursorHandle cursor);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyHapticEffect")]
        static abstract void DestroyHapticEffect(HapticHandle haptic, int effect);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyMutex")]
        static abstract void DestroyMutex(MutexHandle mutex);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPalette")]
        static abstract void DestroyPalette(Palette* palette);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPalette")]
        static abstract void DestroyPalette(Ref<Palette> palette);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPixelFormat")]
        static abstract void DestroyPixelFormat(PixelFormat* format);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPixelFormat")]
        static abstract void DestroyPixelFormat(Ref<PixelFormat> format);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyProperties")]
        static abstract void DestroyProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyRenderer")]
        static abstract void DestroyRenderer(RendererHandle renderer);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyRWLock")]
        static abstract void DestroyRWLock(RWLockHandle rwlock);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroySemaphore")]
        static abstract void DestroySemaphore(SemaphoreHandle sem);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroySurface")]
        static abstract void DestroySurface(Surface* surface);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroySurface")]
        static abstract void DestroySurface(Ref<Surface> surface);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyTexture")]
        static abstract void DestroyTexture(TextureHandle texture);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindow")]
        static abstract void DestroyWindow(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindowSurface")]
        static abstract int DestroyWindowSurface(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_DetachThread")]
        static abstract void DetachThread(ThreadHandle thread);

        [NativeFunction("SDL3", EntryPoint = "SDL_DetachVirtualJoystick")]
        static abstract int DetachVirtualJoystick(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_DisableScreenSaver")]
        static abstract int DisableScreenSaver();

        [NativeFunction("SDL3", EntryPoint = "SDL_DuplicateSurface")]
        static abstract Surface* DuplicateSurface(Surface* surface);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DuplicateSurface")]
        static abstract Ptr<Surface> DuplicateSurface(Ref<Surface> surface);

        [return: NativeTypeName("SDL_EGLConfig")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentEGLConfig")]
        static abstract Ptr EGLGetCurrentEGLConfig();

        [return: NativeTypeName("SDL_EGLConfig")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentEGLConfig")]
        static abstract void* EGLGetCurrentEGLConfigRaw();

        [return: NativeTypeName("SDL_EGLDisplay")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentEGLDisplay")]
        static abstract Ptr EGLGetCurrentEGLDisplay();

        [return: NativeTypeName("SDL_EGLDisplay")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentEGLDisplay")]
        static abstract void* EGLGetCurrentEGLDisplayRaw();

        [return: NativeTypeName("SDL_FunctionPointer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetProcAddress")]
        static abstract delegate* unmanaged<void> EGLGetProcAddress(
            [NativeTypeName("const char *")] sbyte* proc
        );

        [return: NativeTypeName("SDL_FunctionPointer")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetProcAddress")]
        static abstract delegate* unmanaged<void> EGLGetProcAddress(
            [NativeTypeName("const char *")] Ref<sbyte> proc
        );

        [return: NativeTypeName("SDL_EGLSurface")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetWindowEGLSurface")]
        static abstract Ptr EGLGetWindowEGLSurface(WindowHandle window);

        [return: NativeTypeName("SDL_EGLSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetWindowEGLSurface")]
        static abstract void* EGLGetWindowEGLSurfaceRaw(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_SetEGLAttributeCallbacks")]
        static abstract void EGLSetEGLAttributeCallbacks(
            [NativeTypeName("SDL_EGLAttribArrayCallback")]
                delegate* unmanaged<nint*> platformAttribCallback,
            [NativeTypeName("SDL_EGLIntArrayCallback")]
                delegate* unmanaged<int*> surfaceAttribCallback,
            [NativeTypeName("SDL_EGLIntArrayCallback")]
                delegate* unmanaged<int*> contextAttribCallback
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_EnableScreenSaver")]
        static abstract int EnableScreenSaver();

        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateDirectory")]
        static abstract int EnumerateDirectory(
            [NativeTypeName("const char *")] sbyte* path,
            [NativeTypeName("SDL_EnumerateDirectoryCallback")]
                delegate* unmanaged<void*, sbyte*, sbyte*, int> callback,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateDirectory")]
        static abstract int EnumerateDirectory(
            [NativeTypeName("const char *")] Ref<sbyte> path,
            [NativeTypeName("SDL_EnumerateDirectoryCallback")]
                delegate* unmanaged<void*, sbyte*, sbyte*, int> callback,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateProperties")]
        static abstract int EnumerateProperties(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("SDL_EnumeratePropertiesCallback")]
                delegate* unmanaged<void*, uint, sbyte*, void> callback,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateProperties")]
        static abstract int EnumerateProperties(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("SDL_EnumeratePropertiesCallback")]
                delegate* unmanaged<void*, uint, sbyte*, void> callback,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateStorageDirectory")]
        static abstract int EnumerateStorageDirectory(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path,
            [NativeTypeName("SDL_EnumerateDirectoryCallback")]
                delegate* unmanaged<void*, sbyte*, sbyte*, int> callback,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateStorageDirectory")]
        static abstract int EnumerateStorageDirectory(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path,
            [NativeTypeName("SDL_EnumerateDirectoryCallback")]
                delegate* unmanaged<void*, sbyte*, sbyte*, int> callback,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_Error")]
        static abstract int Error(Errorcode code);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EventEnabled")]
        static abstract MaybeBool<int> EventEnabled([NativeTypeName("Uint32")] uint type);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EventEnabled")]
        static abstract int EventEnabledRaw([NativeTypeName("Uint32")] uint type);

        [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRect")]
        static abstract int FillSurfaceRect(
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            [NativeTypeName("Uint32")] uint color
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRect")]
        static abstract int FillSurfaceRect(
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            [NativeTypeName("Uint32")] uint color
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRects")]
        static abstract int FillSurfaceRects(
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* rects,
            int count,
            [NativeTypeName("Uint32")] uint color
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRects")]
        static abstract int FillSurfaceRects(
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rects,
            int count,
            [NativeTypeName("Uint32")] uint color
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_FilterEvents")]
        static abstract void FilterEvents(
            [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_FilterEvents")]
        static abstract void FilterEvents(
            [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_FlashWindow")]
        static abstract int FlashWindow(WindowHandle window, FlashOperation operation);

        [NativeFunction("SDL3", EntryPoint = "SDL_FlipSurface")]
        static abstract int FlipSurface(Surface* surface, FlipMode flip);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlipSurface")]
        static abstract int FlipSurface(Ref<Surface> surface, FlipMode flip);

        [NativeFunction("SDL3", EntryPoint = "SDL_FlushAudioStream")]
        static abstract int FlushAudioStream(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_FlushEvent")]
        static abstract void FlushEvent([NativeTypeName("Uint32")] uint type);

        [NativeFunction("SDL3", EntryPoint = "SDL_FlushEvents")]
        static abstract void FlushEvents(
            [NativeTypeName("Uint32")] uint minType,
            [NativeTypeName("Uint32")] uint maxType
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_FlushRenderer")]
        static abstract int FlushRenderer(RendererHandle renderer);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadConnected")]
        static abstract MaybeBool<int> GamepadConnected(GamepadHandle gamepad);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadConnected")]
        static abstract int GamepadConnectedRaw(GamepadHandle gamepad);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadEventsEnabled")]
        static abstract MaybeBool<int> GamepadEventsEnabled();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadEventsEnabled")]
        static abstract int GamepadEventsEnabledRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasAxis")]
        static abstract MaybeBool<int> GamepadHasAxis(GamepadHandle gamepad, GamepadAxis axis);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasAxis")]
        static abstract int GamepadHasAxisRaw(GamepadHandle gamepad, GamepadAxis axis);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasButton")]
        static abstract MaybeBool<int> GamepadHasButton(
            GamepadHandle gamepad,
            GamepadButton button
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasButton")]
        static abstract int GamepadHasButtonRaw(GamepadHandle gamepad, GamepadButton button);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasSensor")]
        static abstract MaybeBool<int> GamepadHasSensor(GamepadHandle gamepad, SensorType type);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasSensor")]
        static abstract int GamepadHasSensorRaw(GamepadHandle gamepad, SensorType type);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadSensorEnabled")]
        static abstract MaybeBool<int> GamepadSensorEnabled(GamepadHandle gamepad, SensorType type);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadSensorEnabled")]
        static abstract int GamepadSensorEnabledRaw(GamepadHandle gamepad, SensorType type);

        [return: NativeTypeName("SDL_AssertionHandler")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionHandler")]
        static abstract delegate* unmanaged<AssertData*, void*, AssertState> GetAssertionHandler(
            void** puserdata
        );

        [return: NativeTypeName("SDL_AssertionHandler")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionHandler")]
        static abstract delegate* unmanaged<AssertData*, void*, AssertState> GetAssertionHandler(
            Ref2D puserdata
        );

        [return: NativeTypeName("const SDL_AssertData *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionReport")]
        static abstract Ptr<AssertData> GetAssertionReport();

        [return: NativeTypeName("const SDL_AssertData *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionReport")]
        static abstract AssertData* GetAssertionReportRaw();

        [return: NativeTypeName("SDL_AudioDeviceID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioCaptureDevices")]
        static abstract uint* GetAudioCaptureDevices(int* count);

        [return: NativeTypeName("SDL_AudioDeviceID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioCaptureDevices")]
        static abstract Ptr<uint> GetAudioCaptureDevices(Ref<int> count);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceFormat")]
        static abstract int GetAudioDeviceFormat(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            AudioSpec* spec,
            int* sample_frames
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceFormat")]
        static abstract int GetAudioDeviceFormat(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            Ref<AudioSpec> spec,
            Ref<int> sample_frames
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceName")]
        static abstract Ptr<sbyte> GetAudioDeviceName(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceName")]
        static abstract sbyte* GetAudioDeviceNameRaw(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDriver")]
        static abstract Ptr<sbyte> GetAudioDriver(int index);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDriver")]
        static abstract sbyte* GetAudioDriverRaw(int index);

        [return: NativeTypeName("SDL_AudioDeviceID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioOutputDevices")]
        static abstract uint* GetAudioOutputDevices(int* count);

        [return: NativeTypeName("SDL_AudioDeviceID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioOutputDevices")]
        static abstract Ptr<uint> GetAudioOutputDevices(Ref<int> count);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamAvailable")]
        static abstract int GetAudioStreamAvailable(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamData")]
        static abstract int GetAudioStreamData(AudioStreamHandle stream, void* buf, int len);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamData")]
        static abstract int GetAudioStreamData(AudioStreamHandle stream, Ref buf, int len);

        [return: NativeTypeName("SDL_AudioDeviceID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamDevice")]
        static abstract uint GetAudioStreamDevice(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFormat")]
        static abstract int GetAudioStreamFormat(
            AudioStreamHandle stream,
            AudioSpec* src_spec,
            AudioSpec* dst_spec
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFormat")]
        static abstract int GetAudioStreamFormat(
            AudioStreamHandle stream,
            Ref<AudioSpec> src_spec,
            Ref<AudioSpec> dst_spec
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFrequencyRatio")]
        static abstract float GetAudioStreamFrequencyRatio(AudioStreamHandle stream);

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamProperties")]
        static abstract uint GetAudioStreamProperties(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamQueued")]
        static abstract int GetAudioStreamQueued(AudioStreamHandle stream);

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetBasePath")]
        static abstract Ptr<sbyte> GetBasePath();

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetBasePath")]
        static abstract sbyte* GetBasePathRaw();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetBooleanProperty")]
        static abstract int GetBooleanProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("SDL_bool")] int default_value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetBooleanProperty")]
        static abstract MaybeBool<int> GetBooleanProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("SDL_bool")] MaybeBool<int> default_value
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDeviceName")]
        static abstract Ptr<sbyte> GetCameraDeviceName(
            [NativeTypeName("SDL_CameraDeviceID")] uint instance_id
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDeviceName")]
        static abstract sbyte* GetCameraDeviceNameRaw(
            [NativeTypeName("SDL_CameraDeviceID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDevicePosition")]
        static abstract CameraPosition GetCameraDevicePosition(
            [NativeTypeName("SDL_CameraDeviceID")] uint instance_id
        );

        [return: NativeTypeName("SDL_CameraDeviceID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDevices")]
        static abstract uint* GetCameraDevices(int* count);

        [return: NativeTypeName("SDL_CameraDeviceID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDevices")]
        static abstract Ptr<uint> GetCameraDevices(Ref<int> count);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDeviceSupportedFormats")]
        static abstract CameraSpec* GetCameraDeviceSupportedFormats(
            [NativeTypeName("SDL_CameraDeviceID")] uint devid,
            int* count
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDeviceSupportedFormats")]
        static abstract Ptr<CameraSpec> GetCameraDeviceSupportedFormats(
            [NativeTypeName("SDL_CameraDeviceID")] uint devid,
            Ref<int> count
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDriver")]
        static abstract Ptr<sbyte> GetCameraDriver(int index);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDriver")]
        static abstract sbyte* GetCameraDriverRaw(int index);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraFormat")]
        static abstract int GetCameraFormat(CameraHandle camera, CameraSpec* spec);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraFormat")]
        static abstract int GetCameraFormat(CameraHandle camera, Ref<CameraSpec> spec);

        [return: NativeTypeName("SDL_CameraDeviceID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraInstanceID")]
        static abstract uint GetCameraInstanceID(CameraHandle camera);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraPermissionState")]
        static abstract int GetCameraPermissionState(CameraHandle camera);

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraProperties")]
        static abstract uint GetCameraProperties(CameraHandle camera);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardData")]
        static abstract void* GetClipboardData(
            [NativeTypeName("const char *")] sbyte* mime_type,
            [NativeTypeName("size_t *")] nuint* size
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardData")]
        static abstract Ptr GetClipboardData(
            [NativeTypeName("const char *")] Ref<sbyte> mime_type,
            [NativeTypeName("size_t *")] Ref<nuint> size
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardText")]
        static abstract Ptr<sbyte> GetClipboardText();

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardText")]
        static abstract sbyte* GetClipboardTextRaw();

        [return: NativeTypeName("const SDL_DisplayMode *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
        static abstract DisplayMode* GetClosestFullscreenDisplayMode(
            [NativeTypeName("SDL_DisplayID")] uint displayID,
            int w,
            int h,
            float refresh_rate,
            [NativeTypeName("SDL_bool")] int include_high_density_modes
        );

        [return: NativeTypeName("const SDL_DisplayMode *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
        static abstract Ptr<DisplayMode> GetClosestFullscreenDisplayMode(
            [NativeTypeName("SDL_DisplayID")] uint displayID,
            int w,
            int h,
            float refresh_rate,
            [NativeTypeName("SDL_bool")] MaybeBool<int> include_high_density_modes
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCPUCacheLineSize")]
        static abstract int GetCPUCacheLineSize();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCPUCount")]
        static abstract int GetCPUCount();

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentAudioDriver")]
        static abstract Ptr<sbyte> GetCurrentAudioDriver();

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentAudioDriver")]
        static abstract sbyte* GetCurrentAudioDriverRaw();

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentCameraDriver")]
        static abstract Ptr<sbyte> GetCurrentCameraDriver();

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentCameraDriver")]
        static abstract sbyte* GetCurrentCameraDriverRaw();

        [return: NativeTypeName("const SDL_DisplayMode *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDisplayMode")]
        static abstract Ptr<DisplayMode> GetCurrentDisplayMode(
            [NativeTypeName("SDL_DisplayID")] uint displayID
        );

        [return: NativeTypeName("const SDL_DisplayMode *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDisplayMode")]
        static abstract DisplayMode* GetCurrentDisplayModeRaw(
            [NativeTypeName("SDL_DisplayID")] uint displayID
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDisplayOrientation")]
        static abstract DisplayOrientation GetCurrentDisplayOrientation(
            [NativeTypeName("SDL_DisplayID")] uint displayID
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentRenderOutputSize")]
        static abstract int GetCurrentRenderOutputSize(RendererHandle renderer, int* w, int* h);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentRenderOutputSize")]
        static abstract int GetCurrentRenderOutputSize(
            RendererHandle renderer,
            Ref<int> w,
            Ref<int> h
        );

        [return: NativeTypeName("SDL_ThreadID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentThreadID")]
        static abstract ulong GetCurrentThreadID();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentTime")]
        static abstract int GetCurrentTime([NativeTypeName("SDL_Time *")] long* ticks);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentTime")]
        static abstract int GetCurrentTime([NativeTypeName("SDL_Time *")] Ref<long> ticks);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentVideoDriver")]
        static abstract Ptr<sbyte> GetCurrentVideoDriver();

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentVideoDriver")]
        static abstract sbyte* GetCurrentVideoDriverRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCursor")]
        static abstract CursorHandle GetCursor();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetDayOfWeek")]
        static abstract int GetDayOfWeek(int year, int month, int day);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetDayOfYear")]
        static abstract int GetDayOfYear(int year, int month, int day);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetDaysInMonth")]
        static abstract int GetDaysInMonth(int year, int month);

        [return: NativeTypeName("SDL_AssertionHandler")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultAssertionHandler")]
        static abstract delegate* unmanaged<
            AssertData*,
            void*,
            AssertState> GetDefaultAssertionHandler();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultCursor")]
        static abstract CursorHandle GetDefaultCursor();

        [return: NativeTypeName("const SDL_DisplayMode *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDesktopDisplayMode")]
        static abstract Ptr<DisplayMode> GetDesktopDisplayMode(
            [NativeTypeName("SDL_DisplayID")] uint displayID
        );

        [return: NativeTypeName("const SDL_DisplayMode *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDesktopDisplayMode")]
        static abstract DisplayMode* GetDesktopDisplayModeRaw(
            [NativeTypeName("SDL_DisplayID")] uint displayID
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayBounds")]
        static abstract int GetDisplayBounds(
            [NativeTypeName("SDL_DisplayID")] uint displayID,
            Rect* rect
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayBounds")]
        static abstract int GetDisplayBounds(
            [NativeTypeName("SDL_DisplayID")] uint displayID,
            Ref<Rect> rect
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayContentScale")]
        static abstract float GetDisplayContentScale(
            [NativeTypeName("SDL_DisplayID")] uint displayID
        );

        [return: NativeTypeName("SDL_DisplayID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForPoint")]
        static abstract uint GetDisplayForPoint([NativeTypeName("const SDL_Point *")] Point* point);

        [return: NativeTypeName("SDL_DisplayID")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForPoint")]
        static abstract uint GetDisplayForPoint(
            [NativeTypeName("const SDL_Point *")] Ref<Point> point
        );

        [return: NativeTypeName("SDL_DisplayID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForRect")]
        static abstract uint GetDisplayForRect([NativeTypeName("const SDL_Rect *")] Rect* rect);

        [return: NativeTypeName("SDL_DisplayID")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForRect")]
        static abstract uint GetDisplayForRect([NativeTypeName("const SDL_Rect *")] Ref<Rect> rect);

        [return: NativeTypeName("SDL_DisplayID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForWindow")]
        static abstract uint GetDisplayForWindow(WindowHandle window);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayName")]
        static abstract Ptr<sbyte> GetDisplayName([NativeTypeName("SDL_DisplayID")] uint displayID);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayName")]
        static abstract sbyte* GetDisplayNameRaw([NativeTypeName("SDL_DisplayID")] uint displayID);

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayProperties")]
        static abstract uint GetDisplayProperties([NativeTypeName("SDL_DisplayID")] uint displayID);

        [return: NativeTypeName("SDL_DisplayID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplays")]
        static abstract uint* GetDisplays(int* count);

        [return: NativeTypeName("SDL_DisplayID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplays")]
        static abstract Ptr<uint> GetDisplays(Ref<int> count);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayUsableBounds")]
        static abstract int GetDisplayUsableBounds(
            [NativeTypeName("SDL_DisplayID")] uint displayID,
            Rect* rect
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayUsableBounds")]
        static abstract int GetDisplayUsableBounds(
            [NativeTypeName("SDL_DisplayID")] uint displayID,
            Ref<Rect> rect
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetError")]
        static abstract Ptr<sbyte> GetError();

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetError")]
        static abstract sbyte* GetErrorRaw();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEventFilter")]
        static abstract int GetEventFilter(
            [NativeTypeName("SDL_EventFilter *")] delegate* unmanaged<void*, Event*, int>* filter,
            void** userdata
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEventFilter")]
        static abstract MaybeBool<int> GetEventFilter(
            [NativeTypeName("SDL_EventFilter *")] delegate* unmanaged<void*, Event*, int>* filter,
            Ref2D userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetFloatProperty")]
        static abstract float GetFloatProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            float default_value
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetFloatProperty")]
        static abstract float GetFloatProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            float default_value
        );

        [return: NativeTypeName("const SDL_DisplayMode **")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetFullscreenDisplayModes")]
        static abstract DisplayMode** GetFullscreenDisplayModes(
            [NativeTypeName("SDL_DisplayID")] uint displayID,
            int* count
        );

        [return: NativeTypeName("const SDL_DisplayMode **")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetFullscreenDisplayModes")]
        static abstract Ptr2D<DisplayMode> GetFullscreenDisplayModes(
            [NativeTypeName("SDL_DisplayID")] uint displayID,
            Ref<int> count
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis")]
        static abstract Ptr<sbyte> GetGamepadAppleSFSymbolsNameForAxis(
            GamepadHandle gamepad,
            GamepadAxis axis
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis")]
        static abstract sbyte* GetGamepadAppleSFSymbolsNameForAxisRaw(
            GamepadHandle gamepad,
            GamepadAxis axis
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton")]
        static abstract Ptr<sbyte> GetGamepadAppleSFSymbolsNameForButton(
            GamepadHandle gamepad,
            GamepadButton button
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton")]
        static abstract sbyte* GetGamepadAppleSFSymbolsNameForButtonRaw(
            GamepadHandle gamepad,
            GamepadButton button
        );

        [return: NativeTypeName("Sint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAxis")]
        static abstract short GetGamepadAxis(GamepadHandle gamepad, GamepadAxis axis);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAxisFromString")]
        static abstract GamepadAxis GetGamepadAxisFromString(
            [NativeTypeName("const char *")] sbyte* str
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAxisFromString")]
        static abstract GamepadAxis GetGamepadAxisFromString(
            [NativeTypeName("const char *")] Ref<sbyte> str
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadBindings")]
        static abstract GamepadBinding** GetGamepadBindings(GamepadHandle gamepad, int* count);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadBindings")]
        static abstract Ptr2D<GamepadBinding> GetGamepadBindings(
            GamepadHandle gamepad,
            Ref<int> count
        );

        [return: NativeTypeName("Uint8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButton")]
        static abstract byte GetGamepadButton(GamepadHandle gamepad, GamepadButton button);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonFromString")]
        static abstract GamepadButton GetGamepadButtonFromString(
            [NativeTypeName("const char *")] sbyte* str
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonFromString")]
        static abstract GamepadButton GetGamepadButtonFromString(
            [NativeTypeName("const char *")] Ref<sbyte> str
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonLabel")]
        static abstract GamepadButtonLabel GetGamepadButtonLabel(
            GamepadHandle gamepad,
            GamepadButton button
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonLabelForType")]
        static abstract GamepadButtonLabel GetGamepadButtonLabelForType(
            GamepadType type,
            GamepadButton button
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadConnectionState")]
        static abstract JoystickConnectionState GetGamepadConnectionState(GamepadHandle gamepad);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFirmwareVersion")]
        static abstract ushort GetGamepadFirmwareVersion(GamepadHandle gamepad);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFromInstanceID")]
        static abstract GamepadHandle GetGamepadFromInstanceID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFromPlayerIndex")]
        static abstract GamepadHandle GetGamepadFromPlayerIndex(int player_index);

        [return: NativeTypeName("SDL_JoystickGUID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceGUID")]
        static abstract Guid GetGamepadInstanceGuid(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("SDL_JoystickID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceID")]
        static abstract uint GetGamepadInstanceID(GamepadHandle gamepad);

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceMapping")]
        static abstract Ptr<sbyte> GetGamepadInstanceMapping(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceMapping")]
        static abstract sbyte* GetGamepadInstanceMappingRaw(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceName")]
        static abstract Ptr<sbyte> GetGamepadInstanceName(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceName")]
        static abstract sbyte* GetGamepadInstanceNameRaw(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstancePath")]
        static abstract Ptr<sbyte> GetGamepadInstancePath(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstancePath")]
        static abstract sbyte* GetGamepadInstancePathRaw(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstancePlayerIndex")]
        static abstract int GetGamepadInstancePlayerIndex(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceProduct")]
        static abstract ushort GetGamepadInstanceProduct(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceProductVersion")]
        static abstract ushort GetGamepadInstanceProductVersion(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceType")]
        static abstract GamepadType GetGamepadInstanceType(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceVendor")]
        static abstract ushort GetGamepadInstanceVendor(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadJoystick")]
        static abstract JoystickHandle GetGamepadJoystick(GamepadHandle gamepad);

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMapping")]
        static abstract Ptr<sbyte> GetGamepadMapping(GamepadHandle gamepad);

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForGUID")]
        static abstract Ptr<sbyte> GetGamepadMappingForGuid(
            [NativeTypeName("SDL_JoystickGUID")] Guid guid
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForGUID")]
        static abstract sbyte* GetGamepadMappingForGuidRaw(
            [NativeTypeName("SDL_JoystickGUID")] Guid guid
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMapping")]
        static abstract sbyte* GetGamepadMappingRaw(GamepadHandle gamepad);

        [return: NativeTypeName("char **")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappings")]
        static abstract sbyte** GetGamepadMappings(int* count);

        [return: NativeTypeName("char **")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappings")]
        static abstract Ptr2D<sbyte> GetGamepadMappings(Ref<int> count);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadName")]
        static abstract Ptr<sbyte> GetGamepadName(GamepadHandle gamepad);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadName")]
        static abstract sbyte* GetGamepadNameRaw(GamepadHandle gamepad);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPath")]
        static abstract Ptr<sbyte> GetGamepadPath(GamepadHandle gamepad);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPath")]
        static abstract sbyte* GetGamepadPathRaw(GamepadHandle gamepad);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPlayerIndex")]
        static abstract int GetGamepadPlayerIndex(GamepadHandle gamepad);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPowerInfo")]
        static abstract PowerState GetGamepadPowerInfo(GamepadHandle gamepad, int* percent);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPowerInfo")]
        static abstract PowerState GetGamepadPowerInfo(GamepadHandle gamepad, Ref<int> percent);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProduct")]
        static abstract ushort GetGamepadProduct(GamepadHandle gamepad);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProductVersion")]
        static abstract ushort GetGamepadProductVersion(GamepadHandle gamepad);

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProperties")]
        static abstract uint GetGamepadProperties(GamepadHandle gamepad);

        [return: NativeTypeName("SDL_JoystickID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepads")]
        static abstract uint* GetGamepads(int* count);

        [return: NativeTypeName("SDL_JoystickID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepads")]
        static abstract Ptr<uint> GetGamepads(Ref<int> count);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorData")]
        static abstract int GetGamepadSensorData(
            GamepadHandle gamepad,
            SensorType type,
            float* data,
            int num_values
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorData")]
        static abstract int GetGamepadSensorData(
            GamepadHandle gamepad,
            SensorType type,
            Ref<float> data,
            int num_values
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorDataRate")]
        static abstract float GetGamepadSensorDataRate(GamepadHandle gamepad, SensorType type);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSerial")]
        static abstract Ptr<sbyte> GetGamepadSerial(GamepadHandle gamepad);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSerial")]
        static abstract sbyte* GetGamepadSerialRaw(GamepadHandle gamepad);

        [return: NativeTypeName("Uint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSteamHandle")]
        static abstract ulong GetGamepadSteamHandle(GamepadHandle gamepad);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForAxis")]
        static abstract Ptr<sbyte> GetGamepadStringForAxis(GamepadAxis axis);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForAxis")]
        static abstract sbyte* GetGamepadStringForAxisRaw(GamepadAxis axis);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForButton")]
        static abstract Ptr<sbyte> GetGamepadStringForButton(GamepadButton button);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForButton")]
        static abstract sbyte* GetGamepadStringForButtonRaw(GamepadButton button);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForType")]
        static abstract Ptr<sbyte> GetGamepadStringForType(GamepadType type);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForType")]
        static abstract sbyte* GetGamepadStringForTypeRaw(GamepadType type);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTouchpadFinger")]
        static abstract int GetGamepadTouchpadFinger(
            GamepadHandle gamepad,
            int touchpad,
            int finger,
            [NativeTypeName("Uint8 *")] byte* state,
            float* x,
            float* y,
            float* pressure
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTouchpadFinger")]
        static abstract int GetGamepadTouchpadFinger(
            GamepadHandle gamepad,
            int touchpad,
            int finger,
            [NativeTypeName("Uint8 *")] Ref<byte> state,
            Ref<float> x,
            Ref<float> y,
            Ref<float> pressure
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadType")]
        static abstract GamepadType GetGamepadType(GamepadHandle gamepad);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTypeFromString")]
        static abstract GamepadType GetGamepadTypeFromString(
            [NativeTypeName("const char *")] sbyte* str
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTypeFromString")]
        static abstract GamepadType GetGamepadTypeFromString(
            [NativeTypeName("const char *")] Ref<sbyte> str
        );

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadVendor")]
        static abstract ushort GetGamepadVendor(GamepadHandle gamepad);

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalMouseState")]
        static abstract uint GetGlobalMouseState(float* x, float* y);

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalMouseState")]
        static abstract uint GetGlobalMouseState(Ref<float> x, Ref<float> y);

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalProperties")]
        static abstract uint GetGlobalProperties();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGrabbedWindow")]
        static abstract WindowHandle GetGrabbedWindow();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticEffectStatus")]
        static abstract int GetHapticEffectStatus(HapticHandle haptic, int effect);

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticFeatures")]
        static abstract uint GetHapticFeatures(HapticHandle haptic);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticFromInstanceID")]
        static abstract HapticHandle GetHapticFromInstanceID(
            [NativeTypeName("SDL_HapticID")] uint instance_id
        );

        [return: NativeTypeName("SDL_HapticID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticInstanceID")]
        static abstract uint GetHapticInstanceID(HapticHandle haptic);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticInstanceName")]
        static abstract Ptr<sbyte> GetHapticInstanceName(
            [NativeTypeName("SDL_HapticID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticInstanceName")]
        static abstract sbyte* GetHapticInstanceNameRaw(
            [NativeTypeName("SDL_HapticID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticName")]
        static abstract Ptr<sbyte> GetHapticName(HapticHandle haptic);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticName")]
        static abstract sbyte* GetHapticNameRaw(HapticHandle haptic);

        [return: NativeTypeName("SDL_HapticID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHaptics")]
        static abstract uint* GetHaptics(int* count);

        [return: NativeTypeName("SDL_HapticID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHaptics")]
        static abstract Ptr<uint> GetHaptics(Ref<int> count);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHint")]
        static abstract sbyte* GetHint([NativeTypeName("const char *")] sbyte* name);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHint")]
        static abstract Ptr<sbyte> GetHint([NativeTypeName("const char *")] Ref<sbyte> name);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHintBoolean")]
        static abstract int GetHintBoolean(
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("SDL_bool")] int default_value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHintBoolean")]
        static abstract MaybeBool<int> GetHintBoolean(
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("SDL_bool")] MaybeBool<int> default_value
        );

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetIOProperties")]
        static abstract uint GetIOProperties(IOStreamHandle context);

        [return: NativeTypeName("Sint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetIOSize")]
        static abstract long GetIOSize(IOStreamHandle context);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetIOStatus")]
        static abstract IOStatus GetIOStatus(IOStreamHandle context);

        [return: NativeTypeName("Sint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxis")]
        static abstract short GetJoystickAxis(JoystickHandle joystick, int axis);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxisInitialState")]
        static abstract int GetJoystickAxisInitialState(
            JoystickHandle joystick,
            int axis,
            [NativeTypeName("Sint16 *")] short* state
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxisInitialState")]
        static abstract MaybeBool<int> GetJoystickAxisInitialState(
            JoystickHandle joystick,
            int axis,
            [NativeTypeName("Sint16 *")] Ref<short> state
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickBall")]
        static abstract int GetJoystickBall(JoystickHandle joystick, int ball, int* dx, int* dy);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickBall")]
        static abstract int GetJoystickBall(
            JoystickHandle joystick,
            int ball,
            Ref<int> dx,
            Ref<int> dy
        );

        [return: NativeTypeName("Uint8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickButton")]
        static abstract byte GetJoystickButton(JoystickHandle joystick, int button);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickConnectionState")]
        static abstract JoystickConnectionState GetJoystickConnectionState(JoystickHandle joystick);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFirmwareVersion")]
        static abstract ushort GetJoystickFirmwareVersion(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFromInstanceID")]
        static abstract JoystickHandle GetJoystickFromInstanceID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFromPlayerIndex")]
        static abstract JoystickHandle GetJoystickFromPlayerIndex(int player_index);

        [return: NativeTypeName("SDL_JoystickGUID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUID")]
        static abstract Guid GetJoystickGuid(JoystickHandle joystick);

        [return: NativeTypeName("SDL_JoystickGUID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDFromString")]
        static abstract Guid GetJoystickGuidFromString(
            [NativeTypeName("const char *")] sbyte* pchGUID
        );

        [return: NativeTypeName("SDL_JoystickGUID")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDFromString")]
        static abstract Guid GetJoystickGuidFromString(
            [NativeTypeName("const char *")] Ref<sbyte> pchGUID
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDInfo")]
        static abstract void GetJoystickGuidInfo(
            [NativeTypeName("SDL_JoystickGUID")] Guid guid,
            [NativeTypeName("Uint16 *")] ushort* vendor,
            [NativeTypeName("Uint16 *")] ushort* product,
            [NativeTypeName("Uint16 *")] ushort* version,
            [NativeTypeName("Uint16 *")] ushort* crc16
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDInfo")]
        static abstract void GetJoystickGuidInfo(
            [NativeTypeName("SDL_JoystickGUID")] Guid guid,
            [NativeTypeName("Uint16 *")] Ref<ushort> vendor,
            [NativeTypeName("Uint16 *")] Ref<ushort> product,
            [NativeTypeName("Uint16 *")] Ref<ushort> version,
            [NativeTypeName("Uint16 *")] Ref<ushort> crc16
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDString")]
        static abstract int GetJoystickGuidString(
            [NativeTypeName("SDL_JoystickGUID")] Guid guid,
            [NativeTypeName("char *")] sbyte* pszGUID,
            int cbGUID
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDString")]
        static abstract int GetJoystickGuidString(
            [NativeTypeName("SDL_JoystickGUID")] Guid guid,
            [NativeTypeName("char *")] Ref<sbyte> pszGUID,
            int cbGUID
        );

        [return: NativeTypeName("Uint8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickHat")]
        static abstract byte GetJoystickHat(JoystickHandle joystick, int hat);

        [return: NativeTypeName("SDL_JoystickGUID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceGUID")]
        static abstract Guid GetJoystickInstanceGuid(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("SDL_JoystickID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceID")]
        static abstract uint GetJoystickInstanceID(JoystickHandle joystick);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceName")]
        static abstract Ptr<sbyte> GetJoystickInstanceName(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceName")]
        static abstract sbyte* GetJoystickInstanceNameRaw(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstancePath")]
        static abstract Ptr<sbyte> GetJoystickInstancePath(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstancePath")]
        static abstract sbyte* GetJoystickInstancePathRaw(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstancePlayerIndex")]
        static abstract int GetJoystickInstancePlayerIndex(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceProduct")]
        static abstract ushort GetJoystickInstanceProduct(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceProductVersion")]
        static abstract ushort GetJoystickInstanceProductVersion(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceType")]
        static abstract JoystickType GetJoystickInstanceType(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceVendor")]
        static abstract ushort GetJoystickInstanceVendor(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickName")]
        static abstract Ptr<sbyte> GetJoystickName(JoystickHandle joystick);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickName")]
        static abstract sbyte* GetJoystickNameRaw(JoystickHandle joystick);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPath")]
        static abstract Ptr<sbyte> GetJoystickPath(JoystickHandle joystick);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPath")]
        static abstract sbyte* GetJoystickPathRaw(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPlayerIndex")]
        static abstract int GetJoystickPlayerIndex(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPowerInfo")]
        static abstract PowerState GetJoystickPowerInfo(JoystickHandle joystick, int* percent);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPowerInfo")]
        static abstract PowerState GetJoystickPowerInfo(JoystickHandle joystick, Ref<int> percent);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProduct")]
        static abstract ushort GetJoystickProduct(JoystickHandle joystick);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProductVersion")]
        static abstract ushort GetJoystickProductVersion(JoystickHandle joystick);

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProperties")]
        static abstract uint GetJoystickProperties(JoystickHandle joystick);

        [return: NativeTypeName("SDL_JoystickID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoysticks")]
        static abstract uint* GetJoysticks(int* count);

        [return: NativeTypeName("SDL_JoystickID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoysticks")]
        static abstract Ptr<uint> GetJoysticks(Ref<int> count);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickSerial")]
        static abstract Ptr<sbyte> GetJoystickSerial(JoystickHandle joystick);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickSerial")]
        static abstract sbyte* GetJoystickSerialRaw(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickType")]
        static abstract JoystickType GetJoystickType(JoystickHandle joystick);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickVendor")]
        static abstract ushort GetJoystickVendor(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardFocus")]
        static abstract WindowHandle GetKeyboardFocus();

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardInstanceName")]
        static abstract Ptr<sbyte> GetKeyboardInstanceName(
            [NativeTypeName("SDL_KeyboardID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardInstanceName")]
        static abstract sbyte* GetKeyboardInstanceNameRaw(
            [NativeTypeName("SDL_KeyboardID")] uint instance_id
        );

        [return: NativeTypeName("SDL_KeyboardID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboards")]
        static abstract uint* GetKeyboards(int* count);

        [return: NativeTypeName("SDL_KeyboardID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboards")]
        static abstract Ptr<uint> GetKeyboards(Ref<int> count);

        [return: NativeTypeName("const Uint8 *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardState")]
        static abstract byte* GetKeyboardState(int* numkeys);

        [return: NativeTypeName("const Uint8 *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardState")]
        static abstract Ptr<byte> GetKeyboardState(Ref<int> numkeys);

        [return: NativeTypeName("SDL_Keycode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromName")]
        static abstract int GetKeyFromName([NativeTypeName("const char *")] sbyte* name);

        [return: NativeTypeName("SDL_Keycode")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromName")]
        static abstract int GetKeyFromName([NativeTypeName("const char *")] Ref<sbyte> name);

        [return: NativeTypeName("SDL_Keycode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromScancode")]
        static abstract int GetKeyFromScancode(Scancode scancode);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyName")]
        static abstract Ptr<sbyte> GetKeyName([NativeTypeName("SDL_Keycode")] int key);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyName")]
        static abstract sbyte* GetKeyNameRaw([NativeTypeName("SDL_Keycode")] int key);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetLogOutputFunction")]
        static abstract void GetLogOutputFunction(
            [NativeTypeName("SDL_LogOutputFunction *")]
                delegate* unmanaged<void*, int, LogPriority, sbyte*, void>* callback,
            void** userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetLogOutputFunction")]
        static abstract void GetLogOutputFunction(
            [NativeTypeName("SDL_LogOutputFunction *")]
                delegate* unmanaged<void*, int, LogPriority, sbyte*, void>* callback,
            Ref2D userdata
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMasksForPixelFormatEnum")]
        static abstract int GetMasksForPixelFormatEnum(
            PixelFormatEnum format,
            int* bpp,
            [NativeTypeName("Uint32 *")] uint* Rmask,
            [NativeTypeName("Uint32 *")] uint* Gmask,
            [NativeTypeName("Uint32 *")] uint* Bmask,
            [NativeTypeName("Uint32 *")] uint* Amask
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMasksForPixelFormatEnum")]
        static abstract MaybeBool<int> GetMasksForPixelFormatEnum(
            PixelFormatEnum format,
            Ref<int> bpp,
            [NativeTypeName("Uint32 *")] Ref<uint> Rmask,
            [NativeTypeName("Uint32 *")] Ref<uint> Gmask,
            [NativeTypeName("Uint32 *")] Ref<uint> Bmask,
            [NativeTypeName("Uint32 *")] Ref<uint> Amask
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetMaxHapticEffects")]
        static abstract int GetMaxHapticEffects(HapticHandle haptic);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetMaxHapticEffectsPlaying")]
        static abstract int GetMaxHapticEffectsPlaying(HapticHandle haptic);

        [return: NativeTypeName("SDL_MouseID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMice")]
        static abstract uint* GetMice(int* count);

        [return: NativeTypeName("SDL_MouseID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMice")]
        static abstract Ptr<uint> GetMice(Ref<int> count);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetModState")]
        static abstract Keymod GetModState();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseFocus")]
        static abstract WindowHandle GetMouseFocus();

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseInstanceName")]
        static abstract Ptr<sbyte> GetMouseInstanceName(
            [NativeTypeName("SDL_MouseID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseInstanceName")]
        static abstract sbyte* GetMouseInstanceNameRaw(
            [NativeTypeName("SDL_MouseID")] uint instance_id
        );

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseState")]
        static abstract uint GetMouseState(float* x, float* y);

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseState")]
        static abstract uint GetMouseState(Ref<float> x, Ref<float> y);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNaturalDisplayOrientation")]
        static abstract DisplayOrientation GetNaturalDisplayOrientation(
            [NativeTypeName("SDL_DisplayID")] uint displayID
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumAudioDrivers")]
        static abstract int GetNumAudioDrivers();

        [return: NativeTypeName("Sint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumberProperty")]
        static abstract long GetNumberProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("Sint64")] long default_value
        );

        [return: NativeTypeName("Sint64")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumberProperty")]
        static abstract long GetNumberProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("Sint64")] long default_value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumCameraDrivers")]
        static abstract int GetNumCameraDrivers();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGamepadTouchpadFingers")]
        static abstract int GetNumGamepadTouchpadFingers(GamepadHandle gamepad, int touchpad);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGamepadTouchpads")]
        static abstract int GetNumGamepadTouchpads(GamepadHandle gamepad);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumHapticAxes")]
        static abstract int GetNumHapticAxes(HapticHandle haptic);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickAxes")]
        static abstract int GetNumJoystickAxes(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickBalls")]
        static abstract int GetNumJoystickBalls(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickButtons")]
        static abstract int GetNumJoystickButtons(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickHats")]
        static abstract int GetNumJoystickHats(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumRenderDrivers")]
        static abstract int GetNumRenderDrivers();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumVideoDrivers")]
        static abstract int GetNumVideoDrivers();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetPathInfo")]
        static abstract int GetPathInfo(
            [NativeTypeName("const char *")] sbyte* path,
            PathInfo* info
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPathInfo")]
        static abstract int GetPathInfo(
            [NativeTypeName("const char *")] Ref<sbyte> path,
            Ref<PathInfo> info
        );

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPenCapabilities")]
        static abstract uint GetPenCapabilities(
            [NativeTypeName("SDL_PenID")] uint instance_id,
            PenCapabilityInfo* capabilities
        );

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPenCapabilities")]
        static abstract uint GetPenCapabilities(
            [NativeTypeName("SDL_PenID")] uint instance_id,
            Ref<PenCapabilityInfo> capabilities
        );

        [return: NativeTypeName("SDL_PenID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPenFromGUID")]
        static abstract uint GetPenFromGuid(Guid guid);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetPenGUID")]
        static abstract Guid GetPenGuid([NativeTypeName("SDL_PenID")] uint instance_id);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPenName")]
        static abstract Ptr<sbyte> GetPenName([NativeTypeName("SDL_PenID")] uint instance_id);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPenName")]
        static abstract sbyte* GetPenNameRaw([NativeTypeName("SDL_PenID")] uint instance_id);

        [return: NativeTypeName("SDL_PenID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPens")]
        static abstract uint* GetPens(int* count);

        [return: NativeTypeName("SDL_PenID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPens")]
        static abstract Ptr<uint> GetPens(Ref<int> count);

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPenStatus")]
        static abstract uint GetPenStatus(
            [NativeTypeName("SDL_PenID")] uint instance_id,
            float* x,
            float* y,
            float* axes,
            [NativeTypeName("size_t")] nuint num_axes
        );

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPenStatus")]
        static abstract uint GetPenStatus(
            [NativeTypeName("SDL_PenID")] uint instance_id,
            Ref<float> x,
            Ref<float> y,
            Ref<float> axes,
            [NativeTypeName("size_t")] nuint num_axes
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetPenType")]
        static abstract PenSubtype GetPenType([NativeTypeName("SDL_PenID")] uint instance_id);

        [return: NativeTypeName("Uint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPerformanceCounter")]
        static abstract ulong GetPerformanceCounter();

        [return: NativeTypeName("Uint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPerformanceFrequency")]
        static abstract ulong GetPerformanceFrequency();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatEnumForMasks")]
        static abstract PixelFormatEnum GetPixelFormatEnumForMasks(
            int bpp,
            [NativeTypeName("Uint32")] uint Rmask,
            [NativeTypeName("Uint32")] uint Gmask,
            [NativeTypeName("Uint32")] uint Bmask,
            [NativeTypeName("Uint32")] uint Amask
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatName")]
        static abstract Ptr<sbyte> GetPixelFormatName(PixelFormatEnum format);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatName")]
        static abstract sbyte* GetPixelFormatNameRaw(PixelFormatEnum format);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPlatform")]
        static abstract Ptr<sbyte> GetPlatform();

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPlatform")]
        static abstract sbyte* GetPlatformRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetPowerInfo")]
        static abstract PowerState GetPowerInfo(int* seconds, int* percent);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPowerInfo")]
        static abstract PowerState GetPowerInfo(Ref<int> seconds, Ref<int> percent);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPreferredLocales")]
        static abstract Ptr<Locale> GetPreferredLocales();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetPreferredLocales")]
        static abstract Locale* GetPreferredLocalesRaw();

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPrefPath")]
        static abstract sbyte* GetPrefPath(
            [NativeTypeName("const char *")] sbyte* org,
            [NativeTypeName("const char *")] sbyte* app
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPrefPath")]
        static abstract Ptr<sbyte> GetPrefPath(
            [NativeTypeName("const char *")] Ref<sbyte> org,
            [NativeTypeName("const char *")] Ref<sbyte> app
        );

        [return: NativeTypeName("SDL_DisplayID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPrimaryDisplay")]
        static abstract uint GetPrimaryDisplay();

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPrimarySelectionText")]
        static abstract Ptr<sbyte> GetPrimarySelectionText();

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPrimarySelectionText")]
        static abstract sbyte* GetPrimarySelectionTextRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetProperty")]
        static abstract void* GetProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            void* default_value
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetProperty")]
        static abstract Ptr GetProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            Ref default_value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetPropertyType")]
        static abstract PropertyType GetPropertyType(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPropertyType")]
        static abstract PropertyType GetPropertyType(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRealGamepadInstanceType")]
        static abstract GamepadType GetRealGamepadInstanceType(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRealGamepadType")]
        static abstract GamepadType GetRealGamepadType(GamepadHandle gamepad);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersection")]
        static abstract int GetRectAndLineIntersection(
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            int* X1,
            int* Y1,
            int* X2,
            int* Y2
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersection")]
        static abstract MaybeBool<int> GetRectAndLineIntersection(
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            Ref<int> X1,
            Ref<int> Y1,
            Ref<int> X2,
            Ref<int> Y2
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersectionFloat")]
        static abstract int GetRectAndLineIntersectionFloat(
            [NativeTypeName("const SDL_FRect *")] FRect* rect,
            float* X1,
            float* Y1,
            float* X2,
            float* Y2
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersectionFloat")]
        static abstract MaybeBool<int> GetRectAndLineIntersectionFloat(
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> rect,
            Ref<float> X1,
            Ref<float> Y1,
            Ref<float> X2,
            Ref<float> Y2
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPoints")]
        static abstract int GetRectEnclosingPoints(
            [NativeTypeName("const SDL_Point *")] Point* points,
            int count,
            [NativeTypeName("const SDL_Rect *")] Rect* clip,
            Rect* result
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPoints")]
        static abstract MaybeBool<int> GetRectEnclosingPoints(
            [NativeTypeName("const SDL_Point *")] Ref<Point> points,
            int count,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> clip,
            Ref<Rect> result
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
        static abstract int GetRectEnclosingPointsFloat(
            [NativeTypeName("const SDL_FPoint *")] FPoint* points,
            int count,
            [NativeTypeName("const SDL_FRect *")] FRect* clip,
            FRect* result
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
        static abstract MaybeBool<int> GetRectEnclosingPointsFloat(
            [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> points,
            int count,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> clip,
            Ref<FRect> result
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersection")]
        static abstract int GetRectIntersection(
            [NativeTypeName("const SDL_Rect *")] Rect* A,
            [NativeTypeName("const SDL_Rect *")] Rect* B,
            Rect* result
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersection")]
        static abstract MaybeBool<int> GetRectIntersection(
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> A,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> B,
            Ref<Rect> result
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersectionFloat")]
        static abstract int GetRectIntersectionFloat(
            [NativeTypeName("const SDL_FRect *")] FRect* A,
            [NativeTypeName("const SDL_FRect *")] FRect* B,
            FRect* result
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersectionFloat")]
        static abstract MaybeBool<int> GetRectIntersectionFloat(
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> A,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> B,
            Ref<FRect> result
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnion")]
        static abstract int GetRectUnion(
            [NativeTypeName("const SDL_Rect *")] Rect* A,
            [NativeTypeName("const SDL_Rect *")] Rect* B,
            Rect* result
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnion")]
        static abstract int GetRectUnion(
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> A,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> B,
            Ref<Rect> result
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnionFloat")]
        static abstract int GetRectUnionFloat(
            [NativeTypeName("const SDL_FRect *")] FRect* A,
            [NativeTypeName("const SDL_FRect *")] FRect* B,
            FRect* result
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnionFloat")]
        static abstract int GetRectUnionFloat(
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> A,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> B,
            Ref<FRect> result
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseMode")]
        static abstract MaybeBool<int> GetRelativeMouseMode();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseMode")]
        static abstract int GetRelativeMouseModeRaw();

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseState")]
        static abstract uint GetRelativeMouseState(float* x, float* y);

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseState")]
        static abstract uint GetRelativeMouseState(Ref<float> x, Ref<float> y);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderClipRect")]
        static abstract int GetRenderClipRect(RendererHandle renderer, Rect* rect);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderClipRect")]
        static abstract int GetRenderClipRect(RendererHandle renderer, Ref<Rect> rect);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderColorScale")]
        static abstract int GetRenderColorScale(RendererHandle renderer, float* scale);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderColorScale")]
        static abstract int GetRenderColorScale(RendererHandle renderer, Ref<float> scale);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawBlendMode")]
        static abstract int GetRenderDrawBlendMode(RendererHandle renderer, BlendMode* blendMode);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawBlendMode")]
        static abstract int GetRenderDrawBlendMode(
            RendererHandle renderer,
            Ref<BlendMode> blendMode
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColor")]
        static abstract int GetRenderDrawColor(
            RendererHandle renderer,
            [NativeTypeName("Uint8 *")] byte* r,
            [NativeTypeName("Uint8 *")] byte* g,
            [NativeTypeName("Uint8 *")] byte* b,
            [NativeTypeName("Uint8 *")] byte* a
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColor")]
        static abstract int GetRenderDrawColor(
            RendererHandle renderer,
            [NativeTypeName("Uint8 *")] Ref<byte> r,
            [NativeTypeName("Uint8 *")] Ref<byte> g,
            [NativeTypeName("Uint8 *")] Ref<byte> b,
            [NativeTypeName("Uint8 *")] Ref<byte> a
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColorFloat")]
        static abstract int GetRenderDrawColorFloat(
            RendererHandle renderer,
            float* r,
            float* g,
            float* b,
            float* a
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColorFloat")]
        static abstract int GetRenderDrawColorFloat(
            RendererHandle renderer,
            Ref<float> r,
            Ref<float> g,
            Ref<float> b,
            Ref<float> a
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDriver")]
        static abstract Ptr<sbyte> GetRenderDriver(int index);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDriver")]
        static abstract sbyte* GetRenderDriverRaw(int index);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderer")]
        static abstract RendererHandle GetRenderer(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererFromTexture")]
        static abstract RendererHandle GetRendererFromTexture(TextureHandle texture);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererInfo")]
        static abstract int GetRendererInfo(RendererHandle renderer, RendererInfo* info);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererInfo")]
        static abstract int GetRendererInfo(RendererHandle renderer, Ref<RendererInfo> info);

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererProperties")]
        static abstract uint GetRendererProperties(RendererHandle renderer);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentation")]
        static abstract int GetRenderLogicalPresentation(
            RendererHandle renderer,
            int* w,
            int* h,
            RendererLogicalPresentation* mode,
            ScaleMode* scale_mode
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentation")]
        static abstract int GetRenderLogicalPresentation(
            RendererHandle renderer,
            Ref<int> w,
            Ref<int> h,
            Ref<RendererLogicalPresentation> mode,
            Ref<ScaleMode> scale_mode
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalCommandEncoder")]
        static abstract Ptr GetRenderMetalCommandEncoder(RendererHandle renderer);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalCommandEncoder")]
        static abstract void* GetRenderMetalCommandEncoderRaw(RendererHandle renderer);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalLayer")]
        static abstract Ptr GetRenderMetalLayer(RendererHandle renderer);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalLayer")]
        static abstract void* GetRenderMetalLayerRaw(RendererHandle renderer);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderOutputSize")]
        static abstract int GetRenderOutputSize(RendererHandle renderer, int* w, int* h);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderOutputSize")]
        static abstract int GetRenderOutputSize(RendererHandle renderer, Ref<int> w, Ref<int> h);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderScale")]
        static abstract int GetRenderScale(RendererHandle renderer, float* scaleX, float* scaleY);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderScale")]
        static abstract int GetRenderScale(
            RendererHandle renderer,
            Ref<float> scaleX,
            Ref<float> scaleY
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderTarget")]
        static abstract TextureHandle GetRenderTarget(RendererHandle renderer);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderViewport")]
        static abstract int GetRenderViewport(RendererHandle renderer, Rect* rect);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderViewport")]
        static abstract int GetRenderViewport(RendererHandle renderer, Ref<Rect> rect);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderVSync")]
        static abstract int GetRenderVSync(RendererHandle renderer, int* vsync);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderVSync")]
        static abstract int GetRenderVSync(RendererHandle renderer, Ref<int> vsync);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderWindow")]
        static abstract WindowHandle GetRenderWindow(RendererHandle renderer);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRevision")]
        static abstract Ptr<sbyte> GetRevision();

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRevision")]
        static abstract sbyte* GetRevisionRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRGB")]
        static abstract void GetRGB(
            [NativeTypeName("Uint32")] uint pixel,
            [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format,
            [NativeTypeName("Uint8 *")] byte* r,
            [NativeTypeName("Uint8 *")] byte* g,
            [NativeTypeName("Uint8 *")] byte* b
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRGB")]
        static abstract void GetRGB(
            [NativeTypeName("Uint32")] uint pixel,
            [NativeTypeName("const SDL_PixelFormat *")] Ref<PixelFormat> format,
            [NativeTypeName("Uint8 *")] Ref<byte> r,
            [NativeTypeName("Uint8 *")] Ref<byte> g,
            [NativeTypeName("Uint8 *")] Ref<byte> b
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRGBA")]
        static abstract void GetRgba(
            [NativeTypeName("Uint32")] uint pixel,
            [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format,
            [NativeTypeName("Uint8 *")] byte* r,
            [NativeTypeName("Uint8 *")] byte* g,
            [NativeTypeName("Uint8 *")] byte* b,
            [NativeTypeName("Uint8 *")] byte* a
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRGBA")]
        static abstract void GetRgba(
            [NativeTypeName("Uint32")] uint pixel,
            [NativeTypeName("const SDL_PixelFormat *")] Ref<PixelFormat> format,
            [NativeTypeName("Uint8 *")] Ref<byte> r,
            [NativeTypeName("Uint8 *")] Ref<byte> g,
            [NativeTypeName("Uint8 *")] Ref<byte> b,
            [NativeTypeName("Uint8 *")] Ref<byte> a
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromKey")]
        static abstract Scancode GetScancodeFromKey([NativeTypeName("SDL_Keycode")] int key);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromName")]
        static abstract Scancode GetScancodeFromName([NativeTypeName("const char *")] sbyte* name);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromName")]
        static abstract Scancode GetScancodeFromName(
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeName")]
        static abstract Ptr<sbyte> GetScancodeName(Scancode scancode);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeName")]
        static abstract sbyte* GetScancodeNameRaw(Scancode scancode);

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSemaphoreValue")]
        static abstract uint GetSemaphoreValue(SemaphoreHandle sem);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorData")]
        static abstract int GetSensorData(SensorHandle sensor, float* data, int num_values);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorData")]
        static abstract int GetSensorData(SensorHandle sensor, Ref<float> data, int num_values);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorFromInstanceID")]
        static abstract SensorHandle GetSensorFromInstanceID(
            [NativeTypeName("SDL_SensorID")] uint instance_id
        );

        [return: NativeTypeName("SDL_SensorID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorInstanceID")]
        static abstract uint GetSensorInstanceID(SensorHandle sensor);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorInstanceName")]
        static abstract Ptr<sbyte> GetSensorInstanceName(
            [NativeTypeName("SDL_SensorID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorInstanceName")]
        static abstract sbyte* GetSensorInstanceNameRaw(
            [NativeTypeName("SDL_SensorID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorInstanceNonPortableType")]
        static abstract int GetSensorInstanceNonPortableType(
            [NativeTypeName("SDL_SensorID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorInstanceType")]
        static abstract SensorType GetSensorInstanceType(
            [NativeTypeName("SDL_SensorID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorName")]
        static abstract Ptr<sbyte> GetSensorName(SensorHandle sensor);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorName")]
        static abstract sbyte* GetSensorNameRaw(SensorHandle sensor);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNonPortableType")]
        static abstract int GetSensorNonPortableType(SensorHandle sensor);

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorProperties")]
        static abstract uint GetSensorProperties(SensorHandle sensor);

        [return: NativeTypeName("SDL_SensorID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensors")]
        static abstract uint* GetSensors(int* count);

        [return: NativeTypeName("SDL_SensorID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensors")]
        static abstract Ptr<uint> GetSensors(Ref<int> count);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorType")]
        static abstract SensorType GetSensorType(SensorHandle sensor);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSilenceValueForFormat")]
        static abstract int GetSilenceValueForFormat(
            [NativeTypeName("SDL_AudioFormat")] ushort format
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageFileSize")]
        static abstract int GetStorageFileSize(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path,
            [NativeTypeName("Uint64 *")] ulong* length
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageFileSize")]
        static abstract int GetStorageFileSize(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path,
            [NativeTypeName("Uint64 *")] Ref<ulong> length
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetStoragePathInfo")]
        static abstract int GetStoragePathInfo(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path,
            PathInfo* info
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStoragePathInfo")]
        static abstract int GetStoragePathInfo(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path,
            Ref<PathInfo> info
        );

        [return: NativeTypeName("Uint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageSpaceRemaining")]
        static abstract ulong GetStorageSpaceRemaining(StorageHandle storage);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStringProperty")]
        static abstract sbyte* GetStringProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("const char *")] sbyte* default_value
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStringProperty")]
        static abstract Ptr<sbyte> GetStringProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("const char *")] Ref<sbyte> default_value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceAlphaMod")]
        static abstract int GetSurfaceAlphaMod(
            Surface* surface,
            [NativeTypeName("Uint8 *")] byte* alpha
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceAlphaMod")]
        static abstract int GetSurfaceAlphaMod(
            Ref<Surface> surface,
            [NativeTypeName("Uint8 *")] Ref<byte> alpha
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceBlendMode")]
        static abstract int GetSurfaceBlendMode(Surface* surface, BlendMode* blendMode);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceBlendMode")]
        static abstract int GetSurfaceBlendMode(Ref<Surface> surface, Ref<BlendMode> blendMode);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceClipRect")]
        static abstract int GetSurfaceClipRect(Surface* surface, Rect* rect);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceClipRect")]
        static abstract int GetSurfaceClipRect(Ref<Surface> surface, Ref<Rect> rect);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorKey")]
        static abstract int GetSurfaceColorKey(
            Surface* surface,
            [NativeTypeName("Uint32 *")] uint* key
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorKey")]
        static abstract int GetSurfaceColorKey(
            Ref<Surface> surface,
            [NativeTypeName("Uint32 *")] Ref<uint> key
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorMod")]
        static abstract int GetSurfaceColorMod(
            Surface* surface,
            [NativeTypeName("Uint8 *")] byte* r,
            [NativeTypeName("Uint8 *")] byte* g,
            [NativeTypeName("Uint8 *")] byte* b
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorMod")]
        static abstract int GetSurfaceColorMod(
            Ref<Surface> surface,
            [NativeTypeName("Uint8 *")] Ref<byte> r,
            [NativeTypeName("Uint8 *")] Ref<byte> g,
            [NativeTypeName("Uint8 *")] Ref<byte> b
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorspace")]
        static abstract int GetSurfaceColorspace(Surface* surface, Colorspace* colorspace);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorspace")]
        static abstract int GetSurfaceColorspace(Ref<Surface> surface, Ref<Colorspace> colorspace);

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceProperties")]
        static abstract uint GetSurfaceProperties(Surface* surface);

        [return: NativeTypeName("SDL_PropertiesID")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceProperties")]
        static abstract uint GetSurfaceProperties(Ref<Surface> surface);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSystemRAM")]
        static abstract int GetSystemRAM();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSystemTheme")]
        static abstract SystemTheme GetSystemTheme();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaMod")]
        static abstract int GetTextureAlphaMod(
            TextureHandle texture,
            [NativeTypeName("Uint8 *")] byte* alpha
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaMod")]
        static abstract int GetTextureAlphaMod(
            TextureHandle texture,
            [NativeTypeName("Uint8 *")] Ref<byte> alpha
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaModFloat")]
        static abstract int GetTextureAlphaModFloat(TextureHandle texture, float* alpha);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaModFloat")]
        static abstract int GetTextureAlphaModFloat(TextureHandle texture, Ref<float> alpha);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureBlendMode")]
        static abstract int GetTextureBlendMode(TextureHandle texture, BlendMode* blendMode);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureBlendMode")]
        static abstract int GetTextureBlendMode(TextureHandle texture, Ref<BlendMode> blendMode);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorMod")]
        static abstract int GetTextureColorMod(
            TextureHandle texture,
            [NativeTypeName("Uint8 *")] byte* r,
            [NativeTypeName("Uint8 *")] byte* g,
            [NativeTypeName("Uint8 *")] byte* b
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorMod")]
        static abstract int GetTextureColorMod(
            TextureHandle texture,
            [NativeTypeName("Uint8 *")] Ref<byte> r,
            [NativeTypeName("Uint8 *")] Ref<byte> g,
            [NativeTypeName("Uint8 *")] Ref<byte> b
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorModFloat")]
        static abstract int GetTextureColorModFloat(
            TextureHandle texture,
            float* r,
            float* g,
            float* b
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorModFloat")]
        static abstract int GetTextureColorModFloat(
            TextureHandle texture,
            Ref<float> r,
            Ref<float> g,
            Ref<float> b
        );

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureProperties")]
        static abstract uint GetTextureProperties(TextureHandle texture);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureScaleMode")]
        static abstract int GetTextureScaleMode(TextureHandle texture, ScaleMode* scaleMode);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureScaleMode")]
        static abstract int GetTextureScaleMode(TextureHandle texture, Ref<ScaleMode> scaleMode);

        [return: NativeTypeName("SDL_ThreadID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadID")]
        static abstract ulong GetThreadID(ThreadHandle thread);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadName")]
        static abstract Ptr<sbyte> GetThreadName(ThreadHandle thread);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadName")]
        static abstract sbyte* GetThreadNameRaw(ThreadHandle thread);

        [return: NativeTypeName("Uint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTicks")]
        static abstract ulong GetTicks();

        [return: NativeTypeName("Uint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTicksNS")]
        static abstract ulong GetTicksNS();

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTLS")]
        static abstract Ptr GetTLS([NativeTypeName("SDL_TLSID")] uint id);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetTLS")]
        static abstract void* GetTLSRaw([NativeTypeName("SDL_TLSID")] uint id);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceName")]
        static abstract Ptr<sbyte> GetTouchDeviceName(
            [NativeTypeName("SDL_TouchID")] ulong touchID
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceName")]
        static abstract sbyte* GetTouchDeviceNameRaw([NativeTypeName("SDL_TouchID")] ulong touchID);

        [return: NativeTypeName("SDL_TouchID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDevices")]
        static abstract ulong* GetTouchDevices(int* count);

        [return: NativeTypeName("SDL_TouchID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDevices")]
        static abstract Ptr<ulong> GetTouchDevices(Ref<int> count);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceType")]
        static abstract TouchDeviceType GetTouchDeviceType(
            [NativeTypeName("SDL_TouchID")] ulong touchID
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchFingers")]
        static abstract Finger** GetTouchFingers(
            [NativeTypeName("SDL_TouchID")] ulong touchID,
            int* count
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchFingers")]
        static abstract Ptr2D<Finger> GetTouchFingers(
            [NativeTypeName("SDL_TouchID")] ulong touchID,
            Ref<int> count
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetUserFolder")]
        static abstract Ptr<sbyte> GetUserFolder(Folder folder);

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetUserFolder")]
        static abstract sbyte* GetUserFolderRaw(Folder folder);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetVersion")]
        static abstract int GetVersion(Version* ver);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetVersion")]
        static abstract int GetVersion(Ref<Version> ver);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetVideoDriver")]
        static abstract Ptr<sbyte> GetVideoDriver(int index);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetVideoDriver")]
        static abstract sbyte* GetVideoDriverRaw(int index);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowBordersSize")]
        static abstract int GetWindowBordersSize(
            WindowHandle window,
            int* top,
            int* left,
            int* bottom,
            int* right
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowBordersSize")]
        static abstract int GetWindowBordersSize(
            WindowHandle window,
            Ref<int> top,
            Ref<int> left,
            Ref<int> bottom,
            Ref<int> right
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowDisplayScale")]
        static abstract float GetWindowDisplayScale(WindowHandle window);

        [return: NativeTypeName("SDL_WindowFlags")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFlags")]
        static abstract uint GetWindowFlags(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFromID")]
        static abstract WindowHandle GetWindowFromID([NativeTypeName("SDL_WindowID")] uint id);

        [return: NativeTypeName("const SDL_DisplayMode *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFullscreenMode")]
        static abstract Ptr<DisplayMode> GetWindowFullscreenMode(WindowHandle window);

        [return: NativeTypeName("const SDL_DisplayMode *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFullscreenMode")]
        static abstract DisplayMode* GetWindowFullscreenModeRaw(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowICCProfile")]
        static abstract void* GetWindowICCProfile(
            WindowHandle window,
            [NativeTypeName("size_t *")] nuint* size
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowICCProfile")]
        static abstract Ptr GetWindowICCProfile(
            WindowHandle window,
            [NativeTypeName("size_t *")] Ref<nuint> size
        );

        [return: NativeTypeName("SDL_WindowID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowID")]
        static abstract uint GetWindowID(WindowHandle window);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowKeyboardGrab")]
        static abstract MaybeBool<int> GetWindowKeyboardGrab(WindowHandle window);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowKeyboardGrab")]
        static abstract int GetWindowKeyboardGrabRaw(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMaximumSize")]
        static abstract int GetWindowMaximumSize(WindowHandle window, int* w, int* h);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMaximumSize")]
        static abstract int GetWindowMaximumSize(WindowHandle window, Ref<int> w, Ref<int> h);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMinimumSize")]
        static abstract int GetWindowMinimumSize(WindowHandle window, int* w, int* h);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMinimumSize")]
        static abstract int GetWindowMinimumSize(WindowHandle window, Ref<int> w, Ref<int> h);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseGrab")]
        static abstract MaybeBool<int> GetWindowMouseGrab(WindowHandle window);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseGrab")]
        static abstract int GetWindowMouseGrabRaw(WindowHandle window);

        [return: NativeTypeName("const SDL_Rect *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseRect")]
        static abstract Ptr<Rect> GetWindowMouseRect(WindowHandle window);

        [return: NativeTypeName("const SDL_Rect *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseRect")]
        static abstract Rect* GetWindowMouseRectRaw(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowOpacity")]
        static abstract int GetWindowOpacity(WindowHandle window, float* out_opacity);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowOpacity")]
        static abstract int GetWindowOpacity(WindowHandle window, Ref<float> out_opacity);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowParent")]
        static abstract WindowHandle GetWindowParent(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPixelDensity")]
        static abstract float GetWindowPixelDensity(WindowHandle window);

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPixelFormat")]
        static abstract uint GetWindowPixelFormat(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPosition")]
        static abstract int GetWindowPosition(WindowHandle window, int* x, int* y);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPosition")]
        static abstract int GetWindowPosition(WindowHandle window, Ref<int> x, Ref<int> y);

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowProperties")]
        static abstract uint GetWindowProperties(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSize")]
        static abstract int GetWindowSize(WindowHandle window, int* w, int* h);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSize")]
        static abstract int GetWindowSize(WindowHandle window, Ref<int> w, Ref<int> h);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSizeInPixels")]
        static abstract int GetWindowSizeInPixels(WindowHandle window, int* w, int* h);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSizeInPixels")]
        static abstract int GetWindowSizeInPixels(WindowHandle window, Ref<int> w, Ref<int> h);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurface")]
        static abstract Ptr<Surface> GetWindowSurface(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurface")]
        static abstract Surface* GetWindowSurfaceRaw(WindowHandle window);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowTitle")]
        static abstract Ptr<sbyte> GetWindowTitle(WindowHandle window);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowTitle")]
        static abstract sbyte* GetWindowTitleRaw(WindowHandle window);

        [return: NativeTypeName("SDL_GLContext")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_CreateContext")]
        static abstract Ptr GLCreateContext(WindowHandle window);

        [return: NativeTypeName("SDL_GLContext")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_CreateContext")]
        static abstract void* GLCreateContextRaw(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GL_DeleteContext")]
        static abstract int GLDeleteContext([NativeTypeName("SDL_GLContext")] void* context);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_DeleteContext")]
        static abstract int GLDeleteContext([NativeTypeName("SDL_GLContext")] Ref context);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_ExtensionSupported")]
        static abstract int GLExtensionSupported([NativeTypeName("const char *")] sbyte* extension);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_ExtensionSupported")]
        static abstract MaybeBool<int> GLExtensionSupported(
            [NativeTypeName("const char *")] Ref<sbyte> extension
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetAttribute")]
        static abstract int GLGetAttribute(GLattr attr, int* value);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetAttribute")]
        static abstract int GLGetAttribute(GLattr attr, Ref<int> value);

        [return: NativeTypeName("SDL_GLContext")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetCurrentContext")]
        static abstract Ptr GLGetCurrentContext();

        [return: NativeTypeName("SDL_GLContext")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetCurrentContext")]
        static abstract void* GLGetCurrentContextRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetCurrentWindow")]
        static abstract WindowHandle GLGetCurrentWindow();

        [return: NativeTypeName("SDL_FunctionPointer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetProcAddress")]
        static abstract delegate* unmanaged<void> GLGetProcAddress(
            [NativeTypeName("const char *")] sbyte* proc
        );

        [return: NativeTypeName("SDL_FunctionPointer")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetProcAddress")]
        static abstract delegate* unmanaged<void> GLGetProcAddress(
            [NativeTypeName("const char *")] Ref<sbyte> proc
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetSwapInterval")]
        static abstract int GLGetSwapInterval(int* interval);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetSwapInterval")]
        static abstract int GLGetSwapInterval(Ref<int> interval);

        [NativeFunction("SDL3", EntryPoint = "SDL_GL_LoadLibrary")]
        static abstract int GLLoadLibrary([NativeTypeName("const char *")] sbyte* path);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_LoadLibrary")]
        static abstract int GLLoadLibrary([NativeTypeName("const char *")] Ref<sbyte> path);

        [NativeFunction("SDL3", EntryPoint = "SDL_GL_MakeCurrent")]
        static abstract int GLMakeCurrent(
            WindowHandle window,
            [NativeTypeName("SDL_GLContext")] void* context
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_MakeCurrent")]
        static abstract int GLMakeCurrent(
            WindowHandle window,
            [NativeTypeName("SDL_GLContext")] Ref context
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GL_ResetAttributes")]
        static abstract void GLResetAttributes();

        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetAttribute")]
        static abstract int GLSetAttribute(GLattr attr, int value);

        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetSwapInterval")]
        static abstract int GLSetSwapInterval(int interval);

        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SwapWindow")]
        static abstract int GLSwapWindow(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GL_UnloadLibrary")]
        static abstract void GLUnloadLibrary();

        [return: NativeTypeName("char **")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GlobDirectory")]
        static abstract sbyte** GlobDirectory(
            [NativeTypeName("const char *")] sbyte* path,
            [NativeTypeName("const char *")] sbyte* pattern,
            [NativeTypeName("Uint32")] uint flags,
            int* count
        );

        [return: NativeTypeName("char **")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GlobDirectory")]
        static abstract Ptr2D<sbyte> GlobDirectory(
            [NativeTypeName("const char *")] Ref<sbyte> path,
            [NativeTypeName("const char *")] Ref<sbyte> pattern,
            [NativeTypeName("Uint32")] uint flags,
            Ref<int> count
        );

        [return: NativeTypeName("char **")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GlobStorageDirectory")]
        static abstract sbyte** GlobStorageDirectory(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path,
            [NativeTypeName("const char *")] sbyte* pattern,
            [NativeTypeName("Uint32")] uint flags,
            int* count
        );

        [return: NativeTypeName("char **")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GlobStorageDirectory")]
        static abstract Ptr2D<sbyte> GlobStorageDirectory(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path,
            [NativeTypeName("const char *")] Ref<sbyte> pattern,
            [NativeTypeName("Uint32")] uint flags,
            Ref<int> count
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GUIDFromString")]
        static abstract Guid GuidFromString([NativeTypeName("const char *")] sbyte* pchGUID);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GUIDFromString")]
        static abstract Guid GuidFromString([NativeTypeName("const char *")] Ref<sbyte> pchGUID);

        [NativeFunction("SDL3", EntryPoint = "SDL_GUIDToString")]
        static abstract int GuidToString(
            Guid guid,
            [NativeTypeName("char *")] sbyte* pszGUID,
            int cbGUID
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GUIDToString")]
        static abstract int GuidToString(
            Guid guid,
            [NativeTypeName("char *")] Ref<sbyte> pszGUID,
            int cbGUID
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HapticEffectSupported")]
        static abstract int HapticEffectSupported(
            HapticHandle haptic,
            [NativeTypeName("const SDL_HapticEffect *")] HapticEffect* effect
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HapticEffectSupported")]
        static abstract MaybeBool<int> HapticEffectSupported(
            HapticHandle haptic,
            [NativeTypeName("const SDL_HapticEffect *")] Ref<HapticEffect> effect
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HapticRumbleSupported")]
        static abstract MaybeBool<int> HapticRumbleSupported(HapticHandle haptic);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HapticRumbleSupported")]
        static abstract int HapticRumbleSupportedRaw(HapticHandle haptic);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAltiVec")]
        static abstract MaybeBool<int> HasAltiVec();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAltiVec")]
        static abstract int HasAltiVecRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasARMSIMD")]
        static abstract MaybeBool<int> HasArmsimd();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasARMSIMD")]
        static abstract int HasArmsimdRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX")]
        static abstract MaybeBool<int> HasAVX();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX2")]
        static abstract MaybeBool<int> HasAVX2();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX2")]
        static abstract int HasAVX2Raw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX512F")]
        static abstract MaybeBool<int> HasAVX512F();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX512F")]
        static abstract int HasAVX512FRaw();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX")]
        static abstract int HasAVXRaw();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardData")]
        static abstract int HasClipboardData([NativeTypeName("const char *")] sbyte* mime_type);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardData")]
        static abstract MaybeBool<int> HasClipboardData(
            [NativeTypeName("const char *")] Ref<sbyte> mime_type
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardText")]
        static abstract MaybeBool<int> HasClipboardText();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardText")]
        static abstract int HasClipboardTextRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasEvent")]
        static abstract MaybeBool<int> HasEvent([NativeTypeName("Uint32")] uint type);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasEvent")]
        static abstract int HasEventRaw([NativeTypeName("Uint32")] uint type);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasEvents")]
        static abstract MaybeBool<int> HasEvents(
            [NativeTypeName("Uint32")] uint minType,
            [NativeTypeName("Uint32")] uint maxType
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasEvents")]
        static abstract int HasEventsRaw(
            [NativeTypeName("Uint32")] uint minType,
            [NativeTypeName("Uint32")] uint maxType
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasGamepad")]
        static abstract MaybeBool<int> HasGamepad();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasGamepad")]
        static abstract int HasGamepadRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasJoystick")]
        static abstract MaybeBool<int> HasJoystick();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasJoystick")]
        static abstract int HasJoystickRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasKeyboard")]
        static abstract MaybeBool<int> HasKeyboard();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasKeyboard")]
        static abstract int HasKeyboardRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasLASX")]
        static abstract MaybeBool<int> HasLasx();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasLASX")]
        static abstract int HasLasxRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasLSX")]
        static abstract MaybeBool<int> HasLSX();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasLSX")]
        static abstract int HasLSXRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasMMX")]
        static abstract MaybeBool<int> HasMMX();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasMMX")]
        static abstract int HasMMXRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasMouse")]
        static abstract MaybeBool<int> HasMouse();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasMouse")]
        static abstract int HasMouseRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasNEON")]
        static abstract MaybeBool<int> HasNeon();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasNEON")]
        static abstract int HasNeonRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasPrimarySelectionText")]
        static abstract MaybeBool<int> HasPrimarySelectionText();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasPrimarySelectionText")]
        static abstract int HasPrimarySelectionTextRaw();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasProperty")]
        static abstract int HasProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasProperty")]
        static abstract MaybeBool<int> HasProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersection")]
        static abstract int HasRectIntersection(
            [NativeTypeName("const SDL_Rect *")] Rect* A,
            [NativeTypeName("const SDL_Rect *")] Rect* B
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersection")]
        static abstract MaybeBool<int> HasRectIntersection(
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> A,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> B
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersectionFloat")]
        static abstract int HasRectIntersectionFloat(
            [NativeTypeName("const SDL_FRect *")] FRect* A,
            [NativeTypeName("const SDL_FRect *")] FRect* B
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersectionFloat")]
        static abstract MaybeBool<int> HasRectIntersectionFloat(
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> A,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> B
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasScreenKeyboardSupport")]
        static abstract MaybeBool<int> HasScreenKeyboardSupport();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasScreenKeyboardSupport")]
        static abstract int HasScreenKeyboardSupportRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE")]
        static abstract MaybeBool<int> HasSSE();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE2")]
        static abstract MaybeBool<int> HasSSE2();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE2")]
        static abstract int HasSSE2Raw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE3")]
        static abstract MaybeBool<int> HasSSE3();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE3")]
        static abstract int HasSSE3Raw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE41")]
        static abstract MaybeBool<int> HasSSE41();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE41")]
        static abstract int HasSSE41Raw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE42")]
        static abstract MaybeBool<int> HasSSE42();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE42")]
        static abstract int HasSSE42Raw();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE")]
        static abstract int HasSSERaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_ble_scan")]
        static abstract void HidBleScan([NativeTypeName("SDL_bool")] int active);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_ble_scan")]
        static abstract void HidBleScan([NativeTypeName("SDL_bool")] MaybeBool<int> active);

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_close")]
        static abstract int HidClose(HidDeviceHandle dev);

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_device_change_count")]
        static abstract uint HidDeviceChangeCount();

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_enumerate")]
        static abstract Ptr<HidDeviceInfo> HidEnumerate(
            [NativeTypeName("unsigned short")] ushort vendor_id,
            [NativeTypeName("unsigned short")] ushort product_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_enumerate")]
        static abstract HidDeviceInfo* HidEnumerateRaw(
            [NativeTypeName("unsigned short")] ushort vendor_id,
            [NativeTypeName("unsigned short")] ushort product_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_exit")]
        static abstract int HidExit();

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_free_enumeration")]
        static abstract void HidFreeEnumeration(HidDeviceInfo* devs);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_free_enumeration")]
        static abstract void HidFreeEnumeration(Ref<HidDeviceInfo> devs);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_device_info")]
        static abstract Ptr<HidDeviceInfo> HidGetDeviceInfo(HidDeviceHandle dev);

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_device_info")]
        static abstract HidDeviceInfo* HidGetDeviceInfoRaw(HidDeviceHandle dev);

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_feature_report")]
        static abstract int HidGetFeatureReport(
            HidDeviceHandle dev,
            [NativeTypeName("unsigned char *")] byte* data,
            [NativeTypeName("size_t")] nuint length
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_feature_report")]
        static abstract int HidGetFeatureReport(
            HidDeviceHandle dev,
            [NativeTypeName("unsigned char *")] Ref<byte> data,
            [NativeTypeName("size_t")] nuint length
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_indexed_string")]
        static abstract int HidGetIndexedString(
            HidDeviceHandle dev,
            int string_index,
            [NativeTypeName("wchar_t *")] uint* @string,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_indexed_string")]
        static abstract int HidGetIndexedString(
            HidDeviceHandle dev,
            int string_index,
            [NativeTypeName("wchar_t *")] Ref<uint> @string,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_input_report")]
        static abstract int HidGetInputReport(
            HidDeviceHandle dev,
            [NativeTypeName("unsigned char *")] byte* data,
            [NativeTypeName("size_t")] nuint length
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_input_report")]
        static abstract int HidGetInputReport(
            HidDeviceHandle dev,
            [NativeTypeName("unsigned char *")] Ref<byte> data,
            [NativeTypeName("size_t")] nuint length
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_manufacturer_string")]
        static abstract int HidGetManufacturerString(
            HidDeviceHandle dev,
            [NativeTypeName("wchar_t *")] uint* @string,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_manufacturer_string")]
        static abstract int HidGetManufacturerString(
            HidDeviceHandle dev,
            [NativeTypeName("wchar_t *")] Ref<uint> @string,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_product_string")]
        static abstract int HidGetProductString(
            HidDeviceHandle dev,
            [NativeTypeName("wchar_t *")] uint* @string,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_product_string")]
        static abstract int HidGetProductString(
            HidDeviceHandle dev,
            [NativeTypeName("wchar_t *")] Ref<uint> @string,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_report_descriptor")]
        static abstract int HidGetReportDescriptor(
            HidDeviceHandle dev,
            [NativeTypeName("unsigned char *")] byte* buf,
            [NativeTypeName("size_t")] nuint buf_size
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_report_descriptor")]
        static abstract int HidGetReportDescriptor(
            HidDeviceHandle dev,
            [NativeTypeName("unsigned char *")] Ref<byte> buf,
            [NativeTypeName("size_t")] nuint buf_size
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_serial_number_string")]
        static abstract int HidGetSerialNumberString(
            HidDeviceHandle dev,
            [NativeTypeName("wchar_t *")] uint* @string,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_serial_number_string")]
        static abstract int HidGetSerialNumberString(
            HidDeviceHandle dev,
            [NativeTypeName("wchar_t *")] Ref<uint> @string,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_init")]
        static abstract int HidInit();

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_open")]
        static abstract HidDeviceHandle HidOpen(
            [NativeTypeName("unsigned short")] ushort vendor_id,
            [NativeTypeName("unsigned short")] ushort product_id,
            [NativeTypeName("const wchar_t *")] uint* serial_number
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_open")]
        static abstract HidDeviceHandle HidOpen(
            [NativeTypeName("unsigned short")] ushort vendor_id,
            [NativeTypeName("unsigned short")] ushort product_id,
            [NativeTypeName("const wchar_t *")] Ref<uint> serial_number
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_open_path")]
        static abstract HidDeviceHandle HidOpenPath([NativeTypeName("const char *")] sbyte* path);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_open_path")]
        static abstract HidDeviceHandle HidOpenPath(
            [NativeTypeName("const char *")] Ref<sbyte> path
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_read")]
        static abstract int HidRead(
            HidDeviceHandle dev,
            [NativeTypeName("unsigned char *")] byte* data,
            [NativeTypeName("size_t")] nuint length
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_read")]
        static abstract int HidRead(
            HidDeviceHandle dev,
            [NativeTypeName("unsigned char *")] Ref<byte> data,
            [NativeTypeName("size_t")] nuint length
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_read_timeout")]
        static abstract int HidReadTimeout(
            HidDeviceHandle dev,
            [NativeTypeName("unsigned char *")] byte* data,
            [NativeTypeName("size_t")] nuint length,
            int milliseconds
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_read_timeout")]
        static abstract int HidReadTimeout(
            HidDeviceHandle dev,
            [NativeTypeName("unsigned char *")] Ref<byte> data,
            [NativeTypeName("size_t")] nuint length,
            int milliseconds
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_send_feature_report")]
        static abstract int HidSendFeatureReport(
            HidDeviceHandle dev,
            [NativeTypeName("const unsigned char *")] byte* data,
            [NativeTypeName("size_t")] nuint length
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_send_feature_report")]
        static abstract int HidSendFeatureReport(
            HidDeviceHandle dev,
            [NativeTypeName("const unsigned char *")] Ref<byte> data,
            [NativeTypeName("size_t")] nuint length
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_set_nonblocking")]
        static abstract int HidSetNonblocking(HidDeviceHandle dev, int nonblock);

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_write")]
        static abstract int HidWrite(
            HidDeviceHandle dev,
            [NativeTypeName("const unsigned char *")] byte* data,
            [NativeTypeName("size_t")] nuint length
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_write")]
        static abstract int HidWrite(
            HidDeviceHandle dev,
            [NativeTypeName("const unsigned char *")] Ref<byte> data,
            [NativeTypeName("size_t")] nuint length
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_HideCursor")]
        static abstract int HideCursor();

        [NativeFunction("SDL3", EntryPoint = "SDL_HideWindow")]
        static abstract int HideWindow(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_Init")]
        static abstract int Init([NativeTypeName("Uint32")] uint flags);

        [NativeFunction("SDL3", EntryPoint = "SDL_InitHapticRumble")]
        static abstract int InitHapticRumble(HapticHandle haptic);

        [NativeFunction("SDL3", EntryPoint = "SDL_InitSubSystem")]
        static abstract int InitSubSystem([NativeTypeName("Uint32")] uint flags);

        [NativeFunction("SDL3", EntryPoint = "SDL_IOFromConstMem")]
        static abstract IOStreamHandle IOFromConstMem(
            [NativeTypeName("const void *")] void* mem,
            [NativeTypeName("size_t")] nuint size
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOFromConstMem")]
        static abstract IOStreamHandle IOFromConstMem(
            [NativeTypeName("const void *")] Ref mem,
            [NativeTypeName("size_t")] nuint size
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_IOFromDynamicMem")]
        static abstract IOStreamHandle IOFromDynamicMem();

        [NativeFunction("SDL3", EntryPoint = "SDL_IOFromFile")]
        static abstract IOStreamHandle IOFromFile(
            [NativeTypeName("const char *")] sbyte* file,
            [NativeTypeName("const char *")] sbyte* mode
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOFromFile")]
        static abstract IOStreamHandle IOFromFile(
            [NativeTypeName("const char *")] Ref<sbyte> file,
            [NativeTypeName("const char *")] Ref<sbyte> mode
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_IOFromMem")]
        static abstract IOStreamHandle IOFromMem(void* mem, [NativeTypeName("size_t")] nuint size);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOFromMem")]
        static abstract IOStreamHandle IOFromMem(Ref mem, [NativeTypeName("size_t")] nuint size);

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOvprintf")]
        static abstract nuint IOvprintf(
            IOStreamHandle context,
            [NativeTypeName("const char *")] sbyte* fmt,
            [NativeTypeName("va_list")] sbyte* ap
        );

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOvprintf")]
        static abstract nuint IOvprintf(
            IOStreamHandle context,
            [NativeTypeName("const char *")] Ref<sbyte> fmt,
            [NativeTypeName("va_list")] Ref<sbyte> ap
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsGamepad")]
        static abstract MaybeBool<int> IsGamepad(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsGamepad")]
        static abstract int IsGamepadRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickHaptic")]
        static abstract MaybeBool<int> IsJoystickHaptic(JoystickHandle joystick);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickHaptic")]
        static abstract int IsJoystickHapticRaw(JoystickHandle joystick);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickVirtual")]
        static abstract MaybeBool<int> IsJoystickVirtual(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickVirtual")]
        static abstract int IsJoystickVirtualRaw(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsMouseHaptic")]
        static abstract MaybeBool<int> IsMouseHaptic();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsMouseHaptic")]
        static abstract int IsMouseHapticRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsTablet")]
        static abstract MaybeBool<int> IsTablet();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsTablet")]
        static abstract int IsTabletRaw();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_JoystickConnected")]
        static abstract MaybeBool<int> JoystickConnected(JoystickHandle joystick);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_JoystickConnected")]
        static abstract int JoystickConnectedRaw(JoystickHandle joystick);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_JoystickEventsEnabled")]
        static abstract MaybeBool<int> JoystickEventsEnabled();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_JoystickEventsEnabled")]
        static abstract int JoystickEventsEnabledRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP")]
        static abstract Surface* LoadBMP([NativeTypeName("const char *")] sbyte* file);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP")]
        static abstract Ptr<Surface> LoadBMP([NativeTypeName("const char *")] Ref<sbyte> file);

        [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP_IO")]
        static abstract Surface* LoadBMPIO(
            IOStreamHandle src,
            [NativeTypeName("SDL_bool")] int closeio
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP_IO")]
        static abstract Ptr<Surface> LoadBMPIO(
            IOStreamHandle src,
            [NativeTypeName("SDL_bool")] MaybeBool<int> closeio
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile")]
        static abstract void* LoadFile(
            [NativeTypeName("const char *")] sbyte* file,
            [NativeTypeName("size_t *")] nuint* datasize
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile")]
        static abstract Ptr LoadFile(
            [NativeTypeName("const char *")] Ref<sbyte> file,
            [NativeTypeName("size_t *")] Ref<nuint> datasize
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile_IO")]
        static abstract void* LoadFileIO(
            IOStreamHandle src,
            [NativeTypeName("size_t *")] nuint* datasize,
            [NativeTypeName("SDL_bool")] int closeio
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile_IO")]
        static abstract Ptr LoadFileIO(
            IOStreamHandle src,
            [NativeTypeName("size_t *")] Ref<nuint> datasize,
            [NativeTypeName("SDL_bool")] MaybeBool<int> closeio
        );

        [return: NativeTypeName("SDL_FunctionPointer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFunction")]
        static abstract delegate* unmanaged<void> LoadFunction(
            void* handle,
            [NativeTypeName("const char *")] sbyte* name
        );

        [return: NativeTypeName("SDL_FunctionPointer")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFunction")]
        static abstract delegate* unmanaged<void> LoadFunction(
            Ref handle,
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_LoadObject")]
        static abstract void* LoadObject([NativeTypeName("const char *")] sbyte* sofile);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadObject")]
        static abstract Ptr LoadObject([NativeTypeName("const char *")] Ref<sbyte> sofile);

        [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV")]
        static abstract int LoadWAV(
            [NativeTypeName("const char *")] sbyte* path,
            AudioSpec* spec,
            [NativeTypeName("Uint8 **")] byte** audio_buf,
            [NativeTypeName("Uint32 *")] uint* audio_len
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV")]
        static abstract int LoadWAV(
            [NativeTypeName("const char *")] Ref<sbyte> path,
            Ref<AudioSpec> spec,
            [NativeTypeName("Uint8 **")] Ref2D<byte> audio_buf,
            [NativeTypeName("Uint32 *")] Ref<uint> audio_len
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV_IO")]
        static abstract int LoadWAVIO(
            IOStreamHandle src,
            [NativeTypeName("SDL_bool")] int closeio,
            AudioSpec* spec,
            [NativeTypeName("Uint8 **")] byte** audio_buf,
            [NativeTypeName("Uint32 *")] uint* audio_len
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV_IO")]
        static abstract int LoadWAVIO(
            IOStreamHandle src,
            [NativeTypeName("SDL_bool")] MaybeBool<int> closeio,
            Ref<AudioSpec> spec,
            [NativeTypeName("Uint8 **")] Ref2D<byte> audio_buf,
            [NativeTypeName("Uint32 *")] Ref<uint> audio_len
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_LockAudioStream")]
        static abstract int LockAudioStream(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_LockJoysticks")]
        static abstract void LockJoysticks();

        [NativeFunction("SDL3", EntryPoint = "SDL_LockMutex")]
        static abstract void LockMutex(MutexHandle mutex);

        [NativeFunction("SDL3", EntryPoint = "SDL_LockProperties")]
        static abstract int LockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [NativeFunction("SDL3", EntryPoint = "SDL_LockRWLockForReading")]
        static abstract void LockRWLockForReading(RWLockHandle rwlock);

        [NativeFunction("SDL3", EntryPoint = "SDL_LockRWLockForWriting")]
        static abstract void LockRWLockForWriting(RWLockHandle rwlock);

        [NativeFunction("SDL3", EntryPoint = "SDL_LockSpinlock")]
        static abstract void LockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockSpinlock")]
        static abstract void LockSpinlock([NativeTypeName("SDL_SpinLock *")] Ref<int> @lock);

        [NativeFunction("SDL3", EntryPoint = "SDL_LockSurface")]
        static abstract int LockSurface(Surface* surface);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockSurface")]
        static abstract int LockSurface(Ref<Surface> surface);

        [NativeFunction("SDL3", EntryPoint = "SDL_LockTexture")]
        static abstract int LockTexture(
            TextureHandle texture,
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            void** pixels,
            int* pitch
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockTexture")]
        static abstract int LockTexture(
            TextureHandle texture,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            Ref2D pixels,
            Ref<int> pitch
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_LockTextureToSurface")]
        static abstract int LockTextureToSurface(
            TextureHandle texture,
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            Surface** surface
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockTextureToSurface")]
        static abstract int LockTextureToSurface(
            TextureHandle texture,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            Ref2D<Surface> surface
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_LogGetPriority")]
        static abstract LogPriority LogGetPriority(int category);

        [NativeFunction("SDL3", EntryPoint = "SDL_LogMessageV")]
        static abstract void LogMessageV(
            int category,
            LogPriority priority,
            [NativeTypeName("const char *")] sbyte* fmt,
            [NativeTypeName("va_list")] sbyte* ap
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LogMessageV")]
        static abstract void LogMessageV(
            int category,
            LogPriority priority,
            [NativeTypeName("const char *")] Ref<sbyte> fmt,
            [NativeTypeName("va_list")] Ref<sbyte> ap
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_LogResetPriorities")]
        static abstract void LogResetPriorities();

        [NativeFunction("SDL3", EntryPoint = "SDL_LogSetAllPriority")]
        static abstract void LogSetAllPriority(LogPriority priority);

        [NativeFunction("SDL3", EntryPoint = "SDL_LogSetPriority")]
        static abstract void LogSetPriority(int category, LogPriority priority);

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapRGB")]
        static abstract uint MapRGB(
            [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b
        );

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapRGB")]
        static abstract uint MapRGB(
            [NativeTypeName("const SDL_PixelFormat *")] Ref<PixelFormat> format,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b
        );

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapRGBA")]
        static abstract uint MapRgba(
            [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b,
            [NativeTypeName("Uint8")] byte a
        );

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapRGBA")]
        static abstract uint MapRgba(
            [NativeTypeName("const SDL_PixelFormat *")] Ref<PixelFormat> format,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b,
            [NativeTypeName("Uint8")] byte a
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_MaximizeWindow")]
        static abstract int MaximizeWindow(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_MemoryBarrierAcquireFunction")]
        static abstract void MemoryBarrierAcquireFunction();

        [NativeFunction("SDL3", EntryPoint = "SDL_MemoryBarrierReleaseFunction")]
        static abstract void MemoryBarrierReleaseFunction();

        [return: NativeTypeName("SDL_MetalView")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_Metal_CreateView")]
        static abstract Ptr MetalCreateView(WindowHandle window);

        [return: NativeTypeName("SDL_MetalView")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Metal_CreateView")]
        static abstract void* MetalCreateViewRaw(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_Metal_DestroyView")]
        static abstract void MetalDestroyView([NativeTypeName("SDL_MetalView")] void* view);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_Metal_DestroyView")]
        static abstract void MetalDestroyView([NativeTypeName("SDL_MetalView")] Ref view);

        [NativeFunction("SDL3", EntryPoint = "SDL_Metal_GetLayer")]
        static abstract void* MetalGetLayer([NativeTypeName("SDL_MetalView")] void* view);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_Metal_GetLayer")]
        static abstract Ptr MetalGetLayer([NativeTypeName("SDL_MetalView")] Ref view);

        [NativeFunction("SDL3", EntryPoint = "SDL_MinimizeWindow")]
        static abstract int MinimizeWindow(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_MixAudioFormat")]
        static abstract int MixAudioFormat(
            [NativeTypeName("Uint8 *")] byte* dst,
            [NativeTypeName("const Uint8 *")] byte* src,
            [NativeTypeName("SDL_AudioFormat")] ushort format,
            [NativeTypeName("Uint32")] uint len,
            int volume
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_MixAudioFormat")]
        static abstract int MixAudioFormat(
            [NativeTypeName("Uint8 *")] Ref<byte> dst,
            [NativeTypeName("const Uint8 *")] Ref<byte> src,
            [NativeTypeName("SDL_AudioFormat")] ushort format,
            [NativeTypeName("Uint32")] uint len,
            int volume
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidBecomeActive")]
        static abstract void OnApplicationDidBecomeActive();

        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidEnterBackground")]
        static abstract void OnApplicationDidEnterBackground();

        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning")]
        static abstract void OnApplicationDidReceiveMemoryWarning();

        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillEnterForeground")]
        static abstract void OnApplicationWillEnterForeground();

        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillResignActive")]
        static abstract void OnApplicationWillResignActive();

        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillTerminate")]
        static abstract void OnApplicationWillTerminate();

        [return: NativeTypeName("SDL_AudioDeviceID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDevice")]
        static abstract uint OpenAudioDevice(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* spec
        );

        [return: NativeTypeName("SDL_AudioDeviceID")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDevice")]
        static abstract uint OpenAudioDevice(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> spec
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDeviceStream")]
        static abstract AudioStreamHandle OpenAudioDeviceStream(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* spec,
            [NativeTypeName("SDL_AudioStreamCallback")]
                delegate* unmanaged<void*, AudioStreamHandle, int, int, void> callback,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDeviceStream")]
        static abstract AudioStreamHandle OpenAudioDeviceStream(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> spec,
            [NativeTypeName("SDL_AudioStreamCallback")]
                delegate* unmanaged<void*, AudioStreamHandle, int, int, void> callback,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenCameraDevice")]
        static abstract CameraHandle OpenCameraDevice(
            [NativeTypeName("SDL_CameraDeviceID")] uint instance_id,
            [NativeTypeName("const SDL_CameraSpec *")] CameraSpec* spec
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenCameraDevice")]
        static abstract CameraHandle OpenCameraDevice(
            [NativeTypeName("SDL_CameraDeviceID")] uint instance_id,
            [NativeTypeName("const SDL_CameraSpec *")] Ref<CameraSpec> spec
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenFileStorage")]
        static abstract StorageHandle OpenFileStorage([NativeTypeName("const char *")] sbyte* path);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenFileStorage")]
        static abstract StorageHandle OpenFileStorage(
            [NativeTypeName("const char *")] Ref<sbyte> path
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenGamepad")]
        static abstract GamepadHandle OpenGamepad(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenHaptic")]
        static abstract HapticHandle OpenHaptic([NativeTypeName("SDL_HapticID")] uint instance_id);

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenHapticFromJoystick")]
        static abstract HapticHandle OpenHapticFromJoystick(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenHapticFromMouse")]
        static abstract HapticHandle OpenHapticFromMouse();

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenIO")]
        static abstract IOStreamHandle OpenIO(
            [NativeTypeName("const SDL_IOStreamInterface *")] IOStreamInterface* iface,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenIO")]
        static abstract IOStreamHandle OpenIO(
            [NativeTypeName("const SDL_IOStreamInterface *")] Ref<IOStreamInterface> iface,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenJoystick")]
        static abstract JoystickHandle OpenJoystick(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenSensor")]
        static abstract SensorHandle OpenSensor([NativeTypeName("SDL_SensorID")] uint instance_id);

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenStorage")]
        static abstract StorageHandle OpenStorage(
            [NativeTypeName("const SDL_StorageInterface *")] StorageInterface* iface,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenStorage")]
        static abstract StorageHandle OpenStorage(
            [NativeTypeName("const SDL_StorageInterface *")] Ref<StorageInterface> iface,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenTitleStorage")]
        static abstract StorageHandle OpenTitleStorage(
            [NativeTypeName("const char *")] sbyte* @override,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenTitleStorage")]
        static abstract StorageHandle OpenTitleStorage(
            [NativeTypeName("const char *")] Ref<sbyte> @override,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenURL")]
        static abstract int OpenURL([NativeTypeName("const char *")] sbyte* url);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenURL")]
        static abstract int OpenURL([NativeTypeName("const char *")] Ref<sbyte> url);

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenUserStorage")]
        static abstract StorageHandle OpenUserStorage(
            [NativeTypeName("const char *")] sbyte* org,
            [NativeTypeName("const char *")] sbyte* app,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenUserStorage")]
        static abstract StorageHandle OpenUserStorage(
            [NativeTypeName("const char *")] Ref<sbyte> org,
            [NativeTypeName("const char *")] Ref<sbyte> app,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioDevice")]
        static abstract int PauseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev);

        [NativeFunction("SDL3", EntryPoint = "SDL_PauseHaptic")]
        static abstract int PauseHaptic(HapticHandle haptic);

        [NativeFunction("SDL3", EntryPoint = "SDL_PeepEvents")]
        static abstract int PeepEvents(
            Event* events,
            int numevents,
            EventAction action,
            [NativeTypeName("Uint32")] uint minType,
            [NativeTypeName("Uint32")] uint maxType
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PeepEvents")]
        static abstract int PeepEvents(
            Ref<Event> events,
            int numevents,
            EventAction action,
            [NativeTypeName("Uint32")] uint minType,
            [NativeTypeName("Uint32")] uint maxType
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PenConnected")]
        static abstract MaybeBool<int> PenConnected([NativeTypeName("SDL_PenID")] uint instance_id);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PenConnected")]
        static abstract int PenConnectedRaw([NativeTypeName("SDL_PenID")] uint instance_id);

        [NativeFunction("SDL3", EntryPoint = "SDL_PlayHapticRumble")]
        static abstract int PlayHapticRumble(
            HapticHandle haptic,
            float strength,
            [NativeTypeName("Uint32")] uint length
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PollEvent")]
        static abstract int PollEvent(Event* @event);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PollEvent")]
        static abstract MaybeBool<int> PollEvent(Ref<Event> @event);

        [NativeFunction("SDL3", EntryPoint = "SDL_PostSemaphore")]
        static abstract int PostSemaphore(SemaphoreHandle sem);

        [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplyAlpha")]
        static abstract int PremultiplyAlpha(
            int width,
            int height,
            PixelFormatEnum src_format,
            [NativeTypeName("const void *")] void* src,
            int src_pitch,
            PixelFormatEnum dst_format,
            void* dst,
            int dst_pitch
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplyAlpha")]
        static abstract int PremultiplyAlpha(
            int width,
            int height,
            PixelFormatEnum src_format,
            [NativeTypeName("const void *")] Ref src,
            int src_pitch,
            PixelFormatEnum dst_format,
            Ref dst,
            int dst_pitch
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_PumpEvents")]
        static abstract void PumpEvents();

        [NativeFunction("SDL3", EntryPoint = "SDL_PushEvent")]
        static abstract int PushEvent(Event* @event);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushEvent")]
        static abstract int PushEvent(Ref<Event> @event);

        [NativeFunction("SDL3", EntryPoint = "SDL_PutAudioStreamData")]
        static abstract int PutAudioStreamData(
            AudioStreamHandle stream,
            [NativeTypeName("const void *")] void* buf,
            int len
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PutAudioStreamData")]
        static abstract int PutAudioStreamData(
            AudioStreamHandle stream,
            [NativeTypeName("const void *")] Ref buf,
            int len
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_QueryTexture")]
        static abstract int QueryTexture(
            TextureHandle texture,
            PixelFormatEnum* format,
            int* access,
            int* w,
            int* h
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_QueryTexture")]
        static abstract int QueryTexture(
            TextureHandle texture,
            Ref<PixelFormatEnum> format,
            Ref<int> access,
            Ref<int> w,
            Ref<int> h
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_Quit")]
        static abstract void Quit();

        [NativeFunction("SDL3", EntryPoint = "SDL_QuitSubSystem")]
        static abstract void QuitSubSystem([NativeTypeName("Uint32")] uint flags);

        [NativeFunction("SDL3", EntryPoint = "SDL_RaiseWindow")]
        static abstract int RaiseWindow(WindowHandle window);

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadIO")]
        static abstract nuint ReadIO(
            IOStreamHandle context,
            void* ptr,
            [NativeTypeName("size_t")] nuint size
        );

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadIO")]
        static abstract nuint ReadIO(
            IOStreamHandle context,
            Ref ptr,
            [NativeTypeName("size_t")] nuint size
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16BE")]
        static abstract int ReadS16BE(
            IOStreamHandle src,
            [NativeTypeName("Sint16 *")] short* value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16BE")]
        static abstract MaybeBool<int> ReadS16BE(
            IOStreamHandle src,
            [NativeTypeName("Sint16 *")] Ref<short> value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16LE")]
        static abstract int ReadS16LE(
            IOStreamHandle src,
            [NativeTypeName("Sint16 *")] short* value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16LE")]
        static abstract MaybeBool<int> ReadS16LE(
            IOStreamHandle src,
            [NativeTypeName("Sint16 *")] Ref<short> value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32BE")]
        static abstract int ReadS32BE(IOStreamHandle src, [NativeTypeName("Sint32 *")] int* value);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32BE")]
        static abstract MaybeBool<int> ReadS32BE(
            IOStreamHandle src,
            [NativeTypeName("Sint32 *")] Ref<int> value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32LE")]
        static abstract int ReadS32LE(IOStreamHandle src, [NativeTypeName("Sint32 *")] int* value);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32LE")]
        static abstract MaybeBool<int> ReadS32LE(
            IOStreamHandle src,
            [NativeTypeName("Sint32 *")] Ref<int> value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64BE")]
        static abstract int ReadS64BE(IOStreamHandle src, [NativeTypeName("Sint64 *")] long* value);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64BE")]
        static abstract MaybeBool<int> ReadS64BE(
            IOStreamHandle src,
            [NativeTypeName("Sint64 *")] Ref<long> value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64LE")]
        static abstract int ReadS64LE(IOStreamHandle src, [NativeTypeName("Sint64 *")] long* value);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64LE")]
        static abstract MaybeBool<int> ReadS64LE(
            IOStreamHandle src,
            [NativeTypeName("Sint64 *")] Ref<long> value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ReadStorageFile")]
        static abstract int ReadStorageFile(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path,
            void* destination,
            [NativeTypeName("Uint64")] ulong length
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadStorageFile")]
        static abstract int ReadStorageFile(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path,
            Ref destination,
            [NativeTypeName("Uint64")] ulong length
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixel")]
        static abstract int ReadSurfacePixel(
            Surface* surface,
            int x,
            int y,
            [NativeTypeName("Uint8 *")] byte* r,
            [NativeTypeName("Uint8 *")] byte* g,
            [NativeTypeName("Uint8 *")] byte* b,
            [NativeTypeName("Uint8 *")] byte* a
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixel")]
        static abstract int ReadSurfacePixel(
            Ref<Surface> surface,
            int x,
            int y,
            [NativeTypeName("Uint8 *")] Ref<byte> r,
            [NativeTypeName("Uint8 *")] Ref<byte> g,
            [NativeTypeName("Uint8 *")] Ref<byte> b,
            [NativeTypeName("Uint8 *")] Ref<byte> a
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16BE")]
        static abstract int ReadU16BE(
            IOStreamHandle src,
            [NativeTypeName("Uint16 *")] ushort* value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16BE")]
        static abstract MaybeBool<int> ReadU16BE(
            IOStreamHandle src,
            [NativeTypeName("Uint16 *")] Ref<ushort> value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16LE")]
        static abstract int ReadU16LE(
            IOStreamHandle src,
            [NativeTypeName("Uint16 *")] ushort* value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16LE")]
        static abstract MaybeBool<int> ReadU16LE(
            IOStreamHandle src,
            [NativeTypeName("Uint16 *")] Ref<ushort> value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32BE")]
        static abstract int ReadU32BE(IOStreamHandle src, [NativeTypeName("Uint32 *")] uint* value);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32BE")]
        static abstract MaybeBool<int> ReadU32BE(
            IOStreamHandle src,
            [NativeTypeName("Uint32 *")] Ref<uint> value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32LE")]
        static abstract int ReadU32LE(IOStreamHandle src, [NativeTypeName("Uint32 *")] uint* value);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32LE")]
        static abstract MaybeBool<int> ReadU32LE(
            IOStreamHandle src,
            [NativeTypeName("Uint32 *")] Ref<uint> value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64BE")]
        static abstract int ReadU64BE(
            IOStreamHandle src,
            [NativeTypeName("Uint64 *")] ulong* value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64BE")]
        static abstract MaybeBool<int> ReadU64BE(
            IOStreamHandle src,
            [NativeTypeName("Uint64 *")] Ref<ulong> value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64LE")]
        static abstract int ReadU64LE(
            IOStreamHandle src,
            [NativeTypeName("Uint64 *")] ulong* value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64LE")]
        static abstract MaybeBool<int> ReadU64LE(
            IOStreamHandle src,
            [NativeTypeName("Uint64 *")] Ref<ulong> value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU8")]
        static abstract int ReadU8(IOStreamHandle src, [NativeTypeName("Uint8 *")] byte* value);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU8")]
        static abstract MaybeBool<int> ReadU8(
            IOStreamHandle src,
            [NativeTypeName("Uint8 *")] Ref<byte> value
        );

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RegisterEvents")]
        static abstract uint RegisterEvents(int numevents);

        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseCameraFrame")]
        static abstract int ReleaseCameraFrame(CameraHandle camera, Surface* frame);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseCameraFrame")]
        static abstract int ReleaseCameraFrame(CameraHandle camera, Ref<Surface> frame);

        [NativeFunction("SDL3", EntryPoint = "SDL_ReloadGamepadMappings")]
        static abstract int ReloadGamepadMappings();

        [NativeFunction("SDL3", EntryPoint = "SDL_RemovePath")]
        static abstract int RemovePath([NativeTypeName("const char *")] sbyte* path);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemovePath")]
        static abstract int RemovePath([NativeTypeName("const char *")] Ref<sbyte> path);

        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveStoragePath")]
        static abstract int RemoveStoragePath(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveStoragePath")]
        static abstract int RemoveStoragePath(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveTimer")]
        static abstract MaybeBool<int> RemoveTimer([NativeTypeName("SDL_TimerID")] uint id);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveTimer")]
        static abstract int RemoveTimerRaw([NativeTypeName("SDL_TimerID")] uint id);

        [NativeFunction("SDL3", EntryPoint = "SDL_RenamePath")]
        static abstract int RenamePath(
            [NativeTypeName("const char *")] sbyte* oldpath,
            [NativeTypeName("const char *")] sbyte* newpath
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenamePath")]
        static abstract int RenamePath(
            [NativeTypeName("const char *")] Ref<sbyte> oldpath,
            [NativeTypeName("const char *")] Ref<sbyte> newpath
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenameStoragePath")]
        static abstract int RenameStoragePath(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* oldpath,
            [NativeTypeName("const char *")] sbyte* newpath
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenameStoragePath")]
        static abstract int RenameStoragePath(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> oldpath,
            [NativeTypeName("const char *")] Ref<sbyte> newpath
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderClear")]
        static abstract int RenderClear(RendererHandle renderer);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderClipEnabled")]
        static abstract MaybeBool<int> RenderClipEnabled(RendererHandle renderer);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderClipEnabled")]
        static abstract int RenderClipEnabledRaw(RendererHandle renderer);

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesFromWindow")]
        static abstract int RenderCoordinatesFromWindow(
            RendererHandle renderer,
            float window_x,
            float window_y,
            float* x,
            float* y
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesFromWindow")]
        static abstract int RenderCoordinatesFromWindow(
            RendererHandle renderer,
            float window_x,
            float window_y,
            Ref<float> x,
            Ref<float> y
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesToWindow")]
        static abstract int RenderCoordinatesToWindow(
            RendererHandle renderer,
            float x,
            float y,
            float* window_x,
            float* window_y
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesToWindow")]
        static abstract int RenderCoordinatesToWindow(
            RendererHandle renderer,
            float x,
            float y,
            Ref<float> window_x,
            Ref<float> window_y
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRect")]
        static abstract int RenderFillRect(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] FRect* rect
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRect")]
        static abstract int RenderFillRect(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> rect
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRects")]
        static abstract int RenderFillRects(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] FRect* rects,
            int count
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRects")]
        static abstract int RenderFillRects(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> rects,
            int count
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometry")]
        static abstract int RenderGeometry(
            RendererHandle renderer,
            TextureHandle texture,
            [NativeTypeName("const SDL_Vertex *")] Vertex* vertices,
            int num_vertices,
            [NativeTypeName("const int *")] int* indices,
            int num_indices
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometry")]
        static abstract int RenderGeometry(
            RendererHandle renderer,
            TextureHandle texture,
            [NativeTypeName("const SDL_Vertex *")] Ref<Vertex> vertices,
            int num_vertices,
            [NativeTypeName("const int *")] Ref<int> indices,
            int num_indices
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRaw")]
        static abstract int RenderGeometryRaw(
            RendererHandle renderer,
            TextureHandle texture,
            [NativeTypeName("const float *")] float* xy,
            int xy_stride,
            [NativeTypeName("const SDL_Color *")] Color* color,
            int color_stride,
            [NativeTypeName("const float *")] float* uv,
            int uv_stride,
            int num_vertices,
            [NativeTypeName("const void *")] void* indices,
            int num_indices,
            int size_indices
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRaw")]
        static abstract int RenderGeometryRaw(
            RendererHandle renderer,
            TextureHandle texture,
            [NativeTypeName("const float *")] Ref<float> xy,
            int xy_stride,
            [NativeTypeName("const SDL_Color *")] Ref<Color> color,
            int color_stride,
            [NativeTypeName("const float *")] Ref<float> uv,
            int uv_stride,
            int num_vertices,
            [NativeTypeName("const void *")] Ref indices,
            int num_indices,
            int size_indices
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRawFloat")]
        static abstract int RenderGeometryRawFloat(
            RendererHandle renderer,
            TextureHandle texture,
            [NativeTypeName("const float *")] float* xy,
            int xy_stride,
            [NativeTypeName("const SDL_FColor *")] FColor* color,
            int color_stride,
            [NativeTypeName("const float *")] float* uv,
            int uv_stride,
            int num_vertices,
            [NativeTypeName("const void *")] void* indices,
            int num_indices,
            int size_indices
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRawFloat")]
        static abstract int RenderGeometryRawFloat(
            RendererHandle renderer,
            TextureHandle texture,
            [NativeTypeName("const float *")] Ref<float> xy,
            int xy_stride,
            [NativeTypeName("const SDL_FColor *")] Ref<FColor> color,
            int color_stride,
            [NativeTypeName("const float *")] Ref<float> uv,
            int uv_stride,
            int num_vertices,
            [NativeTypeName("const void *")] Ref indices,
            int num_indices,
            int size_indices
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderLine")]
        static abstract int RenderLine(
            RendererHandle renderer,
            float x1,
            float y1,
            float x2,
            float y2
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderLines")]
        static abstract int RenderLines(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FPoint *")] FPoint* points,
            int count
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderLines")]
        static abstract int RenderLines(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> points,
            int count
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoint")]
        static abstract int RenderPoint(RendererHandle renderer, float x, float y);

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoints")]
        static abstract int RenderPoints(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FPoint *")] FPoint* points,
            int count
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoints")]
        static abstract int RenderPoints(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> points,
            int count
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPresent")]
        static abstract int RenderPresent(RendererHandle renderer);

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderReadPixels")]
        static abstract Surface* RenderReadPixels(
            RendererHandle renderer,
            [NativeTypeName("const SDL_Rect *")] Rect* rect
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderReadPixels")]
        static abstract Ptr<Surface> RenderReadPixels(
            RendererHandle renderer,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderRect")]
        static abstract int RenderRect(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] FRect* rect
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderRect")]
        static abstract int RenderRect(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> rect
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderRects")]
        static abstract int RenderRects(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] FRect* rects,
            int count
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderRects")]
        static abstract int RenderRects(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> rects,
            int count
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture")]
        static abstract int RenderTexture(
            RendererHandle renderer,
            TextureHandle texture,
            [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
            [NativeTypeName("const SDL_FRect *")] FRect* dstrect
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture")]
        static abstract int RenderTexture(
            RendererHandle renderer,
            TextureHandle texture,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> srcrect,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> dstrect
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureRotated")]
        static abstract int RenderTextureRotated(
            RendererHandle renderer,
            TextureHandle texture,
            [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
            [NativeTypeName("const SDL_FRect *")] FRect* dstrect,
            [NativeTypeName("const double")] double angle,
            [NativeTypeName("const SDL_FPoint *")] FPoint* center,
            [NativeTypeName("const SDL_FlipMode")] FlipMode flip
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureRotated")]
        static abstract int RenderTextureRotated(
            RendererHandle renderer,
            TextureHandle texture,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> srcrect,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> dstrect,
            [NativeTypeName("const double")] double angle,
            [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> center,
            [NativeTypeName("const SDL_FlipMode")] FlipMode flip
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderViewportSet")]
        static abstract MaybeBool<int> RenderViewportSet(RendererHandle renderer);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderViewportSet")]
        static abstract int RenderViewportSetRaw(RendererHandle renderer);

        [NativeFunction("SDL3", EntryPoint = "SDL_ReportAssertion")]
        static abstract AssertState ReportAssertion(
            AssertData* data,
            [NativeTypeName("const char *")] sbyte* func,
            [NativeTypeName("const char *")] sbyte* file,
            int line
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReportAssertion")]
        static abstract AssertState ReportAssertion(
            Ref<AssertData> data,
            [NativeTypeName("const char *")] Ref<sbyte> func,
            [NativeTypeName("const char *")] Ref<sbyte> file,
            int line
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ResetAssertionReport")]
        static abstract void ResetAssertionReport();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResetHint")]
        static abstract int ResetHint([NativeTypeName("const char *")] sbyte* name);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResetHint")]
        static abstract MaybeBool<int> ResetHint([NativeTypeName("const char *")] Ref<sbyte> name);

        [NativeFunction("SDL3", EntryPoint = "SDL_ResetHints")]
        static abstract void ResetHints();

        [NativeFunction("SDL3", EntryPoint = "SDL_ResetKeyboard")]
        static abstract void ResetKeyboard();

        [NativeFunction("SDL3", EntryPoint = "SDL_RestoreWindow")]
        static abstract int RestoreWindow(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioDevice")]
        static abstract int ResumeAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev);

        [NativeFunction("SDL3", EntryPoint = "SDL_ResumeHaptic")]
        static abstract int ResumeHaptic(HapticHandle haptic);

        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepad")]
        static abstract int RumbleGamepad(
            GamepadHandle gamepad,
            [NativeTypeName("Uint16")] ushort low_frequency_rumble,
            [NativeTypeName("Uint16")] ushort high_frequency_rumble,
            [NativeTypeName("Uint32")] uint duration_ms
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepadTriggers")]
        static abstract int RumbleGamepadTriggers(
            GamepadHandle gamepad,
            [NativeTypeName("Uint16")] ushort left_rumble,
            [NativeTypeName("Uint16")] ushort right_rumble,
            [NativeTypeName("Uint32")] uint duration_ms
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystick")]
        static abstract int RumbleJoystick(
            JoystickHandle joystick,
            [NativeTypeName("Uint16")] ushort low_frequency_rumble,
            [NativeTypeName("Uint16")] ushort high_frequency_rumble,
            [NativeTypeName("Uint32")] uint duration_ms
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystickTriggers")]
        static abstract int RumbleJoystickTriggers(
            JoystickHandle joystick,
            [NativeTypeName("Uint16")] ushort left_rumble,
            [NativeTypeName("Uint16")] ushort right_rumble,
            [NativeTypeName("Uint32")] uint duration_ms
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RunHapticEffect")]
        static abstract int RunHapticEffect(
            HapticHandle haptic,
            int effect,
            [NativeTypeName("Uint32")] uint iterations
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP")]
        static abstract int SaveBMP(Surface* surface, [NativeTypeName("const char *")] sbyte* file);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP")]
        static abstract int SaveBMP(
            Ref<Surface> surface,
            [NativeTypeName("const char *")] Ref<sbyte> file
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP_IO")]
        static abstract int SaveBMPIO(
            Surface* surface,
            IOStreamHandle dst,
            [NativeTypeName("SDL_bool")] int closeio
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP_IO")]
        static abstract int SaveBMPIO(
            Ref<Surface> surface,
            IOStreamHandle dst,
            [NativeTypeName("SDL_bool")] MaybeBool<int> closeio
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScreenKeyboardShown")]
        static abstract MaybeBool<int> ScreenKeyboardShown(WindowHandle window);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScreenKeyboardShown")]
        static abstract int ScreenKeyboardShownRaw(WindowHandle window);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScreenSaverEnabled")]
        static abstract MaybeBool<int> ScreenSaverEnabled();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScreenSaverEnabled")]
        static abstract int ScreenSaverEnabledRaw();

        [return: NativeTypeName("Sint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SeekIO")]
        static abstract long SeekIO(
            IOStreamHandle context,
            [NativeTypeName("Sint64")] long offset,
            int whence
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SendGamepadEffect")]
        static abstract int SendGamepadEffect(
            GamepadHandle gamepad,
            [NativeTypeName("const void *")] void* data,
            int size
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SendGamepadEffect")]
        static abstract int SendGamepadEffect(
            GamepadHandle gamepad,
            [NativeTypeName("const void *")] Ref data,
            int size
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickEffect")]
        static abstract int SendJoystickEffect(
            JoystickHandle joystick,
            [NativeTypeName("const void *")] void* data,
            int size
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickEffect")]
        static abstract int SendJoystickEffect(
            JoystickHandle joystick,
            [NativeTypeName("const void *")] Ref data,
            int size
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetAssertionHandler")]
        static abstract void SetAssertionHandler(
            [NativeTypeName("SDL_AssertionHandler")]
                delegate* unmanaged<AssertData*, void*, AssertState> handler,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAssertionHandler")]
        static abstract void SetAssertionHandler(
            [NativeTypeName("SDL_AssertionHandler")]
                delegate* unmanaged<AssertData*, void*, AssertState> handler,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioPostmixCallback")]
        static abstract int SetAudioPostmixCallback(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            [NativeTypeName("SDL_AudioPostmixCallback")]
                delegate* unmanaged<void*, AudioSpec*, float*, int, void> callback,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioPostmixCallback")]
        static abstract int SetAudioPostmixCallback(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            [NativeTypeName("SDL_AudioPostmixCallback")]
                delegate* unmanaged<void*, AudioSpec*, float*, int, void> callback,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFormat")]
        static abstract int SetAudioStreamFormat(
            AudioStreamHandle stream,
            [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* src_spec,
            [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* dst_spec
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFormat")]
        static abstract int SetAudioStreamFormat(
            AudioStreamHandle stream,
            [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> src_spec,
            [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> dst_spec
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFrequencyRatio")]
        static abstract int SetAudioStreamFrequencyRatio(AudioStreamHandle stream, float ratio);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGetCallback")]
        static abstract int SetAudioStreamGetCallback(
            AudioStreamHandle stream,
            [NativeTypeName("SDL_AudioStreamCallback")]
                delegate* unmanaged<void*, AudioStreamHandle, int, int, void> callback,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGetCallback")]
        static abstract int SetAudioStreamGetCallback(
            AudioStreamHandle stream,
            [NativeTypeName("SDL_AudioStreamCallback")]
                delegate* unmanaged<void*, AudioStreamHandle, int, int, void> callback,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamPutCallback")]
        static abstract int SetAudioStreamPutCallback(
            AudioStreamHandle stream,
            [NativeTypeName("SDL_AudioStreamCallback")]
                delegate* unmanaged<void*, AudioStreamHandle, int, int, void> callback,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamPutCallback")]
        static abstract int SetAudioStreamPutCallback(
            AudioStreamHandle stream,
            [NativeTypeName("SDL_AudioStreamCallback")]
                delegate* unmanaged<void*, AudioStreamHandle, int, int, void> callback,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetBooleanProperty")]
        static abstract int SetBooleanProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("SDL_bool")] int value
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetBooleanProperty")]
        static abstract int SetBooleanProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("SDL_bool")] MaybeBool<int> value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardData")]
        static abstract int SetClipboardData(
            [NativeTypeName("SDL_ClipboardDataCallback")]
                delegate* unmanaged<void*, sbyte*, nuint*, void*> callback,
            [NativeTypeName("SDL_ClipboardCleanupCallback")]
                delegate* unmanaged<void*, void> cleanup,
            void* userdata,
            [NativeTypeName("const char **")] sbyte** mime_types,
            [NativeTypeName("size_t")] nuint num_mime_types
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardData")]
        static abstract int SetClipboardData(
            [NativeTypeName("SDL_ClipboardDataCallback")]
                delegate* unmanaged<void*, sbyte*, nuint*, void*> callback,
            [NativeTypeName("SDL_ClipboardCleanupCallback")]
                delegate* unmanaged<void*, void> cleanup,
            Ref userdata,
            [NativeTypeName("const char **")] Ref2D<sbyte> mime_types,
            [NativeTypeName("size_t")] nuint num_mime_types
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardText")]
        static abstract int SetClipboardText([NativeTypeName("const char *")] sbyte* text);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardText")]
        static abstract int SetClipboardText([NativeTypeName("const char *")] Ref<sbyte> text);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetCursor")]
        static abstract int SetCursor(CursorHandle cursor);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetEventEnabled")]
        static abstract void SetEventEnabled(
            [NativeTypeName("Uint32")] uint type,
            [NativeTypeName("SDL_bool")] int enabled
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetEventEnabled")]
        static abstract void SetEventEnabled(
            [NativeTypeName("Uint32")] uint type,
            [NativeTypeName("SDL_bool")] MaybeBool<int> enabled
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetEventFilter")]
        static abstract void SetEventFilter(
            [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetEventFilter")]
        static abstract void SetEventFilter(
            [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetFloatProperty")]
        static abstract int SetFloatProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            float value
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetFloatProperty")]
        static abstract int SetFloatProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            float value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadEventsEnabled")]
        static abstract void SetGamepadEventsEnabled([NativeTypeName("SDL_bool")] int enabled);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadEventsEnabled")]
        static abstract void SetGamepadEventsEnabled(
            [NativeTypeName("SDL_bool")] MaybeBool<int> enabled
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadLED")]
        static abstract int SetGamepadLED(
            GamepadHandle gamepad,
            [NativeTypeName("Uint8")] byte red,
            [NativeTypeName("Uint8")] byte green,
            [NativeTypeName("Uint8")] byte blue
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadMapping")]
        static abstract int SetGamepadMapping(
            [NativeTypeName("SDL_JoystickID")] uint instance_id,
            [NativeTypeName("const char *")] sbyte* mapping
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadMapping")]
        static abstract int SetGamepadMapping(
            [NativeTypeName("SDL_JoystickID")] uint instance_id,
            [NativeTypeName("const char *")] Ref<sbyte> mapping
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadPlayerIndex")]
        static abstract int SetGamepadPlayerIndex(GamepadHandle gamepad, int player_index);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadSensorEnabled")]
        static abstract int SetGamepadSensorEnabled(
            GamepadHandle gamepad,
            SensorType type,
            [NativeTypeName("SDL_bool")] int enabled
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadSensorEnabled")]
        static abstract int SetGamepadSensorEnabled(
            GamepadHandle gamepad,
            SensorType type,
            [NativeTypeName("SDL_bool")] MaybeBool<int> enabled
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticAutocenter")]
        static abstract int SetHapticAutocenter(HapticHandle haptic, int autocenter);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticGain")]
        static abstract int SetHapticGain(HapticHandle haptic, int gain);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHint")]
        static abstract int SetHint(
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("const char *")] sbyte* value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHint")]
        static abstract MaybeBool<int> SetHint(
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("const char *")] Ref<sbyte> value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHintWithPriority")]
        static abstract int SetHintWithPriority(
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("const char *")] sbyte* value,
            HintPriority priority
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHintWithPriority")]
        static abstract MaybeBool<int> SetHintWithPriority(
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("const char *")] Ref<sbyte> value,
            HintPriority priority
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickEventsEnabled")]
        static abstract void SetJoystickEventsEnabled([NativeTypeName("SDL_bool")] int enabled);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickEventsEnabled")]
        static abstract void SetJoystickEventsEnabled(
            [NativeTypeName("SDL_bool")] MaybeBool<int> enabled
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickLED")]
        static abstract int SetJoystickLED(
            JoystickHandle joystick,
            [NativeTypeName("Uint8")] byte red,
            [NativeTypeName("Uint8")] byte green,
            [NativeTypeName("Uint8")] byte blue
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickPlayerIndex")]
        static abstract int SetJoystickPlayerIndex(JoystickHandle joystick, int player_index);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualAxis")]
        static abstract int SetJoystickVirtualAxis(
            JoystickHandle joystick,
            int axis,
            [NativeTypeName("Sint16")] short value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualButton")]
        static abstract int SetJoystickVirtualButton(
            JoystickHandle joystick,
            int button,
            [NativeTypeName("Uint8")] byte value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualHat")]
        static abstract int SetJoystickVirtualHat(
            JoystickHandle joystick,
            int hat,
            [NativeTypeName("Uint8")] byte value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetLogOutputFunction")]
        static abstract void SetLogOutputFunction(
            [NativeTypeName("SDL_LogOutputFunction")]
                delegate* unmanaged<void*, int, LogPriority, sbyte*, void> callback,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetLogOutputFunction")]
        static abstract void SetLogOutputFunction(
            [NativeTypeName("SDL_LogOutputFunction")]
                delegate* unmanaged<void*, int, LogPriority, sbyte*, void> callback,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetModState")]
        static abstract void SetModState(Keymod modstate);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetNumberProperty")]
        static abstract int SetNumberProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("Sint64")] long value
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetNumberProperty")]
        static abstract int SetNumberProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("Sint64")] long value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetPaletteColors")]
        static abstract int SetPaletteColors(
            Palette* palette,
            [NativeTypeName("const SDL_Color *")] Color* colors,
            int firstcolor,
            int ncolors
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPaletteColors")]
        static abstract int SetPaletteColors(
            Ref<Palette> palette,
            [NativeTypeName("const SDL_Color *")] Ref<Color> colors,
            int firstcolor,
            int ncolors
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetPixelFormatPalette")]
        static abstract int SetPixelFormatPalette(PixelFormat* format, Palette* palette);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPixelFormatPalette")]
        static abstract int SetPixelFormatPalette(Ref<PixelFormat> format, Ref<Palette> palette);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetPrimarySelectionText")]
        static abstract int SetPrimarySelectionText([NativeTypeName("const char *")] sbyte* text);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPrimarySelectionText")]
        static abstract int SetPrimarySelectionText(
            [NativeTypeName("const char *")] Ref<sbyte> text
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetProperty")]
        static abstract int SetProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            void* value
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetProperty")]
        static abstract int SetProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            Ref value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetPropertyWithCleanup")]
        static abstract int SetPropertyWithCleanup(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            void* value,
            [NativeTypeName("void (*)(void *, void *)")]
                delegate* unmanaged<void*, void*, void> cleanup,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPropertyWithCleanup")]
        static abstract int SetPropertyWithCleanup(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            Ref value,
            [NativeTypeName("void (*)(void *, void *)")]
                delegate* unmanaged<void*, void*, void> cleanup,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetRelativeMouseMode")]
        static abstract int SetRelativeMouseMode([NativeTypeName("SDL_bool")] int enabled);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRelativeMouseMode")]
        static abstract int SetRelativeMouseMode(
            [NativeTypeName("SDL_bool")] MaybeBool<int> enabled
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderClipRect")]
        static abstract int SetRenderClipRect(
            RendererHandle renderer,
            [NativeTypeName("const SDL_Rect *")] Rect* rect
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderClipRect")]
        static abstract int SetRenderClipRect(
            RendererHandle renderer,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderColorScale")]
        static abstract int SetRenderColorScale(RendererHandle renderer, float scale);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawBlendMode")]
        static abstract int SetRenderDrawBlendMode(RendererHandle renderer, BlendMode blendMode);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColor")]
        static abstract int SetRenderDrawColor(
            RendererHandle renderer,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b,
            [NativeTypeName("Uint8")] byte a
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColorFloat")]
        static abstract int SetRenderDrawColorFloat(
            RendererHandle renderer,
            float r,
            float g,
            float b,
            float a
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderLogicalPresentation")]
        static abstract int SetRenderLogicalPresentation(
            RendererHandle renderer,
            int w,
            int h,
            RendererLogicalPresentation mode,
            ScaleMode scale_mode
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderScale")]
        static abstract int SetRenderScale(RendererHandle renderer, float scaleX, float scaleY);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderTarget")]
        static abstract int SetRenderTarget(RendererHandle renderer, TextureHandle texture);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderViewport")]
        static abstract int SetRenderViewport(
            RendererHandle renderer,
            [NativeTypeName("const SDL_Rect *")] Rect* rect
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderViewport")]
        static abstract int SetRenderViewport(
            RendererHandle renderer,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderVSync")]
        static abstract int SetRenderVSync(RendererHandle renderer, int vsync);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetStringProperty")]
        static abstract int SetStringProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("const char *")] sbyte* value
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetStringProperty")]
        static abstract int SetStringProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("const char *")] Ref<sbyte> value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceAlphaMod")]
        static abstract int SetSurfaceAlphaMod(
            Surface* surface,
            [NativeTypeName("Uint8")] byte alpha
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceAlphaMod")]
        static abstract int SetSurfaceAlphaMod(
            Ref<Surface> surface,
            [NativeTypeName("Uint8")] byte alpha
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceBlendMode")]
        static abstract int SetSurfaceBlendMode(Surface* surface, BlendMode blendMode);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceBlendMode")]
        static abstract int SetSurfaceBlendMode(Ref<Surface> surface, BlendMode blendMode);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceClipRect")]
        static abstract int SetSurfaceClipRect(
            Surface* surface,
            [NativeTypeName("const SDL_Rect *")] Rect* rect
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceClipRect")]
        static abstract MaybeBool<int> SetSurfaceClipRect(
            Ref<Surface> surface,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorKey")]
        static abstract int SetSurfaceColorKey(
            Surface* surface,
            int flag,
            [NativeTypeName("Uint32")] uint key
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorKey")]
        static abstract int SetSurfaceColorKey(
            Ref<Surface> surface,
            int flag,
            [NativeTypeName("Uint32")] uint key
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorMod")]
        static abstract int SetSurfaceColorMod(
            Surface* surface,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorMod")]
        static abstract int SetSurfaceColorMod(
            Ref<Surface> surface,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorspace")]
        static abstract int SetSurfaceColorspace(Surface* surface, Colorspace colorspace);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorspace")]
        static abstract int SetSurfaceColorspace(Ref<Surface> surface, Colorspace colorspace);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfacePalette")]
        static abstract int SetSurfacePalette(Surface* surface, Palette* palette);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfacePalette")]
        static abstract int SetSurfacePalette(Ref<Surface> surface, Ref<Palette> palette);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceRLE")]
        static abstract int SetSurfaceRLE(Surface* surface, int flag);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceRLE")]
        static abstract int SetSurfaceRLE(Ref<Surface> surface, int flag);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextInputRect")]
        static abstract int SetTextInputRect([NativeTypeName("const SDL_Rect *")] Rect* rect);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextInputRect")]
        static abstract int SetTextInputRect([NativeTypeName("const SDL_Rect *")] Ref<Rect> rect);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaMod")]
        static abstract int SetTextureAlphaMod(
            TextureHandle texture,
            [NativeTypeName("Uint8")] byte alpha
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaModFloat")]
        static abstract int SetTextureAlphaModFloat(TextureHandle texture, float alpha);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureBlendMode")]
        static abstract int SetTextureBlendMode(TextureHandle texture, BlendMode blendMode);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorMod")]
        static abstract int SetTextureColorMod(
            TextureHandle texture,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorModFloat")]
        static abstract int SetTextureColorModFloat(
            TextureHandle texture,
            float r,
            float g,
            float b
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureScaleMode")]
        static abstract int SetTextureScaleMode(TextureHandle texture, ScaleMode scaleMode);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetThreadPriority")]
        static abstract int SetThreadPriority(ThreadPriority priority);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetTLS")]
        static abstract int SetTLS(
            [NativeTypeName("SDL_TLSID")] uint id,
            [NativeTypeName("const void *")] void* value,
            [NativeTypeName("void (*)(void *)")] delegate* unmanaged<void*, void> destructor
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTLS")]
        static abstract int SetTLS(
            [NativeTypeName("SDL_TLSID")] uint id,
            [NativeTypeName("const void *")] Ref value,
            [NativeTypeName("void (*)(void *)")] delegate* unmanaged<void*, void> destructor
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAlwaysOnTop")]
        static abstract int SetWindowAlwaysOnTop(
            WindowHandle window,
            [NativeTypeName("SDL_bool")] int on_top
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAlwaysOnTop")]
        static abstract int SetWindowAlwaysOnTop(
            WindowHandle window,
            [NativeTypeName("SDL_bool")] MaybeBool<int> on_top
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowBordered")]
        static abstract int SetWindowBordered(
            WindowHandle window,
            [NativeTypeName("SDL_bool")] int bordered
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowBordered")]
        static abstract int SetWindowBordered(
            WindowHandle window,
            [NativeTypeName("SDL_bool")] MaybeBool<int> bordered
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFocusable")]
        static abstract int SetWindowFocusable(
            WindowHandle window,
            [NativeTypeName("SDL_bool")] int focusable
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFocusable")]
        static abstract int SetWindowFocusable(
            WindowHandle window,
            [NativeTypeName("SDL_bool")] MaybeBool<int> focusable
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreen")]
        static abstract int SetWindowFullscreen(
            WindowHandle window,
            [NativeTypeName("SDL_bool")] int fullscreen
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreen")]
        static abstract int SetWindowFullscreen(
            WindowHandle window,
            [NativeTypeName("SDL_bool")] MaybeBool<int> fullscreen
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreenMode")]
        static abstract int SetWindowFullscreenMode(
            WindowHandle window,
            [NativeTypeName("const SDL_DisplayMode *")] DisplayMode* mode
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreenMode")]
        static abstract int SetWindowFullscreenMode(
            WindowHandle window,
            [NativeTypeName("const SDL_DisplayMode *")] Ref<DisplayMode> mode
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowHitTest")]
        static abstract int SetWindowHitTest(
            WindowHandle window,
            [NativeTypeName("SDL_HitTest")]
                delegate* unmanaged<WindowHandle, Point*, void*, HitTestResult> callback,
            void* callback_data
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowHitTest")]
        static abstract int SetWindowHitTest(
            WindowHandle window,
            [NativeTypeName("SDL_HitTest")]
                delegate* unmanaged<WindowHandle, Point*, void*, HitTestResult> callback,
            Ref callback_data
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowIcon")]
        static abstract int SetWindowIcon(WindowHandle window, Surface* icon);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowIcon")]
        static abstract int SetWindowIcon(WindowHandle window, Ref<Surface> icon);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowInputFocus")]
        static abstract int SetWindowInputFocus(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowKeyboardGrab")]
        static abstract int SetWindowKeyboardGrab(
            WindowHandle window,
            [NativeTypeName("SDL_bool")] int grabbed
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowKeyboardGrab")]
        static abstract int SetWindowKeyboardGrab(
            WindowHandle window,
            [NativeTypeName("SDL_bool")] MaybeBool<int> grabbed
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMaximumSize")]
        static abstract int SetWindowMaximumSize(WindowHandle window, int max_w, int max_h);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMinimumSize")]
        static abstract int SetWindowMinimumSize(WindowHandle window, int min_w, int min_h);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowModalFor")]
        static abstract int SetWindowModalFor(
            WindowHandle modal_window,
            WindowHandle parent_window
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseGrab")]
        static abstract int SetWindowMouseGrab(
            WindowHandle window,
            [NativeTypeName("SDL_bool")] int grabbed
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseGrab")]
        static abstract int SetWindowMouseGrab(
            WindowHandle window,
            [NativeTypeName("SDL_bool")] MaybeBool<int> grabbed
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseRect")]
        static abstract int SetWindowMouseRect(
            WindowHandle window,
            [NativeTypeName("const SDL_Rect *")] Rect* rect
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseRect")]
        static abstract int SetWindowMouseRect(
            WindowHandle window,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowOpacity")]
        static abstract int SetWindowOpacity(WindowHandle window, float opacity);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowPosition")]
        static abstract int SetWindowPosition(WindowHandle window, int x, int y);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowResizable")]
        static abstract int SetWindowResizable(
            WindowHandle window,
            [NativeTypeName("SDL_bool")] int resizable
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowResizable")]
        static abstract int SetWindowResizable(
            WindowHandle window,
            [NativeTypeName("SDL_bool")] MaybeBool<int> resizable
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowShape")]
        static abstract int SetWindowShape(WindowHandle window, Surface* shape);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowShape")]
        static abstract int SetWindowShape(WindowHandle window, Ref<Surface> shape);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSize")]
        static abstract int SetWindowSize(WindowHandle window, int w, int h);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowTitle")]
        static abstract int SetWindowTitle(
            WindowHandle window,
            [NativeTypeName("const char *")] sbyte* title
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowTitle")]
        static abstract int SetWindowTitle(
            WindowHandle window,
            [NativeTypeName("const char *")] Ref<sbyte> title
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ShowCursor")]
        static abstract int ShowCursor();

        [NativeFunction("SDL3", EntryPoint = "SDL_ShowMessageBox")]
        static abstract int ShowMessageBox(
            [NativeTypeName("const SDL_MessageBoxData *")] MessageBoxData* messageboxdata,
            int* buttonid
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowMessageBox")]
        static abstract int ShowMessageBox(
            [NativeTypeName("const SDL_MessageBoxData *")] Ref<MessageBoxData> messageboxdata,
            Ref<int> buttonid
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFileDialog")]
        static abstract void ShowOpenFileDialog(
            [NativeTypeName("SDL_DialogFileCallback")]
                delegate* unmanaged<void*, sbyte**, int, void> callback,
            void* userdata,
            WindowHandle window,
            [NativeTypeName("const SDL_DialogFileFilter *")] DialogFileFilter* filters,
            [NativeTypeName("const char *")] sbyte* default_location,
            [NativeTypeName("SDL_bool")] int allow_many
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFileDialog")]
        static abstract void ShowOpenFileDialog(
            [NativeTypeName("SDL_DialogFileCallback")]
                delegate* unmanaged<void*, sbyte**, int, void> callback,
            Ref userdata,
            WindowHandle window,
            [NativeTypeName("const SDL_DialogFileFilter *")] Ref<DialogFileFilter> filters,
            [NativeTypeName("const char *")] Ref<sbyte> default_location,
            [NativeTypeName("SDL_bool")] MaybeBool<int> allow_many
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFolderDialog")]
        static abstract void ShowOpenFolderDialog(
            [NativeTypeName("SDL_DialogFileCallback")]
                delegate* unmanaged<void*, sbyte**, int, void> callback,
            void* userdata,
            WindowHandle window,
            [NativeTypeName("const char *")] sbyte* default_location,
            [NativeTypeName("SDL_bool")] int allow_many
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFolderDialog")]
        static abstract void ShowOpenFolderDialog(
            [NativeTypeName("SDL_DialogFileCallback")]
                delegate* unmanaged<void*, sbyte**, int, void> callback,
            Ref userdata,
            WindowHandle window,
            [NativeTypeName("const char *")] Ref<sbyte> default_location,
            [NativeTypeName("SDL_bool")] MaybeBool<int> allow_many
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ShowSaveFileDialog")]
        static abstract void ShowSaveFileDialog(
            [NativeTypeName("SDL_DialogFileCallback")]
                delegate* unmanaged<void*, sbyte**, int, void> callback,
            void* userdata,
            WindowHandle window,
            [NativeTypeName("const SDL_DialogFileFilter *")] DialogFileFilter* filters,
            [NativeTypeName("const char *")] sbyte* default_location
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowSaveFileDialog")]
        static abstract void ShowSaveFileDialog(
            [NativeTypeName("SDL_DialogFileCallback")]
                delegate* unmanaged<void*, sbyte**, int, void> callback,
            Ref userdata,
            WindowHandle window,
            [NativeTypeName("const SDL_DialogFileFilter *")] Ref<DialogFileFilter> filters,
            [NativeTypeName("const char *")] Ref<sbyte> default_location
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ShowSimpleMessageBox")]
        static abstract int ShowSimpleMessageBox(
            [NativeTypeName("Uint32")] uint flags,
            [NativeTypeName("const char *")] sbyte* title,
            [NativeTypeName("const char *")] sbyte* message,
            WindowHandle window
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowSimpleMessageBox")]
        static abstract int ShowSimpleMessageBox(
            [NativeTypeName("Uint32")] uint flags,
            [NativeTypeName("const char *")] Ref<sbyte> title,
            [NativeTypeName("const char *")] Ref<sbyte> message,
            WindowHandle window
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindow")]
        static abstract int ShowWindow(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindowSystemMenu")]
        static abstract int ShowWindowSystemMenu(WindowHandle window, int x, int y);

        [NativeFunction("SDL3", EntryPoint = "SDL_SignalCondition")]
        static abstract int SignalCondition(ConditionHandle cond);

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SIMDGetAlignment")]
        static abstract nuint SimdGetAlignment();

        [NativeFunction("SDL3", EntryPoint = "SDL_SoftStretch")]
        static abstract int SoftStretch(
            Surface* src,
            [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* dstrect,
            ScaleMode scaleMode
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SoftStretch")]
        static abstract int SoftStretch(
            Ref<Surface> src,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect,
            ScaleMode scaleMode
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInput")]
        static abstract void StartTextInput();

        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffect")]
        static abstract int StopHapticEffect(HapticHandle haptic, int effect);

        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffects")]
        static abstract int StopHapticEffects(HapticHandle haptic);

        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticRumble")]
        static abstract int StopHapticRumble(HapticHandle haptic);

        [NativeFunction("SDL3", EntryPoint = "SDL_StopTextInput")]
        static abstract void StopTextInput();

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_StorageReady")]
        static abstract MaybeBool<int> StorageReady(StorageHandle storage);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StorageReady")]
        static abstract int StorageReadyRaw(StorageHandle storage);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasColorKey")]
        static abstract int SurfaceHasColorKey(Surface* surface);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasColorKey")]
        static abstract MaybeBool<int> SurfaceHasColorKey(Ref<Surface> surface);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasRLE")]
        static abstract int SurfaceHasRLE(Surface* surface);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasRLE")]
        static abstract MaybeBool<int> SurfaceHasRLE(Ref<Surface> surface);

        [NativeFunction("SDL3", EntryPoint = "SDL_SyncWindow")]
        static abstract int SyncWindow(WindowHandle window);

        [return: NativeTypeName("Sint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TellIO")]
        static abstract long TellIO(IOStreamHandle context);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_TextInputActive")]
        static abstract MaybeBool<int> TextInputActive();

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TextInputActive")]
        static abstract int TextInputActiveRaw();

        [return: NativeTypeName("SDL_Time")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TimeFromWindows")]
        static abstract long TimeFromWindows(
            [NativeTypeName("Uint32")] uint dwLowDateTime,
            [NativeTypeName("Uint32")] uint dwHighDateTime
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_TimeToDateTime")]
        static abstract int TimeToDateTime(
            [NativeTypeName("SDL_Time")] long ticks,
            DateTime* dt,
            [NativeTypeName("SDL_bool")] int localTime
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_TimeToDateTime")]
        static abstract int TimeToDateTime(
            [NativeTypeName("SDL_Time")] long ticks,
            Ref<DateTime> dt,
            [NativeTypeName("SDL_bool")] MaybeBool<int> localTime
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_TimeToWindows")]
        static abstract void TimeToWindows(
            [NativeTypeName("SDL_Time")] long ticks,
            [NativeTypeName("Uint32 *")] uint* dwLowDateTime,
            [NativeTypeName("Uint32 *")] uint* dwHighDateTime
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_TimeToWindows")]
        static abstract void TimeToWindows(
            [NativeTypeName("SDL_Time")] long ticks,
            [NativeTypeName("Uint32 *")] Ref<uint> dwLowDateTime,
            [NativeTypeName("Uint32 *")] Ref<uint> dwHighDateTime
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockMutex")]
        static abstract int TryLockMutex(MutexHandle mutex);

        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForReading")]
        static abstract int TryLockRWLockForReading(RWLockHandle rwlock);

        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForWriting")]
        static abstract int TryLockRWLockForWriting(RWLockHandle rwlock);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockSpinlock")]
        static abstract int TryLockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockSpinlock")]
        static abstract MaybeBool<int> TryLockSpinlock(
            [NativeTypeName("SDL_SpinLock *")] Ref<int> @lock
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_TryWaitSemaphore")]
        static abstract int TryWaitSemaphore(SemaphoreHandle sem);

        [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStream")]
        static abstract void UnbindAudioStream(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStreams")]
        static abstract void UnbindAudioStreams(AudioStreamHandle* streams, int num_streams);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStreams")]
        static abstract void UnbindAudioStreams(Ref<AudioStreamHandle> streams, int num_streams);

        [NativeFunction("SDL3", EntryPoint = "SDL_UnloadObject")]
        static abstract void UnloadObject(void* handle);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnloadObject")]
        static abstract void UnloadObject(Ref handle);

        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockAudioStream")]
        static abstract int UnlockAudioStream(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockJoysticks")]
        static abstract void UnlockJoysticks();

        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockMutex")]
        static abstract void UnlockMutex(MutexHandle mutex);

        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockProperties")]
        static abstract void UnlockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockRWLock")]
        static abstract void UnlockRWLock(RWLockHandle rwlock);

        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSpinlock")]
        static abstract void UnlockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSpinlock")]
        static abstract void UnlockSpinlock([NativeTypeName("SDL_SpinLock *")] Ref<int> @lock);

        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSurface")]
        static abstract void UnlockSurface(Surface* surface);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSurface")]
        static abstract void UnlockSurface(Ref<Surface> surface);

        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockTexture")]
        static abstract void UnlockTexture(TextureHandle texture);

        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateGamepads")]
        static abstract void UpdateGamepads();

        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateHapticEffect")]
        static abstract int UpdateHapticEffect(
            HapticHandle haptic,
            int effect,
            [NativeTypeName("const SDL_HapticEffect *")] HapticEffect* data
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateHapticEffect")]
        static abstract int UpdateHapticEffect(
            HapticHandle haptic,
            int effect,
            [NativeTypeName("const SDL_HapticEffect *")] Ref<HapticEffect> data
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateJoysticks")]
        static abstract void UpdateJoysticks();

        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateNVTexture")]
        static abstract int UpdateNVTexture(
            TextureHandle texture,
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            [NativeTypeName("const Uint8 *")] byte* Yplane,
            int Ypitch,
            [NativeTypeName("const Uint8 *")] byte* UVplane,
            int UVpitch
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateNVTexture")]
        static abstract int UpdateNVTexture(
            TextureHandle texture,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            [NativeTypeName("const Uint8 *")] Ref<byte> Yplane,
            int Ypitch,
            [NativeTypeName("const Uint8 *")] Ref<byte> UVplane,
            int UVpitch
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateSensors")]
        static abstract void UpdateSensors();

        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateTexture")]
        static abstract int UpdateTexture(
            TextureHandle texture,
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            [NativeTypeName("const void *")] void* pixels,
            int pitch
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateTexture")]
        static abstract int UpdateTexture(
            TextureHandle texture,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            [NativeTypeName("const void *")] Ref pixels,
            int pitch
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurface")]
        static abstract int UpdateWindowSurface(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurfaceRects")]
        static abstract int UpdateWindowSurfaceRects(
            WindowHandle window,
            [NativeTypeName("const SDL_Rect *")] Rect* rects,
            int numrects
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurfaceRects")]
        static abstract int UpdateWindowSurfaceRects(
            WindowHandle window,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rects,
            int numrects
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateYUVTexture")]
        static abstract int UpdateYUVTexture(
            TextureHandle texture,
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            [NativeTypeName("const Uint8 *")] byte* Yplane,
            int Ypitch,
            [NativeTypeName("const Uint8 *")] byte* Uplane,
            int Upitch,
            [NativeTypeName("const Uint8 *")] byte* Vplane,
            int Vpitch
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateYUVTexture")]
        static abstract int UpdateYUVTexture(
            TextureHandle texture,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            [NativeTypeName("const Uint8 *")] Ref<byte> Yplane,
            int Ypitch,
            [NativeTypeName("const Uint8 *")] Ref<byte> Uplane,
            int Upitch,
            [NativeTypeName("const Uint8 *")] Ref<byte> Vplane,
            int Vpitch
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_WaitCondition")]
        static abstract int WaitCondition(ConditionHandle cond, MutexHandle mutex);

        [NativeFunction("SDL3", EntryPoint = "SDL_WaitConditionTimeout")]
        static abstract int WaitConditionTimeout(
            ConditionHandle cond,
            MutexHandle mutex,
            [NativeTypeName("Sint32")] int timeoutMS
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitEvent")]
        static abstract int WaitEvent(Event* @event);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitEvent")]
        static abstract MaybeBool<int> WaitEvent(Ref<Event> @event);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitEventTimeout")]
        static abstract int WaitEventTimeout(
            Event* @event,
            [NativeTypeName("Sint32")] int timeoutMS
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitEventTimeout")]
        static abstract MaybeBool<int> WaitEventTimeout(
            Ref<Event> @event,
            [NativeTypeName("Sint32")] int timeoutMS
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphore")]
        static abstract int WaitSemaphore(SemaphoreHandle sem);

        [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphoreTimeout")]
        static abstract int WaitSemaphoreTimeout(
            SemaphoreHandle sem,
            [NativeTypeName("Sint32")] int timeoutMS
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_WaitThread")]
        static abstract void WaitThread(ThreadHandle thread, int* status);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitThread")]
        static abstract void WaitThread(ThreadHandle thread, Ref<int> status);

        [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseGlobal")]
        static abstract int WarpMouseGlobal(float x, float y);

        [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseInWindow")]
        static abstract void WarpMouseInWindow(WindowHandle window, float x, float y);

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WasInit")]
        static abstract uint WasInit([NativeTypeName("Uint32")] uint flags);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WindowHasSurface")]
        static abstract MaybeBool<int> WindowHasSurface(WindowHandle window);

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WindowHasSurface")]
        static abstract int WindowHasSurfaceRaw(WindowHandle window);

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteIO")]
        static abstract nuint WriteIO(
            IOStreamHandle context,
            [NativeTypeName("const void *")] void* ptr,
            [NativeTypeName("size_t")] nuint size
        );

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteIO")]
        static abstract nuint WriteIO(
            IOStreamHandle context,
            [NativeTypeName("const void *")] Ref ptr,
            [NativeTypeName("size_t")] nuint size
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16BE")]
        static abstract MaybeBool<int> WriteS16BE(
            IOStreamHandle dst,
            [NativeTypeName("Sint16")] short value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16BE")]
        static abstract int WriteS16BERaw(
            IOStreamHandle dst,
            [NativeTypeName("Sint16")] short value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16LE")]
        static abstract MaybeBool<int> WriteS16LE(
            IOStreamHandle dst,
            [NativeTypeName("Sint16")] short value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16LE")]
        static abstract int WriteS16LERaw(
            IOStreamHandle dst,
            [NativeTypeName("Sint16")] short value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32BE")]
        static abstract MaybeBool<int> WriteS32BE(
            IOStreamHandle dst,
            [NativeTypeName("Sint32")] int value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32BE")]
        static abstract int WriteS32BERaw(IOStreamHandle dst, [NativeTypeName("Sint32")] int value);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32LE")]
        static abstract MaybeBool<int> WriteS32LE(
            IOStreamHandle dst,
            [NativeTypeName("Sint32")] int value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32LE")]
        static abstract int WriteS32LERaw(IOStreamHandle dst, [NativeTypeName("Sint32")] int value);

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64BE")]
        static abstract MaybeBool<int> WriteS64BE(
            IOStreamHandle dst,
            [NativeTypeName("Sint64")] long value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64BE")]
        static abstract int WriteS64BERaw(
            IOStreamHandle dst,
            [NativeTypeName("Sint64")] long value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64LE")]
        static abstract MaybeBool<int> WriteS64LE(
            IOStreamHandle dst,
            [NativeTypeName("Sint64")] long value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64LE")]
        static abstract int WriteS64LERaw(
            IOStreamHandle dst,
            [NativeTypeName("Sint64")] long value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_WriteStorageFile")]
        static abstract int WriteStorageFile(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path,
            [NativeTypeName("const void *")] void* source,
            [NativeTypeName("Uint64")] ulong length
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteStorageFile")]
        static abstract int WriteStorageFile(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path,
            [NativeTypeName("const void *")] Ref source,
            [NativeTypeName("Uint64")] ulong length
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16BE")]
        static abstract MaybeBool<int> WriteU16BE(
            IOStreamHandle dst,
            [NativeTypeName("Uint16")] ushort value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16BE")]
        static abstract int WriteU16BERaw(
            IOStreamHandle dst,
            [NativeTypeName("Uint16")] ushort value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16LE")]
        static abstract MaybeBool<int> WriteU16LE(
            IOStreamHandle dst,
            [NativeTypeName("Uint16")] ushort value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16LE")]
        static abstract int WriteU16LERaw(
            IOStreamHandle dst,
            [NativeTypeName("Uint16")] ushort value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32BE")]
        static abstract MaybeBool<int> WriteU32BE(
            IOStreamHandle dst,
            [NativeTypeName("Uint32")] uint value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32BE")]
        static abstract int WriteU32BERaw(
            IOStreamHandle dst,
            [NativeTypeName("Uint32")] uint value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32LE")]
        static abstract MaybeBool<int> WriteU32LE(
            IOStreamHandle dst,
            [NativeTypeName("Uint32")] uint value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32LE")]
        static abstract int WriteU32LERaw(
            IOStreamHandle dst,
            [NativeTypeName("Uint32")] uint value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64BE")]
        static abstract MaybeBool<int> WriteU64BE(
            IOStreamHandle dst,
            [NativeTypeName("Uint64")] ulong value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64BE")]
        static abstract int WriteU64BERaw(
            IOStreamHandle dst,
            [NativeTypeName("Uint64")] ulong value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64LE")]
        static abstract MaybeBool<int> WriteU64LE(
            IOStreamHandle dst,
            [NativeTypeName("Uint64")] ulong value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64LE")]
        static abstract int WriteU64LERaw(
            IOStreamHandle dst,
            [NativeTypeName("Uint64")] ulong value
        );

        [return: NativeTypeName("SDL_bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU8")]
        static abstract MaybeBool<int> WriteU8(
            IOStreamHandle dst,
            [NativeTypeName("Uint8")] byte value
        );

        [return: NativeTypeName("SDL_bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU8")]
        static abstract int WriteU8Raw(IOStreamHandle dst, [NativeTypeName("Uint8")] byte value);
    }

    [NativeFunction("SDL3", EntryPoint = "SDL_AcquireCameraFrame")]
    Surface* AcquireCameraFrame(
        CameraHandle camera,
        [NativeTypeName("Uint64 *")] ulong* timestampNS
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AcquireCameraFrame")]
    Ptr<Surface> AcquireCameraFrame(
        CameraHandle camera,
        [NativeTypeName("Uint64 *")] Ref<ulong> timestampNS
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_AddEventWatch")]
    int AddEventWatch(
        [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddEventWatch")]
    int AddEventWatch(
        [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMapping")]
    int AddGamepadMapping([NativeTypeName("const char *")] sbyte* mapping);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMapping")]
    int AddGamepadMapping([NativeTypeName("const char *")] Ref<sbyte> mapping);

    [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromFile")]
    int AddGamepadMappingsFromFile([NativeTypeName("const char *")] sbyte* file);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromFile")]
    int AddGamepadMappingsFromFile([NativeTypeName("const char *")] Ref<sbyte> file);

    [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromIO")]
    int AddGamepadMappingsFromIO(IOStreamHandle src, [NativeTypeName("SDL_bool")] int closeio);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromIO")]
    int AddGamepadMappingsFromIO(
        IOStreamHandle src,
        [NativeTypeName("SDL_bool")] MaybeBool<int> closeio
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_AddHintCallback")]
    int AddHintCallback(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("SDL_HintCallback")]
            delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void> callback,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddHintCallback")]
    int AddHintCallback(
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("SDL_HintCallback")]
            delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void> callback,
        Ref userdata
    );

    [return: NativeTypeName("SDL_TimerID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddTimer")]
    uint AddTimer(
        [NativeTypeName("Uint32")] uint interval,
        [NativeTypeName("SDL_TimerCallback")] delegate* unmanaged<uint, void*, uint> callback,
        void* param2
    );

    [return: NativeTypeName("SDL_TimerID")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddTimer")]
    uint AddTimer(
        [NativeTypeName("Uint32")] uint interval,
        [NativeTypeName("SDL_TimerCallback")] delegate* unmanaged<uint, void*, uint> callback,
        Ref param2
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_AddVulkanRenderSemaphores")]
    int AddVulkanRenderSemaphores(
        RendererHandle renderer,
        [NativeTypeName("Uint32")] uint wait_stage_mask,
        [NativeTypeName("Sint64")] long wait_semaphore,
        [NativeTypeName("Sint64")] long signal_semaphore
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AllocateEventMemory")]
    Ptr AllocateEventMemory([NativeTypeName("size_t")] nuint size);

    [NativeFunction("SDL3", EntryPoint = "SDL_AllocateEventMemory")]
    void* AllocateEventMemoryRaw([NativeTypeName("size_t")] nuint size);

    [NativeFunction("SDL3", EntryPoint = "SDL_AtomicAdd")]
    int AtomicAdd(AtomicInt* a, int v);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AtomicAdd")]
    int AtomicAdd(Ref<AtomicInt> a, int v);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AtomicCompareAndSwap")]
    int AtomicCompareAndSwap(AtomicInt* a, int oldval, int newval);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AtomicCompareAndSwap")]
    MaybeBool<int> AtomicCompareAndSwap(Ref<AtomicInt> a, int oldval, int newval);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AtomicCompareAndSwapPointer")]
    int AtomicCompareAndSwapPointer(void** a, void* oldval, void* newval);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AtomicCompareAndSwapPointer")]
    MaybeBool<int> AtomicCompareAndSwapPointer(Ref2D a, Ref oldval, Ref newval);

    [NativeFunction("SDL3", EntryPoint = "SDL_AtomicGet")]
    int AtomicGet(AtomicInt* a);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AtomicGet")]
    int AtomicGet(Ref<AtomicInt> a);

    [NativeFunction("SDL3", EntryPoint = "SDL_AtomicGetPtr")]
    void* AtomicGetPtr(void** a);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AtomicGetPtr")]
    Ptr AtomicGetPtr(Ref2D a);

    [NativeFunction("SDL3", EntryPoint = "SDL_AtomicSet")]
    int AtomicSet(AtomicInt* a, int v);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AtomicSet")]
    int AtomicSet(Ref<AtomicInt> a, int v);

    [NativeFunction("SDL3", EntryPoint = "SDL_AtomicSetPtr")]
    void* AtomicSetPtr(void** a, void* v);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AtomicSetPtr")]
    Ptr AtomicSetPtr(Ref2D a, Ref v);

    [return: NativeTypeName("SDL_JoystickID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AttachVirtualJoystick")]
    uint AttachVirtualJoystick(JoystickType type, int naxes, int nbuttons, int nhats);

    [return: NativeTypeName("SDL_JoystickID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AttachVirtualJoystickEx")]
    uint AttachVirtualJoystickEx(
        [NativeTypeName("const SDL_VirtualJoystickDesc *")] VirtualJoystickDesc* desc
    );

    [return: NativeTypeName("SDL_JoystickID")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AttachVirtualJoystickEx")]
    uint AttachVirtualJoystickEx(
        [NativeTypeName("const SDL_VirtualJoystickDesc *")] Ref<VirtualJoystickDesc> desc
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AudioDevicePaused")]
    MaybeBool<int> AudioDevicePaused([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AudioDevicePaused")]
    int AudioDevicePausedRaw([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStream")]
    int BindAudioStream([NativeTypeName("SDL_AudioDeviceID")] uint devid, AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStreams")]
    int BindAudioStreams(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        AudioStreamHandle* streams,
        int num_streams
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStreams")]
    int BindAudioStreams(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        Ref<AudioStreamHandle> streams,
        int num_streams
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface")]
    int BlitSurface(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        Rect* dstrect
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface")]
    int BlitSurface(
        Ref<Surface> src,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
        Ref<Surface> dst,
        Ref<Rect> dstrect
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceScaled")]
    int BlitSurfaceScaled(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        Rect* dstrect,
        ScaleMode scaleMode
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceScaled")]
    int BlitSurfaceScaled(
        Ref<Surface> src,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
        Ref<Surface> dst,
        Ref<Rect> dstrect,
        ScaleMode scaleMode
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUnchecked")]
    int BlitSurfaceUnchecked(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* dstrect
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUnchecked")]
    int BlitSurfaceUnchecked(
        Ref<Surface> src,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUncheckedScaled")]
    int BlitSurfaceUncheckedScaled(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* dstrect,
        ScaleMode scaleMode
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUncheckedScaled")]
    int BlitSurfaceUncheckedScaled(
        Ref<Surface> src,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect,
        ScaleMode scaleMode
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BroadcastCondition")]
    int BroadcastCondition(ConditionHandle cond);

    [NativeFunction("SDL3", EntryPoint = "SDL_CaptureMouse")]
    int CaptureMouse([NativeTypeName("SDL_bool")] int enabled);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CaptureMouse")]
    int CaptureMouse([NativeTypeName("SDL_bool")] MaybeBool<int> enabled);

    [NativeFunction("SDL3", EntryPoint = "SDL_CleanupTLS")]
    void CleanupTLS();

    [NativeFunction("SDL3", EntryPoint = "SDL_ClearAudioStream")]
    int ClearAudioStream(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_ClearClipboardData")]
    int ClearClipboardData();

    [NativeFunction("SDL3", EntryPoint = "SDL_ClearComposition")]
    void ClearComposition();

    [NativeFunction("SDL3", EntryPoint = "SDL_ClearError")]
    void ClearError();

    [NativeFunction("SDL3", EntryPoint = "SDL_ClearProperty")]
    int ClearProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearProperty")]
    int ClearProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CloseAudioDevice")]
    void CloseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [NativeFunction("SDL3", EntryPoint = "SDL_CloseCamera")]
    void CloseCamera(CameraHandle camera);

    [NativeFunction("SDL3", EntryPoint = "SDL_CloseGamepad")]
    void CloseGamepad(GamepadHandle gamepad);

    [NativeFunction("SDL3", EntryPoint = "SDL_CloseHaptic")]
    void CloseHaptic(HapticHandle haptic);

    [NativeFunction("SDL3", EntryPoint = "SDL_CloseIO")]
    int CloseIO(IOStreamHandle context);

    [NativeFunction("SDL3", EntryPoint = "SDL_CloseJoystick")]
    void CloseJoystick(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_CloseSensor")]
    void CloseSensor(SensorHandle sensor);

    [NativeFunction("SDL3", EntryPoint = "SDL_CloseStorage")]
    int CloseStorage(StorageHandle storage);

    [NativeFunction("SDL3", EntryPoint = "SDL_ComposeCustomBlendMode")]
    BlendMode ComposeCustomBlendMode(
        BlendFactor srcColorFactor,
        BlendFactor dstColorFactor,
        BlendOperation colorOperation,
        BlendFactor srcAlphaFactor,
        BlendFactor dstAlphaFactor,
        BlendOperation alphaOperation
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertAudioSamples")]
    int ConvertAudioSamples(
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* src_spec,
        [NativeTypeName("const Uint8 *")] byte* src_data,
        int src_len,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* dst_spec,
        [NativeTypeName("Uint8 **")] byte** dst_data,
        int* dst_len
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertAudioSamples")]
    int ConvertAudioSamples(
        [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> src_spec,
        [NativeTypeName("const Uint8 *")] Ref<byte> src_data,
        int src_len,
        [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> dst_spec,
        [NativeTypeName("Uint8 **")] Ref2D<byte> dst_data,
        Ref<int> dst_len
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertEventToRenderCoordinates")]
    int ConvertEventToRenderCoordinates(RendererHandle renderer, Event* @event);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertEventToRenderCoordinates")]
    int ConvertEventToRenderCoordinates(RendererHandle renderer, Ref<Event> @event);

    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixels")]
    int ConvertPixels(
        int width,
        int height,
        PixelFormatEnum src_format,
        [NativeTypeName("const void *")] void* src,
        int src_pitch,
        PixelFormatEnum dst_format,
        void* dst,
        int dst_pitch
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixels")]
    int ConvertPixels(
        int width,
        int height,
        PixelFormatEnum src_format,
        [NativeTypeName("const void *")] Ref src,
        int src_pitch,
        PixelFormatEnum dst_format,
        Ref dst,
        int dst_pitch
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixelsAndColorspace")]
    int ConvertPixelsAndColorspace(
        int width,
        int height,
        PixelFormatEnum src_format,
        Colorspace src_colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint src_properties,
        [NativeTypeName("const void *")] void* src,
        int src_pitch,
        PixelFormatEnum dst_format,
        Colorspace dst_colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint dst_properties,
        void* dst,
        int dst_pitch
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixelsAndColorspace")]
    int ConvertPixelsAndColorspace(
        int width,
        int height,
        PixelFormatEnum src_format,
        Colorspace src_colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint src_properties,
        [NativeTypeName("const void *")] Ref src,
        int src_pitch,
        PixelFormatEnum dst_format,
        Colorspace dst_colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint dst_properties,
        Ref dst,
        int dst_pitch
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurface")]
    Surface* ConvertSurface(
        Surface* surface,
        [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurface")]
    Ptr<Surface> ConvertSurface(
        Ref<Surface> surface,
        [NativeTypeName("const SDL_PixelFormat *")] Ref<PixelFormat> format
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceFormat")]
    Surface* ConvertSurfaceFormat(Surface* surface, PixelFormatEnum pixel_format);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceFormat")]
    Ptr<Surface> ConvertSurfaceFormat(Ref<Surface> surface, PixelFormatEnum pixel_format);

    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceFormatAndColorspace")]
    Surface* ConvertSurfaceFormatAndColorspace(
        Surface* surface,
        PixelFormatEnum pixel_format,
        Colorspace colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceFormatAndColorspace")]
    Ptr<Surface> ConvertSurfaceFormatAndColorspace(
        Ref<Surface> surface,
        PixelFormatEnum pixel_format,
        Colorspace colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CopyProperties")]
    int CopyProperties(
        [NativeTypeName("SDL_PropertiesID")] uint src,
        [NativeTypeName("SDL_PropertiesID")] uint dst
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateAudioStream")]
    AudioStreamHandle CreateAudioStream(
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* src_spec,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* dst_spec
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateAudioStream")]
    AudioStreamHandle CreateAudioStream(
        [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> src_spec,
        [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> dst_spec
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateColorCursor")]
    CursorHandle CreateColorCursor(Surface* surface, int hot_x, int hot_y);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateColorCursor")]
    CursorHandle CreateColorCursor(Ref<Surface> surface, int hot_x, int hot_y);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateCondition")]
    ConditionHandle CreateCondition();

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateCursor")]
    CursorHandle CreateCursor(
        [NativeTypeName("const Uint8 *")] byte* data,
        [NativeTypeName("const Uint8 *")] byte* mask,
        int w,
        int h,
        int hot_x,
        int hot_y
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateCursor")]
    CursorHandle CreateCursor(
        [NativeTypeName("const Uint8 *")] Ref<byte> data,
        [NativeTypeName("const Uint8 *")] Ref<byte> mask,
        int w,
        int h,
        int hot_x,
        int hot_y
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateDirectory")]
    int CreateDirectory([NativeTypeName("const char *")] sbyte* path);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateDirectory")]
    int CreateDirectory([NativeTypeName("const char *")] Ref<sbyte> path);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateHapticEffect")]
    int CreateHapticEffect(
        HapticHandle haptic,
        [NativeTypeName("const SDL_HapticEffect *")] HapticEffect* effect
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateHapticEffect")]
    int CreateHapticEffect(
        HapticHandle haptic,
        [NativeTypeName("const SDL_HapticEffect *")] Ref<HapticEffect> effect
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateMutex")]
    MutexHandle CreateMutex();

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreatePalette")]
    Ptr<Palette> CreatePalette(int ncolors);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreatePalette")]
    Palette* CreatePaletteRaw(int ncolors);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreatePixelFormat")]
    Ptr<PixelFormat> CreatePixelFormat(PixelFormatEnum pixel_format);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreatePixelFormat")]
    PixelFormat* CreatePixelFormatRaw(PixelFormatEnum pixel_format);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreatePopupWindow")]
    WindowHandle CreatePopupWindow(
        WindowHandle parent,
        int offset_x,
        int offset_y,
        int w,
        int h,
        [NativeTypeName("SDL_WindowFlags")] uint flags
    );

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateProperties")]
    uint CreateProperties();

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateRenderer")]
    RendererHandle CreateRenderer(
        WindowHandle window,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("Uint32")] uint flags
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateRenderer")]
    RendererHandle CreateRenderer(
        WindowHandle window,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("Uint32")] uint flags
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateRendererWithProperties")]
    RendererHandle CreateRendererWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateRWLock")]
    RWLockHandle CreateRWLock();

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSemaphore")]
    SemaphoreHandle CreateSemaphore([NativeTypeName("Uint32")] uint initial_value);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSoftwareRenderer")]
    RendererHandle CreateSoftwareRenderer(Surface* surface);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSoftwareRenderer")]
    RendererHandle CreateSoftwareRenderer(Ref<Surface> surface);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateStorageDirectory")]
    int CreateStorageDirectory(StorageHandle storage, [NativeTypeName("const char *")] sbyte* path);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateStorageDirectory")]
    int CreateStorageDirectory(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurface")]
    Ptr<Surface> CreateSurface(int width, int height, PixelFormatEnum format);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfaceFrom")]
    Surface* CreateSurfaceFrom(
        void* pixels,
        int width,
        int height,
        int pitch,
        PixelFormatEnum format
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfaceFrom")]
    Ptr<Surface> CreateSurfaceFrom(
        Ref pixels,
        int width,
        int height,
        int pitch,
        PixelFormatEnum format
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurface")]
    Surface* CreateSurfaceRaw(int width, int height, PixelFormatEnum format);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSystemCursor")]
    CursorHandle CreateSystemCursor(SystemCursor id);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTexture")]
    TextureHandle CreateTexture(
        RendererHandle renderer,
        PixelFormatEnum format,
        int access,
        int w,
        int h
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureFromSurface")]
    TextureHandle CreateTextureFromSurface(RendererHandle renderer, Surface* surface);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureFromSurface")]
    TextureHandle CreateTextureFromSurface(RendererHandle renderer, Ref<Surface> surface);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureWithProperties")]
    TextureHandle CreateTextureWithProperties(
        RendererHandle renderer,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateThread")]
    ThreadHandle CreateThread(
        [NativeTypeName("SDL_ThreadFunction")] delegate* unmanaged<void*, int> fn,
        [NativeTypeName("const char *")] sbyte* name,
        void* data
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateThread")]
    ThreadHandle CreateThread(
        [NativeTypeName("SDL_ThreadFunction")] delegate* unmanaged<void*, int> fn,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        Ref data
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadWithStackSize")]
    ThreadHandle CreateThreadWithStackSize(
        [NativeTypeName("SDL_ThreadFunction")] delegate* unmanaged<void*, int> fn,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const size_t")] nuint stacksize,
        void* data
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadWithStackSize")]
    ThreadHandle CreateThreadWithStackSize(
        [NativeTypeName("SDL_ThreadFunction")] delegate* unmanaged<void*, int> fn,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("const size_t")] nuint stacksize,
        Ref data
    );

    [return: NativeTypeName("SDL_TLSID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTLS")]
    uint CreateTLS();

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindow")]
    WindowHandle CreateWindow(
        [NativeTypeName("const char *")] sbyte* title,
        int w,
        int h,
        [NativeTypeName("SDL_WindowFlags")] uint flags
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindow")]
    WindowHandle CreateWindow(
        [NativeTypeName("const char *")] Ref<sbyte> title,
        int w,
        int h,
        [NativeTypeName("SDL_WindowFlags")] uint flags
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowAndRenderer")]
    int CreateWindowAndRenderer(
        [NativeTypeName("const char *")] sbyte* title,
        int width,
        int height,
        [NativeTypeName("SDL_WindowFlags")] uint window_flags,
        WindowHandle* window,
        RendererHandle* renderer
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowAndRenderer")]
    int CreateWindowAndRenderer(
        [NativeTypeName("const char *")] Ref<sbyte> title,
        int width,
        int height,
        [NativeTypeName("SDL_WindowFlags")] uint window_flags,
        Ref<WindowHandle> window,
        Ref<RendererHandle> renderer
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowWithProperties")]
    WindowHandle CreateWindowWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CursorVisible")]
    MaybeBool<int> CursorVisible();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CursorVisible")]
    int CursorVisibleRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_DateTimeToTime")]
    int DateTimeToTime(
        [NativeTypeName("const SDL_DateTime *")] DateTime* dt,
        [NativeTypeName("SDL_Time *")] long* ticks
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DateTimeToTime")]
    int DateTimeToTime(
        [NativeTypeName("const SDL_DateTime *")] Ref<DateTime> dt,
        [NativeTypeName("SDL_Time *")] Ref<long> ticks
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_Delay")]
    void Delay([NativeTypeName("Uint32")] uint ms);

    [NativeFunction("SDL3", EntryPoint = "SDL_DelayNS")]
    void DelayNS([NativeTypeName("Uint64")] ulong ns);

    [NativeFunction("SDL3", EntryPoint = "SDL_DelEventWatch")]
    void DelEventWatch(
        [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DelEventWatch")]
    void DelEventWatch(
        [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_DelHintCallback")]
    void DelHintCallback(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("SDL_HintCallback")]
            delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void> callback,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DelHintCallback")]
    void DelHintCallback(
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("SDL_HintCallback")]
            delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void> callback,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyAudioStream")]
    void DestroyAudioStream(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyCondition")]
    void DestroyCondition(ConditionHandle cond);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyCursor")]
    void DestroyCursor(CursorHandle cursor);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyHapticEffect")]
    void DestroyHapticEffect(HapticHandle haptic, int effect);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyMutex")]
    void DestroyMutex(MutexHandle mutex);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPalette")]
    void DestroyPalette(Palette* palette);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPalette")]
    void DestroyPalette(Ref<Palette> palette);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPixelFormat")]
    void DestroyPixelFormat(PixelFormat* format);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPixelFormat")]
    void DestroyPixelFormat(Ref<PixelFormat> format);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyProperties")]
    void DestroyProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyRenderer")]
    void DestroyRenderer(RendererHandle renderer);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyRWLock")]
    void DestroyRWLock(RWLockHandle rwlock);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroySemaphore")]
    void DestroySemaphore(SemaphoreHandle sem);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroySurface")]
    void DestroySurface(Surface* surface);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroySurface")]
    void DestroySurface(Ref<Surface> surface);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyTexture")]
    void DestroyTexture(TextureHandle texture);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindow")]
    void DestroyWindow(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindowSurface")]
    int DestroyWindowSurface(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_DetachThread")]
    void DetachThread(ThreadHandle thread);

    [NativeFunction("SDL3", EntryPoint = "SDL_DetachVirtualJoystick")]
    int DetachVirtualJoystick([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_DisableScreenSaver")]
    int DisableScreenSaver();

    [NativeFunction("SDL3", EntryPoint = "SDL_DuplicateSurface")]
    Surface* DuplicateSurface(Surface* surface);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DuplicateSurface")]
    Ptr<Surface> DuplicateSurface(Ref<Surface> surface);

    [return: NativeTypeName("SDL_EGLConfig")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentEGLConfig")]
    Ptr EGLGetCurrentEGLConfig();

    [return: NativeTypeName("SDL_EGLConfig")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentEGLConfig")]
    void* EGLGetCurrentEGLConfigRaw();

    [return: NativeTypeName("SDL_EGLDisplay")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentEGLDisplay")]
    Ptr EGLGetCurrentEGLDisplay();

    [return: NativeTypeName("SDL_EGLDisplay")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentEGLDisplay")]
    void* EGLGetCurrentEGLDisplayRaw();

    [return: NativeTypeName("SDL_FunctionPointer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetProcAddress")]
    delegate* unmanaged<void> EGLGetProcAddress([NativeTypeName("const char *")] sbyte* proc);

    [return: NativeTypeName("SDL_FunctionPointer")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetProcAddress")]
    delegate* unmanaged<void> EGLGetProcAddress([NativeTypeName("const char *")] Ref<sbyte> proc);

    [return: NativeTypeName("SDL_EGLSurface")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetWindowEGLSurface")]
    Ptr EGLGetWindowEGLSurface(WindowHandle window);

    [return: NativeTypeName("SDL_EGLSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetWindowEGLSurface")]
    void* EGLGetWindowEGLSurfaceRaw(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_SetEGLAttributeCallbacks")]
    void EGLSetEGLAttributeCallbacks(
        [NativeTypeName("SDL_EGLAttribArrayCallback")]
            delegate* unmanaged<nint*> platformAttribCallback,
        [NativeTypeName("SDL_EGLIntArrayCallback")] delegate* unmanaged<int*> surfaceAttribCallback,
        [NativeTypeName("SDL_EGLIntArrayCallback")] delegate* unmanaged<int*> contextAttribCallback
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_EnableScreenSaver")]
    int EnableScreenSaver();

    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateDirectory")]
    int EnumerateDirectory(
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("SDL_EnumerateDirectoryCallback")]
            delegate* unmanaged<void*, sbyte*, sbyte*, int> callback,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateDirectory")]
    int EnumerateDirectory(
        [NativeTypeName("const char *")] Ref<sbyte> path,
        [NativeTypeName("SDL_EnumerateDirectoryCallback")]
            delegate* unmanaged<void*, sbyte*, sbyte*, int> callback,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateProperties")]
    int EnumerateProperties(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("SDL_EnumeratePropertiesCallback")]
            delegate* unmanaged<void*, uint, sbyte*, void> callback,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateProperties")]
    int EnumerateProperties(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("SDL_EnumeratePropertiesCallback")]
            delegate* unmanaged<void*, uint, sbyte*, void> callback,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateStorageDirectory")]
    int EnumerateStorageDirectory(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("SDL_EnumerateDirectoryCallback")]
            delegate* unmanaged<void*, sbyte*, sbyte*, int> callback,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateStorageDirectory")]
    int EnumerateStorageDirectory(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path,
        [NativeTypeName("SDL_EnumerateDirectoryCallback")]
            delegate* unmanaged<void*, sbyte*, sbyte*, int> callback,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_Error")]
    int Error(Errorcode code);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EventEnabled")]
    MaybeBool<int> EventEnabled([NativeTypeName("Uint32")] uint type);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EventEnabled")]
    int EventEnabledRaw([NativeTypeName("Uint32")] uint type);

    [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRect")]
    int FillSurfaceRect(
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        [NativeTypeName("Uint32")] uint color
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRect")]
    int FillSurfaceRect(
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        [NativeTypeName("Uint32")] uint color
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRects")]
    int FillSurfaceRects(
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* rects,
        int count,
        [NativeTypeName("Uint32")] uint color
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRects")]
    int FillSurfaceRects(
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rects,
        int count,
        [NativeTypeName("Uint32")] uint color
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_FilterEvents")]
    void FilterEvents(
        [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_FilterEvents")]
    void FilterEvents(
        [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_FlashWindow")]
    int FlashWindow(WindowHandle window, FlashOperation operation);

    [NativeFunction("SDL3", EntryPoint = "SDL_FlipSurface")]
    int FlipSurface(Surface* surface, FlipMode flip);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlipSurface")]
    int FlipSurface(Ref<Surface> surface, FlipMode flip);

    [NativeFunction("SDL3", EntryPoint = "SDL_FlushAudioStream")]
    int FlushAudioStream(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_FlushEvent")]
    void FlushEvent([NativeTypeName("Uint32")] uint type);

    [NativeFunction("SDL3", EntryPoint = "SDL_FlushEvents")]
    void FlushEvents(
        [NativeTypeName("Uint32")] uint minType,
        [NativeTypeName("Uint32")] uint maxType
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_FlushRenderer")]
    int FlushRenderer(RendererHandle renderer);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadConnected")]
    MaybeBool<int> GamepadConnected(GamepadHandle gamepad);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadConnected")]
    int GamepadConnectedRaw(GamepadHandle gamepad);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadEventsEnabled")]
    MaybeBool<int> GamepadEventsEnabled();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadEventsEnabled")]
    int GamepadEventsEnabledRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasAxis")]
    MaybeBool<int> GamepadHasAxis(GamepadHandle gamepad, GamepadAxis axis);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasAxis")]
    int GamepadHasAxisRaw(GamepadHandle gamepad, GamepadAxis axis);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasButton")]
    MaybeBool<int> GamepadHasButton(GamepadHandle gamepad, GamepadButton button);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasButton")]
    int GamepadHasButtonRaw(GamepadHandle gamepad, GamepadButton button);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasSensor")]
    MaybeBool<int> GamepadHasSensor(GamepadHandle gamepad, SensorType type);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasSensor")]
    int GamepadHasSensorRaw(GamepadHandle gamepad, SensorType type);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadSensorEnabled")]
    MaybeBool<int> GamepadSensorEnabled(GamepadHandle gamepad, SensorType type);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadSensorEnabled")]
    int GamepadSensorEnabledRaw(GamepadHandle gamepad, SensorType type);

    [return: NativeTypeName("SDL_AssertionHandler")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionHandler")]
    delegate* unmanaged<AssertData*, void*, AssertState> GetAssertionHandler(void** puserdata);

    [return: NativeTypeName("SDL_AssertionHandler")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionHandler")]
    delegate* unmanaged<AssertData*, void*, AssertState> GetAssertionHandler(Ref2D puserdata);

    [return: NativeTypeName("const SDL_AssertData *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionReport")]
    Ptr<AssertData> GetAssertionReport();

    [return: NativeTypeName("const SDL_AssertData *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionReport")]
    AssertData* GetAssertionReportRaw();

    [return: NativeTypeName("SDL_AudioDeviceID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioCaptureDevices")]
    uint* GetAudioCaptureDevices(int* count);

    [return: NativeTypeName("SDL_AudioDeviceID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioCaptureDevices")]
    Ptr<uint> GetAudioCaptureDevices(Ref<int> count);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceFormat")]
    int GetAudioDeviceFormat(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        AudioSpec* spec,
        int* sample_frames
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceFormat")]
    int GetAudioDeviceFormat(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        Ref<AudioSpec> spec,
        Ref<int> sample_frames
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceName")]
    Ptr<sbyte> GetAudioDeviceName([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceName")]
    sbyte* GetAudioDeviceNameRaw([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDriver")]
    Ptr<sbyte> GetAudioDriver(int index);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDriver")]
    sbyte* GetAudioDriverRaw(int index);

    [return: NativeTypeName("SDL_AudioDeviceID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioOutputDevices")]
    uint* GetAudioOutputDevices(int* count);

    [return: NativeTypeName("SDL_AudioDeviceID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioOutputDevices")]
    Ptr<uint> GetAudioOutputDevices(Ref<int> count);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamAvailable")]
    int GetAudioStreamAvailable(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamData")]
    int GetAudioStreamData(AudioStreamHandle stream, void* buf, int len);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamData")]
    int GetAudioStreamData(AudioStreamHandle stream, Ref buf, int len);

    [return: NativeTypeName("SDL_AudioDeviceID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamDevice")]
    uint GetAudioStreamDevice(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFormat")]
    int GetAudioStreamFormat(AudioStreamHandle stream, AudioSpec* src_spec, AudioSpec* dst_spec);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFormat")]
    int GetAudioStreamFormat(
        AudioStreamHandle stream,
        Ref<AudioSpec> src_spec,
        Ref<AudioSpec> dst_spec
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFrequencyRatio")]
    float GetAudioStreamFrequencyRatio(AudioStreamHandle stream);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamProperties")]
    uint GetAudioStreamProperties(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamQueued")]
    int GetAudioStreamQueued(AudioStreamHandle stream);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetBasePath")]
    Ptr<sbyte> GetBasePath();

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetBasePath")]
    sbyte* GetBasePathRaw();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetBooleanProperty")]
    int GetBooleanProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("SDL_bool")] int default_value
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetBooleanProperty")]
    MaybeBool<int> GetBooleanProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("SDL_bool")] MaybeBool<int> default_value
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDeviceName")]
    Ptr<sbyte> GetCameraDeviceName([NativeTypeName("SDL_CameraDeviceID")] uint instance_id);

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDeviceName")]
    sbyte* GetCameraDeviceNameRaw([NativeTypeName("SDL_CameraDeviceID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDevicePosition")]
    CameraPosition GetCameraDevicePosition([NativeTypeName("SDL_CameraDeviceID")] uint instance_id);

    [return: NativeTypeName("SDL_CameraDeviceID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDevices")]
    uint* GetCameraDevices(int* count);

    [return: NativeTypeName("SDL_CameraDeviceID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDevices")]
    Ptr<uint> GetCameraDevices(Ref<int> count);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDeviceSupportedFormats")]
    CameraSpec* GetCameraDeviceSupportedFormats(
        [NativeTypeName("SDL_CameraDeviceID")] uint devid,
        int* count
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDeviceSupportedFormats")]
    Ptr<CameraSpec> GetCameraDeviceSupportedFormats(
        [NativeTypeName("SDL_CameraDeviceID")] uint devid,
        Ref<int> count
    );

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDriver")]
    Ptr<sbyte> GetCameraDriver(int index);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDriver")]
    sbyte* GetCameraDriverRaw(int index);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraFormat")]
    int GetCameraFormat(CameraHandle camera, CameraSpec* spec);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraFormat")]
    int GetCameraFormat(CameraHandle camera, Ref<CameraSpec> spec);

    [return: NativeTypeName("SDL_CameraDeviceID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraInstanceID")]
    uint GetCameraInstanceID(CameraHandle camera);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraPermissionState")]
    int GetCameraPermissionState(CameraHandle camera);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraProperties")]
    uint GetCameraProperties(CameraHandle camera);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardData")]
    void* GetClipboardData(
        [NativeTypeName("const char *")] sbyte* mime_type,
        [NativeTypeName("size_t *")] nuint* size
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardData")]
    Ptr GetClipboardData(
        [NativeTypeName("const char *")] Ref<sbyte> mime_type,
        [NativeTypeName("size_t *")] Ref<nuint> size
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardText")]
    Ptr<sbyte> GetClipboardText();

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardText")]
    sbyte* GetClipboardTextRaw();

    [return: NativeTypeName("const SDL_DisplayMode *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
    DisplayMode* GetClosestFullscreenDisplayMode(
        [NativeTypeName("SDL_DisplayID")] uint displayID,
        int w,
        int h,
        float refresh_rate,
        [NativeTypeName("SDL_bool")] int include_high_density_modes
    );

    [return: NativeTypeName("const SDL_DisplayMode *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
    Ptr<DisplayMode> GetClosestFullscreenDisplayMode(
        [NativeTypeName("SDL_DisplayID")] uint displayID,
        int w,
        int h,
        float refresh_rate,
        [NativeTypeName("SDL_bool")] MaybeBool<int> include_high_density_modes
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCPUCacheLineSize")]
    int GetCPUCacheLineSize();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCPUCount")]
    int GetCPUCount();

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentAudioDriver")]
    Ptr<sbyte> GetCurrentAudioDriver();

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentAudioDriver")]
    sbyte* GetCurrentAudioDriverRaw();

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentCameraDriver")]
    Ptr<sbyte> GetCurrentCameraDriver();

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentCameraDriver")]
    sbyte* GetCurrentCameraDriverRaw();

    [return: NativeTypeName("const SDL_DisplayMode *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDisplayMode")]
    Ptr<DisplayMode> GetCurrentDisplayMode([NativeTypeName("SDL_DisplayID")] uint displayID);

    [return: NativeTypeName("const SDL_DisplayMode *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDisplayMode")]
    DisplayMode* GetCurrentDisplayModeRaw([NativeTypeName("SDL_DisplayID")] uint displayID);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDisplayOrientation")]
    DisplayOrientation GetCurrentDisplayOrientation(
        [NativeTypeName("SDL_DisplayID")] uint displayID
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentRenderOutputSize")]
    int GetCurrentRenderOutputSize(RendererHandle renderer, int* w, int* h);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentRenderOutputSize")]
    int GetCurrentRenderOutputSize(RendererHandle renderer, Ref<int> w, Ref<int> h);

    [return: NativeTypeName("SDL_ThreadID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentThreadID")]
    ulong GetCurrentThreadID();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentTime")]
    int GetCurrentTime([NativeTypeName("SDL_Time *")] long* ticks);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentTime")]
    int GetCurrentTime([NativeTypeName("SDL_Time *")] Ref<long> ticks);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentVideoDriver")]
    Ptr<sbyte> GetCurrentVideoDriver();

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentVideoDriver")]
    sbyte* GetCurrentVideoDriverRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCursor")]
    CursorHandle GetCursor();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetDayOfWeek")]
    int GetDayOfWeek(int year, int month, int day);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetDayOfYear")]
    int GetDayOfYear(int year, int month, int day);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetDaysInMonth")]
    int GetDaysInMonth(int year, int month);

    [return: NativeTypeName("SDL_AssertionHandler")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultAssertionHandler")]
    delegate* unmanaged<AssertData*, void*, AssertState> GetDefaultAssertionHandler();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultCursor")]
    CursorHandle GetDefaultCursor();

    [return: NativeTypeName("const SDL_DisplayMode *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDesktopDisplayMode")]
    Ptr<DisplayMode> GetDesktopDisplayMode([NativeTypeName("SDL_DisplayID")] uint displayID);

    [return: NativeTypeName("const SDL_DisplayMode *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDesktopDisplayMode")]
    DisplayMode* GetDesktopDisplayModeRaw([NativeTypeName("SDL_DisplayID")] uint displayID);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayBounds")]
    int GetDisplayBounds([NativeTypeName("SDL_DisplayID")] uint displayID, Rect* rect);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayBounds")]
    int GetDisplayBounds([NativeTypeName("SDL_DisplayID")] uint displayID, Ref<Rect> rect);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayContentScale")]
    float GetDisplayContentScale([NativeTypeName("SDL_DisplayID")] uint displayID);

    [return: NativeTypeName("SDL_DisplayID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForPoint")]
    uint GetDisplayForPoint([NativeTypeName("const SDL_Point *")] Point* point);

    [return: NativeTypeName("SDL_DisplayID")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForPoint")]
    uint GetDisplayForPoint([NativeTypeName("const SDL_Point *")] Ref<Point> point);

    [return: NativeTypeName("SDL_DisplayID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForRect")]
    uint GetDisplayForRect([NativeTypeName("const SDL_Rect *")] Rect* rect);

    [return: NativeTypeName("SDL_DisplayID")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForRect")]
    uint GetDisplayForRect([NativeTypeName("const SDL_Rect *")] Ref<Rect> rect);

    [return: NativeTypeName("SDL_DisplayID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForWindow")]
    uint GetDisplayForWindow(WindowHandle window);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayName")]
    Ptr<sbyte> GetDisplayName([NativeTypeName("SDL_DisplayID")] uint displayID);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayName")]
    sbyte* GetDisplayNameRaw([NativeTypeName("SDL_DisplayID")] uint displayID);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayProperties")]
    uint GetDisplayProperties([NativeTypeName("SDL_DisplayID")] uint displayID);

    [return: NativeTypeName("SDL_DisplayID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplays")]
    uint* GetDisplays(int* count);

    [return: NativeTypeName("SDL_DisplayID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplays")]
    Ptr<uint> GetDisplays(Ref<int> count);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayUsableBounds")]
    int GetDisplayUsableBounds([NativeTypeName("SDL_DisplayID")] uint displayID, Rect* rect);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayUsableBounds")]
    int GetDisplayUsableBounds([NativeTypeName("SDL_DisplayID")] uint displayID, Ref<Rect> rect);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetError")]
    Ptr<sbyte> GetError();

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetError")]
    sbyte* GetErrorRaw();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEventFilter")]
    int GetEventFilter(
        [NativeTypeName("SDL_EventFilter *")] delegate* unmanaged<void*, Event*, int>* filter,
        void** userdata
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEventFilter")]
    MaybeBool<int> GetEventFilter(
        [NativeTypeName("SDL_EventFilter *")] delegate* unmanaged<void*, Event*, int>* filter,
        Ref2D userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetFloatProperty")]
    float GetFloatProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        float default_value
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetFloatProperty")]
    float GetFloatProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        float default_value
    );

    [return: NativeTypeName("const SDL_DisplayMode **")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetFullscreenDisplayModes")]
    DisplayMode** GetFullscreenDisplayModes(
        [NativeTypeName("SDL_DisplayID")] uint displayID,
        int* count
    );

    [return: NativeTypeName("const SDL_DisplayMode **")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetFullscreenDisplayModes")]
    Ptr2D<DisplayMode> GetFullscreenDisplayModes(
        [NativeTypeName("SDL_DisplayID")] uint displayID,
        Ref<int> count
    );

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis")]
    Ptr<sbyte> GetGamepadAppleSFSymbolsNameForAxis(GamepadHandle gamepad, GamepadAxis axis);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis")]
    sbyte* GetGamepadAppleSFSymbolsNameForAxisRaw(GamepadHandle gamepad, GamepadAxis axis);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton")]
    Ptr<sbyte> GetGamepadAppleSFSymbolsNameForButton(GamepadHandle gamepad, GamepadButton button);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton")]
    sbyte* GetGamepadAppleSFSymbolsNameForButtonRaw(GamepadHandle gamepad, GamepadButton button);

    [return: NativeTypeName("Sint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAxis")]
    short GetGamepadAxis(GamepadHandle gamepad, GamepadAxis axis);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAxisFromString")]
    GamepadAxis GetGamepadAxisFromString([NativeTypeName("const char *")] sbyte* str);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAxisFromString")]
    GamepadAxis GetGamepadAxisFromString([NativeTypeName("const char *")] Ref<sbyte> str);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadBindings")]
    GamepadBinding** GetGamepadBindings(GamepadHandle gamepad, int* count);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadBindings")]
    Ptr2D<GamepadBinding> GetGamepadBindings(GamepadHandle gamepad, Ref<int> count);

    [return: NativeTypeName("Uint8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButton")]
    byte GetGamepadButton(GamepadHandle gamepad, GamepadButton button);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonFromString")]
    GamepadButton GetGamepadButtonFromString([NativeTypeName("const char *")] sbyte* str);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonFromString")]
    GamepadButton GetGamepadButtonFromString([NativeTypeName("const char *")] Ref<sbyte> str);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonLabel")]
    GamepadButtonLabel GetGamepadButtonLabel(GamepadHandle gamepad, GamepadButton button);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonLabelForType")]
    GamepadButtonLabel GetGamepadButtonLabelForType(GamepadType type, GamepadButton button);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadConnectionState")]
    JoystickConnectionState GetGamepadConnectionState(GamepadHandle gamepad);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFirmwareVersion")]
    ushort GetGamepadFirmwareVersion(GamepadHandle gamepad);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFromInstanceID")]
    GamepadHandle GetGamepadFromInstanceID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFromPlayerIndex")]
    GamepadHandle GetGamepadFromPlayerIndex(int player_index);

    [return: NativeTypeName("SDL_JoystickGUID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceGUID")]
    Guid GetGamepadInstanceGuid([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("SDL_JoystickID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceID")]
    uint GetGamepadInstanceID(GamepadHandle gamepad);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceMapping")]
    Ptr<sbyte> GetGamepadInstanceMapping([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceMapping")]
    sbyte* GetGamepadInstanceMappingRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceName")]
    Ptr<sbyte> GetGamepadInstanceName([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceName")]
    sbyte* GetGamepadInstanceNameRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstancePath")]
    Ptr<sbyte> GetGamepadInstancePath([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstancePath")]
    sbyte* GetGamepadInstancePathRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstancePlayerIndex")]
    int GetGamepadInstancePlayerIndex([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceProduct")]
    ushort GetGamepadInstanceProduct([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceProductVersion")]
    ushort GetGamepadInstanceProductVersion([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceType")]
    GamepadType GetGamepadInstanceType([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadInstanceVendor")]
    ushort GetGamepadInstanceVendor([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadJoystick")]
    JoystickHandle GetGamepadJoystick(GamepadHandle gamepad);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMapping")]
    Ptr<sbyte> GetGamepadMapping(GamepadHandle gamepad);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForGUID")]
    Ptr<sbyte> GetGamepadMappingForGuid([NativeTypeName("SDL_JoystickGUID")] Guid guid);

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForGUID")]
    sbyte* GetGamepadMappingForGuidRaw([NativeTypeName("SDL_JoystickGUID")] Guid guid);

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMapping")]
    sbyte* GetGamepadMappingRaw(GamepadHandle gamepad);

    [return: NativeTypeName("char **")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappings")]
    sbyte** GetGamepadMappings(int* count);

    [return: NativeTypeName("char **")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappings")]
    Ptr2D<sbyte> GetGamepadMappings(Ref<int> count);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadName")]
    Ptr<sbyte> GetGamepadName(GamepadHandle gamepad);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadName")]
    sbyte* GetGamepadNameRaw(GamepadHandle gamepad);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPath")]
    Ptr<sbyte> GetGamepadPath(GamepadHandle gamepad);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPath")]
    sbyte* GetGamepadPathRaw(GamepadHandle gamepad);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPlayerIndex")]
    int GetGamepadPlayerIndex(GamepadHandle gamepad);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPowerInfo")]
    PowerState GetGamepadPowerInfo(GamepadHandle gamepad, int* percent);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPowerInfo")]
    PowerState GetGamepadPowerInfo(GamepadHandle gamepad, Ref<int> percent);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProduct")]
    ushort GetGamepadProduct(GamepadHandle gamepad);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProductVersion")]
    ushort GetGamepadProductVersion(GamepadHandle gamepad);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProperties")]
    uint GetGamepadProperties(GamepadHandle gamepad);

    [return: NativeTypeName("SDL_JoystickID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepads")]
    uint* GetGamepads(int* count);

    [return: NativeTypeName("SDL_JoystickID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepads")]
    Ptr<uint> GetGamepads(Ref<int> count);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorData")]
    int GetGamepadSensorData(GamepadHandle gamepad, SensorType type, float* data, int num_values);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorData")]
    int GetGamepadSensorData(
        GamepadHandle gamepad,
        SensorType type,
        Ref<float> data,
        int num_values
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorDataRate")]
    float GetGamepadSensorDataRate(GamepadHandle gamepad, SensorType type);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSerial")]
    Ptr<sbyte> GetGamepadSerial(GamepadHandle gamepad);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSerial")]
    sbyte* GetGamepadSerialRaw(GamepadHandle gamepad);

    [return: NativeTypeName("Uint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSteamHandle")]
    ulong GetGamepadSteamHandle(GamepadHandle gamepad);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForAxis")]
    Ptr<sbyte> GetGamepadStringForAxis(GamepadAxis axis);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForAxis")]
    sbyte* GetGamepadStringForAxisRaw(GamepadAxis axis);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForButton")]
    Ptr<sbyte> GetGamepadStringForButton(GamepadButton button);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForButton")]
    sbyte* GetGamepadStringForButtonRaw(GamepadButton button);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForType")]
    Ptr<sbyte> GetGamepadStringForType(GamepadType type);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForType")]
    sbyte* GetGamepadStringForTypeRaw(GamepadType type);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTouchpadFinger")]
    int GetGamepadTouchpadFinger(
        GamepadHandle gamepad,
        int touchpad,
        int finger,
        [NativeTypeName("Uint8 *")] byte* state,
        float* x,
        float* y,
        float* pressure
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTouchpadFinger")]
    int GetGamepadTouchpadFinger(
        GamepadHandle gamepad,
        int touchpad,
        int finger,
        [NativeTypeName("Uint8 *")] Ref<byte> state,
        Ref<float> x,
        Ref<float> y,
        Ref<float> pressure
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadType")]
    GamepadType GetGamepadType(GamepadHandle gamepad);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTypeFromString")]
    GamepadType GetGamepadTypeFromString([NativeTypeName("const char *")] sbyte* str);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTypeFromString")]
    GamepadType GetGamepadTypeFromString([NativeTypeName("const char *")] Ref<sbyte> str);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadVendor")]
    ushort GetGamepadVendor(GamepadHandle gamepad);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalMouseState")]
    uint GetGlobalMouseState(float* x, float* y);

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalMouseState")]
    uint GetGlobalMouseState(Ref<float> x, Ref<float> y);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalProperties")]
    uint GetGlobalProperties();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGrabbedWindow")]
    WindowHandle GetGrabbedWindow();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticEffectStatus")]
    int GetHapticEffectStatus(HapticHandle haptic, int effect);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticFeatures")]
    uint GetHapticFeatures(HapticHandle haptic);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticFromInstanceID")]
    HapticHandle GetHapticFromInstanceID([NativeTypeName("SDL_HapticID")] uint instance_id);

    [return: NativeTypeName("SDL_HapticID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticInstanceID")]
    uint GetHapticInstanceID(HapticHandle haptic);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticInstanceName")]
    Ptr<sbyte> GetHapticInstanceName([NativeTypeName("SDL_HapticID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticInstanceName")]
    sbyte* GetHapticInstanceNameRaw([NativeTypeName("SDL_HapticID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticName")]
    Ptr<sbyte> GetHapticName(HapticHandle haptic);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticName")]
    sbyte* GetHapticNameRaw(HapticHandle haptic);

    [return: NativeTypeName("SDL_HapticID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHaptics")]
    uint* GetHaptics(int* count);

    [return: NativeTypeName("SDL_HapticID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHaptics")]
    Ptr<uint> GetHaptics(Ref<int> count);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHint")]
    sbyte* GetHint([NativeTypeName("const char *")] sbyte* name);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHint")]
    Ptr<sbyte> GetHint([NativeTypeName("const char *")] Ref<sbyte> name);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHintBoolean")]
    int GetHintBoolean(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("SDL_bool")] int default_value
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHintBoolean")]
    MaybeBool<int> GetHintBoolean(
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("SDL_bool")] MaybeBool<int> default_value
    );

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetIOProperties")]
    uint GetIOProperties(IOStreamHandle context);

    [return: NativeTypeName("Sint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetIOSize")]
    long GetIOSize(IOStreamHandle context);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetIOStatus")]
    IOStatus GetIOStatus(IOStreamHandle context);

    [return: NativeTypeName("Sint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxis")]
    short GetJoystickAxis(JoystickHandle joystick, int axis);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxisInitialState")]
    int GetJoystickAxisInitialState(
        JoystickHandle joystick,
        int axis,
        [NativeTypeName("Sint16 *")] short* state
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxisInitialState")]
    MaybeBool<int> GetJoystickAxisInitialState(
        JoystickHandle joystick,
        int axis,
        [NativeTypeName("Sint16 *")] Ref<short> state
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickBall")]
    int GetJoystickBall(JoystickHandle joystick, int ball, int* dx, int* dy);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickBall")]
    int GetJoystickBall(JoystickHandle joystick, int ball, Ref<int> dx, Ref<int> dy);

    [return: NativeTypeName("Uint8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickButton")]
    byte GetJoystickButton(JoystickHandle joystick, int button);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickConnectionState")]
    JoystickConnectionState GetJoystickConnectionState(JoystickHandle joystick);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFirmwareVersion")]
    ushort GetJoystickFirmwareVersion(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFromInstanceID")]
    JoystickHandle GetJoystickFromInstanceID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFromPlayerIndex")]
    JoystickHandle GetJoystickFromPlayerIndex(int player_index);

    [return: NativeTypeName("SDL_JoystickGUID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUID")]
    Guid GetJoystickGuid(JoystickHandle joystick);

    [return: NativeTypeName("SDL_JoystickGUID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDFromString")]
    Guid GetJoystickGuidFromString([NativeTypeName("const char *")] sbyte* pchGUID);

    [return: NativeTypeName("SDL_JoystickGUID")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDFromString")]
    Guid GetJoystickGuidFromString([NativeTypeName("const char *")] Ref<sbyte> pchGUID);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDInfo")]
    void GetJoystickGuidInfo(
        [NativeTypeName("SDL_JoystickGUID")] Guid guid,
        [NativeTypeName("Uint16 *")] ushort* vendor,
        [NativeTypeName("Uint16 *")] ushort* product,
        [NativeTypeName("Uint16 *")] ushort* version,
        [NativeTypeName("Uint16 *")] ushort* crc16
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDInfo")]
    void GetJoystickGuidInfo(
        [NativeTypeName("SDL_JoystickGUID")] Guid guid,
        [NativeTypeName("Uint16 *")] Ref<ushort> vendor,
        [NativeTypeName("Uint16 *")] Ref<ushort> product,
        [NativeTypeName("Uint16 *")] Ref<ushort> version,
        [NativeTypeName("Uint16 *")] Ref<ushort> crc16
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDString")]
    int GetJoystickGuidString(
        [NativeTypeName("SDL_JoystickGUID")] Guid guid,
        [NativeTypeName("char *")] sbyte* pszGUID,
        int cbGUID
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDString")]
    int GetJoystickGuidString(
        [NativeTypeName("SDL_JoystickGUID")] Guid guid,
        [NativeTypeName("char *")] Ref<sbyte> pszGUID,
        int cbGUID
    );

    [return: NativeTypeName("Uint8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickHat")]
    byte GetJoystickHat(JoystickHandle joystick, int hat);

    [return: NativeTypeName("SDL_JoystickGUID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceGUID")]
    Guid GetJoystickInstanceGuid([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("SDL_JoystickID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceID")]
    uint GetJoystickInstanceID(JoystickHandle joystick);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceName")]
    Ptr<sbyte> GetJoystickInstanceName([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceName")]
    sbyte* GetJoystickInstanceNameRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstancePath")]
    Ptr<sbyte> GetJoystickInstancePath([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstancePath")]
    sbyte* GetJoystickInstancePathRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstancePlayerIndex")]
    int GetJoystickInstancePlayerIndex([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceProduct")]
    ushort GetJoystickInstanceProduct([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceProductVersion")]
    ushort GetJoystickInstanceProductVersion([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceType")]
    JoystickType GetJoystickInstanceType([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickInstanceVendor")]
    ushort GetJoystickInstanceVendor([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickName")]
    Ptr<sbyte> GetJoystickName(JoystickHandle joystick);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickName")]
    sbyte* GetJoystickNameRaw(JoystickHandle joystick);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPath")]
    Ptr<sbyte> GetJoystickPath(JoystickHandle joystick);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPath")]
    sbyte* GetJoystickPathRaw(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPlayerIndex")]
    int GetJoystickPlayerIndex(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPowerInfo")]
    PowerState GetJoystickPowerInfo(JoystickHandle joystick, int* percent);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPowerInfo")]
    PowerState GetJoystickPowerInfo(JoystickHandle joystick, Ref<int> percent);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProduct")]
    ushort GetJoystickProduct(JoystickHandle joystick);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProductVersion")]
    ushort GetJoystickProductVersion(JoystickHandle joystick);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProperties")]
    uint GetJoystickProperties(JoystickHandle joystick);

    [return: NativeTypeName("SDL_JoystickID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoysticks")]
    uint* GetJoysticks(int* count);

    [return: NativeTypeName("SDL_JoystickID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoysticks")]
    Ptr<uint> GetJoysticks(Ref<int> count);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickSerial")]
    Ptr<sbyte> GetJoystickSerial(JoystickHandle joystick);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickSerial")]
    sbyte* GetJoystickSerialRaw(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickType")]
    JoystickType GetJoystickType(JoystickHandle joystick);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickVendor")]
    ushort GetJoystickVendor(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardFocus")]
    WindowHandle GetKeyboardFocus();

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardInstanceName")]
    Ptr<sbyte> GetKeyboardInstanceName([NativeTypeName("SDL_KeyboardID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardInstanceName")]
    sbyte* GetKeyboardInstanceNameRaw([NativeTypeName("SDL_KeyboardID")] uint instance_id);

    [return: NativeTypeName("SDL_KeyboardID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboards")]
    uint* GetKeyboards(int* count);

    [return: NativeTypeName("SDL_KeyboardID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboards")]
    Ptr<uint> GetKeyboards(Ref<int> count);

    [return: NativeTypeName("const Uint8 *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardState")]
    byte* GetKeyboardState(int* numkeys);

    [return: NativeTypeName("const Uint8 *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardState")]
    Ptr<byte> GetKeyboardState(Ref<int> numkeys);

    [return: NativeTypeName("SDL_Keycode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromName")]
    int GetKeyFromName([NativeTypeName("const char *")] sbyte* name);

    [return: NativeTypeName("SDL_Keycode")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromName")]
    int GetKeyFromName([NativeTypeName("const char *")] Ref<sbyte> name);

    [return: NativeTypeName("SDL_Keycode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromScancode")]
    int GetKeyFromScancode(Scancode scancode);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyName")]
    Ptr<sbyte> GetKeyName([NativeTypeName("SDL_Keycode")] int key);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyName")]
    sbyte* GetKeyNameRaw([NativeTypeName("SDL_Keycode")] int key);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetLogOutputFunction")]
    void GetLogOutputFunction(
        [NativeTypeName("SDL_LogOutputFunction *")]
            delegate* unmanaged<void*, int, LogPriority, sbyte*, void>* callback,
        void** userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetLogOutputFunction")]
    void GetLogOutputFunction(
        [NativeTypeName("SDL_LogOutputFunction *")]
            delegate* unmanaged<void*, int, LogPriority, sbyte*, void>* callback,
        Ref2D userdata
    );

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMasksForPixelFormatEnum")]
    int GetMasksForPixelFormatEnum(
        PixelFormatEnum format,
        int* bpp,
        [NativeTypeName("Uint32 *")] uint* Rmask,
        [NativeTypeName("Uint32 *")] uint* Gmask,
        [NativeTypeName("Uint32 *")] uint* Bmask,
        [NativeTypeName("Uint32 *")] uint* Amask
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMasksForPixelFormatEnum")]
    MaybeBool<int> GetMasksForPixelFormatEnum(
        PixelFormatEnum format,
        Ref<int> bpp,
        [NativeTypeName("Uint32 *")] Ref<uint> Rmask,
        [NativeTypeName("Uint32 *")] Ref<uint> Gmask,
        [NativeTypeName("Uint32 *")] Ref<uint> Bmask,
        [NativeTypeName("Uint32 *")] Ref<uint> Amask
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetMaxHapticEffects")]
    int GetMaxHapticEffects(HapticHandle haptic);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetMaxHapticEffectsPlaying")]
    int GetMaxHapticEffectsPlaying(HapticHandle haptic);

    [return: NativeTypeName("SDL_MouseID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMice")]
    uint* GetMice(int* count);

    [return: NativeTypeName("SDL_MouseID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMice")]
    Ptr<uint> GetMice(Ref<int> count);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetModState")]
    Keymod GetModState();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseFocus")]
    WindowHandle GetMouseFocus();

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseInstanceName")]
    Ptr<sbyte> GetMouseInstanceName([NativeTypeName("SDL_MouseID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseInstanceName")]
    sbyte* GetMouseInstanceNameRaw([NativeTypeName("SDL_MouseID")] uint instance_id);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseState")]
    uint GetMouseState(float* x, float* y);

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseState")]
    uint GetMouseState(Ref<float> x, Ref<float> y);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNaturalDisplayOrientation")]
    DisplayOrientation GetNaturalDisplayOrientation(
        [NativeTypeName("SDL_DisplayID")] uint displayID
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumAudioDrivers")]
    int GetNumAudioDrivers();

    [return: NativeTypeName("Sint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumberProperty")]
    long GetNumberProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("Sint64")] long default_value
    );

    [return: NativeTypeName("Sint64")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumberProperty")]
    long GetNumberProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("Sint64")] long default_value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumCameraDrivers")]
    int GetNumCameraDrivers();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGamepadTouchpadFingers")]
    int GetNumGamepadTouchpadFingers(GamepadHandle gamepad, int touchpad);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGamepadTouchpads")]
    int GetNumGamepadTouchpads(GamepadHandle gamepad);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumHapticAxes")]
    int GetNumHapticAxes(HapticHandle haptic);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickAxes")]
    int GetNumJoystickAxes(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickBalls")]
    int GetNumJoystickBalls(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickButtons")]
    int GetNumJoystickButtons(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickHats")]
    int GetNumJoystickHats(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumRenderDrivers")]
    int GetNumRenderDrivers();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumVideoDrivers")]
    int GetNumVideoDrivers();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetPathInfo")]
    int GetPathInfo([NativeTypeName("const char *")] sbyte* path, PathInfo* info);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPathInfo")]
    int GetPathInfo([NativeTypeName("const char *")] Ref<sbyte> path, Ref<PathInfo> info);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPenCapabilities")]
    uint GetPenCapabilities(
        [NativeTypeName("SDL_PenID")] uint instance_id,
        PenCapabilityInfo* capabilities
    );

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPenCapabilities")]
    uint GetPenCapabilities(
        [NativeTypeName("SDL_PenID")] uint instance_id,
        Ref<PenCapabilityInfo> capabilities
    );

    [return: NativeTypeName("SDL_PenID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPenFromGUID")]
    uint GetPenFromGuid(Guid guid);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetPenGUID")]
    Guid GetPenGuid([NativeTypeName("SDL_PenID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPenName")]
    Ptr<sbyte> GetPenName([NativeTypeName("SDL_PenID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPenName")]
    sbyte* GetPenNameRaw([NativeTypeName("SDL_PenID")] uint instance_id);

    [return: NativeTypeName("SDL_PenID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPens")]
    uint* GetPens(int* count);

    [return: NativeTypeName("SDL_PenID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPens")]
    Ptr<uint> GetPens(Ref<int> count);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPenStatus")]
    uint GetPenStatus(
        [NativeTypeName("SDL_PenID")] uint instance_id,
        float* x,
        float* y,
        float* axes,
        [NativeTypeName("size_t")] nuint num_axes
    );

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPenStatus")]
    uint GetPenStatus(
        [NativeTypeName("SDL_PenID")] uint instance_id,
        Ref<float> x,
        Ref<float> y,
        Ref<float> axes,
        [NativeTypeName("size_t")] nuint num_axes
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetPenType")]
    PenSubtype GetPenType([NativeTypeName("SDL_PenID")] uint instance_id);

    [return: NativeTypeName("Uint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPerformanceCounter")]
    ulong GetPerformanceCounter();

    [return: NativeTypeName("Uint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPerformanceFrequency")]
    ulong GetPerformanceFrequency();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatEnumForMasks")]
    PixelFormatEnum GetPixelFormatEnumForMasks(
        int bpp,
        [NativeTypeName("Uint32")] uint Rmask,
        [NativeTypeName("Uint32")] uint Gmask,
        [NativeTypeName("Uint32")] uint Bmask,
        [NativeTypeName("Uint32")] uint Amask
    );

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatName")]
    Ptr<sbyte> GetPixelFormatName(PixelFormatEnum format);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatName")]
    sbyte* GetPixelFormatNameRaw(PixelFormatEnum format);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPlatform")]
    Ptr<sbyte> GetPlatform();

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPlatform")]
    sbyte* GetPlatformRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetPowerInfo")]
    PowerState GetPowerInfo(int* seconds, int* percent);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPowerInfo")]
    PowerState GetPowerInfo(Ref<int> seconds, Ref<int> percent);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPreferredLocales")]
    Ptr<Locale> GetPreferredLocales();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetPreferredLocales")]
    Locale* GetPreferredLocalesRaw();

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPrefPath")]
    sbyte* GetPrefPath(
        [NativeTypeName("const char *")] sbyte* org,
        [NativeTypeName("const char *")] sbyte* app
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPrefPath")]
    Ptr<sbyte> GetPrefPath(
        [NativeTypeName("const char *")] Ref<sbyte> org,
        [NativeTypeName("const char *")] Ref<sbyte> app
    );

    [return: NativeTypeName("SDL_DisplayID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPrimaryDisplay")]
    uint GetPrimaryDisplay();

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPrimarySelectionText")]
    Ptr<sbyte> GetPrimarySelectionText();

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPrimarySelectionText")]
    sbyte* GetPrimarySelectionTextRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetProperty")]
    void* GetProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        void* default_value
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetProperty")]
    Ptr GetProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        Ref default_value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetPropertyType")]
    PropertyType GetPropertyType(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPropertyType")]
    PropertyType GetPropertyType(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRealGamepadInstanceType")]
    GamepadType GetRealGamepadInstanceType([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRealGamepadType")]
    GamepadType GetRealGamepadType(GamepadHandle gamepad);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersection")]
    int GetRectAndLineIntersection(
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        int* X1,
        int* Y1,
        int* X2,
        int* Y2
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersection")]
    MaybeBool<int> GetRectAndLineIntersection(
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        Ref<int> X1,
        Ref<int> Y1,
        Ref<int> X2,
        Ref<int> Y2
    );

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersectionFloat")]
    int GetRectAndLineIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] FRect* rect,
        float* X1,
        float* Y1,
        float* X2,
        float* Y2
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersectionFloat")]
    MaybeBool<int> GetRectAndLineIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> rect,
        Ref<float> X1,
        Ref<float> Y1,
        Ref<float> X2,
        Ref<float> Y2
    );

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPoints")]
    int GetRectEnclosingPoints(
        [NativeTypeName("const SDL_Point *")] Point* points,
        int count,
        [NativeTypeName("const SDL_Rect *")] Rect* clip,
        Rect* result
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPoints")]
    MaybeBool<int> GetRectEnclosingPoints(
        [NativeTypeName("const SDL_Point *")] Ref<Point> points,
        int count,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> clip,
        Ref<Rect> result
    );

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
    int GetRectEnclosingPointsFloat(
        [NativeTypeName("const SDL_FPoint *")] FPoint* points,
        int count,
        [NativeTypeName("const SDL_FRect *")] FRect* clip,
        FRect* result
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
    MaybeBool<int> GetRectEnclosingPointsFloat(
        [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> points,
        int count,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> clip,
        Ref<FRect> result
    );

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersection")]
    int GetRectIntersection(
        [NativeTypeName("const SDL_Rect *")] Rect* A,
        [NativeTypeName("const SDL_Rect *")] Rect* B,
        Rect* result
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersection")]
    MaybeBool<int> GetRectIntersection(
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> A,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> B,
        Ref<Rect> result
    );

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersectionFloat")]
    int GetRectIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] FRect* A,
        [NativeTypeName("const SDL_FRect *")] FRect* B,
        FRect* result
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersectionFloat")]
    MaybeBool<int> GetRectIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> A,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> B,
        Ref<FRect> result
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnion")]
    int GetRectUnion(
        [NativeTypeName("const SDL_Rect *")] Rect* A,
        [NativeTypeName("const SDL_Rect *")] Rect* B,
        Rect* result
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnion")]
    int GetRectUnion(
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> A,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> B,
        Ref<Rect> result
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnionFloat")]
    int GetRectUnionFloat(
        [NativeTypeName("const SDL_FRect *")] FRect* A,
        [NativeTypeName("const SDL_FRect *")] FRect* B,
        FRect* result
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnionFloat")]
    int GetRectUnionFloat(
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> A,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> B,
        Ref<FRect> result
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseMode")]
    MaybeBool<int> GetRelativeMouseMode();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseMode")]
    int GetRelativeMouseModeRaw();

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseState")]
    uint GetRelativeMouseState(float* x, float* y);

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseState")]
    uint GetRelativeMouseState(Ref<float> x, Ref<float> y);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderClipRect")]
    int GetRenderClipRect(RendererHandle renderer, Rect* rect);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderClipRect")]
    int GetRenderClipRect(RendererHandle renderer, Ref<Rect> rect);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderColorScale")]
    int GetRenderColorScale(RendererHandle renderer, float* scale);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderColorScale")]
    int GetRenderColorScale(RendererHandle renderer, Ref<float> scale);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawBlendMode")]
    int GetRenderDrawBlendMode(RendererHandle renderer, BlendMode* blendMode);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawBlendMode")]
    int GetRenderDrawBlendMode(RendererHandle renderer, Ref<BlendMode> blendMode);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColor")]
    int GetRenderDrawColor(
        RendererHandle renderer,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b,
        [NativeTypeName("Uint8 *")] byte* a
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColor")]
    int GetRenderDrawColor(
        RendererHandle renderer,
        [NativeTypeName("Uint8 *")] Ref<byte> r,
        [NativeTypeName("Uint8 *")] Ref<byte> g,
        [NativeTypeName("Uint8 *")] Ref<byte> b,
        [NativeTypeName("Uint8 *")] Ref<byte> a
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColorFloat")]
    int GetRenderDrawColorFloat(RendererHandle renderer, float* r, float* g, float* b, float* a);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColorFloat")]
    int GetRenderDrawColorFloat(
        RendererHandle renderer,
        Ref<float> r,
        Ref<float> g,
        Ref<float> b,
        Ref<float> a
    );

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDriver")]
    Ptr<sbyte> GetRenderDriver(int index);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDriver")]
    sbyte* GetRenderDriverRaw(int index);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderer")]
    RendererHandle GetRenderer(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererFromTexture")]
    RendererHandle GetRendererFromTexture(TextureHandle texture);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererInfo")]
    int GetRendererInfo(RendererHandle renderer, RendererInfo* info);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererInfo")]
    int GetRendererInfo(RendererHandle renderer, Ref<RendererInfo> info);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererProperties")]
    uint GetRendererProperties(RendererHandle renderer);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentation")]
    int GetRenderLogicalPresentation(
        RendererHandle renderer,
        int* w,
        int* h,
        RendererLogicalPresentation* mode,
        ScaleMode* scale_mode
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentation")]
    int GetRenderLogicalPresentation(
        RendererHandle renderer,
        Ref<int> w,
        Ref<int> h,
        Ref<RendererLogicalPresentation> mode,
        Ref<ScaleMode> scale_mode
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalCommandEncoder")]
    Ptr GetRenderMetalCommandEncoder(RendererHandle renderer);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalCommandEncoder")]
    void* GetRenderMetalCommandEncoderRaw(RendererHandle renderer);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalLayer")]
    Ptr GetRenderMetalLayer(RendererHandle renderer);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalLayer")]
    void* GetRenderMetalLayerRaw(RendererHandle renderer);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderOutputSize")]
    int GetRenderOutputSize(RendererHandle renderer, int* w, int* h);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderOutputSize")]
    int GetRenderOutputSize(RendererHandle renderer, Ref<int> w, Ref<int> h);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderScale")]
    int GetRenderScale(RendererHandle renderer, float* scaleX, float* scaleY);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderScale")]
    int GetRenderScale(RendererHandle renderer, Ref<float> scaleX, Ref<float> scaleY);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderTarget")]
    TextureHandle GetRenderTarget(RendererHandle renderer);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderViewport")]
    int GetRenderViewport(RendererHandle renderer, Rect* rect);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderViewport")]
    int GetRenderViewport(RendererHandle renderer, Ref<Rect> rect);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderVSync")]
    int GetRenderVSync(RendererHandle renderer, int* vsync);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderVSync")]
    int GetRenderVSync(RendererHandle renderer, Ref<int> vsync);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderWindow")]
    WindowHandle GetRenderWindow(RendererHandle renderer);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRevision")]
    Ptr<sbyte> GetRevision();

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRevision")]
    sbyte* GetRevisionRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRGB")]
    void GetRGB(
        [NativeTypeName("Uint32")] uint pixel,
        [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRGB")]
    void GetRGB(
        [NativeTypeName("Uint32")] uint pixel,
        [NativeTypeName("const SDL_PixelFormat *")] Ref<PixelFormat> format,
        [NativeTypeName("Uint8 *")] Ref<byte> r,
        [NativeTypeName("Uint8 *")] Ref<byte> g,
        [NativeTypeName("Uint8 *")] Ref<byte> b
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRGBA")]
    void GetRgba(
        [NativeTypeName("Uint32")] uint pixel,
        [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b,
        [NativeTypeName("Uint8 *")] byte* a
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRGBA")]
    void GetRgba(
        [NativeTypeName("Uint32")] uint pixel,
        [NativeTypeName("const SDL_PixelFormat *")] Ref<PixelFormat> format,
        [NativeTypeName("Uint8 *")] Ref<byte> r,
        [NativeTypeName("Uint8 *")] Ref<byte> g,
        [NativeTypeName("Uint8 *")] Ref<byte> b,
        [NativeTypeName("Uint8 *")] Ref<byte> a
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromKey")]
    Scancode GetScancodeFromKey([NativeTypeName("SDL_Keycode")] int key);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromName")]
    Scancode GetScancodeFromName([NativeTypeName("const char *")] sbyte* name);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromName")]
    Scancode GetScancodeFromName([NativeTypeName("const char *")] Ref<sbyte> name);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeName")]
    Ptr<sbyte> GetScancodeName(Scancode scancode);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeName")]
    sbyte* GetScancodeNameRaw(Scancode scancode);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSemaphoreValue")]
    uint GetSemaphoreValue(SemaphoreHandle sem);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorData")]
    int GetSensorData(SensorHandle sensor, float* data, int num_values);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorData")]
    int GetSensorData(SensorHandle sensor, Ref<float> data, int num_values);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorFromInstanceID")]
    SensorHandle GetSensorFromInstanceID([NativeTypeName("SDL_SensorID")] uint instance_id);

    [return: NativeTypeName("SDL_SensorID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorInstanceID")]
    uint GetSensorInstanceID(SensorHandle sensor);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorInstanceName")]
    Ptr<sbyte> GetSensorInstanceName([NativeTypeName("SDL_SensorID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorInstanceName")]
    sbyte* GetSensorInstanceNameRaw([NativeTypeName("SDL_SensorID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorInstanceNonPortableType")]
    int GetSensorInstanceNonPortableType([NativeTypeName("SDL_SensorID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorInstanceType")]
    SensorType GetSensorInstanceType([NativeTypeName("SDL_SensorID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorName")]
    Ptr<sbyte> GetSensorName(SensorHandle sensor);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorName")]
    sbyte* GetSensorNameRaw(SensorHandle sensor);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNonPortableType")]
    int GetSensorNonPortableType(SensorHandle sensor);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorProperties")]
    uint GetSensorProperties(SensorHandle sensor);

    [return: NativeTypeName("SDL_SensorID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensors")]
    uint* GetSensors(int* count);

    [return: NativeTypeName("SDL_SensorID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensors")]
    Ptr<uint> GetSensors(Ref<int> count);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorType")]
    SensorType GetSensorType(SensorHandle sensor);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSilenceValueForFormat")]
    int GetSilenceValueForFormat([NativeTypeName("SDL_AudioFormat")] ushort format);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageFileSize")]
    int GetStorageFileSize(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("Uint64 *")] ulong* length
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageFileSize")]
    int GetStorageFileSize(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path,
        [NativeTypeName("Uint64 *")] Ref<ulong> length
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetStoragePathInfo")]
    int GetStoragePathInfo(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* path,
        PathInfo* info
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStoragePathInfo")]
    int GetStoragePathInfo(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path,
        Ref<PathInfo> info
    );

    [return: NativeTypeName("Uint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageSpaceRemaining")]
    ulong GetStorageSpaceRemaining(StorageHandle storage);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStringProperty")]
    sbyte* GetStringProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const char *")] sbyte* default_value
    );

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStringProperty")]
    Ptr<sbyte> GetStringProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("const char *")] Ref<sbyte> default_value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceAlphaMod")]
    int GetSurfaceAlphaMod(Surface* surface, [NativeTypeName("Uint8 *")] byte* alpha);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceAlphaMod")]
    int GetSurfaceAlphaMod(Ref<Surface> surface, [NativeTypeName("Uint8 *")] Ref<byte> alpha);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceBlendMode")]
    int GetSurfaceBlendMode(Surface* surface, BlendMode* blendMode);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceBlendMode")]
    int GetSurfaceBlendMode(Ref<Surface> surface, Ref<BlendMode> blendMode);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceClipRect")]
    int GetSurfaceClipRect(Surface* surface, Rect* rect);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceClipRect")]
    int GetSurfaceClipRect(Ref<Surface> surface, Ref<Rect> rect);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorKey")]
    int GetSurfaceColorKey(Surface* surface, [NativeTypeName("Uint32 *")] uint* key);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorKey")]
    int GetSurfaceColorKey(Ref<Surface> surface, [NativeTypeName("Uint32 *")] Ref<uint> key);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorMod")]
    int GetSurfaceColorMod(
        Surface* surface,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorMod")]
    int GetSurfaceColorMod(
        Ref<Surface> surface,
        [NativeTypeName("Uint8 *")] Ref<byte> r,
        [NativeTypeName("Uint8 *")] Ref<byte> g,
        [NativeTypeName("Uint8 *")] Ref<byte> b
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorspace")]
    int GetSurfaceColorspace(Surface* surface, Colorspace* colorspace);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorspace")]
    int GetSurfaceColorspace(Ref<Surface> surface, Ref<Colorspace> colorspace);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceProperties")]
    uint GetSurfaceProperties(Surface* surface);

    [return: NativeTypeName("SDL_PropertiesID")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceProperties")]
    uint GetSurfaceProperties(Ref<Surface> surface);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSystemRAM")]
    int GetSystemRAM();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSystemTheme")]
    SystemTheme GetSystemTheme();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaMod")]
    int GetTextureAlphaMod(TextureHandle texture, [NativeTypeName("Uint8 *")] byte* alpha);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaMod")]
    int GetTextureAlphaMod(TextureHandle texture, [NativeTypeName("Uint8 *")] Ref<byte> alpha);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaModFloat")]
    int GetTextureAlphaModFloat(TextureHandle texture, float* alpha);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaModFloat")]
    int GetTextureAlphaModFloat(TextureHandle texture, Ref<float> alpha);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureBlendMode")]
    int GetTextureBlendMode(TextureHandle texture, BlendMode* blendMode);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureBlendMode")]
    int GetTextureBlendMode(TextureHandle texture, Ref<BlendMode> blendMode);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorMod")]
    int GetTextureColorMod(
        TextureHandle texture,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorMod")]
    int GetTextureColorMod(
        TextureHandle texture,
        [NativeTypeName("Uint8 *")] Ref<byte> r,
        [NativeTypeName("Uint8 *")] Ref<byte> g,
        [NativeTypeName("Uint8 *")] Ref<byte> b
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorModFloat")]
    int GetTextureColorModFloat(TextureHandle texture, float* r, float* g, float* b);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorModFloat")]
    int GetTextureColorModFloat(TextureHandle texture, Ref<float> r, Ref<float> g, Ref<float> b);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureProperties")]
    uint GetTextureProperties(TextureHandle texture);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureScaleMode")]
    int GetTextureScaleMode(TextureHandle texture, ScaleMode* scaleMode);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureScaleMode")]
    int GetTextureScaleMode(TextureHandle texture, Ref<ScaleMode> scaleMode);

    [return: NativeTypeName("SDL_ThreadID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadID")]
    ulong GetThreadID(ThreadHandle thread);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadName")]
    Ptr<sbyte> GetThreadName(ThreadHandle thread);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadName")]
    sbyte* GetThreadNameRaw(ThreadHandle thread);

    [return: NativeTypeName("Uint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTicks")]
    ulong GetTicks();

    [return: NativeTypeName("Uint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTicksNS")]
    ulong GetTicksNS();

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTLS")]
    Ptr GetTLS([NativeTypeName("SDL_TLSID")] uint id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetTLS")]
    void* GetTLSRaw([NativeTypeName("SDL_TLSID")] uint id);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceName")]
    Ptr<sbyte> GetTouchDeviceName([NativeTypeName("SDL_TouchID")] ulong touchID);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceName")]
    sbyte* GetTouchDeviceNameRaw([NativeTypeName("SDL_TouchID")] ulong touchID);

    [return: NativeTypeName("SDL_TouchID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDevices")]
    ulong* GetTouchDevices(int* count);

    [return: NativeTypeName("SDL_TouchID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDevices")]
    Ptr<ulong> GetTouchDevices(Ref<int> count);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceType")]
    TouchDeviceType GetTouchDeviceType([NativeTypeName("SDL_TouchID")] ulong touchID);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchFingers")]
    Finger** GetTouchFingers([NativeTypeName("SDL_TouchID")] ulong touchID, int* count);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchFingers")]
    Ptr2D<Finger> GetTouchFingers([NativeTypeName("SDL_TouchID")] ulong touchID, Ref<int> count);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetUserFolder")]
    Ptr<sbyte> GetUserFolder(Folder folder);

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetUserFolder")]
    sbyte* GetUserFolderRaw(Folder folder);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetVersion")]
    int GetVersion(Version* ver);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetVersion")]
    int GetVersion(Ref<Version> ver);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetVideoDriver")]
    Ptr<sbyte> GetVideoDriver(int index);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetVideoDriver")]
    sbyte* GetVideoDriverRaw(int index);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowBordersSize")]
    int GetWindowBordersSize(WindowHandle window, int* top, int* left, int* bottom, int* right);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowBordersSize")]
    int GetWindowBordersSize(
        WindowHandle window,
        Ref<int> top,
        Ref<int> left,
        Ref<int> bottom,
        Ref<int> right
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowDisplayScale")]
    float GetWindowDisplayScale(WindowHandle window);

    [return: NativeTypeName("SDL_WindowFlags")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFlags")]
    uint GetWindowFlags(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFromID")]
    WindowHandle GetWindowFromID([NativeTypeName("SDL_WindowID")] uint id);

    [return: NativeTypeName("const SDL_DisplayMode *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFullscreenMode")]
    Ptr<DisplayMode> GetWindowFullscreenMode(WindowHandle window);

    [return: NativeTypeName("const SDL_DisplayMode *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFullscreenMode")]
    DisplayMode* GetWindowFullscreenModeRaw(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowICCProfile")]
    void* GetWindowICCProfile(WindowHandle window, [NativeTypeName("size_t *")] nuint* size);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowICCProfile")]
    Ptr GetWindowICCProfile(WindowHandle window, [NativeTypeName("size_t *")] Ref<nuint> size);

    [return: NativeTypeName("SDL_WindowID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowID")]
    uint GetWindowID(WindowHandle window);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowKeyboardGrab")]
    MaybeBool<int> GetWindowKeyboardGrab(WindowHandle window);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowKeyboardGrab")]
    int GetWindowKeyboardGrabRaw(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMaximumSize")]
    int GetWindowMaximumSize(WindowHandle window, int* w, int* h);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMaximumSize")]
    int GetWindowMaximumSize(WindowHandle window, Ref<int> w, Ref<int> h);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMinimumSize")]
    int GetWindowMinimumSize(WindowHandle window, int* w, int* h);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMinimumSize")]
    int GetWindowMinimumSize(WindowHandle window, Ref<int> w, Ref<int> h);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseGrab")]
    MaybeBool<int> GetWindowMouseGrab(WindowHandle window);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseGrab")]
    int GetWindowMouseGrabRaw(WindowHandle window);

    [return: NativeTypeName("const SDL_Rect *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseRect")]
    Ptr<Rect> GetWindowMouseRect(WindowHandle window);

    [return: NativeTypeName("const SDL_Rect *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseRect")]
    Rect* GetWindowMouseRectRaw(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowOpacity")]
    int GetWindowOpacity(WindowHandle window, float* out_opacity);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowOpacity")]
    int GetWindowOpacity(WindowHandle window, Ref<float> out_opacity);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowParent")]
    WindowHandle GetWindowParent(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPixelDensity")]
    float GetWindowPixelDensity(WindowHandle window);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPixelFormat")]
    uint GetWindowPixelFormat(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPosition")]
    int GetWindowPosition(WindowHandle window, int* x, int* y);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPosition")]
    int GetWindowPosition(WindowHandle window, Ref<int> x, Ref<int> y);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowProperties")]
    uint GetWindowProperties(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSize")]
    int GetWindowSize(WindowHandle window, int* w, int* h);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSize")]
    int GetWindowSize(WindowHandle window, Ref<int> w, Ref<int> h);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSizeInPixels")]
    int GetWindowSizeInPixels(WindowHandle window, int* w, int* h);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSizeInPixels")]
    int GetWindowSizeInPixels(WindowHandle window, Ref<int> w, Ref<int> h);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurface")]
    Ptr<Surface> GetWindowSurface(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurface")]
    Surface* GetWindowSurfaceRaw(WindowHandle window);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowTitle")]
    Ptr<sbyte> GetWindowTitle(WindowHandle window);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowTitle")]
    sbyte* GetWindowTitleRaw(WindowHandle window);

    [return: NativeTypeName("SDL_GLContext")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_CreateContext")]
    Ptr GLCreateContext(WindowHandle window);

    [return: NativeTypeName("SDL_GLContext")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_CreateContext")]
    void* GLCreateContextRaw(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GL_DeleteContext")]
    int GLDeleteContext([NativeTypeName("SDL_GLContext")] void* context);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_DeleteContext")]
    int GLDeleteContext([NativeTypeName("SDL_GLContext")] Ref context);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_ExtensionSupported")]
    int GLExtensionSupported([NativeTypeName("const char *")] sbyte* extension);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_ExtensionSupported")]
    MaybeBool<int> GLExtensionSupported([NativeTypeName("const char *")] Ref<sbyte> extension);

    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetAttribute")]
    int GLGetAttribute(GLattr attr, int* value);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetAttribute")]
    int GLGetAttribute(GLattr attr, Ref<int> value);

    [return: NativeTypeName("SDL_GLContext")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetCurrentContext")]
    Ptr GLGetCurrentContext();

    [return: NativeTypeName("SDL_GLContext")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetCurrentContext")]
    void* GLGetCurrentContextRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetCurrentWindow")]
    WindowHandle GLGetCurrentWindow();

    [return: NativeTypeName("SDL_FunctionPointer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetProcAddress")]
    delegate* unmanaged<void> GLGetProcAddress([NativeTypeName("const char *")] sbyte* proc);

    [return: NativeTypeName("SDL_FunctionPointer")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetProcAddress")]
    delegate* unmanaged<void> GLGetProcAddress([NativeTypeName("const char *")] Ref<sbyte> proc);

    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetSwapInterval")]
    int GLGetSwapInterval(int* interval);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetSwapInterval")]
    int GLGetSwapInterval(Ref<int> interval);

    [NativeFunction("SDL3", EntryPoint = "SDL_GL_LoadLibrary")]
    int GLLoadLibrary([NativeTypeName("const char *")] sbyte* path);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_LoadLibrary")]
    int GLLoadLibrary([NativeTypeName("const char *")] Ref<sbyte> path);

    [NativeFunction("SDL3", EntryPoint = "SDL_GL_MakeCurrent")]
    int GLMakeCurrent(WindowHandle window, [NativeTypeName("SDL_GLContext")] void* context);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_MakeCurrent")]
    int GLMakeCurrent(WindowHandle window, [NativeTypeName("SDL_GLContext")] Ref context);

    [NativeFunction("SDL3", EntryPoint = "SDL_GL_ResetAttributes")]
    void GLResetAttributes();

    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetAttribute")]
    int GLSetAttribute(GLattr attr, int value);

    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetSwapInterval")]
    int GLSetSwapInterval(int interval);

    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SwapWindow")]
    int GLSwapWindow(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GL_UnloadLibrary")]
    void GLUnloadLibrary();

    [return: NativeTypeName("char **")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GlobDirectory")]
    sbyte** GlobDirectory(
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("const char *")] sbyte* pattern,
        [NativeTypeName("Uint32")] uint flags,
        int* count
    );

    [return: NativeTypeName("char **")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GlobDirectory")]
    Ptr2D<sbyte> GlobDirectory(
        [NativeTypeName("const char *")] Ref<sbyte> path,
        [NativeTypeName("const char *")] Ref<sbyte> pattern,
        [NativeTypeName("Uint32")] uint flags,
        Ref<int> count
    );

    [return: NativeTypeName("char **")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GlobStorageDirectory")]
    sbyte** GlobStorageDirectory(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("const char *")] sbyte* pattern,
        [NativeTypeName("Uint32")] uint flags,
        int* count
    );

    [return: NativeTypeName("char **")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GlobStorageDirectory")]
    Ptr2D<sbyte> GlobStorageDirectory(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path,
        [NativeTypeName("const char *")] Ref<sbyte> pattern,
        [NativeTypeName("Uint32")] uint flags,
        Ref<int> count
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GUIDFromString")]
    Guid GuidFromString([NativeTypeName("const char *")] sbyte* pchGUID);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GUIDFromString")]
    Guid GuidFromString([NativeTypeName("const char *")] Ref<sbyte> pchGUID);

    [NativeFunction("SDL3", EntryPoint = "SDL_GUIDToString")]
    int GuidToString(Guid guid, [NativeTypeName("char *")] sbyte* pszGUID, int cbGUID);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GUIDToString")]
    int GuidToString(Guid guid, [NativeTypeName("char *")] Ref<sbyte> pszGUID, int cbGUID);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HapticEffectSupported")]
    int HapticEffectSupported(
        HapticHandle haptic,
        [NativeTypeName("const SDL_HapticEffect *")] HapticEffect* effect
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HapticEffectSupported")]
    MaybeBool<int> HapticEffectSupported(
        HapticHandle haptic,
        [NativeTypeName("const SDL_HapticEffect *")] Ref<HapticEffect> effect
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HapticRumbleSupported")]
    MaybeBool<int> HapticRumbleSupported(HapticHandle haptic);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HapticRumbleSupported")]
    int HapticRumbleSupportedRaw(HapticHandle haptic);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAltiVec")]
    MaybeBool<int> HasAltiVec();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAltiVec")]
    int HasAltiVecRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasARMSIMD")]
    MaybeBool<int> HasArmsimd();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasARMSIMD")]
    int HasArmsimdRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX")]
    MaybeBool<int> HasAVX();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX2")]
    MaybeBool<int> HasAVX2();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX2")]
    int HasAVX2Raw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX512F")]
    MaybeBool<int> HasAVX512F();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX512F")]
    int HasAVX512FRaw();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX")]
    int HasAVXRaw();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardData")]
    int HasClipboardData([NativeTypeName("const char *")] sbyte* mime_type);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardData")]
    MaybeBool<int> HasClipboardData([NativeTypeName("const char *")] Ref<sbyte> mime_type);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardText")]
    MaybeBool<int> HasClipboardText();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardText")]
    int HasClipboardTextRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasEvent")]
    MaybeBool<int> HasEvent([NativeTypeName("Uint32")] uint type);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasEvent")]
    int HasEventRaw([NativeTypeName("Uint32")] uint type);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasEvents")]
    MaybeBool<int> HasEvents(
        [NativeTypeName("Uint32")] uint minType,
        [NativeTypeName("Uint32")] uint maxType
    );

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasEvents")]
    int HasEventsRaw(
        [NativeTypeName("Uint32")] uint minType,
        [NativeTypeName("Uint32")] uint maxType
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasGamepad")]
    MaybeBool<int> HasGamepad();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasGamepad")]
    int HasGamepadRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasJoystick")]
    MaybeBool<int> HasJoystick();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasJoystick")]
    int HasJoystickRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasKeyboard")]
    MaybeBool<int> HasKeyboard();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasKeyboard")]
    int HasKeyboardRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasLASX")]
    MaybeBool<int> HasLasx();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasLASX")]
    int HasLasxRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasLSX")]
    MaybeBool<int> HasLSX();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasLSX")]
    int HasLSXRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasMMX")]
    MaybeBool<int> HasMMX();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasMMX")]
    int HasMMXRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasMouse")]
    MaybeBool<int> HasMouse();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasMouse")]
    int HasMouseRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasNEON")]
    MaybeBool<int> HasNeon();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasNEON")]
    int HasNeonRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasPrimarySelectionText")]
    MaybeBool<int> HasPrimarySelectionText();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasPrimarySelectionText")]
    int HasPrimarySelectionTextRaw();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasProperty")]
    int HasProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasProperty")]
    MaybeBool<int> HasProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name
    );

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersection")]
    int HasRectIntersection(
        [NativeTypeName("const SDL_Rect *")] Rect* A,
        [NativeTypeName("const SDL_Rect *")] Rect* B
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersection")]
    MaybeBool<int> HasRectIntersection(
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> A,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> B
    );

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersectionFloat")]
    int HasRectIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] FRect* A,
        [NativeTypeName("const SDL_FRect *")] FRect* B
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersectionFloat")]
    MaybeBool<int> HasRectIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> A,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> B
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasScreenKeyboardSupport")]
    MaybeBool<int> HasScreenKeyboardSupport();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasScreenKeyboardSupport")]
    int HasScreenKeyboardSupportRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE")]
    MaybeBool<int> HasSSE();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE2")]
    MaybeBool<int> HasSSE2();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE2")]
    int HasSSE2Raw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE3")]
    MaybeBool<int> HasSSE3();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE3")]
    int HasSSE3Raw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE41")]
    MaybeBool<int> HasSSE41();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE41")]
    int HasSSE41Raw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE42")]
    MaybeBool<int> HasSSE42();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE42")]
    int HasSSE42Raw();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE")]
    int HasSSERaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_ble_scan")]
    void HidBleScan([NativeTypeName("SDL_bool")] int active);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_ble_scan")]
    void HidBleScan([NativeTypeName("SDL_bool")] MaybeBool<int> active);

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_close")]
    int HidClose(HidDeviceHandle dev);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_device_change_count")]
    uint HidDeviceChangeCount();

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_enumerate")]
    Ptr<HidDeviceInfo> HidEnumerate(
        [NativeTypeName("unsigned short")] ushort vendor_id,
        [NativeTypeName("unsigned short")] ushort product_id
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_enumerate")]
    HidDeviceInfo* HidEnumerateRaw(
        [NativeTypeName("unsigned short")] ushort vendor_id,
        [NativeTypeName("unsigned short")] ushort product_id
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_exit")]
    int HidExit();

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_free_enumeration")]
    void HidFreeEnumeration(HidDeviceInfo* devs);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_free_enumeration")]
    void HidFreeEnumeration(Ref<HidDeviceInfo> devs);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_device_info")]
    Ptr<HidDeviceInfo> HidGetDeviceInfo(HidDeviceHandle dev);

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_device_info")]
    HidDeviceInfo* HidGetDeviceInfoRaw(HidDeviceHandle dev);

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_feature_report")]
    int HidGetFeatureReport(
        HidDeviceHandle dev,
        [NativeTypeName("unsigned char *")] byte* data,
        [NativeTypeName("size_t")] nuint length
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_feature_report")]
    int HidGetFeatureReport(
        HidDeviceHandle dev,
        [NativeTypeName("unsigned char *")] Ref<byte> data,
        [NativeTypeName("size_t")] nuint length
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_indexed_string")]
    int HidGetIndexedString(
        HidDeviceHandle dev,
        int string_index,
        [NativeTypeName("wchar_t *")] uint* @string,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_indexed_string")]
    int HidGetIndexedString(
        HidDeviceHandle dev,
        int string_index,
        [NativeTypeName("wchar_t *")] Ref<uint> @string,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_input_report")]
    int HidGetInputReport(
        HidDeviceHandle dev,
        [NativeTypeName("unsigned char *")] byte* data,
        [NativeTypeName("size_t")] nuint length
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_input_report")]
    int HidGetInputReport(
        HidDeviceHandle dev,
        [NativeTypeName("unsigned char *")] Ref<byte> data,
        [NativeTypeName("size_t")] nuint length
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_manufacturer_string")]
    int HidGetManufacturerString(
        HidDeviceHandle dev,
        [NativeTypeName("wchar_t *")] uint* @string,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_manufacturer_string")]
    int HidGetManufacturerString(
        HidDeviceHandle dev,
        [NativeTypeName("wchar_t *")] Ref<uint> @string,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_product_string")]
    int HidGetProductString(
        HidDeviceHandle dev,
        [NativeTypeName("wchar_t *")] uint* @string,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_product_string")]
    int HidGetProductString(
        HidDeviceHandle dev,
        [NativeTypeName("wchar_t *")] Ref<uint> @string,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_report_descriptor")]
    int HidGetReportDescriptor(
        HidDeviceHandle dev,
        [NativeTypeName("unsigned char *")] byte* buf,
        [NativeTypeName("size_t")] nuint buf_size
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_report_descriptor")]
    int HidGetReportDescriptor(
        HidDeviceHandle dev,
        [NativeTypeName("unsigned char *")] Ref<byte> buf,
        [NativeTypeName("size_t")] nuint buf_size
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_serial_number_string")]
    int HidGetSerialNumberString(
        HidDeviceHandle dev,
        [NativeTypeName("wchar_t *")] uint* @string,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_serial_number_string")]
    int HidGetSerialNumberString(
        HidDeviceHandle dev,
        [NativeTypeName("wchar_t *")] Ref<uint> @string,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_init")]
    int HidInit();

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_open")]
    HidDeviceHandle HidOpen(
        [NativeTypeName("unsigned short")] ushort vendor_id,
        [NativeTypeName("unsigned short")] ushort product_id,
        [NativeTypeName("const wchar_t *")] uint* serial_number
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_open")]
    HidDeviceHandle HidOpen(
        [NativeTypeName("unsigned short")] ushort vendor_id,
        [NativeTypeName("unsigned short")] ushort product_id,
        [NativeTypeName("const wchar_t *")] Ref<uint> serial_number
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_open_path")]
    HidDeviceHandle HidOpenPath([NativeTypeName("const char *")] sbyte* path);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_open_path")]
    HidDeviceHandle HidOpenPath([NativeTypeName("const char *")] Ref<sbyte> path);

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_read")]
    int HidRead(
        HidDeviceHandle dev,
        [NativeTypeName("unsigned char *")] byte* data,
        [NativeTypeName("size_t")] nuint length
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_read")]
    int HidRead(
        HidDeviceHandle dev,
        [NativeTypeName("unsigned char *")] Ref<byte> data,
        [NativeTypeName("size_t")] nuint length
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_read_timeout")]
    int HidReadTimeout(
        HidDeviceHandle dev,
        [NativeTypeName("unsigned char *")] byte* data,
        [NativeTypeName("size_t")] nuint length,
        int milliseconds
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_read_timeout")]
    int HidReadTimeout(
        HidDeviceHandle dev,
        [NativeTypeName("unsigned char *")] Ref<byte> data,
        [NativeTypeName("size_t")] nuint length,
        int milliseconds
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_send_feature_report")]
    int HidSendFeatureReport(
        HidDeviceHandle dev,
        [NativeTypeName("const unsigned char *")] byte* data,
        [NativeTypeName("size_t")] nuint length
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_send_feature_report")]
    int HidSendFeatureReport(
        HidDeviceHandle dev,
        [NativeTypeName("const unsigned char *")] Ref<byte> data,
        [NativeTypeName("size_t")] nuint length
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_set_nonblocking")]
    int HidSetNonblocking(HidDeviceHandle dev, int nonblock);

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_write")]
    int HidWrite(
        HidDeviceHandle dev,
        [NativeTypeName("const unsigned char *")] byte* data,
        [NativeTypeName("size_t")] nuint length
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_write")]
    int HidWrite(
        HidDeviceHandle dev,
        [NativeTypeName("const unsigned char *")] Ref<byte> data,
        [NativeTypeName("size_t")] nuint length
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_HideCursor")]
    int HideCursor();

    [NativeFunction("SDL3", EntryPoint = "SDL_HideWindow")]
    int HideWindow(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_Init")]
    int Init([NativeTypeName("Uint32")] uint flags);

    [NativeFunction("SDL3", EntryPoint = "SDL_InitHapticRumble")]
    int InitHapticRumble(HapticHandle haptic);

    [NativeFunction("SDL3", EntryPoint = "SDL_InitSubSystem")]
    int InitSubSystem([NativeTypeName("Uint32")] uint flags);

    [NativeFunction("SDL3", EntryPoint = "SDL_IOFromConstMem")]
    IOStreamHandle IOFromConstMem(
        [NativeTypeName("const void *")] void* mem,
        [NativeTypeName("size_t")] nuint size
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOFromConstMem")]
    IOStreamHandle IOFromConstMem(
        [NativeTypeName("const void *")] Ref mem,
        [NativeTypeName("size_t")] nuint size
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_IOFromDynamicMem")]
    IOStreamHandle IOFromDynamicMem();

    [NativeFunction("SDL3", EntryPoint = "SDL_IOFromFile")]
    IOStreamHandle IOFromFile(
        [NativeTypeName("const char *")] sbyte* file,
        [NativeTypeName("const char *")] sbyte* mode
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOFromFile")]
    IOStreamHandle IOFromFile(
        [NativeTypeName("const char *")] Ref<sbyte> file,
        [NativeTypeName("const char *")] Ref<sbyte> mode
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_IOFromMem")]
    IOStreamHandle IOFromMem(void* mem, [NativeTypeName("size_t")] nuint size);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOFromMem")]
    IOStreamHandle IOFromMem(Ref mem, [NativeTypeName("size_t")] nuint size);

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOvprintf")]
    nuint IOvprintf(
        IOStreamHandle context,
        [NativeTypeName("const char *")] sbyte* fmt,
        [NativeTypeName("va_list")] sbyte* ap
    );

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOvprintf")]
    nuint IOvprintf(
        IOStreamHandle context,
        [NativeTypeName("const char *")] Ref<sbyte> fmt,
        [NativeTypeName("va_list")] Ref<sbyte> ap
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsGamepad")]
    MaybeBool<int> IsGamepad([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsGamepad")]
    int IsGamepadRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickHaptic")]
    MaybeBool<int> IsJoystickHaptic(JoystickHandle joystick);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickHaptic")]
    int IsJoystickHapticRaw(JoystickHandle joystick);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickVirtual")]
    MaybeBool<int> IsJoystickVirtual([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickVirtual")]
    int IsJoystickVirtualRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsMouseHaptic")]
    MaybeBool<int> IsMouseHaptic();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsMouseHaptic")]
    int IsMouseHapticRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsTablet")]
    MaybeBool<int> IsTablet();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsTablet")]
    int IsTabletRaw();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_JoystickConnected")]
    MaybeBool<int> JoystickConnected(JoystickHandle joystick);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_JoystickConnected")]
    int JoystickConnectedRaw(JoystickHandle joystick);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_JoystickEventsEnabled")]
    MaybeBool<int> JoystickEventsEnabled();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_JoystickEventsEnabled")]
    int JoystickEventsEnabledRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP")]
    Surface* LoadBMP([NativeTypeName("const char *")] sbyte* file);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP")]
    Ptr<Surface> LoadBMP([NativeTypeName("const char *")] Ref<sbyte> file);

    [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP_IO")]
    Surface* LoadBMPIO(IOStreamHandle src, [NativeTypeName("SDL_bool")] int closeio);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP_IO")]
    Ptr<Surface> LoadBMPIO(IOStreamHandle src, [NativeTypeName("SDL_bool")] MaybeBool<int> closeio);

    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile")]
    void* LoadFile(
        [NativeTypeName("const char *")] sbyte* file,
        [NativeTypeName("size_t *")] nuint* datasize
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile")]
    Ptr LoadFile(
        [NativeTypeName("const char *")] Ref<sbyte> file,
        [NativeTypeName("size_t *")] Ref<nuint> datasize
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile_IO")]
    void* LoadFileIO(
        IOStreamHandle src,
        [NativeTypeName("size_t *")] nuint* datasize,
        [NativeTypeName("SDL_bool")] int closeio
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile_IO")]
    Ptr LoadFileIO(
        IOStreamHandle src,
        [NativeTypeName("size_t *")] Ref<nuint> datasize,
        [NativeTypeName("SDL_bool")] MaybeBool<int> closeio
    );

    [return: NativeTypeName("SDL_FunctionPointer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFunction")]
    delegate* unmanaged<void> LoadFunction(
        void* handle,
        [NativeTypeName("const char *")] sbyte* name
    );

    [return: NativeTypeName("SDL_FunctionPointer")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFunction")]
    delegate* unmanaged<void> LoadFunction(
        Ref handle,
        [NativeTypeName("const char *")] Ref<sbyte> name
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_LoadObject")]
    void* LoadObject([NativeTypeName("const char *")] sbyte* sofile);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadObject")]
    Ptr LoadObject([NativeTypeName("const char *")] Ref<sbyte> sofile);

    [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV")]
    int LoadWAV(
        [NativeTypeName("const char *")] sbyte* path,
        AudioSpec* spec,
        [NativeTypeName("Uint8 **")] byte** audio_buf,
        [NativeTypeName("Uint32 *")] uint* audio_len
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV")]
    int LoadWAV(
        [NativeTypeName("const char *")] Ref<sbyte> path,
        Ref<AudioSpec> spec,
        [NativeTypeName("Uint8 **")] Ref2D<byte> audio_buf,
        [NativeTypeName("Uint32 *")] Ref<uint> audio_len
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV_IO")]
    int LoadWAVIO(
        IOStreamHandle src,
        [NativeTypeName("SDL_bool")] int closeio,
        AudioSpec* spec,
        [NativeTypeName("Uint8 **")] byte** audio_buf,
        [NativeTypeName("Uint32 *")] uint* audio_len
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV_IO")]
    int LoadWAVIO(
        IOStreamHandle src,
        [NativeTypeName("SDL_bool")] MaybeBool<int> closeio,
        Ref<AudioSpec> spec,
        [NativeTypeName("Uint8 **")] Ref2D<byte> audio_buf,
        [NativeTypeName("Uint32 *")] Ref<uint> audio_len
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_LockAudioStream")]
    int LockAudioStream(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_LockJoysticks")]
    void LockJoysticks();

    [NativeFunction("SDL3", EntryPoint = "SDL_LockMutex")]
    void LockMutex(MutexHandle mutex);

    [NativeFunction("SDL3", EntryPoint = "SDL_LockProperties")]
    int LockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [NativeFunction("SDL3", EntryPoint = "SDL_LockRWLockForReading")]
    void LockRWLockForReading(RWLockHandle rwlock);

    [NativeFunction("SDL3", EntryPoint = "SDL_LockRWLockForWriting")]
    void LockRWLockForWriting(RWLockHandle rwlock);

    [NativeFunction("SDL3", EntryPoint = "SDL_LockSpinlock")]
    void LockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockSpinlock")]
    void LockSpinlock([NativeTypeName("SDL_SpinLock *")] Ref<int> @lock);

    [NativeFunction("SDL3", EntryPoint = "SDL_LockSurface")]
    int LockSurface(Surface* surface);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockSurface")]
    int LockSurface(Ref<Surface> surface);

    [NativeFunction("SDL3", EntryPoint = "SDL_LockTexture")]
    int LockTexture(
        TextureHandle texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        void** pixels,
        int* pitch
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockTexture")]
    int LockTexture(
        TextureHandle texture,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        Ref2D pixels,
        Ref<int> pitch
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_LockTextureToSurface")]
    int LockTextureToSurface(
        TextureHandle texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        Surface** surface
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockTextureToSurface")]
    int LockTextureToSurface(
        TextureHandle texture,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        Ref2D<Surface> surface
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_LogGetPriority")]
    LogPriority LogGetPriority(int category);

    [NativeFunction("SDL3", EntryPoint = "SDL_LogMessageV")]
    void LogMessageV(
        int category,
        LogPriority priority,
        [NativeTypeName("const char *")] sbyte* fmt,
        [NativeTypeName("va_list")] sbyte* ap
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LogMessageV")]
    void LogMessageV(
        int category,
        LogPriority priority,
        [NativeTypeName("const char *")] Ref<sbyte> fmt,
        [NativeTypeName("va_list")] Ref<sbyte> ap
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_LogResetPriorities")]
    void LogResetPriorities();

    [NativeFunction("SDL3", EntryPoint = "SDL_LogSetAllPriority")]
    void LogSetAllPriority(LogPriority priority);

    [NativeFunction("SDL3", EntryPoint = "SDL_LogSetPriority")]
    void LogSetPriority(int category, LogPriority priority);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapRGB")]
    uint MapRGB(
        [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapRGB")]
    uint MapRGB(
        [NativeTypeName("const SDL_PixelFormat *")] Ref<PixelFormat> format,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapRGBA")]
    uint MapRgba(
        [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b,
        [NativeTypeName("Uint8")] byte a
    );

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapRGBA")]
    uint MapRgba(
        [NativeTypeName("const SDL_PixelFormat *")] Ref<PixelFormat> format,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b,
        [NativeTypeName("Uint8")] byte a
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_MaximizeWindow")]
    int MaximizeWindow(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_MemoryBarrierAcquireFunction")]
    void MemoryBarrierAcquireFunction();

    [NativeFunction("SDL3", EntryPoint = "SDL_MemoryBarrierReleaseFunction")]
    void MemoryBarrierReleaseFunction();

    [return: NativeTypeName("SDL_MetalView")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_Metal_CreateView")]
    Ptr MetalCreateView(WindowHandle window);

    [return: NativeTypeName("SDL_MetalView")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Metal_CreateView")]
    void* MetalCreateViewRaw(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_Metal_DestroyView")]
    void MetalDestroyView([NativeTypeName("SDL_MetalView")] void* view);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_Metal_DestroyView")]
    void MetalDestroyView([NativeTypeName("SDL_MetalView")] Ref view);

    [NativeFunction("SDL3", EntryPoint = "SDL_Metal_GetLayer")]
    void* MetalGetLayer([NativeTypeName("SDL_MetalView")] void* view);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_Metal_GetLayer")]
    Ptr MetalGetLayer([NativeTypeName("SDL_MetalView")] Ref view);

    [NativeFunction("SDL3", EntryPoint = "SDL_MinimizeWindow")]
    int MinimizeWindow(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_MixAudioFormat")]
    int MixAudioFormat(
        [NativeTypeName("Uint8 *")] byte* dst,
        [NativeTypeName("const Uint8 *")] byte* src,
        [NativeTypeName("SDL_AudioFormat")] ushort format,
        [NativeTypeName("Uint32")] uint len,
        int volume
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_MixAudioFormat")]
    int MixAudioFormat(
        [NativeTypeName("Uint8 *")] Ref<byte> dst,
        [NativeTypeName("const Uint8 *")] Ref<byte> src,
        [NativeTypeName("SDL_AudioFormat")] ushort format,
        [NativeTypeName("Uint32")] uint len,
        int volume
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidBecomeActive")]
    void OnApplicationDidBecomeActive();

    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidEnterBackground")]
    void OnApplicationDidEnterBackground();

    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning")]
    void OnApplicationDidReceiveMemoryWarning();

    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillEnterForeground")]
    void OnApplicationWillEnterForeground();

    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillResignActive")]
    void OnApplicationWillResignActive();

    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillTerminate")]
    void OnApplicationWillTerminate();

    [return: NativeTypeName("SDL_AudioDeviceID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDevice")]
    uint OpenAudioDevice(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* spec
    );

    [return: NativeTypeName("SDL_AudioDeviceID")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDevice")]
    uint OpenAudioDevice(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> spec
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDeviceStream")]
    AudioStreamHandle OpenAudioDeviceStream(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* spec,
        [NativeTypeName("SDL_AudioStreamCallback")]
            delegate* unmanaged<void*, AudioStreamHandle, int, int, void> callback,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDeviceStream")]
    AudioStreamHandle OpenAudioDeviceStream(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> spec,
        [NativeTypeName("SDL_AudioStreamCallback")]
            delegate* unmanaged<void*, AudioStreamHandle, int, int, void> callback,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenCameraDevice")]
    CameraHandle OpenCameraDevice(
        [NativeTypeName("SDL_CameraDeviceID")] uint instance_id,
        [NativeTypeName("const SDL_CameraSpec *")] CameraSpec* spec
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenCameraDevice")]
    CameraHandle OpenCameraDevice(
        [NativeTypeName("SDL_CameraDeviceID")] uint instance_id,
        [NativeTypeName("const SDL_CameraSpec *")] Ref<CameraSpec> spec
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenFileStorage")]
    StorageHandle OpenFileStorage([NativeTypeName("const char *")] sbyte* path);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenFileStorage")]
    StorageHandle OpenFileStorage([NativeTypeName("const char *")] Ref<sbyte> path);

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenGamepad")]
    GamepadHandle OpenGamepad([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenHaptic")]
    HapticHandle OpenHaptic([NativeTypeName("SDL_HapticID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenHapticFromJoystick")]
    HapticHandle OpenHapticFromJoystick(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenHapticFromMouse")]
    HapticHandle OpenHapticFromMouse();

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenIO")]
    IOStreamHandle OpenIO(
        [NativeTypeName("const SDL_IOStreamInterface *")] IOStreamInterface* iface,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenIO")]
    IOStreamHandle OpenIO(
        [NativeTypeName("const SDL_IOStreamInterface *")] Ref<IOStreamInterface> iface,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenJoystick")]
    JoystickHandle OpenJoystick([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenSensor")]
    SensorHandle OpenSensor([NativeTypeName("SDL_SensorID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenStorage")]
    StorageHandle OpenStorage(
        [NativeTypeName("const SDL_StorageInterface *")] StorageInterface* iface,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenStorage")]
    StorageHandle OpenStorage(
        [NativeTypeName("const SDL_StorageInterface *")] Ref<StorageInterface> iface,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenTitleStorage")]
    StorageHandle OpenTitleStorage(
        [NativeTypeName("const char *")] sbyte* @override,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenTitleStorage")]
    StorageHandle OpenTitleStorage(
        [NativeTypeName("const char *")] Ref<sbyte> @override,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenURL")]
    int OpenURL([NativeTypeName("const char *")] sbyte* url);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenURL")]
    int OpenURL([NativeTypeName("const char *")] Ref<sbyte> url);

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenUserStorage")]
    StorageHandle OpenUserStorage(
        [NativeTypeName("const char *")] sbyte* org,
        [NativeTypeName("const char *")] sbyte* app,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenUserStorage")]
    StorageHandle OpenUserStorage(
        [NativeTypeName("const char *")] Ref<sbyte> org,
        [NativeTypeName("const char *")] Ref<sbyte> app,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioDevice")]
    int PauseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [NativeFunction("SDL3", EntryPoint = "SDL_PauseHaptic")]
    int PauseHaptic(HapticHandle haptic);

    [NativeFunction("SDL3", EntryPoint = "SDL_PeepEvents")]
    int PeepEvents(
        Event* events,
        int numevents,
        EventAction action,
        [NativeTypeName("Uint32")] uint minType,
        [NativeTypeName("Uint32")] uint maxType
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PeepEvents")]
    int PeepEvents(
        Ref<Event> events,
        int numevents,
        EventAction action,
        [NativeTypeName("Uint32")] uint minType,
        [NativeTypeName("Uint32")] uint maxType
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PenConnected")]
    MaybeBool<int> PenConnected([NativeTypeName("SDL_PenID")] uint instance_id);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PenConnected")]
    int PenConnectedRaw([NativeTypeName("SDL_PenID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_PlayHapticRumble")]
    int PlayHapticRumble(
        HapticHandle haptic,
        float strength,
        [NativeTypeName("Uint32")] uint length
    );

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PollEvent")]
    int PollEvent(Event* @event);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PollEvent")]
    MaybeBool<int> PollEvent(Ref<Event> @event);

    [NativeFunction("SDL3", EntryPoint = "SDL_PostSemaphore")]
    int PostSemaphore(SemaphoreHandle sem);

    [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplyAlpha")]
    int PremultiplyAlpha(
        int width,
        int height,
        PixelFormatEnum src_format,
        [NativeTypeName("const void *")] void* src,
        int src_pitch,
        PixelFormatEnum dst_format,
        void* dst,
        int dst_pitch
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplyAlpha")]
    int PremultiplyAlpha(
        int width,
        int height,
        PixelFormatEnum src_format,
        [NativeTypeName("const void *")] Ref src,
        int src_pitch,
        PixelFormatEnum dst_format,
        Ref dst,
        int dst_pitch
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_PumpEvents")]
    void PumpEvents();

    [NativeFunction("SDL3", EntryPoint = "SDL_PushEvent")]
    int PushEvent(Event* @event);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushEvent")]
    int PushEvent(Ref<Event> @event);

    [NativeFunction("SDL3", EntryPoint = "SDL_PutAudioStreamData")]
    int PutAudioStreamData(
        AudioStreamHandle stream,
        [NativeTypeName("const void *")] void* buf,
        int len
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PutAudioStreamData")]
    int PutAudioStreamData(
        AudioStreamHandle stream,
        [NativeTypeName("const void *")] Ref buf,
        int len
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_QueryTexture")]
    int QueryTexture(TextureHandle texture, PixelFormatEnum* format, int* access, int* w, int* h);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_QueryTexture")]
    int QueryTexture(
        TextureHandle texture,
        Ref<PixelFormatEnum> format,
        Ref<int> access,
        Ref<int> w,
        Ref<int> h
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_Quit")]
    void Quit();

    [NativeFunction("SDL3", EntryPoint = "SDL_QuitSubSystem")]
    void QuitSubSystem([NativeTypeName("Uint32")] uint flags);

    [NativeFunction("SDL3", EntryPoint = "SDL_RaiseWindow")]
    int RaiseWindow(WindowHandle window);

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadIO")]
    nuint ReadIO(IOStreamHandle context, void* ptr, [NativeTypeName("size_t")] nuint size);

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadIO")]
    nuint ReadIO(IOStreamHandle context, Ref ptr, [NativeTypeName("size_t")] nuint size);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16BE")]
    int ReadS16BE(IOStreamHandle src, [NativeTypeName("Sint16 *")] short* value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16BE")]
    MaybeBool<int> ReadS16BE(IOStreamHandle src, [NativeTypeName("Sint16 *")] Ref<short> value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16LE")]
    int ReadS16LE(IOStreamHandle src, [NativeTypeName("Sint16 *")] short* value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16LE")]
    MaybeBool<int> ReadS16LE(IOStreamHandle src, [NativeTypeName("Sint16 *")] Ref<short> value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32BE")]
    int ReadS32BE(IOStreamHandle src, [NativeTypeName("Sint32 *")] int* value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32BE")]
    MaybeBool<int> ReadS32BE(IOStreamHandle src, [NativeTypeName("Sint32 *")] Ref<int> value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32LE")]
    int ReadS32LE(IOStreamHandle src, [NativeTypeName("Sint32 *")] int* value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32LE")]
    MaybeBool<int> ReadS32LE(IOStreamHandle src, [NativeTypeName("Sint32 *")] Ref<int> value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64BE")]
    int ReadS64BE(IOStreamHandle src, [NativeTypeName("Sint64 *")] long* value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64BE")]
    MaybeBool<int> ReadS64BE(IOStreamHandle src, [NativeTypeName("Sint64 *")] Ref<long> value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64LE")]
    int ReadS64LE(IOStreamHandle src, [NativeTypeName("Sint64 *")] long* value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64LE")]
    MaybeBool<int> ReadS64LE(IOStreamHandle src, [NativeTypeName("Sint64 *")] Ref<long> value);

    [NativeFunction("SDL3", EntryPoint = "SDL_ReadStorageFile")]
    int ReadStorageFile(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* path,
        void* destination,
        [NativeTypeName("Uint64")] ulong length
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadStorageFile")]
    int ReadStorageFile(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path,
        Ref destination,
        [NativeTypeName("Uint64")] ulong length
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixel")]
    int ReadSurfacePixel(
        Surface* surface,
        int x,
        int y,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b,
        [NativeTypeName("Uint8 *")] byte* a
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixel")]
    int ReadSurfacePixel(
        Ref<Surface> surface,
        int x,
        int y,
        [NativeTypeName("Uint8 *")] Ref<byte> r,
        [NativeTypeName("Uint8 *")] Ref<byte> g,
        [NativeTypeName("Uint8 *")] Ref<byte> b,
        [NativeTypeName("Uint8 *")] Ref<byte> a
    );

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16BE")]
    int ReadU16BE(IOStreamHandle src, [NativeTypeName("Uint16 *")] ushort* value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16BE")]
    MaybeBool<int> ReadU16BE(IOStreamHandle src, [NativeTypeName("Uint16 *")] Ref<ushort> value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16LE")]
    int ReadU16LE(IOStreamHandle src, [NativeTypeName("Uint16 *")] ushort* value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16LE")]
    MaybeBool<int> ReadU16LE(IOStreamHandle src, [NativeTypeName("Uint16 *")] Ref<ushort> value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32BE")]
    int ReadU32BE(IOStreamHandle src, [NativeTypeName("Uint32 *")] uint* value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32BE")]
    MaybeBool<int> ReadU32BE(IOStreamHandle src, [NativeTypeName("Uint32 *")] Ref<uint> value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32LE")]
    int ReadU32LE(IOStreamHandle src, [NativeTypeName("Uint32 *")] uint* value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32LE")]
    MaybeBool<int> ReadU32LE(IOStreamHandle src, [NativeTypeName("Uint32 *")] Ref<uint> value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64BE")]
    int ReadU64BE(IOStreamHandle src, [NativeTypeName("Uint64 *")] ulong* value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64BE")]
    MaybeBool<int> ReadU64BE(IOStreamHandle src, [NativeTypeName("Uint64 *")] Ref<ulong> value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64LE")]
    int ReadU64LE(IOStreamHandle src, [NativeTypeName("Uint64 *")] ulong* value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64LE")]
    MaybeBool<int> ReadU64LE(IOStreamHandle src, [NativeTypeName("Uint64 *")] Ref<ulong> value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU8")]
    int ReadU8(IOStreamHandle src, [NativeTypeName("Uint8 *")] byte* value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU8")]
    MaybeBool<int> ReadU8(IOStreamHandle src, [NativeTypeName("Uint8 *")] Ref<byte> value);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RegisterEvents")]
    uint RegisterEvents(int numevents);

    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseCameraFrame")]
    int ReleaseCameraFrame(CameraHandle camera, Surface* frame);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseCameraFrame")]
    int ReleaseCameraFrame(CameraHandle camera, Ref<Surface> frame);

    [NativeFunction("SDL3", EntryPoint = "SDL_ReloadGamepadMappings")]
    int ReloadGamepadMappings();

    [NativeFunction("SDL3", EntryPoint = "SDL_RemovePath")]
    int RemovePath([NativeTypeName("const char *")] sbyte* path);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemovePath")]
    int RemovePath([NativeTypeName("const char *")] Ref<sbyte> path);

    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveStoragePath")]
    int RemoveStoragePath(StorageHandle storage, [NativeTypeName("const char *")] sbyte* path);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveStoragePath")]
    int RemoveStoragePath(StorageHandle storage, [NativeTypeName("const char *")] Ref<sbyte> path);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveTimer")]
    MaybeBool<int> RemoveTimer([NativeTypeName("SDL_TimerID")] uint id);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveTimer")]
    int RemoveTimerRaw([NativeTypeName("SDL_TimerID")] uint id);

    [NativeFunction("SDL3", EntryPoint = "SDL_RenamePath")]
    int RenamePath(
        [NativeTypeName("const char *")] sbyte* oldpath,
        [NativeTypeName("const char *")] sbyte* newpath
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenamePath")]
    int RenamePath(
        [NativeTypeName("const char *")] Ref<sbyte> oldpath,
        [NativeTypeName("const char *")] Ref<sbyte> newpath
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RenameStoragePath")]
    int RenameStoragePath(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* oldpath,
        [NativeTypeName("const char *")] sbyte* newpath
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenameStoragePath")]
    int RenameStoragePath(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> oldpath,
        [NativeTypeName("const char *")] Ref<sbyte> newpath
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderClear")]
    int RenderClear(RendererHandle renderer);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderClipEnabled")]
    MaybeBool<int> RenderClipEnabled(RendererHandle renderer);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderClipEnabled")]
    int RenderClipEnabledRaw(RendererHandle renderer);

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesFromWindow")]
    int RenderCoordinatesFromWindow(
        RendererHandle renderer,
        float window_x,
        float window_y,
        float* x,
        float* y
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesFromWindow")]
    int RenderCoordinatesFromWindow(
        RendererHandle renderer,
        float window_x,
        float window_y,
        Ref<float> x,
        Ref<float> y
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesToWindow")]
    int RenderCoordinatesToWindow(
        RendererHandle renderer,
        float x,
        float y,
        float* window_x,
        float* window_y
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesToWindow")]
    int RenderCoordinatesToWindow(
        RendererHandle renderer,
        float x,
        float y,
        Ref<float> window_x,
        Ref<float> window_y
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRect")]
    int RenderFillRect(RendererHandle renderer, [NativeTypeName("const SDL_FRect *")] FRect* rect);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRect")]
    int RenderFillRect(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> rect
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRects")]
    int RenderFillRects(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FRect *")] FRect* rects,
        int count
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRects")]
    int RenderFillRects(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> rects,
        int count
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometry")]
    int RenderGeometry(
        RendererHandle renderer,
        TextureHandle texture,
        [NativeTypeName("const SDL_Vertex *")] Vertex* vertices,
        int num_vertices,
        [NativeTypeName("const int *")] int* indices,
        int num_indices
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometry")]
    int RenderGeometry(
        RendererHandle renderer,
        TextureHandle texture,
        [NativeTypeName("const SDL_Vertex *")] Ref<Vertex> vertices,
        int num_vertices,
        [NativeTypeName("const int *")] Ref<int> indices,
        int num_indices
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRaw")]
    int RenderGeometryRaw(
        RendererHandle renderer,
        TextureHandle texture,
        [NativeTypeName("const float *")] float* xy,
        int xy_stride,
        [NativeTypeName("const SDL_Color *")] Color* color,
        int color_stride,
        [NativeTypeName("const float *")] float* uv,
        int uv_stride,
        int num_vertices,
        [NativeTypeName("const void *")] void* indices,
        int num_indices,
        int size_indices
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRaw")]
    int RenderGeometryRaw(
        RendererHandle renderer,
        TextureHandle texture,
        [NativeTypeName("const float *")] Ref<float> xy,
        int xy_stride,
        [NativeTypeName("const SDL_Color *")] Ref<Color> color,
        int color_stride,
        [NativeTypeName("const float *")] Ref<float> uv,
        int uv_stride,
        int num_vertices,
        [NativeTypeName("const void *")] Ref indices,
        int num_indices,
        int size_indices
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRawFloat")]
    int RenderGeometryRawFloat(
        RendererHandle renderer,
        TextureHandle texture,
        [NativeTypeName("const float *")] float* xy,
        int xy_stride,
        [NativeTypeName("const SDL_FColor *")] FColor* color,
        int color_stride,
        [NativeTypeName("const float *")] float* uv,
        int uv_stride,
        int num_vertices,
        [NativeTypeName("const void *")] void* indices,
        int num_indices,
        int size_indices
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRawFloat")]
    int RenderGeometryRawFloat(
        RendererHandle renderer,
        TextureHandle texture,
        [NativeTypeName("const float *")] Ref<float> xy,
        int xy_stride,
        [NativeTypeName("const SDL_FColor *")] Ref<FColor> color,
        int color_stride,
        [NativeTypeName("const float *")] Ref<float> uv,
        int uv_stride,
        int num_vertices,
        [NativeTypeName("const void *")] Ref indices,
        int num_indices,
        int size_indices
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderLine")]
    int RenderLine(RendererHandle renderer, float x1, float y1, float x2, float y2);

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderLines")]
    int RenderLines(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FPoint *")] FPoint* points,
        int count
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderLines")]
    int RenderLines(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> points,
        int count
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoint")]
    int RenderPoint(RendererHandle renderer, float x, float y);

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoints")]
    int RenderPoints(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FPoint *")] FPoint* points,
        int count
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoints")]
    int RenderPoints(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> points,
        int count
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPresent")]
    int RenderPresent(RendererHandle renderer);

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderReadPixels")]
    Surface* RenderReadPixels(
        RendererHandle renderer,
        [NativeTypeName("const SDL_Rect *")] Rect* rect
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderReadPixels")]
    Ptr<Surface> RenderReadPixels(
        RendererHandle renderer,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderRect")]
    int RenderRect(RendererHandle renderer, [NativeTypeName("const SDL_FRect *")] FRect* rect);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderRect")]
    int RenderRect(RendererHandle renderer, [NativeTypeName("const SDL_FRect *")] Ref<FRect> rect);

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderRects")]
    int RenderRects(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FRect *")] FRect* rects,
        int count
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderRects")]
    int RenderRects(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> rects,
        int count
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture")]
    int RenderTexture(
        RendererHandle renderer,
        TextureHandle texture,
        [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
        [NativeTypeName("const SDL_FRect *")] FRect* dstrect
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture")]
    int RenderTexture(
        RendererHandle renderer,
        TextureHandle texture,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> srcrect,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> dstrect
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureRotated")]
    int RenderTextureRotated(
        RendererHandle renderer,
        TextureHandle texture,
        [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
        [NativeTypeName("const SDL_FRect *")] FRect* dstrect,
        [NativeTypeName("const double")] double angle,
        [NativeTypeName("const SDL_FPoint *")] FPoint* center,
        [NativeTypeName("const SDL_FlipMode")] FlipMode flip
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureRotated")]
    int RenderTextureRotated(
        RendererHandle renderer,
        TextureHandle texture,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> srcrect,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> dstrect,
        [NativeTypeName("const double")] double angle,
        [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> center,
        [NativeTypeName("const SDL_FlipMode")] FlipMode flip
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderViewportSet")]
    MaybeBool<int> RenderViewportSet(RendererHandle renderer);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderViewportSet")]
    int RenderViewportSetRaw(RendererHandle renderer);

    [NativeFunction("SDL3", EntryPoint = "SDL_ReportAssertion")]
    AssertState ReportAssertion(
        AssertData* data,
        [NativeTypeName("const char *")] sbyte* func,
        [NativeTypeName("const char *")] sbyte* file,
        int line
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReportAssertion")]
    AssertState ReportAssertion(
        Ref<AssertData> data,
        [NativeTypeName("const char *")] Ref<sbyte> func,
        [NativeTypeName("const char *")] Ref<sbyte> file,
        int line
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ResetAssertionReport")]
    void ResetAssertionReport();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResetHint")]
    int ResetHint([NativeTypeName("const char *")] sbyte* name);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResetHint")]
    MaybeBool<int> ResetHint([NativeTypeName("const char *")] Ref<sbyte> name);

    [NativeFunction("SDL3", EntryPoint = "SDL_ResetHints")]
    void ResetHints();

    [NativeFunction("SDL3", EntryPoint = "SDL_ResetKeyboard")]
    void ResetKeyboard();

    [NativeFunction("SDL3", EntryPoint = "SDL_RestoreWindow")]
    int RestoreWindow(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioDevice")]
    int ResumeAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [NativeFunction("SDL3", EntryPoint = "SDL_ResumeHaptic")]
    int ResumeHaptic(HapticHandle haptic);

    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepad")]
    int RumbleGamepad(
        GamepadHandle gamepad,
        [NativeTypeName("Uint16")] ushort low_frequency_rumble,
        [NativeTypeName("Uint16")] ushort high_frequency_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepadTriggers")]
    int RumbleGamepadTriggers(
        GamepadHandle gamepad,
        [NativeTypeName("Uint16")] ushort left_rumble,
        [NativeTypeName("Uint16")] ushort right_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystick")]
    int RumbleJoystick(
        JoystickHandle joystick,
        [NativeTypeName("Uint16")] ushort low_frequency_rumble,
        [NativeTypeName("Uint16")] ushort high_frequency_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystickTriggers")]
    int RumbleJoystickTriggers(
        JoystickHandle joystick,
        [NativeTypeName("Uint16")] ushort left_rumble,
        [NativeTypeName("Uint16")] ushort right_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RunHapticEffect")]
    int RunHapticEffect(
        HapticHandle haptic,
        int effect,
        [NativeTypeName("Uint32")] uint iterations
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP")]
    int SaveBMP(Surface* surface, [NativeTypeName("const char *")] sbyte* file);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP")]
    int SaveBMP(Ref<Surface> surface, [NativeTypeName("const char *")] Ref<sbyte> file);

    [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP_IO")]
    int SaveBMPIO(Surface* surface, IOStreamHandle dst, [NativeTypeName("SDL_bool")] int closeio);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP_IO")]
    int SaveBMPIO(
        Ref<Surface> surface,
        IOStreamHandle dst,
        [NativeTypeName("SDL_bool")] MaybeBool<int> closeio
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScreenKeyboardShown")]
    MaybeBool<int> ScreenKeyboardShown(WindowHandle window);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScreenKeyboardShown")]
    int ScreenKeyboardShownRaw(WindowHandle window);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScreenSaverEnabled")]
    MaybeBool<int> ScreenSaverEnabled();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScreenSaverEnabled")]
    int ScreenSaverEnabledRaw();

    [return: NativeTypeName("Sint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SeekIO")]
    long SeekIO(IOStreamHandle context, [NativeTypeName("Sint64")] long offset, int whence);

    [NativeFunction("SDL3", EntryPoint = "SDL_SendGamepadEffect")]
    int SendGamepadEffect(
        GamepadHandle gamepad,
        [NativeTypeName("const void *")] void* data,
        int size
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SendGamepadEffect")]
    int SendGamepadEffect(
        GamepadHandle gamepad,
        [NativeTypeName("const void *")] Ref data,
        int size
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickEffect")]
    int SendJoystickEffect(
        JoystickHandle joystick,
        [NativeTypeName("const void *")] void* data,
        int size
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickEffect")]
    int SendJoystickEffect(
        JoystickHandle joystick,
        [NativeTypeName("const void *")] Ref data,
        int size
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetAssertionHandler")]
    void SetAssertionHandler(
        [NativeTypeName("SDL_AssertionHandler")]
            delegate* unmanaged<AssertData*, void*, AssertState> handler,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAssertionHandler")]
    void SetAssertionHandler(
        [NativeTypeName("SDL_AssertionHandler")]
            delegate* unmanaged<AssertData*, void*, AssertState> handler,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioPostmixCallback")]
    int SetAudioPostmixCallback(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        [NativeTypeName("SDL_AudioPostmixCallback")]
            delegate* unmanaged<void*, AudioSpec*, float*, int, void> callback,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioPostmixCallback")]
    int SetAudioPostmixCallback(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        [NativeTypeName("SDL_AudioPostmixCallback")]
            delegate* unmanaged<void*, AudioSpec*, float*, int, void> callback,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFormat")]
    int SetAudioStreamFormat(
        AudioStreamHandle stream,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* src_spec,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* dst_spec
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFormat")]
    int SetAudioStreamFormat(
        AudioStreamHandle stream,
        [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> src_spec,
        [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> dst_spec
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFrequencyRatio")]
    int SetAudioStreamFrequencyRatio(AudioStreamHandle stream, float ratio);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGetCallback")]
    int SetAudioStreamGetCallback(
        AudioStreamHandle stream,
        [NativeTypeName("SDL_AudioStreamCallback")]
            delegate* unmanaged<void*, AudioStreamHandle, int, int, void> callback,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGetCallback")]
    int SetAudioStreamGetCallback(
        AudioStreamHandle stream,
        [NativeTypeName("SDL_AudioStreamCallback")]
            delegate* unmanaged<void*, AudioStreamHandle, int, int, void> callback,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamPutCallback")]
    int SetAudioStreamPutCallback(
        AudioStreamHandle stream,
        [NativeTypeName("SDL_AudioStreamCallback")]
            delegate* unmanaged<void*, AudioStreamHandle, int, int, void> callback,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamPutCallback")]
    int SetAudioStreamPutCallback(
        AudioStreamHandle stream,
        [NativeTypeName("SDL_AudioStreamCallback")]
            delegate* unmanaged<void*, AudioStreamHandle, int, int, void> callback,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetBooleanProperty")]
    int SetBooleanProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("SDL_bool")] int value
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetBooleanProperty")]
    int SetBooleanProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("SDL_bool")] MaybeBool<int> value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardData")]
    int SetClipboardData(
        [NativeTypeName("SDL_ClipboardDataCallback")]
            delegate* unmanaged<void*, sbyte*, nuint*, void*> callback,
        [NativeTypeName("SDL_ClipboardCleanupCallback")] delegate* unmanaged<void*, void> cleanup,
        void* userdata,
        [NativeTypeName("const char **")] sbyte** mime_types,
        [NativeTypeName("size_t")] nuint num_mime_types
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardData")]
    int SetClipboardData(
        [NativeTypeName("SDL_ClipboardDataCallback")]
            delegate* unmanaged<void*, sbyte*, nuint*, void*> callback,
        [NativeTypeName("SDL_ClipboardCleanupCallback")] delegate* unmanaged<void*, void> cleanup,
        Ref userdata,
        [NativeTypeName("const char **")] Ref2D<sbyte> mime_types,
        [NativeTypeName("size_t")] nuint num_mime_types
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardText")]
    int SetClipboardText([NativeTypeName("const char *")] sbyte* text);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardText")]
    int SetClipboardText([NativeTypeName("const char *")] Ref<sbyte> text);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetCursor")]
    int SetCursor(CursorHandle cursor);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetEventEnabled")]
    void SetEventEnabled(
        [NativeTypeName("Uint32")] uint type,
        [NativeTypeName("SDL_bool")] int enabled
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetEventEnabled")]
    void SetEventEnabled(
        [NativeTypeName("Uint32")] uint type,
        [NativeTypeName("SDL_bool")] MaybeBool<int> enabled
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetEventFilter")]
    void SetEventFilter(
        [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetEventFilter")]
    void SetEventFilter(
        [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetFloatProperty")]
    int SetFloatProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        float value
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetFloatProperty")]
    int SetFloatProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        float value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadEventsEnabled")]
    void SetGamepadEventsEnabled([NativeTypeName("SDL_bool")] int enabled);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadEventsEnabled")]
    void SetGamepadEventsEnabled([NativeTypeName("SDL_bool")] MaybeBool<int> enabled);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadLED")]
    int SetGamepadLED(
        GamepadHandle gamepad,
        [NativeTypeName("Uint8")] byte red,
        [NativeTypeName("Uint8")] byte green,
        [NativeTypeName("Uint8")] byte blue
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadMapping")]
    int SetGamepadMapping(
        [NativeTypeName("SDL_JoystickID")] uint instance_id,
        [NativeTypeName("const char *")] sbyte* mapping
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadMapping")]
    int SetGamepadMapping(
        [NativeTypeName("SDL_JoystickID")] uint instance_id,
        [NativeTypeName("const char *")] Ref<sbyte> mapping
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadPlayerIndex")]
    int SetGamepadPlayerIndex(GamepadHandle gamepad, int player_index);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadSensorEnabled")]
    int SetGamepadSensorEnabled(
        GamepadHandle gamepad,
        SensorType type,
        [NativeTypeName("SDL_bool")] int enabled
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadSensorEnabled")]
    int SetGamepadSensorEnabled(
        GamepadHandle gamepad,
        SensorType type,
        [NativeTypeName("SDL_bool")] MaybeBool<int> enabled
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticAutocenter")]
    int SetHapticAutocenter(HapticHandle haptic, int autocenter);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticGain")]
    int SetHapticGain(HapticHandle haptic, int gain);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHint")]
    int SetHint(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const char *")] sbyte* value
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHint")]
    MaybeBool<int> SetHint(
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("const char *")] Ref<sbyte> value
    );

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHintWithPriority")]
    int SetHintWithPriority(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const char *")] sbyte* value,
        HintPriority priority
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHintWithPriority")]
    MaybeBool<int> SetHintWithPriority(
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("const char *")] Ref<sbyte> value,
        HintPriority priority
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickEventsEnabled")]
    void SetJoystickEventsEnabled([NativeTypeName("SDL_bool")] int enabled);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickEventsEnabled")]
    void SetJoystickEventsEnabled([NativeTypeName("SDL_bool")] MaybeBool<int> enabled);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickLED")]
    int SetJoystickLED(
        JoystickHandle joystick,
        [NativeTypeName("Uint8")] byte red,
        [NativeTypeName("Uint8")] byte green,
        [NativeTypeName("Uint8")] byte blue
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickPlayerIndex")]
    int SetJoystickPlayerIndex(JoystickHandle joystick, int player_index);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualAxis")]
    int SetJoystickVirtualAxis(
        JoystickHandle joystick,
        int axis,
        [NativeTypeName("Sint16")] short value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualButton")]
    int SetJoystickVirtualButton(
        JoystickHandle joystick,
        int button,
        [NativeTypeName("Uint8")] byte value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualHat")]
    int SetJoystickVirtualHat(
        JoystickHandle joystick,
        int hat,
        [NativeTypeName("Uint8")] byte value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetLogOutputFunction")]
    void SetLogOutputFunction(
        [NativeTypeName("SDL_LogOutputFunction")]
            delegate* unmanaged<void*, int, LogPriority, sbyte*, void> callback,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetLogOutputFunction")]
    void SetLogOutputFunction(
        [NativeTypeName("SDL_LogOutputFunction")]
            delegate* unmanaged<void*, int, LogPriority, sbyte*, void> callback,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetModState")]
    void SetModState(Keymod modstate);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetNumberProperty")]
    int SetNumberProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("Sint64")] long value
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetNumberProperty")]
    int SetNumberProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("Sint64")] long value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetPaletteColors")]
    int SetPaletteColors(
        Palette* palette,
        [NativeTypeName("const SDL_Color *")] Color* colors,
        int firstcolor,
        int ncolors
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPaletteColors")]
    int SetPaletteColors(
        Ref<Palette> palette,
        [NativeTypeName("const SDL_Color *")] Ref<Color> colors,
        int firstcolor,
        int ncolors
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetPixelFormatPalette")]
    int SetPixelFormatPalette(PixelFormat* format, Palette* palette);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPixelFormatPalette")]
    int SetPixelFormatPalette(Ref<PixelFormat> format, Ref<Palette> palette);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetPrimarySelectionText")]
    int SetPrimarySelectionText([NativeTypeName("const char *")] sbyte* text);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPrimarySelectionText")]
    int SetPrimarySelectionText([NativeTypeName("const char *")] Ref<sbyte> text);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetProperty")]
    int SetProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        void* value
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetProperty")]
    int SetProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        Ref value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetPropertyWithCleanup")]
    int SetPropertyWithCleanup(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        void* value,
        [NativeTypeName("void (*)(void *, void *)")]
            delegate* unmanaged<void*, void*, void> cleanup,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPropertyWithCleanup")]
    int SetPropertyWithCleanup(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        Ref value,
        [NativeTypeName("void (*)(void *, void *)")]
            delegate* unmanaged<void*, void*, void> cleanup,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetRelativeMouseMode")]
    int SetRelativeMouseMode([NativeTypeName("SDL_bool")] int enabled);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRelativeMouseMode")]
    int SetRelativeMouseMode([NativeTypeName("SDL_bool")] MaybeBool<int> enabled);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderClipRect")]
    int SetRenderClipRect(RendererHandle renderer, [NativeTypeName("const SDL_Rect *")] Rect* rect);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderClipRect")]
    int SetRenderClipRect(
        RendererHandle renderer,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderColorScale")]
    int SetRenderColorScale(RendererHandle renderer, float scale);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawBlendMode")]
    int SetRenderDrawBlendMode(RendererHandle renderer, BlendMode blendMode);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColor")]
    int SetRenderDrawColor(
        RendererHandle renderer,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b,
        [NativeTypeName("Uint8")] byte a
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColorFloat")]
    int SetRenderDrawColorFloat(RendererHandle renderer, float r, float g, float b, float a);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderLogicalPresentation")]
    int SetRenderLogicalPresentation(
        RendererHandle renderer,
        int w,
        int h,
        RendererLogicalPresentation mode,
        ScaleMode scale_mode
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderScale")]
    int SetRenderScale(RendererHandle renderer, float scaleX, float scaleY);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderTarget")]
    int SetRenderTarget(RendererHandle renderer, TextureHandle texture);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderViewport")]
    int SetRenderViewport(RendererHandle renderer, [NativeTypeName("const SDL_Rect *")] Rect* rect);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderViewport")]
    int SetRenderViewport(
        RendererHandle renderer,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderVSync")]
    int SetRenderVSync(RendererHandle renderer, int vsync);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetStringProperty")]
    int SetStringProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const char *")] sbyte* value
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetStringProperty")]
    int SetStringProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("const char *")] Ref<sbyte> value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceAlphaMod")]
    int SetSurfaceAlphaMod(Surface* surface, [NativeTypeName("Uint8")] byte alpha);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceAlphaMod")]
    int SetSurfaceAlphaMod(Ref<Surface> surface, [NativeTypeName("Uint8")] byte alpha);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceBlendMode")]
    int SetSurfaceBlendMode(Surface* surface, BlendMode blendMode);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceBlendMode")]
    int SetSurfaceBlendMode(Ref<Surface> surface, BlendMode blendMode);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceClipRect")]
    int SetSurfaceClipRect(Surface* surface, [NativeTypeName("const SDL_Rect *")] Rect* rect);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceClipRect")]
    MaybeBool<int> SetSurfaceClipRect(
        Ref<Surface> surface,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorKey")]
    int SetSurfaceColorKey(Surface* surface, int flag, [NativeTypeName("Uint32")] uint key);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorKey")]
    int SetSurfaceColorKey(Ref<Surface> surface, int flag, [NativeTypeName("Uint32")] uint key);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorMod")]
    int SetSurfaceColorMod(
        Surface* surface,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorMod")]
    int SetSurfaceColorMod(
        Ref<Surface> surface,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorspace")]
    int SetSurfaceColorspace(Surface* surface, Colorspace colorspace);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorspace")]
    int SetSurfaceColorspace(Ref<Surface> surface, Colorspace colorspace);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfacePalette")]
    int SetSurfacePalette(Surface* surface, Palette* palette);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfacePalette")]
    int SetSurfacePalette(Ref<Surface> surface, Ref<Palette> palette);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceRLE")]
    int SetSurfaceRLE(Surface* surface, int flag);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceRLE")]
    int SetSurfaceRLE(Ref<Surface> surface, int flag);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextInputRect")]
    int SetTextInputRect([NativeTypeName("const SDL_Rect *")] Rect* rect);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextInputRect")]
    int SetTextInputRect([NativeTypeName("const SDL_Rect *")] Ref<Rect> rect);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaMod")]
    int SetTextureAlphaMod(TextureHandle texture, [NativeTypeName("Uint8")] byte alpha);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaModFloat")]
    int SetTextureAlphaModFloat(TextureHandle texture, float alpha);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureBlendMode")]
    int SetTextureBlendMode(TextureHandle texture, BlendMode blendMode);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorMod")]
    int SetTextureColorMod(
        TextureHandle texture,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorModFloat")]
    int SetTextureColorModFloat(TextureHandle texture, float r, float g, float b);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureScaleMode")]
    int SetTextureScaleMode(TextureHandle texture, ScaleMode scaleMode);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetThreadPriority")]
    int SetThreadPriority(ThreadPriority priority);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetTLS")]
    int SetTLS(
        [NativeTypeName("SDL_TLSID")] uint id,
        [NativeTypeName("const void *")] void* value,
        [NativeTypeName("void (*)(void *)")] delegate* unmanaged<void*, void> destructor
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTLS")]
    int SetTLS(
        [NativeTypeName("SDL_TLSID")] uint id,
        [NativeTypeName("const void *")] Ref value,
        [NativeTypeName("void (*)(void *)")] delegate* unmanaged<void*, void> destructor
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAlwaysOnTop")]
    int SetWindowAlwaysOnTop(WindowHandle window, [NativeTypeName("SDL_bool")] int on_top);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAlwaysOnTop")]
    int SetWindowAlwaysOnTop(
        WindowHandle window,
        [NativeTypeName("SDL_bool")] MaybeBool<int> on_top
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowBordered")]
    int SetWindowBordered(WindowHandle window, [NativeTypeName("SDL_bool")] int bordered);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowBordered")]
    int SetWindowBordered(
        WindowHandle window,
        [NativeTypeName("SDL_bool")] MaybeBool<int> bordered
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFocusable")]
    int SetWindowFocusable(WindowHandle window, [NativeTypeName("SDL_bool")] int focusable);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFocusable")]
    int SetWindowFocusable(
        WindowHandle window,
        [NativeTypeName("SDL_bool")] MaybeBool<int> focusable
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreen")]
    int SetWindowFullscreen(WindowHandle window, [NativeTypeName("SDL_bool")] int fullscreen);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreen")]
    int SetWindowFullscreen(
        WindowHandle window,
        [NativeTypeName("SDL_bool")] MaybeBool<int> fullscreen
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreenMode")]
    int SetWindowFullscreenMode(
        WindowHandle window,
        [NativeTypeName("const SDL_DisplayMode *")] DisplayMode* mode
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreenMode")]
    int SetWindowFullscreenMode(
        WindowHandle window,
        [NativeTypeName("const SDL_DisplayMode *")] Ref<DisplayMode> mode
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowHitTest")]
    int SetWindowHitTest(
        WindowHandle window,
        [NativeTypeName("SDL_HitTest")]
            delegate* unmanaged<WindowHandle, Point*, void*, HitTestResult> callback,
        void* callback_data
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowHitTest")]
    int SetWindowHitTest(
        WindowHandle window,
        [NativeTypeName("SDL_HitTest")]
            delegate* unmanaged<WindowHandle, Point*, void*, HitTestResult> callback,
        Ref callback_data
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowIcon")]
    int SetWindowIcon(WindowHandle window, Surface* icon);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowIcon")]
    int SetWindowIcon(WindowHandle window, Ref<Surface> icon);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowInputFocus")]
    int SetWindowInputFocus(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowKeyboardGrab")]
    int SetWindowKeyboardGrab(WindowHandle window, [NativeTypeName("SDL_bool")] int grabbed);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowKeyboardGrab")]
    int SetWindowKeyboardGrab(
        WindowHandle window,
        [NativeTypeName("SDL_bool")] MaybeBool<int> grabbed
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMaximumSize")]
    int SetWindowMaximumSize(WindowHandle window, int max_w, int max_h);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMinimumSize")]
    int SetWindowMinimumSize(WindowHandle window, int min_w, int min_h);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowModalFor")]
    int SetWindowModalFor(WindowHandle modal_window, WindowHandle parent_window);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseGrab")]
    int SetWindowMouseGrab(WindowHandle window, [NativeTypeName("SDL_bool")] int grabbed);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseGrab")]
    int SetWindowMouseGrab(
        WindowHandle window,
        [NativeTypeName("SDL_bool")] MaybeBool<int> grabbed
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseRect")]
    int SetWindowMouseRect(WindowHandle window, [NativeTypeName("const SDL_Rect *")] Rect* rect);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseRect")]
    int SetWindowMouseRect(
        WindowHandle window,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowOpacity")]
    int SetWindowOpacity(WindowHandle window, float opacity);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowPosition")]
    int SetWindowPosition(WindowHandle window, int x, int y);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowResizable")]
    int SetWindowResizable(WindowHandle window, [NativeTypeName("SDL_bool")] int resizable);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowResizable")]
    int SetWindowResizable(
        WindowHandle window,
        [NativeTypeName("SDL_bool")] MaybeBool<int> resizable
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowShape")]
    int SetWindowShape(WindowHandle window, Surface* shape);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowShape")]
    int SetWindowShape(WindowHandle window, Ref<Surface> shape);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSize")]
    int SetWindowSize(WindowHandle window, int w, int h);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowTitle")]
    int SetWindowTitle(WindowHandle window, [NativeTypeName("const char *")] sbyte* title);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowTitle")]
    int SetWindowTitle(WindowHandle window, [NativeTypeName("const char *")] Ref<sbyte> title);

    [NativeFunction("SDL3", EntryPoint = "SDL_ShowCursor")]
    int ShowCursor();

    [NativeFunction("SDL3", EntryPoint = "SDL_ShowMessageBox")]
    int ShowMessageBox(
        [NativeTypeName("const SDL_MessageBoxData *")] MessageBoxData* messageboxdata,
        int* buttonid
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowMessageBox")]
    int ShowMessageBox(
        [NativeTypeName("const SDL_MessageBoxData *")] Ref<MessageBoxData> messageboxdata,
        Ref<int> buttonid
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFileDialog")]
    void ShowOpenFileDialog(
        [NativeTypeName("SDL_DialogFileCallback")]
            delegate* unmanaged<void*, sbyte**, int, void> callback,
        void* userdata,
        WindowHandle window,
        [NativeTypeName("const SDL_DialogFileFilter *")] DialogFileFilter* filters,
        [NativeTypeName("const char *")] sbyte* default_location,
        [NativeTypeName("SDL_bool")] int allow_many
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFileDialog")]
    void ShowOpenFileDialog(
        [NativeTypeName("SDL_DialogFileCallback")]
            delegate* unmanaged<void*, sbyte**, int, void> callback,
        Ref userdata,
        WindowHandle window,
        [NativeTypeName("const SDL_DialogFileFilter *")] Ref<DialogFileFilter> filters,
        [NativeTypeName("const char *")] Ref<sbyte> default_location,
        [NativeTypeName("SDL_bool")] MaybeBool<int> allow_many
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFolderDialog")]
    void ShowOpenFolderDialog(
        [NativeTypeName("SDL_DialogFileCallback")]
            delegate* unmanaged<void*, sbyte**, int, void> callback,
        void* userdata,
        WindowHandle window,
        [NativeTypeName("const char *")] sbyte* default_location,
        [NativeTypeName("SDL_bool")] int allow_many
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFolderDialog")]
    void ShowOpenFolderDialog(
        [NativeTypeName("SDL_DialogFileCallback")]
            delegate* unmanaged<void*, sbyte**, int, void> callback,
        Ref userdata,
        WindowHandle window,
        [NativeTypeName("const char *")] Ref<sbyte> default_location,
        [NativeTypeName("SDL_bool")] MaybeBool<int> allow_many
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ShowSaveFileDialog")]
    void ShowSaveFileDialog(
        [NativeTypeName("SDL_DialogFileCallback")]
            delegate* unmanaged<void*, sbyte**, int, void> callback,
        void* userdata,
        WindowHandle window,
        [NativeTypeName("const SDL_DialogFileFilter *")] DialogFileFilter* filters,
        [NativeTypeName("const char *")] sbyte* default_location
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowSaveFileDialog")]
    void ShowSaveFileDialog(
        [NativeTypeName("SDL_DialogFileCallback")]
            delegate* unmanaged<void*, sbyte**, int, void> callback,
        Ref userdata,
        WindowHandle window,
        [NativeTypeName("const SDL_DialogFileFilter *")] Ref<DialogFileFilter> filters,
        [NativeTypeName("const char *")] Ref<sbyte> default_location
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ShowSimpleMessageBox")]
    int ShowSimpleMessageBox(
        [NativeTypeName("Uint32")] uint flags,
        [NativeTypeName("const char *")] sbyte* title,
        [NativeTypeName("const char *")] sbyte* message,
        WindowHandle window
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowSimpleMessageBox")]
    int ShowSimpleMessageBox(
        [NativeTypeName("Uint32")] uint flags,
        [NativeTypeName("const char *")] Ref<sbyte> title,
        [NativeTypeName("const char *")] Ref<sbyte> message,
        WindowHandle window
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindow")]
    int ShowWindow(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindowSystemMenu")]
    int ShowWindowSystemMenu(WindowHandle window, int x, int y);

    [NativeFunction("SDL3", EntryPoint = "SDL_SignalCondition")]
    int SignalCondition(ConditionHandle cond);

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SIMDGetAlignment")]
    nuint SimdGetAlignment();

    [NativeFunction("SDL3", EntryPoint = "SDL_SoftStretch")]
    int SoftStretch(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* dstrect,
        ScaleMode scaleMode
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SoftStretch")]
    int SoftStretch(
        Ref<Surface> src,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect,
        ScaleMode scaleMode
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInput")]
    void StartTextInput();

    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffect")]
    int StopHapticEffect(HapticHandle haptic, int effect);

    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffects")]
    int StopHapticEffects(HapticHandle haptic);

    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticRumble")]
    int StopHapticRumble(HapticHandle haptic);

    [NativeFunction("SDL3", EntryPoint = "SDL_StopTextInput")]
    void StopTextInput();

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_StorageReady")]
    MaybeBool<int> StorageReady(StorageHandle storage);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StorageReady")]
    int StorageReadyRaw(StorageHandle storage);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasColorKey")]
    int SurfaceHasColorKey(Surface* surface);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasColorKey")]
    MaybeBool<int> SurfaceHasColorKey(Ref<Surface> surface);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasRLE")]
    int SurfaceHasRLE(Surface* surface);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasRLE")]
    MaybeBool<int> SurfaceHasRLE(Ref<Surface> surface);

    [NativeFunction("SDL3", EntryPoint = "SDL_SyncWindow")]
    int SyncWindow(WindowHandle window);

    [return: NativeTypeName("Sint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TellIO")]
    long TellIO(IOStreamHandle context);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_TextInputActive")]
    MaybeBool<int> TextInputActive();

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TextInputActive")]
    int TextInputActiveRaw();

    [return: NativeTypeName("SDL_Time")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TimeFromWindows")]
    long TimeFromWindows(
        [NativeTypeName("Uint32")] uint dwLowDateTime,
        [NativeTypeName("Uint32")] uint dwHighDateTime
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_TimeToDateTime")]
    int TimeToDateTime(
        [NativeTypeName("SDL_Time")] long ticks,
        DateTime* dt,
        [NativeTypeName("SDL_bool")] int localTime
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_TimeToDateTime")]
    int TimeToDateTime(
        [NativeTypeName("SDL_Time")] long ticks,
        Ref<DateTime> dt,
        [NativeTypeName("SDL_bool")] MaybeBool<int> localTime
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_TimeToWindows")]
    void TimeToWindows(
        [NativeTypeName("SDL_Time")] long ticks,
        [NativeTypeName("Uint32 *")] uint* dwLowDateTime,
        [NativeTypeName("Uint32 *")] uint* dwHighDateTime
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_TimeToWindows")]
    void TimeToWindows(
        [NativeTypeName("SDL_Time")] long ticks,
        [NativeTypeName("Uint32 *")] Ref<uint> dwLowDateTime,
        [NativeTypeName("Uint32 *")] Ref<uint> dwHighDateTime
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockMutex")]
    int TryLockMutex(MutexHandle mutex);

    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForReading")]
    int TryLockRWLockForReading(RWLockHandle rwlock);

    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForWriting")]
    int TryLockRWLockForWriting(RWLockHandle rwlock);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockSpinlock")]
    int TryLockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockSpinlock")]
    MaybeBool<int> TryLockSpinlock([NativeTypeName("SDL_SpinLock *")] Ref<int> @lock);

    [NativeFunction("SDL3", EntryPoint = "SDL_TryWaitSemaphore")]
    int TryWaitSemaphore(SemaphoreHandle sem);

    [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStream")]
    void UnbindAudioStream(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStreams")]
    void UnbindAudioStreams(AudioStreamHandle* streams, int num_streams);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStreams")]
    void UnbindAudioStreams(Ref<AudioStreamHandle> streams, int num_streams);

    [NativeFunction("SDL3", EntryPoint = "SDL_UnloadObject")]
    void UnloadObject(void* handle);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnloadObject")]
    void UnloadObject(Ref handle);

    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockAudioStream")]
    int UnlockAudioStream(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockJoysticks")]
    void UnlockJoysticks();

    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockMutex")]
    void UnlockMutex(MutexHandle mutex);

    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockProperties")]
    void UnlockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockRWLock")]
    void UnlockRWLock(RWLockHandle rwlock);

    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSpinlock")]
    void UnlockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSpinlock")]
    void UnlockSpinlock([NativeTypeName("SDL_SpinLock *")] Ref<int> @lock);

    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSurface")]
    void UnlockSurface(Surface* surface);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSurface")]
    void UnlockSurface(Ref<Surface> surface);

    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockTexture")]
    void UnlockTexture(TextureHandle texture);

    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateGamepads")]
    void UpdateGamepads();

    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateHapticEffect")]
    int UpdateHapticEffect(
        HapticHandle haptic,
        int effect,
        [NativeTypeName("const SDL_HapticEffect *")] HapticEffect* data
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateHapticEffect")]
    int UpdateHapticEffect(
        HapticHandle haptic,
        int effect,
        [NativeTypeName("const SDL_HapticEffect *")] Ref<HapticEffect> data
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateJoysticks")]
    void UpdateJoysticks();

    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateNVTexture")]
    int UpdateNVTexture(
        TextureHandle texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        [NativeTypeName("const Uint8 *")] byte* Yplane,
        int Ypitch,
        [NativeTypeName("const Uint8 *")] byte* UVplane,
        int UVpitch
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateNVTexture")]
    int UpdateNVTexture(
        TextureHandle texture,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        [NativeTypeName("const Uint8 *")] Ref<byte> Yplane,
        int Ypitch,
        [NativeTypeName("const Uint8 *")] Ref<byte> UVplane,
        int UVpitch
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateSensors")]
    void UpdateSensors();

    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateTexture")]
    int UpdateTexture(
        TextureHandle texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        [NativeTypeName("const void *")] void* pixels,
        int pitch
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateTexture")]
    int UpdateTexture(
        TextureHandle texture,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        [NativeTypeName("const void *")] Ref pixels,
        int pitch
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurface")]
    int UpdateWindowSurface(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurfaceRects")]
    int UpdateWindowSurfaceRects(
        WindowHandle window,
        [NativeTypeName("const SDL_Rect *")] Rect* rects,
        int numrects
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurfaceRects")]
    int UpdateWindowSurfaceRects(
        WindowHandle window,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rects,
        int numrects
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateYUVTexture")]
    int UpdateYUVTexture(
        TextureHandle texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        [NativeTypeName("const Uint8 *")] byte* Yplane,
        int Ypitch,
        [NativeTypeName("const Uint8 *")] byte* Uplane,
        int Upitch,
        [NativeTypeName("const Uint8 *")] byte* Vplane,
        int Vpitch
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateYUVTexture")]
    int UpdateYUVTexture(
        TextureHandle texture,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        [NativeTypeName("const Uint8 *")] Ref<byte> Yplane,
        int Ypitch,
        [NativeTypeName("const Uint8 *")] Ref<byte> Uplane,
        int Upitch,
        [NativeTypeName("const Uint8 *")] Ref<byte> Vplane,
        int Vpitch
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_WaitCondition")]
    int WaitCondition(ConditionHandle cond, MutexHandle mutex);

    [NativeFunction("SDL3", EntryPoint = "SDL_WaitConditionTimeout")]
    int WaitConditionTimeout(
        ConditionHandle cond,
        MutexHandle mutex,
        [NativeTypeName("Sint32")] int timeoutMS
    );

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitEvent")]
    int WaitEvent(Event* @event);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitEvent")]
    MaybeBool<int> WaitEvent(Ref<Event> @event);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitEventTimeout")]
    int WaitEventTimeout(Event* @event, [NativeTypeName("Sint32")] int timeoutMS);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitEventTimeout")]
    MaybeBool<int> WaitEventTimeout(Ref<Event> @event, [NativeTypeName("Sint32")] int timeoutMS);

    [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphore")]
    int WaitSemaphore(SemaphoreHandle sem);

    [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphoreTimeout")]
    int WaitSemaphoreTimeout(SemaphoreHandle sem, [NativeTypeName("Sint32")] int timeoutMS);

    [NativeFunction("SDL3", EntryPoint = "SDL_WaitThread")]
    void WaitThread(ThreadHandle thread, int* status);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitThread")]
    void WaitThread(ThreadHandle thread, Ref<int> status);

    [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseGlobal")]
    int WarpMouseGlobal(float x, float y);

    [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseInWindow")]
    void WarpMouseInWindow(WindowHandle window, float x, float y);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WasInit")]
    uint WasInit([NativeTypeName("Uint32")] uint flags);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WindowHasSurface")]
    MaybeBool<int> WindowHasSurface(WindowHandle window);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WindowHasSurface")]
    int WindowHasSurfaceRaw(WindowHandle window);

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteIO")]
    nuint WriteIO(
        IOStreamHandle context,
        [NativeTypeName("const void *")] void* ptr,
        [NativeTypeName("size_t")] nuint size
    );

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteIO")]
    nuint WriteIO(
        IOStreamHandle context,
        [NativeTypeName("const void *")] Ref ptr,
        [NativeTypeName("size_t")] nuint size
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16BE")]
    MaybeBool<int> WriteS16BE(IOStreamHandle dst, [NativeTypeName("Sint16")] short value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16BE")]
    int WriteS16BERaw(IOStreamHandle dst, [NativeTypeName("Sint16")] short value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16LE")]
    MaybeBool<int> WriteS16LE(IOStreamHandle dst, [NativeTypeName("Sint16")] short value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16LE")]
    int WriteS16LERaw(IOStreamHandle dst, [NativeTypeName("Sint16")] short value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32BE")]
    MaybeBool<int> WriteS32BE(IOStreamHandle dst, [NativeTypeName("Sint32")] int value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32BE")]
    int WriteS32BERaw(IOStreamHandle dst, [NativeTypeName("Sint32")] int value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32LE")]
    MaybeBool<int> WriteS32LE(IOStreamHandle dst, [NativeTypeName("Sint32")] int value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32LE")]
    int WriteS32LERaw(IOStreamHandle dst, [NativeTypeName("Sint32")] int value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64BE")]
    MaybeBool<int> WriteS64BE(IOStreamHandle dst, [NativeTypeName("Sint64")] long value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64BE")]
    int WriteS64BERaw(IOStreamHandle dst, [NativeTypeName("Sint64")] long value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64LE")]
    MaybeBool<int> WriteS64LE(IOStreamHandle dst, [NativeTypeName("Sint64")] long value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64LE")]
    int WriteS64LERaw(IOStreamHandle dst, [NativeTypeName("Sint64")] long value);

    [NativeFunction("SDL3", EntryPoint = "SDL_WriteStorageFile")]
    int WriteStorageFile(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("const void *")] void* source,
        [NativeTypeName("Uint64")] ulong length
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteStorageFile")]
    int WriteStorageFile(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path,
        [NativeTypeName("const void *")] Ref source,
        [NativeTypeName("Uint64")] ulong length
    );

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16BE")]
    MaybeBool<int> WriteU16BE(IOStreamHandle dst, [NativeTypeName("Uint16")] ushort value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16BE")]
    int WriteU16BERaw(IOStreamHandle dst, [NativeTypeName("Uint16")] ushort value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16LE")]
    MaybeBool<int> WriteU16LE(IOStreamHandle dst, [NativeTypeName("Uint16")] ushort value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16LE")]
    int WriteU16LERaw(IOStreamHandle dst, [NativeTypeName("Uint16")] ushort value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32BE")]
    MaybeBool<int> WriteU32BE(IOStreamHandle dst, [NativeTypeName("Uint32")] uint value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32BE")]
    int WriteU32BERaw(IOStreamHandle dst, [NativeTypeName("Uint32")] uint value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32LE")]
    MaybeBool<int> WriteU32LE(IOStreamHandle dst, [NativeTypeName("Uint32")] uint value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32LE")]
    int WriteU32LERaw(IOStreamHandle dst, [NativeTypeName("Uint32")] uint value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64BE")]
    MaybeBool<int> WriteU64BE(IOStreamHandle dst, [NativeTypeName("Uint64")] ulong value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64BE")]
    int WriteU64BERaw(IOStreamHandle dst, [NativeTypeName("Uint64")] ulong value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64LE")]
    MaybeBool<int> WriteU64LE(IOStreamHandle dst, [NativeTypeName("Uint64")] ulong value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64LE")]
    int WriteU64LERaw(IOStreamHandle dst, [NativeTypeName("Uint64")] ulong value);

    [return: NativeTypeName("SDL_bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU8")]
    MaybeBool<int> WriteU8(IOStreamHandle dst, [NativeTypeName("Uint8")] byte value);

    [return: NativeTypeName("SDL_bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU8")]
    int WriteU8Raw(IOStreamHandle dst, [NativeTypeName("Uint8")] byte value);
}
