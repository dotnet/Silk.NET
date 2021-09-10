// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using Silk.NET.Core;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.Sdl
{
    internal class SdlVkSurface : IVkSurface
    {
        private readonly SdlView _view;

        public SdlVkSurface(SdlView view)
        {
            _view = view;
        }

        public unsafe VkNonDispatchableHandle Create<T>(VkHandle instance, T* allocator) where T : unmanaged
        {
            VkNonDispatchableHandle ret;
            if (_view.Sdl.VulkanCreateSurface(_view.SdlWindow, instance, &ret) == SdlBool.False)
            {
                throw new PlatformException("Failed to create surface.", _view.Sdl.GetErrorAsException());
            }

            return ret;
        }

        private unsafe byte** _requiredExtensions;

        public unsafe byte** GetRequiredExtensions(out uint count)
        {
            fixed (uint* countPtr = &count)
            {
                if (_view.Sdl.VulkanGetInstanceExtensions(_view.SdlWindow, countPtr, (byte**) 0) == SdlBool.True)
                {
                    if (_requiredExtensions == null)
                    {
                        _requiredExtensions = (byte**) Marshal.AllocHGlobal((nint) (sizeof(byte*) * count));
                    }
                    else
                    {
                        _requiredExtensions = (byte**) Marshal.ReAllocHGlobal
                            ((nint) _requiredExtensions, (nint) (sizeof(byte*) * count));
                    }

                    if (_view.Sdl.VulkanGetInstanceExtensions
                        (_view.SdlWindow, countPtr, _requiredExtensions) == SdlBool.True)
                    {
                        return (byte**) _requiredExtensions;
                    }
                }
            }

            throw new PlatformException(_view.Sdl.GetErrorAsException());
        }
    }
}
