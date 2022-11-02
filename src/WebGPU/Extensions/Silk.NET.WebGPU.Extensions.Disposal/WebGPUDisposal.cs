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
            _wgpu?.TextureViewDrop(textureView);
            _dawn?.TextureViewRelease(textureView);
        }

        public void Dispose(ShaderModule* shaderModule)
        {
            _wgpu?.ShaderModuleDrop(shaderModule);
            _dawn?.ShaderModuleRelease(shaderModule);
        }

        public void Dispose(RenderPipeline* renderPipeline)
        {
            _wgpu?.RenderPipelineDrop(renderPipeline);
            _dawn?.RenderPipelineRelease(renderPipeline);
        }

        public void Dispose(RenderBundle* renderBundle)
        {
            _wgpu?.RenderBundleDrop(renderBundle);
            _dawn?.RenderBundleRelease(renderBundle);
        }

        public void Dispose(PipelineLayout* pipelineLayout)
        {
            _wgpu?.PipelineLayoutDrop(pipelineLayout);
            _dawn?.PipelineLayoutRelease(pipelineLayout);
        }

        public void Dispose(Device* device)
        {
            _wgpu?.DeviceDrop(device);
            _dawn?.DeviceRelease(device);
        }

        public void Dispose(CommandEncoder* commandEncoder)
        {
            _wgpu?.CommandEncoderDrop(commandEncoder);
            _dawn?.CommandEncoderRelease(commandEncoder);
        }

        public void Dispose(CommandBuffer* commandBuffer)
        {
            _wgpu?.CommandBufferDrop(commandBuffer);
            _dawn?.CommandBufferRelease(commandBuffer);
        }

        public void Dispose(ComputePipeline* computePipeline)
        {
            _wgpu?.ComputePipelineDrop(computePipeline);
            _dawn?.ComputePipelineRelease(computePipeline);
        }

        public void Dispose(Adapter* adapter)
        {
            _wgpu?.AdapterDrop(adapter);
            _dawn?.AdapterRelease(adapter);
        }

        public void Dispose(BindGroup* bindGroup)
        {
            _wgpu?.BindGroupDrop(bindGroup);
            _dawn?.BindGroupRelease(bindGroup);
        }

        public void Dispose(BindGroupLayout* bindGroupLayout)
        {
            _wgpu?.BindGroupLayoutDrop(bindGroupLayout);
            _dawn?.BindGroupLayoutRelease(bindGroupLayout);
        }

        public void Dispose(Buffer* buffer)
        {
            _wgpu?.BufferDrop(buffer);
            _dawn?.BufferRelease(buffer);
        }

        public void Dispose(Surface* surface)
        {
            _wgpu?.SurfaceDrop(surface);
            _dawn?.SurfaceRelease(surface);
        }

        public void Dispose(Texture* texture)
        {
            _wgpu?.TextureDrop(texture);
            _dawn?.TextureRelease(texture);
        }

        public void Dispose(Sampler* sampler)
        {
            _wgpu?.SamplerDrop(sampler);
            _dawn?.SamplerRelease(sampler);
        }

        public void Dispose(QuerySet* querySet)
        {
            _wgpu?.QuerySetDrop(querySet);
            _dawn?.QuerySetRelease(querySet);
        }
    }
}
