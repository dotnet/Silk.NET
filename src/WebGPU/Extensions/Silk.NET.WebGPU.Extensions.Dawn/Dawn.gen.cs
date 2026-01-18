// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.WebGPU;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Extension("dawn-webgpu.h")]
    public unsafe partial class Dawn : NativeExtension<WebGPU>
    {
        public const string ExtensionName = "dawn-webgpu.h";
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3768, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterPropertiesFreeMembers")]
        public partial void AdapterPropertiesFreeMembers(AdapterProperties value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3769, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterPropertiesMemoryHeapsFreeMembers")]
        public partial void AdapterPropertiesMemoryHeapsFreeMembers(AdapterPropertiesMemoryHeaps value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3771, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDrmFormatCapabilitiesFreeMembers")]
        public partial void DrmFormatCapabilitiesFreeMembers(DrmFormatCapabilities value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3772, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetInstanceFeatures")]
        public unsafe partial Status GetInstanceFeatures(InstanceFeatures* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3772, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetInstanceFeatures")]
        public partial Status GetInstanceFeatures(ref InstanceFeatures features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3773, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3773, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3773, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuGetProcAddress")]
        public unsafe partial PfnProc GetProcAddress(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string procName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3774, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryEndAccessStateFreeMembers")]
        public partial void SharedBufferMemoryEndAccessStateFreeMembers(SharedBufferMemoryEndAccessState value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3775, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryEndAccessStateFreeMembers")]
        public partial void SharedTextureMemoryEndAccessStateFreeMembers(SharedTextureMemoryEndAccessState value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3779, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterCreateDevice")]
        public unsafe partial Device* AdapterCreateDevice(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3779, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterCreateDevice")]
        public unsafe partial Device* AdapterCreateDevice(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DeviceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3780, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public unsafe partial nuint AdapterEnumerateFeatures(Adapter* adapter, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3780, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterEnumerateFeatures")]
        public unsafe partial nuint AdapterEnumerateFeatures(Adapter* adapter, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3781, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetFormatCapabilities")]
        public unsafe partial Status AdapterGetFormatCapabilities(Adapter* adapter, TextureFormat format, FormatCapabilities* capabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3781, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetFormatCapabilities")]
        public unsafe partial Status AdapterGetFormatCapabilities(Adapter* adapter, TextureFormat format, ref FormatCapabilities capabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3782, Column 26 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetInstance")]
        public unsafe partial Instance* AdapterGetInstance(Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3783, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial Status AdapterGetLimits(Adapter* adapter, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3783, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetLimits")]
        public unsafe partial Status AdapterGetLimits(Adapter* adapter, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3784, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public unsafe partial Status AdapterGetProperties(Adapter* adapter, AdapterProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3784, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterGetProperties")]
        public unsafe partial Status AdapterGetProperties(Adapter* adapter, ref AdapterProperties properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3786, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3786, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3786, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3786, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice")]
        public unsafe partial void AdapterRequestDevice<T0>(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DeviceDescriptor descriptor, PfnRequestDeviceCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3787, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice2")]
        public unsafe partial Future AdapterRequestDevice2(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* options, RequestDeviceCallbackInfo2 callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3787, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDevice2")]
        public unsafe partial Future AdapterRequestDevice2(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DeviceDescriptor options, RequestDeviceCallbackInfo2 callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3788, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDeviceF")]
        public unsafe partial Future AdapterRequestDeviceF(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceDescriptor* options, RequestDeviceCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3788, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuAdapterRequestDeviceF")]
        public unsafe partial Future AdapterRequestDeviceF(Adapter* adapter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly DeviceDescriptor options, RequestDeviceCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3793, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroup* bindGroup, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3793, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroup* bindGroup, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3793, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupSetLabel")]
        public unsafe partial void BindGroupSetLabel(BindGroup* bindGroup, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3798, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayout* bindGroupLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3798, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayout* bindGroupLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3798, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBindGroupLayoutSetLabel")]
        public unsafe partial void BindGroupLayoutSetLabel(BindGroupLayout* bindGroupLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3809, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync(Buffer* buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, PfnBufferMapCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3809, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsync")]
        public unsafe partial void BufferMapAsync<T0>(Buffer* buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, PfnBufferMapCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3810, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferMapAsyncF")]
        public unsafe partial Future BufferMapAsyncF(Buffer* buffer, Silk.NET.WebGPU.MapMode mode, nuint offset, nuint size, BufferMapCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3811, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3811, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3811, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuBufferSetLabel")]
        public unsafe partial void BufferSetLabel(Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3817, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBuffer* commandBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3817, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBuffer* commandBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3817, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandBufferSetLabel")]
        public unsafe partial void CommandBufferSetLabel(CommandBuffer* commandBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3826, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3826, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3826, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3826, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3826, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyBuffer source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3826, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyBuffer source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3826, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyBuffer source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3826, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyBufferToTexture")]
        public unsafe partial void CommandEncoderCopyBufferToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyBuffer source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3827, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3827, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3827, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyBuffer destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3827, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyBuffer destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3827, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3827, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyBuffer* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3827, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyBuffer destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3827, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToBuffer")]
        public unsafe partial void CommandEncoderCopyTextureToBuffer(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyBuffer destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3828, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3828, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3828, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3828, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3828, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3828, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3828, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3828, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderCopyTextureToTexture")]
        public unsafe partial void CommandEncoderCopyTextureToTexture(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3830, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3830, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3830, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInjectValidationError")]
        public unsafe partial void CommandEncoderInjectValidationError(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3831, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3831, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3831, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderInsertDebugMarker")]
        public unsafe partial void CommandEncoderInsertDebugMarker(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3833, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3833, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3833, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderPushDebugGroup")]
        public unsafe partial void CommandEncoderPushDebugGroup(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3835, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3835, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3835, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderSetLabel")]
        public unsafe partial void CommandEncoderSetLabel(CommandEncoder* commandEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3836, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3836, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3836, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuCommandEncoderWriteBuffer")]
        public unsafe partial void CommandEncoderWriteBuffer(CommandEncoder* commandEncoder, Buffer* buffer, ulong bufferOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3845, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3845, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3845, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderInsertDebugMarker")]
        public unsafe partial void ComputePassEncoderInsertDebugMarker(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3847, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3847, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3847, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderPushDebugGroup")]
        public unsafe partial void ComputePassEncoderPushDebugGroup(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3849, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3849, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3849, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderSetLabel")]
        public unsafe partial void ComputePassEncoderSetLabel(ComputePassEncoder* computePassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3851, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePassEncoderWriteTimestamp")]
        public unsafe partial void ComputePassEncoderWriteTimestamp(ComputePassEncoder* computePassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3857, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipeline* computePipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3857, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipeline* computePipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3857, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuComputePipelineSetLabel")]
        public unsafe partial void ComputePipelineSetLabel(ComputePipeline* computePipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3867, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3867, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3867, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3867, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsync")]
        public unsafe partial void DeviceCreateComputePipelineAsync<T0>(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ComputePipelineDescriptor descriptor, PfnCreateComputePipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3868, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsyncF")]
        public unsafe partial Future DeviceCreateComputePipelineAsyncF(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineDescriptor* descriptor, CreateComputePipelineAsyncCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3868, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateComputePipelineAsyncF")]
        public unsafe partial Future DeviceCreateComputePipelineAsyncF(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ComputePipelineDescriptor descriptor, CreateComputePipelineAsyncCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3869, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorBuffer")]
        public unsafe partial Buffer* DeviceCreateErrorBuffer(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3869, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorBuffer")]
        public unsafe partial Buffer* DeviceCreateErrorBuffer(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3870, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateErrorExternalTexture(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3871, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3871, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3871, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderModuleDescriptor* descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3871, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ShaderModuleDescriptor descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3871, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ShaderModuleDescriptor descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3871, Column 30 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorShaderModule")]
        public unsafe partial ShaderModule* DeviceCreateErrorShaderModule(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ShaderModuleDescriptor descriptor, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errorMessage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3872, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorTexture")]
        public unsafe partial Texture* DeviceCreateErrorTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3872, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateErrorTexture")]
        public unsafe partial Texture* DeviceCreateErrorTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3873, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateExternalTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalTextureDescriptor* externalTextureDescriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3873, Column 33 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateExternalTexture")]
        public unsafe partial ExternalTextureImpl* DeviceCreateExternalTexture(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ExternalTextureDescriptor externalTextureDescriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3878, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3878, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3878, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3878, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsync")]
        public unsafe partial void DeviceCreateRenderPipelineAsync<T0>(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderPipelineDescriptor descriptor, PfnCreateRenderPipelineAsyncCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3879, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsyncF")]
        public unsafe partial Future DeviceCreateRenderPipelineAsyncF(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderPipelineDescriptor* descriptor, CreateRenderPipelineAsyncCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3879, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateRenderPipelineAsyncF")]
        public unsafe partial Future DeviceCreateRenderPipelineAsyncF(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RenderPipelineDescriptor descriptor, CreateRenderPipelineAsyncCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3882, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapChainDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3882, Column 27 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceCreateSwapChain")]
        public unsafe partial SwapChain* DeviceCreateSwapChain(Device* device, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SwapChainDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3885, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public unsafe partial nuint DeviceEnumerateFeatures(Device* device, FeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3885, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceEnumerateFeatures")]
        public unsafe partial nuint DeviceEnumerateFeatures(Device* device, ref FeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3886, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3886, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3886, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceForceLoss")]
        public unsafe partial void DeviceForceLoss(Device* device, DeviceLostReason type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3887, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetAdapter")]
        public unsafe partial Adapter* DeviceGetAdapter(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3888, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial Status DeviceGetLimits(Device* device, SupportedLimits* limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3888, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetLimits")]
        public unsafe partial Status DeviceGetLimits(Device* device, ref SupportedLimits limits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3890, Column 35 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceGetSupportedSurfaceUsage")]
        public unsafe partial Silk.NET.WebGPU.TextureUsage DeviceGetSupportedSurfaceUsage(Device* device, Surface* surface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3892, Column 36 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedBufferMemory")]
        public unsafe partial SharedBufferMemoryImpl* DeviceImportSharedBufferMemory(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedBufferMemoryDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3892, Column 36 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedBufferMemory")]
        public unsafe partial SharedBufferMemoryImpl* DeviceImportSharedBufferMemory(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SharedBufferMemoryDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3893, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedFence")]
        public unsafe partial SharedFenceImpl* DeviceImportSharedFence(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedFenceDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3893, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedFence")]
        public unsafe partial SharedFenceImpl* DeviceImportSharedFence(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SharedFenceDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3894, Column 37 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedTextureMemory")]
        public unsafe partial SharedTextureMemoryImpl* DeviceImportSharedTextureMemory(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedTextureMemoryDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3894, Column 37 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceImportSharedTextureMemory")]
        public unsafe partial SharedTextureMemoryImpl* DeviceImportSharedTextureMemory(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SharedTextureMemoryDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3895, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3895, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3895, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceInjectError")]
        public unsafe partial void DeviceInjectError(Device* device, ErrorType type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3896, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public unsafe partial void DevicePopErrorScope(Device* device, PfnErrorCallback oldCallback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3896, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope")]
        public unsafe partial void DevicePopErrorScope<T0>(Device* device, PfnErrorCallback oldCallback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3897, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScope2")]
        public unsafe partial Future DevicePopErrorScope2(Device* device, PopErrorScopeCallbackInfo2 callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3898, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDevicePopErrorScopeF")]
        public unsafe partial Future DevicePopErrorScopeF(Device* device, PopErrorScopeCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3900, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback(Device* device, PfnDeviceLostCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3900, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetDeviceLostCallback")]
        public unsafe partial void DeviceSetDeviceLostCallback<T0>(Device* device, PfnDeviceLostCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3901, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3901, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3901, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLabel")]
        public unsafe partial void DeviceSetLabel(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3902, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLoggingCallback")]
        public unsafe partial void DeviceSetLoggingCallback(Device* device, PfnLoggingCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3902, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetLoggingCallback")]
        public unsafe partial void DeviceSetLoggingCallback<T0>(Device* device, PfnLoggingCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3903, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public unsafe partial void DeviceSetUncapturedErrorCallback(Device* device, PfnErrorCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3903, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceSetUncapturedErrorCallback")]
        public unsafe partial void DeviceSetUncapturedErrorCallback<T0>(Device* device, PfnErrorCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3904, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceTick")]
        public unsafe partial void DeviceTick(Device* device);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3905, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceValidateTextureDescriptor")]
        public unsafe partial void DeviceValidateTextureDescriptor(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3905, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuDeviceValidateTextureDescriptor")]
        public unsafe partial void DeviceValidateTextureDescriptor(Device* device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3910, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureDestroy")]
        public unsafe partial void ExternalTextureDestroy(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3911, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureExpire")]
        public unsafe partial void ExternalTextureExpire(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3912, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureRefresh")]
        public unsafe partial void ExternalTextureRefresh(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3913, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3913, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3913, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureSetLabel")]
        public unsafe partial void ExternalTextureSetLabel(ExternalTextureImpl* externalTexture, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3914, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureAddRef")]
        public unsafe partial void ExternalTextureAddRef(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3915, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuExternalTextureRelease")]
        public unsafe partial void ExternalTextureRelease(ExternalTextureImpl* externalTexture);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3919, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateWGSLLanguageFeatures")]
        public unsafe partial nuint InstanceEnumerateWGSLLanguageFeatures(Instance* instance, WGSLFeatureName* features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3919, Column 20 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceEnumerateWGSLLanguageFeatures")]
        public unsafe partial nuint InstanceEnumerateWGSLLanguageFeatures(Instance* instance, ref WGSLFeatureName features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3920, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceHasWGSLLanguageFeature")]
        public unsafe partial Silk.NET.Core.Bool32 InstanceHasWGSLLanguageFeature(Instance* instance, WGSLFeatureName feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3922, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3922, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3922, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RequestAdapterOptions options, PfnRequestAdapterCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3922, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter")]
        public unsafe partial void InstanceRequestAdapter<T0>(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RequestAdapterOptions options, PfnRequestAdapterCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3923, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter2")]
        public unsafe partial Future InstanceRequestAdapter2(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, RequestAdapterCallbackInfo2 callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3923, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapter2")]
        public unsafe partial Future InstanceRequestAdapter2(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RequestAdapterOptions options, RequestAdapterCallbackInfo2 callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3924, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapterF")]
        public unsafe partial Future InstanceRequestAdapterF(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RequestAdapterOptions* options, RequestAdapterCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3924, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuInstanceRequestAdapterF")]
        public unsafe partial Future InstanceRequestAdapterF(Instance* instance, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly RequestAdapterOptions options, RequestAdapterCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3930, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayout* pipelineLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3930, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayout* pipelineLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3930, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuPipelineLayoutSetLabel")]
        public unsafe partial void PipelineLayoutSetLabel(PipelineLayout* pipelineLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3938, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySet* querySet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3938, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySet* querySet, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3938, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQuerySetSetLabel")]
        public unsafe partial void QuerySetSetLabel(QuerySet* querySet, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyExternalTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3943, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyExternalTextureForBrowser")]
        public unsafe partial void QueueCopyExternalTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyExternalTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyTextureForBrowserOptions* options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3944, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueCopyTextureForBrowser")]
        public unsafe partial void QueueCopyTextureForBrowser(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture source, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D copySize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CopyTextureForBrowserOptions options);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3945, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone(Queue* queue, PfnQueueWorkDoneCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3945, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDone")]
        public unsafe partial void QueueOnSubmittedWorkDone<T0>(Queue* queue, PfnQueueWorkDoneCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3946, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueOnSubmittedWorkDoneF")]
        public unsafe partial Future QueueOnSubmittedWorkDoneF(Queue* queue, QueueWorkDoneCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3947, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3947, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3947, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueSetLabel")]
        public unsafe partial void QueueSetLabel(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageCopyTexture* destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDataLayout* dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Extent3D* writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3950, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuQueueWriteTexture")]
        public unsafe partial void QueueWriteTexture<T0>(Queue* queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ImageCopyTexture destination, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 data, nuint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TextureDataLayout dataLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Extent3D writeSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3955, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleSetLabel")]
        public unsafe partial void RenderBundleSetLabel(RenderBundle* renderBundle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3955, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleSetLabel")]
        public unsafe partial void RenderBundleSetLabel(RenderBundle* renderBundle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3955, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleSetLabel")]
        public unsafe partial void RenderBundleSetLabel(RenderBundle* renderBundle, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3965, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3965, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3965, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderInsertDebugMarker")]
        public unsafe partial void RenderBundleEncoderInsertDebugMarker(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3967, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3967, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3967, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderPushDebugGroup")]
        public unsafe partial void RenderBundleEncoderPushDebugGroup(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3970, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3970, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3970, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderBundleEncoderSetLabel")]
        public unsafe partial void RenderBundleEncoderSetLabel(RenderBundleEncoder* renderBundleEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3985, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3985, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3985, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderInsertDebugMarker")]
        public unsafe partial void RenderPassEncoderInsertDebugMarker(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string markerLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3986, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPixelLocalStorageBarrier")]
        public unsafe partial void RenderPassEncoderPixelLocalStorageBarrier(RenderPassEncoder* renderPassEncoder);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3988, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3988, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3988, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderPushDebugGroup")]
        public unsafe partial void RenderPassEncoderPushDebugGroup(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string groupLabel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3992, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3992, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3992, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderSetLabel")]
        public unsafe partial void RenderPassEncoderSetLabel(RenderPassEncoder* renderPassEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3998, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPassEncoderWriteTimestamp")]
        public unsafe partial void RenderPassEncoderWriteTimestamp(RenderPassEncoder* renderPassEncoder, QuerySet* querySet, uint queryIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4004, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipeline* renderPipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4004, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipeline* renderPipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4004, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuRenderPipelineSetLabel")]
        public unsafe partial void RenderPipelineSetLabel(RenderPipeline* renderPipeline, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4009, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(Sampler* sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4009, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(Sampler* sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4009, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSamplerSetLabel")]
        public unsafe partial void SamplerSetLabel(Sampler* sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4014, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo(ShaderModule* shaderModule, PfnCompilationInfoCallback callback, void* userdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4014, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfo")]
        public unsafe partial void ShaderModuleGetCompilationInfo<T0>(ShaderModule* shaderModule, PfnCompilationInfoCallback callback, ref T0 userdata) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4015, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleGetCompilationInfoF")]
        public unsafe partial Future ShaderModuleGetCompilationInfoF(ShaderModule* shaderModule, CompilationInfoCallbackInfo callbackInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4016, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModule* shaderModule, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4016, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModule* shaderModule, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4016, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuShaderModuleSetLabel")]
        public unsafe partial void ShaderModuleSetLabel(ShaderModule* shaderModule, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4021, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryBeginAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedBufferMemoryBeginAccess(SharedBufferMemoryImpl* sharedBufferMemory, Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedBufferMemoryBeginAccessDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4021, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryBeginAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedBufferMemoryBeginAccess(SharedBufferMemoryImpl* sharedBufferMemory, Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SharedBufferMemoryBeginAccessDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4022, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryCreateBuffer")]
        public unsafe partial Buffer* SharedBufferMemoryCreateBuffer(SharedBufferMemoryImpl* sharedBufferMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4022, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryCreateBuffer")]
        public unsafe partial Buffer* SharedBufferMemoryCreateBuffer(SharedBufferMemoryImpl* sharedBufferMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BufferDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4023, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryEndAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedBufferMemoryEndAccess(SharedBufferMemoryImpl* sharedBufferMemory, Buffer* buffer, SharedBufferMemoryEndAccessState* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4023, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryEndAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedBufferMemoryEndAccess(SharedBufferMemoryImpl* sharedBufferMemory, Buffer* buffer, ref SharedBufferMemoryEndAccessState descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4024, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryGetProperties")]
        public unsafe partial Status SharedBufferMemoryGetProperties(SharedBufferMemoryImpl* sharedBufferMemory, SharedBufferMemoryProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4024, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryGetProperties")]
        public unsafe partial Status SharedBufferMemoryGetProperties(SharedBufferMemoryImpl* sharedBufferMemory, ref SharedBufferMemoryProperties properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4025, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryIsDeviceLost")]
        public unsafe partial Silk.NET.Core.Bool32 SharedBufferMemoryIsDeviceLost(SharedBufferMemoryImpl* sharedBufferMemory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4026, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemorySetLabel")]
        public unsafe partial void SharedBufferMemorySetLabel(SharedBufferMemoryImpl* sharedBufferMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4026, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemorySetLabel")]
        public unsafe partial void SharedBufferMemorySetLabel(SharedBufferMemoryImpl* sharedBufferMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4026, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemorySetLabel")]
        public unsafe partial void SharedBufferMemorySetLabel(SharedBufferMemoryImpl* sharedBufferMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4027, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryAddRef")]
        public unsafe partial void SharedBufferMemoryAddRef(SharedBufferMemoryImpl* sharedBufferMemory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4028, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedBufferMemoryRelease")]
        public unsafe partial void SharedBufferMemoryRelease(SharedBufferMemoryImpl* sharedBufferMemory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4031, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedFenceExportInfo")]
        public unsafe partial void SharedFenceExportInfo(SharedFenceImpl* sharedFence, SharedFenceExportInfo* info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4031, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedFenceExportInfo")]
        public unsafe partial void SharedFenceExportInfo(SharedFenceImpl* sharedFence, ref SharedFenceExportInfo info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4032, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedFenceAddRef")]
        public unsafe partial void SharedFenceAddRef(SharedFenceImpl* sharedFence);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4033, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedFenceRelease")]
        public unsafe partial void SharedFenceRelease(SharedFenceImpl* sharedFence);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4036, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryBeginAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedTextureMemoryBeginAccess(SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedTextureMemoryBeginAccessDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4036, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryBeginAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedTextureMemoryBeginAccess(SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SharedTextureMemoryBeginAccessDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4037, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryCreateTexture")]
        public unsafe partial Texture* SharedTextureMemoryCreateTexture(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4037, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryCreateTexture")]
        public unsafe partial Texture* SharedTextureMemoryCreateTexture(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TextureDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4038, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryEndAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedTextureMemoryEndAccess(SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, SharedTextureMemoryEndAccessState* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4038, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryEndAccess")]
        public unsafe partial Silk.NET.Core.Bool32 SharedTextureMemoryEndAccess(SharedTextureMemoryImpl* sharedTextureMemory, Texture* texture, ref SharedTextureMemoryEndAccessState descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4039, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryGetProperties")]
        public unsafe partial Status SharedTextureMemoryGetProperties(SharedTextureMemoryImpl* sharedTextureMemory, SharedTextureMemoryProperties* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4039, Column 24 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryGetProperties")]
        public unsafe partial Status SharedTextureMemoryGetProperties(SharedTextureMemoryImpl* sharedTextureMemory, ref SharedTextureMemoryProperties properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4040, Column 22 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryIsDeviceLost")]
        public unsafe partial Silk.NET.Core.Bool32 SharedTextureMemoryIsDeviceLost(SharedTextureMemoryImpl* sharedTextureMemory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4041, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemorySetLabel")]
        public unsafe partial void SharedTextureMemorySetLabel(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4041, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemorySetLabel")]
        public unsafe partial void SharedTextureMemorySetLabel(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4041, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemorySetLabel")]
        public unsafe partial void SharedTextureMemorySetLabel(SharedTextureMemoryImpl* sharedTextureMemory, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4042, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryAddRef")]
        public unsafe partial void SharedTextureMemoryAddRef(SharedTextureMemoryImpl* sharedTextureMemory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4043, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSharedTextureMemoryRelease")]
        public unsafe partial void SharedTextureMemoryRelease(SharedTextureMemoryImpl* sharedTextureMemory);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4049, Column 31 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSurfaceGetPreferredFormat")]
        public unsafe partial TextureFormat SurfaceGetPreferredFormat(Surface* surface, Adapter* adapter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4056, Column 25 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainGetCurrentTexture")]
        public unsafe partial Texture* SwapChainGetCurrentTexture(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4057, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainGetCurrentTextureView")]
        public unsafe partial TextureView* SwapChainGetCurrentTextureView(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4058, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainPresent")]
        public unsafe partial void SwapChainPresent(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4059, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainAddRef")]
        public unsafe partial void SwapChainAddRef(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4060, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuSwapChainRelease")]
        public unsafe partial void SwapChainRelease(SwapChain* swapChain);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4063, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateErrorView")]
        public unsafe partial TextureView* TextureCreateErrorView(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureViewDescriptor* descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4063, Column 29 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureCreateErrorView")]
        public unsafe partial TextureView* TextureCreateErrorView(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TextureViewDescriptor descriptor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4074, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4074, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4074, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureSetLabel")]
        public unsafe partial void TextureSetLabel(Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4079, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureView* textureView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4079, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureView* textureView, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte label);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4079, Column 18 in dawn-webgpu.h")]
        [NativeApi(EntryPoint = "wgpuTextureViewSetLabel")]
        public unsafe partial void TextureViewSetLabel(TextureView* textureView, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string label);

        public Dawn(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

