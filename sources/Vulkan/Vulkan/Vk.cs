using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.Vulkan;

public partial class Vk
{
    public static IVk Create()
    {
        var context = new NativeContext();
        var vk = new Vk(context);

        context.Vk = vk;

        return vk;
    }

    public unsafe IVk Clone()
    {
        var context = new NativeContext();
        var vk = new Vk(context);

        context.Vk = vk;

        vk.CurrentInstance = CurrentInstance;
        vk.CurrentDevice = CurrentDevice;
        Array.Copy(_slots, vk._slots, _slots.Length);

        return vk;
    }

    private class NativeContext : INativeContext
    {
        public Vk Vk { get; set; } = null!;
        private IVk Ivk => Vk;

        public unsafe void* LoadFunction(string functionName, string libraryNameHint)
        {
            if (functionName == "vkGetDeviceProcAddr")
            {
                return (delegate* unmanaged<DeviceHandle, sbyte*, void*>)&GetDeviceProcAddr;
            }

            if (functionName == "vkGetInstanceProcAddr")
            {
                return (delegate* unmanaged<InstanceHandle, sbyte*, void*>)&GetInstanceProcAddr;
            }

            void* ptr = Ivk.GetDeviceProcAddr(Vk.CurrentDevice.GetValueOrDefault(), functionName);
            if (ptr != null)
            {
                return ptr;
            }

            ptr = Ivk.GetInstanceProcAddr(Vk.CurrentInstance.GetValueOrDefault(), functionName);
            return ptr;
        }

        [UnmanagedCallersOnly]
        private static unsafe void* GetDeviceProcAddr(DeviceHandle device, sbyte* pName)
        {
            return DllImport.GetDeviceProcAddr(device, pName);
        }

        [UnmanagedCallersOnly]
        private static unsafe void* GetInstanceProcAddr(InstanceHandle instance, sbyte* pName)
        {
            return DllImport.GetInstanceProcAddr(instance, pName);
        }

        public void Dispose() {}
    }
}