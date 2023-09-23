// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.WebGPU.Extensions.WGPU;

namespace Silk.NET.WebGPU.Extensions.Disposal
{
    [Obsolete("Please use the *Release functions on the WebGPU class itself!")]
    public unsafe class WebGPUDisposal
    {
        private readonly WebGPU _webGpu;

        public WebGPUDisposal(WebGPU webGpu)
        {
            _webGpu = webGpu;
        }

        public void Dispose(TextureView* textureView) 
        {
            _webGpu.TextureViewRelease(textureView);
        }

        public void Dispose(ShaderModule* shaderModule)
        {
            _webGpu.ShaderModuleRelease(shaderModule);
        }

        public void Dispose(RenderPipeline* renderPipeline)
        {
            _webGpu.RenderPipelineRelease(renderPipeline);
        }

        public void Dispose(RenderBundle* renderBundle)
        {
            _webGpu.RenderBundleRelease(renderBundle);
        }

        public void Dispose(PipelineLayout* pipelineLayout)
        {
            _webGpu.PipelineLayoutRelease(pipelineLayout);
        }

        public void Dispose(Device* device)
        {
            _webGpu.DeviceRelease(device);
        }

        public void Dispose(CommandEncoder* commandEncoder)
        {
            _webGpu.CommandEncoderRelease(commandEncoder);
        }

        public void Dispose(CommandBuffer* commandBuffer)
        {
            _webGpu.CommandBufferRelease(commandBuffer);
        }

        public void Dispose(ComputePipeline* computePipeline)
        {
            _webGpu.ComputePipelineRelease(computePipeline);
        }

        public void Dispose(Adapter* adapter)
        {
            _webGpu.AdapterRelease(adapter);
        }

        public void Dispose(BindGroup* bindGroup)
        {
            _webGpu.BindGroupRelease(bindGroup);
        }

        public void Dispose(BindGroupLayout* bindGroupLayout)
        {
            _webGpu.BindGroupLayoutRelease(bindGroupLayout);
        }

        public void Dispose(Buffer* buffer)
        {
            _webGpu.BufferRelease(buffer);
        }

        public void Dispose(Surface* surface)
        {
            _webGpu.SurfaceRelease(surface);
        }

        public void Dispose(Texture* texture)
        {
            _webGpu.TextureRelease(texture);
        }

        public void Dispose(Sampler* sampler)
        {
            _webGpu.SamplerRelease(sampler);
        }

        public void Dispose(QuerySet* querySet)
        {
            _webGpu.QuerySetRelease(querySet);
        }

        public void Dispose(RenderBundleEncoder* renderBundleEncoder)
        {
            _webGpu.RenderBundleEncoderRelease(renderBundleEncoder);
        }
    }
}
