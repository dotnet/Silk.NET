// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public unsafe partial interface ISdl
{
    public partial interface Static
    {
        [NativeFunction("SDL3", EntryPoint = "SDL_abs")]
        static abstract int Abs(int x);

        [NativeFunction("SDL3", EntryPoint = "SDL_acos")]
        static abstract double Acos(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_acosf")]
        static abstract float Acosf(float x);

        [NativeFunction("SDL3", EntryPoint = "SDL_AcquireCameraFrame")]
        static abstract Surface* AcquireCameraFrame(
            CameraHandle camera,
            [NativeTypeName("Uint64 *")] nuint* timestampNS
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AcquireCameraFrame")]
        static abstract Ptr<Surface> AcquireCameraFrame(
            CameraHandle camera,
            [NativeTypeName("Uint64 *")] Ref<nuint> timestampNS
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_AcquireGPUCommandBuffer")]
        static abstract GPUCommandBufferHandle AcquireGPUCommandBuffer(GPUDeviceHandle device);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AcquireGPUSwapchainTexture")]
        static abstract byte AcquireGPUSwapchainTexture(
            GPUCommandBufferHandle command_buffer,
            WindowHandle window,
            GPUTextureHandle* swapchain_texture,
            [NativeTypeName("Uint32 *")] uint* swapchain_texture_width,
            [NativeTypeName("Uint32 *")] uint* swapchain_texture_height
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AcquireGPUSwapchainTexture")]
        static abstract MaybeBool<byte> AcquireGPUSwapchainTexture(
            GPUCommandBufferHandle command_buffer,
            WindowHandle window,
            Ref<GPUTextureHandle> swapchain_texture,
            [NativeTypeName("Uint32 *")] Ref<uint> swapchain_texture_width,
            [NativeTypeName("Uint32 *")] Ref<uint> swapchain_texture_height
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_AddAtomicInt")]
        static abstract int AddAtomicInt(AtomicInt* a, int v);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddAtomicInt")]
        static abstract int AddAtomicInt(Ref<AtomicInt> a, int v);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddEventWatch")]
        static abstract byte AddEventWatch(
            [NativeTypeName("SDL_EventFilter")] EventFilter filter,
            void* userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddEventWatch")]
        static abstract MaybeBool<byte> AddEventWatch(
            [NativeTypeName("SDL_EventFilter")] EventFilter filter,
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
            [NativeTypeName("bool")] byte closeio
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromIO")]
        static abstract int AddGamepadMappingsFromIO(
            IOStreamHandle src,
            [NativeTypeName("bool")] MaybeBool<byte> closeio
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddHintCallback")]
        static abstract byte AddHintCallback(
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("SDL_HintCallback")] HintCallback callback,
            void* userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddHintCallback")]
        static abstract MaybeBool<byte> AddHintCallback(
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("SDL_HintCallback")] HintCallback callback,
            Ref userdata
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddSurfaceAlternateImage")]
        static abstract byte AddSurfaceAlternateImage(Surface* surface, Surface* image);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddSurfaceAlternateImage")]
        static abstract MaybeBool<byte> AddSurfaceAlternateImage(
            Ref<Surface> surface,
            Ref<Surface> image
        );

        [return: NativeTypeName("SDL_TimerID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddTimer")]
        static abstract uint AddTimer(
            [NativeTypeName("Uint32")] uint interval,
            [NativeTypeName("SDL_TimerCallback")] TimerCallback callback,
            void* userdata
        );

        [return: NativeTypeName("SDL_TimerID")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddTimer")]
        static abstract uint AddTimer(
            [NativeTypeName("Uint32")] uint interval,
            [NativeTypeName("SDL_TimerCallback")] TimerCallback callback,
            Ref userdata
        );

        [return: NativeTypeName("SDL_TimerID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddTimerNS")]
        static abstract uint AddTimerNS(
            [NativeTypeName("Uint64")] nuint interval,
            [NativeTypeName("SDL_NSTimerCallback")] NSTimerCallback callback,
            void* userdata
        );

        [return: NativeTypeName("SDL_TimerID")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddTimerNS")]
        static abstract uint AddTimerNS(
            [NativeTypeName("Uint64")] nuint interval,
            [NativeTypeName("SDL_NSTimerCallback")] NSTimerCallback callback,
            Ref userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddVulkanRenderSemaphores")]
        static abstract MaybeBool<byte> AddVulkanRenderSemaphores(
            RendererHandle renderer,
            [NativeTypeName("Uint32")] uint wait_stage_mask,
            [NativeTypeName("Sint64")] nint wait_semaphore,
            [NativeTypeName("Sint64")] nint signal_semaphore
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddVulkanRenderSemaphores")]
        static abstract byte AddVulkanRenderSemaphoresRaw(
            RendererHandle renderer,
            [NativeTypeName("Uint32")] uint wait_stage_mask,
            [NativeTypeName("Sint64")] nint wait_semaphore,
            [NativeTypeName("Sint64")] nint signal_semaphore
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_aligned_alloc")]
        static abstract Ptr AlignedAlloc(
            [NativeTypeName("size_t")] nuint alignment,
            [NativeTypeName("size_t")] nuint size
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_aligned_alloc")]
        static abstract void* AlignedAllocRaw(
            [NativeTypeName("size_t")] nuint alignment,
            [NativeTypeName("size_t")] nuint size
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_aligned_free")]
        static abstract void AlignedFree(void* mem);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_aligned_free")]
        static abstract void AlignedFree(Ref mem);

        [NativeFunction("SDL3", EntryPoint = "SDL_asin")]
        static abstract double Asin(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_asinf")]
        static abstract float Asinf(float x);

        [NativeFunction("SDL3", EntryPoint = "SDL_atan")]
        static abstract double Atan(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_atan2")]
        static abstract double Atan2(double y, double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_atan2f")]
        static abstract float Atan2F(float y, float x);

        [NativeFunction("SDL3", EntryPoint = "SDL_atanf")]
        static abstract float Atanf(float x);

        [NativeFunction("SDL3", EntryPoint = "SDL_atof")]
        static abstract double Atof([NativeTypeName("const char *")] sbyte* str);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_atof")]
        static abstract double Atof([NativeTypeName("const char *")] Ref<sbyte> str);

        [NativeFunction("SDL3", EntryPoint = "SDL_atoi")]
        static abstract int Atoi([NativeTypeName("const char *")] sbyte* str);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_atoi")]
        static abstract int Atoi([NativeTypeName("const char *")] Ref<sbyte> str);

        [return: NativeTypeName("SDL_JoystickID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AttachVirtualJoystick")]
        static abstract uint AttachVirtualJoystick(
            [NativeTypeName("const SDL_VirtualJoystickDesc *")] VirtualJoystickDesc* desc
        );

        [return: NativeTypeName("SDL_JoystickID")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AttachVirtualJoystick")]
        static abstract uint AttachVirtualJoystick(
            [NativeTypeName("const SDL_VirtualJoystickDesc *")] Ref<VirtualJoystickDesc> desc
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AudioDevicePaused")]
        static abstract MaybeBool<byte> AudioDevicePaused(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AudioDevicePaused")]
        static abstract byte AudioDevicePausedRaw([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_AudioStreamDevicePaused")]
        static abstract MaybeBool<byte> AudioStreamDevicePaused(AudioStreamHandle stream);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AudioStreamDevicePaused")]
        static abstract byte AudioStreamDevicePausedRaw(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPUComputePass")]
        static abstract GPUComputePassHandle BeginGPUComputePass(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("const SDL_GPUStorageTextureReadWriteBinding *")]
                GPUStorageTextureReadWriteBinding* storage_texture_bindings,
            [NativeTypeName("Uint32")] uint num_storage_texture_bindings,
            [NativeTypeName("const SDL_GPUStorageBufferReadWriteBinding *")]
                GPUStorageBufferReadWriteBinding* storage_buffer_bindings,
            [NativeTypeName("Uint32")] uint num_storage_buffer_bindings
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPUComputePass")]
        static abstract GPUComputePassHandle BeginGPUComputePass(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("const SDL_GPUStorageTextureReadWriteBinding *")]
                Ref<GPUStorageTextureReadWriteBinding> storage_texture_bindings,
            [NativeTypeName("Uint32")] uint num_storage_texture_bindings,
            [NativeTypeName("const SDL_GPUStorageBufferReadWriteBinding *")]
                Ref<GPUStorageBufferReadWriteBinding> storage_buffer_bindings,
            [NativeTypeName("Uint32")] uint num_storage_buffer_bindings
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPUCopyPass")]
        static abstract GPUCopyPassHandle BeginGPUCopyPass(GPUCommandBufferHandle command_buffer);

        [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPURenderPass")]
        static abstract GPURenderPassHandle BeginGPURenderPass(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("const SDL_GPUColorTargetInfo *")]
                GPUColorTargetInfo* color_target_infos,
            [NativeTypeName("Uint32")] uint num_color_targets,
            [NativeTypeName("const SDL_GPUDepthStencilTargetInfo *")]
                GPUDepthStencilTargetInfo* depth_stencil_target_info
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPURenderPass")]
        static abstract GPURenderPassHandle BeginGPURenderPass(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("const SDL_GPUColorTargetInfo *")]
                Ref<GPUColorTargetInfo> color_target_infos,
            [NativeTypeName("Uint32")] uint num_color_targets,
            [NativeTypeName("const SDL_GPUDepthStencilTargetInfo *")]
                Ref<GPUDepthStencilTargetInfo> depth_stencil_target_info
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStream")]
        static abstract MaybeBool<byte> BindAudioStream(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            AudioStreamHandle stream
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStream")]
        static abstract byte BindAudioStreamRaw(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            AudioStreamHandle stream
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStreams")]
        static abstract byte BindAudioStreams(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            [NativeTypeName("SDL_AudioStream *const *")] AudioStreamHandle* streams,
            int num_streams
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStreams")]
        static abstract MaybeBool<byte> BindAudioStreams(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            [NativeTypeName("SDL_AudioStream *const *")] Ref<AudioStreamHandle> streams,
            int num_streams
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputePipeline")]
        static abstract void BindGPUComputePipeline(
            GPUComputePassHandle compute_pass,
            GPUComputePipelineHandle compute_pipeline
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeSamplers")]
        static abstract void BindGPUComputeSamplers(
            GPUComputePassHandle compute_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
                GPUTextureSamplerBinding* texture_sampler_bindings,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeSamplers")]
        static abstract void BindGPUComputeSamplers(
            GPUComputePassHandle compute_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
                Ref<GPUTextureSamplerBinding> texture_sampler_bindings,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageBuffers")]
        static abstract void BindGPUComputeStorageBuffers(
            GPUComputePassHandle compute_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("SDL_GPUBuffer *const *")] GPUBufferHandle* storage_buffers,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageBuffers")]
        static abstract void BindGPUComputeStorageBuffers(
            GPUComputePassHandle compute_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("SDL_GPUBuffer *const *")] Ref<GPUBufferHandle> storage_buffers,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageTextures")]
        static abstract void BindGPUComputeStorageTextures(
            GPUComputePassHandle compute_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("SDL_GPUTexture *const *")] GPUTextureHandle* storage_textures,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageTextures")]
        static abstract void BindGPUComputeStorageTextures(
            GPUComputePassHandle compute_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("SDL_GPUTexture *const *")] Ref<GPUTextureHandle> storage_textures,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentSamplers")]
        static abstract void BindGPUFragmentSamplers(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
                GPUTextureSamplerBinding* texture_sampler_bindings,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentSamplers")]
        static abstract void BindGPUFragmentSamplers(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
                Ref<GPUTextureSamplerBinding> texture_sampler_bindings,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageBuffers")]
        static abstract void BindGPUFragmentStorageBuffers(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("SDL_GPUBuffer *const *")] GPUBufferHandle* storage_buffers,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageBuffers")]
        static abstract void BindGPUFragmentStorageBuffers(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("SDL_GPUBuffer *const *")] Ref<GPUBufferHandle> storage_buffers,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageTextures")]
        static abstract void BindGPUFragmentStorageTextures(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("SDL_GPUTexture *const *")] GPUTextureHandle* storage_textures,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageTextures")]
        static abstract void BindGPUFragmentStorageTextures(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("SDL_GPUTexture *const *")] Ref<GPUTextureHandle> storage_textures,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUGraphicsPipeline")]
        static abstract void BindGPUGraphicsPipeline(
            GPURenderPassHandle render_pass,
            GPUGraphicsPipelineHandle graphics_pipeline
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUIndexBuffer")]
        static abstract void BindGPUIndexBuffer(
            GPURenderPassHandle render_pass,
            [NativeTypeName("const SDL_GPUBufferBinding *")] GPUBufferBinding* binding,
            GPUIndexElementSize index_element_size
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUIndexBuffer")]
        static abstract void BindGPUIndexBuffer(
            GPURenderPassHandle render_pass,
            [NativeTypeName("const SDL_GPUBufferBinding *")] Ref<GPUBufferBinding> binding,
            GPUIndexElementSize index_element_size
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexBuffers")]
        static abstract void BindGPUVertexBuffers(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("const SDL_GPUBufferBinding *")] GPUBufferBinding* bindings,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexBuffers")]
        static abstract void BindGPUVertexBuffers(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("const SDL_GPUBufferBinding *")] Ref<GPUBufferBinding> bindings,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexSamplers")]
        static abstract void BindGPUVertexSamplers(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
                GPUTextureSamplerBinding* texture_sampler_bindings,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexSamplers")]
        static abstract void BindGPUVertexSamplers(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
                Ref<GPUTextureSamplerBinding> texture_sampler_bindings,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageBuffers")]
        static abstract void BindGPUVertexStorageBuffers(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("SDL_GPUBuffer *const *")] GPUBufferHandle* storage_buffers,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageBuffers")]
        static abstract void BindGPUVertexStorageBuffers(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("SDL_GPUBuffer *const *")] Ref<GPUBufferHandle> storage_buffers,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageTextures")]
        static abstract void BindGPUVertexStorageTextures(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("SDL_GPUTexture *const *")] GPUTextureHandle* storage_textures,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageTextures")]
        static abstract void BindGPUVertexStorageTextures(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint first_slot,
            [NativeTypeName("SDL_GPUTexture *const *")] Ref<GPUTextureHandle> storage_textures,
            [NativeTypeName("Uint32")] uint num_bindings
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BlitGPUTexture")]
        static abstract void BlitGPUTexture(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("const SDL_GPUBlitInfo *")] GPUBlitInfo* info
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitGPUTexture")]
        static abstract void BlitGPUTexture(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("const SDL_GPUBlitInfo *")] Ref<GPUBlitInfo> info
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface")]
        static abstract byte BlitSurface(
            Surface* src,
            [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* dstrect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface")]
        static abstract MaybeBool<byte> BlitSurface(
            Ref<Surface> src,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface9Grid")]
        static abstract byte BlitSurface9Grid(
            Surface* src,
            [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
            int left_width,
            int right_width,
            int top_height,
            int bottom_height,
            float scale,
            ScaleMode scaleMode,
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* dstrect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface9Grid")]
        static abstract MaybeBool<byte> BlitSurface9Grid(
            Ref<Surface> src,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
            int left_width,
            int right_width,
            int top_height,
            int bottom_height,
            float scale,
            ScaleMode scaleMode,
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceScaled")]
        static abstract byte BlitSurfaceScaled(
            Surface* src,
            [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* dstrect,
            ScaleMode scaleMode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceScaled")]
        static abstract MaybeBool<byte> BlitSurfaceScaled(
            Ref<Surface> src,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect,
            ScaleMode scaleMode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiled")]
        static abstract byte BlitSurfaceTiled(
            Surface* src,
            [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* dstrect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiled")]
        static abstract MaybeBool<byte> BlitSurfaceTiled(
            Ref<Surface> src,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiledWithScale")]
        static abstract byte BlitSurfaceTiledWithScale(
            Surface* src,
            [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
            float scale,
            ScaleMode scaleMode,
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* dstrect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiledWithScale")]
        static abstract MaybeBool<byte> BlitSurfaceTiledWithScale(
            Ref<Surface> src,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
            float scale,
            ScaleMode scaleMode,
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUnchecked")]
        static abstract byte BlitSurfaceUnchecked(
            Surface* src,
            [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* dstrect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUnchecked")]
        static abstract MaybeBool<byte> BlitSurfaceUnchecked(
            Ref<Surface> src,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUncheckedScaled")]
        static abstract byte BlitSurfaceUncheckedScaled(
            Surface* src,
            [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* dstrect,
            ScaleMode scaleMode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUncheckedScaled")]
        static abstract MaybeBool<byte> BlitSurfaceUncheckedScaled(
            Ref<Surface> src,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect,
            ScaleMode scaleMode
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_BroadcastCondition")]
        static abstract void BroadcastCondition(ConditionHandle cond);

        [NativeFunction("SDL3", EntryPoint = "SDL_bsearch")]
        static abstract void* Bsearch(
            [NativeTypeName("const void *")] void* key,
            [NativeTypeName("const void *")] void* @base,
            [NativeTypeName("size_t")] nuint nmemb,
            [NativeTypeName("size_t")] nuint size,
            [NativeTypeName("SDL_CompareCallback")] CompareCallback compare
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_bsearch")]
        static abstract Ptr Bsearch(
            [NativeTypeName("const void *")] Ref key,
            [NativeTypeName("const void *")] Ref @base,
            [NativeTypeName("size_t")] nuint nmemb,
            [NativeTypeName("size_t")] nuint size,
            [NativeTypeName("SDL_CompareCallback")] CompareCallback compare
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_bsearch_r")]
        static abstract void* BsearchR(
            [NativeTypeName("const void *")] void* key,
            [NativeTypeName("const void *")] void* @base,
            [NativeTypeName("size_t")] nuint nmemb,
            [NativeTypeName("size_t")] nuint size,
            [NativeTypeName("SDL_CompareCallback_r")] CompareCallbackR compare,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_bsearch_r")]
        static abstract Ptr BsearchR(
            [NativeTypeName("const void *")] Ref key,
            [NativeTypeName("const void *")] Ref @base,
            [NativeTypeName("size_t")] nuint nmemb,
            [NativeTypeName("size_t")] nuint size,
            [NativeTypeName("SDL_CompareCallback_r")] CompareCallbackR compare,
            Ref userdata
        );

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CalculateGPUTextureFormatSize")]
        static abstract uint CalculateGPUTextureFormatSize(
            GPUTextureFormat format,
            [NativeTypeName("Uint32")] uint width,
            [NativeTypeName("Uint32")] uint height,
            [NativeTypeName("Uint32")] uint depth_or_layer_count
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_calloc")]
        static abstract Ptr Calloc(
            [NativeTypeName("size_t")] nuint nmemb,
            [NativeTypeName("size_t")] nuint size
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_calloc")]
        static abstract void* CallocRaw(
            [NativeTypeName("size_t")] nuint nmemb,
            [NativeTypeName("size_t")] nuint size
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CancelGPUCommandBuffer")]
        static abstract MaybeBool<byte> CancelGPUCommandBuffer(
            GPUCommandBufferHandle command_buffer
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CancelGPUCommandBuffer")]
        static abstract byte CancelGPUCommandBufferRaw(GPUCommandBufferHandle command_buffer);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CaptureMouse")]
        static abstract byte CaptureMouse([NativeTypeName("bool")] byte enabled);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CaptureMouse")]
        static abstract MaybeBool<byte> CaptureMouse(
            [NativeTypeName("bool")] MaybeBool<byte> enabled
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ceil")]
        static abstract double Ceil(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_ceilf")]
        static abstract float Ceilf(float x);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClaimWindowForGPUDevice")]
        static abstract MaybeBool<byte> ClaimWindowForGPUDevice(
            GPUDeviceHandle device,
            WindowHandle window
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClaimWindowForGPUDevice")]
        static abstract byte ClaimWindowForGPUDeviceRaw(
            GPUDeviceHandle device,
            WindowHandle window
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CleanupTLS")]
        static abstract void CleanupTLS();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearAudioStream")]
        static abstract MaybeBool<byte> ClearAudioStream(AudioStreamHandle stream);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearAudioStream")]
        static abstract byte ClearAudioStreamRaw(AudioStreamHandle stream);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearClipboardData")]
        static abstract MaybeBool<byte> ClearClipboardData();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearClipboardData")]
        static abstract byte ClearClipboardDataRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearComposition")]
        static abstract MaybeBool<byte> ClearComposition(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearComposition")]
        static abstract byte ClearCompositionRaw(WindowHandle window);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearError")]
        static abstract MaybeBool<byte> ClearError();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearError")]
        static abstract byte ClearErrorRaw();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearProperty")]
        static abstract byte ClearProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearProperty")]
        static abstract MaybeBool<byte> ClearProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearSurface")]
        static abstract byte ClearSurface(Surface* surface, float r, float g, float b, float a);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearSurface")]
        static abstract MaybeBool<byte> ClearSurface(
            Ref<Surface> surface,
            float r,
            float g,
            float b,
            float a
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CloseAudioDevice")]
        static abstract void CloseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [NativeFunction("SDL3", EntryPoint = "SDL_CloseCamera")]
        static abstract void CloseCamera(CameraHandle camera);

        [NativeFunction("SDL3", EntryPoint = "SDL_CloseGamepad")]
        static abstract void CloseGamepad(GamepadHandle gamepad);

        [NativeFunction("SDL3", EntryPoint = "SDL_CloseHaptic")]
        static abstract void CloseHaptic(HapticHandle haptic);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CloseIO")]
        static abstract MaybeBool<byte> CloseIO(IOStreamHandle context);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CloseIO")]
        static abstract byte CloseIORaw(IOStreamHandle context);

        [NativeFunction("SDL3", EntryPoint = "SDL_CloseJoystick")]
        static abstract void CloseJoystick(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_CloseSensor")]
        static abstract void CloseSensor(SensorHandle sensor);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CloseStorage")]
        static abstract MaybeBool<byte> CloseStorage(StorageHandle storage);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CloseStorage")]
        static abstract byte CloseStorageRaw(StorageHandle storage);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicInt")]
        static abstract byte CompareAndSwapAtomicInt(AtomicInt* a, int oldval, int newval);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicInt")]
        static abstract MaybeBool<byte> CompareAndSwapAtomicInt(
            Ref<AtomicInt> a,
            int oldval,
            int newval
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicPointer")]
        static abstract byte CompareAndSwapAtomicPointer(void** a, void* oldval, void* newval);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicPointer")]
        static abstract MaybeBool<byte> CompareAndSwapAtomicPointer(
            Ref2D a,
            Ref oldval,
            Ref newval
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicU32")]
        static abstract byte CompareAndSwapAtomicU32(
            AtomicU32* a,
            [NativeTypeName("Uint32")] uint oldval,
            [NativeTypeName("Uint32")] uint newval
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicU32")]
        static abstract MaybeBool<byte> CompareAndSwapAtomicU32(
            Ref<AtomicU32> a,
            [NativeTypeName("Uint32")] uint oldval,
            [NativeTypeName("Uint32")] uint newval
        );

        [return: NativeTypeName("SDL_BlendMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ComposeCustomBlendMode")]
        static abstract uint ComposeCustomBlendMode(
            BlendFactor srcColorFactor,
            BlendFactor dstColorFactor,
            BlendOperation colorOperation,
            BlendFactor srcAlphaFactor,
            BlendFactor dstAlphaFactor,
            BlendOperation alphaOperation
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertAudioSamples")]
        static abstract byte ConvertAudioSamples(
            [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* src_spec,
            [NativeTypeName("const Uint8 *")] byte* src_data,
            int src_len,
            [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* dst_spec,
            [NativeTypeName("Uint8 **")] byte** dst_data,
            int* dst_len
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertAudioSamples")]
        static abstract MaybeBool<byte> ConvertAudioSamples(
            [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> src_spec,
            [NativeTypeName("const Uint8 *")] Ref<byte> src_data,
            int src_len,
            [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> dst_spec,
            [NativeTypeName("Uint8 **")] Ref2D<byte> dst_data,
            Ref<int> dst_len
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertEventToRenderCoordinates")]
        static abstract byte ConvertEventToRenderCoordinates(
            RendererHandle renderer,
            Event* @event
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertEventToRenderCoordinates")]
        static abstract MaybeBool<byte> ConvertEventToRenderCoordinates(
            RendererHandle renderer,
            Ref<Event> @event
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixels")]
        static abstract byte ConvertPixels(
            int width,
            int height,
            PixelFormat src_format,
            [NativeTypeName("const void *")] void* src,
            int src_pitch,
            PixelFormat dst_format,
            void* dst,
            int dst_pitch
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixels")]
        static abstract MaybeBool<byte> ConvertPixels(
            int width,
            int height,
            PixelFormat src_format,
            [NativeTypeName("const void *")] Ref src,
            int src_pitch,
            PixelFormat dst_format,
            Ref dst,
            int dst_pitch
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixelsAndColorspace")]
        static abstract byte ConvertPixelsAndColorspace(
            int width,
            int height,
            PixelFormat src_format,
            Colorspace src_colorspace,
            [NativeTypeName("SDL_PropertiesID")] uint src_properties,
            [NativeTypeName("const void *")] void* src,
            int src_pitch,
            PixelFormat dst_format,
            Colorspace dst_colorspace,
            [NativeTypeName("SDL_PropertiesID")] uint dst_properties,
            void* dst,
            int dst_pitch
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixelsAndColorspace")]
        static abstract MaybeBool<byte> ConvertPixelsAndColorspace(
            int width,
            int height,
            PixelFormat src_format,
            Colorspace src_colorspace,
            [NativeTypeName("SDL_PropertiesID")] uint src_properties,
            [NativeTypeName("const void *")] Ref src,
            int src_pitch,
            PixelFormat dst_format,
            Colorspace dst_colorspace,
            [NativeTypeName("SDL_PropertiesID")] uint dst_properties,
            Ref dst,
            int dst_pitch
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurface")]
        static abstract Surface* ConvertSurface(Surface* surface, PixelFormat format);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurface")]
        static abstract Ptr<Surface> ConvertSurface(Ref<Surface> surface, PixelFormat format);

        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceAndColorspace")]
        static abstract Surface* ConvertSurfaceAndColorspace(
            Surface* surface,
            PixelFormat format,
            Palette* palette,
            Colorspace colorspace,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceAndColorspace")]
        static abstract Ptr<Surface> ConvertSurfaceAndColorspace(
            Ref<Surface> surface,
            PixelFormat format,
            Ref<Palette> palette,
            Colorspace colorspace,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyFile")]
        static abstract byte CopyFile(
            [NativeTypeName("const char *")] sbyte* oldpath,
            [NativeTypeName("const char *")] sbyte* newpath
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyFile")]
        static abstract MaybeBool<byte> CopyFile(
            [NativeTypeName("const char *")] Ref<sbyte> oldpath,
            [NativeTypeName("const char *")] Ref<sbyte> newpath
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUBufferToBuffer")]
        static abstract void CopyGPUBufferToBuffer(
            GPUCopyPassHandle copy_pass,
            [NativeTypeName("const SDL_GPUBufferLocation *")] GPUBufferLocation* source,
            [NativeTypeName("const SDL_GPUBufferLocation *")] GPUBufferLocation* destination,
            [NativeTypeName("Uint32")] uint size,
            [NativeTypeName("bool")] byte cycle
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUBufferToBuffer")]
        static abstract void CopyGPUBufferToBuffer(
            GPUCopyPassHandle copy_pass,
            [NativeTypeName("const SDL_GPUBufferLocation *")] Ref<GPUBufferLocation> source,
            [NativeTypeName("const SDL_GPUBufferLocation *")] Ref<GPUBufferLocation> destination,
            [NativeTypeName("Uint32")] uint size,
            [NativeTypeName("bool")] MaybeBool<byte> cycle
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUTextureToTexture")]
        static abstract void CopyGPUTextureToTexture(
            GPUCopyPassHandle copy_pass,
            [NativeTypeName("const SDL_GPUTextureLocation *")] GPUTextureLocation* source,
            [NativeTypeName("const SDL_GPUTextureLocation *")] GPUTextureLocation* destination,
            [NativeTypeName("Uint32")] uint w,
            [NativeTypeName("Uint32")] uint h,
            [NativeTypeName("Uint32")] uint d,
            [NativeTypeName("bool")] byte cycle
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUTextureToTexture")]
        static abstract void CopyGPUTextureToTexture(
            GPUCopyPassHandle copy_pass,
            [NativeTypeName("const SDL_GPUTextureLocation *")] Ref<GPUTextureLocation> source,
            [NativeTypeName("const SDL_GPUTextureLocation *")] Ref<GPUTextureLocation> destination,
            [NativeTypeName("Uint32")] uint w,
            [NativeTypeName("Uint32")] uint h,
            [NativeTypeName("Uint32")] uint d,
            [NativeTypeName("bool")] MaybeBool<byte> cycle
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyProperties")]
        static abstract MaybeBool<byte> CopyProperties(
            [NativeTypeName("SDL_PropertiesID")] uint src,
            [NativeTypeName("SDL_PropertiesID")] uint dst
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyProperties")]
        static abstract byte CopyPropertiesRaw(
            [NativeTypeName("SDL_PropertiesID")] uint src,
            [NativeTypeName("SDL_PropertiesID")] uint dst
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_copysign")]
        static abstract double Copysign(double x, double y);

        [NativeFunction("SDL3", EntryPoint = "SDL_copysignf")]
        static abstract float Copysignf(float x, float y);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyStorageFile")]
        static abstract byte CopyStorageFile(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* oldpath,
            [NativeTypeName("const char *")] sbyte* newpath
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyStorageFile")]
        static abstract MaybeBool<byte> CopyStorageFile(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> oldpath,
            [NativeTypeName("const char *")] Ref<sbyte> newpath
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_cos")]
        static abstract double Cos(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_cosf")]
        static abstract float Cosf(float x);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_crc16")]
        static abstract ushort Crc16(
            [NativeTypeName("Uint16")] ushort crc,
            [NativeTypeName("const void *")] void* data,
            [NativeTypeName("size_t")] nuint len
        );

        [return: NativeTypeName("Uint16")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_crc16")]
        static abstract ushort Crc16(
            [NativeTypeName("Uint16")] ushort crc,
            [NativeTypeName("const void *")] Ref data,
            [NativeTypeName("size_t")] nuint len
        );

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_crc32")]
        static abstract uint Crc32(
            [NativeTypeName("Uint32")] uint crc,
            [NativeTypeName("const void *")] void* data,
            [NativeTypeName("size_t")] nuint len
        );

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_crc32")]
        static abstract uint Crc32(
            [NativeTypeName("Uint32")] uint crc,
            [NativeTypeName("const void *")] Ref data,
            [NativeTypeName("size_t")] nuint len
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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateDirectory")]
        static abstract byte CreateDirectory([NativeTypeName("const char *")] sbyte* path);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateDirectory")]
        static abstract MaybeBool<byte> CreateDirectory(
            [NativeTypeName("const char *")] Ref<sbyte> path
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateEnvironment")]
        static abstract EnvironmentHandle CreateEnvironment(
            [NativeTypeName("bool")] byte populated
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateEnvironment")]
        static abstract EnvironmentHandle CreateEnvironment(
            [NativeTypeName("bool")] MaybeBool<byte> populated
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUBuffer")]
        static abstract GPUBufferHandle CreateGPUBuffer(
            GPUDeviceHandle device,
            [NativeTypeName("const SDL_GPUBufferCreateInfo *")] GPUBufferCreateInfo* createinfo
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUBuffer")]
        static abstract GPUBufferHandle CreateGPUBuffer(
            GPUDeviceHandle device,
            [NativeTypeName("const SDL_GPUBufferCreateInfo *")] Ref<GPUBufferCreateInfo> createinfo
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUComputePipeline")]
        static abstract GPUComputePipelineHandle CreateGPUComputePipeline(
            GPUDeviceHandle device,
            [NativeTypeName("const SDL_GPUComputePipelineCreateInfo *")]
                GPUComputePipelineCreateInfo* createinfo
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUComputePipeline")]
        static abstract GPUComputePipelineHandle CreateGPUComputePipeline(
            GPUDeviceHandle device,
            [NativeTypeName("const SDL_GPUComputePipelineCreateInfo *")]
                Ref<GPUComputePipelineCreateInfo> createinfo
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUDevice")]
        static abstract GPUDeviceHandle CreateGPUDevice(
            [NativeTypeName("SDL_GPUShaderFormat")] uint format_flags,
            [NativeTypeName("bool")] byte debug_mode,
            [NativeTypeName("const char *")] sbyte* name
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUDevice")]
        static abstract GPUDeviceHandle CreateGPUDevice(
            [NativeTypeName("SDL_GPUShaderFormat")] uint format_flags,
            [NativeTypeName("bool")] MaybeBool<byte> debug_mode,
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUDeviceWithProperties")]
        static abstract GPUDeviceHandle CreateGPUDeviceWithProperties(
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUGraphicsPipeline")]
        static abstract GPUGraphicsPipelineHandle CreateGPUGraphicsPipeline(
            GPUDeviceHandle device,
            [NativeTypeName("const SDL_GPUGraphicsPipelineCreateInfo *")]
                GPUGraphicsPipelineCreateInfo* createinfo
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUGraphicsPipeline")]
        static abstract GPUGraphicsPipelineHandle CreateGPUGraphicsPipeline(
            GPUDeviceHandle device,
            [NativeTypeName("const SDL_GPUGraphicsPipelineCreateInfo *")]
                Ref<GPUGraphicsPipelineCreateInfo> createinfo
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUSampler")]
        static abstract GPUSamplerHandle CreateGPUSampler(
            GPUDeviceHandle device,
            [NativeTypeName("const SDL_GPUSamplerCreateInfo *")] GPUSamplerCreateInfo* createinfo
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUSampler")]
        static abstract GPUSamplerHandle CreateGPUSampler(
            GPUDeviceHandle device,
            [NativeTypeName("const SDL_GPUSamplerCreateInfo *")]
                Ref<GPUSamplerCreateInfo> createinfo
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUShader")]
        static abstract GPUShaderHandle CreateGPUShader(
            GPUDeviceHandle device,
            [NativeTypeName("const SDL_GPUShaderCreateInfo *")] GPUShaderCreateInfo* createinfo
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUShader")]
        static abstract GPUShaderHandle CreateGPUShader(
            GPUDeviceHandle device,
            [NativeTypeName("const SDL_GPUShaderCreateInfo *")] Ref<GPUShaderCreateInfo> createinfo
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTexture")]
        static abstract GPUTextureHandle CreateGPUTexture(
            GPUDeviceHandle device,
            [NativeTypeName("const SDL_GPUTextureCreateInfo *")] GPUTextureCreateInfo* createinfo
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTexture")]
        static abstract GPUTextureHandle CreateGPUTexture(
            GPUDeviceHandle device,
            [NativeTypeName("const SDL_GPUTextureCreateInfo *")]
                Ref<GPUTextureCreateInfo> createinfo
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTransferBuffer")]
        static abstract GPUTransferBufferHandle CreateGPUTransferBuffer(
            GPUDeviceHandle device,
            [NativeTypeName("const SDL_GPUTransferBufferCreateInfo *")]
                GPUTransferBufferCreateInfo* createinfo
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTransferBuffer")]
        static abstract GPUTransferBufferHandle CreateGPUTransferBuffer(
            GPUDeviceHandle device,
            [NativeTypeName("const SDL_GPUTransferBufferCreateInfo *")]
                Ref<GPUTransferBufferCreateInfo> createinfo
        );

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

        [NativeFunction("SDL3", EntryPoint = "SDL_CreatePopupWindow")]
        static abstract WindowHandle CreatePopupWindow(
            WindowHandle parent,
            int offset_x,
            int offset_y,
            int w,
            int h,
            [NativeTypeName("SDL_WindowFlags")] nuint flags
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateProcess")]
        static abstract ProcessHandle CreateProcess(
            [NativeTypeName("const char *const *")] sbyte** args,
            [NativeTypeName("bool")] byte pipe_stdio
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateProcess")]
        static abstract ProcessHandle CreateProcess(
            [NativeTypeName("const char *const *")] Ref2D<sbyte> args,
            [NativeTypeName("bool")] MaybeBool<byte> pipe_stdio
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateProcessWithProperties")]
        static abstract ProcessHandle CreateProcessWithProperties(
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateProperties")]
        static abstract uint CreateProperties();

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateRenderer")]
        static abstract RendererHandle CreateRenderer(
            WindowHandle window,
            [NativeTypeName("const char *")] sbyte* name
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateRenderer")]
        static abstract RendererHandle CreateRenderer(
            WindowHandle window,
            [NativeTypeName("const char *")] Ref<sbyte> name
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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateStorageDirectory")]
        static abstract byte CreateStorageDirectory(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateStorageDirectory")]
        static abstract MaybeBool<byte> CreateStorageDirectory(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurface")]
        static abstract Ptr<Surface> CreateSurface(int width, int height, PixelFormat format);

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfaceFrom")]
        static abstract Surface* CreateSurfaceFrom(
            int width,
            int height,
            PixelFormat format,
            void* pixels,
            int pitch
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfaceFrom")]
        static abstract Ptr<Surface> CreateSurfaceFrom(
            int width,
            int height,
            PixelFormat format,
            Ref pixels,
            int pitch
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfacePalette")]
        static abstract Palette* CreateSurfacePalette(Surface* surface);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfacePalette")]
        static abstract Ptr<Palette> CreateSurfacePalette(Ref<Surface> surface);

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurface")]
        static abstract Surface* CreateSurfaceRaw(int width, int height, PixelFormat format);

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSystemCursor")]
        static abstract CursorHandle CreateSystemCursor(SystemCursor id);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTexture")]
        static abstract Ptr<Texture> CreateTexture(
            RendererHandle renderer,
            PixelFormat format,
            TextureAccess access,
            int w,
            int h
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureFromSurface")]
        static abstract Texture* CreateTextureFromSurface(
            RendererHandle renderer,
            Surface* surface
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureFromSurface")]
        static abstract Ptr<Texture> CreateTextureFromSurface(
            RendererHandle renderer,
            Ref<Surface> surface
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTexture")]
        static abstract Texture* CreateTextureRaw(
            RendererHandle renderer,
            PixelFormat format,
            TextureAccess access,
            int w,
            int h
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureWithProperties")]
        static abstract Ptr<Texture> CreateTextureWithProperties(
            RendererHandle renderer,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureWithProperties")]
        static abstract Texture* CreateTextureWithPropertiesRaw(
            RendererHandle renderer,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadRuntime")]
        static abstract ThreadHandle CreateThreadRuntime(
            [NativeTypeName("SDL_ThreadFunction")] ThreadFunction fn,
            [NativeTypeName("const char *")] sbyte* name,
            void* data,
            [NativeTypeName("SDL_FunctionPointer")] FunctionPointer pfnBeginThread,
            [NativeTypeName("SDL_FunctionPointer")] FunctionPointer pfnEndThread
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadRuntime")]
        static abstract ThreadHandle CreateThreadRuntime(
            [NativeTypeName("SDL_ThreadFunction")] ThreadFunction fn,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            Ref data,
            [NativeTypeName("SDL_FunctionPointer")] FunctionPointer pfnBeginThread,
            [NativeTypeName("SDL_FunctionPointer")] FunctionPointer pfnEndThread
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadWithPropertiesRuntime")]
        static abstract ThreadHandle CreateThreadWithPropertiesRuntime(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("SDL_FunctionPointer")] FunctionPointer pfnBeginThread,
            [NativeTypeName("SDL_FunctionPointer")] FunctionPointer pfnEndThread
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindow")]
        static abstract WindowHandle CreateWindow(
            [NativeTypeName("const char *")] sbyte* title,
            int w,
            int h,
            [NativeTypeName("SDL_WindowFlags")] nuint flags
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindow")]
        static abstract WindowHandle CreateWindow(
            [NativeTypeName("const char *")] Ref<sbyte> title,
            int w,
            int h,
            [NativeTypeName("SDL_WindowFlags")] nuint flags
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowAndRenderer")]
        static abstract byte CreateWindowAndRenderer(
            [NativeTypeName("const char *")] sbyte* title,
            int width,
            int height,
            [NativeTypeName("SDL_WindowFlags")] nuint window_flags,
            WindowHandle* window,
            RendererHandle* renderer
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowAndRenderer")]
        static abstract MaybeBool<byte> CreateWindowAndRenderer(
            [NativeTypeName("const char *")] Ref<sbyte> title,
            int width,
            int height,
            [NativeTypeName("SDL_WindowFlags")] nuint window_flags,
            Ref<WindowHandle> window,
            Ref<RendererHandle> renderer
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowWithProperties")]
        static abstract WindowHandle CreateWindowWithProperties(
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_CursorVisible")]
        static abstract MaybeBool<byte> CursorVisible();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CursorVisible")]
        static abstract byte CursorVisibleRaw();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DateTimeToTime")]
        static abstract byte DateTimeToTime(
            [NativeTypeName("const SDL_DateTime *")] DateTime* dt,
            [NativeTypeName("SDL_Time *")] nint* ticks
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DateTimeToTime")]
        static abstract MaybeBool<byte> DateTimeToTime(
            [NativeTypeName("const SDL_DateTime *")] Ref<DateTime> dt,
            [NativeTypeName("SDL_Time *")] Ref<nint> ticks
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_Delay")]
        static abstract void Delay([NativeTypeName("Uint32")] uint ms);

        [NativeFunction("SDL3", EntryPoint = "SDL_DelayNS")]
        static abstract void DelayNS([NativeTypeName("Uint64")] nuint ns);

        [NativeFunction("SDL3", EntryPoint = "SDL_DelayPrecise")]
        static abstract void DelayPrecise([NativeTypeName("Uint64")] nuint ns);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyAudioStream")]
        static abstract void DestroyAudioStream(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyCondition")]
        static abstract void DestroyCondition(ConditionHandle cond);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyCursor")]
        static abstract void DestroyCursor(CursorHandle cursor);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyEnvironment")]
        static abstract void DestroyEnvironment(EnvironmentHandle env);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyGPUDevice")]
        static abstract void DestroyGPUDevice(GPUDeviceHandle device);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyHapticEffect")]
        static abstract void DestroyHapticEffect(HapticHandle haptic, int effect);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyMutex")]
        static abstract void DestroyMutex(MutexHandle mutex);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPalette")]
        static abstract void DestroyPalette(Palette* palette);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPalette")]
        static abstract void DestroyPalette(Ref<Palette> palette);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyProcess")]
        static abstract void DestroyProcess(ProcessHandle process);

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
        static abstract void DestroyTexture(Texture* texture);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyTexture")]
        static abstract void DestroyTexture(Ref<Texture> texture);

        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindow")]
        static abstract void DestroyWindow(WindowHandle window);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindowSurface")]
        static abstract MaybeBool<byte> DestroyWindowSurface(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindowSurface")]
        static abstract byte DestroyWindowSurfaceRaw(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_DetachThread")]
        static abstract void DetachThread(ThreadHandle thread);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DetachVirtualJoystick")]
        static abstract MaybeBool<byte> DetachVirtualJoystick(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DetachVirtualJoystick")]
        static abstract byte DetachVirtualJoystickRaw(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DisableScreenSaver")]
        static abstract MaybeBool<byte> DisableScreenSaver();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DisableScreenSaver")]
        static abstract byte DisableScreenSaverRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_DispatchGPUCompute")]
        static abstract void DispatchGPUCompute(
            GPUComputePassHandle compute_pass,
            [NativeTypeName("Uint32")] uint groupcount_x,
            [NativeTypeName("Uint32")] uint groupcount_y,
            [NativeTypeName("Uint32")] uint groupcount_z
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_DispatchGPUComputeIndirect")]
        static abstract void DispatchGPUComputeIndirect(
            GPUComputePassHandle compute_pass,
            GPUBufferHandle buffer,
            [NativeTypeName("Uint32")] uint offset
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUBuffer")]
        static abstract void DownloadFromGPUBuffer(
            GPUCopyPassHandle copy_pass,
            [NativeTypeName("const SDL_GPUBufferRegion *")] GPUBufferRegion* source,
            [NativeTypeName("const SDL_GPUTransferBufferLocation *")]
                GPUTransferBufferLocation* destination
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUBuffer")]
        static abstract void DownloadFromGPUBuffer(
            GPUCopyPassHandle copy_pass,
            [NativeTypeName("const SDL_GPUBufferRegion *")] Ref<GPUBufferRegion> source,
            [NativeTypeName("const SDL_GPUTransferBufferLocation *")]
                Ref<GPUTransferBufferLocation> destination
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUTexture")]
        static abstract void DownloadFromGPUTexture(
            GPUCopyPassHandle copy_pass,
            [NativeTypeName("const SDL_GPUTextureRegion *")] GPUTextureRegion* source,
            [NativeTypeName("const SDL_GPUTextureTransferInfo *")]
                GPUTextureTransferInfo* destination
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUTexture")]
        static abstract void DownloadFromGPUTexture(
            GPUCopyPassHandle copy_pass,
            [NativeTypeName("const SDL_GPUTextureRegion *")] Ref<GPUTextureRegion> source,
            [NativeTypeName("const SDL_GPUTextureTransferInfo *")]
                Ref<GPUTextureTransferInfo> destination
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUIndexedPrimitives")]
        static abstract void DrawGPUIndexedPrimitives(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint num_indices,
            [NativeTypeName("Uint32")] uint num_instances,
            [NativeTypeName("Uint32")] uint first_index,
            [NativeTypeName("Sint32")] int vertex_offset,
            [NativeTypeName("Uint32")] uint first_instance
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUIndexedPrimitivesIndirect")]
        static abstract void DrawGPUIndexedPrimitivesIndirect(
            GPURenderPassHandle render_pass,
            GPUBufferHandle buffer,
            [NativeTypeName("Uint32")] uint offset,
            [NativeTypeName("Uint32")] uint draw_count
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUPrimitives")]
        static abstract void DrawGPUPrimitives(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint32")] uint num_vertices,
            [NativeTypeName("Uint32")] uint num_instances,
            [NativeTypeName("Uint32")] uint first_vertex,
            [NativeTypeName("Uint32")] uint first_instance
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUPrimitivesIndirect")]
        static abstract void DrawGPUPrimitivesIndirect(
            GPURenderPassHandle render_pass,
            GPUBufferHandle buffer,
            [NativeTypeName("Uint32")] uint offset,
            [NativeTypeName("Uint32")] uint draw_count
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_DuplicateSurface")]
        static abstract Surface* DuplicateSurface(Surface* surface);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_DuplicateSurface")]
        static abstract Ptr<Surface> DuplicateSurface(Ref<Surface> surface);

        [return: NativeTypeName("SDL_EGLConfig")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentConfig")]
        static abstract Ptr EGLGetCurrentConfig();

        [return: NativeTypeName("SDL_EGLConfig")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentConfig")]
        static abstract void* EGLGetCurrentConfigRaw();

        [return: NativeTypeName("SDL_EGLDisplay")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentDisplay")]
        static abstract Ptr EGLGetCurrentDisplay();

        [return: NativeTypeName("SDL_EGLDisplay")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentDisplay")]
        static abstract void* EGLGetCurrentDisplayRaw();

        [return: NativeTypeName("SDL_FunctionPointer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetProcAddress")]
        static abstract FunctionPointer EGLGetProcAddress(
            [NativeTypeName("const char *")] sbyte* proc
        );

        [return: NativeTypeName("SDL_FunctionPointer")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetProcAddress")]
        static abstract FunctionPointer EGLGetProcAddress(
            [NativeTypeName("const char *")] Ref<sbyte> proc
        );

        [return: NativeTypeName("SDL_EGLSurface")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetWindowSurface")]
        static abstract Ptr EGLGetWindowSurface(WindowHandle window);

        [return: NativeTypeName("SDL_EGLSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetWindowSurface")]
        static abstract void* EGLGetWindowSurfaceRaw(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_SetAttributeCallbacks")]
        static abstract void EGLSetAttributeCallbacks(
            [NativeTypeName("SDL_EGLAttribArrayCallback")]
                EGLAttribArrayCallback platformAttribCallback,
            [NativeTypeName("SDL_EGLIntArrayCallback")] EGLIntArrayCallback surfaceAttribCallback,
            [NativeTypeName("SDL_EGLIntArrayCallback")] EGLIntArrayCallback contextAttribCallback,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_SetAttributeCallbacks")]
        static abstract void EGLSetAttributeCallbacks(
            [NativeTypeName("SDL_EGLAttribArrayCallback")]
                EGLAttribArrayCallback platformAttribCallback,
            [NativeTypeName("SDL_EGLIntArrayCallback")] EGLIntArrayCallback surfaceAttribCallback,
            [NativeTypeName("SDL_EGLIntArrayCallback")] EGLIntArrayCallback contextAttribCallback,
            Ref userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnableScreenSaver")]
        static abstract MaybeBool<byte> EnableScreenSaver();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnableScreenSaver")]
        static abstract byte EnableScreenSaverRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_EndGPUComputePass")]
        static abstract void EndGPUComputePass(GPUComputePassHandle compute_pass);

        [NativeFunction("SDL3", EntryPoint = "SDL_EndGPUCopyPass")]
        static abstract void EndGPUCopyPass(GPUCopyPassHandle copy_pass);

        [NativeFunction("SDL3", EntryPoint = "SDL_EndGPURenderPass")]
        static abstract void EndGPURenderPass(GPURenderPassHandle render_pass);

        [NativeFunction("SDL3", EntryPoint = "SDL_EnterAppMainCallbacks")]
        static abstract int EnterAppMainCallbacks(
            int argc,
            [NativeTypeName("char *[]")] sbyte** argv,
            [NativeTypeName("SDL_AppInit_func")] AppInitFunc appinit,
            [NativeTypeName("SDL_AppIterate_func")] AppIterateFunc appiter,
            [NativeTypeName("SDL_AppEvent_func")] AppEventFunc appevent,
            [NativeTypeName("SDL_AppQuit_func")] AppQuitFunc appquit
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnterAppMainCallbacks")]
        static abstract int EnterAppMainCallbacks(
            int argc,
            [NativeTypeName("char *[]")] Ref2D<sbyte> argv,
            [NativeTypeName("SDL_AppInit_func")] AppInitFunc appinit,
            [NativeTypeName("SDL_AppIterate_func")] AppIterateFunc appiter,
            [NativeTypeName("SDL_AppEvent_func")] AppEventFunc appevent,
            [NativeTypeName("SDL_AppQuit_func")] AppQuitFunc appquit
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateDirectory")]
        static abstract byte EnumerateDirectory(
            [NativeTypeName("const char *")] sbyte* path,
            [NativeTypeName("SDL_EnumerateDirectoryCallback")] EnumerateDirectoryCallback callback,
            void* userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateDirectory")]
        static abstract MaybeBool<byte> EnumerateDirectory(
            [NativeTypeName("const char *")] Ref<sbyte> path,
            [NativeTypeName("SDL_EnumerateDirectoryCallback")] EnumerateDirectoryCallback callback,
            Ref userdata
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateProperties")]
        static abstract byte EnumerateProperties(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("SDL_EnumeratePropertiesCallback")]
                EnumeratePropertiesCallback callback,
            void* userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateProperties")]
        static abstract MaybeBool<byte> EnumerateProperties(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("SDL_EnumeratePropertiesCallback")]
                EnumeratePropertiesCallback callback,
            Ref userdata
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateStorageDirectory")]
        static abstract byte EnumerateStorageDirectory(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path,
            [NativeTypeName("SDL_EnumerateDirectoryCallback")] EnumerateDirectoryCallback callback,
            void* userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateStorageDirectory")]
        static abstract MaybeBool<byte> EnumerateStorageDirectory(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path,
            [NativeTypeName("SDL_EnumerateDirectoryCallback")] EnumerateDirectoryCallback callback,
            Ref userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_EventEnabled")]
        static abstract MaybeBool<byte> EventEnabled([NativeTypeName("Uint32")] uint type);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EventEnabled")]
        static abstract byte EventEnabledRaw([NativeTypeName("Uint32")] uint type);

        [NativeFunction("SDL3", EntryPoint = "SDL_exp")]
        static abstract double Exp(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_expf")]
        static abstract float Expf(float x);

        [NativeFunction("SDL3", EntryPoint = "SDL_fabs")]
        static abstract double Fabs(double x);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRect")]
        static abstract byte FillSurfaceRect(
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            [NativeTypeName("Uint32")] uint color
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRect")]
        static abstract MaybeBool<byte> FillSurfaceRect(
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            [NativeTypeName("Uint32")] uint color
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRects")]
        static abstract byte FillSurfaceRects(
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* rects,
            int count,
            [NativeTypeName("Uint32")] uint color
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRects")]
        static abstract MaybeBool<byte> FillSurfaceRects(
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rects,
            int count,
            [NativeTypeName("Uint32")] uint color
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_FilterEvents")]
        static abstract void FilterEvents(
            [NativeTypeName("SDL_EventFilter")] EventFilter filter,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_FilterEvents")]
        static abstract void FilterEvents(
            [NativeTypeName("SDL_EventFilter")] EventFilter filter,
            Ref userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlashWindow")]
        static abstract MaybeBool<byte> FlashWindow(WindowHandle window, FlashOperation operation);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlashWindow")]
        static abstract byte FlashWindowRaw(WindowHandle window, FlashOperation operation);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlipSurface")]
        static abstract byte FlipSurface(Surface* surface, FlipMode flip);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlipSurface")]
        static abstract MaybeBool<byte> FlipSurface(Ref<Surface> surface, FlipMode flip);

        [NativeFunction("SDL3", EntryPoint = "SDL_floor")]
        static abstract double Floor(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_floorf")]
        static abstract float Floorf(float x);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlushAudioStream")]
        static abstract MaybeBool<byte> FlushAudioStream(AudioStreamHandle stream);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlushAudioStream")]
        static abstract byte FlushAudioStreamRaw(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_FlushEvent")]
        static abstract void FlushEvent([NativeTypeName("Uint32")] uint type);

        [NativeFunction("SDL3", EntryPoint = "SDL_FlushEvents")]
        static abstract void FlushEvents(
            [NativeTypeName("Uint32")] uint minType,
            [NativeTypeName("Uint32")] uint maxType
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlushIO")]
        static abstract MaybeBool<byte> FlushIO(IOStreamHandle context);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlushIO")]
        static abstract byte FlushIORaw(IOStreamHandle context);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlushRenderer")]
        static abstract MaybeBool<byte> FlushRenderer(RendererHandle renderer);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlushRenderer")]
        static abstract byte FlushRendererRaw(RendererHandle renderer);

        [NativeFunction("SDL3", EntryPoint = "SDL_fmod")]
        static abstract double Fmod(double x, double y);

        [NativeFunction("SDL3", EntryPoint = "SDL_fmodf")]
        static abstract float Fmodf(float x, float y);

        [NativeFunction("SDL3", EntryPoint = "SDL_free")]
        static abstract void Free(void* mem);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_free")]
        static abstract void Free(Ref mem);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadConnected")]
        static abstract MaybeBool<byte> GamepadConnected(GamepadHandle gamepad);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadConnected")]
        static abstract byte GamepadConnectedRaw(GamepadHandle gamepad);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadEventsEnabled")]
        static abstract MaybeBool<byte> GamepadEventsEnabled();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadEventsEnabled")]
        static abstract byte GamepadEventsEnabledRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasAxis")]
        static abstract MaybeBool<byte> GamepadHasAxis(GamepadHandle gamepad, GamepadAxis axis);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasAxis")]
        static abstract byte GamepadHasAxisRaw(GamepadHandle gamepad, GamepadAxis axis);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasButton")]
        static abstract MaybeBool<byte> GamepadHasButton(
            GamepadHandle gamepad,
            GamepadButton button
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasButton")]
        static abstract byte GamepadHasButtonRaw(GamepadHandle gamepad, GamepadButton button);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasSensor")]
        static abstract MaybeBool<byte> GamepadHasSensor(GamepadHandle gamepad, SensorType type);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasSensor")]
        static abstract byte GamepadHasSensorRaw(GamepadHandle gamepad, SensorType type);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadSensorEnabled")]
        static abstract MaybeBool<byte> GamepadSensorEnabled(
            GamepadHandle gamepad,
            SensorType type
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadSensorEnabled")]
        static abstract byte GamepadSensorEnabledRaw(GamepadHandle gamepad, SensorType type);

        [NativeFunction("SDL3", EntryPoint = "SDL_GDKSuspendComplete")]
        static abstract void GDKSuspendComplete();

        [NativeFunction("SDL3", EntryPoint = "SDL_GenerateMipmapsForGPUTexture")]
        static abstract void GenerateMipmapsForGPUTexture(
            GPUCommandBufferHandle command_buffer,
            GPUTextureHandle texture
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAppMetadataProperty")]
        static abstract sbyte* GetAppMetadataProperty([NativeTypeName("const char *")] sbyte* name);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAppMetadataProperty")]
        static abstract Ptr<sbyte> GetAppMetadataProperty(
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [return: NativeTypeName("SDL_AssertionHandler")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionHandler")]
        static abstract AssertionHandler GetAssertionHandler(void** puserdata);

        [return: NativeTypeName("SDL_AssertionHandler")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionHandler")]
        static abstract AssertionHandler GetAssertionHandler(Ref2D puserdata);

        [return: NativeTypeName("const SDL_AssertData *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionReport")]
        static abstract Ptr<AssertData> GetAssertionReport();

        [return: NativeTypeName("const SDL_AssertData *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionReport")]
        static abstract AssertData* GetAssertionReportRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicInt")]
        static abstract int GetAtomicInt(AtomicInt* a);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicInt")]
        static abstract int GetAtomicInt(Ref<AtomicInt> a);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicPointer")]
        static abstract void* GetAtomicPointer(void** a);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicPointer")]
        static abstract Ptr GetAtomicPointer(Ref2D a);

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicU32")]
        static abstract uint GetAtomicU32(AtomicU32* a);

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicU32")]
        static abstract uint GetAtomicU32(Ref<AtomicU32> a);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceChannelMap")]
        static abstract int* GetAudioDeviceChannelMap(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            int* count
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceChannelMap")]
        static abstract Ptr<int> GetAudioDeviceChannelMap(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            Ref<int> count
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceFormat")]
        static abstract byte GetAudioDeviceFormat(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            AudioSpec* spec,
            int* sample_frames
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceFormat")]
        static abstract MaybeBool<byte> GetAudioDeviceFormat(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            Ref<AudioSpec> spec,
            Ref<int> sample_frames
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceGain")]
        static abstract float GetAudioDeviceGain([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceName")]
        static abstract Ptr<sbyte> GetAudioDeviceName(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid
        );

        [return: NativeTypeName("const char *")]
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

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioFormatName")]
        static abstract Ptr<sbyte> GetAudioFormatName(AudioFormat format);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioFormatName")]
        static abstract sbyte* GetAudioFormatNameRaw(AudioFormat format);

        [return: NativeTypeName("SDL_AudioDeviceID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioPlaybackDevices")]
        static abstract uint* GetAudioPlaybackDevices(int* count);

        [return: NativeTypeName("SDL_AudioDeviceID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioPlaybackDevices")]
        static abstract Ptr<uint> GetAudioPlaybackDevices(Ref<int> count);

        [return: NativeTypeName("SDL_AudioDeviceID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioRecordingDevices")]
        static abstract uint* GetAudioRecordingDevices(int* count);

        [return: NativeTypeName("SDL_AudioDeviceID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioRecordingDevices")]
        static abstract Ptr<uint> GetAudioRecordingDevices(Ref<int> count);

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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFormat")]
        static abstract byte GetAudioStreamFormat(
            AudioStreamHandle stream,
            AudioSpec* src_spec,
            AudioSpec* dst_spec
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFormat")]
        static abstract MaybeBool<byte> GetAudioStreamFormat(
            AudioStreamHandle stream,
            Ref<AudioSpec> src_spec,
            Ref<AudioSpec> dst_spec
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFrequencyRatio")]
        static abstract float GetAudioStreamFrequencyRatio(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamGain")]
        static abstract float GetAudioStreamGain(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamInputChannelMap")]
        static abstract int* GetAudioStreamInputChannelMap(AudioStreamHandle stream, int* count);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamInputChannelMap")]
        static abstract Ptr<int> GetAudioStreamInputChannelMap(
            AudioStreamHandle stream,
            Ref<int> count
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamOutputChannelMap")]
        static abstract int* GetAudioStreamOutputChannelMap(AudioStreamHandle stream, int* count);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamOutputChannelMap")]
        static abstract Ptr<int> GetAudioStreamOutputChannelMap(
            AudioStreamHandle stream,
            Ref<int> count
        );

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamProperties")]
        static abstract uint GetAudioStreamProperties(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamQueued")]
        static abstract int GetAudioStreamQueued(AudioStreamHandle stream);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetBasePath")]
        static abstract Ptr<sbyte> GetBasePath();

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetBasePath")]
        static abstract sbyte* GetBasePathRaw();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetBooleanProperty")]
        static abstract byte GetBooleanProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("bool")] byte default_value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetBooleanProperty")]
        static abstract MaybeBool<byte> GetBooleanProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("bool")] MaybeBool<byte> default_value
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDriver")]
        static abstract Ptr<sbyte> GetCameraDriver(int index);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDriver")]
        static abstract sbyte* GetCameraDriverRaw(int index);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraFormat")]
        static abstract byte GetCameraFormat(CameraHandle camera, CameraSpec* spec);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraFormat")]
        static abstract MaybeBool<byte> GetCameraFormat(CameraHandle camera, Ref<CameraSpec> spec);

        [return: NativeTypeName("SDL_CameraID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraID")]
        static abstract uint GetCameraID(CameraHandle camera);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraName")]
        static abstract Ptr<sbyte> GetCameraName([NativeTypeName("SDL_CameraID")] uint instance_id);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraName")]
        static abstract sbyte* GetCameraNameRaw([NativeTypeName("SDL_CameraID")] uint instance_id);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraPermissionState")]
        static abstract int GetCameraPermissionState(CameraHandle camera);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraPosition")]
        static abstract CameraPosition GetCameraPosition(
            [NativeTypeName("SDL_CameraID")] uint instance_id
        );

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraProperties")]
        static abstract uint GetCameraProperties(CameraHandle camera);

        [return: NativeTypeName("SDL_CameraID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameras")]
        static abstract uint* GetCameras(int* count);

        [return: NativeTypeName("SDL_CameraID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameras")]
        static abstract Ptr<uint> GetCameras(Ref<int> count);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraSupportedFormats")]
        static abstract CameraSpec** GetCameraSupportedFormats(
            [NativeTypeName("SDL_CameraID")] uint instance_id,
            int* count
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraSupportedFormats")]
        static abstract Ptr2D<CameraSpec> GetCameraSupportedFormats(
            [NativeTypeName("SDL_CameraID")] uint instance_id,
            Ref<int> count
        );

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

        [return: NativeTypeName("char **")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardMimeTypes")]
        static abstract sbyte** GetClipboardMimeTypes(
            [NativeTypeName("size_t *")] nuint* num_mime_types
        );

        [return: NativeTypeName("char **")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardMimeTypes")]
        static abstract Ptr2D<sbyte> GetClipboardMimeTypes(
            [NativeTypeName("size_t *")] Ref<nuint> num_mime_types
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardText")]
        static abstract Ptr<sbyte> GetClipboardText();

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardText")]
        static abstract sbyte* GetClipboardTextRaw();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
        static abstract byte GetClosestFullscreenDisplayMode(
            [NativeTypeName("SDL_DisplayID")] uint displayID,
            int w,
            int h,
            float refresh_rate,
            [NativeTypeName("bool")] byte include_high_density_modes,
            DisplayMode* closest
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
        static abstract MaybeBool<byte> GetClosestFullscreenDisplayMode(
            [NativeTypeName("SDL_DisplayID")] uint displayID,
            int w,
            int h,
            float refresh_rate,
            [NativeTypeName("bool")] MaybeBool<byte> include_high_density_modes,
            Ref<DisplayMode> closest
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCPUCacheLineSize")]
        static abstract int GetCPUCacheLineSize();

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

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDirectory")]
        static abstract Ptr<sbyte> GetCurrentDirectory();

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDirectory")]
        static abstract sbyte* GetCurrentDirectoryRaw();

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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentRenderOutputSize")]
        static abstract byte GetCurrentRenderOutputSize(RendererHandle renderer, int* w, int* h);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentRenderOutputSize")]
        static abstract MaybeBool<byte> GetCurrentRenderOutputSize(
            RendererHandle renderer,
            Ref<int> w,
            Ref<int> h
        );

        [return: NativeTypeName("SDL_ThreadID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentThreadID")]
        static abstract nuint GetCurrentThreadID();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentTime")]
        static abstract byte GetCurrentTime([NativeTypeName("SDL_Time *")] nint* ticks);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentTime")]
        static abstract MaybeBool<byte> GetCurrentTime(
            [NativeTypeName("SDL_Time *")] Ref<nint> ticks
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentVideoDriver")]
        static abstract Ptr<sbyte> GetCurrentVideoDriver();

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentVideoDriver")]
        static abstract sbyte* GetCurrentVideoDriverRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetCursor")]
        static abstract CursorHandle GetCursor();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDateTimeLocalePreferences")]
        static abstract byte GetDateTimeLocalePreferences(
            DateFormat* dateFormat,
            TimeFormat* timeFormat
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDateTimeLocalePreferences")]
        static abstract MaybeBool<byte> GetDateTimeLocalePreferences(
            Ref<DateFormat> dateFormat,
            Ref<TimeFormat> timeFormat
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetDayOfWeek")]
        static abstract int GetDayOfWeek(int year, int month, int day);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetDayOfYear")]
        static abstract int GetDayOfYear(int year, int month, int day);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetDaysInMonth")]
        static abstract int GetDaysInMonth(int year, int month);

        [return: NativeTypeName("SDL_AssertionHandler")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultAssertionHandler")]
        static abstract AssertionHandler GetDefaultAssertionHandler();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultCursor")]
        static abstract CursorHandle GetDefaultCursor();

        [return: NativeTypeName("SDL_LogOutputFunction")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultLogOutputFunction")]
        static abstract LogOutputFunction GetDefaultLogOutputFunction();

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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayBounds")]
        static abstract byte GetDisplayBounds(
            [NativeTypeName("SDL_DisplayID")] uint displayID,
            Rect* rect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayBounds")]
        static abstract MaybeBool<byte> GetDisplayBounds(
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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayUsableBounds")]
        static abstract byte GetDisplayUsableBounds(
            [NativeTypeName("SDL_DisplayID")] uint displayID,
            Rect* rect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayUsableBounds")]
        static abstract MaybeBool<byte> GetDisplayUsableBounds(
            [NativeTypeName("SDL_DisplayID")] uint displayID,
            Ref<Rect> rect
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_getenv")]
        static abstract sbyte* Getenv([NativeTypeName("const char *")] sbyte* name);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_getenv")]
        static abstract Ptr<sbyte> Getenv([NativeTypeName("const char *")] Ref<sbyte> name);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_getenv_unsafe")]
        static abstract sbyte* GetenvUnsafe([NativeTypeName("const char *")] sbyte* name);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_getenv_unsafe")]
        static abstract Ptr<sbyte> GetenvUnsafe([NativeTypeName("const char *")] Ref<sbyte> name);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironment")]
        static abstract EnvironmentHandle GetEnvironment();

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariable")]
        static abstract sbyte* GetEnvironmentVariable(
            EnvironmentHandle env,
            [NativeTypeName("const char *")] sbyte* name
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariable")]
        static abstract Ptr<sbyte> GetEnvironmentVariable(
            EnvironmentHandle env,
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [return: NativeTypeName("char **")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariables")]
        static abstract Ptr2D<sbyte> GetEnvironmentVariables(EnvironmentHandle env);

        [return: NativeTypeName("char **")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariables")]
        static abstract sbyte** GetEnvironmentVariablesRaw(EnvironmentHandle env);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetError")]
        static abstract Ptr<sbyte> GetError();

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetError")]
        static abstract sbyte* GetErrorRaw();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEventFilter")]
        static abstract byte GetEventFilter(
            [NativeTypeName("SDL_EventFilter *")] EventFilter* filter,
            void** userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEventFilter")]
        static abstract MaybeBool<byte> GetEventFilter(
            [NativeTypeName("SDL_EventFilter *")] Ref<EventFilter> filter,
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

        [NativeFunction("SDL3", EntryPoint = "SDL_GetFullscreenDisplayModes")]
        static abstract DisplayMode** GetFullscreenDisplayModes(
            [NativeTypeName("SDL_DisplayID")] uint displayID,
            int* count
        );

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

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButton")]
        static abstract MaybeBool<byte> GetGamepadButton(
            GamepadHandle gamepad,
            GamepadButton button
        );

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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButton")]
        static abstract byte GetGamepadButtonRaw(GamepadHandle gamepad, GamepadButton button);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadConnectionState")]
        static abstract JoystickConnectionState GetGamepadConnectionState(GamepadHandle gamepad);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFirmwareVersion")]
        static abstract ushort GetGamepadFirmwareVersion(GamepadHandle gamepad);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFromID")]
        static abstract GamepadHandle GetGamepadFromID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFromPlayerIndex")]
        static abstract GamepadHandle GetGamepadFromPlayerIndex(int player_index);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadGUIDForID")]
        static abstract Guid GetGamepadGuidForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("SDL_JoystickID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadID")]
        static abstract uint GetGamepadID(GamepadHandle gamepad);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadJoystick")]
        static abstract JoystickHandle GetGamepadJoystick(GamepadHandle gamepad);

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMapping")]
        static abstract Ptr<sbyte> GetGamepadMapping(GamepadHandle gamepad);

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForGUID")]
        static abstract Ptr<sbyte> GetGamepadMappingForGuid(Guid guid);

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForGUID")]
        static abstract sbyte* GetGamepadMappingForGuidRaw(Guid guid);

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForID")]
        static abstract Ptr<sbyte> GetGamepadMappingForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForID")]
        static abstract sbyte* GetGamepadMappingForIDRaw(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
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
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadNameForID")]
        static abstract Ptr<sbyte> GetGamepadNameForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadNameForID")]
        static abstract sbyte* GetGamepadNameForIDRaw(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadName")]
        static abstract sbyte* GetGamepadNameRaw(GamepadHandle gamepad);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPath")]
        static abstract Ptr<sbyte> GetGamepadPath(GamepadHandle gamepad);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPathForID")]
        static abstract Ptr<sbyte> GetGamepadPathForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPathForID")]
        static abstract sbyte* GetGamepadPathForIDRaw(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPath")]
        static abstract sbyte* GetGamepadPathRaw(GamepadHandle gamepad);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPlayerIndex")]
        static abstract int GetGamepadPlayerIndex(GamepadHandle gamepad);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPlayerIndexForID")]
        static abstract int GetGamepadPlayerIndexForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPowerInfo")]
        static abstract PowerState GetGamepadPowerInfo(GamepadHandle gamepad, int* percent);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPowerInfo")]
        static abstract PowerState GetGamepadPowerInfo(GamepadHandle gamepad, Ref<int> percent);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProduct")]
        static abstract ushort GetGamepadProduct(GamepadHandle gamepad);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProductForID")]
        static abstract ushort GetGamepadProductForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProductVersion")]
        static abstract ushort GetGamepadProductVersion(GamepadHandle gamepad);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProductVersionForID")]
        static abstract ushort GetGamepadProductVersionForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorData")]
        static abstract byte GetGamepadSensorData(
            GamepadHandle gamepad,
            SensorType type,
            float* data,
            int num_values
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorData")]
        static abstract MaybeBool<byte> GetGamepadSensorData(
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
        static abstract nuint GetGamepadSteamHandle(GamepadHandle gamepad);

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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTouchpadFinger")]
        static abstract byte GetGamepadTouchpadFinger(
            GamepadHandle gamepad,
            int touchpad,
            int finger,
            bool* down,
            float* x,
            float* y,
            float* pressure
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTouchpadFinger")]
        static abstract MaybeBool<byte> GetGamepadTouchpadFinger(
            GamepadHandle gamepad,
            int touchpad,
            int finger,
            Ref<bool> down,
            Ref<float> x,
            Ref<float> y,
            Ref<float> pressure
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadType")]
        static abstract GamepadType GetGamepadType(GamepadHandle gamepad);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTypeForID")]
        static abstract GamepadType GetGamepadTypeForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

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

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadVendorForID")]
        static abstract ushort GetGamepadVendorForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("SDL_MouseButtonFlags")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalMouseState")]
        static abstract uint GetGlobalMouseState(float* x, float* y);

        [return: NativeTypeName("SDL_MouseButtonFlags")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalMouseState")]
        static abstract uint GetGlobalMouseState(Ref<float> x, Ref<float> y);

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalProperties")]
        static abstract uint GetGlobalProperties();

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDeviceDriver")]
        static abstract Ptr<sbyte> GetGPUDeviceDriver(GPUDeviceHandle device);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDeviceDriver")]
        static abstract sbyte* GetGPUDeviceDriverRaw(GPUDeviceHandle device);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDriver")]
        static abstract Ptr<sbyte> GetGPUDriver(int index);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDriver")]
        static abstract sbyte* GetGPUDriverRaw(int index);

        [return: NativeTypeName("SDL_GPUShaderFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUShaderFormats")]
        static abstract uint GetGPUShaderFormats(GPUDeviceHandle device);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUSwapchainTextureFormat")]
        static abstract GPUTextureFormat GetGPUSwapchainTextureFormat(
            GPUDeviceHandle device,
            WindowHandle window
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetGrabbedWindow")]
        static abstract WindowHandle GetGrabbedWindow();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticEffectStatus")]
        static abstract MaybeBool<byte> GetHapticEffectStatus(HapticHandle haptic, int effect);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticEffectStatus")]
        static abstract byte GetHapticEffectStatusRaw(HapticHandle haptic, int effect);

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticFeatures")]
        static abstract uint GetHapticFeatures(HapticHandle haptic);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticFromID")]
        static abstract HapticHandle GetHapticFromID(
            [NativeTypeName("SDL_HapticID")] uint instance_id
        );

        [return: NativeTypeName("SDL_HapticID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticID")]
        static abstract uint GetHapticID(HapticHandle haptic);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticName")]
        static abstract Ptr<sbyte> GetHapticName(HapticHandle haptic);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticNameForID")]
        static abstract Ptr<sbyte> GetHapticNameForID(
            [NativeTypeName("SDL_HapticID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticNameForID")]
        static abstract sbyte* GetHapticNameForIDRaw(
            [NativeTypeName("SDL_HapticID")] uint instance_id
        );

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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHintBoolean")]
        static abstract byte GetHintBoolean(
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("bool")] byte default_value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHintBoolean")]
        static abstract MaybeBool<byte> GetHintBoolean(
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("bool")] MaybeBool<byte> default_value
        );

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetIOProperties")]
        static abstract uint GetIOProperties(IOStreamHandle context);

        [return: NativeTypeName("Sint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetIOSize")]
        static abstract nint GetIOSize(IOStreamHandle context);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetIOStatus")]
        static abstract IOStatus GetIOStatus(IOStreamHandle context);

        [return: NativeTypeName("Sint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxis")]
        static abstract short GetJoystickAxis(JoystickHandle joystick, int axis);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxisInitialState")]
        static abstract byte GetJoystickAxisInitialState(
            JoystickHandle joystick,
            int axis,
            [NativeTypeName("Sint16 *")] short* state
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxisInitialState")]
        static abstract MaybeBool<byte> GetJoystickAxisInitialState(
            JoystickHandle joystick,
            int axis,
            [NativeTypeName("Sint16 *")] Ref<short> state
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickBall")]
        static abstract byte GetJoystickBall(JoystickHandle joystick, int ball, int* dx, int* dy);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickBall")]
        static abstract MaybeBool<byte> GetJoystickBall(
            JoystickHandle joystick,
            int ball,
            Ref<int> dx,
            Ref<int> dy
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickButton")]
        static abstract MaybeBool<byte> GetJoystickButton(JoystickHandle joystick, int button);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickButton")]
        static abstract byte GetJoystickButtonRaw(JoystickHandle joystick, int button);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickConnectionState")]
        static abstract JoystickConnectionState GetJoystickConnectionState(JoystickHandle joystick);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFirmwareVersion")]
        static abstract ushort GetJoystickFirmwareVersion(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFromID")]
        static abstract JoystickHandle GetJoystickFromID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFromPlayerIndex")]
        static abstract JoystickHandle GetJoystickFromPlayerIndex(int player_index);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUID")]
        static abstract Guid GetJoystickGuid(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDForID")]
        static abstract Guid GetJoystickGuidForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDInfo")]
        static abstract void GetJoystickGuidInfo(
            Guid guid,
            [NativeTypeName("Uint16 *")] ushort* vendor,
            [NativeTypeName("Uint16 *")] ushort* product,
            [NativeTypeName("Uint16 *")] ushort* version,
            [NativeTypeName("Uint16 *")] ushort* crc16
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDInfo")]
        static abstract void GetJoystickGuidInfo(
            Guid guid,
            [NativeTypeName("Uint16 *")] Ref<ushort> vendor,
            [NativeTypeName("Uint16 *")] Ref<ushort> product,
            [NativeTypeName("Uint16 *")] Ref<ushort> version,
            [NativeTypeName("Uint16 *")] Ref<ushort> crc16
        );

        [return: NativeTypeName("Uint8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickHat")]
        static abstract byte GetJoystickHat(JoystickHandle joystick, int hat);

        [return: NativeTypeName("SDL_JoystickID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickID")]
        static abstract uint GetJoystickID(JoystickHandle joystick);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickName")]
        static abstract Ptr<sbyte> GetJoystickName(JoystickHandle joystick);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickNameForID")]
        static abstract Ptr<sbyte> GetJoystickNameForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickNameForID")]
        static abstract sbyte* GetJoystickNameForIDRaw(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickName")]
        static abstract sbyte* GetJoystickNameRaw(JoystickHandle joystick);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPath")]
        static abstract Ptr<sbyte> GetJoystickPath(JoystickHandle joystick);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPathForID")]
        static abstract Ptr<sbyte> GetJoystickPathForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPathForID")]
        static abstract sbyte* GetJoystickPathForIDRaw(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPath")]
        static abstract sbyte* GetJoystickPathRaw(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPlayerIndex")]
        static abstract int GetJoystickPlayerIndex(JoystickHandle joystick);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPlayerIndexForID")]
        static abstract int GetJoystickPlayerIndexForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPowerInfo")]
        static abstract PowerState GetJoystickPowerInfo(JoystickHandle joystick, int* percent);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPowerInfo")]
        static abstract PowerState GetJoystickPowerInfo(JoystickHandle joystick, Ref<int> percent);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProduct")]
        static abstract ushort GetJoystickProduct(JoystickHandle joystick);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProductForID")]
        static abstract ushort GetJoystickProductForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProductVersion")]
        static abstract ushort GetJoystickProductVersion(JoystickHandle joystick);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProductVersionForID")]
        static abstract ushort GetJoystickProductVersionForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

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

        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickTypeForID")]
        static abstract JoystickType GetJoystickTypeForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickVendor")]
        static abstract ushort GetJoystickVendor(JoystickHandle joystick);

        [return: NativeTypeName("Uint16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickVendorForID")]
        static abstract ushort GetJoystickVendorForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardFocus")]
        static abstract WindowHandle GetKeyboardFocus();

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardNameForID")]
        static abstract Ptr<sbyte> GetKeyboardNameForID(
            [NativeTypeName("SDL_KeyboardID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardNameForID")]
        static abstract sbyte* GetKeyboardNameForIDRaw(
            [NativeTypeName("SDL_KeyboardID")] uint instance_id
        );

        [return: NativeTypeName("SDL_KeyboardID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboards")]
        static abstract uint* GetKeyboards(int* count);

        [return: NativeTypeName("SDL_KeyboardID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboards")]
        static abstract Ptr<uint> GetKeyboards(Ref<int> count);

        [return: NativeTypeName("const bool *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardState")]
        static abstract bool* GetKeyboardState(int* numkeys);

        [return: NativeTypeName("const bool *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardState")]
        static abstract Ptr<bool> GetKeyboardState(Ref<int> numkeys);

        [return: NativeTypeName("SDL_Keycode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromName")]
        static abstract uint GetKeyFromName([NativeTypeName("const char *")] sbyte* name);

        [return: NativeTypeName("SDL_Keycode")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromName")]
        static abstract uint GetKeyFromName([NativeTypeName("const char *")] Ref<sbyte> name);

        [return: NativeTypeName("SDL_Keycode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromScancode")]
        static abstract uint GetKeyFromScancode(
            Scancode scancode,
            [NativeTypeName("SDL_Keymod")] ushort modstate,
            [NativeTypeName("bool")] byte key_event
        );

        [return: NativeTypeName("SDL_Keycode")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromScancode")]
        static abstract uint GetKeyFromScancode(
            Scancode scancode,
            [NativeTypeName("SDL_Keymod")] ushort modstate,
            [NativeTypeName("bool")] MaybeBool<byte> key_event
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyName")]
        static abstract Ptr<sbyte> GetKeyName([NativeTypeName("SDL_Keycode")] uint key);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyName")]
        static abstract sbyte* GetKeyNameRaw([NativeTypeName("SDL_Keycode")] uint key);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetLogOutputFunction")]
        static abstract void GetLogOutputFunction(
            [NativeTypeName("SDL_LogOutputFunction *")] LogOutputFunction* callback,
            void** userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetLogOutputFunction")]
        static abstract void GetLogOutputFunction(
            [NativeTypeName("SDL_LogOutputFunction *")] Ref<LogOutputFunction> callback,
            Ref2D userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetLogPriority")]
        static abstract LogPriority GetLogPriority(int category);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMasksForPixelFormat")]
        static abstract byte GetMasksForPixelFormat(
            PixelFormat format,
            int* bpp,
            [NativeTypeName("Uint32 *")] uint* Rmask,
            [NativeTypeName("Uint32 *")] uint* Gmask,
            [NativeTypeName("Uint32 *")] uint* Bmask,
            [NativeTypeName("Uint32 *")] uint* Amask
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMasksForPixelFormat")]
        static abstract MaybeBool<byte> GetMasksForPixelFormat(
            PixelFormat format,
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

        [NativeFunction("SDL3", EntryPoint = "SDL_GetMemoryFunctions")]
        static abstract void GetMemoryFunctions(
            [NativeTypeName("SDL_malloc_func *")] MallocFunc* malloc_func,
            [NativeTypeName("SDL_calloc_func *")] CallocFunc* calloc_func,
            [NativeTypeName("SDL_realloc_func *")] ReallocFunc* realloc_func,
            [NativeTypeName("SDL_free_func *")] FreeFunc* free_func
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMemoryFunctions")]
        static abstract void GetMemoryFunctions(
            [NativeTypeName("SDL_malloc_func *")] Ref<MallocFunc> malloc_func,
            [NativeTypeName("SDL_calloc_func *")] Ref<CallocFunc> calloc_func,
            [NativeTypeName("SDL_realloc_func *")] Ref<ReallocFunc> realloc_func,
            [NativeTypeName("SDL_free_func *")] Ref<FreeFunc> free_func
        );

        [return: NativeTypeName("SDL_MouseID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMice")]
        static abstract uint* GetMice(int* count);

        [return: NativeTypeName("SDL_MouseID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMice")]
        static abstract Ptr<uint> GetMice(Ref<int> count);

        [return: NativeTypeName("SDL_Keymod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetModState")]
        static abstract ushort GetModState();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseFocus")]
        static abstract WindowHandle GetMouseFocus();

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseNameForID")]
        static abstract Ptr<sbyte> GetMouseNameForID(
            [NativeTypeName("SDL_MouseID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseNameForID")]
        static abstract sbyte* GetMouseNameForIDRaw(
            [NativeTypeName("SDL_MouseID")] uint instance_id
        );

        [return: NativeTypeName("SDL_MouseButtonFlags")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseState")]
        static abstract uint GetMouseState(float* x, float* y);

        [return: NativeTypeName("SDL_MouseButtonFlags")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseState")]
        static abstract uint GetMouseState(Ref<float> x, Ref<float> y);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNaturalDisplayOrientation")]
        static abstract DisplayOrientation GetNaturalDisplayOrientation(
            [NativeTypeName("SDL_DisplayID")] uint displayID
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumAllocations")]
        static abstract int GetNumAllocations();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumAudioDrivers")]
        static abstract int GetNumAudioDrivers();

        [return: NativeTypeName("Sint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumberProperty")]
        static abstract nint GetNumberProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("Sint64")] nint default_value
        );

        [return: NativeTypeName("Sint64")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumberProperty")]
        static abstract nint GetNumberProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("Sint64")] nint default_value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumCameraDrivers")]
        static abstract int GetNumCameraDrivers();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGamepadTouchpadFingers")]
        static abstract int GetNumGamepadTouchpadFingers(GamepadHandle gamepad, int touchpad);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGamepadTouchpads")]
        static abstract int GetNumGamepadTouchpads(GamepadHandle gamepad);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGPUDrivers")]
        static abstract int GetNumGPUDrivers();

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

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumLogicalCPUCores")]
        static abstract int GetNumLogicalCPUCores();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumRenderDrivers")]
        static abstract int GetNumRenderDrivers();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumVideoDrivers")]
        static abstract int GetNumVideoDrivers();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetOriginalMemoryFunctions")]
        static abstract void GetOriginalMemoryFunctions(
            [NativeTypeName("SDL_malloc_func *")] MallocFunc* malloc_func,
            [NativeTypeName("SDL_calloc_func *")] CallocFunc* calloc_func,
            [NativeTypeName("SDL_realloc_func *")] ReallocFunc* realloc_func,
            [NativeTypeName("SDL_free_func *")] FreeFunc* free_func
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetOriginalMemoryFunctions")]
        static abstract void GetOriginalMemoryFunctions(
            [NativeTypeName("SDL_malloc_func *")] Ref<MallocFunc> malloc_func,
            [NativeTypeName("SDL_calloc_func *")] Ref<CallocFunc> calloc_func,
            [NativeTypeName("SDL_realloc_func *")] Ref<ReallocFunc> realloc_func,
            [NativeTypeName("SDL_free_func *")] Ref<FreeFunc> free_func
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPathInfo")]
        static abstract byte GetPathInfo(
            [NativeTypeName("const char *")] sbyte* path,
            PathInfo* info
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPathInfo")]
        static abstract MaybeBool<byte> GetPathInfo(
            [NativeTypeName("const char *")] Ref<sbyte> path,
            Ref<PathInfo> info
        );

        [return: NativeTypeName("Uint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPerformanceCounter")]
        static abstract nuint GetPerformanceCounter();

        [return: NativeTypeName("Uint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPerformanceFrequency")]
        static abstract nuint GetPerformanceFrequency();

        [return: NativeTypeName("const SDL_PixelFormatDetails *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatDetails")]
        static abstract Ptr<PixelFormatDetails> GetPixelFormatDetails(PixelFormat format);

        [return: NativeTypeName("const SDL_PixelFormatDetails *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatDetails")]
        static abstract PixelFormatDetails* GetPixelFormatDetailsRaw(PixelFormat format);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatForMasks")]
        static abstract PixelFormat GetPixelFormatForMasks(
            int bpp,
            [NativeTypeName("Uint32")] uint Rmask,
            [NativeTypeName("Uint32")] uint Gmask,
            [NativeTypeName("Uint32")] uint Bmask,
            [NativeTypeName("Uint32")] uint Amask
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatName")]
        static abstract Ptr<sbyte> GetPixelFormatName(PixelFormat format);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatName")]
        static abstract sbyte* GetPixelFormatNameRaw(PixelFormat format);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPlatform")]
        static abstract Ptr<sbyte> GetPlatform();

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPlatform")]
        static abstract sbyte* GetPlatformRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetPointerProperty")]
        static abstract void* GetPointerProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            void* default_value
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPointerProperty")]
        static abstract Ptr GetPointerProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            Ref default_value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetPowerInfo")]
        static abstract PowerState GetPowerInfo(int* seconds, int* percent);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPowerInfo")]
        static abstract PowerState GetPowerInfo(Ref<int> seconds, Ref<int> percent);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetPreferredLocales")]
        static abstract Locale** GetPreferredLocales(int* count);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPreferredLocales")]
        static abstract Ptr2D<Locale> GetPreferredLocales(Ref<int> count);

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

        [NativeFunction("SDL3", EntryPoint = "SDL_GetProcessInput")]
        static abstract IOStreamHandle GetProcessInput(ProcessHandle process);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetProcessOutput")]
        static abstract IOStreamHandle GetProcessOutput(ProcessHandle process);

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetProcessProperties")]
        static abstract uint GetProcessProperties(ProcessHandle process);

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

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRealGamepadType")]
        static abstract GamepadType GetRealGamepadType(GamepadHandle gamepad);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRealGamepadTypeForID")]
        static abstract GamepadType GetRealGamepadTypeForID(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersection")]
        static abstract byte GetRectAndLineIntersection(
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            int* X1,
            int* Y1,
            int* X2,
            int* Y2
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersection")]
        static abstract MaybeBool<byte> GetRectAndLineIntersection(
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            Ref<int> X1,
            Ref<int> Y1,
            Ref<int> X2,
            Ref<int> Y2
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersectionFloat")]
        static abstract byte GetRectAndLineIntersectionFloat(
            [NativeTypeName("const SDL_FRect *")] FRect* rect,
            float* X1,
            float* Y1,
            float* X2,
            float* Y2
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersectionFloat")]
        static abstract MaybeBool<byte> GetRectAndLineIntersectionFloat(
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> rect,
            Ref<float> X1,
            Ref<float> Y1,
            Ref<float> X2,
            Ref<float> Y2
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPoints")]
        static abstract byte GetRectEnclosingPoints(
            [NativeTypeName("const SDL_Point *")] Point* points,
            int count,
            [NativeTypeName("const SDL_Rect *")] Rect* clip,
            Rect* result
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPoints")]
        static abstract MaybeBool<byte> GetRectEnclosingPoints(
            [NativeTypeName("const SDL_Point *")] Ref<Point> points,
            int count,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> clip,
            Ref<Rect> result
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
        static abstract byte GetRectEnclosingPointsFloat(
            [NativeTypeName("const SDL_FPoint *")] FPoint* points,
            int count,
            [NativeTypeName("const SDL_FRect *")] FRect* clip,
            FRect* result
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
        static abstract MaybeBool<byte> GetRectEnclosingPointsFloat(
            [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> points,
            int count,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> clip,
            Ref<FRect> result
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersection")]
        static abstract byte GetRectIntersection(
            [NativeTypeName("const SDL_Rect *")] Rect* A,
            [NativeTypeName("const SDL_Rect *")] Rect* B,
            Rect* result
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersection")]
        static abstract MaybeBool<byte> GetRectIntersection(
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> A,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> B,
            Ref<Rect> result
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersectionFloat")]
        static abstract byte GetRectIntersectionFloat(
            [NativeTypeName("const SDL_FRect *")] FRect* A,
            [NativeTypeName("const SDL_FRect *")] FRect* B,
            FRect* result
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersectionFloat")]
        static abstract MaybeBool<byte> GetRectIntersectionFloat(
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> A,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> B,
            Ref<FRect> result
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnion")]
        static abstract byte GetRectUnion(
            [NativeTypeName("const SDL_Rect *")] Rect* A,
            [NativeTypeName("const SDL_Rect *")] Rect* B,
            Rect* result
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnion")]
        static abstract MaybeBool<byte> GetRectUnion(
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> A,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> B,
            Ref<Rect> result
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnionFloat")]
        static abstract byte GetRectUnionFloat(
            [NativeTypeName("const SDL_FRect *")] FRect* A,
            [NativeTypeName("const SDL_FRect *")] FRect* B,
            FRect* result
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnionFloat")]
        static abstract MaybeBool<byte> GetRectUnionFloat(
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> A,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> B,
            Ref<FRect> result
        );

        [return: NativeTypeName("SDL_MouseButtonFlags")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseState")]
        static abstract uint GetRelativeMouseState(float* x, float* y);

        [return: NativeTypeName("SDL_MouseButtonFlags")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseState")]
        static abstract uint GetRelativeMouseState(Ref<float> x, Ref<float> y);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderClipRect")]
        static abstract byte GetRenderClipRect(RendererHandle renderer, Rect* rect);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderClipRect")]
        static abstract MaybeBool<byte> GetRenderClipRect(RendererHandle renderer, Ref<Rect> rect);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderColorScale")]
        static abstract byte GetRenderColorScale(RendererHandle renderer, float* scale);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderColorScale")]
        static abstract MaybeBool<byte> GetRenderColorScale(
            RendererHandle renderer,
            Ref<float> scale
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawBlendMode")]
        static abstract byte GetRenderDrawBlendMode(
            RendererHandle renderer,
            [NativeTypeName("SDL_BlendMode *")] BlendMode* blendMode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawBlendMode")]
        static abstract MaybeBool<byte> GetRenderDrawBlendMode(
            RendererHandle renderer,
            [NativeTypeName("SDL_BlendMode *")] Ref<BlendMode> blendMode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColor")]
        static abstract byte GetRenderDrawColor(
            RendererHandle renderer,
            [NativeTypeName("Uint8 *")] byte* r,
            [NativeTypeName("Uint8 *")] byte* g,
            [NativeTypeName("Uint8 *")] byte* b,
            [NativeTypeName("Uint8 *")] byte* a
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColor")]
        static abstract MaybeBool<byte> GetRenderDrawColor(
            RendererHandle renderer,
            [NativeTypeName("Uint8 *")] Ref<byte> r,
            [NativeTypeName("Uint8 *")] Ref<byte> g,
            [NativeTypeName("Uint8 *")] Ref<byte> b,
            [NativeTypeName("Uint8 *")] Ref<byte> a
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColorFloat")]
        static abstract byte GetRenderDrawColorFloat(
            RendererHandle renderer,
            float* r,
            float* g,
            float* b,
            float* a
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColorFloat")]
        static abstract MaybeBool<byte> GetRenderDrawColorFloat(
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
        static abstract RendererHandle GetRendererFromTexture(Texture* texture);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererFromTexture")]
        static abstract RendererHandle GetRendererFromTexture(Ref<Texture> texture);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererName")]
        static abstract Ptr<sbyte> GetRendererName(RendererHandle renderer);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererName")]
        static abstract sbyte* GetRendererNameRaw(RendererHandle renderer);

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererProperties")]
        static abstract uint GetRendererProperties(RendererHandle renderer);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentation")]
        static abstract byte GetRenderLogicalPresentation(
            RendererHandle renderer,
            int* w,
            int* h,
            RendererLogicalPresentation* mode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentation")]
        static abstract MaybeBool<byte> GetRenderLogicalPresentation(
            RendererHandle renderer,
            Ref<int> w,
            Ref<int> h,
            Ref<RendererLogicalPresentation> mode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentationRect")]
        static abstract byte GetRenderLogicalPresentationRect(RendererHandle renderer, FRect* rect);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentationRect")]
        static abstract MaybeBool<byte> GetRenderLogicalPresentationRect(
            RendererHandle renderer,
            Ref<FRect> rect
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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderOutputSize")]
        static abstract byte GetRenderOutputSize(RendererHandle renderer, int* w, int* h);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderOutputSize")]
        static abstract MaybeBool<byte> GetRenderOutputSize(
            RendererHandle renderer,
            Ref<int> w,
            Ref<int> h
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderSafeArea")]
        static abstract byte GetRenderSafeArea(RendererHandle renderer, Rect* rect);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderSafeArea")]
        static abstract MaybeBool<byte> GetRenderSafeArea(RendererHandle renderer, Ref<Rect> rect);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderScale")]
        static abstract byte GetRenderScale(RendererHandle renderer, float* scaleX, float* scaleY);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderScale")]
        static abstract MaybeBool<byte> GetRenderScale(
            RendererHandle renderer,
            Ref<float> scaleX,
            Ref<float> scaleY
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderTarget")]
        static abstract Ptr<Texture> GetRenderTarget(RendererHandle renderer);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderTarget")]
        static abstract Texture* GetRenderTargetRaw(RendererHandle renderer);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderViewport")]
        static abstract byte GetRenderViewport(RendererHandle renderer, Rect* rect);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderViewport")]
        static abstract MaybeBool<byte> GetRenderViewport(RendererHandle renderer, Ref<Rect> rect);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderVSync")]
        static abstract byte GetRenderVSync(RendererHandle renderer, int* vsync);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderVSync")]
        static abstract MaybeBool<byte> GetRenderVSync(RendererHandle renderer, Ref<int> vsync);

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
            [NativeTypeName("const SDL_PixelFormatDetails *")] PixelFormatDetails* format,
            [NativeTypeName("const SDL_Palette *")] Palette* palette,
            [NativeTypeName("Uint8 *")] byte* r,
            [NativeTypeName("Uint8 *")] byte* g,
            [NativeTypeName("Uint8 *")] byte* b
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRGB")]
        static abstract void GetRGB(
            [NativeTypeName("Uint32")] uint pixel,
            [NativeTypeName("const SDL_PixelFormatDetails *")] Ref<PixelFormatDetails> format,
            [NativeTypeName("const SDL_Palette *")] Ref<Palette> palette,
            [NativeTypeName("Uint8 *")] Ref<byte> r,
            [NativeTypeName("Uint8 *")] Ref<byte> g,
            [NativeTypeName("Uint8 *")] Ref<byte> b
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetRGBA")]
        static abstract void GetRgba(
            [NativeTypeName("Uint32")] uint pixel,
            [NativeTypeName("const SDL_PixelFormatDetails *")] PixelFormatDetails* format,
            [NativeTypeName("const SDL_Palette *")] Palette* palette,
            [NativeTypeName("Uint8 *")] byte* r,
            [NativeTypeName("Uint8 *")] byte* g,
            [NativeTypeName("Uint8 *")] byte* b,
            [NativeTypeName("Uint8 *")] byte* a
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRGBA")]
        static abstract void GetRgba(
            [NativeTypeName("Uint32")] uint pixel,
            [NativeTypeName("const SDL_PixelFormatDetails *")] Ref<PixelFormatDetails> format,
            [NativeTypeName("const SDL_Palette *")] Ref<Palette> palette,
            [NativeTypeName("Uint8 *")] Ref<byte> r,
            [NativeTypeName("Uint8 *")] Ref<byte> g,
            [NativeTypeName("Uint8 *")] Ref<byte> b,
            [NativeTypeName("Uint8 *")] Ref<byte> a
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSandbox")]
        static abstract Sandbox GetSandbox();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromKey")]
        static abstract Scancode GetScancodeFromKey(
            [NativeTypeName("SDL_Keycode")] uint key,
            [NativeTypeName("SDL_Keymod *")] ushort* modstate
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromKey")]
        static abstract Scancode GetScancodeFromKey(
            [NativeTypeName("SDL_Keycode")] uint key,
            [NativeTypeName("SDL_Keymod *")] Ref<ushort> modstate
        );

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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorData")]
        static abstract byte GetSensorData(SensorHandle sensor, float* data, int num_values);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorData")]
        static abstract MaybeBool<byte> GetSensorData(
            SensorHandle sensor,
            Ref<float> data,
            int num_values
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorFromID")]
        static abstract SensorHandle GetSensorFromID(
            [NativeTypeName("SDL_SensorID")] uint instance_id
        );

        [return: NativeTypeName("SDL_SensorID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorID")]
        static abstract uint GetSensorID(SensorHandle sensor);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorName")]
        static abstract Ptr<sbyte> GetSensorName(SensorHandle sensor);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNameForID")]
        static abstract Ptr<sbyte> GetSensorNameForID(
            [NativeTypeName("SDL_SensorID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNameForID")]
        static abstract sbyte* GetSensorNameForIDRaw(
            [NativeTypeName("SDL_SensorID")] uint instance_id
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorName")]
        static abstract sbyte* GetSensorNameRaw(SensorHandle sensor);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNonPortableType")]
        static abstract int GetSensorNonPortableType(SensorHandle sensor);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNonPortableTypeForID")]
        static abstract int GetSensorNonPortableTypeForID(
            [NativeTypeName("SDL_SensorID")] uint instance_id
        );

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

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorTypeForID")]
        static abstract SensorType GetSensorTypeForID(
            [NativeTypeName("SDL_SensorID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSilenceValueForFormat")]
        static abstract int GetSilenceValueForFormat(AudioFormat format);

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSIMDAlignment")]
        static abstract nuint GetSimdAlignment();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageFileSize")]
        static abstract byte GetStorageFileSize(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path,
            [NativeTypeName("Uint64 *")] nuint* length
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageFileSize")]
        static abstract MaybeBool<byte> GetStorageFileSize(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path,
            [NativeTypeName("Uint64 *")] Ref<nuint> length
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStoragePathInfo")]
        static abstract byte GetStoragePathInfo(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path,
            PathInfo* info
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStoragePathInfo")]
        static abstract MaybeBool<byte> GetStoragePathInfo(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path,
            Ref<PathInfo> info
        );

        [return: NativeTypeName("Uint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageSpaceRemaining")]
        static abstract nuint GetStorageSpaceRemaining(StorageHandle storage);

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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceAlphaMod")]
        static abstract byte GetSurfaceAlphaMod(
            Surface* surface,
            [NativeTypeName("Uint8 *")] byte* alpha
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceAlphaMod")]
        static abstract MaybeBool<byte> GetSurfaceAlphaMod(
            Ref<Surface> surface,
            [NativeTypeName("Uint8 *")] Ref<byte> alpha
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceBlendMode")]
        static abstract byte GetSurfaceBlendMode(
            Surface* surface,
            [NativeTypeName("SDL_BlendMode *")] BlendMode* blendMode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceBlendMode")]
        static abstract MaybeBool<byte> GetSurfaceBlendMode(
            Ref<Surface> surface,
            [NativeTypeName("SDL_BlendMode *")] Ref<BlendMode> blendMode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceClipRect")]
        static abstract byte GetSurfaceClipRect(Surface* surface, Rect* rect);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceClipRect")]
        static abstract MaybeBool<byte> GetSurfaceClipRect(Ref<Surface> surface, Ref<Rect> rect);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorKey")]
        static abstract byte GetSurfaceColorKey(
            Surface* surface,
            [NativeTypeName("Uint32 *")] uint* key
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorKey")]
        static abstract MaybeBool<byte> GetSurfaceColorKey(
            Ref<Surface> surface,
            [NativeTypeName("Uint32 *")] Ref<uint> key
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorMod")]
        static abstract byte GetSurfaceColorMod(
            Surface* surface,
            [NativeTypeName("Uint8 *")] byte* r,
            [NativeTypeName("Uint8 *")] byte* g,
            [NativeTypeName("Uint8 *")] byte* b
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorMod")]
        static abstract MaybeBool<byte> GetSurfaceColorMod(
            Ref<Surface> surface,
            [NativeTypeName("Uint8 *")] Ref<byte> r,
            [NativeTypeName("Uint8 *")] Ref<byte> g,
            [NativeTypeName("Uint8 *")] Ref<byte> b
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorspace")]
        static abstract Colorspace GetSurfaceColorspace(Surface* surface);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorspace")]
        static abstract Colorspace GetSurfaceColorspace(Ref<Surface> surface);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceImages")]
        static abstract Surface** GetSurfaceImages(Surface* surface, int* count);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceImages")]
        static abstract Ptr2D<Surface> GetSurfaceImages(Ref<Surface> surface, Ref<int> count);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfacePalette")]
        static abstract Palette* GetSurfacePalette(Surface* surface);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfacePalette")]
        static abstract Ptr<Palette> GetSurfacePalette(Ref<Surface> surface);

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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextInputArea")]
        static abstract byte GetTextInputArea(WindowHandle window, Rect* rect, int* cursor);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextInputArea")]
        static abstract MaybeBool<byte> GetTextInputArea(
            WindowHandle window,
            Ref<Rect> rect,
            Ref<int> cursor
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaMod")]
        static abstract byte GetTextureAlphaMod(
            Texture* texture,
            [NativeTypeName("Uint8 *")] byte* alpha
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaMod")]
        static abstract MaybeBool<byte> GetTextureAlphaMod(
            Ref<Texture> texture,
            [NativeTypeName("Uint8 *")] Ref<byte> alpha
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaModFloat")]
        static abstract byte GetTextureAlphaModFloat(Texture* texture, float* alpha);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaModFloat")]
        static abstract MaybeBool<byte> GetTextureAlphaModFloat(
            Ref<Texture> texture,
            Ref<float> alpha
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureBlendMode")]
        static abstract byte GetTextureBlendMode(
            Texture* texture,
            [NativeTypeName("SDL_BlendMode *")] BlendMode* blendMode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureBlendMode")]
        static abstract MaybeBool<byte> GetTextureBlendMode(
            Ref<Texture> texture,
            [NativeTypeName("SDL_BlendMode *")] Ref<BlendMode> blendMode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorMod")]
        static abstract byte GetTextureColorMod(
            Texture* texture,
            [NativeTypeName("Uint8 *")] byte* r,
            [NativeTypeName("Uint8 *")] byte* g,
            [NativeTypeName("Uint8 *")] byte* b
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorMod")]
        static abstract MaybeBool<byte> GetTextureColorMod(
            Ref<Texture> texture,
            [NativeTypeName("Uint8 *")] Ref<byte> r,
            [NativeTypeName("Uint8 *")] Ref<byte> g,
            [NativeTypeName("Uint8 *")] Ref<byte> b
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorModFloat")]
        static abstract byte GetTextureColorModFloat(
            Texture* texture,
            float* r,
            float* g,
            float* b
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorModFloat")]
        static abstract MaybeBool<byte> GetTextureColorModFloat(
            Ref<Texture> texture,
            Ref<float> r,
            Ref<float> g,
            Ref<float> b
        );

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureProperties")]
        static abstract uint GetTextureProperties(Texture* texture);

        [return: NativeTypeName("SDL_PropertiesID")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureProperties")]
        static abstract uint GetTextureProperties(Ref<Texture> texture);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureScaleMode")]
        static abstract byte GetTextureScaleMode(Texture* texture, ScaleMode* scaleMode);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureScaleMode")]
        static abstract MaybeBool<byte> GetTextureScaleMode(
            Ref<Texture> texture,
            Ref<ScaleMode> scaleMode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureSize")]
        static abstract byte GetTextureSize(Texture* texture, float* w, float* h);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureSize")]
        static abstract MaybeBool<byte> GetTextureSize(
            Ref<Texture> texture,
            Ref<float> w,
            Ref<float> h
        );

        [return: NativeTypeName("SDL_ThreadID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadID")]
        static abstract nuint GetThreadID(ThreadHandle thread);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadName")]
        static abstract Ptr<sbyte> GetThreadName(ThreadHandle thread);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadName")]
        static abstract sbyte* GetThreadNameRaw(ThreadHandle thread);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadState")]
        static abstract ThreadState GetThreadState(ThreadHandle thread);

        [return: NativeTypeName("Uint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTicks")]
        static abstract nuint GetTicks();

        [return: NativeTypeName("Uint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTicksNS")]
        static abstract nuint GetTicksNS();

        [NativeFunction("SDL3", EntryPoint = "SDL_GetTLS")]
        static abstract void* GetTLS([NativeTypeName("SDL_TLSID *")] AtomicInt* id);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTLS")]
        static abstract Ptr GetTLS([NativeTypeName("SDL_TLSID *")] Ref<AtomicInt> id);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceName")]
        static abstract Ptr<sbyte> GetTouchDeviceName(
            [NativeTypeName("SDL_TouchID")] nuint touchID
        );

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceName")]
        static abstract sbyte* GetTouchDeviceNameRaw([NativeTypeName("SDL_TouchID")] nuint touchID);

        [return: NativeTypeName("SDL_TouchID *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDevices")]
        static abstract nuint* GetTouchDevices(int* count);

        [return: NativeTypeName("SDL_TouchID *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDevices")]
        static abstract Ptr<nuint> GetTouchDevices(Ref<int> count);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceType")]
        static abstract TouchDeviceType GetTouchDeviceType(
            [NativeTypeName("SDL_TouchID")] nuint touchID
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchFingers")]
        static abstract Finger** GetTouchFingers(
            [NativeTypeName("SDL_TouchID")] nuint touchID,
            int* count
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchFingers")]
        static abstract Ptr2D<Finger> GetTouchFingers(
            [NativeTypeName("SDL_TouchID")] nuint touchID,
            Ref<int> count
        );

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetUserFolder")]
        static abstract Ptr<sbyte> GetUserFolder(Folder folder);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetUserFolder")]
        static abstract sbyte* GetUserFolderRaw(Folder folder);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetVersion")]
        static abstract int GetVersion();

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetVideoDriver")]
        static abstract Ptr<sbyte> GetVideoDriver(int index);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetVideoDriver")]
        static abstract sbyte* GetVideoDriverRaw(int index);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowAspectRatio")]
        static abstract byte GetWindowAspectRatio(
            WindowHandle window,
            float* min_aspect,
            float* max_aspect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowAspectRatio")]
        static abstract MaybeBool<byte> GetWindowAspectRatio(
            WindowHandle window,
            Ref<float> min_aspect,
            Ref<float> max_aspect
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowBordersSize")]
        static abstract byte GetWindowBordersSize(
            WindowHandle window,
            int* top,
            int* left,
            int* bottom,
            int* right
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowBordersSize")]
        static abstract MaybeBool<byte> GetWindowBordersSize(
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
        static abstract nuint GetWindowFlags(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFromEvent")]
        static abstract WindowHandle GetWindowFromEvent(
            [NativeTypeName("const SDL_Event *")] Event* @event
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFromEvent")]
        static abstract WindowHandle GetWindowFromEvent(
            [NativeTypeName("const SDL_Event *")] Ref<Event> @event
        );

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

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowKeyboardGrab")]
        static abstract MaybeBool<byte> GetWindowKeyboardGrab(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowKeyboardGrab")]
        static abstract byte GetWindowKeyboardGrabRaw(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMaximumSize")]
        static abstract byte GetWindowMaximumSize(WindowHandle window, int* w, int* h);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMaximumSize")]
        static abstract MaybeBool<byte> GetWindowMaximumSize(
            WindowHandle window,
            Ref<int> w,
            Ref<int> h
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMinimumSize")]
        static abstract byte GetWindowMinimumSize(WindowHandle window, int* w, int* h);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMinimumSize")]
        static abstract MaybeBool<byte> GetWindowMinimumSize(
            WindowHandle window,
            Ref<int> w,
            Ref<int> h
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseGrab")]
        static abstract MaybeBool<byte> GetWindowMouseGrab(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseGrab")]
        static abstract byte GetWindowMouseGrabRaw(WindowHandle window);

        [return: NativeTypeName("const SDL_Rect *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseRect")]
        static abstract Ptr<Rect> GetWindowMouseRect(WindowHandle window);

        [return: NativeTypeName("const SDL_Rect *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseRect")]
        static abstract Rect* GetWindowMouseRectRaw(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowOpacity")]
        static abstract float GetWindowOpacity(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowParent")]
        static abstract WindowHandle GetWindowParent(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPixelDensity")]
        static abstract float GetWindowPixelDensity(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPixelFormat")]
        static abstract PixelFormat GetWindowPixelFormat(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPosition")]
        static abstract byte GetWindowPosition(WindowHandle window, int* x, int* y);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPosition")]
        static abstract MaybeBool<byte> GetWindowPosition(
            WindowHandle window,
            Ref<int> x,
            Ref<int> y
        );

        [return: NativeTypeName("SDL_PropertiesID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowProperties")]
        static abstract uint GetWindowProperties(WindowHandle window);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowRelativeMouseMode")]
        static abstract MaybeBool<byte> GetWindowRelativeMouseMode(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowRelativeMouseMode")]
        static abstract byte GetWindowRelativeMouseModeRaw(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindows")]
        static abstract WindowHandle* GetWindows(int* count);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindows")]
        static abstract Ptr<WindowHandle> GetWindows(Ref<int> count);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSafeArea")]
        static abstract byte GetWindowSafeArea(WindowHandle window, Rect* rect);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSafeArea")]
        static abstract MaybeBool<byte> GetWindowSafeArea(WindowHandle window, Ref<Rect> rect);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSize")]
        static abstract byte GetWindowSize(WindowHandle window, int* w, int* h);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSize")]
        static abstract MaybeBool<byte> GetWindowSize(WindowHandle window, Ref<int> w, Ref<int> h);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSizeInPixels")]
        static abstract byte GetWindowSizeInPixels(WindowHandle window, int* w, int* h);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSizeInPixels")]
        static abstract MaybeBool<byte> GetWindowSizeInPixels(
            WindowHandle window,
            Ref<int> w,
            Ref<int> h
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurface")]
        static abstract Ptr<Surface> GetWindowSurface(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurface")]
        static abstract Surface* GetWindowSurfaceRaw(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurfaceVSync")]
        static abstract byte GetWindowSurfaceVSync(WindowHandle window, int* vsync);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurfaceVSync")]
        static abstract MaybeBool<byte> GetWindowSurfaceVSync(WindowHandle window, Ref<int> vsync);

        [return: NativeTypeName("const char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowTitle")]
        static abstract Ptr<sbyte> GetWindowTitle(WindowHandle window);

        [return: NativeTypeName("const char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowTitle")]
        static abstract sbyte* GetWindowTitleRaw(WindowHandle window);

        [return: NativeTypeName("SDL_GLContext")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_CreateContext")]
        static abstract GLContextStateHandle GLCreateContext(WindowHandle window);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_DestroyContext")]
        static abstract MaybeBool<byte> GLDestroyContext(
            [NativeTypeName("SDL_GLContext")] GLContextStateHandle context
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_DestroyContext")]
        static abstract byte GLDestroyContextRaw(
            [NativeTypeName("SDL_GLContext")] GLContextStateHandle context
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_ExtensionSupported")]
        static abstract byte GLExtensionSupported(
            [NativeTypeName("const char *")] sbyte* extension
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_ExtensionSupported")]
        static abstract MaybeBool<byte> GLExtensionSupported(
            [NativeTypeName("const char *")] Ref<sbyte> extension
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetAttribute")]
        static abstract byte GLGetAttribute(GLAttr attr, int* value);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetAttribute")]
        static abstract MaybeBool<byte> GLGetAttribute(GLAttr attr, Ref<int> value);

        [return: NativeTypeName("SDL_GLContext")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetCurrentContext")]
        static abstract GLContextStateHandle GLGetCurrentContext();

        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetCurrentWindow")]
        static abstract WindowHandle GLGetCurrentWindow();

        [return: NativeTypeName("SDL_FunctionPointer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetProcAddress")]
        static abstract FunctionPointer GLGetProcAddress(
            [NativeTypeName("const char *")] sbyte* proc
        );

        [return: NativeTypeName("SDL_FunctionPointer")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetProcAddress")]
        static abstract FunctionPointer GLGetProcAddress(
            [NativeTypeName("const char *")] Ref<sbyte> proc
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetSwapInterval")]
        static abstract byte GLGetSwapInterval(int* interval);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetSwapInterval")]
        static abstract MaybeBool<byte> GLGetSwapInterval(Ref<int> interval);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_LoadLibrary")]
        static abstract byte GLLoadLibrary([NativeTypeName("const char *")] sbyte* path);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_LoadLibrary")]
        static abstract MaybeBool<byte> GLLoadLibrary(
            [NativeTypeName("const char *")] Ref<sbyte> path
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_MakeCurrent")]
        static abstract MaybeBool<byte> GLMakeCurrent(
            WindowHandle window,
            [NativeTypeName("SDL_GLContext")] GLContextStateHandle context
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_MakeCurrent")]
        static abstract byte GLMakeCurrentRaw(
            WindowHandle window,
            [NativeTypeName("SDL_GLContext")] GLContextStateHandle context
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GL_ResetAttributes")]
        static abstract void GLResetAttributes();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetAttribute")]
        static abstract MaybeBool<byte> GLSetAttribute(GLAttr attr, int value);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetAttribute")]
        static abstract byte GLSetAttributeRaw(GLAttr attr, int value);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetSwapInterval")]
        static abstract MaybeBool<byte> GLSetSwapInterval(int interval);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetSwapInterval")]
        static abstract byte GLSetSwapIntervalRaw(int interval);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SwapWindow")]
        static abstract MaybeBool<byte> GLSwapWindow(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SwapWindow")]
        static abstract byte GLSwapWindowRaw(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_GL_UnloadLibrary")]
        static abstract void GLUnloadLibrary();

        [return: NativeTypeName("char **")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GlobDirectory")]
        static abstract sbyte** GlobDirectory(
            [NativeTypeName("const char *")] sbyte* path,
            [NativeTypeName("const char *")] sbyte* pattern,
            [NativeTypeName("SDL_GlobFlags")] uint flags,
            int* count
        );

        [return: NativeTypeName("char **")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GlobDirectory")]
        static abstract Ptr2D<sbyte> GlobDirectory(
            [NativeTypeName("const char *")] Ref<sbyte> path,
            [NativeTypeName("const char *")] Ref<sbyte> pattern,
            [NativeTypeName("SDL_GlobFlags")] uint flags,
            Ref<int> count
        );

        [return: NativeTypeName("char **")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GlobStorageDirectory")]
        static abstract sbyte** GlobStorageDirectory(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path,
            [NativeTypeName("const char *")] sbyte* pattern,
            [NativeTypeName("SDL_GlobFlags")] uint flags,
            int* count
        );

        [return: NativeTypeName("char **")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GlobStorageDirectory")]
        static abstract Ptr2D<sbyte> GlobStorageDirectory(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path,
            [NativeTypeName("const char *")] Ref<sbyte> pattern,
            [NativeTypeName("SDL_GlobFlags")] uint flags,
            Ref<int> count
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsProperties")]
        static abstract MaybeBool<byte> GPUSupportsProperties(
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsProperties")]
        static abstract byte GPUSupportsPropertiesRaw(
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsShaderFormats")]
        static abstract byte GPUSupportsShaderFormats(
            [NativeTypeName("SDL_GPUShaderFormat")] uint format_flags,
            [NativeTypeName("const char *")] sbyte* name
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsShaderFormats")]
        static abstract MaybeBool<byte> GPUSupportsShaderFormats(
            [NativeTypeName("SDL_GPUShaderFormat")] uint format_flags,
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureFormatTexelBlockSize")]
        static abstract uint GPUTextureFormatTexelBlockSize(GPUTextureFormat format);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsFormat")]
        static abstract MaybeBool<byte> GPUTextureSupportsFormat(
            GPUDeviceHandle device,
            GPUTextureFormat format,
            GPUTextureType type,
            [NativeTypeName("SDL_GPUTextureUsageFlags")] uint usage
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsFormat")]
        static abstract byte GPUTextureSupportsFormatRaw(
            GPUDeviceHandle device,
            GPUTextureFormat format,
            GPUTextureType type,
            [NativeTypeName("SDL_GPUTextureUsageFlags")] uint usage
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsSampleCount")]
        static abstract MaybeBool<byte> GPUTextureSupportsSampleCount(
            GPUDeviceHandle device,
            GPUTextureFormat format,
            GPUSampleCount sample_count
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsSampleCount")]
        static abstract byte GPUTextureSupportsSampleCountRaw(
            GPUDeviceHandle device,
            GPUTextureFormat format,
            GPUSampleCount sample_count
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_GUIDToString")]
        static abstract void GuidToString(
            Guid guid,
            [NativeTypeName("char *")] sbyte* pszGUID,
            int cbGUID
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_GUIDToString")]
        static abstract void GuidToString(
            Guid guid,
            [NativeTypeName("char *")] Ref<sbyte> pszGUID,
            int cbGUID
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HapticEffectSupported")]
        static abstract byte HapticEffectSupported(
            HapticHandle haptic,
            [NativeTypeName("const SDL_HapticEffect *")] HapticEffect* effect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HapticEffectSupported")]
        static abstract MaybeBool<byte> HapticEffectSupported(
            HapticHandle haptic,
            [NativeTypeName("const SDL_HapticEffect *")] Ref<HapticEffect> effect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HapticRumbleSupported")]
        static abstract MaybeBool<byte> HapticRumbleSupported(HapticHandle haptic);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HapticRumbleSupported")]
        static abstract byte HapticRumbleSupportedRaw(HapticHandle haptic);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAltiVec")]
        static abstract MaybeBool<byte> HasAltiVec();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAltiVec")]
        static abstract byte HasAltiVecRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasARMSIMD")]
        static abstract MaybeBool<byte> HasArmsimd();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasARMSIMD")]
        static abstract byte HasArmsimdRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX")]
        static abstract MaybeBool<byte> HasAVX();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX2")]
        static abstract MaybeBool<byte> HasAVX2();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX2")]
        static abstract byte HasAVX2Raw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX512F")]
        static abstract MaybeBool<byte> HasAVX512F();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX512F")]
        static abstract byte HasAVX512FRaw();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX")]
        static abstract byte HasAVXRaw();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardData")]
        static abstract byte HasClipboardData([NativeTypeName("const char *")] sbyte* mime_type);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardData")]
        static abstract MaybeBool<byte> HasClipboardData(
            [NativeTypeName("const char *")] Ref<sbyte> mime_type
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardText")]
        static abstract MaybeBool<byte> HasClipboardText();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardText")]
        static abstract byte HasClipboardTextRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasEvent")]
        static abstract MaybeBool<byte> HasEvent([NativeTypeName("Uint32")] uint type);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasEvent")]
        static abstract byte HasEventRaw([NativeTypeName("Uint32")] uint type);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasEvents")]
        static abstract MaybeBool<byte> HasEvents(
            [NativeTypeName("Uint32")] uint minType,
            [NativeTypeName("Uint32")] uint maxType
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasEvents")]
        static abstract byte HasEventsRaw(
            [NativeTypeName("Uint32")] uint minType,
            [NativeTypeName("Uint32")] uint maxType
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasGamepad")]
        static abstract MaybeBool<byte> HasGamepad();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasGamepad")]
        static abstract byte HasGamepadRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasJoystick")]
        static abstract MaybeBool<byte> HasJoystick();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasJoystick")]
        static abstract byte HasJoystickRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasKeyboard")]
        static abstract MaybeBool<byte> HasKeyboard();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasKeyboard")]
        static abstract byte HasKeyboardRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasLASX")]
        static abstract MaybeBool<byte> HasLasx();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasLASX")]
        static abstract byte HasLasxRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasLSX")]
        static abstract MaybeBool<byte> HasLSX();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasLSX")]
        static abstract byte HasLSXRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasMMX")]
        static abstract MaybeBool<byte> HasMMX();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasMMX")]
        static abstract byte HasMMXRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasMouse")]
        static abstract MaybeBool<byte> HasMouse();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasMouse")]
        static abstract byte HasMouseRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasNEON")]
        static abstract MaybeBool<byte> HasNeon();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasNEON")]
        static abstract byte HasNeonRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasPrimarySelectionText")]
        static abstract MaybeBool<byte> HasPrimarySelectionText();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasPrimarySelectionText")]
        static abstract byte HasPrimarySelectionTextRaw();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasProperty")]
        static abstract byte HasProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasProperty")]
        static abstract MaybeBool<byte> HasProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersection")]
        static abstract byte HasRectIntersection(
            [NativeTypeName("const SDL_Rect *")] Rect* A,
            [NativeTypeName("const SDL_Rect *")] Rect* B
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersection")]
        static abstract MaybeBool<byte> HasRectIntersection(
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> A,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> B
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersectionFloat")]
        static abstract byte HasRectIntersectionFloat(
            [NativeTypeName("const SDL_FRect *")] FRect* A,
            [NativeTypeName("const SDL_FRect *")] FRect* B
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersectionFloat")]
        static abstract MaybeBool<byte> HasRectIntersectionFloat(
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> A,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> B
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasScreenKeyboardSupport")]
        static abstract MaybeBool<byte> HasScreenKeyboardSupport();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasScreenKeyboardSupport")]
        static abstract byte HasScreenKeyboardSupportRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE")]
        static abstract MaybeBool<byte> HasSSE();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE2")]
        static abstract MaybeBool<byte> HasSSE2();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE2")]
        static abstract byte HasSSE2Raw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE3")]
        static abstract MaybeBool<byte> HasSSE3();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE3")]
        static abstract byte HasSSE3Raw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE41")]
        static abstract MaybeBool<byte> HasSSE41();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE41")]
        static abstract byte HasSSE41Raw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE42")]
        static abstract MaybeBool<byte> HasSSE42();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE42")]
        static abstract byte HasSSE42Raw();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE")]
        static abstract byte HasSSERaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_hid_ble_scan")]
        static abstract void HidBleScan([NativeTypeName("bool")] byte active);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_ble_scan")]
        static abstract void HidBleScan([NativeTypeName("bool")] MaybeBool<byte> active);

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

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HideCursor")]
        static abstract MaybeBool<byte> HideCursor();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HideCursor")]
        static abstract byte HideCursorRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_HideWindow")]
        static abstract MaybeBool<byte> HideWindow(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HideWindow")]
        static abstract byte HideWindowRaw(WindowHandle window);

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_iconv")]
        static abstract nuint Iconv(
            [NativeTypeName("SDL_iconv_t")] IconvDataTHandle cd,
            [NativeTypeName("const char **")] sbyte** inbuf,
            [NativeTypeName("size_t *")] nuint* inbytesleft,
            [NativeTypeName("char **")] sbyte** outbuf,
            [NativeTypeName("size_t *")] nuint* outbytesleft
        );

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_iconv")]
        static abstract nuint Iconv(
            [NativeTypeName("SDL_iconv_t")] IconvDataTHandle cd,
            [NativeTypeName("const char **")] Ref2D<sbyte> inbuf,
            [NativeTypeName("size_t *")] Ref<nuint> inbytesleft,
            [NativeTypeName("char **")] Ref2D<sbyte> outbuf,
            [NativeTypeName("size_t *")] Ref<nuint> outbytesleft
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_iconv_close")]
        static abstract int IconvClose([NativeTypeName("SDL_iconv_t")] IconvDataTHandle cd);

        [return: NativeTypeName("SDL_iconv_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_iconv_open")]
        static abstract IconvDataTHandle IconvOpen(
            [NativeTypeName("const char *")] sbyte* tocode,
            [NativeTypeName("const char *")] sbyte* fromcode
        );

        [return: NativeTypeName("SDL_iconv_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_iconv_open")]
        static abstract IconvDataTHandle IconvOpen(
            [NativeTypeName("const char *")] Ref<sbyte> tocode,
            [NativeTypeName("const char *")] Ref<sbyte> fromcode
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_iconv_string")]
        static abstract sbyte* IconvString(
            [NativeTypeName("const char *")] sbyte* tocode,
            [NativeTypeName("const char *")] sbyte* fromcode,
            [NativeTypeName("const char *")] sbyte* inbuf,
            [NativeTypeName("size_t")] nuint inbytesleft
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_iconv_string")]
        static abstract Ptr<sbyte> IconvString(
            [NativeTypeName("const char *")] Ref<sbyte> tocode,
            [NativeTypeName("const char *")] Ref<sbyte> fromcode,
            [NativeTypeName("const char *")] Ref<sbyte> inbuf,
            [NativeTypeName("size_t")] nuint inbytesleft
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_Init")]
        static abstract MaybeBool<byte> Init([NativeTypeName("SDL_InitFlags")] uint flags);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_InitHapticRumble")]
        static abstract MaybeBool<byte> InitHapticRumble(HapticHandle haptic);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_InitHapticRumble")]
        static abstract byte InitHapticRumbleRaw(HapticHandle haptic);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Init")]
        static abstract byte InitRaw([NativeTypeName("SDL_InitFlags")] uint flags);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_InitSubSystem")]
        static abstract MaybeBool<byte> InitSubSystem([NativeTypeName("SDL_InitFlags")] uint flags);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_InitSubSystem")]
        static abstract byte InitSubSystemRaw([NativeTypeName("SDL_InitFlags")] uint flags);

        [NativeFunction("SDL3", EntryPoint = "SDL_InsertGPUDebugLabel")]
        static abstract void InsertGPUDebugLabel(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("const char *")] sbyte* text
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_InsertGPUDebugLabel")]
        static abstract void InsertGPUDebugLabel(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("const char *")] Ref<sbyte> text
        );

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
            [NativeTypeName("va_list")] VaListTagHandle ap
        );

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOvprintf")]
        static abstract nuint IOvprintf(
            IOStreamHandle context,
            [NativeTypeName("const char *")] Ref<sbyte> fmt,
            [NativeTypeName("va_list")] VaListTagHandle ap
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_isalnum")]
        static abstract int Isalnum(int x);

        [NativeFunction("SDL3", EntryPoint = "SDL_isalpha")]
        static abstract int Isalpha(int x);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePhysical")]
        static abstract MaybeBool<byte> IsAudioDevicePhysical(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePhysical")]
        static abstract byte IsAudioDevicePhysicalRaw(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePlayback")]
        static abstract MaybeBool<byte> IsAudioDevicePlayback(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePlayback")]
        static abstract byte IsAudioDevicePlaybackRaw(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_isblank")]
        static abstract int Isblank(int x);

        [NativeFunction("SDL3", EntryPoint = "SDL_iscntrl")]
        static abstract int Iscntrl(int x);

        [NativeFunction("SDL3", EntryPoint = "SDL_isdigit")]
        static abstract int Isdigit(int x);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsGamepad")]
        static abstract MaybeBool<byte> IsGamepad(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsGamepad")]
        static abstract byte IsGamepadRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

        [NativeFunction("SDL3", EntryPoint = "SDL_isgraph")]
        static abstract int Isgraph(int x);

        [NativeFunction("SDL3", EntryPoint = "SDL_isinf")]
        static abstract int Isinf(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_isinff")]
        static abstract int Isinff(float x);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickHaptic")]
        static abstract MaybeBool<byte> IsJoystickHaptic(JoystickHandle joystick);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickHaptic")]
        static abstract byte IsJoystickHapticRaw(JoystickHandle joystick);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickVirtual")]
        static abstract MaybeBool<byte> IsJoystickVirtual(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickVirtual")]
        static abstract byte IsJoystickVirtualRaw(
            [NativeTypeName("SDL_JoystickID")] uint instance_id
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_islower")]
        static abstract int Islower(int x);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsMainThread")]
        static abstract MaybeBool<byte> IsMainThread();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsMainThread")]
        static abstract byte IsMainThreadRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsMouseHaptic")]
        static abstract MaybeBool<byte> IsMouseHaptic();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsMouseHaptic")]
        static abstract byte IsMouseHapticRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_isnan")]
        static abstract int Isnan(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_isnanf")]
        static abstract int Isnanf(float x);

        [NativeFunction("SDL3", EntryPoint = "SDL_isprint")]
        static abstract int Isprint(int x);

        [NativeFunction("SDL3", EntryPoint = "SDL_ispunct")]
        static abstract int Ispunct(int x);

        [NativeFunction("SDL3", EntryPoint = "SDL_isspace")]
        static abstract int Isspace(int x);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsTablet")]
        static abstract MaybeBool<byte> IsTablet();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsTablet")]
        static abstract byte IsTabletRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsTV")]
        static abstract MaybeBool<byte> IsTV();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsTV")]
        static abstract byte IsTVRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_isupper")]
        static abstract int Isupper(int x);

        [NativeFunction("SDL3", EntryPoint = "SDL_isxdigit")]
        static abstract int Isxdigit(int x);

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_itoa")]
        static abstract sbyte* Itoa(int value, [NativeTypeName("char *")] sbyte* str, int radix);

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_itoa")]
        static abstract Ptr<sbyte> Itoa(
            int value,
            [NativeTypeName("char *")] Ref<sbyte> str,
            int radix
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_JoystickConnected")]
        static abstract MaybeBool<byte> JoystickConnected(JoystickHandle joystick);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_JoystickConnected")]
        static abstract byte JoystickConnectedRaw(JoystickHandle joystick);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_JoystickEventsEnabled")]
        static abstract MaybeBool<byte> JoystickEventsEnabled();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_JoystickEventsEnabled")]
        static abstract byte JoystickEventsEnabledRaw();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_KillProcess")]
        static abstract byte KillProcess(
            ProcessHandle process,
            [NativeTypeName("bool")] byte force
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_KillProcess")]
        static abstract MaybeBool<byte> KillProcess(
            ProcessHandle process,
            [NativeTypeName("bool")] MaybeBool<byte> force
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_lltoa")]
        static abstract sbyte* Lltoa(
            [NativeTypeName("long long")] long value,
            [NativeTypeName("char *")] sbyte* str,
            int radix
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_lltoa")]
        static abstract Ptr<sbyte> Lltoa(
            [NativeTypeName("long long")] long value,
            [NativeTypeName("char *")] Ref<sbyte> str,
            int radix
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP")]
        static abstract Surface* LoadBMP([NativeTypeName("const char *")] sbyte* file);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP")]
        static abstract Ptr<Surface> LoadBMP([NativeTypeName("const char *")] Ref<sbyte> file);

        [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP_IO")]
        static abstract Surface* LoadBMPIO(
            IOStreamHandle src,
            [NativeTypeName("bool")] byte closeio
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP_IO")]
        static abstract Ptr<Surface> LoadBMPIO(
            IOStreamHandle src,
            [NativeTypeName("bool")] MaybeBool<byte> closeio
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
            [NativeTypeName("bool")] byte closeio
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile_IO")]
        static abstract Ptr LoadFileIO(
            IOStreamHandle src,
            [NativeTypeName("size_t *")] Ref<nuint> datasize,
            [NativeTypeName("bool")] MaybeBool<byte> closeio
        );

        [return: NativeTypeName("SDL_FunctionPointer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFunction")]
        static abstract FunctionPointer LoadFunction(
            SharedObjectHandle handle,
            [NativeTypeName("const char *")] sbyte* name
        );

        [return: NativeTypeName("SDL_FunctionPointer")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFunction")]
        static abstract FunctionPointer LoadFunction(
            SharedObjectHandle handle,
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_LoadObject")]
        static abstract SharedObjectHandle LoadObject(
            [NativeTypeName("const char *")] sbyte* sofile
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadObject")]
        static abstract SharedObjectHandle LoadObject(
            [NativeTypeName("const char *")] Ref<sbyte> sofile
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV")]
        static abstract byte LoadWAV(
            [NativeTypeName("const char *")] sbyte* path,
            AudioSpec* spec,
            [NativeTypeName("Uint8 **")] byte** audio_buf,
            [NativeTypeName("Uint32 *")] uint* audio_len
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV")]
        static abstract MaybeBool<byte> LoadWAV(
            [NativeTypeName("const char *")] Ref<sbyte> path,
            Ref<AudioSpec> spec,
            [NativeTypeName("Uint8 **")] Ref2D<byte> audio_buf,
            [NativeTypeName("Uint32 *")] Ref<uint> audio_len
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV_IO")]
        static abstract byte LoadWAVIO(
            IOStreamHandle src,
            [NativeTypeName("bool")] byte closeio,
            AudioSpec* spec,
            [NativeTypeName("Uint8 **")] byte** audio_buf,
            [NativeTypeName("Uint32 *")] uint* audio_len
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV_IO")]
        static abstract MaybeBool<byte> LoadWAVIO(
            IOStreamHandle src,
            [NativeTypeName("bool")] MaybeBool<byte> closeio,
            Ref<AudioSpec> spec,
            [NativeTypeName("Uint8 **")] Ref2D<byte> audio_buf,
            [NativeTypeName("Uint32 *")] Ref<uint> audio_len
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockAudioStream")]
        static abstract MaybeBool<byte> LockAudioStream(AudioStreamHandle stream);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockAudioStream")]
        static abstract byte LockAudioStreamRaw(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_LockJoysticks")]
        static abstract void LockJoysticks();

        [NativeFunction("SDL3", EntryPoint = "SDL_LockMutex")]
        static abstract void LockMutex(MutexHandle mutex);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockProperties")]
        static abstract MaybeBool<byte> LockProperties(
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockProperties")]
        static abstract byte LockPropertiesRaw([NativeTypeName("SDL_PropertiesID")] uint props);

        [NativeFunction("SDL3", EntryPoint = "SDL_LockRWLockForReading")]
        static abstract void LockRWLockForReading(RWLockHandle rwlock);

        [NativeFunction("SDL3", EntryPoint = "SDL_LockRWLockForWriting")]
        static abstract void LockRWLockForWriting(RWLockHandle rwlock);

        [NativeFunction("SDL3", EntryPoint = "SDL_LockSpinlock")]
        static abstract void LockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockSpinlock")]
        static abstract void LockSpinlock([NativeTypeName("SDL_SpinLock *")] Ref<int> @lock);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockSurface")]
        static abstract byte LockSurface(Surface* surface);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockSurface")]
        static abstract MaybeBool<byte> LockSurface(Ref<Surface> surface);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockTexture")]
        static abstract byte LockTexture(
            Texture* texture,
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            void** pixels,
            int* pitch
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockTexture")]
        static abstract MaybeBool<byte> LockTexture(
            Ref<Texture> texture,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            Ref2D pixels,
            Ref<int> pitch
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockTextureToSurface")]
        static abstract byte LockTextureToSurface(
            Texture* texture,
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            Surface** surface
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockTextureToSurface")]
        static abstract MaybeBool<byte> LockTextureToSurface(
            Ref<Texture> texture,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            Ref2D<Surface> surface
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_log")]
        static abstract double Log(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_log10")]
        static abstract double Log10(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_log10f")]
        static abstract float Log10F(float x);

        [NativeFunction("SDL3", EntryPoint = "SDL_logf")]
        static abstract float Logf(float x);

        [NativeFunction("SDL3", EntryPoint = "SDL_LogMessageV")]
        static abstract void LogMessageV(
            int category,
            LogPriority priority,
            [NativeTypeName("const char *")] sbyte* fmt,
            [NativeTypeName("va_list")] VaListTagHandle ap
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_LogMessageV")]
        static abstract void LogMessageV(
            int category,
            LogPriority priority,
            [NativeTypeName("const char *")] Ref<sbyte> fmt,
            [NativeTypeName("va_list")] VaListTagHandle ap
        );

        [return: NativeTypeName("long")]
        [NativeFunction("SDL3", EntryPoint = "SDL_lround")]
        static abstract nint Lround(double x);

        [return: NativeTypeName("long")]
        [NativeFunction("SDL3", EntryPoint = "SDL_lroundf")]
        static abstract nint Lroundf(float x);

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ltoa")]
        static abstract sbyte* Ltoa(
            [NativeTypeName("long")] nint value,
            [NativeTypeName("char *")] sbyte* str,
            int radix
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ltoa")]
        static abstract Ptr<sbyte> Ltoa(
            [NativeTypeName("long")] nint value,
            [NativeTypeName("char *")] Ref<sbyte> str,
            int radix
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_main")]
        static abstract int Main(int argc, [NativeTypeName("char *[]")] sbyte** argv);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_main")]
        static abstract int Main(int argc, [NativeTypeName("char *[]")] Ref2D<sbyte> argv);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_malloc")]
        static abstract Ptr Malloc([NativeTypeName("size_t")] nuint size);

        [NativeFunction("SDL3", EntryPoint = "SDL_malloc")]
        static abstract void* MallocRaw([NativeTypeName("size_t")] nuint size);

        [NativeFunction("SDL3", EntryPoint = "SDL_MapGPUTransferBuffer")]
        static abstract void* MapGPUTransferBuffer(
            GPUDeviceHandle device,
            GPUTransferBufferHandle transfer_buffer,
            [NativeTypeName("bool")] byte cycle
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapGPUTransferBuffer")]
        static abstract Ptr MapGPUTransferBuffer(
            GPUDeviceHandle device,
            GPUTransferBufferHandle transfer_buffer,
            [NativeTypeName("bool")] MaybeBool<byte> cycle
        );

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapRGB")]
        static abstract uint MapRGB(
            [NativeTypeName("const SDL_PixelFormatDetails *")] PixelFormatDetails* format,
            [NativeTypeName("const SDL_Palette *")] Palette* palette,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b
        );

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapRGB")]
        static abstract uint MapRGB(
            [NativeTypeName("const SDL_PixelFormatDetails *")] Ref<PixelFormatDetails> format,
            [NativeTypeName("const SDL_Palette *")] Ref<Palette> palette,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b
        );

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapRGBA")]
        static abstract uint MapRgba(
            [NativeTypeName("const SDL_PixelFormatDetails *")] PixelFormatDetails* format,
            [NativeTypeName("const SDL_Palette *")] Palette* palette,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b,
            [NativeTypeName("Uint8")] byte a
        );

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapRGBA")]
        static abstract uint MapRgba(
            [NativeTypeName("const SDL_PixelFormatDetails *")] Ref<PixelFormatDetails> format,
            [NativeTypeName("const SDL_Palette *")] Ref<Palette> palette,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b,
            [NativeTypeName("Uint8")] byte a
        );

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGB")]
        static abstract uint MapSurfaceRGB(
            Surface* surface,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b
        );

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGB")]
        static abstract uint MapSurfaceRGB(
            Ref<Surface> surface,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b
        );

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGBA")]
        static abstract uint MapSurfaceRgba(
            Surface* surface,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b,
            [NativeTypeName("Uint8")] byte a
        );

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGBA")]
        static abstract uint MapSurfaceRgba(
            Ref<Surface> surface,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b,
            [NativeTypeName("Uint8")] byte a
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_MaximizeWindow")]
        static abstract MaybeBool<byte> MaximizeWindow(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MaximizeWindow")]
        static abstract byte MaximizeWindowRaw(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_memcmp")]
        static abstract int Memcmp(
            [NativeTypeName("const void *")] void* s1,
            [NativeTypeName("const void *")] void* s2,
            [NativeTypeName("size_t")] nuint len
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_memcmp")]
        static abstract int Memcmp(
            [NativeTypeName("const void *")] Ref s1,
            [NativeTypeName("const void *")] Ref s2,
            [NativeTypeName("size_t")] nuint len
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_MemoryBarrierAcquireFunction")]
        static abstract void MemoryBarrierAcquireFunction();

        [NativeFunction("SDL3", EntryPoint = "SDL_MemoryBarrierReleaseFunction")]
        static abstract void MemoryBarrierReleaseFunction();

        [NativeFunction("SDL3", EntryPoint = "SDL_memset4")]
        static abstract void* Memset4(
            void* dst,
            [NativeTypeName("Uint32")] uint val,
            [NativeTypeName("size_t")] nuint dwords
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_memset4")]
        static abstract Ptr Memset4(
            Ref dst,
            [NativeTypeName("Uint32")] uint val,
            [NativeTypeName("size_t")] nuint dwords
        );

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

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_MinimizeWindow")]
        static abstract MaybeBool<byte> MinimizeWindow(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MinimizeWindow")]
        static abstract byte MinimizeWindowRaw(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MixAudio")]
        static abstract byte MixAudio(
            [NativeTypeName("Uint8 *")] byte* dst,
            [NativeTypeName("const Uint8 *")] byte* src,
            AudioFormat format,
            [NativeTypeName("Uint32")] uint len,
            float volume
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_MixAudio")]
        static abstract MaybeBool<byte> MixAudio(
            [NativeTypeName("Uint8 *")] Ref<byte> dst,
            [NativeTypeName("const Uint8 *")] Ref<byte> src,
            AudioFormat format,
            [NativeTypeName("Uint32")] uint len,
            float volume
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_modf")]
        static abstract double Modf(double x, double* y);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_modf")]
        static abstract double Modf(double x, Ref<double> y);

        [NativeFunction("SDL3", EntryPoint = "SDL_modff")]
        static abstract float Modff(float x, float* y);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_modff")]
        static abstract float Modff(float x, Ref<float> y);

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_murmur3_32")]
        static abstract uint Murmur3X32(
            [NativeTypeName("const void *")] void* data,
            [NativeTypeName("size_t")] nuint len,
            [NativeTypeName("Uint32")] uint seed
        );

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_murmur3_32")]
        static abstract uint Murmur3X32(
            [NativeTypeName("const void *")] Ref data,
            [NativeTypeName("size_t")] nuint len,
            [NativeTypeName("Uint32")] uint seed
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidEnterBackground")]
        static abstract void OnApplicationDidEnterBackground();

        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidEnterForeground")]
        static abstract void OnApplicationDidEnterForeground();

        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning")]
        static abstract void OnApplicationDidReceiveMemoryWarning();

        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillEnterBackground")]
        static abstract void OnApplicationWillEnterBackground();

        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillEnterForeground")]
        static abstract void OnApplicationWillEnterForeground();

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
            [NativeTypeName("SDL_AudioStreamCallback")] AudioStreamCallback callback,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDeviceStream")]
        static abstract AudioStreamHandle OpenAudioDeviceStream(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> spec,
            [NativeTypeName("SDL_AudioStreamCallback")] AudioStreamCallback callback,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_OpenCamera")]
        static abstract CameraHandle OpenCamera(
            [NativeTypeName("SDL_CameraID")] uint instance_id,
            [NativeTypeName("const SDL_CameraSpec *")] CameraSpec* spec
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenCamera")]
        static abstract CameraHandle OpenCamera(
            [NativeTypeName("SDL_CameraID")] uint instance_id,
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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenURL")]
        static abstract byte OpenURL([NativeTypeName("const char *")] sbyte* url);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenURL")]
        static abstract MaybeBool<byte> OpenURL([NativeTypeName("const char *")] Ref<sbyte> url);

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

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_OutOfMemory")]
        static abstract MaybeBool<byte> OutOfMemory();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OutOfMemory")]
        static abstract byte OutOfMemoryRaw();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioDevice")]
        static abstract MaybeBool<byte> PauseAudioDevice(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioDevice")]
        static abstract byte PauseAudioDeviceRaw([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioStreamDevice")]
        static abstract MaybeBool<byte> PauseAudioStreamDevice(AudioStreamHandle stream);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioStreamDevice")]
        static abstract byte PauseAudioStreamDeviceRaw(AudioStreamHandle stream);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PauseHaptic")]
        static abstract MaybeBool<byte> PauseHaptic(HapticHandle haptic);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PauseHaptic")]
        static abstract byte PauseHapticRaw(HapticHandle haptic);

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

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PlayHapticRumble")]
        static abstract MaybeBool<byte> PlayHapticRumble(
            HapticHandle haptic,
            float strength,
            [NativeTypeName("Uint32")] uint length
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PlayHapticRumble")]
        static abstract byte PlayHapticRumbleRaw(
            HapticHandle haptic,
            float strength,
            [NativeTypeName("Uint32")] uint length
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PollEvent")]
        static abstract byte PollEvent(Event* @event);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PollEvent")]
        static abstract MaybeBool<byte> PollEvent(Ref<Event> @event);

        [NativeFunction("SDL3", EntryPoint = "SDL_PopGPUDebugGroup")]
        static abstract void PopGPUDebugGroup(GPUCommandBufferHandle command_buffer);

        [NativeFunction("SDL3", EntryPoint = "SDL_pow")]
        static abstract double Pow(double x, double y);

        [NativeFunction("SDL3", EntryPoint = "SDL_powf")]
        static abstract float Powf(float x, float y);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplyAlpha")]
        static abstract byte PremultiplyAlpha(
            int width,
            int height,
            PixelFormat src_format,
            [NativeTypeName("const void *")] void* src,
            int src_pitch,
            PixelFormat dst_format,
            void* dst,
            int dst_pitch,
            [NativeTypeName("bool")] byte linear
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplyAlpha")]
        static abstract MaybeBool<byte> PremultiplyAlpha(
            int width,
            int height,
            PixelFormat src_format,
            [NativeTypeName("const void *")] Ref src,
            int src_pitch,
            PixelFormat dst_format,
            Ref dst,
            int dst_pitch,
            [NativeTypeName("bool")] MaybeBool<byte> linear
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplySurfaceAlpha")]
        static abstract byte PremultiplySurfaceAlpha(
            Surface* surface,
            [NativeTypeName("bool")] byte linear
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplySurfaceAlpha")]
        static abstract MaybeBool<byte> PremultiplySurfaceAlpha(
            Ref<Surface> surface,
            [NativeTypeName("bool")] MaybeBool<byte> linear
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_PumpEvents")]
        static abstract void PumpEvents();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushEvent")]
        static abstract byte PushEvent(Event* @event);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushEvent")]
        static abstract MaybeBool<byte> PushEvent(Ref<Event> @event);

        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUComputeUniformData")]
        static abstract void PushGPUComputeUniformData(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("Uint32")] uint slot_index,
            [NativeTypeName("const void *")] void* data,
            [NativeTypeName("Uint32")] uint length
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUComputeUniformData")]
        static abstract void PushGPUComputeUniformData(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("Uint32")] uint slot_index,
            [NativeTypeName("const void *")] Ref data,
            [NativeTypeName("Uint32")] uint length
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUDebugGroup")]
        static abstract void PushGPUDebugGroup(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("const char *")] sbyte* name
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUDebugGroup")]
        static abstract void PushGPUDebugGroup(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUFragmentUniformData")]
        static abstract void PushGPUFragmentUniformData(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("Uint32")] uint slot_index,
            [NativeTypeName("const void *")] void* data,
            [NativeTypeName("Uint32")] uint length
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUFragmentUniformData")]
        static abstract void PushGPUFragmentUniformData(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("Uint32")] uint slot_index,
            [NativeTypeName("const void *")] Ref data,
            [NativeTypeName("Uint32")] uint length
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUVertexUniformData")]
        static abstract void PushGPUVertexUniformData(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("Uint32")] uint slot_index,
            [NativeTypeName("const void *")] void* data,
            [NativeTypeName("Uint32")] uint length
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUVertexUniformData")]
        static abstract void PushGPUVertexUniformData(
            GPUCommandBufferHandle command_buffer,
            [NativeTypeName("Uint32")] uint slot_index,
            [NativeTypeName("const void *")] Ref data,
            [NativeTypeName("Uint32")] uint length
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PutAudioStreamData")]
        static abstract byte PutAudioStreamData(
            AudioStreamHandle stream,
            [NativeTypeName("const void *")] void* buf,
            int len
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_PutAudioStreamData")]
        static abstract MaybeBool<byte> PutAudioStreamData(
            AudioStreamHandle stream,
            [NativeTypeName("const void *")] Ref buf,
            int len
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_qsort")]
        static abstract void Qsort(
            void* @base,
            [NativeTypeName("size_t")] nuint nmemb,
            [NativeTypeName("size_t")] nuint size,
            [NativeTypeName("SDL_CompareCallback")] CompareCallback compare
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_qsort")]
        static abstract void Qsort(
            Ref @base,
            [NativeTypeName("size_t")] nuint nmemb,
            [NativeTypeName("size_t")] nuint size,
            [NativeTypeName("SDL_CompareCallback")] CompareCallback compare
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_qsort_r")]
        static abstract void QsortR(
            void* @base,
            [NativeTypeName("size_t")] nuint nmemb,
            [NativeTypeName("size_t")] nuint size,
            [NativeTypeName("SDL_CompareCallback_r")] CompareCallbackR compare,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_qsort_r")]
        static abstract void QsortR(
            Ref @base,
            [NativeTypeName("size_t")] nuint nmemb,
            [NativeTypeName("size_t")] nuint size,
            [NativeTypeName("SDL_CompareCallback_r")] CompareCallbackR compare,
            Ref userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_QueryGPUFence")]
        static abstract MaybeBool<byte> QueryGPUFence(GPUDeviceHandle device, GPUFenceHandle fence);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_QueryGPUFence")]
        static abstract byte QueryGPUFenceRaw(GPUDeviceHandle device, GPUFenceHandle fence);

        [NativeFunction("SDL3", EntryPoint = "SDL_Quit")]
        static abstract void Quit();

        [NativeFunction("SDL3", EntryPoint = "SDL_QuitSubSystem")]
        static abstract void QuitSubSystem([NativeTypeName("SDL_InitFlags")] uint flags);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RaiseWindow")]
        static abstract MaybeBool<byte> RaiseWindow(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RaiseWindow")]
        static abstract byte RaiseWindowRaw(WindowHandle window);

        [return: NativeTypeName("Sint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_rand")]
        static abstract int Rand([NativeTypeName("Sint32")] int n);

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_rand_bits")]
        static abstract uint RandBits();

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_rand_bits_r")]
        static abstract uint RandBitsR([NativeTypeName("Uint64 *")] nuint* state);

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_rand_bits_r")]
        static abstract uint RandBitsR([NativeTypeName("Uint64 *")] Ref<nuint> state);

        [return: NativeTypeName("Sint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_rand_r")]
        static abstract int RandR(
            [NativeTypeName("Uint64 *")] nuint* state,
            [NativeTypeName("Sint32")] int n
        );

        [return: NativeTypeName("Sint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_rand_r")]
        static abstract int RandR(
            [NativeTypeName("Uint64 *")] Ref<nuint> state,
            [NativeTypeName("Sint32")] int n
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_randf")]
        static abstract float Randf();

        [NativeFunction("SDL3", EntryPoint = "SDL_randf_r")]
        static abstract float RandfR([NativeTypeName("Uint64 *")] nuint* state);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_randf_r")]
        static abstract float RandfR([NativeTypeName("Uint64 *")] Ref<nuint> state);

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

        [NativeFunction("SDL3", EntryPoint = "SDL_ReadProcess")]
        static abstract void* ReadProcess(
            ProcessHandle process,
            [NativeTypeName("size_t *")] nuint* datasize,
            int* exitcode
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadProcess")]
        static abstract Ptr ReadProcess(
            ProcessHandle process,
            [NativeTypeName("size_t *")] Ref<nuint> datasize,
            Ref<int> exitcode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16BE")]
        static abstract byte ReadS16BE(
            IOStreamHandle src,
            [NativeTypeName("Sint16 *")] short* value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16BE")]
        static abstract MaybeBool<byte> ReadS16BE(
            IOStreamHandle src,
            [NativeTypeName("Sint16 *")] Ref<short> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16LE")]
        static abstract byte ReadS16LE(
            IOStreamHandle src,
            [NativeTypeName("Sint16 *")] short* value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16LE")]
        static abstract MaybeBool<byte> ReadS16LE(
            IOStreamHandle src,
            [NativeTypeName("Sint16 *")] Ref<short> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32BE")]
        static abstract byte ReadS32BE(IOStreamHandle src, [NativeTypeName("Sint32 *")] int* value);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32BE")]
        static abstract MaybeBool<byte> ReadS32BE(
            IOStreamHandle src,
            [NativeTypeName("Sint32 *")] Ref<int> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32LE")]
        static abstract byte ReadS32LE(IOStreamHandle src, [NativeTypeName("Sint32 *")] int* value);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32LE")]
        static abstract MaybeBool<byte> ReadS32LE(
            IOStreamHandle src,
            [NativeTypeName("Sint32 *")] Ref<int> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64BE")]
        static abstract byte ReadS64BE(
            IOStreamHandle src,
            [NativeTypeName("Sint64 *")] nint* value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64BE")]
        static abstract MaybeBool<byte> ReadS64BE(
            IOStreamHandle src,
            [NativeTypeName("Sint64 *")] Ref<nint> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64LE")]
        static abstract byte ReadS64LE(
            IOStreamHandle src,
            [NativeTypeName("Sint64 *")] nint* value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64LE")]
        static abstract MaybeBool<byte> ReadS64LE(
            IOStreamHandle src,
            [NativeTypeName("Sint64 *")] Ref<nint> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS8")]
        static abstract byte ReadS8(IOStreamHandle src, [NativeTypeName("Sint8 *")] sbyte* value);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS8")]
        static abstract MaybeBool<byte> ReadS8(
            IOStreamHandle src,
            [NativeTypeName("Sint8 *")] Ref<sbyte> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadStorageFile")]
        static abstract byte ReadStorageFile(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path,
            void* destination,
            [NativeTypeName("Uint64")] nuint length
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadStorageFile")]
        static abstract MaybeBool<byte> ReadStorageFile(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path,
            Ref destination,
            [NativeTypeName("Uint64")] nuint length
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixel")]
        static abstract byte ReadSurfacePixel(
            Surface* surface,
            int x,
            int y,
            [NativeTypeName("Uint8 *")] byte* r,
            [NativeTypeName("Uint8 *")] byte* g,
            [NativeTypeName("Uint8 *")] byte* b,
            [NativeTypeName("Uint8 *")] byte* a
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixel")]
        static abstract MaybeBool<byte> ReadSurfacePixel(
            Ref<Surface> surface,
            int x,
            int y,
            [NativeTypeName("Uint8 *")] Ref<byte> r,
            [NativeTypeName("Uint8 *")] Ref<byte> g,
            [NativeTypeName("Uint8 *")] Ref<byte> b,
            [NativeTypeName("Uint8 *")] Ref<byte> a
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixelFloat")]
        static abstract byte ReadSurfacePixelFloat(
            Surface* surface,
            int x,
            int y,
            float* r,
            float* g,
            float* b,
            float* a
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixelFloat")]
        static abstract MaybeBool<byte> ReadSurfacePixelFloat(
            Ref<Surface> surface,
            int x,
            int y,
            Ref<float> r,
            Ref<float> g,
            Ref<float> b,
            Ref<float> a
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16BE")]
        static abstract byte ReadU16BE(
            IOStreamHandle src,
            [NativeTypeName("Uint16 *")] ushort* value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16BE")]
        static abstract MaybeBool<byte> ReadU16BE(
            IOStreamHandle src,
            [NativeTypeName("Uint16 *")] Ref<ushort> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16LE")]
        static abstract byte ReadU16LE(
            IOStreamHandle src,
            [NativeTypeName("Uint16 *")] ushort* value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16LE")]
        static abstract MaybeBool<byte> ReadU16LE(
            IOStreamHandle src,
            [NativeTypeName("Uint16 *")] Ref<ushort> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32BE")]
        static abstract byte ReadU32BE(
            IOStreamHandle src,
            [NativeTypeName("Uint32 *")] uint* value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32BE")]
        static abstract MaybeBool<byte> ReadU32BE(
            IOStreamHandle src,
            [NativeTypeName("Uint32 *")] Ref<uint> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32LE")]
        static abstract byte ReadU32LE(
            IOStreamHandle src,
            [NativeTypeName("Uint32 *")] uint* value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32LE")]
        static abstract MaybeBool<byte> ReadU32LE(
            IOStreamHandle src,
            [NativeTypeName("Uint32 *")] Ref<uint> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64BE")]
        static abstract byte ReadU64BE(
            IOStreamHandle src,
            [NativeTypeName("Uint64 *")] nuint* value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64BE")]
        static abstract MaybeBool<byte> ReadU64BE(
            IOStreamHandle src,
            [NativeTypeName("Uint64 *")] Ref<nuint> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64LE")]
        static abstract byte ReadU64LE(
            IOStreamHandle src,
            [NativeTypeName("Uint64 *")] nuint* value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64LE")]
        static abstract MaybeBool<byte> ReadU64LE(
            IOStreamHandle src,
            [NativeTypeName("Uint64 *")] Ref<nuint> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU8")]
        static abstract byte ReadU8(IOStreamHandle src, [NativeTypeName("Uint8 *")] byte* value);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU8")]
        static abstract MaybeBool<byte> ReadU8(
            IOStreamHandle src,
            [NativeTypeName("Uint8 *")] Ref<byte> value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_realloc")]
        static abstract void* Realloc(void* mem, [NativeTypeName("size_t")] nuint size);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_realloc")]
        static abstract Ptr Realloc(Ref mem, [NativeTypeName("size_t")] nuint size);

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RegisterEvents")]
        static abstract uint RegisterEvents(int numevents);

        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseCameraFrame")]
        static abstract void ReleaseCameraFrame(CameraHandle camera, Surface* frame);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseCameraFrame")]
        static abstract void ReleaseCameraFrame(CameraHandle camera, Ref<Surface> frame);

        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUBuffer")]
        static abstract void ReleaseGPUBuffer(GPUDeviceHandle device, GPUBufferHandle buffer);

        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUComputePipeline")]
        static abstract void ReleaseGPUComputePipeline(
            GPUDeviceHandle device,
            GPUComputePipelineHandle compute_pipeline
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUFence")]
        static abstract void ReleaseGPUFence(GPUDeviceHandle device, GPUFenceHandle fence);

        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUGraphicsPipeline")]
        static abstract void ReleaseGPUGraphicsPipeline(
            GPUDeviceHandle device,
            GPUGraphicsPipelineHandle graphics_pipeline
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUSampler")]
        static abstract void ReleaseGPUSampler(GPUDeviceHandle device, GPUSamplerHandle sampler);

        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUShader")]
        static abstract void ReleaseGPUShader(GPUDeviceHandle device, GPUShaderHandle shader);

        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUTexture")]
        static abstract void ReleaseGPUTexture(GPUDeviceHandle device, GPUTextureHandle texture);

        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUTransferBuffer")]
        static abstract void ReleaseGPUTransferBuffer(
            GPUDeviceHandle device,
            GPUTransferBufferHandle transfer_buffer
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseWindowFromGPUDevice")]
        static abstract void ReleaseWindowFromGPUDevice(
            GPUDeviceHandle device,
            WindowHandle window
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReloadGamepadMappings")]
        static abstract MaybeBool<byte> ReloadGamepadMappings();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReloadGamepadMappings")]
        static abstract byte ReloadGamepadMappingsRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveEventWatch")]
        static abstract void RemoveEventWatch(
            [NativeTypeName("SDL_EventFilter")] EventFilter filter,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveEventWatch")]
        static abstract void RemoveEventWatch(
            [NativeTypeName("SDL_EventFilter")] EventFilter filter,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveHintCallback")]
        static abstract void RemoveHintCallback(
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("SDL_HintCallback")] HintCallback callback,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveHintCallback")]
        static abstract void RemoveHintCallback(
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("SDL_HintCallback")] HintCallback callback,
            Ref userdata
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemovePath")]
        static abstract byte RemovePath([NativeTypeName("const char *")] sbyte* path);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemovePath")]
        static abstract MaybeBool<byte> RemovePath(
            [NativeTypeName("const char *")] Ref<sbyte> path
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveStoragePath")]
        static abstract byte RemoveStoragePath(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveStoragePath")]
        static abstract MaybeBool<byte> RemoveStoragePath(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveSurfaceAlternateImages")]
        static abstract void RemoveSurfaceAlternateImages(Surface* surface);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveSurfaceAlternateImages")]
        static abstract void RemoveSurfaceAlternateImages(Ref<Surface> surface);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveTimer")]
        static abstract MaybeBool<byte> RemoveTimer([NativeTypeName("SDL_TimerID")] uint id);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveTimer")]
        static abstract byte RemoveTimerRaw([NativeTypeName("SDL_TimerID")] uint id);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenamePath")]
        static abstract byte RenamePath(
            [NativeTypeName("const char *")] sbyte* oldpath,
            [NativeTypeName("const char *")] sbyte* newpath
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenamePath")]
        static abstract MaybeBool<byte> RenamePath(
            [NativeTypeName("const char *")] Ref<sbyte> oldpath,
            [NativeTypeName("const char *")] Ref<sbyte> newpath
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenameStoragePath")]
        static abstract byte RenameStoragePath(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* oldpath,
            [NativeTypeName("const char *")] sbyte* newpath
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenameStoragePath")]
        static abstract MaybeBool<byte> RenameStoragePath(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> oldpath,
            [NativeTypeName("const char *")] Ref<sbyte> newpath
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderClear")]
        static abstract MaybeBool<byte> RenderClear(RendererHandle renderer);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderClear")]
        static abstract byte RenderClearRaw(RendererHandle renderer);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderClipEnabled")]
        static abstract MaybeBool<byte> RenderClipEnabled(RendererHandle renderer);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderClipEnabled")]
        static abstract byte RenderClipEnabledRaw(RendererHandle renderer);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesFromWindow")]
        static abstract byte RenderCoordinatesFromWindow(
            RendererHandle renderer,
            float window_x,
            float window_y,
            float* x,
            float* y
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesFromWindow")]
        static abstract MaybeBool<byte> RenderCoordinatesFromWindow(
            RendererHandle renderer,
            float window_x,
            float window_y,
            Ref<float> x,
            Ref<float> y
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesToWindow")]
        static abstract byte RenderCoordinatesToWindow(
            RendererHandle renderer,
            float x,
            float y,
            float* window_x,
            float* window_y
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesToWindow")]
        static abstract MaybeBool<byte> RenderCoordinatesToWindow(
            RendererHandle renderer,
            float x,
            float y,
            Ref<float> window_x,
            Ref<float> window_y
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderDebugText")]
        static abstract byte RenderDebugText(
            RendererHandle renderer,
            float x,
            float y,
            [NativeTypeName("const char *")] sbyte* str
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderDebugText")]
        static abstract MaybeBool<byte> RenderDebugText(
            RendererHandle renderer,
            float x,
            float y,
            [NativeTypeName("const char *")] Ref<sbyte> str
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRect")]
        static abstract byte RenderFillRect(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] FRect* rect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRect")]
        static abstract MaybeBool<byte> RenderFillRect(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> rect
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRects")]
        static abstract byte RenderFillRects(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] FRect* rects,
            int count
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRects")]
        static abstract MaybeBool<byte> RenderFillRects(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> rects,
            int count
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometry")]
        static abstract byte RenderGeometry(
            RendererHandle renderer,
            Texture* texture,
            [NativeTypeName("const SDL_Vertex *")] Vertex* vertices,
            int num_vertices,
            [NativeTypeName("const int *")] int* indices,
            int num_indices
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometry")]
        static abstract MaybeBool<byte> RenderGeometry(
            RendererHandle renderer,
            Ref<Texture> texture,
            [NativeTypeName("const SDL_Vertex *")] Ref<Vertex> vertices,
            int num_vertices,
            [NativeTypeName("const int *")] Ref<int> indices,
            int num_indices
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRaw")]
        static abstract byte RenderGeometryRaw(
            RendererHandle renderer,
            Texture* texture,
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

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRaw")]
        static abstract MaybeBool<byte> RenderGeometryRaw(
            RendererHandle renderer,
            Ref<Texture> texture,
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

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderLine")]
        static abstract MaybeBool<byte> RenderLine(
            RendererHandle renderer,
            float x1,
            float y1,
            float x2,
            float y2
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderLine")]
        static abstract byte RenderLineRaw(
            RendererHandle renderer,
            float x1,
            float y1,
            float x2,
            float y2
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderLines")]
        static abstract byte RenderLines(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FPoint *")] FPoint* points,
            int count
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderLines")]
        static abstract MaybeBool<byte> RenderLines(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> points,
            int count
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoint")]
        static abstract MaybeBool<byte> RenderPoint(RendererHandle renderer, float x, float y);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoint")]
        static abstract byte RenderPointRaw(RendererHandle renderer, float x, float y);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoints")]
        static abstract byte RenderPoints(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FPoint *")] FPoint* points,
            int count
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoints")]
        static abstract MaybeBool<byte> RenderPoints(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> points,
            int count
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPresent")]
        static abstract MaybeBool<byte> RenderPresent(RendererHandle renderer);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPresent")]
        static abstract byte RenderPresentRaw(RendererHandle renderer);

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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderRect")]
        static abstract byte RenderRect(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] FRect* rect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderRect")]
        static abstract MaybeBool<byte> RenderRect(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> rect
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderRects")]
        static abstract byte RenderRects(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] FRect* rects,
            int count
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderRects")]
        static abstract MaybeBool<byte> RenderRects(
            RendererHandle renderer,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> rects,
            int count
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture")]
        static abstract byte RenderTexture(
            RendererHandle renderer,
            Texture* texture,
            [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
            [NativeTypeName("const SDL_FRect *")] FRect* dstrect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture")]
        static abstract MaybeBool<byte> RenderTexture(
            RendererHandle renderer,
            Ref<Texture> texture,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> srcrect,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> dstrect
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture9Grid")]
        static abstract byte RenderTexture9Grid(
            RendererHandle renderer,
            Texture* texture,
            [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
            float left_width,
            float right_width,
            float top_height,
            float bottom_height,
            float scale,
            [NativeTypeName("const SDL_FRect *")] FRect* dstrect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture9Grid")]
        static abstract MaybeBool<byte> RenderTexture9Grid(
            RendererHandle renderer,
            Ref<Texture> texture,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> srcrect,
            float left_width,
            float right_width,
            float top_height,
            float bottom_height,
            float scale,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> dstrect
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureAffine")]
        static abstract byte RenderTextureAffine(
            RendererHandle renderer,
            Texture* texture,
            [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
            [NativeTypeName("const SDL_FPoint *")] FPoint* origin,
            [NativeTypeName("const SDL_FPoint *")] FPoint* right,
            [NativeTypeName("const SDL_FPoint *")] FPoint* down
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureAffine")]
        static abstract MaybeBool<byte> RenderTextureAffine(
            RendererHandle renderer,
            Ref<Texture> texture,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> srcrect,
            [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> origin,
            [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> right,
            [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> down
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureRotated")]
        static abstract byte RenderTextureRotated(
            RendererHandle renderer,
            Texture* texture,
            [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
            [NativeTypeName("const SDL_FRect *")] FRect* dstrect,
            double angle,
            [NativeTypeName("const SDL_FPoint *")] FPoint* center,
            FlipMode flip
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureRotated")]
        static abstract MaybeBool<byte> RenderTextureRotated(
            RendererHandle renderer,
            Ref<Texture> texture,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> srcrect,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> dstrect,
            double angle,
            [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> center,
            FlipMode flip
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureTiled")]
        static abstract byte RenderTextureTiled(
            RendererHandle renderer,
            Texture* texture,
            [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
            float scale,
            [NativeTypeName("const SDL_FRect *")] FRect* dstrect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureTiled")]
        static abstract MaybeBool<byte> RenderTextureTiled(
            RendererHandle renderer,
            Ref<Texture> texture,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> srcrect,
            float scale,
            [NativeTypeName("const SDL_FRect *")] Ref<FRect> dstrect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderViewportSet")]
        static abstract MaybeBool<byte> RenderViewportSet(RendererHandle renderer);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderViewportSet")]
        static abstract byte RenderViewportSetRaw(RendererHandle renderer);

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

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResetHint")]
        static abstract byte ResetHint([NativeTypeName("const char *")] sbyte* name);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResetHint")]
        static abstract MaybeBool<byte> ResetHint([NativeTypeName("const char *")] Ref<sbyte> name);

        [NativeFunction("SDL3", EntryPoint = "SDL_ResetHints")]
        static abstract void ResetHints();

        [NativeFunction("SDL3", EntryPoint = "SDL_ResetKeyboard")]
        static abstract void ResetKeyboard();

        [NativeFunction("SDL3", EntryPoint = "SDL_ResetLogPriorities")]
        static abstract void ResetLogPriorities();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RestoreWindow")]
        static abstract MaybeBool<byte> RestoreWindow(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RestoreWindow")]
        static abstract byte RestoreWindowRaw(WindowHandle window);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioDevice")]
        static abstract MaybeBool<byte> ResumeAudioDevice(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioDevice")]
        static abstract byte ResumeAudioDeviceRaw([NativeTypeName("SDL_AudioDeviceID")] uint devid);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioStreamDevice")]
        static abstract MaybeBool<byte> ResumeAudioStreamDevice(AudioStreamHandle stream);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioStreamDevice")]
        static abstract byte ResumeAudioStreamDeviceRaw(AudioStreamHandle stream);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResumeHaptic")]
        static abstract MaybeBool<byte> ResumeHaptic(HapticHandle haptic);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResumeHaptic")]
        static abstract byte ResumeHapticRaw(HapticHandle haptic);

        [NativeFunction("SDL3", EntryPoint = "SDL_round")]
        static abstract double Round(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_roundf")]
        static abstract float Roundf(float x);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepad")]
        static abstract MaybeBool<byte> RumbleGamepad(
            GamepadHandle gamepad,
            [NativeTypeName("Uint16")] ushort low_frequency_rumble,
            [NativeTypeName("Uint16")] ushort high_frequency_rumble,
            [NativeTypeName("Uint32")] uint duration_ms
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepad")]
        static abstract byte RumbleGamepadRaw(
            GamepadHandle gamepad,
            [NativeTypeName("Uint16")] ushort low_frequency_rumble,
            [NativeTypeName("Uint16")] ushort high_frequency_rumble,
            [NativeTypeName("Uint32")] uint duration_ms
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepadTriggers")]
        static abstract MaybeBool<byte> RumbleGamepadTriggers(
            GamepadHandle gamepad,
            [NativeTypeName("Uint16")] ushort left_rumble,
            [NativeTypeName("Uint16")] ushort right_rumble,
            [NativeTypeName("Uint32")] uint duration_ms
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepadTriggers")]
        static abstract byte RumbleGamepadTriggersRaw(
            GamepadHandle gamepad,
            [NativeTypeName("Uint16")] ushort left_rumble,
            [NativeTypeName("Uint16")] ushort right_rumble,
            [NativeTypeName("Uint32")] uint duration_ms
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystick")]
        static abstract MaybeBool<byte> RumbleJoystick(
            JoystickHandle joystick,
            [NativeTypeName("Uint16")] ushort low_frequency_rumble,
            [NativeTypeName("Uint16")] ushort high_frequency_rumble,
            [NativeTypeName("Uint32")] uint duration_ms
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystick")]
        static abstract byte RumbleJoystickRaw(
            JoystickHandle joystick,
            [NativeTypeName("Uint16")] ushort low_frequency_rumble,
            [NativeTypeName("Uint16")] ushort high_frequency_rumble,
            [NativeTypeName("Uint32")] uint duration_ms
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystickTriggers")]
        static abstract MaybeBool<byte> RumbleJoystickTriggers(
            JoystickHandle joystick,
            [NativeTypeName("Uint16")] ushort left_rumble,
            [NativeTypeName("Uint16")] ushort right_rumble,
            [NativeTypeName("Uint32")] uint duration_ms
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystickTriggers")]
        static abstract byte RumbleJoystickTriggersRaw(
            JoystickHandle joystick,
            [NativeTypeName("Uint16")] ushort left_rumble,
            [NativeTypeName("Uint16")] ushort right_rumble,
            [NativeTypeName("Uint32")] uint duration_ms
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_RunApp")]
        static abstract int RunApp(
            int argc,
            [NativeTypeName("char *[]")] sbyte** argv,
            [NativeTypeName("SDL_main_func")] MainFunc mainFunction,
            void* reserved
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RunApp")]
        static abstract int RunApp(
            int argc,
            [NativeTypeName("char *[]")] Ref2D<sbyte> argv,
            [NativeTypeName("SDL_main_func")] MainFunc mainFunction,
            Ref reserved
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RunHapticEffect")]
        static abstract MaybeBool<byte> RunHapticEffect(
            HapticHandle haptic,
            int effect,
            [NativeTypeName("Uint32")] uint iterations
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RunHapticEffect")]
        static abstract byte RunHapticEffectRaw(
            HapticHandle haptic,
            int effect,
            [NativeTypeName("Uint32")] uint iterations
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RunOnMainThread")]
        static abstract byte RunOnMainThread(
            [NativeTypeName("SDL_MainThreadCallback")] MainThreadCallback callback,
            void* userdata,
            [NativeTypeName("bool")] byte wait_complete
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_RunOnMainThread")]
        static abstract MaybeBool<byte> RunOnMainThread(
            [NativeTypeName("SDL_MainThreadCallback")] MainThreadCallback callback,
            Ref userdata,
            [NativeTypeName("bool")] MaybeBool<byte> wait_complete
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP")]
        static abstract byte SaveBMP(
            Surface* surface,
            [NativeTypeName("const char *")] sbyte* file
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP")]
        static abstract MaybeBool<byte> SaveBMP(
            Ref<Surface> surface,
            [NativeTypeName("const char *")] Ref<sbyte> file
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP_IO")]
        static abstract byte SaveBMPIO(
            Surface* surface,
            IOStreamHandle dst,
            [NativeTypeName("bool")] byte closeio
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP_IO")]
        static abstract MaybeBool<byte> SaveBMPIO(
            Ref<Surface> surface,
            IOStreamHandle dst,
            [NativeTypeName("bool")] MaybeBool<byte> closeio
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile")]
        static abstract byte SaveFile(
            [NativeTypeName("const char *")] sbyte* file,
            [NativeTypeName("const void *")] void* data,
            [NativeTypeName("size_t")] nuint datasize
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile")]
        static abstract MaybeBool<byte> SaveFile(
            [NativeTypeName("const char *")] Ref<sbyte> file,
            [NativeTypeName("const void *")] Ref data,
            [NativeTypeName("size_t")] nuint datasize
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile_IO")]
        static abstract byte SaveFileIO(
            IOStreamHandle src,
            [NativeTypeName("const void *")] void* data,
            [NativeTypeName("size_t")] nuint datasize,
            [NativeTypeName("bool")] byte closeio
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile_IO")]
        static abstract MaybeBool<byte> SaveFileIO(
            IOStreamHandle src,
            [NativeTypeName("const void *")] Ref data,
            [NativeTypeName("size_t")] nuint datasize,
            [NativeTypeName("bool")] MaybeBool<byte> closeio
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_scalbn")]
        static abstract double Scalbn(double x, int n);

        [NativeFunction("SDL3", EntryPoint = "SDL_scalbnf")]
        static abstract float Scalbnf(float x, int n);

        [NativeFunction("SDL3", EntryPoint = "SDL_ScaleSurface")]
        static abstract Surface* ScaleSurface(
            Surface* surface,
            int width,
            int height,
            ScaleMode scaleMode
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScaleSurface")]
        static abstract Ptr<Surface> ScaleSurface(
            Ref<Surface> surface,
            int width,
            int height,
            ScaleMode scaleMode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScreenKeyboardShown")]
        static abstract MaybeBool<byte> ScreenKeyboardShown(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScreenKeyboardShown")]
        static abstract byte ScreenKeyboardShownRaw(WindowHandle window);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScreenSaverEnabled")]
        static abstract MaybeBool<byte> ScreenSaverEnabled();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScreenSaverEnabled")]
        static abstract byte ScreenSaverEnabledRaw();

        [return: NativeTypeName("Sint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SeekIO")]
        static abstract nint SeekIO(
            IOStreamHandle context,
            [NativeTypeName("Sint64")] nint offset,
            IOWhence whence
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SendGamepadEffect")]
        static abstract byte SendGamepadEffect(
            GamepadHandle gamepad,
            [NativeTypeName("const void *")] void* data,
            int size
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SendGamepadEffect")]
        static abstract MaybeBool<byte> SendGamepadEffect(
            GamepadHandle gamepad,
            [NativeTypeName("const void *")] Ref data,
            int size
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickEffect")]
        static abstract byte SendJoystickEffect(
            JoystickHandle joystick,
            [NativeTypeName("const void *")] void* data,
            int size
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickEffect")]
        static abstract MaybeBool<byte> SendJoystickEffect(
            JoystickHandle joystick,
            [NativeTypeName("const void *")] Ref data,
            int size
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickVirtualSensorData")]
        static abstract byte SendJoystickVirtualSensorData(
            JoystickHandle joystick,
            SensorType type,
            [NativeTypeName("Uint64")] nuint sensor_timestamp,
            [NativeTypeName("const float *")] float* data,
            int num_values
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickVirtualSensorData")]
        static abstract MaybeBool<byte> SendJoystickVirtualSensorData(
            JoystickHandle joystick,
            SensorType type,
            [NativeTypeName("Uint64")] nuint sensor_timestamp,
            [NativeTypeName("const float *")] Ref<float> data,
            int num_values
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadata")]
        static abstract byte SetAppMetadata(
            [NativeTypeName("const char *")] sbyte* appname,
            [NativeTypeName("const char *")] sbyte* appversion,
            [NativeTypeName("const char *")] sbyte* appidentifier
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadata")]
        static abstract MaybeBool<byte> SetAppMetadata(
            [NativeTypeName("const char *")] Ref<sbyte> appname,
            [NativeTypeName("const char *")] Ref<sbyte> appversion,
            [NativeTypeName("const char *")] Ref<sbyte> appidentifier
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadataProperty")]
        static abstract byte SetAppMetadataProperty(
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("const char *")] sbyte* value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadataProperty")]
        static abstract MaybeBool<byte> SetAppMetadataProperty(
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("const char *")] Ref<sbyte> value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetAssertionHandler")]
        static abstract void SetAssertionHandler(
            [NativeTypeName("SDL_AssertionHandler")] AssertionHandler handler,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAssertionHandler")]
        static abstract void SetAssertionHandler(
            [NativeTypeName("SDL_AssertionHandler")] AssertionHandler handler,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicInt")]
        static abstract int SetAtomicInt(AtomicInt* a, int v);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicInt")]
        static abstract int SetAtomicInt(Ref<AtomicInt> a, int v);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicPointer")]
        static abstract void* SetAtomicPointer(void** a, void* v);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicPointer")]
        static abstract Ptr SetAtomicPointer(Ref2D a, Ref v);

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicU32")]
        static abstract uint SetAtomicU32(AtomicU32* a, [NativeTypeName("Uint32")] uint v);

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicU32")]
        static abstract uint SetAtomicU32(Ref<AtomicU32> a, [NativeTypeName("Uint32")] uint v);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioDeviceGain")]
        static abstract MaybeBool<byte> SetAudioDeviceGain(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            float gain
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioDeviceGain")]
        static abstract byte SetAudioDeviceGainRaw(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            float gain
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioPostmixCallback")]
        static abstract byte SetAudioPostmixCallback(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            [NativeTypeName("SDL_AudioPostmixCallback")] AudioPostmixCallback callback,
            void* userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioPostmixCallback")]
        static abstract MaybeBool<byte> SetAudioPostmixCallback(
            [NativeTypeName("SDL_AudioDeviceID")] uint devid,
            [NativeTypeName("SDL_AudioPostmixCallback")] AudioPostmixCallback callback,
            Ref userdata
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFormat")]
        static abstract byte SetAudioStreamFormat(
            AudioStreamHandle stream,
            [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* src_spec,
            [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* dst_spec
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFormat")]
        static abstract MaybeBool<byte> SetAudioStreamFormat(
            AudioStreamHandle stream,
            [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> src_spec,
            [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> dst_spec
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFrequencyRatio")]
        static abstract MaybeBool<byte> SetAudioStreamFrequencyRatio(
            AudioStreamHandle stream,
            float ratio
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFrequencyRatio")]
        static abstract byte SetAudioStreamFrequencyRatioRaw(AudioStreamHandle stream, float ratio);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGain")]
        static abstract MaybeBool<byte> SetAudioStreamGain(AudioStreamHandle stream, float gain);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGain")]
        static abstract byte SetAudioStreamGainRaw(AudioStreamHandle stream, float gain);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGetCallback")]
        static abstract byte SetAudioStreamGetCallback(
            AudioStreamHandle stream,
            [NativeTypeName("SDL_AudioStreamCallback")] AudioStreamCallback callback,
            void* userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGetCallback")]
        static abstract MaybeBool<byte> SetAudioStreamGetCallback(
            AudioStreamHandle stream,
            [NativeTypeName("SDL_AudioStreamCallback")] AudioStreamCallback callback,
            Ref userdata
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamInputChannelMap")]
        static abstract byte SetAudioStreamInputChannelMap(
            AudioStreamHandle stream,
            [NativeTypeName("const int *")] int* chmap,
            int count
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamInputChannelMap")]
        static abstract MaybeBool<byte> SetAudioStreamInputChannelMap(
            AudioStreamHandle stream,
            [NativeTypeName("const int *")] Ref<int> chmap,
            int count
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamOutputChannelMap")]
        static abstract byte SetAudioStreamOutputChannelMap(
            AudioStreamHandle stream,
            [NativeTypeName("const int *")] int* chmap,
            int count
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamOutputChannelMap")]
        static abstract MaybeBool<byte> SetAudioStreamOutputChannelMap(
            AudioStreamHandle stream,
            [NativeTypeName("const int *")] Ref<int> chmap,
            int count
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamPutCallback")]
        static abstract byte SetAudioStreamPutCallback(
            AudioStreamHandle stream,
            [NativeTypeName("SDL_AudioStreamCallback")] AudioStreamCallback callback,
            void* userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamPutCallback")]
        static abstract MaybeBool<byte> SetAudioStreamPutCallback(
            AudioStreamHandle stream,
            [NativeTypeName("SDL_AudioStreamCallback")] AudioStreamCallback callback,
            Ref userdata
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetBooleanProperty")]
        static abstract byte SetBooleanProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("bool")] byte value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetBooleanProperty")]
        static abstract MaybeBool<byte> SetBooleanProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("bool")] MaybeBool<byte> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardData")]
        static abstract byte SetClipboardData(
            [NativeTypeName("SDL_ClipboardDataCallback")] ClipboardDataCallback callback,
            [NativeTypeName("SDL_ClipboardCleanupCallback")] ClipboardCleanupCallback cleanup,
            void* userdata,
            [NativeTypeName("const char **")] sbyte** mime_types,
            [NativeTypeName("size_t")] nuint num_mime_types
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardData")]
        static abstract MaybeBool<byte> SetClipboardData(
            [NativeTypeName("SDL_ClipboardDataCallback")] ClipboardDataCallback callback,
            [NativeTypeName("SDL_ClipboardCleanupCallback")] ClipboardCleanupCallback cleanup,
            Ref userdata,
            [NativeTypeName("const char **")] Ref2D<sbyte> mime_types,
            [NativeTypeName("size_t")] nuint num_mime_types
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardText")]
        static abstract byte SetClipboardText([NativeTypeName("const char *")] sbyte* text);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardText")]
        static abstract MaybeBool<byte> SetClipboardText(
            [NativeTypeName("const char *")] Ref<sbyte> text
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetCurrentThreadPriority")]
        static abstract MaybeBool<byte> SetCurrentThreadPriority(ThreadPriority priority);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetCurrentThreadPriority")]
        static abstract byte SetCurrentThreadPriorityRaw(ThreadPriority priority);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetCursor")]
        static abstract MaybeBool<byte> SetCursor(CursorHandle cursor);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetCursor")]
        static abstract byte SetCursorRaw(CursorHandle cursor);

        [NativeFunction("SDL3", EntryPoint = "SDL_setenv_unsafe")]
        static abstract int SetenvUnsafe(
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("const char *")] sbyte* value,
            int overwrite
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_setenv_unsafe")]
        static abstract int SetenvUnsafe(
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("const char *")] Ref<sbyte> value,
            int overwrite
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetEnvironmentVariable")]
        static abstract byte SetEnvironmentVariable(
            EnvironmentHandle env,
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("const char *")] sbyte* value,
            [NativeTypeName("bool")] byte overwrite
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetEnvironmentVariable")]
        static abstract MaybeBool<byte> SetEnvironmentVariable(
            EnvironmentHandle env,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("const char *")] Ref<sbyte> value,
            [NativeTypeName("bool")] MaybeBool<byte> overwrite
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetErrorV")]
        static abstract byte SetErrorV(
            [NativeTypeName("const char *")] sbyte* fmt,
            [NativeTypeName("va_list")] VaListTagHandle ap
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetErrorV")]
        static abstract MaybeBool<byte> SetErrorV(
            [NativeTypeName("const char *")] Ref<sbyte> fmt,
            [NativeTypeName("va_list")] VaListTagHandle ap
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetEventEnabled")]
        static abstract void SetEventEnabled(
            [NativeTypeName("Uint32")] uint type,
            [NativeTypeName("bool")] byte enabled
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetEventEnabled")]
        static abstract void SetEventEnabled(
            [NativeTypeName("Uint32")] uint type,
            [NativeTypeName("bool")] MaybeBool<byte> enabled
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetEventFilter")]
        static abstract void SetEventFilter(
            [NativeTypeName("SDL_EventFilter")] EventFilter filter,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetEventFilter")]
        static abstract void SetEventFilter(
            [NativeTypeName("SDL_EventFilter")] EventFilter filter,
            Ref userdata
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetFloatProperty")]
        static abstract byte SetFloatProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            float value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetFloatProperty")]
        static abstract MaybeBool<byte> SetFloatProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            float value
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadEventsEnabled")]
        static abstract void SetGamepadEventsEnabled([NativeTypeName("bool")] byte enabled);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadEventsEnabled")]
        static abstract void SetGamepadEventsEnabled(
            [NativeTypeName("bool")] MaybeBool<byte> enabled
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadLED")]
        static abstract MaybeBool<byte> SetGamepadLED(
            GamepadHandle gamepad,
            [NativeTypeName("Uint8")] byte red,
            [NativeTypeName("Uint8")] byte green,
            [NativeTypeName("Uint8")] byte blue
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadLED")]
        static abstract byte SetGamepadLEDRaw(
            GamepadHandle gamepad,
            [NativeTypeName("Uint8")] byte red,
            [NativeTypeName("Uint8")] byte green,
            [NativeTypeName("Uint8")] byte blue
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadMapping")]
        static abstract byte SetGamepadMapping(
            [NativeTypeName("SDL_JoystickID")] uint instance_id,
            [NativeTypeName("const char *")] sbyte* mapping
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadMapping")]
        static abstract MaybeBool<byte> SetGamepadMapping(
            [NativeTypeName("SDL_JoystickID")] uint instance_id,
            [NativeTypeName("const char *")] Ref<sbyte> mapping
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadPlayerIndex")]
        static abstract MaybeBool<byte> SetGamepadPlayerIndex(
            GamepadHandle gamepad,
            int player_index
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadPlayerIndex")]
        static abstract byte SetGamepadPlayerIndexRaw(GamepadHandle gamepad, int player_index);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadSensorEnabled")]
        static abstract byte SetGamepadSensorEnabled(
            GamepadHandle gamepad,
            SensorType type,
            [NativeTypeName("bool")] byte enabled
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadSensorEnabled")]
        static abstract MaybeBool<byte> SetGamepadSensorEnabled(
            GamepadHandle gamepad,
            SensorType type,
            [NativeTypeName("bool")] MaybeBool<byte> enabled
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUAllowedFramesInFlight")]
        static abstract MaybeBool<byte> SetGPUAllowedFramesInFlight(
            GPUDeviceHandle device,
            [NativeTypeName("Uint32")] uint allowed_frames_in_flight
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUAllowedFramesInFlight")]
        static abstract byte SetGPUAllowedFramesInFlightRaw(
            GPUDeviceHandle device,
            [NativeTypeName("Uint32")] uint allowed_frames_in_flight
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUBlendConstants")]
        static abstract void SetGPUBlendConstants(
            GPURenderPassHandle render_pass,
            FColor blend_constants
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUBufferName")]
        static abstract void SetGPUBufferName(
            GPUDeviceHandle device,
            GPUBufferHandle buffer,
            [NativeTypeName("const char *")] sbyte* text
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUBufferName")]
        static abstract void SetGPUBufferName(
            GPUDeviceHandle device,
            GPUBufferHandle buffer,
            [NativeTypeName("const char *")] Ref<sbyte> text
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUScissor")]
        static abstract void SetGPUScissor(
            GPURenderPassHandle render_pass,
            [NativeTypeName("const SDL_Rect *")] Rect* scissor
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUScissor")]
        static abstract void SetGPUScissor(
            GPURenderPassHandle render_pass,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> scissor
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUStencilReference")]
        static abstract void SetGPUStencilReference(
            GPURenderPassHandle render_pass,
            [NativeTypeName("Uint8")] byte reference
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUSwapchainParameters")]
        static abstract MaybeBool<byte> SetGPUSwapchainParameters(
            GPUDeviceHandle device,
            WindowHandle window,
            GPUSwapchainComposition swapchain_composition,
            GPUPresentMode present_mode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUSwapchainParameters")]
        static abstract byte SetGPUSwapchainParametersRaw(
            GPUDeviceHandle device,
            WindowHandle window,
            GPUSwapchainComposition swapchain_composition,
            GPUPresentMode present_mode
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUTextureName")]
        static abstract void SetGPUTextureName(
            GPUDeviceHandle device,
            GPUTextureHandle texture,
            [NativeTypeName("const char *")] sbyte* text
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUTextureName")]
        static abstract void SetGPUTextureName(
            GPUDeviceHandle device,
            GPUTextureHandle texture,
            [NativeTypeName("const char *")] Ref<sbyte> text
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUViewport")]
        static abstract void SetGPUViewport(
            GPURenderPassHandle render_pass,
            [NativeTypeName("const SDL_GPUViewport *")] GPUViewport* viewport
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUViewport")]
        static abstract void SetGPUViewport(
            GPURenderPassHandle render_pass,
            [NativeTypeName("const SDL_GPUViewport *")] Ref<GPUViewport> viewport
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticAutocenter")]
        static abstract MaybeBool<byte> SetHapticAutocenter(HapticHandle haptic, int autocenter);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticAutocenter")]
        static abstract byte SetHapticAutocenterRaw(HapticHandle haptic, int autocenter);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticGain")]
        static abstract MaybeBool<byte> SetHapticGain(HapticHandle haptic, int gain);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticGain")]
        static abstract byte SetHapticGainRaw(HapticHandle haptic, int gain);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHint")]
        static abstract byte SetHint(
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("const char *")] sbyte* value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHint")]
        static abstract MaybeBool<byte> SetHint(
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("const char *")] Ref<sbyte> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHintWithPriority")]
        static abstract byte SetHintWithPriority(
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("const char *")] sbyte* value,
            HintPriority priority
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHintWithPriority")]
        static abstract MaybeBool<byte> SetHintWithPriority(
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("const char *")] Ref<sbyte> value,
            HintPriority priority
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetInitialized")]
        static abstract void SetInitialized(
            InitState* state,
            [NativeTypeName("bool")] byte initialized
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetInitialized")]
        static abstract void SetInitialized(
            Ref<InitState> state,
            [NativeTypeName("bool")] MaybeBool<byte> initialized
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickEventsEnabled")]
        static abstract void SetJoystickEventsEnabled([NativeTypeName("bool")] byte enabled);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickEventsEnabled")]
        static abstract void SetJoystickEventsEnabled(
            [NativeTypeName("bool")] MaybeBool<byte> enabled
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickLED")]
        static abstract MaybeBool<byte> SetJoystickLED(
            JoystickHandle joystick,
            [NativeTypeName("Uint8")] byte red,
            [NativeTypeName("Uint8")] byte green,
            [NativeTypeName("Uint8")] byte blue
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickLED")]
        static abstract byte SetJoystickLEDRaw(
            JoystickHandle joystick,
            [NativeTypeName("Uint8")] byte red,
            [NativeTypeName("Uint8")] byte green,
            [NativeTypeName("Uint8")] byte blue
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickPlayerIndex")]
        static abstract MaybeBool<byte> SetJoystickPlayerIndex(
            JoystickHandle joystick,
            int player_index
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickPlayerIndex")]
        static abstract byte SetJoystickPlayerIndexRaw(JoystickHandle joystick, int player_index);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualAxis")]
        static abstract MaybeBool<byte> SetJoystickVirtualAxis(
            JoystickHandle joystick,
            int axis,
            [NativeTypeName("Sint16")] short value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualAxis")]
        static abstract byte SetJoystickVirtualAxisRaw(
            JoystickHandle joystick,
            int axis,
            [NativeTypeName("Sint16")] short value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualBall")]
        static abstract MaybeBool<byte> SetJoystickVirtualBall(
            JoystickHandle joystick,
            int ball,
            [NativeTypeName("Sint16")] short xrel,
            [NativeTypeName("Sint16")] short yrel
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualBall")]
        static abstract byte SetJoystickVirtualBallRaw(
            JoystickHandle joystick,
            int ball,
            [NativeTypeName("Sint16")] short xrel,
            [NativeTypeName("Sint16")] short yrel
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualButton")]
        static abstract byte SetJoystickVirtualButton(
            JoystickHandle joystick,
            int button,
            [NativeTypeName("bool")] byte down
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualButton")]
        static abstract MaybeBool<byte> SetJoystickVirtualButton(
            JoystickHandle joystick,
            int button,
            [NativeTypeName("bool")] MaybeBool<byte> down
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualHat")]
        static abstract MaybeBool<byte> SetJoystickVirtualHat(
            JoystickHandle joystick,
            int hat,
            [NativeTypeName("Uint8")] byte value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualHat")]
        static abstract byte SetJoystickVirtualHatRaw(
            JoystickHandle joystick,
            int hat,
            [NativeTypeName("Uint8")] byte value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualTouchpad")]
        static abstract byte SetJoystickVirtualTouchpad(
            JoystickHandle joystick,
            int touchpad,
            int finger,
            [NativeTypeName("bool")] byte down,
            float x,
            float y,
            float pressure
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualTouchpad")]
        static abstract MaybeBool<byte> SetJoystickVirtualTouchpad(
            JoystickHandle joystick,
            int touchpad,
            int finger,
            [NativeTypeName("bool")] MaybeBool<byte> down,
            float x,
            float y,
            float pressure
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetLinuxThreadPriority")]
        static abstract MaybeBool<byte> SetLinuxThreadPriority(
            [NativeTypeName("Sint64")] nint threadID,
            int priority
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetLinuxThreadPriorityAndPolicy")]
        static abstract MaybeBool<byte> SetLinuxThreadPriorityAndPolicy(
            [NativeTypeName("Sint64")] nint threadID,
            int sdlPriority,
            int schedPolicy
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetLinuxThreadPriorityAndPolicy")]
        static abstract byte SetLinuxThreadPriorityAndPolicyRaw(
            [NativeTypeName("Sint64")] nint threadID,
            int sdlPriority,
            int schedPolicy
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetLinuxThreadPriority")]
        static abstract byte SetLinuxThreadPriorityRaw(
            [NativeTypeName("Sint64")] nint threadID,
            int priority
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetLogOutputFunction")]
        static abstract void SetLogOutputFunction(
            [NativeTypeName("SDL_LogOutputFunction")] LogOutputFunction callback,
            void* userdata
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetLogOutputFunction")]
        static abstract void SetLogOutputFunction(
            [NativeTypeName("SDL_LogOutputFunction")] LogOutputFunction callback,
            Ref userdata
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriorities")]
        static abstract void SetLogPriorities(LogPriority priority);

        [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriority")]
        static abstract void SetLogPriority(int category, LogPriority priority);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriorityPrefix")]
        static abstract byte SetLogPriorityPrefix(
            LogPriority priority,
            [NativeTypeName("const char *")] sbyte* prefix
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriorityPrefix")]
        static abstract MaybeBool<byte> SetLogPriorityPrefix(
            LogPriority priority,
            [NativeTypeName("const char *")] Ref<sbyte> prefix
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetMainReady")]
        static abstract void SetMainReady();

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetMemoryFunctions")]
        static abstract MaybeBool<byte> SetMemoryFunctions(
            [NativeTypeName("SDL_malloc_func")] MallocFunc malloc_func,
            [NativeTypeName("SDL_calloc_func")] CallocFunc calloc_func,
            [NativeTypeName("SDL_realloc_func")] ReallocFunc realloc_func,
            [NativeTypeName("SDL_free_func")] FreeFunc free_func
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetMemoryFunctions")]
        static abstract byte SetMemoryFunctionsRaw(
            [NativeTypeName("SDL_malloc_func")] MallocFunc malloc_func,
            [NativeTypeName("SDL_calloc_func")] CallocFunc calloc_func,
            [NativeTypeName("SDL_realloc_func")] ReallocFunc realloc_func,
            [NativeTypeName("SDL_free_func")] FreeFunc free_func
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SetModState")]
        static abstract void SetModState([NativeTypeName("SDL_Keymod")] ushort modstate);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetNumberProperty")]
        static abstract byte SetNumberProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("Sint64")] nint value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetNumberProperty")]
        static abstract MaybeBool<byte> SetNumberProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("Sint64")] nint value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPaletteColors")]
        static abstract byte SetPaletteColors(
            Palette* palette,
            [NativeTypeName("const SDL_Color *")] Color* colors,
            int firstcolor,
            int ncolors
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPaletteColors")]
        static abstract MaybeBool<byte> SetPaletteColors(
            Ref<Palette> palette,
            [NativeTypeName("const SDL_Color *")] Ref<Color> colors,
            int firstcolor,
            int ncolors
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerProperty")]
        static abstract byte SetPointerProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            void* value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerProperty")]
        static abstract MaybeBool<byte> SetPointerProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            Ref value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerPropertyWithCleanup")]
        static abstract byte SetPointerPropertyWithCleanup(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            void* value,
            [NativeTypeName("SDL_CleanupPropertyCallback")] CleanupPropertyCallback cleanup,
            void* userdata
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerPropertyWithCleanup")]
        static abstract MaybeBool<byte> SetPointerPropertyWithCleanup(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            Ref value,
            [NativeTypeName("SDL_CleanupPropertyCallback")] CleanupPropertyCallback cleanup,
            Ref userdata
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPrimarySelectionText")]
        static abstract byte SetPrimarySelectionText([NativeTypeName("const char *")] sbyte* text);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPrimarySelectionText")]
        static abstract MaybeBool<byte> SetPrimarySelectionText(
            [NativeTypeName("const char *")] Ref<sbyte> text
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderClipRect")]
        static abstract byte SetRenderClipRect(
            RendererHandle renderer,
            [NativeTypeName("const SDL_Rect *")] Rect* rect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderClipRect")]
        static abstract MaybeBool<byte> SetRenderClipRect(
            RendererHandle renderer,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderColorScale")]
        static abstract MaybeBool<byte> SetRenderColorScale(RendererHandle renderer, float scale);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderColorScale")]
        static abstract byte SetRenderColorScaleRaw(RendererHandle renderer, float scale);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawBlendMode")]
        static abstract MaybeBool<byte> SetRenderDrawBlendMode(
            RendererHandle renderer,
            [NativeTypeName("SDL_BlendMode")] BlendMode blendMode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawBlendMode")]
        static abstract byte SetRenderDrawBlendModeRaw(
            RendererHandle renderer,
            [NativeTypeName("SDL_BlendMode")] BlendMode blendMode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColor")]
        static abstract MaybeBool<byte> SetRenderDrawColor(
            RendererHandle renderer,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b,
            [NativeTypeName("Uint8")] byte a
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColorFloat")]
        static abstract MaybeBool<byte> SetRenderDrawColorFloat(
            RendererHandle renderer,
            float r,
            float g,
            float b,
            float a
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColorFloat")]
        static abstract byte SetRenderDrawColorFloatRaw(
            RendererHandle renderer,
            float r,
            float g,
            float b,
            float a
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColor")]
        static abstract byte SetRenderDrawColorRaw(
            RendererHandle renderer,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b,
            [NativeTypeName("Uint8")] byte a
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderLogicalPresentation")]
        static abstract MaybeBool<byte> SetRenderLogicalPresentation(
            RendererHandle renderer,
            int w,
            int h,
            RendererLogicalPresentation mode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderLogicalPresentation")]
        static abstract byte SetRenderLogicalPresentationRaw(
            RendererHandle renderer,
            int w,
            int h,
            RendererLogicalPresentation mode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderScale")]
        static abstract MaybeBool<byte> SetRenderScale(
            RendererHandle renderer,
            float scaleX,
            float scaleY
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderScale")]
        static abstract byte SetRenderScaleRaw(RendererHandle renderer, float scaleX, float scaleY);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderTarget")]
        static abstract byte SetRenderTarget(RendererHandle renderer, Texture* texture);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderTarget")]
        static abstract MaybeBool<byte> SetRenderTarget(
            RendererHandle renderer,
            Ref<Texture> texture
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderViewport")]
        static abstract byte SetRenderViewport(
            RendererHandle renderer,
            [NativeTypeName("const SDL_Rect *")] Rect* rect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderViewport")]
        static abstract MaybeBool<byte> SetRenderViewport(
            RendererHandle renderer,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderVSync")]
        static abstract MaybeBool<byte> SetRenderVSync(RendererHandle renderer, int vsync);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderVSync")]
        static abstract byte SetRenderVSyncRaw(RendererHandle renderer, int vsync);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetScancodeName")]
        static abstract byte SetScancodeName(
            Scancode scancode,
            [NativeTypeName("const char *")] sbyte* name
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetScancodeName")]
        static abstract MaybeBool<byte> SetScancodeName(
            Scancode scancode,
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetStringProperty")]
        static abstract byte SetStringProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] sbyte* name,
            [NativeTypeName("const char *")] sbyte* value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetStringProperty")]
        static abstract MaybeBool<byte> SetStringProperty(
            [NativeTypeName("SDL_PropertiesID")] uint props,
            [NativeTypeName("const char *")] Ref<sbyte> name,
            [NativeTypeName("const char *")] Ref<sbyte> value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceAlphaMod")]
        static abstract byte SetSurfaceAlphaMod(
            Surface* surface,
            [NativeTypeName("Uint8")] byte alpha
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceAlphaMod")]
        static abstract MaybeBool<byte> SetSurfaceAlphaMod(
            Ref<Surface> surface,
            [NativeTypeName("Uint8")] byte alpha
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceBlendMode")]
        static abstract byte SetSurfaceBlendMode(
            Surface* surface,
            [NativeTypeName("SDL_BlendMode")] BlendMode blendMode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceBlendMode")]
        static abstract MaybeBool<byte> SetSurfaceBlendMode(
            Ref<Surface> surface,
            [NativeTypeName("SDL_BlendMode")] BlendMode blendMode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceClipRect")]
        static abstract byte SetSurfaceClipRect(
            Surface* surface,
            [NativeTypeName("const SDL_Rect *")] Rect* rect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceClipRect")]
        static abstract MaybeBool<byte> SetSurfaceClipRect(
            Ref<Surface> surface,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorKey")]
        static abstract byte SetSurfaceColorKey(
            Surface* surface,
            [NativeTypeName("bool")] byte enabled,
            [NativeTypeName("Uint32")] uint key
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorKey")]
        static abstract MaybeBool<byte> SetSurfaceColorKey(
            Ref<Surface> surface,
            [NativeTypeName("bool")] MaybeBool<byte> enabled,
            [NativeTypeName("Uint32")] uint key
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorMod")]
        static abstract byte SetSurfaceColorMod(
            Surface* surface,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorMod")]
        static abstract MaybeBool<byte> SetSurfaceColorMod(
            Ref<Surface> surface,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorspace")]
        static abstract byte SetSurfaceColorspace(Surface* surface, Colorspace colorspace);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorspace")]
        static abstract MaybeBool<byte> SetSurfaceColorspace(
            Ref<Surface> surface,
            Colorspace colorspace
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfacePalette")]
        static abstract byte SetSurfacePalette(Surface* surface, Palette* palette);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfacePalette")]
        static abstract MaybeBool<byte> SetSurfacePalette(
            Ref<Surface> surface,
            Ref<Palette> palette
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceRLE")]
        static abstract byte SetSurfaceRLE(Surface* surface, [NativeTypeName("bool")] byte enabled);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceRLE")]
        static abstract MaybeBool<byte> SetSurfaceRLE(
            Ref<Surface> surface,
            [NativeTypeName("bool")] MaybeBool<byte> enabled
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextInputArea")]
        static abstract byte SetTextInputArea(
            WindowHandle window,
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            int cursor
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextInputArea")]
        static abstract MaybeBool<byte> SetTextInputArea(
            WindowHandle window,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            int cursor
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaMod")]
        static abstract byte SetTextureAlphaMod(
            Texture* texture,
            [NativeTypeName("Uint8")] byte alpha
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaMod")]
        static abstract MaybeBool<byte> SetTextureAlphaMod(
            Ref<Texture> texture,
            [NativeTypeName("Uint8")] byte alpha
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaModFloat")]
        static abstract byte SetTextureAlphaModFloat(Texture* texture, float alpha);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaModFloat")]
        static abstract MaybeBool<byte> SetTextureAlphaModFloat(Ref<Texture> texture, float alpha);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureBlendMode")]
        static abstract byte SetTextureBlendMode(
            Texture* texture,
            [NativeTypeName("SDL_BlendMode")] BlendMode blendMode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureBlendMode")]
        static abstract MaybeBool<byte> SetTextureBlendMode(
            Ref<Texture> texture,
            [NativeTypeName("SDL_BlendMode")] BlendMode blendMode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorMod")]
        static abstract byte SetTextureColorMod(
            Texture* texture,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorMod")]
        static abstract MaybeBool<byte> SetTextureColorMod(
            Ref<Texture> texture,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorModFloat")]
        static abstract byte SetTextureColorModFloat(Texture* texture, float r, float g, float b);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorModFloat")]
        static abstract MaybeBool<byte> SetTextureColorModFloat(
            Ref<Texture> texture,
            float r,
            float g,
            float b
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureScaleMode")]
        static abstract byte SetTextureScaleMode(Texture* texture, ScaleMode scaleMode);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureScaleMode")]
        static abstract MaybeBool<byte> SetTextureScaleMode(
            Ref<Texture> texture,
            ScaleMode scaleMode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTLS")]
        static abstract byte SetTLS(
            [NativeTypeName("SDL_TLSID *")] AtomicInt* id,
            [NativeTypeName("const void *")] void* value,
            [NativeTypeName("SDL_TLSDestructorCallback")] TLSDestructorCallback destructor
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTLS")]
        static abstract MaybeBool<byte> SetTLS(
            [NativeTypeName("SDL_TLSID *")] Ref<AtomicInt> id,
            [NativeTypeName("const void *")] Ref value,
            [NativeTypeName("SDL_TLSDestructorCallback")] TLSDestructorCallback destructor
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAlwaysOnTop")]
        static abstract byte SetWindowAlwaysOnTop(
            WindowHandle window,
            [NativeTypeName("bool")] byte on_top
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAlwaysOnTop")]
        static abstract MaybeBool<byte> SetWindowAlwaysOnTop(
            WindowHandle window,
            [NativeTypeName("bool")] MaybeBool<byte> on_top
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAspectRatio")]
        static abstract MaybeBool<byte> SetWindowAspectRatio(
            WindowHandle window,
            float min_aspect,
            float max_aspect
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAspectRatio")]
        static abstract byte SetWindowAspectRatioRaw(
            WindowHandle window,
            float min_aspect,
            float max_aspect
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowBordered")]
        static abstract byte SetWindowBordered(
            WindowHandle window,
            [NativeTypeName("bool")] byte bordered
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowBordered")]
        static abstract MaybeBool<byte> SetWindowBordered(
            WindowHandle window,
            [NativeTypeName("bool")] MaybeBool<byte> bordered
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFocusable")]
        static abstract byte SetWindowFocusable(
            WindowHandle window,
            [NativeTypeName("bool")] byte focusable
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFocusable")]
        static abstract MaybeBool<byte> SetWindowFocusable(
            WindowHandle window,
            [NativeTypeName("bool")] MaybeBool<byte> focusable
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreen")]
        static abstract byte SetWindowFullscreen(
            WindowHandle window,
            [NativeTypeName("bool")] byte fullscreen
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreen")]
        static abstract MaybeBool<byte> SetWindowFullscreen(
            WindowHandle window,
            [NativeTypeName("bool")] MaybeBool<byte> fullscreen
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreenMode")]
        static abstract byte SetWindowFullscreenMode(
            WindowHandle window,
            [NativeTypeName("const SDL_DisplayMode *")] DisplayMode* mode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreenMode")]
        static abstract MaybeBool<byte> SetWindowFullscreenMode(
            WindowHandle window,
            [NativeTypeName("const SDL_DisplayMode *")] Ref<DisplayMode> mode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowHitTest")]
        static abstract byte SetWindowHitTest(
            WindowHandle window,
            [NativeTypeName("SDL_HitTest")] HitTest callback,
            void* callback_data
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowHitTest")]
        static abstract MaybeBool<byte> SetWindowHitTest(
            WindowHandle window,
            [NativeTypeName("SDL_HitTest")] HitTest callback,
            Ref callback_data
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowIcon")]
        static abstract byte SetWindowIcon(WindowHandle window, Surface* icon);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowIcon")]
        static abstract MaybeBool<byte> SetWindowIcon(WindowHandle window, Ref<Surface> icon);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowKeyboardGrab")]
        static abstract byte SetWindowKeyboardGrab(
            WindowHandle window,
            [NativeTypeName("bool")] byte grabbed
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowKeyboardGrab")]
        static abstract MaybeBool<byte> SetWindowKeyboardGrab(
            WindowHandle window,
            [NativeTypeName("bool")] MaybeBool<byte> grabbed
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMaximumSize")]
        static abstract MaybeBool<byte> SetWindowMaximumSize(
            WindowHandle window,
            int max_w,
            int max_h
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMaximumSize")]
        static abstract byte SetWindowMaximumSizeRaw(WindowHandle window, int max_w, int max_h);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMinimumSize")]
        static abstract MaybeBool<byte> SetWindowMinimumSize(
            WindowHandle window,
            int min_w,
            int min_h
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMinimumSize")]
        static abstract byte SetWindowMinimumSizeRaw(WindowHandle window, int min_w, int min_h);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowModal")]
        static abstract byte SetWindowModal(
            WindowHandle window,
            [NativeTypeName("bool")] byte modal
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowModal")]
        static abstract MaybeBool<byte> SetWindowModal(
            WindowHandle window,
            [NativeTypeName("bool")] MaybeBool<byte> modal
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseGrab")]
        static abstract byte SetWindowMouseGrab(
            WindowHandle window,
            [NativeTypeName("bool")] byte grabbed
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseGrab")]
        static abstract MaybeBool<byte> SetWindowMouseGrab(
            WindowHandle window,
            [NativeTypeName("bool")] MaybeBool<byte> grabbed
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseRect")]
        static abstract byte SetWindowMouseRect(
            WindowHandle window,
            [NativeTypeName("const SDL_Rect *")] Rect* rect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseRect")]
        static abstract MaybeBool<byte> SetWindowMouseRect(
            WindowHandle window,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowOpacity")]
        static abstract MaybeBool<byte> SetWindowOpacity(WindowHandle window, float opacity);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowOpacity")]
        static abstract byte SetWindowOpacityRaw(WindowHandle window, float opacity);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowParent")]
        static abstract MaybeBool<byte> SetWindowParent(WindowHandle window, WindowHandle parent);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowParent")]
        static abstract byte SetWindowParentRaw(WindowHandle window, WindowHandle parent);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowPosition")]
        static abstract MaybeBool<byte> SetWindowPosition(WindowHandle window, int x, int y);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowPosition")]
        static abstract byte SetWindowPositionRaw(WindowHandle window, int x, int y);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowRelativeMouseMode")]
        static abstract byte SetWindowRelativeMouseMode(
            WindowHandle window,
            [NativeTypeName("bool")] byte enabled
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowRelativeMouseMode")]
        static abstract MaybeBool<byte> SetWindowRelativeMouseMode(
            WindowHandle window,
            [NativeTypeName("bool")] MaybeBool<byte> enabled
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowResizable")]
        static abstract byte SetWindowResizable(
            WindowHandle window,
            [NativeTypeName("bool")] byte resizable
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowResizable")]
        static abstract MaybeBool<byte> SetWindowResizable(
            WindowHandle window,
            [NativeTypeName("bool")] MaybeBool<byte> resizable
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowShape")]
        static abstract byte SetWindowShape(WindowHandle window, Surface* shape);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowShape")]
        static abstract MaybeBool<byte> SetWindowShape(WindowHandle window, Ref<Surface> shape);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSize")]
        static abstract MaybeBool<byte> SetWindowSize(WindowHandle window, int w, int h);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSize")]
        static abstract byte SetWindowSizeRaw(WindowHandle window, int w, int h);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSurfaceVSync")]
        static abstract MaybeBool<byte> SetWindowSurfaceVSync(WindowHandle window, int vsync);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSurfaceVSync")]
        static abstract byte SetWindowSurfaceVSyncRaw(WindowHandle window, int vsync);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowTitle")]
        static abstract byte SetWindowTitle(
            WindowHandle window,
            [NativeTypeName("const char *")] sbyte* title
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowTitle")]
        static abstract MaybeBool<byte> SetWindowTitle(
            WindowHandle window,
            [NativeTypeName("const char *")] Ref<sbyte> title
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShouldInit")]
        static abstract byte ShouldInit(InitState* state);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShouldInit")]
        static abstract MaybeBool<byte> ShouldInit(Ref<InitState> state);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShouldQuit")]
        static abstract byte ShouldQuit(InitState* state);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShouldQuit")]
        static abstract MaybeBool<byte> ShouldQuit(Ref<InitState> state);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowCursor")]
        static abstract MaybeBool<byte> ShowCursor();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowCursor")]
        static abstract byte ShowCursorRaw();

        [NativeFunction("SDL3", EntryPoint = "SDL_ShowFileDialogWithProperties")]
        static abstract void ShowFileDialogWithProperties(
            FileDialogType type,
            [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
            void* userdata,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowFileDialogWithProperties")]
        static abstract void ShowFileDialogWithProperties(
            FileDialogType type,
            [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
            Ref userdata,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowMessageBox")]
        static abstract byte ShowMessageBox(
            [NativeTypeName("const SDL_MessageBoxData *")] MessageBoxData* messageboxdata,
            int* buttonid
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowMessageBox")]
        static abstract MaybeBool<byte> ShowMessageBox(
            [NativeTypeName("const SDL_MessageBoxData *")] Ref<MessageBoxData> messageboxdata,
            Ref<int> buttonid
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFileDialog")]
        static abstract void ShowOpenFileDialog(
            [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
            void* userdata,
            WindowHandle window,
            [NativeTypeName("const SDL_DialogFileFilter *")] DialogFileFilter* filters,
            int nfilters,
            [NativeTypeName("const char *")] sbyte* default_location,
            [NativeTypeName("bool")] byte allow_many
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFileDialog")]
        static abstract void ShowOpenFileDialog(
            [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
            Ref userdata,
            WindowHandle window,
            [NativeTypeName("const SDL_DialogFileFilter *")] Ref<DialogFileFilter> filters,
            int nfilters,
            [NativeTypeName("const char *")] Ref<sbyte> default_location,
            [NativeTypeName("bool")] MaybeBool<byte> allow_many
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFolderDialog")]
        static abstract void ShowOpenFolderDialog(
            [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
            void* userdata,
            WindowHandle window,
            [NativeTypeName("const char *")] sbyte* default_location,
            [NativeTypeName("bool")] byte allow_many
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFolderDialog")]
        static abstract void ShowOpenFolderDialog(
            [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
            Ref userdata,
            WindowHandle window,
            [NativeTypeName("const char *")] Ref<sbyte> default_location,
            [NativeTypeName("bool")] MaybeBool<byte> allow_many
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_ShowSaveFileDialog")]
        static abstract void ShowSaveFileDialog(
            [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
            void* userdata,
            WindowHandle window,
            [NativeTypeName("const SDL_DialogFileFilter *")] DialogFileFilter* filters,
            int nfilters,
            [NativeTypeName("const char *")] sbyte* default_location
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowSaveFileDialog")]
        static abstract void ShowSaveFileDialog(
            [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
            Ref userdata,
            WindowHandle window,
            [NativeTypeName("const SDL_DialogFileFilter *")] Ref<DialogFileFilter> filters,
            int nfilters,
            [NativeTypeName("const char *")] Ref<sbyte> default_location
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowSimpleMessageBox")]
        static abstract byte ShowSimpleMessageBox(
            [NativeTypeName("SDL_MessageBoxFlags")] uint flags,
            [NativeTypeName("const char *")] sbyte* title,
            [NativeTypeName("const char *")] sbyte* message,
            WindowHandle window
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowSimpleMessageBox")]
        static abstract MaybeBool<byte> ShowSimpleMessageBox(
            [NativeTypeName("SDL_MessageBoxFlags")] uint flags,
            [NativeTypeName("const char *")] Ref<sbyte> title,
            [NativeTypeName("const char *")] Ref<sbyte> message,
            WindowHandle window
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindow")]
        static abstract MaybeBool<byte> ShowWindow(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindow")]
        static abstract byte ShowWindowRaw(WindowHandle window);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindowSystemMenu")]
        static abstract MaybeBool<byte> ShowWindowSystemMenu(WindowHandle window, int x, int y);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindowSystemMenu")]
        static abstract byte ShowWindowSystemMenuRaw(WindowHandle window, int x, int y);

        [NativeFunction("SDL3", EntryPoint = "SDL_SignalCondition")]
        static abstract void SignalCondition(ConditionHandle cond);

        [NativeFunction("SDL3", EntryPoint = "SDL_SignalSemaphore")]
        static abstract void SignalSemaphore(SemaphoreHandle sem);

        [NativeFunction("SDL3", EntryPoint = "SDL_sin")]
        static abstract double Sin(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_sinf")]
        static abstract float Sinf(float x);

        [NativeFunction("SDL3", EntryPoint = "SDL_sqrt")]
        static abstract double Sqrt(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_sqrtf")]
        static abstract float Sqrtf(float x);

        [NativeFunction("SDL3", EntryPoint = "SDL_srand")]
        static abstract void Srand([NativeTypeName("Uint64")] nuint seed);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInput")]
        static abstract MaybeBool<byte> StartTextInput(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInput")]
        static abstract byte StartTextInputRaw(WindowHandle window);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInputWithProperties")]
        static abstract MaybeBool<byte> StartTextInputWithProperties(
            WindowHandle window,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInputWithProperties")]
        static abstract byte StartTextInputWithPropertiesRaw(
            WindowHandle window,
            [NativeTypeName("SDL_PropertiesID")] uint props
        );

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StepBackUTF8")]
        static abstract uint StepBackUTF8(
            [NativeTypeName("const char *")] sbyte* start,
            [NativeTypeName("const char **")] sbyte** pstr
        );

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_StepBackUTF8")]
        static abstract uint StepBackUTF8(
            [NativeTypeName("const char *")] Ref<sbyte> start,
            [NativeTypeName("const char **")] Ref2D<sbyte> pstr
        );

        [return: NativeTypeName("Uint32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StepUTF8")]
        static abstract uint StepUTF8(
            [NativeTypeName("const char **")] sbyte** pstr,
            [NativeTypeName("size_t *")] nuint* pslen
        );

        [return: NativeTypeName("Uint32")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_StepUTF8")]
        static abstract uint StepUTF8(
            [NativeTypeName("const char **")] Ref2D<sbyte> pstr,
            [NativeTypeName("size_t *")] Ref<nuint> pslen
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffect")]
        static abstract MaybeBool<byte> StopHapticEffect(HapticHandle haptic, int effect);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffect")]
        static abstract byte StopHapticEffectRaw(HapticHandle haptic, int effect);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffects")]
        static abstract MaybeBool<byte> StopHapticEffects(HapticHandle haptic);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffects")]
        static abstract byte StopHapticEffectsRaw(HapticHandle haptic);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticRumble")]
        static abstract MaybeBool<byte> StopHapticRumble(HapticHandle haptic);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticRumble")]
        static abstract byte StopHapticRumbleRaw(HapticHandle haptic);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopTextInput")]
        static abstract MaybeBool<byte> StopTextInput(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopTextInput")]
        static abstract byte StopTextInputRaw(WindowHandle window);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_StorageReady")]
        static abstract MaybeBool<byte> StorageReady(StorageHandle storage);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StorageReady")]
        static abstract byte StorageReadyRaw(StorageHandle storage);

        [NativeFunction("SDL3", EntryPoint = "SDL_strcasecmp")]
        static abstract int Strcasecmp(
            [NativeTypeName("const char *")] sbyte* str1,
            [NativeTypeName("const char *")] sbyte* str2
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strcasecmp")]
        static abstract int Strcasecmp(
            [NativeTypeName("const char *")] Ref<sbyte> str1,
            [NativeTypeName("const char *")] Ref<sbyte> str2
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strcasestr")]
        static abstract sbyte* Strcasestr(
            [NativeTypeName("const char *")] sbyte* haystack,
            [NativeTypeName("const char *")] sbyte* needle
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strcasestr")]
        static abstract Ptr<sbyte> Strcasestr(
            [NativeTypeName("const char *")] Ref<sbyte> haystack,
            [NativeTypeName("const char *")] Ref<sbyte> needle
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strchr")]
        static abstract sbyte* Strchr([NativeTypeName("const char *")] sbyte* str, int c);

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strchr")]
        static abstract Ptr<sbyte> Strchr([NativeTypeName("const char *")] Ref<sbyte> str, int c);

        [NativeFunction("SDL3", EntryPoint = "SDL_strcmp")]
        static abstract int Strcmp(
            [NativeTypeName("const char *")] sbyte* str1,
            [NativeTypeName("const char *")] sbyte* str2
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strcmp")]
        static abstract int Strcmp(
            [NativeTypeName("const char *")] Ref<sbyte> str1,
            [NativeTypeName("const char *")] Ref<sbyte> str2
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strdup")]
        static abstract sbyte* Strdup([NativeTypeName("const char *")] sbyte* str);

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strdup")]
        static abstract Ptr<sbyte> Strdup([NativeTypeName("const char *")] Ref<sbyte> str);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StretchSurface")]
        static abstract byte StretchSurface(
            Surface* src,
            [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
            Surface* dst,
            [NativeTypeName("const SDL_Rect *")] Rect* dstrect,
            ScaleMode scaleMode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_StretchSurface")]
        static abstract MaybeBool<byte> StretchSurface(
            Ref<Surface> src,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
            Ref<Surface> dst,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect,
            ScaleMode scaleMode
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_StringToGUID")]
        static abstract Guid StringToGuid([NativeTypeName("const char *")] sbyte* pchGUID);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_StringToGUID")]
        static abstract Guid StringToGuid([NativeTypeName("const char *")] Ref<sbyte> pchGUID);

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlcat")]
        static abstract nuint Strlcat(
            [NativeTypeName("char *")] sbyte* dst,
            [NativeTypeName("const char *")] sbyte* src,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlcat")]
        static abstract nuint Strlcat(
            [NativeTypeName("char *")] Ref<sbyte> dst,
            [NativeTypeName("const char *")] Ref<sbyte> src,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlcpy")]
        static abstract nuint Strlcpy(
            [NativeTypeName("char *")] sbyte* dst,
            [NativeTypeName("const char *")] sbyte* src,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlcpy")]
        static abstract nuint Strlcpy(
            [NativeTypeName("char *")] Ref<sbyte> dst,
            [NativeTypeName("const char *")] Ref<sbyte> src,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlen")]
        static abstract nuint Strlen([NativeTypeName("const char *")] sbyte* str);

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlen")]
        static abstract nuint Strlen([NativeTypeName("const char *")] Ref<sbyte> str);

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlwr")]
        static abstract sbyte* Strlwr([NativeTypeName("char *")] sbyte* str);

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlwr")]
        static abstract Ptr<sbyte> Strlwr([NativeTypeName("char *")] Ref<sbyte> str);

        [NativeFunction("SDL3", EntryPoint = "SDL_strncasecmp")]
        static abstract int Strncasecmp(
            [NativeTypeName("const char *")] sbyte* str1,
            [NativeTypeName("const char *")] sbyte* str2,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strncasecmp")]
        static abstract int Strncasecmp(
            [NativeTypeName("const char *")] Ref<sbyte> str1,
            [NativeTypeName("const char *")] Ref<sbyte> str2,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_strncmp")]
        static abstract int Strncmp(
            [NativeTypeName("const char *")] sbyte* str1,
            [NativeTypeName("const char *")] sbyte* str2,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strncmp")]
        static abstract int Strncmp(
            [NativeTypeName("const char *")] Ref<sbyte> str1,
            [NativeTypeName("const char *")] Ref<sbyte> str2,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strndup")]
        static abstract sbyte* Strndup(
            [NativeTypeName("const char *")] sbyte* str,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strndup")]
        static abstract Ptr<sbyte> Strndup(
            [NativeTypeName("const char *")] Ref<sbyte> str,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strnlen")]
        static abstract nuint Strnlen(
            [NativeTypeName("const char *")] sbyte* str,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strnlen")]
        static abstract nuint Strnlen(
            [NativeTypeName("const char *")] Ref<sbyte> str,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strnstr")]
        static abstract sbyte* Strnstr(
            [NativeTypeName("const char *")] sbyte* haystack,
            [NativeTypeName("const char *")] sbyte* needle,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strnstr")]
        static abstract Ptr<sbyte> Strnstr(
            [NativeTypeName("const char *")] Ref<sbyte> haystack,
            [NativeTypeName("const char *")] Ref<sbyte> needle,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strpbrk")]
        static abstract sbyte* Strpbrk(
            [NativeTypeName("const char *")] sbyte* str,
            [NativeTypeName("const char *")] sbyte* breakset
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strpbrk")]
        static abstract Ptr<sbyte> Strpbrk(
            [NativeTypeName("const char *")] Ref<sbyte> str,
            [NativeTypeName("const char *")] Ref<sbyte> breakset
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strrchr")]
        static abstract sbyte* Strrchr([NativeTypeName("const char *")] sbyte* str, int c);

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strrchr")]
        static abstract Ptr<sbyte> Strrchr([NativeTypeName("const char *")] Ref<sbyte> str, int c);

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strrev")]
        static abstract sbyte* Strrev([NativeTypeName("char *")] sbyte* str);

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strrev")]
        static abstract Ptr<sbyte> Strrev([NativeTypeName("char *")] Ref<sbyte> str);

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strstr")]
        static abstract sbyte* Strstr(
            [NativeTypeName("const char *")] sbyte* haystack,
            [NativeTypeName("const char *")] sbyte* needle
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strstr")]
        static abstract Ptr<sbyte> Strstr(
            [NativeTypeName("const char *")] Ref<sbyte> haystack,
            [NativeTypeName("const char *")] Ref<sbyte> needle
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_strtod")]
        static abstract double Strtod(
            [NativeTypeName("const char *")] sbyte* str,
            [NativeTypeName("char **")] sbyte** endp
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtod")]
        static abstract double Strtod(
            [NativeTypeName("const char *")] Ref<sbyte> str,
            [NativeTypeName("char **")] Ref2D<sbyte> endp
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtok_r")]
        static abstract sbyte* StrtokR(
            [NativeTypeName("char *")] sbyte* str,
            [NativeTypeName("const char *")] sbyte* delim,
            [NativeTypeName("char **")] sbyte** saveptr
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtok_r")]
        static abstract Ptr<sbyte> StrtokR(
            [NativeTypeName("char *")] Ref<sbyte> str,
            [NativeTypeName("const char *")] Ref<sbyte> delim,
            [NativeTypeName("char **")] Ref2D<sbyte> saveptr
        );

        [return: NativeTypeName("long")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtol")]
        static abstract nint Strtol(
            [NativeTypeName("const char *")] sbyte* str,
            [NativeTypeName("char **")] sbyte** endp,
            int @base
        );

        [return: NativeTypeName("long")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtol")]
        static abstract nint Strtol(
            [NativeTypeName("const char *")] Ref<sbyte> str,
            [NativeTypeName("char **")] Ref2D<sbyte> endp,
            int @base
        );

        [return: NativeTypeName("long long")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtoll")]
        static abstract long Strtoll(
            [NativeTypeName("const char *")] sbyte* str,
            [NativeTypeName("char **")] sbyte** endp,
            int @base
        );

        [return: NativeTypeName("long long")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtoll")]
        static abstract long Strtoll(
            [NativeTypeName("const char *")] Ref<sbyte> str,
            [NativeTypeName("char **")] Ref2D<sbyte> endp,
            int @base
        );

        [return: NativeTypeName("unsigned long")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtoul")]
        static abstract nuint Strtoul(
            [NativeTypeName("const char *")] sbyte* str,
            [NativeTypeName("char **")] sbyte** endp,
            int @base
        );

        [return: NativeTypeName("unsigned long")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtoul")]
        static abstract nuint Strtoul(
            [NativeTypeName("const char *")] Ref<sbyte> str,
            [NativeTypeName("char **")] Ref2D<sbyte> endp,
            int @base
        );

        [return: NativeTypeName("unsigned long long")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtoull")]
        static abstract ulong Strtoull(
            [NativeTypeName("const char *")] sbyte* str,
            [NativeTypeName("char **")] sbyte** endp,
            int @base
        );

        [return: NativeTypeName("unsigned long long")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtoull")]
        static abstract ulong Strtoull(
            [NativeTypeName("const char *")] Ref<sbyte> str,
            [NativeTypeName("char **")] Ref2D<sbyte> endp,
            int @base
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strupr")]
        static abstract sbyte* Strupr([NativeTypeName("char *")] sbyte* str);

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_strupr")]
        static abstract Ptr<sbyte> Strupr([NativeTypeName("char *")] Ref<sbyte> str);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SubmitGPUCommandBuffer")]
        static abstract MaybeBool<byte> SubmitGPUCommandBuffer(
            GPUCommandBufferHandle command_buffer
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_SubmitGPUCommandBufferAndAcquireFence")]
        static abstract GPUFenceHandle SubmitGPUCommandBufferAndAcquireFence(
            GPUCommandBufferHandle command_buffer
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SubmitGPUCommandBuffer")]
        static abstract byte SubmitGPUCommandBufferRaw(GPUCommandBufferHandle command_buffer);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasAlternateImages")]
        static abstract byte SurfaceHasAlternateImages(Surface* surface);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasAlternateImages")]
        static abstract MaybeBool<byte> SurfaceHasAlternateImages(Ref<Surface> surface);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasColorKey")]
        static abstract byte SurfaceHasColorKey(Surface* surface);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasColorKey")]
        static abstract MaybeBool<byte> SurfaceHasColorKey(Ref<Surface> surface);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasRLE")]
        static abstract byte SurfaceHasRLE(Surface* surface);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasRLE")]
        static abstract MaybeBool<byte> SurfaceHasRLE(Ref<Surface> surface);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_SyncWindow")]
        static abstract MaybeBool<byte> SyncWindow(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SyncWindow")]
        static abstract byte SyncWindowRaw(WindowHandle window);

        [NativeFunction("SDL3", EntryPoint = "SDL_tan")]
        static abstract double Tan(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_tanf")]
        static abstract float Tanf(float x);

        [return: NativeTypeName("Sint64")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TellIO")]
        static abstract nint TellIO(IOStreamHandle context);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_TextInputActive")]
        static abstract MaybeBool<byte> TextInputActive(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TextInputActive")]
        static abstract byte TextInputActiveRaw(WindowHandle window);

        [return: NativeTypeName("SDL_Time")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TimeFromWindows")]
        static abstract nint TimeFromWindows(
            [NativeTypeName("Uint32")] uint dwLowDateTime,
            [NativeTypeName("Uint32")] uint dwHighDateTime
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TimeToDateTime")]
        static abstract byte TimeToDateTime(
            [NativeTypeName("SDL_Time")] nint ticks,
            DateTime* dt,
            [NativeTypeName("bool")] byte localTime
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_TimeToDateTime")]
        static abstract MaybeBool<byte> TimeToDateTime(
            [NativeTypeName("SDL_Time")] nint ticks,
            Ref<DateTime> dt,
            [NativeTypeName("bool")] MaybeBool<byte> localTime
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_TimeToWindows")]
        static abstract void TimeToWindows(
            [NativeTypeName("SDL_Time")] nint ticks,
            [NativeTypeName("Uint32 *")] uint* dwLowDateTime,
            [NativeTypeName("Uint32 *")] uint* dwHighDateTime
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_TimeToWindows")]
        static abstract void TimeToWindows(
            [NativeTypeName("SDL_Time")] nint ticks,
            [NativeTypeName("Uint32 *")] Ref<uint> dwLowDateTime,
            [NativeTypeName("Uint32 *")] Ref<uint> dwHighDateTime
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_tolower")]
        static abstract int Tolower(int x);

        [NativeFunction("SDL3", EntryPoint = "SDL_toupper")]
        static abstract int Toupper(int x);

        [NativeFunction("SDL3", EntryPoint = "SDL_trunc")]
        static abstract double Trunc(double x);

        [NativeFunction("SDL3", EntryPoint = "SDL_truncf")]
        static abstract float Truncf(float x);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockMutex")]
        static abstract MaybeBool<byte> TryLockMutex(MutexHandle mutex);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockMutex")]
        static abstract byte TryLockMutexRaw(MutexHandle mutex);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForReading")]
        static abstract MaybeBool<byte> TryLockRWLockForReading(RWLockHandle rwlock);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForReading")]
        static abstract byte TryLockRWLockForReadingRaw(RWLockHandle rwlock);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForWriting")]
        static abstract MaybeBool<byte> TryLockRWLockForWriting(RWLockHandle rwlock);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForWriting")]
        static abstract byte TryLockRWLockForWritingRaw(RWLockHandle rwlock);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockSpinlock")]
        static abstract byte TryLockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockSpinlock")]
        static abstract MaybeBool<byte> TryLockSpinlock(
            [NativeTypeName("SDL_SpinLock *")] Ref<int> @lock
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryWaitSemaphore")]
        static abstract MaybeBool<byte> TryWaitSemaphore(SemaphoreHandle sem);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryWaitSemaphore")]
        static abstract byte TryWaitSemaphoreRaw(SemaphoreHandle sem);

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UCS4ToUTF8")]
        static abstract sbyte* UCS4ToUTF8(
            [NativeTypeName("Uint32")] uint codepoint,
            [NativeTypeName("char *")] sbyte* dst
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UCS4ToUTF8")]
        static abstract Ptr<sbyte> UCS4ToUTF8(
            [NativeTypeName("Uint32")] uint codepoint,
            [NativeTypeName("char *")] Ref<sbyte> dst
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_uitoa")]
        static abstract sbyte* Uitoa(
            [NativeTypeName("unsigned int")] uint value,
            [NativeTypeName("char *")] sbyte* str,
            int radix
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_uitoa")]
        static abstract Ptr<sbyte> Uitoa(
            [NativeTypeName("unsigned int")] uint value,
            [NativeTypeName("char *")] Ref<sbyte> str,
            int radix
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ulltoa")]
        static abstract sbyte* Ulltoa(
            [NativeTypeName("unsigned long long")] ulong value,
            [NativeTypeName("char *")] sbyte* str,
            int radix
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ulltoa")]
        static abstract Ptr<sbyte> Ulltoa(
            [NativeTypeName("unsigned long long")] ulong value,
            [NativeTypeName("char *")] Ref<sbyte> str,
            int radix
        );

        [return: NativeTypeName("char *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ultoa")]
        static abstract sbyte* Ultoa(
            [NativeTypeName("unsigned long")] nuint value,
            [NativeTypeName("char *")] sbyte* str,
            int radix
        );

        [return: NativeTypeName("char *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_ultoa")]
        static abstract Ptr<sbyte> Ultoa(
            [NativeTypeName("unsigned long")] nuint value,
            [NativeTypeName("char *")] Ref<sbyte> str,
            int radix
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStream")]
        static abstract void UnbindAudioStream(AudioStreamHandle stream);

        [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStreams")]
        static abstract void UnbindAudioStreams(
            [NativeTypeName("SDL_AudioStream *const *")] AudioStreamHandle* streams,
            int num_streams
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStreams")]
        static abstract void UnbindAudioStreams(
            [NativeTypeName("SDL_AudioStream *const *")] Ref<AudioStreamHandle> streams,
            int num_streams
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_UnloadObject")]
        static abstract void UnloadObject(SharedObjectHandle handle);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockAudioStream")]
        static abstract MaybeBool<byte> UnlockAudioStream(AudioStreamHandle stream);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockAudioStream")]
        static abstract byte UnlockAudioStreamRaw(AudioStreamHandle stream);

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
        static abstract void UnlockTexture(Texture* texture);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockTexture")]
        static abstract void UnlockTexture(Ref<Texture> texture);

        [NativeFunction("SDL3", EntryPoint = "SDL_UnmapGPUTransferBuffer")]
        static abstract void UnmapGPUTransferBuffer(
            GPUDeviceHandle device,
            GPUTransferBufferHandle transfer_buffer
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_unsetenv_unsafe")]
        static abstract int UnsetenvUnsafe([NativeTypeName("const char *")] sbyte* name);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_unsetenv_unsafe")]
        static abstract int UnsetenvUnsafe([NativeTypeName("const char *")] Ref<sbyte> name);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnsetEnvironmentVariable")]
        static abstract byte UnsetEnvironmentVariable(
            EnvironmentHandle env,
            [NativeTypeName("const char *")] sbyte* name
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnsetEnvironmentVariable")]
        static abstract MaybeBool<byte> UnsetEnvironmentVariable(
            EnvironmentHandle env,
            [NativeTypeName("const char *")] Ref<sbyte> name
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateGamepads")]
        static abstract void UpdateGamepads();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateHapticEffect")]
        static abstract byte UpdateHapticEffect(
            HapticHandle haptic,
            int effect,
            [NativeTypeName("const SDL_HapticEffect *")] HapticEffect* data
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateHapticEffect")]
        static abstract MaybeBool<byte> UpdateHapticEffect(
            HapticHandle haptic,
            int effect,
            [NativeTypeName("const SDL_HapticEffect *")] Ref<HapticEffect> data
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateJoysticks")]
        static abstract void UpdateJoysticks();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateNVTexture")]
        static abstract byte UpdateNVTexture(
            Texture* texture,
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            [NativeTypeName("const Uint8 *")] byte* Yplane,
            int Ypitch,
            [NativeTypeName("const Uint8 *")] byte* UVplane,
            int UVpitch
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateNVTexture")]
        static abstract MaybeBool<byte> UpdateNVTexture(
            Ref<Texture> texture,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            [NativeTypeName("const Uint8 *")] Ref<byte> Yplane,
            int Ypitch,
            [NativeTypeName("const Uint8 *")] Ref<byte> UVplane,
            int UVpitch
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateSensors")]
        static abstract void UpdateSensors();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateTexture")]
        static abstract byte UpdateTexture(
            Texture* texture,
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            [NativeTypeName("const void *")] void* pixels,
            int pitch
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateTexture")]
        static abstract MaybeBool<byte> UpdateTexture(
            Ref<Texture> texture,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            [NativeTypeName("const void *")] Ref pixels,
            int pitch
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurface")]
        static abstract MaybeBool<byte> UpdateWindowSurface(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurface")]
        static abstract byte UpdateWindowSurfaceRaw(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurfaceRects")]
        static abstract byte UpdateWindowSurfaceRects(
            WindowHandle window,
            [NativeTypeName("const SDL_Rect *")] Rect* rects,
            int numrects
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurfaceRects")]
        static abstract MaybeBool<byte> UpdateWindowSurfaceRects(
            WindowHandle window,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rects,
            int numrects
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateYUVTexture")]
        static abstract byte UpdateYUVTexture(
            Texture* texture,
            [NativeTypeName("const SDL_Rect *")] Rect* rect,
            [NativeTypeName("const Uint8 *")] byte* Yplane,
            int Ypitch,
            [NativeTypeName("const Uint8 *")] byte* Uplane,
            int Upitch,
            [NativeTypeName("const Uint8 *")] byte* Vplane,
            int Vpitch
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateYUVTexture")]
        static abstract MaybeBool<byte> UpdateYUVTexture(
            Ref<Texture> texture,
            [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
            [NativeTypeName("const Uint8 *")] Ref<byte> Yplane,
            int Ypitch,
            [NativeTypeName("const Uint8 *")] Ref<byte> Uplane,
            int Upitch,
            [NativeTypeName("const Uint8 *")] Ref<byte> Vplane,
            int Vpitch
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUBuffer")]
        static abstract void UploadToGPUBuffer(
            GPUCopyPassHandle copy_pass,
            [NativeTypeName("const SDL_GPUTransferBufferLocation *")]
                GPUTransferBufferLocation* source,
            [NativeTypeName("const SDL_GPUBufferRegion *")] GPUBufferRegion* destination,
            [NativeTypeName("bool")] byte cycle
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUBuffer")]
        static abstract void UploadToGPUBuffer(
            GPUCopyPassHandle copy_pass,
            [NativeTypeName("const SDL_GPUTransferBufferLocation *")]
                Ref<GPUTransferBufferLocation> source,
            [NativeTypeName("const SDL_GPUBufferRegion *")] Ref<GPUBufferRegion> destination,
            [NativeTypeName("bool")] MaybeBool<byte> cycle
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUTexture")]
        static abstract void UploadToGPUTexture(
            GPUCopyPassHandle copy_pass,
            [NativeTypeName("const SDL_GPUTextureTransferInfo *")] GPUTextureTransferInfo* source,
            [NativeTypeName("const SDL_GPUTextureRegion *")] GPUTextureRegion* destination,
            [NativeTypeName("bool")] byte cycle
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUTexture")]
        static abstract void UploadToGPUTexture(
            GPUCopyPassHandle copy_pass,
            [NativeTypeName("const SDL_GPUTextureTransferInfo *")]
                Ref<GPUTextureTransferInfo> source,
            [NativeTypeName("const SDL_GPUTextureRegion *")] Ref<GPUTextureRegion> destination,
            [NativeTypeName("bool")] MaybeBool<byte> cycle
        );

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlcpy")]
        static abstract nuint Utf8Strlcpy(
            [NativeTypeName("char *")] sbyte* dst,
            [NativeTypeName("const char *")] sbyte* src,
            [NativeTypeName("size_t")] nuint dst_bytes
        );

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlcpy")]
        static abstract nuint Utf8Strlcpy(
            [NativeTypeName("char *")] Ref<sbyte> dst,
            [NativeTypeName("const char *")] Ref<sbyte> src,
            [NativeTypeName("size_t")] nuint dst_bytes
        );

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlen")]
        static abstract nuint Utf8Strlen([NativeTypeName("const char *")] sbyte* str);

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlen")]
        static abstract nuint Utf8Strlen([NativeTypeName("const char *")] Ref<sbyte> str);

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_utf8strnlen")]
        static abstract nuint Utf8Strnlen(
            [NativeTypeName("const char *")] sbyte* str,
            [NativeTypeName("size_t")] nuint bytes
        );

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_utf8strnlen")]
        static abstract nuint Utf8Strnlen(
            [NativeTypeName("const char *")] Ref<sbyte> str,
            [NativeTypeName("size_t")] nuint bytes
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_vasprintf")]
        static abstract int Vasprintf(
            [NativeTypeName("char **")] sbyte** strp,
            [NativeTypeName("const char *")] sbyte* fmt,
            [NativeTypeName("va_list")] VaListTagHandle ap
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_vasprintf")]
        static abstract int Vasprintf(
            [NativeTypeName("char **")] Ref2D<sbyte> strp,
            [NativeTypeName("const char *")] Ref<sbyte> fmt,
            [NativeTypeName("va_list")] VaListTagHandle ap
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_vsnprintf")]
        static abstract int Vsnprintf(
            [NativeTypeName("char *")] sbyte* text,
            [NativeTypeName("size_t")] nuint maxlen,
            [NativeTypeName("const char *")] sbyte* fmt,
            [NativeTypeName("va_list")] VaListTagHandle ap
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_vsnprintf")]
        static abstract int Vsnprintf(
            [NativeTypeName("char *")] Ref<sbyte> text,
            [NativeTypeName("size_t")] nuint maxlen,
            [NativeTypeName("const char *")] Ref<sbyte> fmt,
            [NativeTypeName("va_list")] VaListTagHandle ap
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_vsscanf")]
        static abstract int Vsscanf(
            [NativeTypeName("const char *")] sbyte* text,
            [NativeTypeName("const char *")] sbyte* fmt,
            [NativeTypeName("va_list")] VaListTagHandle ap
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_vsscanf")]
        static abstract int Vsscanf(
            [NativeTypeName("const char *")] Ref<sbyte> text,
            [NativeTypeName("const char *")] Ref<sbyte> fmt,
            [NativeTypeName("va_list")] VaListTagHandle ap
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_vswprintf")]
        static abstract int Vswprintf(
            [NativeTypeName("wchar_t *")] uint* text,
            [NativeTypeName("size_t")] nuint maxlen,
            [NativeTypeName("const wchar_t *")] uint* fmt,
            [NativeTypeName("va_list")] VaListTagHandle ap
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_vswprintf")]
        static abstract int Vswprintf(
            [NativeTypeName("wchar_t *")] Ref<uint> text,
            [NativeTypeName("size_t")] nuint maxlen,
            [NativeTypeName("const wchar_t *")] Ref<uint> fmt,
            [NativeTypeName("va_list")] VaListTagHandle ap
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_CreateSurface")]
        static abstract byte VulkanCreateSurface(
            WindowHandle window,
            [NativeTypeName("VkInstance")] void* instance,
            [NativeTypeName("const struct VkAllocationCallbacks *")] void* allocator,
            [NativeTypeName("VkSurfaceKHR *")] ulong* surface
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_CreateSurface")]
        static abstract MaybeBool<byte> VulkanCreateSurface(
            WindowHandle window,
            [NativeTypeName("VkInstance")] Ref instance,
            [NativeTypeName("const struct VkAllocationCallbacks *")] Ref allocator,
            [NativeTypeName("VkSurfaceKHR *")] Ref<ulong> surface
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_DestroySurface")]
        static abstract void VulkanDestroySurface(
            [NativeTypeName("VkInstance")] void* instance,
            [NativeTypeName("VkSurfaceKHR")] ulong surface,
            [NativeTypeName("const struct VkAllocationCallbacks *")] void* allocator
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_DestroySurface")]
        static abstract void VulkanDestroySurface(
            [NativeTypeName("VkInstance")] Ref instance,
            [NativeTypeName("VkSurfaceKHR")] ulong surface,
            [NativeTypeName("const struct VkAllocationCallbacks *")] Ref allocator
        );

        [return: NativeTypeName("const char *const *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        static abstract sbyte** VulkanGetInstanceExtensions(
            [NativeTypeName("Uint32 *")] uint* count
        );

        [return: NativeTypeName("const char *const *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        static abstract Ptr2D<sbyte> VulkanGetInstanceExtensions(
            [NativeTypeName("Uint32 *")] Ref<uint> count
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetPresentationSupport")]
        static abstract byte VulkanGetPresentationSupport(
            [NativeTypeName("VkInstance")] void* instance,
            [NativeTypeName("VkPhysicalDevice")] ulong physicalDevice,
            [NativeTypeName("Uint32")] uint queueFamilyIndex
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetPresentationSupport")]
        static abstract MaybeBool<byte> VulkanGetPresentationSupport(
            [NativeTypeName("VkInstance")] Ref instance,
            [NativeTypeName("VkPhysicalDevice")] ulong physicalDevice,
            [NativeTypeName("Uint32")] uint queueFamilyIndex
        );

        [return: NativeTypeName("SDL_FunctionPointer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetVkGetInstanceProcAddr")]
        static abstract FunctionPointer VulkanGetVkGetInstanceProcAddr();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_LoadLibrary")]
        static abstract byte VulkanLoadLibrary([NativeTypeName("const char *")] sbyte* path);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_LoadLibrary")]
        static abstract MaybeBool<byte> VulkanLoadLibrary(
            [NativeTypeName("const char *")] Ref<sbyte> path
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_UnloadLibrary")]
        static abstract void VulkanUnloadLibrary();

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitAndAcquireGPUSwapchainTexture")]
        static abstract byte WaitAndAcquireGPUSwapchainTexture(
            GPUCommandBufferHandle command_buffer,
            WindowHandle window,
            GPUTextureHandle* swapchain_texture,
            [NativeTypeName("Uint32 *")] uint* swapchain_texture_width,
            [NativeTypeName("Uint32 *")] uint* swapchain_texture_height
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitAndAcquireGPUSwapchainTexture")]
        static abstract MaybeBool<byte> WaitAndAcquireGPUSwapchainTexture(
            GPUCommandBufferHandle command_buffer,
            WindowHandle window,
            Ref<GPUTextureHandle> swapchain_texture,
            [NativeTypeName("Uint32 *")] Ref<uint> swapchain_texture_width,
            [NativeTypeName("Uint32 *")] Ref<uint> swapchain_texture_height
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_WaitCondition")]
        static abstract void WaitCondition(ConditionHandle cond, MutexHandle mutex);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitConditionTimeout")]
        static abstract MaybeBool<byte> WaitConditionTimeout(
            ConditionHandle cond,
            MutexHandle mutex,
            [NativeTypeName("Sint32")] int timeoutMS
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitConditionTimeout")]
        static abstract byte WaitConditionTimeoutRaw(
            ConditionHandle cond,
            MutexHandle mutex,
            [NativeTypeName("Sint32")] int timeoutMS
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitEvent")]
        static abstract byte WaitEvent(Event* @event);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitEvent")]
        static abstract MaybeBool<byte> WaitEvent(Ref<Event> @event);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitEventTimeout")]
        static abstract byte WaitEventTimeout(
            Event* @event,
            [NativeTypeName("Sint32")] int timeoutMS
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitEventTimeout")]
        static abstract MaybeBool<byte> WaitEventTimeout(
            Ref<Event> @event,
            [NativeTypeName("Sint32")] int timeoutMS
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUFences")]
        static abstract byte WaitForGPUFences(
            GPUDeviceHandle device,
            [NativeTypeName("bool")] byte wait_all,
            [NativeTypeName("SDL_GPUFence *const *")] GPUFenceHandle* fences,
            [NativeTypeName("Uint32")] uint num_fences
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUFences")]
        static abstract MaybeBool<byte> WaitForGPUFences(
            GPUDeviceHandle device,
            [NativeTypeName("bool")] MaybeBool<byte> wait_all,
            [NativeTypeName("SDL_GPUFence *const *")] Ref<GPUFenceHandle> fences,
            [NativeTypeName("Uint32")] uint num_fences
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUIdle")]
        static abstract MaybeBool<byte> WaitForGPUIdle(GPUDeviceHandle device);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUIdle")]
        static abstract byte WaitForGPUIdleRaw(GPUDeviceHandle device);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUSwapchain")]
        static abstract MaybeBool<byte> WaitForGPUSwapchain(
            GPUDeviceHandle device,
            WindowHandle window
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUSwapchain")]
        static abstract byte WaitForGPUSwapchainRaw(GPUDeviceHandle device, WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitProcess")]
        static abstract byte WaitProcess(
            ProcessHandle process,
            [NativeTypeName("bool")] byte block,
            int* exitcode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitProcess")]
        static abstract MaybeBool<byte> WaitProcess(
            ProcessHandle process,
            [NativeTypeName("bool")] MaybeBool<byte> block,
            Ref<int> exitcode
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphore")]
        static abstract void WaitSemaphore(SemaphoreHandle sem);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphoreTimeout")]
        static abstract MaybeBool<byte> WaitSemaphoreTimeout(
            SemaphoreHandle sem,
            [NativeTypeName("Sint32")] int timeoutMS
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphoreTimeout")]
        static abstract byte WaitSemaphoreTimeoutRaw(
            SemaphoreHandle sem,
            [NativeTypeName("Sint32")] int timeoutMS
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_WaitThread")]
        static abstract void WaitThread(ThreadHandle thread, int* status);

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitThread")]
        static abstract void WaitThread(ThreadHandle thread, Ref<int> status);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseGlobal")]
        static abstract MaybeBool<byte> WarpMouseGlobal(float x, float y);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseGlobal")]
        static abstract byte WarpMouseGlobalRaw(float x, float y);

        [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseInWindow")]
        static abstract void WarpMouseInWindow(WindowHandle window, float x, float y);

        [return: NativeTypeName("SDL_InitFlags")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WasInit")]
        static abstract uint WasInit([NativeTypeName("SDL_InitFlags")] uint flags);

        [NativeFunction("SDL3", EntryPoint = "SDL_wcscasecmp")]
        static abstract int Wcscasecmp(
            [NativeTypeName("const wchar_t *")] uint* str1,
            [NativeTypeName("const wchar_t *")] uint* str2
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcscasecmp")]
        static abstract int Wcscasecmp(
            [NativeTypeName("const wchar_t *")] Ref<uint> str1,
            [NativeTypeName("const wchar_t *")] Ref<uint> str2
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_wcscmp")]
        static abstract int Wcscmp(
            [NativeTypeName("const wchar_t *")] uint* str1,
            [NativeTypeName("const wchar_t *")] uint* str2
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcscmp")]
        static abstract int Wcscmp(
            [NativeTypeName("const wchar_t *")] Ref<uint> str1,
            [NativeTypeName("const wchar_t *")] Ref<uint> str2
        );

        [return: NativeTypeName("wchar_t *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsdup")]
        static abstract uint* Wcsdup([NativeTypeName("const wchar_t *")] uint* wstr);

        [return: NativeTypeName("wchar_t *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsdup")]
        static abstract Ptr<uint> Wcsdup([NativeTypeName("const wchar_t *")] Ref<uint> wstr);

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcslcat")]
        static abstract nuint Wcslcat(
            [NativeTypeName("wchar_t *")] uint* dst,
            [NativeTypeName("const wchar_t *")] uint* src,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcslcat")]
        static abstract nuint Wcslcat(
            [NativeTypeName("wchar_t *")] Ref<uint> dst,
            [NativeTypeName("const wchar_t *")] Ref<uint> src,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcslcpy")]
        static abstract nuint Wcslcpy(
            [NativeTypeName("wchar_t *")] uint* dst,
            [NativeTypeName("const wchar_t *")] uint* src,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcslcpy")]
        static abstract nuint Wcslcpy(
            [NativeTypeName("wchar_t *")] Ref<uint> dst,
            [NativeTypeName("const wchar_t *")] Ref<uint> src,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcslen")]
        static abstract nuint Wcslen([NativeTypeName("const wchar_t *")] uint* wstr);

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcslen")]
        static abstract nuint Wcslen([NativeTypeName("const wchar_t *")] Ref<uint> wstr);

        [NativeFunction("SDL3", EntryPoint = "SDL_wcsncasecmp")]
        static abstract int Wcsncasecmp(
            [NativeTypeName("const wchar_t *")] uint* str1,
            [NativeTypeName("const wchar_t *")] uint* str2,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsncasecmp")]
        static abstract int Wcsncasecmp(
            [NativeTypeName("const wchar_t *")] Ref<uint> str1,
            [NativeTypeName("const wchar_t *")] Ref<uint> str2,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [NativeFunction("SDL3", EntryPoint = "SDL_wcsncmp")]
        static abstract int Wcsncmp(
            [NativeTypeName("const wchar_t *")] uint* str1,
            [NativeTypeName("const wchar_t *")] uint* str2,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsncmp")]
        static abstract int Wcsncmp(
            [NativeTypeName("const wchar_t *")] Ref<uint> str1,
            [NativeTypeName("const wchar_t *")] Ref<uint> str2,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("size_t")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsnlen")]
        static abstract nuint Wcsnlen(
            [NativeTypeName("const wchar_t *")] uint* wstr,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("size_t")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsnlen")]
        static abstract nuint Wcsnlen(
            [NativeTypeName("const wchar_t *")] Ref<uint> wstr,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("wchar_t *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsnstr")]
        static abstract uint* Wcsnstr(
            [NativeTypeName("const wchar_t *")] uint* haystack,
            [NativeTypeName("const wchar_t *")] uint* needle,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("wchar_t *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsnstr")]
        static abstract Ptr<uint> Wcsnstr(
            [NativeTypeName("const wchar_t *")] Ref<uint> haystack,
            [NativeTypeName("const wchar_t *")] Ref<uint> needle,
            [NativeTypeName("size_t")] nuint maxlen
        );

        [return: NativeTypeName("wchar_t *")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsstr")]
        static abstract uint* Wcsstr(
            [NativeTypeName("const wchar_t *")] uint* haystack,
            [NativeTypeName("const wchar_t *")] uint* needle
        );

        [return: NativeTypeName("wchar_t *")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsstr")]
        static abstract Ptr<uint> Wcsstr(
            [NativeTypeName("const wchar_t *")] Ref<uint> haystack,
            [NativeTypeName("const wchar_t *")] Ref<uint> needle
        );

        [return: NativeTypeName("long")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcstol")]
        static abstract nint Wcstol(
            [NativeTypeName("const wchar_t *")] uint* str,
            [NativeTypeName("wchar_t **")] uint** endp,
            int @base
        );

        [return: NativeTypeName("long")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcstol")]
        static abstract nint Wcstol(
            [NativeTypeName("const wchar_t *")] Ref<uint> str,
            [NativeTypeName("wchar_t **")] Ref2D<uint> endp,
            int @base
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WindowHasSurface")]
        static abstract MaybeBool<byte> WindowHasSurface(WindowHandle window);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WindowHasSurface")]
        static abstract byte WindowHasSurfaceRaw(WindowHandle window);

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUPresentMode")]
        static abstract MaybeBool<byte> WindowSupportsGPUPresentMode(
            GPUDeviceHandle device,
            WindowHandle window,
            GPUPresentMode present_mode
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUPresentMode")]
        static abstract byte WindowSupportsGPUPresentModeRaw(
            GPUDeviceHandle device,
            WindowHandle window,
            GPUPresentMode present_mode
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUSwapchainComposition")]
        static abstract MaybeBool<byte> WindowSupportsGPUSwapchainComposition(
            GPUDeviceHandle device,
            WindowHandle window,
            GPUSwapchainComposition swapchain_composition
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUSwapchainComposition")]
        static abstract byte WindowSupportsGPUSwapchainCompositionRaw(
            GPUDeviceHandle device,
            WindowHandle window,
            GPUSwapchainComposition swapchain_composition
        );

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

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16BE")]
        static abstract MaybeBool<byte> WriteS16BE(
            IOStreamHandle dst,
            [NativeTypeName("Sint16")] short value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16BE")]
        static abstract byte WriteS16BERaw(
            IOStreamHandle dst,
            [NativeTypeName("Sint16")] short value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16LE")]
        static abstract MaybeBool<byte> WriteS16LE(
            IOStreamHandle dst,
            [NativeTypeName("Sint16")] short value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16LE")]
        static abstract byte WriteS16LERaw(
            IOStreamHandle dst,
            [NativeTypeName("Sint16")] short value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32BE")]
        static abstract MaybeBool<byte> WriteS32BE(
            IOStreamHandle dst,
            [NativeTypeName("Sint32")] int value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32BE")]
        static abstract byte WriteS32BERaw(
            IOStreamHandle dst,
            [NativeTypeName("Sint32")] int value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32LE")]
        static abstract MaybeBool<byte> WriteS32LE(
            IOStreamHandle dst,
            [NativeTypeName("Sint32")] int value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32LE")]
        static abstract byte WriteS32LERaw(
            IOStreamHandle dst,
            [NativeTypeName("Sint32")] int value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64BE")]
        static abstract MaybeBool<byte> WriteS64BE(
            IOStreamHandle dst,
            [NativeTypeName("Sint64")] nint value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64BE")]
        static abstract byte WriteS64BERaw(
            IOStreamHandle dst,
            [NativeTypeName("Sint64")] nint value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64LE")]
        static abstract MaybeBool<byte> WriteS64LE(
            IOStreamHandle dst,
            [NativeTypeName("Sint64")] nint value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64LE")]
        static abstract byte WriteS64LERaw(
            IOStreamHandle dst,
            [NativeTypeName("Sint64")] nint value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS8")]
        static abstract MaybeBool<byte> WriteS8(
            IOStreamHandle dst,
            [NativeTypeName("Sint8")] sbyte value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS8")]
        static abstract byte WriteS8Raw(IOStreamHandle dst, [NativeTypeName("Sint8")] sbyte value);

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteStorageFile")]
        static abstract byte WriteStorageFile(
            StorageHandle storage,
            [NativeTypeName("const char *")] sbyte* path,
            [NativeTypeName("const void *")] void* source,
            [NativeTypeName("Uint64")] nuint length
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteStorageFile")]
        static abstract MaybeBool<byte> WriteStorageFile(
            StorageHandle storage,
            [NativeTypeName("const char *")] Ref<sbyte> path,
            [NativeTypeName("const void *")] Ref source,
            [NativeTypeName("Uint64")] nuint length
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteSurfacePixel")]
        static abstract byte WriteSurfacePixel(
            Surface* surface,
            int x,
            int y,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b,
            [NativeTypeName("Uint8")] byte a
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteSurfacePixel")]
        static abstract MaybeBool<byte> WriteSurfacePixel(
            Ref<Surface> surface,
            int x,
            int y,
            [NativeTypeName("Uint8")] byte r,
            [NativeTypeName("Uint8")] byte g,
            [NativeTypeName("Uint8")] byte b,
            [NativeTypeName("Uint8")] byte a
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteSurfacePixelFloat")]
        static abstract byte WriteSurfacePixelFloat(
            Surface* surface,
            int x,
            int y,
            float r,
            float g,
            float b,
            float a
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteSurfacePixelFloat")]
        static abstract MaybeBool<byte> WriteSurfacePixelFloat(
            Ref<Surface> surface,
            int x,
            int y,
            float r,
            float g,
            float b,
            float a
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16BE")]
        static abstract MaybeBool<byte> WriteU16BE(
            IOStreamHandle dst,
            [NativeTypeName("Uint16")] ushort value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16BE")]
        static abstract byte WriteU16BERaw(
            IOStreamHandle dst,
            [NativeTypeName("Uint16")] ushort value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16LE")]
        static abstract MaybeBool<byte> WriteU16LE(
            IOStreamHandle dst,
            [NativeTypeName("Uint16")] ushort value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16LE")]
        static abstract byte WriteU16LERaw(
            IOStreamHandle dst,
            [NativeTypeName("Uint16")] ushort value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32BE")]
        static abstract MaybeBool<byte> WriteU32BE(
            IOStreamHandle dst,
            [NativeTypeName("Uint32")] uint value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32BE")]
        static abstract byte WriteU32BERaw(
            IOStreamHandle dst,
            [NativeTypeName("Uint32")] uint value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32LE")]
        static abstract MaybeBool<byte> WriteU32LE(
            IOStreamHandle dst,
            [NativeTypeName("Uint32")] uint value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32LE")]
        static abstract byte WriteU32LERaw(
            IOStreamHandle dst,
            [NativeTypeName("Uint32")] uint value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64BE")]
        static abstract MaybeBool<byte> WriteU64BE(
            IOStreamHandle dst,
            [NativeTypeName("Uint64")] nuint value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64BE")]
        static abstract byte WriteU64BERaw(
            IOStreamHandle dst,
            [NativeTypeName("Uint64")] nuint value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64LE")]
        static abstract MaybeBool<byte> WriteU64LE(
            IOStreamHandle dst,
            [NativeTypeName("Uint64")] nuint value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64LE")]
        static abstract byte WriteU64LERaw(
            IOStreamHandle dst,
            [NativeTypeName("Uint64")] nuint value
        );

        [return: NativeTypeName("bool")]
        [Transformed]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU8")]
        static abstract MaybeBool<byte> WriteU8(
            IOStreamHandle dst,
            [NativeTypeName("Uint8")] byte value
        );

        [return: NativeTypeName("bool")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU8")]
        static abstract byte WriteU8Raw(IOStreamHandle dst, [NativeTypeName("Uint8")] byte value);
    }

    [NativeFunction("SDL3", EntryPoint = "SDL_abs")]
    int Abs(int x);

    [NativeFunction("SDL3", EntryPoint = "SDL_acos")]
    double Acos(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_acosf")]
    float Acosf(float x);

    [NativeFunction("SDL3", EntryPoint = "SDL_AcquireCameraFrame")]
    Surface* AcquireCameraFrame(
        CameraHandle camera,
        [NativeTypeName("Uint64 *")] nuint* timestampNS
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AcquireCameraFrame")]
    Ptr<Surface> AcquireCameraFrame(
        CameraHandle camera,
        [NativeTypeName("Uint64 *")] Ref<nuint> timestampNS
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_AcquireGPUCommandBuffer")]
    GPUCommandBufferHandle AcquireGPUCommandBuffer(GPUDeviceHandle device);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AcquireGPUSwapchainTexture")]
    byte AcquireGPUSwapchainTexture(
        GPUCommandBufferHandle command_buffer,
        WindowHandle window,
        GPUTextureHandle* swapchain_texture,
        [NativeTypeName("Uint32 *")] uint* swapchain_texture_width,
        [NativeTypeName("Uint32 *")] uint* swapchain_texture_height
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AcquireGPUSwapchainTexture")]
    MaybeBool<byte> AcquireGPUSwapchainTexture(
        GPUCommandBufferHandle command_buffer,
        WindowHandle window,
        Ref<GPUTextureHandle> swapchain_texture,
        [NativeTypeName("Uint32 *")] Ref<uint> swapchain_texture_width,
        [NativeTypeName("Uint32 *")] Ref<uint> swapchain_texture_height
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_AddAtomicInt")]
    int AddAtomicInt(AtomicInt* a, int v);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddAtomicInt")]
    int AddAtomicInt(Ref<AtomicInt> a, int v);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddEventWatch")]
    byte AddEventWatch([NativeTypeName("SDL_EventFilter")] EventFilter filter, void* userdata);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddEventWatch")]
    MaybeBool<byte> AddEventWatch(
        [NativeTypeName("SDL_EventFilter")] EventFilter filter,
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
    int AddGamepadMappingsFromIO(IOStreamHandle src, [NativeTypeName("bool")] byte closeio);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromIO")]
    int AddGamepadMappingsFromIO(
        IOStreamHandle src,
        [NativeTypeName("bool")] MaybeBool<byte> closeio
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddHintCallback")]
    byte AddHintCallback(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("SDL_HintCallback")] HintCallback callback,
        void* userdata
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddHintCallback")]
    MaybeBool<byte> AddHintCallback(
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("SDL_HintCallback")] HintCallback callback,
        Ref userdata
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddSurfaceAlternateImage")]
    byte AddSurfaceAlternateImage(Surface* surface, Surface* image);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddSurfaceAlternateImage")]
    MaybeBool<byte> AddSurfaceAlternateImage(Ref<Surface> surface, Ref<Surface> image);

    [return: NativeTypeName("SDL_TimerID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddTimer")]
    uint AddTimer(
        [NativeTypeName("Uint32")] uint interval,
        [NativeTypeName("SDL_TimerCallback")] TimerCallback callback,
        void* userdata
    );

    [return: NativeTypeName("SDL_TimerID")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddTimer")]
    uint AddTimer(
        [NativeTypeName("Uint32")] uint interval,
        [NativeTypeName("SDL_TimerCallback")] TimerCallback callback,
        Ref userdata
    );

    [return: NativeTypeName("SDL_TimerID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddTimerNS")]
    uint AddTimerNS(
        [NativeTypeName("Uint64")] nuint interval,
        [NativeTypeName("SDL_NSTimerCallback")] NSTimerCallback callback,
        void* userdata
    );

    [return: NativeTypeName("SDL_TimerID")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddTimerNS")]
    uint AddTimerNS(
        [NativeTypeName("Uint64")] nuint interval,
        [NativeTypeName("SDL_NSTimerCallback")] NSTimerCallback callback,
        Ref userdata
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddVulkanRenderSemaphores")]
    MaybeBool<byte> AddVulkanRenderSemaphores(
        RendererHandle renderer,
        [NativeTypeName("Uint32")] uint wait_stage_mask,
        [NativeTypeName("Sint64")] nint wait_semaphore,
        [NativeTypeName("Sint64")] nint signal_semaphore
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddVulkanRenderSemaphores")]
    byte AddVulkanRenderSemaphoresRaw(
        RendererHandle renderer,
        [NativeTypeName("Uint32")] uint wait_stage_mask,
        [NativeTypeName("Sint64")] nint wait_semaphore,
        [NativeTypeName("Sint64")] nint signal_semaphore
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_aligned_alloc")]
    Ptr AlignedAlloc(
        [NativeTypeName("size_t")] nuint alignment,
        [NativeTypeName("size_t")] nuint size
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_aligned_alloc")]
    void* AlignedAllocRaw(
        [NativeTypeName("size_t")] nuint alignment,
        [NativeTypeName("size_t")] nuint size
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_aligned_free")]
    void AlignedFree(void* mem);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_aligned_free")]
    void AlignedFree(Ref mem);

    [NativeFunction("SDL3", EntryPoint = "SDL_asin")]
    double Asin(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_asinf")]
    float Asinf(float x);

    [NativeFunction("SDL3", EntryPoint = "SDL_atan")]
    double Atan(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_atan2")]
    double Atan2(double y, double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_atan2f")]
    float Atan2F(float y, float x);

    [NativeFunction("SDL3", EntryPoint = "SDL_atanf")]
    float Atanf(float x);

    [NativeFunction("SDL3", EntryPoint = "SDL_atof")]
    double Atof([NativeTypeName("const char *")] sbyte* str);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_atof")]
    double Atof([NativeTypeName("const char *")] Ref<sbyte> str);

    [NativeFunction("SDL3", EntryPoint = "SDL_atoi")]
    int Atoi([NativeTypeName("const char *")] sbyte* str);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_atoi")]
    int Atoi([NativeTypeName("const char *")] Ref<sbyte> str);

    [return: NativeTypeName("SDL_JoystickID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AttachVirtualJoystick")]
    uint AttachVirtualJoystick(
        [NativeTypeName("const SDL_VirtualJoystickDesc *")] VirtualJoystickDesc* desc
    );

    [return: NativeTypeName("SDL_JoystickID")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AttachVirtualJoystick")]
    uint AttachVirtualJoystick(
        [NativeTypeName("const SDL_VirtualJoystickDesc *")] Ref<VirtualJoystickDesc> desc
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AudioDevicePaused")]
    MaybeBool<byte> AudioDevicePaused([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AudioDevicePaused")]
    byte AudioDevicePausedRaw([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_AudioStreamDevicePaused")]
    MaybeBool<byte> AudioStreamDevicePaused(AudioStreamHandle stream);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AudioStreamDevicePaused")]
    byte AudioStreamDevicePausedRaw(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPUComputePass")]
    GPUComputePassHandle BeginGPUComputePass(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("const SDL_GPUStorageTextureReadWriteBinding *")]
            GPUStorageTextureReadWriteBinding* storage_texture_bindings,
        [NativeTypeName("Uint32")] uint num_storage_texture_bindings,
        [NativeTypeName("const SDL_GPUStorageBufferReadWriteBinding *")]
            GPUStorageBufferReadWriteBinding* storage_buffer_bindings,
        [NativeTypeName("Uint32")] uint num_storage_buffer_bindings
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPUComputePass")]
    GPUComputePassHandle BeginGPUComputePass(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("const SDL_GPUStorageTextureReadWriteBinding *")]
            Ref<GPUStorageTextureReadWriteBinding> storage_texture_bindings,
        [NativeTypeName("Uint32")] uint num_storage_texture_bindings,
        [NativeTypeName("const SDL_GPUStorageBufferReadWriteBinding *")]
            Ref<GPUStorageBufferReadWriteBinding> storage_buffer_bindings,
        [NativeTypeName("Uint32")] uint num_storage_buffer_bindings
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPUCopyPass")]
    GPUCopyPassHandle BeginGPUCopyPass(GPUCommandBufferHandle command_buffer);

    [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPURenderPass")]
    GPURenderPassHandle BeginGPURenderPass(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("const SDL_GPUColorTargetInfo *")] GPUColorTargetInfo* color_target_infos,
        [NativeTypeName("Uint32")] uint num_color_targets,
        [NativeTypeName("const SDL_GPUDepthStencilTargetInfo *")]
            GPUDepthStencilTargetInfo* depth_stencil_target_info
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPURenderPass")]
    GPURenderPassHandle BeginGPURenderPass(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("const SDL_GPUColorTargetInfo *")]
            Ref<GPUColorTargetInfo> color_target_infos,
        [NativeTypeName("Uint32")] uint num_color_targets,
        [NativeTypeName("const SDL_GPUDepthStencilTargetInfo *")]
            Ref<GPUDepthStencilTargetInfo> depth_stencil_target_info
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStream")]
    MaybeBool<byte> BindAudioStream(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        AudioStreamHandle stream
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStream")]
    byte BindAudioStreamRaw(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        AudioStreamHandle stream
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStreams")]
    byte BindAudioStreams(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        [NativeTypeName("SDL_AudioStream *const *")] AudioStreamHandle* streams,
        int num_streams
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStreams")]
    MaybeBool<byte> BindAudioStreams(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        [NativeTypeName("SDL_AudioStream *const *")] Ref<AudioStreamHandle> streams,
        int num_streams
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputePipeline")]
    void BindGPUComputePipeline(
        GPUComputePassHandle compute_pass,
        GPUComputePipelineHandle compute_pipeline
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeSamplers")]
    void BindGPUComputeSamplers(
        GPUComputePassHandle compute_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
            GPUTextureSamplerBinding* texture_sampler_bindings,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeSamplers")]
    void BindGPUComputeSamplers(
        GPUComputePassHandle compute_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
            Ref<GPUTextureSamplerBinding> texture_sampler_bindings,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageBuffers")]
    void BindGPUComputeStorageBuffers(
        GPUComputePassHandle compute_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("SDL_GPUBuffer *const *")] GPUBufferHandle* storage_buffers,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageBuffers")]
    void BindGPUComputeStorageBuffers(
        GPUComputePassHandle compute_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("SDL_GPUBuffer *const *")] Ref<GPUBufferHandle> storage_buffers,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageTextures")]
    void BindGPUComputeStorageTextures(
        GPUComputePassHandle compute_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("SDL_GPUTexture *const *")] GPUTextureHandle* storage_textures,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageTextures")]
    void BindGPUComputeStorageTextures(
        GPUComputePassHandle compute_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("SDL_GPUTexture *const *")] Ref<GPUTextureHandle> storage_textures,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentSamplers")]
    void BindGPUFragmentSamplers(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
            GPUTextureSamplerBinding* texture_sampler_bindings,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentSamplers")]
    void BindGPUFragmentSamplers(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
            Ref<GPUTextureSamplerBinding> texture_sampler_bindings,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageBuffers")]
    void BindGPUFragmentStorageBuffers(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("SDL_GPUBuffer *const *")] GPUBufferHandle* storage_buffers,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageBuffers")]
    void BindGPUFragmentStorageBuffers(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("SDL_GPUBuffer *const *")] Ref<GPUBufferHandle> storage_buffers,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageTextures")]
    void BindGPUFragmentStorageTextures(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("SDL_GPUTexture *const *")] GPUTextureHandle* storage_textures,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageTextures")]
    void BindGPUFragmentStorageTextures(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("SDL_GPUTexture *const *")] Ref<GPUTextureHandle> storage_textures,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUGraphicsPipeline")]
    void BindGPUGraphicsPipeline(
        GPURenderPassHandle render_pass,
        GPUGraphicsPipelineHandle graphics_pipeline
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUIndexBuffer")]
    void BindGPUIndexBuffer(
        GPURenderPassHandle render_pass,
        [NativeTypeName("const SDL_GPUBufferBinding *")] GPUBufferBinding* binding,
        GPUIndexElementSize index_element_size
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUIndexBuffer")]
    void BindGPUIndexBuffer(
        GPURenderPassHandle render_pass,
        [NativeTypeName("const SDL_GPUBufferBinding *")] Ref<GPUBufferBinding> binding,
        GPUIndexElementSize index_element_size
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexBuffers")]
    void BindGPUVertexBuffers(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("const SDL_GPUBufferBinding *")] GPUBufferBinding* bindings,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexBuffers")]
    void BindGPUVertexBuffers(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("const SDL_GPUBufferBinding *")] Ref<GPUBufferBinding> bindings,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexSamplers")]
    void BindGPUVertexSamplers(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
            GPUTextureSamplerBinding* texture_sampler_bindings,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexSamplers")]
    void BindGPUVertexSamplers(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("const SDL_GPUTextureSamplerBinding *")]
            Ref<GPUTextureSamplerBinding> texture_sampler_bindings,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageBuffers")]
    void BindGPUVertexStorageBuffers(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("SDL_GPUBuffer *const *")] GPUBufferHandle* storage_buffers,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageBuffers")]
    void BindGPUVertexStorageBuffers(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("SDL_GPUBuffer *const *")] Ref<GPUBufferHandle> storage_buffers,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageTextures")]
    void BindGPUVertexStorageTextures(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("SDL_GPUTexture *const *")] GPUTextureHandle* storage_textures,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageTextures")]
    void BindGPUVertexStorageTextures(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint first_slot,
        [NativeTypeName("SDL_GPUTexture *const *")] Ref<GPUTextureHandle> storage_textures,
        [NativeTypeName("Uint32")] uint num_bindings
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BlitGPUTexture")]
    void BlitGPUTexture(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("const SDL_GPUBlitInfo *")] GPUBlitInfo* info
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitGPUTexture")]
    void BlitGPUTexture(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("const SDL_GPUBlitInfo *")] Ref<GPUBlitInfo> info
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface")]
    byte BlitSurface(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* dstrect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface")]
    MaybeBool<byte> BlitSurface(
        Ref<Surface> src,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface9Grid")]
    byte BlitSurface9Grid(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        int left_width,
        int right_width,
        int top_height,
        int bottom_height,
        float scale,
        ScaleMode scaleMode,
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* dstrect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface9Grid")]
    MaybeBool<byte> BlitSurface9Grid(
        Ref<Surface> src,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
        int left_width,
        int right_width,
        int top_height,
        int bottom_height,
        float scale,
        ScaleMode scaleMode,
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceScaled")]
    byte BlitSurfaceScaled(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* dstrect,
        ScaleMode scaleMode
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceScaled")]
    MaybeBool<byte> BlitSurfaceScaled(
        Ref<Surface> src,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect,
        ScaleMode scaleMode
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiled")]
    byte BlitSurfaceTiled(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* dstrect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiled")]
    MaybeBool<byte> BlitSurfaceTiled(
        Ref<Surface> src,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiledWithScale")]
    byte BlitSurfaceTiledWithScale(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        float scale,
        ScaleMode scaleMode,
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* dstrect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiledWithScale")]
    MaybeBool<byte> BlitSurfaceTiledWithScale(
        Ref<Surface> src,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
        float scale,
        ScaleMode scaleMode,
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUnchecked")]
    byte BlitSurfaceUnchecked(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* dstrect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUnchecked")]
    MaybeBool<byte> BlitSurfaceUnchecked(
        Ref<Surface> src,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUncheckedScaled")]
    byte BlitSurfaceUncheckedScaled(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* dstrect,
        ScaleMode scaleMode
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUncheckedScaled")]
    MaybeBool<byte> BlitSurfaceUncheckedScaled(
        Ref<Surface> src,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect,
        ScaleMode scaleMode
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_BroadcastCondition")]
    void BroadcastCondition(ConditionHandle cond);

    [NativeFunction("SDL3", EntryPoint = "SDL_bsearch")]
    void* Bsearch(
        [NativeTypeName("const void *")] void* key,
        [NativeTypeName("const void *")] void* @base,
        [NativeTypeName("size_t")] nuint nmemb,
        [NativeTypeName("size_t")] nuint size,
        [NativeTypeName("SDL_CompareCallback")] CompareCallback compare
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_bsearch")]
    Ptr Bsearch(
        [NativeTypeName("const void *")] Ref key,
        [NativeTypeName("const void *")] Ref @base,
        [NativeTypeName("size_t")] nuint nmemb,
        [NativeTypeName("size_t")] nuint size,
        [NativeTypeName("SDL_CompareCallback")] CompareCallback compare
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_bsearch_r")]
    void* BsearchR(
        [NativeTypeName("const void *")] void* key,
        [NativeTypeName("const void *")] void* @base,
        [NativeTypeName("size_t")] nuint nmemb,
        [NativeTypeName("size_t")] nuint size,
        [NativeTypeName("SDL_CompareCallback_r")] CompareCallbackR compare,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_bsearch_r")]
    Ptr BsearchR(
        [NativeTypeName("const void *")] Ref key,
        [NativeTypeName("const void *")] Ref @base,
        [NativeTypeName("size_t")] nuint nmemb,
        [NativeTypeName("size_t")] nuint size,
        [NativeTypeName("SDL_CompareCallback_r")] CompareCallbackR compare,
        Ref userdata
    );

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CalculateGPUTextureFormatSize")]
    uint CalculateGPUTextureFormatSize(
        GPUTextureFormat format,
        [NativeTypeName("Uint32")] uint width,
        [NativeTypeName("Uint32")] uint height,
        [NativeTypeName("Uint32")] uint depth_or_layer_count
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_calloc")]
    Ptr Calloc([NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size);

    [NativeFunction("SDL3", EntryPoint = "SDL_calloc")]
    void* CallocRaw([NativeTypeName("size_t")] nuint nmemb, [NativeTypeName("size_t")] nuint size);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CancelGPUCommandBuffer")]
    MaybeBool<byte> CancelGPUCommandBuffer(GPUCommandBufferHandle command_buffer);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CancelGPUCommandBuffer")]
    byte CancelGPUCommandBufferRaw(GPUCommandBufferHandle command_buffer);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CaptureMouse")]
    byte CaptureMouse([NativeTypeName("bool")] byte enabled);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CaptureMouse")]
    MaybeBool<byte> CaptureMouse([NativeTypeName("bool")] MaybeBool<byte> enabled);

    [NativeFunction("SDL3", EntryPoint = "SDL_ceil")]
    double Ceil(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_ceilf")]
    float Ceilf(float x);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClaimWindowForGPUDevice")]
    MaybeBool<byte> ClaimWindowForGPUDevice(GPUDeviceHandle device, WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClaimWindowForGPUDevice")]
    byte ClaimWindowForGPUDeviceRaw(GPUDeviceHandle device, WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_CleanupTLS")]
    void CleanupTLS();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearAudioStream")]
    MaybeBool<byte> ClearAudioStream(AudioStreamHandle stream);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearAudioStream")]
    byte ClearAudioStreamRaw(AudioStreamHandle stream);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearClipboardData")]
    MaybeBool<byte> ClearClipboardData();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearClipboardData")]
    byte ClearClipboardDataRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearComposition")]
    MaybeBool<byte> ClearComposition(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearComposition")]
    byte ClearCompositionRaw(WindowHandle window);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearError")]
    MaybeBool<byte> ClearError();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearError")]
    byte ClearErrorRaw();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearProperty")]
    byte ClearProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearProperty")]
    MaybeBool<byte> ClearProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearSurface")]
    byte ClearSurface(Surface* surface, float r, float g, float b, float a);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearSurface")]
    MaybeBool<byte> ClearSurface(Ref<Surface> surface, float r, float g, float b, float a);

    [NativeFunction("SDL3", EntryPoint = "SDL_CloseAudioDevice")]
    void CloseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [NativeFunction("SDL3", EntryPoint = "SDL_CloseCamera")]
    void CloseCamera(CameraHandle camera);

    [NativeFunction("SDL3", EntryPoint = "SDL_CloseGamepad")]
    void CloseGamepad(GamepadHandle gamepad);

    [NativeFunction("SDL3", EntryPoint = "SDL_CloseHaptic")]
    void CloseHaptic(HapticHandle haptic);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CloseIO")]
    MaybeBool<byte> CloseIO(IOStreamHandle context);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CloseIO")]
    byte CloseIORaw(IOStreamHandle context);

    [NativeFunction("SDL3", EntryPoint = "SDL_CloseJoystick")]
    void CloseJoystick(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_CloseSensor")]
    void CloseSensor(SensorHandle sensor);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CloseStorage")]
    MaybeBool<byte> CloseStorage(StorageHandle storage);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CloseStorage")]
    byte CloseStorageRaw(StorageHandle storage);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicInt")]
    byte CompareAndSwapAtomicInt(AtomicInt* a, int oldval, int newval);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicInt")]
    MaybeBool<byte> CompareAndSwapAtomicInt(Ref<AtomicInt> a, int oldval, int newval);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicPointer")]
    byte CompareAndSwapAtomicPointer(void** a, void* oldval, void* newval);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicPointer")]
    MaybeBool<byte> CompareAndSwapAtomicPointer(Ref2D a, Ref oldval, Ref newval);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicU32")]
    byte CompareAndSwapAtomicU32(
        AtomicU32* a,
        [NativeTypeName("Uint32")] uint oldval,
        [NativeTypeName("Uint32")] uint newval
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicU32")]
    MaybeBool<byte> CompareAndSwapAtomicU32(
        Ref<AtomicU32> a,
        [NativeTypeName("Uint32")] uint oldval,
        [NativeTypeName("Uint32")] uint newval
    );

    [return: NativeTypeName("SDL_BlendMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ComposeCustomBlendMode")]
    uint ComposeCustomBlendMode(
        BlendFactor srcColorFactor,
        BlendFactor dstColorFactor,
        BlendOperation colorOperation,
        BlendFactor srcAlphaFactor,
        BlendFactor dstAlphaFactor,
        BlendOperation alphaOperation
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertAudioSamples")]
    byte ConvertAudioSamples(
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* src_spec,
        [NativeTypeName("const Uint8 *")] byte* src_data,
        int src_len,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* dst_spec,
        [NativeTypeName("Uint8 **")] byte** dst_data,
        int* dst_len
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertAudioSamples")]
    MaybeBool<byte> ConvertAudioSamples(
        [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> src_spec,
        [NativeTypeName("const Uint8 *")] Ref<byte> src_data,
        int src_len,
        [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> dst_spec,
        [NativeTypeName("Uint8 **")] Ref2D<byte> dst_data,
        Ref<int> dst_len
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertEventToRenderCoordinates")]
    byte ConvertEventToRenderCoordinates(RendererHandle renderer, Event* @event);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertEventToRenderCoordinates")]
    MaybeBool<byte> ConvertEventToRenderCoordinates(RendererHandle renderer, Ref<Event> @event);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixels")]
    byte ConvertPixels(
        int width,
        int height,
        PixelFormat src_format,
        [NativeTypeName("const void *")] void* src,
        int src_pitch,
        PixelFormat dst_format,
        void* dst,
        int dst_pitch
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixels")]
    MaybeBool<byte> ConvertPixels(
        int width,
        int height,
        PixelFormat src_format,
        [NativeTypeName("const void *")] Ref src,
        int src_pitch,
        PixelFormat dst_format,
        Ref dst,
        int dst_pitch
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixelsAndColorspace")]
    byte ConvertPixelsAndColorspace(
        int width,
        int height,
        PixelFormat src_format,
        Colorspace src_colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint src_properties,
        [NativeTypeName("const void *")] void* src,
        int src_pitch,
        PixelFormat dst_format,
        Colorspace dst_colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint dst_properties,
        void* dst,
        int dst_pitch
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixelsAndColorspace")]
    MaybeBool<byte> ConvertPixelsAndColorspace(
        int width,
        int height,
        PixelFormat src_format,
        Colorspace src_colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint src_properties,
        [NativeTypeName("const void *")] Ref src,
        int src_pitch,
        PixelFormat dst_format,
        Colorspace dst_colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint dst_properties,
        Ref dst,
        int dst_pitch
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurface")]
    Surface* ConvertSurface(Surface* surface, PixelFormat format);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurface")]
    Ptr<Surface> ConvertSurface(Ref<Surface> surface, PixelFormat format);

    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceAndColorspace")]
    Surface* ConvertSurfaceAndColorspace(
        Surface* surface,
        PixelFormat format,
        Palette* palette,
        Colorspace colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceAndColorspace")]
    Ptr<Surface> ConvertSurfaceAndColorspace(
        Ref<Surface> surface,
        PixelFormat format,
        Ref<Palette> palette,
        Colorspace colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyFile")]
    byte CopyFile(
        [NativeTypeName("const char *")] sbyte* oldpath,
        [NativeTypeName("const char *")] sbyte* newpath
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyFile")]
    MaybeBool<byte> CopyFile(
        [NativeTypeName("const char *")] Ref<sbyte> oldpath,
        [NativeTypeName("const char *")] Ref<sbyte> newpath
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUBufferToBuffer")]
    void CopyGPUBufferToBuffer(
        GPUCopyPassHandle copy_pass,
        [NativeTypeName("const SDL_GPUBufferLocation *")] GPUBufferLocation* source,
        [NativeTypeName("const SDL_GPUBufferLocation *")] GPUBufferLocation* destination,
        [NativeTypeName("Uint32")] uint size,
        [NativeTypeName("bool")] byte cycle
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUBufferToBuffer")]
    void CopyGPUBufferToBuffer(
        GPUCopyPassHandle copy_pass,
        [NativeTypeName("const SDL_GPUBufferLocation *")] Ref<GPUBufferLocation> source,
        [NativeTypeName("const SDL_GPUBufferLocation *")] Ref<GPUBufferLocation> destination,
        [NativeTypeName("Uint32")] uint size,
        [NativeTypeName("bool")] MaybeBool<byte> cycle
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUTextureToTexture")]
    void CopyGPUTextureToTexture(
        GPUCopyPassHandle copy_pass,
        [NativeTypeName("const SDL_GPUTextureLocation *")] GPUTextureLocation* source,
        [NativeTypeName("const SDL_GPUTextureLocation *")] GPUTextureLocation* destination,
        [NativeTypeName("Uint32")] uint w,
        [NativeTypeName("Uint32")] uint h,
        [NativeTypeName("Uint32")] uint d,
        [NativeTypeName("bool")] byte cycle
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUTextureToTexture")]
    void CopyGPUTextureToTexture(
        GPUCopyPassHandle copy_pass,
        [NativeTypeName("const SDL_GPUTextureLocation *")] Ref<GPUTextureLocation> source,
        [NativeTypeName("const SDL_GPUTextureLocation *")] Ref<GPUTextureLocation> destination,
        [NativeTypeName("Uint32")] uint w,
        [NativeTypeName("Uint32")] uint h,
        [NativeTypeName("Uint32")] uint d,
        [NativeTypeName("bool")] MaybeBool<byte> cycle
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyProperties")]
    MaybeBool<byte> CopyProperties(
        [NativeTypeName("SDL_PropertiesID")] uint src,
        [NativeTypeName("SDL_PropertiesID")] uint dst
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyProperties")]
    byte CopyPropertiesRaw(
        [NativeTypeName("SDL_PropertiesID")] uint src,
        [NativeTypeName("SDL_PropertiesID")] uint dst
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_copysign")]
    double Copysign(double x, double y);

    [NativeFunction("SDL3", EntryPoint = "SDL_copysignf")]
    float Copysignf(float x, float y);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyStorageFile")]
    byte CopyStorageFile(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* oldpath,
        [NativeTypeName("const char *")] sbyte* newpath
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyStorageFile")]
    MaybeBool<byte> CopyStorageFile(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> oldpath,
        [NativeTypeName("const char *")] Ref<sbyte> newpath
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_cos")]
    double Cos(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_cosf")]
    float Cosf(float x);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_crc16")]
    ushort Crc16(
        [NativeTypeName("Uint16")] ushort crc,
        [NativeTypeName("const void *")] void* data,
        [NativeTypeName("size_t")] nuint len
    );

    [return: NativeTypeName("Uint16")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_crc16")]
    ushort Crc16(
        [NativeTypeName("Uint16")] ushort crc,
        [NativeTypeName("const void *")] Ref data,
        [NativeTypeName("size_t")] nuint len
    );

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_crc32")]
    uint Crc32(
        [NativeTypeName("Uint32")] uint crc,
        [NativeTypeName("const void *")] void* data,
        [NativeTypeName("size_t")] nuint len
    );

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_crc32")]
    uint Crc32(
        [NativeTypeName("Uint32")] uint crc,
        [NativeTypeName("const void *")] Ref data,
        [NativeTypeName("size_t")] nuint len
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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateDirectory")]
    byte CreateDirectory([NativeTypeName("const char *")] sbyte* path);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateDirectory")]
    MaybeBool<byte> CreateDirectory([NativeTypeName("const char *")] Ref<sbyte> path);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateEnvironment")]
    EnvironmentHandle CreateEnvironment([NativeTypeName("bool")] byte populated);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateEnvironment")]
    EnvironmentHandle CreateEnvironment([NativeTypeName("bool")] MaybeBool<byte> populated);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUBuffer")]
    GPUBufferHandle CreateGPUBuffer(
        GPUDeviceHandle device,
        [NativeTypeName("const SDL_GPUBufferCreateInfo *")] GPUBufferCreateInfo* createinfo
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUBuffer")]
    GPUBufferHandle CreateGPUBuffer(
        GPUDeviceHandle device,
        [NativeTypeName("const SDL_GPUBufferCreateInfo *")] Ref<GPUBufferCreateInfo> createinfo
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUComputePipeline")]
    GPUComputePipelineHandle CreateGPUComputePipeline(
        GPUDeviceHandle device,
        [NativeTypeName("const SDL_GPUComputePipelineCreateInfo *")]
            GPUComputePipelineCreateInfo* createinfo
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUComputePipeline")]
    GPUComputePipelineHandle CreateGPUComputePipeline(
        GPUDeviceHandle device,
        [NativeTypeName("const SDL_GPUComputePipelineCreateInfo *")]
            Ref<GPUComputePipelineCreateInfo> createinfo
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUDevice")]
    GPUDeviceHandle CreateGPUDevice(
        [NativeTypeName("SDL_GPUShaderFormat")] uint format_flags,
        [NativeTypeName("bool")] byte debug_mode,
        [NativeTypeName("const char *")] sbyte* name
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUDevice")]
    GPUDeviceHandle CreateGPUDevice(
        [NativeTypeName("SDL_GPUShaderFormat")] uint format_flags,
        [NativeTypeName("bool")] MaybeBool<byte> debug_mode,
        [NativeTypeName("const char *")] Ref<sbyte> name
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUDeviceWithProperties")]
    GPUDeviceHandle CreateGPUDeviceWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUGraphicsPipeline")]
    GPUGraphicsPipelineHandle CreateGPUGraphicsPipeline(
        GPUDeviceHandle device,
        [NativeTypeName("const SDL_GPUGraphicsPipelineCreateInfo *")]
            GPUGraphicsPipelineCreateInfo* createinfo
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUGraphicsPipeline")]
    GPUGraphicsPipelineHandle CreateGPUGraphicsPipeline(
        GPUDeviceHandle device,
        [NativeTypeName("const SDL_GPUGraphicsPipelineCreateInfo *")]
            Ref<GPUGraphicsPipelineCreateInfo> createinfo
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUSampler")]
    GPUSamplerHandle CreateGPUSampler(
        GPUDeviceHandle device,
        [NativeTypeName("const SDL_GPUSamplerCreateInfo *")] GPUSamplerCreateInfo* createinfo
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUSampler")]
    GPUSamplerHandle CreateGPUSampler(
        GPUDeviceHandle device,
        [NativeTypeName("const SDL_GPUSamplerCreateInfo *")] Ref<GPUSamplerCreateInfo> createinfo
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUShader")]
    GPUShaderHandle CreateGPUShader(
        GPUDeviceHandle device,
        [NativeTypeName("const SDL_GPUShaderCreateInfo *")] GPUShaderCreateInfo* createinfo
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUShader")]
    GPUShaderHandle CreateGPUShader(
        GPUDeviceHandle device,
        [NativeTypeName("const SDL_GPUShaderCreateInfo *")] Ref<GPUShaderCreateInfo> createinfo
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTexture")]
    GPUTextureHandle CreateGPUTexture(
        GPUDeviceHandle device,
        [NativeTypeName("const SDL_GPUTextureCreateInfo *")] GPUTextureCreateInfo* createinfo
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTexture")]
    GPUTextureHandle CreateGPUTexture(
        GPUDeviceHandle device,
        [NativeTypeName("const SDL_GPUTextureCreateInfo *")] Ref<GPUTextureCreateInfo> createinfo
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTransferBuffer")]
    GPUTransferBufferHandle CreateGPUTransferBuffer(
        GPUDeviceHandle device,
        [NativeTypeName("const SDL_GPUTransferBufferCreateInfo *")]
            GPUTransferBufferCreateInfo* createinfo
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTransferBuffer")]
    GPUTransferBufferHandle CreateGPUTransferBuffer(
        GPUDeviceHandle device,
        [NativeTypeName("const SDL_GPUTransferBufferCreateInfo *")]
            Ref<GPUTransferBufferCreateInfo> createinfo
    );

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

    [NativeFunction("SDL3", EntryPoint = "SDL_CreatePopupWindow")]
    WindowHandle CreatePopupWindow(
        WindowHandle parent,
        int offset_x,
        int offset_y,
        int w,
        int h,
        [NativeTypeName("SDL_WindowFlags")] nuint flags
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateProcess")]
    ProcessHandle CreateProcess(
        [NativeTypeName("const char *const *")] sbyte** args,
        [NativeTypeName("bool")] byte pipe_stdio
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateProcess")]
    ProcessHandle CreateProcess(
        [NativeTypeName("const char *const *")] Ref2D<sbyte> args,
        [NativeTypeName("bool")] MaybeBool<byte> pipe_stdio
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateProcessWithProperties")]
    ProcessHandle CreateProcessWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateProperties")]
    uint CreateProperties();

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateRenderer")]
    RendererHandle CreateRenderer(
        WindowHandle window,
        [NativeTypeName("const char *")] sbyte* name
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateRenderer")]
    RendererHandle CreateRenderer(
        WindowHandle window,
        [NativeTypeName("const char *")] Ref<sbyte> name
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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateStorageDirectory")]
    byte CreateStorageDirectory(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* path
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateStorageDirectory")]
    MaybeBool<byte> CreateStorageDirectory(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurface")]
    Ptr<Surface> CreateSurface(int width, int height, PixelFormat format);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfaceFrom")]
    Surface* CreateSurfaceFrom(int width, int height, PixelFormat format, void* pixels, int pitch);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfaceFrom")]
    Ptr<Surface> CreateSurfaceFrom(
        int width,
        int height,
        PixelFormat format,
        Ref pixels,
        int pitch
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfacePalette")]
    Palette* CreateSurfacePalette(Surface* surface);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfacePalette")]
    Ptr<Palette> CreateSurfacePalette(Ref<Surface> surface);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurface")]
    Surface* CreateSurfaceRaw(int width, int height, PixelFormat format);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSystemCursor")]
    CursorHandle CreateSystemCursor(SystemCursor id);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTexture")]
    Ptr<Texture> CreateTexture(
        RendererHandle renderer,
        PixelFormat format,
        TextureAccess access,
        int w,
        int h
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureFromSurface")]
    Texture* CreateTextureFromSurface(RendererHandle renderer, Surface* surface);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureFromSurface")]
    Ptr<Texture> CreateTextureFromSurface(RendererHandle renderer, Ref<Surface> surface);

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTexture")]
    Texture* CreateTextureRaw(
        RendererHandle renderer,
        PixelFormat format,
        TextureAccess access,
        int w,
        int h
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureWithProperties")]
    Ptr<Texture> CreateTextureWithProperties(
        RendererHandle renderer,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureWithProperties")]
    Texture* CreateTextureWithPropertiesRaw(
        RendererHandle renderer,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadRuntime")]
    ThreadHandle CreateThreadRuntime(
        [NativeTypeName("SDL_ThreadFunction")] ThreadFunction fn,
        [NativeTypeName("const char *")] sbyte* name,
        void* data,
        [NativeTypeName("SDL_FunctionPointer")] FunctionPointer pfnBeginThread,
        [NativeTypeName("SDL_FunctionPointer")] FunctionPointer pfnEndThread
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadRuntime")]
    ThreadHandle CreateThreadRuntime(
        [NativeTypeName("SDL_ThreadFunction")] ThreadFunction fn,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        Ref data,
        [NativeTypeName("SDL_FunctionPointer")] FunctionPointer pfnBeginThread,
        [NativeTypeName("SDL_FunctionPointer")] FunctionPointer pfnEndThread
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadWithPropertiesRuntime")]
    ThreadHandle CreateThreadWithPropertiesRuntime(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("SDL_FunctionPointer")] FunctionPointer pfnBeginThread,
        [NativeTypeName("SDL_FunctionPointer")] FunctionPointer pfnEndThread
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindow")]
    WindowHandle CreateWindow(
        [NativeTypeName("const char *")] sbyte* title,
        int w,
        int h,
        [NativeTypeName("SDL_WindowFlags")] nuint flags
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindow")]
    WindowHandle CreateWindow(
        [NativeTypeName("const char *")] Ref<sbyte> title,
        int w,
        int h,
        [NativeTypeName("SDL_WindowFlags")] nuint flags
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowAndRenderer")]
    byte CreateWindowAndRenderer(
        [NativeTypeName("const char *")] sbyte* title,
        int width,
        int height,
        [NativeTypeName("SDL_WindowFlags")] nuint window_flags,
        WindowHandle* window,
        RendererHandle* renderer
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowAndRenderer")]
    MaybeBool<byte> CreateWindowAndRenderer(
        [NativeTypeName("const char *")] Ref<sbyte> title,
        int width,
        int height,
        [NativeTypeName("SDL_WindowFlags")] nuint window_flags,
        Ref<WindowHandle> window,
        Ref<RendererHandle> renderer
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowWithProperties")]
    WindowHandle CreateWindowWithProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_CursorVisible")]
    MaybeBool<byte> CursorVisible();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CursorVisible")]
    byte CursorVisibleRaw();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DateTimeToTime")]
    byte DateTimeToTime(
        [NativeTypeName("const SDL_DateTime *")] DateTime* dt,
        [NativeTypeName("SDL_Time *")] nint* ticks
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DateTimeToTime")]
    MaybeBool<byte> DateTimeToTime(
        [NativeTypeName("const SDL_DateTime *")] Ref<DateTime> dt,
        [NativeTypeName("SDL_Time *")] Ref<nint> ticks
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_Delay")]
    void Delay([NativeTypeName("Uint32")] uint ms);

    [NativeFunction("SDL3", EntryPoint = "SDL_DelayNS")]
    void DelayNS([NativeTypeName("Uint64")] nuint ns);

    [NativeFunction("SDL3", EntryPoint = "SDL_DelayPrecise")]
    void DelayPrecise([NativeTypeName("Uint64")] nuint ns);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyAudioStream")]
    void DestroyAudioStream(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyCondition")]
    void DestroyCondition(ConditionHandle cond);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyCursor")]
    void DestroyCursor(CursorHandle cursor);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyEnvironment")]
    void DestroyEnvironment(EnvironmentHandle env);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyGPUDevice")]
    void DestroyGPUDevice(GPUDeviceHandle device);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyHapticEffect")]
    void DestroyHapticEffect(HapticHandle haptic, int effect);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyMutex")]
    void DestroyMutex(MutexHandle mutex);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPalette")]
    void DestroyPalette(Palette* palette);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPalette")]
    void DestroyPalette(Ref<Palette> palette);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyProcess")]
    void DestroyProcess(ProcessHandle process);

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
    void DestroyTexture(Texture* texture);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyTexture")]
    void DestroyTexture(Ref<Texture> texture);

    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindow")]
    void DestroyWindow(WindowHandle window);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindowSurface")]
    MaybeBool<byte> DestroyWindowSurface(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindowSurface")]
    byte DestroyWindowSurfaceRaw(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_DetachThread")]
    void DetachThread(ThreadHandle thread);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DetachVirtualJoystick")]
    MaybeBool<byte> DetachVirtualJoystick([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DetachVirtualJoystick")]
    byte DetachVirtualJoystickRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DisableScreenSaver")]
    MaybeBool<byte> DisableScreenSaver();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DisableScreenSaver")]
    byte DisableScreenSaverRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_DispatchGPUCompute")]
    void DispatchGPUCompute(
        GPUComputePassHandle compute_pass,
        [NativeTypeName("Uint32")] uint groupcount_x,
        [NativeTypeName("Uint32")] uint groupcount_y,
        [NativeTypeName("Uint32")] uint groupcount_z
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_DispatchGPUComputeIndirect")]
    void DispatchGPUComputeIndirect(
        GPUComputePassHandle compute_pass,
        GPUBufferHandle buffer,
        [NativeTypeName("Uint32")] uint offset
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUBuffer")]
    void DownloadFromGPUBuffer(
        GPUCopyPassHandle copy_pass,
        [NativeTypeName("const SDL_GPUBufferRegion *")] GPUBufferRegion* source,
        [NativeTypeName("const SDL_GPUTransferBufferLocation *")]
            GPUTransferBufferLocation* destination
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUBuffer")]
    void DownloadFromGPUBuffer(
        GPUCopyPassHandle copy_pass,
        [NativeTypeName("const SDL_GPUBufferRegion *")] Ref<GPUBufferRegion> source,
        [NativeTypeName("const SDL_GPUTransferBufferLocation *")]
            Ref<GPUTransferBufferLocation> destination
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUTexture")]
    void DownloadFromGPUTexture(
        GPUCopyPassHandle copy_pass,
        [NativeTypeName("const SDL_GPUTextureRegion *")] GPUTextureRegion* source,
        [NativeTypeName("const SDL_GPUTextureTransferInfo *")] GPUTextureTransferInfo* destination
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUTexture")]
    void DownloadFromGPUTexture(
        GPUCopyPassHandle copy_pass,
        [NativeTypeName("const SDL_GPUTextureRegion *")] Ref<GPUTextureRegion> source,
        [NativeTypeName("const SDL_GPUTextureTransferInfo *")]
            Ref<GPUTextureTransferInfo> destination
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUIndexedPrimitives")]
    void DrawGPUIndexedPrimitives(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint num_indices,
        [NativeTypeName("Uint32")] uint num_instances,
        [NativeTypeName("Uint32")] uint first_index,
        [NativeTypeName("Sint32")] int vertex_offset,
        [NativeTypeName("Uint32")] uint first_instance
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUIndexedPrimitivesIndirect")]
    void DrawGPUIndexedPrimitivesIndirect(
        GPURenderPassHandle render_pass,
        GPUBufferHandle buffer,
        [NativeTypeName("Uint32")] uint offset,
        [NativeTypeName("Uint32")] uint draw_count
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUPrimitives")]
    void DrawGPUPrimitives(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint32")] uint num_vertices,
        [NativeTypeName("Uint32")] uint num_instances,
        [NativeTypeName("Uint32")] uint first_vertex,
        [NativeTypeName("Uint32")] uint first_instance
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUPrimitivesIndirect")]
    void DrawGPUPrimitivesIndirect(
        GPURenderPassHandle render_pass,
        GPUBufferHandle buffer,
        [NativeTypeName("Uint32")] uint offset,
        [NativeTypeName("Uint32")] uint draw_count
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_DuplicateSurface")]
    Surface* DuplicateSurface(Surface* surface);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_DuplicateSurface")]
    Ptr<Surface> DuplicateSurface(Ref<Surface> surface);

    [return: NativeTypeName("SDL_EGLConfig")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentConfig")]
    Ptr EGLGetCurrentConfig();

    [return: NativeTypeName("SDL_EGLConfig")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentConfig")]
    void* EGLGetCurrentConfigRaw();

    [return: NativeTypeName("SDL_EGLDisplay")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentDisplay")]
    Ptr EGLGetCurrentDisplay();

    [return: NativeTypeName("SDL_EGLDisplay")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentDisplay")]
    void* EGLGetCurrentDisplayRaw();

    [return: NativeTypeName("SDL_FunctionPointer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetProcAddress")]
    FunctionPointer EGLGetProcAddress([NativeTypeName("const char *")] sbyte* proc);

    [return: NativeTypeName("SDL_FunctionPointer")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetProcAddress")]
    FunctionPointer EGLGetProcAddress([NativeTypeName("const char *")] Ref<sbyte> proc);

    [return: NativeTypeName("SDL_EGLSurface")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetWindowSurface")]
    Ptr EGLGetWindowSurface(WindowHandle window);

    [return: NativeTypeName("SDL_EGLSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetWindowSurface")]
    void* EGLGetWindowSurfaceRaw(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_SetAttributeCallbacks")]
    void EGLSetAttributeCallbacks(
        [NativeTypeName("SDL_EGLAttribArrayCallback")]
            EGLAttribArrayCallback platformAttribCallback,
        [NativeTypeName("SDL_EGLIntArrayCallback")] EGLIntArrayCallback surfaceAttribCallback,
        [NativeTypeName("SDL_EGLIntArrayCallback")] EGLIntArrayCallback contextAttribCallback,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_SetAttributeCallbacks")]
    void EGLSetAttributeCallbacks(
        [NativeTypeName("SDL_EGLAttribArrayCallback")]
            EGLAttribArrayCallback platformAttribCallback,
        [NativeTypeName("SDL_EGLIntArrayCallback")] EGLIntArrayCallback surfaceAttribCallback,
        [NativeTypeName("SDL_EGLIntArrayCallback")] EGLIntArrayCallback contextAttribCallback,
        Ref userdata
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnableScreenSaver")]
    MaybeBool<byte> EnableScreenSaver();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnableScreenSaver")]
    byte EnableScreenSaverRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_EndGPUComputePass")]
    void EndGPUComputePass(GPUComputePassHandle compute_pass);

    [NativeFunction("SDL3", EntryPoint = "SDL_EndGPUCopyPass")]
    void EndGPUCopyPass(GPUCopyPassHandle copy_pass);

    [NativeFunction("SDL3", EntryPoint = "SDL_EndGPURenderPass")]
    void EndGPURenderPass(GPURenderPassHandle render_pass);

    [NativeFunction("SDL3", EntryPoint = "SDL_EnterAppMainCallbacks")]
    int EnterAppMainCallbacks(
        int argc,
        [NativeTypeName("char *[]")] sbyte** argv,
        [NativeTypeName("SDL_AppInit_func")] AppInitFunc appinit,
        [NativeTypeName("SDL_AppIterate_func")] AppIterateFunc appiter,
        [NativeTypeName("SDL_AppEvent_func")] AppEventFunc appevent,
        [NativeTypeName("SDL_AppQuit_func")] AppQuitFunc appquit
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnterAppMainCallbacks")]
    int EnterAppMainCallbacks(
        int argc,
        [NativeTypeName("char *[]")] Ref2D<sbyte> argv,
        [NativeTypeName("SDL_AppInit_func")] AppInitFunc appinit,
        [NativeTypeName("SDL_AppIterate_func")] AppIterateFunc appiter,
        [NativeTypeName("SDL_AppEvent_func")] AppEventFunc appevent,
        [NativeTypeName("SDL_AppQuit_func")] AppQuitFunc appquit
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateDirectory")]
    byte EnumerateDirectory(
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("SDL_EnumerateDirectoryCallback")] EnumerateDirectoryCallback callback,
        void* userdata
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateDirectory")]
    MaybeBool<byte> EnumerateDirectory(
        [NativeTypeName("const char *")] Ref<sbyte> path,
        [NativeTypeName("SDL_EnumerateDirectoryCallback")] EnumerateDirectoryCallback callback,
        Ref userdata
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateProperties")]
    byte EnumerateProperties(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("SDL_EnumeratePropertiesCallback")] EnumeratePropertiesCallback callback,
        void* userdata
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateProperties")]
    MaybeBool<byte> EnumerateProperties(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("SDL_EnumeratePropertiesCallback")] EnumeratePropertiesCallback callback,
        Ref userdata
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateStorageDirectory")]
    byte EnumerateStorageDirectory(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("SDL_EnumerateDirectoryCallback")] EnumerateDirectoryCallback callback,
        void* userdata
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateStorageDirectory")]
    MaybeBool<byte> EnumerateStorageDirectory(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path,
        [NativeTypeName("SDL_EnumerateDirectoryCallback")] EnumerateDirectoryCallback callback,
        Ref userdata
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_EventEnabled")]
    MaybeBool<byte> EventEnabled([NativeTypeName("Uint32")] uint type);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EventEnabled")]
    byte EventEnabledRaw([NativeTypeName("Uint32")] uint type);

    [NativeFunction("SDL3", EntryPoint = "SDL_exp")]
    double Exp(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_expf")]
    float Expf(float x);

    [NativeFunction("SDL3", EntryPoint = "SDL_fabs")]
    double Fabs(double x);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRect")]
    byte FillSurfaceRect(
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        [NativeTypeName("Uint32")] uint color
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRect")]
    MaybeBool<byte> FillSurfaceRect(
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        [NativeTypeName("Uint32")] uint color
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRects")]
    byte FillSurfaceRects(
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* rects,
        int count,
        [NativeTypeName("Uint32")] uint color
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRects")]
    MaybeBool<byte> FillSurfaceRects(
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rects,
        int count,
        [NativeTypeName("Uint32")] uint color
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_FilterEvents")]
    void FilterEvents([NativeTypeName("SDL_EventFilter")] EventFilter filter, void* userdata);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_FilterEvents")]
    void FilterEvents([NativeTypeName("SDL_EventFilter")] EventFilter filter, Ref userdata);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlashWindow")]
    MaybeBool<byte> FlashWindow(WindowHandle window, FlashOperation operation);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlashWindow")]
    byte FlashWindowRaw(WindowHandle window, FlashOperation operation);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlipSurface")]
    byte FlipSurface(Surface* surface, FlipMode flip);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlipSurface")]
    MaybeBool<byte> FlipSurface(Ref<Surface> surface, FlipMode flip);

    [NativeFunction("SDL3", EntryPoint = "SDL_floor")]
    double Floor(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_floorf")]
    float Floorf(float x);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlushAudioStream")]
    MaybeBool<byte> FlushAudioStream(AudioStreamHandle stream);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlushAudioStream")]
    byte FlushAudioStreamRaw(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_FlushEvent")]
    void FlushEvent([NativeTypeName("Uint32")] uint type);

    [NativeFunction("SDL3", EntryPoint = "SDL_FlushEvents")]
    void FlushEvents(
        [NativeTypeName("Uint32")] uint minType,
        [NativeTypeName("Uint32")] uint maxType
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlushIO")]
    MaybeBool<byte> FlushIO(IOStreamHandle context);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlushIO")]
    byte FlushIORaw(IOStreamHandle context);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlushRenderer")]
    MaybeBool<byte> FlushRenderer(RendererHandle renderer);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlushRenderer")]
    byte FlushRendererRaw(RendererHandle renderer);

    [NativeFunction("SDL3", EntryPoint = "SDL_fmod")]
    double Fmod(double x, double y);

    [NativeFunction("SDL3", EntryPoint = "SDL_fmodf")]
    float Fmodf(float x, float y);

    [NativeFunction("SDL3", EntryPoint = "SDL_free")]
    void Free(void* mem);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_free")]
    void Free(Ref mem);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadConnected")]
    MaybeBool<byte> GamepadConnected(GamepadHandle gamepad);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadConnected")]
    byte GamepadConnectedRaw(GamepadHandle gamepad);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadEventsEnabled")]
    MaybeBool<byte> GamepadEventsEnabled();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadEventsEnabled")]
    byte GamepadEventsEnabledRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasAxis")]
    MaybeBool<byte> GamepadHasAxis(GamepadHandle gamepad, GamepadAxis axis);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasAxis")]
    byte GamepadHasAxisRaw(GamepadHandle gamepad, GamepadAxis axis);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasButton")]
    MaybeBool<byte> GamepadHasButton(GamepadHandle gamepad, GamepadButton button);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasButton")]
    byte GamepadHasButtonRaw(GamepadHandle gamepad, GamepadButton button);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasSensor")]
    MaybeBool<byte> GamepadHasSensor(GamepadHandle gamepad, SensorType type);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasSensor")]
    byte GamepadHasSensorRaw(GamepadHandle gamepad, SensorType type);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadSensorEnabled")]
    MaybeBool<byte> GamepadSensorEnabled(GamepadHandle gamepad, SensorType type);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadSensorEnabled")]
    byte GamepadSensorEnabledRaw(GamepadHandle gamepad, SensorType type);

    [NativeFunction("SDL3", EntryPoint = "SDL_GDKSuspendComplete")]
    void GDKSuspendComplete();

    [NativeFunction("SDL3", EntryPoint = "SDL_GenerateMipmapsForGPUTexture")]
    void GenerateMipmapsForGPUTexture(
        GPUCommandBufferHandle command_buffer,
        GPUTextureHandle texture
    );

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAppMetadataProperty")]
    sbyte* GetAppMetadataProperty([NativeTypeName("const char *")] sbyte* name);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAppMetadataProperty")]
    Ptr<sbyte> GetAppMetadataProperty([NativeTypeName("const char *")] Ref<sbyte> name);

    [return: NativeTypeName("SDL_AssertionHandler")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionHandler")]
    AssertionHandler GetAssertionHandler(void** puserdata);

    [return: NativeTypeName("SDL_AssertionHandler")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionHandler")]
    AssertionHandler GetAssertionHandler(Ref2D puserdata);

    [return: NativeTypeName("const SDL_AssertData *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionReport")]
    Ptr<AssertData> GetAssertionReport();

    [return: NativeTypeName("const SDL_AssertData *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionReport")]
    AssertData* GetAssertionReportRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicInt")]
    int GetAtomicInt(AtomicInt* a);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicInt")]
    int GetAtomicInt(Ref<AtomicInt> a);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicPointer")]
    void* GetAtomicPointer(void** a);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicPointer")]
    Ptr GetAtomicPointer(Ref2D a);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicU32")]
    uint GetAtomicU32(AtomicU32* a);

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicU32")]
    uint GetAtomicU32(Ref<AtomicU32> a);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceChannelMap")]
    int* GetAudioDeviceChannelMap([NativeTypeName("SDL_AudioDeviceID")] uint devid, int* count);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceChannelMap")]
    Ptr<int> GetAudioDeviceChannelMap(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        Ref<int> count
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceFormat")]
    byte GetAudioDeviceFormat(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        AudioSpec* spec,
        int* sample_frames
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceFormat")]
    MaybeBool<byte> GetAudioDeviceFormat(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        Ref<AudioSpec> spec,
        Ref<int> sample_frames
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceGain")]
    float GetAudioDeviceGain([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceName")]
    Ptr<sbyte> GetAudioDeviceName([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceName")]
    sbyte* GetAudioDeviceNameRaw([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDriver")]
    Ptr<sbyte> GetAudioDriver(int index);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDriver")]
    sbyte* GetAudioDriverRaw(int index);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioFormatName")]
    Ptr<sbyte> GetAudioFormatName(AudioFormat format);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioFormatName")]
    sbyte* GetAudioFormatNameRaw(AudioFormat format);

    [return: NativeTypeName("SDL_AudioDeviceID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioPlaybackDevices")]
    uint* GetAudioPlaybackDevices(int* count);

    [return: NativeTypeName("SDL_AudioDeviceID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioPlaybackDevices")]
    Ptr<uint> GetAudioPlaybackDevices(Ref<int> count);

    [return: NativeTypeName("SDL_AudioDeviceID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioRecordingDevices")]
    uint* GetAudioRecordingDevices(int* count);

    [return: NativeTypeName("SDL_AudioDeviceID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioRecordingDevices")]
    Ptr<uint> GetAudioRecordingDevices(Ref<int> count);

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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFormat")]
    byte GetAudioStreamFormat(AudioStreamHandle stream, AudioSpec* src_spec, AudioSpec* dst_spec);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFormat")]
    MaybeBool<byte> GetAudioStreamFormat(
        AudioStreamHandle stream,
        Ref<AudioSpec> src_spec,
        Ref<AudioSpec> dst_spec
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFrequencyRatio")]
    float GetAudioStreamFrequencyRatio(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamGain")]
    float GetAudioStreamGain(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamInputChannelMap")]
    int* GetAudioStreamInputChannelMap(AudioStreamHandle stream, int* count);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamInputChannelMap")]
    Ptr<int> GetAudioStreamInputChannelMap(AudioStreamHandle stream, Ref<int> count);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamOutputChannelMap")]
    int* GetAudioStreamOutputChannelMap(AudioStreamHandle stream, int* count);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamOutputChannelMap")]
    Ptr<int> GetAudioStreamOutputChannelMap(AudioStreamHandle stream, Ref<int> count);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamProperties")]
    uint GetAudioStreamProperties(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamQueued")]
    int GetAudioStreamQueued(AudioStreamHandle stream);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetBasePath")]
    Ptr<sbyte> GetBasePath();

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetBasePath")]
    sbyte* GetBasePathRaw();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetBooleanProperty")]
    byte GetBooleanProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("bool")] byte default_value
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetBooleanProperty")]
    MaybeBool<byte> GetBooleanProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("bool")] MaybeBool<byte> default_value
    );

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDriver")]
    Ptr<sbyte> GetCameraDriver(int index);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDriver")]
    sbyte* GetCameraDriverRaw(int index);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraFormat")]
    byte GetCameraFormat(CameraHandle camera, CameraSpec* spec);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraFormat")]
    MaybeBool<byte> GetCameraFormat(CameraHandle camera, Ref<CameraSpec> spec);

    [return: NativeTypeName("SDL_CameraID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraID")]
    uint GetCameraID(CameraHandle camera);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraName")]
    Ptr<sbyte> GetCameraName([NativeTypeName("SDL_CameraID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraName")]
    sbyte* GetCameraNameRaw([NativeTypeName("SDL_CameraID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraPermissionState")]
    int GetCameraPermissionState(CameraHandle camera);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraPosition")]
    CameraPosition GetCameraPosition([NativeTypeName("SDL_CameraID")] uint instance_id);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraProperties")]
    uint GetCameraProperties(CameraHandle camera);

    [return: NativeTypeName("SDL_CameraID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameras")]
    uint* GetCameras(int* count);

    [return: NativeTypeName("SDL_CameraID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameras")]
    Ptr<uint> GetCameras(Ref<int> count);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraSupportedFormats")]
    CameraSpec** GetCameraSupportedFormats(
        [NativeTypeName("SDL_CameraID")] uint instance_id,
        int* count
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraSupportedFormats")]
    Ptr2D<CameraSpec> GetCameraSupportedFormats(
        [NativeTypeName("SDL_CameraID")] uint instance_id,
        Ref<int> count
    );

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

    [return: NativeTypeName("char **")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardMimeTypes")]
    sbyte** GetClipboardMimeTypes([NativeTypeName("size_t *")] nuint* num_mime_types);

    [return: NativeTypeName("char **")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardMimeTypes")]
    Ptr2D<sbyte> GetClipboardMimeTypes([NativeTypeName("size_t *")] Ref<nuint> num_mime_types);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardText")]
    Ptr<sbyte> GetClipboardText();

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardText")]
    sbyte* GetClipboardTextRaw();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
    byte GetClosestFullscreenDisplayMode(
        [NativeTypeName("SDL_DisplayID")] uint displayID,
        int w,
        int h,
        float refresh_rate,
        [NativeTypeName("bool")] byte include_high_density_modes,
        DisplayMode* closest
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
    MaybeBool<byte> GetClosestFullscreenDisplayMode(
        [NativeTypeName("SDL_DisplayID")] uint displayID,
        int w,
        int h,
        float refresh_rate,
        [NativeTypeName("bool")] MaybeBool<byte> include_high_density_modes,
        Ref<DisplayMode> closest
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCPUCacheLineSize")]
    int GetCPUCacheLineSize();

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

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDirectory")]
    Ptr<sbyte> GetCurrentDirectory();

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDirectory")]
    sbyte* GetCurrentDirectoryRaw();

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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentRenderOutputSize")]
    byte GetCurrentRenderOutputSize(RendererHandle renderer, int* w, int* h);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentRenderOutputSize")]
    MaybeBool<byte> GetCurrentRenderOutputSize(RendererHandle renderer, Ref<int> w, Ref<int> h);

    [return: NativeTypeName("SDL_ThreadID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentThreadID")]
    nuint GetCurrentThreadID();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentTime")]
    byte GetCurrentTime([NativeTypeName("SDL_Time *")] nint* ticks);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentTime")]
    MaybeBool<byte> GetCurrentTime([NativeTypeName("SDL_Time *")] Ref<nint> ticks);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentVideoDriver")]
    Ptr<sbyte> GetCurrentVideoDriver();

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentVideoDriver")]
    sbyte* GetCurrentVideoDriverRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetCursor")]
    CursorHandle GetCursor();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDateTimeLocalePreferences")]
    byte GetDateTimeLocalePreferences(DateFormat* dateFormat, TimeFormat* timeFormat);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDateTimeLocalePreferences")]
    MaybeBool<byte> GetDateTimeLocalePreferences(
        Ref<DateFormat> dateFormat,
        Ref<TimeFormat> timeFormat
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetDayOfWeek")]
    int GetDayOfWeek(int year, int month, int day);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetDayOfYear")]
    int GetDayOfYear(int year, int month, int day);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetDaysInMonth")]
    int GetDaysInMonth(int year, int month);

    [return: NativeTypeName("SDL_AssertionHandler")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultAssertionHandler")]
    AssertionHandler GetDefaultAssertionHandler();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultCursor")]
    CursorHandle GetDefaultCursor();

    [return: NativeTypeName("SDL_LogOutputFunction")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultLogOutputFunction")]
    LogOutputFunction GetDefaultLogOutputFunction();

    [return: NativeTypeName("const SDL_DisplayMode *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDesktopDisplayMode")]
    Ptr<DisplayMode> GetDesktopDisplayMode([NativeTypeName("SDL_DisplayID")] uint displayID);

    [return: NativeTypeName("const SDL_DisplayMode *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDesktopDisplayMode")]
    DisplayMode* GetDesktopDisplayModeRaw([NativeTypeName("SDL_DisplayID")] uint displayID);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayBounds")]
    byte GetDisplayBounds([NativeTypeName("SDL_DisplayID")] uint displayID, Rect* rect);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayBounds")]
    MaybeBool<byte> GetDisplayBounds(
        [NativeTypeName("SDL_DisplayID")] uint displayID,
        Ref<Rect> rect
    );

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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayUsableBounds")]
    byte GetDisplayUsableBounds([NativeTypeName("SDL_DisplayID")] uint displayID, Rect* rect);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayUsableBounds")]
    MaybeBool<byte> GetDisplayUsableBounds(
        [NativeTypeName("SDL_DisplayID")] uint displayID,
        Ref<Rect> rect
    );

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_getenv")]
    sbyte* Getenv([NativeTypeName("const char *")] sbyte* name);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_getenv")]
    Ptr<sbyte> Getenv([NativeTypeName("const char *")] Ref<sbyte> name);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_getenv_unsafe")]
    sbyte* GetenvUnsafe([NativeTypeName("const char *")] sbyte* name);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_getenv_unsafe")]
    Ptr<sbyte> GetenvUnsafe([NativeTypeName("const char *")] Ref<sbyte> name);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironment")]
    EnvironmentHandle GetEnvironment();

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariable")]
    sbyte* GetEnvironmentVariable(
        EnvironmentHandle env,
        [NativeTypeName("const char *")] sbyte* name
    );

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariable")]
    Ptr<sbyte> GetEnvironmentVariable(
        EnvironmentHandle env,
        [NativeTypeName("const char *")] Ref<sbyte> name
    );

    [return: NativeTypeName("char **")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariables")]
    Ptr2D<sbyte> GetEnvironmentVariables(EnvironmentHandle env);

    [return: NativeTypeName("char **")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariables")]
    sbyte** GetEnvironmentVariablesRaw(EnvironmentHandle env);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetError")]
    Ptr<sbyte> GetError();

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetError")]
    sbyte* GetErrorRaw();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEventFilter")]
    byte GetEventFilter([NativeTypeName("SDL_EventFilter *")] EventFilter* filter, void** userdata);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEventFilter")]
    MaybeBool<byte> GetEventFilter(
        [NativeTypeName("SDL_EventFilter *")] Ref<EventFilter> filter,
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

    [NativeFunction("SDL3", EntryPoint = "SDL_GetFullscreenDisplayModes")]
    DisplayMode** GetFullscreenDisplayModes(
        [NativeTypeName("SDL_DisplayID")] uint displayID,
        int* count
    );

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

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButton")]
    MaybeBool<byte> GetGamepadButton(GamepadHandle gamepad, GamepadButton button);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonFromString")]
    GamepadButton GetGamepadButtonFromString([NativeTypeName("const char *")] sbyte* str);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonFromString")]
    GamepadButton GetGamepadButtonFromString([NativeTypeName("const char *")] Ref<sbyte> str);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonLabel")]
    GamepadButtonLabel GetGamepadButtonLabel(GamepadHandle gamepad, GamepadButton button);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonLabelForType")]
    GamepadButtonLabel GetGamepadButtonLabelForType(GamepadType type, GamepadButton button);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButton")]
    byte GetGamepadButtonRaw(GamepadHandle gamepad, GamepadButton button);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadConnectionState")]
    JoystickConnectionState GetGamepadConnectionState(GamepadHandle gamepad);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFirmwareVersion")]
    ushort GetGamepadFirmwareVersion(GamepadHandle gamepad);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFromID")]
    GamepadHandle GetGamepadFromID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFromPlayerIndex")]
    GamepadHandle GetGamepadFromPlayerIndex(int player_index);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadGUIDForID")]
    Guid GetGamepadGuidForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("SDL_JoystickID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadID")]
    uint GetGamepadID(GamepadHandle gamepad);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadJoystick")]
    JoystickHandle GetGamepadJoystick(GamepadHandle gamepad);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMapping")]
    Ptr<sbyte> GetGamepadMapping(GamepadHandle gamepad);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForGUID")]
    Ptr<sbyte> GetGamepadMappingForGuid(Guid guid);

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForGUID")]
    sbyte* GetGamepadMappingForGuidRaw(Guid guid);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForID")]
    Ptr<sbyte> GetGamepadMappingForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForID")]
    sbyte* GetGamepadMappingForIDRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

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
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadNameForID")]
    Ptr<sbyte> GetGamepadNameForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadNameForID")]
    sbyte* GetGamepadNameForIDRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadName")]
    sbyte* GetGamepadNameRaw(GamepadHandle gamepad);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPath")]
    Ptr<sbyte> GetGamepadPath(GamepadHandle gamepad);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPathForID")]
    Ptr<sbyte> GetGamepadPathForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPathForID")]
    sbyte* GetGamepadPathForIDRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPath")]
    sbyte* GetGamepadPathRaw(GamepadHandle gamepad);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPlayerIndex")]
    int GetGamepadPlayerIndex(GamepadHandle gamepad);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPlayerIndexForID")]
    int GetGamepadPlayerIndexForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPowerInfo")]
    PowerState GetGamepadPowerInfo(GamepadHandle gamepad, int* percent);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPowerInfo")]
    PowerState GetGamepadPowerInfo(GamepadHandle gamepad, Ref<int> percent);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProduct")]
    ushort GetGamepadProduct(GamepadHandle gamepad);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProductForID")]
    ushort GetGamepadProductForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProductVersion")]
    ushort GetGamepadProductVersion(GamepadHandle gamepad);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProductVersionForID")]
    ushort GetGamepadProductVersionForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorData")]
    byte GetGamepadSensorData(GamepadHandle gamepad, SensorType type, float* data, int num_values);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorData")]
    MaybeBool<byte> GetGamepadSensorData(
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
    nuint GetGamepadSteamHandle(GamepadHandle gamepad);

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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTouchpadFinger")]
    byte GetGamepadTouchpadFinger(
        GamepadHandle gamepad,
        int touchpad,
        int finger,
        bool* down,
        float* x,
        float* y,
        float* pressure
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTouchpadFinger")]
    MaybeBool<byte> GetGamepadTouchpadFinger(
        GamepadHandle gamepad,
        int touchpad,
        int finger,
        Ref<bool> down,
        Ref<float> x,
        Ref<float> y,
        Ref<float> pressure
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadType")]
    GamepadType GetGamepadType(GamepadHandle gamepad);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTypeForID")]
    GamepadType GetGamepadTypeForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTypeFromString")]
    GamepadType GetGamepadTypeFromString([NativeTypeName("const char *")] sbyte* str);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTypeFromString")]
    GamepadType GetGamepadTypeFromString([NativeTypeName("const char *")] Ref<sbyte> str);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadVendor")]
    ushort GetGamepadVendor(GamepadHandle gamepad);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadVendorForID")]
    ushort GetGamepadVendorForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("SDL_MouseButtonFlags")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalMouseState")]
    uint GetGlobalMouseState(float* x, float* y);

    [return: NativeTypeName("SDL_MouseButtonFlags")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalMouseState")]
    uint GetGlobalMouseState(Ref<float> x, Ref<float> y);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalProperties")]
    uint GetGlobalProperties();

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDeviceDriver")]
    Ptr<sbyte> GetGPUDeviceDriver(GPUDeviceHandle device);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDeviceDriver")]
    sbyte* GetGPUDeviceDriverRaw(GPUDeviceHandle device);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDriver")]
    Ptr<sbyte> GetGPUDriver(int index);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDriver")]
    sbyte* GetGPUDriverRaw(int index);

    [return: NativeTypeName("SDL_GPUShaderFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUShaderFormats")]
    uint GetGPUShaderFormats(GPUDeviceHandle device);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUSwapchainTextureFormat")]
    GPUTextureFormat GetGPUSwapchainTextureFormat(GPUDeviceHandle device, WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetGrabbedWindow")]
    WindowHandle GetGrabbedWindow();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticEffectStatus")]
    MaybeBool<byte> GetHapticEffectStatus(HapticHandle haptic, int effect);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticEffectStatus")]
    byte GetHapticEffectStatusRaw(HapticHandle haptic, int effect);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticFeatures")]
    uint GetHapticFeatures(HapticHandle haptic);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticFromID")]
    HapticHandle GetHapticFromID([NativeTypeName("SDL_HapticID")] uint instance_id);

    [return: NativeTypeName("SDL_HapticID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticID")]
    uint GetHapticID(HapticHandle haptic);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticName")]
    Ptr<sbyte> GetHapticName(HapticHandle haptic);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticNameForID")]
    Ptr<sbyte> GetHapticNameForID([NativeTypeName("SDL_HapticID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticNameForID")]
    sbyte* GetHapticNameForIDRaw([NativeTypeName("SDL_HapticID")] uint instance_id);

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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHintBoolean")]
    byte GetHintBoolean(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("bool")] byte default_value
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHintBoolean")]
    MaybeBool<byte> GetHintBoolean(
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("bool")] MaybeBool<byte> default_value
    );

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetIOProperties")]
    uint GetIOProperties(IOStreamHandle context);

    [return: NativeTypeName("Sint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetIOSize")]
    nint GetIOSize(IOStreamHandle context);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetIOStatus")]
    IOStatus GetIOStatus(IOStreamHandle context);

    [return: NativeTypeName("Sint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxis")]
    short GetJoystickAxis(JoystickHandle joystick, int axis);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxisInitialState")]
    byte GetJoystickAxisInitialState(
        JoystickHandle joystick,
        int axis,
        [NativeTypeName("Sint16 *")] short* state
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxisInitialState")]
    MaybeBool<byte> GetJoystickAxisInitialState(
        JoystickHandle joystick,
        int axis,
        [NativeTypeName("Sint16 *")] Ref<short> state
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickBall")]
    byte GetJoystickBall(JoystickHandle joystick, int ball, int* dx, int* dy);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickBall")]
    MaybeBool<byte> GetJoystickBall(JoystickHandle joystick, int ball, Ref<int> dx, Ref<int> dy);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickButton")]
    MaybeBool<byte> GetJoystickButton(JoystickHandle joystick, int button);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickButton")]
    byte GetJoystickButtonRaw(JoystickHandle joystick, int button);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickConnectionState")]
    JoystickConnectionState GetJoystickConnectionState(JoystickHandle joystick);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFirmwareVersion")]
    ushort GetJoystickFirmwareVersion(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFromID")]
    JoystickHandle GetJoystickFromID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFromPlayerIndex")]
    JoystickHandle GetJoystickFromPlayerIndex(int player_index);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUID")]
    Guid GetJoystickGuid(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDForID")]
    Guid GetJoystickGuidForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDInfo")]
    void GetJoystickGuidInfo(
        Guid guid,
        [NativeTypeName("Uint16 *")] ushort* vendor,
        [NativeTypeName("Uint16 *")] ushort* product,
        [NativeTypeName("Uint16 *")] ushort* version,
        [NativeTypeName("Uint16 *")] ushort* crc16
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDInfo")]
    void GetJoystickGuidInfo(
        Guid guid,
        [NativeTypeName("Uint16 *")] Ref<ushort> vendor,
        [NativeTypeName("Uint16 *")] Ref<ushort> product,
        [NativeTypeName("Uint16 *")] Ref<ushort> version,
        [NativeTypeName("Uint16 *")] Ref<ushort> crc16
    );

    [return: NativeTypeName("Uint8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickHat")]
    byte GetJoystickHat(JoystickHandle joystick, int hat);

    [return: NativeTypeName("SDL_JoystickID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickID")]
    uint GetJoystickID(JoystickHandle joystick);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickName")]
    Ptr<sbyte> GetJoystickName(JoystickHandle joystick);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickNameForID")]
    Ptr<sbyte> GetJoystickNameForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickNameForID")]
    sbyte* GetJoystickNameForIDRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickName")]
    sbyte* GetJoystickNameRaw(JoystickHandle joystick);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPath")]
    Ptr<sbyte> GetJoystickPath(JoystickHandle joystick);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPathForID")]
    Ptr<sbyte> GetJoystickPathForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPathForID")]
    sbyte* GetJoystickPathForIDRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPath")]
    sbyte* GetJoystickPathRaw(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPlayerIndex")]
    int GetJoystickPlayerIndex(JoystickHandle joystick);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPlayerIndexForID")]
    int GetJoystickPlayerIndexForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPowerInfo")]
    PowerState GetJoystickPowerInfo(JoystickHandle joystick, int* percent);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPowerInfo")]
    PowerState GetJoystickPowerInfo(JoystickHandle joystick, Ref<int> percent);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProduct")]
    ushort GetJoystickProduct(JoystickHandle joystick);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProductForID")]
    ushort GetJoystickProductForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProductVersion")]
    ushort GetJoystickProductVersion(JoystickHandle joystick);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProductVersionForID")]
    ushort GetJoystickProductVersionForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

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

    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickTypeForID")]
    JoystickType GetJoystickTypeForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickVendor")]
    ushort GetJoystickVendor(JoystickHandle joystick);

    [return: NativeTypeName("Uint16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickVendorForID")]
    ushort GetJoystickVendorForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardFocus")]
    WindowHandle GetKeyboardFocus();

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardNameForID")]
    Ptr<sbyte> GetKeyboardNameForID([NativeTypeName("SDL_KeyboardID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardNameForID")]
    sbyte* GetKeyboardNameForIDRaw([NativeTypeName("SDL_KeyboardID")] uint instance_id);

    [return: NativeTypeName("SDL_KeyboardID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboards")]
    uint* GetKeyboards(int* count);

    [return: NativeTypeName("SDL_KeyboardID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboards")]
    Ptr<uint> GetKeyboards(Ref<int> count);

    [return: NativeTypeName("const bool *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardState")]
    bool* GetKeyboardState(int* numkeys);

    [return: NativeTypeName("const bool *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardState")]
    Ptr<bool> GetKeyboardState(Ref<int> numkeys);

    [return: NativeTypeName("SDL_Keycode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromName")]
    uint GetKeyFromName([NativeTypeName("const char *")] sbyte* name);

    [return: NativeTypeName("SDL_Keycode")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromName")]
    uint GetKeyFromName([NativeTypeName("const char *")] Ref<sbyte> name);

    [return: NativeTypeName("SDL_Keycode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromScancode")]
    uint GetKeyFromScancode(
        Scancode scancode,
        [NativeTypeName("SDL_Keymod")] ushort modstate,
        [NativeTypeName("bool")] byte key_event
    );

    [return: NativeTypeName("SDL_Keycode")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromScancode")]
    uint GetKeyFromScancode(
        Scancode scancode,
        [NativeTypeName("SDL_Keymod")] ushort modstate,
        [NativeTypeName("bool")] MaybeBool<byte> key_event
    );

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyName")]
    Ptr<sbyte> GetKeyName([NativeTypeName("SDL_Keycode")] uint key);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyName")]
    sbyte* GetKeyNameRaw([NativeTypeName("SDL_Keycode")] uint key);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetLogOutputFunction")]
    void GetLogOutputFunction(
        [NativeTypeName("SDL_LogOutputFunction *")] LogOutputFunction* callback,
        void** userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetLogOutputFunction")]
    void GetLogOutputFunction(
        [NativeTypeName("SDL_LogOutputFunction *")] Ref<LogOutputFunction> callback,
        Ref2D userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetLogPriority")]
    LogPriority GetLogPriority(int category);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMasksForPixelFormat")]
    byte GetMasksForPixelFormat(
        PixelFormat format,
        int* bpp,
        [NativeTypeName("Uint32 *")] uint* Rmask,
        [NativeTypeName("Uint32 *")] uint* Gmask,
        [NativeTypeName("Uint32 *")] uint* Bmask,
        [NativeTypeName("Uint32 *")] uint* Amask
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMasksForPixelFormat")]
    MaybeBool<byte> GetMasksForPixelFormat(
        PixelFormat format,
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

    [NativeFunction("SDL3", EntryPoint = "SDL_GetMemoryFunctions")]
    void GetMemoryFunctions(
        [NativeTypeName("SDL_malloc_func *")] MallocFunc* malloc_func,
        [NativeTypeName("SDL_calloc_func *")] CallocFunc* calloc_func,
        [NativeTypeName("SDL_realloc_func *")] ReallocFunc* realloc_func,
        [NativeTypeName("SDL_free_func *")] FreeFunc* free_func
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMemoryFunctions")]
    void GetMemoryFunctions(
        [NativeTypeName("SDL_malloc_func *")] Ref<MallocFunc> malloc_func,
        [NativeTypeName("SDL_calloc_func *")] Ref<CallocFunc> calloc_func,
        [NativeTypeName("SDL_realloc_func *")] Ref<ReallocFunc> realloc_func,
        [NativeTypeName("SDL_free_func *")] Ref<FreeFunc> free_func
    );

    [return: NativeTypeName("SDL_MouseID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMice")]
    uint* GetMice(int* count);

    [return: NativeTypeName("SDL_MouseID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMice")]
    Ptr<uint> GetMice(Ref<int> count);

    [return: NativeTypeName("SDL_Keymod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetModState")]
    ushort GetModState();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseFocus")]
    WindowHandle GetMouseFocus();

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseNameForID")]
    Ptr<sbyte> GetMouseNameForID([NativeTypeName("SDL_MouseID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseNameForID")]
    sbyte* GetMouseNameForIDRaw([NativeTypeName("SDL_MouseID")] uint instance_id);

    [return: NativeTypeName("SDL_MouseButtonFlags")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseState")]
    uint GetMouseState(float* x, float* y);

    [return: NativeTypeName("SDL_MouseButtonFlags")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseState")]
    uint GetMouseState(Ref<float> x, Ref<float> y);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNaturalDisplayOrientation")]
    DisplayOrientation GetNaturalDisplayOrientation(
        [NativeTypeName("SDL_DisplayID")] uint displayID
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumAllocations")]
    int GetNumAllocations();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumAudioDrivers")]
    int GetNumAudioDrivers();

    [return: NativeTypeName("Sint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumberProperty")]
    nint GetNumberProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("Sint64")] nint default_value
    );

    [return: NativeTypeName("Sint64")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumberProperty")]
    nint GetNumberProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("Sint64")] nint default_value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumCameraDrivers")]
    int GetNumCameraDrivers();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGamepadTouchpadFingers")]
    int GetNumGamepadTouchpadFingers(GamepadHandle gamepad, int touchpad);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGamepadTouchpads")]
    int GetNumGamepadTouchpads(GamepadHandle gamepad);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGPUDrivers")]
    int GetNumGPUDrivers();

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

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumLogicalCPUCores")]
    int GetNumLogicalCPUCores();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumRenderDrivers")]
    int GetNumRenderDrivers();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumVideoDrivers")]
    int GetNumVideoDrivers();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetOriginalMemoryFunctions")]
    void GetOriginalMemoryFunctions(
        [NativeTypeName("SDL_malloc_func *")] MallocFunc* malloc_func,
        [NativeTypeName("SDL_calloc_func *")] CallocFunc* calloc_func,
        [NativeTypeName("SDL_realloc_func *")] ReallocFunc* realloc_func,
        [NativeTypeName("SDL_free_func *")] FreeFunc* free_func
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetOriginalMemoryFunctions")]
    void GetOriginalMemoryFunctions(
        [NativeTypeName("SDL_malloc_func *")] Ref<MallocFunc> malloc_func,
        [NativeTypeName("SDL_calloc_func *")] Ref<CallocFunc> calloc_func,
        [NativeTypeName("SDL_realloc_func *")] Ref<ReallocFunc> realloc_func,
        [NativeTypeName("SDL_free_func *")] Ref<FreeFunc> free_func
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPathInfo")]
    byte GetPathInfo([NativeTypeName("const char *")] sbyte* path, PathInfo* info);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPathInfo")]
    MaybeBool<byte> GetPathInfo(
        [NativeTypeName("const char *")] Ref<sbyte> path,
        Ref<PathInfo> info
    );

    [return: NativeTypeName("Uint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPerformanceCounter")]
    nuint GetPerformanceCounter();

    [return: NativeTypeName("Uint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPerformanceFrequency")]
    nuint GetPerformanceFrequency();

    [return: NativeTypeName("const SDL_PixelFormatDetails *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatDetails")]
    Ptr<PixelFormatDetails> GetPixelFormatDetails(PixelFormat format);

    [return: NativeTypeName("const SDL_PixelFormatDetails *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatDetails")]
    PixelFormatDetails* GetPixelFormatDetailsRaw(PixelFormat format);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatForMasks")]
    PixelFormat GetPixelFormatForMasks(
        int bpp,
        [NativeTypeName("Uint32")] uint Rmask,
        [NativeTypeName("Uint32")] uint Gmask,
        [NativeTypeName("Uint32")] uint Bmask,
        [NativeTypeName("Uint32")] uint Amask
    );

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatName")]
    Ptr<sbyte> GetPixelFormatName(PixelFormat format);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatName")]
    sbyte* GetPixelFormatNameRaw(PixelFormat format);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPlatform")]
    Ptr<sbyte> GetPlatform();

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPlatform")]
    sbyte* GetPlatformRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetPointerProperty")]
    void* GetPointerProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        void* default_value
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPointerProperty")]
    Ptr GetPointerProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        Ref default_value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetPowerInfo")]
    PowerState GetPowerInfo(int* seconds, int* percent);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPowerInfo")]
    PowerState GetPowerInfo(Ref<int> seconds, Ref<int> percent);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetPreferredLocales")]
    Locale** GetPreferredLocales(int* count);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPreferredLocales")]
    Ptr2D<Locale> GetPreferredLocales(Ref<int> count);

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

    [NativeFunction("SDL3", EntryPoint = "SDL_GetProcessInput")]
    IOStreamHandle GetProcessInput(ProcessHandle process);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetProcessOutput")]
    IOStreamHandle GetProcessOutput(ProcessHandle process);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetProcessProperties")]
    uint GetProcessProperties(ProcessHandle process);

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

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRealGamepadType")]
    GamepadType GetRealGamepadType(GamepadHandle gamepad);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRealGamepadTypeForID")]
    GamepadType GetRealGamepadTypeForID([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersection")]
    byte GetRectAndLineIntersection(
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        int* X1,
        int* Y1,
        int* X2,
        int* Y2
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersection")]
    MaybeBool<byte> GetRectAndLineIntersection(
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        Ref<int> X1,
        Ref<int> Y1,
        Ref<int> X2,
        Ref<int> Y2
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersectionFloat")]
    byte GetRectAndLineIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] FRect* rect,
        float* X1,
        float* Y1,
        float* X2,
        float* Y2
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersectionFloat")]
    MaybeBool<byte> GetRectAndLineIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> rect,
        Ref<float> X1,
        Ref<float> Y1,
        Ref<float> X2,
        Ref<float> Y2
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPoints")]
    byte GetRectEnclosingPoints(
        [NativeTypeName("const SDL_Point *")] Point* points,
        int count,
        [NativeTypeName("const SDL_Rect *")] Rect* clip,
        Rect* result
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPoints")]
    MaybeBool<byte> GetRectEnclosingPoints(
        [NativeTypeName("const SDL_Point *")] Ref<Point> points,
        int count,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> clip,
        Ref<Rect> result
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
    byte GetRectEnclosingPointsFloat(
        [NativeTypeName("const SDL_FPoint *")] FPoint* points,
        int count,
        [NativeTypeName("const SDL_FRect *")] FRect* clip,
        FRect* result
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
    MaybeBool<byte> GetRectEnclosingPointsFloat(
        [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> points,
        int count,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> clip,
        Ref<FRect> result
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersection")]
    byte GetRectIntersection(
        [NativeTypeName("const SDL_Rect *")] Rect* A,
        [NativeTypeName("const SDL_Rect *")] Rect* B,
        Rect* result
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersection")]
    MaybeBool<byte> GetRectIntersection(
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> A,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> B,
        Ref<Rect> result
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersectionFloat")]
    byte GetRectIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] FRect* A,
        [NativeTypeName("const SDL_FRect *")] FRect* B,
        FRect* result
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersectionFloat")]
    MaybeBool<byte> GetRectIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> A,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> B,
        Ref<FRect> result
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnion")]
    byte GetRectUnion(
        [NativeTypeName("const SDL_Rect *")] Rect* A,
        [NativeTypeName("const SDL_Rect *")] Rect* B,
        Rect* result
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnion")]
    MaybeBool<byte> GetRectUnion(
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> A,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> B,
        Ref<Rect> result
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnionFloat")]
    byte GetRectUnionFloat(
        [NativeTypeName("const SDL_FRect *")] FRect* A,
        [NativeTypeName("const SDL_FRect *")] FRect* B,
        FRect* result
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnionFloat")]
    MaybeBool<byte> GetRectUnionFloat(
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> A,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> B,
        Ref<FRect> result
    );

    [return: NativeTypeName("SDL_MouseButtonFlags")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseState")]
    uint GetRelativeMouseState(float* x, float* y);

    [return: NativeTypeName("SDL_MouseButtonFlags")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseState")]
    uint GetRelativeMouseState(Ref<float> x, Ref<float> y);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderClipRect")]
    byte GetRenderClipRect(RendererHandle renderer, Rect* rect);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderClipRect")]
    MaybeBool<byte> GetRenderClipRect(RendererHandle renderer, Ref<Rect> rect);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderColorScale")]
    byte GetRenderColorScale(RendererHandle renderer, float* scale);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderColorScale")]
    MaybeBool<byte> GetRenderColorScale(RendererHandle renderer, Ref<float> scale);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawBlendMode")]
    byte GetRenderDrawBlendMode(
        RendererHandle renderer,
        [NativeTypeName("SDL_BlendMode *")] BlendMode* blendMode
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawBlendMode")]
    MaybeBool<byte> GetRenderDrawBlendMode(
        RendererHandle renderer,
        [NativeTypeName("SDL_BlendMode *")] Ref<BlendMode> blendMode
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColor")]
    byte GetRenderDrawColor(
        RendererHandle renderer,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b,
        [NativeTypeName("Uint8 *")] byte* a
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColor")]
    MaybeBool<byte> GetRenderDrawColor(
        RendererHandle renderer,
        [NativeTypeName("Uint8 *")] Ref<byte> r,
        [NativeTypeName("Uint8 *")] Ref<byte> g,
        [NativeTypeName("Uint8 *")] Ref<byte> b,
        [NativeTypeName("Uint8 *")] Ref<byte> a
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColorFloat")]
    byte GetRenderDrawColorFloat(RendererHandle renderer, float* r, float* g, float* b, float* a);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColorFloat")]
    MaybeBool<byte> GetRenderDrawColorFloat(
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
    RendererHandle GetRendererFromTexture(Texture* texture);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererFromTexture")]
    RendererHandle GetRendererFromTexture(Ref<Texture> texture);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererName")]
    Ptr<sbyte> GetRendererName(RendererHandle renderer);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererName")]
    sbyte* GetRendererNameRaw(RendererHandle renderer);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererProperties")]
    uint GetRendererProperties(RendererHandle renderer);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentation")]
    byte GetRenderLogicalPresentation(
        RendererHandle renderer,
        int* w,
        int* h,
        RendererLogicalPresentation* mode
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentation")]
    MaybeBool<byte> GetRenderLogicalPresentation(
        RendererHandle renderer,
        Ref<int> w,
        Ref<int> h,
        Ref<RendererLogicalPresentation> mode
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentationRect")]
    byte GetRenderLogicalPresentationRect(RendererHandle renderer, FRect* rect);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentationRect")]
    MaybeBool<byte> GetRenderLogicalPresentationRect(RendererHandle renderer, Ref<FRect> rect);

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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderOutputSize")]
    byte GetRenderOutputSize(RendererHandle renderer, int* w, int* h);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderOutputSize")]
    MaybeBool<byte> GetRenderOutputSize(RendererHandle renderer, Ref<int> w, Ref<int> h);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderSafeArea")]
    byte GetRenderSafeArea(RendererHandle renderer, Rect* rect);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderSafeArea")]
    MaybeBool<byte> GetRenderSafeArea(RendererHandle renderer, Ref<Rect> rect);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderScale")]
    byte GetRenderScale(RendererHandle renderer, float* scaleX, float* scaleY);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderScale")]
    MaybeBool<byte> GetRenderScale(RendererHandle renderer, Ref<float> scaleX, Ref<float> scaleY);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderTarget")]
    Ptr<Texture> GetRenderTarget(RendererHandle renderer);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderTarget")]
    Texture* GetRenderTargetRaw(RendererHandle renderer);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderViewport")]
    byte GetRenderViewport(RendererHandle renderer, Rect* rect);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderViewport")]
    MaybeBool<byte> GetRenderViewport(RendererHandle renderer, Ref<Rect> rect);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderVSync")]
    byte GetRenderVSync(RendererHandle renderer, int* vsync);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderVSync")]
    MaybeBool<byte> GetRenderVSync(RendererHandle renderer, Ref<int> vsync);

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
        [NativeTypeName("const SDL_PixelFormatDetails *")] PixelFormatDetails* format,
        [NativeTypeName("const SDL_Palette *")] Palette* palette,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRGB")]
    void GetRGB(
        [NativeTypeName("Uint32")] uint pixel,
        [NativeTypeName("const SDL_PixelFormatDetails *")] Ref<PixelFormatDetails> format,
        [NativeTypeName("const SDL_Palette *")] Ref<Palette> palette,
        [NativeTypeName("Uint8 *")] Ref<byte> r,
        [NativeTypeName("Uint8 *")] Ref<byte> g,
        [NativeTypeName("Uint8 *")] Ref<byte> b
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetRGBA")]
    void GetRgba(
        [NativeTypeName("Uint32")] uint pixel,
        [NativeTypeName("const SDL_PixelFormatDetails *")] PixelFormatDetails* format,
        [NativeTypeName("const SDL_Palette *")] Palette* palette,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b,
        [NativeTypeName("Uint8 *")] byte* a
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRGBA")]
    void GetRgba(
        [NativeTypeName("Uint32")] uint pixel,
        [NativeTypeName("const SDL_PixelFormatDetails *")] Ref<PixelFormatDetails> format,
        [NativeTypeName("const SDL_Palette *")] Ref<Palette> palette,
        [NativeTypeName("Uint8 *")] Ref<byte> r,
        [NativeTypeName("Uint8 *")] Ref<byte> g,
        [NativeTypeName("Uint8 *")] Ref<byte> b,
        [NativeTypeName("Uint8 *")] Ref<byte> a
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSandbox")]
    Sandbox GetSandbox();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromKey")]
    Scancode GetScancodeFromKey(
        [NativeTypeName("SDL_Keycode")] uint key,
        [NativeTypeName("SDL_Keymod *")] ushort* modstate
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromKey")]
    Scancode GetScancodeFromKey(
        [NativeTypeName("SDL_Keycode")] uint key,
        [NativeTypeName("SDL_Keymod *")] Ref<ushort> modstate
    );

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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorData")]
    byte GetSensorData(SensorHandle sensor, float* data, int num_values);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorData")]
    MaybeBool<byte> GetSensorData(SensorHandle sensor, Ref<float> data, int num_values);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorFromID")]
    SensorHandle GetSensorFromID([NativeTypeName("SDL_SensorID")] uint instance_id);

    [return: NativeTypeName("SDL_SensorID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorID")]
    uint GetSensorID(SensorHandle sensor);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorName")]
    Ptr<sbyte> GetSensorName(SensorHandle sensor);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNameForID")]
    Ptr<sbyte> GetSensorNameForID([NativeTypeName("SDL_SensorID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNameForID")]
    sbyte* GetSensorNameForIDRaw([NativeTypeName("SDL_SensorID")] uint instance_id);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorName")]
    sbyte* GetSensorNameRaw(SensorHandle sensor);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNonPortableType")]
    int GetSensorNonPortableType(SensorHandle sensor);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNonPortableTypeForID")]
    int GetSensorNonPortableTypeForID([NativeTypeName("SDL_SensorID")] uint instance_id);

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

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorTypeForID")]
    SensorType GetSensorTypeForID([NativeTypeName("SDL_SensorID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSilenceValueForFormat")]
    int GetSilenceValueForFormat(AudioFormat format);

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSIMDAlignment")]
    nuint GetSimdAlignment();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageFileSize")]
    byte GetStorageFileSize(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("Uint64 *")] nuint* length
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageFileSize")]
    MaybeBool<byte> GetStorageFileSize(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path,
        [NativeTypeName("Uint64 *")] Ref<nuint> length
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStoragePathInfo")]
    byte GetStoragePathInfo(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* path,
        PathInfo* info
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStoragePathInfo")]
    MaybeBool<byte> GetStoragePathInfo(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path,
        Ref<PathInfo> info
    );

    [return: NativeTypeName("Uint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageSpaceRemaining")]
    nuint GetStorageSpaceRemaining(StorageHandle storage);

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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceAlphaMod")]
    byte GetSurfaceAlphaMod(Surface* surface, [NativeTypeName("Uint8 *")] byte* alpha);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceAlphaMod")]
    MaybeBool<byte> GetSurfaceAlphaMod(
        Ref<Surface> surface,
        [NativeTypeName("Uint8 *")] Ref<byte> alpha
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceBlendMode")]
    byte GetSurfaceBlendMode(
        Surface* surface,
        [NativeTypeName("SDL_BlendMode *")] BlendMode* blendMode
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceBlendMode")]
    MaybeBool<byte> GetSurfaceBlendMode(
        Ref<Surface> surface,
        [NativeTypeName("SDL_BlendMode *")] Ref<BlendMode> blendMode
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceClipRect")]
    byte GetSurfaceClipRect(Surface* surface, Rect* rect);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceClipRect")]
    MaybeBool<byte> GetSurfaceClipRect(Ref<Surface> surface, Ref<Rect> rect);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorKey")]
    byte GetSurfaceColorKey(Surface* surface, [NativeTypeName("Uint32 *")] uint* key);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorKey")]
    MaybeBool<byte> GetSurfaceColorKey(
        Ref<Surface> surface,
        [NativeTypeName("Uint32 *")] Ref<uint> key
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorMod")]
    byte GetSurfaceColorMod(
        Surface* surface,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorMod")]
    MaybeBool<byte> GetSurfaceColorMod(
        Ref<Surface> surface,
        [NativeTypeName("Uint8 *")] Ref<byte> r,
        [NativeTypeName("Uint8 *")] Ref<byte> g,
        [NativeTypeName("Uint8 *")] Ref<byte> b
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorspace")]
    Colorspace GetSurfaceColorspace(Surface* surface);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorspace")]
    Colorspace GetSurfaceColorspace(Ref<Surface> surface);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceImages")]
    Surface** GetSurfaceImages(Surface* surface, int* count);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceImages")]
    Ptr2D<Surface> GetSurfaceImages(Ref<Surface> surface, Ref<int> count);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfacePalette")]
    Palette* GetSurfacePalette(Surface* surface);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfacePalette")]
    Ptr<Palette> GetSurfacePalette(Ref<Surface> surface);

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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextInputArea")]
    byte GetTextInputArea(WindowHandle window, Rect* rect, int* cursor);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextInputArea")]
    MaybeBool<byte> GetTextInputArea(WindowHandle window, Ref<Rect> rect, Ref<int> cursor);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaMod")]
    byte GetTextureAlphaMod(Texture* texture, [NativeTypeName("Uint8 *")] byte* alpha);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaMod")]
    MaybeBool<byte> GetTextureAlphaMod(
        Ref<Texture> texture,
        [NativeTypeName("Uint8 *")] Ref<byte> alpha
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaModFloat")]
    byte GetTextureAlphaModFloat(Texture* texture, float* alpha);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaModFloat")]
    MaybeBool<byte> GetTextureAlphaModFloat(Ref<Texture> texture, Ref<float> alpha);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureBlendMode")]
    byte GetTextureBlendMode(
        Texture* texture,
        [NativeTypeName("SDL_BlendMode *")] BlendMode* blendMode
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureBlendMode")]
    MaybeBool<byte> GetTextureBlendMode(
        Ref<Texture> texture,
        [NativeTypeName("SDL_BlendMode *")] Ref<BlendMode> blendMode
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorMod")]
    byte GetTextureColorMod(
        Texture* texture,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorMod")]
    MaybeBool<byte> GetTextureColorMod(
        Ref<Texture> texture,
        [NativeTypeName("Uint8 *")] Ref<byte> r,
        [NativeTypeName("Uint8 *")] Ref<byte> g,
        [NativeTypeName("Uint8 *")] Ref<byte> b
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorModFloat")]
    byte GetTextureColorModFloat(Texture* texture, float* r, float* g, float* b);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorModFloat")]
    MaybeBool<byte> GetTextureColorModFloat(
        Ref<Texture> texture,
        Ref<float> r,
        Ref<float> g,
        Ref<float> b
    );

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureProperties")]
    uint GetTextureProperties(Texture* texture);

    [return: NativeTypeName("SDL_PropertiesID")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureProperties")]
    uint GetTextureProperties(Ref<Texture> texture);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureScaleMode")]
    byte GetTextureScaleMode(Texture* texture, ScaleMode* scaleMode);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureScaleMode")]
    MaybeBool<byte> GetTextureScaleMode(Ref<Texture> texture, Ref<ScaleMode> scaleMode);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureSize")]
    byte GetTextureSize(Texture* texture, float* w, float* h);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureSize")]
    MaybeBool<byte> GetTextureSize(Ref<Texture> texture, Ref<float> w, Ref<float> h);

    [return: NativeTypeName("SDL_ThreadID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadID")]
    nuint GetThreadID(ThreadHandle thread);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadName")]
    Ptr<sbyte> GetThreadName(ThreadHandle thread);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadName")]
    sbyte* GetThreadNameRaw(ThreadHandle thread);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadState")]
    ThreadState GetThreadState(ThreadHandle thread);

    [return: NativeTypeName("Uint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTicks")]
    nuint GetTicks();

    [return: NativeTypeName("Uint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTicksNS")]
    nuint GetTicksNS();

    [NativeFunction("SDL3", EntryPoint = "SDL_GetTLS")]
    void* GetTLS([NativeTypeName("SDL_TLSID *")] AtomicInt* id);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTLS")]
    Ptr GetTLS([NativeTypeName("SDL_TLSID *")] Ref<AtomicInt> id);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceName")]
    Ptr<sbyte> GetTouchDeviceName([NativeTypeName("SDL_TouchID")] nuint touchID);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceName")]
    sbyte* GetTouchDeviceNameRaw([NativeTypeName("SDL_TouchID")] nuint touchID);

    [return: NativeTypeName("SDL_TouchID *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDevices")]
    nuint* GetTouchDevices(int* count);

    [return: NativeTypeName("SDL_TouchID *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDevices")]
    Ptr<nuint> GetTouchDevices(Ref<int> count);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceType")]
    TouchDeviceType GetTouchDeviceType([NativeTypeName("SDL_TouchID")] nuint touchID);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchFingers")]
    Finger** GetTouchFingers([NativeTypeName("SDL_TouchID")] nuint touchID, int* count);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchFingers")]
    Ptr2D<Finger> GetTouchFingers([NativeTypeName("SDL_TouchID")] nuint touchID, Ref<int> count);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetUserFolder")]
    Ptr<sbyte> GetUserFolder(Folder folder);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetUserFolder")]
    sbyte* GetUserFolderRaw(Folder folder);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetVersion")]
    int GetVersion();

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetVideoDriver")]
    Ptr<sbyte> GetVideoDriver(int index);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetVideoDriver")]
    sbyte* GetVideoDriverRaw(int index);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowAspectRatio")]
    byte GetWindowAspectRatio(WindowHandle window, float* min_aspect, float* max_aspect);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowAspectRatio")]
    MaybeBool<byte> GetWindowAspectRatio(
        WindowHandle window,
        Ref<float> min_aspect,
        Ref<float> max_aspect
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowBordersSize")]
    byte GetWindowBordersSize(WindowHandle window, int* top, int* left, int* bottom, int* right);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowBordersSize")]
    MaybeBool<byte> GetWindowBordersSize(
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
    nuint GetWindowFlags(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFromEvent")]
    WindowHandle GetWindowFromEvent([NativeTypeName("const SDL_Event *")] Event* @event);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFromEvent")]
    WindowHandle GetWindowFromEvent([NativeTypeName("const SDL_Event *")] Ref<Event> @event);

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

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowKeyboardGrab")]
    MaybeBool<byte> GetWindowKeyboardGrab(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowKeyboardGrab")]
    byte GetWindowKeyboardGrabRaw(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMaximumSize")]
    byte GetWindowMaximumSize(WindowHandle window, int* w, int* h);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMaximumSize")]
    MaybeBool<byte> GetWindowMaximumSize(WindowHandle window, Ref<int> w, Ref<int> h);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMinimumSize")]
    byte GetWindowMinimumSize(WindowHandle window, int* w, int* h);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMinimumSize")]
    MaybeBool<byte> GetWindowMinimumSize(WindowHandle window, Ref<int> w, Ref<int> h);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseGrab")]
    MaybeBool<byte> GetWindowMouseGrab(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseGrab")]
    byte GetWindowMouseGrabRaw(WindowHandle window);

    [return: NativeTypeName("const SDL_Rect *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseRect")]
    Ptr<Rect> GetWindowMouseRect(WindowHandle window);

    [return: NativeTypeName("const SDL_Rect *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseRect")]
    Rect* GetWindowMouseRectRaw(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowOpacity")]
    float GetWindowOpacity(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowParent")]
    WindowHandle GetWindowParent(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPixelDensity")]
    float GetWindowPixelDensity(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPixelFormat")]
    PixelFormat GetWindowPixelFormat(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPosition")]
    byte GetWindowPosition(WindowHandle window, int* x, int* y);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPosition")]
    MaybeBool<byte> GetWindowPosition(WindowHandle window, Ref<int> x, Ref<int> y);

    [return: NativeTypeName("SDL_PropertiesID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowProperties")]
    uint GetWindowProperties(WindowHandle window);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowRelativeMouseMode")]
    MaybeBool<byte> GetWindowRelativeMouseMode(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowRelativeMouseMode")]
    byte GetWindowRelativeMouseModeRaw(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindows")]
    WindowHandle* GetWindows(int* count);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindows")]
    Ptr<WindowHandle> GetWindows(Ref<int> count);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSafeArea")]
    byte GetWindowSafeArea(WindowHandle window, Rect* rect);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSafeArea")]
    MaybeBool<byte> GetWindowSafeArea(WindowHandle window, Ref<Rect> rect);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSize")]
    byte GetWindowSize(WindowHandle window, int* w, int* h);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSize")]
    MaybeBool<byte> GetWindowSize(WindowHandle window, Ref<int> w, Ref<int> h);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSizeInPixels")]
    byte GetWindowSizeInPixels(WindowHandle window, int* w, int* h);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSizeInPixels")]
    MaybeBool<byte> GetWindowSizeInPixels(WindowHandle window, Ref<int> w, Ref<int> h);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurface")]
    Ptr<Surface> GetWindowSurface(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurface")]
    Surface* GetWindowSurfaceRaw(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurfaceVSync")]
    byte GetWindowSurfaceVSync(WindowHandle window, int* vsync);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurfaceVSync")]
    MaybeBool<byte> GetWindowSurfaceVSync(WindowHandle window, Ref<int> vsync);

    [return: NativeTypeName("const char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowTitle")]
    Ptr<sbyte> GetWindowTitle(WindowHandle window);

    [return: NativeTypeName("const char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowTitle")]
    sbyte* GetWindowTitleRaw(WindowHandle window);

    [return: NativeTypeName("SDL_GLContext")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_CreateContext")]
    GLContextStateHandle GLCreateContext(WindowHandle window);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_DestroyContext")]
    MaybeBool<byte> GLDestroyContext(
        [NativeTypeName("SDL_GLContext")] GLContextStateHandle context
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_DestroyContext")]
    byte GLDestroyContextRaw([NativeTypeName("SDL_GLContext")] GLContextStateHandle context);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_ExtensionSupported")]
    byte GLExtensionSupported([NativeTypeName("const char *")] sbyte* extension);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_ExtensionSupported")]
    MaybeBool<byte> GLExtensionSupported([NativeTypeName("const char *")] Ref<sbyte> extension);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetAttribute")]
    byte GLGetAttribute(GLAttr attr, int* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetAttribute")]
    MaybeBool<byte> GLGetAttribute(GLAttr attr, Ref<int> value);

    [return: NativeTypeName("SDL_GLContext")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetCurrentContext")]
    GLContextStateHandle GLGetCurrentContext();

    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetCurrentWindow")]
    WindowHandle GLGetCurrentWindow();

    [return: NativeTypeName("SDL_FunctionPointer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetProcAddress")]
    FunctionPointer GLGetProcAddress([NativeTypeName("const char *")] sbyte* proc);

    [return: NativeTypeName("SDL_FunctionPointer")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetProcAddress")]
    FunctionPointer GLGetProcAddress([NativeTypeName("const char *")] Ref<sbyte> proc);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetSwapInterval")]
    byte GLGetSwapInterval(int* interval);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetSwapInterval")]
    MaybeBool<byte> GLGetSwapInterval(Ref<int> interval);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_LoadLibrary")]
    byte GLLoadLibrary([NativeTypeName("const char *")] sbyte* path);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_LoadLibrary")]
    MaybeBool<byte> GLLoadLibrary([NativeTypeName("const char *")] Ref<sbyte> path);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_MakeCurrent")]
    MaybeBool<byte> GLMakeCurrent(
        WindowHandle window,
        [NativeTypeName("SDL_GLContext")] GLContextStateHandle context
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_MakeCurrent")]
    byte GLMakeCurrentRaw(
        WindowHandle window,
        [NativeTypeName("SDL_GLContext")] GLContextStateHandle context
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GL_ResetAttributes")]
    void GLResetAttributes();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetAttribute")]
    MaybeBool<byte> GLSetAttribute(GLAttr attr, int value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetAttribute")]
    byte GLSetAttributeRaw(GLAttr attr, int value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetSwapInterval")]
    MaybeBool<byte> GLSetSwapInterval(int interval);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetSwapInterval")]
    byte GLSetSwapIntervalRaw(int interval);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SwapWindow")]
    MaybeBool<byte> GLSwapWindow(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SwapWindow")]
    byte GLSwapWindowRaw(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_GL_UnloadLibrary")]
    void GLUnloadLibrary();

    [return: NativeTypeName("char **")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GlobDirectory")]
    sbyte** GlobDirectory(
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("const char *")] sbyte* pattern,
        [NativeTypeName("SDL_GlobFlags")] uint flags,
        int* count
    );

    [return: NativeTypeName("char **")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GlobDirectory")]
    Ptr2D<sbyte> GlobDirectory(
        [NativeTypeName("const char *")] Ref<sbyte> path,
        [NativeTypeName("const char *")] Ref<sbyte> pattern,
        [NativeTypeName("SDL_GlobFlags")] uint flags,
        Ref<int> count
    );

    [return: NativeTypeName("char **")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GlobStorageDirectory")]
    sbyte** GlobStorageDirectory(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("const char *")] sbyte* pattern,
        [NativeTypeName("SDL_GlobFlags")] uint flags,
        int* count
    );

    [return: NativeTypeName("char **")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GlobStorageDirectory")]
    Ptr2D<sbyte> GlobStorageDirectory(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path,
        [NativeTypeName("const char *")] Ref<sbyte> pattern,
        [NativeTypeName("SDL_GlobFlags")] uint flags,
        Ref<int> count
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsProperties")]
    MaybeBool<byte> GPUSupportsProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsProperties")]
    byte GPUSupportsPropertiesRaw([NativeTypeName("SDL_PropertiesID")] uint props);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsShaderFormats")]
    byte GPUSupportsShaderFormats(
        [NativeTypeName("SDL_GPUShaderFormat")] uint format_flags,
        [NativeTypeName("const char *")] sbyte* name
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsShaderFormats")]
    MaybeBool<byte> GPUSupportsShaderFormats(
        [NativeTypeName("SDL_GPUShaderFormat")] uint format_flags,
        [NativeTypeName("const char *")] Ref<sbyte> name
    );

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureFormatTexelBlockSize")]
    uint GPUTextureFormatTexelBlockSize(GPUTextureFormat format);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsFormat")]
    MaybeBool<byte> GPUTextureSupportsFormat(
        GPUDeviceHandle device,
        GPUTextureFormat format,
        GPUTextureType type,
        [NativeTypeName("SDL_GPUTextureUsageFlags")] uint usage
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsFormat")]
    byte GPUTextureSupportsFormatRaw(
        GPUDeviceHandle device,
        GPUTextureFormat format,
        GPUTextureType type,
        [NativeTypeName("SDL_GPUTextureUsageFlags")] uint usage
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsSampleCount")]
    MaybeBool<byte> GPUTextureSupportsSampleCount(
        GPUDeviceHandle device,
        GPUTextureFormat format,
        GPUSampleCount sample_count
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsSampleCount")]
    byte GPUTextureSupportsSampleCountRaw(
        GPUDeviceHandle device,
        GPUTextureFormat format,
        GPUSampleCount sample_count
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_GUIDToString")]
    void GuidToString(Guid guid, [NativeTypeName("char *")] sbyte* pszGUID, int cbGUID);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_GUIDToString")]
    void GuidToString(Guid guid, [NativeTypeName("char *")] Ref<sbyte> pszGUID, int cbGUID);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HapticEffectSupported")]
    byte HapticEffectSupported(
        HapticHandle haptic,
        [NativeTypeName("const SDL_HapticEffect *")] HapticEffect* effect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HapticEffectSupported")]
    MaybeBool<byte> HapticEffectSupported(
        HapticHandle haptic,
        [NativeTypeName("const SDL_HapticEffect *")] Ref<HapticEffect> effect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HapticRumbleSupported")]
    MaybeBool<byte> HapticRumbleSupported(HapticHandle haptic);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HapticRumbleSupported")]
    byte HapticRumbleSupportedRaw(HapticHandle haptic);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAltiVec")]
    MaybeBool<byte> HasAltiVec();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAltiVec")]
    byte HasAltiVecRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasARMSIMD")]
    MaybeBool<byte> HasArmsimd();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasARMSIMD")]
    byte HasArmsimdRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX")]
    MaybeBool<byte> HasAVX();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX2")]
    MaybeBool<byte> HasAVX2();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX2")]
    byte HasAVX2Raw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX512F")]
    MaybeBool<byte> HasAVX512F();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX512F")]
    byte HasAVX512FRaw();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX")]
    byte HasAVXRaw();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardData")]
    byte HasClipboardData([NativeTypeName("const char *")] sbyte* mime_type);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardData")]
    MaybeBool<byte> HasClipboardData([NativeTypeName("const char *")] Ref<sbyte> mime_type);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardText")]
    MaybeBool<byte> HasClipboardText();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardText")]
    byte HasClipboardTextRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasEvent")]
    MaybeBool<byte> HasEvent([NativeTypeName("Uint32")] uint type);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasEvent")]
    byte HasEventRaw([NativeTypeName("Uint32")] uint type);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasEvents")]
    MaybeBool<byte> HasEvents(
        [NativeTypeName("Uint32")] uint minType,
        [NativeTypeName("Uint32")] uint maxType
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasEvents")]
    byte HasEventsRaw(
        [NativeTypeName("Uint32")] uint minType,
        [NativeTypeName("Uint32")] uint maxType
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasGamepad")]
    MaybeBool<byte> HasGamepad();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasGamepad")]
    byte HasGamepadRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasJoystick")]
    MaybeBool<byte> HasJoystick();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasJoystick")]
    byte HasJoystickRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasKeyboard")]
    MaybeBool<byte> HasKeyboard();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasKeyboard")]
    byte HasKeyboardRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasLASX")]
    MaybeBool<byte> HasLasx();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasLASX")]
    byte HasLasxRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasLSX")]
    MaybeBool<byte> HasLSX();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasLSX")]
    byte HasLSXRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasMMX")]
    MaybeBool<byte> HasMMX();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasMMX")]
    byte HasMMXRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasMouse")]
    MaybeBool<byte> HasMouse();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasMouse")]
    byte HasMouseRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasNEON")]
    MaybeBool<byte> HasNeon();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasNEON")]
    byte HasNeonRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasPrimarySelectionText")]
    MaybeBool<byte> HasPrimarySelectionText();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasPrimarySelectionText")]
    byte HasPrimarySelectionTextRaw();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasProperty")]
    byte HasProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasProperty")]
    MaybeBool<byte> HasProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersection")]
    byte HasRectIntersection(
        [NativeTypeName("const SDL_Rect *")] Rect* A,
        [NativeTypeName("const SDL_Rect *")] Rect* B
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersection")]
    MaybeBool<byte> HasRectIntersection(
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> A,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> B
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersectionFloat")]
    byte HasRectIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] FRect* A,
        [NativeTypeName("const SDL_FRect *")] FRect* B
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersectionFloat")]
    MaybeBool<byte> HasRectIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> A,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> B
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasScreenKeyboardSupport")]
    MaybeBool<byte> HasScreenKeyboardSupport();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasScreenKeyboardSupport")]
    byte HasScreenKeyboardSupportRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE")]
    MaybeBool<byte> HasSSE();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE2")]
    MaybeBool<byte> HasSSE2();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE2")]
    byte HasSSE2Raw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE3")]
    MaybeBool<byte> HasSSE3();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE3")]
    byte HasSSE3Raw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE41")]
    MaybeBool<byte> HasSSE41();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE41")]
    byte HasSSE41Raw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE42")]
    MaybeBool<byte> HasSSE42();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE42")]
    byte HasSSE42Raw();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE")]
    byte HasSSERaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_hid_ble_scan")]
    void HidBleScan([NativeTypeName("bool")] byte active);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_ble_scan")]
    void HidBleScan([NativeTypeName("bool")] MaybeBool<byte> active);

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

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HideCursor")]
    MaybeBool<byte> HideCursor();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HideCursor")]
    byte HideCursorRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_HideWindow")]
    MaybeBool<byte> HideWindow(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HideWindow")]
    byte HideWindowRaw(WindowHandle window);

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_iconv")]
    nuint Iconv(
        [NativeTypeName("SDL_iconv_t")] IconvDataTHandle cd,
        [NativeTypeName("const char **")] sbyte** inbuf,
        [NativeTypeName("size_t *")] nuint* inbytesleft,
        [NativeTypeName("char **")] sbyte** outbuf,
        [NativeTypeName("size_t *")] nuint* outbytesleft
    );

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_iconv")]
    nuint Iconv(
        [NativeTypeName("SDL_iconv_t")] IconvDataTHandle cd,
        [NativeTypeName("const char **")] Ref2D<sbyte> inbuf,
        [NativeTypeName("size_t *")] Ref<nuint> inbytesleft,
        [NativeTypeName("char **")] Ref2D<sbyte> outbuf,
        [NativeTypeName("size_t *")] Ref<nuint> outbytesleft
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_iconv_close")]
    int IconvClose([NativeTypeName("SDL_iconv_t")] IconvDataTHandle cd);

    [return: NativeTypeName("SDL_iconv_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_iconv_open")]
    IconvDataTHandle IconvOpen(
        [NativeTypeName("const char *")] sbyte* tocode,
        [NativeTypeName("const char *")] sbyte* fromcode
    );

    [return: NativeTypeName("SDL_iconv_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_iconv_open")]
    IconvDataTHandle IconvOpen(
        [NativeTypeName("const char *")] Ref<sbyte> tocode,
        [NativeTypeName("const char *")] Ref<sbyte> fromcode
    );

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_iconv_string")]
    sbyte* IconvString(
        [NativeTypeName("const char *")] sbyte* tocode,
        [NativeTypeName("const char *")] sbyte* fromcode,
        [NativeTypeName("const char *")] sbyte* inbuf,
        [NativeTypeName("size_t")] nuint inbytesleft
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_iconv_string")]
    Ptr<sbyte> IconvString(
        [NativeTypeName("const char *")] Ref<sbyte> tocode,
        [NativeTypeName("const char *")] Ref<sbyte> fromcode,
        [NativeTypeName("const char *")] Ref<sbyte> inbuf,
        [NativeTypeName("size_t")] nuint inbytesleft
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_Init")]
    MaybeBool<byte> Init([NativeTypeName("SDL_InitFlags")] uint flags);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_InitHapticRumble")]
    MaybeBool<byte> InitHapticRumble(HapticHandle haptic);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_InitHapticRumble")]
    byte InitHapticRumbleRaw(HapticHandle haptic);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Init")]
    byte InitRaw([NativeTypeName("SDL_InitFlags")] uint flags);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_InitSubSystem")]
    MaybeBool<byte> InitSubSystem([NativeTypeName("SDL_InitFlags")] uint flags);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_InitSubSystem")]
    byte InitSubSystemRaw([NativeTypeName("SDL_InitFlags")] uint flags);

    [NativeFunction("SDL3", EntryPoint = "SDL_InsertGPUDebugLabel")]
    void InsertGPUDebugLabel(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("const char *")] sbyte* text
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_InsertGPUDebugLabel")]
    void InsertGPUDebugLabel(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("const char *")] Ref<sbyte> text
    );

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
        [NativeTypeName("va_list")] VaListTagHandle ap
    );

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOvprintf")]
    nuint IOvprintf(
        IOStreamHandle context,
        [NativeTypeName("const char *")] Ref<sbyte> fmt,
        [NativeTypeName("va_list")] VaListTagHandle ap
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_isalnum")]
    int Isalnum(int x);

    [NativeFunction("SDL3", EntryPoint = "SDL_isalpha")]
    int Isalpha(int x);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePhysical")]
    MaybeBool<byte> IsAudioDevicePhysical([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePhysical")]
    byte IsAudioDevicePhysicalRaw([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePlayback")]
    MaybeBool<byte> IsAudioDevicePlayback([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePlayback")]
    byte IsAudioDevicePlaybackRaw([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [NativeFunction("SDL3", EntryPoint = "SDL_isblank")]
    int Isblank(int x);

    [NativeFunction("SDL3", EntryPoint = "SDL_iscntrl")]
    int Iscntrl(int x);

    [NativeFunction("SDL3", EntryPoint = "SDL_isdigit")]
    int Isdigit(int x);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsGamepad")]
    MaybeBool<byte> IsGamepad([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsGamepad")]
    byte IsGamepadRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_isgraph")]
    int Isgraph(int x);

    [NativeFunction("SDL3", EntryPoint = "SDL_isinf")]
    int Isinf(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_isinff")]
    int Isinff(float x);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickHaptic")]
    MaybeBool<byte> IsJoystickHaptic(JoystickHandle joystick);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickHaptic")]
    byte IsJoystickHapticRaw(JoystickHandle joystick);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickVirtual")]
    MaybeBool<byte> IsJoystickVirtual([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickVirtual")]
    byte IsJoystickVirtualRaw([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [NativeFunction("SDL3", EntryPoint = "SDL_islower")]
    int Islower(int x);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsMainThread")]
    MaybeBool<byte> IsMainThread();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsMainThread")]
    byte IsMainThreadRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsMouseHaptic")]
    MaybeBool<byte> IsMouseHaptic();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsMouseHaptic")]
    byte IsMouseHapticRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_isnan")]
    int Isnan(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_isnanf")]
    int Isnanf(float x);

    [NativeFunction("SDL3", EntryPoint = "SDL_isprint")]
    int Isprint(int x);

    [NativeFunction("SDL3", EntryPoint = "SDL_ispunct")]
    int Ispunct(int x);

    [NativeFunction("SDL3", EntryPoint = "SDL_isspace")]
    int Isspace(int x);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsTablet")]
    MaybeBool<byte> IsTablet();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsTablet")]
    byte IsTabletRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsTV")]
    MaybeBool<byte> IsTV();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsTV")]
    byte IsTVRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_isupper")]
    int Isupper(int x);

    [NativeFunction("SDL3", EntryPoint = "SDL_isxdigit")]
    int Isxdigit(int x);

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_itoa")]
    sbyte* Itoa(int value, [NativeTypeName("char *")] sbyte* str, int radix);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_itoa")]
    Ptr<sbyte> Itoa(int value, [NativeTypeName("char *")] Ref<sbyte> str, int radix);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_JoystickConnected")]
    MaybeBool<byte> JoystickConnected(JoystickHandle joystick);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_JoystickConnected")]
    byte JoystickConnectedRaw(JoystickHandle joystick);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_JoystickEventsEnabled")]
    MaybeBool<byte> JoystickEventsEnabled();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_JoystickEventsEnabled")]
    byte JoystickEventsEnabledRaw();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_KillProcess")]
    byte KillProcess(ProcessHandle process, [NativeTypeName("bool")] byte force);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_KillProcess")]
    MaybeBool<byte> KillProcess(
        ProcessHandle process,
        [NativeTypeName("bool")] MaybeBool<byte> force
    );

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_lltoa")]
    sbyte* Lltoa(
        [NativeTypeName("long long")] long value,
        [NativeTypeName("char *")] sbyte* str,
        int radix
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_lltoa")]
    Ptr<sbyte> Lltoa(
        [NativeTypeName("long long")] long value,
        [NativeTypeName("char *")] Ref<sbyte> str,
        int radix
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP")]
    Surface* LoadBMP([NativeTypeName("const char *")] sbyte* file);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP")]
    Ptr<Surface> LoadBMP([NativeTypeName("const char *")] Ref<sbyte> file);

    [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP_IO")]
    Surface* LoadBMPIO(IOStreamHandle src, [NativeTypeName("bool")] byte closeio);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP_IO")]
    Ptr<Surface> LoadBMPIO(IOStreamHandle src, [NativeTypeName("bool")] MaybeBool<byte> closeio);

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
        [NativeTypeName("bool")] byte closeio
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile_IO")]
    Ptr LoadFileIO(
        IOStreamHandle src,
        [NativeTypeName("size_t *")] Ref<nuint> datasize,
        [NativeTypeName("bool")] MaybeBool<byte> closeio
    );

    [return: NativeTypeName("SDL_FunctionPointer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFunction")]
    FunctionPointer LoadFunction(
        SharedObjectHandle handle,
        [NativeTypeName("const char *")] sbyte* name
    );

    [return: NativeTypeName("SDL_FunctionPointer")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFunction")]
    FunctionPointer LoadFunction(
        SharedObjectHandle handle,
        [NativeTypeName("const char *")] Ref<sbyte> name
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_LoadObject")]
    SharedObjectHandle LoadObject([NativeTypeName("const char *")] sbyte* sofile);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadObject")]
    SharedObjectHandle LoadObject([NativeTypeName("const char *")] Ref<sbyte> sofile);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV")]
    byte LoadWAV(
        [NativeTypeName("const char *")] sbyte* path,
        AudioSpec* spec,
        [NativeTypeName("Uint8 **")] byte** audio_buf,
        [NativeTypeName("Uint32 *")] uint* audio_len
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV")]
    MaybeBool<byte> LoadWAV(
        [NativeTypeName("const char *")] Ref<sbyte> path,
        Ref<AudioSpec> spec,
        [NativeTypeName("Uint8 **")] Ref2D<byte> audio_buf,
        [NativeTypeName("Uint32 *")] Ref<uint> audio_len
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV_IO")]
    byte LoadWAVIO(
        IOStreamHandle src,
        [NativeTypeName("bool")] byte closeio,
        AudioSpec* spec,
        [NativeTypeName("Uint8 **")] byte** audio_buf,
        [NativeTypeName("Uint32 *")] uint* audio_len
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV_IO")]
    MaybeBool<byte> LoadWAVIO(
        IOStreamHandle src,
        [NativeTypeName("bool")] MaybeBool<byte> closeio,
        Ref<AudioSpec> spec,
        [NativeTypeName("Uint8 **")] Ref2D<byte> audio_buf,
        [NativeTypeName("Uint32 *")] Ref<uint> audio_len
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockAudioStream")]
    MaybeBool<byte> LockAudioStream(AudioStreamHandle stream);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockAudioStream")]
    byte LockAudioStreamRaw(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_LockJoysticks")]
    void LockJoysticks();

    [NativeFunction("SDL3", EntryPoint = "SDL_LockMutex")]
    void LockMutex(MutexHandle mutex);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockProperties")]
    MaybeBool<byte> LockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockProperties")]
    byte LockPropertiesRaw([NativeTypeName("SDL_PropertiesID")] uint props);

    [NativeFunction("SDL3", EntryPoint = "SDL_LockRWLockForReading")]
    void LockRWLockForReading(RWLockHandle rwlock);

    [NativeFunction("SDL3", EntryPoint = "SDL_LockRWLockForWriting")]
    void LockRWLockForWriting(RWLockHandle rwlock);

    [NativeFunction("SDL3", EntryPoint = "SDL_LockSpinlock")]
    void LockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockSpinlock")]
    void LockSpinlock([NativeTypeName("SDL_SpinLock *")] Ref<int> @lock);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockSurface")]
    byte LockSurface(Surface* surface);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockSurface")]
    MaybeBool<byte> LockSurface(Ref<Surface> surface);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockTexture")]
    byte LockTexture(
        Texture* texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        void** pixels,
        int* pitch
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockTexture")]
    MaybeBool<byte> LockTexture(
        Ref<Texture> texture,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        Ref2D pixels,
        Ref<int> pitch
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockTextureToSurface")]
    byte LockTextureToSurface(
        Texture* texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        Surface** surface
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockTextureToSurface")]
    MaybeBool<byte> LockTextureToSurface(
        Ref<Texture> texture,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        Ref2D<Surface> surface
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_log")]
    double Log(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_log10")]
    double Log10(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_log10f")]
    float Log10F(float x);

    [NativeFunction("SDL3", EntryPoint = "SDL_logf")]
    float Logf(float x);

    [NativeFunction("SDL3", EntryPoint = "SDL_LogMessageV")]
    void LogMessageV(
        int category,
        LogPriority priority,
        [NativeTypeName("const char *")] sbyte* fmt,
        [NativeTypeName("va_list")] VaListTagHandle ap
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_LogMessageV")]
    void LogMessageV(
        int category,
        LogPriority priority,
        [NativeTypeName("const char *")] Ref<sbyte> fmt,
        [NativeTypeName("va_list")] VaListTagHandle ap
    );

    [return: NativeTypeName("long")]
    [NativeFunction("SDL3", EntryPoint = "SDL_lround")]
    nint Lround(double x);

    [return: NativeTypeName("long")]
    [NativeFunction("SDL3", EntryPoint = "SDL_lroundf")]
    nint Lroundf(float x);

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ltoa")]
    sbyte* Ltoa(
        [NativeTypeName("long")] nint value,
        [NativeTypeName("char *")] sbyte* str,
        int radix
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ltoa")]
    Ptr<sbyte> Ltoa(
        [NativeTypeName("long")] nint value,
        [NativeTypeName("char *")] Ref<sbyte> str,
        int radix
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_main")]
    int Main(int argc, [NativeTypeName("char *[]")] sbyte** argv);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_main")]
    int Main(int argc, [NativeTypeName("char *[]")] Ref2D<sbyte> argv);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_malloc")]
    Ptr Malloc([NativeTypeName("size_t")] nuint size);

    [NativeFunction("SDL3", EntryPoint = "SDL_malloc")]
    void* MallocRaw([NativeTypeName("size_t")] nuint size);

    [NativeFunction("SDL3", EntryPoint = "SDL_MapGPUTransferBuffer")]
    void* MapGPUTransferBuffer(
        GPUDeviceHandle device,
        GPUTransferBufferHandle transfer_buffer,
        [NativeTypeName("bool")] byte cycle
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapGPUTransferBuffer")]
    Ptr MapGPUTransferBuffer(
        GPUDeviceHandle device,
        GPUTransferBufferHandle transfer_buffer,
        [NativeTypeName("bool")] MaybeBool<byte> cycle
    );

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapRGB")]
    uint MapRGB(
        [NativeTypeName("const SDL_PixelFormatDetails *")] PixelFormatDetails* format,
        [NativeTypeName("const SDL_Palette *")] Palette* palette,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapRGB")]
    uint MapRGB(
        [NativeTypeName("const SDL_PixelFormatDetails *")] Ref<PixelFormatDetails> format,
        [NativeTypeName("const SDL_Palette *")] Ref<Palette> palette,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapRGBA")]
    uint MapRgba(
        [NativeTypeName("const SDL_PixelFormatDetails *")] PixelFormatDetails* format,
        [NativeTypeName("const SDL_Palette *")] Palette* palette,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b,
        [NativeTypeName("Uint8")] byte a
    );

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapRGBA")]
    uint MapRgba(
        [NativeTypeName("const SDL_PixelFormatDetails *")] Ref<PixelFormatDetails> format,
        [NativeTypeName("const SDL_Palette *")] Ref<Palette> palette,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b,
        [NativeTypeName("Uint8")] byte a
    );

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGB")]
    uint MapSurfaceRGB(
        Surface* surface,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGB")]
    uint MapSurfaceRGB(
        Ref<Surface> surface,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGBA")]
    uint MapSurfaceRgba(
        Surface* surface,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b,
        [NativeTypeName("Uint8")] byte a
    );

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGBA")]
    uint MapSurfaceRgba(
        Ref<Surface> surface,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b,
        [NativeTypeName("Uint8")] byte a
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_MaximizeWindow")]
    MaybeBool<byte> MaximizeWindow(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MaximizeWindow")]
    byte MaximizeWindowRaw(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_memcmp")]
    int Memcmp(
        [NativeTypeName("const void *")] void* s1,
        [NativeTypeName("const void *")] void* s2,
        [NativeTypeName("size_t")] nuint len
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_memcmp")]
    int Memcmp(
        [NativeTypeName("const void *")] Ref s1,
        [NativeTypeName("const void *")] Ref s2,
        [NativeTypeName("size_t")] nuint len
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_MemoryBarrierAcquireFunction")]
    void MemoryBarrierAcquireFunction();

    [NativeFunction("SDL3", EntryPoint = "SDL_MemoryBarrierReleaseFunction")]
    void MemoryBarrierReleaseFunction();

    [NativeFunction("SDL3", EntryPoint = "SDL_memset4")]
    void* Memset4(
        void* dst,
        [NativeTypeName("Uint32")] uint val,
        [NativeTypeName("size_t")] nuint dwords
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_memset4")]
    Ptr Memset4(
        Ref dst,
        [NativeTypeName("Uint32")] uint val,
        [NativeTypeName("size_t")] nuint dwords
    );

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

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_MinimizeWindow")]
    MaybeBool<byte> MinimizeWindow(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MinimizeWindow")]
    byte MinimizeWindowRaw(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MixAudio")]
    byte MixAudio(
        [NativeTypeName("Uint8 *")] byte* dst,
        [NativeTypeName("const Uint8 *")] byte* src,
        AudioFormat format,
        [NativeTypeName("Uint32")] uint len,
        float volume
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_MixAudio")]
    MaybeBool<byte> MixAudio(
        [NativeTypeName("Uint8 *")] Ref<byte> dst,
        [NativeTypeName("const Uint8 *")] Ref<byte> src,
        AudioFormat format,
        [NativeTypeName("Uint32")] uint len,
        float volume
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_modf")]
    double Modf(double x, double* y);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_modf")]
    double Modf(double x, Ref<double> y);

    [NativeFunction("SDL3", EntryPoint = "SDL_modff")]
    float Modff(float x, float* y);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_modff")]
    float Modff(float x, Ref<float> y);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_murmur3_32")]
    uint Murmur3X32(
        [NativeTypeName("const void *")] void* data,
        [NativeTypeName("size_t")] nuint len,
        [NativeTypeName("Uint32")] uint seed
    );

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_murmur3_32")]
    uint Murmur3X32(
        [NativeTypeName("const void *")] Ref data,
        [NativeTypeName("size_t")] nuint len,
        [NativeTypeName("Uint32")] uint seed
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidEnterBackground")]
    void OnApplicationDidEnterBackground();

    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidEnterForeground")]
    void OnApplicationDidEnterForeground();

    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning")]
    void OnApplicationDidReceiveMemoryWarning();

    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillEnterBackground")]
    void OnApplicationWillEnterBackground();

    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillEnterForeground")]
    void OnApplicationWillEnterForeground();

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
        [NativeTypeName("SDL_AudioStreamCallback")] AudioStreamCallback callback,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDeviceStream")]
    AudioStreamHandle OpenAudioDeviceStream(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> spec,
        [NativeTypeName("SDL_AudioStreamCallback")] AudioStreamCallback callback,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_OpenCamera")]
    CameraHandle OpenCamera(
        [NativeTypeName("SDL_CameraID")] uint instance_id,
        [NativeTypeName("const SDL_CameraSpec *")] CameraSpec* spec
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenCamera")]
    CameraHandle OpenCamera(
        [NativeTypeName("SDL_CameraID")] uint instance_id,
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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenURL")]
    byte OpenURL([NativeTypeName("const char *")] sbyte* url);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenURL")]
    MaybeBool<byte> OpenURL([NativeTypeName("const char *")] Ref<sbyte> url);

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

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_OutOfMemory")]
    MaybeBool<byte> OutOfMemory();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OutOfMemory")]
    byte OutOfMemoryRaw();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioDevice")]
    MaybeBool<byte> PauseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioDevice")]
    byte PauseAudioDeviceRaw([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioStreamDevice")]
    MaybeBool<byte> PauseAudioStreamDevice(AudioStreamHandle stream);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioStreamDevice")]
    byte PauseAudioStreamDeviceRaw(AudioStreamHandle stream);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PauseHaptic")]
    MaybeBool<byte> PauseHaptic(HapticHandle haptic);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PauseHaptic")]
    byte PauseHapticRaw(HapticHandle haptic);

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

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PlayHapticRumble")]
    MaybeBool<byte> PlayHapticRumble(
        HapticHandle haptic,
        float strength,
        [NativeTypeName("Uint32")] uint length
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PlayHapticRumble")]
    byte PlayHapticRumbleRaw(
        HapticHandle haptic,
        float strength,
        [NativeTypeName("Uint32")] uint length
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PollEvent")]
    byte PollEvent(Event* @event);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PollEvent")]
    MaybeBool<byte> PollEvent(Ref<Event> @event);

    [NativeFunction("SDL3", EntryPoint = "SDL_PopGPUDebugGroup")]
    void PopGPUDebugGroup(GPUCommandBufferHandle command_buffer);

    [NativeFunction("SDL3", EntryPoint = "SDL_pow")]
    double Pow(double x, double y);

    [NativeFunction("SDL3", EntryPoint = "SDL_powf")]
    float Powf(float x, float y);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplyAlpha")]
    byte PremultiplyAlpha(
        int width,
        int height,
        PixelFormat src_format,
        [NativeTypeName("const void *")] void* src,
        int src_pitch,
        PixelFormat dst_format,
        void* dst,
        int dst_pitch,
        [NativeTypeName("bool")] byte linear
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplyAlpha")]
    MaybeBool<byte> PremultiplyAlpha(
        int width,
        int height,
        PixelFormat src_format,
        [NativeTypeName("const void *")] Ref src,
        int src_pitch,
        PixelFormat dst_format,
        Ref dst,
        int dst_pitch,
        [NativeTypeName("bool")] MaybeBool<byte> linear
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplySurfaceAlpha")]
    byte PremultiplySurfaceAlpha(Surface* surface, [NativeTypeName("bool")] byte linear);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplySurfaceAlpha")]
    MaybeBool<byte> PremultiplySurfaceAlpha(
        Ref<Surface> surface,
        [NativeTypeName("bool")] MaybeBool<byte> linear
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_PumpEvents")]
    void PumpEvents();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushEvent")]
    byte PushEvent(Event* @event);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushEvent")]
    MaybeBool<byte> PushEvent(Ref<Event> @event);

    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUComputeUniformData")]
    void PushGPUComputeUniformData(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("Uint32")] uint slot_index,
        [NativeTypeName("const void *")] void* data,
        [NativeTypeName("Uint32")] uint length
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUComputeUniformData")]
    void PushGPUComputeUniformData(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("Uint32")] uint slot_index,
        [NativeTypeName("const void *")] Ref data,
        [NativeTypeName("Uint32")] uint length
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUDebugGroup")]
    void PushGPUDebugGroup(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("const char *")] sbyte* name
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUDebugGroup")]
    void PushGPUDebugGroup(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("const char *")] Ref<sbyte> name
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUFragmentUniformData")]
    void PushGPUFragmentUniformData(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("Uint32")] uint slot_index,
        [NativeTypeName("const void *")] void* data,
        [NativeTypeName("Uint32")] uint length
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUFragmentUniformData")]
    void PushGPUFragmentUniformData(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("Uint32")] uint slot_index,
        [NativeTypeName("const void *")] Ref data,
        [NativeTypeName("Uint32")] uint length
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUVertexUniformData")]
    void PushGPUVertexUniformData(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("Uint32")] uint slot_index,
        [NativeTypeName("const void *")] void* data,
        [NativeTypeName("Uint32")] uint length
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUVertexUniformData")]
    void PushGPUVertexUniformData(
        GPUCommandBufferHandle command_buffer,
        [NativeTypeName("Uint32")] uint slot_index,
        [NativeTypeName("const void *")] Ref data,
        [NativeTypeName("Uint32")] uint length
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PutAudioStreamData")]
    byte PutAudioStreamData(
        AudioStreamHandle stream,
        [NativeTypeName("const void *")] void* buf,
        int len
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_PutAudioStreamData")]
    MaybeBool<byte> PutAudioStreamData(
        AudioStreamHandle stream,
        [NativeTypeName("const void *")] Ref buf,
        int len
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_qsort")]
    void Qsort(
        void* @base,
        [NativeTypeName("size_t")] nuint nmemb,
        [NativeTypeName("size_t")] nuint size,
        [NativeTypeName("SDL_CompareCallback")] CompareCallback compare
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_qsort")]
    void Qsort(
        Ref @base,
        [NativeTypeName("size_t")] nuint nmemb,
        [NativeTypeName("size_t")] nuint size,
        [NativeTypeName("SDL_CompareCallback")] CompareCallback compare
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_qsort_r")]
    void QsortR(
        void* @base,
        [NativeTypeName("size_t")] nuint nmemb,
        [NativeTypeName("size_t")] nuint size,
        [NativeTypeName("SDL_CompareCallback_r")] CompareCallbackR compare,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_qsort_r")]
    void QsortR(
        Ref @base,
        [NativeTypeName("size_t")] nuint nmemb,
        [NativeTypeName("size_t")] nuint size,
        [NativeTypeName("SDL_CompareCallback_r")] CompareCallbackR compare,
        Ref userdata
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_QueryGPUFence")]
    MaybeBool<byte> QueryGPUFence(GPUDeviceHandle device, GPUFenceHandle fence);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_QueryGPUFence")]
    byte QueryGPUFenceRaw(GPUDeviceHandle device, GPUFenceHandle fence);

    [NativeFunction("SDL3", EntryPoint = "SDL_Quit")]
    void Quit();

    [NativeFunction("SDL3", EntryPoint = "SDL_QuitSubSystem")]
    void QuitSubSystem([NativeTypeName("SDL_InitFlags")] uint flags);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RaiseWindow")]
    MaybeBool<byte> RaiseWindow(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RaiseWindow")]
    byte RaiseWindowRaw(WindowHandle window);

    [return: NativeTypeName("Sint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_rand")]
    int Rand([NativeTypeName("Sint32")] int n);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_rand_bits")]
    uint RandBits();

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_rand_bits_r")]
    uint RandBitsR([NativeTypeName("Uint64 *")] nuint* state);

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_rand_bits_r")]
    uint RandBitsR([NativeTypeName("Uint64 *")] Ref<nuint> state);

    [return: NativeTypeName("Sint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_rand_r")]
    int RandR([NativeTypeName("Uint64 *")] nuint* state, [NativeTypeName("Sint32")] int n);

    [return: NativeTypeName("Sint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_rand_r")]
    int RandR([NativeTypeName("Uint64 *")] Ref<nuint> state, [NativeTypeName("Sint32")] int n);

    [NativeFunction("SDL3", EntryPoint = "SDL_randf")]
    float Randf();

    [NativeFunction("SDL3", EntryPoint = "SDL_randf_r")]
    float RandfR([NativeTypeName("Uint64 *")] nuint* state);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_randf_r")]
    float RandfR([NativeTypeName("Uint64 *")] Ref<nuint> state);

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadIO")]
    nuint ReadIO(IOStreamHandle context, void* ptr, [NativeTypeName("size_t")] nuint size);

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadIO")]
    nuint ReadIO(IOStreamHandle context, Ref ptr, [NativeTypeName("size_t")] nuint size);

    [NativeFunction("SDL3", EntryPoint = "SDL_ReadProcess")]
    void* ReadProcess(
        ProcessHandle process,
        [NativeTypeName("size_t *")] nuint* datasize,
        int* exitcode
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadProcess")]
    Ptr ReadProcess(
        ProcessHandle process,
        [NativeTypeName("size_t *")] Ref<nuint> datasize,
        Ref<int> exitcode
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16BE")]
    byte ReadS16BE(IOStreamHandle src, [NativeTypeName("Sint16 *")] short* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16BE")]
    MaybeBool<byte> ReadS16BE(IOStreamHandle src, [NativeTypeName("Sint16 *")] Ref<short> value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16LE")]
    byte ReadS16LE(IOStreamHandle src, [NativeTypeName("Sint16 *")] short* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16LE")]
    MaybeBool<byte> ReadS16LE(IOStreamHandle src, [NativeTypeName("Sint16 *")] Ref<short> value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32BE")]
    byte ReadS32BE(IOStreamHandle src, [NativeTypeName("Sint32 *")] int* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32BE")]
    MaybeBool<byte> ReadS32BE(IOStreamHandle src, [NativeTypeName("Sint32 *")] Ref<int> value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32LE")]
    byte ReadS32LE(IOStreamHandle src, [NativeTypeName("Sint32 *")] int* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32LE")]
    MaybeBool<byte> ReadS32LE(IOStreamHandle src, [NativeTypeName("Sint32 *")] Ref<int> value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64BE")]
    byte ReadS64BE(IOStreamHandle src, [NativeTypeName("Sint64 *")] nint* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64BE")]
    MaybeBool<byte> ReadS64BE(IOStreamHandle src, [NativeTypeName("Sint64 *")] Ref<nint> value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64LE")]
    byte ReadS64LE(IOStreamHandle src, [NativeTypeName("Sint64 *")] nint* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64LE")]
    MaybeBool<byte> ReadS64LE(IOStreamHandle src, [NativeTypeName("Sint64 *")] Ref<nint> value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS8")]
    byte ReadS8(IOStreamHandle src, [NativeTypeName("Sint8 *")] sbyte* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS8")]
    MaybeBool<byte> ReadS8(IOStreamHandle src, [NativeTypeName("Sint8 *")] Ref<sbyte> value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadStorageFile")]
    byte ReadStorageFile(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* path,
        void* destination,
        [NativeTypeName("Uint64")] nuint length
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadStorageFile")]
    MaybeBool<byte> ReadStorageFile(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path,
        Ref destination,
        [NativeTypeName("Uint64")] nuint length
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixel")]
    byte ReadSurfacePixel(
        Surface* surface,
        int x,
        int y,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b,
        [NativeTypeName("Uint8 *")] byte* a
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixel")]
    MaybeBool<byte> ReadSurfacePixel(
        Ref<Surface> surface,
        int x,
        int y,
        [NativeTypeName("Uint8 *")] Ref<byte> r,
        [NativeTypeName("Uint8 *")] Ref<byte> g,
        [NativeTypeName("Uint8 *")] Ref<byte> b,
        [NativeTypeName("Uint8 *")] Ref<byte> a
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixelFloat")]
    byte ReadSurfacePixelFloat(
        Surface* surface,
        int x,
        int y,
        float* r,
        float* g,
        float* b,
        float* a
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixelFloat")]
    MaybeBool<byte> ReadSurfacePixelFloat(
        Ref<Surface> surface,
        int x,
        int y,
        Ref<float> r,
        Ref<float> g,
        Ref<float> b,
        Ref<float> a
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16BE")]
    byte ReadU16BE(IOStreamHandle src, [NativeTypeName("Uint16 *")] ushort* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16BE")]
    MaybeBool<byte> ReadU16BE(IOStreamHandle src, [NativeTypeName("Uint16 *")] Ref<ushort> value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16LE")]
    byte ReadU16LE(IOStreamHandle src, [NativeTypeName("Uint16 *")] ushort* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16LE")]
    MaybeBool<byte> ReadU16LE(IOStreamHandle src, [NativeTypeName("Uint16 *")] Ref<ushort> value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32BE")]
    byte ReadU32BE(IOStreamHandle src, [NativeTypeName("Uint32 *")] uint* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32BE")]
    MaybeBool<byte> ReadU32BE(IOStreamHandle src, [NativeTypeName("Uint32 *")] Ref<uint> value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32LE")]
    byte ReadU32LE(IOStreamHandle src, [NativeTypeName("Uint32 *")] uint* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32LE")]
    MaybeBool<byte> ReadU32LE(IOStreamHandle src, [NativeTypeName("Uint32 *")] Ref<uint> value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64BE")]
    byte ReadU64BE(IOStreamHandle src, [NativeTypeName("Uint64 *")] nuint* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64BE")]
    MaybeBool<byte> ReadU64BE(IOStreamHandle src, [NativeTypeName("Uint64 *")] Ref<nuint> value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64LE")]
    byte ReadU64LE(IOStreamHandle src, [NativeTypeName("Uint64 *")] nuint* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64LE")]
    MaybeBool<byte> ReadU64LE(IOStreamHandle src, [NativeTypeName("Uint64 *")] Ref<nuint> value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU8")]
    byte ReadU8(IOStreamHandle src, [NativeTypeName("Uint8 *")] byte* value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU8")]
    MaybeBool<byte> ReadU8(IOStreamHandle src, [NativeTypeName("Uint8 *")] Ref<byte> value);

    [NativeFunction("SDL3", EntryPoint = "SDL_realloc")]
    void* Realloc(void* mem, [NativeTypeName("size_t")] nuint size);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_realloc")]
    Ptr Realloc(Ref mem, [NativeTypeName("size_t")] nuint size);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RegisterEvents")]
    uint RegisterEvents(int numevents);

    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseCameraFrame")]
    void ReleaseCameraFrame(CameraHandle camera, Surface* frame);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseCameraFrame")]
    void ReleaseCameraFrame(CameraHandle camera, Ref<Surface> frame);

    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUBuffer")]
    void ReleaseGPUBuffer(GPUDeviceHandle device, GPUBufferHandle buffer);

    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUComputePipeline")]
    void ReleaseGPUComputePipeline(
        GPUDeviceHandle device,
        GPUComputePipelineHandle compute_pipeline
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUFence")]
    void ReleaseGPUFence(GPUDeviceHandle device, GPUFenceHandle fence);

    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUGraphicsPipeline")]
    void ReleaseGPUGraphicsPipeline(
        GPUDeviceHandle device,
        GPUGraphicsPipelineHandle graphics_pipeline
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUSampler")]
    void ReleaseGPUSampler(GPUDeviceHandle device, GPUSamplerHandle sampler);

    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUShader")]
    void ReleaseGPUShader(GPUDeviceHandle device, GPUShaderHandle shader);

    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUTexture")]
    void ReleaseGPUTexture(GPUDeviceHandle device, GPUTextureHandle texture);

    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUTransferBuffer")]
    void ReleaseGPUTransferBuffer(GPUDeviceHandle device, GPUTransferBufferHandle transfer_buffer);

    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseWindowFromGPUDevice")]
    void ReleaseWindowFromGPUDevice(GPUDeviceHandle device, WindowHandle window);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReloadGamepadMappings")]
    MaybeBool<byte> ReloadGamepadMappings();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReloadGamepadMappings")]
    byte ReloadGamepadMappingsRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveEventWatch")]
    void RemoveEventWatch([NativeTypeName("SDL_EventFilter")] EventFilter filter, void* userdata);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveEventWatch")]
    void RemoveEventWatch([NativeTypeName("SDL_EventFilter")] EventFilter filter, Ref userdata);

    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveHintCallback")]
    void RemoveHintCallback(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("SDL_HintCallback")] HintCallback callback,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveHintCallback")]
    void RemoveHintCallback(
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("SDL_HintCallback")] HintCallback callback,
        Ref userdata
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemovePath")]
    byte RemovePath([NativeTypeName("const char *")] sbyte* path);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemovePath")]
    MaybeBool<byte> RemovePath([NativeTypeName("const char *")] Ref<sbyte> path);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveStoragePath")]
    byte RemoveStoragePath(StorageHandle storage, [NativeTypeName("const char *")] sbyte* path);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveStoragePath")]
    MaybeBool<byte> RemoveStoragePath(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveSurfaceAlternateImages")]
    void RemoveSurfaceAlternateImages(Surface* surface);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveSurfaceAlternateImages")]
    void RemoveSurfaceAlternateImages(Ref<Surface> surface);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveTimer")]
    MaybeBool<byte> RemoveTimer([NativeTypeName("SDL_TimerID")] uint id);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveTimer")]
    byte RemoveTimerRaw([NativeTypeName("SDL_TimerID")] uint id);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenamePath")]
    byte RenamePath(
        [NativeTypeName("const char *")] sbyte* oldpath,
        [NativeTypeName("const char *")] sbyte* newpath
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenamePath")]
    MaybeBool<byte> RenamePath(
        [NativeTypeName("const char *")] Ref<sbyte> oldpath,
        [NativeTypeName("const char *")] Ref<sbyte> newpath
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenameStoragePath")]
    byte RenameStoragePath(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* oldpath,
        [NativeTypeName("const char *")] sbyte* newpath
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenameStoragePath")]
    MaybeBool<byte> RenameStoragePath(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> oldpath,
        [NativeTypeName("const char *")] Ref<sbyte> newpath
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderClear")]
    MaybeBool<byte> RenderClear(RendererHandle renderer);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderClear")]
    byte RenderClearRaw(RendererHandle renderer);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderClipEnabled")]
    MaybeBool<byte> RenderClipEnabled(RendererHandle renderer);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderClipEnabled")]
    byte RenderClipEnabledRaw(RendererHandle renderer);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesFromWindow")]
    byte RenderCoordinatesFromWindow(
        RendererHandle renderer,
        float window_x,
        float window_y,
        float* x,
        float* y
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesFromWindow")]
    MaybeBool<byte> RenderCoordinatesFromWindow(
        RendererHandle renderer,
        float window_x,
        float window_y,
        Ref<float> x,
        Ref<float> y
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesToWindow")]
    byte RenderCoordinatesToWindow(
        RendererHandle renderer,
        float x,
        float y,
        float* window_x,
        float* window_y
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesToWindow")]
    MaybeBool<byte> RenderCoordinatesToWindow(
        RendererHandle renderer,
        float x,
        float y,
        Ref<float> window_x,
        Ref<float> window_y
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderDebugText")]
    byte RenderDebugText(
        RendererHandle renderer,
        float x,
        float y,
        [NativeTypeName("const char *")] sbyte* str
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderDebugText")]
    MaybeBool<byte> RenderDebugText(
        RendererHandle renderer,
        float x,
        float y,
        [NativeTypeName("const char *")] Ref<sbyte> str
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRect")]
    byte RenderFillRect(RendererHandle renderer, [NativeTypeName("const SDL_FRect *")] FRect* rect);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRect")]
    MaybeBool<byte> RenderFillRect(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> rect
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRects")]
    byte RenderFillRects(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FRect *")] FRect* rects,
        int count
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRects")]
    MaybeBool<byte> RenderFillRects(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> rects,
        int count
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometry")]
    byte RenderGeometry(
        RendererHandle renderer,
        Texture* texture,
        [NativeTypeName("const SDL_Vertex *")] Vertex* vertices,
        int num_vertices,
        [NativeTypeName("const int *")] int* indices,
        int num_indices
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometry")]
    MaybeBool<byte> RenderGeometry(
        RendererHandle renderer,
        Ref<Texture> texture,
        [NativeTypeName("const SDL_Vertex *")] Ref<Vertex> vertices,
        int num_vertices,
        [NativeTypeName("const int *")] Ref<int> indices,
        int num_indices
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRaw")]
    byte RenderGeometryRaw(
        RendererHandle renderer,
        Texture* texture,
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

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRaw")]
    MaybeBool<byte> RenderGeometryRaw(
        RendererHandle renderer,
        Ref<Texture> texture,
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

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderLine")]
    MaybeBool<byte> RenderLine(RendererHandle renderer, float x1, float y1, float x2, float y2);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderLine")]
    byte RenderLineRaw(RendererHandle renderer, float x1, float y1, float x2, float y2);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderLines")]
    byte RenderLines(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FPoint *")] FPoint* points,
        int count
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderLines")]
    MaybeBool<byte> RenderLines(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> points,
        int count
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoint")]
    MaybeBool<byte> RenderPoint(RendererHandle renderer, float x, float y);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoint")]
    byte RenderPointRaw(RendererHandle renderer, float x, float y);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoints")]
    byte RenderPoints(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FPoint *")] FPoint* points,
        int count
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoints")]
    MaybeBool<byte> RenderPoints(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> points,
        int count
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPresent")]
    MaybeBool<byte> RenderPresent(RendererHandle renderer);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPresent")]
    byte RenderPresentRaw(RendererHandle renderer);

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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderRect")]
    byte RenderRect(RendererHandle renderer, [NativeTypeName("const SDL_FRect *")] FRect* rect);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderRect")]
    MaybeBool<byte> RenderRect(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> rect
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderRects")]
    byte RenderRects(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FRect *")] FRect* rects,
        int count
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderRects")]
    MaybeBool<byte> RenderRects(
        RendererHandle renderer,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> rects,
        int count
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture")]
    byte RenderTexture(
        RendererHandle renderer,
        Texture* texture,
        [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
        [NativeTypeName("const SDL_FRect *")] FRect* dstrect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture")]
    MaybeBool<byte> RenderTexture(
        RendererHandle renderer,
        Ref<Texture> texture,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> srcrect,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> dstrect
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture9Grid")]
    byte RenderTexture9Grid(
        RendererHandle renderer,
        Texture* texture,
        [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
        float left_width,
        float right_width,
        float top_height,
        float bottom_height,
        float scale,
        [NativeTypeName("const SDL_FRect *")] FRect* dstrect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture9Grid")]
    MaybeBool<byte> RenderTexture9Grid(
        RendererHandle renderer,
        Ref<Texture> texture,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> srcrect,
        float left_width,
        float right_width,
        float top_height,
        float bottom_height,
        float scale,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> dstrect
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureAffine")]
    byte RenderTextureAffine(
        RendererHandle renderer,
        Texture* texture,
        [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
        [NativeTypeName("const SDL_FPoint *")] FPoint* origin,
        [NativeTypeName("const SDL_FPoint *")] FPoint* right,
        [NativeTypeName("const SDL_FPoint *")] FPoint* down
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureAffine")]
    MaybeBool<byte> RenderTextureAffine(
        RendererHandle renderer,
        Ref<Texture> texture,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> srcrect,
        [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> origin,
        [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> right,
        [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> down
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureRotated")]
    byte RenderTextureRotated(
        RendererHandle renderer,
        Texture* texture,
        [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
        [NativeTypeName("const SDL_FRect *")] FRect* dstrect,
        double angle,
        [NativeTypeName("const SDL_FPoint *")] FPoint* center,
        FlipMode flip
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureRotated")]
    MaybeBool<byte> RenderTextureRotated(
        RendererHandle renderer,
        Ref<Texture> texture,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> srcrect,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> dstrect,
        double angle,
        [NativeTypeName("const SDL_FPoint *")] Ref<FPoint> center,
        FlipMode flip
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureTiled")]
    byte RenderTextureTiled(
        RendererHandle renderer,
        Texture* texture,
        [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
        float scale,
        [NativeTypeName("const SDL_FRect *")] FRect* dstrect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureTiled")]
    MaybeBool<byte> RenderTextureTiled(
        RendererHandle renderer,
        Ref<Texture> texture,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> srcrect,
        float scale,
        [NativeTypeName("const SDL_FRect *")] Ref<FRect> dstrect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderViewportSet")]
    MaybeBool<byte> RenderViewportSet(RendererHandle renderer);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderViewportSet")]
    byte RenderViewportSetRaw(RendererHandle renderer);

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

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResetHint")]
    byte ResetHint([NativeTypeName("const char *")] sbyte* name);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResetHint")]
    MaybeBool<byte> ResetHint([NativeTypeName("const char *")] Ref<sbyte> name);

    [NativeFunction("SDL3", EntryPoint = "SDL_ResetHints")]
    void ResetHints();

    [NativeFunction("SDL3", EntryPoint = "SDL_ResetKeyboard")]
    void ResetKeyboard();

    [NativeFunction("SDL3", EntryPoint = "SDL_ResetLogPriorities")]
    void ResetLogPriorities();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RestoreWindow")]
    MaybeBool<byte> RestoreWindow(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RestoreWindow")]
    byte RestoreWindowRaw(WindowHandle window);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioDevice")]
    MaybeBool<byte> ResumeAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioDevice")]
    byte ResumeAudioDeviceRaw([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioStreamDevice")]
    MaybeBool<byte> ResumeAudioStreamDevice(AudioStreamHandle stream);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioStreamDevice")]
    byte ResumeAudioStreamDeviceRaw(AudioStreamHandle stream);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResumeHaptic")]
    MaybeBool<byte> ResumeHaptic(HapticHandle haptic);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResumeHaptic")]
    byte ResumeHapticRaw(HapticHandle haptic);

    [NativeFunction("SDL3", EntryPoint = "SDL_round")]
    double Round(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_roundf")]
    float Roundf(float x);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepad")]
    MaybeBool<byte> RumbleGamepad(
        GamepadHandle gamepad,
        [NativeTypeName("Uint16")] ushort low_frequency_rumble,
        [NativeTypeName("Uint16")] ushort high_frequency_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepad")]
    byte RumbleGamepadRaw(
        GamepadHandle gamepad,
        [NativeTypeName("Uint16")] ushort low_frequency_rumble,
        [NativeTypeName("Uint16")] ushort high_frequency_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepadTriggers")]
    MaybeBool<byte> RumbleGamepadTriggers(
        GamepadHandle gamepad,
        [NativeTypeName("Uint16")] ushort left_rumble,
        [NativeTypeName("Uint16")] ushort right_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepadTriggers")]
    byte RumbleGamepadTriggersRaw(
        GamepadHandle gamepad,
        [NativeTypeName("Uint16")] ushort left_rumble,
        [NativeTypeName("Uint16")] ushort right_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystick")]
    MaybeBool<byte> RumbleJoystick(
        JoystickHandle joystick,
        [NativeTypeName("Uint16")] ushort low_frequency_rumble,
        [NativeTypeName("Uint16")] ushort high_frequency_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystick")]
    byte RumbleJoystickRaw(
        JoystickHandle joystick,
        [NativeTypeName("Uint16")] ushort low_frequency_rumble,
        [NativeTypeName("Uint16")] ushort high_frequency_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystickTriggers")]
    MaybeBool<byte> RumbleJoystickTriggers(
        JoystickHandle joystick,
        [NativeTypeName("Uint16")] ushort left_rumble,
        [NativeTypeName("Uint16")] ushort right_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystickTriggers")]
    byte RumbleJoystickTriggersRaw(
        JoystickHandle joystick,
        [NativeTypeName("Uint16")] ushort left_rumble,
        [NativeTypeName("Uint16")] ushort right_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_RunApp")]
    int RunApp(
        int argc,
        [NativeTypeName("char *[]")] sbyte** argv,
        [NativeTypeName("SDL_main_func")] MainFunc mainFunction,
        void* reserved
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RunApp")]
    int RunApp(
        int argc,
        [NativeTypeName("char *[]")] Ref2D<sbyte> argv,
        [NativeTypeName("SDL_main_func")] MainFunc mainFunction,
        Ref reserved
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RunHapticEffect")]
    MaybeBool<byte> RunHapticEffect(
        HapticHandle haptic,
        int effect,
        [NativeTypeName("Uint32")] uint iterations
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RunHapticEffect")]
    byte RunHapticEffectRaw(
        HapticHandle haptic,
        int effect,
        [NativeTypeName("Uint32")] uint iterations
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RunOnMainThread")]
    byte RunOnMainThread(
        [NativeTypeName("SDL_MainThreadCallback")] MainThreadCallback callback,
        void* userdata,
        [NativeTypeName("bool")] byte wait_complete
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_RunOnMainThread")]
    MaybeBool<byte> RunOnMainThread(
        [NativeTypeName("SDL_MainThreadCallback")] MainThreadCallback callback,
        Ref userdata,
        [NativeTypeName("bool")] MaybeBool<byte> wait_complete
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP")]
    byte SaveBMP(Surface* surface, [NativeTypeName("const char *")] sbyte* file);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP")]
    MaybeBool<byte> SaveBMP(Ref<Surface> surface, [NativeTypeName("const char *")] Ref<sbyte> file);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP_IO")]
    byte SaveBMPIO(Surface* surface, IOStreamHandle dst, [NativeTypeName("bool")] byte closeio);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP_IO")]
    MaybeBool<byte> SaveBMPIO(
        Ref<Surface> surface,
        IOStreamHandle dst,
        [NativeTypeName("bool")] MaybeBool<byte> closeio
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile")]
    byte SaveFile(
        [NativeTypeName("const char *")] sbyte* file,
        [NativeTypeName("const void *")] void* data,
        [NativeTypeName("size_t")] nuint datasize
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile")]
    MaybeBool<byte> SaveFile(
        [NativeTypeName("const char *")] Ref<sbyte> file,
        [NativeTypeName("const void *")] Ref data,
        [NativeTypeName("size_t")] nuint datasize
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile_IO")]
    byte SaveFileIO(
        IOStreamHandle src,
        [NativeTypeName("const void *")] void* data,
        [NativeTypeName("size_t")] nuint datasize,
        [NativeTypeName("bool")] byte closeio
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile_IO")]
    MaybeBool<byte> SaveFileIO(
        IOStreamHandle src,
        [NativeTypeName("const void *")] Ref data,
        [NativeTypeName("size_t")] nuint datasize,
        [NativeTypeName("bool")] MaybeBool<byte> closeio
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_scalbn")]
    double Scalbn(double x, int n);

    [NativeFunction("SDL3", EntryPoint = "SDL_scalbnf")]
    float Scalbnf(float x, int n);

    [NativeFunction("SDL3", EntryPoint = "SDL_ScaleSurface")]
    Surface* ScaleSurface(Surface* surface, int width, int height, ScaleMode scaleMode);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScaleSurface")]
    Ptr<Surface> ScaleSurface(Ref<Surface> surface, int width, int height, ScaleMode scaleMode);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScreenKeyboardShown")]
    MaybeBool<byte> ScreenKeyboardShown(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScreenKeyboardShown")]
    byte ScreenKeyboardShownRaw(WindowHandle window);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScreenSaverEnabled")]
    MaybeBool<byte> ScreenSaverEnabled();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScreenSaverEnabled")]
    byte ScreenSaverEnabledRaw();

    [return: NativeTypeName("Sint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SeekIO")]
    nint SeekIO(IOStreamHandle context, [NativeTypeName("Sint64")] nint offset, IOWhence whence);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SendGamepadEffect")]
    byte SendGamepadEffect(
        GamepadHandle gamepad,
        [NativeTypeName("const void *")] void* data,
        int size
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SendGamepadEffect")]
    MaybeBool<byte> SendGamepadEffect(
        GamepadHandle gamepad,
        [NativeTypeName("const void *")] Ref data,
        int size
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickEffect")]
    byte SendJoystickEffect(
        JoystickHandle joystick,
        [NativeTypeName("const void *")] void* data,
        int size
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickEffect")]
    MaybeBool<byte> SendJoystickEffect(
        JoystickHandle joystick,
        [NativeTypeName("const void *")] Ref data,
        int size
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickVirtualSensorData")]
    byte SendJoystickVirtualSensorData(
        JoystickHandle joystick,
        SensorType type,
        [NativeTypeName("Uint64")] nuint sensor_timestamp,
        [NativeTypeName("const float *")] float* data,
        int num_values
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickVirtualSensorData")]
    MaybeBool<byte> SendJoystickVirtualSensorData(
        JoystickHandle joystick,
        SensorType type,
        [NativeTypeName("Uint64")] nuint sensor_timestamp,
        [NativeTypeName("const float *")] Ref<float> data,
        int num_values
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadata")]
    byte SetAppMetadata(
        [NativeTypeName("const char *")] sbyte* appname,
        [NativeTypeName("const char *")] sbyte* appversion,
        [NativeTypeName("const char *")] sbyte* appidentifier
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadata")]
    MaybeBool<byte> SetAppMetadata(
        [NativeTypeName("const char *")] Ref<sbyte> appname,
        [NativeTypeName("const char *")] Ref<sbyte> appversion,
        [NativeTypeName("const char *")] Ref<sbyte> appidentifier
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadataProperty")]
    byte SetAppMetadataProperty(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const char *")] sbyte* value
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadataProperty")]
    MaybeBool<byte> SetAppMetadataProperty(
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("const char *")] Ref<sbyte> value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetAssertionHandler")]
    void SetAssertionHandler(
        [NativeTypeName("SDL_AssertionHandler")] AssertionHandler handler,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAssertionHandler")]
    void SetAssertionHandler(
        [NativeTypeName("SDL_AssertionHandler")] AssertionHandler handler,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicInt")]
    int SetAtomicInt(AtomicInt* a, int v);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicInt")]
    int SetAtomicInt(Ref<AtomicInt> a, int v);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicPointer")]
    void* SetAtomicPointer(void** a, void* v);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicPointer")]
    Ptr SetAtomicPointer(Ref2D a, Ref v);

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicU32")]
    uint SetAtomicU32(AtomicU32* a, [NativeTypeName("Uint32")] uint v);

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicU32")]
    uint SetAtomicU32(Ref<AtomicU32> a, [NativeTypeName("Uint32")] uint v);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioDeviceGain")]
    MaybeBool<byte> SetAudioDeviceGain(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        float gain
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioDeviceGain")]
    byte SetAudioDeviceGainRaw([NativeTypeName("SDL_AudioDeviceID")] uint devid, float gain);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioPostmixCallback")]
    byte SetAudioPostmixCallback(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        [NativeTypeName("SDL_AudioPostmixCallback")] AudioPostmixCallback callback,
        void* userdata
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioPostmixCallback")]
    MaybeBool<byte> SetAudioPostmixCallback(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        [NativeTypeName("SDL_AudioPostmixCallback")] AudioPostmixCallback callback,
        Ref userdata
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFormat")]
    byte SetAudioStreamFormat(
        AudioStreamHandle stream,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* src_spec,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* dst_spec
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFormat")]
    MaybeBool<byte> SetAudioStreamFormat(
        AudioStreamHandle stream,
        [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> src_spec,
        [NativeTypeName("const SDL_AudioSpec *")] Ref<AudioSpec> dst_spec
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFrequencyRatio")]
    MaybeBool<byte> SetAudioStreamFrequencyRatio(AudioStreamHandle stream, float ratio);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFrequencyRatio")]
    byte SetAudioStreamFrequencyRatioRaw(AudioStreamHandle stream, float ratio);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGain")]
    MaybeBool<byte> SetAudioStreamGain(AudioStreamHandle stream, float gain);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGain")]
    byte SetAudioStreamGainRaw(AudioStreamHandle stream, float gain);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGetCallback")]
    byte SetAudioStreamGetCallback(
        AudioStreamHandle stream,
        [NativeTypeName("SDL_AudioStreamCallback")] AudioStreamCallback callback,
        void* userdata
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGetCallback")]
    MaybeBool<byte> SetAudioStreamGetCallback(
        AudioStreamHandle stream,
        [NativeTypeName("SDL_AudioStreamCallback")] AudioStreamCallback callback,
        Ref userdata
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamInputChannelMap")]
    byte SetAudioStreamInputChannelMap(
        AudioStreamHandle stream,
        [NativeTypeName("const int *")] int* chmap,
        int count
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamInputChannelMap")]
    MaybeBool<byte> SetAudioStreamInputChannelMap(
        AudioStreamHandle stream,
        [NativeTypeName("const int *")] Ref<int> chmap,
        int count
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamOutputChannelMap")]
    byte SetAudioStreamOutputChannelMap(
        AudioStreamHandle stream,
        [NativeTypeName("const int *")] int* chmap,
        int count
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamOutputChannelMap")]
    MaybeBool<byte> SetAudioStreamOutputChannelMap(
        AudioStreamHandle stream,
        [NativeTypeName("const int *")] Ref<int> chmap,
        int count
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamPutCallback")]
    byte SetAudioStreamPutCallback(
        AudioStreamHandle stream,
        [NativeTypeName("SDL_AudioStreamCallback")] AudioStreamCallback callback,
        void* userdata
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamPutCallback")]
    MaybeBool<byte> SetAudioStreamPutCallback(
        AudioStreamHandle stream,
        [NativeTypeName("SDL_AudioStreamCallback")] AudioStreamCallback callback,
        Ref userdata
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetBooleanProperty")]
    byte SetBooleanProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("bool")] byte value
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetBooleanProperty")]
    MaybeBool<byte> SetBooleanProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("bool")] MaybeBool<byte> value
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardData")]
    byte SetClipboardData(
        [NativeTypeName("SDL_ClipboardDataCallback")] ClipboardDataCallback callback,
        [NativeTypeName("SDL_ClipboardCleanupCallback")] ClipboardCleanupCallback cleanup,
        void* userdata,
        [NativeTypeName("const char **")] sbyte** mime_types,
        [NativeTypeName("size_t")] nuint num_mime_types
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardData")]
    MaybeBool<byte> SetClipboardData(
        [NativeTypeName("SDL_ClipboardDataCallback")] ClipboardDataCallback callback,
        [NativeTypeName("SDL_ClipboardCleanupCallback")] ClipboardCleanupCallback cleanup,
        Ref userdata,
        [NativeTypeName("const char **")] Ref2D<sbyte> mime_types,
        [NativeTypeName("size_t")] nuint num_mime_types
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardText")]
    byte SetClipboardText([NativeTypeName("const char *")] sbyte* text);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardText")]
    MaybeBool<byte> SetClipboardText([NativeTypeName("const char *")] Ref<sbyte> text);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetCurrentThreadPriority")]
    MaybeBool<byte> SetCurrentThreadPriority(ThreadPriority priority);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetCurrentThreadPriority")]
    byte SetCurrentThreadPriorityRaw(ThreadPriority priority);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetCursor")]
    MaybeBool<byte> SetCursor(CursorHandle cursor);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetCursor")]
    byte SetCursorRaw(CursorHandle cursor);

    [NativeFunction("SDL3", EntryPoint = "SDL_setenv_unsafe")]
    int SetenvUnsafe(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const char *")] sbyte* value,
        int overwrite
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_setenv_unsafe")]
    int SetenvUnsafe(
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("const char *")] Ref<sbyte> value,
        int overwrite
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetEnvironmentVariable")]
    byte SetEnvironmentVariable(
        EnvironmentHandle env,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const char *")] sbyte* value,
        [NativeTypeName("bool")] byte overwrite
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetEnvironmentVariable")]
    MaybeBool<byte> SetEnvironmentVariable(
        EnvironmentHandle env,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("const char *")] Ref<sbyte> value,
        [NativeTypeName("bool")] MaybeBool<byte> overwrite
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetErrorV")]
    byte SetErrorV(
        [NativeTypeName("const char *")] sbyte* fmt,
        [NativeTypeName("va_list")] VaListTagHandle ap
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetErrorV")]
    MaybeBool<byte> SetErrorV(
        [NativeTypeName("const char *")] Ref<sbyte> fmt,
        [NativeTypeName("va_list")] VaListTagHandle ap
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetEventEnabled")]
    void SetEventEnabled(
        [NativeTypeName("Uint32")] uint type,
        [NativeTypeName("bool")] byte enabled
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetEventEnabled")]
    void SetEventEnabled(
        [NativeTypeName("Uint32")] uint type,
        [NativeTypeName("bool")] MaybeBool<byte> enabled
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetEventFilter")]
    void SetEventFilter([NativeTypeName("SDL_EventFilter")] EventFilter filter, void* userdata);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetEventFilter")]
    void SetEventFilter([NativeTypeName("SDL_EventFilter")] EventFilter filter, Ref userdata);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetFloatProperty")]
    byte SetFloatProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        float value
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetFloatProperty")]
    MaybeBool<byte> SetFloatProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        float value
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadEventsEnabled")]
    void SetGamepadEventsEnabled([NativeTypeName("bool")] byte enabled);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadEventsEnabled")]
    void SetGamepadEventsEnabled([NativeTypeName("bool")] MaybeBool<byte> enabled);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadLED")]
    MaybeBool<byte> SetGamepadLED(
        GamepadHandle gamepad,
        [NativeTypeName("Uint8")] byte red,
        [NativeTypeName("Uint8")] byte green,
        [NativeTypeName("Uint8")] byte blue
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadLED")]
    byte SetGamepadLEDRaw(
        GamepadHandle gamepad,
        [NativeTypeName("Uint8")] byte red,
        [NativeTypeName("Uint8")] byte green,
        [NativeTypeName("Uint8")] byte blue
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadMapping")]
    byte SetGamepadMapping(
        [NativeTypeName("SDL_JoystickID")] uint instance_id,
        [NativeTypeName("const char *")] sbyte* mapping
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadMapping")]
    MaybeBool<byte> SetGamepadMapping(
        [NativeTypeName("SDL_JoystickID")] uint instance_id,
        [NativeTypeName("const char *")] Ref<sbyte> mapping
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadPlayerIndex")]
    MaybeBool<byte> SetGamepadPlayerIndex(GamepadHandle gamepad, int player_index);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadPlayerIndex")]
    byte SetGamepadPlayerIndexRaw(GamepadHandle gamepad, int player_index);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadSensorEnabled")]
    byte SetGamepadSensorEnabled(
        GamepadHandle gamepad,
        SensorType type,
        [NativeTypeName("bool")] byte enabled
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadSensorEnabled")]
    MaybeBool<byte> SetGamepadSensorEnabled(
        GamepadHandle gamepad,
        SensorType type,
        [NativeTypeName("bool")] MaybeBool<byte> enabled
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUAllowedFramesInFlight")]
    MaybeBool<byte> SetGPUAllowedFramesInFlight(
        GPUDeviceHandle device,
        [NativeTypeName("Uint32")] uint allowed_frames_in_flight
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUAllowedFramesInFlight")]
    byte SetGPUAllowedFramesInFlightRaw(
        GPUDeviceHandle device,
        [NativeTypeName("Uint32")] uint allowed_frames_in_flight
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUBlendConstants")]
    void SetGPUBlendConstants(GPURenderPassHandle render_pass, FColor blend_constants);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUBufferName")]
    void SetGPUBufferName(
        GPUDeviceHandle device,
        GPUBufferHandle buffer,
        [NativeTypeName("const char *")] sbyte* text
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUBufferName")]
    void SetGPUBufferName(
        GPUDeviceHandle device,
        GPUBufferHandle buffer,
        [NativeTypeName("const char *")] Ref<sbyte> text
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUScissor")]
    void SetGPUScissor(
        GPURenderPassHandle render_pass,
        [NativeTypeName("const SDL_Rect *")] Rect* scissor
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUScissor")]
    void SetGPUScissor(
        GPURenderPassHandle render_pass,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> scissor
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUStencilReference")]
    void SetGPUStencilReference(
        GPURenderPassHandle render_pass,
        [NativeTypeName("Uint8")] byte reference
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUSwapchainParameters")]
    MaybeBool<byte> SetGPUSwapchainParameters(
        GPUDeviceHandle device,
        WindowHandle window,
        GPUSwapchainComposition swapchain_composition,
        GPUPresentMode present_mode
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUSwapchainParameters")]
    byte SetGPUSwapchainParametersRaw(
        GPUDeviceHandle device,
        WindowHandle window,
        GPUSwapchainComposition swapchain_composition,
        GPUPresentMode present_mode
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUTextureName")]
    void SetGPUTextureName(
        GPUDeviceHandle device,
        GPUTextureHandle texture,
        [NativeTypeName("const char *")] sbyte* text
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUTextureName")]
    void SetGPUTextureName(
        GPUDeviceHandle device,
        GPUTextureHandle texture,
        [NativeTypeName("const char *")] Ref<sbyte> text
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUViewport")]
    void SetGPUViewport(
        GPURenderPassHandle render_pass,
        [NativeTypeName("const SDL_GPUViewport *")] GPUViewport* viewport
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUViewport")]
    void SetGPUViewport(
        GPURenderPassHandle render_pass,
        [NativeTypeName("const SDL_GPUViewport *")] Ref<GPUViewport> viewport
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticAutocenter")]
    MaybeBool<byte> SetHapticAutocenter(HapticHandle haptic, int autocenter);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticAutocenter")]
    byte SetHapticAutocenterRaw(HapticHandle haptic, int autocenter);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticGain")]
    MaybeBool<byte> SetHapticGain(HapticHandle haptic, int gain);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticGain")]
    byte SetHapticGainRaw(HapticHandle haptic, int gain);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHint")]
    byte SetHint(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const char *")] sbyte* value
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHint")]
    MaybeBool<byte> SetHint(
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("const char *")] Ref<sbyte> value
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHintWithPriority")]
    byte SetHintWithPriority(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const char *")] sbyte* value,
        HintPriority priority
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHintWithPriority")]
    MaybeBool<byte> SetHintWithPriority(
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("const char *")] Ref<sbyte> value,
        HintPriority priority
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetInitialized")]
    void SetInitialized(InitState* state, [NativeTypeName("bool")] byte initialized);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetInitialized")]
    void SetInitialized(Ref<InitState> state, [NativeTypeName("bool")] MaybeBool<byte> initialized);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickEventsEnabled")]
    void SetJoystickEventsEnabled([NativeTypeName("bool")] byte enabled);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickEventsEnabled")]
    void SetJoystickEventsEnabled([NativeTypeName("bool")] MaybeBool<byte> enabled);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickLED")]
    MaybeBool<byte> SetJoystickLED(
        JoystickHandle joystick,
        [NativeTypeName("Uint8")] byte red,
        [NativeTypeName("Uint8")] byte green,
        [NativeTypeName("Uint8")] byte blue
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickLED")]
    byte SetJoystickLEDRaw(
        JoystickHandle joystick,
        [NativeTypeName("Uint8")] byte red,
        [NativeTypeName("Uint8")] byte green,
        [NativeTypeName("Uint8")] byte blue
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickPlayerIndex")]
    MaybeBool<byte> SetJoystickPlayerIndex(JoystickHandle joystick, int player_index);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickPlayerIndex")]
    byte SetJoystickPlayerIndexRaw(JoystickHandle joystick, int player_index);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualAxis")]
    MaybeBool<byte> SetJoystickVirtualAxis(
        JoystickHandle joystick,
        int axis,
        [NativeTypeName("Sint16")] short value
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualAxis")]
    byte SetJoystickVirtualAxisRaw(
        JoystickHandle joystick,
        int axis,
        [NativeTypeName("Sint16")] short value
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualBall")]
    MaybeBool<byte> SetJoystickVirtualBall(
        JoystickHandle joystick,
        int ball,
        [NativeTypeName("Sint16")] short xrel,
        [NativeTypeName("Sint16")] short yrel
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualBall")]
    byte SetJoystickVirtualBallRaw(
        JoystickHandle joystick,
        int ball,
        [NativeTypeName("Sint16")] short xrel,
        [NativeTypeName("Sint16")] short yrel
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualButton")]
    byte SetJoystickVirtualButton(
        JoystickHandle joystick,
        int button,
        [NativeTypeName("bool")] byte down
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualButton")]
    MaybeBool<byte> SetJoystickVirtualButton(
        JoystickHandle joystick,
        int button,
        [NativeTypeName("bool")] MaybeBool<byte> down
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualHat")]
    MaybeBool<byte> SetJoystickVirtualHat(
        JoystickHandle joystick,
        int hat,
        [NativeTypeName("Uint8")] byte value
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualHat")]
    byte SetJoystickVirtualHatRaw(
        JoystickHandle joystick,
        int hat,
        [NativeTypeName("Uint8")] byte value
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualTouchpad")]
    byte SetJoystickVirtualTouchpad(
        JoystickHandle joystick,
        int touchpad,
        int finger,
        [NativeTypeName("bool")] byte down,
        float x,
        float y,
        float pressure
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualTouchpad")]
    MaybeBool<byte> SetJoystickVirtualTouchpad(
        JoystickHandle joystick,
        int touchpad,
        int finger,
        [NativeTypeName("bool")] MaybeBool<byte> down,
        float x,
        float y,
        float pressure
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetLinuxThreadPriority")]
    MaybeBool<byte> SetLinuxThreadPriority([NativeTypeName("Sint64")] nint threadID, int priority);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetLinuxThreadPriorityAndPolicy")]
    MaybeBool<byte> SetLinuxThreadPriorityAndPolicy(
        [NativeTypeName("Sint64")] nint threadID,
        int sdlPriority,
        int schedPolicy
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetLinuxThreadPriorityAndPolicy")]
    byte SetLinuxThreadPriorityAndPolicyRaw(
        [NativeTypeName("Sint64")] nint threadID,
        int sdlPriority,
        int schedPolicy
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetLinuxThreadPriority")]
    byte SetLinuxThreadPriorityRaw([NativeTypeName("Sint64")] nint threadID, int priority);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetLogOutputFunction")]
    void SetLogOutputFunction(
        [NativeTypeName("SDL_LogOutputFunction")] LogOutputFunction callback,
        void* userdata
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetLogOutputFunction")]
    void SetLogOutputFunction(
        [NativeTypeName("SDL_LogOutputFunction")] LogOutputFunction callback,
        Ref userdata
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriorities")]
    void SetLogPriorities(LogPriority priority);

    [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriority")]
    void SetLogPriority(int category, LogPriority priority);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriorityPrefix")]
    byte SetLogPriorityPrefix(LogPriority priority, [NativeTypeName("const char *")] sbyte* prefix);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriorityPrefix")]
    MaybeBool<byte> SetLogPriorityPrefix(
        LogPriority priority,
        [NativeTypeName("const char *")] Ref<sbyte> prefix
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetMainReady")]
    void SetMainReady();

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetMemoryFunctions")]
    MaybeBool<byte> SetMemoryFunctions(
        [NativeTypeName("SDL_malloc_func")] MallocFunc malloc_func,
        [NativeTypeName("SDL_calloc_func")] CallocFunc calloc_func,
        [NativeTypeName("SDL_realloc_func")] ReallocFunc realloc_func,
        [NativeTypeName("SDL_free_func")] FreeFunc free_func
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetMemoryFunctions")]
    byte SetMemoryFunctionsRaw(
        [NativeTypeName("SDL_malloc_func")] MallocFunc malloc_func,
        [NativeTypeName("SDL_calloc_func")] CallocFunc calloc_func,
        [NativeTypeName("SDL_realloc_func")] ReallocFunc realloc_func,
        [NativeTypeName("SDL_free_func")] FreeFunc free_func
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_SetModState")]
    void SetModState([NativeTypeName("SDL_Keymod")] ushort modstate);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetNumberProperty")]
    byte SetNumberProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("Sint64")] nint value
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetNumberProperty")]
    MaybeBool<byte> SetNumberProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("Sint64")] nint value
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPaletteColors")]
    byte SetPaletteColors(
        Palette* palette,
        [NativeTypeName("const SDL_Color *")] Color* colors,
        int firstcolor,
        int ncolors
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPaletteColors")]
    MaybeBool<byte> SetPaletteColors(
        Ref<Palette> palette,
        [NativeTypeName("const SDL_Color *")] Ref<Color> colors,
        int firstcolor,
        int ncolors
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerProperty")]
    byte SetPointerProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        void* value
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerProperty")]
    MaybeBool<byte> SetPointerProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        Ref value
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerPropertyWithCleanup")]
    byte SetPointerPropertyWithCleanup(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        void* value,
        [NativeTypeName("SDL_CleanupPropertyCallback")] CleanupPropertyCallback cleanup,
        void* userdata
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerPropertyWithCleanup")]
    MaybeBool<byte> SetPointerPropertyWithCleanup(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        Ref value,
        [NativeTypeName("SDL_CleanupPropertyCallback")] CleanupPropertyCallback cleanup,
        Ref userdata
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPrimarySelectionText")]
    byte SetPrimarySelectionText([NativeTypeName("const char *")] sbyte* text);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPrimarySelectionText")]
    MaybeBool<byte> SetPrimarySelectionText([NativeTypeName("const char *")] Ref<sbyte> text);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderClipRect")]
    byte SetRenderClipRect(
        RendererHandle renderer,
        [NativeTypeName("const SDL_Rect *")] Rect* rect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderClipRect")]
    MaybeBool<byte> SetRenderClipRect(
        RendererHandle renderer,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderColorScale")]
    MaybeBool<byte> SetRenderColorScale(RendererHandle renderer, float scale);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderColorScale")]
    byte SetRenderColorScaleRaw(RendererHandle renderer, float scale);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawBlendMode")]
    MaybeBool<byte> SetRenderDrawBlendMode(
        RendererHandle renderer,
        [NativeTypeName("SDL_BlendMode")] BlendMode blendMode
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawBlendMode")]
    byte SetRenderDrawBlendModeRaw(
        RendererHandle renderer,
        [NativeTypeName("SDL_BlendMode")] BlendMode blendMode
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColor")]
    MaybeBool<byte> SetRenderDrawColor(
        RendererHandle renderer,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b,
        [NativeTypeName("Uint8")] byte a
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColorFloat")]
    MaybeBool<byte> SetRenderDrawColorFloat(
        RendererHandle renderer,
        float r,
        float g,
        float b,
        float a
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColorFloat")]
    byte SetRenderDrawColorFloatRaw(RendererHandle renderer, float r, float g, float b, float a);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColor")]
    byte SetRenderDrawColorRaw(
        RendererHandle renderer,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b,
        [NativeTypeName("Uint8")] byte a
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderLogicalPresentation")]
    MaybeBool<byte> SetRenderLogicalPresentation(
        RendererHandle renderer,
        int w,
        int h,
        RendererLogicalPresentation mode
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderLogicalPresentation")]
    byte SetRenderLogicalPresentationRaw(
        RendererHandle renderer,
        int w,
        int h,
        RendererLogicalPresentation mode
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderScale")]
    MaybeBool<byte> SetRenderScale(RendererHandle renderer, float scaleX, float scaleY);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderScale")]
    byte SetRenderScaleRaw(RendererHandle renderer, float scaleX, float scaleY);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderTarget")]
    byte SetRenderTarget(RendererHandle renderer, Texture* texture);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderTarget")]
    MaybeBool<byte> SetRenderTarget(RendererHandle renderer, Ref<Texture> texture);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderViewport")]
    byte SetRenderViewport(
        RendererHandle renderer,
        [NativeTypeName("const SDL_Rect *")] Rect* rect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderViewport")]
    MaybeBool<byte> SetRenderViewport(
        RendererHandle renderer,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderVSync")]
    MaybeBool<byte> SetRenderVSync(RendererHandle renderer, int vsync);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderVSync")]
    byte SetRenderVSyncRaw(RendererHandle renderer, int vsync);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetScancodeName")]
    byte SetScancodeName(Scancode scancode, [NativeTypeName("const char *")] sbyte* name);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetScancodeName")]
    MaybeBool<byte> SetScancodeName(
        Scancode scancode,
        [NativeTypeName("const char *")] Ref<sbyte> name
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetStringProperty")]
    byte SetStringProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const char *")] sbyte* value
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetStringProperty")]
    MaybeBool<byte> SetStringProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] Ref<sbyte> name,
        [NativeTypeName("const char *")] Ref<sbyte> value
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceAlphaMod")]
    byte SetSurfaceAlphaMod(Surface* surface, [NativeTypeName("Uint8")] byte alpha);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceAlphaMod")]
    MaybeBool<byte> SetSurfaceAlphaMod(Ref<Surface> surface, [NativeTypeName("Uint8")] byte alpha);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceBlendMode")]
    byte SetSurfaceBlendMode(
        Surface* surface,
        [NativeTypeName("SDL_BlendMode")] BlendMode blendMode
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceBlendMode")]
    MaybeBool<byte> SetSurfaceBlendMode(
        Ref<Surface> surface,
        [NativeTypeName("SDL_BlendMode")] BlendMode blendMode
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceClipRect")]
    byte SetSurfaceClipRect(Surface* surface, [NativeTypeName("const SDL_Rect *")] Rect* rect);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceClipRect")]
    MaybeBool<byte> SetSurfaceClipRect(
        Ref<Surface> surface,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorKey")]
    byte SetSurfaceColorKey(
        Surface* surface,
        [NativeTypeName("bool")] byte enabled,
        [NativeTypeName("Uint32")] uint key
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorKey")]
    MaybeBool<byte> SetSurfaceColorKey(
        Ref<Surface> surface,
        [NativeTypeName("bool")] MaybeBool<byte> enabled,
        [NativeTypeName("Uint32")] uint key
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorMod")]
    byte SetSurfaceColorMod(
        Surface* surface,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorMod")]
    MaybeBool<byte> SetSurfaceColorMod(
        Ref<Surface> surface,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorspace")]
    byte SetSurfaceColorspace(Surface* surface, Colorspace colorspace);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorspace")]
    MaybeBool<byte> SetSurfaceColorspace(Ref<Surface> surface, Colorspace colorspace);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfacePalette")]
    byte SetSurfacePalette(Surface* surface, Palette* palette);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfacePalette")]
    MaybeBool<byte> SetSurfacePalette(Ref<Surface> surface, Ref<Palette> palette);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceRLE")]
    byte SetSurfaceRLE(Surface* surface, [NativeTypeName("bool")] byte enabled);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceRLE")]
    MaybeBool<byte> SetSurfaceRLE(
        Ref<Surface> surface,
        [NativeTypeName("bool")] MaybeBool<byte> enabled
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextInputArea")]
    byte SetTextInputArea(
        WindowHandle window,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        int cursor
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextInputArea")]
    MaybeBool<byte> SetTextInputArea(
        WindowHandle window,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        int cursor
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaMod")]
    byte SetTextureAlphaMod(Texture* texture, [NativeTypeName("Uint8")] byte alpha);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaMod")]
    MaybeBool<byte> SetTextureAlphaMod(Ref<Texture> texture, [NativeTypeName("Uint8")] byte alpha);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaModFloat")]
    byte SetTextureAlphaModFloat(Texture* texture, float alpha);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaModFloat")]
    MaybeBool<byte> SetTextureAlphaModFloat(Ref<Texture> texture, float alpha);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureBlendMode")]
    byte SetTextureBlendMode(
        Texture* texture,
        [NativeTypeName("SDL_BlendMode")] BlendMode blendMode
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureBlendMode")]
    MaybeBool<byte> SetTextureBlendMode(
        Ref<Texture> texture,
        [NativeTypeName("SDL_BlendMode")] BlendMode blendMode
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorMod")]
    byte SetTextureColorMod(
        Texture* texture,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorMod")]
    MaybeBool<byte> SetTextureColorMod(
        Ref<Texture> texture,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorModFloat")]
    byte SetTextureColorModFloat(Texture* texture, float r, float g, float b);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorModFloat")]
    MaybeBool<byte> SetTextureColorModFloat(Ref<Texture> texture, float r, float g, float b);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureScaleMode")]
    byte SetTextureScaleMode(Texture* texture, ScaleMode scaleMode);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureScaleMode")]
    MaybeBool<byte> SetTextureScaleMode(Ref<Texture> texture, ScaleMode scaleMode);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTLS")]
    byte SetTLS(
        [NativeTypeName("SDL_TLSID *")] AtomicInt* id,
        [NativeTypeName("const void *")] void* value,
        [NativeTypeName("SDL_TLSDestructorCallback")] TLSDestructorCallback destructor
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTLS")]
    MaybeBool<byte> SetTLS(
        [NativeTypeName("SDL_TLSID *")] Ref<AtomicInt> id,
        [NativeTypeName("const void *")] Ref value,
        [NativeTypeName("SDL_TLSDestructorCallback")] TLSDestructorCallback destructor
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAlwaysOnTop")]
    byte SetWindowAlwaysOnTop(WindowHandle window, [NativeTypeName("bool")] byte on_top);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAlwaysOnTop")]
    MaybeBool<byte> SetWindowAlwaysOnTop(
        WindowHandle window,
        [NativeTypeName("bool")] MaybeBool<byte> on_top
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAspectRatio")]
    MaybeBool<byte> SetWindowAspectRatio(WindowHandle window, float min_aspect, float max_aspect);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAspectRatio")]
    byte SetWindowAspectRatioRaw(WindowHandle window, float min_aspect, float max_aspect);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowBordered")]
    byte SetWindowBordered(WindowHandle window, [NativeTypeName("bool")] byte bordered);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowBordered")]
    MaybeBool<byte> SetWindowBordered(
        WindowHandle window,
        [NativeTypeName("bool")] MaybeBool<byte> bordered
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFocusable")]
    byte SetWindowFocusable(WindowHandle window, [NativeTypeName("bool")] byte focusable);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFocusable")]
    MaybeBool<byte> SetWindowFocusable(
        WindowHandle window,
        [NativeTypeName("bool")] MaybeBool<byte> focusable
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreen")]
    byte SetWindowFullscreen(WindowHandle window, [NativeTypeName("bool")] byte fullscreen);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreen")]
    MaybeBool<byte> SetWindowFullscreen(
        WindowHandle window,
        [NativeTypeName("bool")] MaybeBool<byte> fullscreen
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreenMode")]
    byte SetWindowFullscreenMode(
        WindowHandle window,
        [NativeTypeName("const SDL_DisplayMode *")] DisplayMode* mode
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreenMode")]
    MaybeBool<byte> SetWindowFullscreenMode(
        WindowHandle window,
        [NativeTypeName("const SDL_DisplayMode *")] Ref<DisplayMode> mode
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowHitTest")]
    byte SetWindowHitTest(
        WindowHandle window,
        [NativeTypeName("SDL_HitTest")] HitTest callback,
        void* callback_data
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowHitTest")]
    MaybeBool<byte> SetWindowHitTest(
        WindowHandle window,
        [NativeTypeName("SDL_HitTest")] HitTest callback,
        Ref callback_data
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowIcon")]
    byte SetWindowIcon(WindowHandle window, Surface* icon);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowIcon")]
    MaybeBool<byte> SetWindowIcon(WindowHandle window, Ref<Surface> icon);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowKeyboardGrab")]
    byte SetWindowKeyboardGrab(WindowHandle window, [NativeTypeName("bool")] byte grabbed);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowKeyboardGrab")]
    MaybeBool<byte> SetWindowKeyboardGrab(
        WindowHandle window,
        [NativeTypeName("bool")] MaybeBool<byte> grabbed
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMaximumSize")]
    MaybeBool<byte> SetWindowMaximumSize(WindowHandle window, int max_w, int max_h);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMaximumSize")]
    byte SetWindowMaximumSizeRaw(WindowHandle window, int max_w, int max_h);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMinimumSize")]
    MaybeBool<byte> SetWindowMinimumSize(WindowHandle window, int min_w, int min_h);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMinimumSize")]
    byte SetWindowMinimumSizeRaw(WindowHandle window, int min_w, int min_h);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowModal")]
    byte SetWindowModal(WindowHandle window, [NativeTypeName("bool")] byte modal);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowModal")]
    MaybeBool<byte> SetWindowModal(
        WindowHandle window,
        [NativeTypeName("bool")] MaybeBool<byte> modal
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseGrab")]
    byte SetWindowMouseGrab(WindowHandle window, [NativeTypeName("bool")] byte grabbed);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseGrab")]
    MaybeBool<byte> SetWindowMouseGrab(
        WindowHandle window,
        [NativeTypeName("bool")] MaybeBool<byte> grabbed
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseRect")]
    byte SetWindowMouseRect(WindowHandle window, [NativeTypeName("const SDL_Rect *")] Rect* rect);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseRect")]
    MaybeBool<byte> SetWindowMouseRect(
        WindowHandle window,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowOpacity")]
    MaybeBool<byte> SetWindowOpacity(WindowHandle window, float opacity);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowOpacity")]
    byte SetWindowOpacityRaw(WindowHandle window, float opacity);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowParent")]
    MaybeBool<byte> SetWindowParent(WindowHandle window, WindowHandle parent);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowParent")]
    byte SetWindowParentRaw(WindowHandle window, WindowHandle parent);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowPosition")]
    MaybeBool<byte> SetWindowPosition(WindowHandle window, int x, int y);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowPosition")]
    byte SetWindowPositionRaw(WindowHandle window, int x, int y);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowRelativeMouseMode")]
    byte SetWindowRelativeMouseMode(WindowHandle window, [NativeTypeName("bool")] byte enabled);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowRelativeMouseMode")]
    MaybeBool<byte> SetWindowRelativeMouseMode(
        WindowHandle window,
        [NativeTypeName("bool")] MaybeBool<byte> enabled
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowResizable")]
    byte SetWindowResizable(WindowHandle window, [NativeTypeName("bool")] byte resizable);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowResizable")]
    MaybeBool<byte> SetWindowResizable(
        WindowHandle window,
        [NativeTypeName("bool")] MaybeBool<byte> resizable
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowShape")]
    byte SetWindowShape(WindowHandle window, Surface* shape);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowShape")]
    MaybeBool<byte> SetWindowShape(WindowHandle window, Ref<Surface> shape);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSize")]
    MaybeBool<byte> SetWindowSize(WindowHandle window, int w, int h);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSize")]
    byte SetWindowSizeRaw(WindowHandle window, int w, int h);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSurfaceVSync")]
    MaybeBool<byte> SetWindowSurfaceVSync(WindowHandle window, int vsync);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSurfaceVSync")]
    byte SetWindowSurfaceVSyncRaw(WindowHandle window, int vsync);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowTitle")]
    byte SetWindowTitle(WindowHandle window, [NativeTypeName("const char *")] sbyte* title);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowTitle")]
    MaybeBool<byte> SetWindowTitle(
        WindowHandle window,
        [NativeTypeName("const char *")] Ref<sbyte> title
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShouldInit")]
    byte ShouldInit(InitState* state);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShouldInit")]
    MaybeBool<byte> ShouldInit(Ref<InitState> state);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShouldQuit")]
    byte ShouldQuit(InitState* state);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShouldQuit")]
    MaybeBool<byte> ShouldQuit(Ref<InitState> state);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowCursor")]
    MaybeBool<byte> ShowCursor();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowCursor")]
    byte ShowCursorRaw();

    [NativeFunction("SDL3", EntryPoint = "SDL_ShowFileDialogWithProperties")]
    void ShowFileDialogWithProperties(
        FileDialogType type,
        [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
        void* userdata,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowFileDialogWithProperties")]
    void ShowFileDialogWithProperties(
        FileDialogType type,
        [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
        Ref userdata,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowMessageBox")]
    byte ShowMessageBox(
        [NativeTypeName("const SDL_MessageBoxData *")] MessageBoxData* messageboxdata,
        int* buttonid
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowMessageBox")]
    MaybeBool<byte> ShowMessageBox(
        [NativeTypeName("const SDL_MessageBoxData *")] Ref<MessageBoxData> messageboxdata,
        Ref<int> buttonid
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFileDialog")]
    void ShowOpenFileDialog(
        [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
        void* userdata,
        WindowHandle window,
        [NativeTypeName("const SDL_DialogFileFilter *")] DialogFileFilter* filters,
        int nfilters,
        [NativeTypeName("const char *")] sbyte* default_location,
        [NativeTypeName("bool")] byte allow_many
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFileDialog")]
    void ShowOpenFileDialog(
        [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
        Ref userdata,
        WindowHandle window,
        [NativeTypeName("const SDL_DialogFileFilter *")] Ref<DialogFileFilter> filters,
        int nfilters,
        [NativeTypeName("const char *")] Ref<sbyte> default_location,
        [NativeTypeName("bool")] MaybeBool<byte> allow_many
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFolderDialog")]
    void ShowOpenFolderDialog(
        [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
        void* userdata,
        WindowHandle window,
        [NativeTypeName("const char *")] sbyte* default_location,
        [NativeTypeName("bool")] byte allow_many
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFolderDialog")]
    void ShowOpenFolderDialog(
        [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
        Ref userdata,
        WindowHandle window,
        [NativeTypeName("const char *")] Ref<sbyte> default_location,
        [NativeTypeName("bool")] MaybeBool<byte> allow_many
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_ShowSaveFileDialog")]
    void ShowSaveFileDialog(
        [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
        void* userdata,
        WindowHandle window,
        [NativeTypeName("const SDL_DialogFileFilter *")] DialogFileFilter* filters,
        int nfilters,
        [NativeTypeName("const char *")] sbyte* default_location
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowSaveFileDialog")]
    void ShowSaveFileDialog(
        [NativeTypeName("SDL_DialogFileCallback")] DialogFileCallback callback,
        Ref userdata,
        WindowHandle window,
        [NativeTypeName("const SDL_DialogFileFilter *")] Ref<DialogFileFilter> filters,
        int nfilters,
        [NativeTypeName("const char *")] Ref<sbyte> default_location
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowSimpleMessageBox")]
    byte ShowSimpleMessageBox(
        [NativeTypeName("SDL_MessageBoxFlags")] uint flags,
        [NativeTypeName("const char *")] sbyte* title,
        [NativeTypeName("const char *")] sbyte* message,
        WindowHandle window
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowSimpleMessageBox")]
    MaybeBool<byte> ShowSimpleMessageBox(
        [NativeTypeName("SDL_MessageBoxFlags")] uint flags,
        [NativeTypeName("const char *")] Ref<sbyte> title,
        [NativeTypeName("const char *")] Ref<sbyte> message,
        WindowHandle window
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindow")]
    MaybeBool<byte> ShowWindow(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindow")]
    byte ShowWindowRaw(WindowHandle window);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindowSystemMenu")]
    MaybeBool<byte> ShowWindowSystemMenu(WindowHandle window, int x, int y);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindowSystemMenu")]
    byte ShowWindowSystemMenuRaw(WindowHandle window, int x, int y);

    [NativeFunction("SDL3", EntryPoint = "SDL_SignalCondition")]
    void SignalCondition(ConditionHandle cond);

    [NativeFunction("SDL3", EntryPoint = "SDL_SignalSemaphore")]
    void SignalSemaphore(SemaphoreHandle sem);

    [NativeFunction("SDL3", EntryPoint = "SDL_sin")]
    double Sin(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_sinf")]
    float Sinf(float x);

    [NativeFunction("SDL3", EntryPoint = "SDL_sqrt")]
    double Sqrt(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_sqrtf")]
    float Sqrtf(float x);

    [NativeFunction("SDL3", EntryPoint = "SDL_srand")]
    void Srand([NativeTypeName("Uint64")] nuint seed);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInput")]
    MaybeBool<byte> StartTextInput(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInput")]
    byte StartTextInputRaw(WindowHandle window);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInputWithProperties")]
    MaybeBool<byte> StartTextInputWithProperties(
        WindowHandle window,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInputWithProperties")]
    byte StartTextInputWithPropertiesRaw(
        WindowHandle window,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StepBackUTF8")]
    uint StepBackUTF8(
        [NativeTypeName("const char *")] sbyte* start,
        [NativeTypeName("const char **")] sbyte** pstr
    );

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_StepBackUTF8")]
    uint StepBackUTF8(
        [NativeTypeName("const char *")] Ref<sbyte> start,
        [NativeTypeName("const char **")] Ref2D<sbyte> pstr
    );

    [return: NativeTypeName("Uint32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StepUTF8")]
    uint StepUTF8(
        [NativeTypeName("const char **")] sbyte** pstr,
        [NativeTypeName("size_t *")] nuint* pslen
    );

    [return: NativeTypeName("Uint32")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_StepUTF8")]
    uint StepUTF8(
        [NativeTypeName("const char **")] Ref2D<sbyte> pstr,
        [NativeTypeName("size_t *")] Ref<nuint> pslen
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffect")]
    MaybeBool<byte> StopHapticEffect(HapticHandle haptic, int effect);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffect")]
    byte StopHapticEffectRaw(HapticHandle haptic, int effect);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffects")]
    MaybeBool<byte> StopHapticEffects(HapticHandle haptic);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffects")]
    byte StopHapticEffectsRaw(HapticHandle haptic);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticRumble")]
    MaybeBool<byte> StopHapticRumble(HapticHandle haptic);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticRumble")]
    byte StopHapticRumbleRaw(HapticHandle haptic);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopTextInput")]
    MaybeBool<byte> StopTextInput(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopTextInput")]
    byte StopTextInputRaw(WindowHandle window);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_StorageReady")]
    MaybeBool<byte> StorageReady(StorageHandle storage);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StorageReady")]
    byte StorageReadyRaw(StorageHandle storage);

    [NativeFunction("SDL3", EntryPoint = "SDL_strcasecmp")]
    int Strcasecmp(
        [NativeTypeName("const char *")] sbyte* str1,
        [NativeTypeName("const char *")] sbyte* str2
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strcasecmp")]
    int Strcasecmp(
        [NativeTypeName("const char *")] Ref<sbyte> str1,
        [NativeTypeName("const char *")] Ref<sbyte> str2
    );

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strcasestr")]
    sbyte* Strcasestr(
        [NativeTypeName("const char *")] sbyte* haystack,
        [NativeTypeName("const char *")] sbyte* needle
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strcasestr")]
    Ptr<sbyte> Strcasestr(
        [NativeTypeName("const char *")] Ref<sbyte> haystack,
        [NativeTypeName("const char *")] Ref<sbyte> needle
    );

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strchr")]
    sbyte* Strchr([NativeTypeName("const char *")] sbyte* str, int c);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strchr")]
    Ptr<sbyte> Strchr([NativeTypeName("const char *")] Ref<sbyte> str, int c);

    [NativeFunction("SDL3", EntryPoint = "SDL_strcmp")]
    int Strcmp(
        [NativeTypeName("const char *")] sbyte* str1,
        [NativeTypeName("const char *")] sbyte* str2
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strcmp")]
    int Strcmp(
        [NativeTypeName("const char *")] Ref<sbyte> str1,
        [NativeTypeName("const char *")] Ref<sbyte> str2
    );

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strdup")]
    sbyte* Strdup([NativeTypeName("const char *")] sbyte* str);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strdup")]
    Ptr<sbyte> Strdup([NativeTypeName("const char *")] Ref<sbyte> str);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StretchSurface")]
    byte StretchSurface(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* dstrect,
        ScaleMode scaleMode
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_StretchSurface")]
    MaybeBool<byte> StretchSurface(
        Ref<Surface> src,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> srcrect,
        Ref<Surface> dst,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> dstrect,
        ScaleMode scaleMode
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_StringToGUID")]
    Guid StringToGuid([NativeTypeName("const char *")] sbyte* pchGUID);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_StringToGUID")]
    Guid StringToGuid([NativeTypeName("const char *")] Ref<sbyte> pchGUID);

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlcat")]
    nuint Strlcat(
        [NativeTypeName("char *")] sbyte* dst,
        [NativeTypeName("const char *")] sbyte* src,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlcat")]
    nuint Strlcat(
        [NativeTypeName("char *")] Ref<sbyte> dst,
        [NativeTypeName("const char *")] Ref<sbyte> src,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlcpy")]
    nuint Strlcpy(
        [NativeTypeName("char *")] sbyte* dst,
        [NativeTypeName("const char *")] sbyte* src,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlcpy")]
    nuint Strlcpy(
        [NativeTypeName("char *")] Ref<sbyte> dst,
        [NativeTypeName("const char *")] Ref<sbyte> src,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlen")]
    nuint Strlen([NativeTypeName("const char *")] sbyte* str);

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlen")]
    nuint Strlen([NativeTypeName("const char *")] Ref<sbyte> str);

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlwr")]
    sbyte* Strlwr([NativeTypeName("char *")] sbyte* str);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlwr")]
    Ptr<sbyte> Strlwr([NativeTypeName("char *")] Ref<sbyte> str);

    [NativeFunction("SDL3", EntryPoint = "SDL_strncasecmp")]
    int Strncasecmp(
        [NativeTypeName("const char *")] sbyte* str1,
        [NativeTypeName("const char *")] sbyte* str2,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strncasecmp")]
    int Strncasecmp(
        [NativeTypeName("const char *")] Ref<sbyte> str1,
        [NativeTypeName("const char *")] Ref<sbyte> str2,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_strncmp")]
    int Strncmp(
        [NativeTypeName("const char *")] sbyte* str1,
        [NativeTypeName("const char *")] sbyte* str2,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strncmp")]
    int Strncmp(
        [NativeTypeName("const char *")] Ref<sbyte> str1,
        [NativeTypeName("const char *")] Ref<sbyte> str2,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strndup")]
    sbyte* Strndup(
        [NativeTypeName("const char *")] sbyte* str,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strndup")]
    Ptr<sbyte> Strndup(
        [NativeTypeName("const char *")] Ref<sbyte> str,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strnlen")]
    nuint Strnlen(
        [NativeTypeName("const char *")] sbyte* str,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strnlen")]
    nuint Strnlen(
        [NativeTypeName("const char *")] Ref<sbyte> str,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strnstr")]
    sbyte* Strnstr(
        [NativeTypeName("const char *")] sbyte* haystack,
        [NativeTypeName("const char *")] sbyte* needle,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strnstr")]
    Ptr<sbyte> Strnstr(
        [NativeTypeName("const char *")] Ref<sbyte> haystack,
        [NativeTypeName("const char *")] Ref<sbyte> needle,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strpbrk")]
    sbyte* Strpbrk(
        [NativeTypeName("const char *")] sbyte* str,
        [NativeTypeName("const char *")] sbyte* breakset
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strpbrk")]
    Ptr<sbyte> Strpbrk(
        [NativeTypeName("const char *")] Ref<sbyte> str,
        [NativeTypeName("const char *")] Ref<sbyte> breakset
    );

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strrchr")]
    sbyte* Strrchr([NativeTypeName("const char *")] sbyte* str, int c);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strrchr")]
    Ptr<sbyte> Strrchr([NativeTypeName("const char *")] Ref<sbyte> str, int c);

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strrev")]
    sbyte* Strrev([NativeTypeName("char *")] sbyte* str);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strrev")]
    Ptr<sbyte> Strrev([NativeTypeName("char *")] Ref<sbyte> str);

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strstr")]
    sbyte* Strstr(
        [NativeTypeName("const char *")] sbyte* haystack,
        [NativeTypeName("const char *")] sbyte* needle
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strstr")]
    Ptr<sbyte> Strstr(
        [NativeTypeName("const char *")] Ref<sbyte> haystack,
        [NativeTypeName("const char *")] Ref<sbyte> needle
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_strtod")]
    double Strtod(
        [NativeTypeName("const char *")] sbyte* str,
        [NativeTypeName("char **")] sbyte** endp
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtod")]
    double Strtod(
        [NativeTypeName("const char *")] Ref<sbyte> str,
        [NativeTypeName("char **")] Ref2D<sbyte> endp
    );

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtok_r")]
    sbyte* StrtokR(
        [NativeTypeName("char *")] sbyte* str,
        [NativeTypeName("const char *")] sbyte* delim,
        [NativeTypeName("char **")] sbyte** saveptr
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtok_r")]
    Ptr<sbyte> StrtokR(
        [NativeTypeName("char *")] Ref<sbyte> str,
        [NativeTypeName("const char *")] Ref<sbyte> delim,
        [NativeTypeName("char **")] Ref2D<sbyte> saveptr
    );

    [return: NativeTypeName("long")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtol")]
    nint Strtol(
        [NativeTypeName("const char *")] sbyte* str,
        [NativeTypeName("char **")] sbyte** endp,
        int @base
    );

    [return: NativeTypeName("long")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtol")]
    nint Strtol(
        [NativeTypeName("const char *")] Ref<sbyte> str,
        [NativeTypeName("char **")] Ref2D<sbyte> endp,
        int @base
    );

    [return: NativeTypeName("long long")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtoll")]
    long Strtoll(
        [NativeTypeName("const char *")] sbyte* str,
        [NativeTypeName("char **")] sbyte** endp,
        int @base
    );

    [return: NativeTypeName("long long")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtoll")]
    long Strtoll(
        [NativeTypeName("const char *")] Ref<sbyte> str,
        [NativeTypeName("char **")] Ref2D<sbyte> endp,
        int @base
    );

    [return: NativeTypeName("unsigned long")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtoul")]
    nuint Strtoul(
        [NativeTypeName("const char *")] sbyte* str,
        [NativeTypeName("char **")] sbyte** endp,
        int @base
    );

    [return: NativeTypeName("unsigned long")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtoul")]
    nuint Strtoul(
        [NativeTypeName("const char *")] Ref<sbyte> str,
        [NativeTypeName("char **")] Ref2D<sbyte> endp,
        int @base
    );

    [return: NativeTypeName("unsigned long long")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtoull")]
    ulong Strtoull(
        [NativeTypeName("const char *")] sbyte* str,
        [NativeTypeName("char **")] sbyte** endp,
        int @base
    );

    [return: NativeTypeName("unsigned long long")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtoull")]
    ulong Strtoull(
        [NativeTypeName("const char *")] Ref<sbyte> str,
        [NativeTypeName("char **")] Ref2D<sbyte> endp,
        int @base
    );

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strupr")]
    sbyte* Strupr([NativeTypeName("char *")] sbyte* str);

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_strupr")]
    Ptr<sbyte> Strupr([NativeTypeName("char *")] Ref<sbyte> str);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SubmitGPUCommandBuffer")]
    MaybeBool<byte> SubmitGPUCommandBuffer(GPUCommandBufferHandle command_buffer);

    [NativeFunction("SDL3", EntryPoint = "SDL_SubmitGPUCommandBufferAndAcquireFence")]
    GPUFenceHandle SubmitGPUCommandBufferAndAcquireFence(GPUCommandBufferHandle command_buffer);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SubmitGPUCommandBuffer")]
    byte SubmitGPUCommandBufferRaw(GPUCommandBufferHandle command_buffer);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasAlternateImages")]
    byte SurfaceHasAlternateImages(Surface* surface);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasAlternateImages")]
    MaybeBool<byte> SurfaceHasAlternateImages(Ref<Surface> surface);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasColorKey")]
    byte SurfaceHasColorKey(Surface* surface);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasColorKey")]
    MaybeBool<byte> SurfaceHasColorKey(Ref<Surface> surface);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasRLE")]
    byte SurfaceHasRLE(Surface* surface);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasRLE")]
    MaybeBool<byte> SurfaceHasRLE(Ref<Surface> surface);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_SyncWindow")]
    MaybeBool<byte> SyncWindow(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SyncWindow")]
    byte SyncWindowRaw(WindowHandle window);

    [NativeFunction("SDL3", EntryPoint = "SDL_tan")]
    double Tan(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_tanf")]
    float Tanf(float x);

    [return: NativeTypeName("Sint64")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TellIO")]
    nint TellIO(IOStreamHandle context);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_TextInputActive")]
    MaybeBool<byte> TextInputActive(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TextInputActive")]
    byte TextInputActiveRaw(WindowHandle window);

    [return: NativeTypeName("SDL_Time")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TimeFromWindows")]
    nint TimeFromWindows(
        [NativeTypeName("Uint32")] uint dwLowDateTime,
        [NativeTypeName("Uint32")] uint dwHighDateTime
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TimeToDateTime")]
    byte TimeToDateTime(
        [NativeTypeName("SDL_Time")] nint ticks,
        DateTime* dt,
        [NativeTypeName("bool")] byte localTime
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_TimeToDateTime")]
    MaybeBool<byte> TimeToDateTime(
        [NativeTypeName("SDL_Time")] nint ticks,
        Ref<DateTime> dt,
        [NativeTypeName("bool")] MaybeBool<byte> localTime
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_TimeToWindows")]
    void TimeToWindows(
        [NativeTypeName("SDL_Time")] nint ticks,
        [NativeTypeName("Uint32 *")] uint* dwLowDateTime,
        [NativeTypeName("Uint32 *")] uint* dwHighDateTime
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_TimeToWindows")]
    void TimeToWindows(
        [NativeTypeName("SDL_Time")] nint ticks,
        [NativeTypeName("Uint32 *")] Ref<uint> dwLowDateTime,
        [NativeTypeName("Uint32 *")] Ref<uint> dwHighDateTime
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_tolower")]
    int Tolower(int x);

    [NativeFunction("SDL3", EntryPoint = "SDL_toupper")]
    int Toupper(int x);

    [NativeFunction("SDL3", EntryPoint = "SDL_trunc")]
    double Trunc(double x);

    [NativeFunction("SDL3", EntryPoint = "SDL_truncf")]
    float Truncf(float x);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockMutex")]
    MaybeBool<byte> TryLockMutex(MutexHandle mutex);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockMutex")]
    byte TryLockMutexRaw(MutexHandle mutex);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForReading")]
    MaybeBool<byte> TryLockRWLockForReading(RWLockHandle rwlock);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForReading")]
    byte TryLockRWLockForReadingRaw(RWLockHandle rwlock);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForWriting")]
    MaybeBool<byte> TryLockRWLockForWriting(RWLockHandle rwlock);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForWriting")]
    byte TryLockRWLockForWritingRaw(RWLockHandle rwlock);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockSpinlock")]
    byte TryLockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockSpinlock")]
    MaybeBool<byte> TryLockSpinlock([NativeTypeName("SDL_SpinLock *")] Ref<int> @lock);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryWaitSemaphore")]
    MaybeBool<byte> TryWaitSemaphore(SemaphoreHandle sem);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryWaitSemaphore")]
    byte TryWaitSemaphoreRaw(SemaphoreHandle sem);

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UCS4ToUTF8")]
    sbyte* UCS4ToUTF8(
        [NativeTypeName("Uint32")] uint codepoint,
        [NativeTypeName("char *")] sbyte* dst
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UCS4ToUTF8")]
    Ptr<sbyte> UCS4ToUTF8(
        [NativeTypeName("Uint32")] uint codepoint,
        [NativeTypeName("char *")] Ref<sbyte> dst
    );

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_uitoa")]
    sbyte* Uitoa(
        [NativeTypeName("unsigned int")] uint value,
        [NativeTypeName("char *")] sbyte* str,
        int radix
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_uitoa")]
    Ptr<sbyte> Uitoa(
        [NativeTypeName("unsigned int")] uint value,
        [NativeTypeName("char *")] Ref<sbyte> str,
        int radix
    );

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ulltoa")]
    sbyte* Ulltoa(
        [NativeTypeName("unsigned long long")] ulong value,
        [NativeTypeName("char *")] sbyte* str,
        int radix
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ulltoa")]
    Ptr<sbyte> Ulltoa(
        [NativeTypeName("unsigned long long")] ulong value,
        [NativeTypeName("char *")] Ref<sbyte> str,
        int radix
    );

    [return: NativeTypeName("char *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ultoa")]
    sbyte* Ultoa(
        [NativeTypeName("unsigned long")] nuint value,
        [NativeTypeName("char *")] sbyte* str,
        int radix
    );

    [return: NativeTypeName("char *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_ultoa")]
    Ptr<sbyte> Ultoa(
        [NativeTypeName("unsigned long")] nuint value,
        [NativeTypeName("char *")] Ref<sbyte> str,
        int radix
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStream")]
    void UnbindAudioStream(AudioStreamHandle stream);

    [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStreams")]
    void UnbindAudioStreams(
        [NativeTypeName("SDL_AudioStream *const *")] AudioStreamHandle* streams,
        int num_streams
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStreams")]
    void UnbindAudioStreams(
        [NativeTypeName("SDL_AudioStream *const *")] Ref<AudioStreamHandle> streams,
        int num_streams
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_UnloadObject")]
    void UnloadObject(SharedObjectHandle handle);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockAudioStream")]
    MaybeBool<byte> UnlockAudioStream(AudioStreamHandle stream);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockAudioStream")]
    byte UnlockAudioStreamRaw(AudioStreamHandle stream);

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
    void UnlockTexture(Texture* texture);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockTexture")]
    void UnlockTexture(Ref<Texture> texture);

    [NativeFunction("SDL3", EntryPoint = "SDL_UnmapGPUTransferBuffer")]
    void UnmapGPUTransferBuffer(GPUDeviceHandle device, GPUTransferBufferHandle transfer_buffer);

    [NativeFunction("SDL3", EntryPoint = "SDL_unsetenv_unsafe")]
    int UnsetenvUnsafe([NativeTypeName("const char *")] sbyte* name);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_unsetenv_unsafe")]
    int UnsetenvUnsafe([NativeTypeName("const char *")] Ref<sbyte> name);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnsetEnvironmentVariable")]
    byte UnsetEnvironmentVariable(
        EnvironmentHandle env,
        [NativeTypeName("const char *")] sbyte* name
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnsetEnvironmentVariable")]
    MaybeBool<byte> UnsetEnvironmentVariable(
        EnvironmentHandle env,
        [NativeTypeName("const char *")] Ref<sbyte> name
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateGamepads")]
    void UpdateGamepads();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateHapticEffect")]
    byte UpdateHapticEffect(
        HapticHandle haptic,
        int effect,
        [NativeTypeName("const SDL_HapticEffect *")] HapticEffect* data
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateHapticEffect")]
    MaybeBool<byte> UpdateHapticEffect(
        HapticHandle haptic,
        int effect,
        [NativeTypeName("const SDL_HapticEffect *")] Ref<HapticEffect> data
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateJoysticks")]
    void UpdateJoysticks();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateNVTexture")]
    byte UpdateNVTexture(
        Texture* texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        [NativeTypeName("const Uint8 *")] byte* Yplane,
        int Ypitch,
        [NativeTypeName("const Uint8 *")] byte* UVplane,
        int UVpitch
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateNVTexture")]
    MaybeBool<byte> UpdateNVTexture(
        Ref<Texture> texture,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        [NativeTypeName("const Uint8 *")] Ref<byte> Yplane,
        int Ypitch,
        [NativeTypeName("const Uint8 *")] Ref<byte> UVplane,
        int UVpitch
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateSensors")]
    void UpdateSensors();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateTexture")]
    byte UpdateTexture(
        Texture* texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        [NativeTypeName("const void *")] void* pixels,
        int pitch
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateTexture")]
    MaybeBool<byte> UpdateTexture(
        Ref<Texture> texture,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        [NativeTypeName("const void *")] Ref pixels,
        int pitch
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurface")]
    MaybeBool<byte> UpdateWindowSurface(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurface")]
    byte UpdateWindowSurfaceRaw(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurfaceRects")]
    byte UpdateWindowSurfaceRects(
        WindowHandle window,
        [NativeTypeName("const SDL_Rect *")] Rect* rects,
        int numrects
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurfaceRects")]
    MaybeBool<byte> UpdateWindowSurfaceRects(
        WindowHandle window,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rects,
        int numrects
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateYUVTexture")]
    byte UpdateYUVTexture(
        Texture* texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        [NativeTypeName("const Uint8 *")] byte* Yplane,
        int Ypitch,
        [NativeTypeName("const Uint8 *")] byte* Uplane,
        int Upitch,
        [NativeTypeName("const Uint8 *")] byte* Vplane,
        int Vpitch
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateYUVTexture")]
    MaybeBool<byte> UpdateYUVTexture(
        Ref<Texture> texture,
        [NativeTypeName("const SDL_Rect *")] Ref<Rect> rect,
        [NativeTypeName("const Uint8 *")] Ref<byte> Yplane,
        int Ypitch,
        [NativeTypeName("const Uint8 *")] Ref<byte> Uplane,
        int Upitch,
        [NativeTypeName("const Uint8 *")] Ref<byte> Vplane,
        int Vpitch
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUBuffer")]
    void UploadToGPUBuffer(
        GPUCopyPassHandle copy_pass,
        [NativeTypeName("const SDL_GPUTransferBufferLocation *")] GPUTransferBufferLocation* source,
        [NativeTypeName("const SDL_GPUBufferRegion *")] GPUBufferRegion* destination,
        [NativeTypeName("bool")] byte cycle
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUBuffer")]
    void UploadToGPUBuffer(
        GPUCopyPassHandle copy_pass,
        [NativeTypeName("const SDL_GPUTransferBufferLocation *")]
            Ref<GPUTransferBufferLocation> source,
        [NativeTypeName("const SDL_GPUBufferRegion *")] Ref<GPUBufferRegion> destination,
        [NativeTypeName("bool")] MaybeBool<byte> cycle
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUTexture")]
    void UploadToGPUTexture(
        GPUCopyPassHandle copy_pass,
        [NativeTypeName("const SDL_GPUTextureTransferInfo *")] GPUTextureTransferInfo* source,
        [NativeTypeName("const SDL_GPUTextureRegion *")] GPUTextureRegion* destination,
        [NativeTypeName("bool")] byte cycle
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUTexture")]
    void UploadToGPUTexture(
        GPUCopyPassHandle copy_pass,
        [NativeTypeName("const SDL_GPUTextureTransferInfo *")] Ref<GPUTextureTransferInfo> source,
        [NativeTypeName("const SDL_GPUTextureRegion *")] Ref<GPUTextureRegion> destination,
        [NativeTypeName("bool")] MaybeBool<byte> cycle
    );

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlcpy")]
    nuint Utf8Strlcpy(
        [NativeTypeName("char *")] sbyte* dst,
        [NativeTypeName("const char *")] sbyte* src,
        [NativeTypeName("size_t")] nuint dst_bytes
    );

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlcpy")]
    nuint Utf8Strlcpy(
        [NativeTypeName("char *")] Ref<sbyte> dst,
        [NativeTypeName("const char *")] Ref<sbyte> src,
        [NativeTypeName("size_t")] nuint dst_bytes
    );

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlen")]
    nuint Utf8Strlen([NativeTypeName("const char *")] sbyte* str);

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlen")]
    nuint Utf8Strlen([NativeTypeName("const char *")] Ref<sbyte> str);

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_utf8strnlen")]
    nuint Utf8Strnlen(
        [NativeTypeName("const char *")] sbyte* str,
        [NativeTypeName("size_t")] nuint bytes
    );

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_utf8strnlen")]
    nuint Utf8Strnlen(
        [NativeTypeName("const char *")] Ref<sbyte> str,
        [NativeTypeName("size_t")] nuint bytes
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_vasprintf")]
    int Vasprintf(
        [NativeTypeName("char **")] sbyte** strp,
        [NativeTypeName("const char *")] sbyte* fmt,
        [NativeTypeName("va_list")] VaListTagHandle ap
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_vasprintf")]
    int Vasprintf(
        [NativeTypeName("char **")] Ref2D<sbyte> strp,
        [NativeTypeName("const char *")] Ref<sbyte> fmt,
        [NativeTypeName("va_list")] VaListTagHandle ap
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_vsnprintf")]
    int Vsnprintf(
        [NativeTypeName("char *")] sbyte* text,
        [NativeTypeName("size_t")] nuint maxlen,
        [NativeTypeName("const char *")] sbyte* fmt,
        [NativeTypeName("va_list")] VaListTagHandle ap
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_vsnprintf")]
    int Vsnprintf(
        [NativeTypeName("char *")] Ref<sbyte> text,
        [NativeTypeName("size_t")] nuint maxlen,
        [NativeTypeName("const char *")] Ref<sbyte> fmt,
        [NativeTypeName("va_list")] VaListTagHandle ap
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_vsscanf")]
    int Vsscanf(
        [NativeTypeName("const char *")] sbyte* text,
        [NativeTypeName("const char *")] sbyte* fmt,
        [NativeTypeName("va_list")] VaListTagHandle ap
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_vsscanf")]
    int Vsscanf(
        [NativeTypeName("const char *")] Ref<sbyte> text,
        [NativeTypeName("const char *")] Ref<sbyte> fmt,
        [NativeTypeName("va_list")] VaListTagHandle ap
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_vswprintf")]
    int Vswprintf(
        [NativeTypeName("wchar_t *")] uint* text,
        [NativeTypeName("size_t")] nuint maxlen,
        [NativeTypeName("const wchar_t *")] uint* fmt,
        [NativeTypeName("va_list")] VaListTagHandle ap
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_vswprintf")]
    int Vswprintf(
        [NativeTypeName("wchar_t *")] Ref<uint> text,
        [NativeTypeName("size_t")] nuint maxlen,
        [NativeTypeName("const wchar_t *")] Ref<uint> fmt,
        [NativeTypeName("va_list")] VaListTagHandle ap
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_CreateSurface")]
    byte VulkanCreateSurface(
        WindowHandle window,
        [NativeTypeName("VkInstance")] void* instance,
        [NativeTypeName("const struct VkAllocationCallbacks *")] void* allocator,
        [NativeTypeName("VkSurfaceKHR *")] ulong* surface
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_CreateSurface")]
    MaybeBool<byte> VulkanCreateSurface(
        WindowHandle window,
        [NativeTypeName("VkInstance")] Ref instance,
        [NativeTypeName("const struct VkAllocationCallbacks *")] Ref allocator,
        [NativeTypeName("VkSurfaceKHR *")] Ref<ulong> surface
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_DestroySurface")]
    void VulkanDestroySurface(
        [NativeTypeName("VkInstance")] void* instance,
        [NativeTypeName("VkSurfaceKHR")] ulong surface,
        [NativeTypeName("const struct VkAllocationCallbacks *")] void* allocator
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_DestroySurface")]
    void VulkanDestroySurface(
        [NativeTypeName("VkInstance")] Ref instance,
        [NativeTypeName("VkSurfaceKHR")] ulong surface,
        [NativeTypeName("const struct VkAllocationCallbacks *")] Ref allocator
    );

    [return: NativeTypeName("const char *const *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
    sbyte** VulkanGetInstanceExtensions([NativeTypeName("Uint32 *")] uint* count);

    [return: NativeTypeName("const char *const *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
    Ptr2D<sbyte> VulkanGetInstanceExtensions([NativeTypeName("Uint32 *")] Ref<uint> count);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetPresentationSupport")]
    byte VulkanGetPresentationSupport(
        [NativeTypeName("VkInstance")] void* instance,
        [NativeTypeName("VkPhysicalDevice")] ulong physicalDevice,
        [NativeTypeName("Uint32")] uint queueFamilyIndex
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetPresentationSupport")]
    MaybeBool<byte> VulkanGetPresentationSupport(
        [NativeTypeName("VkInstance")] Ref instance,
        [NativeTypeName("VkPhysicalDevice")] ulong physicalDevice,
        [NativeTypeName("Uint32")] uint queueFamilyIndex
    );

    [return: NativeTypeName("SDL_FunctionPointer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetVkGetInstanceProcAddr")]
    FunctionPointer VulkanGetVkGetInstanceProcAddr();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_LoadLibrary")]
    byte VulkanLoadLibrary([NativeTypeName("const char *")] sbyte* path);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_LoadLibrary")]
    MaybeBool<byte> VulkanLoadLibrary([NativeTypeName("const char *")] Ref<sbyte> path);

    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_UnloadLibrary")]
    void VulkanUnloadLibrary();

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitAndAcquireGPUSwapchainTexture")]
    byte WaitAndAcquireGPUSwapchainTexture(
        GPUCommandBufferHandle command_buffer,
        WindowHandle window,
        GPUTextureHandle* swapchain_texture,
        [NativeTypeName("Uint32 *")] uint* swapchain_texture_width,
        [NativeTypeName("Uint32 *")] uint* swapchain_texture_height
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitAndAcquireGPUSwapchainTexture")]
    MaybeBool<byte> WaitAndAcquireGPUSwapchainTexture(
        GPUCommandBufferHandle command_buffer,
        WindowHandle window,
        Ref<GPUTextureHandle> swapchain_texture,
        [NativeTypeName("Uint32 *")] Ref<uint> swapchain_texture_width,
        [NativeTypeName("Uint32 *")] Ref<uint> swapchain_texture_height
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_WaitCondition")]
    void WaitCondition(ConditionHandle cond, MutexHandle mutex);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitConditionTimeout")]
    MaybeBool<byte> WaitConditionTimeout(
        ConditionHandle cond,
        MutexHandle mutex,
        [NativeTypeName("Sint32")] int timeoutMS
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitConditionTimeout")]
    byte WaitConditionTimeoutRaw(
        ConditionHandle cond,
        MutexHandle mutex,
        [NativeTypeName("Sint32")] int timeoutMS
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitEvent")]
    byte WaitEvent(Event* @event);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitEvent")]
    MaybeBool<byte> WaitEvent(Ref<Event> @event);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitEventTimeout")]
    byte WaitEventTimeout(Event* @event, [NativeTypeName("Sint32")] int timeoutMS);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitEventTimeout")]
    MaybeBool<byte> WaitEventTimeout(Ref<Event> @event, [NativeTypeName("Sint32")] int timeoutMS);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUFences")]
    byte WaitForGPUFences(
        GPUDeviceHandle device,
        [NativeTypeName("bool")] byte wait_all,
        [NativeTypeName("SDL_GPUFence *const *")] GPUFenceHandle* fences,
        [NativeTypeName("Uint32")] uint num_fences
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUFences")]
    MaybeBool<byte> WaitForGPUFences(
        GPUDeviceHandle device,
        [NativeTypeName("bool")] MaybeBool<byte> wait_all,
        [NativeTypeName("SDL_GPUFence *const *")] Ref<GPUFenceHandle> fences,
        [NativeTypeName("Uint32")] uint num_fences
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUIdle")]
    MaybeBool<byte> WaitForGPUIdle(GPUDeviceHandle device);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUIdle")]
    byte WaitForGPUIdleRaw(GPUDeviceHandle device);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUSwapchain")]
    MaybeBool<byte> WaitForGPUSwapchain(GPUDeviceHandle device, WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUSwapchain")]
    byte WaitForGPUSwapchainRaw(GPUDeviceHandle device, WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitProcess")]
    byte WaitProcess(ProcessHandle process, [NativeTypeName("bool")] byte block, int* exitcode);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitProcess")]
    MaybeBool<byte> WaitProcess(
        ProcessHandle process,
        [NativeTypeName("bool")] MaybeBool<byte> block,
        Ref<int> exitcode
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphore")]
    void WaitSemaphore(SemaphoreHandle sem);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphoreTimeout")]
    MaybeBool<byte> WaitSemaphoreTimeout(
        SemaphoreHandle sem,
        [NativeTypeName("Sint32")] int timeoutMS
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphoreTimeout")]
    byte WaitSemaphoreTimeoutRaw(SemaphoreHandle sem, [NativeTypeName("Sint32")] int timeoutMS);

    [NativeFunction("SDL3", EntryPoint = "SDL_WaitThread")]
    void WaitThread(ThreadHandle thread, int* status);

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitThread")]
    void WaitThread(ThreadHandle thread, Ref<int> status);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseGlobal")]
    MaybeBool<byte> WarpMouseGlobal(float x, float y);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseGlobal")]
    byte WarpMouseGlobalRaw(float x, float y);

    [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseInWindow")]
    void WarpMouseInWindow(WindowHandle window, float x, float y);

    [return: NativeTypeName("SDL_InitFlags")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WasInit")]
    uint WasInit([NativeTypeName("SDL_InitFlags")] uint flags);

    [NativeFunction("SDL3", EntryPoint = "SDL_wcscasecmp")]
    int Wcscasecmp(
        [NativeTypeName("const wchar_t *")] uint* str1,
        [NativeTypeName("const wchar_t *")] uint* str2
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcscasecmp")]
    int Wcscasecmp(
        [NativeTypeName("const wchar_t *")] Ref<uint> str1,
        [NativeTypeName("const wchar_t *")] Ref<uint> str2
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_wcscmp")]
    int Wcscmp(
        [NativeTypeName("const wchar_t *")] uint* str1,
        [NativeTypeName("const wchar_t *")] uint* str2
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcscmp")]
    int Wcscmp(
        [NativeTypeName("const wchar_t *")] Ref<uint> str1,
        [NativeTypeName("const wchar_t *")] Ref<uint> str2
    );

    [return: NativeTypeName("wchar_t *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsdup")]
    uint* Wcsdup([NativeTypeName("const wchar_t *")] uint* wstr);

    [return: NativeTypeName("wchar_t *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsdup")]
    Ptr<uint> Wcsdup([NativeTypeName("const wchar_t *")] Ref<uint> wstr);

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcslcat")]
    nuint Wcslcat(
        [NativeTypeName("wchar_t *")] uint* dst,
        [NativeTypeName("const wchar_t *")] uint* src,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcslcat")]
    nuint Wcslcat(
        [NativeTypeName("wchar_t *")] Ref<uint> dst,
        [NativeTypeName("const wchar_t *")] Ref<uint> src,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcslcpy")]
    nuint Wcslcpy(
        [NativeTypeName("wchar_t *")] uint* dst,
        [NativeTypeName("const wchar_t *")] uint* src,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcslcpy")]
    nuint Wcslcpy(
        [NativeTypeName("wchar_t *")] Ref<uint> dst,
        [NativeTypeName("const wchar_t *")] Ref<uint> src,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcslen")]
    nuint Wcslen([NativeTypeName("const wchar_t *")] uint* wstr);

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcslen")]
    nuint Wcslen([NativeTypeName("const wchar_t *")] Ref<uint> wstr);

    [NativeFunction("SDL3", EntryPoint = "SDL_wcsncasecmp")]
    int Wcsncasecmp(
        [NativeTypeName("const wchar_t *")] uint* str1,
        [NativeTypeName("const wchar_t *")] uint* str2,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsncasecmp")]
    int Wcsncasecmp(
        [NativeTypeName("const wchar_t *")] Ref<uint> str1,
        [NativeTypeName("const wchar_t *")] Ref<uint> str2,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [NativeFunction("SDL3", EntryPoint = "SDL_wcsncmp")]
    int Wcsncmp(
        [NativeTypeName("const wchar_t *")] uint* str1,
        [NativeTypeName("const wchar_t *")] uint* str2,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsncmp")]
    int Wcsncmp(
        [NativeTypeName("const wchar_t *")] Ref<uint> str1,
        [NativeTypeName("const wchar_t *")] Ref<uint> str2,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("size_t")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsnlen")]
    nuint Wcsnlen(
        [NativeTypeName("const wchar_t *")] uint* wstr,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("size_t")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsnlen")]
    nuint Wcsnlen(
        [NativeTypeName("const wchar_t *")] Ref<uint> wstr,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("wchar_t *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsnstr")]
    uint* Wcsnstr(
        [NativeTypeName("const wchar_t *")] uint* haystack,
        [NativeTypeName("const wchar_t *")] uint* needle,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("wchar_t *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsnstr")]
    Ptr<uint> Wcsnstr(
        [NativeTypeName("const wchar_t *")] Ref<uint> haystack,
        [NativeTypeName("const wchar_t *")] Ref<uint> needle,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [return: NativeTypeName("wchar_t *")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsstr")]
    uint* Wcsstr(
        [NativeTypeName("const wchar_t *")] uint* haystack,
        [NativeTypeName("const wchar_t *")] uint* needle
    );

    [return: NativeTypeName("wchar_t *")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsstr")]
    Ptr<uint> Wcsstr(
        [NativeTypeName("const wchar_t *")] Ref<uint> haystack,
        [NativeTypeName("const wchar_t *")] Ref<uint> needle
    );

    [return: NativeTypeName("long")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcstol")]
    nint Wcstol(
        [NativeTypeName("const wchar_t *")] uint* str,
        [NativeTypeName("wchar_t **")] uint** endp,
        int @base
    );

    [return: NativeTypeName("long")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcstol")]
    nint Wcstol(
        [NativeTypeName("const wchar_t *")] Ref<uint> str,
        [NativeTypeName("wchar_t **")] Ref2D<uint> endp,
        int @base
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WindowHasSurface")]
    MaybeBool<byte> WindowHasSurface(WindowHandle window);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WindowHasSurface")]
    byte WindowHasSurfaceRaw(WindowHandle window);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUPresentMode")]
    MaybeBool<byte> WindowSupportsGPUPresentMode(
        GPUDeviceHandle device,
        WindowHandle window,
        GPUPresentMode present_mode
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUPresentMode")]
    byte WindowSupportsGPUPresentModeRaw(
        GPUDeviceHandle device,
        WindowHandle window,
        GPUPresentMode present_mode
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUSwapchainComposition")]
    MaybeBool<byte> WindowSupportsGPUSwapchainComposition(
        GPUDeviceHandle device,
        WindowHandle window,
        GPUSwapchainComposition swapchain_composition
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUSwapchainComposition")]
    byte WindowSupportsGPUSwapchainCompositionRaw(
        GPUDeviceHandle device,
        WindowHandle window,
        GPUSwapchainComposition swapchain_composition
    );

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

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16BE")]
    MaybeBool<byte> WriteS16BE(IOStreamHandle dst, [NativeTypeName("Sint16")] short value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16BE")]
    byte WriteS16BERaw(IOStreamHandle dst, [NativeTypeName("Sint16")] short value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16LE")]
    MaybeBool<byte> WriteS16LE(IOStreamHandle dst, [NativeTypeName("Sint16")] short value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16LE")]
    byte WriteS16LERaw(IOStreamHandle dst, [NativeTypeName("Sint16")] short value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32BE")]
    MaybeBool<byte> WriteS32BE(IOStreamHandle dst, [NativeTypeName("Sint32")] int value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32BE")]
    byte WriteS32BERaw(IOStreamHandle dst, [NativeTypeName("Sint32")] int value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32LE")]
    MaybeBool<byte> WriteS32LE(IOStreamHandle dst, [NativeTypeName("Sint32")] int value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32LE")]
    byte WriteS32LERaw(IOStreamHandle dst, [NativeTypeName("Sint32")] int value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64BE")]
    MaybeBool<byte> WriteS64BE(IOStreamHandle dst, [NativeTypeName("Sint64")] nint value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64BE")]
    byte WriteS64BERaw(IOStreamHandle dst, [NativeTypeName("Sint64")] nint value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64LE")]
    MaybeBool<byte> WriteS64LE(IOStreamHandle dst, [NativeTypeName("Sint64")] nint value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64LE")]
    byte WriteS64LERaw(IOStreamHandle dst, [NativeTypeName("Sint64")] nint value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS8")]
    MaybeBool<byte> WriteS8(IOStreamHandle dst, [NativeTypeName("Sint8")] sbyte value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS8")]
    byte WriteS8Raw(IOStreamHandle dst, [NativeTypeName("Sint8")] sbyte value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteStorageFile")]
    byte WriteStorageFile(
        StorageHandle storage,
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("const void *")] void* source,
        [NativeTypeName("Uint64")] nuint length
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteStorageFile")]
    MaybeBool<byte> WriteStorageFile(
        StorageHandle storage,
        [NativeTypeName("const char *")] Ref<sbyte> path,
        [NativeTypeName("const void *")] Ref source,
        [NativeTypeName("Uint64")] nuint length
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteSurfacePixel")]
    byte WriteSurfacePixel(
        Surface* surface,
        int x,
        int y,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b,
        [NativeTypeName("Uint8")] byte a
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteSurfacePixel")]
    MaybeBool<byte> WriteSurfacePixel(
        Ref<Surface> surface,
        int x,
        int y,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b,
        [NativeTypeName("Uint8")] byte a
    );

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteSurfacePixelFloat")]
    byte WriteSurfacePixelFloat(Surface* surface, int x, int y, float r, float g, float b, float a);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteSurfacePixelFloat")]
    MaybeBool<byte> WriteSurfacePixelFloat(
        Ref<Surface> surface,
        int x,
        int y,
        float r,
        float g,
        float b,
        float a
    );

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16BE")]
    MaybeBool<byte> WriteU16BE(IOStreamHandle dst, [NativeTypeName("Uint16")] ushort value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16BE")]
    byte WriteU16BERaw(IOStreamHandle dst, [NativeTypeName("Uint16")] ushort value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16LE")]
    MaybeBool<byte> WriteU16LE(IOStreamHandle dst, [NativeTypeName("Uint16")] ushort value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16LE")]
    byte WriteU16LERaw(IOStreamHandle dst, [NativeTypeName("Uint16")] ushort value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32BE")]
    MaybeBool<byte> WriteU32BE(IOStreamHandle dst, [NativeTypeName("Uint32")] uint value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32BE")]
    byte WriteU32BERaw(IOStreamHandle dst, [NativeTypeName("Uint32")] uint value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32LE")]
    MaybeBool<byte> WriteU32LE(IOStreamHandle dst, [NativeTypeName("Uint32")] uint value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32LE")]
    byte WriteU32LERaw(IOStreamHandle dst, [NativeTypeName("Uint32")] uint value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64BE")]
    MaybeBool<byte> WriteU64BE(IOStreamHandle dst, [NativeTypeName("Uint64")] nuint value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64BE")]
    byte WriteU64BERaw(IOStreamHandle dst, [NativeTypeName("Uint64")] nuint value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64LE")]
    MaybeBool<byte> WriteU64LE(IOStreamHandle dst, [NativeTypeName("Uint64")] nuint value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64LE")]
    byte WriteU64LERaw(IOStreamHandle dst, [NativeTypeName("Uint64")] nuint value);

    [return: NativeTypeName("bool")]
    [Transformed]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU8")]
    MaybeBool<byte> WriteU8(IOStreamHandle dst, [NativeTypeName("Uint8")] byte value);

    [return: NativeTypeName("bool")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU8")]
    byte WriteU8Raw(IOStreamHandle dst, [NativeTypeName("Uint8")] byte value);
}
