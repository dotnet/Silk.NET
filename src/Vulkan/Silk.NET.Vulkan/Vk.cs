using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;
using LibraryLoader = Ultz.SuperInvoke.Loader.LibraryLoader;

namespace Silk.NET.Vulkan
{
    public partial class Vk
    {
        private VkExtensionLoaderSource _extensionLoaders;
        private readonly Dictionary<IntPtr, List<string>> _extensions = new Dictionary<IntPtr, List<string>>();
        public Instance? CurrentInstance { get; set; }
        public Device? CurrentDevice { get; set; }
        public static Version32 Version10 => new Version32(1, 0, 0);
        public static Version32 Version11 => new Version32(1, 1, 0);
        public static Version32 Version12 => new Version32(1, 2, 0);

        public static Version32 MakeVersion
            (uint major, uint minor, uint patch = 0) => new Version32(major, minor, patch);

        public static Vk GetApi()
        {
            var sym = new VkLoader(LibraryLoader.GetPlatformDefaultLoader());
            var ret = LibraryLoader<Vk>.Load(new VulkanLibraryNameContainer(), sym);
            sym.Vulkan = ret;
            ret._extensionLoaders = new VkExtensionLoaderSource(ret);
            return ret;
        }

        [Obsolete
        (
            "This method depends on the CurrentInstance property. " +
            "You should defer usage of these APIs where possible. " +
            "They will be removed in Silk.NET 2.0."
        )]
        public static Vk GetApi(InstanceCreateInfo info) => GetApi(ref info);
        public static Vk GetApi(InstanceCreateInfo info, out Instance instance) => GetApi(ref info, out instance);

        [Obsolete
        (
            "This method depends on the CurrentInstance property. " +
            "You should defer usage of these APIs where possible. " +
            "They will be removed in Silk.NET 2.0."
        )]
        public static unsafe Vk GetApi(ref InstanceCreateInfo info)
        {
            var api = GetApi(ref info, out var instance);
            api.CurrentInstance = instance;
            return api;
        }

        public static unsafe Vk GetApi(ref InstanceCreateInfo info, out Instance instance)
        {
            var sym = new VkLoader(LibraryLoader.GetPlatformDefaultLoader());
            var ret = LibraryLoader<Vk>.Load(new VulkanLibraryNameContainer(), sym);
            sym.Vulkan = ret;
            fixed (InstanceCreateInfo* infoPtr = &info)
            {
                fixed (Instance* instancePtr = &instance)
                {
                    ret.CreateInstance(infoPtr, null, instancePtr);
                }
            }

            return ret;
        }

        [Obsolete
        (
            "This method depends on the CurrentInstance property. " +
            "You should defer usage of these APIs where possible. " +
            "They will be removed in Silk.NET 2.0."
        )]
        public static Vk GetApi(ref InstanceCreateInfo info, ref AllocationCallbacks callbacks)
        {
            var api = GetApi(ref info, ref callbacks, out var instance);
            api.CurrentInstance = instance;
            return api;
        }

        public static Vk GetApi(ref InstanceCreateInfo info, ref AllocationCallbacks callbacks, out Instance instance)
        {
            var sym = new VkLoader(LibraryLoader.GetPlatformDefaultLoader());
            var ret = LibraryLoader<Vk>.Load(new VulkanLibraryNameContainer(), sym);
            sym.Vulkan = ret;
            ret.CreateInstance(ref info, ref callbacks, out instance);
            return ret;
        }

        [Obsolete
        (
            "This method has been deprecated in favour of the more explicit TryGetInstanceExtension and " +
            "TryGetDeviceExtension methods. This is because this method currently depends on the CurrentInstance " +
            "and CurrentDevice property, which are now both obsolete and pending removal along with this method."
        )]
        public bool TryGetExtension<T>(out T ext)
            where T : NativeExtension<Vk>
        {
            ext = LibraryLoader<Vk>.Load<T>(this);
            return ext != null;
        }

        /// <summary>
        /// Attempts to load the given instance extension.
        /// </summary>
        /// <param name="instance">The instance to load the extension from.</param>
        /// <param name="ext">The loaded instance extension, or null if load failed.</param>
        /// <typeparam name="T">The instance extension to load.</typeparam>
        /// <remarks>
        /// This function doesn't check that the extension is enabled - you will get an error later on if you attempt
        /// to call an extension function from an extension that isn't loaded.
        /// </remarks>
        /// <returns>Whether the extension is available and loaded.</returns>
        public bool TryGetInstanceExtension<T>(Instance instance, out T ext) where T : NativeExtension<Vk> =>
            !((ext = IsInstanceExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? LibraryActivator.CreateInstance<T>
                    (SearchPaths.GetLibraryName(), _extensionLoaders.Get(instance, null))
                : null) is null);

        /// <summary>
        /// Attempts to load the given device extension.
        /// </summary>
        /// <param name="instance">The instance to load the extension from.</param>
        /// <param name="device">The device to load the extension from.</param>
        /// <param name="ext">The loaded device extension, or null if load failed.</param>
        /// <typeparam name="T">The device extension to load.</typeparam>
        /// <remarks>
        /// This function doesn't check that the extension is enabled - you will get an error later on if you attempt
        /// to call an extension function from an extension that isn't loaded.
        /// </remarks>
        /// <returns>Whether the extension is available and loaded.</returns>
        public bool TryGetDeviceExtension<T>
            (Instance instance, Device device, out T ext) where T : NativeExtension<Vk> =>
            !((ext = IsDeviceExtensionPresent(instance, ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? LibraryActivator.CreateInstance<T>
                    (SearchPaths.GetLibraryName(), _extensionLoaders.Get(instance, device))
                : null) is null);

        /// <inheritdoc />
        [Obsolete
        (
            "This method has been deprecated in favour of the more explicit IsInstanceExtensionPresent and " +
            "IsDeviceExtensionPresent methods. This is because this method currently depends on the CurrentInstance " +
            "and CurrentDevice property, which are now both obsolete and pending removal along with this method."
        )]
        public override bool IsExtensionPresent(string extension)
        {
            return (!_extensions.ContainsKey(CurrentDevice?.Handle ?? IntPtr.Zero)
                ? _extensions[CurrentDevice?.Handle ?? IntPtr.Zero] = GetExtensions(CurrentInstance, null)
                : _extensions[CurrentDevice?.Handle ?? IntPtr.Zero]).Contains(extension);
        }

        private List<string> _cachedInstanceExtensions = new List<string>();
        private Dictionary<IntPtr, List<string>> _cachedDeviceExtensions = new Dictionary<IntPtr, List<string>>();

        /// <summary>
        /// Checks whether the given instance extension is available.
        /// </summary>
        /// <param name="extension">The instance extension name.</param>
        /// <returns>Whether the instance extension is available.</returns>
        public unsafe bool IsInstanceExtensionPresent(string extension)
        {
            if (_cachedInstanceExtensions.Count == 0)
            {
                var extProperties = stackalloc ExtensionProperties[128];
                Add(_cachedInstanceExtensions, extProperties);
            }

            return _cachedInstanceExtensions.Contains(extension);
        }

        /// <summary>
        /// Checks whether the given device extension is available on any physical devices.
        /// </summary>
        /// <param name="instance">The Vulkan instance.</param>
        /// <param name="extension">The extension to check for.</param>
        /// <returns>Whether the device extension is available.</returns>
        public bool IsDeviceExtensionPresent(Instance instance, string extension)
            => IsDeviceExtensionPresent(instance, extension, out _);

        /// <summary>
        /// Checks whether the given device extension is available on the given physical device.
        /// </summary>
        /// <param name="device">The physical device.</param>
        /// <param name="extension">The extension to check for.</param>
        /// <returns>Whether the device extension is available.</returns>
        public unsafe bool IsDeviceExtensionPresent(PhysicalDevice device, string extension)
        {
            List<string> list;
            if (!_cachedDeviceExtensions.ContainsKey(device.Handle))
            {
                var extProperties = stackalloc ExtensionProperties[128];
                _cachedDeviceExtensions.Add(device.Handle, list = Add(device, new List<string>(), extProperties));
            }
            else
            {
                list = _cachedDeviceExtensions[device.Handle];
            }

            return list.Contains(extension);
        }

        /// <summary>
        /// Checks whether the given device extension is available, and returns the first physical device that provides
        /// it.
        /// </summary>
        /// <param name="instance">The Vulkan instance to use.</param>
        /// <param name="extension">The extension to check for.</param>
        /// <param name="device">The first physical device that provides the extension.</param>
        /// <returns>Whether the device extension is available.</returns>
        public unsafe bool IsDeviceExtensionPresent(Instance instance, string extension, out PhysicalDevice device)
        {
            var physicalDeviceCount = 0u;
            EnumeratePhysicalDevices(instance, &physicalDeviceCount, null);
            var physicalDevices = stackalloc PhysicalDevice[(int) physicalDeviceCount];
            EnumeratePhysicalDevices(instance, &physicalDeviceCount, physicalDevices);

            for (var i = 0; i < physicalDeviceCount; i++)
            {
                var physicalDevice = physicalDevices[i];
                if (IsDeviceExtensionPresent(physicalDevice, extension))
                {
                    device = physicalDevice;
                    return true;
                }
            }

            device = default;
            return false;
        }

        /// <summary>
        /// Clears all cached extension information, so that the next time extension-related functions are called the
        /// cached extension information is refreshed.
        /// </summary>
        public void PurgeExtensionCache()
        {
            _extensions.Clear();
            _cachedInstanceExtensions.Clear();
            _cachedDeviceExtensions.Clear();
        }

        private unsafe List<string> GetExtensions(Instance? instance, PhysicalDevice? device)
        {
            var l = new List<string>();
            var props = stackalloc ExtensionProperties[128];

            if (instance.HasValue)
            {
                if (!device.HasValue)
                {
                    var physicalDeviceCount = 0u;
                    EnumeratePhysicalDevices(instance.Value, &physicalDeviceCount, null);
                    var physicalDevices = stackalloc PhysicalDevice[(int) physicalDeviceCount];
                    EnumeratePhysicalDevices(instance.Value, &physicalDeviceCount, physicalDevices);

                    for (var i = 0; i < physicalDeviceCount; i++)
                    {
                        var physicalDevice = physicalDevices[i];
                        Add(physicalDevice, l, props);
                    }
                }
                else
                {
                    Add(device.Value, l, props);
                }
            }

            return l.Distinct().ToList();
        }

        private unsafe void Add(ICollection<string> l, ExtensionProperties* props)
        {
            var result = Result.Incomplete;
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
        }

        private unsafe List<string> Add(PhysicalDevice physicalDevice, List<string> l, ExtensionProperties* props)
        {
            var result = Result.Incomplete;
            while (result == Result.Incomplete)
            {
                var deviceExtPropertiesCount = 128u;
                result = EnumerateDeviceExtensionProperties
                    (physicalDevice, (byte*) 0, &deviceExtPropertiesCount, props);
                if (result == Result.Success || result == Result.Incomplete)
                {
                    for (var j = 0; j < deviceExtPropertiesCount; j++)
                    {
                        l.Add(Marshal.PtrToStringAnsi((IntPtr) props[j].ExtensionName));
                    }
                }
            }

            return l;
        }
    }
}
