// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Ultz.SuperInvoke.Loader;

namespace Silk.NET.Vulkan
{
    internal class VkExtensionLoader : LibraryLoader
    {
        private readonly Instance? _instance;
        private readonly Device? _device;
        private readonly Vk _base;

        public VkExtensionLoader(Instance? instance, Device? device, Vk @base)
        {
            _instance = instance;
            _device = device;
            _base = @base;
        }

        protected override IntPtr CoreLoadNativeLibrary(string name) => _base.Library.Handle;

        protected override void CoreFreeNativeLibrary(IntPtr handle)
        {
            // do nothing
        }

        protected override IntPtr CoreLoadFunctionPointer(IntPtr handle, string functionName)
        {
            IntPtr ret = default;
            try
            {
                ret = _device.HasValue
                    ? _base.GetDeviceProcAddr(_device.Value, functionName).Value
                    : _instance.HasValue
                        ? _base.GetInstanceProcAddr(_instance.Value, functionName).Value
                        : _base.Library.LoadFunction(functionName);
            }
            catch
            {
                // do nothing
            }
            finally
            {
                if (ret == default)
                {
                    throw new EntryPointNotFoundException
                    (
                        $"Entry point \"{functionName}\" not found. Note that instance and device extensions must be " +
                        "enabled in order to load symbols correctly."
                    );
                }
            }

            return ret;
        }
    }
}
