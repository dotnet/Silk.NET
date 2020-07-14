// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.CompilerServices;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke.Loader;

namespace Silk.NET.OpenXR
{
    /// <summary>
    /// Library loader for the Vulkan API.
    /// </summary>
    public class XrLoader : LibraryLoader
    {
        /// <summary>
        /// The Vulkan instance.
        /// </summary>
        public XR OpenXR { get; internal set; }
        
        /// <summary>
        /// The base library loader.
        /// </summary>
        public LibraryLoader BaseLoader { get; }
        
        /// <summary>
        /// Create a new Vulkan loader.
        /// </summary>
        /// <param name="defaultLoader">The default loader to use.</param>
        public XrLoader(LibraryLoader defaultLoader)
        {
            BaseLoader = defaultLoader;
            OpenXR = null;
        }

        /// <inheritdoc />
        protected override IntPtr CoreLoadNativeLibrary(string name) => BaseLoader.LoadNativeLibrary(name);
        
        /// <inheritdoc />
        protected override void CoreFreeNativeLibrary(IntPtr handle) => BaseLoader.FreeNativeLibrary(handle);
        
        /// <inheritdoc />
        protected override IntPtr CoreLoadFunctionPointer(IntPtr library, string symbolName)
        {
            IntPtr sym = default;
            try
            {
                sym = BaseLoader.LoadFunctionPointer(library, symbolName);
                if (sym != IntPtr.Zero)
                {
                    return sym;
                }
            }
            catch
            {
                // do nothing, just move on.
            }

            OpenXR.GetInstanceProcAddr(default, symbolName, ref Unsafe.As<IntPtr, FuncPtr>(ref sym));
            if (sym != default)
            {
                return sym;
            }

            if (OpenXR.CurrentInstance.HasValue)
            {
                OpenXR.GetInstanceProcAddr
                    (OpenXR.CurrentInstance.Value, symbolName, ref Unsafe.As<IntPtr, FuncPtr>(ref sym));
                if (sym != IntPtr.Zero)
                {
                    return sym;
                }
            }
            
            throw new EntryPointNotFoundException
            (
                $"Entry point \"{symbolName}\" not found. Note that instance extensions must be enabled in order to "+
                "load symbols correctly."
            );
        }
    }
}
