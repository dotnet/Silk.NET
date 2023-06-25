// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.WebGPU.Extensions.WGPU;

namespace Silk.NET.WebGPU.Extensions.Disposal
{
    public unsafe class WebGPUDisposal
    {
        private readonly WebGPU _webGpu;

        private readonly Dawn.Dawn _dawn;
        private readonly Wgpu _wgpu;

        public WebGPUDisposal(WebGPU webGpu)
        {
            _webGpu = webGpu;

            webGpu.TryGetDeviceExtension(null, out _dawn);
            webGpu.TryGetDeviceExtension(null, out _wgpu);
        }

        public void Dispose(TextureView* textureView)
        {
            if(this._wgpu != null) 
                _wgpu.TextureViewDrop(textureView);
            else 
                _webGpu.TextureViewRelease(textureView);
        }

        public void Dispose(ShaderModule* shaderModule)
        {
            if(this._wgpu != null) 
                _wgpu.ShaderModuleDrop(shaderModule);
            else 
                _webGpu.ShaderModuleRelease(shaderModule);
        }

        public void Dispose(RenderPipeline* renderPipeline)
        {
            if(this._wgpu != null) 
                _wgpu.RenderPipelineDrop(renderPipeline);
            else 
                _webGpu.RenderPipelineRelease(renderPipeline);
        }

        public void Dispose(RenderBundle* renderBundle)
        {
            if(this._wgpu != null) 
                _wgpu.RenderBundleDrop(renderBundle);
            else 
                _webGpu.RenderBundleRelease(renderBundle);
        }

        public void Dispose(PipelineLayout* pipelineLayout)
        {
            if(this._wgpu != null) 
                _wgpu.PipelineLayoutDrop(pipelineLayout);
            else 
                _webGpu.PipelineLayoutRelease(pipelineLayout);
        }

        public void Dispose(Device* device)
        {
            if(this._wgpu != null) 
                _wgpu.DeviceDrop(device);
            else 
                _webGpu.DeviceRelease(device);
        }

        public void Dispose(CommandEncoder* commandEncoder)
        {
            if(this._wgpu != null) 
                _wgpu.CommandEncoderDrop(commandEncoder);
            else 
                _webGpu.CommandEncoderRelease(commandEncoder);
        }

        public void Dispose(CommandBuffer* commandBuffer)
        {
            if(this._wgpu != null) 
                _wgpu.CommandBufferDrop(commandBuffer);
            else 
                _webGpu.CommandBufferRelease(commandBuffer);
        }

        public void Dispose(ComputePipeline* computePipeline)
        {
            if(this._wgpu != null) 
                _wgpu.ComputePipelineDrop(computePipeline);
            else 
                _webGpu.ComputePipelineRelease(computePipeline);
        }

        public void Dispose(Adapter* adapter)
        {
            if(this._wgpu != null) 
                _wgpu.AdapterDrop(adapter);
            else 
                _webGpu.AdapterRelease(adapter);
        }

        public void Dispose(BindGroup* bindGroup)
        {
            if(this._wgpu != null) 
                _wgpu.BindGroupDrop(bindGroup);
            else 
                _webGpu.BindGroupRelease(bindGroup);
        }

        public void Dispose(BindGroupLayout* bindGroupLayout)
        {
            if(this._wgpu != null) 
                _wgpu.BindGroupLayoutDrop(bindGroupLayout);
            else 
                _webGpu.BindGroupLayoutRelease(bindGroupLayout);
        }

        public void Dispose(Buffer* buffer)
        {
            if(this._wgpu != null) 
                _wgpu.BufferDrop(buffer);
            else 
                _webGpu.BufferRelease(buffer);
        }

        public void Dispose(Surface* surface)
        {
            if(this._wgpu != null) 
                _wgpu.SurfaceDrop(surface);
            else 
                _webGpu.SurfaceRelease(surface);
        }

        public void Dispose(Texture* texture)
        {
            if(this._wgpu != null) 
                _wgpu.TextureDrop(texture);
            else 
                _webGpu.TextureRelease(texture);
        }

        public void Dispose(Sampler* sampler)
        {
            if(this._wgpu != null) 
                _wgpu.SamplerDrop(sampler);
            else 
                _webGpu.SamplerRelease(sampler);
        }

        public void Dispose(QuerySet* querySet)
        {
            if(this._wgpu != null) 
                _wgpu.QuerySetDrop(querySet);
            else 
                _webGpu.QuerySetRelease(querySet);
        }

        public void Dispose(SwapChain* swapChain)
        {
            if(this._wgpu != null) 
                _wgpu.SwapChainDrop(swapChain);
            else 
                _webGpu.SwapChainRelease(swapChain);
        }

        public void Dispose(RenderBundleEncoder* renderBundleEncoder)
        {
            if(this._wgpu != null) 
                _wgpu.RenderBundleEncoderDrop(renderBundleEncoder);
            else 
                _webGpu.RenderBundleEncoderRelease(renderBundleEncoder);
        }
    }
}
