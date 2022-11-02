using System;
using Silk.NET.WebGPU.Extensions.WGPU;

namespace Silk.NET.WebGPU.Extensions.Disposal
{
    public unsafe class WebGPUDisposal
    {
        // ReSharper disable once InconsistentNaming
        private readonly WebGPU webGpu;

        private Dawn.Dawn dawn;
        private Wgpu      wgpu;

        public WebGPUDisposal(WebGPU webGpu)
        {
            this.webGpu = webGpu;

            webGpu.TryGetDeviceExtension(null, out dawn);
            webGpu.TryGetDeviceExtension(null, out wgpu);
        }

        public void Dispose(TextureView* textureView)
        {
            wgpu?.TextureViewDrop(textureView);
            dawn?.TextureViewRelease(textureView);
        }

        public void Dispose(ShaderModule* shaderModule)
        {
            wgpu?.ShaderModuleDrop(shaderModule);
            dawn?.ShaderModuleRelease(shaderModule);
        }

        public void Dispose(RenderPipeline* renderPipeline)
        {
            wgpu?.RenderPipelineDrop(renderPipeline);
            dawn?.RenderPipelineRelease(renderPipeline);
        }

        public void Dispose(RenderBundle* renderBundle)
        {
            wgpu?.RenderBundleDrop(renderBundle);
            dawn?.RenderBundleRelease(renderBundle);
        }

        public void Dispose(PipelineLayout* pipelineLayout)
        {
            wgpu?.PipelineLayoutDrop(pipelineLayout);
            dawn?.PipelineLayoutRelease(pipelineLayout);
        }

        public void Dispose(Device* device)
        {
            wgpu?.DeviceDrop(device);
            dawn?.DeviceRelease(device);
        }

        public void Dispose(CommandEncoder* commandEncoder)
        {
            wgpu?.CommandEncoderDrop(commandEncoder);
            dawn?.CommandEncoderRelease(commandEncoder);
        }

        public void Dispose(CommandBuffer* commandBuffer)
        {
            wgpu?.CommandBufferDrop(commandBuffer);
            dawn?.CommandBufferRelease(commandBuffer);
        }

        public void Dispose(ComputePipeline* computePipeline)
        {
            wgpu?.ComputePipelineDrop(computePipeline);
            dawn?.ComputePipelineRelease(computePipeline);
        }
        
        public void Dispose(Adapter* adapter)
        {
            wgpu?.AdapterDrop(adapter);
            dawn?.AdapterRelease(adapter);
        }
        
        public void Dispose(BindGroup* bindGroup)
        {
            wgpu?.BindGroupDrop(bindGroup);
            dawn?.BindGroupRelease(bindGroup);
        }
        
        public void Dispose(BindGroupLayout* bindGroupLayout)
        {
            wgpu?.BindGroupLayoutDrop(bindGroupLayout);
            dawn?.BindGroupLayoutRelease(bindGroupLayout);
        }
        
        public void Dispose(Buffer* buffer)
        {
            wgpu?.BufferDrop(buffer);
            dawn?.BufferRelease(buffer);
        }
        
        public void Dispose(Surface* surface)
        {
            wgpu?.SurfaceDrop(surface);
            dawn?.SurfaceRelease(surface);
        }

        public void Dispose(Texture* texture)
        {
            wgpu?.TextureDrop(texture);
            dawn?.TextureRelease(texture);
        }

        public void Dispose(Sampler* sampler)
        {
            wgpu?.SamplerDrop(sampler);
            dawn?.SamplerRelease(sampler);
        }

        public void Dispose(QuerySet* querySet)
        {
            wgpu?.QuerySetDrop(querySet);
            dawn?.QuerySetRelease(querySet);
        }
    }
}
