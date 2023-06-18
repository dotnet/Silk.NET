// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

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
        protected override nint CoreLoadNativeLibrary(string name) => BaseLoader.LoadNativeLibrary(name);
        
        /// <inheritdoc />
        protected override void CoreFreeNativeLibrary(nint handle) => BaseLoader.FreeNativeLibrary(handle);
        
        /// <inheritdoc />
        protected override unsafe nint CoreLoadFunctionPointer(nint library, string symbolName)
        {
            nint sym = default;
            try
            {
                sym = BaseLoader.LoadFunctionPointer(library, symbolName);
                if (sym != 0)
                {
                    return sym;
                }
            }
            catch
            {
                // do nothing, just move on.
            }

            fixed (byte* symbolBytes = Encoding.UTF8.GetBytes(symbolName))
            {
                OpenXR.GetInstanceProcAddr(default, symbolBytes, (PfnVoidFunction*) &sym);

                if (sym != default)
                {
                    return sym;
                }

                if (OpenXR.CurrentInstance.HasValue)
                {
                    OpenXR.GetInstanceProcAddr
                        (OpenXR.CurrentInstance.Value, symbolBytes, (PfnVoidFunction*) &sym);
                    if (sym != default)
                    {
                        return sym;
                    }
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
