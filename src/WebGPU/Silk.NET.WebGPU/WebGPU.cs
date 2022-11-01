using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using static Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    public partial class WebGPU
    {
        public static WebGPU GetApi()
        {
             return new(CreateDefaultContext(new WebGPULibraryNameContainer().GetLibraryName()));
        }

        [Obsolete("Use TryGetDeviceExtension!")]
        public override bool IsExtensionPresent(string name) 
        {
            throw new NotSupportedException();
        }

        public unsafe bool TryGetDeviceExtension<T>(Device* device, out T ext)
            where T:NativeExtension<WebGPU>
        {
             ext = IsDeviceExtensionPresent(device, GetExtensionAttribute(typeof(T)).Name)
                 ? (T) Activator.CreateInstance(typeof(T), new LamdaNativeContext(str => (nint) this.GetProcAddress(device, str).Handle))
                 : null;
             return ext is not null;
        }

        public unsafe bool IsDeviceExtensionPresent(Device* device, string extension)
        {
            return extension switch
            {
                "wgpu.h" => this.GetProcAddress(device, "wgpuBufferDrop").Handle != null,
                _ => false
            };
        }
    }
}

