using System;
using Silk.NET.WebGPU.Extensions.WGPU;

namespace Silk.NET.WebGPU.Extensions.Disposal
{
    public unsafe class Disposal
    {
        // ReSharper disable once InconsistentNaming
        private readonly WebGPU webGpu;

        private Dawn.Dawn dawn;
        private Wgpu      wgpu;
        
        public Disposal(WebGPU webGpu)
        {
            this.webGpu = webGpu;

            webGpu.TryGetDeviceExtension(null, out dawn);
            webGpu.TryGetDeviceExtension(null, out wgpu);
        }

        public void Dispose(TextureView* textureView)
        {
            wgpu?.TextureViewDrop(textureView);
            dawn?.TextureViewRelease((Dawn.TextureView*) textureView);
        }
    }
}
