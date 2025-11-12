using System.Reflection;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.Vulkan;

public partial class Vk
{
    static Vk()
    {
        LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
        LoaderInterface.RegisterAlternativeName("vulkan", "vulkan-1");
        LoaderInterface.RegisterAlternativeName("vulkan", "MoltenVK");
    }

    public unsafe partial class DllImport
    {
        public static partial Result CreateInstance(InstanceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, InstanceTHandle* pInstance)
            => CreateInstanceInternal(pCreateInfo, pAllocator, pInstance);

        public static partial Result CreateDevice(PhysicalDeviceTHandle physicalDevice, DeviceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, DeviceTHandle* pDevice)
            => CreateDeviceInternal(physicalDevice, pCreateInfo, pAllocator, pDevice);
    }

    // TODO: Clean this up and make this more similar to how the OpenAL bindings work
    private InstanceTHandle? _currentInstance;
    public InstanceTHandle? CurrentInstance
    {
        get => _currentInstance;
        set
        {
            if (_currentInstance != null && _currentInstance != value)
                throw new InvalidOperationException(
                    "CurrentInstance cannot be changed once set, use another API object for additional devices. For more "
                    + "info, see https://dotnet.github.io/Silk.NET/docs/v3/silk.net/static-vs-instance-bindings"
                );
            _currentInstance = value;
        }
    }

    private DeviceTHandle? _currentDevice;
    public DeviceTHandle? CurrentDevice
    {
        get => _currentDevice;
        set
        {
            if (_currentDevice != null && _currentDevice != value)
                throw new InvalidOperationException(
                    "CurrentDevice cannot be changed once set, use another API object for additional devices. For more "
                    + "info, see https://dotnet.github.io/Silk.NET/docs/v3/silk.net/static-vs-instance-bindings"
                );
            _currentDevice = value;
        }
    }

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

    unsafe Result IVk.CreateDevice(PhysicalDeviceTHandle physicalDevice, DeviceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, DeviceTHandle* pDevice)
    {
        var result = CreateDeviceInternal(physicalDevice, pCreateInfo, pAllocator, pDevice);
        if (result == Result.Success)
        {
            CurrentDevice = *pDevice;
        }

        return result;
    }

    unsafe Result IVk.CreateInstance(InstanceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, InstanceTHandle* pInstance)
    {
        var result = CreateInstanceInternal(pCreateInfo, pAllocator, pInstance);
        if (result == Result.Success)
        {
            CurrentInstance = *pInstance;
        }

        return result;
    }

    private class NativeContext : INativeContext
    {
        public Vk Vk { get; set; } = null!;
        private IVk Ivk => Vk;

        public unsafe void* LoadFunction(string functionName, string libraryNameHint)
        {
            if (functionName == "vkGetDeviceProcAddr")
            {
                return (delegate* unmanaged<DeviceTHandle, sbyte*, void*>)&GetDeviceProcAddr;
            }

            if (functionName == "vkGetInstanceProcAddr")
            {
                return (delegate* unmanaged<InstanceTHandle, sbyte*, void*>)&GetInstanceProcAddr;
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
        private static unsafe void* GetDeviceProcAddr(DeviceTHandle device, sbyte* pName)
        {
            return DllImport.GetDeviceProcAddr(device, pName);
        }

        [UnmanagedCallersOnly]
        private static unsafe void* GetInstanceProcAddr(InstanceTHandle instance, sbyte* pName)
        {
            return DllImport.GetInstanceProcAddr(instance, pName);
        }

        public void Dispose() {}
    }
}
