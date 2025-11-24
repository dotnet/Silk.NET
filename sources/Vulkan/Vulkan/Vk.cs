using System.Reflection;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.Vulkan;

public partial class Vk
{
    public const string ErrMultipleInstanceSingleObject =
        "CurrentInstance cannot be changed once set, use another API object for additional instances. For more "
        + "info, see https://dotnet.github.io/Silk.NET/docs/v3/silk.net/static-vs-instance-bindings";

    public const string ErrMultipleDeviceSingleObject =
        "CurrentDevice cannot be changed once set, use another API object for additional devices. For more "
        + "info, see https://dotnet.github.io/Silk.NET/docs/v3/silk.net/static-vs-instance-bindings";

    static Vk()
    {
        LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());
        LoaderInterface.RegisterAlternativeName("vulkan", "vulkan-1");
        LoaderInterface.RegisterAlternativeName("vulkan", "MoltenVK");
    }

    public unsafe partial class DllImport
    {
        public static partial Result CreateInstance(InstanceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, InstanceHandle* pInstance)
            => CreateInstanceInternal(pCreateInfo, pAllocator, pInstance);

        public static partial Result CreateDevice(PhysicalDeviceHandle physicalDevice, DeviceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, DeviceHandle* pDevice)
            => CreateDeviceInternal(physicalDevice, pCreateInfo, pAllocator, pDevice);
    }

    public partial class StaticWrapper<T>
    {
        public InstanceHandle CurrentInstance
        {
            get;
            set
            {
                if (field == value)
                {
                    return;
                }

                if (field != nullptr)
                {
                    throw new InvalidOperationException(ErrMultipleInstanceSingleObject);
                }

                field = value;
            }
        }

        public DeviceHandle CurrentDevice
        {
            get;
            set
            {
                if (field == value)
                {
                    return;
                }

                if (field != nullptr)
                {
                    throw new InvalidOperationException(ErrMultipleDeviceSingleObject);
                }

                field = value;
            }
        }

        public IVk Clone() => new StaticWrapper<T>();
    }

    public partial class ThisThread
    {
        private static partial IVk ContextFactory() => Create();
    }

    public InstanceHandle CurrentInstance
    {
        get;
        set
        {
            if (field == value)
            {
                return;
            }

            if (field != nullptr)
            {
                throw new InvalidOperationException(ErrMultipleInstanceSingleObject);
            }

            field = value;
        }
    }

    public DeviceHandle CurrentDevice
    {
        get;
        set
        {
            if (field == value)
            {
                return;
            }

            if (field != nullptr)
            {
                throw new InvalidOperationException(ErrMultipleDeviceSingleObject);
            }

            field = value;
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

    unsafe Result IVk.CreateDevice(PhysicalDeviceHandle physicalDevice, DeviceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, DeviceHandle* pDevice)
    {
        var result = CreateDeviceInternal(physicalDevice, pCreateInfo, pAllocator, pDevice);
        if (result == Result.Success)
        {
            CurrentDevice = *pDevice;
        }

        return result;
    }

    unsafe Result IVk.CreateInstance(InstanceCreateInfo* pCreateInfo, AllocationCallbacks* pAllocator, InstanceHandle* pInstance)
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
                return (delegate* unmanaged<DeviceHandle, sbyte*, void*>)&GetDeviceProcAddr;
            }

            if (functionName == "vkGetInstanceProcAddr")
            {
                return (delegate* unmanaged<InstanceHandle, sbyte*, void*>)&GetInstanceProcAddr;
            }

            void* ptr = Ivk.GetDeviceProcAddr(Vk.CurrentDevice, functionName);
            if (ptr != null)
            {
                return ptr;
            }

            ptr = Ivk.GetInstanceProcAddr(Vk.CurrentInstance, functionName);
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
