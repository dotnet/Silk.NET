using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using LibraryLoader = Ultz.SuperInvoke.Loader.LibraryLoader;

namespace Silk.NET.Vulkan
{
    public partial class Vk
    {
        private VkLoader _extLoader;
        private Dictionary<IntPtr, List<string>> _extensions = new Dictionary<IntPtr, List<string>>();
        public Instance? CurrentInstance { get; set; }
        public Device? CurrentDevice { get; set; }
        public static Version32 Version10 => new Version32(1, 0, 0);
        public static Version32 Version11 => new Version32(1, 1, 0);
        public static Version32 Version12 => new Version32(1, 2, 0);
        public static Version32 MakeVersion(uint major, uint minor, uint patch = 0) => new Version32(major, minor, patch);
        public static Vk GetApi()
        {
            var sym = new VkLoader(LibraryLoader.GetPlatformDefaultLoader());
            var ret = LibraryLoader<Vk>.Load(new VulkanLibraryNameContainer(), sym);
            sym.Vulkan = ret;
            return ret;
        }

        public static Vk GetApi(InstanceCreateInfo info) => GetApi(ref info);
        public static unsafe Vk GetApi(ref InstanceCreateInfo info)
        {
            var sym = new VkLoader(LibraryLoader.GetPlatformDefaultLoader());
            var ret = LibraryLoader<Vk>.Load(new VulkanLibraryNameContainer(), sym);
            sym.Vulkan = ret;
            Instance instance;
            fixed (InstanceCreateInfo* infoPtr = &info)
            {
                ret.CreateInstance(infoPtr, null, &instance);
            }

            ret.CurrentInstance = instance;
            return ret;
        }

        public static Vk GetApi(ref InstanceCreateInfo info, ref AllocationCallbacks callbacks)
        {
            var sym = new VkLoader(LibraryLoader.GetPlatformDefaultLoader());
            var ret = LibraryLoader<Vk>.Load(new VulkanLibraryNameContainer(), sym);
            sym.Vulkan = ret;
            ret.CreateInstance(ref info, ref callbacks, out var instance);
            ret.CurrentInstance = instance;
            return ret;
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<Vk>
        {
            ext = LibraryLoader<Vk>.Load<T>(this);
            return ext != null;
        }

        public override bool IsExtensionPresent(string extension)
        {
            return (!_extensions.ContainsKey
                (CurrentDevice?.Handle ?? IntPtr.Zero)
                ? _extensions[CurrentDevice?.Handle ?? IntPtr.Zero] = GetExtensions()
                : _extensions[CurrentDevice?.Handle ?? IntPtr.Zero]).Contains(extension);
        }

        public void PurgeExtensionCache() => _extensions.Clear();

        private unsafe List<string> GetExtensions()
        {
            var l = new List<string>();
            var result = Result.Incomplete;
            var props = stackalloc ExtensionProperties[128];
            while (result == Result.Incomplete)
            {
                var instanceExtPropertiesCount = 128u;
                result = EnumerateInstanceExtensionProperties((byte*) 0, &instanceExtPropertiesCount, props);
                if (result == Result.Success || result == Result.Incomplete)
                {
                    for (var i = 0; i < instanceExtPropertiesCount; i++)
                    {
                        l.Add(Marshal.PtrToStringAnsi((IntPtr) props[i].ExtensionName));
                    }
                }
            }

            if (CurrentInstance.HasValue)
            {
                var physicalDeviceCount = 0u;
                EnumeratePhysicalDevices(CurrentInstance.Value, &physicalDeviceCount, (PhysicalDevice*)null);
                var physicalDevices = stackalloc PhysicalDevice[(int) physicalDeviceCount];
                EnumeratePhysicalDevices(CurrentInstance.Value, &physicalDeviceCount, physicalDevices);

                for (var i = 0; i < physicalDeviceCount; i++)
                {
                    var device = physicalDevices[i];
                    result = Result.Incomplete;
                    while (result == Result.Incomplete)
                    {
                        var deviceExtPropertiesCount = 128u;
                        result = EnumerateDeviceExtensionProperties
                            (device, (byte*) 0, &deviceExtPropertiesCount, props);
                        if (result == Result.Success || result == Result.Incomplete)
                        {
                            for (var j = 0; j < deviceExtPropertiesCount; j++)
                            {
                                l.Add(Marshal.PtrToStringAnsi((IntPtr) props[j].ExtensionName));
                            }
                        }
                    }
                }
            }

            return l.Distinct().ToList();
        }
    }
}

