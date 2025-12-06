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
        [NativeName("SDL_abs")]
        [NativeFunction("SDL3", EntryPoint = "SDL_abs")]
        static abstract int Abs(int x);

        [NativeName("SDL_acos")]
        [NativeFunction("SDL3", EntryPoint = "SDL_acos")]
        static abstract double Acos(double x);

        [NativeName("SDL_acosf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_acosf")]
        static abstract float Acosf(float x);

        [NativeName("SDL_AcquireCameraFrame")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AcquireCameraFrame")]
        static abstract Surface* AcquireCameraFrame(CameraHandle camera, ulong* timestampNS);

        [NativeName("SDL_AcquireCameraFrame")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AcquireCameraFrame")]
        static abstract Ptr<Surface> AcquireCameraFrame(
            CameraHandle camera,
            Ref<ulong> timestampNS
        );

        [NativeName("SDL_AcquireGPUCommandBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AcquireGPUCommandBuffer")]
        static abstract GpuCommandBufferHandle AcquireGpuCommandBuffer(GpuDeviceHandle device);

        [NativeName("SDL_AcquireGPUSwapchainTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AcquireGPUSwapchainTexture")]
        static abstract byte AcquireGpuSwapchainTexture(
            GpuCommandBufferHandle command_buffer,
            WindowHandle window,
            GpuTextureHandle* swapchain_texture,
            uint* swapchain_texture_width,
            uint* swapchain_texture_height
        );

        [NativeName("SDL_AcquireGPUSwapchainTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AcquireGPUSwapchainTexture")]
        static abstract MaybeBool<byte> AcquireGpuSwapchainTexture(
            GpuCommandBufferHandle command_buffer,
            WindowHandle window,
            Ref<GpuTextureHandle> swapchain_texture,
            Ref<uint> swapchain_texture_width,
            Ref<uint> swapchain_texture_height
        );

        [NativeName("SDL_AddAtomicInt")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddAtomicInt")]
        static abstract int AddAtomicInt(AtomicInt* a, int v);

        [NativeName("SDL_AddAtomicInt")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddAtomicInt")]
        static abstract int AddAtomicInt(Ref<AtomicInt> a, int v);

        [NativeName("SDL_AddEventWatch")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddEventWatch")]
        static abstract byte AddEventWatch(EventFilter filter, void* userdata);

        [NativeName("SDL_AddEventWatch")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddEventWatch")]
        static abstract MaybeBool<byte> AddEventWatch(EventFilter filter, Ref userdata);

        [NativeName("SDL_AddGamepadMapping")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMapping")]
        static abstract int AddGamepadMapping(sbyte* mapping);

        [NativeName("SDL_AddGamepadMapping")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMapping")]
        static abstract int AddGamepadMapping(Ref<sbyte> mapping);

        [NativeName("SDL_AddGamepadMappingsFromFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromFile")]
        static abstract int AddGamepadMappingsFromFile(sbyte* file);

        [NativeName("SDL_AddGamepadMappingsFromFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromFile")]
        static abstract int AddGamepadMappingsFromFile(Ref<sbyte> file);

        [NativeName("SDL_AddGamepadMappingsFromIO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromIO")]
        static abstract int AddGamepadMappingsFromIo(IoStreamHandle src, byte closeio);

        [NativeName("SDL_AddGamepadMappingsFromIO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromIO")]
        static abstract int AddGamepadMappingsFromIo(IoStreamHandle src, MaybeBool<byte> closeio);

        [NativeName("SDL_AddHintCallback")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddHintCallback")]
        static abstract byte AddHintCallback(sbyte* name, HintCallback callback, void* userdata);

        [NativeName("SDL_AddHintCallback")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddHintCallback")]
        static abstract MaybeBool<byte> AddHintCallback(
            Ref<sbyte> name,
            HintCallback callback,
            Ref userdata
        );

        [NativeName("SDL_AddSurfaceAlternateImage")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddSurfaceAlternateImage")]
        static abstract byte AddSurfaceAlternateImage(Surface* surface, Surface* image);

        [NativeName("SDL_AddSurfaceAlternateImage")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddSurfaceAlternateImage")]
        static abstract MaybeBool<byte> AddSurfaceAlternateImage(
            Ref<Surface> surface,
            Ref<Surface> image
        );

        [NativeName("SDL_AddTimer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddTimer")]
        static abstract uint AddTimer(uint interval, TimerCallback callback, void* userdata);

        [NativeName("SDL_AddTimer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddTimer")]
        static abstract uint AddTimer(uint interval, TimerCallback callback, Ref userdata);

        [NativeName("SDL_AddTimerNS")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddTimerNS")]
        static abstract uint AddTimerNs(ulong interval, NsTimerCallback callback, void* userdata);

        [NativeName("SDL_AddTimerNS")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddTimerNS")]
        static abstract uint AddTimerNs(ulong interval, NsTimerCallback callback, Ref userdata);

        [NativeName("SDL_AddVulkanRenderSemaphores")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddVulkanRenderSemaphores")]
        static abstract MaybeBool<byte> AddVulkanRenderSemaphores(
            RendererHandle renderer,
            uint wait_stage_mask,
            long wait_semaphore,
            long signal_semaphore
        );

        [NativeName("SDL_AddVulkanRenderSemaphores")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AddVulkanRenderSemaphores")]
        static abstract byte AddVulkanRenderSemaphoresRaw(
            RendererHandle renderer,
            uint wait_stage_mask,
            long wait_semaphore,
            long signal_semaphore
        );

        [NativeName("SDL_aligned_alloc")]
        [NativeFunction("SDL3", EntryPoint = "SDL_aligned_alloc")]
        static abstract Ptr AlignedAlloc(nuint alignment, nuint size);

        [NativeName("SDL_aligned_alloc")]
        [NativeFunction("SDL3", EntryPoint = "SDL_aligned_alloc")]
        static abstract void* AlignedAllocRaw(nuint alignment, nuint size);

        [NativeName("SDL_aligned_free")]
        [NativeFunction("SDL3", EntryPoint = "SDL_aligned_free")]
        static abstract void AlignedFree(void* mem);

        [NativeName("SDL_aligned_free")]
        [NativeFunction("SDL3", EntryPoint = "SDL_aligned_free")]
        static abstract void AlignedFree(Ref mem);

        [NativeName("SDL_asin")]
        [NativeFunction("SDL3", EntryPoint = "SDL_asin")]
        static abstract double Asin(double x);

        [NativeName("SDL_asinf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_asinf")]
        static abstract float Asinf(float x);

        [NativeName("SDL_atan")]
        [NativeFunction("SDL3", EntryPoint = "SDL_atan")]
        static abstract double Atan(double x);

        [NativeName("SDL_atan2")]
        [NativeFunction("SDL3", EntryPoint = "SDL_atan2")]
        static abstract double Atan2(double y, double x);

        [NativeName("SDL_atan2f")]
        [NativeFunction("SDL3", EntryPoint = "SDL_atan2f")]
        static abstract float Atan2F(float y, float x);

        [NativeName("SDL_atanf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_atanf")]
        static abstract float Atanf(float x);

        [NativeName("SDL_atof")]
        [NativeFunction("SDL3", EntryPoint = "SDL_atof")]
        static abstract double Atof(sbyte* str);

        [NativeName("SDL_atof")]
        [NativeFunction("SDL3", EntryPoint = "SDL_atof")]
        static abstract double Atof(Ref<sbyte> str);

        [NativeName("SDL_atoi")]
        [NativeFunction("SDL3", EntryPoint = "SDL_atoi")]
        static abstract int Atoi(sbyte* str);

        [NativeName("SDL_atoi")]
        [NativeFunction("SDL3", EntryPoint = "SDL_atoi")]
        static abstract int Atoi(Ref<sbyte> str);

        [NativeName("SDL_AttachVirtualJoystick")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AttachVirtualJoystick")]
        static abstract uint AttachVirtualJoystick(VirtualJoystickDesc* desc);

        [NativeName("SDL_AttachVirtualJoystick")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AttachVirtualJoystick")]
        static abstract uint AttachVirtualJoystick(Ref<VirtualJoystickDesc> desc);

        [NativeName("SDL_AudioDevicePaused")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AudioDevicePaused")]
        static abstract MaybeBool<byte> AudioDevicePaused(uint devid);

        [NativeName("SDL_AudioDevicePaused")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AudioDevicePaused")]
        static abstract byte AudioDevicePausedRaw(uint devid);

        [NativeName("SDL_AudioStreamDevicePaused")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AudioStreamDevicePaused")]
        static abstract MaybeBool<byte> AudioStreamDevicePaused(AudioStreamHandle stream);

        [NativeName("SDL_AudioStreamDevicePaused")]
        [NativeFunction("SDL3", EntryPoint = "SDL_AudioStreamDevicePaused")]
        static abstract byte AudioStreamDevicePausedRaw(AudioStreamHandle stream);

        [NativeName("SDL_BeginGPUComputePass")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPUComputePass")]
        static abstract GpuComputePassHandle BeginGpuComputePass(
            GpuCommandBufferHandle command_buffer,
            GpuStorageTextureReadWriteBinding* storage_texture_bindings,
            uint num_storage_texture_bindings,
            GpuStorageBufferReadWriteBinding* storage_buffer_bindings,
            uint num_storage_buffer_bindings
        );

        [NativeName("SDL_BeginGPUComputePass")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPUComputePass")]
        static abstract GpuComputePassHandle BeginGpuComputePass(
            GpuCommandBufferHandle command_buffer,
            Ref<GpuStorageTextureReadWriteBinding> storage_texture_bindings,
            uint num_storage_texture_bindings,
            Ref<GpuStorageBufferReadWriteBinding> storage_buffer_bindings,
            uint num_storage_buffer_bindings
        );

        [NativeName("SDL_BeginGPUCopyPass")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPUCopyPass")]
        static abstract GpuCopyPassHandle BeginGpuCopyPass(GpuCommandBufferHandle command_buffer);

        [NativeName("SDL_BeginGPURenderPass")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPURenderPass")]
        static abstract GpuRenderPassHandle BeginGpuRenderPass(
            GpuCommandBufferHandle command_buffer,
            GpuColorTargetInfo* color_target_infos,
            uint num_color_targets,
            GpuDepthStencilTargetInfo* depth_stencil_target_info
        );

        [NativeName("SDL_BeginGPURenderPass")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPURenderPass")]
        static abstract GpuRenderPassHandle BeginGpuRenderPass(
            GpuCommandBufferHandle command_buffer,
            Ref<GpuColorTargetInfo> color_target_infos,
            uint num_color_targets,
            Ref<GpuDepthStencilTargetInfo> depth_stencil_target_info
        );

        [NativeName("SDL_BindAudioStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStream")]
        static abstract MaybeBool<byte> BindAudioStream(uint devid, AudioStreamHandle stream);

        [NativeName("SDL_BindAudioStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStream")]
        static abstract byte BindAudioStreamRaw(uint devid, AudioStreamHandle stream);

        [NativeName("SDL_BindAudioStreams")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStreams")]
        static abstract byte BindAudioStreams(
            uint devid,
            AudioStreamHandle* streams,
            int num_streams
        );

        [NativeName("SDL_BindAudioStreams")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStreams")]
        static abstract MaybeBool<byte> BindAudioStreams(
            uint devid,
            Ref<AudioStreamHandle> streams,
            int num_streams
        );

        [NativeName("SDL_BindGPUComputePipeline")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputePipeline")]
        static abstract void BindGpuComputePipeline(
            GpuComputePassHandle compute_pass,
            GpuComputePipelineHandle compute_pipeline
        );

        [NativeName("SDL_BindGPUComputeSamplers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeSamplers")]
        static abstract void BindGpuComputeSamplers(
            GpuComputePassHandle compute_pass,
            uint first_slot,
            GpuTextureSamplerBinding* texture_sampler_bindings,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUComputeSamplers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeSamplers")]
        static abstract void BindGpuComputeSamplers(
            GpuComputePassHandle compute_pass,
            uint first_slot,
            Ref<GpuTextureSamplerBinding> texture_sampler_bindings,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUComputeStorageBuffers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageBuffers")]
        static abstract void BindGpuComputeStorageBuffers(
            GpuComputePassHandle compute_pass,
            uint first_slot,
            GpuBufferHandle* storage_buffers,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUComputeStorageBuffers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageBuffers")]
        static abstract void BindGpuComputeStorageBuffers(
            GpuComputePassHandle compute_pass,
            uint first_slot,
            Ref<GpuBufferHandle> storage_buffers,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUComputeStorageTextures")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageTextures")]
        static abstract void BindGpuComputeStorageTextures(
            GpuComputePassHandle compute_pass,
            uint first_slot,
            GpuTextureHandle* storage_textures,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUComputeStorageTextures")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageTextures")]
        static abstract void BindGpuComputeStorageTextures(
            GpuComputePassHandle compute_pass,
            uint first_slot,
            Ref<GpuTextureHandle> storage_textures,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUFragmentSamplers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentSamplers")]
        static abstract void BindGpuFragmentSamplers(
            GpuRenderPassHandle render_pass,
            uint first_slot,
            GpuTextureSamplerBinding* texture_sampler_bindings,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUFragmentSamplers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentSamplers")]
        static abstract void BindGpuFragmentSamplers(
            GpuRenderPassHandle render_pass,
            uint first_slot,
            Ref<GpuTextureSamplerBinding> texture_sampler_bindings,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUFragmentStorageBuffers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageBuffers")]
        static abstract void BindGpuFragmentStorageBuffers(
            GpuRenderPassHandle render_pass,
            uint first_slot,
            GpuBufferHandle* storage_buffers,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUFragmentStorageBuffers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageBuffers")]
        static abstract void BindGpuFragmentStorageBuffers(
            GpuRenderPassHandle render_pass,
            uint first_slot,
            Ref<GpuBufferHandle> storage_buffers,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUFragmentStorageTextures")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageTextures")]
        static abstract void BindGpuFragmentStorageTextures(
            GpuRenderPassHandle render_pass,
            uint first_slot,
            GpuTextureHandle* storage_textures,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUFragmentStorageTextures")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageTextures")]
        static abstract void BindGpuFragmentStorageTextures(
            GpuRenderPassHandle render_pass,
            uint first_slot,
            Ref<GpuTextureHandle> storage_textures,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUGraphicsPipeline")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUGraphicsPipeline")]
        static abstract void BindGpuGraphicsPipeline(
            GpuRenderPassHandle render_pass,
            GpuGraphicsPipelineHandle graphics_pipeline
        );

        [NativeName("SDL_BindGPUIndexBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUIndexBuffer")]
        static abstract void BindGpuIndexBuffer(
            GpuRenderPassHandle render_pass,
            GpuBufferBinding* binding,
            GpuIndexElementSize index_element_size
        );

        [NativeName("SDL_BindGPUIndexBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUIndexBuffer")]
        static abstract void BindGpuIndexBuffer(
            GpuRenderPassHandle render_pass,
            Ref<GpuBufferBinding> binding,
            GpuIndexElementSize index_element_size
        );

        [NativeName("SDL_BindGPUVertexBuffers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexBuffers")]
        static abstract void BindGpuVertexBuffers(
            GpuRenderPassHandle render_pass,
            uint first_slot,
            GpuBufferBinding* bindings,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUVertexBuffers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexBuffers")]
        static abstract void BindGpuVertexBuffers(
            GpuRenderPassHandle render_pass,
            uint first_slot,
            Ref<GpuBufferBinding> bindings,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUVertexSamplers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexSamplers")]
        static abstract void BindGpuVertexSamplers(
            GpuRenderPassHandle render_pass,
            uint first_slot,
            GpuTextureSamplerBinding* texture_sampler_bindings,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUVertexSamplers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexSamplers")]
        static abstract void BindGpuVertexSamplers(
            GpuRenderPassHandle render_pass,
            uint first_slot,
            Ref<GpuTextureSamplerBinding> texture_sampler_bindings,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUVertexStorageBuffers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageBuffers")]
        static abstract void BindGpuVertexStorageBuffers(
            GpuRenderPassHandle render_pass,
            uint first_slot,
            GpuBufferHandle* storage_buffers,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUVertexStorageBuffers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageBuffers")]
        static abstract void BindGpuVertexStorageBuffers(
            GpuRenderPassHandle render_pass,
            uint first_slot,
            Ref<GpuBufferHandle> storage_buffers,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUVertexStorageTextures")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageTextures")]
        static abstract void BindGpuVertexStorageTextures(
            GpuRenderPassHandle render_pass,
            uint first_slot,
            GpuTextureHandle* storage_textures,
            uint num_bindings
        );

        [NativeName("SDL_BindGPUVertexStorageTextures")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageTextures")]
        static abstract void BindGpuVertexStorageTextures(
            GpuRenderPassHandle render_pass,
            uint first_slot,
            Ref<GpuTextureHandle> storage_textures,
            uint num_bindings
        );

        [NativeName("SDL_BlitGPUTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitGPUTexture")]
        static abstract void BlitGpuTexture(
            GpuCommandBufferHandle command_buffer,
            GpuBlitInfo* info
        );

        [NativeName("SDL_BlitGPUTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitGPUTexture")]
        static abstract void BlitGpuTexture(
            GpuCommandBufferHandle command_buffer,
            Ref<GpuBlitInfo> info
        );

        [NativeName("SDL_BlitSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface")]
        static abstract byte BlitSurface(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

        [NativeName("SDL_BlitSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface")]
        static abstract MaybeBool<byte> BlitSurface(
            Ref<Surface> src,
            Ref<Rect> srcrect,
            Ref<Surface> dst,
            Ref<Rect> dstrect
        );

        [NativeName("SDL_BlitSurface9Grid")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface9Grid")]
        static abstract byte BlitSurface9Grid(
            Surface* src,
            Rect* srcrect,
            int left_width,
            int right_width,
            int top_height,
            int bottom_height,
            float scale,
            ScaleMode scaleMode,
            Surface* dst,
            Rect* dstrect
        );

        [NativeName("SDL_BlitSurface9Grid")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface9Grid")]
        static abstract MaybeBool<byte> BlitSurface9Grid(
            Ref<Surface> src,
            Ref<Rect> srcrect,
            int left_width,
            int right_width,
            int top_height,
            int bottom_height,
            float scale,
            ScaleMode scaleMode,
            Ref<Surface> dst,
            Ref<Rect> dstrect
        );

        [NativeName("SDL_BlitSurfaceScaled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceScaled")]
        static abstract byte BlitSurfaceScaled(
            Surface* src,
            Rect* srcrect,
            Surface* dst,
            Rect* dstrect,
            ScaleMode scaleMode
        );

        [NativeName("SDL_BlitSurfaceScaled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceScaled")]
        static abstract MaybeBool<byte> BlitSurfaceScaled(
            Ref<Surface> src,
            Ref<Rect> srcrect,
            Ref<Surface> dst,
            Ref<Rect> dstrect,
            ScaleMode scaleMode
        );

        [NativeName("SDL_BlitSurfaceTiled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiled")]
        static abstract byte BlitSurfaceTiled(
            Surface* src,
            Rect* srcrect,
            Surface* dst,
            Rect* dstrect
        );

        [NativeName("SDL_BlitSurfaceTiled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiled")]
        static abstract MaybeBool<byte> BlitSurfaceTiled(
            Ref<Surface> src,
            Ref<Rect> srcrect,
            Ref<Surface> dst,
            Ref<Rect> dstrect
        );

        [NativeName("SDL_BlitSurfaceTiledWithScale")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiledWithScale")]
        static abstract byte BlitSurfaceTiledWithScale(
            Surface* src,
            Rect* srcrect,
            float scale,
            ScaleMode scaleMode,
            Surface* dst,
            Rect* dstrect
        );

        [NativeName("SDL_BlitSurfaceTiledWithScale")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiledWithScale")]
        static abstract MaybeBool<byte> BlitSurfaceTiledWithScale(
            Ref<Surface> src,
            Ref<Rect> srcrect,
            float scale,
            ScaleMode scaleMode,
            Ref<Surface> dst,
            Ref<Rect> dstrect
        );

        [NativeName("SDL_BlitSurfaceUnchecked")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUnchecked")]
        static abstract byte BlitSurfaceUnchecked(
            Surface* src,
            Rect* srcrect,
            Surface* dst,
            Rect* dstrect
        );

        [NativeName("SDL_BlitSurfaceUnchecked")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUnchecked")]
        static abstract MaybeBool<byte> BlitSurfaceUnchecked(
            Ref<Surface> src,
            Ref<Rect> srcrect,
            Ref<Surface> dst,
            Ref<Rect> dstrect
        );

        [NativeName("SDL_BlitSurfaceUncheckedScaled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUncheckedScaled")]
        static abstract byte BlitSurfaceUncheckedScaled(
            Surface* src,
            Rect* srcrect,
            Surface* dst,
            Rect* dstrect,
            ScaleMode scaleMode
        );

        [NativeName("SDL_BlitSurfaceUncheckedScaled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUncheckedScaled")]
        static abstract MaybeBool<byte> BlitSurfaceUncheckedScaled(
            Ref<Surface> src,
            Ref<Rect> srcrect,
            Ref<Surface> dst,
            Ref<Rect> dstrect,
            ScaleMode scaleMode
        );

        [NativeName("SDL_BroadcastCondition")]
        [NativeFunction("SDL3", EntryPoint = "SDL_BroadcastCondition")]
        static abstract void BroadcastCondition(ConditionHandle cond);

        [NativeName("SDL_bsearch")]
        [NativeFunction("SDL3", EntryPoint = "SDL_bsearch")]
        static abstract void* Bsearch(
            void* key,
            void* @base,
            nuint nmemb,
            nuint size,
            CompareCallback compare
        );

        [NativeName("SDL_bsearch")]
        [NativeFunction("SDL3", EntryPoint = "SDL_bsearch")]
        static abstract Ptr Bsearch(
            Ref key,
            Ref @base,
            nuint nmemb,
            nuint size,
            CompareCallback compare
        );

        [NativeName("SDL_bsearch_r")]
        [NativeFunction("SDL3", EntryPoint = "SDL_bsearch_r")]
        static abstract void* BsearchR(
            void* key,
            void* @base,
            nuint nmemb,
            nuint size,
            CompareCallbackR compare,
            void* userdata
        );

        [NativeName("SDL_bsearch_r")]
        [NativeFunction("SDL3", EntryPoint = "SDL_bsearch_r")]
        static abstract Ptr BsearchR(
            Ref key,
            Ref @base,
            nuint nmemb,
            nuint size,
            CompareCallbackR compare,
            Ref userdata
        );

        [NativeName("SDL_CalculateGPUTextureFormatSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CalculateGPUTextureFormatSize")]
        static abstract uint CalculateGpuTextureFormatSize(
            GpuTextureFormat format,
            uint width,
            uint height,
            uint depth_or_layer_count
        );

        [NativeName("SDL_calloc")]
        [NativeFunction("SDL3", EntryPoint = "SDL_calloc")]
        static abstract Ptr Calloc(nuint nmemb, nuint size);

        [NativeName("SDL_calloc")]
        [NativeFunction("SDL3", EntryPoint = "SDL_calloc")]
        static abstract void* CallocRaw(nuint nmemb, nuint size);

        [NativeName("SDL_CancelGPUCommandBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CancelGPUCommandBuffer")]
        static abstract MaybeBool<byte> CancelGpuCommandBuffer(
            GpuCommandBufferHandle command_buffer
        );

        [NativeName("SDL_CancelGPUCommandBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CancelGPUCommandBuffer")]
        static abstract byte CancelGpuCommandBufferRaw(GpuCommandBufferHandle command_buffer);

        [NativeName("SDL_CaptureMouse")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CaptureMouse")]
        static abstract byte CaptureMouse(byte enabled);

        [NativeName("SDL_CaptureMouse")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CaptureMouse")]
        static abstract MaybeBool<byte> CaptureMouse(MaybeBool<byte> enabled);

        [NativeName("SDL_ceil")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ceil")]
        static abstract double Ceil(double x);

        [NativeName("SDL_ceilf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ceilf")]
        static abstract float Ceilf(float x);

        [NativeName("SDL_ClaimWindowForGPUDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClaimWindowForGPUDevice")]
        static abstract MaybeBool<byte> ClaimWindowForGpuDevice(
            GpuDeviceHandle device,
            WindowHandle window
        );

        [NativeName("SDL_ClaimWindowForGPUDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClaimWindowForGPUDevice")]
        static abstract byte ClaimWindowForGpuDeviceRaw(
            GpuDeviceHandle device,
            WindowHandle window
        );

        [NativeName("SDL_CleanupTLS")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CleanupTLS")]
        static abstract void CleanupTls();

        [NativeName("SDL_ClearAudioStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearAudioStream")]
        static abstract MaybeBool<byte> ClearAudioStream(AudioStreamHandle stream);

        [NativeName("SDL_ClearAudioStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearAudioStream")]
        static abstract byte ClearAudioStreamRaw(AudioStreamHandle stream);

        [NativeName("SDL_ClearClipboardData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearClipboardData")]
        static abstract MaybeBool<byte> ClearClipboardData();

        [NativeName("SDL_ClearClipboardData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearClipboardData")]
        static abstract byte ClearClipboardDataRaw();

        [NativeName("SDL_ClearComposition")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearComposition")]
        static abstract MaybeBool<byte> ClearComposition(WindowHandle window);

        [NativeName("SDL_ClearComposition")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearComposition")]
        static abstract byte ClearCompositionRaw(WindowHandle window);

        [NativeName("SDL_ClearError")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearError")]
        static abstract MaybeBool<byte> ClearError();

        [NativeName("SDL_ClearError")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearError")]
        static abstract byte ClearErrorRaw();

        [NativeName("SDL_ClearProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearProperty")]
        static abstract byte ClearProperty(uint props, sbyte* name);

        [NativeName("SDL_ClearProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearProperty")]
        static abstract MaybeBool<byte> ClearProperty(uint props, Ref<sbyte> name);

        [NativeName("SDL_ClearSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearSurface")]
        static abstract byte ClearSurface(Surface* surface, float r, float g, float b, float a);

        [NativeName("SDL_ClearSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ClearSurface")]
        static abstract MaybeBool<byte> ClearSurface(
            Ref<Surface> surface,
            float r,
            float g,
            float b,
            float a
        );

        [NativeName("SDL_CloseAudioDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CloseAudioDevice")]
        static abstract void CloseAudioDevice(uint devid);

        [NativeName("SDL_CloseCamera")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CloseCamera")]
        static abstract void CloseCamera(CameraHandle camera);

        [NativeName("SDL_CloseGamepad")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CloseGamepad")]
        static abstract void CloseGamepad(GamepadHandle gamepad);

        [NativeName("SDL_CloseHaptic")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CloseHaptic")]
        static abstract void CloseHaptic(HapticHandle haptic);

        [NativeName("SDL_CloseIO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CloseIO")]
        static abstract MaybeBool<byte> CloseIo(IoStreamHandle context);

        [NativeName("SDL_CloseIO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CloseIO")]
        static abstract byte CloseIoRaw(IoStreamHandle context);

        [NativeName("SDL_CloseJoystick")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CloseJoystick")]
        static abstract void CloseJoystick(JoystickHandle joystick);

        [NativeName("SDL_CloseSensor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CloseSensor")]
        static abstract void CloseSensor(SensorHandle sensor);

        [NativeName("SDL_CloseStorage")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CloseStorage")]
        static abstract MaybeBool<byte> CloseStorage(StorageHandle storage);

        [NativeName("SDL_CloseStorage")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CloseStorage")]
        static abstract byte CloseStorageRaw(StorageHandle storage);

        [NativeName("SDL_CompareAndSwapAtomicInt")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicInt")]
        static abstract byte CompareAndSwapAtomicInt(AtomicInt* a, int oldval, int newval);

        [NativeName("SDL_CompareAndSwapAtomicInt")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicInt")]
        static abstract MaybeBool<byte> CompareAndSwapAtomicInt(
            Ref<AtomicInt> a,
            int oldval,
            int newval
        );

        [NativeName("SDL_CompareAndSwapAtomicPointer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicPointer")]
        static abstract byte CompareAndSwapAtomicPointer(void** a, void* oldval, void* newval);

        [NativeName("SDL_CompareAndSwapAtomicPointer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicPointer")]
        static abstract MaybeBool<byte> CompareAndSwapAtomicPointer(
            Ref2D a,
            Ref oldval,
            Ref newval
        );

        [NativeName("SDL_CompareAndSwapAtomicU32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicU32")]
        static abstract byte CompareAndSwapAtomicU32(AtomicU32* a, uint oldval, uint newval);

        [NativeName("SDL_CompareAndSwapAtomicU32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicU32")]
        static abstract MaybeBool<byte> CompareAndSwapAtomicU32(
            Ref<AtomicU32> a,
            uint oldval,
            uint newval
        );

        [NativeName("SDL_ComposeCustomBlendMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ComposeCustomBlendMode")]
        static abstract uint ComposeCustomBlendMode(
            BlendFactor srcColorFactor,
            BlendFactor dstColorFactor,
            BlendOperation colorOperation,
            BlendFactor srcAlphaFactor,
            BlendFactor dstAlphaFactor,
            BlendOperation alphaOperation
        );

        [NativeName("SDL_ConvertAudioSamples")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertAudioSamples")]
        static abstract byte ConvertAudioSamples(
            AudioSpec* src_spec,
            byte* src_data,
            int src_len,
            AudioSpec* dst_spec,
            byte** dst_data,
            int* dst_len
        );

        [NativeName("SDL_ConvertAudioSamples")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertAudioSamples")]
        static abstract MaybeBool<byte> ConvertAudioSamples(
            Ref<AudioSpec> src_spec,
            Ref<byte> src_data,
            int src_len,
            Ref<AudioSpec> dst_spec,
            Ref2D<byte> dst_data,
            Ref<int> dst_len
        );

        [NativeName("SDL_ConvertEventToRenderCoordinates")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertEventToRenderCoordinates")]
        static abstract byte ConvertEventToRenderCoordinates(
            RendererHandle renderer,
            Event* @event
        );

        [NativeName("SDL_ConvertEventToRenderCoordinates")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertEventToRenderCoordinates")]
        static abstract MaybeBool<byte> ConvertEventToRenderCoordinates(
            RendererHandle renderer,
            Ref<Event> @event
        );

        [NativeName("SDL_ConvertPixels")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixels")]
        static abstract byte ConvertPixels(
            int width,
            int height,
            PixelFormat src_format,
            void* src,
            int src_pitch,
            PixelFormat dst_format,
            void* dst,
            int dst_pitch
        );

        [NativeName("SDL_ConvertPixels")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixels")]
        static abstract MaybeBool<byte> ConvertPixels(
            int width,
            int height,
            PixelFormat src_format,
            Ref src,
            int src_pitch,
            PixelFormat dst_format,
            Ref dst,
            int dst_pitch
        );

        [NativeName("SDL_ConvertPixelsAndColorspace")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixelsAndColorspace")]
        static abstract byte ConvertPixelsAndColorspace(
            int width,
            int height,
            PixelFormat src_format,
            Colorspace src_colorspace,
            uint src_properties,
            void* src,
            int src_pitch,
            PixelFormat dst_format,
            Colorspace dst_colorspace,
            uint dst_properties,
            void* dst,
            int dst_pitch
        );

        [NativeName("SDL_ConvertPixelsAndColorspace")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixelsAndColorspace")]
        static abstract MaybeBool<byte> ConvertPixelsAndColorspace(
            int width,
            int height,
            PixelFormat src_format,
            Colorspace src_colorspace,
            uint src_properties,
            Ref src,
            int src_pitch,
            PixelFormat dst_format,
            Colorspace dst_colorspace,
            uint dst_properties,
            Ref dst,
            int dst_pitch
        );

        [NativeName("SDL_ConvertSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurface")]
        static abstract Surface* ConvertSurface(Surface* surface, PixelFormat format);

        [NativeName("SDL_ConvertSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurface")]
        static abstract Ptr<Surface> ConvertSurface(Ref<Surface> surface, PixelFormat format);

        [NativeName("SDL_ConvertSurfaceAndColorspace")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceAndColorspace")]
        static abstract Surface* ConvertSurfaceAndColorspace(
            Surface* surface,
            PixelFormat format,
            Palette* palette,
            Colorspace colorspace,
            uint props
        );

        [NativeName("SDL_ConvertSurfaceAndColorspace")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceAndColorspace")]
        static abstract Ptr<Surface> ConvertSurfaceAndColorspace(
            Ref<Surface> surface,
            PixelFormat format,
            Ref<Palette> palette,
            Colorspace colorspace,
            uint props
        );

        [NativeName("SDL_CopyFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyFile")]
        static abstract byte CopyFile(sbyte* oldpath, sbyte* newpath);

        [NativeName("SDL_CopyFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyFile")]
        static abstract MaybeBool<byte> CopyFile(Ref<sbyte> oldpath, Ref<sbyte> newpath);

        [NativeName("SDL_CopyGPUBufferToBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUBufferToBuffer")]
        static abstract void CopyGpuBufferToBuffer(
            GpuCopyPassHandle copy_pass,
            GpuBufferLocation* source,
            GpuBufferLocation* destination,
            uint size,
            byte cycle
        );

        [NativeName("SDL_CopyGPUBufferToBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUBufferToBuffer")]
        static abstract void CopyGpuBufferToBuffer(
            GpuCopyPassHandle copy_pass,
            Ref<GpuBufferLocation> source,
            Ref<GpuBufferLocation> destination,
            uint size,
            MaybeBool<byte> cycle
        );

        [NativeName("SDL_CopyGPUTextureToTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUTextureToTexture")]
        static abstract void CopyGpuTextureToTexture(
            GpuCopyPassHandle copy_pass,
            GpuTextureLocation* source,
            GpuTextureLocation* destination,
            uint w,
            uint h,
            uint d,
            byte cycle
        );

        [NativeName("SDL_CopyGPUTextureToTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUTextureToTexture")]
        static abstract void CopyGpuTextureToTexture(
            GpuCopyPassHandle copy_pass,
            Ref<GpuTextureLocation> source,
            Ref<GpuTextureLocation> destination,
            uint w,
            uint h,
            uint d,
            MaybeBool<byte> cycle
        );

        [NativeName("SDL_CopyProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyProperties")]
        static abstract MaybeBool<byte> CopyProperties(uint src, uint dst);

        [NativeName("SDL_CopyProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyProperties")]
        static abstract byte CopyPropertiesRaw(uint src, uint dst);

        [NativeName("SDL_copysign")]
        [NativeFunction("SDL3", EntryPoint = "SDL_copysign")]
        static abstract double Copysign(double x, double y);

        [NativeName("SDL_copysignf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_copysignf")]
        static abstract float Copysignf(float x, float y);

        [NativeName("SDL_CopyStorageFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyStorageFile")]
        static abstract byte CopyStorageFile(StorageHandle storage, sbyte* oldpath, sbyte* newpath);

        [NativeName("SDL_CopyStorageFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CopyStorageFile")]
        static abstract MaybeBool<byte> CopyStorageFile(
            StorageHandle storage,
            Ref<sbyte> oldpath,
            Ref<sbyte> newpath
        );

        [NativeName("SDL_cos")]
        [NativeFunction("SDL3", EntryPoint = "SDL_cos")]
        static abstract double Cos(double x);

        [NativeName("SDL_cosf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_cosf")]
        static abstract float Cosf(float x);

        [NativeName("SDL_crc16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_crc16")]
        static abstract ushort Crc16(ushort crc, void* data, nuint len);

        [NativeName("SDL_crc16")]
        [NativeFunction("SDL3", EntryPoint = "SDL_crc16")]
        static abstract ushort Crc16(ushort crc, Ref data, nuint len);

        [NativeName("SDL_crc32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_crc32")]
        static abstract uint Crc32(uint crc, void* data, nuint len);

        [NativeName("SDL_crc32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_crc32")]
        static abstract uint Crc32(uint crc, Ref data, nuint len);

        [NativeName("SDL_CreateAudioStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateAudioStream")]
        static abstract AudioStreamHandle CreateAudioStream(
            AudioSpec* src_spec,
            AudioSpec* dst_spec
        );

        [NativeName("SDL_CreateAudioStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateAudioStream")]
        static abstract AudioStreamHandle CreateAudioStream(
            Ref<AudioSpec> src_spec,
            Ref<AudioSpec> dst_spec
        );

        [NativeName("SDL_CreateColorCursor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateColorCursor")]
        static abstract CursorHandle CreateColorCursor(Surface* surface, int hot_x, int hot_y);

        [NativeName("SDL_CreateColorCursor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateColorCursor")]
        static abstract CursorHandle CreateColorCursor(Ref<Surface> surface, int hot_x, int hot_y);

        [NativeName("SDL_CreateCondition")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateCondition")]
        static abstract ConditionHandle CreateCondition();

        [NativeName("SDL_CreateCursor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateCursor")]
        static abstract CursorHandle CreateCursor(
            byte* data,
            byte* mask,
            int w,
            int h,
            int hot_x,
            int hot_y
        );

        [NativeName("SDL_CreateCursor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateCursor")]
        static abstract CursorHandle CreateCursor(
            Ref<byte> data,
            Ref<byte> mask,
            int w,
            int h,
            int hot_x,
            int hot_y
        );

        [NativeName("SDL_CreateDirectory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateDirectory")]
        static abstract byte CreateDirectory(sbyte* path);

        [NativeName("SDL_CreateDirectory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateDirectory")]
        static abstract MaybeBool<byte> CreateDirectory(Ref<sbyte> path);

        [NativeName("SDL_CreateEnvironment")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateEnvironment")]
        static abstract EnvironmentHandle CreateEnvironment(byte populated);

        [NativeName("SDL_CreateEnvironment")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateEnvironment")]
        static abstract EnvironmentHandle CreateEnvironment(MaybeBool<byte> populated);

        [NativeName("SDL_CreateGPUBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUBuffer")]
        static abstract GpuBufferHandle CreateGpuBuffer(
            GpuDeviceHandle device,
            GpuBufferCreateInfo* createinfo
        );

        [NativeName("SDL_CreateGPUBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUBuffer")]
        static abstract GpuBufferHandle CreateGpuBuffer(
            GpuDeviceHandle device,
            Ref<GpuBufferCreateInfo> createinfo
        );

        [NativeName("SDL_CreateGPUComputePipeline")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUComputePipeline")]
        static abstract GpuComputePipelineHandle CreateGpuComputePipeline(
            GpuDeviceHandle device,
            GpuComputePipelineCreateInfo* createinfo
        );

        [NativeName("SDL_CreateGPUComputePipeline")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUComputePipeline")]
        static abstract GpuComputePipelineHandle CreateGpuComputePipeline(
            GpuDeviceHandle device,
            Ref<GpuComputePipelineCreateInfo> createinfo
        );

        [NativeName("SDL_CreateGPUDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUDevice")]
        static abstract GpuDeviceHandle CreateGpuDevice(
            uint format_flags,
            byte debug_mode,
            sbyte* name
        );

        [NativeName("SDL_CreateGPUDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUDevice")]
        static abstract GpuDeviceHandle CreateGpuDevice(
            uint format_flags,
            MaybeBool<byte> debug_mode,
            Ref<sbyte> name
        );

        [NativeName("SDL_CreateGPUDeviceWithProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUDeviceWithProperties")]
        static abstract GpuDeviceHandle CreateGpuDeviceWithProperties(uint props);

        [NativeName("SDL_CreateGPUGraphicsPipeline")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUGraphicsPipeline")]
        static abstract GpuGraphicsPipelineHandle CreateGpuGraphicsPipeline(
            GpuDeviceHandle device,
            GpuGraphicsPipelineCreateInfo* createinfo
        );

        [NativeName("SDL_CreateGPUGraphicsPipeline")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUGraphicsPipeline")]
        static abstract GpuGraphicsPipelineHandle CreateGpuGraphicsPipeline(
            GpuDeviceHandle device,
            Ref<GpuGraphicsPipelineCreateInfo> createinfo
        );

        [NativeName("SDL_CreateGPUSampler")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUSampler")]
        static abstract GpuSamplerHandle CreateGpuSampler(
            GpuDeviceHandle device,
            GpuSamplerCreateInfo* createinfo
        );

        [NativeName("SDL_CreateGPUSampler")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUSampler")]
        static abstract GpuSamplerHandle CreateGpuSampler(
            GpuDeviceHandle device,
            Ref<GpuSamplerCreateInfo> createinfo
        );

        [NativeName("SDL_CreateGPUShader")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUShader")]
        static abstract GpuShaderHandle CreateGpuShader(
            GpuDeviceHandle device,
            GpuShaderCreateInfo* createinfo
        );

        [NativeName("SDL_CreateGPUShader")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUShader")]
        static abstract GpuShaderHandle CreateGpuShader(
            GpuDeviceHandle device,
            Ref<GpuShaderCreateInfo> createinfo
        );

        [NativeName("SDL_CreateGPUTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTexture")]
        static abstract GpuTextureHandle CreateGpuTexture(
            GpuDeviceHandle device,
            GpuTextureCreateInfo* createinfo
        );

        [NativeName("SDL_CreateGPUTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTexture")]
        static abstract GpuTextureHandle CreateGpuTexture(
            GpuDeviceHandle device,
            Ref<GpuTextureCreateInfo> createinfo
        );

        [NativeName("SDL_CreateGPUTransferBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTransferBuffer")]
        static abstract GpuTransferBufferHandle CreateGpuTransferBuffer(
            GpuDeviceHandle device,
            GpuTransferBufferCreateInfo* createinfo
        );

        [NativeName("SDL_CreateGPUTransferBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTransferBuffer")]
        static abstract GpuTransferBufferHandle CreateGpuTransferBuffer(
            GpuDeviceHandle device,
            Ref<GpuTransferBufferCreateInfo> createinfo
        );

        [NativeName("SDL_CreateHapticEffect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateHapticEffect")]
        static abstract int CreateHapticEffect(HapticHandle haptic, HapticEffect* effect);

        [NativeName("SDL_CreateHapticEffect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateHapticEffect")]
        static abstract int CreateHapticEffect(HapticHandle haptic, Ref<HapticEffect> effect);

        [NativeName("SDL_CreateMutex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateMutex")]
        static abstract MutexHandle CreateMutex();

        [NativeName("SDL_CreatePalette")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreatePalette")]
        static abstract Ptr<Palette> CreatePalette(int ncolors);

        [NativeName("SDL_CreatePalette")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreatePalette")]
        static abstract Palette* CreatePaletteRaw(int ncolors);

        [NativeName("SDL_CreatePopupWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreatePopupWindow")]
        static abstract WindowHandle CreatePopupWindow(
            WindowHandle parent,
            int offset_x,
            int offset_y,
            int w,
            int h,
            ulong flags
        );

        [NativeName("SDL_CreateProcess")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateProcess")]
        static abstract ProcessHandle CreateProcess(sbyte** args, byte pipe_stdio);

        [NativeName("SDL_CreateProcess")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateProcess")]
        static abstract ProcessHandle CreateProcess(Ref2D<sbyte> args, MaybeBool<byte> pipe_stdio);

        [NativeName("SDL_CreateProcessWithProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateProcessWithProperties")]
        static abstract ProcessHandle CreateProcessWithProperties(uint props);

        [NativeName("SDL_CreateProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateProperties")]
        static abstract uint CreateProperties();

        [NativeName("SDL_CreateRenderer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateRenderer")]
        static abstract RendererHandle CreateRenderer(WindowHandle window, sbyte* name);

        [NativeName("SDL_CreateRenderer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateRenderer")]
        static abstract RendererHandle CreateRenderer(WindowHandle window, Ref<sbyte> name);

        [NativeName("SDL_CreateRendererWithProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateRendererWithProperties")]
        static abstract RendererHandle CreateRendererWithProperties(uint props);

        [NativeName("SDL_CreateRWLock")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateRWLock")]
        static abstract RwLockHandle CreateRwLock();

        [NativeName("SDL_CreateSemaphore")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSemaphore")]
        static abstract SemaphoreHandle CreateSemaphore(uint initial_value);

        [NativeName("SDL_CreateSoftwareRenderer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSoftwareRenderer")]
        static abstract RendererHandle CreateSoftwareRenderer(Surface* surface);

        [NativeName("SDL_CreateSoftwareRenderer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSoftwareRenderer")]
        static abstract RendererHandle CreateSoftwareRenderer(Ref<Surface> surface);

        [NativeName("SDL_CreateStorageDirectory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateStorageDirectory")]
        static abstract byte CreateStorageDirectory(StorageHandle storage, sbyte* path);

        [NativeName("SDL_CreateStorageDirectory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateStorageDirectory")]
        static abstract MaybeBool<byte> CreateStorageDirectory(
            StorageHandle storage,
            Ref<sbyte> path
        );

        [NativeName("SDL_CreateSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurface")]
        static abstract Ptr<Surface> CreateSurface(int width, int height, PixelFormat format);

        [NativeName("SDL_CreateSurfaceFrom")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfaceFrom")]
        static abstract Surface* CreateSurfaceFrom(
            int width,
            int height,
            PixelFormat format,
            void* pixels,
            int pitch
        );

        [NativeName("SDL_CreateSurfaceFrom")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfaceFrom")]
        static abstract Ptr<Surface> CreateSurfaceFrom(
            int width,
            int height,
            PixelFormat format,
            Ref pixels,
            int pitch
        );

        [NativeName("SDL_CreateSurfacePalette")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfacePalette")]
        static abstract Palette* CreateSurfacePalette(Surface* surface);

        [NativeName("SDL_CreateSurfacePalette")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfacePalette")]
        static abstract Ptr<Palette> CreateSurfacePalette(Ref<Surface> surface);

        [NativeName("SDL_CreateSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurface")]
        static abstract Surface* CreateSurfaceRaw(int width, int height, PixelFormat format);

        [NativeName("SDL_CreateSystemCursor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateSystemCursor")]
        static abstract CursorHandle CreateSystemCursor(SystemCursor id);

        [NativeName("SDL_CreateTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTexture")]
        static abstract Ptr<Texture> CreateTexture(
            RendererHandle renderer,
            PixelFormat format,
            TextureAccess access,
            int w,
            int h
        );

        [NativeName("SDL_CreateTextureFromSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureFromSurface")]
        static abstract Texture* CreateTextureFromSurface(
            RendererHandle renderer,
            Surface* surface
        );

        [NativeName("SDL_CreateTextureFromSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureFromSurface")]
        static abstract Ptr<Texture> CreateTextureFromSurface(
            RendererHandle renderer,
            Ref<Surface> surface
        );

        [NativeName("SDL_CreateTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTexture")]
        static abstract Texture* CreateTextureRaw(
            RendererHandle renderer,
            PixelFormat format,
            TextureAccess access,
            int w,
            int h
        );

        [NativeName("SDL_CreateTextureWithProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureWithProperties")]
        static abstract Ptr<Texture> CreateTextureWithProperties(
            RendererHandle renderer,
            uint props
        );

        [NativeName("SDL_CreateTextureWithProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureWithProperties")]
        static abstract Texture* CreateTextureWithPropertiesRaw(
            RendererHandle renderer,
            uint props
        );

        [NativeName("SDL_CreateThreadRuntime")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadRuntime")]
        static abstract ThreadHandle CreateThreadRuntime(
            ThreadFunction fn,
            sbyte* name,
            void* data,
            FunctionPointer pfnBeginThread,
            FunctionPointer pfnEndThread
        );

        [NativeName("SDL_CreateThreadRuntime")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadRuntime")]
        static abstract ThreadHandle CreateThreadRuntime(
            ThreadFunction fn,
            Ref<sbyte> name,
            Ref data,
            FunctionPointer pfnBeginThread,
            FunctionPointer pfnEndThread
        );

        [NativeName("SDL_CreateThreadWithPropertiesRuntime")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadWithPropertiesRuntime")]
        static abstract ThreadHandle CreateThreadWithPropertiesRuntime(
            uint props,
            FunctionPointer pfnBeginThread,
            FunctionPointer pfnEndThread
        );

        [NativeName("SDL_CreateWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindow")]
        static abstract WindowHandle CreateWindow(sbyte* title, int w, int h, ulong flags);

        [NativeName("SDL_CreateWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindow")]
        static abstract WindowHandle CreateWindow(Ref<sbyte> title, int w, int h, ulong flags);

        [NativeName("SDL_CreateWindowAndRenderer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowAndRenderer")]
        static abstract byte CreateWindowAndRenderer(
            sbyte* title,
            int width,
            int height,
            ulong window_flags,
            WindowHandle* window,
            RendererHandle* renderer
        );

        [NativeName("SDL_CreateWindowAndRenderer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowAndRenderer")]
        static abstract MaybeBool<byte> CreateWindowAndRenderer(
            Ref<sbyte> title,
            int width,
            int height,
            ulong window_flags,
            Ref<WindowHandle> window,
            Ref<RendererHandle> renderer
        );

        [NativeName("SDL_CreateWindowWithProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowWithProperties")]
        static abstract WindowHandle CreateWindowWithProperties(uint props);

        [NativeName("SDL_CursorVisible")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CursorVisible")]
        static abstract MaybeBool<byte> CursorVisible();

        [NativeName("SDL_CursorVisible")]
        [NativeFunction("SDL3", EntryPoint = "SDL_CursorVisible")]
        static abstract byte CursorVisibleRaw();

        [NativeName("SDL_DateTimeToTime")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DateTimeToTime")]
        static abstract byte DateTimeToTime(DateTime* dt, long* ticks);

        [NativeName("SDL_DateTimeToTime")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DateTimeToTime")]
        static abstract MaybeBool<byte> DateTimeToTime(Ref<DateTime> dt, Ref<long> ticks);

        [NativeName("SDL_Delay")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Delay")]
        static abstract void Delay(uint ms);

        [NativeName("SDL_DelayNS")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DelayNS")]
        static abstract void DelayNs(ulong ns);

        [NativeName("SDL_DelayPrecise")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DelayPrecise")]
        static abstract void DelayPrecise(ulong ns);

        [NativeName("SDL_DestroyAudioStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyAudioStream")]
        static abstract void DestroyAudioStream(AudioStreamHandle stream);

        [NativeName("SDL_DestroyCondition")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyCondition")]
        static abstract void DestroyCondition(ConditionHandle cond);

        [NativeName("SDL_DestroyCursor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyCursor")]
        static abstract void DestroyCursor(CursorHandle cursor);

        [NativeName("SDL_DestroyEnvironment")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyEnvironment")]
        static abstract void DestroyEnvironment(EnvironmentHandle env);

        [NativeName("SDL_DestroyGPUDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyGPUDevice")]
        static abstract void DestroyGpuDevice(GpuDeviceHandle device);

        [NativeName("SDL_DestroyHapticEffect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyHapticEffect")]
        static abstract void DestroyHapticEffect(HapticHandle haptic, int effect);

        [NativeName("SDL_DestroyMutex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyMutex")]
        static abstract void DestroyMutex(MutexHandle mutex);

        [NativeName("SDL_DestroyPalette")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPalette")]
        static abstract void DestroyPalette(Palette* palette);

        [NativeName("SDL_DestroyPalette")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPalette")]
        static abstract void DestroyPalette(Ref<Palette> palette);

        [NativeName("SDL_DestroyProcess")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyProcess")]
        static abstract void DestroyProcess(ProcessHandle process);

        [NativeName("SDL_DestroyProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyProperties")]
        static abstract void DestroyProperties(uint props);

        [NativeName("SDL_DestroyRenderer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyRenderer")]
        static abstract void DestroyRenderer(RendererHandle renderer);

        [NativeName("SDL_DestroyRWLock")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyRWLock")]
        static abstract void DestroyRwLock(RwLockHandle rwlock);

        [NativeName("SDL_DestroySemaphore")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroySemaphore")]
        static abstract void DestroySemaphore(SemaphoreHandle sem);

        [NativeName("SDL_DestroySurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroySurface")]
        static abstract void DestroySurface(Surface* surface);

        [NativeName("SDL_DestroySurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroySurface")]
        static abstract void DestroySurface(Ref<Surface> surface);

        [NativeName("SDL_DestroyTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyTexture")]
        static abstract void DestroyTexture(Texture* texture);

        [NativeName("SDL_DestroyTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyTexture")]
        static abstract void DestroyTexture(Ref<Texture> texture);

        [NativeName("SDL_DestroyWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindow")]
        static abstract void DestroyWindow(WindowHandle window);

        [NativeName("SDL_DestroyWindowSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindowSurface")]
        static abstract MaybeBool<byte> DestroyWindowSurface(WindowHandle window);

        [NativeName("SDL_DestroyWindowSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindowSurface")]
        static abstract byte DestroyWindowSurfaceRaw(WindowHandle window);

        [NativeName("SDL_DetachThread")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DetachThread")]
        static abstract void DetachThread(ThreadHandle thread);

        [NativeName("SDL_DetachVirtualJoystick")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DetachVirtualJoystick")]
        static abstract MaybeBool<byte> DetachVirtualJoystick(uint instance_id);

        [NativeName("SDL_DetachVirtualJoystick")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DetachVirtualJoystick")]
        static abstract byte DetachVirtualJoystickRaw(uint instance_id);

        [NativeName("SDL_DisableScreenSaver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DisableScreenSaver")]
        static abstract MaybeBool<byte> DisableScreenSaver();

        [NativeName("SDL_DisableScreenSaver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DisableScreenSaver")]
        static abstract byte DisableScreenSaverRaw();

        [NativeName("SDL_DispatchGPUCompute")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DispatchGPUCompute")]
        static abstract void DispatchGpuCompute(
            GpuComputePassHandle compute_pass,
            uint groupcount_x,
            uint groupcount_y,
            uint groupcount_z
        );

        [NativeName("SDL_DispatchGPUComputeIndirect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DispatchGPUComputeIndirect")]
        static abstract void DispatchGpuComputeIndirect(
            GpuComputePassHandle compute_pass,
            GpuBufferHandle buffer,
            uint offset
        );

        [NativeName("SDL_DownloadFromGPUBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUBuffer")]
        static abstract void DownloadFromGpuBuffer(
            GpuCopyPassHandle copy_pass,
            GpuBufferRegion* source,
            GpuTransferBufferLocation* destination
        );

        [NativeName("SDL_DownloadFromGPUBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUBuffer")]
        static abstract void DownloadFromGpuBuffer(
            GpuCopyPassHandle copy_pass,
            Ref<GpuBufferRegion> source,
            Ref<GpuTransferBufferLocation> destination
        );

        [NativeName("SDL_DownloadFromGPUTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUTexture")]
        static abstract void DownloadFromGpuTexture(
            GpuCopyPassHandle copy_pass,
            GpuTextureRegion* source,
            GpuTextureTransferInfo* destination
        );

        [NativeName("SDL_DownloadFromGPUTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUTexture")]
        static abstract void DownloadFromGpuTexture(
            GpuCopyPassHandle copy_pass,
            Ref<GpuTextureRegion> source,
            Ref<GpuTextureTransferInfo> destination
        );

        [NativeName("SDL_DrawGPUIndexedPrimitives")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUIndexedPrimitives")]
        static abstract void DrawGpuIndexedPrimitives(
            GpuRenderPassHandle render_pass,
            uint num_indices,
            uint num_instances,
            uint first_index,
            int vertex_offset,
            uint first_instance
        );

        [NativeName("SDL_DrawGPUIndexedPrimitivesIndirect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUIndexedPrimitivesIndirect")]
        static abstract void DrawGpuIndexedPrimitivesIndirect(
            GpuRenderPassHandle render_pass,
            GpuBufferHandle buffer,
            uint offset,
            uint draw_count
        );

        [NativeName("SDL_DrawGPUPrimitives")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUPrimitives")]
        static abstract void DrawGpuPrimitives(
            GpuRenderPassHandle render_pass,
            uint num_vertices,
            uint num_instances,
            uint first_vertex,
            uint first_instance
        );

        [NativeName("SDL_DrawGPUPrimitivesIndirect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUPrimitivesIndirect")]
        static abstract void DrawGpuPrimitivesIndirect(
            GpuRenderPassHandle render_pass,
            GpuBufferHandle buffer,
            uint offset,
            uint draw_count
        );

        [NativeName("SDL_DuplicateSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DuplicateSurface")]
        static abstract Surface* DuplicateSurface(Surface* surface);

        [NativeName("SDL_DuplicateSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_DuplicateSurface")]
        static abstract Ptr<Surface> DuplicateSurface(Ref<Surface> surface);

        [NativeName("SDL_EGL_GetCurrentConfig")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentConfig")]
        static abstract Ptr EglGetCurrentConfig();

        [NativeName("SDL_EGL_GetCurrentConfig")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentConfig")]
        static abstract void* EglGetCurrentConfigRaw();

        [NativeName("SDL_EGL_GetCurrentDisplay")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentDisplay")]
        static abstract Ptr EglGetCurrentDisplay();

        [NativeName("SDL_EGL_GetCurrentDisplay")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentDisplay")]
        static abstract void* EglGetCurrentDisplayRaw();

        [NativeName("SDL_EGL_GetProcAddress")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetProcAddress")]
        static abstract FunctionPointer EglGetProcAddress(sbyte* proc);

        [NativeName("SDL_EGL_GetProcAddress")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetProcAddress")]
        static abstract FunctionPointer EglGetProcAddress(Ref<sbyte> proc);

        [NativeName("SDL_EGL_GetWindowSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetWindowSurface")]
        static abstract Ptr EglGetWindowSurface(WindowHandle window);

        [NativeName("SDL_EGL_GetWindowSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetWindowSurface")]
        static abstract void* EglGetWindowSurfaceRaw(WindowHandle window);

        [NativeName("SDL_EGL_SetAttributeCallbacks")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_SetAttributeCallbacks")]
        static abstract void EglSetAttributeCallbacks(
            EglAttribArrayCallback platformAttribCallback,
            EglIntArrayCallback surfaceAttribCallback,
            EglIntArrayCallback contextAttribCallback,
            void* userdata
        );

        [NativeName("SDL_EGL_SetAttributeCallbacks")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EGL_SetAttributeCallbacks")]
        static abstract void EglSetAttributeCallbacks(
            EglAttribArrayCallback platformAttribCallback,
            EglIntArrayCallback surfaceAttribCallback,
            EglIntArrayCallback contextAttribCallback,
            Ref userdata
        );

        [NativeName("SDL_EnableScreenSaver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnableScreenSaver")]
        static abstract MaybeBool<byte> EnableScreenSaver();

        [NativeName("SDL_EnableScreenSaver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnableScreenSaver")]
        static abstract byte EnableScreenSaverRaw();

        [NativeName("SDL_EndGPUComputePass")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EndGPUComputePass")]
        static abstract void EndGpuComputePass(GpuComputePassHandle compute_pass);

        [NativeName("SDL_EndGPUCopyPass")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EndGPUCopyPass")]
        static abstract void EndGpuCopyPass(GpuCopyPassHandle copy_pass);

        [NativeName("SDL_EndGPURenderPass")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EndGPURenderPass")]
        static abstract void EndGpuRenderPass(GpuRenderPassHandle render_pass);

        [NativeName("SDL_EnterAppMainCallbacks")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnterAppMainCallbacks")]
        static abstract int EnterAppMainCallbacks(
            int argc,
            sbyte** argv,
            AppInitFunc appinit,
            AppIterateFunc appiter,
            AppEventFunc appevent,
            AppQuitFunc appquit
        );

        [NativeName("SDL_EnterAppMainCallbacks")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnterAppMainCallbacks")]
        static abstract int EnterAppMainCallbacks(
            int argc,
            Ref2D<sbyte> argv,
            AppInitFunc appinit,
            AppIterateFunc appiter,
            AppEventFunc appevent,
            AppQuitFunc appquit
        );

        [NativeName("SDL_EnumerateDirectory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateDirectory")]
        static abstract byte EnumerateDirectory(
            sbyte* path,
            EnumerateDirectoryCallback callback,
            void* userdata
        );

        [NativeName("SDL_EnumerateDirectory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateDirectory")]
        static abstract MaybeBool<byte> EnumerateDirectory(
            Ref<sbyte> path,
            EnumerateDirectoryCallback callback,
            Ref userdata
        );

        [NativeName("SDL_EnumerateProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateProperties")]
        static abstract byte EnumerateProperties(
            uint props,
            EnumeratePropertiesCallback callback,
            void* userdata
        );

        [NativeName("SDL_EnumerateProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateProperties")]
        static abstract MaybeBool<byte> EnumerateProperties(
            uint props,
            EnumeratePropertiesCallback callback,
            Ref userdata
        );

        [NativeName("SDL_EnumerateStorageDirectory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateStorageDirectory")]
        static abstract byte EnumerateStorageDirectory(
            StorageHandle storage,
            sbyte* path,
            EnumerateDirectoryCallback callback,
            void* userdata
        );

        [NativeName("SDL_EnumerateStorageDirectory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateStorageDirectory")]
        static abstract MaybeBool<byte> EnumerateStorageDirectory(
            StorageHandle storage,
            Ref<sbyte> path,
            EnumerateDirectoryCallback callback,
            Ref userdata
        );

        [NativeName("SDL_EventEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EventEnabled")]
        static abstract MaybeBool<byte> EventEnabled(uint type);

        [NativeName("SDL_EventEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_EventEnabled")]
        static abstract byte EventEnabledRaw(uint type);

        [NativeName("SDL_exp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_exp")]
        static abstract double Exp(double x);

        [NativeName("SDL_expf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_expf")]
        static abstract float Expf(float x);

        [NativeName("SDL_fabs")]
        [NativeFunction("SDL3", EntryPoint = "SDL_fabs")]
        static abstract double Fabs(double x);

        [NativeName("SDL_FillSurfaceRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRect")]
        static abstract byte FillSurfaceRect(Surface* dst, Rect* rect, uint color);

        [NativeName("SDL_FillSurfaceRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRect")]
        static abstract MaybeBool<byte> FillSurfaceRect(
            Ref<Surface> dst,
            Ref<Rect> rect,
            uint color
        );

        [NativeName("SDL_FillSurfaceRects")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRects")]
        static abstract byte FillSurfaceRects(Surface* dst, Rect* rects, int count, uint color);

        [NativeName("SDL_FillSurfaceRects")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRects")]
        static abstract MaybeBool<byte> FillSurfaceRects(
            Ref<Surface> dst,
            Ref<Rect> rects,
            int count,
            uint color
        );

        [NativeName("SDL_FilterEvents")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FilterEvents")]
        static abstract void FilterEvents(EventFilter filter, void* userdata);

        [NativeName("SDL_FilterEvents")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FilterEvents")]
        static abstract void FilterEvents(EventFilter filter, Ref userdata);

        [NativeName("SDL_FlashWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlashWindow")]
        static abstract MaybeBool<byte> FlashWindow(WindowHandle window, FlashOperation operation);

        [NativeName("SDL_FlashWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlashWindow")]
        static abstract byte FlashWindowRaw(WindowHandle window, FlashOperation operation);

        [NativeName("SDL_FlipSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlipSurface")]
        static abstract byte FlipSurface(Surface* surface, FlipMode flip);

        [NativeName("SDL_FlipSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlipSurface")]
        static abstract MaybeBool<byte> FlipSurface(Ref<Surface> surface, FlipMode flip);

        [NativeName("SDL_floor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_floor")]
        static abstract double Floor(double x);

        [NativeName("SDL_floorf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_floorf")]
        static abstract float Floorf(float x);

        [NativeName("SDL_FlushAudioStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlushAudioStream")]
        static abstract MaybeBool<byte> FlushAudioStream(AudioStreamHandle stream);

        [NativeName("SDL_FlushAudioStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlushAudioStream")]
        static abstract byte FlushAudioStreamRaw(AudioStreamHandle stream);

        [NativeName("SDL_FlushEvent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlushEvent")]
        static abstract void FlushEvent(uint type);

        [NativeName("SDL_FlushEvents")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlushEvents")]
        static abstract void FlushEvents(uint minType, uint maxType);

        [NativeName("SDL_FlushIO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlushIO")]
        static abstract MaybeBool<byte> FlushIo(IoStreamHandle context);

        [NativeName("SDL_FlushIO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlushIO")]
        static abstract byte FlushIoRaw(IoStreamHandle context);

        [NativeName("SDL_FlushRenderer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlushRenderer")]
        static abstract MaybeBool<byte> FlushRenderer(RendererHandle renderer);

        [NativeName("SDL_FlushRenderer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_FlushRenderer")]
        static abstract byte FlushRendererRaw(RendererHandle renderer);

        [NativeName("SDL_fmod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_fmod")]
        static abstract double Fmod(double x, double y);

        [NativeName("SDL_fmodf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_fmodf")]
        static abstract float Fmodf(float x, float y);

        [NativeName("SDL_free")]
        [NativeFunction("SDL3", EntryPoint = "SDL_free")]
        static abstract void Free(void* mem);

        [NativeName("SDL_free")]
        [NativeFunction("SDL3", EntryPoint = "SDL_free")]
        static abstract void Free(Ref mem);

        [NativeName("SDL_GamepadConnected")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadConnected")]
        static abstract MaybeBool<byte> GamepadConnected(GamepadHandle gamepad);

        [NativeName("SDL_GamepadConnected")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadConnected")]
        static abstract byte GamepadConnectedRaw(GamepadHandle gamepad);

        [NativeName("SDL_GamepadEventsEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadEventsEnabled")]
        static abstract MaybeBool<byte> GamepadEventsEnabled();

        [NativeName("SDL_GamepadEventsEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadEventsEnabled")]
        static abstract byte GamepadEventsEnabledRaw();

        [NativeName("SDL_GamepadHasAxis")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasAxis")]
        static abstract MaybeBool<byte> GamepadHasAxis(GamepadHandle gamepad, GamepadAxis axis);

        [NativeName("SDL_GamepadHasAxis")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasAxis")]
        static abstract byte GamepadHasAxisRaw(GamepadHandle gamepad, GamepadAxis axis);

        [NativeName("SDL_GamepadHasButton")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasButton")]
        static abstract MaybeBool<byte> GamepadHasButton(
            GamepadHandle gamepad,
            GamepadButton button
        );

        [NativeName("SDL_GamepadHasButton")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasButton")]
        static abstract byte GamepadHasButtonRaw(GamepadHandle gamepad, GamepadButton button);

        [NativeName("SDL_GamepadHasSensor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasSensor")]
        static abstract MaybeBool<byte> GamepadHasSensor(GamepadHandle gamepad, SensorType type);

        [NativeName("SDL_GamepadHasSensor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasSensor")]
        static abstract byte GamepadHasSensorRaw(GamepadHandle gamepad, SensorType type);

        [NativeName("SDL_GamepadSensorEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadSensorEnabled")]
        static abstract MaybeBool<byte> GamepadSensorEnabled(
            GamepadHandle gamepad,
            SensorType type
        );

        [NativeName("SDL_GamepadSensorEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GamepadSensorEnabled")]
        static abstract byte GamepadSensorEnabledRaw(GamepadHandle gamepad, SensorType type);

        [NativeName("SDL_GDKSuspendComplete")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GDKSuspendComplete")]
        static abstract void GdkSuspendComplete();

        [NativeName("SDL_GenerateMipmapsForGPUTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GenerateMipmapsForGPUTexture")]
        static abstract void GenerateMipmapsForGpuTexture(
            GpuCommandBufferHandle command_buffer,
            GpuTextureHandle texture
        );

        [NativeName("SDL_GetAppMetadataProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAppMetadataProperty")]
        static abstract sbyte* GetAppMetadataProperty(sbyte* name);

        [NativeName("SDL_GetAppMetadataProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAppMetadataProperty")]
        static abstract Ptr<sbyte> GetAppMetadataProperty(Ref<sbyte> name);

        [NativeName("SDL_GetAssertionHandler")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionHandler")]
        static abstract AssertionHandler GetAssertionHandler(void** puserdata);

        [NativeName("SDL_GetAssertionHandler")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionHandler")]
        static abstract AssertionHandler GetAssertionHandler(Ref2D puserdata);

        [NativeName("SDL_GetAssertionReport")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionReport")]
        static abstract Ptr<AssertData> GetAssertionReport();

        [NativeName("SDL_GetAssertionReport")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionReport")]
        static abstract AssertData* GetAssertionReportRaw();

        [NativeName("SDL_GetAtomicInt")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicInt")]
        static abstract int GetAtomicInt(AtomicInt* a);

        [NativeName("SDL_GetAtomicInt")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicInt")]
        static abstract int GetAtomicInt(Ref<AtomicInt> a);

        [NativeName("SDL_GetAtomicPointer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicPointer")]
        static abstract void* GetAtomicPointer(void** a);

        [NativeName("SDL_GetAtomicPointer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicPointer")]
        static abstract Ptr GetAtomicPointer(Ref2D a);

        [NativeName("SDL_GetAtomicU32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicU32")]
        static abstract uint GetAtomicU32(AtomicU32* a);

        [NativeName("SDL_GetAtomicU32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicU32")]
        static abstract uint GetAtomicU32(Ref<AtomicU32> a);

        [NativeName("SDL_GetAudioDeviceChannelMap")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceChannelMap")]
        static abstract int* GetAudioDeviceChannelMap(uint devid, int* count);

        [NativeName("SDL_GetAudioDeviceChannelMap")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceChannelMap")]
        static abstract Ptr<int> GetAudioDeviceChannelMap(uint devid, Ref<int> count);

        [NativeName("SDL_GetAudioDeviceFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceFormat")]
        static abstract byte GetAudioDeviceFormat(uint devid, AudioSpec* spec, int* sample_frames);

        [NativeName("SDL_GetAudioDeviceFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceFormat")]
        static abstract MaybeBool<byte> GetAudioDeviceFormat(
            uint devid,
            Ref<AudioSpec> spec,
            Ref<int> sample_frames
        );

        [NativeName("SDL_GetAudioDeviceGain")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceGain")]
        static abstract float GetAudioDeviceGain(uint devid);

        [NativeName("SDL_GetAudioDeviceName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceName")]
        static abstract Ptr<sbyte> GetAudioDeviceName(uint devid);

        [NativeName("SDL_GetAudioDeviceName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceName")]
        static abstract sbyte* GetAudioDeviceNameRaw(uint devid);

        [NativeName("SDL_GetAudioDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDriver")]
        static abstract Ptr<sbyte> GetAudioDriver(int index);

        [NativeName("SDL_GetAudioDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDriver")]
        static abstract sbyte* GetAudioDriverRaw(int index);

        [NativeName("SDL_GetAudioFormatName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioFormatName")]
        static abstract Ptr<sbyte> GetAudioFormatName(AudioFormat format);

        [NativeName("SDL_GetAudioFormatName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioFormatName")]
        static abstract sbyte* GetAudioFormatNameRaw(AudioFormat format);

        [NativeName("SDL_GetAudioPlaybackDevices")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioPlaybackDevices")]
        static abstract uint* GetAudioPlaybackDevices(int* count);

        [NativeName("SDL_GetAudioPlaybackDevices")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioPlaybackDevices")]
        static abstract Ptr<uint> GetAudioPlaybackDevices(Ref<int> count);

        [NativeName("SDL_GetAudioRecordingDevices")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioRecordingDevices")]
        static abstract uint* GetAudioRecordingDevices(int* count);

        [NativeName("SDL_GetAudioRecordingDevices")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioRecordingDevices")]
        static abstract Ptr<uint> GetAudioRecordingDevices(Ref<int> count);

        [NativeName("SDL_GetAudioStreamAvailable")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamAvailable")]
        static abstract int GetAudioStreamAvailable(AudioStreamHandle stream);

        [NativeName("SDL_GetAudioStreamData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamData")]
        static abstract int GetAudioStreamData(AudioStreamHandle stream, void* buf, int len);

        [NativeName("SDL_GetAudioStreamData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamData")]
        static abstract int GetAudioStreamData(AudioStreamHandle stream, Ref buf, int len);

        [NativeName("SDL_GetAudioStreamDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamDevice")]
        static abstract uint GetAudioStreamDevice(AudioStreamHandle stream);

        [NativeName("SDL_GetAudioStreamFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFormat")]
        static abstract byte GetAudioStreamFormat(
            AudioStreamHandle stream,
            AudioSpec* src_spec,
            AudioSpec* dst_spec
        );

        [NativeName("SDL_GetAudioStreamFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFormat")]
        static abstract MaybeBool<byte> GetAudioStreamFormat(
            AudioStreamHandle stream,
            Ref<AudioSpec> src_spec,
            Ref<AudioSpec> dst_spec
        );

        [NativeName("SDL_GetAudioStreamFrequencyRatio")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFrequencyRatio")]
        static abstract float GetAudioStreamFrequencyRatio(AudioStreamHandle stream);

        [NativeName("SDL_GetAudioStreamGain")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamGain")]
        static abstract float GetAudioStreamGain(AudioStreamHandle stream);

        [NativeName("SDL_GetAudioStreamInputChannelMap")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamInputChannelMap")]
        static abstract int* GetAudioStreamInputChannelMap(AudioStreamHandle stream, int* count);

        [NativeName("SDL_GetAudioStreamInputChannelMap")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamInputChannelMap")]
        static abstract Ptr<int> GetAudioStreamInputChannelMap(
            AudioStreamHandle stream,
            Ref<int> count
        );

        [NativeName("SDL_GetAudioStreamOutputChannelMap")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamOutputChannelMap")]
        static abstract int* GetAudioStreamOutputChannelMap(AudioStreamHandle stream, int* count);

        [NativeName("SDL_GetAudioStreamOutputChannelMap")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamOutputChannelMap")]
        static abstract Ptr<int> GetAudioStreamOutputChannelMap(
            AudioStreamHandle stream,
            Ref<int> count
        );

        [NativeName("SDL_GetAudioStreamProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamProperties")]
        static abstract uint GetAudioStreamProperties(AudioStreamHandle stream);

        [NativeName("SDL_GetAudioStreamQueued")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamQueued")]
        static abstract int GetAudioStreamQueued(AudioStreamHandle stream);

        [NativeName("SDL_GetBasePath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetBasePath")]
        static abstract Ptr<sbyte> GetBasePath();

        [NativeName("SDL_GetBasePath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetBasePath")]
        static abstract sbyte* GetBasePathRaw();

        [NativeName("SDL_GetBooleanProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetBooleanProperty")]
        static abstract byte GetBooleanProperty(uint props, sbyte* name, byte default_value);

        [NativeName("SDL_GetBooleanProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetBooleanProperty")]
        static abstract MaybeBool<byte> GetBooleanProperty(
            uint props,
            Ref<sbyte> name,
            MaybeBool<byte> default_value
        );

        [NativeName("SDL_GetCameraDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDriver")]
        static abstract Ptr<sbyte> GetCameraDriver(int index);

        [NativeName("SDL_GetCameraDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDriver")]
        static abstract sbyte* GetCameraDriverRaw(int index);

        [NativeName("SDL_GetCameraFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraFormat")]
        static abstract byte GetCameraFormat(CameraHandle camera, CameraSpec* spec);

        [NativeName("SDL_GetCameraFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraFormat")]
        static abstract MaybeBool<byte> GetCameraFormat(CameraHandle camera, Ref<CameraSpec> spec);

        [NativeName("SDL_GetCameraID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraID")]
        static abstract uint GetCameraId(CameraHandle camera);

        [NativeName("SDL_GetCameraName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraName")]
        static abstract Ptr<sbyte> GetCameraName(uint instance_id);

        [NativeName("SDL_GetCameraName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraName")]
        static abstract sbyte* GetCameraNameRaw(uint instance_id);

        [NativeName("SDL_GetCameraPermissionState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraPermissionState")]
        static abstract int GetCameraPermissionState(CameraHandle camera);

        [NativeName("SDL_GetCameraPosition")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraPosition")]
        static abstract CameraPosition GetCameraPosition(uint instance_id);

        [NativeName("SDL_GetCameraProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraProperties")]
        static abstract uint GetCameraProperties(CameraHandle camera);

        [NativeName("SDL_GetCameras")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameras")]
        static abstract uint* GetCameras(int* count);

        [NativeName("SDL_GetCameras")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameras")]
        static abstract Ptr<uint> GetCameras(Ref<int> count);

        [NativeName("SDL_GetCameraSupportedFormats")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraSupportedFormats")]
        static abstract CameraSpec** GetCameraSupportedFormats(uint instance_id, int* count);

        [NativeName("SDL_GetCameraSupportedFormats")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraSupportedFormats")]
        static abstract Ptr2D<CameraSpec> GetCameraSupportedFormats(
            uint instance_id,
            Ref<int> count
        );

        [NativeName("SDL_GetClipboardData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardData")]
        static abstract void* GetClipboardData(sbyte* mime_type, nuint* size);

        [NativeName("SDL_GetClipboardData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardData")]
        static abstract Ptr GetClipboardData(Ref<sbyte> mime_type, Ref<nuint> size);

        [NativeName("SDL_GetClipboardMimeTypes")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardMimeTypes")]
        static abstract sbyte** GetClipboardMimeTypes(nuint* num_mime_types);

        [NativeName("SDL_GetClipboardMimeTypes")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardMimeTypes")]
        static abstract Ptr2D<sbyte> GetClipboardMimeTypes(Ref<nuint> num_mime_types);

        [NativeName("SDL_GetClipboardText")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardText")]
        static abstract Ptr<sbyte> GetClipboardText();

        [NativeName("SDL_GetClipboardText")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardText")]
        static abstract sbyte* GetClipboardTextRaw();

        [NativeName("SDL_GetClosestFullscreenDisplayMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
        static abstract byte GetClosestFullscreenDisplayMode(
            uint displayID,
            int w,
            int h,
            float refresh_rate,
            byte include_high_density_modes,
            DisplayMode* closest
        );

        [NativeName("SDL_GetClosestFullscreenDisplayMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
        static abstract MaybeBool<byte> GetClosestFullscreenDisplayMode(
            uint displayID,
            int w,
            int h,
            float refresh_rate,
            MaybeBool<byte> include_high_density_modes,
            Ref<DisplayMode> closest
        );

        [NativeName("SDL_GetCPUCacheLineSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCPUCacheLineSize")]
        static abstract int GetCpuCacheLineSize();

        [NativeName("SDL_GetCurrentAudioDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentAudioDriver")]
        static abstract Ptr<sbyte> GetCurrentAudioDriver();

        [NativeName("SDL_GetCurrentAudioDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentAudioDriver")]
        static abstract sbyte* GetCurrentAudioDriverRaw();

        [NativeName("SDL_GetCurrentCameraDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentCameraDriver")]
        static abstract Ptr<sbyte> GetCurrentCameraDriver();

        [NativeName("SDL_GetCurrentCameraDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentCameraDriver")]
        static abstract sbyte* GetCurrentCameraDriverRaw();

        [NativeName("SDL_GetCurrentDirectory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDirectory")]
        static abstract Ptr<sbyte> GetCurrentDirectory();

        [NativeName("SDL_GetCurrentDirectory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDirectory")]
        static abstract sbyte* GetCurrentDirectoryRaw();

        [NativeName("SDL_GetCurrentDisplayMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDisplayMode")]
        static abstract Ptr<DisplayMode> GetCurrentDisplayMode(uint displayID);

        [NativeName("SDL_GetCurrentDisplayMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDisplayMode")]
        static abstract DisplayMode* GetCurrentDisplayModeRaw(uint displayID);

        [NativeName("SDL_GetCurrentDisplayOrientation")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDisplayOrientation")]
        static abstract DisplayOrientation GetCurrentDisplayOrientation(uint displayID);

        [NativeName("SDL_GetCurrentRenderOutputSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentRenderOutputSize")]
        static abstract byte GetCurrentRenderOutputSize(RendererHandle renderer, int* w, int* h);

        [NativeName("SDL_GetCurrentRenderOutputSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentRenderOutputSize")]
        static abstract MaybeBool<byte> GetCurrentRenderOutputSize(
            RendererHandle renderer,
            Ref<int> w,
            Ref<int> h
        );

        [NativeName("SDL_GetCurrentThreadID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentThreadID")]
        static abstract ulong GetCurrentThreadId();

        [NativeName("SDL_GetCurrentTime")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentTime")]
        static abstract byte GetCurrentTime(long* ticks);

        [NativeName("SDL_GetCurrentTime")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentTime")]
        static abstract MaybeBool<byte> GetCurrentTime(Ref<long> ticks);

        [NativeName("SDL_GetCurrentVideoDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentVideoDriver")]
        static abstract Ptr<sbyte> GetCurrentVideoDriver();

        [NativeName("SDL_GetCurrentVideoDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentVideoDriver")]
        static abstract sbyte* GetCurrentVideoDriverRaw();

        [NativeName("SDL_GetCursor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetCursor")]
        static abstract CursorHandle GetCursor();

        [NativeName("SDL_GetDateTimeLocalePreferences")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDateTimeLocalePreferences")]
        static abstract byte GetDateTimeLocalePreferences(
            DateFormat* dateFormat,
            TimeFormat* timeFormat
        );

        [NativeName("SDL_GetDateTimeLocalePreferences")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDateTimeLocalePreferences")]
        static abstract MaybeBool<byte> GetDateTimeLocalePreferences(
            Ref<DateFormat> dateFormat,
            Ref<TimeFormat> timeFormat
        );

        [NativeName("SDL_GetDayOfWeek")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDayOfWeek")]
        static abstract int GetDayOfWeek(int year, int month, int day);

        [NativeName("SDL_GetDayOfYear")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDayOfYear")]
        static abstract int GetDayOfYear(int year, int month, int day);

        [NativeName("SDL_GetDaysInMonth")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDaysInMonth")]
        static abstract int GetDaysInMonth(int year, int month);

        [NativeName("SDL_GetDefaultAssertionHandler")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultAssertionHandler")]
        static abstract AssertionHandler GetDefaultAssertionHandler();

        [NativeName("SDL_GetDefaultCursor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultCursor")]
        static abstract CursorHandle GetDefaultCursor();

        [NativeName("SDL_GetDefaultLogOutputFunction")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultLogOutputFunction")]
        static abstract LogOutputFunction GetDefaultLogOutputFunction();

        [NativeName("SDL_GetDesktopDisplayMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDesktopDisplayMode")]
        static abstract Ptr<DisplayMode> GetDesktopDisplayMode(uint displayID);

        [NativeName("SDL_GetDesktopDisplayMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDesktopDisplayMode")]
        static abstract DisplayMode* GetDesktopDisplayModeRaw(uint displayID);

        [NativeName("SDL_GetDirect3D9AdapterIndex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDirect3D9AdapterIndex")]
        static abstract int GetDirect3D9AdapterIndex(uint displayID);

        [NativeName("SDL_GetDisplayBounds")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayBounds")]
        static abstract byte GetDisplayBounds(uint displayID, Rect* rect);

        [NativeName("SDL_GetDisplayBounds")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayBounds")]
        static abstract MaybeBool<byte> GetDisplayBounds(uint displayID, Ref<Rect> rect);

        [NativeName("SDL_GetDisplayContentScale")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayContentScale")]
        static abstract float GetDisplayContentScale(uint displayID);

        [NativeName("SDL_GetDisplayForPoint")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForPoint")]
        static abstract uint GetDisplayForPoint(Point* point);

        [NativeName("SDL_GetDisplayForPoint")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForPoint")]
        static abstract uint GetDisplayForPoint(Ref<Point> point);

        [NativeName("SDL_GetDisplayForRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForRect")]
        static abstract uint GetDisplayForRect(Rect* rect);

        [NativeName("SDL_GetDisplayForRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForRect")]
        static abstract uint GetDisplayForRect(Ref<Rect> rect);

        [NativeName("SDL_GetDisplayForWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForWindow")]
        static abstract uint GetDisplayForWindow(WindowHandle window);

        [NativeName("SDL_GetDisplayName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayName")]
        static abstract Ptr<sbyte> GetDisplayName(uint displayID);

        [NativeName("SDL_GetDisplayName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayName")]
        static abstract sbyte* GetDisplayNameRaw(uint displayID);

        [NativeName("SDL_GetDisplayProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayProperties")]
        static abstract uint GetDisplayProperties(uint displayID);

        [NativeName("SDL_GetDisplays")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplays")]
        static abstract uint* GetDisplays(int* count);

        [NativeName("SDL_GetDisplays")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplays")]
        static abstract Ptr<uint> GetDisplays(Ref<int> count);

        [NativeName("SDL_GetDisplayUsableBounds")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayUsableBounds")]
        static abstract byte GetDisplayUsableBounds(uint displayID, Rect* rect);

        [NativeName("SDL_GetDisplayUsableBounds")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayUsableBounds")]
        static abstract MaybeBool<byte> GetDisplayUsableBounds(uint displayID, Ref<Rect> rect);

        [NativeName("SDL_GetDXGIOutputInfo")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDXGIOutputInfo")]
        static abstract byte GetDxgiOutputInfo(uint displayID, int* adapterIndex, int* outputIndex);

        [NativeName("SDL_GetDXGIOutputInfo")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetDXGIOutputInfo")]
        static abstract MaybeBool<byte> GetDxgiOutputInfo(
            uint displayID,
            Ref<int> adapterIndex,
            Ref<int> outputIndex
        );

        [NativeName("SDL_getenv")]
        [NativeFunction("SDL3", EntryPoint = "SDL_getenv")]
        static abstract sbyte* Getenv(sbyte* name);

        [NativeName("SDL_getenv")]
        [NativeFunction("SDL3", EntryPoint = "SDL_getenv")]
        static abstract Ptr<sbyte> Getenv(Ref<sbyte> name);

        [NativeName("SDL_getenv_unsafe")]
        [NativeFunction("SDL3", EntryPoint = "SDL_getenv_unsafe")]
        static abstract sbyte* GetenvUnsafe(sbyte* name);

        [NativeName("SDL_getenv_unsafe")]
        [NativeFunction("SDL3", EntryPoint = "SDL_getenv_unsafe")]
        static abstract Ptr<sbyte> GetenvUnsafe(Ref<sbyte> name);

        [NativeName("SDL_GetEnvironment")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironment")]
        static abstract EnvironmentHandle GetEnvironment();

        [NativeName("SDL_GetEnvironmentVariable")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariable")]
        static abstract sbyte* GetEnvironmentVariable(EnvironmentHandle env, sbyte* name);

        [NativeName("SDL_GetEnvironmentVariable")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariable")]
        static abstract Ptr<sbyte> GetEnvironmentVariable(EnvironmentHandle env, Ref<sbyte> name);

        [NativeName("SDL_GetEnvironmentVariables")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariables")]
        static abstract Ptr2D<sbyte> GetEnvironmentVariables(EnvironmentHandle env);

        [NativeName("SDL_GetEnvironmentVariables")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariables")]
        static abstract sbyte** GetEnvironmentVariablesRaw(EnvironmentHandle env);

        [NativeName("SDL_GetError")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetError")]
        static abstract Ptr<sbyte> GetError();

        [NativeName("SDL_GetError")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetError")]
        static abstract sbyte* GetErrorRaw();

        [NativeName("SDL_GetEventFilter")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEventFilter")]
        static abstract byte GetEventFilter(EventFilter* filter, void** userdata);

        [NativeName("SDL_GetEventFilter")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetEventFilter")]
        static abstract MaybeBool<byte> GetEventFilter(Ref<EventFilter> filter, Ref2D userdata);

        [NativeName("SDL_GetFloatProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetFloatProperty")]
        static abstract float GetFloatProperty(uint props, sbyte* name, float default_value);

        [NativeName("SDL_GetFloatProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetFloatProperty")]
        static abstract float GetFloatProperty(uint props, Ref<sbyte> name, float default_value);

        [NativeName("SDL_GetFullscreenDisplayModes")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetFullscreenDisplayModes")]
        static abstract DisplayMode** GetFullscreenDisplayModes(uint displayID, int* count);

        [NativeName("SDL_GetFullscreenDisplayModes")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetFullscreenDisplayModes")]
        static abstract Ptr2D<DisplayMode> GetFullscreenDisplayModes(
            uint displayID,
            Ref<int> count
        );

        [NativeName("SDL_GetGamepadAppleSFSymbolsNameForAxis")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis")]
        static abstract Ptr<sbyte> GetGamepadAppleSfSymbolsNameForAxis(
            GamepadHandle gamepad,
            GamepadAxis axis
        );

        [NativeName("SDL_GetGamepadAppleSFSymbolsNameForAxis")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis")]
        static abstract sbyte* GetGamepadAppleSfSymbolsNameForAxisRaw(
            GamepadHandle gamepad,
            GamepadAxis axis
        );

        [NativeName("SDL_GetGamepadAppleSFSymbolsNameForButton")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton")]
        static abstract Ptr<sbyte> GetGamepadAppleSfSymbolsNameForButton(
            GamepadHandle gamepad,
            GamepadButton button
        );

        [NativeName("SDL_GetGamepadAppleSFSymbolsNameForButton")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton")]
        static abstract sbyte* GetGamepadAppleSfSymbolsNameForButtonRaw(
            GamepadHandle gamepad,
            GamepadButton button
        );

        [NativeName("SDL_GetGamepadAxis")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAxis")]
        static abstract short GetGamepadAxis(GamepadHandle gamepad, GamepadAxis axis);

        [NativeName("SDL_GetGamepadAxisFromString")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAxisFromString")]
        static abstract GamepadAxis GetGamepadAxisFromString(sbyte* str);

        [NativeName("SDL_GetGamepadAxisFromString")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAxisFromString")]
        static abstract GamepadAxis GetGamepadAxisFromString(Ref<sbyte> str);

        [NativeName("SDL_GetGamepadBindings")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadBindings")]
        static abstract GamepadBinding** GetGamepadBindings(GamepadHandle gamepad, int* count);

        [NativeName("SDL_GetGamepadBindings")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadBindings")]
        static abstract Ptr2D<GamepadBinding> GetGamepadBindings(
            GamepadHandle gamepad,
            Ref<int> count
        );

        [NativeName("SDL_GetGamepadButton")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButton")]
        static abstract MaybeBool<byte> GetGamepadButton(
            GamepadHandle gamepad,
            GamepadButton button
        );

        [NativeName("SDL_GetGamepadButtonFromString")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonFromString")]
        static abstract GamepadButton GetGamepadButtonFromString(sbyte* str);

        [NativeName("SDL_GetGamepadButtonFromString")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonFromString")]
        static abstract GamepadButton GetGamepadButtonFromString(Ref<sbyte> str);

        [NativeName("SDL_GetGamepadButtonLabel")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonLabel")]
        static abstract GamepadButtonLabel GetGamepadButtonLabel(
            GamepadHandle gamepad,
            GamepadButton button
        );

        [NativeName("SDL_GetGamepadButtonLabelForType")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonLabelForType")]
        static abstract GamepadButtonLabel GetGamepadButtonLabelForType(
            GamepadType type,
            GamepadButton button
        );

        [NativeName("SDL_GetGamepadButton")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButton")]
        static abstract byte GetGamepadButtonRaw(GamepadHandle gamepad, GamepadButton button);

        [NativeName("SDL_GetGamepadConnectionState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadConnectionState")]
        static abstract JoystickConnectionState GetGamepadConnectionState(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadFirmwareVersion")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFirmwareVersion")]
        static abstract ushort GetGamepadFirmwareVersion(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadFromID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFromID")]
        static abstract GamepadHandle GetGamepadFromId(uint instance_id);

        [NativeName("SDL_GetGamepadFromPlayerIndex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFromPlayerIndex")]
        static abstract GamepadHandle GetGamepadFromPlayerIndex(int player_index);

        [NativeName("SDL_GetGamepadGUIDForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadGUIDForID")]
        static abstract Guid GetGamepadGuidForId(uint instance_id);

        [NativeName("SDL_GetGamepadID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadID")]
        static abstract uint GetGamepadId(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadJoystick")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadJoystick")]
        static abstract JoystickHandle GetGamepadJoystick(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadMapping")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMapping")]
        static abstract Ptr<sbyte> GetGamepadMapping(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadMappingForGUID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForGUID")]
        static abstract Ptr<sbyte> GetGamepadMappingForGuid(Guid guid);

        [NativeName("SDL_GetGamepadMappingForGUID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForGUID")]
        static abstract sbyte* GetGamepadMappingForGuidRaw(Guid guid);

        [NativeName("SDL_GetGamepadMappingForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForID")]
        static abstract Ptr<sbyte> GetGamepadMappingForId(uint instance_id);

        [NativeName("SDL_GetGamepadMappingForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForID")]
        static abstract sbyte* GetGamepadMappingForIdRaw(uint instance_id);

        [NativeName("SDL_GetGamepadMapping")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMapping")]
        static abstract sbyte* GetGamepadMappingRaw(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadMappings")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappings")]
        static abstract sbyte** GetGamepadMappings(int* count);

        [NativeName("SDL_GetGamepadMappings")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappings")]
        static abstract Ptr2D<sbyte> GetGamepadMappings(Ref<int> count);

        [NativeName("SDL_GetGamepadName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadName")]
        static abstract Ptr<sbyte> GetGamepadName(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadNameForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadNameForID")]
        static abstract Ptr<sbyte> GetGamepadNameForId(uint instance_id);

        [NativeName("SDL_GetGamepadNameForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadNameForID")]
        static abstract sbyte* GetGamepadNameForIdRaw(uint instance_id);

        [NativeName("SDL_GetGamepadName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadName")]
        static abstract sbyte* GetGamepadNameRaw(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadPath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPath")]
        static abstract Ptr<sbyte> GetGamepadPath(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadPathForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPathForID")]
        static abstract Ptr<sbyte> GetGamepadPathForId(uint instance_id);

        [NativeName("SDL_GetGamepadPathForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPathForID")]
        static abstract sbyte* GetGamepadPathForIdRaw(uint instance_id);

        [NativeName("SDL_GetGamepadPath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPath")]
        static abstract sbyte* GetGamepadPathRaw(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadPlayerIndex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPlayerIndex")]
        static abstract int GetGamepadPlayerIndex(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadPlayerIndexForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPlayerIndexForID")]
        static abstract int GetGamepadPlayerIndexForId(uint instance_id);

        [NativeName("SDL_GetGamepadPowerInfo")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPowerInfo")]
        static abstract PowerState GetGamepadPowerInfo(GamepadHandle gamepad, int* percent);

        [NativeName("SDL_GetGamepadPowerInfo")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPowerInfo")]
        static abstract PowerState GetGamepadPowerInfo(GamepadHandle gamepad, Ref<int> percent);

        [NativeName("SDL_GetGamepadProduct")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProduct")]
        static abstract ushort GetGamepadProduct(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadProductForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProductForID")]
        static abstract ushort GetGamepadProductForId(uint instance_id);

        [NativeName("SDL_GetGamepadProductVersion")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProductVersion")]
        static abstract ushort GetGamepadProductVersion(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadProductVersionForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProductVersionForID")]
        static abstract ushort GetGamepadProductVersionForId(uint instance_id);

        [NativeName("SDL_GetGamepadProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProperties")]
        static abstract uint GetGamepadProperties(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepads")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepads")]
        static abstract uint* GetGamepads(int* count);

        [NativeName("SDL_GetGamepads")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepads")]
        static abstract Ptr<uint> GetGamepads(Ref<int> count);

        [NativeName("SDL_GetGamepadSensorData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorData")]
        static abstract byte GetGamepadSensorData(
            GamepadHandle gamepad,
            SensorType type,
            float* data,
            int num_values
        );

        [NativeName("SDL_GetGamepadSensorData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorData")]
        static abstract MaybeBool<byte> GetGamepadSensorData(
            GamepadHandle gamepad,
            SensorType type,
            Ref<float> data,
            int num_values
        );

        [NativeName("SDL_GetGamepadSensorDataRate")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorDataRate")]
        static abstract float GetGamepadSensorDataRate(GamepadHandle gamepad, SensorType type);

        [NativeName("SDL_GetGamepadSerial")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSerial")]
        static abstract Ptr<sbyte> GetGamepadSerial(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadSerial")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSerial")]
        static abstract sbyte* GetGamepadSerialRaw(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadSteamHandle")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSteamHandle")]
        static abstract ulong GetGamepadSteamHandle(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadStringForAxis")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForAxis")]
        static abstract Ptr<sbyte> GetGamepadStringForAxis(GamepadAxis axis);

        [NativeName("SDL_GetGamepadStringForAxis")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForAxis")]
        static abstract sbyte* GetGamepadStringForAxisRaw(GamepadAxis axis);

        [NativeName("SDL_GetGamepadStringForButton")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForButton")]
        static abstract Ptr<sbyte> GetGamepadStringForButton(GamepadButton button);

        [NativeName("SDL_GetGamepadStringForButton")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForButton")]
        static abstract sbyte* GetGamepadStringForButtonRaw(GamepadButton button);

        [NativeName("SDL_GetGamepadStringForType")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForType")]
        static abstract Ptr<sbyte> GetGamepadStringForType(GamepadType type);

        [NativeName("SDL_GetGamepadStringForType")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForType")]
        static abstract sbyte* GetGamepadStringForTypeRaw(GamepadType type);

        [NativeName("SDL_GetGamepadTouchpadFinger")]
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

        [NativeName("SDL_GetGamepadTouchpadFinger")]
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

        [NativeName("SDL_GetGamepadType")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadType")]
        static abstract GamepadType GetGamepadType(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadTypeForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTypeForID")]
        static abstract GamepadType GetGamepadTypeForId(uint instance_id);

        [NativeName("SDL_GetGamepadTypeFromString")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTypeFromString")]
        static abstract GamepadType GetGamepadTypeFromString(sbyte* str);

        [NativeName("SDL_GetGamepadTypeFromString")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTypeFromString")]
        static abstract GamepadType GetGamepadTypeFromString(Ref<sbyte> str);

        [NativeName("SDL_GetGamepadVendor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadVendor")]
        static abstract ushort GetGamepadVendor(GamepadHandle gamepad);

        [NativeName("SDL_GetGamepadVendorForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadVendorForID")]
        static abstract ushort GetGamepadVendorForId(uint instance_id);

        [NativeName("SDL_GetGlobalMouseState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalMouseState")]
        static abstract uint GetGlobalMouseState(float* x, float* y);

        [NativeName("SDL_GetGlobalMouseState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalMouseState")]
        static abstract uint GetGlobalMouseState(Ref<float> x, Ref<float> y);

        [NativeName("SDL_GetGlobalProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalProperties")]
        static abstract uint GetGlobalProperties();

        [NativeName("SDL_GetGPUDeviceDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDeviceDriver")]
        static abstract Ptr<sbyte> GetGpuDeviceDriver(GpuDeviceHandle device);

        [NativeName("SDL_GetGPUDeviceDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDeviceDriver")]
        static abstract sbyte* GetGpuDeviceDriverRaw(GpuDeviceHandle device);

        [NativeName("SDL_GetGPUDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDriver")]
        static abstract Ptr<sbyte> GetGpuDriver(int index);

        [NativeName("SDL_GetGPUDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDriver")]
        static abstract sbyte* GetGpuDriverRaw(int index);

        [NativeName("SDL_GetGPUShaderFormats")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUShaderFormats")]
        static abstract uint GetGpuShaderFormats(GpuDeviceHandle device);

        [NativeName("SDL_GetGPUSwapchainTextureFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUSwapchainTextureFormat")]
        static abstract GpuTextureFormat GetGpuSwapchainTextureFormat(
            GpuDeviceHandle device,
            WindowHandle window
        );

        [NativeName("SDL_GetGrabbedWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetGrabbedWindow")]
        static abstract WindowHandle GetGrabbedWindow();

        [NativeName("SDL_GetHapticEffectStatus")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticEffectStatus")]
        static abstract MaybeBool<byte> GetHapticEffectStatus(HapticHandle haptic, int effect);

        [NativeName("SDL_GetHapticEffectStatus")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticEffectStatus")]
        static abstract byte GetHapticEffectStatusRaw(HapticHandle haptic, int effect);

        [NativeName("SDL_GetHapticFeatures")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticFeatures")]
        static abstract uint GetHapticFeatures(HapticHandle haptic);

        [NativeName("SDL_GetHapticFromID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticFromID")]
        static abstract HapticHandle GetHapticFromId(uint instance_id);

        [NativeName("SDL_GetHapticID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticID")]
        static abstract uint GetHapticId(HapticHandle haptic);

        [NativeName("SDL_GetHapticName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticName")]
        static abstract Ptr<sbyte> GetHapticName(HapticHandle haptic);

        [NativeName("SDL_GetHapticNameForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticNameForID")]
        static abstract Ptr<sbyte> GetHapticNameForId(uint instance_id);

        [NativeName("SDL_GetHapticNameForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticNameForID")]
        static abstract sbyte* GetHapticNameForIdRaw(uint instance_id);

        [NativeName("SDL_GetHapticName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticName")]
        static abstract sbyte* GetHapticNameRaw(HapticHandle haptic);

        [NativeName("SDL_GetHaptics")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHaptics")]
        static abstract uint* GetHaptics(int* count);

        [NativeName("SDL_GetHaptics")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHaptics")]
        static abstract Ptr<uint> GetHaptics(Ref<int> count);

        [NativeName("SDL_GetHint")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHint")]
        static abstract sbyte* GetHint(sbyte* name);

        [NativeName("SDL_GetHint")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHint")]
        static abstract Ptr<sbyte> GetHint(Ref<sbyte> name);

        [NativeName("SDL_GetHintBoolean")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHintBoolean")]
        static abstract byte GetHintBoolean(sbyte* name, byte default_value);

        [NativeName("SDL_GetHintBoolean")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetHintBoolean")]
        static abstract MaybeBool<byte> GetHintBoolean(
            Ref<sbyte> name,
            MaybeBool<byte> default_value
        );

        [NativeName("SDL_GetIOProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetIOProperties")]
        static abstract uint GetIoProperties(IoStreamHandle context);

        [NativeName("SDL_GetIOSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetIOSize")]
        static abstract long GetIoSize(IoStreamHandle context);

        [NativeName("SDL_GetIOStatus")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetIOStatus")]
        static abstract IoStatus GetIoStatus(IoStreamHandle context);

        [NativeName("SDL_GetJoystickAxis")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxis")]
        static abstract short GetJoystickAxis(JoystickHandle joystick, int axis);

        [NativeName("SDL_GetJoystickAxisInitialState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxisInitialState")]
        static abstract byte GetJoystickAxisInitialState(
            JoystickHandle joystick,
            int axis,
            short* state
        );

        [NativeName("SDL_GetJoystickAxisInitialState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxisInitialState")]
        static abstract MaybeBool<byte> GetJoystickAxisInitialState(
            JoystickHandle joystick,
            int axis,
            Ref<short> state
        );

        [NativeName("SDL_GetJoystickBall")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickBall")]
        static abstract byte GetJoystickBall(JoystickHandle joystick, int ball, int* dx, int* dy);

        [NativeName("SDL_GetJoystickBall")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickBall")]
        static abstract MaybeBool<byte> GetJoystickBall(
            JoystickHandle joystick,
            int ball,
            Ref<int> dx,
            Ref<int> dy
        );

        [NativeName("SDL_GetJoystickButton")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickButton")]
        static abstract MaybeBool<byte> GetJoystickButton(JoystickHandle joystick, int button);

        [NativeName("SDL_GetJoystickButton")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickButton")]
        static abstract byte GetJoystickButtonRaw(JoystickHandle joystick, int button);

        [NativeName("SDL_GetJoystickConnectionState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickConnectionState")]
        static abstract JoystickConnectionState GetJoystickConnectionState(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickFirmwareVersion")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFirmwareVersion")]
        static abstract ushort GetJoystickFirmwareVersion(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickFromID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFromID")]
        static abstract JoystickHandle GetJoystickFromId(uint instance_id);

        [NativeName("SDL_GetJoystickFromPlayerIndex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFromPlayerIndex")]
        static abstract JoystickHandle GetJoystickFromPlayerIndex(int player_index);

        [NativeName("SDL_GetJoystickGUID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUID")]
        static abstract Guid GetJoystickGuid(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickGUIDForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDForID")]
        static abstract Guid GetJoystickGuidForId(uint instance_id);

        [NativeName("SDL_GetJoystickGUIDInfo")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDInfo")]
        static abstract void GetJoystickGuidInfo(
            Guid guid,
            ushort* vendor,
            ushort* product,
            ushort* version,
            ushort* crc16
        );

        [NativeName("SDL_GetJoystickGUIDInfo")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDInfo")]
        static abstract void GetJoystickGuidInfo(
            Guid guid,
            Ref<ushort> vendor,
            Ref<ushort> product,
            Ref<ushort> version,
            Ref<ushort> crc16
        );

        [NativeName("SDL_GetJoystickHat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickHat")]
        static abstract byte GetJoystickHat(JoystickHandle joystick, int hat);

        [NativeName("SDL_GetJoystickID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickID")]
        static abstract uint GetJoystickId(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickName")]
        static abstract Ptr<sbyte> GetJoystickName(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickNameForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickNameForID")]
        static abstract Ptr<sbyte> GetJoystickNameForId(uint instance_id);

        [NativeName("SDL_GetJoystickNameForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickNameForID")]
        static abstract sbyte* GetJoystickNameForIdRaw(uint instance_id);

        [NativeName("SDL_GetJoystickName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickName")]
        static abstract sbyte* GetJoystickNameRaw(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickPath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPath")]
        static abstract Ptr<sbyte> GetJoystickPath(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickPathForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPathForID")]
        static abstract Ptr<sbyte> GetJoystickPathForId(uint instance_id);

        [NativeName("SDL_GetJoystickPathForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPathForID")]
        static abstract sbyte* GetJoystickPathForIdRaw(uint instance_id);

        [NativeName("SDL_GetJoystickPath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPath")]
        static abstract sbyte* GetJoystickPathRaw(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickPlayerIndex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPlayerIndex")]
        static abstract int GetJoystickPlayerIndex(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickPlayerIndexForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPlayerIndexForID")]
        static abstract int GetJoystickPlayerIndexForId(uint instance_id);

        [NativeName("SDL_GetJoystickPowerInfo")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPowerInfo")]
        static abstract PowerState GetJoystickPowerInfo(JoystickHandle joystick, int* percent);

        [NativeName("SDL_GetJoystickPowerInfo")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPowerInfo")]
        static abstract PowerState GetJoystickPowerInfo(JoystickHandle joystick, Ref<int> percent);

        [NativeName("SDL_GetJoystickProduct")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProduct")]
        static abstract ushort GetJoystickProduct(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickProductForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProductForID")]
        static abstract ushort GetJoystickProductForId(uint instance_id);

        [NativeName("SDL_GetJoystickProductVersion")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProductVersion")]
        static abstract ushort GetJoystickProductVersion(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickProductVersionForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProductVersionForID")]
        static abstract ushort GetJoystickProductVersionForId(uint instance_id);

        [NativeName("SDL_GetJoystickProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProperties")]
        static abstract uint GetJoystickProperties(JoystickHandle joystick);

        [NativeName("SDL_GetJoysticks")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoysticks")]
        static abstract uint* GetJoysticks(int* count);

        [NativeName("SDL_GetJoysticks")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoysticks")]
        static abstract Ptr<uint> GetJoysticks(Ref<int> count);

        [NativeName("SDL_GetJoystickSerial")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickSerial")]
        static abstract Ptr<sbyte> GetJoystickSerial(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickSerial")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickSerial")]
        static abstract sbyte* GetJoystickSerialRaw(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickType")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickType")]
        static abstract JoystickType GetJoystickType(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickTypeForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickTypeForID")]
        static abstract JoystickType GetJoystickTypeForId(uint instance_id);

        [NativeName("SDL_GetJoystickVendor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickVendor")]
        static abstract ushort GetJoystickVendor(JoystickHandle joystick);

        [NativeName("SDL_GetJoystickVendorForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickVendorForID")]
        static abstract ushort GetJoystickVendorForId(uint instance_id);

        [NativeName("SDL_GetKeyboardFocus")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardFocus")]
        static abstract WindowHandle GetKeyboardFocus();

        [NativeName("SDL_GetKeyboardNameForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardNameForID")]
        static abstract Ptr<sbyte> GetKeyboardNameForId(uint instance_id);

        [NativeName("SDL_GetKeyboardNameForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardNameForID")]
        static abstract sbyte* GetKeyboardNameForIdRaw(uint instance_id);

        [NativeName("SDL_GetKeyboards")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboards")]
        static abstract uint* GetKeyboards(int* count);

        [NativeName("SDL_GetKeyboards")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboards")]
        static abstract Ptr<uint> GetKeyboards(Ref<int> count);

        [NativeName("SDL_GetKeyboardState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardState")]
        static abstract bool* GetKeyboardState(int* numkeys);

        [NativeName("SDL_GetKeyboardState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardState")]
        static abstract Ptr<bool> GetKeyboardState(Ref<int> numkeys);

        [NativeName("SDL_GetKeyFromName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromName")]
        static abstract uint GetKeyFromName(sbyte* name);

        [NativeName("SDL_GetKeyFromName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromName")]
        static abstract uint GetKeyFromName(Ref<sbyte> name);

        [NativeName("SDL_GetKeyFromScancode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromScancode")]
        static abstract uint GetKeyFromScancode(Scancode scancode, ushort modstate, byte key_event);

        [NativeName("SDL_GetKeyFromScancode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromScancode")]
        static abstract uint GetKeyFromScancode(
            Scancode scancode,
            ushort modstate,
            MaybeBool<byte> key_event
        );

        [NativeName("SDL_GetKeyName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyName")]
        static abstract Ptr<sbyte> GetKeyName(uint key);

        [NativeName("SDL_GetKeyName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyName")]
        static abstract sbyte* GetKeyNameRaw(uint key);

        [NativeName("SDL_GetLogOutputFunction")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetLogOutputFunction")]
        static abstract void GetLogOutputFunction(LogOutputFunction* callback, void** userdata);

        [NativeName("SDL_GetLogOutputFunction")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetLogOutputFunction")]
        static abstract void GetLogOutputFunction(Ref<LogOutputFunction> callback, Ref2D userdata);

        [NativeName("SDL_GetLogPriority")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetLogPriority")]
        static abstract LogPriority GetLogPriority(int category);

        [NativeName("SDL_GetMasksForPixelFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMasksForPixelFormat")]
        static abstract byte GetMasksForPixelFormat(
            PixelFormat format,
            int* bpp,
            uint* Rmask,
            uint* Gmask,
            uint* Bmask,
            uint* Amask
        );

        [NativeName("SDL_GetMasksForPixelFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMasksForPixelFormat")]
        static abstract MaybeBool<byte> GetMasksForPixelFormat(
            PixelFormat format,
            Ref<int> bpp,
            Ref<uint> Rmask,
            Ref<uint> Gmask,
            Ref<uint> Bmask,
            Ref<uint> Amask
        );

        [NativeName("SDL_GetMaxHapticEffects")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMaxHapticEffects")]
        static abstract int GetMaxHapticEffects(HapticHandle haptic);

        [NativeName("SDL_GetMaxHapticEffectsPlaying")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMaxHapticEffectsPlaying")]
        static abstract int GetMaxHapticEffectsPlaying(HapticHandle haptic);

        [NativeName("SDL_GetMemoryFunctions")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMemoryFunctions")]
        static abstract void GetMemoryFunctions(
            MallocFunc* malloc_func,
            CallocFunc* calloc_func,
            ReallocFunc* realloc_func,
            FreeFunc* free_func
        );

        [NativeName("SDL_GetMemoryFunctions")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMemoryFunctions")]
        static abstract void GetMemoryFunctions(
            Ref<MallocFunc> malloc_func,
            Ref<CallocFunc> calloc_func,
            Ref<ReallocFunc> realloc_func,
            Ref<FreeFunc> free_func
        );

        [NativeName("SDL_GetMice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMice")]
        static abstract uint* GetMice(int* count);

        [NativeName("SDL_GetMice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMice")]
        static abstract Ptr<uint> GetMice(Ref<int> count);

        [NativeName("SDL_GetModState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetModState")]
        static abstract ushort GetModState();

        [NativeName("SDL_GetMouseFocus")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseFocus")]
        static abstract WindowHandle GetMouseFocus();

        [NativeName("SDL_GetMouseNameForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseNameForID")]
        static abstract Ptr<sbyte> GetMouseNameForId(uint instance_id);

        [NativeName("SDL_GetMouseNameForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseNameForID")]
        static abstract sbyte* GetMouseNameForIdRaw(uint instance_id);

        [NativeName("SDL_GetMouseState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseState")]
        static abstract uint GetMouseState(float* x, float* y);

        [NativeName("SDL_GetMouseState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseState")]
        static abstract uint GetMouseState(Ref<float> x, Ref<float> y);

        [NativeName("SDL_GetNaturalDisplayOrientation")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNaturalDisplayOrientation")]
        static abstract DisplayOrientation GetNaturalDisplayOrientation(uint displayID);

        [NativeName("SDL_GetNumAllocations")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumAllocations")]
        static abstract int GetNumAllocations();

        [NativeName("SDL_GetNumAudioDrivers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumAudioDrivers")]
        static abstract int GetNumAudioDrivers();

        [NativeName("SDL_GetNumberProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumberProperty")]
        static abstract long GetNumberProperty(uint props, sbyte* name, long default_value);

        [NativeName("SDL_GetNumberProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumberProperty")]
        static abstract long GetNumberProperty(uint props, Ref<sbyte> name, long default_value);

        [NativeName("SDL_GetNumCameraDrivers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumCameraDrivers")]
        static abstract int GetNumCameraDrivers();

        [NativeName("SDL_GetNumGamepadTouchpadFingers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGamepadTouchpadFingers")]
        static abstract int GetNumGamepadTouchpadFingers(GamepadHandle gamepad, int touchpad);

        [NativeName("SDL_GetNumGamepadTouchpads")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGamepadTouchpads")]
        static abstract int GetNumGamepadTouchpads(GamepadHandle gamepad);

        [NativeName("SDL_GetNumGPUDrivers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGPUDrivers")]
        static abstract int GetNumGpuDrivers();

        [NativeName("SDL_GetNumHapticAxes")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumHapticAxes")]
        static abstract int GetNumHapticAxes(HapticHandle haptic);

        [NativeName("SDL_GetNumJoystickAxes")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickAxes")]
        static abstract int GetNumJoystickAxes(JoystickHandle joystick);

        [NativeName("SDL_GetNumJoystickBalls")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickBalls")]
        static abstract int GetNumJoystickBalls(JoystickHandle joystick);

        [NativeName("SDL_GetNumJoystickButtons")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickButtons")]
        static abstract int GetNumJoystickButtons(JoystickHandle joystick);

        [NativeName("SDL_GetNumJoystickHats")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickHats")]
        static abstract int GetNumJoystickHats(JoystickHandle joystick);

        [NativeName("SDL_GetNumLogicalCPUCores")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumLogicalCPUCores")]
        static abstract int GetNumLogicalCpuCores();

        [NativeName("SDL_GetNumRenderDrivers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumRenderDrivers")]
        static abstract int GetNumRenderDrivers();

        [NativeName("SDL_GetNumVideoDrivers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetNumVideoDrivers")]
        static abstract int GetNumVideoDrivers();

        [NativeName("SDL_GetOriginalMemoryFunctions")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetOriginalMemoryFunctions")]
        static abstract void GetOriginalMemoryFunctions(
            MallocFunc* malloc_func,
            CallocFunc* calloc_func,
            ReallocFunc* realloc_func,
            FreeFunc* free_func
        );

        [NativeName("SDL_GetOriginalMemoryFunctions")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetOriginalMemoryFunctions")]
        static abstract void GetOriginalMemoryFunctions(
            Ref<MallocFunc> malloc_func,
            Ref<CallocFunc> calloc_func,
            Ref<ReallocFunc> realloc_func,
            Ref<FreeFunc> free_func
        );

        [NativeName("SDL_GetPathInfo")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPathInfo")]
        static abstract byte GetPathInfo(sbyte* path, PathInfo* info);

        [NativeName("SDL_GetPathInfo")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPathInfo")]
        static abstract MaybeBool<byte> GetPathInfo(Ref<sbyte> path, Ref<PathInfo> info);

        [NativeName("SDL_GetPerformanceCounter")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPerformanceCounter")]
        static abstract ulong GetPerformanceCounter();

        [NativeName("SDL_GetPerformanceFrequency")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPerformanceFrequency")]
        static abstract ulong GetPerformanceFrequency();

        [NativeName("SDL_GetPixelFormatDetails")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatDetails")]
        static abstract Ptr<PixelFormatDetails> GetPixelFormatDetails(PixelFormat format);

        [NativeName("SDL_GetPixelFormatDetails")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatDetails")]
        static abstract PixelFormatDetails* GetPixelFormatDetailsRaw(PixelFormat format);

        [NativeName("SDL_GetPixelFormatForMasks")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatForMasks")]
        static abstract PixelFormat GetPixelFormatForMasks(
            int bpp,
            uint Rmask,
            uint Gmask,
            uint Bmask,
            uint Amask
        );

        [NativeName("SDL_GetPixelFormatName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatName")]
        static abstract Ptr<sbyte> GetPixelFormatName(PixelFormat format);

        [NativeName("SDL_GetPixelFormatName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatName")]
        static abstract sbyte* GetPixelFormatNameRaw(PixelFormat format);

        [NativeName("SDL_GetPlatform")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPlatform")]
        static abstract Ptr<sbyte> GetPlatform();

        [NativeName("SDL_GetPlatform")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPlatform")]
        static abstract sbyte* GetPlatformRaw();

        [NativeName("SDL_GetPointerProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPointerProperty")]
        static abstract void* GetPointerProperty(uint props, sbyte* name, void* default_value);

        [NativeName("SDL_GetPointerProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPointerProperty")]
        static abstract Ptr GetPointerProperty(uint props, Ref<sbyte> name, Ref default_value);

        [NativeName("SDL_GetPowerInfo")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPowerInfo")]
        static abstract PowerState GetPowerInfo(int* seconds, int* percent);

        [NativeName("SDL_GetPowerInfo")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPowerInfo")]
        static abstract PowerState GetPowerInfo(Ref<int> seconds, Ref<int> percent);

        [NativeName("SDL_GetPreferredLocales")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPreferredLocales")]
        static abstract Locale** GetPreferredLocales(int* count);

        [NativeName("SDL_GetPreferredLocales")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPreferredLocales")]
        static abstract Ptr2D<Locale> GetPreferredLocales(Ref<int> count);

        [NativeName("SDL_GetPrefPath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPrefPath")]
        static abstract sbyte* GetPrefPath(sbyte* org, sbyte* app);

        [NativeName("SDL_GetPrefPath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPrefPath")]
        static abstract Ptr<sbyte> GetPrefPath(Ref<sbyte> org, Ref<sbyte> app);

        [NativeName("SDL_GetPrimaryDisplay")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPrimaryDisplay")]
        static abstract uint GetPrimaryDisplay();

        [NativeName("SDL_GetPrimarySelectionText")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPrimarySelectionText")]
        static abstract Ptr<sbyte> GetPrimarySelectionText();

        [NativeName("SDL_GetPrimarySelectionText")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPrimarySelectionText")]
        static abstract sbyte* GetPrimarySelectionTextRaw();

        [NativeName("SDL_GetProcessInput")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetProcessInput")]
        static abstract IoStreamHandle GetProcessInput(ProcessHandle process);

        [NativeName("SDL_GetProcessOutput")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetProcessOutput")]
        static abstract IoStreamHandle GetProcessOutput(ProcessHandle process);

        [NativeName("SDL_GetProcessProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetProcessProperties")]
        static abstract uint GetProcessProperties(ProcessHandle process);

        [NativeName("SDL_GetPropertyType")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPropertyType")]
        static abstract PropertyType GetPropertyType(uint props, sbyte* name);

        [NativeName("SDL_GetPropertyType")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetPropertyType")]
        static abstract PropertyType GetPropertyType(uint props, Ref<sbyte> name);

        [NativeName("SDL_GetRealGamepadType")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRealGamepadType")]
        static abstract GamepadType GetRealGamepadType(GamepadHandle gamepad);

        [NativeName("SDL_GetRealGamepadTypeForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRealGamepadTypeForID")]
        static abstract GamepadType GetRealGamepadTypeForId(uint instance_id);

        [NativeName("SDL_GetRectAndLineIntersection")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersection")]
        static abstract byte GetRectAndLineIntersection(
            Rect* rect,
            int* X1,
            int* Y1,
            int* X2,
            int* Y2
        );

        [NativeName("SDL_GetRectAndLineIntersection")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersection")]
        static abstract MaybeBool<byte> GetRectAndLineIntersection(
            Ref<Rect> rect,
            Ref<int> X1,
            Ref<int> Y1,
            Ref<int> X2,
            Ref<int> Y2
        );

        [NativeName("SDL_GetRectAndLineIntersectionFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersectionFloat")]
        static abstract byte GetRectAndLineIntersectionFloat(
            FRect* rect,
            float* X1,
            float* Y1,
            float* X2,
            float* Y2
        );

        [NativeName("SDL_GetRectAndLineIntersectionFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersectionFloat")]
        static abstract MaybeBool<byte> GetRectAndLineIntersectionFloat(
            Ref<FRect> rect,
            Ref<float> X1,
            Ref<float> Y1,
            Ref<float> X2,
            Ref<float> Y2
        );

        [NativeName("SDL_GetRectEnclosingPoints")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPoints")]
        static abstract byte GetRectEnclosingPoints(
            Point* points,
            int count,
            Rect* clip,
            Rect* result
        );

        [NativeName("SDL_GetRectEnclosingPoints")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPoints")]
        static abstract MaybeBool<byte> GetRectEnclosingPoints(
            Ref<Point> points,
            int count,
            Ref<Rect> clip,
            Ref<Rect> result
        );

        [NativeName("SDL_GetRectEnclosingPointsFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
        static abstract byte GetRectEnclosingPointsFloat(
            FPoint* points,
            int count,
            FRect* clip,
            FRect* result
        );

        [NativeName("SDL_GetRectEnclosingPointsFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
        static abstract MaybeBool<byte> GetRectEnclosingPointsFloat(
            Ref<FPoint> points,
            int count,
            Ref<FRect> clip,
            Ref<FRect> result
        );

        [NativeName("SDL_GetRectIntersection")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersection")]
        static abstract byte GetRectIntersection(Rect* A, Rect* B, Rect* result);

        [NativeName("SDL_GetRectIntersection")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersection")]
        static abstract MaybeBool<byte> GetRectIntersection(
            Ref<Rect> A,
            Ref<Rect> B,
            Ref<Rect> result
        );

        [NativeName("SDL_GetRectIntersectionFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersectionFloat")]
        static abstract byte GetRectIntersectionFloat(FRect* A, FRect* B, FRect* result);

        [NativeName("SDL_GetRectIntersectionFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersectionFloat")]
        static abstract MaybeBool<byte> GetRectIntersectionFloat(
            Ref<FRect> A,
            Ref<FRect> B,
            Ref<FRect> result
        );

        [NativeName("SDL_GetRectUnion")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnion")]
        static abstract byte GetRectUnion(Rect* A, Rect* B, Rect* result);

        [NativeName("SDL_GetRectUnion")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnion")]
        static abstract MaybeBool<byte> GetRectUnion(Ref<Rect> A, Ref<Rect> B, Ref<Rect> result);

        [NativeName("SDL_GetRectUnionFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnionFloat")]
        static abstract byte GetRectUnionFloat(FRect* A, FRect* B, FRect* result);

        [NativeName("SDL_GetRectUnionFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnionFloat")]
        static abstract MaybeBool<byte> GetRectUnionFloat(
            Ref<FRect> A,
            Ref<FRect> B,
            Ref<FRect> result
        );

        [NativeName("SDL_GetRelativeMouseState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseState")]
        static abstract uint GetRelativeMouseState(float* x, float* y);

        [NativeName("SDL_GetRelativeMouseState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseState")]
        static abstract uint GetRelativeMouseState(Ref<float> x, Ref<float> y);

        [NativeName("SDL_GetRenderClipRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderClipRect")]
        static abstract byte GetRenderClipRect(RendererHandle renderer, Rect* rect);

        [NativeName("SDL_GetRenderClipRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderClipRect")]
        static abstract MaybeBool<byte> GetRenderClipRect(RendererHandle renderer, Ref<Rect> rect);

        [NativeName("SDL_GetRenderColorScale")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderColorScale")]
        static abstract byte GetRenderColorScale(RendererHandle renderer, float* scale);

        [NativeName("SDL_GetRenderColorScale")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderColorScale")]
        static abstract MaybeBool<byte> GetRenderColorScale(
            RendererHandle renderer,
            Ref<float> scale
        );

        [NativeName("SDL_GetRenderDrawBlendMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawBlendMode")]
        static abstract byte GetRenderDrawBlendMode(RendererHandle renderer, BlendMode* blendMode);

        [NativeName("SDL_GetRenderDrawBlendMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawBlendMode")]
        static abstract MaybeBool<byte> GetRenderDrawBlendMode(
            RendererHandle renderer,
            Ref<BlendMode> blendMode
        );

        [NativeName("SDL_GetRenderDrawColor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColor")]
        static abstract byte GetRenderDrawColor(
            RendererHandle renderer,
            byte* r,
            byte* g,
            byte* b,
            byte* a
        );

        [NativeName("SDL_GetRenderDrawColor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColor")]
        static abstract MaybeBool<byte> GetRenderDrawColor(
            RendererHandle renderer,
            Ref<byte> r,
            Ref<byte> g,
            Ref<byte> b,
            Ref<byte> a
        );

        [NativeName("SDL_GetRenderDrawColorFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColorFloat")]
        static abstract byte GetRenderDrawColorFloat(
            RendererHandle renderer,
            float* r,
            float* g,
            float* b,
            float* a
        );

        [NativeName("SDL_GetRenderDrawColorFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColorFloat")]
        static abstract MaybeBool<byte> GetRenderDrawColorFloat(
            RendererHandle renderer,
            Ref<float> r,
            Ref<float> g,
            Ref<float> b,
            Ref<float> a
        );

        [NativeName("SDL_GetRenderDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDriver")]
        static abstract Ptr<sbyte> GetRenderDriver(int index);

        [NativeName("SDL_GetRenderDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDriver")]
        static abstract sbyte* GetRenderDriverRaw(int index);

        [NativeName("SDL_GetRenderer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderer")]
        static abstract RendererHandle GetRenderer(WindowHandle window);

        [NativeName("SDL_GetRendererFromTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererFromTexture")]
        static abstract RendererHandle GetRendererFromTexture(Texture* texture);

        [NativeName("SDL_GetRendererFromTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererFromTexture")]
        static abstract RendererHandle GetRendererFromTexture(Ref<Texture> texture);

        [NativeName("SDL_GetRendererName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererName")]
        static abstract Ptr<sbyte> GetRendererName(RendererHandle renderer);

        [NativeName("SDL_GetRendererName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererName")]
        static abstract sbyte* GetRendererNameRaw(RendererHandle renderer);

        [NativeName("SDL_GetRendererProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererProperties")]
        static abstract uint GetRendererProperties(RendererHandle renderer);

        [NativeName("SDL_GetRenderLogicalPresentation")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentation")]
        static abstract byte GetRenderLogicalPresentation(
            RendererHandle renderer,
            int* w,
            int* h,
            RendererLogicalPresentation* mode
        );

        [NativeName("SDL_GetRenderLogicalPresentation")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentation")]
        static abstract MaybeBool<byte> GetRenderLogicalPresentation(
            RendererHandle renderer,
            Ref<int> w,
            Ref<int> h,
            Ref<RendererLogicalPresentation> mode
        );

        [NativeName("SDL_GetRenderLogicalPresentationRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentationRect")]
        static abstract byte GetRenderLogicalPresentationRect(RendererHandle renderer, FRect* rect);

        [NativeName("SDL_GetRenderLogicalPresentationRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentationRect")]
        static abstract MaybeBool<byte> GetRenderLogicalPresentationRect(
            RendererHandle renderer,
            Ref<FRect> rect
        );

        [NativeName("SDL_GetRenderMetalCommandEncoder")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalCommandEncoder")]
        static abstract Ptr GetRenderMetalCommandEncoder(RendererHandle renderer);

        [NativeName("SDL_GetRenderMetalCommandEncoder")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalCommandEncoder")]
        static abstract void* GetRenderMetalCommandEncoderRaw(RendererHandle renderer);

        [NativeName("SDL_GetRenderMetalLayer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalLayer")]
        static abstract Ptr GetRenderMetalLayer(RendererHandle renderer);

        [NativeName("SDL_GetRenderMetalLayer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalLayer")]
        static abstract void* GetRenderMetalLayerRaw(RendererHandle renderer);

        [NativeName("SDL_GetRenderOutputSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderOutputSize")]
        static abstract byte GetRenderOutputSize(RendererHandle renderer, int* w, int* h);

        [NativeName("SDL_GetRenderOutputSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderOutputSize")]
        static abstract MaybeBool<byte> GetRenderOutputSize(
            RendererHandle renderer,
            Ref<int> w,
            Ref<int> h
        );

        [NativeName("SDL_GetRenderSafeArea")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderSafeArea")]
        static abstract byte GetRenderSafeArea(RendererHandle renderer, Rect* rect);

        [NativeName("SDL_GetRenderSafeArea")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderSafeArea")]
        static abstract MaybeBool<byte> GetRenderSafeArea(RendererHandle renderer, Ref<Rect> rect);

        [NativeName("SDL_GetRenderScale")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderScale")]
        static abstract byte GetRenderScale(RendererHandle renderer, float* scaleX, float* scaleY);

        [NativeName("SDL_GetRenderScale")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderScale")]
        static abstract MaybeBool<byte> GetRenderScale(
            RendererHandle renderer,
            Ref<float> scaleX,
            Ref<float> scaleY
        );

        [NativeName("SDL_GetRenderTarget")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderTarget")]
        static abstract Ptr<Texture> GetRenderTarget(RendererHandle renderer);

        [NativeName("SDL_GetRenderTarget")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderTarget")]
        static abstract Texture* GetRenderTargetRaw(RendererHandle renderer);

        [NativeName("SDL_GetRenderViewport")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderViewport")]
        static abstract byte GetRenderViewport(RendererHandle renderer, Rect* rect);

        [NativeName("SDL_GetRenderViewport")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderViewport")]
        static abstract MaybeBool<byte> GetRenderViewport(RendererHandle renderer, Ref<Rect> rect);

        [NativeName("SDL_GetRenderVSync")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderVSync")]
        static abstract byte GetRenderVSync(RendererHandle renderer, int* vsync);

        [NativeName("SDL_GetRenderVSync")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderVSync")]
        static abstract MaybeBool<byte> GetRenderVSync(RendererHandle renderer, Ref<int> vsync);

        [NativeName("SDL_GetRenderWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderWindow")]
        static abstract WindowHandle GetRenderWindow(RendererHandle renderer);

        [NativeName("SDL_GetRevision")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRevision")]
        static abstract Ptr<sbyte> GetRevision();

        [NativeName("SDL_GetRevision")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRevision")]
        static abstract sbyte* GetRevisionRaw();

        [NativeName("SDL_GetRGB")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRGB")]
        static abstract void GetRgb(
            uint pixel,
            PixelFormatDetails* format,
            Palette* palette,
            byte* r,
            byte* g,
            byte* b
        );

        [NativeName("SDL_GetRGB")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRGB")]
        static abstract void GetRgb(
            uint pixel,
            Ref<PixelFormatDetails> format,
            Ref<Palette> palette,
            Ref<byte> r,
            Ref<byte> g,
            Ref<byte> b
        );

        [NativeName("SDL_GetRGBA")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRGBA")]
        static abstract void GetRgba(
            uint pixel,
            PixelFormatDetails* format,
            Palette* palette,
            byte* r,
            byte* g,
            byte* b,
            byte* a
        );

        [NativeName("SDL_GetRGBA")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetRGBA")]
        static abstract void GetRgba(
            uint pixel,
            Ref<PixelFormatDetails> format,
            Ref<Palette> palette,
            Ref<byte> r,
            Ref<byte> g,
            Ref<byte> b,
            Ref<byte> a
        );

        [NativeName("SDL_GetSandbox")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSandbox")]
        static abstract Sandbox GetSandbox();

        [NativeName("SDL_GetScancodeFromKey")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromKey")]
        static abstract Scancode GetScancodeFromKey(uint key, ushort* modstate);

        [NativeName("SDL_GetScancodeFromKey")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromKey")]
        static abstract Scancode GetScancodeFromKey(uint key, Ref<ushort> modstate);

        [NativeName("SDL_GetScancodeFromName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromName")]
        static abstract Scancode GetScancodeFromName(sbyte* name);

        [NativeName("SDL_GetScancodeFromName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromName")]
        static abstract Scancode GetScancodeFromName(Ref<sbyte> name);

        [NativeName("SDL_GetScancodeName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeName")]
        static abstract Ptr<sbyte> GetScancodeName(Scancode scancode);

        [NativeName("SDL_GetScancodeName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeName")]
        static abstract sbyte* GetScancodeNameRaw(Scancode scancode);

        [NativeName("SDL_GetSemaphoreValue")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSemaphoreValue")]
        static abstract uint GetSemaphoreValue(SemaphoreHandle sem);

        [NativeName("SDL_GetSensorData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorData")]
        static abstract byte GetSensorData(SensorHandle sensor, float* data, int num_values);

        [NativeName("SDL_GetSensorData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorData")]
        static abstract MaybeBool<byte> GetSensorData(
            SensorHandle sensor,
            Ref<float> data,
            int num_values
        );

        [NativeName("SDL_GetSensorFromID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorFromID")]
        static abstract SensorHandle GetSensorFromId(uint instance_id);

        [NativeName("SDL_GetSensorID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorID")]
        static abstract uint GetSensorId(SensorHandle sensor);

        [NativeName("SDL_GetSensorName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorName")]
        static abstract Ptr<sbyte> GetSensorName(SensorHandle sensor);

        [NativeName("SDL_GetSensorNameForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNameForID")]
        static abstract Ptr<sbyte> GetSensorNameForId(uint instance_id);

        [NativeName("SDL_GetSensorNameForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNameForID")]
        static abstract sbyte* GetSensorNameForIdRaw(uint instance_id);

        [NativeName("SDL_GetSensorName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorName")]
        static abstract sbyte* GetSensorNameRaw(SensorHandle sensor);

        [NativeName("SDL_GetSensorNonPortableType")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNonPortableType")]
        static abstract int GetSensorNonPortableType(SensorHandle sensor);

        [NativeName("SDL_GetSensorNonPortableTypeForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNonPortableTypeForID")]
        static abstract int GetSensorNonPortableTypeForId(uint instance_id);

        [NativeName("SDL_GetSensorProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorProperties")]
        static abstract uint GetSensorProperties(SensorHandle sensor);

        [NativeName("SDL_GetSensors")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensors")]
        static abstract uint* GetSensors(int* count);

        [NativeName("SDL_GetSensors")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensors")]
        static abstract Ptr<uint> GetSensors(Ref<int> count);

        [NativeName("SDL_GetSensorType")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorType")]
        static abstract SensorType GetSensorType(SensorHandle sensor);

        [NativeName("SDL_GetSensorTypeForID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorTypeForID")]
        static abstract SensorType GetSensorTypeForId(uint instance_id);

        [NativeName("SDL_GetSilenceValueForFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSilenceValueForFormat")]
        static abstract int GetSilenceValueForFormat(AudioFormat format);

        [NativeName("SDL_GetSIMDAlignment")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSIMDAlignment")]
        static abstract nuint GetSimdAlignment();

        [NativeName("SDL_GetStorageFileSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageFileSize")]
        static abstract byte GetStorageFileSize(StorageHandle storage, sbyte* path, ulong* length);

        [NativeName("SDL_GetStorageFileSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageFileSize")]
        static abstract MaybeBool<byte> GetStorageFileSize(
            StorageHandle storage,
            Ref<sbyte> path,
            Ref<ulong> length
        );

        [NativeName("SDL_GetStoragePathInfo")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStoragePathInfo")]
        static abstract byte GetStoragePathInfo(StorageHandle storage, sbyte* path, PathInfo* info);

        [NativeName("SDL_GetStoragePathInfo")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStoragePathInfo")]
        static abstract MaybeBool<byte> GetStoragePathInfo(
            StorageHandle storage,
            Ref<sbyte> path,
            Ref<PathInfo> info
        );

        [NativeName("SDL_GetStorageSpaceRemaining")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageSpaceRemaining")]
        static abstract ulong GetStorageSpaceRemaining(StorageHandle storage);

        [NativeName("SDL_GetStringProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStringProperty")]
        static abstract sbyte* GetStringProperty(uint props, sbyte* name, sbyte* default_value);

        [NativeName("SDL_GetStringProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetStringProperty")]
        static abstract Ptr<sbyte> GetStringProperty(
            uint props,
            Ref<sbyte> name,
            Ref<sbyte> default_value
        );

        [NativeName("SDL_GetSurfaceAlphaMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceAlphaMod")]
        static abstract byte GetSurfaceAlphaMod(Surface* surface, byte* alpha);

        [NativeName("SDL_GetSurfaceAlphaMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceAlphaMod")]
        static abstract MaybeBool<byte> GetSurfaceAlphaMod(Ref<Surface> surface, Ref<byte> alpha);

        [NativeName("SDL_GetSurfaceBlendMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceBlendMode")]
        static abstract byte GetSurfaceBlendMode(Surface* surface, BlendMode* blendMode);

        [NativeName("SDL_GetSurfaceBlendMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceBlendMode")]
        static abstract MaybeBool<byte> GetSurfaceBlendMode(
            Ref<Surface> surface,
            Ref<BlendMode> blendMode
        );

        [NativeName("SDL_GetSurfaceClipRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceClipRect")]
        static abstract byte GetSurfaceClipRect(Surface* surface, Rect* rect);

        [NativeName("SDL_GetSurfaceClipRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceClipRect")]
        static abstract MaybeBool<byte> GetSurfaceClipRect(Ref<Surface> surface, Ref<Rect> rect);

        [NativeName("SDL_GetSurfaceColorKey")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorKey")]
        static abstract byte GetSurfaceColorKey(Surface* surface, uint* key);

        [NativeName("SDL_GetSurfaceColorKey")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorKey")]
        static abstract MaybeBool<byte> GetSurfaceColorKey(Ref<Surface> surface, Ref<uint> key);

        [NativeName("SDL_GetSurfaceColorMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorMod")]
        static abstract byte GetSurfaceColorMod(Surface* surface, byte* r, byte* g, byte* b);

        [NativeName("SDL_GetSurfaceColorMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorMod")]
        static abstract MaybeBool<byte> GetSurfaceColorMod(
            Ref<Surface> surface,
            Ref<byte> r,
            Ref<byte> g,
            Ref<byte> b
        );

        [NativeName("SDL_GetSurfaceColorspace")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorspace")]
        static abstract Colorspace GetSurfaceColorspace(Surface* surface);

        [NativeName("SDL_GetSurfaceColorspace")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorspace")]
        static abstract Colorspace GetSurfaceColorspace(Ref<Surface> surface);

        [NativeName("SDL_GetSurfaceImages")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceImages")]
        static abstract Surface** GetSurfaceImages(Surface* surface, int* count);

        [NativeName("SDL_GetSurfaceImages")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceImages")]
        static abstract Ptr2D<Surface> GetSurfaceImages(Ref<Surface> surface, Ref<int> count);

        [NativeName("SDL_GetSurfacePalette")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfacePalette")]
        static abstract Palette* GetSurfacePalette(Surface* surface);

        [NativeName("SDL_GetSurfacePalette")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfacePalette")]
        static abstract Ptr<Palette> GetSurfacePalette(Ref<Surface> surface);

        [NativeName("SDL_GetSurfaceProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceProperties")]
        static abstract uint GetSurfaceProperties(Surface* surface);

        [NativeName("SDL_GetSurfaceProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceProperties")]
        static abstract uint GetSurfaceProperties(Ref<Surface> surface);

        [NativeName("SDL_GetSystemRAM")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSystemRAM")]
        static abstract int GetSystemRam();

        [NativeName("SDL_GetSystemTheme")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetSystemTheme")]
        static abstract SystemTheme GetSystemTheme();

        [NativeName("SDL_GetTextInputArea")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextInputArea")]
        static abstract byte GetTextInputArea(WindowHandle window, Rect* rect, int* cursor);

        [NativeName("SDL_GetTextInputArea")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextInputArea")]
        static abstract MaybeBool<byte> GetTextInputArea(
            WindowHandle window,
            Ref<Rect> rect,
            Ref<int> cursor
        );

        [NativeName("SDL_GetTextureAlphaMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaMod")]
        static abstract byte GetTextureAlphaMod(Texture* texture, byte* alpha);

        [NativeName("SDL_GetTextureAlphaMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaMod")]
        static abstract MaybeBool<byte> GetTextureAlphaMod(Ref<Texture> texture, Ref<byte> alpha);

        [NativeName("SDL_GetTextureAlphaModFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaModFloat")]
        static abstract byte GetTextureAlphaModFloat(Texture* texture, float* alpha);

        [NativeName("SDL_GetTextureAlphaModFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaModFloat")]
        static abstract MaybeBool<byte> GetTextureAlphaModFloat(
            Ref<Texture> texture,
            Ref<float> alpha
        );

        [NativeName("SDL_GetTextureBlendMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureBlendMode")]
        static abstract byte GetTextureBlendMode(Texture* texture, BlendMode* blendMode);

        [NativeName("SDL_GetTextureBlendMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureBlendMode")]
        static abstract MaybeBool<byte> GetTextureBlendMode(
            Ref<Texture> texture,
            Ref<BlendMode> blendMode
        );

        [NativeName("SDL_GetTextureColorMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorMod")]
        static abstract byte GetTextureColorMod(Texture* texture, byte* r, byte* g, byte* b);

        [NativeName("SDL_GetTextureColorMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorMod")]
        static abstract MaybeBool<byte> GetTextureColorMod(
            Ref<Texture> texture,
            Ref<byte> r,
            Ref<byte> g,
            Ref<byte> b
        );

        [NativeName("SDL_GetTextureColorModFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorModFloat")]
        static abstract byte GetTextureColorModFloat(
            Texture* texture,
            float* r,
            float* g,
            float* b
        );

        [NativeName("SDL_GetTextureColorModFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorModFloat")]
        static abstract MaybeBool<byte> GetTextureColorModFloat(
            Ref<Texture> texture,
            Ref<float> r,
            Ref<float> g,
            Ref<float> b
        );

        [NativeName("SDL_GetTextureProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureProperties")]
        static abstract uint GetTextureProperties(Texture* texture);

        [NativeName("SDL_GetTextureProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureProperties")]
        static abstract uint GetTextureProperties(Ref<Texture> texture);

        [NativeName("SDL_GetTextureScaleMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureScaleMode")]
        static abstract byte GetTextureScaleMode(Texture* texture, ScaleMode* scaleMode);

        [NativeName("SDL_GetTextureScaleMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureScaleMode")]
        static abstract MaybeBool<byte> GetTextureScaleMode(
            Ref<Texture> texture,
            Ref<ScaleMode> scaleMode
        );

        [NativeName("SDL_GetTextureSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureSize")]
        static abstract byte GetTextureSize(Texture* texture, float* w, float* h);

        [NativeName("SDL_GetTextureSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureSize")]
        static abstract MaybeBool<byte> GetTextureSize(
            Ref<Texture> texture,
            Ref<float> w,
            Ref<float> h
        );

        [NativeName("SDL_GetThreadID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadID")]
        static abstract ulong GetThreadId(ThreadHandle thread);

        [NativeName("SDL_GetThreadName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadName")]
        static abstract Ptr<sbyte> GetThreadName(ThreadHandle thread);

        [NativeName("SDL_GetThreadName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadName")]
        static abstract sbyte* GetThreadNameRaw(ThreadHandle thread);

        [NativeName("SDL_GetThreadState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadState")]
        static abstract ThreadState GetThreadState(ThreadHandle thread);

        [NativeName("SDL_GetTicks")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTicks")]
        static abstract ulong GetTicks();

        [NativeName("SDL_GetTicksNS")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTicksNS")]
        static abstract ulong GetTicksNs();

        [NativeName("SDL_GetTLS")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTLS")]
        static abstract void* GetTls(AtomicInt* id);

        [NativeName("SDL_GetTLS")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTLS")]
        static abstract Ptr GetTls(Ref<AtomicInt> id);

        [NativeName("SDL_GetTouchDeviceName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceName")]
        static abstract Ptr<sbyte> GetTouchDeviceName(ulong touchID);

        [NativeName("SDL_GetTouchDeviceName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceName")]
        static abstract sbyte* GetTouchDeviceNameRaw(ulong touchID);

        [NativeName("SDL_GetTouchDevices")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDevices")]
        static abstract ulong* GetTouchDevices(int* count);

        [NativeName("SDL_GetTouchDevices")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDevices")]
        static abstract Ptr<ulong> GetTouchDevices(Ref<int> count);

        [NativeName("SDL_GetTouchDeviceType")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceType")]
        static abstract TouchDeviceType GetTouchDeviceType(ulong touchID);

        [NativeName("SDL_GetTouchFingers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchFingers")]
        static abstract Finger** GetTouchFingers(ulong touchID, int* count);

        [NativeName("SDL_GetTouchFingers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchFingers")]
        static abstract Ptr2D<Finger> GetTouchFingers(ulong touchID, Ref<int> count);

        [NativeName("SDL_GetUserFolder")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetUserFolder")]
        static abstract Ptr<sbyte> GetUserFolder(Folder folder);

        [NativeName("SDL_GetUserFolder")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetUserFolder")]
        static abstract sbyte* GetUserFolderRaw(Folder folder);

        [NativeName("SDL_GetVersion")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetVersion")]
        static abstract int GetVersion();

        [NativeName("SDL_GetVideoDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetVideoDriver")]
        static abstract Ptr<sbyte> GetVideoDriver(int index);

        [NativeName("SDL_GetVideoDriver")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetVideoDriver")]
        static abstract sbyte* GetVideoDriverRaw(int index);

        [NativeName("SDL_GetWindowAspectRatio")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowAspectRatio")]
        static abstract byte GetWindowAspectRatio(
            WindowHandle window,
            float* min_aspect,
            float* max_aspect
        );

        [NativeName("SDL_GetWindowAspectRatio")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowAspectRatio")]
        static abstract MaybeBool<byte> GetWindowAspectRatio(
            WindowHandle window,
            Ref<float> min_aspect,
            Ref<float> max_aspect
        );

        [NativeName("SDL_GetWindowBordersSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowBordersSize")]
        static abstract byte GetWindowBordersSize(
            WindowHandle window,
            int* top,
            int* left,
            int* bottom,
            int* right
        );

        [NativeName("SDL_GetWindowBordersSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowBordersSize")]
        static abstract MaybeBool<byte> GetWindowBordersSize(
            WindowHandle window,
            Ref<int> top,
            Ref<int> left,
            Ref<int> bottom,
            Ref<int> right
        );

        [NativeName("SDL_GetWindowDisplayScale")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowDisplayScale")]
        static abstract float GetWindowDisplayScale(WindowHandle window);

        [NativeName("SDL_GetWindowFlags")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFlags")]
        static abstract ulong GetWindowFlags(WindowHandle window);

        [NativeName("SDL_GetWindowFromEvent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFromEvent")]
        static abstract WindowHandle GetWindowFromEvent(Event* @event);

        [NativeName("SDL_GetWindowFromEvent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFromEvent")]
        static abstract WindowHandle GetWindowFromEvent(Ref<Event> @event);

        [NativeName("SDL_GetWindowFromID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFromID")]
        static abstract WindowHandle GetWindowFromId(uint id);

        [NativeName("SDL_GetWindowFullscreenMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFullscreenMode")]
        static abstract Ptr<DisplayMode> GetWindowFullscreenMode(WindowHandle window);

        [NativeName("SDL_GetWindowFullscreenMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFullscreenMode")]
        static abstract DisplayMode* GetWindowFullscreenModeRaw(WindowHandle window);

        [NativeName("SDL_GetWindowICCProfile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowICCProfile")]
        static abstract void* GetWindowIccProfile(WindowHandle window, nuint* size);

        [NativeName("SDL_GetWindowICCProfile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowICCProfile")]
        static abstract Ptr GetWindowIccProfile(WindowHandle window, Ref<nuint> size);

        [NativeName("SDL_GetWindowID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowID")]
        static abstract uint GetWindowId(WindowHandle window);

        [NativeName("SDL_GetWindowKeyboardGrab")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowKeyboardGrab")]
        static abstract MaybeBool<byte> GetWindowKeyboardGrab(WindowHandle window);

        [NativeName("SDL_GetWindowKeyboardGrab")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowKeyboardGrab")]
        static abstract byte GetWindowKeyboardGrabRaw(WindowHandle window);

        [NativeName("SDL_GetWindowMaximumSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMaximumSize")]
        static abstract byte GetWindowMaximumSize(WindowHandle window, int* w, int* h);

        [NativeName("SDL_GetWindowMaximumSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMaximumSize")]
        static abstract MaybeBool<byte> GetWindowMaximumSize(
            WindowHandle window,
            Ref<int> w,
            Ref<int> h
        );

        [NativeName("SDL_GetWindowMinimumSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMinimumSize")]
        static abstract byte GetWindowMinimumSize(WindowHandle window, int* w, int* h);

        [NativeName("SDL_GetWindowMinimumSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMinimumSize")]
        static abstract MaybeBool<byte> GetWindowMinimumSize(
            WindowHandle window,
            Ref<int> w,
            Ref<int> h
        );

        [NativeName("SDL_GetWindowMouseGrab")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseGrab")]
        static abstract MaybeBool<byte> GetWindowMouseGrab(WindowHandle window);

        [NativeName("SDL_GetWindowMouseGrab")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseGrab")]
        static abstract byte GetWindowMouseGrabRaw(WindowHandle window);

        [NativeName("SDL_GetWindowMouseRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseRect")]
        static abstract Ptr<Rect> GetWindowMouseRect(WindowHandle window);

        [NativeName("SDL_GetWindowMouseRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseRect")]
        static abstract Rect* GetWindowMouseRectRaw(WindowHandle window);

        [NativeName("SDL_GetWindowOpacity")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowOpacity")]
        static abstract float GetWindowOpacity(WindowHandle window);

        [NativeName("SDL_GetWindowParent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowParent")]
        static abstract WindowHandle GetWindowParent(WindowHandle window);

        [NativeName("SDL_GetWindowPixelDensity")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPixelDensity")]
        static abstract float GetWindowPixelDensity(WindowHandle window);

        [NativeName("SDL_GetWindowPixelFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPixelFormat")]
        static abstract PixelFormat GetWindowPixelFormat(WindowHandle window);

        [NativeName("SDL_GetWindowPosition")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPosition")]
        static abstract byte GetWindowPosition(WindowHandle window, int* x, int* y);

        [NativeName("SDL_GetWindowPosition")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPosition")]
        static abstract MaybeBool<byte> GetWindowPosition(
            WindowHandle window,
            Ref<int> x,
            Ref<int> y
        );

        [NativeName("SDL_GetWindowProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowProperties")]
        static abstract uint GetWindowProperties(WindowHandle window);

        [NativeName("SDL_GetWindowRelativeMouseMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowRelativeMouseMode")]
        static abstract MaybeBool<byte> GetWindowRelativeMouseMode(WindowHandle window);

        [NativeName("SDL_GetWindowRelativeMouseMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowRelativeMouseMode")]
        static abstract byte GetWindowRelativeMouseModeRaw(WindowHandle window);

        [NativeName("SDL_GetWindows")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindows")]
        static abstract WindowHandle* GetWindows(int* count);

        [NativeName("SDL_GetWindows")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindows")]
        static abstract Ptr<WindowHandle> GetWindows(Ref<int> count);

        [NativeName("SDL_GetWindowSafeArea")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSafeArea")]
        static abstract byte GetWindowSafeArea(WindowHandle window, Rect* rect);

        [NativeName("SDL_GetWindowSafeArea")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSafeArea")]
        static abstract MaybeBool<byte> GetWindowSafeArea(WindowHandle window, Ref<Rect> rect);

        [NativeName("SDL_GetWindowSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSize")]
        static abstract byte GetWindowSize(WindowHandle window, int* w, int* h);

        [NativeName("SDL_GetWindowSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSize")]
        static abstract MaybeBool<byte> GetWindowSize(WindowHandle window, Ref<int> w, Ref<int> h);

        [NativeName("SDL_GetWindowSizeInPixels")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSizeInPixels")]
        static abstract byte GetWindowSizeInPixels(WindowHandle window, int* w, int* h);

        [NativeName("SDL_GetWindowSizeInPixels")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSizeInPixels")]
        static abstract MaybeBool<byte> GetWindowSizeInPixels(
            WindowHandle window,
            Ref<int> w,
            Ref<int> h
        );

        [NativeName("SDL_GetWindowSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurface")]
        static abstract Ptr<Surface> GetWindowSurface(WindowHandle window);

        [NativeName("SDL_GetWindowSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurface")]
        static abstract Surface* GetWindowSurfaceRaw(WindowHandle window);

        [NativeName("SDL_GetWindowSurfaceVSync")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurfaceVSync")]
        static abstract byte GetWindowSurfaceVSync(WindowHandle window, int* vsync);

        [NativeName("SDL_GetWindowSurfaceVSync")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurfaceVSync")]
        static abstract MaybeBool<byte> GetWindowSurfaceVSync(WindowHandle window, Ref<int> vsync);

        [NativeName("SDL_GetWindowTitle")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowTitle")]
        static abstract Ptr<sbyte> GetWindowTitle(WindowHandle window);

        [NativeName("SDL_GetWindowTitle")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowTitle")]
        static abstract sbyte* GetWindowTitleRaw(WindowHandle window);

        [NativeName("SDL_GL_CreateContext")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_CreateContext")]
        static abstract GlContextStateHandle GlCreateContext(WindowHandle window);

        [NativeName("SDL_GL_DestroyContext")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_DestroyContext")]
        static abstract MaybeBool<byte> GlDestroyContext(GlContextStateHandle context);

        [NativeName("SDL_GL_DestroyContext")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_DestroyContext")]
        static abstract byte GlDestroyContextRaw(GlContextStateHandle context);

        [NativeName("SDL_GL_ExtensionSupported")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_ExtensionSupported")]
        static abstract byte GlExtensionSupported(sbyte* extension);

        [NativeName("SDL_GL_ExtensionSupported")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_ExtensionSupported")]
        static abstract MaybeBool<byte> GlExtensionSupported(Ref<sbyte> extension);

        [NativeName("SDL_GL_GetAttribute")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetAttribute")]
        static abstract byte GlGetAttribute(GlAttr attr, int* value);

        [NativeName("SDL_GL_GetAttribute")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetAttribute")]
        static abstract MaybeBool<byte> GlGetAttribute(GlAttr attr, Ref<int> value);

        [NativeName("SDL_GL_GetCurrentContext")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetCurrentContext")]
        static abstract GlContextStateHandle GlGetCurrentContext();

        [NativeName("SDL_GL_GetCurrentWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetCurrentWindow")]
        static abstract WindowHandle GlGetCurrentWindow();

        [NativeName("SDL_GL_GetProcAddress")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetProcAddress")]
        static abstract FunctionPointer GlGetProcAddress(sbyte* proc);

        [NativeName("SDL_GL_GetProcAddress")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetProcAddress")]
        static abstract FunctionPointer GlGetProcAddress(Ref<sbyte> proc);

        [NativeName("SDL_GL_GetSwapInterval")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetSwapInterval")]
        static abstract byte GlGetSwapInterval(int* interval);

        [NativeName("SDL_GL_GetSwapInterval")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetSwapInterval")]
        static abstract MaybeBool<byte> GlGetSwapInterval(Ref<int> interval);

        [NativeName("SDL_GL_LoadLibrary")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_LoadLibrary")]
        static abstract byte GlLoadLibrary(sbyte* path);

        [NativeName("SDL_GL_LoadLibrary")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_LoadLibrary")]
        static abstract MaybeBool<byte> GlLoadLibrary(Ref<sbyte> path);

        [NativeName("SDL_GL_MakeCurrent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_MakeCurrent")]
        static abstract MaybeBool<byte> GlMakeCurrent(
            WindowHandle window,
            GlContextStateHandle context
        );

        [NativeName("SDL_GL_MakeCurrent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_MakeCurrent")]
        static abstract byte GlMakeCurrentRaw(WindowHandle window, GlContextStateHandle context);

        [NativeName("SDL_GL_ResetAttributes")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_ResetAttributes")]
        static abstract void GlResetAttributes();

        [NativeName("SDL_GL_SetAttribute")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetAttribute")]
        static abstract MaybeBool<byte> GlSetAttribute(GlAttr attr, int value);

        [NativeName("SDL_GL_SetAttribute")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetAttribute")]
        static abstract byte GlSetAttributeRaw(GlAttr attr, int value);

        [NativeName("SDL_GL_SetSwapInterval")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetSwapInterval")]
        static abstract MaybeBool<byte> GlSetSwapInterval(int interval);

        [NativeName("SDL_GL_SetSwapInterval")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetSwapInterval")]
        static abstract byte GlSetSwapIntervalRaw(int interval);

        [NativeName("SDL_GL_SwapWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SwapWindow")]
        static abstract MaybeBool<byte> GlSwapWindow(WindowHandle window);

        [NativeName("SDL_GL_SwapWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_SwapWindow")]
        static abstract byte GlSwapWindowRaw(WindowHandle window);

        [NativeName("SDL_GL_UnloadLibrary")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GL_UnloadLibrary")]
        static abstract void GlUnloadLibrary();

        [NativeName("SDL_GlobDirectory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GlobDirectory")]
        static abstract sbyte** GlobDirectory(sbyte* path, sbyte* pattern, uint flags, int* count);

        [NativeName("SDL_GlobDirectory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GlobDirectory")]
        static abstract Ptr2D<sbyte> GlobDirectory(
            Ref<sbyte> path,
            Ref<sbyte> pattern,
            uint flags,
            Ref<int> count
        );

        [NativeName("SDL_GlobStorageDirectory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GlobStorageDirectory")]
        static abstract sbyte** GlobStorageDirectory(
            StorageHandle storage,
            sbyte* path,
            sbyte* pattern,
            uint flags,
            int* count
        );

        [NativeName("SDL_GlobStorageDirectory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GlobStorageDirectory")]
        static abstract Ptr2D<sbyte> GlobStorageDirectory(
            StorageHandle storage,
            Ref<sbyte> path,
            Ref<sbyte> pattern,
            uint flags,
            Ref<int> count
        );

        [NativeName("SDL_GPUSupportsProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsProperties")]
        static abstract MaybeBool<byte> GpuSupportsProperties(uint props);

        [NativeName("SDL_GPUSupportsProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsProperties")]
        static abstract byte GpuSupportsPropertiesRaw(uint props);

        [NativeName("SDL_GPUSupportsShaderFormats")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsShaderFormats")]
        static abstract byte GpuSupportsShaderFormats(uint format_flags, sbyte* name);

        [NativeName("SDL_GPUSupportsShaderFormats")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsShaderFormats")]
        static abstract MaybeBool<byte> GpuSupportsShaderFormats(
            uint format_flags,
            Ref<sbyte> name
        );

        [NativeName("SDL_GPUTextureFormatTexelBlockSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureFormatTexelBlockSize")]
        static abstract uint GpuTextureFormatTexelBlockSize(GpuTextureFormat format);

        [NativeName("SDL_GPUTextureSupportsFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsFormat")]
        static abstract MaybeBool<byte> GpuTextureSupportsFormat(
            GpuDeviceHandle device,
            GpuTextureFormat format,
            GpuTextureType type,
            uint usage
        );

        [NativeName("SDL_GPUTextureSupportsFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsFormat")]
        static abstract byte GpuTextureSupportsFormatRaw(
            GpuDeviceHandle device,
            GpuTextureFormat format,
            GpuTextureType type,
            uint usage
        );

        [NativeName("SDL_GPUTextureSupportsSampleCount")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsSampleCount")]
        static abstract MaybeBool<byte> GpuTextureSupportsSampleCount(
            GpuDeviceHandle device,
            GpuTextureFormat format,
            GpuSampleCount sample_count
        );

        [NativeName("SDL_GPUTextureSupportsSampleCount")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsSampleCount")]
        static abstract byte GpuTextureSupportsSampleCountRaw(
            GpuDeviceHandle device,
            GpuTextureFormat format,
            GpuSampleCount sample_count
        );

        [NativeName("SDL_GUIDToString")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GUIDToString")]
        static abstract void GuidToString(Guid guid, sbyte* pszGUID, int cbGUID);

        [NativeName("SDL_GUIDToString")]
        [NativeFunction("SDL3", EntryPoint = "SDL_GUIDToString")]
        static abstract void GuidToString(Guid guid, Ref<sbyte> pszGUID, int cbGUID);

        [NativeName("SDL_HapticEffectSupported")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HapticEffectSupported")]
        static abstract byte HapticEffectSupported(HapticHandle haptic, HapticEffect* effect);

        [NativeName("SDL_HapticEffectSupported")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HapticEffectSupported")]
        static abstract MaybeBool<byte> HapticEffectSupported(
            HapticHandle haptic,
            Ref<HapticEffect> effect
        );

        [NativeName("SDL_HapticRumbleSupported")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HapticRumbleSupported")]
        static abstract MaybeBool<byte> HapticRumbleSupported(HapticHandle haptic);

        [NativeName("SDL_HapticRumbleSupported")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HapticRumbleSupported")]
        static abstract byte HapticRumbleSupportedRaw(HapticHandle haptic);

        [NativeName("SDL_HasAltiVec")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAltiVec")]
        static abstract MaybeBool<byte> HasAltiVec();

        [NativeName("SDL_HasAltiVec")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAltiVec")]
        static abstract byte HasAltiVecRaw();

        [NativeName("SDL_HasARMSIMD")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasARMSIMD")]
        static abstract MaybeBool<byte> HasArmsimd();

        [NativeName("SDL_HasARMSIMD")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasARMSIMD")]
        static abstract byte HasArmsimdRaw();

        [NativeName("SDL_HasAVX")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX")]
        static abstract MaybeBool<byte> HasAvx();

        [NativeName("SDL_HasAVX2")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX2")]
        static abstract MaybeBool<byte> HasAvx2();

        [NativeName("SDL_HasAVX2")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX2")]
        static abstract byte HasAvx2Raw();

        [NativeName("SDL_HasAVX512F")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX512F")]
        static abstract MaybeBool<byte> HasAvx512F();

        [NativeName("SDL_HasAVX512F")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX512F")]
        static abstract byte HasAvx512FRaw();

        [NativeName("SDL_HasAVX")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX")]
        static abstract byte HasAvxRaw();

        [NativeName("SDL_HasClipboardData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardData")]
        static abstract byte HasClipboardData(sbyte* mime_type);

        [NativeName("SDL_HasClipboardData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardData")]
        static abstract MaybeBool<byte> HasClipboardData(Ref<sbyte> mime_type);

        [NativeName("SDL_HasClipboardText")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardText")]
        static abstract MaybeBool<byte> HasClipboardText();

        [NativeName("SDL_HasClipboardText")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardText")]
        static abstract byte HasClipboardTextRaw();

        [NativeName("SDL_HasEvent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasEvent")]
        static abstract MaybeBool<byte> HasEvent(uint type);

        [NativeName("SDL_HasEvent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasEvent")]
        static abstract byte HasEventRaw(uint type);

        [NativeName("SDL_HasEvents")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasEvents")]
        static abstract MaybeBool<byte> HasEvents(uint minType, uint maxType);

        [NativeName("SDL_HasEvents")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasEvents")]
        static abstract byte HasEventsRaw(uint minType, uint maxType);

        [NativeName("SDL_HasGamepad")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasGamepad")]
        static abstract MaybeBool<byte> HasGamepad();

        [NativeName("SDL_HasGamepad")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasGamepad")]
        static abstract byte HasGamepadRaw();

        [NativeName("SDL_HasJoystick")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasJoystick")]
        static abstract MaybeBool<byte> HasJoystick();

        [NativeName("SDL_HasJoystick")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasJoystick")]
        static abstract byte HasJoystickRaw();

        [NativeName("SDL_HasKeyboard")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasKeyboard")]
        static abstract MaybeBool<byte> HasKeyboard();

        [NativeName("SDL_HasKeyboard")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasKeyboard")]
        static abstract byte HasKeyboardRaw();

        [NativeName("SDL_HasLASX")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasLASX")]
        static abstract MaybeBool<byte> HasLasx();

        [NativeName("SDL_HasLASX")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasLASX")]
        static abstract byte HasLasxRaw();

        [NativeName("SDL_HasLSX")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasLSX")]
        static abstract MaybeBool<byte> HasLsx();

        [NativeName("SDL_HasLSX")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasLSX")]
        static abstract byte HasLsxRaw();

        [NativeName("SDL_HasMMX")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasMMX")]
        static abstract MaybeBool<byte> HasMmx();

        [NativeName("SDL_HasMMX")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasMMX")]
        static abstract byte HasMmxRaw();

        [NativeName("SDL_HasMouse")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasMouse")]
        static abstract MaybeBool<byte> HasMouse();

        [NativeName("SDL_HasMouse")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasMouse")]
        static abstract byte HasMouseRaw();

        [NativeName("SDL_HasNEON")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasNEON")]
        static abstract MaybeBool<byte> HasNeon();

        [NativeName("SDL_HasNEON")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasNEON")]
        static abstract byte HasNeonRaw();

        [NativeName("SDL_HasPrimarySelectionText")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasPrimarySelectionText")]
        static abstract MaybeBool<byte> HasPrimarySelectionText();

        [NativeName("SDL_HasPrimarySelectionText")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasPrimarySelectionText")]
        static abstract byte HasPrimarySelectionTextRaw();

        [NativeName("SDL_HasProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasProperty")]
        static abstract byte HasProperty(uint props, sbyte* name);

        [NativeName("SDL_HasProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasProperty")]
        static abstract MaybeBool<byte> HasProperty(uint props, Ref<sbyte> name);

        [NativeName("SDL_HasRectIntersection")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersection")]
        static abstract byte HasRectIntersection(Rect* A, Rect* B);

        [NativeName("SDL_HasRectIntersection")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersection")]
        static abstract MaybeBool<byte> HasRectIntersection(Ref<Rect> A, Ref<Rect> B);

        [NativeName("SDL_HasRectIntersectionFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersectionFloat")]
        static abstract byte HasRectIntersectionFloat(FRect* A, FRect* B);

        [NativeName("SDL_HasRectIntersectionFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersectionFloat")]
        static abstract MaybeBool<byte> HasRectIntersectionFloat(Ref<FRect> A, Ref<FRect> B);

        [NativeName("SDL_HasScreenKeyboardSupport")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasScreenKeyboardSupport")]
        static abstract MaybeBool<byte> HasScreenKeyboardSupport();

        [NativeName("SDL_HasScreenKeyboardSupport")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasScreenKeyboardSupport")]
        static abstract byte HasScreenKeyboardSupportRaw();

        [NativeName("SDL_HasSSE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE")]
        static abstract MaybeBool<byte> HasSse();

        [NativeName("SDL_HasSSE2")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE2")]
        static abstract MaybeBool<byte> HasSse2();

        [NativeName("SDL_HasSSE2")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE2")]
        static abstract byte HasSse2Raw();

        [NativeName("SDL_HasSSE3")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE3")]
        static abstract MaybeBool<byte> HasSse3();

        [NativeName("SDL_HasSSE3")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE3")]
        static abstract byte HasSse3Raw();

        [NativeName("SDL_HasSSE41")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE41")]
        static abstract MaybeBool<byte> HasSse41();

        [NativeName("SDL_HasSSE41")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE41")]
        static abstract byte HasSse41Raw();

        [NativeName("SDL_HasSSE42")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE42")]
        static abstract MaybeBool<byte> HasSse42();

        [NativeName("SDL_HasSSE42")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE42")]
        static abstract byte HasSse42Raw();

        [NativeName("SDL_HasSSE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE")]
        static abstract byte HasSseRaw();

        [NativeName("SDL_hid_ble_scan")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_ble_scan")]
        static abstract void HidBleScan(byte active);

        [NativeName("SDL_hid_ble_scan")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_ble_scan")]
        static abstract void HidBleScan(MaybeBool<byte> active);

        [NativeName("SDL_hid_close")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_close")]
        static abstract int HidClose(HidDeviceHandle dev);

        [NativeName("SDL_hid_device_change_count")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_device_change_count")]
        static abstract uint HidDeviceChangeCount();

        [NativeName("SDL_hid_enumerate")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_enumerate")]
        static abstract Ptr<HidDeviceInfo> HidEnumerate(ushort vendor_id, ushort product_id);

        [NativeName("SDL_hid_enumerate")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_enumerate")]
        static abstract HidDeviceInfo* HidEnumerateRaw(ushort vendor_id, ushort product_id);

        [NativeName("SDL_hid_exit")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_exit")]
        static abstract int HidExit();

        [NativeName("SDL_hid_free_enumeration")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_free_enumeration")]
        static abstract void HidFreeEnumeration(HidDeviceInfo* devs);

        [NativeName("SDL_hid_free_enumeration")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_free_enumeration")]
        static abstract void HidFreeEnumeration(Ref<HidDeviceInfo> devs);

        [NativeName("SDL_hid_get_device_info")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_device_info")]
        static abstract Ptr<HidDeviceInfo> HidGetDeviceInfo(HidDeviceHandle dev);

        [NativeName("SDL_hid_get_device_info")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_device_info")]
        static abstract HidDeviceInfo* HidGetDeviceInfoRaw(HidDeviceHandle dev);

        [NativeName("SDL_hid_get_feature_report")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_feature_report")]
        static abstract int HidGetFeatureReport(HidDeviceHandle dev, byte* data, nuint length);

        [NativeName("SDL_hid_get_feature_report")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_feature_report")]
        static abstract int HidGetFeatureReport(HidDeviceHandle dev, Ref<byte> data, nuint length);

        [NativeName("SDL_hid_get_indexed_string")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_indexed_string")]
        static abstract int HidGetIndexedString(
            HidDeviceHandle dev,
            int string_index,
            ushort* @string,
            nuint maxlen
        );

        [NativeName("SDL_hid_get_indexed_string")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_indexed_string")]
        static abstract int HidGetIndexedString(
            HidDeviceHandle dev,
            int string_index,
            Ref<ushort> @string,
            nuint maxlen
        );

        [NativeName("SDL_hid_get_input_report")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_input_report")]
        static abstract int HidGetInputReport(HidDeviceHandle dev, byte* data, nuint length);

        [NativeName("SDL_hid_get_input_report")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_input_report")]
        static abstract int HidGetInputReport(HidDeviceHandle dev, Ref<byte> data, nuint length);

        [NativeName("SDL_hid_get_manufacturer_string")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_manufacturer_string")]
        static abstract int HidGetManufacturerString(
            HidDeviceHandle dev,
            ushort* @string,
            nuint maxlen
        );

        [NativeName("SDL_hid_get_manufacturer_string")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_manufacturer_string")]
        static abstract int HidGetManufacturerString(
            HidDeviceHandle dev,
            Ref<ushort> @string,
            nuint maxlen
        );

        [NativeName("SDL_hid_get_product_string")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_product_string")]
        static abstract int HidGetProductString(HidDeviceHandle dev, ushort* @string, nuint maxlen);

        [NativeName("SDL_hid_get_product_string")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_product_string")]
        static abstract int HidGetProductString(
            HidDeviceHandle dev,
            Ref<ushort> @string,
            nuint maxlen
        );

        [NativeName("SDL_hid_get_report_descriptor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_report_descriptor")]
        static abstract int HidGetReportDescriptor(HidDeviceHandle dev, byte* buf, nuint buf_size);

        [NativeName("SDL_hid_get_report_descriptor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_report_descriptor")]
        static abstract int HidGetReportDescriptor(
            HidDeviceHandle dev,
            Ref<byte> buf,
            nuint buf_size
        );

        [NativeName("SDL_hid_get_serial_number_string")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_serial_number_string")]
        static abstract int HidGetSerialNumberString(
            HidDeviceHandle dev,
            ushort* @string,
            nuint maxlen
        );

        [NativeName("SDL_hid_get_serial_number_string")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_serial_number_string")]
        static abstract int HidGetSerialNumberString(
            HidDeviceHandle dev,
            Ref<ushort> @string,
            nuint maxlen
        );

        [NativeName("SDL_hid_init")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_init")]
        static abstract int HidInit();

        [NativeName("SDL_hid_open")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_open")]
        static abstract HidDeviceHandle HidOpen(
            ushort vendor_id,
            ushort product_id,
            ushort* serial_number
        );

        [NativeName("SDL_hid_open")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_open")]
        static abstract HidDeviceHandle HidOpen(
            ushort vendor_id,
            ushort product_id,
            Ref<ushort> serial_number
        );

        [NativeName("SDL_hid_open_path")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_open_path")]
        static abstract HidDeviceHandle HidOpenPath(sbyte* path);

        [NativeName("SDL_hid_open_path")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_open_path")]
        static abstract HidDeviceHandle HidOpenPath(Ref<sbyte> path);

        [NativeName("SDL_hid_read")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_read")]
        static abstract int HidRead(HidDeviceHandle dev, byte* data, nuint length);

        [NativeName("SDL_hid_read")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_read")]
        static abstract int HidRead(HidDeviceHandle dev, Ref<byte> data, nuint length);

        [NativeName("SDL_hid_read_timeout")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_read_timeout")]
        static abstract int HidReadTimeout(
            HidDeviceHandle dev,
            byte* data,
            nuint length,
            int milliseconds
        );

        [NativeName("SDL_hid_read_timeout")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_read_timeout")]
        static abstract int HidReadTimeout(
            HidDeviceHandle dev,
            Ref<byte> data,
            nuint length,
            int milliseconds
        );

        [NativeName("SDL_hid_send_feature_report")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_send_feature_report")]
        static abstract int HidSendFeatureReport(HidDeviceHandle dev, byte* data, nuint length);

        [NativeName("SDL_hid_send_feature_report")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_send_feature_report")]
        static abstract int HidSendFeatureReport(HidDeviceHandle dev, Ref<byte> data, nuint length);

        [NativeName("SDL_hid_set_nonblocking")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_set_nonblocking")]
        static abstract int HidSetNonblocking(HidDeviceHandle dev, int nonblock);

        [NativeName("SDL_hid_write")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_write")]
        static abstract int HidWrite(HidDeviceHandle dev, byte* data, nuint length);

        [NativeName("SDL_hid_write")]
        [NativeFunction("SDL3", EntryPoint = "SDL_hid_write")]
        static abstract int HidWrite(HidDeviceHandle dev, Ref<byte> data, nuint length);

        [NativeName("SDL_HideCursor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HideCursor")]
        static abstract MaybeBool<byte> HideCursor();

        [NativeName("SDL_HideCursor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HideCursor")]
        static abstract byte HideCursorRaw();

        [NativeName("SDL_HideWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HideWindow")]
        static abstract MaybeBool<byte> HideWindow(WindowHandle window);

        [NativeName("SDL_HideWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_HideWindow")]
        static abstract byte HideWindowRaw(WindowHandle window);

        [NativeName("SDL_iconv")]
        [NativeFunction("SDL3", EntryPoint = "SDL_iconv")]
        static abstract nuint Iconv(
            IconvDataTHandle cd,
            sbyte** inbuf,
            nuint* inbytesleft,
            sbyte** outbuf,
            nuint* outbytesleft
        );

        [NativeName("SDL_iconv")]
        [NativeFunction("SDL3", EntryPoint = "SDL_iconv")]
        static abstract nuint Iconv(
            IconvDataTHandle cd,
            Ref2D<sbyte> inbuf,
            Ref<nuint> inbytesleft,
            Ref2D<sbyte> outbuf,
            Ref<nuint> outbytesleft
        );

        [NativeName("SDL_iconv_close")]
        [NativeFunction("SDL3", EntryPoint = "SDL_iconv_close")]
        static abstract int IconvClose(IconvDataTHandle cd);

        [NativeName("SDL_iconv_open")]
        [NativeFunction("SDL3", EntryPoint = "SDL_iconv_open")]
        static abstract IconvDataTHandle IconvOpen(sbyte* tocode, sbyte* fromcode);

        [NativeName("SDL_iconv_open")]
        [NativeFunction("SDL3", EntryPoint = "SDL_iconv_open")]
        static abstract IconvDataTHandle IconvOpen(Ref<sbyte> tocode, Ref<sbyte> fromcode);

        [NativeName("SDL_iconv_string")]
        [NativeFunction("SDL3", EntryPoint = "SDL_iconv_string")]
        static abstract sbyte* IconvString(
            sbyte* tocode,
            sbyte* fromcode,
            sbyte* inbuf,
            nuint inbytesleft
        );

        [NativeName("SDL_iconv_string")]
        [NativeFunction("SDL3", EntryPoint = "SDL_iconv_string")]
        static abstract Ptr<sbyte> IconvString(
            Ref<sbyte> tocode,
            Ref<sbyte> fromcode,
            Ref<sbyte> inbuf,
            nuint inbytesleft
        );

        [NativeName("SDL_Init")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Init")]
        static abstract MaybeBool<byte> Init(uint flags);

        [NativeName("SDL_InitHapticRumble")]
        [NativeFunction("SDL3", EntryPoint = "SDL_InitHapticRumble")]
        static abstract MaybeBool<byte> InitHapticRumble(HapticHandle haptic);

        [NativeName("SDL_InitHapticRumble")]
        [NativeFunction("SDL3", EntryPoint = "SDL_InitHapticRumble")]
        static abstract byte InitHapticRumbleRaw(HapticHandle haptic);

        [NativeName("SDL_Init")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Init")]
        static abstract byte InitRaw(uint flags);

        [NativeName("SDL_InitSubSystem")]
        [NativeFunction("SDL3", EntryPoint = "SDL_InitSubSystem")]
        static abstract MaybeBool<byte> InitSubSystem(uint flags);

        [NativeName("SDL_InitSubSystem")]
        [NativeFunction("SDL3", EntryPoint = "SDL_InitSubSystem")]
        static abstract byte InitSubSystemRaw(uint flags);

        [NativeName("SDL_InsertGPUDebugLabel")]
        [NativeFunction("SDL3", EntryPoint = "SDL_InsertGPUDebugLabel")]
        static abstract void InsertGpuDebugLabel(
            GpuCommandBufferHandle command_buffer,
            sbyte* text
        );

        [NativeName("SDL_InsertGPUDebugLabel")]
        [NativeFunction("SDL3", EntryPoint = "SDL_InsertGPUDebugLabel")]
        static abstract void InsertGpuDebugLabel(
            GpuCommandBufferHandle command_buffer,
            Ref<sbyte> text
        );

        [NativeName("SDL_IOFromConstMem")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOFromConstMem")]
        static abstract IoStreamHandle IoFromConstMem(void* mem, nuint size);

        [NativeName("SDL_IOFromConstMem")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOFromConstMem")]
        static abstract IoStreamHandle IoFromConstMem(Ref mem, nuint size);

        [NativeName("SDL_IOFromDynamicMem")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOFromDynamicMem")]
        static abstract IoStreamHandle IoFromDynamicMem();

        [NativeName("SDL_IOFromFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOFromFile")]
        static abstract IoStreamHandle IoFromFile(sbyte* file, sbyte* mode);

        [NativeName("SDL_IOFromFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOFromFile")]
        static abstract IoStreamHandle IoFromFile(Ref<sbyte> file, Ref<sbyte> mode);

        [NativeName("SDL_IOFromMem")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOFromMem")]
        static abstract IoStreamHandle IoFromMem(void* mem, nuint size);

        [NativeName("SDL_IOFromMem")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOFromMem")]
        static abstract IoStreamHandle IoFromMem(Ref mem, nuint size);

        [NativeName("SDL_IOvprintf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOvprintf")]
        static abstract nuint IOvprintf(IoStreamHandle context, sbyte* fmt, sbyte* ap);

        [NativeName("SDL_IOvprintf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IOvprintf")]
        static abstract nuint IOvprintf(IoStreamHandle context, Ref<sbyte> fmt, Ref<sbyte> ap);

        [NativeName("SDL_isalnum")]
        [NativeFunction("SDL3", EntryPoint = "SDL_isalnum")]
        static abstract int Isalnum(int x);

        [NativeName("SDL_isalpha")]
        [NativeFunction("SDL3", EntryPoint = "SDL_isalpha")]
        static abstract int Isalpha(int x);

        [NativeName("SDL_IsAudioDevicePhysical")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePhysical")]
        static abstract MaybeBool<byte> IsAudioDevicePhysical(uint devid);

        [NativeName("SDL_IsAudioDevicePhysical")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePhysical")]
        static abstract byte IsAudioDevicePhysicalRaw(uint devid);

        [NativeName("SDL_IsAudioDevicePlayback")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePlayback")]
        static abstract MaybeBool<byte> IsAudioDevicePlayback(uint devid);

        [NativeName("SDL_IsAudioDevicePlayback")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePlayback")]
        static abstract byte IsAudioDevicePlaybackRaw(uint devid);

        [NativeName("SDL_isblank")]
        [NativeFunction("SDL3", EntryPoint = "SDL_isblank")]
        static abstract int Isblank(int x);

        [NativeName("SDL_iscntrl")]
        [NativeFunction("SDL3", EntryPoint = "SDL_iscntrl")]
        static abstract int Iscntrl(int x);

        [NativeName("SDL_isdigit")]
        [NativeFunction("SDL3", EntryPoint = "SDL_isdigit")]
        static abstract int Isdigit(int x);

        [NativeName("SDL_IsGamepad")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsGamepad")]
        static abstract MaybeBool<byte> IsGamepad(uint instance_id);

        [NativeName("SDL_IsGamepad")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsGamepad")]
        static abstract byte IsGamepadRaw(uint instance_id);

        [NativeName("SDL_isgraph")]
        [NativeFunction("SDL3", EntryPoint = "SDL_isgraph")]
        static abstract int Isgraph(int x);

        [NativeName("SDL_isinf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_isinf")]
        static abstract int Isinf(double x);

        [NativeName("SDL_isinff")]
        [NativeFunction("SDL3", EntryPoint = "SDL_isinff")]
        static abstract int Isinff(float x);

        [NativeName("SDL_IsJoystickHaptic")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickHaptic")]
        static abstract MaybeBool<byte> IsJoystickHaptic(JoystickHandle joystick);

        [NativeName("SDL_IsJoystickHaptic")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickHaptic")]
        static abstract byte IsJoystickHapticRaw(JoystickHandle joystick);

        [NativeName("SDL_IsJoystickVirtual")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickVirtual")]
        static abstract MaybeBool<byte> IsJoystickVirtual(uint instance_id);

        [NativeName("SDL_IsJoystickVirtual")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickVirtual")]
        static abstract byte IsJoystickVirtualRaw(uint instance_id);

        [NativeName("SDL_islower")]
        [NativeFunction("SDL3", EntryPoint = "SDL_islower")]
        static abstract int Islower(int x);

        [NativeName("SDL_IsMainThread")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsMainThread")]
        static abstract MaybeBool<byte> IsMainThread();

        [NativeName("SDL_IsMainThread")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsMainThread")]
        static abstract byte IsMainThreadRaw();

        [NativeName("SDL_IsMouseHaptic")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsMouseHaptic")]
        static abstract MaybeBool<byte> IsMouseHaptic();

        [NativeName("SDL_IsMouseHaptic")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsMouseHaptic")]
        static abstract byte IsMouseHapticRaw();

        [NativeName("SDL_isnan")]
        [NativeFunction("SDL3", EntryPoint = "SDL_isnan")]
        static abstract int Isnan(double x);

        [NativeName("SDL_isnanf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_isnanf")]
        static abstract int Isnanf(float x);

        [NativeName("SDL_isprint")]
        [NativeFunction("SDL3", EntryPoint = "SDL_isprint")]
        static abstract int Isprint(int x);

        [NativeName("SDL_ispunct")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ispunct")]
        static abstract int Ispunct(int x);

        [NativeName("SDL_isspace")]
        [NativeFunction("SDL3", EntryPoint = "SDL_isspace")]
        static abstract int Isspace(int x);

        [NativeName("SDL_IsTablet")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsTablet")]
        static abstract MaybeBool<byte> IsTablet();

        [NativeName("SDL_IsTablet")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsTablet")]
        static abstract byte IsTabletRaw();

        [NativeName("SDL_IsTV")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsTV")]
        static abstract MaybeBool<byte> IsTv();

        [NativeName("SDL_IsTV")]
        [NativeFunction("SDL3", EntryPoint = "SDL_IsTV")]
        static abstract byte IsTvRaw();

        [NativeName("SDL_isupper")]
        [NativeFunction("SDL3", EntryPoint = "SDL_isupper")]
        static abstract int Isupper(int x);

        [NativeName("SDL_isxdigit")]
        [NativeFunction("SDL3", EntryPoint = "SDL_isxdigit")]
        static abstract int Isxdigit(int x);

        [NativeName("SDL_itoa")]
        [NativeFunction("SDL3", EntryPoint = "SDL_itoa")]
        static abstract sbyte* Itoa(int value, sbyte* str, int radix);

        [NativeName("SDL_itoa")]
        [NativeFunction("SDL3", EntryPoint = "SDL_itoa")]
        static abstract Ptr<sbyte> Itoa(int value, Ref<sbyte> str, int radix);

        [NativeName("SDL_JoystickConnected")]
        [NativeFunction("SDL3", EntryPoint = "SDL_JoystickConnected")]
        static abstract MaybeBool<byte> JoystickConnected(JoystickHandle joystick);

        [NativeName("SDL_JoystickConnected")]
        [NativeFunction("SDL3", EntryPoint = "SDL_JoystickConnected")]
        static abstract byte JoystickConnectedRaw(JoystickHandle joystick);

        [NativeName("SDL_JoystickEventsEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_JoystickEventsEnabled")]
        static abstract MaybeBool<byte> JoystickEventsEnabled();

        [NativeName("SDL_JoystickEventsEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_JoystickEventsEnabled")]
        static abstract byte JoystickEventsEnabledRaw();

        [NativeName("SDL_KillProcess")]
        [NativeFunction("SDL3", EntryPoint = "SDL_KillProcess")]
        static abstract byte KillProcess(ProcessHandle process, byte force);

        [NativeName("SDL_KillProcess")]
        [NativeFunction("SDL3", EntryPoint = "SDL_KillProcess")]
        static abstract MaybeBool<byte> KillProcess(ProcessHandle process, MaybeBool<byte> force);

        [NativeName("SDL_lltoa")]
        [NativeFunction("SDL3", EntryPoint = "SDL_lltoa")]
        static abstract sbyte* Lltoa(long value, sbyte* str, int radix);

        [NativeName("SDL_lltoa")]
        [NativeFunction("SDL3", EntryPoint = "SDL_lltoa")]
        static abstract Ptr<sbyte> Lltoa(long value, Ref<sbyte> str, int radix);

        [NativeName("SDL_LoadBMP")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP")]
        static abstract Surface* LoadBmp(sbyte* file);

        [NativeName("SDL_LoadBMP")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP")]
        static abstract Ptr<Surface> LoadBmp(Ref<sbyte> file);

        [NativeName("SDL_LoadBMP_IO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP_IO")]
        static abstract Surface* LoadBmpIo(IoStreamHandle src, byte closeio);

        [NativeName("SDL_LoadBMP_IO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP_IO")]
        static abstract Ptr<Surface> LoadBmpIo(IoStreamHandle src, MaybeBool<byte> closeio);

        [NativeName("SDL_LoadFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile")]
        static abstract void* LoadFile(sbyte* file, nuint* datasize);

        [NativeName("SDL_LoadFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile")]
        static abstract Ptr LoadFile(Ref<sbyte> file, Ref<nuint> datasize);

        [NativeName("SDL_LoadFile_IO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile_IO")]
        static abstract void* LoadFileIo(IoStreamHandle src, nuint* datasize, byte closeio);

        [NativeName("SDL_LoadFile_IO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile_IO")]
        static abstract Ptr LoadFileIo(
            IoStreamHandle src,
            Ref<nuint> datasize,
            MaybeBool<byte> closeio
        );

        [NativeName("SDL_LoadFunction")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFunction")]
        static abstract FunctionPointer LoadFunction(SharedObjectHandle handle, sbyte* name);

        [NativeName("SDL_LoadFunction")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadFunction")]
        static abstract FunctionPointer LoadFunction(SharedObjectHandle handle, Ref<sbyte> name);

        [NativeName("SDL_LoadObject")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadObject")]
        static abstract SharedObjectHandle LoadObject(sbyte* sofile);

        [NativeName("SDL_LoadObject")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadObject")]
        static abstract SharedObjectHandle LoadObject(Ref<sbyte> sofile);

        [NativeName("SDL_LoadWAV")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV")]
        static abstract byte LoadWav(
            sbyte* path,
            AudioSpec* spec,
            byte** audio_buf,
            uint* audio_len
        );

        [NativeName("SDL_LoadWAV")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV")]
        static abstract MaybeBool<byte> LoadWav(
            Ref<sbyte> path,
            Ref<AudioSpec> spec,
            Ref2D<byte> audio_buf,
            Ref<uint> audio_len
        );

        [NativeName("SDL_LoadWAV_IO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV_IO")]
        static abstract byte LoadWavIo(
            IoStreamHandle src,
            byte closeio,
            AudioSpec* spec,
            byte** audio_buf,
            uint* audio_len
        );

        [NativeName("SDL_LoadWAV_IO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV_IO")]
        static abstract MaybeBool<byte> LoadWavIo(
            IoStreamHandle src,
            MaybeBool<byte> closeio,
            Ref<AudioSpec> spec,
            Ref2D<byte> audio_buf,
            Ref<uint> audio_len
        );

        [NativeName("SDL_LockAudioStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockAudioStream")]
        static abstract MaybeBool<byte> LockAudioStream(AudioStreamHandle stream);

        [NativeName("SDL_LockAudioStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockAudioStream")]
        static abstract byte LockAudioStreamRaw(AudioStreamHandle stream);

        [NativeName("SDL_LockJoysticks")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockJoysticks")]
        static abstract void LockJoysticks();

        [NativeName("SDL_LockMutex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockMutex")]
        static abstract void LockMutex(MutexHandle mutex);

        [NativeName("SDL_LockProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockProperties")]
        static abstract MaybeBool<byte> LockProperties(uint props);

        [NativeName("SDL_LockProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockProperties")]
        static abstract byte LockPropertiesRaw(uint props);

        [NativeName("SDL_LockRWLockForReading")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockRWLockForReading")]
        static abstract void LockRwLockForReading(RwLockHandle rwlock);

        [NativeName("SDL_LockRWLockForWriting")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockRWLockForWriting")]
        static abstract void LockRwLockForWriting(RwLockHandle rwlock);

        [NativeName("SDL_LockSpinlock")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockSpinlock")]
        static abstract void LockSpinlock(int* @lock);

        [NativeName("SDL_LockSpinlock")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockSpinlock")]
        static abstract void LockSpinlock(Ref<int> @lock);

        [NativeName("SDL_LockSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockSurface")]
        static abstract byte LockSurface(Surface* surface);

        [NativeName("SDL_LockSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockSurface")]
        static abstract MaybeBool<byte> LockSurface(Ref<Surface> surface);

        [NativeName("SDL_LockTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockTexture")]
        static abstract byte LockTexture(Texture* texture, Rect* rect, void** pixels, int* pitch);

        [NativeName("SDL_LockTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockTexture")]
        static abstract MaybeBool<byte> LockTexture(
            Ref<Texture> texture,
            Ref<Rect> rect,
            Ref2D pixels,
            Ref<int> pitch
        );

        [NativeName("SDL_LockTextureToSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockTextureToSurface")]
        static abstract byte LockTextureToSurface(Texture* texture, Rect* rect, Surface** surface);

        [NativeName("SDL_LockTextureToSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LockTextureToSurface")]
        static abstract MaybeBool<byte> LockTextureToSurface(
            Ref<Texture> texture,
            Ref<Rect> rect,
            Ref2D<Surface> surface
        );

        [NativeName("SDL_log")]
        [NativeFunction("SDL3", EntryPoint = "SDL_log")]
        static abstract double Log(double x);

        [NativeName("SDL_log10")]
        [NativeFunction("SDL3", EntryPoint = "SDL_log10")]
        static abstract double Log10(double x);

        [NativeName("SDL_log10f")]
        [NativeFunction("SDL3", EntryPoint = "SDL_log10f")]
        static abstract float Log10F(float x);

        [NativeName("SDL_logf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_logf")]
        static abstract float Logf(float x);

        [NativeName("SDL_LogMessageV")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LogMessageV")]
        static abstract void LogMessageV(int category, LogPriority priority, sbyte* fmt, sbyte* ap);

        [NativeName("SDL_LogMessageV")]
        [NativeFunction("SDL3", EntryPoint = "SDL_LogMessageV")]
        static abstract void LogMessageV(
            int category,
            LogPriority priority,
            Ref<sbyte> fmt,
            Ref<sbyte> ap
        );

        [NativeName("SDL_lround")]
        [NativeFunction("SDL3", EntryPoint = "SDL_lround")]
        static abstract int Lround(double x);

        [NativeName("SDL_lroundf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_lroundf")]
        static abstract int Lroundf(float x);

        [NativeName("SDL_ltoa")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ltoa")]
        static abstract sbyte* Ltoa(int value, sbyte* str, int radix);

        [NativeName("SDL_ltoa")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ltoa")]
        static abstract Ptr<sbyte> Ltoa(int value, Ref<sbyte> str, int radix);

        [NativeName("SDL_main")]
        [NativeFunction("SDL3", EntryPoint = "SDL_main")]
        static abstract int Main(int argc, sbyte** argv);

        [NativeName("SDL_main")]
        [NativeFunction("SDL3", EntryPoint = "SDL_main")]
        static abstract int Main(int argc, Ref2D<sbyte> argv);

        [NativeName("SDL_malloc")]
        [NativeFunction("SDL3", EntryPoint = "SDL_malloc")]
        static abstract Ptr Malloc(nuint size);

        [NativeName("SDL_malloc")]
        [NativeFunction("SDL3", EntryPoint = "SDL_malloc")]
        static abstract void* MallocRaw(nuint size);

        [NativeName("SDL_MapGPUTransferBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapGPUTransferBuffer")]
        static abstract void* MapGpuTransferBuffer(
            GpuDeviceHandle device,
            GpuTransferBufferHandle transfer_buffer,
            byte cycle
        );

        [NativeName("SDL_MapGPUTransferBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapGPUTransferBuffer")]
        static abstract Ptr MapGpuTransferBuffer(
            GpuDeviceHandle device,
            GpuTransferBufferHandle transfer_buffer,
            MaybeBool<byte> cycle
        );

        [NativeName("SDL_MapRGB")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapRGB")]
        static abstract uint MapRgb(
            PixelFormatDetails* format,
            Palette* palette,
            byte r,
            byte g,
            byte b
        );

        [NativeName("SDL_MapRGB")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapRGB")]
        static abstract uint MapRgb(
            Ref<PixelFormatDetails> format,
            Ref<Palette> palette,
            byte r,
            byte g,
            byte b
        );

        [NativeName("SDL_MapRGBA")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapRGBA")]
        static abstract uint MapRgba(
            PixelFormatDetails* format,
            Palette* palette,
            byte r,
            byte g,
            byte b,
            byte a
        );

        [NativeName("SDL_MapRGBA")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapRGBA")]
        static abstract uint MapRgba(
            Ref<PixelFormatDetails> format,
            Ref<Palette> palette,
            byte r,
            byte g,
            byte b,
            byte a
        );

        [NativeName("SDL_MapSurfaceRGB")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGB")]
        static abstract uint MapSurfaceRgb(Surface* surface, byte r, byte g, byte b);

        [NativeName("SDL_MapSurfaceRGB")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGB")]
        static abstract uint MapSurfaceRgb(Ref<Surface> surface, byte r, byte g, byte b);

        [NativeName("SDL_MapSurfaceRGBA")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGBA")]
        static abstract uint MapSurfaceRgba(Surface* surface, byte r, byte g, byte b, byte a);

        [NativeName("SDL_MapSurfaceRGBA")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGBA")]
        static abstract uint MapSurfaceRgba(Ref<Surface> surface, byte r, byte g, byte b, byte a);

        [NativeName("SDL_MaximizeWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MaximizeWindow")]
        static abstract MaybeBool<byte> MaximizeWindow(WindowHandle window);

        [NativeName("SDL_MaximizeWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MaximizeWindow")]
        static abstract byte MaximizeWindowRaw(WindowHandle window);

        [NativeName("SDL_memcmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_memcmp")]
        static abstract int Memcmp(void* s1, void* s2, nuint len);

        [NativeName("SDL_memcmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_memcmp")]
        static abstract int Memcmp(Ref s1, Ref s2, nuint len);

        [NativeName("SDL_MemoryBarrierAcquireFunction")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MemoryBarrierAcquireFunction")]
        static abstract void MemoryBarrierAcquireFunction();

        [NativeName("SDL_MemoryBarrierReleaseFunction")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MemoryBarrierReleaseFunction")]
        static abstract void MemoryBarrierReleaseFunction();

        [NativeName("SDL_memset4")]
        [NativeFunction("SDL3", EntryPoint = "SDL_memset4")]
        static abstract void* Memset4(void* dst, uint val, nuint dwords);

        [NativeName("SDL_memset4")]
        [NativeFunction("SDL3", EntryPoint = "SDL_memset4")]
        static abstract Ptr Memset4(Ref dst, uint val, nuint dwords);

        [NativeName("SDL_Metal_CreateView")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Metal_CreateView")]
        static abstract Ptr MetalCreateView(WindowHandle window);

        [NativeName("SDL_Metal_CreateView")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Metal_CreateView")]
        static abstract void* MetalCreateViewRaw(WindowHandle window);

        [NativeName("SDL_Metal_DestroyView")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Metal_DestroyView")]
        static abstract void MetalDestroyView(void* view);

        [NativeName("SDL_Metal_DestroyView")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Metal_DestroyView")]
        static abstract void MetalDestroyView(Ref view);

        [NativeName("SDL_Metal_GetLayer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Metal_GetLayer")]
        static abstract void* MetalGetLayer(void* view);

        [NativeName("SDL_Metal_GetLayer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Metal_GetLayer")]
        static abstract Ptr MetalGetLayer(Ref view);

        [NativeName("SDL_MinimizeWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MinimizeWindow")]
        static abstract MaybeBool<byte> MinimizeWindow(WindowHandle window);

        [NativeName("SDL_MinimizeWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MinimizeWindow")]
        static abstract byte MinimizeWindowRaw(WindowHandle window);

        [NativeName("SDL_MixAudio")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MixAudio")]
        static abstract byte MixAudio(
            byte* dst,
            byte* src,
            AudioFormat format,
            uint len,
            float volume
        );

        [NativeName("SDL_MixAudio")]
        [NativeFunction("SDL3", EntryPoint = "SDL_MixAudio")]
        static abstract MaybeBool<byte> MixAudio(
            Ref<byte> dst,
            Ref<byte> src,
            AudioFormat format,
            uint len,
            float volume
        );

        [NativeName("SDL_modf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_modf")]
        static abstract double Modf(double x, double* y);

        [NativeName("SDL_modf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_modf")]
        static abstract double Modf(double x, Ref<double> y);

        [NativeName("SDL_modff")]
        [NativeFunction("SDL3", EntryPoint = "SDL_modff")]
        static abstract float Modff(float x, float* y);

        [NativeName("SDL_modff")]
        [NativeFunction("SDL3", EntryPoint = "SDL_modff")]
        static abstract float Modff(float x, Ref<float> y);

        [NativeName("SDL_murmur3_32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_murmur3_32")]
        static abstract uint Murmur3X32(void* data, nuint len, uint seed);

        [NativeName("SDL_murmur3_32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_murmur3_32")]
        static abstract uint Murmur3X32(Ref data, nuint len, uint seed);

        [NativeName("SDL_OnApplicationDidEnterBackground")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidEnterBackground")]
        static abstract void OnApplicationDidEnterBackground();

        [NativeName("SDL_OnApplicationDidEnterForeground")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidEnterForeground")]
        static abstract void OnApplicationDidEnterForeground();

        [NativeName("SDL_OnApplicationDidReceiveMemoryWarning")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning")]
        static abstract void OnApplicationDidReceiveMemoryWarning();

        [NativeName("SDL_OnApplicationWillEnterBackground")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillEnterBackground")]
        static abstract void OnApplicationWillEnterBackground();

        [NativeName("SDL_OnApplicationWillEnterForeground")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillEnterForeground")]
        static abstract void OnApplicationWillEnterForeground();

        [NativeName("SDL_OnApplicationWillTerminate")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillTerminate")]
        static abstract void OnApplicationWillTerminate();

        [NativeName("SDL_OpenAudioDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDevice")]
        static abstract uint OpenAudioDevice(uint devid, AudioSpec* spec);

        [NativeName("SDL_OpenAudioDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDevice")]
        static abstract uint OpenAudioDevice(uint devid, Ref<AudioSpec> spec);

        [NativeName("SDL_OpenAudioDeviceStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDeviceStream")]
        static abstract AudioStreamHandle OpenAudioDeviceStream(
            uint devid,
            AudioSpec* spec,
            AudioStreamCallback callback,
            void* userdata
        );

        [NativeName("SDL_OpenAudioDeviceStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDeviceStream")]
        static abstract AudioStreamHandle OpenAudioDeviceStream(
            uint devid,
            Ref<AudioSpec> spec,
            AudioStreamCallback callback,
            Ref userdata
        );

        [NativeName("SDL_OpenCamera")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenCamera")]
        static abstract CameraHandle OpenCamera(uint instance_id, CameraSpec* spec);

        [NativeName("SDL_OpenCamera")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenCamera")]
        static abstract CameraHandle OpenCamera(uint instance_id, Ref<CameraSpec> spec);

        [NativeName("SDL_OpenFileStorage")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenFileStorage")]
        static abstract StorageHandle OpenFileStorage(sbyte* path);

        [NativeName("SDL_OpenFileStorage")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenFileStorage")]
        static abstract StorageHandle OpenFileStorage(Ref<sbyte> path);

        [NativeName("SDL_OpenGamepad")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenGamepad")]
        static abstract GamepadHandle OpenGamepad(uint instance_id);

        [NativeName("SDL_OpenHaptic")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenHaptic")]
        static abstract HapticHandle OpenHaptic(uint instance_id);

        [NativeName("SDL_OpenHapticFromJoystick")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenHapticFromJoystick")]
        static abstract HapticHandle OpenHapticFromJoystick(JoystickHandle joystick);

        [NativeName("SDL_OpenHapticFromMouse")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenHapticFromMouse")]
        static abstract HapticHandle OpenHapticFromMouse();

        [NativeName("SDL_OpenIO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenIO")]
        static abstract IoStreamHandle OpenIo(IoStreamInterface* iface, void* userdata);

        [NativeName("SDL_OpenIO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenIO")]
        static abstract IoStreamHandle OpenIo(Ref<IoStreamInterface> iface, Ref userdata);

        [NativeName("SDL_OpenJoystick")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenJoystick")]
        static abstract JoystickHandle OpenJoystick(uint instance_id);

        [NativeName("SDL_OpenSensor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenSensor")]
        static abstract SensorHandle OpenSensor(uint instance_id);

        [NativeName("SDL_OpenStorage")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenStorage")]
        static abstract StorageHandle OpenStorage(StorageInterface* iface, void* userdata);

        [NativeName("SDL_OpenStorage")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenStorage")]
        static abstract StorageHandle OpenStorage(Ref<StorageInterface> iface, Ref userdata);

        [NativeName("SDL_OpenTitleStorage")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenTitleStorage")]
        static abstract StorageHandle OpenTitleStorage(sbyte* @override, uint props);

        [NativeName("SDL_OpenTitleStorage")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenTitleStorage")]
        static abstract StorageHandle OpenTitleStorage(Ref<sbyte> @override, uint props);

        [NativeName("SDL_OpenURL")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenURL")]
        static abstract byte OpenUrl(sbyte* url);

        [NativeName("SDL_OpenURL")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenURL")]
        static abstract MaybeBool<byte> OpenUrl(Ref<sbyte> url);

        [NativeName("SDL_OpenUserStorage")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenUserStorage")]
        static abstract StorageHandle OpenUserStorage(sbyte* org, sbyte* app, uint props);

        [NativeName("SDL_OpenUserStorage")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OpenUserStorage")]
        static abstract StorageHandle OpenUserStorage(Ref<sbyte> org, Ref<sbyte> app, uint props);

        [NativeName("SDL_OutOfMemory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OutOfMemory")]
        static abstract MaybeBool<byte> OutOfMemory();

        [NativeName("SDL_OutOfMemory")]
        [NativeFunction("SDL3", EntryPoint = "SDL_OutOfMemory")]
        static abstract byte OutOfMemoryRaw();

        [NativeName("SDL_PauseAudioDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioDevice")]
        static abstract MaybeBool<byte> PauseAudioDevice(uint devid);

        [NativeName("SDL_PauseAudioDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioDevice")]
        static abstract byte PauseAudioDeviceRaw(uint devid);

        [NativeName("SDL_PauseAudioStreamDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioStreamDevice")]
        static abstract MaybeBool<byte> PauseAudioStreamDevice(AudioStreamHandle stream);

        [NativeName("SDL_PauseAudioStreamDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioStreamDevice")]
        static abstract byte PauseAudioStreamDeviceRaw(AudioStreamHandle stream);

        [NativeName("SDL_PauseHaptic")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PauseHaptic")]
        static abstract MaybeBool<byte> PauseHaptic(HapticHandle haptic);

        [NativeName("SDL_PauseHaptic")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PauseHaptic")]
        static abstract byte PauseHapticRaw(HapticHandle haptic);

        [NativeName("SDL_PeepEvents")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PeepEvents")]
        static abstract int PeepEvents(
            Event* events,
            int numevents,
            EventAction action,
            uint minType,
            uint maxType
        );

        [NativeName("SDL_PeepEvents")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PeepEvents")]
        static abstract int PeepEvents(
            Ref<Event> events,
            int numevents,
            EventAction action,
            uint minType,
            uint maxType
        );

        [NativeName("SDL_PlayHapticRumble")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PlayHapticRumble")]
        static abstract MaybeBool<byte> PlayHapticRumble(
            HapticHandle haptic,
            float strength,
            uint length
        );

        [NativeName("SDL_PlayHapticRumble")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PlayHapticRumble")]
        static abstract byte PlayHapticRumbleRaw(HapticHandle haptic, float strength, uint length);

        [NativeName("SDL_PollEvent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PollEvent")]
        static abstract byte PollEvent(Event* @event);

        [NativeName("SDL_PollEvent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PollEvent")]
        static abstract MaybeBool<byte> PollEvent(Ref<Event> @event);

        [NativeName("SDL_PopGPUDebugGroup")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PopGPUDebugGroup")]
        static abstract void PopGpuDebugGroup(GpuCommandBufferHandle command_buffer);

        [NativeName("SDL_pow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_pow")]
        static abstract double Pow(double x, double y);

        [NativeName("SDL_powf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_powf")]
        static abstract float Powf(float x, float y);

        [NativeName("SDL_PremultiplyAlpha")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplyAlpha")]
        static abstract byte PremultiplyAlpha(
            int width,
            int height,
            PixelFormat src_format,
            void* src,
            int src_pitch,
            PixelFormat dst_format,
            void* dst,
            int dst_pitch,
            byte linear
        );

        [NativeName("SDL_PremultiplyAlpha")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplyAlpha")]
        static abstract MaybeBool<byte> PremultiplyAlpha(
            int width,
            int height,
            PixelFormat src_format,
            Ref src,
            int src_pitch,
            PixelFormat dst_format,
            Ref dst,
            int dst_pitch,
            MaybeBool<byte> linear
        );

        [NativeName("SDL_PremultiplySurfaceAlpha")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplySurfaceAlpha")]
        static abstract byte PremultiplySurfaceAlpha(Surface* surface, byte linear);

        [NativeName("SDL_PremultiplySurfaceAlpha")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplySurfaceAlpha")]
        static abstract MaybeBool<byte> PremultiplySurfaceAlpha(
            Ref<Surface> surface,
            MaybeBool<byte> linear
        );

        [NativeName("SDL_PumpEvents")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PumpEvents")]
        static abstract void PumpEvents();

        [NativeName("SDL_PushEvent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushEvent")]
        static abstract byte PushEvent(Event* @event);

        [NativeName("SDL_PushEvent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushEvent")]
        static abstract MaybeBool<byte> PushEvent(Ref<Event> @event);

        [NativeName("SDL_PushGPUComputeUniformData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUComputeUniformData")]
        static abstract void PushGpuComputeUniformData(
            GpuCommandBufferHandle command_buffer,
            uint slot_index,
            void* data,
            uint length
        );

        [NativeName("SDL_PushGPUComputeUniformData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUComputeUniformData")]
        static abstract void PushGpuComputeUniformData(
            GpuCommandBufferHandle command_buffer,
            uint slot_index,
            Ref data,
            uint length
        );

        [NativeName("SDL_PushGPUDebugGroup")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUDebugGroup")]
        static abstract void PushGpuDebugGroup(GpuCommandBufferHandle command_buffer, sbyte* name);

        [NativeName("SDL_PushGPUDebugGroup")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUDebugGroup")]
        static abstract void PushGpuDebugGroup(
            GpuCommandBufferHandle command_buffer,
            Ref<sbyte> name
        );

        [NativeName("SDL_PushGPUFragmentUniformData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUFragmentUniformData")]
        static abstract void PushGpuFragmentUniformData(
            GpuCommandBufferHandle command_buffer,
            uint slot_index,
            void* data,
            uint length
        );

        [NativeName("SDL_PushGPUFragmentUniformData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUFragmentUniformData")]
        static abstract void PushGpuFragmentUniformData(
            GpuCommandBufferHandle command_buffer,
            uint slot_index,
            Ref data,
            uint length
        );

        [NativeName("SDL_PushGPUVertexUniformData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUVertexUniformData")]
        static abstract void PushGpuVertexUniformData(
            GpuCommandBufferHandle command_buffer,
            uint slot_index,
            void* data,
            uint length
        );

        [NativeName("SDL_PushGPUVertexUniformData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUVertexUniformData")]
        static abstract void PushGpuVertexUniformData(
            GpuCommandBufferHandle command_buffer,
            uint slot_index,
            Ref data,
            uint length
        );

        [NativeName("SDL_PutAudioStreamData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PutAudioStreamData")]
        static abstract byte PutAudioStreamData(AudioStreamHandle stream, void* buf, int len);

        [NativeName("SDL_PutAudioStreamData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_PutAudioStreamData")]
        static abstract MaybeBool<byte> PutAudioStreamData(
            AudioStreamHandle stream,
            Ref buf,
            int len
        );

        [NativeName("SDL_qsort")]
        [NativeFunction("SDL3", EntryPoint = "SDL_qsort")]
        static abstract void Qsort(void* @base, nuint nmemb, nuint size, CompareCallback compare);

        [NativeName("SDL_qsort")]
        [NativeFunction("SDL3", EntryPoint = "SDL_qsort")]
        static abstract void Qsort(Ref @base, nuint nmemb, nuint size, CompareCallback compare);

        [NativeName("SDL_qsort_r")]
        [NativeFunction("SDL3", EntryPoint = "SDL_qsort_r")]
        static abstract void QsortR(
            void* @base,
            nuint nmemb,
            nuint size,
            CompareCallbackR compare,
            void* userdata
        );

        [NativeName("SDL_qsort_r")]
        [NativeFunction("SDL3", EntryPoint = "SDL_qsort_r")]
        static abstract void QsortR(
            Ref @base,
            nuint nmemb,
            nuint size,
            CompareCallbackR compare,
            Ref userdata
        );

        [NativeName("SDL_QueryGPUFence")]
        [NativeFunction("SDL3", EntryPoint = "SDL_QueryGPUFence")]
        static abstract MaybeBool<byte> QueryGpuFence(GpuDeviceHandle device, GpuFenceHandle fence);

        [NativeName("SDL_QueryGPUFence")]
        [NativeFunction("SDL3", EntryPoint = "SDL_QueryGPUFence")]
        static abstract byte QueryGpuFenceRaw(GpuDeviceHandle device, GpuFenceHandle fence);

        [NativeName("SDL_Quit")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Quit")]
        static abstract void Quit();

        [NativeName("SDL_QuitSubSystem")]
        [NativeFunction("SDL3", EntryPoint = "SDL_QuitSubSystem")]
        static abstract void QuitSubSystem(uint flags);

        [NativeName("SDL_RaiseWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RaiseWindow")]
        static abstract MaybeBool<byte> RaiseWindow(WindowHandle window);

        [NativeName("SDL_RaiseWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RaiseWindow")]
        static abstract byte RaiseWindowRaw(WindowHandle window);

        [NativeName("SDL_rand")]
        [NativeFunction("SDL3", EntryPoint = "SDL_rand")]
        static abstract int Rand(int n);

        [NativeName("SDL_rand_bits")]
        [NativeFunction("SDL3", EntryPoint = "SDL_rand_bits")]
        static abstract uint RandBits();

        [NativeName("SDL_rand_bits_r")]
        [NativeFunction("SDL3", EntryPoint = "SDL_rand_bits_r")]
        static abstract uint RandBitsR(ulong* state);

        [NativeName("SDL_rand_bits_r")]
        [NativeFunction("SDL3", EntryPoint = "SDL_rand_bits_r")]
        static abstract uint RandBitsR(Ref<ulong> state);

        [NativeName("SDL_rand_r")]
        [NativeFunction("SDL3", EntryPoint = "SDL_rand_r")]
        static abstract int RandR(ulong* state, int n);

        [NativeName("SDL_rand_r")]
        [NativeFunction("SDL3", EntryPoint = "SDL_rand_r")]
        static abstract int RandR(Ref<ulong> state, int n);

        [NativeName("SDL_randf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_randf")]
        static abstract float Randf();

        [NativeName("SDL_randf_r")]
        [NativeFunction("SDL3", EntryPoint = "SDL_randf_r")]
        static abstract float RandfR(ulong* state);

        [NativeName("SDL_randf_r")]
        [NativeFunction("SDL3", EntryPoint = "SDL_randf_r")]
        static abstract float RandfR(Ref<ulong> state);

        [NativeName("SDL_ReadIO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadIO")]
        static abstract nuint ReadIo(IoStreamHandle context, void* ptr, nuint size);

        [NativeName("SDL_ReadIO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadIO")]
        static abstract nuint ReadIo(IoStreamHandle context, Ref ptr, nuint size);

        [NativeName("SDL_ReadProcess")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadProcess")]
        static abstract void* ReadProcess(ProcessHandle process, nuint* datasize, int* exitcode);

        [NativeName("SDL_ReadProcess")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadProcess")]
        static abstract Ptr ReadProcess(
            ProcessHandle process,
            Ref<nuint> datasize,
            Ref<int> exitcode
        );

        [NativeName("SDL_ReadS16BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16BE")]
        static abstract byte ReadS16Be(IoStreamHandle src, short* value);

        [NativeName("SDL_ReadS16BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16BE")]
        static abstract MaybeBool<byte> ReadS16Be(IoStreamHandle src, Ref<short> value);

        [NativeName("SDL_ReadS16LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16LE")]
        static abstract byte ReadS16Le(IoStreamHandle src, short* value);

        [NativeName("SDL_ReadS16LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16LE")]
        static abstract MaybeBool<byte> ReadS16Le(IoStreamHandle src, Ref<short> value);

        [NativeName("SDL_ReadS32BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32BE")]
        static abstract byte ReadS32Be(IoStreamHandle src, int* value);

        [NativeName("SDL_ReadS32BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32BE")]
        static abstract MaybeBool<byte> ReadS32Be(IoStreamHandle src, Ref<int> value);

        [NativeName("SDL_ReadS32LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32LE")]
        static abstract byte ReadS32Le(IoStreamHandle src, int* value);

        [NativeName("SDL_ReadS32LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32LE")]
        static abstract MaybeBool<byte> ReadS32Le(IoStreamHandle src, Ref<int> value);

        [NativeName("SDL_ReadS64BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64BE")]
        static abstract byte ReadS64Be(IoStreamHandle src, long* value);

        [NativeName("SDL_ReadS64BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64BE")]
        static abstract MaybeBool<byte> ReadS64Be(IoStreamHandle src, Ref<long> value);

        [NativeName("SDL_ReadS64LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64LE")]
        static abstract byte ReadS64Le(IoStreamHandle src, long* value);

        [NativeName("SDL_ReadS64LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64LE")]
        static abstract MaybeBool<byte> ReadS64Le(IoStreamHandle src, Ref<long> value);

        [NativeName("SDL_ReadS8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS8")]
        static abstract byte ReadS8(IoStreamHandle src, sbyte* value);

        [NativeName("SDL_ReadS8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadS8")]
        static abstract MaybeBool<byte> ReadS8(IoStreamHandle src, Ref<sbyte> value);

        [NativeName("SDL_ReadStorageFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadStorageFile")]
        static abstract byte ReadStorageFile(
            StorageHandle storage,
            sbyte* path,
            void* destination,
            ulong length
        );

        [NativeName("SDL_ReadStorageFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadStorageFile")]
        static abstract MaybeBool<byte> ReadStorageFile(
            StorageHandle storage,
            Ref<sbyte> path,
            Ref destination,
            ulong length
        );

        [NativeName("SDL_ReadSurfacePixel")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixel")]
        static abstract byte ReadSurfacePixel(
            Surface* surface,
            int x,
            int y,
            byte* r,
            byte* g,
            byte* b,
            byte* a
        );

        [NativeName("SDL_ReadSurfacePixel")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixel")]
        static abstract MaybeBool<byte> ReadSurfacePixel(
            Ref<Surface> surface,
            int x,
            int y,
            Ref<byte> r,
            Ref<byte> g,
            Ref<byte> b,
            Ref<byte> a
        );

        [NativeName("SDL_ReadSurfacePixelFloat")]
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

        [NativeName("SDL_ReadSurfacePixelFloat")]
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

        [NativeName("SDL_ReadU16BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16BE")]
        static abstract byte ReadU16Be(IoStreamHandle src, ushort* value);

        [NativeName("SDL_ReadU16BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16BE")]
        static abstract MaybeBool<byte> ReadU16Be(IoStreamHandle src, Ref<ushort> value);

        [NativeName("SDL_ReadU16LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16LE")]
        static abstract byte ReadU16Le(IoStreamHandle src, ushort* value);

        [NativeName("SDL_ReadU16LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16LE")]
        static abstract MaybeBool<byte> ReadU16Le(IoStreamHandle src, Ref<ushort> value);

        [NativeName("SDL_ReadU32BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32BE")]
        static abstract byte ReadU32Be(IoStreamHandle src, uint* value);

        [NativeName("SDL_ReadU32BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32BE")]
        static abstract MaybeBool<byte> ReadU32Be(IoStreamHandle src, Ref<uint> value);

        [NativeName("SDL_ReadU32LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32LE")]
        static abstract byte ReadU32Le(IoStreamHandle src, uint* value);

        [NativeName("SDL_ReadU32LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32LE")]
        static abstract MaybeBool<byte> ReadU32Le(IoStreamHandle src, Ref<uint> value);

        [NativeName("SDL_ReadU64BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64BE")]
        static abstract byte ReadU64Be(IoStreamHandle src, ulong* value);

        [NativeName("SDL_ReadU64BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64BE")]
        static abstract MaybeBool<byte> ReadU64Be(IoStreamHandle src, Ref<ulong> value);

        [NativeName("SDL_ReadU64LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64LE")]
        static abstract byte ReadU64Le(IoStreamHandle src, ulong* value);

        [NativeName("SDL_ReadU64LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64LE")]
        static abstract MaybeBool<byte> ReadU64Le(IoStreamHandle src, Ref<ulong> value);

        [NativeName("SDL_ReadU8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU8")]
        static abstract byte ReadU8(IoStreamHandle src, byte* value);

        [NativeName("SDL_ReadU8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReadU8")]
        static abstract MaybeBool<byte> ReadU8(IoStreamHandle src, Ref<byte> value);

        [NativeName("SDL_realloc")]
        [NativeFunction("SDL3", EntryPoint = "SDL_realloc")]
        static abstract void* Realloc(void* mem, nuint size);

        [NativeName("SDL_realloc")]
        [NativeFunction("SDL3", EntryPoint = "SDL_realloc")]
        static abstract Ptr Realloc(Ref mem, nuint size);

        [NativeName("SDL_RegisterApp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RegisterApp")]
        static abstract byte RegisterApp(sbyte* name, uint style, void* hInst);

        [NativeName("SDL_RegisterApp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RegisterApp")]
        static abstract MaybeBool<byte> RegisterApp(Ref<sbyte> name, uint style, Ref hInst);

        [NativeName("SDL_RegisterEvents")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RegisterEvents")]
        static abstract uint RegisterEvents(int numevents);

        [NativeName("SDL_ReleaseCameraFrame")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseCameraFrame")]
        static abstract void ReleaseCameraFrame(CameraHandle camera, Surface* frame);

        [NativeName("SDL_ReleaseCameraFrame")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseCameraFrame")]
        static abstract void ReleaseCameraFrame(CameraHandle camera, Ref<Surface> frame);

        [NativeName("SDL_ReleaseGPUBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUBuffer")]
        static abstract void ReleaseGpuBuffer(GpuDeviceHandle device, GpuBufferHandle buffer);

        [NativeName("SDL_ReleaseGPUComputePipeline")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUComputePipeline")]
        static abstract void ReleaseGpuComputePipeline(
            GpuDeviceHandle device,
            GpuComputePipelineHandle compute_pipeline
        );

        [NativeName("SDL_ReleaseGPUFence")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUFence")]
        static abstract void ReleaseGpuFence(GpuDeviceHandle device, GpuFenceHandle fence);

        [NativeName("SDL_ReleaseGPUGraphicsPipeline")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUGraphicsPipeline")]
        static abstract void ReleaseGpuGraphicsPipeline(
            GpuDeviceHandle device,
            GpuGraphicsPipelineHandle graphics_pipeline
        );

        [NativeName("SDL_ReleaseGPUSampler")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUSampler")]
        static abstract void ReleaseGpuSampler(GpuDeviceHandle device, GpuSamplerHandle sampler);

        [NativeName("SDL_ReleaseGPUShader")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUShader")]
        static abstract void ReleaseGpuShader(GpuDeviceHandle device, GpuShaderHandle shader);

        [NativeName("SDL_ReleaseGPUTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUTexture")]
        static abstract void ReleaseGpuTexture(GpuDeviceHandle device, GpuTextureHandle texture);

        [NativeName("SDL_ReleaseGPUTransferBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUTransferBuffer")]
        static abstract void ReleaseGpuTransferBuffer(
            GpuDeviceHandle device,
            GpuTransferBufferHandle transfer_buffer
        );

        [NativeName("SDL_ReleaseWindowFromGPUDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseWindowFromGPUDevice")]
        static abstract void ReleaseWindowFromGpuDevice(
            GpuDeviceHandle device,
            WindowHandle window
        );

        [NativeName("SDL_ReloadGamepadMappings")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReloadGamepadMappings")]
        static abstract MaybeBool<byte> ReloadGamepadMappings();

        [NativeName("SDL_ReloadGamepadMappings")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReloadGamepadMappings")]
        static abstract byte ReloadGamepadMappingsRaw();

        [NativeName("SDL_RemoveEventWatch")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveEventWatch")]
        static abstract void RemoveEventWatch(EventFilter filter, void* userdata);

        [NativeName("SDL_RemoveEventWatch")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveEventWatch")]
        static abstract void RemoveEventWatch(EventFilter filter, Ref userdata);

        [NativeName("SDL_RemoveHintCallback")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveHintCallback")]
        static abstract void RemoveHintCallback(sbyte* name, HintCallback callback, void* userdata);

        [NativeName("SDL_RemoveHintCallback")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveHintCallback")]
        static abstract void RemoveHintCallback(
            Ref<sbyte> name,
            HintCallback callback,
            Ref userdata
        );

        [NativeName("SDL_RemovePath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemovePath")]
        static abstract byte RemovePath(sbyte* path);

        [NativeName("SDL_RemovePath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemovePath")]
        static abstract MaybeBool<byte> RemovePath(Ref<sbyte> path);

        [NativeName("SDL_RemoveStoragePath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveStoragePath")]
        static abstract byte RemoveStoragePath(StorageHandle storage, sbyte* path);

        [NativeName("SDL_RemoveStoragePath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveStoragePath")]
        static abstract MaybeBool<byte> RemoveStoragePath(StorageHandle storage, Ref<sbyte> path);

        [NativeName("SDL_RemoveSurfaceAlternateImages")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveSurfaceAlternateImages")]
        static abstract void RemoveSurfaceAlternateImages(Surface* surface);

        [NativeName("SDL_RemoveSurfaceAlternateImages")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveSurfaceAlternateImages")]
        static abstract void RemoveSurfaceAlternateImages(Ref<Surface> surface);

        [NativeName("SDL_RemoveTimer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveTimer")]
        static abstract MaybeBool<byte> RemoveTimer(uint id);

        [NativeName("SDL_RemoveTimer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RemoveTimer")]
        static abstract byte RemoveTimerRaw(uint id);

        [NativeName("SDL_RenamePath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenamePath")]
        static abstract byte RenamePath(sbyte* oldpath, sbyte* newpath);

        [NativeName("SDL_RenamePath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenamePath")]
        static abstract MaybeBool<byte> RenamePath(Ref<sbyte> oldpath, Ref<sbyte> newpath);

        [NativeName("SDL_RenameStoragePath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenameStoragePath")]
        static abstract byte RenameStoragePath(
            StorageHandle storage,
            sbyte* oldpath,
            sbyte* newpath
        );

        [NativeName("SDL_RenameStoragePath")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenameStoragePath")]
        static abstract MaybeBool<byte> RenameStoragePath(
            StorageHandle storage,
            Ref<sbyte> oldpath,
            Ref<sbyte> newpath
        );

        [NativeName("SDL_RenderClear")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderClear")]
        static abstract MaybeBool<byte> RenderClear(RendererHandle renderer);

        [NativeName("SDL_RenderClear")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderClear")]
        static abstract byte RenderClearRaw(RendererHandle renderer);

        [NativeName("SDL_RenderClipEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderClipEnabled")]
        static abstract MaybeBool<byte> RenderClipEnabled(RendererHandle renderer);

        [NativeName("SDL_RenderClipEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderClipEnabled")]
        static abstract byte RenderClipEnabledRaw(RendererHandle renderer);

        [NativeName("SDL_RenderCoordinatesFromWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesFromWindow")]
        static abstract byte RenderCoordinatesFromWindow(
            RendererHandle renderer,
            float window_x,
            float window_y,
            float* x,
            float* y
        );

        [NativeName("SDL_RenderCoordinatesFromWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesFromWindow")]
        static abstract MaybeBool<byte> RenderCoordinatesFromWindow(
            RendererHandle renderer,
            float window_x,
            float window_y,
            Ref<float> x,
            Ref<float> y
        );

        [NativeName("SDL_RenderCoordinatesToWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesToWindow")]
        static abstract byte RenderCoordinatesToWindow(
            RendererHandle renderer,
            float x,
            float y,
            float* window_x,
            float* window_y
        );

        [NativeName("SDL_RenderCoordinatesToWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesToWindow")]
        static abstract MaybeBool<byte> RenderCoordinatesToWindow(
            RendererHandle renderer,
            float x,
            float y,
            Ref<float> window_x,
            Ref<float> window_y
        );

        [NativeName("SDL_RenderDebugText")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderDebugText")]
        static abstract byte RenderDebugText(RendererHandle renderer, float x, float y, sbyte* str);

        [NativeName("SDL_RenderDebugText")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderDebugText")]
        static abstract MaybeBool<byte> RenderDebugText(
            RendererHandle renderer,
            float x,
            float y,
            Ref<sbyte> str
        );

        [NativeName("SDL_RenderFillRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRect")]
        static abstract byte RenderFillRect(RendererHandle renderer, FRect* rect);

        [NativeName("SDL_RenderFillRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRect")]
        static abstract MaybeBool<byte> RenderFillRect(RendererHandle renderer, Ref<FRect> rect);

        [NativeName("SDL_RenderFillRects")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRects")]
        static abstract byte RenderFillRects(RendererHandle renderer, FRect* rects, int count);

        [NativeName("SDL_RenderFillRects")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRects")]
        static abstract MaybeBool<byte> RenderFillRects(
            RendererHandle renderer,
            Ref<FRect> rects,
            int count
        );

        [NativeName("SDL_RenderGeometry")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometry")]
        static abstract byte RenderGeometry(
            RendererHandle renderer,
            Texture* texture,
            Vertex* vertices,
            int num_vertices,
            int* indices,
            int num_indices
        );

        [NativeName("SDL_RenderGeometry")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometry")]
        static abstract MaybeBool<byte> RenderGeometry(
            RendererHandle renderer,
            Ref<Texture> texture,
            Ref<Vertex> vertices,
            int num_vertices,
            Ref<int> indices,
            int num_indices
        );

        [NativeName("SDL_RenderGeometryRaw")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRaw")]
        static abstract byte RenderGeometryRaw(
            RendererHandle renderer,
            Texture* texture,
            float* xy,
            int xy_stride,
            FColor* color,
            int color_stride,
            float* uv,
            int uv_stride,
            int num_vertices,
            void* indices,
            int num_indices,
            int size_indices
        );

        [NativeName("SDL_RenderGeometryRaw")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRaw")]
        static abstract MaybeBool<byte> RenderGeometryRaw(
            RendererHandle renderer,
            Ref<Texture> texture,
            Ref<float> xy,
            int xy_stride,
            Ref<FColor> color,
            int color_stride,
            Ref<float> uv,
            int uv_stride,
            int num_vertices,
            Ref indices,
            int num_indices,
            int size_indices
        );

        [NativeName("SDL_RenderLine")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderLine")]
        static abstract MaybeBool<byte> RenderLine(
            RendererHandle renderer,
            float x1,
            float y1,
            float x2,
            float y2
        );

        [NativeName("SDL_RenderLine")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderLine")]
        static abstract byte RenderLineRaw(
            RendererHandle renderer,
            float x1,
            float y1,
            float x2,
            float y2
        );

        [NativeName("SDL_RenderLines")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderLines")]
        static abstract byte RenderLines(RendererHandle renderer, FPoint* points, int count);

        [NativeName("SDL_RenderLines")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderLines")]
        static abstract MaybeBool<byte> RenderLines(
            RendererHandle renderer,
            Ref<FPoint> points,
            int count
        );

        [NativeName("SDL_RenderPoint")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoint")]
        static abstract MaybeBool<byte> RenderPoint(RendererHandle renderer, float x, float y);

        [NativeName("SDL_RenderPoint")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoint")]
        static abstract byte RenderPointRaw(RendererHandle renderer, float x, float y);

        [NativeName("SDL_RenderPoints")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoints")]
        static abstract byte RenderPoints(RendererHandle renderer, FPoint* points, int count);

        [NativeName("SDL_RenderPoints")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoints")]
        static abstract MaybeBool<byte> RenderPoints(
            RendererHandle renderer,
            Ref<FPoint> points,
            int count
        );

        [NativeName("SDL_RenderPresent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPresent")]
        static abstract MaybeBool<byte> RenderPresent(RendererHandle renderer);

        [NativeName("SDL_RenderPresent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderPresent")]
        static abstract byte RenderPresentRaw(RendererHandle renderer);

        [NativeName("SDL_RenderReadPixels")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderReadPixels")]
        static abstract Surface* RenderReadPixels(RendererHandle renderer, Rect* rect);

        [NativeName("SDL_RenderReadPixels")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderReadPixels")]
        static abstract Ptr<Surface> RenderReadPixels(RendererHandle renderer, Ref<Rect> rect);

        [NativeName("SDL_RenderRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderRect")]
        static abstract byte RenderRect(RendererHandle renderer, FRect* rect);

        [NativeName("SDL_RenderRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderRect")]
        static abstract MaybeBool<byte> RenderRect(RendererHandle renderer, Ref<FRect> rect);

        [NativeName("SDL_RenderRects")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderRects")]
        static abstract byte RenderRects(RendererHandle renderer, FRect* rects, int count);

        [NativeName("SDL_RenderRects")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderRects")]
        static abstract MaybeBool<byte> RenderRects(
            RendererHandle renderer,
            Ref<FRect> rects,
            int count
        );

        [NativeName("SDL_RenderTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture")]
        static abstract byte RenderTexture(
            RendererHandle renderer,
            Texture* texture,
            FRect* srcrect,
            FRect* dstrect
        );

        [NativeName("SDL_RenderTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture")]
        static abstract MaybeBool<byte> RenderTexture(
            RendererHandle renderer,
            Ref<Texture> texture,
            Ref<FRect> srcrect,
            Ref<FRect> dstrect
        );

        [NativeName("SDL_RenderTexture9Grid")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture9Grid")]
        static abstract byte RenderTexture9Grid(
            RendererHandle renderer,
            Texture* texture,
            FRect* srcrect,
            float left_width,
            float right_width,
            float top_height,
            float bottom_height,
            float scale,
            FRect* dstrect
        );

        [NativeName("SDL_RenderTexture9Grid")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture9Grid")]
        static abstract MaybeBool<byte> RenderTexture9Grid(
            RendererHandle renderer,
            Ref<Texture> texture,
            Ref<FRect> srcrect,
            float left_width,
            float right_width,
            float top_height,
            float bottom_height,
            float scale,
            Ref<FRect> dstrect
        );

        [NativeName("SDL_RenderTextureAffine")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureAffine")]
        static abstract byte RenderTextureAffine(
            RendererHandle renderer,
            Texture* texture,
            FRect* srcrect,
            FPoint* origin,
            FPoint* right,
            FPoint* down
        );

        [NativeName("SDL_RenderTextureAffine")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureAffine")]
        static abstract MaybeBool<byte> RenderTextureAffine(
            RendererHandle renderer,
            Ref<Texture> texture,
            Ref<FRect> srcrect,
            Ref<FPoint> origin,
            Ref<FPoint> right,
            Ref<FPoint> down
        );

        [NativeName("SDL_RenderTextureRotated")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureRotated")]
        static abstract byte RenderTextureRotated(
            RendererHandle renderer,
            Texture* texture,
            FRect* srcrect,
            FRect* dstrect,
            double angle,
            FPoint* center,
            FlipMode flip
        );

        [NativeName("SDL_RenderTextureRotated")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureRotated")]
        static abstract MaybeBool<byte> RenderTextureRotated(
            RendererHandle renderer,
            Ref<Texture> texture,
            Ref<FRect> srcrect,
            Ref<FRect> dstrect,
            double angle,
            Ref<FPoint> center,
            FlipMode flip
        );

        [NativeName("SDL_RenderTextureTiled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureTiled")]
        static abstract byte RenderTextureTiled(
            RendererHandle renderer,
            Texture* texture,
            FRect* srcrect,
            float scale,
            FRect* dstrect
        );

        [NativeName("SDL_RenderTextureTiled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureTiled")]
        static abstract MaybeBool<byte> RenderTextureTiled(
            RendererHandle renderer,
            Ref<Texture> texture,
            Ref<FRect> srcrect,
            float scale,
            Ref<FRect> dstrect
        );

        [NativeName("SDL_RenderViewportSet")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderViewportSet")]
        static abstract MaybeBool<byte> RenderViewportSet(RendererHandle renderer);

        [NativeName("SDL_RenderViewportSet")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RenderViewportSet")]
        static abstract byte RenderViewportSetRaw(RendererHandle renderer);

        [NativeName("SDL_ReportAssertion")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReportAssertion")]
        static abstract AssertState ReportAssertion(
            AssertData* data,
            sbyte* func,
            sbyte* file,
            int line
        );

        [NativeName("SDL_ReportAssertion")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ReportAssertion")]
        static abstract AssertState ReportAssertion(
            Ref<AssertData> data,
            Ref<sbyte> func,
            Ref<sbyte> file,
            int line
        );

        [NativeName("SDL_ResetAssertionReport")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResetAssertionReport")]
        static abstract void ResetAssertionReport();

        [NativeName("SDL_ResetHint")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResetHint")]
        static abstract byte ResetHint(sbyte* name);

        [NativeName("SDL_ResetHint")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResetHint")]
        static abstract MaybeBool<byte> ResetHint(Ref<sbyte> name);

        [NativeName("SDL_ResetHints")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResetHints")]
        static abstract void ResetHints();

        [NativeName("SDL_ResetKeyboard")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResetKeyboard")]
        static abstract void ResetKeyboard();

        [NativeName("SDL_ResetLogPriorities")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResetLogPriorities")]
        static abstract void ResetLogPriorities();

        [NativeName("SDL_RestoreWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RestoreWindow")]
        static abstract MaybeBool<byte> RestoreWindow(WindowHandle window);

        [NativeName("SDL_RestoreWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RestoreWindow")]
        static abstract byte RestoreWindowRaw(WindowHandle window);

        [NativeName("SDL_ResumeAudioDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioDevice")]
        static abstract MaybeBool<byte> ResumeAudioDevice(uint devid);

        [NativeName("SDL_ResumeAudioDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioDevice")]
        static abstract byte ResumeAudioDeviceRaw(uint devid);

        [NativeName("SDL_ResumeAudioStreamDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioStreamDevice")]
        static abstract MaybeBool<byte> ResumeAudioStreamDevice(AudioStreamHandle stream);

        [NativeName("SDL_ResumeAudioStreamDevice")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioStreamDevice")]
        static abstract byte ResumeAudioStreamDeviceRaw(AudioStreamHandle stream);

        [NativeName("SDL_ResumeHaptic")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResumeHaptic")]
        static abstract MaybeBool<byte> ResumeHaptic(HapticHandle haptic);

        [NativeName("SDL_ResumeHaptic")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ResumeHaptic")]
        static abstract byte ResumeHapticRaw(HapticHandle haptic);

        [NativeName("SDL_round")]
        [NativeFunction("SDL3", EntryPoint = "SDL_round")]
        static abstract double Round(double x);

        [NativeName("SDL_roundf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_roundf")]
        static abstract float Roundf(float x);

        [NativeName("SDL_RumbleGamepad")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepad")]
        static abstract MaybeBool<byte> RumbleGamepad(
            GamepadHandle gamepad,
            ushort low_frequency_rumble,
            ushort high_frequency_rumble,
            uint duration_ms
        );

        [NativeName("SDL_RumbleGamepad")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepad")]
        static abstract byte RumbleGamepadRaw(
            GamepadHandle gamepad,
            ushort low_frequency_rumble,
            ushort high_frequency_rumble,
            uint duration_ms
        );

        [NativeName("SDL_RumbleGamepadTriggers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepadTriggers")]
        static abstract MaybeBool<byte> RumbleGamepadTriggers(
            GamepadHandle gamepad,
            ushort left_rumble,
            ushort right_rumble,
            uint duration_ms
        );

        [NativeName("SDL_RumbleGamepadTriggers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepadTriggers")]
        static abstract byte RumbleGamepadTriggersRaw(
            GamepadHandle gamepad,
            ushort left_rumble,
            ushort right_rumble,
            uint duration_ms
        );

        [NativeName("SDL_RumbleJoystick")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystick")]
        static abstract MaybeBool<byte> RumbleJoystick(
            JoystickHandle joystick,
            ushort low_frequency_rumble,
            ushort high_frequency_rumble,
            uint duration_ms
        );

        [NativeName("SDL_RumbleJoystick")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystick")]
        static abstract byte RumbleJoystickRaw(
            JoystickHandle joystick,
            ushort low_frequency_rumble,
            ushort high_frequency_rumble,
            uint duration_ms
        );

        [NativeName("SDL_RumbleJoystickTriggers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystickTriggers")]
        static abstract MaybeBool<byte> RumbleJoystickTriggers(
            JoystickHandle joystick,
            ushort left_rumble,
            ushort right_rumble,
            uint duration_ms
        );

        [NativeName("SDL_RumbleJoystickTriggers")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystickTriggers")]
        static abstract byte RumbleJoystickTriggersRaw(
            JoystickHandle joystick,
            ushort left_rumble,
            ushort right_rumble,
            uint duration_ms
        );

        [NativeName("SDL_RunApp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RunApp")]
        static abstract int RunApp(int argc, sbyte** argv, MainFunc mainFunction, void* reserved);

        [NativeName("SDL_RunApp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RunApp")]
        static abstract int RunApp(
            int argc,
            Ref2D<sbyte> argv,
            MainFunc mainFunction,
            Ref reserved
        );

        [NativeName("SDL_RunHapticEffect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RunHapticEffect")]
        static abstract MaybeBool<byte> RunHapticEffect(
            HapticHandle haptic,
            int effect,
            uint iterations
        );

        [NativeName("SDL_RunHapticEffect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RunHapticEffect")]
        static abstract byte RunHapticEffectRaw(HapticHandle haptic, int effect, uint iterations);

        [NativeName("SDL_RunOnMainThread")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RunOnMainThread")]
        static abstract byte RunOnMainThread(
            MainThreadCallback callback,
            void* userdata,
            byte wait_complete
        );

        [NativeName("SDL_RunOnMainThread")]
        [NativeFunction("SDL3", EntryPoint = "SDL_RunOnMainThread")]
        static abstract MaybeBool<byte> RunOnMainThread(
            MainThreadCallback callback,
            Ref userdata,
            MaybeBool<byte> wait_complete
        );

        [NativeName("SDL_SaveBMP")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP")]
        static abstract byte SaveBmp(Surface* surface, sbyte* file);

        [NativeName("SDL_SaveBMP")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP")]
        static abstract MaybeBool<byte> SaveBmp(Ref<Surface> surface, Ref<sbyte> file);

        [NativeName("SDL_SaveBMP_IO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP_IO")]
        static abstract byte SaveBmpIo(Surface* surface, IoStreamHandle dst, byte closeio);

        [NativeName("SDL_SaveBMP_IO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP_IO")]
        static abstract MaybeBool<byte> SaveBmpIo(
            Ref<Surface> surface,
            IoStreamHandle dst,
            MaybeBool<byte> closeio
        );

        [NativeName("SDL_SaveFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile")]
        static abstract byte SaveFile(sbyte* file, void* data, nuint datasize);

        [NativeName("SDL_SaveFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile")]
        static abstract MaybeBool<byte> SaveFile(Ref<sbyte> file, Ref data, nuint datasize);

        [NativeName("SDL_SaveFile_IO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile_IO")]
        static abstract byte SaveFileIo(
            IoStreamHandle src,
            void* data,
            nuint datasize,
            byte closeio
        );

        [NativeName("SDL_SaveFile_IO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile_IO")]
        static abstract MaybeBool<byte> SaveFileIo(
            IoStreamHandle src,
            Ref data,
            nuint datasize,
            MaybeBool<byte> closeio
        );

        [NativeName("SDL_scalbn")]
        [NativeFunction("SDL3", EntryPoint = "SDL_scalbn")]
        static abstract double Scalbn(double x, int n);

        [NativeName("SDL_scalbnf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_scalbnf")]
        static abstract float Scalbnf(float x, int n);

        [NativeName("SDL_ScaleSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScaleSurface")]
        static abstract Surface* ScaleSurface(
            Surface* surface,
            int width,
            int height,
            ScaleMode scaleMode
        );

        [NativeName("SDL_ScaleSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScaleSurface")]
        static abstract Ptr<Surface> ScaleSurface(
            Ref<Surface> surface,
            int width,
            int height,
            ScaleMode scaleMode
        );

        [NativeName("SDL_ScreenKeyboardShown")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScreenKeyboardShown")]
        static abstract MaybeBool<byte> ScreenKeyboardShown(WindowHandle window);

        [NativeName("SDL_ScreenKeyboardShown")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScreenKeyboardShown")]
        static abstract byte ScreenKeyboardShownRaw(WindowHandle window);

        [NativeName("SDL_ScreenSaverEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScreenSaverEnabled")]
        static abstract MaybeBool<byte> ScreenSaverEnabled();

        [NativeName("SDL_ScreenSaverEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ScreenSaverEnabled")]
        static abstract byte ScreenSaverEnabledRaw();

        [NativeName("SDL_SeekIO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SeekIO")]
        static abstract long SeekIo(IoStreamHandle context, long offset, IoWhence whence);

        [NativeName("SDL_SendGamepadEffect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SendGamepadEffect")]
        static abstract byte SendGamepadEffect(GamepadHandle gamepad, void* data, int size);

        [NativeName("SDL_SendGamepadEffect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SendGamepadEffect")]
        static abstract MaybeBool<byte> SendGamepadEffect(
            GamepadHandle gamepad,
            Ref data,
            int size
        );

        [NativeName("SDL_SendJoystickEffect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickEffect")]
        static abstract byte SendJoystickEffect(JoystickHandle joystick, void* data, int size);

        [NativeName("SDL_SendJoystickEffect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickEffect")]
        static abstract MaybeBool<byte> SendJoystickEffect(
            JoystickHandle joystick,
            Ref data,
            int size
        );

        [NativeName("SDL_SendJoystickVirtualSensorData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickVirtualSensorData")]
        static abstract byte SendJoystickVirtualSensorData(
            JoystickHandle joystick,
            SensorType type,
            ulong sensor_timestamp,
            float* data,
            int num_values
        );

        [NativeName("SDL_SendJoystickVirtualSensorData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickVirtualSensorData")]
        static abstract MaybeBool<byte> SendJoystickVirtualSensorData(
            JoystickHandle joystick,
            SensorType type,
            ulong sensor_timestamp,
            Ref<float> data,
            int num_values
        );

        [NativeName("SDL_SetAppMetadata")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadata")]
        static abstract byte SetAppMetadata(
            sbyte* appname,
            sbyte* appversion,
            sbyte* appidentifier
        );

        [NativeName("SDL_SetAppMetadata")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadata")]
        static abstract MaybeBool<byte> SetAppMetadata(
            Ref<sbyte> appname,
            Ref<sbyte> appversion,
            Ref<sbyte> appidentifier
        );

        [NativeName("SDL_SetAppMetadataProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadataProperty")]
        static abstract byte SetAppMetadataProperty(sbyte* name, sbyte* value);

        [NativeName("SDL_SetAppMetadataProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadataProperty")]
        static abstract MaybeBool<byte> SetAppMetadataProperty(Ref<sbyte> name, Ref<sbyte> value);

        [NativeName("SDL_SetAssertionHandler")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAssertionHandler")]
        static abstract void SetAssertionHandler(AssertionHandler handler, void* userdata);

        [NativeName("SDL_SetAssertionHandler")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAssertionHandler")]
        static abstract void SetAssertionHandler(AssertionHandler handler, Ref userdata);

        [NativeName("SDL_SetAtomicInt")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicInt")]
        static abstract int SetAtomicInt(AtomicInt* a, int v);

        [NativeName("SDL_SetAtomicInt")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicInt")]
        static abstract int SetAtomicInt(Ref<AtomicInt> a, int v);

        [NativeName("SDL_SetAtomicPointer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicPointer")]
        static abstract void* SetAtomicPointer(void** a, void* v);

        [NativeName("SDL_SetAtomicPointer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicPointer")]
        static abstract Ptr SetAtomicPointer(Ref2D a, Ref v);

        [NativeName("SDL_SetAtomicU32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicU32")]
        static abstract uint SetAtomicU32(AtomicU32* a, uint v);

        [NativeName("SDL_SetAtomicU32")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicU32")]
        static abstract uint SetAtomicU32(Ref<AtomicU32> a, uint v);

        [NativeName("SDL_SetAudioDeviceGain")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioDeviceGain")]
        static abstract MaybeBool<byte> SetAudioDeviceGain(uint devid, float gain);

        [NativeName("SDL_SetAudioDeviceGain")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioDeviceGain")]
        static abstract byte SetAudioDeviceGainRaw(uint devid, float gain);

        [NativeName("SDL_SetAudioPostmixCallback")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioPostmixCallback")]
        static abstract byte SetAudioPostmixCallback(
            uint devid,
            AudioPostmixCallback callback,
            void* userdata
        );

        [NativeName("SDL_SetAudioPostmixCallback")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioPostmixCallback")]
        static abstract MaybeBool<byte> SetAudioPostmixCallback(
            uint devid,
            AudioPostmixCallback callback,
            Ref userdata
        );

        [NativeName("SDL_SetAudioStreamFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFormat")]
        static abstract byte SetAudioStreamFormat(
            AudioStreamHandle stream,
            AudioSpec* src_spec,
            AudioSpec* dst_spec
        );

        [NativeName("SDL_SetAudioStreamFormat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFormat")]
        static abstract MaybeBool<byte> SetAudioStreamFormat(
            AudioStreamHandle stream,
            Ref<AudioSpec> src_spec,
            Ref<AudioSpec> dst_spec
        );

        [NativeName("SDL_SetAudioStreamFrequencyRatio")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFrequencyRatio")]
        static abstract MaybeBool<byte> SetAudioStreamFrequencyRatio(
            AudioStreamHandle stream,
            float ratio
        );

        [NativeName("SDL_SetAudioStreamFrequencyRatio")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFrequencyRatio")]
        static abstract byte SetAudioStreamFrequencyRatioRaw(AudioStreamHandle stream, float ratio);

        [NativeName("SDL_SetAudioStreamGain")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGain")]
        static abstract MaybeBool<byte> SetAudioStreamGain(AudioStreamHandle stream, float gain);

        [NativeName("SDL_SetAudioStreamGain")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGain")]
        static abstract byte SetAudioStreamGainRaw(AudioStreamHandle stream, float gain);

        [NativeName("SDL_SetAudioStreamGetCallback")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGetCallback")]
        static abstract byte SetAudioStreamGetCallback(
            AudioStreamHandle stream,
            AudioStreamCallback callback,
            void* userdata
        );

        [NativeName("SDL_SetAudioStreamGetCallback")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGetCallback")]
        static abstract MaybeBool<byte> SetAudioStreamGetCallback(
            AudioStreamHandle stream,
            AudioStreamCallback callback,
            Ref userdata
        );

        [NativeName("SDL_SetAudioStreamInputChannelMap")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamInputChannelMap")]
        static abstract byte SetAudioStreamInputChannelMap(
            AudioStreamHandle stream,
            int* chmap,
            int count
        );

        [NativeName("SDL_SetAudioStreamInputChannelMap")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamInputChannelMap")]
        static abstract MaybeBool<byte> SetAudioStreamInputChannelMap(
            AudioStreamHandle stream,
            Ref<int> chmap,
            int count
        );

        [NativeName("SDL_SetAudioStreamOutputChannelMap")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamOutputChannelMap")]
        static abstract byte SetAudioStreamOutputChannelMap(
            AudioStreamHandle stream,
            int* chmap,
            int count
        );

        [NativeName("SDL_SetAudioStreamOutputChannelMap")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamOutputChannelMap")]
        static abstract MaybeBool<byte> SetAudioStreamOutputChannelMap(
            AudioStreamHandle stream,
            Ref<int> chmap,
            int count
        );

        [NativeName("SDL_SetAudioStreamPutCallback")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamPutCallback")]
        static abstract byte SetAudioStreamPutCallback(
            AudioStreamHandle stream,
            AudioStreamCallback callback,
            void* userdata
        );

        [NativeName("SDL_SetAudioStreamPutCallback")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamPutCallback")]
        static abstract MaybeBool<byte> SetAudioStreamPutCallback(
            AudioStreamHandle stream,
            AudioStreamCallback callback,
            Ref userdata
        );

        [NativeName("SDL_SetBooleanProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetBooleanProperty")]
        static abstract byte SetBooleanProperty(uint props, sbyte* name, byte value);

        [NativeName("SDL_SetBooleanProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetBooleanProperty")]
        static abstract MaybeBool<byte> SetBooleanProperty(
            uint props,
            Ref<sbyte> name,
            MaybeBool<byte> value
        );

        [NativeName("SDL_SetClipboardData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardData")]
        static abstract byte SetClipboardData(
            ClipboardDataCallback callback,
            ClipboardCleanupCallback cleanup,
            void* userdata,
            sbyte** mime_types,
            nuint num_mime_types
        );

        [NativeName("SDL_SetClipboardData")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardData")]
        static abstract MaybeBool<byte> SetClipboardData(
            ClipboardDataCallback callback,
            ClipboardCleanupCallback cleanup,
            Ref userdata,
            Ref2D<sbyte> mime_types,
            nuint num_mime_types
        );

        [NativeName("SDL_SetClipboardText")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardText")]
        static abstract byte SetClipboardText(sbyte* text);

        [NativeName("SDL_SetClipboardText")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardText")]
        static abstract MaybeBool<byte> SetClipboardText(Ref<sbyte> text);

        [NativeName("SDL_SetCurrentThreadPriority")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetCurrentThreadPriority")]
        static abstract MaybeBool<byte> SetCurrentThreadPriority(ThreadPriority priority);

        [NativeName("SDL_SetCurrentThreadPriority")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetCurrentThreadPriority")]
        static abstract byte SetCurrentThreadPriorityRaw(ThreadPriority priority);

        [NativeName("SDL_SetCursor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetCursor")]
        static abstract MaybeBool<byte> SetCursor(CursorHandle cursor);

        [NativeName("SDL_SetCursor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetCursor")]
        static abstract byte SetCursorRaw(CursorHandle cursor);

        [NativeName("SDL_setenv_unsafe")]
        [NativeFunction("SDL3", EntryPoint = "SDL_setenv_unsafe")]
        static abstract int SetenvUnsafe(sbyte* name, sbyte* value, int overwrite);

        [NativeName("SDL_setenv_unsafe")]
        [NativeFunction("SDL3", EntryPoint = "SDL_setenv_unsafe")]
        static abstract int SetenvUnsafe(Ref<sbyte> name, Ref<sbyte> value, int overwrite);

        [NativeName("SDL_SetEnvironmentVariable")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetEnvironmentVariable")]
        static abstract byte SetEnvironmentVariable(
            EnvironmentHandle env,
            sbyte* name,
            sbyte* value,
            byte overwrite
        );

        [NativeName("SDL_SetEnvironmentVariable")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetEnvironmentVariable")]
        static abstract MaybeBool<byte> SetEnvironmentVariable(
            EnvironmentHandle env,
            Ref<sbyte> name,
            Ref<sbyte> value,
            MaybeBool<byte> overwrite
        );

        [NativeName("SDL_SetErrorV")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetErrorV")]
        static abstract byte SetErrorV(sbyte* fmt, sbyte* ap);

        [NativeName("SDL_SetErrorV")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetErrorV")]
        static abstract MaybeBool<byte> SetErrorV(Ref<sbyte> fmt, Ref<sbyte> ap);

        [NativeName("SDL_SetEventEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetEventEnabled")]
        static abstract void SetEventEnabled(uint type, byte enabled);

        [NativeName("SDL_SetEventEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetEventEnabled")]
        static abstract void SetEventEnabled(uint type, MaybeBool<byte> enabled);

        [NativeName("SDL_SetEventFilter")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetEventFilter")]
        static abstract void SetEventFilter(EventFilter filter, void* userdata);

        [NativeName("SDL_SetEventFilter")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetEventFilter")]
        static abstract void SetEventFilter(EventFilter filter, Ref userdata);

        [NativeName("SDL_SetFloatProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetFloatProperty")]
        static abstract byte SetFloatProperty(uint props, sbyte* name, float value);

        [NativeName("SDL_SetFloatProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetFloatProperty")]
        static abstract MaybeBool<byte> SetFloatProperty(uint props, Ref<sbyte> name, float value);

        [NativeName("SDL_SetGamepadEventsEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadEventsEnabled")]
        static abstract void SetGamepadEventsEnabled(byte enabled);

        [NativeName("SDL_SetGamepadEventsEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadEventsEnabled")]
        static abstract void SetGamepadEventsEnabled(MaybeBool<byte> enabled);

        [NativeName("SDL_SetGamepadLED")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadLED")]
        static abstract MaybeBool<byte> SetGamepadLed(
            GamepadHandle gamepad,
            byte red,
            byte green,
            byte blue
        );

        [NativeName("SDL_SetGamepadLED")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadLED")]
        static abstract byte SetGamepadLedRaw(
            GamepadHandle gamepad,
            byte red,
            byte green,
            byte blue
        );

        [NativeName("SDL_SetGamepadMapping")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadMapping")]
        static abstract byte SetGamepadMapping(uint instance_id, sbyte* mapping);

        [NativeName("SDL_SetGamepadMapping")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadMapping")]
        static abstract MaybeBool<byte> SetGamepadMapping(uint instance_id, Ref<sbyte> mapping);

        [NativeName("SDL_SetGamepadPlayerIndex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadPlayerIndex")]
        static abstract MaybeBool<byte> SetGamepadPlayerIndex(
            GamepadHandle gamepad,
            int player_index
        );

        [NativeName("SDL_SetGamepadPlayerIndex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadPlayerIndex")]
        static abstract byte SetGamepadPlayerIndexRaw(GamepadHandle gamepad, int player_index);

        [NativeName("SDL_SetGamepadSensorEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadSensorEnabled")]
        static abstract byte SetGamepadSensorEnabled(
            GamepadHandle gamepad,
            SensorType type,
            byte enabled
        );

        [NativeName("SDL_SetGamepadSensorEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadSensorEnabled")]
        static abstract MaybeBool<byte> SetGamepadSensorEnabled(
            GamepadHandle gamepad,
            SensorType type,
            MaybeBool<byte> enabled
        );

        [NativeName("SDL_SetGPUAllowedFramesInFlight")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUAllowedFramesInFlight")]
        static abstract MaybeBool<byte> SetGpuAllowedFramesInFlight(
            GpuDeviceHandle device,
            uint allowed_frames_in_flight
        );

        [NativeName("SDL_SetGPUAllowedFramesInFlight")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUAllowedFramesInFlight")]
        static abstract byte SetGpuAllowedFramesInFlightRaw(
            GpuDeviceHandle device,
            uint allowed_frames_in_flight
        );

        [NativeName("SDL_SetGPUBlendConstants")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUBlendConstants")]
        static abstract void SetGpuBlendConstants(
            GpuRenderPassHandle render_pass,
            FColor blend_constants
        );

        [NativeName("SDL_SetGPUBufferName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUBufferName")]
        static abstract void SetGpuBufferName(
            GpuDeviceHandle device,
            GpuBufferHandle buffer,
            sbyte* text
        );

        [NativeName("SDL_SetGPUBufferName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUBufferName")]
        static abstract void SetGpuBufferName(
            GpuDeviceHandle device,
            GpuBufferHandle buffer,
            Ref<sbyte> text
        );

        [NativeName("SDL_SetGPUScissor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUScissor")]
        static abstract void SetGpuScissor(GpuRenderPassHandle render_pass, Rect* scissor);

        [NativeName("SDL_SetGPUScissor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUScissor")]
        static abstract void SetGpuScissor(GpuRenderPassHandle render_pass, Ref<Rect> scissor);

        [NativeName("SDL_SetGPUStencilReference")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUStencilReference")]
        static abstract void SetGpuStencilReference(
            GpuRenderPassHandle render_pass,
            byte reference
        );

        [NativeName("SDL_SetGPUSwapchainParameters")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUSwapchainParameters")]
        static abstract MaybeBool<byte> SetGpuSwapchainParameters(
            GpuDeviceHandle device,
            WindowHandle window,
            GpuSwapchainComposition swapchain_composition,
            GpuPresentMode present_mode
        );

        [NativeName("SDL_SetGPUSwapchainParameters")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUSwapchainParameters")]
        static abstract byte SetGpuSwapchainParametersRaw(
            GpuDeviceHandle device,
            WindowHandle window,
            GpuSwapchainComposition swapchain_composition,
            GpuPresentMode present_mode
        );

        [NativeName("SDL_SetGPUTextureName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUTextureName")]
        static abstract void SetGpuTextureName(
            GpuDeviceHandle device,
            GpuTextureHandle texture,
            sbyte* text
        );

        [NativeName("SDL_SetGPUTextureName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUTextureName")]
        static abstract void SetGpuTextureName(
            GpuDeviceHandle device,
            GpuTextureHandle texture,
            Ref<sbyte> text
        );

        [NativeName("SDL_SetGPUViewport")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUViewport")]
        static abstract void SetGpuViewport(GpuRenderPassHandle render_pass, GpuViewport* viewport);

        [NativeName("SDL_SetGPUViewport")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUViewport")]
        static abstract void SetGpuViewport(
            GpuRenderPassHandle render_pass,
            Ref<GpuViewport> viewport
        );

        [NativeName("SDL_SetHapticAutocenter")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticAutocenter")]
        static abstract MaybeBool<byte> SetHapticAutocenter(HapticHandle haptic, int autocenter);

        [NativeName("SDL_SetHapticAutocenter")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticAutocenter")]
        static abstract byte SetHapticAutocenterRaw(HapticHandle haptic, int autocenter);

        [NativeName("SDL_SetHapticGain")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticGain")]
        static abstract MaybeBool<byte> SetHapticGain(HapticHandle haptic, int gain);

        [NativeName("SDL_SetHapticGain")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticGain")]
        static abstract byte SetHapticGainRaw(HapticHandle haptic, int gain);

        [NativeName("SDL_SetHint")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHint")]
        static abstract byte SetHint(sbyte* name, sbyte* value);

        [NativeName("SDL_SetHint")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHint")]
        static abstract MaybeBool<byte> SetHint(Ref<sbyte> name, Ref<sbyte> value);

        [NativeName("SDL_SetHintWithPriority")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHintWithPriority")]
        static abstract byte SetHintWithPriority(sbyte* name, sbyte* value, HintPriority priority);

        [NativeName("SDL_SetHintWithPriority")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetHintWithPriority")]
        static abstract MaybeBool<byte> SetHintWithPriority(
            Ref<sbyte> name,
            Ref<sbyte> value,
            HintPriority priority
        );

        [NativeName("SDL_SetInitialized")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetInitialized")]
        static abstract void SetInitialized(InitState* state, byte initialized);

        [NativeName("SDL_SetInitialized")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetInitialized")]
        static abstract void SetInitialized(Ref<InitState> state, MaybeBool<byte> initialized);

        [NativeName("SDL_SetJoystickEventsEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickEventsEnabled")]
        static abstract void SetJoystickEventsEnabled(byte enabled);

        [NativeName("SDL_SetJoystickEventsEnabled")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickEventsEnabled")]
        static abstract void SetJoystickEventsEnabled(MaybeBool<byte> enabled);

        [NativeName("SDL_SetJoystickLED")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickLED")]
        static abstract MaybeBool<byte> SetJoystickLed(
            JoystickHandle joystick,
            byte red,
            byte green,
            byte blue
        );

        [NativeName("SDL_SetJoystickLED")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickLED")]
        static abstract byte SetJoystickLedRaw(
            JoystickHandle joystick,
            byte red,
            byte green,
            byte blue
        );

        [NativeName("SDL_SetJoystickPlayerIndex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickPlayerIndex")]
        static abstract MaybeBool<byte> SetJoystickPlayerIndex(
            JoystickHandle joystick,
            int player_index
        );

        [NativeName("SDL_SetJoystickPlayerIndex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickPlayerIndex")]
        static abstract byte SetJoystickPlayerIndexRaw(JoystickHandle joystick, int player_index);

        [NativeName("SDL_SetJoystickVirtualAxis")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualAxis")]
        static abstract MaybeBool<byte> SetJoystickVirtualAxis(
            JoystickHandle joystick,
            int axis,
            short value
        );

        [NativeName("SDL_SetJoystickVirtualAxis")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualAxis")]
        static abstract byte SetJoystickVirtualAxisRaw(
            JoystickHandle joystick,
            int axis,
            short value
        );

        [NativeName("SDL_SetJoystickVirtualBall")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualBall")]
        static abstract MaybeBool<byte> SetJoystickVirtualBall(
            JoystickHandle joystick,
            int ball,
            short xrel,
            short yrel
        );

        [NativeName("SDL_SetJoystickVirtualBall")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualBall")]
        static abstract byte SetJoystickVirtualBallRaw(
            JoystickHandle joystick,
            int ball,
            short xrel,
            short yrel
        );

        [NativeName("SDL_SetJoystickVirtualButton")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualButton")]
        static abstract byte SetJoystickVirtualButton(
            JoystickHandle joystick,
            int button,
            byte down
        );

        [NativeName("SDL_SetJoystickVirtualButton")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualButton")]
        static abstract MaybeBool<byte> SetJoystickVirtualButton(
            JoystickHandle joystick,
            int button,
            MaybeBool<byte> down
        );

        [NativeName("SDL_SetJoystickVirtualHat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualHat")]
        static abstract MaybeBool<byte> SetJoystickVirtualHat(
            JoystickHandle joystick,
            int hat,
            byte value
        );

        [NativeName("SDL_SetJoystickVirtualHat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualHat")]
        static abstract byte SetJoystickVirtualHatRaw(JoystickHandle joystick, int hat, byte value);

        [NativeName("SDL_SetJoystickVirtualTouchpad")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualTouchpad")]
        static abstract byte SetJoystickVirtualTouchpad(
            JoystickHandle joystick,
            int touchpad,
            int finger,
            byte down,
            float x,
            float y,
            float pressure
        );

        [NativeName("SDL_SetJoystickVirtualTouchpad")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualTouchpad")]
        static abstract MaybeBool<byte> SetJoystickVirtualTouchpad(
            JoystickHandle joystick,
            int touchpad,
            int finger,
            MaybeBool<byte> down,
            float x,
            float y,
            float pressure
        );

        [NativeName("SDL_SetLogOutputFunction")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetLogOutputFunction")]
        static abstract void SetLogOutputFunction(LogOutputFunction callback, void* userdata);

        [NativeName("SDL_SetLogOutputFunction")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetLogOutputFunction")]
        static abstract void SetLogOutputFunction(LogOutputFunction callback, Ref userdata);

        [NativeName("SDL_SetLogPriorities")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriorities")]
        static abstract void SetLogPriorities(LogPriority priority);

        [NativeName("SDL_SetLogPriority")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriority")]
        static abstract void SetLogPriority(int category, LogPriority priority);

        [NativeName("SDL_SetLogPriorityPrefix")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriorityPrefix")]
        static abstract byte SetLogPriorityPrefix(LogPriority priority, sbyte* prefix);

        [NativeName("SDL_SetLogPriorityPrefix")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriorityPrefix")]
        static abstract MaybeBool<byte> SetLogPriorityPrefix(
            LogPriority priority,
            Ref<sbyte> prefix
        );

        [NativeName("SDL_SetMainReady")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetMainReady")]
        static abstract void SetMainReady();

        [NativeName("SDL_SetMemoryFunctions")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetMemoryFunctions")]
        static abstract MaybeBool<byte> SetMemoryFunctions(
            MallocFunc malloc_func,
            CallocFunc calloc_func,
            ReallocFunc realloc_func,
            FreeFunc free_func
        );

        [NativeName("SDL_SetMemoryFunctions")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetMemoryFunctions")]
        static abstract byte SetMemoryFunctionsRaw(
            MallocFunc malloc_func,
            CallocFunc calloc_func,
            ReallocFunc realloc_func,
            FreeFunc free_func
        );

        [NativeName("SDL_SetModState")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetModState")]
        static abstract void SetModState(ushort modstate);

        [NativeName("SDL_SetNumberProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetNumberProperty")]
        static abstract byte SetNumberProperty(uint props, sbyte* name, long value);

        [NativeName("SDL_SetNumberProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetNumberProperty")]
        static abstract MaybeBool<byte> SetNumberProperty(uint props, Ref<sbyte> name, long value);

        [NativeName("SDL_SetPaletteColors")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPaletteColors")]
        static abstract byte SetPaletteColors(
            Palette* palette,
            Color* colors,
            int firstcolor,
            int ncolors
        );

        [NativeName("SDL_SetPaletteColors")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPaletteColors")]
        static abstract MaybeBool<byte> SetPaletteColors(
            Ref<Palette> palette,
            Ref<Color> colors,
            int firstcolor,
            int ncolors
        );

        [NativeName("SDL_SetPointerProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerProperty")]
        static abstract byte SetPointerProperty(uint props, sbyte* name, void* value);

        [NativeName("SDL_SetPointerProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerProperty")]
        static abstract MaybeBool<byte> SetPointerProperty(uint props, Ref<sbyte> name, Ref value);

        [NativeName("SDL_SetPointerPropertyWithCleanup")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerPropertyWithCleanup")]
        static abstract byte SetPointerPropertyWithCleanup(
            uint props,
            sbyte* name,
            void* value,
            CleanupPropertyCallback cleanup,
            void* userdata
        );

        [NativeName("SDL_SetPointerPropertyWithCleanup")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerPropertyWithCleanup")]
        static abstract MaybeBool<byte> SetPointerPropertyWithCleanup(
            uint props,
            Ref<sbyte> name,
            Ref value,
            CleanupPropertyCallback cleanup,
            Ref userdata
        );

        [NativeName("SDL_SetPrimarySelectionText")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPrimarySelectionText")]
        static abstract byte SetPrimarySelectionText(sbyte* text);

        [NativeName("SDL_SetPrimarySelectionText")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetPrimarySelectionText")]
        static abstract MaybeBool<byte> SetPrimarySelectionText(Ref<sbyte> text);

        [NativeName("SDL_SetRenderClipRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderClipRect")]
        static abstract byte SetRenderClipRect(RendererHandle renderer, Rect* rect);

        [NativeName("SDL_SetRenderClipRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderClipRect")]
        static abstract MaybeBool<byte> SetRenderClipRect(RendererHandle renderer, Ref<Rect> rect);

        [NativeName("SDL_SetRenderColorScale")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderColorScale")]
        static abstract MaybeBool<byte> SetRenderColorScale(RendererHandle renderer, float scale);

        [NativeName("SDL_SetRenderColorScale")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderColorScale")]
        static abstract byte SetRenderColorScaleRaw(RendererHandle renderer, float scale);

        [NativeName("SDL_SetRenderDrawBlendMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawBlendMode")]
        static abstract MaybeBool<byte> SetRenderDrawBlendMode(
            RendererHandle renderer,
            BlendMode blendMode
        );

        [NativeName("SDL_SetRenderDrawBlendMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawBlendMode")]
        static abstract byte SetRenderDrawBlendModeRaw(
            RendererHandle renderer,
            BlendMode blendMode
        );

        [NativeName("SDL_SetRenderDrawColor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColor")]
        static abstract MaybeBool<byte> SetRenderDrawColor(
            RendererHandle renderer,
            byte r,
            byte g,
            byte b,
            byte a
        );

        [NativeName("SDL_SetRenderDrawColorFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColorFloat")]
        static abstract MaybeBool<byte> SetRenderDrawColorFloat(
            RendererHandle renderer,
            float r,
            float g,
            float b,
            float a
        );

        [NativeName("SDL_SetRenderDrawColorFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColorFloat")]
        static abstract byte SetRenderDrawColorFloatRaw(
            RendererHandle renderer,
            float r,
            float g,
            float b,
            float a
        );

        [NativeName("SDL_SetRenderDrawColor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColor")]
        static abstract byte SetRenderDrawColorRaw(
            RendererHandle renderer,
            byte r,
            byte g,
            byte b,
            byte a
        );

        [NativeName("SDL_SetRenderLogicalPresentation")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderLogicalPresentation")]
        static abstract MaybeBool<byte> SetRenderLogicalPresentation(
            RendererHandle renderer,
            int w,
            int h,
            RendererLogicalPresentation mode
        );

        [NativeName("SDL_SetRenderLogicalPresentation")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderLogicalPresentation")]
        static abstract byte SetRenderLogicalPresentationRaw(
            RendererHandle renderer,
            int w,
            int h,
            RendererLogicalPresentation mode
        );

        [NativeName("SDL_SetRenderScale")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderScale")]
        static abstract MaybeBool<byte> SetRenderScale(
            RendererHandle renderer,
            float scaleX,
            float scaleY
        );

        [NativeName("SDL_SetRenderScale")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderScale")]
        static abstract byte SetRenderScaleRaw(RendererHandle renderer, float scaleX, float scaleY);

        [NativeName("SDL_SetRenderTarget")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderTarget")]
        static abstract byte SetRenderTarget(RendererHandle renderer, Texture* texture);

        [NativeName("SDL_SetRenderTarget")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderTarget")]
        static abstract MaybeBool<byte> SetRenderTarget(
            RendererHandle renderer,
            Ref<Texture> texture
        );

        [NativeName("SDL_SetRenderViewport")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderViewport")]
        static abstract byte SetRenderViewport(RendererHandle renderer, Rect* rect);

        [NativeName("SDL_SetRenderViewport")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderViewport")]
        static abstract MaybeBool<byte> SetRenderViewport(RendererHandle renderer, Ref<Rect> rect);

        [NativeName("SDL_SetRenderVSync")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderVSync")]
        static abstract MaybeBool<byte> SetRenderVSync(RendererHandle renderer, int vsync);

        [NativeName("SDL_SetRenderVSync")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderVSync")]
        static abstract byte SetRenderVSyncRaw(RendererHandle renderer, int vsync);

        [NativeName("SDL_SetScancodeName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetScancodeName")]
        static abstract byte SetScancodeName(Scancode scancode, sbyte* name);

        [NativeName("SDL_SetScancodeName")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetScancodeName")]
        static abstract MaybeBool<byte> SetScancodeName(Scancode scancode, Ref<sbyte> name);

        [NativeName("SDL_SetStringProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetStringProperty")]
        static abstract byte SetStringProperty(uint props, sbyte* name, sbyte* value);

        [NativeName("SDL_SetStringProperty")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetStringProperty")]
        static abstract MaybeBool<byte> SetStringProperty(
            uint props,
            Ref<sbyte> name,
            Ref<sbyte> value
        );

        [NativeName("SDL_SetSurfaceAlphaMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceAlphaMod")]
        static abstract byte SetSurfaceAlphaMod(Surface* surface, byte alpha);

        [NativeName("SDL_SetSurfaceAlphaMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceAlphaMod")]
        static abstract MaybeBool<byte> SetSurfaceAlphaMod(Ref<Surface> surface, byte alpha);

        [NativeName("SDL_SetSurfaceBlendMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceBlendMode")]
        static abstract byte SetSurfaceBlendMode(Surface* surface, BlendMode blendMode);

        [NativeName("SDL_SetSurfaceBlendMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceBlendMode")]
        static abstract MaybeBool<byte> SetSurfaceBlendMode(
            Ref<Surface> surface,
            BlendMode blendMode
        );

        [NativeName("SDL_SetSurfaceClipRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceClipRect")]
        static abstract byte SetSurfaceClipRect(Surface* surface, Rect* rect);

        [NativeName("SDL_SetSurfaceClipRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceClipRect")]
        static abstract MaybeBool<byte> SetSurfaceClipRect(Ref<Surface> surface, Ref<Rect> rect);

        [NativeName("SDL_SetSurfaceColorKey")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorKey")]
        static abstract byte SetSurfaceColorKey(Surface* surface, byte enabled, uint key);

        [NativeName("SDL_SetSurfaceColorKey")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorKey")]
        static abstract MaybeBool<byte> SetSurfaceColorKey(
            Ref<Surface> surface,
            MaybeBool<byte> enabled,
            uint key
        );

        [NativeName("SDL_SetSurfaceColorMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorMod")]
        static abstract byte SetSurfaceColorMod(Surface* surface, byte r, byte g, byte b);

        [NativeName("SDL_SetSurfaceColorMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorMod")]
        static abstract MaybeBool<byte> SetSurfaceColorMod(
            Ref<Surface> surface,
            byte r,
            byte g,
            byte b
        );

        [NativeName("SDL_SetSurfaceColorspace")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorspace")]
        static abstract byte SetSurfaceColorspace(Surface* surface, Colorspace colorspace);

        [NativeName("SDL_SetSurfaceColorspace")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorspace")]
        static abstract MaybeBool<byte> SetSurfaceColorspace(
            Ref<Surface> surface,
            Colorspace colorspace
        );

        [NativeName("SDL_SetSurfacePalette")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfacePalette")]
        static abstract byte SetSurfacePalette(Surface* surface, Palette* palette);

        [NativeName("SDL_SetSurfacePalette")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfacePalette")]
        static abstract MaybeBool<byte> SetSurfacePalette(
            Ref<Surface> surface,
            Ref<Palette> palette
        );

        [NativeName("SDL_SetSurfaceRLE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceRLE")]
        static abstract byte SetSurfaceRle(Surface* surface, byte enabled);

        [NativeName("SDL_SetSurfaceRLE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceRLE")]
        static abstract MaybeBool<byte> SetSurfaceRle(
            Ref<Surface> surface,
            MaybeBool<byte> enabled
        );

        [NativeName("SDL_SetTextInputArea")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextInputArea")]
        static abstract byte SetTextInputArea(WindowHandle window, Rect* rect, int cursor);

        [NativeName("SDL_SetTextInputArea")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextInputArea")]
        static abstract MaybeBool<byte> SetTextInputArea(
            WindowHandle window,
            Ref<Rect> rect,
            int cursor
        );

        [NativeName("SDL_SetTextureAlphaMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaMod")]
        static abstract byte SetTextureAlphaMod(Texture* texture, byte alpha);

        [NativeName("SDL_SetTextureAlphaMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaMod")]
        static abstract MaybeBool<byte> SetTextureAlphaMod(Ref<Texture> texture, byte alpha);

        [NativeName("SDL_SetTextureAlphaModFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaModFloat")]
        static abstract byte SetTextureAlphaModFloat(Texture* texture, float alpha);

        [NativeName("SDL_SetTextureAlphaModFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaModFloat")]
        static abstract MaybeBool<byte> SetTextureAlphaModFloat(Ref<Texture> texture, float alpha);

        [NativeName("SDL_SetTextureBlendMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureBlendMode")]
        static abstract byte SetTextureBlendMode(Texture* texture, BlendMode blendMode);

        [NativeName("SDL_SetTextureBlendMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureBlendMode")]
        static abstract MaybeBool<byte> SetTextureBlendMode(
            Ref<Texture> texture,
            BlendMode blendMode
        );

        [NativeName("SDL_SetTextureColorMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorMod")]
        static abstract byte SetTextureColorMod(Texture* texture, byte r, byte g, byte b);

        [NativeName("SDL_SetTextureColorMod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorMod")]
        static abstract MaybeBool<byte> SetTextureColorMod(
            Ref<Texture> texture,
            byte r,
            byte g,
            byte b
        );

        [NativeName("SDL_SetTextureColorModFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorModFloat")]
        static abstract byte SetTextureColorModFloat(Texture* texture, float r, float g, float b);

        [NativeName("SDL_SetTextureColorModFloat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorModFloat")]
        static abstract MaybeBool<byte> SetTextureColorModFloat(
            Ref<Texture> texture,
            float r,
            float g,
            float b
        );

        [NativeName("SDL_SetTextureScaleMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureScaleMode")]
        static abstract byte SetTextureScaleMode(Texture* texture, ScaleMode scaleMode);

        [NativeName("SDL_SetTextureScaleMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureScaleMode")]
        static abstract MaybeBool<byte> SetTextureScaleMode(
            Ref<Texture> texture,
            ScaleMode scaleMode
        );

        [NativeName("SDL_SetTLS")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTLS")]
        static abstract byte SetTls(AtomicInt* id, void* value, TlsDestructorCallback destructor);

        [NativeName("SDL_SetTLS")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetTLS")]
        static abstract MaybeBool<byte> SetTls(
            Ref<AtomicInt> id,
            Ref value,
            TlsDestructorCallback destructor
        );

        [NativeName("SDL_SetWindowAlwaysOnTop")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAlwaysOnTop")]
        static abstract byte SetWindowAlwaysOnTop(WindowHandle window, byte on_top);

        [NativeName("SDL_SetWindowAlwaysOnTop")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAlwaysOnTop")]
        static abstract MaybeBool<byte> SetWindowAlwaysOnTop(
            WindowHandle window,
            MaybeBool<byte> on_top
        );

        [NativeName("SDL_SetWindowAspectRatio")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAspectRatio")]
        static abstract MaybeBool<byte> SetWindowAspectRatio(
            WindowHandle window,
            float min_aspect,
            float max_aspect
        );

        [NativeName("SDL_SetWindowAspectRatio")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAspectRatio")]
        static abstract byte SetWindowAspectRatioRaw(
            WindowHandle window,
            float min_aspect,
            float max_aspect
        );

        [NativeName("SDL_SetWindowBordered")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowBordered")]
        static abstract byte SetWindowBordered(WindowHandle window, byte bordered);

        [NativeName("SDL_SetWindowBordered")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowBordered")]
        static abstract MaybeBool<byte> SetWindowBordered(
            WindowHandle window,
            MaybeBool<byte> bordered
        );

        [NativeName("SDL_SetWindowFocusable")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFocusable")]
        static abstract byte SetWindowFocusable(WindowHandle window, byte focusable);

        [NativeName("SDL_SetWindowFocusable")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFocusable")]
        static abstract MaybeBool<byte> SetWindowFocusable(
            WindowHandle window,
            MaybeBool<byte> focusable
        );

        [NativeName("SDL_SetWindowFullscreen")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreen")]
        static abstract byte SetWindowFullscreen(WindowHandle window, byte fullscreen);

        [NativeName("SDL_SetWindowFullscreen")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreen")]
        static abstract MaybeBool<byte> SetWindowFullscreen(
            WindowHandle window,
            MaybeBool<byte> fullscreen
        );

        [NativeName("SDL_SetWindowFullscreenMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreenMode")]
        static abstract byte SetWindowFullscreenMode(WindowHandle window, DisplayMode* mode);

        [NativeName("SDL_SetWindowFullscreenMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreenMode")]
        static abstract MaybeBool<byte> SetWindowFullscreenMode(
            WindowHandle window,
            Ref<DisplayMode> mode
        );

        [NativeName("SDL_SetWindowHitTest")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowHitTest")]
        static abstract byte SetWindowHitTest(
            WindowHandle window,
            HitTest callback,
            void* callback_data
        );

        [NativeName("SDL_SetWindowHitTest")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowHitTest")]
        static abstract MaybeBool<byte> SetWindowHitTest(
            WindowHandle window,
            HitTest callback,
            Ref callback_data
        );

        [NativeName("SDL_SetWindowIcon")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowIcon")]
        static abstract byte SetWindowIcon(WindowHandle window, Surface* icon);

        [NativeName("SDL_SetWindowIcon")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowIcon")]
        static abstract MaybeBool<byte> SetWindowIcon(WindowHandle window, Ref<Surface> icon);

        [NativeName("SDL_SetWindowKeyboardGrab")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowKeyboardGrab")]
        static abstract byte SetWindowKeyboardGrab(WindowHandle window, byte grabbed);

        [NativeName("SDL_SetWindowKeyboardGrab")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowKeyboardGrab")]
        static abstract MaybeBool<byte> SetWindowKeyboardGrab(
            WindowHandle window,
            MaybeBool<byte> grabbed
        );

        [NativeName("SDL_SetWindowMaximumSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMaximumSize")]
        static abstract MaybeBool<byte> SetWindowMaximumSize(
            WindowHandle window,
            int max_w,
            int max_h
        );

        [NativeName("SDL_SetWindowMaximumSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMaximumSize")]
        static abstract byte SetWindowMaximumSizeRaw(WindowHandle window, int max_w, int max_h);

        [NativeName("SDL_SetWindowMinimumSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMinimumSize")]
        static abstract MaybeBool<byte> SetWindowMinimumSize(
            WindowHandle window,
            int min_w,
            int min_h
        );

        [NativeName("SDL_SetWindowMinimumSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMinimumSize")]
        static abstract byte SetWindowMinimumSizeRaw(WindowHandle window, int min_w, int min_h);

        [NativeName("SDL_SetWindowModal")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowModal")]
        static abstract byte SetWindowModal(WindowHandle window, byte modal);

        [NativeName("SDL_SetWindowModal")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowModal")]
        static abstract MaybeBool<byte> SetWindowModal(WindowHandle window, MaybeBool<byte> modal);

        [NativeName("SDL_SetWindowMouseGrab")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseGrab")]
        static abstract byte SetWindowMouseGrab(WindowHandle window, byte grabbed);

        [NativeName("SDL_SetWindowMouseGrab")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseGrab")]
        static abstract MaybeBool<byte> SetWindowMouseGrab(
            WindowHandle window,
            MaybeBool<byte> grabbed
        );

        [NativeName("SDL_SetWindowMouseRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseRect")]
        static abstract byte SetWindowMouseRect(WindowHandle window, Rect* rect);

        [NativeName("SDL_SetWindowMouseRect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseRect")]
        static abstract MaybeBool<byte> SetWindowMouseRect(WindowHandle window, Ref<Rect> rect);

        [NativeName("SDL_SetWindowOpacity")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowOpacity")]
        static abstract MaybeBool<byte> SetWindowOpacity(WindowHandle window, float opacity);

        [NativeName("SDL_SetWindowOpacity")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowOpacity")]
        static abstract byte SetWindowOpacityRaw(WindowHandle window, float opacity);

        [NativeName("SDL_SetWindowParent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowParent")]
        static abstract MaybeBool<byte> SetWindowParent(WindowHandle window, WindowHandle parent);

        [NativeName("SDL_SetWindowParent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowParent")]
        static abstract byte SetWindowParentRaw(WindowHandle window, WindowHandle parent);

        [NativeName("SDL_SetWindowPosition")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowPosition")]
        static abstract MaybeBool<byte> SetWindowPosition(WindowHandle window, int x, int y);

        [NativeName("SDL_SetWindowPosition")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowPosition")]
        static abstract byte SetWindowPositionRaw(WindowHandle window, int x, int y);

        [NativeName("SDL_SetWindowRelativeMouseMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowRelativeMouseMode")]
        static abstract byte SetWindowRelativeMouseMode(WindowHandle window, byte enabled);

        [NativeName("SDL_SetWindowRelativeMouseMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowRelativeMouseMode")]
        static abstract MaybeBool<byte> SetWindowRelativeMouseMode(
            WindowHandle window,
            MaybeBool<byte> enabled
        );

        [NativeName("SDL_SetWindowResizable")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowResizable")]
        static abstract byte SetWindowResizable(WindowHandle window, byte resizable);

        [NativeName("SDL_SetWindowResizable")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowResizable")]
        static abstract MaybeBool<byte> SetWindowResizable(
            WindowHandle window,
            MaybeBool<byte> resizable
        );

        [NativeName("SDL_SetWindowShape")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowShape")]
        static abstract byte SetWindowShape(WindowHandle window, Surface* shape);

        [NativeName("SDL_SetWindowShape")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowShape")]
        static abstract MaybeBool<byte> SetWindowShape(WindowHandle window, Ref<Surface> shape);

        [NativeName("SDL_SetWindowSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSize")]
        static abstract MaybeBool<byte> SetWindowSize(WindowHandle window, int w, int h);

        [NativeName("SDL_SetWindowSize")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSize")]
        static abstract byte SetWindowSizeRaw(WindowHandle window, int w, int h);

        [NativeName("SDL_SetWindowSurfaceVSync")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSurfaceVSync")]
        static abstract MaybeBool<byte> SetWindowSurfaceVSync(WindowHandle window, int vsync);

        [NativeName("SDL_SetWindowSurfaceVSync")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSurfaceVSync")]
        static abstract byte SetWindowSurfaceVSyncRaw(WindowHandle window, int vsync);

        [NativeName("SDL_SetWindowTitle")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowTitle")]
        static abstract byte SetWindowTitle(WindowHandle window, sbyte* title);

        [NativeName("SDL_SetWindowTitle")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowTitle")]
        static abstract MaybeBool<byte> SetWindowTitle(WindowHandle window, Ref<sbyte> title);

        [NativeName("SDL_ShouldInit")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShouldInit")]
        static abstract byte ShouldInit(InitState* state);

        [NativeName("SDL_ShouldInit")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShouldInit")]
        static abstract MaybeBool<byte> ShouldInit(Ref<InitState> state);

        [NativeName("SDL_ShouldQuit")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShouldQuit")]
        static abstract byte ShouldQuit(InitState* state);

        [NativeName("SDL_ShouldQuit")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShouldQuit")]
        static abstract MaybeBool<byte> ShouldQuit(Ref<InitState> state);

        [NativeName("SDL_ShowCursor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowCursor")]
        static abstract MaybeBool<byte> ShowCursor();

        [NativeName("SDL_ShowCursor")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowCursor")]
        static abstract byte ShowCursorRaw();

        [NativeName("SDL_ShowFileDialogWithProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowFileDialogWithProperties")]
        static abstract void ShowFileDialogWithProperties(
            FileDialogType type,
            DialogFileCallback callback,
            void* userdata,
            uint props
        );

        [NativeName("SDL_ShowFileDialogWithProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowFileDialogWithProperties")]
        static abstract void ShowFileDialogWithProperties(
            FileDialogType type,
            DialogFileCallback callback,
            Ref userdata,
            uint props
        );

        [NativeName("SDL_ShowMessageBox")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowMessageBox")]
        static abstract byte ShowMessageBox(MessageBoxData* messageboxdata, int* buttonid);

        [NativeName("SDL_ShowMessageBox")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowMessageBox")]
        static abstract MaybeBool<byte> ShowMessageBox(
            Ref<MessageBoxData> messageboxdata,
            Ref<int> buttonid
        );

        [NativeName("SDL_ShowOpenFileDialog")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFileDialog")]
        static abstract void ShowOpenFileDialog(
            DialogFileCallback callback,
            void* userdata,
            WindowHandle window,
            DialogFileFilter* filters,
            int nfilters,
            sbyte* default_location,
            byte allow_many
        );

        [NativeName("SDL_ShowOpenFileDialog")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFileDialog")]
        static abstract void ShowOpenFileDialog(
            DialogFileCallback callback,
            Ref userdata,
            WindowHandle window,
            Ref<DialogFileFilter> filters,
            int nfilters,
            Ref<sbyte> default_location,
            MaybeBool<byte> allow_many
        );

        [NativeName("SDL_ShowOpenFolderDialog")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFolderDialog")]
        static abstract void ShowOpenFolderDialog(
            DialogFileCallback callback,
            void* userdata,
            WindowHandle window,
            sbyte* default_location,
            byte allow_many
        );

        [NativeName("SDL_ShowOpenFolderDialog")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFolderDialog")]
        static abstract void ShowOpenFolderDialog(
            DialogFileCallback callback,
            Ref userdata,
            WindowHandle window,
            Ref<sbyte> default_location,
            MaybeBool<byte> allow_many
        );

        [NativeName("SDL_ShowSaveFileDialog")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowSaveFileDialog")]
        static abstract void ShowSaveFileDialog(
            DialogFileCallback callback,
            void* userdata,
            WindowHandle window,
            DialogFileFilter* filters,
            int nfilters,
            sbyte* default_location
        );

        [NativeName("SDL_ShowSaveFileDialog")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowSaveFileDialog")]
        static abstract void ShowSaveFileDialog(
            DialogFileCallback callback,
            Ref userdata,
            WindowHandle window,
            Ref<DialogFileFilter> filters,
            int nfilters,
            Ref<sbyte> default_location
        );

        [NativeName("SDL_ShowSimpleMessageBox")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowSimpleMessageBox")]
        static abstract byte ShowSimpleMessageBox(
            uint flags,
            sbyte* title,
            sbyte* message,
            WindowHandle window
        );

        [NativeName("SDL_ShowSimpleMessageBox")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowSimpleMessageBox")]
        static abstract MaybeBool<byte> ShowSimpleMessageBox(
            uint flags,
            Ref<sbyte> title,
            Ref<sbyte> message,
            WindowHandle window
        );

        [NativeName("SDL_ShowWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindow")]
        static abstract MaybeBool<byte> ShowWindow(WindowHandle window);

        [NativeName("SDL_ShowWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindow")]
        static abstract byte ShowWindowRaw(WindowHandle window);

        [NativeName("SDL_ShowWindowSystemMenu")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindowSystemMenu")]
        static abstract MaybeBool<byte> ShowWindowSystemMenu(WindowHandle window, int x, int y);

        [NativeName("SDL_ShowWindowSystemMenu")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindowSystemMenu")]
        static abstract byte ShowWindowSystemMenuRaw(WindowHandle window, int x, int y);

        [NativeName("SDL_SignalCondition")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SignalCondition")]
        static abstract void SignalCondition(ConditionHandle cond);

        [NativeName("SDL_SignalSemaphore")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SignalSemaphore")]
        static abstract void SignalSemaphore(SemaphoreHandle sem);

        [NativeName("SDL_sin")]
        [NativeFunction("SDL3", EntryPoint = "SDL_sin")]
        static abstract double Sin(double x);

        [NativeName("SDL_sinf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_sinf")]
        static abstract float Sinf(float x);

        [NativeName("SDL_sqrt")]
        [NativeFunction("SDL3", EntryPoint = "SDL_sqrt")]
        static abstract double Sqrt(double x);

        [NativeName("SDL_sqrtf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_sqrtf")]
        static abstract float Sqrtf(float x);

        [NativeName("SDL_srand")]
        [NativeFunction("SDL3", EntryPoint = "SDL_srand")]
        static abstract void Srand(ulong seed);

        [NativeName("SDL_StartTextInput")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInput")]
        static abstract MaybeBool<byte> StartTextInput(WindowHandle window);

        [NativeName("SDL_StartTextInput")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInput")]
        static abstract byte StartTextInputRaw(WindowHandle window);

        [NativeName("SDL_StartTextInputWithProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInputWithProperties")]
        static abstract MaybeBool<byte> StartTextInputWithProperties(
            WindowHandle window,
            uint props
        );

        [NativeName("SDL_StartTextInputWithProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInputWithProperties")]
        static abstract byte StartTextInputWithPropertiesRaw(WindowHandle window, uint props);

        [NativeName("SDL_StepBackUTF8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StepBackUTF8")]
        static abstract uint StepBackUtf8(sbyte* start, sbyte** pstr);

        [NativeName("SDL_StepBackUTF8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StepBackUTF8")]
        static abstract uint StepBackUtf8(Ref<sbyte> start, Ref2D<sbyte> pstr);

        [NativeName("SDL_StepUTF8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StepUTF8")]
        static abstract uint StepUtf8(sbyte** pstr, nuint* pslen);

        [NativeName("SDL_StepUTF8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StepUTF8")]
        static abstract uint StepUtf8(Ref2D<sbyte> pstr, Ref<nuint> pslen);

        [NativeName("SDL_StopHapticEffect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffect")]
        static abstract MaybeBool<byte> StopHapticEffect(HapticHandle haptic, int effect);

        [NativeName("SDL_StopHapticEffect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffect")]
        static abstract byte StopHapticEffectRaw(HapticHandle haptic, int effect);

        [NativeName("SDL_StopHapticEffects")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffects")]
        static abstract MaybeBool<byte> StopHapticEffects(HapticHandle haptic);

        [NativeName("SDL_StopHapticEffects")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffects")]
        static abstract byte StopHapticEffectsRaw(HapticHandle haptic);

        [NativeName("SDL_StopHapticRumble")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticRumble")]
        static abstract MaybeBool<byte> StopHapticRumble(HapticHandle haptic);

        [NativeName("SDL_StopHapticRumble")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticRumble")]
        static abstract byte StopHapticRumbleRaw(HapticHandle haptic);

        [NativeName("SDL_StopTextInput")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopTextInput")]
        static abstract MaybeBool<byte> StopTextInput(WindowHandle window);

        [NativeName("SDL_StopTextInput")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StopTextInput")]
        static abstract byte StopTextInputRaw(WindowHandle window);

        [NativeName("SDL_StorageReady")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StorageReady")]
        static abstract MaybeBool<byte> StorageReady(StorageHandle storage);

        [NativeName("SDL_StorageReady")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StorageReady")]
        static abstract byte StorageReadyRaw(StorageHandle storage);

        [NativeName("SDL_strcasecmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strcasecmp")]
        static abstract int Strcasecmp(sbyte* str1, sbyte* str2);

        [NativeName("SDL_strcasecmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strcasecmp")]
        static abstract int Strcasecmp(Ref<sbyte> str1, Ref<sbyte> str2);

        [NativeName("SDL_strcasestr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strcasestr")]
        static abstract sbyte* Strcasestr(sbyte* haystack, sbyte* needle);

        [NativeName("SDL_strcasestr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strcasestr")]
        static abstract Ptr<sbyte> Strcasestr(Ref<sbyte> haystack, Ref<sbyte> needle);

        [NativeName("SDL_strchr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strchr")]
        static abstract sbyte* Strchr(sbyte* str, int c);

        [NativeName("SDL_strchr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strchr")]
        static abstract Ptr<sbyte> Strchr(Ref<sbyte> str, int c);

        [NativeName("SDL_strcmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strcmp")]
        static abstract int Strcmp(sbyte* str1, sbyte* str2);

        [NativeName("SDL_strcmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strcmp")]
        static abstract int Strcmp(Ref<sbyte> str1, Ref<sbyte> str2);

        [NativeName("SDL_strdup")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strdup")]
        static abstract sbyte* Strdup(sbyte* str);

        [NativeName("SDL_strdup")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strdup")]
        static abstract Ptr<sbyte> Strdup(Ref<sbyte> str);

        [NativeName("SDL_StretchSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StretchSurface")]
        static abstract byte StretchSurface(
            Surface* src,
            Rect* srcrect,
            Surface* dst,
            Rect* dstrect,
            ScaleMode scaleMode
        );

        [NativeName("SDL_StretchSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StretchSurface")]
        static abstract MaybeBool<byte> StretchSurface(
            Ref<Surface> src,
            Ref<Rect> srcrect,
            Ref<Surface> dst,
            Ref<Rect> dstrect,
            ScaleMode scaleMode
        );

        [NativeName("SDL_StringToGUID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StringToGUID")]
        static abstract Guid StringToGuid(sbyte* pchGUID);

        [NativeName("SDL_StringToGUID")]
        [NativeFunction("SDL3", EntryPoint = "SDL_StringToGUID")]
        static abstract Guid StringToGuid(Ref<sbyte> pchGUID);

        [NativeName("SDL_strlcat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlcat")]
        static abstract nuint Strlcat(sbyte* dst, sbyte* src, nuint maxlen);

        [NativeName("SDL_strlcat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlcat")]
        static abstract nuint Strlcat(Ref<sbyte> dst, Ref<sbyte> src, nuint maxlen);

        [NativeName("SDL_strlcpy")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlcpy")]
        static abstract nuint Strlcpy(sbyte* dst, sbyte* src, nuint maxlen);

        [NativeName("SDL_strlcpy")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlcpy")]
        static abstract nuint Strlcpy(Ref<sbyte> dst, Ref<sbyte> src, nuint maxlen);

        [NativeName("SDL_strlen")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlen")]
        static abstract nuint Strlen(sbyte* str);

        [NativeName("SDL_strlen")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlen")]
        static abstract nuint Strlen(Ref<sbyte> str);

        [NativeName("SDL_strlwr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlwr")]
        static abstract sbyte* Strlwr(sbyte* str);

        [NativeName("SDL_strlwr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strlwr")]
        static abstract Ptr<sbyte> Strlwr(Ref<sbyte> str);

        [NativeName("SDL_strncasecmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strncasecmp")]
        static abstract int Strncasecmp(sbyte* str1, sbyte* str2, nuint maxlen);

        [NativeName("SDL_strncasecmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strncasecmp")]
        static abstract int Strncasecmp(Ref<sbyte> str1, Ref<sbyte> str2, nuint maxlen);

        [NativeName("SDL_strncmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strncmp")]
        static abstract int Strncmp(sbyte* str1, sbyte* str2, nuint maxlen);

        [NativeName("SDL_strncmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strncmp")]
        static abstract int Strncmp(Ref<sbyte> str1, Ref<sbyte> str2, nuint maxlen);

        [NativeName("SDL_strndup")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strndup")]
        static abstract sbyte* Strndup(sbyte* str, nuint maxlen);

        [NativeName("SDL_strndup")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strndup")]
        static abstract Ptr<sbyte> Strndup(Ref<sbyte> str, nuint maxlen);

        [NativeName("SDL_strnlen")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strnlen")]
        static abstract nuint Strnlen(sbyte* str, nuint maxlen);

        [NativeName("SDL_strnlen")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strnlen")]
        static abstract nuint Strnlen(Ref<sbyte> str, nuint maxlen);

        [NativeName("SDL_strnstr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strnstr")]
        static abstract sbyte* Strnstr(sbyte* haystack, sbyte* needle, nuint maxlen);

        [NativeName("SDL_strnstr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strnstr")]
        static abstract Ptr<sbyte> Strnstr(Ref<sbyte> haystack, Ref<sbyte> needle, nuint maxlen);

        [NativeName("SDL_strpbrk")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strpbrk")]
        static abstract sbyte* Strpbrk(sbyte* str, sbyte* breakset);

        [NativeName("SDL_strpbrk")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strpbrk")]
        static abstract Ptr<sbyte> Strpbrk(Ref<sbyte> str, Ref<sbyte> breakset);

        [NativeName("SDL_strrchr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strrchr")]
        static abstract sbyte* Strrchr(sbyte* str, int c);

        [NativeName("SDL_strrchr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strrchr")]
        static abstract Ptr<sbyte> Strrchr(Ref<sbyte> str, int c);

        [NativeName("SDL_strrev")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strrev")]
        static abstract sbyte* Strrev(sbyte* str);

        [NativeName("SDL_strrev")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strrev")]
        static abstract Ptr<sbyte> Strrev(Ref<sbyte> str);

        [NativeName("SDL_strstr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strstr")]
        static abstract sbyte* Strstr(sbyte* haystack, sbyte* needle);

        [NativeName("SDL_strstr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strstr")]
        static abstract Ptr<sbyte> Strstr(Ref<sbyte> haystack, Ref<sbyte> needle);

        [NativeName("SDL_strtod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtod")]
        static abstract double Strtod(sbyte* str, sbyte** endp);

        [NativeName("SDL_strtod")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtod")]
        static abstract double Strtod(Ref<sbyte> str, Ref2D<sbyte> endp);

        [NativeName("SDL_strtok_r")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtok_r")]
        static abstract sbyte* StrtokR(sbyte* str, sbyte* delim, sbyte** saveptr);

        [NativeName("SDL_strtok_r")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtok_r")]
        static abstract Ptr<sbyte> StrtokR(Ref<sbyte> str, Ref<sbyte> delim, Ref2D<sbyte> saveptr);

        [NativeName("SDL_strtol")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtol")]
        static abstract int Strtol(sbyte* str, sbyte** endp, int @base);

        [NativeName("SDL_strtol")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtol")]
        static abstract int Strtol(Ref<sbyte> str, Ref2D<sbyte> endp, int @base);

        [NativeName("SDL_strtoll")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtoll")]
        static abstract long Strtoll(sbyte* str, sbyte** endp, int @base);

        [NativeName("SDL_strtoll")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtoll")]
        static abstract long Strtoll(Ref<sbyte> str, Ref2D<sbyte> endp, int @base);

        [NativeName("SDL_strtoul")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtoul")]
        static abstract uint Strtoul(sbyte* str, sbyte** endp, int @base);

        [NativeName("SDL_strtoul")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtoul")]
        static abstract uint Strtoul(Ref<sbyte> str, Ref2D<sbyte> endp, int @base);

        [NativeName("SDL_strtoull")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtoull")]
        static abstract ulong Strtoull(sbyte* str, sbyte** endp, int @base);

        [NativeName("SDL_strtoull")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strtoull")]
        static abstract ulong Strtoull(Ref<sbyte> str, Ref2D<sbyte> endp, int @base);

        [NativeName("SDL_strupr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strupr")]
        static abstract sbyte* Strupr(sbyte* str);

        [NativeName("SDL_strupr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_strupr")]
        static abstract Ptr<sbyte> Strupr(Ref<sbyte> str);

        [NativeName("SDL_SubmitGPUCommandBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SubmitGPUCommandBuffer")]
        static abstract MaybeBool<byte> SubmitGpuCommandBuffer(
            GpuCommandBufferHandle command_buffer
        );

        [NativeName("SDL_SubmitGPUCommandBufferAndAcquireFence")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SubmitGPUCommandBufferAndAcquireFence")]
        static abstract GpuFenceHandle SubmitGpuCommandBufferAndAcquireFence(
            GpuCommandBufferHandle command_buffer
        );

        [NativeName("SDL_SubmitGPUCommandBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SubmitGPUCommandBuffer")]
        static abstract byte SubmitGpuCommandBufferRaw(GpuCommandBufferHandle command_buffer);

        [NativeName("SDL_SurfaceHasAlternateImages")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasAlternateImages")]
        static abstract byte SurfaceHasAlternateImages(Surface* surface);

        [NativeName("SDL_SurfaceHasAlternateImages")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasAlternateImages")]
        static abstract MaybeBool<byte> SurfaceHasAlternateImages(Ref<Surface> surface);

        [NativeName("SDL_SurfaceHasColorKey")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasColorKey")]
        static abstract byte SurfaceHasColorKey(Surface* surface);

        [NativeName("SDL_SurfaceHasColorKey")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasColorKey")]
        static abstract MaybeBool<byte> SurfaceHasColorKey(Ref<Surface> surface);

        [NativeName("SDL_SurfaceHasRLE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasRLE")]
        static abstract byte SurfaceHasRle(Surface* surface);

        [NativeName("SDL_SurfaceHasRLE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasRLE")]
        static abstract MaybeBool<byte> SurfaceHasRle(Ref<Surface> surface);

        [NativeName("SDL_SyncWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SyncWindow")]
        static abstract MaybeBool<byte> SyncWindow(WindowHandle window);

        [NativeName("SDL_SyncWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_SyncWindow")]
        static abstract byte SyncWindowRaw(WindowHandle window);

        [NativeName("SDL_tan")]
        [NativeFunction("SDL3", EntryPoint = "SDL_tan")]
        static abstract double Tan(double x);

        [NativeName("SDL_tanf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_tanf")]
        static abstract float Tanf(float x);

        [NativeName("SDL_TellIO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TellIO")]
        static abstract long TellIo(IoStreamHandle context);

        [NativeName("SDL_TextInputActive")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TextInputActive")]
        static abstract MaybeBool<byte> TextInputActive(WindowHandle window);

        [NativeName("SDL_TextInputActive")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TextInputActive")]
        static abstract byte TextInputActiveRaw(WindowHandle window);

        [NativeName("SDL_TimeFromWindows")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TimeFromWindows")]
        static abstract long TimeFromWindows(uint dwLowDateTime, uint dwHighDateTime);

        [NativeName("SDL_TimeToDateTime")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TimeToDateTime")]
        static abstract byte TimeToDateTime(long ticks, DateTime* dt, byte localTime);

        [NativeName("SDL_TimeToDateTime")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TimeToDateTime")]
        static abstract MaybeBool<byte> TimeToDateTime(
            long ticks,
            Ref<DateTime> dt,
            MaybeBool<byte> localTime
        );

        [NativeName("SDL_TimeToWindows")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TimeToWindows")]
        static abstract void TimeToWindows(long ticks, uint* dwLowDateTime, uint* dwHighDateTime);

        [NativeName("SDL_TimeToWindows")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TimeToWindows")]
        static abstract void TimeToWindows(
            long ticks,
            Ref<uint> dwLowDateTime,
            Ref<uint> dwHighDateTime
        );

        [NativeName("SDL_tolower")]
        [NativeFunction("SDL3", EntryPoint = "SDL_tolower")]
        static abstract int Tolower(int x);

        [NativeName("SDL_toupper")]
        [NativeFunction("SDL3", EntryPoint = "SDL_toupper")]
        static abstract int Toupper(int x);

        [NativeName("SDL_trunc")]
        [NativeFunction("SDL3", EntryPoint = "SDL_trunc")]
        static abstract double Trunc(double x);

        [NativeName("SDL_truncf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_truncf")]
        static abstract float Truncf(float x);

        [NativeName("SDL_TryLockMutex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockMutex")]
        static abstract MaybeBool<byte> TryLockMutex(MutexHandle mutex);

        [NativeName("SDL_TryLockMutex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockMutex")]
        static abstract byte TryLockMutexRaw(MutexHandle mutex);

        [NativeName("SDL_TryLockRWLockForReading")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForReading")]
        static abstract MaybeBool<byte> TryLockRwLockForReading(RwLockHandle rwlock);

        [NativeName("SDL_TryLockRWLockForReading")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForReading")]
        static abstract byte TryLockRwLockForReadingRaw(RwLockHandle rwlock);

        [NativeName("SDL_TryLockRWLockForWriting")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForWriting")]
        static abstract MaybeBool<byte> TryLockRwLockForWriting(RwLockHandle rwlock);

        [NativeName("SDL_TryLockRWLockForWriting")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForWriting")]
        static abstract byte TryLockRwLockForWritingRaw(RwLockHandle rwlock);

        [NativeName("SDL_TryLockSpinlock")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockSpinlock")]
        static abstract byte TryLockSpinlock(int* @lock);

        [NativeName("SDL_TryLockSpinlock")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryLockSpinlock")]
        static abstract MaybeBool<byte> TryLockSpinlock(Ref<int> @lock);

        [NativeName("SDL_TryWaitSemaphore")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryWaitSemaphore")]
        static abstract MaybeBool<byte> TryWaitSemaphore(SemaphoreHandle sem);

        [NativeName("SDL_TryWaitSemaphore")]
        [NativeFunction("SDL3", EntryPoint = "SDL_TryWaitSemaphore")]
        static abstract byte TryWaitSemaphoreRaw(SemaphoreHandle sem);

        [NativeName("SDL_UCS4ToUTF8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UCS4ToUTF8")]
        static abstract sbyte* Ucs4ToUtf8(uint codepoint, sbyte* dst);

        [NativeName("SDL_UCS4ToUTF8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UCS4ToUTF8")]
        static abstract Ptr<sbyte> Ucs4ToUtf8(uint codepoint, Ref<sbyte> dst);

        [NativeName("SDL_uitoa")]
        [NativeFunction("SDL3", EntryPoint = "SDL_uitoa")]
        static abstract sbyte* Uitoa(uint value, sbyte* str, int radix);

        [NativeName("SDL_uitoa")]
        [NativeFunction("SDL3", EntryPoint = "SDL_uitoa")]
        static abstract Ptr<sbyte> Uitoa(uint value, Ref<sbyte> str, int radix);

        [NativeName("SDL_ulltoa")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ulltoa")]
        static abstract sbyte* Ulltoa(ulong value, sbyte* str, int radix);

        [NativeName("SDL_ulltoa")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ulltoa")]
        static abstract Ptr<sbyte> Ulltoa(ulong value, Ref<sbyte> str, int radix);

        [NativeName("SDL_ultoa")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ultoa")]
        static abstract sbyte* Ultoa(uint value, sbyte* str, int radix);

        [NativeName("SDL_ultoa")]
        [NativeFunction("SDL3", EntryPoint = "SDL_ultoa")]
        static abstract Ptr<sbyte> Ultoa(uint value, Ref<sbyte> str, int radix);

        [NativeName("SDL_UnbindAudioStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStream")]
        static abstract void UnbindAudioStream(AudioStreamHandle stream);

        [NativeName("SDL_UnbindAudioStreams")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStreams")]
        static abstract void UnbindAudioStreams(AudioStreamHandle* streams, int num_streams);

        [NativeName("SDL_UnbindAudioStreams")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStreams")]
        static abstract void UnbindAudioStreams(Ref<AudioStreamHandle> streams, int num_streams);

        [NativeName("SDL_UnloadObject")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnloadObject")]
        static abstract void UnloadObject(SharedObjectHandle handle);

        [NativeName("SDL_UnlockAudioStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockAudioStream")]
        static abstract MaybeBool<byte> UnlockAudioStream(AudioStreamHandle stream);

        [NativeName("SDL_UnlockAudioStream")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockAudioStream")]
        static abstract byte UnlockAudioStreamRaw(AudioStreamHandle stream);

        [NativeName("SDL_UnlockJoysticks")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockJoysticks")]
        static abstract void UnlockJoysticks();

        [NativeName("SDL_UnlockMutex")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockMutex")]
        static abstract void UnlockMutex(MutexHandle mutex);

        [NativeName("SDL_UnlockProperties")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockProperties")]
        static abstract void UnlockProperties(uint props);

        [NativeName("SDL_UnlockRWLock")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockRWLock")]
        static abstract void UnlockRwLock(RwLockHandle rwlock);

        [NativeName("SDL_UnlockSpinlock")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSpinlock")]
        static abstract void UnlockSpinlock(int* @lock);

        [NativeName("SDL_UnlockSpinlock")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSpinlock")]
        static abstract void UnlockSpinlock(Ref<int> @lock);

        [NativeName("SDL_UnlockSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSurface")]
        static abstract void UnlockSurface(Surface* surface);

        [NativeName("SDL_UnlockSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSurface")]
        static abstract void UnlockSurface(Ref<Surface> surface);

        [NativeName("SDL_UnlockTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockTexture")]
        static abstract void UnlockTexture(Texture* texture);

        [NativeName("SDL_UnlockTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnlockTexture")]
        static abstract void UnlockTexture(Ref<Texture> texture);

        [NativeName("SDL_UnmapGPUTransferBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnmapGPUTransferBuffer")]
        static abstract void UnmapGpuTransferBuffer(
            GpuDeviceHandle device,
            GpuTransferBufferHandle transfer_buffer
        );

        [NativeName("SDL_UnregisterApp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnregisterApp")]
        static abstract void UnregisterApp();

        [NativeName("SDL_unsetenv_unsafe")]
        [NativeFunction("SDL3", EntryPoint = "SDL_unsetenv_unsafe")]
        static abstract int UnsetenvUnsafe(sbyte* name);

        [NativeName("SDL_unsetenv_unsafe")]
        [NativeFunction("SDL3", EntryPoint = "SDL_unsetenv_unsafe")]
        static abstract int UnsetenvUnsafe(Ref<sbyte> name);

        [NativeName("SDL_UnsetEnvironmentVariable")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnsetEnvironmentVariable")]
        static abstract byte UnsetEnvironmentVariable(EnvironmentHandle env, sbyte* name);

        [NativeName("SDL_UnsetEnvironmentVariable")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UnsetEnvironmentVariable")]
        static abstract MaybeBool<byte> UnsetEnvironmentVariable(
            EnvironmentHandle env,
            Ref<sbyte> name
        );

        [NativeName("SDL_UpdateGamepads")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateGamepads")]
        static abstract void UpdateGamepads();

        [NativeName("SDL_UpdateHapticEffect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateHapticEffect")]
        static abstract byte UpdateHapticEffect(
            HapticHandle haptic,
            int effect,
            HapticEffect* data
        );

        [NativeName("SDL_UpdateHapticEffect")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateHapticEffect")]
        static abstract MaybeBool<byte> UpdateHapticEffect(
            HapticHandle haptic,
            int effect,
            Ref<HapticEffect> data
        );

        [NativeName("SDL_UpdateJoysticks")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateJoysticks")]
        static abstract void UpdateJoysticks();

        [NativeName("SDL_UpdateNVTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateNVTexture")]
        static abstract byte UpdateNvTexture(
            Texture* texture,
            Rect* rect,
            byte* Yplane,
            int Ypitch,
            byte* UVplane,
            int UVpitch
        );

        [NativeName("SDL_UpdateNVTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateNVTexture")]
        static abstract MaybeBool<byte> UpdateNvTexture(
            Ref<Texture> texture,
            Ref<Rect> rect,
            Ref<byte> Yplane,
            int Ypitch,
            Ref<byte> UVplane,
            int UVpitch
        );

        [NativeName("SDL_UpdateSensors")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateSensors")]
        static abstract void UpdateSensors();

        [NativeName("SDL_UpdateTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateTexture")]
        static abstract byte UpdateTexture(Texture* texture, Rect* rect, void* pixels, int pitch);

        [NativeName("SDL_UpdateTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateTexture")]
        static abstract MaybeBool<byte> UpdateTexture(
            Ref<Texture> texture,
            Ref<Rect> rect,
            Ref pixels,
            int pitch
        );

        [NativeName("SDL_UpdateWindowSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurface")]
        static abstract MaybeBool<byte> UpdateWindowSurface(WindowHandle window);

        [NativeName("SDL_UpdateWindowSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurface")]
        static abstract byte UpdateWindowSurfaceRaw(WindowHandle window);

        [NativeName("SDL_UpdateWindowSurfaceRects")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurfaceRects")]
        static abstract byte UpdateWindowSurfaceRects(
            WindowHandle window,
            Rect* rects,
            int numrects
        );

        [NativeName("SDL_UpdateWindowSurfaceRects")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurfaceRects")]
        static abstract MaybeBool<byte> UpdateWindowSurfaceRects(
            WindowHandle window,
            Ref<Rect> rects,
            int numrects
        );

        [NativeName("SDL_UpdateYUVTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateYUVTexture")]
        static abstract byte UpdateYuvTexture(
            Texture* texture,
            Rect* rect,
            byte* Yplane,
            int Ypitch,
            byte* Uplane,
            int Upitch,
            byte* Vplane,
            int Vpitch
        );

        [NativeName("SDL_UpdateYUVTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UpdateYUVTexture")]
        static abstract MaybeBool<byte> UpdateYuvTexture(
            Ref<Texture> texture,
            Ref<Rect> rect,
            Ref<byte> Yplane,
            int Ypitch,
            Ref<byte> Uplane,
            int Upitch,
            Ref<byte> Vplane,
            int Vpitch
        );

        [NativeName("SDL_UploadToGPUBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUBuffer")]
        static abstract void UploadToGpuBuffer(
            GpuCopyPassHandle copy_pass,
            GpuTransferBufferLocation* source,
            GpuBufferRegion* destination,
            byte cycle
        );

        [NativeName("SDL_UploadToGPUBuffer")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUBuffer")]
        static abstract void UploadToGpuBuffer(
            GpuCopyPassHandle copy_pass,
            Ref<GpuTransferBufferLocation> source,
            Ref<GpuBufferRegion> destination,
            MaybeBool<byte> cycle
        );

        [NativeName("SDL_UploadToGPUTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUTexture")]
        static abstract void UploadToGpuTexture(
            GpuCopyPassHandle copy_pass,
            GpuTextureTransferInfo* source,
            GpuTextureRegion* destination,
            byte cycle
        );

        [NativeName("SDL_UploadToGPUTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUTexture")]
        static abstract void UploadToGpuTexture(
            GpuCopyPassHandle copy_pass,
            Ref<GpuTextureTransferInfo> source,
            Ref<GpuTextureRegion> destination,
            MaybeBool<byte> cycle
        );

        [NativeName("SDL_utf8strlcpy")]
        [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlcpy")]
        static abstract nuint Utf8Strlcpy(sbyte* dst, sbyte* src, nuint dst_bytes);

        [NativeName("SDL_utf8strlcpy")]
        [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlcpy")]
        static abstract nuint Utf8Strlcpy(Ref<sbyte> dst, Ref<sbyte> src, nuint dst_bytes);

        [NativeName("SDL_utf8strlen")]
        [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlen")]
        static abstract nuint Utf8Strlen(sbyte* str);

        [NativeName("SDL_utf8strlen")]
        [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlen")]
        static abstract nuint Utf8Strlen(Ref<sbyte> str);

        [NativeName("SDL_utf8strnlen")]
        [NativeFunction("SDL3", EntryPoint = "SDL_utf8strnlen")]
        static abstract nuint Utf8Strnlen(sbyte* str, nuint bytes);

        [NativeName("SDL_utf8strnlen")]
        [NativeFunction("SDL3", EntryPoint = "SDL_utf8strnlen")]
        static abstract nuint Utf8Strnlen(Ref<sbyte> str, nuint bytes);

        [NativeName("SDL_vasprintf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_vasprintf")]
        static abstract int Vasprintf(sbyte** strp, sbyte* fmt, sbyte* ap);

        [NativeName("SDL_vasprintf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_vasprintf")]
        static abstract int Vasprintf(Ref2D<sbyte> strp, Ref<sbyte> fmt, Ref<sbyte> ap);

        [NativeName("SDL_vsnprintf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_vsnprintf")]
        static abstract int Vsnprintf(sbyte* text, nuint maxlen, sbyte* fmt, sbyte* ap);

        [NativeName("SDL_vsnprintf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_vsnprintf")]
        static abstract int Vsnprintf(Ref<sbyte> text, nuint maxlen, Ref<sbyte> fmt, Ref<sbyte> ap);

        [NativeName("SDL_vsscanf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_vsscanf")]
        static abstract int Vsscanf(sbyte* text, sbyte* fmt, sbyte* ap);

        [NativeName("SDL_vsscanf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_vsscanf")]
        static abstract int Vsscanf(Ref<sbyte> text, Ref<sbyte> fmt, Ref<sbyte> ap);

        [NativeName("SDL_vswprintf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_vswprintf")]
        static abstract int Vswprintf(ushort* text, nuint maxlen, ushort* fmt, sbyte* ap);

        [NativeName("SDL_vswprintf")]
        [NativeFunction("SDL3", EntryPoint = "SDL_vswprintf")]
        static abstract int Vswprintf(
            Ref<ushort> text,
            nuint maxlen,
            Ref<ushort> fmt,
            Ref<sbyte> ap
        );

        [NativeName("SDL_Vulkan_CreateSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_CreateSurface")]
        static abstract byte VulkanCreateSurface(
            WindowHandle window,
            void* instance,
            void* allocator,
            ulong* surface
        );

        [NativeName("SDL_Vulkan_CreateSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_CreateSurface")]
        static abstract MaybeBool<byte> VulkanCreateSurface(
            WindowHandle window,
            Ref instance,
            Ref allocator,
            Ref<ulong> surface
        );

        [NativeName("SDL_Vulkan_DestroySurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_DestroySurface")]
        static abstract void VulkanDestroySurface(void* instance, ulong surface, void* allocator);

        [NativeName("SDL_Vulkan_DestroySurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_DestroySurface")]
        static abstract void VulkanDestroySurface(Ref instance, ulong surface, Ref allocator);

        [NativeName("SDL_Vulkan_GetInstanceExtensions")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        static abstract sbyte** VulkanGetInstanceExtensions(uint* count);

        [NativeName("SDL_Vulkan_GetInstanceExtensions")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        static abstract Ptr2D<sbyte> VulkanGetInstanceExtensions(Ref<uint> count);

        [NativeName("SDL_Vulkan_GetPresentationSupport")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetPresentationSupport")]
        static abstract byte VulkanGetPresentationSupport(
            void* instance,
            ulong physicalDevice,
            uint queueFamilyIndex
        );

        [NativeName("SDL_Vulkan_GetPresentationSupport")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetPresentationSupport")]
        static abstract MaybeBool<byte> VulkanGetPresentationSupport(
            Ref instance,
            ulong physicalDevice,
            uint queueFamilyIndex
        );

        [NativeName("SDL_Vulkan_GetVkGetInstanceProcAddr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetVkGetInstanceProcAddr")]
        static abstract FunctionPointer VulkanGetVkGetInstanceProcAddr();

        [NativeName("SDL_Vulkan_LoadLibrary")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_LoadLibrary")]
        static abstract byte VulkanLoadLibrary(sbyte* path);

        [NativeName("SDL_Vulkan_LoadLibrary")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_LoadLibrary")]
        static abstract MaybeBool<byte> VulkanLoadLibrary(Ref<sbyte> path);

        [NativeName("SDL_Vulkan_UnloadLibrary")]
        [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_UnloadLibrary")]
        static abstract void VulkanUnloadLibrary();

        [NativeName("SDL_WaitAndAcquireGPUSwapchainTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitAndAcquireGPUSwapchainTexture")]
        static abstract byte WaitAndAcquireGpuSwapchainTexture(
            GpuCommandBufferHandle command_buffer,
            WindowHandle window,
            GpuTextureHandle* swapchain_texture,
            uint* swapchain_texture_width,
            uint* swapchain_texture_height
        );

        [NativeName("SDL_WaitAndAcquireGPUSwapchainTexture")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitAndAcquireGPUSwapchainTexture")]
        static abstract MaybeBool<byte> WaitAndAcquireGpuSwapchainTexture(
            GpuCommandBufferHandle command_buffer,
            WindowHandle window,
            Ref<GpuTextureHandle> swapchain_texture,
            Ref<uint> swapchain_texture_width,
            Ref<uint> swapchain_texture_height
        );

        [NativeName("SDL_WaitCondition")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitCondition")]
        static abstract void WaitCondition(ConditionHandle cond, MutexHandle mutex);

        [NativeName("SDL_WaitConditionTimeout")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitConditionTimeout")]
        static abstract MaybeBool<byte> WaitConditionTimeout(
            ConditionHandle cond,
            MutexHandle mutex,
            int timeoutMS
        );

        [NativeName("SDL_WaitConditionTimeout")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitConditionTimeout")]
        static abstract byte WaitConditionTimeoutRaw(
            ConditionHandle cond,
            MutexHandle mutex,
            int timeoutMS
        );

        [NativeName("SDL_WaitEvent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitEvent")]
        static abstract byte WaitEvent(Event* @event);

        [NativeName("SDL_WaitEvent")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitEvent")]
        static abstract MaybeBool<byte> WaitEvent(Ref<Event> @event);

        [NativeName("SDL_WaitEventTimeout")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitEventTimeout")]
        static abstract byte WaitEventTimeout(Event* @event, int timeoutMS);

        [NativeName("SDL_WaitEventTimeout")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitEventTimeout")]
        static abstract MaybeBool<byte> WaitEventTimeout(Ref<Event> @event, int timeoutMS);

        [NativeName("SDL_WaitForGPUFences")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUFences")]
        static abstract byte WaitForGpuFences(
            GpuDeviceHandle device,
            byte wait_all,
            GpuFenceHandle* fences,
            uint num_fences
        );

        [NativeName("SDL_WaitForGPUFences")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUFences")]
        static abstract MaybeBool<byte> WaitForGpuFences(
            GpuDeviceHandle device,
            MaybeBool<byte> wait_all,
            Ref<GpuFenceHandle> fences,
            uint num_fences
        );

        [NativeName("SDL_WaitForGPUIdle")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUIdle")]
        static abstract MaybeBool<byte> WaitForGpuIdle(GpuDeviceHandle device);

        [NativeName("SDL_WaitForGPUIdle")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUIdle")]
        static abstract byte WaitForGpuIdleRaw(GpuDeviceHandle device);

        [NativeName("SDL_WaitForGPUSwapchain")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUSwapchain")]
        static abstract MaybeBool<byte> WaitForGpuSwapchain(
            GpuDeviceHandle device,
            WindowHandle window
        );

        [NativeName("SDL_WaitForGPUSwapchain")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUSwapchain")]
        static abstract byte WaitForGpuSwapchainRaw(GpuDeviceHandle device, WindowHandle window);

        [NativeName("SDL_WaitProcess")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitProcess")]
        static abstract byte WaitProcess(ProcessHandle process, byte block, int* exitcode);

        [NativeName("SDL_WaitProcess")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitProcess")]
        static abstract MaybeBool<byte> WaitProcess(
            ProcessHandle process,
            MaybeBool<byte> block,
            Ref<int> exitcode
        );

        [NativeName("SDL_WaitSemaphore")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphore")]
        static abstract void WaitSemaphore(SemaphoreHandle sem);

        [NativeName("SDL_WaitSemaphoreTimeout")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphoreTimeout")]
        static abstract MaybeBool<byte> WaitSemaphoreTimeout(SemaphoreHandle sem, int timeoutMS);

        [NativeName("SDL_WaitSemaphoreTimeout")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphoreTimeout")]
        static abstract byte WaitSemaphoreTimeoutRaw(SemaphoreHandle sem, int timeoutMS);

        [NativeName("SDL_WaitThread")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitThread")]
        static abstract void WaitThread(ThreadHandle thread, int* status);

        [NativeName("SDL_WaitThread")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WaitThread")]
        static abstract void WaitThread(ThreadHandle thread, Ref<int> status);

        [NativeName("SDL_WarpMouseGlobal")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseGlobal")]
        static abstract MaybeBool<byte> WarpMouseGlobal(float x, float y);

        [NativeName("SDL_WarpMouseGlobal")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseGlobal")]
        static abstract byte WarpMouseGlobalRaw(float x, float y);

        [NativeName("SDL_WarpMouseInWindow")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseInWindow")]
        static abstract void WarpMouseInWindow(WindowHandle window, float x, float y);

        [NativeName("SDL_WasInit")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WasInit")]
        static abstract uint WasInit(uint flags);

        [NativeName("SDL_wcscasecmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcscasecmp")]
        static abstract int Wcscasecmp(ushort* str1, ushort* str2);

        [NativeName("SDL_wcscasecmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcscasecmp")]
        static abstract int Wcscasecmp(Ref<ushort> str1, Ref<ushort> str2);

        [NativeName("SDL_wcscmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcscmp")]
        static abstract int Wcscmp(ushort* str1, ushort* str2);

        [NativeName("SDL_wcscmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcscmp")]
        static abstract int Wcscmp(Ref<ushort> str1, Ref<ushort> str2);

        [NativeName("SDL_wcsdup")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsdup")]
        static abstract ushort* Wcsdup(ushort* wstr);

        [NativeName("SDL_wcsdup")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsdup")]
        static abstract Ptr<ushort> Wcsdup(Ref<ushort> wstr);

        [NativeName("SDL_wcslcat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcslcat")]
        static abstract nuint Wcslcat(ushort* dst, ushort* src, nuint maxlen);

        [NativeName("SDL_wcslcat")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcslcat")]
        static abstract nuint Wcslcat(Ref<ushort> dst, Ref<ushort> src, nuint maxlen);

        [NativeName("SDL_wcslcpy")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcslcpy")]
        static abstract nuint Wcslcpy(ushort* dst, ushort* src, nuint maxlen);

        [NativeName("SDL_wcslcpy")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcslcpy")]
        static abstract nuint Wcslcpy(Ref<ushort> dst, Ref<ushort> src, nuint maxlen);

        [NativeName("SDL_wcslen")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcslen")]
        static abstract nuint Wcslen(ushort* wstr);

        [NativeName("SDL_wcslen")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcslen")]
        static abstract nuint Wcslen(Ref<ushort> wstr);

        [NativeName("SDL_wcsncasecmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsncasecmp")]
        static abstract int Wcsncasecmp(ushort* str1, ushort* str2, nuint maxlen);

        [NativeName("SDL_wcsncasecmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsncasecmp")]
        static abstract int Wcsncasecmp(Ref<ushort> str1, Ref<ushort> str2, nuint maxlen);

        [NativeName("SDL_wcsncmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsncmp")]
        static abstract int Wcsncmp(ushort* str1, ushort* str2, nuint maxlen);

        [NativeName("SDL_wcsncmp")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsncmp")]
        static abstract int Wcsncmp(Ref<ushort> str1, Ref<ushort> str2, nuint maxlen);

        [NativeName("SDL_wcsnlen")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsnlen")]
        static abstract nuint Wcsnlen(ushort* wstr, nuint maxlen);

        [NativeName("SDL_wcsnlen")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsnlen")]
        static abstract nuint Wcsnlen(Ref<ushort> wstr, nuint maxlen);

        [NativeName("SDL_wcsnstr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsnstr")]
        static abstract ushort* Wcsnstr(ushort* haystack, ushort* needle, nuint maxlen);

        [NativeName("SDL_wcsnstr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsnstr")]
        static abstract Ptr<ushort> Wcsnstr(Ref<ushort> haystack, Ref<ushort> needle, nuint maxlen);

        [NativeName("SDL_wcsstr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsstr")]
        static abstract ushort* Wcsstr(ushort* haystack, ushort* needle);

        [NativeName("SDL_wcsstr")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcsstr")]
        static abstract Ptr<ushort> Wcsstr(Ref<ushort> haystack, Ref<ushort> needle);

        [NativeName("SDL_wcstol")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcstol")]
        static abstract int Wcstol(ushort* str, ushort** endp, int @base);

        [NativeName("SDL_wcstol")]
        [NativeFunction("SDL3", EntryPoint = "SDL_wcstol")]
        static abstract int Wcstol(Ref<ushort> str, Ref2D<ushort> endp, int @base);

        [NativeName("SDL_WindowHasSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WindowHasSurface")]
        static abstract MaybeBool<byte> WindowHasSurface(WindowHandle window);

        [NativeName("SDL_WindowHasSurface")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WindowHasSurface")]
        static abstract byte WindowHasSurfaceRaw(WindowHandle window);

        [NativeName("SDL_WindowSupportsGPUPresentMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUPresentMode")]
        static abstract MaybeBool<byte> WindowSupportsGpuPresentMode(
            GpuDeviceHandle device,
            WindowHandle window,
            GpuPresentMode present_mode
        );

        [NativeName("SDL_WindowSupportsGPUPresentMode")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUPresentMode")]
        static abstract byte WindowSupportsGpuPresentModeRaw(
            GpuDeviceHandle device,
            WindowHandle window,
            GpuPresentMode present_mode
        );

        [NativeName("SDL_WindowSupportsGPUSwapchainComposition")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUSwapchainComposition")]
        static abstract MaybeBool<byte> WindowSupportsGpuSwapchainComposition(
            GpuDeviceHandle device,
            WindowHandle window,
            GpuSwapchainComposition swapchain_composition
        );

        [NativeName("SDL_WindowSupportsGPUSwapchainComposition")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUSwapchainComposition")]
        static abstract byte WindowSupportsGpuSwapchainCompositionRaw(
            GpuDeviceHandle device,
            WindowHandle window,
            GpuSwapchainComposition swapchain_composition
        );

        [NativeName("SDL_WriteIO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteIO")]
        static abstract nuint WriteIo(IoStreamHandle context, void* ptr, nuint size);

        [NativeName("SDL_WriteIO")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteIO")]
        static abstract nuint WriteIo(IoStreamHandle context, Ref ptr, nuint size);

        [NativeName("SDL_WriteS16BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16BE")]
        static abstract MaybeBool<byte> WriteS16Be(IoStreamHandle dst, short value);

        [NativeName("SDL_WriteS16BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16BE")]
        static abstract byte WriteS16BeRaw(IoStreamHandle dst, short value);

        [NativeName("SDL_WriteS16LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16LE")]
        static abstract MaybeBool<byte> WriteS16Le(IoStreamHandle dst, short value);

        [NativeName("SDL_WriteS16LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16LE")]
        static abstract byte WriteS16LeRaw(IoStreamHandle dst, short value);

        [NativeName("SDL_WriteS32BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32BE")]
        static abstract MaybeBool<byte> WriteS32Be(IoStreamHandle dst, int value);

        [NativeName("SDL_WriteS32BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32BE")]
        static abstract byte WriteS32BeRaw(IoStreamHandle dst, int value);

        [NativeName("SDL_WriteS32LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32LE")]
        static abstract MaybeBool<byte> WriteS32Le(IoStreamHandle dst, int value);

        [NativeName("SDL_WriteS32LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32LE")]
        static abstract byte WriteS32LeRaw(IoStreamHandle dst, int value);

        [NativeName("SDL_WriteS64BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64BE")]
        static abstract MaybeBool<byte> WriteS64Be(IoStreamHandle dst, long value);

        [NativeName("SDL_WriteS64BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64BE")]
        static abstract byte WriteS64BeRaw(IoStreamHandle dst, long value);

        [NativeName("SDL_WriteS64LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64LE")]
        static abstract MaybeBool<byte> WriteS64Le(IoStreamHandle dst, long value);

        [NativeName("SDL_WriteS64LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64LE")]
        static abstract byte WriteS64LeRaw(IoStreamHandle dst, long value);

        [NativeName("SDL_WriteS8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS8")]
        static abstract MaybeBool<byte> WriteS8(IoStreamHandle dst, sbyte value);

        [NativeName("SDL_WriteS8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteS8")]
        static abstract byte WriteS8Raw(IoStreamHandle dst, sbyte value);

        [NativeName("SDL_WriteStorageFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteStorageFile")]
        static abstract byte WriteStorageFile(
            StorageHandle storage,
            sbyte* path,
            void* source,
            ulong length
        );

        [NativeName("SDL_WriteStorageFile")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteStorageFile")]
        static abstract MaybeBool<byte> WriteStorageFile(
            StorageHandle storage,
            Ref<sbyte> path,
            Ref source,
            ulong length
        );

        [NativeName("SDL_WriteSurfacePixel")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteSurfacePixel")]
        static abstract byte WriteSurfacePixel(
            Surface* surface,
            int x,
            int y,
            byte r,
            byte g,
            byte b,
            byte a
        );

        [NativeName("SDL_WriteSurfacePixel")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteSurfacePixel")]
        static abstract MaybeBool<byte> WriteSurfacePixel(
            Ref<Surface> surface,
            int x,
            int y,
            byte r,
            byte g,
            byte b,
            byte a
        );

        [NativeName("SDL_WriteSurfacePixelFloat")]
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

        [NativeName("SDL_WriteSurfacePixelFloat")]
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

        [NativeName("SDL_WriteU16BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16BE")]
        static abstract MaybeBool<byte> WriteU16Be(IoStreamHandle dst, ushort value);

        [NativeName("SDL_WriteU16BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16BE")]
        static abstract byte WriteU16BeRaw(IoStreamHandle dst, ushort value);

        [NativeName("SDL_WriteU16LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16LE")]
        static abstract MaybeBool<byte> WriteU16Le(IoStreamHandle dst, ushort value);

        [NativeName("SDL_WriteU16LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16LE")]
        static abstract byte WriteU16LeRaw(IoStreamHandle dst, ushort value);

        [NativeName("SDL_WriteU32BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32BE")]
        static abstract MaybeBool<byte> WriteU32Be(IoStreamHandle dst, uint value);

        [NativeName("SDL_WriteU32BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32BE")]
        static abstract byte WriteU32BeRaw(IoStreamHandle dst, uint value);

        [NativeName("SDL_WriteU32LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32LE")]
        static abstract MaybeBool<byte> WriteU32Le(IoStreamHandle dst, uint value);

        [NativeName("SDL_WriteU32LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32LE")]
        static abstract byte WriteU32LeRaw(IoStreamHandle dst, uint value);

        [NativeName("SDL_WriteU64BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64BE")]
        static abstract MaybeBool<byte> WriteU64Be(IoStreamHandle dst, ulong value);

        [NativeName("SDL_WriteU64BE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64BE")]
        static abstract byte WriteU64BeRaw(IoStreamHandle dst, ulong value);

        [NativeName("SDL_WriteU64LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64LE")]
        static abstract MaybeBool<byte> WriteU64Le(IoStreamHandle dst, ulong value);

        [NativeName("SDL_WriteU64LE")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64LE")]
        static abstract byte WriteU64LeRaw(IoStreamHandle dst, ulong value);

        [NativeName("SDL_WriteU8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU8")]
        static abstract MaybeBool<byte> WriteU8(IoStreamHandle dst, byte value);

        [NativeName("SDL_WriteU8")]
        [NativeFunction("SDL3", EntryPoint = "SDL_WriteU8")]
        static abstract byte WriteU8Raw(IoStreamHandle dst, byte value);
    }

    [NativeName("SDL_abs")]
    [NativeFunction("SDL3", EntryPoint = "SDL_abs")]
    int Abs(int x);

    [NativeName("SDL_acos")]
    [NativeFunction("SDL3", EntryPoint = "SDL_acos")]
    double Acos(double x);

    [NativeName("SDL_acosf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_acosf")]
    float Acosf(float x);

    [NativeName("SDL_AcquireCameraFrame")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AcquireCameraFrame")]
    Surface* AcquireCameraFrame(CameraHandle camera, ulong* timestampNS);

    [NativeName("SDL_AcquireCameraFrame")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AcquireCameraFrame")]
    Ptr<Surface> AcquireCameraFrame(CameraHandle camera, Ref<ulong> timestampNS);

    [NativeName("SDL_AcquireGPUCommandBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AcquireGPUCommandBuffer")]
    GpuCommandBufferHandle AcquireGpuCommandBuffer(GpuDeviceHandle device);

    [NativeName("SDL_AcquireGPUSwapchainTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AcquireGPUSwapchainTexture")]
    byte AcquireGpuSwapchainTexture(
        GpuCommandBufferHandle command_buffer,
        WindowHandle window,
        GpuTextureHandle* swapchain_texture,
        uint* swapchain_texture_width,
        uint* swapchain_texture_height
    );

    [NativeName("SDL_AcquireGPUSwapchainTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AcquireGPUSwapchainTexture")]
    MaybeBool<byte> AcquireGpuSwapchainTexture(
        GpuCommandBufferHandle command_buffer,
        WindowHandle window,
        Ref<GpuTextureHandle> swapchain_texture,
        Ref<uint> swapchain_texture_width,
        Ref<uint> swapchain_texture_height
    );

    [NativeName("SDL_AddAtomicInt")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddAtomicInt")]
    int AddAtomicInt(AtomicInt* a, int v);

    [NativeName("SDL_AddAtomicInt")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddAtomicInt")]
    int AddAtomicInt(Ref<AtomicInt> a, int v);

    [NativeName("SDL_AddEventWatch")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddEventWatch")]
    byte AddEventWatch(EventFilter filter, void* userdata);

    [NativeName("SDL_AddEventWatch")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddEventWatch")]
    MaybeBool<byte> AddEventWatch(EventFilter filter, Ref userdata);

    [NativeName("SDL_AddGamepadMapping")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMapping")]
    int AddGamepadMapping(sbyte* mapping);

    [NativeName("SDL_AddGamepadMapping")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMapping")]
    int AddGamepadMapping(Ref<sbyte> mapping);

    [NativeName("SDL_AddGamepadMappingsFromFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromFile")]
    int AddGamepadMappingsFromFile(sbyte* file);

    [NativeName("SDL_AddGamepadMappingsFromFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromFile")]
    int AddGamepadMappingsFromFile(Ref<sbyte> file);

    [NativeName("SDL_AddGamepadMappingsFromIO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromIO")]
    int AddGamepadMappingsFromIo(IoStreamHandle src, byte closeio);

    [NativeName("SDL_AddGamepadMappingsFromIO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddGamepadMappingsFromIO")]
    int AddGamepadMappingsFromIo(IoStreamHandle src, MaybeBool<byte> closeio);

    [NativeName("SDL_AddHintCallback")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddHintCallback")]
    byte AddHintCallback(sbyte* name, HintCallback callback, void* userdata);

    [NativeName("SDL_AddHintCallback")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddHintCallback")]
    MaybeBool<byte> AddHintCallback(Ref<sbyte> name, HintCallback callback, Ref userdata);

    [NativeName("SDL_AddSurfaceAlternateImage")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddSurfaceAlternateImage")]
    byte AddSurfaceAlternateImage(Surface* surface, Surface* image);

    [NativeName("SDL_AddSurfaceAlternateImage")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddSurfaceAlternateImage")]
    MaybeBool<byte> AddSurfaceAlternateImage(Ref<Surface> surface, Ref<Surface> image);

    [NativeName("SDL_AddTimer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddTimer")]
    uint AddTimer(uint interval, TimerCallback callback, void* userdata);

    [NativeName("SDL_AddTimer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddTimer")]
    uint AddTimer(uint interval, TimerCallback callback, Ref userdata);

    [NativeName("SDL_AddTimerNS")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddTimerNS")]
    uint AddTimerNs(ulong interval, NsTimerCallback callback, void* userdata);

    [NativeName("SDL_AddTimerNS")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddTimerNS")]
    uint AddTimerNs(ulong interval, NsTimerCallback callback, Ref userdata);

    [NativeName("SDL_AddVulkanRenderSemaphores")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddVulkanRenderSemaphores")]
    MaybeBool<byte> AddVulkanRenderSemaphores(
        RendererHandle renderer,
        uint wait_stage_mask,
        long wait_semaphore,
        long signal_semaphore
    );

    [NativeName("SDL_AddVulkanRenderSemaphores")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AddVulkanRenderSemaphores")]
    byte AddVulkanRenderSemaphoresRaw(
        RendererHandle renderer,
        uint wait_stage_mask,
        long wait_semaphore,
        long signal_semaphore
    );

    [NativeName("SDL_aligned_alloc")]
    [NativeFunction("SDL3", EntryPoint = "SDL_aligned_alloc")]
    Ptr AlignedAlloc(nuint alignment, nuint size);

    [NativeName("SDL_aligned_alloc")]
    [NativeFunction("SDL3", EntryPoint = "SDL_aligned_alloc")]
    void* AlignedAllocRaw(nuint alignment, nuint size);

    [NativeName("SDL_aligned_free")]
    [NativeFunction("SDL3", EntryPoint = "SDL_aligned_free")]
    void AlignedFree(void* mem);

    [NativeName("SDL_aligned_free")]
    [NativeFunction("SDL3", EntryPoint = "SDL_aligned_free")]
    void AlignedFree(Ref mem);

    [NativeName("SDL_asin")]
    [NativeFunction("SDL3", EntryPoint = "SDL_asin")]
    double Asin(double x);

    [NativeName("SDL_asinf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_asinf")]
    float Asinf(float x);

    [NativeName("SDL_atan")]
    [NativeFunction("SDL3", EntryPoint = "SDL_atan")]
    double Atan(double x);

    [NativeName("SDL_atan2")]
    [NativeFunction("SDL3", EntryPoint = "SDL_atan2")]
    double Atan2(double y, double x);

    [NativeName("SDL_atan2f")]
    [NativeFunction("SDL3", EntryPoint = "SDL_atan2f")]
    float Atan2F(float y, float x);

    [NativeName("SDL_atanf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_atanf")]
    float Atanf(float x);

    [NativeName("SDL_atof")]
    [NativeFunction("SDL3", EntryPoint = "SDL_atof")]
    double Atof(sbyte* str);

    [NativeName("SDL_atof")]
    [NativeFunction("SDL3", EntryPoint = "SDL_atof")]
    double Atof(Ref<sbyte> str);

    [NativeName("SDL_atoi")]
    [NativeFunction("SDL3", EntryPoint = "SDL_atoi")]
    int Atoi(sbyte* str);

    [NativeName("SDL_atoi")]
    [NativeFunction("SDL3", EntryPoint = "SDL_atoi")]
    int Atoi(Ref<sbyte> str);

    [NativeName("SDL_AttachVirtualJoystick")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AttachVirtualJoystick")]
    uint AttachVirtualJoystick(VirtualJoystickDesc* desc);

    [NativeName("SDL_AttachVirtualJoystick")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AttachVirtualJoystick")]
    uint AttachVirtualJoystick(Ref<VirtualJoystickDesc> desc);

    [NativeName("SDL_AudioDevicePaused")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AudioDevicePaused")]
    MaybeBool<byte> AudioDevicePaused(uint devid);

    [NativeName("SDL_AudioDevicePaused")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AudioDevicePaused")]
    byte AudioDevicePausedRaw(uint devid);

    [NativeName("SDL_AudioStreamDevicePaused")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AudioStreamDevicePaused")]
    MaybeBool<byte> AudioStreamDevicePaused(AudioStreamHandle stream);

    [NativeName("SDL_AudioStreamDevicePaused")]
    [NativeFunction("SDL3", EntryPoint = "SDL_AudioStreamDevicePaused")]
    byte AudioStreamDevicePausedRaw(AudioStreamHandle stream);

    [NativeName("SDL_BeginGPUComputePass")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPUComputePass")]
    GpuComputePassHandle BeginGpuComputePass(
        GpuCommandBufferHandle command_buffer,
        GpuStorageTextureReadWriteBinding* storage_texture_bindings,
        uint num_storage_texture_bindings,
        GpuStorageBufferReadWriteBinding* storage_buffer_bindings,
        uint num_storage_buffer_bindings
    );

    [NativeName("SDL_BeginGPUComputePass")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPUComputePass")]
    GpuComputePassHandle BeginGpuComputePass(
        GpuCommandBufferHandle command_buffer,
        Ref<GpuStorageTextureReadWriteBinding> storage_texture_bindings,
        uint num_storage_texture_bindings,
        Ref<GpuStorageBufferReadWriteBinding> storage_buffer_bindings,
        uint num_storage_buffer_bindings
    );

    [NativeName("SDL_BeginGPUCopyPass")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPUCopyPass")]
    GpuCopyPassHandle BeginGpuCopyPass(GpuCommandBufferHandle command_buffer);

    [NativeName("SDL_BeginGPURenderPass")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPURenderPass")]
    GpuRenderPassHandle BeginGpuRenderPass(
        GpuCommandBufferHandle command_buffer,
        GpuColorTargetInfo* color_target_infos,
        uint num_color_targets,
        GpuDepthStencilTargetInfo* depth_stencil_target_info
    );

    [NativeName("SDL_BeginGPURenderPass")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BeginGPURenderPass")]
    GpuRenderPassHandle BeginGpuRenderPass(
        GpuCommandBufferHandle command_buffer,
        Ref<GpuColorTargetInfo> color_target_infos,
        uint num_color_targets,
        Ref<GpuDepthStencilTargetInfo> depth_stencil_target_info
    );

    [NativeName("SDL_BindAudioStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStream")]
    MaybeBool<byte> BindAudioStream(uint devid, AudioStreamHandle stream);

    [NativeName("SDL_BindAudioStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStream")]
    byte BindAudioStreamRaw(uint devid, AudioStreamHandle stream);

    [NativeName("SDL_BindAudioStreams")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStreams")]
    byte BindAudioStreams(uint devid, AudioStreamHandle* streams, int num_streams);

    [NativeName("SDL_BindAudioStreams")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindAudioStreams")]
    MaybeBool<byte> BindAudioStreams(uint devid, Ref<AudioStreamHandle> streams, int num_streams);

    [NativeName("SDL_BindGPUComputePipeline")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputePipeline")]
    void BindGpuComputePipeline(
        GpuComputePassHandle compute_pass,
        GpuComputePipelineHandle compute_pipeline
    );

    [NativeName("SDL_BindGPUComputeSamplers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeSamplers")]
    void BindGpuComputeSamplers(
        GpuComputePassHandle compute_pass,
        uint first_slot,
        GpuTextureSamplerBinding* texture_sampler_bindings,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUComputeSamplers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeSamplers")]
    void BindGpuComputeSamplers(
        GpuComputePassHandle compute_pass,
        uint first_slot,
        Ref<GpuTextureSamplerBinding> texture_sampler_bindings,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUComputeStorageBuffers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageBuffers")]
    void BindGpuComputeStorageBuffers(
        GpuComputePassHandle compute_pass,
        uint first_slot,
        GpuBufferHandle* storage_buffers,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUComputeStorageBuffers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageBuffers")]
    void BindGpuComputeStorageBuffers(
        GpuComputePassHandle compute_pass,
        uint first_slot,
        Ref<GpuBufferHandle> storage_buffers,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUComputeStorageTextures")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageTextures")]
    void BindGpuComputeStorageTextures(
        GpuComputePassHandle compute_pass,
        uint first_slot,
        GpuTextureHandle* storage_textures,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUComputeStorageTextures")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUComputeStorageTextures")]
    void BindGpuComputeStorageTextures(
        GpuComputePassHandle compute_pass,
        uint first_slot,
        Ref<GpuTextureHandle> storage_textures,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUFragmentSamplers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentSamplers")]
    void BindGpuFragmentSamplers(
        GpuRenderPassHandle render_pass,
        uint first_slot,
        GpuTextureSamplerBinding* texture_sampler_bindings,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUFragmentSamplers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentSamplers")]
    void BindGpuFragmentSamplers(
        GpuRenderPassHandle render_pass,
        uint first_slot,
        Ref<GpuTextureSamplerBinding> texture_sampler_bindings,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUFragmentStorageBuffers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageBuffers")]
    void BindGpuFragmentStorageBuffers(
        GpuRenderPassHandle render_pass,
        uint first_slot,
        GpuBufferHandle* storage_buffers,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUFragmentStorageBuffers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageBuffers")]
    void BindGpuFragmentStorageBuffers(
        GpuRenderPassHandle render_pass,
        uint first_slot,
        Ref<GpuBufferHandle> storage_buffers,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUFragmentStorageTextures")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageTextures")]
    void BindGpuFragmentStorageTextures(
        GpuRenderPassHandle render_pass,
        uint first_slot,
        GpuTextureHandle* storage_textures,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUFragmentStorageTextures")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUFragmentStorageTextures")]
    void BindGpuFragmentStorageTextures(
        GpuRenderPassHandle render_pass,
        uint first_slot,
        Ref<GpuTextureHandle> storage_textures,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUGraphicsPipeline")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUGraphicsPipeline")]
    void BindGpuGraphicsPipeline(
        GpuRenderPassHandle render_pass,
        GpuGraphicsPipelineHandle graphics_pipeline
    );

    [NativeName("SDL_BindGPUIndexBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUIndexBuffer")]
    void BindGpuIndexBuffer(
        GpuRenderPassHandle render_pass,
        GpuBufferBinding* binding,
        GpuIndexElementSize index_element_size
    );

    [NativeName("SDL_BindGPUIndexBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUIndexBuffer")]
    void BindGpuIndexBuffer(
        GpuRenderPassHandle render_pass,
        Ref<GpuBufferBinding> binding,
        GpuIndexElementSize index_element_size
    );

    [NativeName("SDL_BindGPUVertexBuffers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexBuffers")]
    void BindGpuVertexBuffers(
        GpuRenderPassHandle render_pass,
        uint first_slot,
        GpuBufferBinding* bindings,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUVertexBuffers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexBuffers")]
    void BindGpuVertexBuffers(
        GpuRenderPassHandle render_pass,
        uint first_slot,
        Ref<GpuBufferBinding> bindings,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUVertexSamplers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexSamplers")]
    void BindGpuVertexSamplers(
        GpuRenderPassHandle render_pass,
        uint first_slot,
        GpuTextureSamplerBinding* texture_sampler_bindings,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUVertexSamplers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexSamplers")]
    void BindGpuVertexSamplers(
        GpuRenderPassHandle render_pass,
        uint first_slot,
        Ref<GpuTextureSamplerBinding> texture_sampler_bindings,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUVertexStorageBuffers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageBuffers")]
    void BindGpuVertexStorageBuffers(
        GpuRenderPassHandle render_pass,
        uint first_slot,
        GpuBufferHandle* storage_buffers,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUVertexStorageBuffers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageBuffers")]
    void BindGpuVertexStorageBuffers(
        GpuRenderPassHandle render_pass,
        uint first_slot,
        Ref<GpuBufferHandle> storage_buffers,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUVertexStorageTextures")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageTextures")]
    void BindGpuVertexStorageTextures(
        GpuRenderPassHandle render_pass,
        uint first_slot,
        GpuTextureHandle* storage_textures,
        uint num_bindings
    );

    [NativeName("SDL_BindGPUVertexStorageTextures")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BindGPUVertexStorageTextures")]
    void BindGpuVertexStorageTextures(
        GpuRenderPassHandle render_pass,
        uint first_slot,
        Ref<GpuTextureHandle> storage_textures,
        uint num_bindings
    );

    [NativeName("SDL_BlitGPUTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitGPUTexture")]
    void BlitGpuTexture(GpuCommandBufferHandle command_buffer, GpuBlitInfo* info);

    [NativeName("SDL_BlitGPUTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitGPUTexture")]
    void BlitGpuTexture(GpuCommandBufferHandle command_buffer, Ref<GpuBlitInfo> info);

    [NativeName("SDL_BlitSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface")]
    byte BlitSurface(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

    [NativeName("SDL_BlitSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface")]
    MaybeBool<byte> BlitSurface(
        Ref<Surface> src,
        Ref<Rect> srcrect,
        Ref<Surface> dst,
        Ref<Rect> dstrect
    );

    [NativeName("SDL_BlitSurface9Grid")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface9Grid")]
    byte BlitSurface9Grid(
        Surface* src,
        Rect* srcrect,
        int left_width,
        int right_width,
        int top_height,
        int bottom_height,
        float scale,
        ScaleMode scaleMode,
        Surface* dst,
        Rect* dstrect
    );

    [NativeName("SDL_BlitSurface9Grid")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurface9Grid")]
    MaybeBool<byte> BlitSurface9Grid(
        Ref<Surface> src,
        Ref<Rect> srcrect,
        int left_width,
        int right_width,
        int top_height,
        int bottom_height,
        float scale,
        ScaleMode scaleMode,
        Ref<Surface> dst,
        Ref<Rect> dstrect
    );

    [NativeName("SDL_BlitSurfaceScaled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceScaled")]
    byte BlitSurfaceScaled(
        Surface* src,
        Rect* srcrect,
        Surface* dst,
        Rect* dstrect,
        ScaleMode scaleMode
    );

    [NativeName("SDL_BlitSurfaceScaled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceScaled")]
    MaybeBool<byte> BlitSurfaceScaled(
        Ref<Surface> src,
        Ref<Rect> srcrect,
        Ref<Surface> dst,
        Ref<Rect> dstrect,
        ScaleMode scaleMode
    );

    [NativeName("SDL_BlitSurfaceTiled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiled")]
    byte BlitSurfaceTiled(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

    [NativeName("SDL_BlitSurfaceTiled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiled")]
    MaybeBool<byte> BlitSurfaceTiled(
        Ref<Surface> src,
        Ref<Rect> srcrect,
        Ref<Surface> dst,
        Ref<Rect> dstrect
    );

    [NativeName("SDL_BlitSurfaceTiledWithScale")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiledWithScale")]
    byte BlitSurfaceTiledWithScale(
        Surface* src,
        Rect* srcrect,
        float scale,
        ScaleMode scaleMode,
        Surface* dst,
        Rect* dstrect
    );

    [NativeName("SDL_BlitSurfaceTiledWithScale")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceTiledWithScale")]
    MaybeBool<byte> BlitSurfaceTiledWithScale(
        Ref<Surface> src,
        Ref<Rect> srcrect,
        float scale,
        ScaleMode scaleMode,
        Ref<Surface> dst,
        Ref<Rect> dstrect
    );

    [NativeName("SDL_BlitSurfaceUnchecked")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUnchecked")]
    byte BlitSurfaceUnchecked(Surface* src, Rect* srcrect, Surface* dst, Rect* dstrect);

    [NativeName("SDL_BlitSurfaceUnchecked")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUnchecked")]
    MaybeBool<byte> BlitSurfaceUnchecked(
        Ref<Surface> src,
        Ref<Rect> srcrect,
        Ref<Surface> dst,
        Ref<Rect> dstrect
    );

    [NativeName("SDL_BlitSurfaceUncheckedScaled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUncheckedScaled")]
    byte BlitSurfaceUncheckedScaled(
        Surface* src,
        Rect* srcrect,
        Surface* dst,
        Rect* dstrect,
        ScaleMode scaleMode
    );

    [NativeName("SDL_BlitSurfaceUncheckedScaled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BlitSurfaceUncheckedScaled")]
    MaybeBool<byte> BlitSurfaceUncheckedScaled(
        Ref<Surface> src,
        Ref<Rect> srcrect,
        Ref<Surface> dst,
        Ref<Rect> dstrect,
        ScaleMode scaleMode
    );

    [NativeName("SDL_BroadcastCondition")]
    [NativeFunction("SDL3", EntryPoint = "SDL_BroadcastCondition")]
    void BroadcastCondition(ConditionHandle cond);

    [NativeName("SDL_bsearch")]
    [NativeFunction("SDL3", EntryPoint = "SDL_bsearch")]
    void* Bsearch(void* key, void* @base, nuint nmemb, nuint size, CompareCallback compare);

    [NativeName("SDL_bsearch")]
    [NativeFunction("SDL3", EntryPoint = "SDL_bsearch")]
    Ptr Bsearch(Ref key, Ref @base, nuint nmemb, nuint size, CompareCallback compare);

    [NativeName("SDL_bsearch_r")]
    [NativeFunction("SDL3", EntryPoint = "SDL_bsearch_r")]
    void* BsearchR(
        void* key,
        void* @base,
        nuint nmemb,
        nuint size,
        CompareCallbackR compare,
        void* userdata
    );

    [NativeName("SDL_bsearch_r")]
    [NativeFunction("SDL3", EntryPoint = "SDL_bsearch_r")]
    Ptr BsearchR(
        Ref key,
        Ref @base,
        nuint nmemb,
        nuint size,
        CompareCallbackR compare,
        Ref userdata
    );

    [NativeName("SDL_CalculateGPUTextureFormatSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CalculateGPUTextureFormatSize")]
    uint CalculateGpuTextureFormatSize(
        GpuTextureFormat format,
        uint width,
        uint height,
        uint depth_or_layer_count
    );

    [NativeName("SDL_calloc")]
    [NativeFunction("SDL3", EntryPoint = "SDL_calloc")]
    Ptr Calloc(nuint nmemb, nuint size);

    [NativeName("SDL_calloc")]
    [NativeFunction("SDL3", EntryPoint = "SDL_calloc")]
    void* CallocRaw(nuint nmemb, nuint size);

    [NativeName("SDL_CancelGPUCommandBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CancelGPUCommandBuffer")]
    MaybeBool<byte> CancelGpuCommandBuffer(GpuCommandBufferHandle command_buffer);

    [NativeName("SDL_CancelGPUCommandBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CancelGPUCommandBuffer")]
    byte CancelGpuCommandBufferRaw(GpuCommandBufferHandle command_buffer);

    [NativeName("SDL_CaptureMouse")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CaptureMouse")]
    byte CaptureMouse(byte enabled);

    [NativeName("SDL_CaptureMouse")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CaptureMouse")]
    MaybeBool<byte> CaptureMouse(MaybeBool<byte> enabled);

    [NativeName("SDL_ceil")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ceil")]
    double Ceil(double x);

    [NativeName("SDL_ceilf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ceilf")]
    float Ceilf(float x);

    [NativeName("SDL_ClaimWindowForGPUDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClaimWindowForGPUDevice")]
    MaybeBool<byte> ClaimWindowForGpuDevice(GpuDeviceHandle device, WindowHandle window);

    [NativeName("SDL_ClaimWindowForGPUDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClaimWindowForGPUDevice")]
    byte ClaimWindowForGpuDeviceRaw(GpuDeviceHandle device, WindowHandle window);

    [NativeName("SDL_CleanupTLS")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CleanupTLS")]
    void CleanupTls();

    [NativeName("SDL_ClearAudioStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearAudioStream")]
    MaybeBool<byte> ClearAudioStream(AudioStreamHandle stream);

    [NativeName("SDL_ClearAudioStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearAudioStream")]
    byte ClearAudioStreamRaw(AudioStreamHandle stream);

    [NativeName("SDL_ClearClipboardData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearClipboardData")]
    MaybeBool<byte> ClearClipboardData();

    [NativeName("SDL_ClearClipboardData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearClipboardData")]
    byte ClearClipboardDataRaw();

    [NativeName("SDL_ClearComposition")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearComposition")]
    MaybeBool<byte> ClearComposition(WindowHandle window);

    [NativeName("SDL_ClearComposition")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearComposition")]
    byte ClearCompositionRaw(WindowHandle window);

    [NativeName("SDL_ClearError")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearError")]
    MaybeBool<byte> ClearError();

    [NativeName("SDL_ClearError")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearError")]
    byte ClearErrorRaw();

    [NativeName("SDL_ClearProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearProperty")]
    byte ClearProperty(uint props, sbyte* name);

    [NativeName("SDL_ClearProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearProperty")]
    MaybeBool<byte> ClearProperty(uint props, Ref<sbyte> name);

    [NativeName("SDL_ClearSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearSurface")]
    byte ClearSurface(Surface* surface, float r, float g, float b, float a);

    [NativeName("SDL_ClearSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ClearSurface")]
    MaybeBool<byte> ClearSurface(Ref<Surface> surface, float r, float g, float b, float a);

    [NativeName("SDL_CloseAudioDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CloseAudioDevice")]
    void CloseAudioDevice(uint devid);

    [NativeName("SDL_CloseCamera")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CloseCamera")]
    void CloseCamera(CameraHandle camera);

    [NativeName("SDL_CloseGamepad")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CloseGamepad")]
    void CloseGamepad(GamepadHandle gamepad);

    [NativeName("SDL_CloseHaptic")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CloseHaptic")]
    void CloseHaptic(HapticHandle haptic);

    [NativeName("SDL_CloseIO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CloseIO")]
    MaybeBool<byte> CloseIo(IoStreamHandle context);

    [NativeName("SDL_CloseIO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CloseIO")]
    byte CloseIoRaw(IoStreamHandle context);

    [NativeName("SDL_CloseJoystick")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CloseJoystick")]
    void CloseJoystick(JoystickHandle joystick);

    [NativeName("SDL_CloseSensor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CloseSensor")]
    void CloseSensor(SensorHandle sensor);

    [NativeName("SDL_CloseStorage")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CloseStorage")]
    MaybeBool<byte> CloseStorage(StorageHandle storage);

    [NativeName("SDL_CloseStorage")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CloseStorage")]
    byte CloseStorageRaw(StorageHandle storage);

    [NativeName("SDL_CompareAndSwapAtomicInt")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicInt")]
    byte CompareAndSwapAtomicInt(AtomicInt* a, int oldval, int newval);

    [NativeName("SDL_CompareAndSwapAtomicInt")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicInt")]
    MaybeBool<byte> CompareAndSwapAtomicInt(Ref<AtomicInt> a, int oldval, int newval);

    [NativeName("SDL_CompareAndSwapAtomicPointer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicPointer")]
    byte CompareAndSwapAtomicPointer(void** a, void* oldval, void* newval);

    [NativeName("SDL_CompareAndSwapAtomicPointer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicPointer")]
    MaybeBool<byte> CompareAndSwapAtomicPointer(Ref2D a, Ref oldval, Ref newval);

    [NativeName("SDL_CompareAndSwapAtomicU32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicU32")]
    byte CompareAndSwapAtomicU32(AtomicU32* a, uint oldval, uint newval);

    [NativeName("SDL_CompareAndSwapAtomicU32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CompareAndSwapAtomicU32")]
    MaybeBool<byte> CompareAndSwapAtomicU32(Ref<AtomicU32> a, uint oldval, uint newval);

    [NativeName("SDL_ComposeCustomBlendMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ComposeCustomBlendMode")]
    uint ComposeCustomBlendMode(
        BlendFactor srcColorFactor,
        BlendFactor dstColorFactor,
        BlendOperation colorOperation,
        BlendFactor srcAlphaFactor,
        BlendFactor dstAlphaFactor,
        BlendOperation alphaOperation
    );

    [NativeName("SDL_ConvertAudioSamples")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertAudioSamples")]
    byte ConvertAudioSamples(
        AudioSpec* src_spec,
        byte* src_data,
        int src_len,
        AudioSpec* dst_spec,
        byte** dst_data,
        int* dst_len
    );

    [NativeName("SDL_ConvertAudioSamples")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertAudioSamples")]
    MaybeBool<byte> ConvertAudioSamples(
        Ref<AudioSpec> src_spec,
        Ref<byte> src_data,
        int src_len,
        Ref<AudioSpec> dst_spec,
        Ref2D<byte> dst_data,
        Ref<int> dst_len
    );

    [NativeName("SDL_ConvertEventToRenderCoordinates")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertEventToRenderCoordinates")]
    byte ConvertEventToRenderCoordinates(RendererHandle renderer, Event* @event);

    [NativeName("SDL_ConvertEventToRenderCoordinates")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertEventToRenderCoordinates")]
    MaybeBool<byte> ConvertEventToRenderCoordinates(RendererHandle renderer, Ref<Event> @event);

    [NativeName("SDL_ConvertPixels")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixels")]
    byte ConvertPixels(
        int width,
        int height,
        PixelFormat src_format,
        void* src,
        int src_pitch,
        PixelFormat dst_format,
        void* dst,
        int dst_pitch
    );

    [NativeName("SDL_ConvertPixels")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixels")]
    MaybeBool<byte> ConvertPixels(
        int width,
        int height,
        PixelFormat src_format,
        Ref src,
        int src_pitch,
        PixelFormat dst_format,
        Ref dst,
        int dst_pitch
    );

    [NativeName("SDL_ConvertPixelsAndColorspace")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixelsAndColorspace")]
    byte ConvertPixelsAndColorspace(
        int width,
        int height,
        PixelFormat src_format,
        Colorspace src_colorspace,
        uint src_properties,
        void* src,
        int src_pitch,
        PixelFormat dst_format,
        Colorspace dst_colorspace,
        uint dst_properties,
        void* dst,
        int dst_pitch
    );

    [NativeName("SDL_ConvertPixelsAndColorspace")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertPixelsAndColorspace")]
    MaybeBool<byte> ConvertPixelsAndColorspace(
        int width,
        int height,
        PixelFormat src_format,
        Colorspace src_colorspace,
        uint src_properties,
        Ref src,
        int src_pitch,
        PixelFormat dst_format,
        Colorspace dst_colorspace,
        uint dst_properties,
        Ref dst,
        int dst_pitch
    );

    [NativeName("SDL_ConvertSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurface")]
    Surface* ConvertSurface(Surface* surface, PixelFormat format);

    [NativeName("SDL_ConvertSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurface")]
    Ptr<Surface> ConvertSurface(Ref<Surface> surface, PixelFormat format);

    [NativeName("SDL_ConvertSurfaceAndColorspace")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceAndColorspace")]
    Surface* ConvertSurfaceAndColorspace(
        Surface* surface,
        PixelFormat format,
        Palette* palette,
        Colorspace colorspace,
        uint props
    );

    [NativeName("SDL_ConvertSurfaceAndColorspace")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ConvertSurfaceAndColorspace")]
    Ptr<Surface> ConvertSurfaceAndColorspace(
        Ref<Surface> surface,
        PixelFormat format,
        Ref<Palette> palette,
        Colorspace colorspace,
        uint props
    );

    [NativeName("SDL_CopyFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyFile")]
    byte CopyFile(sbyte* oldpath, sbyte* newpath);

    [NativeName("SDL_CopyFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyFile")]
    MaybeBool<byte> CopyFile(Ref<sbyte> oldpath, Ref<sbyte> newpath);

    [NativeName("SDL_CopyGPUBufferToBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUBufferToBuffer")]
    void CopyGpuBufferToBuffer(
        GpuCopyPassHandle copy_pass,
        GpuBufferLocation* source,
        GpuBufferLocation* destination,
        uint size,
        byte cycle
    );

    [NativeName("SDL_CopyGPUBufferToBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUBufferToBuffer")]
    void CopyGpuBufferToBuffer(
        GpuCopyPassHandle copy_pass,
        Ref<GpuBufferLocation> source,
        Ref<GpuBufferLocation> destination,
        uint size,
        MaybeBool<byte> cycle
    );

    [NativeName("SDL_CopyGPUTextureToTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUTextureToTexture")]
    void CopyGpuTextureToTexture(
        GpuCopyPassHandle copy_pass,
        GpuTextureLocation* source,
        GpuTextureLocation* destination,
        uint w,
        uint h,
        uint d,
        byte cycle
    );

    [NativeName("SDL_CopyGPUTextureToTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyGPUTextureToTexture")]
    void CopyGpuTextureToTexture(
        GpuCopyPassHandle copy_pass,
        Ref<GpuTextureLocation> source,
        Ref<GpuTextureLocation> destination,
        uint w,
        uint h,
        uint d,
        MaybeBool<byte> cycle
    );

    [NativeName("SDL_CopyProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyProperties")]
    MaybeBool<byte> CopyProperties(uint src, uint dst);

    [NativeName("SDL_CopyProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyProperties")]
    byte CopyPropertiesRaw(uint src, uint dst);

    [NativeName("SDL_copysign")]
    [NativeFunction("SDL3", EntryPoint = "SDL_copysign")]
    double Copysign(double x, double y);

    [NativeName("SDL_copysignf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_copysignf")]
    float Copysignf(float x, float y);

    [NativeName("SDL_CopyStorageFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyStorageFile")]
    byte CopyStorageFile(StorageHandle storage, sbyte* oldpath, sbyte* newpath);

    [NativeName("SDL_CopyStorageFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CopyStorageFile")]
    MaybeBool<byte> CopyStorageFile(StorageHandle storage, Ref<sbyte> oldpath, Ref<sbyte> newpath);

    [NativeName("SDL_cos")]
    [NativeFunction("SDL3", EntryPoint = "SDL_cos")]
    double Cos(double x);

    [NativeName("SDL_cosf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_cosf")]
    float Cosf(float x);

    [NativeName("SDL_crc16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_crc16")]
    ushort Crc16(ushort crc, void* data, nuint len);

    [NativeName("SDL_crc16")]
    [NativeFunction("SDL3", EntryPoint = "SDL_crc16")]
    ushort Crc16(ushort crc, Ref data, nuint len);

    [NativeName("SDL_crc32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_crc32")]
    uint Crc32(uint crc, void* data, nuint len);

    [NativeName("SDL_crc32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_crc32")]
    uint Crc32(uint crc, Ref data, nuint len);

    [NativeName("SDL_CreateAudioStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateAudioStream")]
    AudioStreamHandle CreateAudioStream(AudioSpec* src_spec, AudioSpec* dst_spec);

    [NativeName("SDL_CreateAudioStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateAudioStream")]
    AudioStreamHandle CreateAudioStream(Ref<AudioSpec> src_spec, Ref<AudioSpec> dst_spec);

    [NativeName("SDL_CreateColorCursor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateColorCursor")]
    CursorHandle CreateColorCursor(Surface* surface, int hot_x, int hot_y);

    [NativeName("SDL_CreateColorCursor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateColorCursor")]
    CursorHandle CreateColorCursor(Ref<Surface> surface, int hot_x, int hot_y);

    [NativeName("SDL_CreateCondition")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateCondition")]
    ConditionHandle CreateCondition();

    [NativeName("SDL_CreateCursor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateCursor")]
    CursorHandle CreateCursor(byte* data, byte* mask, int w, int h, int hot_x, int hot_y);

    [NativeName("SDL_CreateCursor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateCursor")]
    CursorHandle CreateCursor(Ref<byte> data, Ref<byte> mask, int w, int h, int hot_x, int hot_y);

    [NativeName("SDL_CreateDirectory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateDirectory")]
    byte CreateDirectory(sbyte* path);

    [NativeName("SDL_CreateDirectory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateDirectory")]
    MaybeBool<byte> CreateDirectory(Ref<sbyte> path);

    [NativeName("SDL_CreateEnvironment")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateEnvironment")]
    EnvironmentHandle CreateEnvironment(byte populated);

    [NativeName("SDL_CreateEnvironment")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateEnvironment")]
    EnvironmentHandle CreateEnvironment(MaybeBool<byte> populated);

    [NativeName("SDL_CreateGPUBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUBuffer")]
    GpuBufferHandle CreateGpuBuffer(GpuDeviceHandle device, GpuBufferCreateInfo* createinfo);

    [NativeName("SDL_CreateGPUBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUBuffer")]
    GpuBufferHandle CreateGpuBuffer(GpuDeviceHandle device, Ref<GpuBufferCreateInfo> createinfo);

    [NativeName("SDL_CreateGPUComputePipeline")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUComputePipeline")]
    GpuComputePipelineHandle CreateGpuComputePipeline(
        GpuDeviceHandle device,
        GpuComputePipelineCreateInfo* createinfo
    );

    [NativeName("SDL_CreateGPUComputePipeline")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUComputePipeline")]
    GpuComputePipelineHandle CreateGpuComputePipeline(
        GpuDeviceHandle device,
        Ref<GpuComputePipelineCreateInfo> createinfo
    );

    [NativeName("SDL_CreateGPUDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUDevice")]
    GpuDeviceHandle CreateGpuDevice(uint format_flags, byte debug_mode, sbyte* name);

    [NativeName("SDL_CreateGPUDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUDevice")]
    GpuDeviceHandle CreateGpuDevice(uint format_flags, MaybeBool<byte> debug_mode, Ref<sbyte> name);

    [NativeName("SDL_CreateGPUDeviceWithProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUDeviceWithProperties")]
    GpuDeviceHandle CreateGpuDeviceWithProperties(uint props);

    [NativeName("SDL_CreateGPUGraphicsPipeline")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUGraphicsPipeline")]
    GpuGraphicsPipelineHandle CreateGpuGraphicsPipeline(
        GpuDeviceHandle device,
        GpuGraphicsPipelineCreateInfo* createinfo
    );

    [NativeName("SDL_CreateGPUGraphicsPipeline")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUGraphicsPipeline")]
    GpuGraphicsPipelineHandle CreateGpuGraphicsPipeline(
        GpuDeviceHandle device,
        Ref<GpuGraphicsPipelineCreateInfo> createinfo
    );

    [NativeName("SDL_CreateGPUSampler")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUSampler")]
    GpuSamplerHandle CreateGpuSampler(GpuDeviceHandle device, GpuSamplerCreateInfo* createinfo);

    [NativeName("SDL_CreateGPUSampler")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUSampler")]
    GpuSamplerHandle CreateGpuSampler(GpuDeviceHandle device, Ref<GpuSamplerCreateInfo> createinfo);

    [NativeName("SDL_CreateGPUShader")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUShader")]
    GpuShaderHandle CreateGpuShader(GpuDeviceHandle device, GpuShaderCreateInfo* createinfo);

    [NativeName("SDL_CreateGPUShader")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUShader")]
    GpuShaderHandle CreateGpuShader(GpuDeviceHandle device, Ref<GpuShaderCreateInfo> createinfo);

    [NativeName("SDL_CreateGPUTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTexture")]
    GpuTextureHandle CreateGpuTexture(GpuDeviceHandle device, GpuTextureCreateInfo* createinfo);

    [NativeName("SDL_CreateGPUTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTexture")]
    GpuTextureHandle CreateGpuTexture(GpuDeviceHandle device, Ref<GpuTextureCreateInfo> createinfo);

    [NativeName("SDL_CreateGPUTransferBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTransferBuffer")]
    GpuTransferBufferHandle CreateGpuTransferBuffer(
        GpuDeviceHandle device,
        GpuTransferBufferCreateInfo* createinfo
    );

    [NativeName("SDL_CreateGPUTransferBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateGPUTransferBuffer")]
    GpuTransferBufferHandle CreateGpuTransferBuffer(
        GpuDeviceHandle device,
        Ref<GpuTransferBufferCreateInfo> createinfo
    );

    [NativeName("SDL_CreateHapticEffect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateHapticEffect")]
    int CreateHapticEffect(HapticHandle haptic, HapticEffect* effect);

    [NativeName("SDL_CreateHapticEffect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateHapticEffect")]
    int CreateHapticEffect(HapticHandle haptic, Ref<HapticEffect> effect);

    [NativeName("SDL_CreateMutex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateMutex")]
    MutexHandle CreateMutex();

    [NativeName("SDL_CreatePalette")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreatePalette")]
    Ptr<Palette> CreatePalette(int ncolors);

    [NativeName("SDL_CreatePalette")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreatePalette")]
    Palette* CreatePaletteRaw(int ncolors);

    [NativeName("SDL_CreatePopupWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreatePopupWindow")]
    WindowHandle CreatePopupWindow(
        WindowHandle parent,
        int offset_x,
        int offset_y,
        int w,
        int h,
        ulong flags
    );

    [NativeName("SDL_CreateProcess")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateProcess")]
    ProcessHandle CreateProcess(sbyte** args, byte pipe_stdio);

    [NativeName("SDL_CreateProcess")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateProcess")]
    ProcessHandle CreateProcess(Ref2D<sbyte> args, MaybeBool<byte> pipe_stdio);

    [NativeName("SDL_CreateProcessWithProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateProcessWithProperties")]
    ProcessHandle CreateProcessWithProperties(uint props);

    [NativeName("SDL_CreateProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateProperties")]
    uint CreateProperties();

    [NativeName("SDL_CreateRenderer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateRenderer")]
    RendererHandle CreateRenderer(WindowHandle window, sbyte* name);

    [NativeName("SDL_CreateRenderer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateRenderer")]
    RendererHandle CreateRenderer(WindowHandle window, Ref<sbyte> name);

    [NativeName("SDL_CreateRendererWithProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateRendererWithProperties")]
    RendererHandle CreateRendererWithProperties(uint props);

    [NativeName("SDL_CreateRWLock")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateRWLock")]
    RwLockHandle CreateRwLock();

    [NativeName("SDL_CreateSemaphore")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSemaphore")]
    SemaphoreHandle CreateSemaphore(uint initial_value);

    [NativeName("SDL_CreateSoftwareRenderer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSoftwareRenderer")]
    RendererHandle CreateSoftwareRenderer(Surface* surface);

    [NativeName("SDL_CreateSoftwareRenderer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSoftwareRenderer")]
    RendererHandle CreateSoftwareRenderer(Ref<Surface> surface);

    [NativeName("SDL_CreateStorageDirectory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateStorageDirectory")]
    byte CreateStorageDirectory(StorageHandle storage, sbyte* path);

    [NativeName("SDL_CreateStorageDirectory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateStorageDirectory")]
    MaybeBool<byte> CreateStorageDirectory(StorageHandle storage, Ref<sbyte> path);

    [NativeName("SDL_CreateSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurface")]
    Ptr<Surface> CreateSurface(int width, int height, PixelFormat format);

    [NativeName("SDL_CreateSurfaceFrom")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfaceFrom")]
    Surface* CreateSurfaceFrom(int width, int height, PixelFormat format, void* pixels, int pitch);

    [NativeName("SDL_CreateSurfaceFrom")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfaceFrom")]
    Ptr<Surface> CreateSurfaceFrom(
        int width,
        int height,
        PixelFormat format,
        Ref pixels,
        int pitch
    );

    [NativeName("SDL_CreateSurfacePalette")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfacePalette")]
    Palette* CreateSurfacePalette(Surface* surface);

    [NativeName("SDL_CreateSurfacePalette")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurfacePalette")]
    Ptr<Palette> CreateSurfacePalette(Ref<Surface> surface);

    [NativeName("SDL_CreateSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSurface")]
    Surface* CreateSurfaceRaw(int width, int height, PixelFormat format);

    [NativeName("SDL_CreateSystemCursor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateSystemCursor")]
    CursorHandle CreateSystemCursor(SystemCursor id);

    [NativeName("SDL_CreateTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTexture")]
    Ptr<Texture> CreateTexture(
        RendererHandle renderer,
        PixelFormat format,
        TextureAccess access,
        int w,
        int h
    );

    [NativeName("SDL_CreateTextureFromSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureFromSurface")]
    Texture* CreateTextureFromSurface(RendererHandle renderer, Surface* surface);

    [NativeName("SDL_CreateTextureFromSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureFromSurface")]
    Ptr<Texture> CreateTextureFromSurface(RendererHandle renderer, Ref<Surface> surface);

    [NativeName("SDL_CreateTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTexture")]
    Texture* CreateTextureRaw(
        RendererHandle renderer,
        PixelFormat format,
        TextureAccess access,
        int w,
        int h
    );

    [NativeName("SDL_CreateTextureWithProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureWithProperties")]
    Ptr<Texture> CreateTextureWithProperties(RendererHandle renderer, uint props);

    [NativeName("SDL_CreateTextureWithProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateTextureWithProperties")]
    Texture* CreateTextureWithPropertiesRaw(RendererHandle renderer, uint props);

    [NativeName("SDL_CreateThreadRuntime")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadRuntime")]
    ThreadHandle CreateThreadRuntime(
        ThreadFunction fn,
        sbyte* name,
        void* data,
        FunctionPointer pfnBeginThread,
        FunctionPointer pfnEndThread
    );

    [NativeName("SDL_CreateThreadRuntime")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadRuntime")]
    ThreadHandle CreateThreadRuntime(
        ThreadFunction fn,
        Ref<sbyte> name,
        Ref data,
        FunctionPointer pfnBeginThread,
        FunctionPointer pfnEndThread
    );

    [NativeName("SDL_CreateThreadWithPropertiesRuntime")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateThreadWithPropertiesRuntime")]
    ThreadHandle CreateThreadWithPropertiesRuntime(
        uint props,
        FunctionPointer pfnBeginThread,
        FunctionPointer pfnEndThread
    );

    [NativeName("SDL_CreateWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindow")]
    WindowHandle CreateWindow(sbyte* title, int w, int h, ulong flags);

    [NativeName("SDL_CreateWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindow")]
    WindowHandle CreateWindow(Ref<sbyte> title, int w, int h, ulong flags);

    [NativeName("SDL_CreateWindowAndRenderer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowAndRenderer")]
    byte CreateWindowAndRenderer(
        sbyte* title,
        int width,
        int height,
        ulong window_flags,
        WindowHandle* window,
        RendererHandle* renderer
    );

    [NativeName("SDL_CreateWindowAndRenderer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowAndRenderer")]
    MaybeBool<byte> CreateWindowAndRenderer(
        Ref<sbyte> title,
        int width,
        int height,
        ulong window_flags,
        Ref<WindowHandle> window,
        Ref<RendererHandle> renderer
    );

    [NativeName("SDL_CreateWindowWithProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CreateWindowWithProperties")]
    WindowHandle CreateWindowWithProperties(uint props);

    [NativeName("SDL_CursorVisible")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CursorVisible")]
    MaybeBool<byte> CursorVisible();

    [NativeName("SDL_CursorVisible")]
    [NativeFunction("SDL3", EntryPoint = "SDL_CursorVisible")]
    byte CursorVisibleRaw();

    [NativeName("SDL_DateTimeToTime")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DateTimeToTime")]
    byte DateTimeToTime(DateTime* dt, long* ticks);

    [NativeName("SDL_DateTimeToTime")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DateTimeToTime")]
    MaybeBool<byte> DateTimeToTime(Ref<DateTime> dt, Ref<long> ticks);

    [NativeName("SDL_Delay")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Delay")]
    void Delay(uint ms);

    [NativeName("SDL_DelayNS")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DelayNS")]
    void DelayNs(ulong ns);

    [NativeName("SDL_DelayPrecise")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DelayPrecise")]
    void DelayPrecise(ulong ns);

    [NativeName("SDL_DestroyAudioStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyAudioStream")]
    void DestroyAudioStream(AudioStreamHandle stream);

    [NativeName("SDL_DestroyCondition")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyCondition")]
    void DestroyCondition(ConditionHandle cond);

    [NativeName("SDL_DestroyCursor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyCursor")]
    void DestroyCursor(CursorHandle cursor);

    [NativeName("SDL_DestroyEnvironment")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyEnvironment")]
    void DestroyEnvironment(EnvironmentHandle env);

    [NativeName("SDL_DestroyGPUDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyGPUDevice")]
    void DestroyGpuDevice(GpuDeviceHandle device);

    [NativeName("SDL_DestroyHapticEffect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyHapticEffect")]
    void DestroyHapticEffect(HapticHandle haptic, int effect);

    [NativeName("SDL_DestroyMutex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyMutex")]
    void DestroyMutex(MutexHandle mutex);

    [NativeName("SDL_DestroyPalette")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPalette")]
    void DestroyPalette(Palette* palette);

    [NativeName("SDL_DestroyPalette")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyPalette")]
    void DestroyPalette(Ref<Palette> palette);

    [NativeName("SDL_DestroyProcess")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyProcess")]
    void DestroyProcess(ProcessHandle process);

    [NativeName("SDL_DestroyProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyProperties")]
    void DestroyProperties(uint props);

    [NativeName("SDL_DestroyRenderer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyRenderer")]
    void DestroyRenderer(RendererHandle renderer);

    [NativeName("SDL_DestroyRWLock")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyRWLock")]
    void DestroyRwLock(RwLockHandle rwlock);

    [NativeName("SDL_DestroySemaphore")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroySemaphore")]
    void DestroySemaphore(SemaphoreHandle sem);

    [NativeName("SDL_DestroySurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroySurface")]
    void DestroySurface(Surface* surface);

    [NativeName("SDL_DestroySurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroySurface")]
    void DestroySurface(Ref<Surface> surface);

    [NativeName("SDL_DestroyTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyTexture")]
    void DestroyTexture(Texture* texture);

    [NativeName("SDL_DestroyTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyTexture")]
    void DestroyTexture(Ref<Texture> texture);

    [NativeName("SDL_DestroyWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindow")]
    void DestroyWindow(WindowHandle window);

    [NativeName("SDL_DestroyWindowSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindowSurface")]
    MaybeBool<byte> DestroyWindowSurface(WindowHandle window);

    [NativeName("SDL_DestroyWindowSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DestroyWindowSurface")]
    byte DestroyWindowSurfaceRaw(WindowHandle window);

    [NativeName("SDL_DetachThread")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DetachThread")]
    void DetachThread(ThreadHandle thread);

    [NativeName("SDL_DetachVirtualJoystick")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DetachVirtualJoystick")]
    MaybeBool<byte> DetachVirtualJoystick(uint instance_id);

    [NativeName("SDL_DetachVirtualJoystick")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DetachVirtualJoystick")]
    byte DetachVirtualJoystickRaw(uint instance_id);

    [NativeName("SDL_DisableScreenSaver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DisableScreenSaver")]
    MaybeBool<byte> DisableScreenSaver();

    [NativeName("SDL_DisableScreenSaver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DisableScreenSaver")]
    byte DisableScreenSaverRaw();

    [NativeName("SDL_DispatchGPUCompute")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DispatchGPUCompute")]
    void DispatchGpuCompute(
        GpuComputePassHandle compute_pass,
        uint groupcount_x,
        uint groupcount_y,
        uint groupcount_z
    );

    [NativeName("SDL_DispatchGPUComputeIndirect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DispatchGPUComputeIndirect")]
    void DispatchGpuComputeIndirect(
        GpuComputePassHandle compute_pass,
        GpuBufferHandle buffer,
        uint offset
    );

    [NativeName("SDL_DownloadFromGPUBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUBuffer")]
    void DownloadFromGpuBuffer(
        GpuCopyPassHandle copy_pass,
        GpuBufferRegion* source,
        GpuTransferBufferLocation* destination
    );

    [NativeName("SDL_DownloadFromGPUBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUBuffer")]
    void DownloadFromGpuBuffer(
        GpuCopyPassHandle copy_pass,
        Ref<GpuBufferRegion> source,
        Ref<GpuTransferBufferLocation> destination
    );

    [NativeName("SDL_DownloadFromGPUTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUTexture")]
    void DownloadFromGpuTexture(
        GpuCopyPassHandle copy_pass,
        GpuTextureRegion* source,
        GpuTextureTransferInfo* destination
    );

    [NativeName("SDL_DownloadFromGPUTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DownloadFromGPUTexture")]
    void DownloadFromGpuTexture(
        GpuCopyPassHandle copy_pass,
        Ref<GpuTextureRegion> source,
        Ref<GpuTextureTransferInfo> destination
    );

    [NativeName("SDL_DrawGPUIndexedPrimitives")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUIndexedPrimitives")]
    void DrawGpuIndexedPrimitives(
        GpuRenderPassHandle render_pass,
        uint num_indices,
        uint num_instances,
        uint first_index,
        int vertex_offset,
        uint first_instance
    );

    [NativeName("SDL_DrawGPUIndexedPrimitivesIndirect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUIndexedPrimitivesIndirect")]
    void DrawGpuIndexedPrimitivesIndirect(
        GpuRenderPassHandle render_pass,
        GpuBufferHandle buffer,
        uint offset,
        uint draw_count
    );

    [NativeName("SDL_DrawGPUPrimitives")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUPrimitives")]
    void DrawGpuPrimitives(
        GpuRenderPassHandle render_pass,
        uint num_vertices,
        uint num_instances,
        uint first_vertex,
        uint first_instance
    );

    [NativeName("SDL_DrawGPUPrimitivesIndirect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DrawGPUPrimitivesIndirect")]
    void DrawGpuPrimitivesIndirect(
        GpuRenderPassHandle render_pass,
        GpuBufferHandle buffer,
        uint offset,
        uint draw_count
    );

    [NativeName("SDL_DuplicateSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DuplicateSurface")]
    Surface* DuplicateSurface(Surface* surface);

    [NativeName("SDL_DuplicateSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_DuplicateSurface")]
    Ptr<Surface> DuplicateSurface(Ref<Surface> surface);

    [NativeName("SDL_EGL_GetCurrentConfig")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentConfig")]
    Ptr EglGetCurrentConfig();

    [NativeName("SDL_EGL_GetCurrentConfig")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentConfig")]
    void* EglGetCurrentConfigRaw();

    [NativeName("SDL_EGL_GetCurrentDisplay")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentDisplay")]
    Ptr EglGetCurrentDisplay();

    [NativeName("SDL_EGL_GetCurrentDisplay")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetCurrentDisplay")]
    void* EglGetCurrentDisplayRaw();

    [NativeName("SDL_EGL_GetProcAddress")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetProcAddress")]
    FunctionPointer EglGetProcAddress(sbyte* proc);

    [NativeName("SDL_EGL_GetProcAddress")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetProcAddress")]
    FunctionPointer EglGetProcAddress(Ref<sbyte> proc);

    [NativeName("SDL_EGL_GetWindowSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetWindowSurface")]
    Ptr EglGetWindowSurface(WindowHandle window);

    [NativeName("SDL_EGL_GetWindowSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_GetWindowSurface")]
    void* EglGetWindowSurfaceRaw(WindowHandle window);

    [NativeName("SDL_EGL_SetAttributeCallbacks")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_SetAttributeCallbacks")]
    void EglSetAttributeCallbacks(
        EglAttribArrayCallback platformAttribCallback,
        EglIntArrayCallback surfaceAttribCallback,
        EglIntArrayCallback contextAttribCallback,
        void* userdata
    );

    [NativeName("SDL_EGL_SetAttributeCallbacks")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EGL_SetAttributeCallbacks")]
    void EglSetAttributeCallbacks(
        EglAttribArrayCallback platformAttribCallback,
        EglIntArrayCallback surfaceAttribCallback,
        EglIntArrayCallback contextAttribCallback,
        Ref userdata
    );

    [NativeName("SDL_EnableScreenSaver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnableScreenSaver")]
    MaybeBool<byte> EnableScreenSaver();

    [NativeName("SDL_EnableScreenSaver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnableScreenSaver")]
    byte EnableScreenSaverRaw();

    [NativeName("SDL_EndGPUComputePass")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EndGPUComputePass")]
    void EndGpuComputePass(GpuComputePassHandle compute_pass);

    [NativeName("SDL_EndGPUCopyPass")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EndGPUCopyPass")]
    void EndGpuCopyPass(GpuCopyPassHandle copy_pass);

    [NativeName("SDL_EndGPURenderPass")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EndGPURenderPass")]
    void EndGpuRenderPass(GpuRenderPassHandle render_pass);

    [NativeName("SDL_EnterAppMainCallbacks")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnterAppMainCallbacks")]
    int EnterAppMainCallbacks(
        int argc,
        sbyte** argv,
        AppInitFunc appinit,
        AppIterateFunc appiter,
        AppEventFunc appevent,
        AppQuitFunc appquit
    );

    [NativeName("SDL_EnterAppMainCallbacks")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnterAppMainCallbacks")]
    int EnterAppMainCallbacks(
        int argc,
        Ref2D<sbyte> argv,
        AppInitFunc appinit,
        AppIterateFunc appiter,
        AppEventFunc appevent,
        AppQuitFunc appquit
    );

    [NativeName("SDL_EnumerateDirectory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateDirectory")]
    byte EnumerateDirectory(sbyte* path, EnumerateDirectoryCallback callback, void* userdata);

    [NativeName("SDL_EnumerateDirectory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateDirectory")]
    MaybeBool<byte> EnumerateDirectory(
        Ref<sbyte> path,
        EnumerateDirectoryCallback callback,
        Ref userdata
    );

    [NativeName("SDL_EnumerateProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateProperties")]
    byte EnumerateProperties(uint props, EnumeratePropertiesCallback callback, void* userdata);

    [NativeName("SDL_EnumerateProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateProperties")]
    MaybeBool<byte> EnumerateProperties(
        uint props,
        EnumeratePropertiesCallback callback,
        Ref userdata
    );

    [NativeName("SDL_EnumerateStorageDirectory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateStorageDirectory")]
    byte EnumerateStorageDirectory(
        StorageHandle storage,
        sbyte* path,
        EnumerateDirectoryCallback callback,
        void* userdata
    );

    [NativeName("SDL_EnumerateStorageDirectory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EnumerateStorageDirectory")]
    MaybeBool<byte> EnumerateStorageDirectory(
        StorageHandle storage,
        Ref<sbyte> path,
        EnumerateDirectoryCallback callback,
        Ref userdata
    );

    [NativeName("SDL_EventEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EventEnabled")]
    MaybeBool<byte> EventEnabled(uint type);

    [NativeName("SDL_EventEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_EventEnabled")]
    byte EventEnabledRaw(uint type);

    [NativeName("SDL_exp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_exp")]
    double Exp(double x);

    [NativeName("SDL_expf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_expf")]
    float Expf(float x);

    [NativeName("SDL_fabs")]
    [NativeFunction("SDL3", EntryPoint = "SDL_fabs")]
    double Fabs(double x);

    [NativeName("SDL_FillSurfaceRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRect")]
    byte FillSurfaceRect(Surface* dst, Rect* rect, uint color);

    [NativeName("SDL_FillSurfaceRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRect")]
    MaybeBool<byte> FillSurfaceRect(Ref<Surface> dst, Ref<Rect> rect, uint color);

    [NativeName("SDL_FillSurfaceRects")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRects")]
    byte FillSurfaceRects(Surface* dst, Rect* rects, int count, uint color);

    [NativeName("SDL_FillSurfaceRects")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FillSurfaceRects")]
    MaybeBool<byte> FillSurfaceRects(Ref<Surface> dst, Ref<Rect> rects, int count, uint color);

    [NativeName("SDL_FilterEvents")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FilterEvents")]
    void FilterEvents(EventFilter filter, void* userdata);

    [NativeName("SDL_FilterEvents")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FilterEvents")]
    void FilterEvents(EventFilter filter, Ref userdata);

    [NativeName("SDL_FlashWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlashWindow")]
    MaybeBool<byte> FlashWindow(WindowHandle window, FlashOperation operation);

    [NativeName("SDL_FlashWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlashWindow")]
    byte FlashWindowRaw(WindowHandle window, FlashOperation operation);

    [NativeName("SDL_FlipSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlipSurface")]
    byte FlipSurface(Surface* surface, FlipMode flip);

    [NativeName("SDL_FlipSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlipSurface")]
    MaybeBool<byte> FlipSurface(Ref<Surface> surface, FlipMode flip);

    [NativeName("SDL_floor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_floor")]
    double Floor(double x);

    [NativeName("SDL_floorf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_floorf")]
    float Floorf(float x);

    [NativeName("SDL_FlushAudioStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlushAudioStream")]
    MaybeBool<byte> FlushAudioStream(AudioStreamHandle stream);

    [NativeName("SDL_FlushAudioStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlushAudioStream")]
    byte FlushAudioStreamRaw(AudioStreamHandle stream);

    [NativeName("SDL_FlushEvent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlushEvent")]
    void FlushEvent(uint type);

    [NativeName("SDL_FlushEvents")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlushEvents")]
    void FlushEvents(uint minType, uint maxType);

    [NativeName("SDL_FlushIO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlushIO")]
    MaybeBool<byte> FlushIo(IoStreamHandle context);

    [NativeName("SDL_FlushIO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlushIO")]
    byte FlushIoRaw(IoStreamHandle context);

    [NativeName("SDL_FlushRenderer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlushRenderer")]
    MaybeBool<byte> FlushRenderer(RendererHandle renderer);

    [NativeName("SDL_FlushRenderer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_FlushRenderer")]
    byte FlushRendererRaw(RendererHandle renderer);

    [NativeName("SDL_fmod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_fmod")]
    double Fmod(double x, double y);

    [NativeName("SDL_fmodf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_fmodf")]
    float Fmodf(float x, float y);

    [NativeName("SDL_free")]
    [NativeFunction("SDL3", EntryPoint = "SDL_free")]
    void Free(void* mem);

    [NativeName("SDL_free")]
    [NativeFunction("SDL3", EntryPoint = "SDL_free")]
    void Free(Ref mem);

    [NativeName("SDL_GamepadConnected")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadConnected")]
    MaybeBool<byte> GamepadConnected(GamepadHandle gamepad);

    [NativeName("SDL_GamepadConnected")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadConnected")]
    byte GamepadConnectedRaw(GamepadHandle gamepad);

    [NativeName("SDL_GamepadEventsEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadEventsEnabled")]
    MaybeBool<byte> GamepadEventsEnabled();

    [NativeName("SDL_GamepadEventsEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadEventsEnabled")]
    byte GamepadEventsEnabledRaw();

    [NativeName("SDL_GamepadHasAxis")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasAxis")]
    MaybeBool<byte> GamepadHasAxis(GamepadHandle gamepad, GamepadAxis axis);

    [NativeName("SDL_GamepadHasAxis")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasAxis")]
    byte GamepadHasAxisRaw(GamepadHandle gamepad, GamepadAxis axis);

    [NativeName("SDL_GamepadHasButton")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasButton")]
    MaybeBool<byte> GamepadHasButton(GamepadHandle gamepad, GamepadButton button);

    [NativeName("SDL_GamepadHasButton")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasButton")]
    byte GamepadHasButtonRaw(GamepadHandle gamepad, GamepadButton button);

    [NativeName("SDL_GamepadHasSensor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasSensor")]
    MaybeBool<byte> GamepadHasSensor(GamepadHandle gamepad, SensorType type);

    [NativeName("SDL_GamepadHasSensor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadHasSensor")]
    byte GamepadHasSensorRaw(GamepadHandle gamepad, SensorType type);

    [NativeName("SDL_GamepadSensorEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadSensorEnabled")]
    MaybeBool<byte> GamepadSensorEnabled(GamepadHandle gamepad, SensorType type);

    [NativeName("SDL_GamepadSensorEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GamepadSensorEnabled")]
    byte GamepadSensorEnabledRaw(GamepadHandle gamepad, SensorType type);

    [NativeName("SDL_GDKSuspendComplete")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GDKSuspendComplete")]
    void GdkSuspendComplete();

    [NativeName("SDL_GenerateMipmapsForGPUTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GenerateMipmapsForGPUTexture")]
    void GenerateMipmapsForGpuTexture(
        GpuCommandBufferHandle command_buffer,
        GpuTextureHandle texture
    );

    [NativeName("SDL_GetAppMetadataProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAppMetadataProperty")]
    sbyte* GetAppMetadataProperty(sbyte* name);

    [NativeName("SDL_GetAppMetadataProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAppMetadataProperty")]
    Ptr<sbyte> GetAppMetadataProperty(Ref<sbyte> name);

    [NativeName("SDL_GetAssertionHandler")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionHandler")]
    AssertionHandler GetAssertionHandler(void** puserdata);

    [NativeName("SDL_GetAssertionHandler")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionHandler")]
    AssertionHandler GetAssertionHandler(Ref2D puserdata);

    [NativeName("SDL_GetAssertionReport")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionReport")]
    Ptr<AssertData> GetAssertionReport();

    [NativeName("SDL_GetAssertionReport")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAssertionReport")]
    AssertData* GetAssertionReportRaw();

    [NativeName("SDL_GetAtomicInt")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicInt")]
    int GetAtomicInt(AtomicInt* a);

    [NativeName("SDL_GetAtomicInt")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicInt")]
    int GetAtomicInt(Ref<AtomicInt> a);

    [NativeName("SDL_GetAtomicPointer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicPointer")]
    void* GetAtomicPointer(void** a);

    [NativeName("SDL_GetAtomicPointer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicPointer")]
    Ptr GetAtomicPointer(Ref2D a);

    [NativeName("SDL_GetAtomicU32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicU32")]
    uint GetAtomicU32(AtomicU32* a);

    [NativeName("SDL_GetAtomicU32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAtomicU32")]
    uint GetAtomicU32(Ref<AtomicU32> a);

    [NativeName("SDL_GetAudioDeviceChannelMap")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceChannelMap")]
    int* GetAudioDeviceChannelMap(uint devid, int* count);

    [NativeName("SDL_GetAudioDeviceChannelMap")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceChannelMap")]
    Ptr<int> GetAudioDeviceChannelMap(uint devid, Ref<int> count);

    [NativeName("SDL_GetAudioDeviceFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceFormat")]
    byte GetAudioDeviceFormat(uint devid, AudioSpec* spec, int* sample_frames);

    [NativeName("SDL_GetAudioDeviceFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceFormat")]
    MaybeBool<byte> GetAudioDeviceFormat(uint devid, Ref<AudioSpec> spec, Ref<int> sample_frames);

    [NativeName("SDL_GetAudioDeviceGain")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceGain")]
    float GetAudioDeviceGain(uint devid);

    [NativeName("SDL_GetAudioDeviceName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceName")]
    Ptr<sbyte> GetAudioDeviceName(uint devid);

    [NativeName("SDL_GetAudioDeviceName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDeviceName")]
    sbyte* GetAudioDeviceNameRaw(uint devid);

    [NativeName("SDL_GetAudioDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDriver")]
    Ptr<sbyte> GetAudioDriver(int index);

    [NativeName("SDL_GetAudioDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioDriver")]
    sbyte* GetAudioDriverRaw(int index);

    [NativeName("SDL_GetAudioFormatName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioFormatName")]
    Ptr<sbyte> GetAudioFormatName(AudioFormat format);

    [NativeName("SDL_GetAudioFormatName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioFormatName")]
    sbyte* GetAudioFormatNameRaw(AudioFormat format);

    [NativeName("SDL_GetAudioPlaybackDevices")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioPlaybackDevices")]
    uint* GetAudioPlaybackDevices(int* count);

    [NativeName("SDL_GetAudioPlaybackDevices")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioPlaybackDevices")]
    Ptr<uint> GetAudioPlaybackDevices(Ref<int> count);

    [NativeName("SDL_GetAudioRecordingDevices")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioRecordingDevices")]
    uint* GetAudioRecordingDevices(int* count);

    [NativeName("SDL_GetAudioRecordingDevices")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioRecordingDevices")]
    Ptr<uint> GetAudioRecordingDevices(Ref<int> count);

    [NativeName("SDL_GetAudioStreamAvailable")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamAvailable")]
    int GetAudioStreamAvailable(AudioStreamHandle stream);

    [NativeName("SDL_GetAudioStreamData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamData")]
    int GetAudioStreamData(AudioStreamHandle stream, void* buf, int len);

    [NativeName("SDL_GetAudioStreamData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamData")]
    int GetAudioStreamData(AudioStreamHandle stream, Ref buf, int len);

    [NativeName("SDL_GetAudioStreamDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamDevice")]
    uint GetAudioStreamDevice(AudioStreamHandle stream);

    [NativeName("SDL_GetAudioStreamFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFormat")]
    byte GetAudioStreamFormat(AudioStreamHandle stream, AudioSpec* src_spec, AudioSpec* dst_spec);

    [NativeName("SDL_GetAudioStreamFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFormat")]
    MaybeBool<byte> GetAudioStreamFormat(
        AudioStreamHandle stream,
        Ref<AudioSpec> src_spec,
        Ref<AudioSpec> dst_spec
    );

    [NativeName("SDL_GetAudioStreamFrequencyRatio")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamFrequencyRatio")]
    float GetAudioStreamFrequencyRatio(AudioStreamHandle stream);

    [NativeName("SDL_GetAudioStreamGain")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamGain")]
    float GetAudioStreamGain(AudioStreamHandle stream);

    [NativeName("SDL_GetAudioStreamInputChannelMap")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamInputChannelMap")]
    int* GetAudioStreamInputChannelMap(AudioStreamHandle stream, int* count);

    [NativeName("SDL_GetAudioStreamInputChannelMap")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamInputChannelMap")]
    Ptr<int> GetAudioStreamInputChannelMap(AudioStreamHandle stream, Ref<int> count);

    [NativeName("SDL_GetAudioStreamOutputChannelMap")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamOutputChannelMap")]
    int* GetAudioStreamOutputChannelMap(AudioStreamHandle stream, int* count);

    [NativeName("SDL_GetAudioStreamOutputChannelMap")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamOutputChannelMap")]
    Ptr<int> GetAudioStreamOutputChannelMap(AudioStreamHandle stream, Ref<int> count);

    [NativeName("SDL_GetAudioStreamProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamProperties")]
    uint GetAudioStreamProperties(AudioStreamHandle stream);

    [NativeName("SDL_GetAudioStreamQueued")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetAudioStreamQueued")]
    int GetAudioStreamQueued(AudioStreamHandle stream);

    [NativeName("SDL_GetBasePath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetBasePath")]
    Ptr<sbyte> GetBasePath();

    [NativeName("SDL_GetBasePath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetBasePath")]
    sbyte* GetBasePathRaw();

    [NativeName("SDL_GetBooleanProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetBooleanProperty")]
    byte GetBooleanProperty(uint props, sbyte* name, byte default_value);

    [NativeName("SDL_GetBooleanProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetBooleanProperty")]
    MaybeBool<byte> GetBooleanProperty(uint props, Ref<sbyte> name, MaybeBool<byte> default_value);

    [NativeName("SDL_GetCameraDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDriver")]
    Ptr<sbyte> GetCameraDriver(int index);

    [NativeName("SDL_GetCameraDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraDriver")]
    sbyte* GetCameraDriverRaw(int index);

    [NativeName("SDL_GetCameraFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraFormat")]
    byte GetCameraFormat(CameraHandle camera, CameraSpec* spec);

    [NativeName("SDL_GetCameraFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraFormat")]
    MaybeBool<byte> GetCameraFormat(CameraHandle camera, Ref<CameraSpec> spec);

    [NativeName("SDL_GetCameraID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraID")]
    uint GetCameraId(CameraHandle camera);

    [NativeName("SDL_GetCameraName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraName")]
    Ptr<sbyte> GetCameraName(uint instance_id);

    [NativeName("SDL_GetCameraName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraName")]
    sbyte* GetCameraNameRaw(uint instance_id);

    [NativeName("SDL_GetCameraPermissionState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraPermissionState")]
    int GetCameraPermissionState(CameraHandle camera);

    [NativeName("SDL_GetCameraPosition")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraPosition")]
    CameraPosition GetCameraPosition(uint instance_id);

    [NativeName("SDL_GetCameraProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraProperties")]
    uint GetCameraProperties(CameraHandle camera);

    [NativeName("SDL_GetCameras")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameras")]
    uint* GetCameras(int* count);

    [NativeName("SDL_GetCameras")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameras")]
    Ptr<uint> GetCameras(Ref<int> count);

    [NativeName("SDL_GetCameraSupportedFormats")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraSupportedFormats")]
    CameraSpec** GetCameraSupportedFormats(uint instance_id, int* count);

    [NativeName("SDL_GetCameraSupportedFormats")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCameraSupportedFormats")]
    Ptr2D<CameraSpec> GetCameraSupportedFormats(uint instance_id, Ref<int> count);

    [NativeName("SDL_GetClipboardData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardData")]
    void* GetClipboardData(sbyte* mime_type, nuint* size);

    [NativeName("SDL_GetClipboardData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardData")]
    Ptr GetClipboardData(Ref<sbyte> mime_type, Ref<nuint> size);

    [NativeName("SDL_GetClipboardMimeTypes")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardMimeTypes")]
    sbyte** GetClipboardMimeTypes(nuint* num_mime_types);

    [NativeName("SDL_GetClipboardMimeTypes")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardMimeTypes")]
    Ptr2D<sbyte> GetClipboardMimeTypes(Ref<nuint> num_mime_types);

    [NativeName("SDL_GetClipboardText")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardText")]
    Ptr<sbyte> GetClipboardText();

    [NativeName("SDL_GetClipboardText")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClipboardText")]
    sbyte* GetClipboardTextRaw();

    [NativeName("SDL_GetClosestFullscreenDisplayMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
    byte GetClosestFullscreenDisplayMode(
        uint displayID,
        int w,
        int h,
        float refresh_rate,
        byte include_high_density_modes,
        DisplayMode* closest
    );

    [NativeName("SDL_GetClosestFullscreenDisplayMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetClosestFullscreenDisplayMode")]
    MaybeBool<byte> GetClosestFullscreenDisplayMode(
        uint displayID,
        int w,
        int h,
        float refresh_rate,
        MaybeBool<byte> include_high_density_modes,
        Ref<DisplayMode> closest
    );

    [NativeName("SDL_GetCPUCacheLineSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCPUCacheLineSize")]
    int GetCpuCacheLineSize();

    [NativeName("SDL_GetCurrentAudioDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentAudioDriver")]
    Ptr<sbyte> GetCurrentAudioDriver();

    [NativeName("SDL_GetCurrentAudioDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentAudioDriver")]
    sbyte* GetCurrentAudioDriverRaw();

    [NativeName("SDL_GetCurrentCameraDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentCameraDriver")]
    Ptr<sbyte> GetCurrentCameraDriver();

    [NativeName("SDL_GetCurrentCameraDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentCameraDriver")]
    sbyte* GetCurrentCameraDriverRaw();

    [NativeName("SDL_GetCurrentDirectory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDirectory")]
    Ptr<sbyte> GetCurrentDirectory();

    [NativeName("SDL_GetCurrentDirectory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDirectory")]
    sbyte* GetCurrentDirectoryRaw();

    [NativeName("SDL_GetCurrentDisplayMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDisplayMode")]
    Ptr<DisplayMode> GetCurrentDisplayMode(uint displayID);

    [NativeName("SDL_GetCurrentDisplayMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDisplayMode")]
    DisplayMode* GetCurrentDisplayModeRaw(uint displayID);

    [NativeName("SDL_GetCurrentDisplayOrientation")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentDisplayOrientation")]
    DisplayOrientation GetCurrentDisplayOrientation(uint displayID);

    [NativeName("SDL_GetCurrentRenderOutputSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentRenderOutputSize")]
    byte GetCurrentRenderOutputSize(RendererHandle renderer, int* w, int* h);

    [NativeName("SDL_GetCurrentRenderOutputSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentRenderOutputSize")]
    MaybeBool<byte> GetCurrentRenderOutputSize(RendererHandle renderer, Ref<int> w, Ref<int> h);

    [NativeName("SDL_GetCurrentThreadID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentThreadID")]
    ulong GetCurrentThreadId();

    [NativeName("SDL_GetCurrentTime")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentTime")]
    byte GetCurrentTime(long* ticks);

    [NativeName("SDL_GetCurrentTime")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentTime")]
    MaybeBool<byte> GetCurrentTime(Ref<long> ticks);

    [NativeName("SDL_GetCurrentVideoDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentVideoDriver")]
    Ptr<sbyte> GetCurrentVideoDriver();

    [NativeName("SDL_GetCurrentVideoDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCurrentVideoDriver")]
    sbyte* GetCurrentVideoDriverRaw();

    [NativeName("SDL_GetCursor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetCursor")]
    CursorHandle GetCursor();

    [NativeName("SDL_GetDateTimeLocalePreferences")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDateTimeLocalePreferences")]
    byte GetDateTimeLocalePreferences(DateFormat* dateFormat, TimeFormat* timeFormat);

    [NativeName("SDL_GetDateTimeLocalePreferences")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDateTimeLocalePreferences")]
    MaybeBool<byte> GetDateTimeLocalePreferences(
        Ref<DateFormat> dateFormat,
        Ref<TimeFormat> timeFormat
    );

    [NativeName("SDL_GetDayOfWeek")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDayOfWeek")]
    int GetDayOfWeek(int year, int month, int day);

    [NativeName("SDL_GetDayOfYear")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDayOfYear")]
    int GetDayOfYear(int year, int month, int day);

    [NativeName("SDL_GetDaysInMonth")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDaysInMonth")]
    int GetDaysInMonth(int year, int month);

    [NativeName("SDL_GetDefaultAssertionHandler")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultAssertionHandler")]
    AssertionHandler GetDefaultAssertionHandler();

    [NativeName("SDL_GetDefaultCursor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultCursor")]
    CursorHandle GetDefaultCursor();

    [NativeName("SDL_GetDefaultLogOutputFunction")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDefaultLogOutputFunction")]
    LogOutputFunction GetDefaultLogOutputFunction();

    [NativeName("SDL_GetDesktopDisplayMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDesktopDisplayMode")]
    Ptr<DisplayMode> GetDesktopDisplayMode(uint displayID);

    [NativeName("SDL_GetDesktopDisplayMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDesktopDisplayMode")]
    DisplayMode* GetDesktopDisplayModeRaw(uint displayID);

    [NativeName("SDL_GetDirect3D9AdapterIndex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDirect3D9AdapterIndex")]
    int GetDirect3D9AdapterIndex(uint displayID);

    [NativeName("SDL_GetDisplayBounds")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayBounds")]
    byte GetDisplayBounds(uint displayID, Rect* rect);

    [NativeName("SDL_GetDisplayBounds")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayBounds")]
    MaybeBool<byte> GetDisplayBounds(uint displayID, Ref<Rect> rect);

    [NativeName("SDL_GetDisplayContentScale")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayContentScale")]
    float GetDisplayContentScale(uint displayID);

    [NativeName("SDL_GetDisplayForPoint")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForPoint")]
    uint GetDisplayForPoint(Point* point);

    [NativeName("SDL_GetDisplayForPoint")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForPoint")]
    uint GetDisplayForPoint(Ref<Point> point);

    [NativeName("SDL_GetDisplayForRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForRect")]
    uint GetDisplayForRect(Rect* rect);

    [NativeName("SDL_GetDisplayForRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForRect")]
    uint GetDisplayForRect(Ref<Rect> rect);

    [NativeName("SDL_GetDisplayForWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayForWindow")]
    uint GetDisplayForWindow(WindowHandle window);

    [NativeName("SDL_GetDisplayName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayName")]
    Ptr<sbyte> GetDisplayName(uint displayID);

    [NativeName("SDL_GetDisplayName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayName")]
    sbyte* GetDisplayNameRaw(uint displayID);

    [NativeName("SDL_GetDisplayProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayProperties")]
    uint GetDisplayProperties(uint displayID);

    [NativeName("SDL_GetDisplays")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplays")]
    uint* GetDisplays(int* count);

    [NativeName("SDL_GetDisplays")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplays")]
    Ptr<uint> GetDisplays(Ref<int> count);

    [NativeName("SDL_GetDisplayUsableBounds")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayUsableBounds")]
    byte GetDisplayUsableBounds(uint displayID, Rect* rect);

    [NativeName("SDL_GetDisplayUsableBounds")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDisplayUsableBounds")]
    MaybeBool<byte> GetDisplayUsableBounds(uint displayID, Ref<Rect> rect);

    [NativeName("SDL_GetDXGIOutputInfo")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDXGIOutputInfo")]
    byte GetDxgiOutputInfo(uint displayID, int* adapterIndex, int* outputIndex);

    [NativeName("SDL_GetDXGIOutputInfo")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetDXGIOutputInfo")]
    MaybeBool<byte> GetDxgiOutputInfo(uint displayID, Ref<int> adapterIndex, Ref<int> outputIndex);

    [NativeName("SDL_getenv")]
    [NativeFunction("SDL3", EntryPoint = "SDL_getenv")]
    sbyte* Getenv(sbyte* name);

    [NativeName("SDL_getenv")]
    [NativeFunction("SDL3", EntryPoint = "SDL_getenv")]
    Ptr<sbyte> Getenv(Ref<sbyte> name);

    [NativeName("SDL_getenv_unsafe")]
    [NativeFunction("SDL3", EntryPoint = "SDL_getenv_unsafe")]
    sbyte* GetenvUnsafe(sbyte* name);

    [NativeName("SDL_getenv_unsafe")]
    [NativeFunction("SDL3", EntryPoint = "SDL_getenv_unsafe")]
    Ptr<sbyte> GetenvUnsafe(Ref<sbyte> name);

    [NativeName("SDL_GetEnvironment")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironment")]
    EnvironmentHandle GetEnvironment();

    [NativeName("SDL_GetEnvironmentVariable")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariable")]
    sbyte* GetEnvironmentVariable(EnvironmentHandle env, sbyte* name);

    [NativeName("SDL_GetEnvironmentVariable")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariable")]
    Ptr<sbyte> GetEnvironmentVariable(EnvironmentHandle env, Ref<sbyte> name);

    [NativeName("SDL_GetEnvironmentVariables")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariables")]
    Ptr2D<sbyte> GetEnvironmentVariables(EnvironmentHandle env);

    [NativeName("SDL_GetEnvironmentVariables")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEnvironmentVariables")]
    sbyte** GetEnvironmentVariablesRaw(EnvironmentHandle env);

    [NativeName("SDL_GetError")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetError")]
    Ptr<sbyte> GetError();

    [NativeName("SDL_GetError")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetError")]
    sbyte* GetErrorRaw();

    [NativeName("SDL_GetEventFilter")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEventFilter")]
    byte GetEventFilter(EventFilter* filter, void** userdata);

    [NativeName("SDL_GetEventFilter")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetEventFilter")]
    MaybeBool<byte> GetEventFilter(Ref<EventFilter> filter, Ref2D userdata);

    [NativeName("SDL_GetFloatProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetFloatProperty")]
    float GetFloatProperty(uint props, sbyte* name, float default_value);

    [NativeName("SDL_GetFloatProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetFloatProperty")]
    float GetFloatProperty(uint props, Ref<sbyte> name, float default_value);

    [NativeName("SDL_GetFullscreenDisplayModes")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetFullscreenDisplayModes")]
    DisplayMode** GetFullscreenDisplayModes(uint displayID, int* count);

    [NativeName("SDL_GetFullscreenDisplayModes")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetFullscreenDisplayModes")]
    Ptr2D<DisplayMode> GetFullscreenDisplayModes(uint displayID, Ref<int> count);

    [NativeName("SDL_GetGamepadAppleSFSymbolsNameForAxis")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis")]
    Ptr<sbyte> GetGamepadAppleSfSymbolsNameForAxis(GamepadHandle gamepad, GamepadAxis axis);

    [NativeName("SDL_GetGamepadAppleSFSymbolsNameForAxis")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis")]
    sbyte* GetGamepadAppleSfSymbolsNameForAxisRaw(GamepadHandle gamepad, GamepadAxis axis);

    [NativeName("SDL_GetGamepadAppleSFSymbolsNameForButton")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton")]
    Ptr<sbyte> GetGamepadAppleSfSymbolsNameForButton(GamepadHandle gamepad, GamepadButton button);

    [NativeName("SDL_GetGamepadAppleSFSymbolsNameForButton")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton")]
    sbyte* GetGamepadAppleSfSymbolsNameForButtonRaw(GamepadHandle gamepad, GamepadButton button);

    [NativeName("SDL_GetGamepadAxis")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAxis")]
    short GetGamepadAxis(GamepadHandle gamepad, GamepadAxis axis);

    [NativeName("SDL_GetGamepadAxisFromString")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAxisFromString")]
    GamepadAxis GetGamepadAxisFromString(sbyte* str);

    [NativeName("SDL_GetGamepadAxisFromString")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadAxisFromString")]
    GamepadAxis GetGamepadAxisFromString(Ref<sbyte> str);

    [NativeName("SDL_GetGamepadBindings")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadBindings")]
    GamepadBinding** GetGamepadBindings(GamepadHandle gamepad, int* count);

    [NativeName("SDL_GetGamepadBindings")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadBindings")]
    Ptr2D<GamepadBinding> GetGamepadBindings(GamepadHandle gamepad, Ref<int> count);

    [NativeName("SDL_GetGamepadButton")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButton")]
    MaybeBool<byte> GetGamepadButton(GamepadHandle gamepad, GamepadButton button);

    [NativeName("SDL_GetGamepadButtonFromString")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonFromString")]
    GamepadButton GetGamepadButtonFromString(sbyte* str);

    [NativeName("SDL_GetGamepadButtonFromString")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonFromString")]
    GamepadButton GetGamepadButtonFromString(Ref<sbyte> str);

    [NativeName("SDL_GetGamepadButtonLabel")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonLabel")]
    GamepadButtonLabel GetGamepadButtonLabel(GamepadHandle gamepad, GamepadButton button);

    [NativeName("SDL_GetGamepadButtonLabelForType")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButtonLabelForType")]
    GamepadButtonLabel GetGamepadButtonLabelForType(GamepadType type, GamepadButton button);

    [NativeName("SDL_GetGamepadButton")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadButton")]
    byte GetGamepadButtonRaw(GamepadHandle gamepad, GamepadButton button);

    [NativeName("SDL_GetGamepadConnectionState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadConnectionState")]
    JoystickConnectionState GetGamepadConnectionState(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadFirmwareVersion")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFirmwareVersion")]
    ushort GetGamepadFirmwareVersion(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadFromID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFromID")]
    GamepadHandle GetGamepadFromId(uint instance_id);

    [NativeName("SDL_GetGamepadFromPlayerIndex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadFromPlayerIndex")]
    GamepadHandle GetGamepadFromPlayerIndex(int player_index);

    [NativeName("SDL_GetGamepadGUIDForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadGUIDForID")]
    Guid GetGamepadGuidForId(uint instance_id);

    [NativeName("SDL_GetGamepadID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadID")]
    uint GetGamepadId(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadJoystick")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadJoystick")]
    JoystickHandle GetGamepadJoystick(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadMapping")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMapping")]
    Ptr<sbyte> GetGamepadMapping(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadMappingForGUID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForGUID")]
    Ptr<sbyte> GetGamepadMappingForGuid(Guid guid);

    [NativeName("SDL_GetGamepadMappingForGUID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForGUID")]
    sbyte* GetGamepadMappingForGuidRaw(Guid guid);

    [NativeName("SDL_GetGamepadMappingForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForID")]
    Ptr<sbyte> GetGamepadMappingForId(uint instance_id);

    [NativeName("SDL_GetGamepadMappingForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappingForID")]
    sbyte* GetGamepadMappingForIdRaw(uint instance_id);

    [NativeName("SDL_GetGamepadMapping")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMapping")]
    sbyte* GetGamepadMappingRaw(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadMappings")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappings")]
    sbyte** GetGamepadMappings(int* count);

    [NativeName("SDL_GetGamepadMappings")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadMappings")]
    Ptr2D<sbyte> GetGamepadMappings(Ref<int> count);

    [NativeName("SDL_GetGamepadName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadName")]
    Ptr<sbyte> GetGamepadName(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadNameForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadNameForID")]
    Ptr<sbyte> GetGamepadNameForId(uint instance_id);

    [NativeName("SDL_GetGamepadNameForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadNameForID")]
    sbyte* GetGamepadNameForIdRaw(uint instance_id);

    [NativeName("SDL_GetGamepadName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadName")]
    sbyte* GetGamepadNameRaw(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadPath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPath")]
    Ptr<sbyte> GetGamepadPath(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadPathForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPathForID")]
    Ptr<sbyte> GetGamepadPathForId(uint instance_id);

    [NativeName("SDL_GetGamepadPathForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPathForID")]
    sbyte* GetGamepadPathForIdRaw(uint instance_id);

    [NativeName("SDL_GetGamepadPath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPath")]
    sbyte* GetGamepadPathRaw(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadPlayerIndex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPlayerIndex")]
    int GetGamepadPlayerIndex(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadPlayerIndexForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPlayerIndexForID")]
    int GetGamepadPlayerIndexForId(uint instance_id);

    [NativeName("SDL_GetGamepadPowerInfo")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPowerInfo")]
    PowerState GetGamepadPowerInfo(GamepadHandle gamepad, int* percent);

    [NativeName("SDL_GetGamepadPowerInfo")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadPowerInfo")]
    PowerState GetGamepadPowerInfo(GamepadHandle gamepad, Ref<int> percent);

    [NativeName("SDL_GetGamepadProduct")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProduct")]
    ushort GetGamepadProduct(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadProductForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProductForID")]
    ushort GetGamepadProductForId(uint instance_id);

    [NativeName("SDL_GetGamepadProductVersion")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProductVersion")]
    ushort GetGamepadProductVersion(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadProductVersionForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProductVersionForID")]
    ushort GetGamepadProductVersionForId(uint instance_id);

    [NativeName("SDL_GetGamepadProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadProperties")]
    uint GetGamepadProperties(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepads")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepads")]
    uint* GetGamepads(int* count);

    [NativeName("SDL_GetGamepads")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepads")]
    Ptr<uint> GetGamepads(Ref<int> count);

    [NativeName("SDL_GetGamepadSensorData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorData")]
    byte GetGamepadSensorData(GamepadHandle gamepad, SensorType type, float* data, int num_values);

    [NativeName("SDL_GetGamepadSensorData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorData")]
    MaybeBool<byte> GetGamepadSensorData(
        GamepadHandle gamepad,
        SensorType type,
        Ref<float> data,
        int num_values
    );

    [NativeName("SDL_GetGamepadSensorDataRate")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSensorDataRate")]
    float GetGamepadSensorDataRate(GamepadHandle gamepad, SensorType type);

    [NativeName("SDL_GetGamepadSerial")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSerial")]
    Ptr<sbyte> GetGamepadSerial(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadSerial")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSerial")]
    sbyte* GetGamepadSerialRaw(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadSteamHandle")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadSteamHandle")]
    ulong GetGamepadSteamHandle(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadStringForAxis")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForAxis")]
    Ptr<sbyte> GetGamepadStringForAxis(GamepadAxis axis);

    [NativeName("SDL_GetGamepadStringForAxis")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForAxis")]
    sbyte* GetGamepadStringForAxisRaw(GamepadAxis axis);

    [NativeName("SDL_GetGamepadStringForButton")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForButton")]
    Ptr<sbyte> GetGamepadStringForButton(GamepadButton button);

    [NativeName("SDL_GetGamepadStringForButton")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForButton")]
    sbyte* GetGamepadStringForButtonRaw(GamepadButton button);

    [NativeName("SDL_GetGamepadStringForType")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForType")]
    Ptr<sbyte> GetGamepadStringForType(GamepadType type);

    [NativeName("SDL_GetGamepadStringForType")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadStringForType")]
    sbyte* GetGamepadStringForTypeRaw(GamepadType type);

    [NativeName("SDL_GetGamepadTouchpadFinger")]
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

    [NativeName("SDL_GetGamepadTouchpadFinger")]
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

    [NativeName("SDL_GetGamepadType")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadType")]
    GamepadType GetGamepadType(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadTypeForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTypeForID")]
    GamepadType GetGamepadTypeForId(uint instance_id);

    [NativeName("SDL_GetGamepadTypeFromString")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTypeFromString")]
    GamepadType GetGamepadTypeFromString(sbyte* str);

    [NativeName("SDL_GetGamepadTypeFromString")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadTypeFromString")]
    GamepadType GetGamepadTypeFromString(Ref<sbyte> str);

    [NativeName("SDL_GetGamepadVendor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadVendor")]
    ushort GetGamepadVendor(GamepadHandle gamepad);

    [NativeName("SDL_GetGamepadVendorForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGamepadVendorForID")]
    ushort GetGamepadVendorForId(uint instance_id);

    [NativeName("SDL_GetGlobalMouseState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalMouseState")]
    uint GetGlobalMouseState(float* x, float* y);

    [NativeName("SDL_GetGlobalMouseState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalMouseState")]
    uint GetGlobalMouseState(Ref<float> x, Ref<float> y);

    [NativeName("SDL_GetGlobalProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGlobalProperties")]
    uint GetGlobalProperties();

    [NativeName("SDL_GetGPUDeviceDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDeviceDriver")]
    Ptr<sbyte> GetGpuDeviceDriver(GpuDeviceHandle device);

    [NativeName("SDL_GetGPUDeviceDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDeviceDriver")]
    sbyte* GetGpuDeviceDriverRaw(GpuDeviceHandle device);

    [NativeName("SDL_GetGPUDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDriver")]
    Ptr<sbyte> GetGpuDriver(int index);

    [NativeName("SDL_GetGPUDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUDriver")]
    sbyte* GetGpuDriverRaw(int index);

    [NativeName("SDL_GetGPUShaderFormats")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUShaderFormats")]
    uint GetGpuShaderFormats(GpuDeviceHandle device);

    [NativeName("SDL_GetGPUSwapchainTextureFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGPUSwapchainTextureFormat")]
    GpuTextureFormat GetGpuSwapchainTextureFormat(GpuDeviceHandle device, WindowHandle window);

    [NativeName("SDL_GetGrabbedWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetGrabbedWindow")]
    WindowHandle GetGrabbedWindow();

    [NativeName("SDL_GetHapticEffectStatus")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticEffectStatus")]
    MaybeBool<byte> GetHapticEffectStatus(HapticHandle haptic, int effect);

    [NativeName("SDL_GetHapticEffectStatus")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticEffectStatus")]
    byte GetHapticEffectStatusRaw(HapticHandle haptic, int effect);

    [NativeName("SDL_GetHapticFeatures")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticFeatures")]
    uint GetHapticFeatures(HapticHandle haptic);

    [NativeName("SDL_GetHapticFromID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticFromID")]
    HapticHandle GetHapticFromId(uint instance_id);

    [NativeName("SDL_GetHapticID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticID")]
    uint GetHapticId(HapticHandle haptic);

    [NativeName("SDL_GetHapticName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticName")]
    Ptr<sbyte> GetHapticName(HapticHandle haptic);

    [NativeName("SDL_GetHapticNameForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticNameForID")]
    Ptr<sbyte> GetHapticNameForId(uint instance_id);

    [NativeName("SDL_GetHapticNameForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticNameForID")]
    sbyte* GetHapticNameForIdRaw(uint instance_id);

    [NativeName("SDL_GetHapticName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHapticName")]
    sbyte* GetHapticNameRaw(HapticHandle haptic);

    [NativeName("SDL_GetHaptics")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHaptics")]
    uint* GetHaptics(int* count);

    [NativeName("SDL_GetHaptics")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHaptics")]
    Ptr<uint> GetHaptics(Ref<int> count);

    [NativeName("SDL_GetHint")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHint")]
    sbyte* GetHint(sbyte* name);

    [NativeName("SDL_GetHint")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHint")]
    Ptr<sbyte> GetHint(Ref<sbyte> name);

    [NativeName("SDL_GetHintBoolean")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHintBoolean")]
    byte GetHintBoolean(sbyte* name, byte default_value);

    [NativeName("SDL_GetHintBoolean")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetHintBoolean")]
    MaybeBool<byte> GetHintBoolean(Ref<sbyte> name, MaybeBool<byte> default_value);

    [NativeName("SDL_GetIOProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetIOProperties")]
    uint GetIoProperties(IoStreamHandle context);

    [NativeName("SDL_GetIOSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetIOSize")]
    long GetIoSize(IoStreamHandle context);

    [NativeName("SDL_GetIOStatus")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetIOStatus")]
    IoStatus GetIoStatus(IoStreamHandle context);

    [NativeName("SDL_GetJoystickAxis")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxis")]
    short GetJoystickAxis(JoystickHandle joystick, int axis);

    [NativeName("SDL_GetJoystickAxisInitialState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxisInitialState")]
    byte GetJoystickAxisInitialState(JoystickHandle joystick, int axis, short* state);

    [NativeName("SDL_GetJoystickAxisInitialState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickAxisInitialState")]
    MaybeBool<byte> GetJoystickAxisInitialState(
        JoystickHandle joystick,
        int axis,
        Ref<short> state
    );

    [NativeName("SDL_GetJoystickBall")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickBall")]
    byte GetJoystickBall(JoystickHandle joystick, int ball, int* dx, int* dy);

    [NativeName("SDL_GetJoystickBall")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickBall")]
    MaybeBool<byte> GetJoystickBall(JoystickHandle joystick, int ball, Ref<int> dx, Ref<int> dy);

    [NativeName("SDL_GetJoystickButton")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickButton")]
    MaybeBool<byte> GetJoystickButton(JoystickHandle joystick, int button);

    [NativeName("SDL_GetJoystickButton")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickButton")]
    byte GetJoystickButtonRaw(JoystickHandle joystick, int button);

    [NativeName("SDL_GetJoystickConnectionState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickConnectionState")]
    JoystickConnectionState GetJoystickConnectionState(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickFirmwareVersion")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFirmwareVersion")]
    ushort GetJoystickFirmwareVersion(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickFromID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFromID")]
    JoystickHandle GetJoystickFromId(uint instance_id);

    [NativeName("SDL_GetJoystickFromPlayerIndex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickFromPlayerIndex")]
    JoystickHandle GetJoystickFromPlayerIndex(int player_index);

    [NativeName("SDL_GetJoystickGUID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUID")]
    Guid GetJoystickGuid(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickGUIDForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDForID")]
    Guid GetJoystickGuidForId(uint instance_id);

    [NativeName("SDL_GetJoystickGUIDInfo")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDInfo")]
    void GetJoystickGuidInfo(
        Guid guid,
        ushort* vendor,
        ushort* product,
        ushort* version,
        ushort* crc16
    );

    [NativeName("SDL_GetJoystickGUIDInfo")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickGUIDInfo")]
    void GetJoystickGuidInfo(
        Guid guid,
        Ref<ushort> vendor,
        Ref<ushort> product,
        Ref<ushort> version,
        Ref<ushort> crc16
    );

    [NativeName("SDL_GetJoystickHat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickHat")]
    byte GetJoystickHat(JoystickHandle joystick, int hat);

    [NativeName("SDL_GetJoystickID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickID")]
    uint GetJoystickId(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickName")]
    Ptr<sbyte> GetJoystickName(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickNameForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickNameForID")]
    Ptr<sbyte> GetJoystickNameForId(uint instance_id);

    [NativeName("SDL_GetJoystickNameForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickNameForID")]
    sbyte* GetJoystickNameForIdRaw(uint instance_id);

    [NativeName("SDL_GetJoystickName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickName")]
    sbyte* GetJoystickNameRaw(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickPath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPath")]
    Ptr<sbyte> GetJoystickPath(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickPathForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPathForID")]
    Ptr<sbyte> GetJoystickPathForId(uint instance_id);

    [NativeName("SDL_GetJoystickPathForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPathForID")]
    sbyte* GetJoystickPathForIdRaw(uint instance_id);

    [NativeName("SDL_GetJoystickPath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPath")]
    sbyte* GetJoystickPathRaw(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickPlayerIndex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPlayerIndex")]
    int GetJoystickPlayerIndex(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickPlayerIndexForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPlayerIndexForID")]
    int GetJoystickPlayerIndexForId(uint instance_id);

    [NativeName("SDL_GetJoystickPowerInfo")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPowerInfo")]
    PowerState GetJoystickPowerInfo(JoystickHandle joystick, int* percent);

    [NativeName("SDL_GetJoystickPowerInfo")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickPowerInfo")]
    PowerState GetJoystickPowerInfo(JoystickHandle joystick, Ref<int> percent);

    [NativeName("SDL_GetJoystickProduct")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProduct")]
    ushort GetJoystickProduct(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickProductForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProductForID")]
    ushort GetJoystickProductForId(uint instance_id);

    [NativeName("SDL_GetJoystickProductVersion")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProductVersion")]
    ushort GetJoystickProductVersion(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickProductVersionForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProductVersionForID")]
    ushort GetJoystickProductVersionForId(uint instance_id);

    [NativeName("SDL_GetJoystickProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickProperties")]
    uint GetJoystickProperties(JoystickHandle joystick);

    [NativeName("SDL_GetJoysticks")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoysticks")]
    uint* GetJoysticks(int* count);

    [NativeName("SDL_GetJoysticks")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoysticks")]
    Ptr<uint> GetJoysticks(Ref<int> count);

    [NativeName("SDL_GetJoystickSerial")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickSerial")]
    Ptr<sbyte> GetJoystickSerial(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickSerial")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickSerial")]
    sbyte* GetJoystickSerialRaw(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickType")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickType")]
    JoystickType GetJoystickType(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickTypeForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickTypeForID")]
    JoystickType GetJoystickTypeForId(uint instance_id);

    [NativeName("SDL_GetJoystickVendor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickVendor")]
    ushort GetJoystickVendor(JoystickHandle joystick);

    [NativeName("SDL_GetJoystickVendorForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetJoystickVendorForID")]
    ushort GetJoystickVendorForId(uint instance_id);

    [NativeName("SDL_GetKeyboardFocus")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardFocus")]
    WindowHandle GetKeyboardFocus();

    [NativeName("SDL_GetKeyboardNameForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardNameForID")]
    Ptr<sbyte> GetKeyboardNameForId(uint instance_id);

    [NativeName("SDL_GetKeyboardNameForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardNameForID")]
    sbyte* GetKeyboardNameForIdRaw(uint instance_id);

    [NativeName("SDL_GetKeyboards")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboards")]
    uint* GetKeyboards(int* count);

    [NativeName("SDL_GetKeyboards")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboards")]
    Ptr<uint> GetKeyboards(Ref<int> count);

    [NativeName("SDL_GetKeyboardState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardState")]
    bool* GetKeyboardState(int* numkeys);

    [NativeName("SDL_GetKeyboardState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyboardState")]
    Ptr<bool> GetKeyboardState(Ref<int> numkeys);

    [NativeName("SDL_GetKeyFromName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromName")]
    uint GetKeyFromName(sbyte* name);

    [NativeName("SDL_GetKeyFromName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromName")]
    uint GetKeyFromName(Ref<sbyte> name);

    [NativeName("SDL_GetKeyFromScancode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromScancode")]
    uint GetKeyFromScancode(Scancode scancode, ushort modstate, byte key_event);

    [NativeName("SDL_GetKeyFromScancode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyFromScancode")]
    uint GetKeyFromScancode(Scancode scancode, ushort modstate, MaybeBool<byte> key_event);

    [NativeName("SDL_GetKeyName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyName")]
    Ptr<sbyte> GetKeyName(uint key);

    [NativeName("SDL_GetKeyName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetKeyName")]
    sbyte* GetKeyNameRaw(uint key);

    [NativeName("SDL_GetLogOutputFunction")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetLogOutputFunction")]
    void GetLogOutputFunction(LogOutputFunction* callback, void** userdata);

    [NativeName("SDL_GetLogOutputFunction")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetLogOutputFunction")]
    void GetLogOutputFunction(Ref<LogOutputFunction> callback, Ref2D userdata);

    [NativeName("SDL_GetLogPriority")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetLogPriority")]
    LogPriority GetLogPriority(int category);

    [NativeName("SDL_GetMasksForPixelFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMasksForPixelFormat")]
    byte GetMasksForPixelFormat(
        PixelFormat format,
        int* bpp,
        uint* Rmask,
        uint* Gmask,
        uint* Bmask,
        uint* Amask
    );

    [NativeName("SDL_GetMasksForPixelFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMasksForPixelFormat")]
    MaybeBool<byte> GetMasksForPixelFormat(
        PixelFormat format,
        Ref<int> bpp,
        Ref<uint> Rmask,
        Ref<uint> Gmask,
        Ref<uint> Bmask,
        Ref<uint> Amask
    );

    [NativeName("SDL_GetMaxHapticEffects")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMaxHapticEffects")]
    int GetMaxHapticEffects(HapticHandle haptic);

    [NativeName("SDL_GetMaxHapticEffectsPlaying")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMaxHapticEffectsPlaying")]
    int GetMaxHapticEffectsPlaying(HapticHandle haptic);

    [NativeName("SDL_GetMemoryFunctions")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMemoryFunctions")]
    void GetMemoryFunctions(
        MallocFunc* malloc_func,
        CallocFunc* calloc_func,
        ReallocFunc* realloc_func,
        FreeFunc* free_func
    );

    [NativeName("SDL_GetMemoryFunctions")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMemoryFunctions")]
    void GetMemoryFunctions(
        Ref<MallocFunc> malloc_func,
        Ref<CallocFunc> calloc_func,
        Ref<ReallocFunc> realloc_func,
        Ref<FreeFunc> free_func
    );

    [NativeName("SDL_GetMice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMice")]
    uint* GetMice(int* count);

    [NativeName("SDL_GetMice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMice")]
    Ptr<uint> GetMice(Ref<int> count);

    [NativeName("SDL_GetModState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetModState")]
    ushort GetModState();

    [NativeName("SDL_GetMouseFocus")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseFocus")]
    WindowHandle GetMouseFocus();

    [NativeName("SDL_GetMouseNameForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseNameForID")]
    Ptr<sbyte> GetMouseNameForId(uint instance_id);

    [NativeName("SDL_GetMouseNameForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseNameForID")]
    sbyte* GetMouseNameForIdRaw(uint instance_id);

    [NativeName("SDL_GetMouseState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseState")]
    uint GetMouseState(float* x, float* y);

    [NativeName("SDL_GetMouseState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetMouseState")]
    uint GetMouseState(Ref<float> x, Ref<float> y);

    [NativeName("SDL_GetNaturalDisplayOrientation")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNaturalDisplayOrientation")]
    DisplayOrientation GetNaturalDisplayOrientation(uint displayID);

    [NativeName("SDL_GetNumAllocations")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumAllocations")]
    int GetNumAllocations();

    [NativeName("SDL_GetNumAudioDrivers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumAudioDrivers")]
    int GetNumAudioDrivers();

    [NativeName("SDL_GetNumberProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumberProperty")]
    long GetNumberProperty(uint props, sbyte* name, long default_value);

    [NativeName("SDL_GetNumberProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumberProperty")]
    long GetNumberProperty(uint props, Ref<sbyte> name, long default_value);

    [NativeName("SDL_GetNumCameraDrivers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumCameraDrivers")]
    int GetNumCameraDrivers();

    [NativeName("SDL_GetNumGamepadTouchpadFingers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGamepadTouchpadFingers")]
    int GetNumGamepadTouchpadFingers(GamepadHandle gamepad, int touchpad);

    [NativeName("SDL_GetNumGamepadTouchpads")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGamepadTouchpads")]
    int GetNumGamepadTouchpads(GamepadHandle gamepad);

    [NativeName("SDL_GetNumGPUDrivers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumGPUDrivers")]
    int GetNumGpuDrivers();

    [NativeName("SDL_GetNumHapticAxes")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumHapticAxes")]
    int GetNumHapticAxes(HapticHandle haptic);

    [NativeName("SDL_GetNumJoystickAxes")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickAxes")]
    int GetNumJoystickAxes(JoystickHandle joystick);

    [NativeName("SDL_GetNumJoystickBalls")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickBalls")]
    int GetNumJoystickBalls(JoystickHandle joystick);

    [NativeName("SDL_GetNumJoystickButtons")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickButtons")]
    int GetNumJoystickButtons(JoystickHandle joystick);

    [NativeName("SDL_GetNumJoystickHats")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumJoystickHats")]
    int GetNumJoystickHats(JoystickHandle joystick);

    [NativeName("SDL_GetNumLogicalCPUCores")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumLogicalCPUCores")]
    int GetNumLogicalCpuCores();

    [NativeName("SDL_GetNumRenderDrivers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumRenderDrivers")]
    int GetNumRenderDrivers();

    [NativeName("SDL_GetNumVideoDrivers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetNumVideoDrivers")]
    int GetNumVideoDrivers();

    [NativeName("SDL_GetOriginalMemoryFunctions")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetOriginalMemoryFunctions")]
    void GetOriginalMemoryFunctions(
        MallocFunc* malloc_func,
        CallocFunc* calloc_func,
        ReallocFunc* realloc_func,
        FreeFunc* free_func
    );

    [NativeName("SDL_GetOriginalMemoryFunctions")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetOriginalMemoryFunctions")]
    void GetOriginalMemoryFunctions(
        Ref<MallocFunc> malloc_func,
        Ref<CallocFunc> calloc_func,
        Ref<ReallocFunc> realloc_func,
        Ref<FreeFunc> free_func
    );

    [NativeName("SDL_GetPathInfo")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPathInfo")]
    byte GetPathInfo(sbyte* path, PathInfo* info);

    [NativeName("SDL_GetPathInfo")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPathInfo")]
    MaybeBool<byte> GetPathInfo(Ref<sbyte> path, Ref<PathInfo> info);

    [NativeName("SDL_GetPerformanceCounter")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPerformanceCounter")]
    ulong GetPerformanceCounter();

    [NativeName("SDL_GetPerformanceFrequency")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPerformanceFrequency")]
    ulong GetPerformanceFrequency();

    [NativeName("SDL_GetPixelFormatDetails")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatDetails")]
    Ptr<PixelFormatDetails> GetPixelFormatDetails(PixelFormat format);

    [NativeName("SDL_GetPixelFormatDetails")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatDetails")]
    PixelFormatDetails* GetPixelFormatDetailsRaw(PixelFormat format);

    [NativeName("SDL_GetPixelFormatForMasks")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatForMasks")]
    PixelFormat GetPixelFormatForMasks(int bpp, uint Rmask, uint Gmask, uint Bmask, uint Amask);

    [NativeName("SDL_GetPixelFormatName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatName")]
    Ptr<sbyte> GetPixelFormatName(PixelFormat format);

    [NativeName("SDL_GetPixelFormatName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPixelFormatName")]
    sbyte* GetPixelFormatNameRaw(PixelFormat format);

    [NativeName("SDL_GetPlatform")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPlatform")]
    Ptr<sbyte> GetPlatform();

    [NativeName("SDL_GetPlatform")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPlatform")]
    sbyte* GetPlatformRaw();

    [NativeName("SDL_GetPointerProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPointerProperty")]
    void* GetPointerProperty(uint props, sbyte* name, void* default_value);

    [NativeName("SDL_GetPointerProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPointerProperty")]
    Ptr GetPointerProperty(uint props, Ref<sbyte> name, Ref default_value);

    [NativeName("SDL_GetPowerInfo")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPowerInfo")]
    PowerState GetPowerInfo(int* seconds, int* percent);

    [NativeName("SDL_GetPowerInfo")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPowerInfo")]
    PowerState GetPowerInfo(Ref<int> seconds, Ref<int> percent);

    [NativeName("SDL_GetPreferredLocales")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPreferredLocales")]
    Locale** GetPreferredLocales(int* count);

    [NativeName("SDL_GetPreferredLocales")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPreferredLocales")]
    Ptr2D<Locale> GetPreferredLocales(Ref<int> count);

    [NativeName("SDL_GetPrefPath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPrefPath")]
    sbyte* GetPrefPath(sbyte* org, sbyte* app);

    [NativeName("SDL_GetPrefPath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPrefPath")]
    Ptr<sbyte> GetPrefPath(Ref<sbyte> org, Ref<sbyte> app);

    [NativeName("SDL_GetPrimaryDisplay")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPrimaryDisplay")]
    uint GetPrimaryDisplay();

    [NativeName("SDL_GetPrimarySelectionText")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPrimarySelectionText")]
    Ptr<sbyte> GetPrimarySelectionText();

    [NativeName("SDL_GetPrimarySelectionText")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPrimarySelectionText")]
    sbyte* GetPrimarySelectionTextRaw();

    [NativeName("SDL_GetProcessInput")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetProcessInput")]
    IoStreamHandle GetProcessInput(ProcessHandle process);

    [NativeName("SDL_GetProcessOutput")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetProcessOutput")]
    IoStreamHandle GetProcessOutput(ProcessHandle process);

    [NativeName("SDL_GetProcessProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetProcessProperties")]
    uint GetProcessProperties(ProcessHandle process);

    [NativeName("SDL_GetPropertyType")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPropertyType")]
    PropertyType GetPropertyType(uint props, sbyte* name);

    [NativeName("SDL_GetPropertyType")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetPropertyType")]
    PropertyType GetPropertyType(uint props, Ref<sbyte> name);

    [NativeName("SDL_GetRealGamepadType")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRealGamepadType")]
    GamepadType GetRealGamepadType(GamepadHandle gamepad);

    [NativeName("SDL_GetRealGamepadTypeForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRealGamepadTypeForID")]
    GamepadType GetRealGamepadTypeForId(uint instance_id);

    [NativeName("SDL_GetRectAndLineIntersection")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersection")]
    byte GetRectAndLineIntersection(Rect* rect, int* X1, int* Y1, int* X2, int* Y2);

    [NativeName("SDL_GetRectAndLineIntersection")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersection")]
    MaybeBool<byte> GetRectAndLineIntersection(
        Ref<Rect> rect,
        Ref<int> X1,
        Ref<int> Y1,
        Ref<int> X2,
        Ref<int> Y2
    );

    [NativeName("SDL_GetRectAndLineIntersectionFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersectionFloat")]
    byte GetRectAndLineIntersectionFloat(FRect* rect, float* X1, float* Y1, float* X2, float* Y2);

    [NativeName("SDL_GetRectAndLineIntersectionFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectAndLineIntersectionFloat")]
    MaybeBool<byte> GetRectAndLineIntersectionFloat(
        Ref<FRect> rect,
        Ref<float> X1,
        Ref<float> Y1,
        Ref<float> X2,
        Ref<float> Y2
    );

    [NativeName("SDL_GetRectEnclosingPoints")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPoints")]
    byte GetRectEnclosingPoints(Point* points, int count, Rect* clip, Rect* result);

    [NativeName("SDL_GetRectEnclosingPoints")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPoints")]
    MaybeBool<byte> GetRectEnclosingPoints(
        Ref<Point> points,
        int count,
        Ref<Rect> clip,
        Ref<Rect> result
    );

    [NativeName("SDL_GetRectEnclosingPointsFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
    byte GetRectEnclosingPointsFloat(FPoint* points, int count, FRect* clip, FRect* result);

    [NativeName("SDL_GetRectEnclosingPointsFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectEnclosingPointsFloat")]
    MaybeBool<byte> GetRectEnclosingPointsFloat(
        Ref<FPoint> points,
        int count,
        Ref<FRect> clip,
        Ref<FRect> result
    );

    [NativeName("SDL_GetRectIntersection")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersection")]
    byte GetRectIntersection(Rect* A, Rect* B, Rect* result);

    [NativeName("SDL_GetRectIntersection")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersection")]
    MaybeBool<byte> GetRectIntersection(Ref<Rect> A, Ref<Rect> B, Ref<Rect> result);

    [NativeName("SDL_GetRectIntersectionFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersectionFloat")]
    byte GetRectIntersectionFloat(FRect* A, FRect* B, FRect* result);

    [NativeName("SDL_GetRectIntersectionFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectIntersectionFloat")]
    MaybeBool<byte> GetRectIntersectionFloat(Ref<FRect> A, Ref<FRect> B, Ref<FRect> result);

    [NativeName("SDL_GetRectUnion")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnion")]
    byte GetRectUnion(Rect* A, Rect* B, Rect* result);

    [NativeName("SDL_GetRectUnion")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnion")]
    MaybeBool<byte> GetRectUnion(Ref<Rect> A, Ref<Rect> B, Ref<Rect> result);

    [NativeName("SDL_GetRectUnionFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnionFloat")]
    byte GetRectUnionFloat(FRect* A, FRect* B, FRect* result);

    [NativeName("SDL_GetRectUnionFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRectUnionFloat")]
    MaybeBool<byte> GetRectUnionFloat(Ref<FRect> A, Ref<FRect> B, Ref<FRect> result);

    [NativeName("SDL_GetRelativeMouseState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseState")]
    uint GetRelativeMouseState(float* x, float* y);

    [NativeName("SDL_GetRelativeMouseState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRelativeMouseState")]
    uint GetRelativeMouseState(Ref<float> x, Ref<float> y);

    [NativeName("SDL_GetRenderClipRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderClipRect")]
    byte GetRenderClipRect(RendererHandle renderer, Rect* rect);

    [NativeName("SDL_GetRenderClipRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderClipRect")]
    MaybeBool<byte> GetRenderClipRect(RendererHandle renderer, Ref<Rect> rect);

    [NativeName("SDL_GetRenderColorScale")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderColorScale")]
    byte GetRenderColorScale(RendererHandle renderer, float* scale);

    [NativeName("SDL_GetRenderColorScale")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderColorScale")]
    MaybeBool<byte> GetRenderColorScale(RendererHandle renderer, Ref<float> scale);

    [NativeName("SDL_GetRenderDrawBlendMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawBlendMode")]
    byte GetRenderDrawBlendMode(RendererHandle renderer, BlendMode* blendMode);

    [NativeName("SDL_GetRenderDrawBlendMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawBlendMode")]
    MaybeBool<byte> GetRenderDrawBlendMode(RendererHandle renderer, Ref<BlendMode> blendMode);

    [NativeName("SDL_GetRenderDrawColor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColor")]
    byte GetRenderDrawColor(RendererHandle renderer, byte* r, byte* g, byte* b, byte* a);

    [NativeName("SDL_GetRenderDrawColor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColor")]
    MaybeBool<byte> GetRenderDrawColor(
        RendererHandle renderer,
        Ref<byte> r,
        Ref<byte> g,
        Ref<byte> b,
        Ref<byte> a
    );

    [NativeName("SDL_GetRenderDrawColorFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColorFloat")]
    byte GetRenderDrawColorFloat(RendererHandle renderer, float* r, float* g, float* b, float* a);

    [NativeName("SDL_GetRenderDrawColorFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDrawColorFloat")]
    MaybeBool<byte> GetRenderDrawColorFloat(
        RendererHandle renderer,
        Ref<float> r,
        Ref<float> g,
        Ref<float> b,
        Ref<float> a
    );

    [NativeName("SDL_GetRenderDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDriver")]
    Ptr<sbyte> GetRenderDriver(int index);

    [NativeName("SDL_GetRenderDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderDriver")]
    sbyte* GetRenderDriverRaw(int index);

    [NativeName("SDL_GetRenderer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderer")]
    RendererHandle GetRenderer(WindowHandle window);

    [NativeName("SDL_GetRendererFromTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererFromTexture")]
    RendererHandle GetRendererFromTexture(Texture* texture);

    [NativeName("SDL_GetRendererFromTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererFromTexture")]
    RendererHandle GetRendererFromTexture(Ref<Texture> texture);

    [NativeName("SDL_GetRendererName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererName")]
    Ptr<sbyte> GetRendererName(RendererHandle renderer);

    [NativeName("SDL_GetRendererName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererName")]
    sbyte* GetRendererNameRaw(RendererHandle renderer);

    [NativeName("SDL_GetRendererProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRendererProperties")]
    uint GetRendererProperties(RendererHandle renderer);

    [NativeName("SDL_GetRenderLogicalPresentation")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentation")]
    byte GetRenderLogicalPresentation(
        RendererHandle renderer,
        int* w,
        int* h,
        RendererLogicalPresentation* mode
    );

    [NativeName("SDL_GetRenderLogicalPresentation")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentation")]
    MaybeBool<byte> GetRenderLogicalPresentation(
        RendererHandle renderer,
        Ref<int> w,
        Ref<int> h,
        Ref<RendererLogicalPresentation> mode
    );

    [NativeName("SDL_GetRenderLogicalPresentationRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentationRect")]
    byte GetRenderLogicalPresentationRect(RendererHandle renderer, FRect* rect);

    [NativeName("SDL_GetRenderLogicalPresentationRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderLogicalPresentationRect")]
    MaybeBool<byte> GetRenderLogicalPresentationRect(RendererHandle renderer, Ref<FRect> rect);

    [NativeName("SDL_GetRenderMetalCommandEncoder")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalCommandEncoder")]
    Ptr GetRenderMetalCommandEncoder(RendererHandle renderer);

    [NativeName("SDL_GetRenderMetalCommandEncoder")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalCommandEncoder")]
    void* GetRenderMetalCommandEncoderRaw(RendererHandle renderer);

    [NativeName("SDL_GetRenderMetalLayer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalLayer")]
    Ptr GetRenderMetalLayer(RendererHandle renderer);

    [NativeName("SDL_GetRenderMetalLayer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderMetalLayer")]
    void* GetRenderMetalLayerRaw(RendererHandle renderer);

    [NativeName("SDL_GetRenderOutputSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderOutputSize")]
    byte GetRenderOutputSize(RendererHandle renderer, int* w, int* h);

    [NativeName("SDL_GetRenderOutputSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderOutputSize")]
    MaybeBool<byte> GetRenderOutputSize(RendererHandle renderer, Ref<int> w, Ref<int> h);

    [NativeName("SDL_GetRenderSafeArea")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderSafeArea")]
    byte GetRenderSafeArea(RendererHandle renderer, Rect* rect);

    [NativeName("SDL_GetRenderSafeArea")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderSafeArea")]
    MaybeBool<byte> GetRenderSafeArea(RendererHandle renderer, Ref<Rect> rect);

    [NativeName("SDL_GetRenderScale")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderScale")]
    byte GetRenderScale(RendererHandle renderer, float* scaleX, float* scaleY);

    [NativeName("SDL_GetRenderScale")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderScale")]
    MaybeBool<byte> GetRenderScale(RendererHandle renderer, Ref<float> scaleX, Ref<float> scaleY);

    [NativeName("SDL_GetRenderTarget")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderTarget")]
    Ptr<Texture> GetRenderTarget(RendererHandle renderer);

    [NativeName("SDL_GetRenderTarget")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderTarget")]
    Texture* GetRenderTargetRaw(RendererHandle renderer);

    [NativeName("SDL_GetRenderViewport")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderViewport")]
    byte GetRenderViewport(RendererHandle renderer, Rect* rect);

    [NativeName("SDL_GetRenderViewport")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderViewport")]
    MaybeBool<byte> GetRenderViewport(RendererHandle renderer, Ref<Rect> rect);

    [NativeName("SDL_GetRenderVSync")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderVSync")]
    byte GetRenderVSync(RendererHandle renderer, int* vsync);

    [NativeName("SDL_GetRenderVSync")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderVSync")]
    MaybeBool<byte> GetRenderVSync(RendererHandle renderer, Ref<int> vsync);

    [NativeName("SDL_GetRenderWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRenderWindow")]
    WindowHandle GetRenderWindow(RendererHandle renderer);

    [NativeName("SDL_GetRevision")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRevision")]
    Ptr<sbyte> GetRevision();

    [NativeName("SDL_GetRevision")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRevision")]
    sbyte* GetRevisionRaw();

    [NativeName("SDL_GetRGB")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRGB")]
    void GetRgb(
        uint pixel,
        PixelFormatDetails* format,
        Palette* palette,
        byte* r,
        byte* g,
        byte* b
    );

    [NativeName("SDL_GetRGB")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRGB")]
    void GetRgb(
        uint pixel,
        Ref<PixelFormatDetails> format,
        Ref<Palette> palette,
        Ref<byte> r,
        Ref<byte> g,
        Ref<byte> b
    );

    [NativeName("SDL_GetRGBA")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRGBA")]
    void GetRgba(
        uint pixel,
        PixelFormatDetails* format,
        Palette* palette,
        byte* r,
        byte* g,
        byte* b,
        byte* a
    );

    [NativeName("SDL_GetRGBA")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetRGBA")]
    void GetRgba(
        uint pixel,
        Ref<PixelFormatDetails> format,
        Ref<Palette> palette,
        Ref<byte> r,
        Ref<byte> g,
        Ref<byte> b,
        Ref<byte> a
    );

    [NativeName("SDL_GetSandbox")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSandbox")]
    Sandbox GetSandbox();

    [NativeName("SDL_GetScancodeFromKey")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromKey")]
    Scancode GetScancodeFromKey(uint key, ushort* modstate);

    [NativeName("SDL_GetScancodeFromKey")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromKey")]
    Scancode GetScancodeFromKey(uint key, Ref<ushort> modstate);

    [NativeName("SDL_GetScancodeFromName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromName")]
    Scancode GetScancodeFromName(sbyte* name);

    [NativeName("SDL_GetScancodeFromName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeFromName")]
    Scancode GetScancodeFromName(Ref<sbyte> name);

    [NativeName("SDL_GetScancodeName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeName")]
    Ptr<sbyte> GetScancodeName(Scancode scancode);

    [NativeName("SDL_GetScancodeName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetScancodeName")]
    sbyte* GetScancodeNameRaw(Scancode scancode);

    [NativeName("SDL_GetSemaphoreValue")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSemaphoreValue")]
    uint GetSemaphoreValue(SemaphoreHandle sem);

    [NativeName("SDL_GetSensorData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorData")]
    byte GetSensorData(SensorHandle sensor, float* data, int num_values);

    [NativeName("SDL_GetSensorData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorData")]
    MaybeBool<byte> GetSensorData(SensorHandle sensor, Ref<float> data, int num_values);

    [NativeName("SDL_GetSensorFromID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorFromID")]
    SensorHandle GetSensorFromId(uint instance_id);

    [NativeName("SDL_GetSensorID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorID")]
    uint GetSensorId(SensorHandle sensor);

    [NativeName("SDL_GetSensorName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorName")]
    Ptr<sbyte> GetSensorName(SensorHandle sensor);

    [NativeName("SDL_GetSensorNameForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNameForID")]
    Ptr<sbyte> GetSensorNameForId(uint instance_id);

    [NativeName("SDL_GetSensorNameForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNameForID")]
    sbyte* GetSensorNameForIdRaw(uint instance_id);

    [NativeName("SDL_GetSensorName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorName")]
    sbyte* GetSensorNameRaw(SensorHandle sensor);

    [NativeName("SDL_GetSensorNonPortableType")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNonPortableType")]
    int GetSensorNonPortableType(SensorHandle sensor);

    [NativeName("SDL_GetSensorNonPortableTypeForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorNonPortableTypeForID")]
    int GetSensorNonPortableTypeForId(uint instance_id);

    [NativeName("SDL_GetSensorProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorProperties")]
    uint GetSensorProperties(SensorHandle sensor);

    [NativeName("SDL_GetSensors")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensors")]
    uint* GetSensors(int* count);

    [NativeName("SDL_GetSensors")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensors")]
    Ptr<uint> GetSensors(Ref<int> count);

    [NativeName("SDL_GetSensorType")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorType")]
    SensorType GetSensorType(SensorHandle sensor);

    [NativeName("SDL_GetSensorTypeForID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSensorTypeForID")]
    SensorType GetSensorTypeForId(uint instance_id);

    [NativeName("SDL_GetSilenceValueForFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSilenceValueForFormat")]
    int GetSilenceValueForFormat(AudioFormat format);

    [NativeName("SDL_GetSIMDAlignment")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSIMDAlignment")]
    nuint GetSimdAlignment();

    [NativeName("SDL_GetStorageFileSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageFileSize")]
    byte GetStorageFileSize(StorageHandle storage, sbyte* path, ulong* length);

    [NativeName("SDL_GetStorageFileSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageFileSize")]
    MaybeBool<byte> GetStorageFileSize(StorageHandle storage, Ref<sbyte> path, Ref<ulong> length);

    [NativeName("SDL_GetStoragePathInfo")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStoragePathInfo")]
    byte GetStoragePathInfo(StorageHandle storage, sbyte* path, PathInfo* info);

    [NativeName("SDL_GetStoragePathInfo")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStoragePathInfo")]
    MaybeBool<byte> GetStoragePathInfo(StorageHandle storage, Ref<sbyte> path, Ref<PathInfo> info);

    [NativeName("SDL_GetStorageSpaceRemaining")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStorageSpaceRemaining")]
    ulong GetStorageSpaceRemaining(StorageHandle storage);

    [NativeName("SDL_GetStringProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStringProperty")]
    sbyte* GetStringProperty(uint props, sbyte* name, sbyte* default_value);

    [NativeName("SDL_GetStringProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetStringProperty")]
    Ptr<sbyte> GetStringProperty(uint props, Ref<sbyte> name, Ref<sbyte> default_value);

    [NativeName("SDL_GetSurfaceAlphaMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceAlphaMod")]
    byte GetSurfaceAlphaMod(Surface* surface, byte* alpha);

    [NativeName("SDL_GetSurfaceAlphaMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceAlphaMod")]
    MaybeBool<byte> GetSurfaceAlphaMod(Ref<Surface> surface, Ref<byte> alpha);

    [NativeName("SDL_GetSurfaceBlendMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceBlendMode")]
    byte GetSurfaceBlendMode(Surface* surface, BlendMode* blendMode);

    [NativeName("SDL_GetSurfaceBlendMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceBlendMode")]
    MaybeBool<byte> GetSurfaceBlendMode(Ref<Surface> surface, Ref<BlendMode> blendMode);

    [NativeName("SDL_GetSurfaceClipRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceClipRect")]
    byte GetSurfaceClipRect(Surface* surface, Rect* rect);

    [NativeName("SDL_GetSurfaceClipRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceClipRect")]
    MaybeBool<byte> GetSurfaceClipRect(Ref<Surface> surface, Ref<Rect> rect);

    [NativeName("SDL_GetSurfaceColorKey")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorKey")]
    byte GetSurfaceColorKey(Surface* surface, uint* key);

    [NativeName("SDL_GetSurfaceColorKey")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorKey")]
    MaybeBool<byte> GetSurfaceColorKey(Ref<Surface> surface, Ref<uint> key);

    [NativeName("SDL_GetSurfaceColorMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorMod")]
    byte GetSurfaceColorMod(Surface* surface, byte* r, byte* g, byte* b);

    [NativeName("SDL_GetSurfaceColorMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorMod")]
    MaybeBool<byte> GetSurfaceColorMod(Ref<Surface> surface, Ref<byte> r, Ref<byte> g, Ref<byte> b);

    [NativeName("SDL_GetSurfaceColorspace")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorspace")]
    Colorspace GetSurfaceColorspace(Surface* surface);

    [NativeName("SDL_GetSurfaceColorspace")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceColorspace")]
    Colorspace GetSurfaceColorspace(Ref<Surface> surface);

    [NativeName("SDL_GetSurfaceImages")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceImages")]
    Surface** GetSurfaceImages(Surface* surface, int* count);

    [NativeName("SDL_GetSurfaceImages")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceImages")]
    Ptr2D<Surface> GetSurfaceImages(Ref<Surface> surface, Ref<int> count);

    [NativeName("SDL_GetSurfacePalette")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfacePalette")]
    Palette* GetSurfacePalette(Surface* surface);

    [NativeName("SDL_GetSurfacePalette")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfacePalette")]
    Ptr<Palette> GetSurfacePalette(Ref<Surface> surface);

    [NativeName("SDL_GetSurfaceProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceProperties")]
    uint GetSurfaceProperties(Surface* surface);

    [NativeName("SDL_GetSurfaceProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSurfaceProperties")]
    uint GetSurfaceProperties(Ref<Surface> surface);

    [NativeName("SDL_GetSystemRAM")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSystemRAM")]
    int GetSystemRam();

    [NativeName("SDL_GetSystemTheme")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetSystemTheme")]
    SystemTheme GetSystemTheme();

    [NativeName("SDL_GetTextInputArea")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextInputArea")]
    byte GetTextInputArea(WindowHandle window, Rect* rect, int* cursor);

    [NativeName("SDL_GetTextInputArea")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextInputArea")]
    MaybeBool<byte> GetTextInputArea(WindowHandle window, Ref<Rect> rect, Ref<int> cursor);

    [NativeName("SDL_GetTextureAlphaMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaMod")]
    byte GetTextureAlphaMod(Texture* texture, byte* alpha);

    [NativeName("SDL_GetTextureAlphaMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaMod")]
    MaybeBool<byte> GetTextureAlphaMod(Ref<Texture> texture, Ref<byte> alpha);

    [NativeName("SDL_GetTextureAlphaModFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaModFloat")]
    byte GetTextureAlphaModFloat(Texture* texture, float* alpha);

    [NativeName("SDL_GetTextureAlphaModFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureAlphaModFloat")]
    MaybeBool<byte> GetTextureAlphaModFloat(Ref<Texture> texture, Ref<float> alpha);

    [NativeName("SDL_GetTextureBlendMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureBlendMode")]
    byte GetTextureBlendMode(Texture* texture, BlendMode* blendMode);

    [NativeName("SDL_GetTextureBlendMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureBlendMode")]
    MaybeBool<byte> GetTextureBlendMode(Ref<Texture> texture, Ref<BlendMode> blendMode);

    [NativeName("SDL_GetTextureColorMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorMod")]
    byte GetTextureColorMod(Texture* texture, byte* r, byte* g, byte* b);

    [NativeName("SDL_GetTextureColorMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorMod")]
    MaybeBool<byte> GetTextureColorMod(Ref<Texture> texture, Ref<byte> r, Ref<byte> g, Ref<byte> b);

    [NativeName("SDL_GetTextureColorModFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorModFloat")]
    byte GetTextureColorModFloat(Texture* texture, float* r, float* g, float* b);

    [NativeName("SDL_GetTextureColorModFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureColorModFloat")]
    MaybeBool<byte> GetTextureColorModFloat(
        Ref<Texture> texture,
        Ref<float> r,
        Ref<float> g,
        Ref<float> b
    );

    [NativeName("SDL_GetTextureProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureProperties")]
    uint GetTextureProperties(Texture* texture);

    [NativeName("SDL_GetTextureProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureProperties")]
    uint GetTextureProperties(Ref<Texture> texture);

    [NativeName("SDL_GetTextureScaleMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureScaleMode")]
    byte GetTextureScaleMode(Texture* texture, ScaleMode* scaleMode);

    [NativeName("SDL_GetTextureScaleMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureScaleMode")]
    MaybeBool<byte> GetTextureScaleMode(Ref<Texture> texture, Ref<ScaleMode> scaleMode);

    [NativeName("SDL_GetTextureSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureSize")]
    byte GetTextureSize(Texture* texture, float* w, float* h);

    [NativeName("SDL_GetTextureSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTextureSize")]
    MaybeBool<byte> GetTextureSize(Ref<Texture> texture, Ref<float> w, Ref<float> h);

    [NativeName("SDL_GetThreadID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadID")]
    ulong GetThreadId(ThreadHandle thread);

    [NativeName("SDL_GetThreadName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadName")]
    Ptr<sbyte> GetThreadName(ThreadHandle thread);

    [NativeName("SDL_GetThreadName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadName")]
    sbyte* GetThreadNameRaw(ThreadHandle thread);

    [NativeName("SDL_GetThreadState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetThreadState")]
    ThreadState GetThreadState(ThreadHandle thread);

    [NativeName("SDL_GetTicks")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTicks")]
    ulong GetTicks();

    [NativeName("SDL_GetTicksNS")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTicksNS")]
    ulong GetTicksNs();

    [NativeName("SDL_GetTLS")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTLS")]
    void* GetTls(AtomicInt* id);

    [NativeName("SDL_GetTLS")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTLS")]
    Ptr GetTls(Ref<AtomicInt> id);

    [NativeName("SDL_GetTouchDeviceName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceName")]
    Ptr<sbyte> GetTouchDeviceName(ulong touchID);

    [NativeName("SDL_GetTouchDeviceName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceName")]
    sbyte* GetTouchDeviceNameRaw(ulong touchID);

    [NativeName("SDL_GetTouchDevices")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDevices")]
    ulong* GetTouchDevices(int* count);

    [NativeName("SDL_GetTouchDevices")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDevices")]
    Ptr<ulong> GetTouchDevices(Ref<int> count);

    [NativeName("SDL_GetTouchDeviceType")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchDeviceType")]
    TouchDeviceType GetTouchDeviceType(ulong touchID);

    [NativeName("SDL_GetTouchFingers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchFingers")]
    Finger** GetTouchFingers(ulong touchID, int* count);

    [NativeName("SDL_GetTouchFingers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetTouchFingers")]
    Ptr2D<Finger> GetTouchFingers(ulong touchID, Ref<int> count);

    [NativeName("SDL_GetUserFolder")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetUserFolder")]
    Ptr<sbyte> GetUserFolder(Folder folder);

    [NativeName("SDL_GetUserFolder")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetUserFolder")]
    sbyte* GetUserFolderRaw(Folder folder);

    [NativeName("SDL_GetVersion")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetVersion")]
    int GetVersion();

    [NativeName("SDL_GetVideoDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetVideoDriver")]
    Ptr<sbyte> GetVideoDriver(int index);

    [NativeName("SDL_GetVideoDriver")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetVideoDriver")]
    sbyte* GetVideoDriverRaw(int index);

    [NativeName("SDL_GetWindowAspectRatio")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowAspectRatio")]
    byte GetWindowAspectRatio(WindowHandle window, float* min_aspect, float* max_aspect);

    [NativeName("SDL_GetWindowAspectRatio")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowAspectRatio")]
    MaybeBool<byte> GetWindowAspectRatio(
        WindowHandle window,
        Ref<float> min_aspect,
        Ref<float> max_aspect
    );

    [NativeName("SDL_GetWindowBordersSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowBordersSize")]
    byte GetWindowBordersSize(WindowHandle window, int* top, int* left, int* bottom, int* right);

    [NativeName("SDL_GetWindowBordersSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowBordersSize")]
    MaybeBool<byte> GetWindowBordersSize(
        WindowHandle window,
        Ref<int> top,
        Ref<int> left,
        Ref<int> bottom,
        Ref<int> right
    );

    [NativeName("SDL_GetWindowDisplayScale")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowDisplayScale")]
    float GetWindowDisplayScale(WindowHandle window);

    [NativeName("SDL_GetWindowFlags")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFlags")]
    ulong GetWindowFlags(WindowHandle window);

    [NativeName("SDL_GetWindowFromEvent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFromEvent")]
    WindowHandle GetWindowFromEvent(Event* @event);

    [NativeName("SDL_GetWindowFromEvent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFromEvent")]
    WindowHandle GetWindowFromEvent(Ref<Event> @event);

    [NativeName("SDL_GetWindowFromID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFromID")]
    WindowHandle GetWindowFromId(uint id);

    [NativeName("SDL_GetWindowFullscreenMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFullscreenMode")]
    Ptr<DisplayMode> GetWindowFullscreenMode(WindowHandle window);

    [NativeName("SDL_GetWindowFullscreenMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowFullscreenMode")]
    DisplayMode* GetWindowFullscreenModeRaw(WindowHandle window);

    [NativeName("SDL_GetWindowICCProfile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowICCProfile")]
    void* GetWindowIccProfile(WindowHandle window, nuint* size);

    [NativeName("SDL_GetWindowICCProfile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowICCProfile")]
    Ptr GetWindowIccProfile(WindowHandle window, Ref<nuint> size);

    [NativeName("SDL_GetWindowID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowID")]
    uint GetWindowId(WindowHandle window);

    [NativeName("SDL_GetWindowKeyboardGrab")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowKeyboardGrab")]
    MaybeBool<byte> GetWindowKeyboardGrab(WindowHandle window);

    [NativeName("SDL_GetWindowKeyboardGrab")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowKeyboardGrab")]
    byte GetWindowKeyboardGrabRaw(WindowHandle window);

    [NativeName("SDL_GetWindowMaximumSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMaximumSize")]
    byte GetWindowMaximumSize(WindowHandle window, int* w, int* h);

    [NativeName("SDL_GetWindowMaximumSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMaximumSize")]
    MaybeBool<byte> GetWindowMaximumSize(WindowHandle window, Ref<int> w, Ref<int> h);

    [NativeName("SDL_GetWindowMinimumSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMinimumSize")]
    byte GetWindowMinimumSize(WindowHandle window, int* w, int* h);

    [NativeName("SDL_GetWindowMinimumSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMinimumSize")]
    MaybeBool<byte> GetWindowMinimumSize(WindowHandle window, Ref<int> w, Ref<int> h);

    [NativeName("SDL_GetWindowMouseGrab")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseGrab")]
    MaybeBool<byte> GetWindowMouseGrab(WindowHandle window);

    [NativeName("SDL_GetWindowMouseGrab")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseGrab")]
    byte GetWindowMouseGrabRaw(WindowHandle window);

    [NativeName("SDL_GetWindowMouseRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseRect")]
    Ptr<Rect> GetWindowMouseRect(WindowHandle window);

    [NativeName("SDL_GetWindowMouseRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowMouseRect")]
    Rect* GetWindowMouseRectRaw(WindowHandle window);

    [NativeName("SDL_GetWindowOpacity")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowOpacity")]
    float GetWindowOpacity(WindowHandle window);

    [NativeName("SDL_GetWindowParent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowParent")]
    WindowHandle GetWindowParent(WindowHandle window);

    [NativeName("SDL_GetWindowPixelDensity")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPixelDensity")]
    float GetWindowPixelDensity(WindowHandle window);

    [NativeName("SDL_GetWindowPixelFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPixelFormat")]
    PixelFormat GetWindowPixelFormat(WindowHandle window);

    [NativeName("SDL_GetWindowPosition")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPosition")]
    byte GetWindowPosition(WindowHandle window, int* x, int* y);

    [NativeName("SDL_GetWindowPosition")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowPosition")]
    MaybeBool<byte> GetWindowPosition(WindowHandle window, Ref<int> x, Ref<int> y);

    [NativeName("SDL_GetWindowProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowProperties")]
    uint GetWindowProperties(WindowHandle window);

    [NativeName("SDL_GetWindowRelativeMouseMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowRelativeMouseMode")]
    MaybeBool<byte> GetWindowRelativeMouseMode(WindowHandle window);

    [NativeName("SDL_GetWindowRelativeMouseMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowRelativeMouseMode")]
    byte GetWindowRelativeMouseModeRaw(WindowHandle window);

    [NativeName("SDL_GetWindows")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindows")]
    WindowHandle* GetWindows(int* count);

    [NativeName("SDL_GetWindows")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindows")]
    Ptr<WindowHandle> GetWindows(Ref<int> count);

    [NativeName("SDL_GetWindowSafeArea")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSafeArea")]
    byte GetWindowSafeArea(WindowHandle window, Rect* rect);

    [NativeName("SDL_GetWindowSafeArea")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSafeArea")]
    MaybeBool<byte> GetWindowSafeArea(WindowHandle window, Ref<Rect> rect);

    [NativeName("SDL_GetWindowSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSize")]
    byte GetWindowSize(WindowHandle window, int* w, int* h);

    [NativeName("SDL_GetWindowSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSize")]
    MaybeBool<byte> GetWindowSize(WindowHandle window, Ref<int> w, Ref<int> h);

    [NativeName("SDL_GetWindowSizeInPixels")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSizeInPixels")]
    byte GetWindowSizeInPixels(WindowHandle window, int* w, int* h);

    [NativeName("SDL_GetWindowSizeInPixels")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSizeInPixels")]
    MaybeBool<byte> GetWindowSizeInPixels(WindowHandle window, Ref<int> w, Ref<int> h);

    [NativeName("SDL_GetWindowSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurface")]
    Ptr<Surface> GetWindowSurface(WindowHandle window);

    [NativeName("SDL_GetWindowSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurface")]
    Surface* GetWindowSurfaceRaw(WindowHandle window);

    [NativeName("SDL_GetWindowSurfaceVSync")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurfaceVSync")]
    byte GetWindowSurfaceVSync(WindowHandle window, int* vsync);

    [NativeName("SDL_GetWindowSurfaceVSync")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowSurfaceVSync")]
    MaybeBool<byte> GetWindowSurfaceVSync(WindowHandle window, Ref<int> vsync);

    [NativeName("SDL_GetWindowTitle")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowTitle")]
    Ptr<sbyte> GetWindowTitle(WindowHandle window);

    [NativeName("SDL_GetWindowTitle")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GetWindowTitle")]
    sbyte* GetWindowTitleRaw(WindowHandle window);

    [NativeName("SDL_GL_CreateContext")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_CreateContext")]
    GlContextStateHandle GlCreateContext(WindowHandle window);

    [NativeName("SDL_GL_DestroyContext")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_DestroyContext")]
    MaybeBool<byte> GlDestroyContext(GlContextStateHandle context);

    [NativeName("SDL_GL_DestroyContext")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_DestroyContext")]
    byte GlDestroyContextRaw(GlContextStateHandle context);

    [NativeName("SDL_GL_ExtensionSupported")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_ExtensionSupported")]
    byte GlExtensionSupported(sbyte* extension);

    [NativeName("SDL_GL_ExtensionSupported")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_ExtensionSupported")]
    MaybeBool<byte> GlExtensionSupported(Ref<sbyte> extension);

    [NativeName("SDL_GL_GetAttribute")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetAttribute")]
    byte GlGetAttribute(GlAttr attr, int* value);

    [NativeName("SDL_GL_GetAttribute")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetAttribute")]
    MaybeBool<byte> GlGetAttribute(GlAttr attr, Ref<int> value);

    [NativeName("SDL_GL_GetCurrentContext")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetCurrentContext")]
    GlContextStateHandle GlGetCurrentContext();

    [NativeName("SDL_GL_GetCurrentWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetCurrentWindow")]
    WindowHandle GlGetCurrentWindow();

    [NativeName("SDL_GL_GetProcAddress")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetProcAddress")]
    FunctionPointer GlGetProcAddress(sbyte* proc);

    [NativeName("SDL_GL_GetProcAddress")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetProcAddress")]
    FunctionPointer GlGetProcAddress(Ref<sbyte> proc);

    [NativeName("SDL_GL_GetSwapInterval")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetSwapInterval")]
    byte GlGetSwapInterval(int* interval);

    [NativeName("SDL_GL_GetSwapInterval")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_GetSwapInterval")]
    MaybeBool<byte> GlGetSwapInterval(Ref<int> interval);

    [NativeName("SDL_GL_LoadLibrary")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_LoadLibrary")]
    byte GlLoadLibrary(sbyte* path);

    [NativeName("SDL_GL_LoadLibrary")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_LoadLibrary")]
    MaybeBool<byte> GlLoadLibrary(Ref<sbyte> path);

    [NativeName("SDL_GL_MakeCurrent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_MakeCurrent")]
    MaybeBool<byte> GlMakeCurrent(WindowHandle window, GlContextStateHandle context);

    [NativeName("SDL_GL_MakeCurrent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_MakeCurrent")]
    byte GlMakeCurrentRaw(WindowHandle window, GlContextStateHandle context);

    [NativeName("SDL_GL_ResetAttributes")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_ResetAttributes")]
    void GlResetAttributes();

    [NativeName("SDL_GL_SetAttribute")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetAttribute")]
    MaybeBool<byte> GlSetAttribute(GlAttr attr, int value);

    [NativeName("SDL_GL_SetAttribute")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetAttribute")]
    byte GlSetAttributeRaw(GlAttr attr, int value);

    [NativeName("SDL_GL_SetSwapInterval")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetSwapInterval")]
    MaybeBool<byte> GlSetSwapInterval(int interval);

    [NativeName("SDL_GL_SetSwapInterval")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SetSwapInterval")]
    byte GlSetSwapIntervalRaw(int interval);

    [NativeName("SDL_GL_SwapWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SwapWindow")]
    MaybeBool<byte> GlSwapWindow(WindowHandle window);

    [NativeName("SDL_GL_SwapWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_SwapWindow")]
    byte GlSwapWindowRaw(WindowHandle window);

    [NativeName("SDL_GL_UnloadLibrary")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GL_UnloadLibrary")]
    void GlUnloadLibrary();

    [NativeName("SDL_GlobDirectory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GlobDirectory")]
    sbyte** GlobDirectory(sbyte* path, sbyte* pattern, uint flags, int* count);

    [NativeName("SDL_GlobDirectory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GlobDirectory")]
    Ptr2D<sbyte> GlobDirectory(Ref<sbyte> path, Ref<sbyte> pattern, uint flags, Ref<int> count);

    [NativeName("SDL_GlobStorageDirectory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GlobStorageDirectory")]
    sbyte** GlobStorageDirectory(
        StorageHandle storage,
        sbyte* path,
        sbyte* pattern,
        uint flags,
        int* count
    );

    [NativeName("SDL_GlobStorageDirectory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GlobStorageDirectory")]
    Ptr2D<sbyte> GlobStorageDirectory(
        StorageHandle storage,
        Ref<sbyte> path,
        Ref<sbyte> pattern,
        uint flags,
        Ref<int> count
    );

    [NativeName("SDL_GPUSupportsProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsProperties")]
    MaybeBool<byte> GpuSupportsProperties(uint props);

    [NativeName("SDL_GPUSupportsProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsProperties")]
    byte GpuSupportsPropertiesRaw(uint props);

    [NativeName("SDL_GPUSupportsShaderFormats")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsShaderFormats")]
    byte GpuSupportsShaderFormats(uint format_flags, sbyte* name);

    [NativeName("SDL_GPUSupportsShaderFormats")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUSupportsShaderFormats")]
    MaybeBool<byte> GpuSupportsShaderFormats(uint format_flags, Ref<sbyte> name);

    [NativeName("SDL_GPUTextureFormatTexelBlockSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureFormatTexelBlockSize")]
    uint GpuTextureFormatTexelBlockSize(GpuTextureFormat format);

    [NativeName("SDL_GPUTextureSupportsFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsFormat")]
    MaybeBool<byte> GpuTextureSupportsFormat(
        GpuDeviceHandle device,
        GpuTextureFormat format,
        GpuTextureType type,
        uint usage
    );

    [NativeName("SDL_GPUTextureSupportsFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsFormat")]
    byte GpuTextureSupportsFormatRaw(
        GpuDeviceHandle device,
        GpuTextureFormat format,
        GpuTextureType type,
        uint usage
    );

    [NativeName("SDL_GPUTextureSupportsSampleCount")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsSampleCount")]
    MaybeBool<byte> GpuTextureSupportsSampleCount(
        GpuDeviceHandle device,
        GpuTextureFormat format,
        GpuSampleCount sample_count
    );

    [NativeName("SDL_GPUTextureSupportsSampleCount")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GPUTextureSupportsSampleCount")]
    byte GpuTextureSupportsSampleCountRaw(
        GpuDeviceHandle device,
        GpuTextureFormat format,
        GpuSampleCount sample_count
    );

    [NativeName("SDL_GUIDToString")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GUIDToString")]
    void GuidToString(Guid guid, sbyte* pszGUID, int cbGUID);

    [NativeName("SDL_GUIDToString")]
    [NativeFunction("SDL3", EntryPoint = "SDL_GUIDToString")]
    void GuidToString(Guid guid, Ref<sbyte> pszGUID, int cbGUID);

    [NativeName("SDL_HapticEffectSupported")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HapticEffectSupported")]
    byte HapticEffectSupported(HapticHandle haptic, HapticEffect* effect);

    [NativeName("SDL_HapticEffectSupported")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HapticEffectSupported")]
    MaybeBool<byte> HapticEffectSupported(HapticHandle haptic, Ref<HapticEffect> effect);

    [NativeName("SDL_HapticRumbleSupported")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HapticRumbleSupported")]
    MaybeBool<byte> HapticRumbleSupported(HapticHandle haptic);

    [NativeName("SDL_HapticRumbleSupported")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HapticRumbleSupported")]
    byte HapticRumbleSupportedRaw(HapticHandle haptic);

    [NativeName("SDL_HasAltiVec")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAltiVec")]
    MaybeBool<byte> HasAltiVec();

    [NativeName("SDL_HasAltiVec")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAltiVec")]
    byte HasAltiVecRaw();

    [NativeName("SDL_HasARMSIMD")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasARMSIMD")]
    MaybeBool<byte> HasArmsimd();

    [NativeName("SDL_HasARMSIMD")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasARMSIMD")]
    byte HasArmsimdRaw();

    [NativeName("SDL_HasAVX")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX")]
    MaybeBool<byte> HasAvx();

    [NativeName("SDL_HasAVX2")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX2")]
    MaybeBool<byte> HasAvx2();

    [NativeName("SDL_HasAVX2")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX2")]
    byte HasAvx2Raw();

    [NativeName("SDL_HasAVX512F")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX512F")]
    MaybeBool<byte> HasAvx512F();

    [NativeName("SDL_HasAVX512F")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX512F")]
    byte HasAvx512FRaw();

    [NativeName("SDL_HasAVX")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasAVX")]
    byte HasAvxRaw();

    [NativeName("SDL_HasClipboardData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardData")]
    byte HasClipboardData(sbyte* mime_type);

    [NativeName("SDL_HasClipboardData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardData")]
    MaybeBool<byte> HasClipboardData(Ref<sbyte> mime_type);

    [NativeName("SDL_HasClipboardText")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardText")]
    MaybeBool<byte> HasClipboardText();

    [NativeName("SDL_HasClipboardText")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasClipboardText")]
    byte HasClipboardTextRaw();

    [NativeName("SDL_HasEvent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasEvent")]
    MaybeBool<byte> HasEvent(uint type);

    [NativeName("SDL_HasEvent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasEvent")]
    byte HasEventRaw(uint type);

    [NativeName("SDL_HasEvents")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasEvents")]
    MaybeBool<byte> HasEvents(uint minType, uint maxType);

    [NativeName("SDL_HasEvents")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasEvents")]
    byte HasEventsRaw(uint minType, uint maxType);

    [NativeName("SDL_HasGamepad")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasGamepad")]
    MaybeBool<byte> HasGamepad();

    [NativeName("SDL_HasGamepad")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasGamepad")]
    byte HasGamepadRaw();

    [NativeName("SDL_HasJoystick")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasJoystick")]
    MaybeBool<byte> HasJoystick();

    [NativeName("SDL_HasJoystick")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasJoystick")]
    byte HasJoystickRaw();

    [NativeName("SDL_HasKeyboard")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasKeyboard")]
    MaybeBool<byte> HasKeyboard();

    [NativeName("SDL_HasKeyboard")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasKeyboard")]
    byte HasKeyboardRaw();

    [NativeName("SDL_HasLASX")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasLASX")]
    MaybeBool<byte> HasLasx();

    [NativeName("SDL_HasLASX")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasLASX")]
    byte HasLasxRaw();

    [NativeName("SDL_HasLSX")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasLSX")]
    MaybeBool<byte> HasLsx();

    [NativeName("SDL_HasLSX")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasLSX")]
    byte HasLsxRaw();

    [NativeName("SDL_HasMMX")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasMMX")]
    MaybeBool<byte> HasMmx();

    [NativeName("SDL_HasMMX")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasMMX")]
    byte HasMmxRaw();

    [NativeName("SDL_HasMouse")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasMouse")]
    MaybeBool<byte> HasMouse();

    [NativeName("SDL_HasMouse")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasMouse")]
    byte HasMouseRaw();

    [NativeName("SDL_HasNEON")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasNEON")]
    MaybeBool<byte> HasNeon();

    [NativeName("SDL_HasNEON")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasNEON")]
    byte HasNeonRaw();

    [NativeName("SDL_HasPrimarySelectionText")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasPrimarySelectionText")]
    MaybeBool<byte> HasPrimarySelectionText();

    [NativeName("SDL_HasPrimarySelectionText")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasPrimarySelectionText")]
    byte HasPrimarySelectionTextRaw();

    [NativeName("SDL_HasProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasProperty")]
    byte HasProperty(uint props, sbyte* name);

    [NativeName("SDL_HasProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasProperty")]
    MaybeBool<byte> HasProperty(uint props, Ref<sbyte> name);

    [NativeName("SDL_HasRectIntersection")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersection")]
    byte HasRectIntersection(Rect* A, Rect* B);

    [NativeName("SDL_HasRectIntersection")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersection")]
    MaybeBool<byte> HasRectIntersection(Ref<Rect> A, Ref<Rect> B);

    [NativeName("SDL_HasRectIntersectionFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersectionFloat")]
    byte HasRectIntersectionFloat(FRect* A, FRect* B);

    [NativeName("SDL_HasRectIntersectionFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasRectIntersectionFloat")]
    MaybeBool<byte> HasRectIntersectionFloat(Ref<FRect> A, Ref<FRect> B);

    [NativeName("SDL_HasScreenKeyboardSupport")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasScreenKeyboardSupport")]
    MaybeBool<byte> HasScreenKeyboardSupport();

    [NativeName("SDL_HasScreenKeyboardSupport")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasScreenKeyboardSupport")]
    byte HasScreenKeyboardSupportRaw();

    [NativeName("SDL_HasSSE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE")]
    MaybeBool<byte> HasSse();

    [NativeName("SDL_HasSSE2")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE2")]
    MaybeBool<byte> HasSse2();

    [NativeName("SDL_HasSSE2")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE2")]
    byte HasSse2Raw();

    [NativeName("SDL_HasSSE3")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE3")]
    MaybeBool<byte> HasSse3();

    [NativeName("SDL_HasSSE3")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE3")]
    byte HasSse3Raw();

    [NativeName("SDL_HasSSE41")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE41")]
    MaybeBool<byte> HasSse41();

    [NativeName("SDL_HasSSE41")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE41")]
    byte HasSse41Raw();

    [NativeName("SDL_HasSSE42")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE42")]
    MaybeBool<byte> HasSse42();

    [NativeName("SDL_HasSSE42")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE42")]
    byte HasSse42Raw();

    [NativeName("SDL_HasSSE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HasSSE")]
    byte HasSseRaw();

    [NativeName("SDL_hid_ble_scan")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_ble_scan")]
    void HidBleScan(byte active);

    [NativeName("SDL_hid_ble_scan")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_ble_scan")]
    void HidBleScan(MaybeBool<byte> active);

    [NativeName("SDL_hid_close")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_close")]
    int HidClose(HidDeviceHandle dev);

    [NativeName("SDL_hid_device_change_count")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_device_change_count")]
    uint HidDeviceChangeCount();

    [NativeName("SDL_hid_enumerate")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_enumerate")]
    Ptr<HidDeviceInfo> HidEnumerate(ushort vendor_id, ushort product_id);

    [NativeName("SDL_hid_enumerate")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_enumerate")]
    HidDeviceInfo* HidEnumerateRaw(ushort vendor_id, ushort product_id);

    [NativeName("SDL_hid_exit")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_exit")]
    int HidExit();

    [NativeName("SDL_hid_free_enumeration")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_free_enumeration")]
    void HidFreeEnumeration(HidDeviceInfo* devs);

    [NativeName("SDL_hid_free_enumeration")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_free_enumeration")]
    void HidFreeEnumeration(Ref<HidDeviceInfo> devs);

    [NativeName("SDL_hid_get_device_info")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_device_info")]
    Ptr<HidDeviceInfo> HidGetDeviceInfo(HidDeviceHandle dev);

    [NativeName("SDL_hid_get_device_info")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_device_info")]
    HidDeviceInfo* HidGetDeviceInfoRaw(HidDeviceHandle dev);

    [NativeName("SDL_hid_get_feature_report")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_feature_report")]
    int HidGetFeatureReport(HidDeviceHandle dev, byte* data, nuint length);

    [NativeName("SDL_hid_get_feature_report")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_feature_report")]
    int HidGetFeatureReport(HidDeviceHandle dev, Ref<byte> data, nuint length);

    [NativeName("SDL_hid_get_indexed_string")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_indexed_string")]
    int HidGetIndexedString(HidDeviceHandle dev, int string_index, ushort* @string, nuint maxlen);

    [NativeName("SDL_hid_get_indexed_string")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_indexed_string")]
    int HidGetIndexedString(
        HidDeviceHandle dev,
        int string_index,
        Ref<ushort> @string,
        nuint maxlen
    );

    [NativeName("SDL_hid_get_input_report")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_input_report")]
    int HidGetInputReport(HidDeviceHandle dev, byte* data, nuint length);

    [NativeName("SDL_hid_get_input_report")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_input_report")]
    int HidGetInputReport(HidDeviceHandle dev, Ref<byte> data, nuint length);

    [NativeName("SDL_hid_get_manufacturer_string")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_manufacturer_string")]
    int HidGetManufacturerString(HidDeviceHandle dev, ushort* @string, nuint maxlen);

    [NativeName("SDL_hid_get_manufacturer_string")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_manufacturer_string")]
    int HidGetManufacturerString(HidDeviceHandle dev, Ref<ushort> @string, nuint maxlen);

    [NativeName("SDL_hid_get_product_string")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_product_string")]
    int HidGetProductString(HidDeviceHandle dev, ushort* @string, nuint maxlen);

    [NativeName("SDL_hid_get_product_string")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_product_string")]
    int HidGetProductString(HidDeviceHandle dev, Ref<ushort> @string, nuint maxlen);

    [NativeName("SDL_hid_get_report_descriptor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_report_descriptor")]
    int HidGetReportDescriptor(HidDeviceHandle dev, byte* buf, nuint buf_size);

    [NativeName("SDL_hid_get_report_descriptor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_report_descriptor")]
    int HidGetReportDescriptor(HidDeviceHandle dev, Ref<byte> buf, nuint buf_size);

    [NativeName("SDL_hid_get_serial_number_string")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_serial_number_string")]
    int HidGetSerialNumberString(HidDeviceHandle dev, ushort* @string, nuint maxlen);

    [NativeName("SDL_hid_get_serial_number_string")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_get_serial_number_string")]
    int HidGetSerialNumberString(HidDeviceHandle dev, Ref<ushort> @string, nuint maxlen);

    [NativeName("SDL_hid_init")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_init")]
    int HidInit();

    [NativeName("SDL_hid_open")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_open")]
    HidDeviceHandle HidOpen(ushort vendor_id, ushort product_id, ushort* serial_number);

    [NativeName("SDL_hid_open")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_open")]
    HidDeviceHandle HidOpen(ushort vendor_id, ushort product_id, Ref<ushort> serial_number);

    [NativeName("SDL_hid_open_path")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_open_path")]
    HidDeviceHandle HidOpenPath(sbyte* path);

    [NativeName("SDL_hid_open_path")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_open_path")]
    HidDeviceHandle HidOpenPath(Ref<sbyte> path);

    [NativeName("SDL_hid_read")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_read")]
    int HidRead(HidDeviceHandle dev, byte* data, nuint length);

    [NativeName("SDL_hid_read")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_read")]
    int HidRead(HidDeviceHandle dev, Ref<byte> data, nuint length);

    [NativeName("SDL_hid_read_timeout")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_read_timeout")]
    int HidReadTimeout(HidDeviceHandle dev, byte* data, nuint length, int milliseconds);

    [NativeName("SDL_hid_read_timeout")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_read_timeout")]
    int HidReadTimeout(HidDeviceHandle dev, Ref<byte> data, nuint length, int milliseconds);

    [NativeName("SDL_hid_send_feature_report")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_send_feature_report")]
    int HidSendFeatureReport(HidDeviceHandle dev, byte* data, nuint length);

    [NativeName("SDL_hid_send_feature_report")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_send_feature_report")]
    int HidSendFeatureReport(HidDeviceHandle dev, Ref<byte> data, nuint length);

    [NativeName("SDL_hid_set_nonblocking")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_set_nonblocking")]
    int HidSetNonblocking(HidDeviceHandle dev, int nonblock);

    [NativeName("SDL_hid_write")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_write")]
    int HidWrite(HidDeviceHandle dev, byte* data, nuint length);

    [NativeName("SDL_hid_write")]
    [NativeFunction("SDL3", EntryPoint = "SDL_hid_write")]
    int HidWrite(HidDeviceHandle dev, Ref<byte> data, nuint length);

    [NativeName("SDL_HideCursor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HideCursor")]
    MaybeBool<byte> HideCursor();

    [NativeName("SDL_HideCursor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HideCursor")]
    byte HideCursorRaw();

    [NativeName("SDL_HideWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HideWindow")]
    MaybeBool<byte> HideWindow(WindowHandle window);

    [NativeName("SDL_HideWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_HideWindow")]
    byte HideWindowRaw(WindowHandle window);

    [NativeName("SDL_iconv")]
    [NativeFunction("SDL3", EntryPoint = "SDL_iconv")]
    nuint Iconv(
        IconvDataTHandle cd,
        sbyte** inbuf,
        nuint* inbytesleft,
        sbyte** outbuf,
        nuint* outbytesleft
    );

    [NativeName("SDL_iconv")]
    [NativeFunction("SDL3", EntryPoint = "SDL_iconv")]
    nuint Iconv(
        IconvDataTHandle cd,
        Ref2D<sbyte> inbuf,
        Ref<nuint> inbytesleft,
        Ref2D<sbyte> outbuf,
        Ref<nuint> outbytesleft
    );

    [NativeName("SDL_iconv_close")]
    [NativeFunction("SDL3", EntryPoint = "SDL_iconv_close")]
    int IconvClose(IconvDataTHandle cd);

    [NativeName("SDL_iconv_open")]
    [NativeFunction("SDL3", EntryPoint = "SDL_iconv_open")]
    IconvDataTHandle IconvOpen(sbyte* tocode, sbyte* fromcode);

    [NativeName("SDL_iconv_open")]
    [NativeFunction("SDL3", EntryPoint = "SDL_iconv_open")]
    IconvDataTHandle IconvOpen(Ref<sbyte> tocode, Ref<sbyte> fromcode);

    [NativeName("SDL_iconv_string")]
    [NativeFunction("SDL3", EntryPoint = "SDL_iconv_string")]
    sbyte* IconvString(sbyte* tocode, sbyte* fromcode, sbyte* inbuf, nuint inbytesleft);

    [NativeName("SDL_iconv_string")]
    [NativeFunction("SDL3", EntryPoint = "SDL_iconv_string")]
    Ptr<sbyte> IconvString(
        Ref<sbyte> tocode,
        Ref<sbyte> fromcode,
        Ref<sbyte> inbuf,
        nuint inbytesleft
    );

    [NativeName("SDL_Init")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Init")]
    MaybeBool<byte> Init(uint flags);

    [NativeName("SDL_InitHapticRumble")]
    [NativeFunction("SDL3", EntryPoint = "SDL_InitHapticRumble")]
    MaybeBool<byte> InitHapticRumble(HapticHandle haptic);

    [NativeName("SDL_InitHapticRumble")]
    [NativeFunction("SDL3", EntryPoint = "SDL_InitHapticRumble")]
    byte InitHapticRumbleRaw(HapticHandle haptic);

    [NativeName("SDL_Init")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Init")]
    byte InitRaw(uint flags);

    [NativeName("SDL_InitSubSystem")]
    [NativeFunction("SDL3", EntryPoint = "SDL_InitSubSystem")]
    MaybeBool<byte> InitSubSystem(uint flags);

    [NativeName("SDL_InitSubSystem")]
    [NativeFunction("SDL3", EntryPoint = "SDL_InitSubSystem")]
    byte InitSubSystemRaw(uint flags);

    [NativeName("SDL_InsertGPUDebugLabel")]
    [NativeFunction("SDL3", EntryPoint = "SDL_InsertGPUDebugLabel")]
    void InsertGpuDebugLabel(GpuCommandBufferHandle command_buffer, sbyte* text);

    [NativeName("SDL_InsertGPUDebugLabel")]
    [NativeFunction("SDL3", EntryPoint = "SDL_InsertGPUDebugLabel")]
    void InsertGpuDebugLabel(GpuCommandBufferHandle command_buffer, Ref<sbyte> text);

    [NativeName("SDL_IOFromConstMem")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOFromConstMem")]
    IoStreamHandle IoFromConstMem(void* mem, nuint size);

    [NativeName("SDL_IOFromConstMem")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOFromConstMem")]
    IoStreamHandle IoFromConstMem(Ref mem, nuint size);

    [NativeName("SDL_IOFromDynamicMem")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOFromDynamicMem")]
    IoStreamHandle IoFromDynamicMem();

    [NativeName("SDL_IOFromFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOFromFile")]
    IoStreamHandle IoFromFile(sbyte* file, sbyte* mode);

    [NativeName("SDL_IOFromFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOFromFile")]
    IoStreamHandle IoFromFile(Ref<sbyte> file, Ref<sbyte> mode);

    [NativeName("SDL_IOFromMem")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOFromMem")]
    IoStreamHandle IoFromMem(void* mem, nuint size);

    [NativeName("SDL_IOFromMem")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOFromMem")]
    IoStreamHandle IoFromMem(Ref mem, nuint size);

    [NativeName("SDL_IOvprintf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOvprintf")]
    nuint IOvprintf(IoStreamHandle context, sbyte* fmt, sbyte* ap);

    [NativeName("SDL_IOvprintf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IOvprintf")]
    nuint IOvprintf(IoStreamHandle context, Ref<sbyte> fmt, Ref<sbyte> ap);

    [NativeName("SDL_isalnum")]
    [NativeFunction("SDL3", EntryPoint = "SDL_isalnum")]
    int Isalnum(int x);

    [NativeName("SDL_isalpha")]
    [NativeFunction("SDL3", EntryPoint = "SDL_isalpha")]
    int Isalpha(int x);

    [NativeName("SDL_IsAudioDevicePhysical")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePhysical")]
    MaybeBool<byte> IsAudioDevicePhysical(uint devid);

    [NativeName("SDL_IsAudioDevicePhysical")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePhysical")]
    byte IsAudioDevicePhysicalRaw(uint devid);

    [NativeName("SDL_IsAudioDevicePlayback")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePlayback")]
    MaybeBool<byte> IsAudioDevicePlayback(uint devid);

    [NativeName("SDL_IsAudioDevicePlayback")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsAudioDevicePlayback")]
    byte IsAudioDevicePlaybackRaw(uint devid);

    [NativeName("SDL_isblank")]
    [NativeFunction("SDL3", EntryPoint = "SDL_isblank")]
    int Isblank(int x);

    [NativeName("SDL_iscntrl")]
    [NativeFunction("SDL3", EntryPoint = "SDL_iscntrl")]
    int Iscntrl(int x);

    [NativeName("SDL_isdigit")]
    [NativeFunction("SDL3", EntryPoint = "SDL_isdigit")]
    int Isdigit(int x);

    [NativeName("SDL_IsGamepad")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsGamepad")]
    MaybeBool<byte> IsGamepad(uint instance_id);

    [NativeName("SDL_IsGamepad")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsGamepad")]
    byte IsGamepadRaw(uint instance_id);

    [NativeName("SDL_isgraph")]
    [NativeFunction("SDL3", EntryPoint = "SDL_isgraph")]
    int Isgraph(int x);

    [NativeName("SDL_isinf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_isinf")]
    int Isinf(double x);

    [NativeName("SDL_isinff")]
    [NativeFunction("SDL3", EntryPoint = "SDL_isinff")]
    int Isinff(float x);

    [NativeName("SDL_IsJoystickHaptic")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickHaptic")]
    MaybeBool<byte> IsJoystickHaptic(JoystickHandle joystick);

    [NativeName("SDL_IsJoystickHaptic")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickHaptic")]
    byte IsJoystickHapticRaw(JoystickHandle joystick);

    [NativeName("SDL_IsJoystickVirtual")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickVirtual")]
    MaybeBool<byte> IsJoystickVirtual(uint instance_id);

    [NativeName("SDL_IsJoystickVirtual")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsJoystickVirtual")]
    byte IsJoystickVirtualRaw(uint instance_id);

    [NativeName("SDL_islower")]
    [NativeFunction("SDL3", EntryPoint = "SDL_islower")]
    int Islower(int x);

    [NativeName("SDL_IsMainThread")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsMainThread")]
    MaybeBool<byte> IsMainThread();

    [NativeName("SDL_IsMainThread")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsMainThread")]
    byte IsMainThreadRaw();

    [NativeName("SDL_IsMouseHaptic")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsMouseHaptic")]
    MaybeBool<byte> IsMouseHaptic();

    [NativeName("SDL_IsMouseHaptic")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsMouseHaptic")]
    byte IsMouseHapticRaw();

    [NativeName("SDL_isnan")]
    [NativeFunction("SDL3", EntryPoint = "SDL_isnan")]
    int Isnan(double x);

    [NativeName("SDL_isnanf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_isnanf")]
    int Isnanf(float x);

    [NativeName("SDL_isprint")]
    [NativeFunction("SDL3", EntryPoint = "SDL_isprint")]
    int Isprint(int x);

    [NativeName("SDL_ispunct")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ispunct")]
    int Ispunct(int x);

    [NativeName("SDL_isspace")]
    [NativeFunction("SDL3", EntryPoint = "SDL_isspace")]
    int Isspace(int x);

    [NativeName("SDL_IsTablet")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsTablet")]
    MaybeBool<byte> IsTablet();

    [NativeName("SDL_IsTablet")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsTablet")]
    byte IsTabletRaw();

    [NativeName("SDL_IsTV")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsTV")]
    MaybeBool<byte> IsTv();

    [NativeName("SDL_IsTV")]
    [NativeFunction("SDL3", EntryPoint = "SDL_IsTV")]
    byte IsTvRaw();

    [NativeName("SDL_isupper")]
    [NativeFunction("SDL3", EntryPoint = "SDL_isupper")]
    int Isupper(int x);

    [NativeName("SDL_isxdigit")]
    [NativeFunction("SDL3", EntryPoint = "SDL_isxdigit")]
    int Isxdigit(int x);

    [NativeName("SDL_itoa")]
    [NativeFunction("SDL3", EntryPoint = "SDL_itoa")]
    sbyte* Itoa(int value, sbyte* str, int radix);

    [NativeName("SDL_itoa")]
    [NativeFunction("SDL3", EntryPoint = "SDL_itoa")]
    Ptr<sbyte> Itoa(int value, Ref<sbyte> str, int radix);

    [NativeName("SDL_JoystickConnected")]
    [NativeFunction("SDL3", EntryPoint = "SDL_JoystickConnected")]
    MaybeBool<byte> JoystickConnected(JoystickHandle joystick);

    [NativeName("SDL_JoystickConnected")]
    [NativeFunction("SDL3", EntryPoint = "SDL_JoystickConnected")]
    byte JoystickConnectedRaw(JoystickHandle joystick);

    [NativeName("SDL_JoystickEventsEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_JoystickEventsEnabled")]
    MaybeBool<byte> JoystickEventsEnabled();

    [NativeName("SDL_JoystickEventsEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_JoystickEventsEnabled")]
    byte JoystickEventsEnabledRaw();

    [NativeName("SDL_KillProcess")]
    [NativeFunction("SDL3", EntryPoint = "SDL_KillProcess")]
    byte KillProcess(ProcessHandle process, byte force);

    [NativeName("SDL_KillProcess")]
    [NativeFunction("SDL3", EntryPoint = "SDL_KillProcess")]
    MaybeBool<byte> KillProcess(ProcessHandle process, MaybeBool<byte> force);

    [NativeName("SDL_lltoa")]
    [NativeFunction("SDL3", EntryPoint = "SDL_lltoa")]
    sbyte* Lltoa(long value, sbyte* str, int radix);

    [NativeName("SDL_lltoa")]
    [NativeFunction("SDL3", EntryPoint = "SDL_lltoa")]
    Ptr<sbyte> Lltoa(long value, Ref<sbyte> str, int radix);

    [NativeName("SDL_LoadBMP")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP")]
    Surface* LoadBmp(sbyte* file);

    [NativeName("SDL_LoadBMP")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP")]
    Ptr<Surface> LoadBmp(Ref<sbyte> file);

    [NativeName("SDL_LoadBMP_IO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP_IO")]
    Surface* LoadBmpIo(IoStreamHandle src, byte closeio);

    [NativeName("SDL_LoadBMP_IO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadBMP_IO")]
    Ptr<Surface> LoadBmpIo(IoStreamHandle src, MaybeBool<byte> closeio);

    [NativeName("SDL_LoadFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile")]
    void* LoadFile(sbyte* file, nuint* datasize);

    [NativeName("SDL_LoadFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile")]
    Ptr LoadFile(Ref<sbyte> file, Ref<nuint> datasize);

    [NativeName("SDL_LoadFile_IO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile_IO")]
    void* LoadFileIo(IoStreamHandle src, nuint* datasize, byte closeio);

    [NativeName("SDL_LoadFile_IO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFile_IO")]
    Ptr LoadFileIo(IoStreamHandle src, Ref<nuint> datasize, MaybeBool<byte> closeio);

    [NativeName("SDL_LoadFunction")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFunction")]
    FunctionPointer LoadFunction(SharedObjectHandle handle, sbyte* name);

    [NativeName("SDL_LoadFunction")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadFunction")]
    FunctionPointer LoadFunction(SharedObjectHandle handle, Ref<sbyte> name);

    [NativeName("SDL_LoadObject")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadObject")]
    SharedObjectHandle LoadObject(sbyte* sofile);

    [NativeName("SDL_LoadObject")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadObject")]
    SharedObjectHandle LoadObject(Ref<sbyte> sofile);

    [NativeName("SDL_LoadWAV")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV")]
    byte LoadWav(sbyte* path, AudioSpec* spec, byte** audio_buf, uint* audio_len);

    [NativeName("SDL_LoadWAV")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV")]
    MaybeBool<byte> LoadWav(
        Ref<sbyte> path,
        Ref<AudioSpec> spec,
        Ref2D<byte> audio_buf,
        Ref<uint> audio_len
    );

    [NativeName("SDL_LoadWAV_IO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV_IO")]
    byte LoadWavIo(
        IoStreamHandle src,
        byte closeio,
        AudioSpec* spec,
        byte** audio_buf,
        uint* audio_len
    );

    [NativeName("SDL_LoadWAV_IO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LoadWAV_IO")]
    MaybeBool<byte> LoadWavIo(
        IoStreamHandle src,
        MaybeBool<byte> closeio,
        Ref<AudioSpec> spec,
        Ref2D<byte> audio_buf,
        Ref<uint> audio_len
    );

    [NativeName("SDL_LockAudioStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockAudioStream")]
    MaybeBool<byte> LockAudioStream(AudioStreamHandle stream);

    [NativeName("SDL_LockAudioStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockAudioStream")]
    byte LockAudioStreamRaw(AudioStreamHandle stream);

    [NativeName("SDL_LockJoysticks")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockJoysticks")]
    void LockJoysticks();

    [NativeName("SDL_LockMutex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockMutex")]
    void LockMutex(MutexHandle mutex);

    [NativeName("SDL_LockProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockProperties")]
    MaybeBool<byte> LockProperties(uint props);

    [NativeName("SDL_LockProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockProperties")]
    byte LockPropertiesRaw(uint props);

    [NativeName("SDL_LockRWLockForReading")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockRWLockForReading")]
    void LockRwLockForReading(RwLockHandle rwlock);

    [NativeName("SDL_LockRWLockForWriting")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockRWLockForWriting")]
    void LockRwLockForWriting(RwLockHandle rwlock);

    [NativeName("SDL_LockSpinlock")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockSpinlock")]
    void LockSpinlock(int* @lock);

    [NativeName("SDL_LockSpinlock")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockSpinlock")]
    void LockSpinlock(Ref<int> @lock);

    [NativeName("SDL_LockSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockSurface")]
    byte LockSurface(Surface* surface);

    [NativeName("SDL_LockSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockSurface")]
    MaybeBool<byte> LockSurface(Ref<Surface> surface);

    [NativeName("SDL_LockTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockTexture")]
    byte LockTexture(Texture* texture, Rect* rect, void** pixels, int* pitch);

    [NativeName("SDL_LockTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockTexture")]
    MaybeBool<byte> LockTexture(Ref<Texture> texture, Ref<Rect> rect, Ref2D pixels, Ref<int> pitch);

    [NativeName("SDL_LockTextureToSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockTextureToSurface")]
    byte LockTextureToSurface(Texture* texture, Rect* rect, Surface** surface);

    [NativeName("SDL_LockTextureToSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LockTextureToSurface")]
    MaybeBool<byte> LockTextureToSurface(
        Ref<Texture> texture,
        Ref<Rect> rect,
        Ref2D<Surface> surface
    );

    [NativeName("SDL_log")]
    [NativeFunction("SDL3", EntryPoint = "SDL_log")]
    double Log(double x);

    [NativeName("SDL_log10")]
    [NativeFunction("SDL3", EntryPoint = "SDL_log10")]
    double Log10(double x);

    [NativeName("SDL_log10f")]
    [NativeFunction("SDL3", EntryPoint = "SDL_log10f")]
    float Log10F(float x);

    [NativeName("SDL_logf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_logf")]
    float Logf(float x);

    [NativeName("SDL_LogMessageV")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LogMessageV")]
    void LogMessageV(int category, LogPriority priority, sbyte* fmt, sbyte* ap);

    [NativeName("SDL_LogMessageV")]
    [NativeFunction("SDL3", EntryPoint = "SDL_LogMessageV")]
    void LogMessageV(int category, LogPriority priority, Ref<sbyte> fmt, Ref<sbyte> ap);

    [NativeName("SDL_lround")]
    [NativeFunction("SDL3", EntryPoint = "SDL_lround")]
    int Lround(double x);

    [NativeName("SDL_lroundf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_lroundf")]
    int Lroundf(float x);

    [NativeName("SDL_ltoa")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ltoa")]
    sbyte* Ltoa(int value, sbyte* str, int radix);

    [NativeName("SDL_ltoa")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ltoa")]
    Ptr<sbyte> Ltoa(int value, Ref<sbyte> str, int radix);

    [NativeName("SDL_main")]
    [NativeFunction("SDL3", EntryPoint = "SDL_main")]
    int Main(int argc, sbyte** argv);

    [NativeName("SDL_main")]
    [NativeFunction("SDL3", EntryPoint = "SDL_main")]
    int Main(int argc, Ref2D<sbyte> argv);

    [NativeName("SDL_malloc")]
    [NativeFunction("SDL3", EntryPoint = "SDL_malloc")]
    Ptr Malloc(nuint size);

    [NativeName("SDL_malloc")]
    [NativeFunction("SDL3", EntryPoint = "SDL_malloc")]
    void* MallocRaw(nuint size);

    [NativeName("SDL_MapGPUTransferBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapGPUTransferBuffer")]
    void* MapGpuTransferBuffer(
        GpuDeviceHandle device,
        GpuTransferBufferHandle transfer_buffer,
        byte cycle
    );

    [NativeName("SDL_MapGPUTransferBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapGPUTransferBuffer")]
    Ptr MapGpuTransferBuffer(
        GpuDeviceHandle device,
        GpuTransferBufferHandle transfer_buffer,
        MaybeBool<byte> cycle
    );

    [NativeName("SDL_MapRGB")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapRGB")]
    uint MapRgb(PixelFormatDetails* format, Palette* palette, byte r, byte g, byte b);

    [NativeName("SDL_MapRGB")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapRGB")]
    uint MapRgb(Ref<PixelFormatDetails> format, Ref<Palette> palette, byte r, byte g, byte b);

    [NativeName("SDL_MapRGBA")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapRGBA")]
    uint MapRgba(PixelFormatDetails* format, Palette* palette, byte r, byte g, byte b, byte a);

    [NativeName("SDL_MapRGBA")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapRGBA")]
    uint MapRgba(
        Ref<PixelFormatDetails> format,
        Ref<Palette> palette,
        byte r,
        byte g,
        byte b,
        byte a
    );

    [NativeName("SDL_MapSurfaceRGB")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGB")]
    uint MapSurfaceRgb(Surface* surface, byte r, byte g, byte b);

    [NativeName("SDL_MapSurfaceRGB")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGB")]
    uint MapSurfaceRgb(Ref<Surface> surface, byte r, byte g, byte b);

    [NativeName("SDL_MapSurfaceRGBA")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGBA")]
    uint MapSurfaceRgba(Surface* surface, byte r, byte g, byte b, byte a);

    [NativeName("SDL_MapSurfaceRGBA")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MapSurfaceRGBA")]
    uint MapSurfaceRgba(Ref<Surface> surface, byte r, byte g, byte b, byte a);

    [NativeName("SDL_MaximizeWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MaximizeWindow")]
    MaybeBool<byte> MaximizeWindow(WindowHandle window);

    [NativeName("SDL_MaximizeWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MaximizeWindow")]
    byte MaximizeWindowRaw(WindowHandle window);

    [NativeName("SDL_memcmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_memcmp")]
    int Memcmp(void* s1, void* s2, nuint len);

    [NativeName("SDL_memcmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_memcmp")]
    int Memcmp(Ref s1, Ref s2, nuint len);

    [NativeName("SDL_MemoryBarrierAcquireFunction")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MemoryBarrierAcquireFunction")]
    void MemoryBarrierAcquireFunction();

    [NativeName("SDL_MemoryBarrierReleaseFunction")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MemoryBarrierReleaseFunction")]
    void MemoryBarrierReleaseFunction();

    [NativeName("SDL_memset4")]
    [NativeFunction("SDL3", EntryPoint = "SDL_memset4")]
    void* Memset4(void* dst, uint val, nuint dwords);

    [NativeName("SDL_memset4")]
    [NativeFunction("SDL3", EntryPoint = "SDL_memset4")]
    Ptr Memset4(Ref dst, uint val, nuint dwords);

    [NativeName("SDL_Metal_CreateView")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Metal_CreateView")]
    Ptr MetalCreateView(WindowHandle window);

    [NativeName("SDL_Metal_CreateView")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Metal_CreateView")]
    void* MetalCreateViewRaw(WindowHandle window);

    [NativeName("SDL_Metal_DestroyView")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Metal_DestroyView")]
    void MetalDestroyView(void* view);

    [NativeName("SDL_Metal_DestroyView")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Metal_DestroyView")]
    void MetalDestroyView(Ref view);

    [NativeName("SDL_Metal_GetLayer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Metal_GetLayer")]
    void* MetalGetLayer(void* view);

    [NativeName("SDL_Metal_GetLayer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Metal_GetLayer")]
    Ptr MetalGetLayer(Ref view);

    [NativeName("SDL_MinimizeWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MinimizeWindow")]
    MaybeBool<byte> MinimizeWindow(WindowHandle window);

    [NativeName("SDL_MinimizeWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MinimizeWindow")]
    byte MinimizeWindowRaw(WindowHandle window);

    [NativeName("SDL_MixAudio")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MixAudio")]
    byte MixAudio(byte* dst, byte* src, AudioFormat format, uint len, float volume);

    [NativeName("SDL_MixAudio")]
    [NativeFunction("SDL3", EntryPoint = "SDL_MixAudio")]
    MaybeBool<byte> MixAudio(
        Ref<byte> dst,
        Ref<byte> src,
        AudioFormat format,
        uint len,
        float volume
    );

    [NativeName("SDL_modf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_modf")]
    double Modf(double x, double* y);

    [NativeName("SDL_modf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_modf")]
    double Modf(double x, Ref<double> y);

    [NativeName("SDL_modff")]
    [NativeFunction("SDL3", EntryPoint = "SDL_modff")]
    float Modff(float x, float* y);

    [NativeName("SDL_modff")]
    [NativeFunction("SDL3", EntryPoint = "SDL_modff")]
    float Modff(float x, Ref<float> y);

    [NativeName("SDL_murmur3_32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_murmur3_32")]
    uint Murmur3X32(void* data, nuint len, uint seed);

    [NativeName("SDL_murmur3_32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_murmur3_32")]
    uint Murmur3X32(Ref data, nuint len, uint seed);

    [NativeName("SDL_OnApplicationDidEnterBackground")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidEnterBackground")]
    void OnApplicationDidEnterBackground();

    [NativeName("SDL_OnApplicationDidEnterForeground")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidEnterForeground")]
    void OnApplicationDidEnterForeground();

    [NativeName("SDL_OnApplicationDidReceiveMemoryWarning")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning")]
    void OnApplicationDidReceiveMemoryWarning();

    [NativeName("SDL_OnApplicationWillEnterBackground")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillEnterBackground")]
    void OnApplicationWillEnterBackground();

    [NativeName("SDL_OnApplicationWillEnterForeground")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillEnterForeground")]
    void OnApplicationWillEnterForeground();

    [NativeName("SDL_OnApplicationWillTerminate")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OnApplicationWillTerminate")]
    void OnApplicationWillTerminate();

    [NativeName("SDL_OpenAudioDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDevice")]
    uint OpenAudioDevice(uint devid, AudioSpec* spec);

    [NativeName("SDL_OpenAudioDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDevice")]
    uint OpenAudioDevice(uint devid, Ref<AudioSpec> spec);

    [NativeName("SDL_OpenAudioDeviceStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDeviceStream")]
    AudioStreamHandle OpenAudioDeviceStream(
        uint devid,
        AudioSpec* spec,
        AudioStreamCallback callback,
        void* userdata
    );

    [NativeName("SDL_OpenAudioDeviceStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenAudioDeviceStream")]
    AudioStreamHandle OpenAudioDeviceStream(
        uint devid,
        Ref<AudioSpec> spec,
        AudioStreamCallback callback,
        Ref userdata
    );

    [NativeName("SDL_OpenCamera")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenCamera")]
    CameraHandle OpenCamera(uint instance_id, CameraSpec* spec);

    [NativeName("SDL_OpenCamera")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenCamera")]
    CameraHandle OpenCamera(uint instance_id, Ref<CameraSpec> spec);

    [NativeName("SDL_OpenFileStorage")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenFileStorage")]
    StorageHandle OpenFileStorage(sbyte* path);

    [NativeName("SDL_OpenFileStorage")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenFileStorage")]
    StorageHandle OpenFileStorage(Ref<sbyte> path);

    [NativeName("SDL_OpenGamepad")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenGamepad")]
    GamepadHandle OpenGamepad(uint instance_id);

    [NativeName("SDL_OpenHaptic")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenHaptic")]
    HapticHandle OpenHaptic(uint instance_id);

    [NativeName("SDL_OpenHapticFromJoystick")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenHapticFromJoystick")]
    HapticHandle OpenHapticFromJoystick(JoystickHandle joystick);

    [NativeName("SDL_OpenHapticFromMouse")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenHapticFromMouse")]
    HapticHandle OpenHapticFromMouse();

    [NativeName("SDL_OpenIO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenIO")]
    IoStreamHandle OpenIo(IoStreamInterface* iface, void* userdata);

    [NativeName("SDL_OpenIO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenIO")]
    IoStreamHandle OpenIo(Ref<IoStreamInterface> iface, Ref userdata);

    [NativeName("SDL_OpenJoystick")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenJoystick")]
    JoystickHandle OpenJoystick(uint instance_id);

    [NativeName("SDL_OpenSensor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenSensor")]
    SensorHandle OpenSensor(uint instance_id);

    [NativeName("SDL_OpenStorage")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenStorage")]
    StorageHandle OpenStorage(StorageInterface* iface, void* userdata);

    [NativeName("SDL_OpenStorage")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenStorage")]
    StorageHandle OpenStorage(Ref<StorageInterface> iface, Ref userdata);

    [NativeName("SDL_OpenTitleStorage")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenTitleStorage")]
    StorageHandle OpenTitleStorage(sbyte* @override, uint props);

    [NativeName("SDL_OpenTitleStorage")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenTitleStorage")]
    StorageHandle OpenTitleStorage(Ref<sbyte> @override, uint props);

    [NativeName("SDL_OpenURL")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenURL")]
    byte OpenUrl(sbyte* url);

    [NativeName("SDL_OpenURL")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenURL")]
    MaybeBool<byte> OpenUrl(Ref<sbyte> url);

    [NativeName("SDL_OpenUserStorage")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenUserStorage")]
    StorageHandle OpenUserStorage(sbyte* org, sbyte* app, uint props);

    [NativeName("SDL_OpenUserStorage")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OpenUserStorage")]
    StorageHandle OpenUserStorage(Ref<sbyte> org, Ref<sbyte> app, uint props);

    [NativeName("SDL_OutOfMemory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OutOfMemory")]
    MaybeBool<byte> OutOfMemory();

    [NativeName("SDL_OutOfMemory")]
    [NativeFunction("SDL3", EntryPoint = "SDL_OutOfMemory")]
    byte OutOfMemoryRaw();

    [NativeName("SDL_PauseAudioDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioDevice")]
    MaybeBool<byte> PauseAudioDevice(uint devid);

    [NativeName("SDL_PauseAudioDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioDevice")]
    byte PauseAudioDeviceRaw(uint devid);

    [NativeName("SDL_PauseAudioStreamDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioStreamDevice")]
    MaybeBool<byte> PauseAudioStreamDevice(AudioStreamHandle stream);

    [NativeName("SDL_PauseAudioStreamDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PauseAudioStreamDevice")]
    byte PauseAudioStreamDeviceRaw(AudioStreamHandle stream);

    [NativeName("SDL_PauseHaptic")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PauseHaptic")]
    MaybeBool<byte> PauseHaptic(HapticHandle haptic);

    [NativeName("SDL_PauseHaptic")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PauseHaptic")]
    byte PauseHapticRaw(HapticHandle haptic);

    [NativeName("SDL_PeepEvents")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PeepEvents")]
    int PeepEvents(Event* events, int numevents, EventAction action, uint minType, uint maxType);

    [NativeName("SDL_PeepEvents")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PeepEvents")]
    int PeepEvents(
        Ref<Event> events,
        int numevents,
        EventAction action,
        uint minType,
        uint maxType
    );

    [NativeName("SDL_PlayHapticRumble")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PlayHapticRumble")]
    MaybeBool<byte> PlayHapticRumble(HapticHandle haptic, float strength, uint length);

    [NativeName("SDL_PlayHapticRumble")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PlayHapticRumble")]
    byte PlayHapticRumbleRaw(HapticHandle haptic, float strength, uint length);

    [NativeName("SDL_PollEvent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PollEvent")]
    byte PollEvent(Event* @event);

    [NativeName("SDL_PollEvent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PollEvent")]
    MaybeBool<byte> PollEvent(Ref<Event> @event);

    [NativeName("SDL_PopGPUDebugGroup")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PopGPUDebugGroup")]
    void PopGpuDebugGroup(GpuCommandBufferHandle command_buffer);

    [NativeName("SDL_pow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_pow")]
    double Pow(double x, double y);

    [NativeName("SDL_powf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_powf")]
    float Powf(float x, float y);

    [NativeName("SDL_PremultiplyAlpha")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplyAlpha")]
    byte PremultiplyAlpha(
        int width,
        int height,
        PixelFormat src_format,
        void* src,
        int src_pitch,
        PixelFormat dst_format,
        void* dst,
        int dst_pitch,
        byte linear
    );

    [NativeName("SDL_PremultiplyAlpha")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplyAlpha")]
    MaybeBool<byte> PremultiplyAlpha(
        int width,
        int height,
        PixelFormat src_format,
        Ref src,
        int src_pitch,
        PixelFormat dst_format,
        Ref dst,
        int dst_pitch,
        MaybeBool<byte> linear
    );

    [NativeName("SDL_PremultiplySurfaceAlpha")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplySurfaceAlpha")]
    byte PremultiplySurfaceAlpha(Surface* surface, byte linear);

    [NativeName("SDL_PremultiplySurfaceAlpha")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PremultiplySurfaceAlpha")]
    MaybeBool<byte> PremultiplySurfaceAlpha(Ref<Surface> surface, MaybeBool<byte> linear);

    [NativeName("SDL_PumpEvents")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PumpEvents")]
    void PumpEvents();

    [NativeName("SDL_PushEvent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushEvent")]
    byte PushEvent(Event* @event);

    [NativeName("SDL_PushEvent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushEvent")]
    MaybeBool<byte> PushEvent(Ref<Event> @event);

    [NativeName("SDL_PushGPUComputeUniformData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUComputeUniformData")]
    void PushGpuComputeUniformData(
        GpuCommandBufferHandle command_buffer,
        uint slot_index,
        void* data,
        uint length
    );

    [NativeName("SDL_PushGPUComputeUniformData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUComputeUniformData")]
    void PushGpuComputeUniformData(
        GpuCommandBufferHandle command_buffer,
        uint slot_index,
        Ref data,
        uint length
    );

    [NativeName("SDL_PushGPUDebugGroup")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUDebugGroup")]
    void PushGpuDebugGroup(GpuCommandBufferHandle command_buffer, sbyte* name);

    [NativeName("SDL_PushGPUDebugGroup")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUDebugGroup")]
    void PushGpuDebugGroup(GpuCommandBufferHandle command_buffer, Ref<sbyte> name);

    [NativeName("SDL_PushGPUFragmentUniformData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUFragmentUniformData")]
    void PushGpuFragmentUniformData(
        GpuCommandBufferHandle command_buffer,
        uint slot_index,
        void* data,
        uint length
    );

    [NativeName("SDL_PushGPUFragmentUniformData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUFragmentUniformData")]
    void PushGpuFragmentUniformData(
        GpuCommandBufferHandle command_buffer,
        uint slot_index,
        Ref data,
        uint length
    );

    [NativeName("SDL_PushGPUVertexUniformData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUVertexUniformData")]
    void PushGpuVertexUniformData(
        GpuCommandBufferHandle command_buffer,
        uint slot_index,
        void* data,
        uint length
    );

    [NativeName("SDL_PushGPUVertexUniformData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PushGPUVertexUniformData")]
    void PushGpuVertexUniformData(
        GpuCommandBufferHandle command_buffer,
        uint slot_index,
        Ref data,
        uint length
    );

    [NativeName("SDL_PutAudioStreamData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PutAudioStreamData")]
    byte PutAudioStreamData(AudioStreamHandle stream, void* buf, int len);

    [NativeName("SDL_PutAudioStreamData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_PutAudioStreamData")]
    MaybeBool<byte> PutAudioStreamData(AudioStreamHandle stream, Ref buf, int len);

    [NativeName("SDL_qsort")]
    [NativeFunction("SDL3", EntryPoint = "SDL_qsort")]
    void Qsort(void* @base, nuint nmemb, nuint size, CompareCallback compare);

    [NativeName("SDL_qsort")]
    [NativeFunction("SDL3", EntryPoint = "SDL_qsort")]
    void Qsort(Ref @base, nuint nmemb, nuint size, CompareCallback compare);

    [NativeName("SDL_qsort_r")]
    [NativeFunction("SDL3", EntryPoint = "SDL_qsort_r")]
    void QsortR(void* @base, nuint nmemb, nuint size, CompareCallbackR compare, void* userdata);

    [NativeName("SDL_qsort_r")]
    [NativeFunction("SDL3", EntryPoint = "SDL_qsort_r")]
    void QsortR(Ref @base, nuint nmemb, nuint size, CompareCallbackR compare, Ref userdata);

    [NativeName("SDL_QueryGPUFence")]
    [NativeFunction("SDL3", EntryPoint = "SDL_QueryGPUFence")]
    MaybeBool<byte> QueryGpuFence(GpuDeviceHandle device, GpuFenceHandle fence);

    [NativeName("SDL_QueryGPUFence")]
    [NativeFunction("SDL3", EntryPoint = "SDL_QueryGPUFence")]
    byte QueryGpuFenceRaw(GpuDeviceHandle device, GpuFenceHandle fence);

    [NativeName("SDL_Quit")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Quit")]
    void Quit();

    [NativeName("SDL_QuitSubSystem")]
    [NativeFunction("SDL3", EntryPoint = "SDL_QuitSubSystem")]
    void QuitSubSystem(uint flags);

    [NativeName("SDL_RaiseWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RaiseWindow")]
    MaybeBool<byte> RaiseWindow(WindowHandle window);

    [NativeName("SDL_RaiseWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RaiseWindow")]
    byte RaiseWindowRaw(WindowHandle window);

    [NativeName("SDL_rand")]
    [NativeFunction("SDL3", EntryPoint = "SDL_rand")]
    int Rand(int n);

    [NativeName("SDL_rand_bits")]
    [NativeFunction("SDL3", EntryPoint = "SDL_rand_bits")]
    uint RandBits();

    [NativeName("SDL_rand_bits_r")]
    [NativeFunction("SDL3", EntryPoint = "SDL_rand_bits_r")]
    uint RandBitsR(ulong* state);

    [NativeName("SDL_rand_bits_r")]
    [NativeFunction("SDL3", EntryPoint = "SDL_rand_bits_r")]
    uint RandBitsR(Ref<ulong> state);

    [NativeName("SDL_rand_r")]
    [NativeFunction("SDL3", EntryPoint = "SDL_rand_r")]
    int RandR(ulong* state, int n);

    [NativeName("SDL_rand_r")]
    [NativeFunction("SDL3", EntryPoint = "SDL_rand_r")]
    int RandR(Ref<ulong> state, int n);

    [NativeName("SDL_randf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_randf")]
    float Randf();

    [NativeName("SDL_randf_r")]
    [NativeFunction("SDL3", EntryPoint = "SDL_randf_r")]
    float RandfR(ulong* state);

    [NativeName("SDL_randf_r")]
    [NativeFunction("SDL3", EntryPoint = "SDL_randf_r")]
    float RandfR(Ref<ulong> state);

    [NativeName("SDL_ReadIO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadIO")]
    nuint ReadIo(IoStreamHandle context, void* ptr, nuint size);

    [NativeName("SDL_ReadIO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadIO")]
    nuint ReadIo(IoStreamHandle context, Ref ptr, nuint size);

    [NativeName("SDL_ReadProcess")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadProcess")]
    void* ReadProcess(ProcessHandle process, nuint* datasize, int* exitcode);

    [NativeName("SDL_ReadProcess")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadProcess")]
    Ptr ReadProcess(ProcessHandle process, Ref<nuint> datasize, Ref<int> exitcode);

    [NativeName("SDL_ReadS16BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16BE")]
    byte ReadS16Be(IoStreamHandle src, short* value);

    [NativeName("SDL_ReadS16BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16BE")]
    MaybeBool<byte> ReadS16Be(IoStreamHandle src, Ref<short> value);

    [NativeName("SDL_ReadS16LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16LE")]
    byte ReadS16Le(IoStreamHandle src, short* value);

    [NativeName("SDL_ReadS16LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS16LE")]
    MaybeBool<byte> ReadS16Le(IoStreamHandle src, Ref<short> value);

    [NativeName("SDL_ReadS32BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32BE")]
    byte ReadS32Be(IoStreamHandle src, int* value);

    [NativeName("SDL_ReadS32BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32BE")]
    MaybeBool<byte> ReadS32Be(IoStreamHandle src, Ref<int> value);

    [NativeName("SDL_ReadS32LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32LE")]
    byte ReadS32Le(IoStreamHandle src, int* value);

    [NativeName("SDL_ReadS32LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS32LE")]
    MaybeBool<byte> ReadS32Le(IoStreamHandle src, Ref<int> value);

    [NativeName("SDL_ReadS64BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64BE")]
    byte ReadS64Be(IoStreamHandle src, long* value);

    [NativeName("SDL_ReadS64BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64BE")]
    MaybeBool<byte> ReadS64Be(IoStreamHandle src, Ref<long> value);

    [NativeName("SDL_ReadS64LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64LE")]
    byte ReadS64Le(IoStreamHandle src, long* value);

    [NativeName("SDL_ReadS64LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS64LE")]
    MaybeBool<byte> ReadS64Le(IoStreamHandle src, Ref<long> value);

    [NativeName("SDL_ReadS8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS8")]
    byte ReadS8(IoStreamHandle src, sbyte* value);

    [NativeName("SDL_ReadS8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadS8")]
    MaybeBool<byte> ReadS8(IoStreamHandle src, Ref<sbyte> value);

    [NativeName("SDL_ReadStorageFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadStorageFile")]
    byte ReadStorageFile(StorageHandle storage, sbyte* path, void* destination, ulong length);

    [NativeName("SDL_ReadStorageFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadStorageFile")]
    MaybeBool<byte> ReadStorageFile(
        StorageHandle storage,
        Ref<sbyte> path,
        Ref destination,
        ulong length
    );

    [NativeName("SDL_ReadSurfacePixel")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixel")]
    byte ReadSurfacePixel(Surface* surface, int x, int y, byte* r, byte* g, byte* b, byte* a);

    [NativeName("SDL_ReadSurfacePixel")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadSurfacePixel")]
    MaybeBool<byte> ReadSurfacePixel(
        Ref<Surface> surface,
        int x,
        int y,
        Ref<byte> r,
        Ref<byte> g,
        Ref<byte> b,
        Ref<byte> a
    );

    [NativeName("SDL_ReadSurfacePixelFloat")]
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

    [NativeName("SDL_ReadSurfacePixelFloat")]
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

    [NativeName("SDL_ReadU16BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16BE")]
    byte ReadU16Be(IoStreamHandle src, ushort* value);

    [NativeName("SDL_ReadU16BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16BE")]
    MaybeBool<byte> ReadU16Be(IoStreamHandle src, Ref<ushort> value);

    [NativeName("SDL_ReadU16LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16LE")]
    byte ReadU16Le(IoStreamHandle src, ushort* value);

    [NativeName("SDL_ReadU16LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU16LE")]
    MaybeBool<byte> ReadU16Le(IoStreamHandle src, Ref<ushort> value);

    [NativeName("SDL_ReadU32BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32BE")]
    byte ReadU32Be(IoStreamHandle src, uint* value);

    [NativeName("SDL_ReadU32BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32BE")]
    MaybeBool<byte> ReadU32Be(IoStreamHandle src, Ref<uint> value);

    [NativeName("SDL_ReadU32LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32LE")]
    byte ReadU32Le(IoStreamHandle src, uint* value);

    [NativeName("SDL_ReadU32LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU32LE")]
    MaybeBool<byte> ReadU32Le(IoStreamHandle src, Ref<uint> value);

    [NativeName("SDL_ReadU64BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64BE")]
    byte ReadU64Be(IoStreamHandle src, ulong* value);

    [NativeName("SDL_ReadU64BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64BE")]
    MaybeBool<byte> ReadU64Be(IoStreamHandle src, Ref<ulong> value);

    [NativeName("SDL_ReadU64LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64LE")]
    byte ReadU64Le(IoStreamHandle src, ulong* value);

    [NativeName("SDL_ReadU64LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU64LE")]
    MaybeBool<byte> ReadU64Le(IoStreamHandle src, Ref<ulong> value);

    [NativeName("SDL_ReadU8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU8")]
    byte ReadU8(IoStreamHandle src, byte* value);

    [NativeName("SDL_ReadU8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReadU8")]
    MaybeBool<byte> ReadU8(IoStreamHandle src, Ref<byte> value);

    [NativeName("SDL_realloc")]
    [NativeFunction("SDL3", EntryPoint = "SDL_realloc")]
    void* Realloc(void* mem, nuint size);

    [NativeName("SDL_realloc")]
    [NativeFunction("SDL3", EntryPoint = "SDL_realloc")]
    Ptr Realloc(Ref mem, nuint size);

    [NativeName("SDL_RegisterApp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RegisterApp")]
    byte RegisterApp(sbyte* name, uint style, void* hInst);

    [NativeName("SDL_RegisterApp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RegisterApp")]
    MaybeBool<byte> RegisterApp(Ref<sbyte> name, uint style, Ref hInst);

    [NativeName("SDL_RegisterEvents")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RegisterEvents")]
    uint RegisterEvents(int numevents);

    [NativeName("SDL_ReleaseCameraFrame")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseCameraFrame")]
    void ReleaseCameraFrame(CameraHandle camera, Surface* frame);

    [NativeName("SDL_ReleaseCameraFrame")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseCameraFrame")]
    void ReleaseCameraFrame(CameraHandle camera, Ref<Surface> frame);

    [NativeName("SDL_ReleaseGPUBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUBuffer")]
    void ReleaseGpuBuffer(GpuDeviceHandle device, GpuBufferHandle buffer);

    [NativeName("SDL_ReleaseGPUComputePipeline")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUComputePipeline")]
    void ReleaseGpuComputePipeline(
        GpuDeviceHandle device,
        GpuComputePipelineHandle compute_pipeline
    );

    [NativeName("SDL_ReleaseGPUFence")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUFence")]
    void ReleaseGpuFence(GpuDeviceHandle device, GpuFenceHandle fence);

    [NativeName("SDL_ReleaseGPUGraphicsPipeline")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUGraphicsPipeline")]
    void ReleaseGpuGraphicsPipeline(
        GpuDeviceHandle device,
        GpuGraphicsPipelineHandle graphics_pipeline
    );

    [NativeName("SDL_ReleaseGPUSampler")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUSampler")]
    void ReleaseGpuSampler(GpuDeviceHandle device, GpuSamplerHandle sampler);

    [NativeName("SDL_ReleaseGPUShader")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUShader")]
    void ReleaseGpuShader(GpuDeviceHandle device, GpuShaderHandle shader);

    [NativeName("SDL_ReleaseGPUTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUTexture")]
    void ReleaseGpuTexture(GpuDeviceHandle device, GpuTextureHandle texture);

    [NativeName("SDL_ReleaseGPUTransferBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseGPUTransferBuffer")]
    void ReleaseGpuTransferBuffer(GpuDeviceHandle device, GpuTransferBufferHandle transfer_buffer);

    [NativeName("SDL_ReleaseWindowFromGPUDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReleaseWindowFromGPUDevice")]
    void ReleaseWindowFromGpuDevice(GpuDeviceHandle device, WindowHandle window);

    [NativeName("SDL_ReloadGamepadMappings")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReloadGamepadMappings")]
    MaybeBool<byte> ReloadGamepadMappings();

    [NativeName("SDL_ReloadGamepadMappings")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReloadGamepadMappings")]
    byte ReloadGamepadMappingsRaw();

    [NativeName("SDL_RemoveEventWatch")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveEventWatch")]
    void RemoveEventWatch(EventFilter filter, void* userdata);

    [NativeName("SDL_RemoveEventWatch")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveEventWatch")]
    void RemoveEventWatch(EventFilter filter, Ref userdata);

    [NativeName("SDL_RemoveHintCallback")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveHintCallback")]
    void RemoveHintCallback(sbyte* name, HintCallback callback, void* userdata);

    [NativeName("SDL_RemoveHintCallback")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveHintCallback")]
    void RemoveHintCallback(Ref<sbyte> name, HintCallback callback, Ref userdata);

    [NativeName("SDL_RemovePath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemovePath")]
    byte RemovePath(sbyte* path);

    [NativeName("SDL_RemovePath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemovePath")]
    MaybeBool<byte> RemovePath(Ref<sbyte> path);

    [NativeName("SDL_RemoveStoragePath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveStoragePath")]
    byte RemoveStoragePath(StorageHandle storage, sbyte* path);

    [NativeName("SDL_RemoveStoragePath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveStoragePath")]
    MaybeBool<byte> RemoveStoragePath(StorageHandle storage, Ref<sbyte> path);

    [NativeName("SDL_RemoveSurfaceAlternateImages")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveSurfaceAlternateImages")]
    void RemoveSurfaceAlternateImages(Surface* surface);

    [NativeName("SDL_RemoveSurfaceAlternateImages")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveSurfaceAlternateImages")]
    void RemoveSurfaceAlternateImages(Ref<Surface> surface);

    [NativeName("SDL_RemoveTimer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveTimer")]
    MaybeBool<byte> RemoveTimer(uint id);

    [NativeName("SDL_RemoveTimer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RemoveTimer")]
    byte RemoveTimerRaw(uint id);

    [NativeName("SDL_RenamePath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenamePath")]
    byte RenamePath(sbyte* oldpath, sbyte* newpath);

    [NativeName("SDL_RenamePath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenamePath")]
    MaybeBool<byte> RenamePath(Ref<sbyte> oldpath, Ref<sbyte> newpath);

    [NativeName("SDL_RenameStoragePath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenameStoragePath")]
    byte RenameStoragePath(StorageHandle storage, sbyte* oldpath, sbyte* newpath);

    [NativeName("SDL_RenameStoragePath")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenameStoragePath")]
    MaybeBool<byte> RenameStoragePath(
        StorageHandle storage,
        Ref<sbyte> oldpath,
        Ref<sbyte> newpath
    );

    [NativeName("SDL_RenderClear")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderClear")]
    MaybeBool<byte> RenderClear(RendererHandle renderer);

    [NativeName("SDL_RenderClear")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderClear")]
    byte RenderClearRaw(RendererHandle renderer);

    [NativeName("SDL_RenderClipEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderClipEnabled")]
    MaybeBool<byte> RenderClipEnabled(RendererHandle renderer);

    [NativeName("SDL_RenderClipEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderClipEnabled")]
    byte RenderClipEnabledRaw(RendererHandle renderer);

    [NativeName("SDL_RenderCoordinatesFromWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesFromWindow")]
    byte RenderCoordinatesFromWindow(
        RendererHandle renderer,
        float window_x,
        float window_y,
        float* x,
        float* y
    );

    [NativeName("SDL_RenderCoordinatesFromWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesFromWindow")]
    MaybeBool<byte> RenderCoordinatesFromWindow(
        RendererHandle renderer,
        float window_x,
        float window_y,
        Ref<float> x,
        Ref<float> y
    );

    [NativeName("SDL_RenderCoordinatesToWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesToWindow")]
    byte RenderCoordinatesToWindow(
        RendererHandle renderer,
        float x,
        float y,
        float* window_x,
        float* window_y
    );

    [NativeName("SDL_RenderCoordinatesToWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderCoordinatesToWindow")]
    MaybeBool<byte> RenderCoordinatesToWindow(
        RendererHandle renderer,
        float x,
        float y,
        Ref<float> window_x,
        Ref<float> window_y
    );

    [NativeName("SDL_RenderDebugText")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderDebugText")]
    byte RenderDebugText(RendererHandle renderer, float x, float y, sbyte* str);

    [NativeName("SDL_RenderDebugText")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderDebugText")]
    MaybeBool<byte> RenderDebugText(RendererHandle renderer, float x, float y, Ref<sbyte> str);

    [NativeName("SDL_RenderFillRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRect")]
    byte RenderFillRect(RendererHandle renderer, FRect* rect);

    [NativeName("SDL_RenderFillRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRect")]
    MaybeBool<byte> RenderFillRect(RendererHandle renderer, Ref<FRect> rect);

    [NativeName("SDL_RenderFillRects")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRects")]
    byte RenderFillRects(RendererHandle renderer, FRect* rects, int count);

    [NativeName("SDL_RenderFillRects")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderFillRects")]
    MaybeBool<byte> RenderFillRects(RendererHandle renderer, Ref<FRect> rects, int count);

    [NativeName("SDL_RenderGeometry")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometry")]
    byte RenderGeometry(
        RendererHandle renderer,
        Texture* texture,
        Vertex* vertices,
        int num_vertices,
        int* indices,
        int num_indices
    );

    [NativeName("SDL_RenderGeometry")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometry")]
    MaybeBool<byte> RenderGeometry(
        RendererHandle renderer,
        Ref<Texture> texture,
        Ref<Vertex> vertices,
        int num_vertices,
        Ref<int> indices,
        int num_indices
    );

    [NativeName("SDL_RenderGeometryRaw")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRaw")]
    byte RenderGeometryRaw(
        RendererHandle renderer,
        Texture* texture,
        float* xy,
        int xy_stride,
        FColor* color,
        int color_stride,
        float* uv,
        int uv_stride,
        int num_vertices,
        void* indices,
        int num_indices,
        int size_indices
    );

    [NativeName("SDL_RenderGeometryRaw")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderGeometryRaw")]
    MaybeBool<byte> RenderGeometryRaw(
        RendererHandle renderer,
        Ref<Texture> texture,
        Ref<float> xy,
        int xy_stride,
        Ref<FColor> color,
        int color_stride,
        Ref<float> uv,
        int uv_stride,
        int num_vertices,
        Ref indices,
        int num_indices,
        int size_indices
    );

    [NativeName("SDL_RenderLine")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderLine")]
    MaybeBool<byte> RenderLine(RendererHandle renderer, float x1, float y1, float x2, float y2);

    [NativeName("SDL_RenderLine")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderLine")]
    byte RenderLineRaw(RendererHandle renderer, float x1, float y1, float x2, float y2);

    [NativeName("SDL_RenderLines")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderLines")]
    byte RenderLines(RendererHandle renderer, FPoint* points, int count);

    [NativeName("SDL_RenderLines")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderLines")]
    MaybeBool<byte> RenderLines(RendererHandle renderer, Ref<FPoint> points, int count);

    [NativeName("SDL_RenderPoint")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoint")]
    MaybeBool<byte> RenderPoint(RendererHandle renderer, float x, float y);

    [NativeName("SDL_RenderPoint")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoint")]
    byte RenderPointRaw(RendererHandle renderer, float x, float y);

    [NativeName("SDL_RenderPoints")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoints")]
    byte RenderPoints(RendererHandle renderer, FPoint* points, int count);

    [NativeName("SDL_RenderPoints")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPoints")]
    MaybeBool<byte> RenderPoints(RendererHandle renderer, Ref<FPoint> points, int count);

    [NativeName("SDL_RenderPresent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPresent")]
    MaybeBool<byte> RenderPresent(RendererHandle renderer);

    [NativeName("SDL_RenderPresent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderPresent")]
    byte RenderPresentRaw(RendererHandle renderer);

    [NativeName("SDL_RenderReadPixels")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderReadPixels")]
    Surface* RenderReadPixels(RendererHandle renderer, Rect* rect);

    [NativeName("SDL_RenderReadPixels")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderReadPixels")]
    Ptr<Surface> RenderReadPixels(RendererHandle renderer, Ref<Rect> rect);

    [NativeName("SDL_RenderRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderRect")]
    byte RenderRect(RendererHandle renderer, FRect* rect);

    [NativeName("SDL_RenderRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderRect")]
    MaybeBool<byte> RenderRect(RendererHandle renderer, Ref<FRect> rect);

    [NativeName("SDL_RenderRects")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderRects")]
    byte RenderRects(RendererHandle renderer, FRect* rects, int count);

    [NativeName("SDL_RenderRects")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderRects")]
    MaybeBool<byte> RenderRects(RendererHandle renderer, Ref<FRect> rects, int count);

    [NativeName("SDL_RenderTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture")]
    byte RenderTexture(RendererHandle renderer, Texture* texture, FRect* srcrect, FRect* dstrect);

    [NativeName("SDL_RenderTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture")]
    MaybeBool<byte> RenderTexture(
        RendererHandle renderer,
        Ref<Texture> texture,
        Ref<FRect> srcrect,
        Ref<FRect> dstrect
    );

    [NativeName("SDL_RenderTexture9Grid")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture9Grid")]
    byte RenderTexture9Grid(
        RendererHandle renderer,
        Texture* texture,
        FRect* srcrect,
        float left_width,
        float right_width,
        float top_height,
        float bottom_height,
        float scale,
        FRect* dstrect
    );

    [NativeName("SDL_RenderTexture9Grid")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTexture9Grid")]
    MaybeBool<byte> RenderTexture9Grid(
        RendererHandle renderer,
        Ref<Texture> texture,
        Ref<FRect> srcrect,
        float left_width,
        float right_width,
        float top_height,
        float bottom_height,
        float scale,
        Ref<FRect> dstrect
    );

    [NativeName("SDL_RenderTextureAffine")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureAffine")]
    byte RenderTextureAffine(
        RendererHandle renderer,
        Texture* texture,
        FRect* srcrect,
        FPoint* origin,
        FPoint* right,
        FPoint* down
    );

    [NativeName("SDL_RenderTextureAffine")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureAffine")]
    MaybeBool<byte> RenderTextureAffine(
        RendererHandle renderer,
        Ref<Texture> texture,
        Ref<FRect> srcrect,
        Ref<FPoint> origin,
        Ref<FPoint> right,
        Ref<FPoint> down
    );

    [NativeName("SDL_RenderTextureRotated")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureRotated")]
    byte RenderTextureRotated(
        RendererHandle renderer,
        Texture* texture,
        FRect* srcrect,
        FRect* dstrect,
        double angle,
        FPoint* center,
        FlipMode flip
    );

    [NativeName("SDL_RenderTextureRotated")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureRotated")]
    MaybeBool<byte> RenderTextureRotated(
        RendererHandle renderer,
        Ref<Texture> texture,
        Ref<FRect> srcrect,
        Ref<FRect> dstrect,
        double angle,
        Ref<FPoint> center,
        FlipMode flip
    );

    [NativeName("SDL_RenderTextureTiled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureTiled")]
    byte RenderTextureTiled(
        RendererHandle renderer,
        Texture* texture,
        FRect* srcrect,
        float scale,
        FRect* dstrect
    );

    [NativeName("SDL_RenderTextureTiled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderTextureTiled")]
    MaybeBool<byte> RenderTextureTiled(
        RendererHandle renderer,
        Ref<Texture> texture,
        Ref<FRect> srcrect,
        float scale,
        Ref<FRect> dstrect
    );

    [NativeName("SDL_RenderViewportSet")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderViewportSet")]
    MaybeBool<byte> RenderViewportSet(RendererHandle renderer);

    [NativeName("SDL_RenderViewportSet")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RenderViewportSet")]
    byte RenderViewportSetRaw(RendererHandle renderer);

    [NativeName("SDL_ReportAssertion")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReportAssertion")]
    AssertState ReportAssertion(AssertData* data, sbyte* func, sbyte* file, int line);

    [NativeName("SDL_ReportAssertion")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ReportAssertion")]
    AssertState ReportAssertion(Ref<AssertData> data, Ref<sbyte> func, Ref<sbyte> file, int line);

    [NativeName("SDL_ResetAssertionReport")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResetAssertionReport")]
    void ResetAssertionReport();

    [NativeName("SDL_ResetHint")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResetHint")]
    byte ResetHint(sbyte* name);

    [NativeName("SDL_ResetHint")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResetHint")]
    MaybeBool<byte> ResetHint(Ref<sbyte> name);

    [NativeName("SDL_ResetHints")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResetHints")]
    void ResetHints();

    [NativeName("SDL_ResetKeyboard")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResetKeyboard")]
    void ResetKeyboard();

    [NativeName("SDL_ResetLogPriorities")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResetLogPriorities")]
    void ResetLogPriorities();

    [NativeName("SDL_RestoreWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RestoreWindow")]
    MaybeBool<byte> RestoreWindow(WindowHandle window);

    [NativeName("SDL_RestoreWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RestoreWindow")]
    byte RestoreWindowRaw(WindowHandle window);

    [NativeName("SDL_ResumeAudioDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioDevice")]
    MaybeBool<byte> ResumeAudioDevice(uint devid);

    [NativeName("SDL_ResumeAudioDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioDevice")]
    byte ResumeAudioDeviceRaw(uint devid);

    [NativeName("SDL_ResumeAudioStreamDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioStreamDevice")]
    MaybeBool<byte> ResumeAudioStreamDevice(AudioStreamHandle stream);

    [NativeName("SDL_ResumeAudioStreamDevice")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResumeAudioStreamDevice")]
    byte ResumeAudioStreamDeviceRaw(AudioStreamHandle stream);

    [NativeName("SDL_ResumeHaptic")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResumeHaptic")]
    MaybeBool<byte> ResumeHaptic(HapticHandle haptic);

    [NativeName("SDL_ResumeHaptic")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ResumeHaptic")]
    byte ResumeHapticRaw(HapticHandle haptic);

    [NativeName("SDL_round")]
    [NativeFunction("SDL3", EntryPoint = "SDL_round")]
    double Round(double x);

    [NativeName("SDL_roundf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_roundf")]
    float Roundf(float x);

    [NativeName("SDL_RumbleGamepad")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepad")]
    MaybeBool<byte> RumbleGamepad(
        GamepadHandle gamepad,
        ushort low_frequency_rumble,
        ushort high_frequency_rumble,
        uint duration_ms
    );

    [NativeName("SDL_RumbleGamepad")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepad")]
    byte RumbleGamepadRaw(
        GamepadHandle gamepad,
        ushort low_frequency_rumble,
        ushort high_frequency_rumble,
        uint duration_ms
    );

    [NativeName("SDL_RumbleGamepadTriggers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepadTriggers")]
    MaybeBool<byte> RumbleGamepadTriggers(
        GamepadHandle gamepad,
        ushort left_rumble,
        ushort right_rumble,
        uint duration_ms
    );

    [NativeName("SDL_RumbleGamepadTriggers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleGamepadTriggers")]
    byte RumbleGamepadTriggersRaw(
        GamepadHandle gamepad,
        ushort left_rumble,
        ushort right_rumble,
        uint duration_ms
    );

    [NativeName("SDL_RumbleJoystick")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystick")]
    MaybeBool<byte> RumbleJoystick(
        JoystickHandle joystick,
        ushort low_frequency_rumble,
        ushort high_frequency_rumble,
        uint duration_ms
    );

    [NativeName("SDL_RumbleJoystick")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystick")]
    byte RumbleJoystickRaw(
        JoystickHandle joystick,
        ushort low_frequency_rumble,
        ushort high_frequency_rumble,
        uint duration_ms
    );

    [NativeName("SDL_RumbleJoystickTriggers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystickTriggers")]
    MaybeBool<byte> RumbleJoystickTriggers(
        JoystickHandle joystick,
        ushort left_rumble,
        ushort right_rumble,
        uint duration_ms
    );

    [NativeName("SDL_RumbleJoystickTriggers")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RumbleJoystickTriggers")]
    byte RumbleJoystickTriggersRaw(
        JoystickHandle joystick,
        ushort left_rumble,
        ushort right_rumble,
        uint duration_ms
    );

    [NativeName("SDL_RunApp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RunApp")]
    int RunApp(int argc, sbyte** argv, MainFunc mainFunction, void* reserved);

    [NativeName("SDL_RunApp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RunApp")]
    int RunApp(int argc, Ref2D<sbyte> argv, MainFunc mainFunction, Ref reserved);

    [NativeName("SDL_RunHapticEffect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RunHapticEffect")]
    MaybeBool<byte> RunHapticEffect(HapticHandle haptic, int effect, uint iterations);

    [NativeName("SDL_RunHapticEffect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RunHapticEffect")]
    byte RunHapticEffectRaw(HapticHandle haptic, int effect, uint iterations);

    [NativeName("SDL_RunOnMainThread")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RunOnMainThread")]
    byte RunOnMainThread(MainThreadCallback callback, void* userdata, byte wait_complete);

    [NativeName("SDL_RunOnMainThread")]
    [NativeFunction("SDL3", EntryPoint = "SDL_RunOnMainThread")]
    MaybeBool<byte> RunOnMainThread(
        MainThreadCallback callback,
        Ref userdata,
        MaybeBool<byte> wait_complete
    );

    [NativeName("SDL_SaveBMP")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP")]
    byte SaveBmp(Surface* surface, sbyte* file);

    [NativeName("SDL_SaveBMP")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP")]
    MaybeBool<byte> SaveBmp(Ref<Surface> surface, Ref<sbyte> file);

    [NativeName("SDL_SaveBMP_IO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP_IO")]
    byte SaveBmpIo(Surface* surface, IoStreamHandle dst, byte closeio);

    [NativeName("SDL_SaveBMP_IO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveBMP_IO")]
    MaybeBool<byte> SaveBmpIo(Ref<Surface> surface, IoStreamHandle dst, MaybeBool<byte> closeio);

    [NativeName("SDL_SaveFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile")]
    byte SaveFile(sbyte* file, void* data, nuint datasize);

    [NativeName("SDL_SaveFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile")]
    MaybeBool<byte> SaveFile(Ref<sbyte> file, Ref data, nuint datasize);

    [NativeName("SDL_SaveFile_IO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile_IO")]
    byte SaveFileIo(IoStreamHandle src, void* data, nuint datasize, byte closeio);

    [NativeName("SDL_SaveFile_IO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SaveFile_IO")]
    MaybeBool<byte> SaveFileIo(
        IoStreamHandle src,
        Ref data,
        nuint datasize,
        MaybeBool<byte> closeio
    );

    [NativeName("SDL_scalbn")]
    [NativeFunction("SDL3", EntryPoint = "SDL_scalbn")]
    double Scalbn(double x, int n);

    [NativeName("SDL_scalbnf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_scalbnf")]
    float Scalbnf(float x, int n);

    [NativeName("SDL_ScaleSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScaleSurface")]
    Surface* ScaleSurface(Surface* surface, int width, int height, ScaleMode scaleMode);

    [NativeName("SDL_ScaleSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScaleSurface")]
    Ptr<Surface> ScaleSurface(Ref<Surface> surface, int width, int height, ScaleMode scaleMode);

    [NativeName("SDL_ScreenKeyboardShown")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScreenKeyboardShown")]
    MaybeBool<byte> ScreenKeyboardShown(WindowHandle window);

    [NativeName("SDL_ScreenKeyboardShown")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScreenKeyboardShown")]
    byte ScreenKeyboardShownRaw(WindowHandle window);

    [NativeName("SDL_ScreenSaverEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScreenSaverEnabled")]
    MaybeBool<byte> ScreenSaverEnabled();

    [NativeName("SDL_ScreenSaverEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ScreenSaverEnabled")]
    byte ScreenSaverEnabledRaw();

    [NativeName("SDL_SeekIO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SeekIO")]
    long SeekIo(IoStreamHandle context, long offset, IoWhence whence);

    [NativeName("SDL_SendGamepadEffect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SendGamepadEffect")]
    byte SendGamepadEffect(GamepadHandle gamepad, void* data, int size);

    [NativeName("SDL_SendGamepadEffect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SendGamepadEffect")]
    MaybeBool<byte> SendGamepadEffect(GamepadHandle gamepad, Ref data, int size);

    [NativeName("SDL_SendJoystickEffect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickEffect")]
    byte SendJoystickEffect(JoystickHandle joystick, void* data, int size);

    [NativeName("SDL_SendJoystickEffect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickEffect")]
    MaybeBool<byte> SendJoystickEffect(JoystickHandle joystick, Ref data, int size);

    [NativeName("SDL_SendJoystickVirtualSensorData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickVirtualSensorData")]
    byte SendJoystickVirtualSensorData(
        JoystickHandle joystick,
        SensorType type,
        ulong sensor_timestamp,
        float* data,
        int num_values
    );

    [NativeName("SDL_SendJoystickVirtualSensorData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SendJoystickVirtualSensorData")]
    MaybeBool<byte> SendJoystickVirtualSensorData(
        JoystickHandle joystick,
        SensorType type,
        ulong sensor_timestamp,
        Ref<float> data,
        int num_values
    );

    [NativeName("SDL_SetAppMetadata")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadata")]
    byte SetAppMetadata(sbyte* appname, sbyte* appversion, sbyte* appidentifier);

    [NativeName("SDL_SetAppMetadata")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadata")]
    MaybeBool<byte> SetAppMetadata(
        Ref<sbyte> appname,
        Ref<sbyte> appversion,
        Ref<sbyte> appidentifier
    );

    [NativeName("SDL_SetAppMetadataProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadataProperty")]
    byte SetAppMetadataProperty(sbyte* name, sbyte* value);

    [NativeName("SDL_SetAppMetadataProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAppMetadataProperty")]
    MaybeBool<byte> SetAppMetadataProperty(Ref<sbyte> name, Ref<sbyte> value);

    [NativeName("SDL_SetAssertionHandler")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAssertionHandler")]
    void SetAssertionHandler(AssertionHandler handler, void* userdata);

    [NativeName("SDL_SetAssertionHandler")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAssertionHandler")]
    void SetAssertionHandler(AssertionHandler handler, Ref userdata);

    [NativeName("SDL_SetAtomicInt")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicInt")]
    int SetAtomicInt(AtomicInt* a, int v);

    [NativeName("SDL_SetAtomicInt")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicInt")]
    int SetAtomicInt(Ref<AtomicInt> a, int v);

    [NativeName("SDL_SetAtomicPointer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicPointer")]
    void* SetAtomicPointer(void** a, void* v);

    [NativeName("SDL_SetAtomicPointer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicPointer")]
    Ptr SetAtomicPointer(Ref2D a, Ref v);

    [NativeName("SDL_SetAtomicU32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicU32")]
    uint SetAtomicU32(AtomicU32* a, uint v);

    [NativeName("SDL_SetAtomicU32")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAtomicU32")]
    uint SetAtomicU32(Ref<AtomicU32> a, uint v);

    [NativeName("SDL_SetAudioDeviceGain")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioDeviceGain")]
    MaybeBool<byte> SetAudioDeviceGain(uint devid, float gain);

    [NativeName("SDL_SetAudioDeviceGain")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioDeviceGain")]
    byte SetAudioDeviceGainRaw(uint devid, float gain);

    [NativeName("SDL_SetAudioPostmixCallback")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioPostmixCallback")]
    byte SetAudioPostmixCallback(uint devid, AudioPostmixCallback callback, void* userdata);

    [NativeName("SDL_SetAudioPostmixCallback")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioPostmixCallback")]
    MaybeBool<byte> SetAudioPostmixCallback(
        uint devid,
        AudioPostmixCallback callback,
        Ref userdata
    );

    [NativeName("SDL_SetAudioStreamFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFormat")]
    byte SetAudioStreamFormat(AudioStreamHandle stream, AudioSpec* src_spec, AudioSpec* dst_spec);

    [NativeName("SDL_SetAudioStreamFormat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFormat")]
    MaybeBool<byte> SetAudioStreamFormat(
        AudioStreamHandle stream,
        Ref<AudioSpec> src_spec,
        Ref<AudioSpec> dst_spec
    );

    [NativeName("SDL_SetAudioStreamFrequencyRatio")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFrequencyRatio")]
    MaybeBool<byte> SetAudioStreamFrequencyRatio(AudioStreamHandle stream, float ratio);

    [NativeName("SDL_SetAudioStreamFrequencyRatio")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamFrequencyRatio")]
    byte SetAudioStreamFrequencyRatioRaw(AudioStreamHandle stream, float ratio);

    [NativeName("SDL_SetAudioStreamGain")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGain")]
    MaybeBool<byte> SetAudioStreamGain(AudioStreamHandle stream, float gain);

    [NativeName("SDL_SetAudioStreamGain")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGain")]
    byte SetAudioStreamGainRaw(AudioStreamHandle stream, float gain);

    [NativeName("SDL_SetAudioStreamGetCallback")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGetCallback")]
    byte SetAudioStreamGetCallback(
        AudioStreamHandle stream,
        AudioStreamCallback callback,
        void* userdata
    );

    [NativeName("SDL_SetAudioStreamGetCallback")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamGetCallback")]
    MaybeBool<byte> SetAudioStreamGetCallback(
        AudioStreamHandle stream,
        AudioStreamCallback callback,
        Ref userdata
    );

    [NativeName("SDL_SetAudioStreamInputChannelMap")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamInputChannelMap")]
    byte SetAudioStreamInputChannelMap(AudioStreamHandle stream, int* chmap, int count);

    [NativeName("SDL_SetAudioStreamInputChannelMap")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamInputChannelMap")]
    MaybeBool<byte> SetAudioStreamInputChannelMap(
        AudioStreamHandle stream,
        Ref<int> chmap,
        int count
    );

    [NativeName("SDL_SetAudioStreamOutputChannelMap")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamOutputChannelMap")]
    byte SetAudioStreamOutputChannelMap(AudioStreamHandle stream, int* chmap, int count);

    [NativeName("SDL_SetAudioStreamOutputChannelMap")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamOutputChannelMap")]
    MaybeBool<byte> SetAudioStreamOutputChannelMap(
        AudioStreamHandle stream,
        Ref<int> chmap,
        int count
    );

    [NativeName("SDL_SetAudioStreamPutCallback")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamPutCallback")]
    byte SetAudioStreamPutCallback(
        AudioStreamHandle stream,
        AudioStreamCallback callback,
        void* userdata
    );

    [NativeName("SDL_SetAudioStreamPutCallback")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetAudioStreamPutCallback")]
    MaybeBool<byte> SetAudioStreamPutCallback(
        AudioStreamHandle stream,
        AudioStreamCallback callback,
        Ref userdata
    );

    [NativeName("SDL_SetBooleanProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetBooleanProperty")]
    byte SetBooleanProperty(uint props, sbyte* name, byte value);

    [NativeName("SDL_SetBooleanProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetBooleanProperty")]
    MaybeBool<byte> SetBooleanProperty(uint props, Ref<sbyte> name, MaybeBool<byte> value);

    [NativeName("SDL_SetClipboardData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardData")]
    byte SetClipboardData(
        ClipboardDataCallback callback,
        ClipboardCleanupCallback cleanup,
        void* userdata,
        sbyte** mime_types,
        nuint num_mime_types
    );

    [NativeName("SDL_SetClipboardData")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardData")]
    MaybeBool<byte> SetClipboardData(
        ClipboardDataCallback callback,
        ClipboardCleanupCallback cleanup,
        Ref userdata,
        Ref2D<sbyte> mime_types,
        nuint num_mime_types
    );

    [NativeName("SDL_SetClipboardText")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardText")]
    byte SetClipboardText(sbyte* text);

    [NativeName("SDL_SetClipboardText")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetClipboardText")]
    MaybeBool<byte> SetClipboardText(Ref<sbyte> text);

    [NativeName("SDL_SetCurrentThreadPriority")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetCurrentThreadPriority")]
    MaybeBool<byte> SetCurrentThreadPriority(ThreadPriority priority);

    [NativeName("SDL_SetCurrentThreadPriority")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetCurrentThreadPriority")]
    byte SetCurrentThreadPriorityRaw(ThreadPriority priority);

    [NativeName("SDL_SetCursor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetCursor")]
    MaybeBool<byte> SetCursor(CursorHandle cursor);

    [NativeName("SDL_SetCursor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetCursor")]
    byte SetCursorRaw(CursorHandle cursor);

    [NativeName("SDL_setenv_unsafe")]
    [NativeFunction("SDL3", EntryPoint = "SDL_setenv_unsafe")]
    int SetenvUnsafe(sbyte* name, sbyte* value, int overwrite);

    [NativeName("SDL_setenv_unsafe")]
    [NativeFunction("SDL3", EntryPoint = "SDL_setenv_unsafe")]
    int SetenvUnsafe(Ref<sbyte> name, Ref<sbyte> value, int overwrite);

    [NativeName("SDL_SetEnvironmentVariable")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetEnvironmentVariable")]
    byte SetEnvironmentVariable(EnvironmentHandle env, sbyte* name, sbyte* value, byte overwrite);

    [NativeName("SDL_SetEnvironmentVariable")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetEnvironmentVariable")]
    MaybeBool<byte> SetEnvironmentVariable(
        EnvironmentHandle env,
        Ref<sbyte> name,
        Ref<sbyte> value,
        MaybeBool<byte> overwrite
    );

    [NativeName("SDL_SetErrorV")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetErrorV")]
    byte SetErrorV(sbyte* fmt, sbyte* ap);

    [NativeName("SDL_SetErrorV")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetErrorV")]
    MaybeBool<byte> SetErrorV(Ref<sbyte> fmt, Ref<sbyte> ap);

    [NativeName("SDL_SetEventEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetEventEnabled")]
    void SetEventEnabled(uint type, byte enabled);

    [NativeName("SDL_SetEventEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetEventEnabled")]
    void SetEventEnabled(uint type, MaybeBool<byte> enabled);

    [NativeName("SDL_SetEventFilter")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetEventFilter")]
    void SetEventFilter(EventFilter filter, void* userdata);

    [NativeName("SDL_SetEventFilter")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetEventFilter")]
    void SetEventFilter(EventFilter filter, Ref userdata);

    [NativeName("SDL_SetFloatProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetFloatProperty")]
    byte SetFloatProperty(uint props, sbyte* name, float value);

    [NativeName("SDL_SetFloatProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetFloatProperty")]
    MaybeBool<byte> SetFloatProperty(uint props, Ref<sbyte> name, float value);

    [NativeName("SDL_SetGamepadEventsEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadEventsEnabled")]
    void SetGamepadEventsEnabled(byte enabled);

    [NativeName("SDL_SetGamepadEventsEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadEventsEnabled")]
    void SetGamepadEventsEnabled(MaybeBool<byte> enabled);

    [NativeName("SDL_SetGamepadLED")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadLED")]
    MaybeBool<byte> SetGamepadLed(GamepadHandle gamepad, byte red, byte green, byte blue);

    [NativeName("SDL_SetGamepadLED")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadLED")]
    byte SetGamepadLedRaw(GamepadHandle gamepad, byte red, byte green, byte blue);

    [NativeName("SDL_SetGamepadMapping")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadMapping")]
    byte SetGamepadMapping(uint instance_id, sbyte* mapping);

    [NativeName("SDL_SetGamepadMapping")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadMapping")]
    MaybeBool<byte> SetGamepadMapping(uint instance_id, Ref<sbyte> mapping);

    [NativeName("SDL_SetGamepadPlayerIndex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadPlayerIndex")]
    MaybeBool<byte> SetGamepadPlayerIndex(GamepadHandle gamepad, int player_index);

    [NativeName("SDL_SetGamepadPlayerIndex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadPlayerIndex")]
    byte SetGamepadPlayerIndexRaw(GamepadHandle gamepad, int player_index);

    [NativeName("SDL_SetGamepadSensorEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadSensorEnabled")]
    byte SetGamepadSensorEnabled(GamepadHandle gamepad, SensorType type, byte enabled);

    [NativeName("SDL_SetGamepadSensorEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGamepadSensorEnabled")]
    MaybeBool<byte> SetGamepadSensorEnabled(
        GamepadHandle gamepad,
        SensorType type,
        MaybeBool<byte> enabled
    );

    [NativeName("SDL_SetGPUAllowedFramesInFlight")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUAllowedFramesInFlight")]
    MaybeBool<byte> SetGpuAllowedFramesInFlight(
        GpuDeviceHandle device,
        uint allowed_frames_in_flight
    );

    [NativeName("SDL_SetGPUAllowedFramesInFlight")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUAllowedFramesInFlight")]
    byte SetGpuAllowedFramesInFlightRaw(GpuDeviceHandle device, uint allowed_frames_in_flight);

    [NativeName("SDL_SetGPUBlendConstants")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUBlendConstants")]
    void SetGpuBlendConstants(GpuRenderPassHandle render_pass, FColor blend_constants);

    [NativeName("SDL_SetGPUBufferName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUBufferName")]
    void SetGpuBufferName(GpuDeviceHandle device, GpuBufferHandle buffer, sbyte* text);

    [NativeName("SDL_SetGPUBufferName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUBufferName")]
    void SetGpuBufferName(GpuDeviceHandle device, GpuBufferHandle buffer, Ref<sbyte> text);

    [NativeName("SDL_SetGPUScissor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUScissor")]
    void SetGpuScissor(GpuRenderPassHandle render_pass, Rect* scissor);

    [NativeName("SDL_SetGPUScissor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUScissor")]
    void SetGpuScissor(GpuRenderPassHandle render_pass, Ref<Rect> scissor);

    [NativeName("SDL_SetGPUStencilReference")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUStencilReference")]
    void SetGpuStencilReference(GpuRenderPassHandle render_pass, byte reference);

    [NativeName("SDL_SetGPUSwapchainParameters")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUSwapchainParameters")]
    MaybeBool<byte> SetGpuSwapchainParameters(
        GpuDeviceHandle device,
        WindowHandle window,
        GpuSwapchainComposition swapchain_composition,
        GpuPresentMode present_mode
    );

    [NativeName("SDL_SetGPUSwapchainParameters")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUSwapchainParameters")]
    byte SetGpuSwapchainParametersRaw(
        GpuDeviceHandle device,
        WindowHandle window,
        GpuSwapchainComposition swapchain_composition,
        GpuPresentMode present_mode
    );

    [NativeName("SDL_SetGPUTextureName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUTextureName")]
    void SetGpuTextureName(GpuDeviceHandle device, GpuTextureHandle texture, sbyte* text);

    [NativeName("SDL_SetGPUTextureName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUTextureName")]
    void SetGpuTextureName(GpuDeviceHandle device, GpuTextureHandle texture, Ref<sbyte> text);

    [NativeName("SDL_SetGPUViewport")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUViewport")]
    void SetGpuViewport(GpuRenderPassHandle render_pass, GpuViewport* viewport);

    [NativeName("SDL_SetGPUViewport")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetGPUViewport")]
    void SetGpuViewport(GpuRenderPassHandle render_pass, Ref<GpuViewport> viewport);

    [NativeName("SDL_SetHapticAutocenter")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticAutocenter")]
    MaybeBool<byte> SetHapticAutocenter(HapticHandle haptic, int autocenter);

    [NativeName("SDL_SetHapticAutocenter")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticAutocenter")]
    byte SetHapticAutocenterRaw(HapticHandle haptic, int autocenter);

    [NativeName("SDL_SetHapticGain")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticGain")]
    MaybeBool<byte> SetHapticGain(HapticHandle haptic, int gain);

    [NativeName("SDL_SetHapticGain")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHapticGain")]
    byte SetHapticGainRaw(HapticHandle haptic, int gain);

    [NativeName("SDL_SetHint")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHint")]
    byte SetHint(sbyte* name, sbyte* value);

    [NativeName("SDL_SetHint")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHint")]
    MaybeBool<byte> SetHint(Ref<sbyte> name, Ref<sbyte> value);

    [NativeName("SDL_SetHintWithPriority")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHintWithPriority")]
    byte SetHintWithPriority(sbyte* name, sbyte* value, HintPriority priority);

    [NativeName("SDL_SetHintWithPriority")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetHintWithPriority")]
    MaybeBool<byte> SetHintWithPriority(Ref<sbyte> name, Ref<sbyte> value, HintPriority priority);

    [NativeName("SDL_SetInitialized")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetInitialized")]
    void SetInitialized(InitState* state, byte initialized);

    [NativeName("SDL_SetInitialized")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetInitialized")]
    void SetInitialized(Ref<InitState> state, MaybeBool<byte> initialized);

    [NativeName("SDL_SetJoystickEventsEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickEventsEnabled")]
    void SetJoystickEventsEnabled(byte enabled);

    [NativeName("SDL_SetJoystickEventsEnabled")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickEventsEnabled")]
    void SetJoystickEventsEnabled(MaybeBool<byte> enabled);

    [NativeName("SDL_SetJoystickLED")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickLED")]
    MaybeBool<byte> SetJoystickLed(JoystickHandle joystick, byte red, byte green, byte blue);

    [NativeName("SDL_SetJoystickLED")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickLED")]
    byte SetJoystickLedRaw(JoystickHandle joystick, byte red, byte green, byte blue);

    [NativeName("SDL_SetJoystickPlayerIndex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickPlayerIndex")]
    MaybeBool<byte> SetJoystickPlayerIndex(JoystickHandle joystick, int player_index);

    [NativeName("SDL_SetJoystickPlayerIndex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickPlayerIndex")]
    byte SetJoystickPlayerIndexRaw(JoystickHandle joystick, int player_index);

    [NativeName("SDL_SetJoystickVirtualAxis")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualAxis")]
    MaybeBool<byte> SetJoystickVirtualAxis(JoystickHandle joystick, int axis, short value);

    [NativeName("SDL_SetJoystickVirtualAxis")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualAxis")]
    byte SetJoystickVirtualAxisRaw(JoystickHandle joystick, int axis, short value);

    [NativeName("SDL_SetJoystickVirtualBall")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualBall")]
    MaybeBool<byte> SetJoystickVirtualBall(
        JoystickHandle joystick,
        int ball,
        short xrel,
        short yrel
    );

    [NativeName("SDL_SetJoystickVirtualBall")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualBall")]
    byte SetJoystickVirtualBallRaw(JoystickHandle joystick, int ball, short xrel, short yrel);

    [NativeName("SDL_SetJoystickVirtualButton")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualButton")]
    byte SetJoystickVirtualButton(JoystickHandle joystick, int button, byte down);

    [NativeName("SDL_SetJoystickVirtualButton")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualButton")]
    MaybeBool<byte> SetJoystickVirtualButton(
        JoystickHandle joystick,
        int button,
        MaybeBool<byte> down
    );

    [NativeName("SDL_SetJoystickVirtualHat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualHat")]
    MaybeBool<byte> SetJoystickVirtualHat(JoystickHandle joystick, int hat, byte value);

    [NativeName("SDL_SetJoystickVirtualHat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualHat")]
    byte SetJoystickVirtualHatRaw(JoystickHandle joystick, int hat, byte value);

    [NativeName("SDL_SetJoystickVirtualTouchpad")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualTouchpad")]
    byte SetJoystickVirtualTouchpad(
        JoystickHandle joystick,
        int touchpad,
        int finger,
        byte down,
        float x,
        float y,
        float pressure
    );

    [NativeName("SDL_SetJoystickVirtualTouchpad")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetJoystickVirtualTouchpad")]
    MaybeBool<byte> SetJoystickVirtualTouchpad(
        JoystickHandle joystick,
        int touchpad,
        int finger,
        MaybeBool<byte> down,
        float x,
        float y,
        float pressure
    );

    [NativeName("SDL_SetLogOutputFunction")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetLogOutputFunction")]
    void SetLogOutputFunction(LogOutputFunction callback, void* userdata);

    [NativeName("SDL_SetLogOutputFunction")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetLogOutputFunction")]
    void SetLogOutputFunction(LogOutputFunction callback, Ref userdata);

    [NativeName("SDL_SetLogPriorities")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriorities")]
    void SetLogPriorities(LogPriority priority);

    [NativeName("SDL_SetLogPriority")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriority")]
    void SetLogPriority(int category, LogPriority priority);

    [NativeName("SDL_SetLogPriorityPrefix")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriorityPrefix")]
    byte SetLogPriorityPrefix(LogPriority priority, sbyte* prefix);

    [NativeName("SDL_SetLogPriorityPrefix")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetLogPriorityPrefix")]
    MaybeBool<byte> SetLogPriorityPrefix(LogPriority priority, Ref<sbyte> prefix);

    [NativeName("SDL_SetMainReady")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetMainReady")]
    void SetMainReady();

    [NativeName("SDL_SetMemoryFunctions")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetMemoryFunctions")]
    MaybeBool<byte> SetMemoryFunctions(
        MallocFunc malloc_func,
        CallocFunc calloc_func,
        ReallocFunc realloc_func,
        FreeFunc free_func
    );

    [NativeName("SDL_SetMemoryFunctions")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetMemoryFunctions")]
    byte SetMemoryFunctionsRaw(
        MallocFunc malloc_func,
        CallocFunc calloc_func,
        ReallocFunc realloc_func,
        FreeFunc free_func
    );

    [NativeName("SDL_SetModState")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetModState")]
    void SetModState(ushort modstate);

    [NativeName("SDL_SetNumberProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetNumberProperty")]
    byte SetNumberProperty(uint props, sbyte* name, long value);

    [NativeName("SDL_SetNumberProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetNumberProperty")]
    MaybeBool<byte> SetNumberProperty(uint props, Ref<sbyte> name, long value);

    [NativeName("SDL_SetPaletteColors")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPaletteColors")]
    byte SetPaletteColors(Palette* palette, Color* colors, int firstcolor, int ncolors);

    [NativeName("SDL_SetPaletteColors")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPaletteColors")]
    MaybeBool<byte> SetPaletteColors(
        Ref<Palette> palette,
        Ref<Color> colors,
        int firstcolor,
        int ncolors
    );

    [NativeName("SDL_SetPointerProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerProperty")]
    byte SetPointerProperty(uint props, sbyte* name, void* value);

    [NativeName("SDL_SetPointerProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerProperty")]
    MaybeBool<byte> SetPointerProperty(uint props, Ref<sbyte> name, Ref value);

    [NativeName("SDL_SetPointerPropertyWithCleanup")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerPropertyWithCleanup")]
    byte SetPointerPropertyWithCleanup(
        uint props,
        sbyte* name,
        void* value,
        CleanupPropertyCallback cleanup,
        void* userdata
    );

    [NativeName("SDL_SetPointerPropertyWithCleanup")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPointerPropertyWithCleanup")]
    MaybeBool<byte> SetPointerPropertyWithCleanup(
        uint props,
        Ref<sbyte> name,
        Ref value,
        CleanupPropertyCallback cleanup,
        Ref userdata
    );

    [NativeName("SDL_SetPrimarySelectionText")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPrimarySelectionText")]
    byte SetPrimarySelectionText(sbyte* text);

    [NativeName("SDL_SetPrimarySelectionText")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetPrimarySelectionText")]
    MaybeBool<byte> SetPrimarySelectionText(Ref<sbyte> text);

    [NativeName("SDL_SetRenderClipRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderClipRect")]
    byte SetRenderClipRect(RendererHandle renderer, Rect* rect);

    [NativeName("SDL_SetRenderClipRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderClipRect")]
    MaybeBool<byte> SetRenderClipRect(RendererHandle renderer, Ref<Rect> rect);

    [NativeName("SDL_SetRenderColorScale")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderColorScale")]
    MaybeBool<byte> SetRenderColorScale(RendererHandle renderer, float scale);

    [NativeName("SDL_SetRenderColorScale")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderColorScale")]
    byte SetRenderColorScaleRaw(RendererHandle renderer, float scale);

    [NativeName("SDL_SetRenderDrawBlendMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawBlendMode")]
    MaybeBool<byte> SetRenderDrawBlendMode(RendererHandle renderer, BlendMode blendMode);

    [NativeName("SDL_SetRenderDrawBlendMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawBlendMode")]
    byte SetRenderDrawBlendModeRaw(RendererHandle renderer, BlendMode blendMode);

    [NativeName("SDL_SetRenderDrawColor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColor")]
    MaybeBool<byte> SetRenderDrawColor(RendererHandle renderer, byte r, byte g, byte b, byte a);

    [NativeName("SDL_SetRenderDrawColorFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColorFloat")]
    MaybeBool<byte> SetRenderDrawColorFloat(
        RendererHandle renderer,
        float r,
        float g,
        float b,
        float a
    );

    [NativeName("SDL_SetRenderDrawColorFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColorFloat")]
    byte SetRenderDrawColorFloatRaw(RendererHandle renderer, float r, float g, float b, float a);

    [NativeName("SDL_SetRenderDrawColor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderDrawColor")]
    byte SetRenderDrawColorRaw(RendererHandle renderer, byte r, byte g, byte b, byte a);

    [NativeName("SDL_SetRenderLogicalPresentation")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderLogicalPresentation")]
    MaybeBool<byte> SetRenderLogicalPresentation(
        RendererHandle renderer,
        int w,
        int h,
        RendererLogicalPresentation mode
    );

    [NativeName("SDL_SetRenderLogicalPresentation")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderLogicalPresentation")]
    byte SetRenderLogicalPresentationRaw(
        RendererHandle renderer,
        int w,
        int h,
        RendererLogicalPresentation mode
    );

    [NativeName("SDL_SetRenderScale")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderScale")]
    MaybeBool<byte> SetRenderScale(RendererHandle renderer, float scaleX, float scaleY);

    [NativeName("SDL_SetRenderScale")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderScale")]
    byte SetRenderScaleRaw(RendererHandle renderer, float scaleX, float scaleY);

    [NativeName("SDL_SetRenderTarget")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderTarget")]
    byte SetRenderTarget(RendererHandle renderer, Texture* texture);

    [NativeName("SDL_SetRenderTarget")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderTarget")]
    MaybeBool<byte> SetRenderTarget(RendererHandle renderer, Ref<Texture> texture);

    [NativeName("SDL_SetRenderViewport")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderViewport")]
    byte SetRenderViewport(RendererHandle renderer, Rect* rect);

    [NativeName("SDL_SetRenderViewport")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderViewport")]
    MaybeBool<byte> SetRenderViewport(RendererHandle renderer, Ref<Rect> rect);

    [NativeName("SDL_SetRenderVSync")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderVSync")]
    MaybeBool<byte> SetRenderVSync(RendererHandle renderer, int vsync);

    [NativeName("SDL_SetRenderVSync")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetRenderVSync")]
    byte SetRenderVSyncRaw(RendererHandle renderer, int vsync);

    [NativeName("SDL_SetScancodeName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetScancodeName")]
    byte SetScancodeName(Scancode scancode, sbyte* name);

    [NativeName("SDL_SetScancodeName")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetScancodeName")]
    MaybeBool<byte> SetScancodeName(Scancode scancode, Ref<sbyte> name);

    [NativeName("SDL_SetStringProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetStringProperty")]
    byte SetStringProperty(uint props, sbyte* name, sbyte* value);

    [NativeName("SDL_SetStringProperty")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetStringProperty")]
    MaybeBool<byte> SetStringProperty(uint props, Ref<sbyte> name, Ref<sbyte> value);

    [NativeName("SDL_SetSurfaceAlphaMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceAlphaMod")]
    byte SetSurfaceAlphaMod(Surface* surface, byte alpha);

    [NativeName("SDL_SetSurfaceAlphaMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceAlphaMod")]
    MaybeBool<byte> SetSurfaceAlphaMod(Ref<Surface> surface, byte alpha);

    [NativeName("SDL_SetSurfaceBlendMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceBlendMode")]
    byte SetSurfaceBlendMode(Surface* surface, BlendMode blendMode);

    [NativeName("SDL_SetSurfaceBlendMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceBlendMode")]
    MaybeBool<byte> SetSurfaceBlendMode(Ref<Surface> surface, BlendMode blendMode);

    [NativeName("SDL_SetSurfaceClipRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceClipRect")]
    byte SetSurfaceClipRect(Surface* surface, Rect* rect);

    [NativeName("SDL_SetSurfaceClipRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceClipRect")]
    MaybeBool<byte> SetSurfaceClipRect(Ref<Surface> surface, Ref<Rect> rect);

    [NativeName("SDL_SetSurfaceColorKey")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorKey")]
    byte SetSurfaceColorKey(Surface* surface, byte enabled, uint key);

    [NativeName("SDL_SetSurfaceColorKey")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorKey")]
    MaybeBool<byte> SetSurfaceColorKey(Ref<Surface> surface, MaybeBool<byte> enabled, uint key);

    [NativeName("SDL_SetSurfaceColorMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorMod")]
    byte SetSurfaceColorMod(Surface* surface, byte r, byte g, byte b);

    [NativeName("SDL_SetSurfaceColorMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorMod")]
    MaybeBool<byte> SetSurfaceColorMod(Ref<Surface> surface, byte r, byte g, byte b);

    [NativeName("SDL_SetSurfaceColorspace")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorspace")]
    byte SetSurfaceColorspace(Surface* surface, Colorspace colorspace);

    [NativeName("SDL_SetSurfaceColorspace")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceColorspace")]
    MaybeBool<byte> SetSurfaceColorspace(Ref<Surface> surface, Colorspace colorspace);

    [NativeName("SDL_SetSurfacePalette")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfacePalette")]
    byte SetSurfacePalette(Surface* surface, Palette* palette);

    [NativeName("SDL_SetSurfacePalette")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfacePalette")]
    MaybeBool<byte> SetSurfacePalette(Ref<Surface> surface, Ref<Palette> palette);

    [NativeName("SDL_SetSurfaceRLE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceRLE")]
    byte SetSurfaceRle(Surface* surface, byte enabled);

    [NativeName("SDL_SetSurfaceRLE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetSurfaceRLE")]
    MaybeBool<byte> SetSurfaceRle(Ref<Surface> surface, MaybeBool<byte> enabled);

    [NativeName("SDL_SetTextInputArea")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextInputArea")]
    byte SetTextInputArea(WindowHandle window, Rect* rect, int cursor);

    [NativeName("SDL_SetTextInputArea")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextInputArea")]
    MaybeBool<byte> SetTextInputArea(WindowHandle window, Ref<Rect> rect, int cursor);

    [NativeName("SDL_SetTextureAlphaMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaMod")]
    byte SetTextureAlphaMod(Texture* texture, byte alpha);

    [NativeName("SDL_SetTextureAlphaMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaMod")]
    MaybeBool<byte> SetTextureAlphaMod(Ref<Texture> texture, byte alpha);

    [NativeName("SDL_SetTextureAlphaModFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaModFloat")]
    byte SetTextureAlphaModFloat(Texture* texture, float alpha);

    [NativeName("SDL_SetTextureAlphaModFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureAlphaModFloat")]
    MaybeBool<byte> SetTextureAlphaModFloat(Ref<Texture> texture, float alpha);

    [NativeName("SDL_SetTextureBlendMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureBlendMode")]
    byte SetTextureBlendMode(Texture* texture, BlendMode blendMode);

    [NativeName("SDL_SetTextureBlendMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureBlendMode")]
    MaybeBool<byte> SetTextureBlendMode(Ref<Texture> texture, BlendMode blendMode);

    [NativeName("SDL_SetTextureColorMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorMod")]
    byte SetTextureColorMod(Texture* texture, byte r, byte g, byte b);

    [NativeName("SDL_SetTextureColorMod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorMod")]
    MaybeBool<byte> SetTextureColorMod(Ref<Texture> texture, byte r, byte g, byte b);

    [NativeName("SDL_SetTextureColorModFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorModFloat")]
    byte SetTextureColorModFloat(Texture* texture, float r, float g, float b);

    [NativeName("SDL_SetTextureColorModFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureColorModFloat")]
    MaybeBool<byte> SetTextureColorModFloat(Ref<Texture> texture, float r, float g, float b);

    [NativeName("SDL_SetTextureScaleMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureScaleMode")]
    byte SetTextureScaleMode(Texture* texture, ScaleMode scaleMode);

    [NativeName("SDL_SetTextureScaleMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTextureScaleMode")]
    MaybeBool<byte> SetTextureScaleMode(Ref<Texture> texture, ScaleMode scaleMode);

    [NativeName("SDL_SetTLS")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTLS")]
    byte SetTls(AtomicInt* id, void* value, TlsDestructorCallback destructor);

    [NativeName("SDL_SetTLS")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetTLS")]
    MaybeBool<byte> SetTls(Ref<AtomicInt> id, Ref value, TlsDestructorCallback destructor);

    [NativeName("SDL_SetWindowAlwaysOnTop")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAlwaysOnTop")]
    byte SetWindowAlwaysOnTop(WindowHandle window, byte on_top);

    [NativeName("SDL_SetWindowAlwaysOnTop")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAlwaysOnTop")]
    MaybeBool<byte> SetWindowAlwaysOnTop(WindowHandle window, MaybeBool<byte> on_top);

    [NativeName("SDL_SetWindowAspectRatio")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAspectRatio")]
    MaybeBool<byte> SetWindowAspectRatio(WindowHandle window, float min_aspect, float max_aspect);

    [NativeName("SDL_SetWindowAspectRatio")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowAspectRatio")]
    byte SetWindowAspectRatioRaw(WindowHandle window, float min_aspect, float max_aspect);

    [NativeName("SDL_SetWindowBordered")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowBordered")]
    byte SetWindowBordered(WindowHandle window, byte bordered);

    [NativeName("SDL_SetWindowBordered")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowBordered")]
    MaybeBool<byte> SetWindowBordered(WindowHandle window, MaybeBool<byte> bordered);

    [NativeName("SDL_SetWindowFocusable")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFocusable")]
    byte SetWindowFocusable(WindowHandle window, byte focusable);

    [NativeName("SDL_SetWindowFocusable")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFocusable")]
    MaybeBool<byte> SetWindowFocusable(WindowHandle window, MaybeBool<byte> focusable);

    [NativeName("SDL_SetWindowFullscreen")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreen")]
    byte SetWindowFullscreen(WindowHandle window, byte fullscreen);

    [NativeName("SDL_SetWindowFullscreen")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreen")]
    MaybeBool<byte> SetWindowFullscreen(WindowHandle window, MaybeBool<byte> fullscreen);

    [NativeName("SDL_SetWindowFullscreenMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreenMode")]
    byte SetWindowFullscreenMode(WindowHandle window, DisplayMode* mode);

    [NativeName("SDL_SetWindowFullscreenMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowFullscreenMode")]
    MaybeBool<byte> SetWindowFullscreenMode(WindowHandle window, Ref<DisplayMode> mode);

    [NativeName("SDL_SetWindowHitTest")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowHitTest")]
    byte SetWindowHitTest(WindowHandle window, HitTest callback, void* callback_data);

    [NativeName("SDL_SetWindowHitTest")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowHitTest")]
    MaybeBool<byte> SetWindowHitTest(WindowHandle window, HitTest callback, Ref callback_data);

    [NativeName("SDL_SetWindowIcon")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowIcon")]
    byte SetWindowIcon(WindowHandle window, Surface* icon);

    [NativeName("SDL_SetWindowIcon")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowIcon")]
    MaybeBool<byte> SetWindowIcon(WindowHandle window, Ref<Surface> icon);

    [NativeName("SDL_SetWindowKeyboardGrab")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowKeyboardGrab")]
    byte SetWindowKeyboardGrab(WindowHandle window, byte grabbed);

    [NativeName("SDL_SetWindowKeyboardGrab")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowKeyboardGrab")]
    MaybeBool<byte> SetWindowKeyboardGrab(WindowHandle window, MaybeBool<byte> grabbed);

    [NativeName("SDL_SetWindowMaximumSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMaximumSize")]
    MaybeBool<byte> SetWindowMaximumSize(WindowHandle window, int max_w, int max_h);

    [NativeName("SDL_SetWindowMaximumSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMaximumSize")]
    byte SetWindowMaximumSizeRaw(WindowHandle window, int max_w, int max_h);

    [NativeName("SDL_SetWindowMinimumSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMinimumSize")]
    MaybeBool<byte> SetWindowMinimumSize(WindowHandle window, int min_w, int min_h);

    [NativeName("SDL_SetWindowMinimumSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMinimumSize")]
    byte SetWindowMinimumSizeRaw(WindowHandle window, int min_w, int min_h);

    [NativeName("SDL_SetWindowModal")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowModal")]
    byte SetWindowModal(WindowHandle window, byte modal);

    [NativeName("SDL_SetWindowModal")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowModal")]
    MaybeBool<byte> SetWindowModal(WindowHandle window, MaybeBool<byte> modal);

    [NativeName("SDL_SetWindowMouseGrab")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseGrab")]
    byte SetWindowMouseGrab(WindowHandle window, byte grabbed);

    [NativeName("SDL_SetWindowMouseGrab")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseGrab")]
    MaybeBool<byte> SetWindowMouseGrab(WindowHandle window, MaybeBool<byte> grabbed);

    [NativeName("SDL_SetWindowMouseRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseRect")]
    byte SetWindowMouseRect(WindowHandle window, Rect* rect);

    [NativeName("SDL_SetWindowMouseRect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowMouseRect")]
    MaybeBool<byte> SetWindowMouseRect(WindowHandle window, Ref<Rect> rect);

    [NativeName("SDL_SetWindowOpacity")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowOpacity")]
    MaybeBool<byte> SetWindowOpacity(WindowHandle window, float opacity);

    [NativeName("SDL_SetWindowOpacity")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowOpacity")]
    byte SetWindowOpacityRaw(WindowHandle window, float opacity);

    [NativeName("SDL_SetWindowParent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowParent")]
    MaybeBool<byte> SetWindowParent(WindowHandle window, WindowHandle parent);

    [NativeName("SDL_SetWindowParent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowParent")]
    byte SetWindowParentRaw(WindowHandle window, WindowHandle parent);

    [NativeName("SDL_SetWindowPosition")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowPosition")]
    MaybeBool<byte> SetWindowPosition(WindowHandle window, int x, int y);

    [NativeName("SDL_SetWindowPosition")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowPosition")]
    byte SetWindowPositionRaw(WindowHandle window, int x, int y);

    [NativeName("SDL_SetWindowRelativeMouseMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowRelativeMouseMode")]
    byte SetWindowRelativeMouseMode(WindowHandle window, byte enabled);

    [NativeName("SDL_SetWindowRelativeMouseMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowRelativeMouseMode")]
    MaybeBool<byte> SetWindowRelativeMouseMode(WindowHandle window, MaybeBool<byte> enabled);

    [NativeName("SDL_SetWindowResizable")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowResizable")]
    byte SetWindowResizable(WindowHandle window, byte resizable);

    [NativeName("SDL_SetWindowResizable")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowResizable")]
    MaybeBool<byte> SetWindowResizable(WindowHandle window, MaybeBool<byte> resizable);

    [NativeName("SDL_SetWindowShape")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowShape")]
    byte SetWindowShape(WindowHandle window, Surface* shape);

    [NativeName("SDL_SetWindowShape")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowShape")]
    MaybeBool<byte> SetWindowShape(WindowHandle window, Ref<Surface> shape);

    [NativeName("SDL_SetWindowSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSize")]
    MaybeBool<byte> SetWindowSize(WindowHandle window, int w, int h);

    [NativeName("SDL_SetWindowSize")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSize")]
    byte SetWindowSizeRaw(WindowHandle window, int w, int h);

    [NativeName("SDL_SetWindowSurfaceVSync")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSurfaceVSync")]
    MaybeBool<byte> SetWindowSurfaceVSync(WindowHandle window, int vsync);

    [NativeName("SDL_SetWindowSurfaceVSync")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowSurfaceVSync")]
    byte SetWindowSurfaceVSyncRaw(WindowHandle window, int vsync);

    [NativeName("SDL_SetWindowTitle")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowTitle")]
    byte SetWindowTitle(WindowHandle window, sbyte* title);

    [NativeName("SDL_SetWindowTitle")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SetWindowTitle")]
    MaybeBool<byte> SetWindowTitle(WindowHandle window, Ref<sbyte> title);

    [NativeName("SDL_ShouldInit")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShouldInit")]
    byte ShouldInit(InitState* state);

    [NativeName("SDL_ShouldInit")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShouldInit")]
    MaybeBool<byte> ShouldInit(Ref<InitState> state);

    [NativeName("SDL_ShouldQuit")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShouldQuit")]
    byte ShouldQuit(InitState* state);

    [NativeName("SDL_ShouldQuit")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShouldQuit")]
    MaybeBool<byte> ShouldQuit(Ref<InitState> state);

    [NativeName("SDL_ShowCursor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowCursor")]
    MaybeBool<byte> ShowCursor();

    [NativeName("SDL_ShowCursor")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowCursor")]
    byte ShowCursorRaw();

    [NativeName("SDL_ShowFileDialogWithProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowFileDialogWithProperties")]
    void ShowFileDialogWithProperties(
        FileDialogType type,
        DialogFileCallback callback,
        void* userdata,
        uint props
    );

    [NativeName("SDL_ShowFileDialogWithProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowFileDialogWithProperties")]
    void ShowFileDialogWithProperties(
        FileDialogType type,
        DialogFileCallback callback,
        Ref userdata,
        uint props
    );

    [NativeName("SDL_ShowMessageBox")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowMessageBox")]
    byte ShowMessageBox(MessageBoxData* messageboxdata, int* buttonid);

    [NativeName("SDL_ShowMessageBox")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowMessageBox")]
    MaybeBool<byte> ShowMessageBox(Ref<MessageBoxData> messageboxdata, Ref<int> buttonid);

    [NativeName("SDL_ShowOpenFileDialog")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFileDialog")]
    void ShowOpenFileDialog(
        DialogFileCallback callback,
        void* userdata,
        WindowHandle window,
        DialogFileFilter* filters,
        int nfilters,
        sbyte* default_location,
        byte allow_many
    );

    [NativeName("SDL_ShowOpenFileDialog")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFileDialog")]
    void ShowOpenFileDialog(
        DialogFileCallback callback,
        Ref userdata,
        WindowHandle window,
        Ref<DialogFileFilter> filters,
        int nfilters,
        Ref<sbyte> default_location,
        MaybeBool<byte> allow_many
    );

    [NativeName("SDL_ShowOpenFolderDialog")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFolderDialog")]
    void ShowOpenFolderDialog(
        DialogFileCallback callback,
        void* userdata,
        WindowHandle window,
        sbyte* default_location,
        byte allow_many
    );

    [NativeName("SDL_ShowOpenFolderDialog")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowOpenFolderDialog")]
    void ShowOpenFolderDialog(
        DialogFileCallback callback,
        Ref userdata,
        WindowHandle window,
        Ref<sbyte> default_location,
        MaybeBool<byte> allow_many
    );

    [NativeName("SDL_ShowSaveFileDialog")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowSaveFileDialog")]
    void ShowSaveFileDialog(
        DialogFileCallback callback,
        void* userdata,
        WindowHandle window,
        DialogFileFilter* filters,
        int nfilters,
        sbyte* default_location
    );

    [NativeName("SDL_ShowSaveFileDialog")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowSaveFileDialog")]
    void ShowSaveFileDialog(
        DialogFileCallback callback,
        Ref userdata,
        WindowHandle window,
        Ref<DialogFileFilter> filters,
        int nfilters,
        Ref<sbyte> default_location
    );

    [NativeName("SDL_ShowSimpleMessageBox")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowSimpleMessageBox")]
    byte ShowSimpleMessageBox(uint flags, sbyte* title, sbyte* message, WindowHandle window);

    [NativeName("SDL_ShowSimpleMessageBox")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowSimpleMessageBox")]
    MaybeBool<byte> ShowSimpleMessageBox(
        uint flags,
        Ref<sbyte> title,
        Ref<sbyte> message,
        WindowHandle window
    );

    [NativeName("SDL_ShowWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindow")]
    MaybeBool<byte> ShowWindow(WindowHandle window);

    [NativeName("SDL_ShowWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindow")]
    byte ShowWindowRaw(WindowHandle window);

    [NativeName("SDL_ShowWindowSystemMenu")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindowSystemMenu")]
    MaybeBool<byte> ShowWindowSystemMenu(WindowHandle window, int x, int y);

    [NativeName("SDL_ShowWindowSystemMenu")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ShowWindowSystemMenu")]
    byte ShowWindowSystemMenuRaw(WindowHandle window, int x, int y);

    [NativeName("SDL_SignalCondition")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SignalCondition")]
    void SignalCondition(ConditionHandle cond);

    [NativeName("SDL_SignalSemaphore")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SignalSemaphore")]
    void SignalSemaphore(SemaphoreHandle sem);

    [NativeName("SDL_sin")]
    [NativeFunction("SDL3", EntryPoint = "SDL_sin")]
    double Sin(double x);

    [NativeName("SDL_sinf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_sinf")]
    float Sinf(float x);

    [NativeName("SDL_sqrt")]
    [NativeFunction("SDL3", EntryPoint = "SDL_sqrt")]
    double Sqrt(double x);

    [NativeName("SDL_sqrtf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_sqrtf")]
    float Sqrtf(float x);

    [NativeName("SDL_srand")]
    [NativeFunction("SDL3", EntryPoint = "SDL_srand")]
    void Srand(ulong seed);

    [NativeName("SDL_StartTextInput")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInput")]
    MaybeBool<byte> StartTextInput(WindowHandle window);

    [NativeName("SDL_StartTextInput")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInput")]
    byte StartTextInputRaw(WindowHandle window);

    [NativeName("SDL_StartTextInputWithProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInputWithProperties")]
    MaybeBool<byte> StartTextInputWithProperties(WindowHandle window, uint props);

    [NativeName("SDL_StartTextInputWithProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StartTextInputWithProperties")]
    byte StartTextInputWithPropertiesRaw(WindowHandle window, uint props);

    [NativeName("SDL_StepBackUTF8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StepBackUTF8")]
    uint StepBackUtf8(sbyte* start, sbyte** pstr);

    [NativeName("SDL_StepBackUTF8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StepBackUTF8")]
    uint StepBackUtf8(Ref<sbyte> start, Ref2D<sbyte> pstr);

    [NativeName("SDL_StepUTF8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StepUTF8")]
    uint StepUtf8(sbyte** pstr, nuint* pslen);

    [NativeName("SDL_StepUTF8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StepUTF8")]
    uint StepUtf8(Ref2D<sbyte> pstr, Ref<nuint> pslen);

    [NativeName("SDL_StopHapticEffect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffect")]
    MaybeBool<byte> StopHapticEffect(HapticHandle haptic, int effect);

    [NativeName("SDL_StopHapticEffect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffect")]
    byte StopHapticEffectRaw(HapticHandle haptic, int effect);

    [NativeName("SDL_StopHapticEffects")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffects")]
    MaybeBool<byte> StopHapticEffects(HapticHandle haptic);

    [NativeName("SDL_StopHapticEffects")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticEffects")]
    byte StopHapticEffectsRaw(HapticHandle haptic);

    [NativeName("SDL_StopHapticRumble")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticRumble")]
    MaybeBool<byte> StopHapticRumble(HapticHandle haptic);

    [NativeName("SDL_StopHapticRumble")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopHapticRumble")]
    byte StopHapticRumbleRaw(HapticHandle haptic);

    [NativeName("SDL_StopTextInput")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopTextInput")]
    MaybeBool<byte> StopTextInput(WindowHandle window);

    [NativeName("SDL_StopTextInput")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StopTextInput")]
    byte StopTextInputRaw(WindowHandle window);

    [NativeName("SDL_StorageReady")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StorageReady")]
    MaybeBool<byte> StorageReady(StorageHandle storage);

    [NativeName("SDL_StorageReady")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StorageReady")]
    byte StorageReadyRaw(StorageHandle storage);

    [NativeName("SDL_strcasecmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strcasecmp")]
    int Strcasecmp(sbyte* str1, sbyte* str2);

    [NativeName("SDL_strcasecmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strcasecmp")]
    int Strcasecmp(Ref<sbyte> str1, Ref<sbyte> str2);

    [NativeName("SDL_strcasestr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strcasestr")]
    sbyte* Strcasestr(sbyte* haystack, sbyte* needle);

    [NativeName("SDL_strcasestr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strcasestr")]
    Ptr<sbyte> Strcasestr(Ref<sbyte> haystack, Ref<sbyte> needle);

    [NativeName("SDL_strchr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strchr")]
    sbyte* Strchr(sbyte* str, int c);

    [NativeName("SDL_strchr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strchr")]
    Ptr<sbyte> Strchr(Ref<sbyte> str, int c);

    [NativeName("SDL_strcmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strcmp")]
    int Strcmp(sbyte* str1, sbyte* str2);

    [NativeName("SDL_strcmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strcmp")]
    int Strcmp(Ref<sbyte> str1, Ref<sbyte> str2);

    [NativeName("SDL_strdup")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strdup")]
    sbyte* Strdup(sbyte* str);

    [NativeName("SDL_strdup")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strdup")]
    Ptr<sbyte> Strdup(Ref<sbyte> str);

    [NativeName("SDL_StretchSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StretchSurface")]
    byte StretchSurface(
        Surface* src,
        Rect* srcrect,
        Surface* dst,
        Rect* dstrect,
        ScaleMode scaleMode
    );

    [NativeName("SDL_StretchSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StretchSurface")]
    MaybeBool<byte> StretchSurface(
        Ref<Surface> src,
        Ref<Rect> srcrect,
        Ref<Surface> dst,
        Ref<Rect> dstrect,
        ScaleMode scaleMode
    );

    [NativeName("SDL_StringToGUID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StringToGUID")]
    Guid StringToGuid(sbyte* pchGUID);

    [NativeName("SDL_StringToGUID")]
    [NativeFunction("SDL3", EntryPoint = "SDL_StringToGUID")]
    Guid StringToGuid(Ref<sbyte> pchGUID);

    [NativeName("SDL_strlcat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlcat")]
    nuint Strlcat(sbyte* dst, sbyte* src, nuint maxlen);

    [NativeName("SDL_strlcat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlcat")]
    nuint Strlcat(Ref<sbyte> dst, Ref<sbyte> src, nuint maxlen);

    [NativeName("SDL_strlcpy")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlcpy")]
    nuint Strlcpy(sbyte* dst, sbyte* src, nuint maxlen);

    [NativeName("SDL_strlcpy")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlcpy")]
    nuint Strlcpy(Ref<sbyte> dst, Ref<sbyte> src, nuint maxlen);

    [NativeName("SDL_strlen")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlen")]
    nuint Strlen(sbyte* str);

    [NativeName("SDL_strlen")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlen")]
    nuint Strlen(Ref<sbyte> str);

    [NativeName("SDL_strlwr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlwr")]
    sbyte* Strlwr(sbyte* str);

    [NativeName("SDL_strlwr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strlwr")]
    Ptr<sbyte> Strlwr(Ref<sbyte> str);

    [NativeName("SDL_strncasecmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strncasecmp")]
    int Strncasecmp(sbyte* str1, sbyte* str2, nuint maxlen);

    [NativeName("SDL_strncasecmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strncasecmp")]
    int Strncasecmp(Ref<sbyte> str1, Ref<sbyte> str2, nuint maxlen);

    [NativeName("SDL_strncmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strncmp")]
    int Strncmp(sbyte* str1, sbyte* str2, nuint maxlen);

    [NativeName("SDL_strncmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strncmp")]
    int Strncmp(Ref<sbyte> str1, Ref<sbyte> str2, nuint maxlen);

    [NativeName("SDL_strndup")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strndup")]
    sbyte* Strndup(sbyte* str, nuint maxlen);

    [NativeName("SDL_strndup")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strndup")]
    Ptr<sbyte> Strndup(Ref<sbyte> str, nuint maxlen);

    [NativeName("SDL_strnlen")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strnlen")]
    nuint Strnlen(sbyte* str, nuint maxlen);

    [NativeName("SDL_strnlen")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strnlen")]
    nuint Strnlen(Ref<sbyte> str, nuint maxlen);

    [NativeName("SDL_strnstr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strnstr")]
    sbyte* Strnstr(sbyte* haystack, sbyte* needle, nuint maxlen);

    [NativeName("SDL_strnstr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strnstr")]
    Ptr<sbyte> Strnstr(Ref<sbyte> haystack, Ref<sbyte> needle, nuint maxlen);

    [NativeName("SDL_strpbrk")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strpbrk")]
    sbyte* Strpbrk(sbyte* str, sbyte* breakset);

    [NativeName("SDL_strpbrk")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strpbrk")]
    Ptr<sbyte> Strpbrk(Ref<sbyte> str, Ref<sbyte> breakset);

    [NativeName("SDL_strrchr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strrchr")]
    sbyte* Strrchr(sbyte* str, int c);

    [NativeName("SDL_strrchr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strrchr")]
    Ptr<sbyte> Strrchr(Ref<sbyte> str, int c);

    [NativeName("SDL_strrev")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strrev")]
    sbyte* Strrev(sbyte* str);

    [NativeName("SDL_strrev")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strrev")]
    Ptr<sbyte> Strrev(Ref<sbyte> str);

    [NativeName("SDL_strstr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strstr")]
    sbyte* Strstr(sbyte* haystack, sbyte* needle);

    [NativeName("SDL_strstr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strstr")]
    Ptr<sbyte> Strstr(Ref<sbyte> haystack, Ref<sbyte> needle);

    [NativeName("SDL_strtod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtod")]
    double Strtod(sbyte* str, sbyte** endp);

    [NativeName("SDL_strtod")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtod")]
    double Strtod(Ref<sbyte> str, Ref2D<sbyte> endp);

    [NativeName("SDL_strtok_r")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtok_r")]
    sbyte* StrtokR(sbyte* str, sbyte* delim, sbyte** saveptr);

    [NativeName("SDL_strtok_r")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtok_r")]
    Ptr<sbyte> StrtokR(Ref<sbyte> str, Ref<sbyte> delim, Ref2D<sbyte> saveptr);

    [NativeName("SDL_strtol")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtol")]
    int Strtol(sbyte* str, sbyte** endp, int @base);

    [NativeName("SDL_strtol")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtol")]
    int Strtol(Ref<sbyte> str, Ref2D<sbyte> endp, int @base);

    [NativeName("SDL_strtoll")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtoll")]
    long Strtoll(sbyte* str, sbyte** endp, int @base);

    [NativeName("SDL_strtoll")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtoll")]
    long Strtoll(Ref<sbyte> str, Ref2D<sbyte> endp, int @base);

    [NativeName("SDL_strtoul")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtoul")]
    uint Strtoul(sbyte* str, sbyte** endp, int @base);

    [NativeName("SDL_strtoul")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtoul")]
    uint Strtoul(Ref<sbyte> str, Ref2D<sbyte> endp, int @base);

    [NativeName("SDL_strtoull")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtoull")]
    ulong Strtoull(sbyte* str, sbyte** endp, int @base);

    [NativeName("SDL_strtoull")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strtoull")]
    ulong Strtoull(Ref<sbyte> str, Ref2D<sbyte> endp, int @base);

    [NativeName("SDL_strupr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strupr")]
    sbyte* Strupr(sbyte* str);

    [NativeName("SDL_strupr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_strupr")]
    Ptr<sbyte> Strupr(Ref<sbyte> str);

    [NativeName("SDL_SubmitGPUCommandBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SubmitGPUCommandBuffer")]
    MaybeBool<byte> SubmitGpuCommandBuffer(GpuCommandBufferHandle command_buffer);

    [NativeName("SDL_SubmitGPUCommandBufferAndAcquireFence")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SubmitGPUCommandBufferAndAcquireFence")]
    GpuFenceHandle SubmitGpuCommandBufferAndAcquireFence(GpuCommandBufferHandle command_buffer);

    [NativeName("SDL_SubmitGPUCommandBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SubmitGPUCommandBuffer")]
    byte SubmitGpuCommandBufferRaw(GpuCommandBufferHandle command_buffer);

    [NativeName("SDL_SurfaceHasAlternateImages")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasAlternateImages")]
    byte SurfaceHasAlternateImages(Surface* surface);

    [NativeName("SDL_SurfaceHasAlternateImages")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasAlternateImages")]
    MaybeBool<byte> SurfaceHasAlternateImages(Ref<Surface> surface);

    [NativeName("SDL_SurfaceHasColorKey")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasColorKey")]
    byte SurfaceHasColorKey(Surface* surface);

    [NativeName("SDL_SurfaceHasColorKey")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasColorKey")]
    MaybeBool<byte> SurfaceHasColorKey(Ref<Surface> surface);

    [NativeName("SDL_SurfaceHasRLE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasRLE")]
    byte SurfaceHasRle(Surface* surface);

    [NativeName("SDL_SurfaceHasRLE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SurfaceHasRLE")]
    MaybeBool<byte> SurfaceHasRle(Ref<Surface> surface);

    [NativeName("SDL_SyncWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SyncWindow")]
    MaybeBool<byte> SyncWindow(WindowHandle window);

    [NativeName("SDL_SyncWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_SyncWindow")]
    byte SyncWindowRaw(WindowHandle window);

    [NativeName("SDL_tan")]
    [NativeFunction("SDL3", EntryPoint = "SDL_tan")]
    double Tan(double x);

    [NativeName("SDL_tanf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_tanf")]
    float Tanf(float x);

    [NativeName("SDL_TellIO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TellIO")]
    long TellIo(IoStreamHandle context);

    [NativeName("SDL_TextInputActive")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TextInputActive")]
    MaybeBool<byte> TextInputActive(WindowHandle window);

    [NativeName("SDL_TextInputActive")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TextInputActive")]
    byte TextInputActiveRaw(WindowHandle window);

    [NativeName("SDL_TimeFromWindows")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TimeFromWindows")]
    long TimeFromWindows(uint dwLowDateTime, uint dwHighDateTime);

    [NativeName("SDL_TimeToDateTime")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TimeToDateTime")]
    byte TimeToDateTime(long ticks, DateTime* dt, byte localTime);

    [NativeName("SDL_TimeToDateTime")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TimeToDateTime")]
    MaybeBool<byte> TimeToDateTime(long ticks, Ref<DateTime> dt, MaybeBool<byte> localTime);

    [NativeName("SDL_TimeToWindows")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TimeToWindows")]
    void TimeToWindows(long ticks, uint* dwLowDateTime, uint* dwHighDateTime);

    [NativeName("SDL_TimeToWindows")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TimeToWindows")]
    void TimeToWindows(long ticks, Ref<uint> dwLowDateTime, Ref<uint> dwHighDateTime);

    [NativeName("SDL_tolower")]
    [NativeFunction("SDL3", EntryPoint = "SDL_tolower")]
    int Tolower(int x);

    [NativeName("SDL_toupper")]
    [NativeFunction("SDL3", EntryPoint = "SDL_toupper")]
    int Toupper(int x);

    [NativeName("SDL_trunc")]
    [NativeFunction("SDL3", EntryPoint = "SDL_trunc")]
    double Trunc(double x);

    [NativeName("SDL_truncf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_truncf")]
    float Truncf(float x);

    [NativeName("SDL_TryLockMutex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockMutex")]
    MaybeBool<byte> TryLockMutex(MutexHandle mutex);

    [NativeName("SDL_TryLockMutex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockMutex")]
    byte TryLockMutexRaw(MutexHandle mutex);

    [NativeName("SDL_TryLockRWLockForReading")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForReading")]
    MaybeBool<byte> TryLockRwLockForReading(RwLockHandle rwlock);

    [NativeName("SDL_TryLockRWLockForReading")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForReading")]
    byte TryLockRwLockForReadingRaw(RwLockHandle rwlock);

    [NativeName("SDL_TryLockRWLockForWriting")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForWriting")]
    MaybeBool<byte> TryLockRwLockForWriting(RwLockHandle rwlock);

    [NativeName("SDL_TryLockRWLockForWriting")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockRWLockForWriting")]
    byte TryLockRwLockForWritingRaw(RwLockHandle rwlock);

    [NativeName("SDL_TryLockSpinlock")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockSpinlock")]
    byte TryLockSpinlock(int* @lock);

    [NativeName("SDL_TryLockSpinlock")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryLockSpinlock")]
    MaybeBool<byte> TryLockSpinlock(Ref<int> @lock);

    [NativeName("SDL_TryWaitSemaphore")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryWaitSemaphore")]
    MaybeBool<byte> TryWaitSemaphore(SemaphoreHandle sem);

    [NativeName("SDL_TryWaitSemaphore")]
    [NativeFunction("SDL3", EntryPoint = "SDL_TryWaitSemaphore")]
    byte TryWaitSemaphoreRaw(SemaphoreHandle sem);

    [NativeName("SDL_UCS4ToUTF8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UCS4ToUTF8")]
    sbyte* Ucs4ToUtf8(uint codepoint, sbyte* dst);

    [NativeName("SDL_UCS4ToUTF8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UCS4ToUTF8")]
    Ptr<sbyte> Ucs4ToUtf8(uint codepoint, Ref<sbyte> dst);

    [NativeName("SDL_uitoa")]
    [NativeFunction("SDL3", EntryPoint = "SDL_uitoa")]
    sbyte* Uitoa(uint value, sbyte* str, int radix);

    [NativeName("SDL_uitoa")]
    [NativeFunction("SDL3", EntryPoint = "SDL_uitoa")]
    Ptr<sbyte> Uitoa(uint value, Ref<sbyte> str, int radix);

    [NativeName("SDL_ulltoa")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ulltoa")]
    sbyte* Ulltoa(ulong value, sbyte* str, int radix);

    [NativeName("SDL_ulltoa")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ulltoa")]
    Ptr<sbyte> Ulltoa(ulong value, Ref<sbyte> str, int radix);

    [NativeName("SDL_ultoa")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ultoa")]
    sbyte* Ultoa(uint value, sbyte* str, int radix);

    [NativeName("SDL_ultoa")]
    [NativeFunction("SDL3", EntryPoint = "SDL_ultoa")]
    Ptr<sbyte> Ultoa(uint value, Ref<sbyte> str, int radix);

    [NativeName("SDL_UnbindAudioStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStream")]
    void UnbindAudioStream(AudioStreamHandle stream);

    [NativeName("SDL_UnbindAudioStreams")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStreams")]
    void UnbindAudioStreams(AudioStreamHandle* streams, int num_streams);

    [NativeName("SDL_UnbindAudioStreams")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnbindAudioStreams")]
    void UnbindAudioStreams(Ref<AudioStreamHandle> streams, int num_streams);

    [NativeName("SDL_UnloadObject")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnloadObject")]
    void UnloadObject(SharedObjectHandle handle);

    [NativeName("SDL_UnlockAudioStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockAudioStream")]
    MaybeBool<byte> UnlockAudioStream(AudioStreamHandle stream);

    [NativeName("SDL_UnlockAudioStream")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockAudioStream")]
    byte UnlockAudioStreamRaw(AudioStreamHandle stream);

    [NativeName("SDL_UnlockJoysticks")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockJoysticks")]
    void UnlockJoysticks();

    [NativeName("SDL_UnlockMutex")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockMutex")]
    void UnlockMutex(MutexHandle mutex);

    [NativeName("SDL_UnlockProperties")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockProperties")]
    void UnlockProperties(uint props);

    [NativeName("SDL_UnlockRWLock")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockRWLock")]
    void UnlockRwLock(RwLockHandle rwlock);

    [NativeName("SDL_UnlockSpinlock")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSpinlock")]
    void UnlockSpinlock(int* @lock);

    [NativeName("SDL_UnlockSpinlock")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSpinlock")]
    void UnlockSpinlock(Ref<int> @lock);

    [NativeName("SDL_UnlockSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSurface")]
    void UnlockSurface(Surface* surface);

    [NativeName("SDL_UnlockSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockSurface")]
    void UnlockSurface(Ref<Surface> surface);

    [NativeName("SDL_UnlockTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockTexture")]
    void UnlockTexture(Texture* texture);

    [NativeName("SDL_UnlockTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnlockTexture")]
    void UnlockTexture(Ref<Texture> texture);

    [NativeName("SDL_UnmapGPUTransferBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnmapGPUTransferBuffer")]
    void UnmapGpuTransferBuffer(GpuDeviceHandle device, GpuTransferBufferHandle transfer_buffer);

    [NativeName("SDL_UnregisterApp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnregisterApp")]
    void UnregisterApp();

    [NativeName("SDL_unsetenv_unsafe")]
    [NativeFunction("SDL3", EntryPoint = "SDL_unsetenv_unsafe")]
    int UnsetenvUnsafe(sbyte* name);

    [NativeName("SDL_unsetenv_unsafe")]
    [NativeFunction("SDL3", EntryPoint = "SDL_unsetenv_unsafe")]
    int UnsetenvUnsafe(Ref<sbyte> name);

    [NativeName("SDL_UnsetEnvironmentVariable")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnsetEnvironmentVariable")]
    byte UnsetEnvironmentVariable(EnvironmentHandle env, sbyte* name);

    [NativeName("SDL_UnsetEnvironmentVariable")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UnsetEnvironmentVariable")]
    MaybeBool<byte> UnsetEnvironmentVariable(EnvironmentHandle env, Ref<sbyte> name);

    [NativeName("SDL_UpdateGamepads")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateGamepads")]
    void UpdateGamepads();

    [NativeName("SDL_UpdateHapticEffect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateHapticEffect")]
    byte UpdateHapticEffect(HapticHandle haptic, int effect, HapticEffect* data);

    [NativeName("SDL_UpdateHapticEffect")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateHapticEffect")]
    MaybeBool<byte> UpdateHapticEffect(HapticHandle haptic, int effect, Ref<HapticEffect> data);

    [NativeName("SDL_UpdateJoysticks")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateJoysticks")]
    void UpdateJoysticks();

    [NativeName("SDL_UpdateNVTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateNVTexture")]
    byte UpdateNvTexture(
        Texture* texture,
        Rect* rect,
        byte* Yplane,
        int Ypitch,
        byte* UVplane,
        int UVpitch
    );

    [NativeName("SDL_UpdateNVTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateNVTexture")]
    MaybeBool<byte> UpdateNvTexture(
        Ref<Texture> texture,
        Ref<Rect> rect,
        Ref<byte> Yplane,
        int Ypitch,
        Ref<byte> UVplane,
        int UVpitch
    );

    [NativeName("SDL_UpdateSensors")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateSensors")]
    void UpdateSensors();

    [NativeName("SDL_UpdateTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateTexture")]
    byte UpdateTexture(Texture* texture, Rect* rect, void* pixels, int pitch);

    [NativeName("SDL_UpdateTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateTexture")]
    MaybeBool<byte> UpdateTexture(Ref<Texture> texture, Ref<Rect> rect, Ref pixels, int pitch);

    [NativeName("SDL_UpdateWindowSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurface")]
    MaybeBool<byte> UpdateWindowSurface(WindowHandle window);

    [NativeName("SDL_UpdateWindowSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurface")]
    byte UpdateWindowSurfaceRaw(WindowHandle window);

    [NativeName("SDL_UpdateWindowSurfaceRects")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurfaceRects")]
    byte UpdateWindowSurfaceRects(WindowHandle window, Rect* rects, int numrects);

    [NativeName("SDL_UpdateWindowSurfaceRects")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateWindowSurfaceRects")]
    MaybeBool<byte> UpdateWindowSurfaceRects(WindowHandle window, Ref<Rect> rects, int numrects);

    [NativeName("SDL_UpdateYUVTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateYUVTexture")]
    byte UpdateYuvTexture(
        Texture* texture,
        Rect* rect,
        byte* Yplane,
        int Ypitch,
        byte* Uplane,
        int Upitch,
        byte* Vplane,
        int Vpitch
    );

    [NativeName("SDL_UpdateYUVTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UpdateYUVTexture")]
    MaybeBool<byte> UpdateYuvTexture(
        Ref<Texture> texture,
        Ref<Rect> rect,
        Ref<byte> Yplane,
        int Ypitch,
        Ref<byte> Uplane,
        int Upitch,
        Ref<byte> Vplane,
        int Vpitch
    );

    [NativeName("SDL_UploadToGPUBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUBuffer")]
    void UploadToGpuBuffer(
        GpuCopyPassHandle copy_pass,
        GpuTransferBufferLocation* source,
        GpuBufferRegion* destination,
        byte cycle
    );

    [NativeName("SDL_UploadToGPUBuffer")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUBuffer")]
    void UploadToGpuBuffer(
        GpuCopyPassHandle copy_pass,
        Ref<GpuTransferBufferLocation> source,
        Ref<GpuBufferRegion> destination,
        MaybeBool<byte> cycle
    );

    [NativeName("SDL_UploadToGPUTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUTexture")]
    void UploadToGpuTexture(
        GpuCopyPassHandle copy_pass,
        GpuTextureTransferInfo* source,
        GpuTextureRegion* destination,
        byte cycle
    );

    [NativeName("SDL_UploadToGPUTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_UploadToGPUTexture")]
    void UploadToGpuTexture(
        GpuCopyPassHandle copy_pass,
        Ref<GpuTextureTransferInfo> source,
        Ref<GpuTextureRegion> destination,
        MaybeBool<byte> cycle
    );

    [NativeName("SDL_utf8strlcpy")]
    [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlcpy")]
    nuint Utf8Strlcpy(sbyte* dst, sbyte* src, nuint dst_bytes);

    [NativeName("SDL_utf8strlcpy")]
    [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlcpy")]
    nuint Utf8Strlcpy(Ref<sbyte> dst, Ref<sbyte> src, nuint dst_bytes);

    [NativeName("SDL_utf8strlen")]
    [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlen")]
    nuint Utf8Strlen(sbyte* str);

    [NativeName("SDL_utf8strlen")]
    [NativeFunction("SDL3", EntryPoint = "SDL_utf8strlen")]
    nuint Utf8Strlen(Ref<sbyte> str);

    [NativeName("SDL_utf8strnlen")]
    [NativeFunction("SDL3", EntryPoint = "SDL_utf8strnlen")]
    nuint Utf8Strnlen(sbyte* str, nuint bytes);

    [NativeName("SDL_utf8strnlen")]
    [NativeFunction("SDL3", EntryPoint = "SDL_utf8strnlen")]
    nuint Utf8Strnlen(Ref<sbyte> str, nuint bytes);

    [NativeName("SDL_vasprintf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_vasprintf")]
    int Vasprintf(sbyte** strp, sbyte* fmt, sbyte* ap);

    [NativeName("SDL_vasprintf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_vasprintf")]
    int Vasprintf(Ref2D<sbyte> strp, Ref<sbyte> fmt, Ref<sbyte> ap);

    [NativeName("SDL_vsnprintf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_vsnprintf")]
    int Vsnprintf(sbyte* text, nuint maxlen, sbyte* fmt, sbyte* ap);

    [NativeName("SDL_vsnprintf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_vsnprintf")]
    int Vsnprintf(Ref<sbyte> text, nuint maxlen, Ref<sbyte> fmt, Ref<sbyte> ap);

    [NativeName("SDL_vsscanf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_vsscanf")]
    int Vsscanf(sbyte* text, sbyte* fmt, sbyte* ap);

    [NativeName("SDL_vsscanf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_vsscanf")]
    int Vsscanf(Ref<sbyte> text, Ref<sbyte> fmt, Ref<sbyte> ap);

    [NativeName("SDL_vswprintf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_vswprintf")]
    int Vswprintf(ushort* text, nuint maxlen, ushort* fmt, sbyte* ap);

    [NativeName("SDL_vswprintf")]
    [NativeFunction("SDL3", EntryPoint = "SDL_vswprintf")]
    int Vswprintf(Ref<ushort> text, nuint maxlen, Ref<ushort> fmt, Ref<sbyte> ap);

    [NativeName("SDL_Vulkan_CreateSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_CreateSurface")]
    byte VulkanCreateSurface(WindowHandle window, void* instance, void* allocator, ulong* surface);

    [NativeName("SDL_Vulkan_CreateSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_CreateSurface")]
    MaybeBool<byte> VulkanCreateSurface(
        WindowHandle window,
        Ref instance,
        Ref allocator,
        Ref<ulong> surface
    );

    [NativeName("SDL_Vulkan_DestroySurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_DestroySurface")]
    void VulkanDestroySurface(void* instance, ulong surface, void* allocator);

    [NativeName("SDL_Vulkan_DestroySurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_DestroySurface")]
    void VulkanDestroySurface(Ref instance, ulong surface, Ref allocator);

    [NativeName("SDL_Vulkan_GetInstanceExtensions")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
    sbyte** VulkanGetInstanceExtensions(uint* count);

    [NativeName("SDL_Vulkan_GetInstanceExtensions")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
    Ptr2D<sbyte> VulkanGetInstanceExtensions(Ref<uint> count);

    [NativeName("SDL_Vulkan_GetPresentationSupport")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetPresentationSupport")]
    byte VulkanGetPresentationSupport(void* instance, ulong physicalDevice, uint queueFamilyIndex);

    [NativeName("SDL_Vulkan_GetPresentationSupport")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetPresentationSupport")]
    MaybeBool<byte> VulkanGetPresentationSupport(
        Ref instance,
        ulong physicalDevice,
        uint queueFamilyIndex
    );

    [NativeName("SDL_Vulkan_GetVkGetInstanceProcAddr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_GetVkGetInstanceProcAddr")]
    FunctionPointer VulkanGetVkGetInstanceProcAddr();

    [NativeName("SDL_Vulkan_LoadLibrary")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_LoadLibrary")]
    byte VulkanLoadLibrary(sbyte* path);

    [NativeName("SDL_Vulkan_LoadLibrary")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_LoadLibrary")]
    MaybeBool<byte> VulkanLoadLibrary(Ref<sbyte> path);

    [NativeName("SDL_Vulkan_UnloadLibrary")]
    [NativeFunction("SDL3", EntryPoint = "SDL_Vulkan_UnloadLibrary")]
    void VulkanUnloadLibrary();

    [NativeName("SDL_WaitAndAcquireGPUSwapchainTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitAndAcquireGPUSwapchainTexture")]
    byte WaitAndAcquireGpuSwapchainTexture(
        GpuCommandBufferHandle command_buffer,
        WindowHandle window,
        GpuTextureHandle* swapchain_texture,
        uint* swapchain_texture_width,
        uint* swapchain_texture_height
    );

    [NativeName("SDL_WaitAndAcquireGPUSwapchainTexture")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitAndAcquireGPUSwapchainTexture")]
    MaybeBool<byte> WaitAndAcquireGpuSwapchainTexture(
        GpuCommandBufferHandle command_buffer,
        WindowHandle window,
        Ref<GpuTextureHandle> swapchain_texture,
        Ref<uint> swapchain_texture_width,
        Ref<uint> swapchain_texture_height
    );

    [NativeName("SDL_WaitCondition")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitCondition")]
    void WaitCondition(ConditionHandle cond, MutexHandle mutex);

    [NativeName("SDL_WaitConditionTimeout")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitConditionTimeout")]
    MaybeBool<byte> WaitConditionTimeout(ConditionHandle cond, MutexHandle mutex, int timeoutMS);

    [NativeName("SDL_WaitConditionTimeout")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitConditionTimeout")]
    byte WaitConditionTimeoutRaw(ConditionHandle cond, MutexHandle mutex, int timeoutMS);

    [NativeName("SDL_WaitEvent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitEvent")]
    byte WaitEvent(Event* @event);

    [NativeName("SDL_WaitEvent")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitEvent")]
    MaybeBool<byte> WaitEvent(Ref<Event> @event);

    [NativeName("SDL_WaitEventTimeout")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitEventTimeout")]
    byte WaitEventTimeout(Event* @event, int timeoutMS);

    [NativeName("SDL_WaitEventTimeout")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitEventTimeout")]
    MaybeBool<byte> WaitEventTimeout(Ref<Event> @event, int timeoutMS);

    [NativeName("SDL_WaitForGPUFences")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUFences")]
    byte WaitForGpuFences(
        GpuDeviceHandle device,
        byte wait_all,
        GpuFenceHandle* fences,
        uint num_fences
    );

    [NativeName("SDL_WaitForGPUFences")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUFences")]
    MaybeBool<byte> WaitForGpuFences(
        GpuDeviceHandle device,
        MaybeBool<byte> wait_all,
        Ref<GpuFenceHandle> fences,
        uint num_fences
    );

    [NativeName("SDL_WaitForGPUIdle")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUIdle")]
    MaybeBool<byte> WaitForGpuIdle(GpuDeviceHandle device);

    [NativeName("SDL_WaitForGPUIdle")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUIdle")]
    byte WaitForGpuIdleRaw(GpuDeviceHandle device);

    [NativeName("SDL_WaitForGPUSwapchain")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUSwapchain")]
    MaybeBool<byte> WaitForGpuSwapchain(GpuDeviceHandle device, WindowHandle window);

    [NativeName("SDL_WaitForGPUSwapchain")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitForGPUSwapchain")]
    byte WaitForGpuSwapchainRaw(GpuDeviceHandle device, WindowHandle window);

    [NativeName("SDL_WaitProcess")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitProcess")]
    byte WaitProcess(ProcessHandle process, byte block, int* exitcode);

    [NativeName("SDL_WaitProcess")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitProcess")]
    MaybeBool<byte> WaitProcess(ProcessHandle process, MaybeBool<byte> block, Ref<int> exitcode);

    [NativeName("SDL_WaitSemaphore")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphore")]
    void WaitSemaphore(SemaphoreHandle sem);

    [NativeName("SDL_WaitSemaphoreTimeout")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphoreTimeout")]
    MaybeBool<byte> WaitSemaphoreTimeout(SemaphoreHandle sem, int timeoutMS);

    [NativeName("SDL_WaitSemaphoreTimeout")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitSemaphoreTimeout")]
    byte WaitSemaphoreTimeoutRaw(SemaphoreHandle sem, int timeoutMS);

    [NativeName("SDL_WaitThread")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitThread")]
    void WaitThread(ThreadHandle thread, int* status);

    [NativeName("SDL_WaitThread")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WaitThread")]
    void WaitThread(ThreadHandle thread, Ref<int> status);

    [NativeName("SDL_WarpMouseGlobal")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseGlobal")]
    MaybeBool<byte> WarpMouseGlobal(float x, float y);

    [NativeName("SDL_WarpMouseGlobal")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseGlobal")]
    byte WarpMouseGlobalRaw(float x, float y);

    [NativeName("SDL_WarpMouseInWindow")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WarpMouseInWindow")]
    void WarpMouseInWindow(WindowHandle window, float x, float y);

    [NativeName("SDL_WasInit")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WasInit")]
    uint WasInit(uint flags);

    [NativeName("SDL_wcscasecmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcscasecmp")]
    int Wcscasecmp(ushort* str1, ushort* str2);

    [NativeName("SDL_wcscasecmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcscasecmp")]
    int Wcscasecmp(Ref<ushort> str1, Ref<ushort> str2);

    [NativeName("SDL_wcscmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcscmp")]
    int Wcscmp(ushort* str1, ushort* str2);

    [NativeName("SDL_wcscmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcscmp")]
    int Wcscmp(Ref<ushort> str1, Ref<ushort> str2);

    [NativeName("SDL_wcsdup")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsdup")]
    ushort* Wcsdup(ushort* wstr);

    [NativeName("SDL_wcsdup")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsdup")]
    Ptr<ushort> Wcsdup(Ref<ushort> wstr);

    [NativeName("SDL_wcslcat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcslcat")]
    nuint Wcslcat(ushort* dst, ushort* src, nuint maxlen);

    [NativeName("SDL_wcslcat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcslcat")]
    nuint Wcslcat(Ref<ushort> dst, Ref<ushort> src, nuint maxlen);

    [NativeName("SDL_wcslcpy")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcslcpy")]
    nuint Wcslcpy(ushort* dst, ushort* src, nuint maxlen);

    [NativeName("SDL_wcslcpy")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcslcpy")]
    nuint Wcslcpy(Ref<ushort> dst, Ref<ushort> src, nuint maxlen);

    [NativeName("SDL_wcslen")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcslen")]
    nuint Wcslen(ushort* wstr);

    [NativeName("SDL_wcslen")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcslen")]
    nuint Wcslen(Ref<ushort> wstr);

    [NativeName("SDL_wcsncasecmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsncasecmp")]
    int Wcsncasecmp(ushort* str1, ushort* str2, nuint maxlen);

    [NativeName("SDL_wcsncasecmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsncasecmp")]
    int Wcsncasecmp(Ref<ushort> str1, Ref<ushort> str2, nuint maxlen);

    [NativeName("SDL_wcsncmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsncmp")]
    int Wcsncmp(ushort* str1, ushort* str2, nuint maxlen);

    [NativeName("SDL_wcsncmp")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsncmp")]
    int Wcsncmp(Ref<ushort> str1, Ref<ushort> str2, nuint maxlen);

    [NativeName("SDL_wcsnlen")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsnlen")]
    nuint Wcsnlen(ushort* wstr, nuint maxlen);

    [NativeName("SDL_wcsnlen")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsnlen")]
    nuint Wcsnlen(Ref<ushort> wstr, nuint maxlen);

    [NativeName("SDL_wcsnstr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsnstr")]
    ushort* Wcsnstr(ushort* haystack, ushort* needle, nuint maxlen);

    [NativeName("SDL_wcsnstr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsnstr")]
    Ptr<ushort> Wcsnstr(Ref<ushort> haystack, Ref<ushort> needle, nuint maxlen);

    [NativeName("SDL_wcsstr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsstr")]
    ushort* Wcsstr(ushort* haystack, ushort* needle);

    [NativeName("SDL_wcsstr")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcsstr")]
    Ptr<ushort> Wcsstr(Ref<ushort> haystack, Ref<ushort> needle);

    [NativeName("SDL_wcstol")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcstol")]
    int Wcstol(ushort* str, ushort** endp, int @base);

    [NativeName("SDL_wcstol")]
    [NativeFunction("SDL3", EntryPoint = "SDL_wcstol")]
    int Wcstol(Ref<ushort> str, Ref2D<ushort> endp, int @base);

    [NativeName("SDL_WindowHasSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WindowHasSurface")]
    MaybeBool<byte> WindowHasSurface(WindowHandle window);

    [NativeName("SDL_WindowHasSurface")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WindowHasSurface")]
    byte WindowHasSurfaceRaw(WindowHandle window);

    [NativeName("SDL_WindowSupportsGPUPresentMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUPresentMode")]
    MaybeBool<byte> WindowSupportsGpuPresentMode(
        GpuDeviceHandle device,
        WindowHandle window,
        GpuPresentMode present_mode
    );

    [NativeName("SDL_WindowSupportsGPUPresentMode")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUPresentMode")]
    byte WindowSupportsGpuPresentModeRaw(
        GpuDeviceHandle device,
        WindowHandle window,
        GpuPresentMode present_mode
    );

    [NativeName("SDL_WindowSupportsGPUSwapchainComposition")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUSwapchainComposition")]
    MaybeBool<byte> WindowSupportsGpuSwapchainComposition(
        GpuDeviceHandle device,
        WindowHandle window,
        GpuSwapchainComposition swapchain_composition
    );

    [NativeName("SDL_WindowSupportsGPUSwapchainComposition")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WindowSupportsGPUSwapchainComposition")]
    byte WindowSupportsGpuSwapchainCompositionRaw(
        GpuDeviceHandle device,
        WindowHandle window,
        GpuSwapchainComposition swapchain_composition
    );

    [NativeName("SDL_WriteIO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteIO")]
    nuint WriteIo(IoStreamHandle context, void* ptr, nuint size);

    [NativeName("SDL_WriteIO")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteIO")]
    nuint WriteIo(IoStreamHandle context, Ref ptr, nuint size);

    [NativeName("SDL_WriteS16BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16BE")]
    MaybeBool<byte> WriteS16Be(IoStreamHandle dst, short value);

    [NativeName("SDL_WriteS16BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16BE")]
    byte WriteS16BeRaw(IoStreamHandle dst, short value);

    [NativeName("SDL_WriteS16LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16LE")]
    MaybeBool<byte> WriteS16Le(IoStreamHandle dst, short value);

    [NativeName("SDL_WriteS16LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS16LE")]
    byte WriteS16LeRaw(IoStreamHandle dst, short value);

    [NativeName("SDL_WriteS32BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32BE")]
    MaybeBool<byte> WriteS32Be(IoStreamHandle dst, int value);

    [NativeName("SDL_WriteS32BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32BE")]
    byte WriteS32BeRaw(IoStreamHandle dst, int value);

    [NativeName("SDL_WriteS32LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32LE")]
    MaybeBool<byte> WriteS32Le(IoStreamHandle dst, int value);

    [NativeName("SDL_WriteS32LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS32LE")]
    byte WriteS32LeRaw(IoStreamHandle dst, int value);

    [NativeName("SDL_WriteS64BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64BE")]
    MaybeBool<byte> WriteS64Be(IoStreamHandle dst, long value);

    [NativeName("SDL_WriteS64BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64BE")]
    byte WriteS64BeRaw(IoStreamHandle dst, long value);

    [NativeName("SDL_WriteS64LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64LE")]
    MaybeBool<byte> WriteS64Le(IoStreamHandle dst, long value);

    [NativeName("SDL_WriteS64LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS64LE")]
    byte WriteS64LeRaw(IoStreamHandle dst, long value);

    [NativeName("SDL_WriteS8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS8")]
    MaybeBool<byte> WriteS8(IoStreamHandle dst, sbyte value);

    [NativeName("SDL_WriteS8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteS8")]
    byte WriteS8Raw(IoStreamHandle dst, sbyte value);

    [NativeName("SDL_WriteStorageFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteStorageFile")]
    byte WriteStorageFile(StorageHandle storage, sbyte* path, void* source, ulong length);

    [NativeName("SDL_WriteStorageFile")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteStorageFile")]
    MaybeBool<byte> WriteStorageFile(
        StorageHandle storage,
        Ref<sbyte> path,
        Ref source,
        ulong length
    );

    [NativeName("SDL_WriteSurfacePixel")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteSurfacePixel")]
    byte WriteSurfacePixel(Surface* surface, int x, int y, byte r, byte g, byte b, byte a);

    [NativeName("SDL_WriteSurfacePixel")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteSurfacePixel")]
    MaybeBool<byte> WriteSurfacePixel(
        Ref<Surface> surface,
        int x,
        int y,
        byte r,
        byte g,
        byte b,
        byte a
    );

    [NativeName("SDL_WriteSurfacePixelFloat")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteSurfacePixelFloat")]
    byte WriteSurfacePixelFloat(Surface* surface, int x, int y, float r, float g, float b, float a);

    [NativeName("SDL_WriteSurfacePixelFloat")]
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

    [NativeName("SDL_WriteU16BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16BE")]
    MaybeBool<byte> WriteU16Be(IoStreamHandle dst, ushort value);

    [NativeName("SDL_WriteU16BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16BE")]
    byte WriteU16BeRaw(IoStreamHandle dst, ushort value);

    [NativeName("SDL_WriteU16LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16LE")]
    MaybeBool<byte> WriteU16Le(IoStreamHandle dst, ushort value);

    [NativeName("SDL_WriteU16LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU16LE")]
    byte WriteU16LeRaw(IoStreamHandle dst, ushort value);

    [NativeName("SDL_WriteU32BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32BE")]
    MaybeBool<byte> WriteU32Be(IoStreamHandle dst, uint value);

    [NativeName("SDL_WriteU32BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32BE")]
    byte WriteU32BeRaw(IoStreamHandle dst, uint value);

    [NativeName("SDL_WriteU32LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32LE")]
    MaybeBool<byte> WriteU32Le(IoStreamHandle dst, uint value);

    [NativeName("SDL_WriteU32LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU32LE")]
    byte WriteU32LeRaw(IoStreamHandle dst, uint value);

    [NativeName("SDL_WriteU64BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64BE")]
    MaybeBool<byte> WriteU64Be(IoStreamHandle dst, ulong value);

    [NativeName("SDL_WriteU64BE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64BE")]
    byte WriteU64BeRaw(IoStreamHandle dst, ulong value);

    [NativeName("SDL_WriteU64LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64LE")]
    MaybeBool<byte> WriteU64Le(IoStreamHandle dst, ulong value);

    [NativeName("SDL_WriteU64LE")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU64LE")]
    byte WriteU64LeRaw(IoStreamHandle dst, ulong value);

    [NativeName("SDL_WriteU8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU8")]
    MaybeBool<byte> WriteU8(IoStreamHandle dst, byte value);

    [NativeName("SDL_WriteU8")]
    [NativeFunction("SDL3", EntryPoint = "SDL_WriteU8")]
    byte WriteU8Raw(IoStreamHandle dst, byte value);
}
