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
    internal class XrExtensionLoader : LibraryLoader
    {
        private readonly Instance? _instance;
        private readonly XR _base;

        public XrExtensionLoader(Instance? instance, XR @base)
        {
            _instance = instance;
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
                _base.GetInstanceProcAddr(_instance.GetValueOrDefault(), functionName, ref Unsafe.As<IntPtr, FuncPtr>(ref ret));
                ret = ret == default ? _base.Library.LoadFunction(functionName) : ret;
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
