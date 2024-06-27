using System;
using System.Diagnostics.CodeAnalysis;
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
             return new(CreateDefaultContext(new WebGPULibraryNameContainer().GetLibraryNames()));
        }

        [Obsolete("Use TryGetDeviceExtension!")]
        public override bool IsExtensionPresent(string name) 
        {
            throw new NotSupportedException();
        }

#if NET5_0_OR_GREATER
        public unsafe bool TryGetDeviceExtension<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] T>(Device* device, out T ext)
#else
        public unsafe bool TryGetDeviceExtension<T>(Device* device, out T ext)
#endif
            where T:NativeExtension<WebGPU>
        {
             ext = IsDeviceExtensionPresent(device, GetExtensionAttribute(typeof(T)).Name)
                 ? (T) Activator.CreateInstance(typeof(T), Context) //FIXME: Waiting on upstream wgpu-native fix to implement wgpuGetProcAddress
                 : null;
             return ext is not null;
        }

        public unsafe bool IsDeviceExtensionPresent(Device* device, string extension)
        {
            return extension switch
            {
                //NOTE: Make sure to review these function names when we update Dawn/WGPU!
                "wgpu.h" => Context.TryGetProcAddress("wgpuDevicePoll", out _), //FIXME: Waiting on upstream wgpu-native fix to implement wgpuGetProcAddress
                "dawn-webgpu.h" => Context.TryGetProcAddress("wgpuDeviceTick", out _),
                _ => false
            };
        }
    }
}

