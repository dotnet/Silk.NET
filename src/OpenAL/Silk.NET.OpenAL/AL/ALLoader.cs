// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Ultz.SuperInvoke;
using Ultz.SuperInvoke.Loader;
namespace Silk.NET.OpenAL
{
    public class ALLoader : LibraryLoader
    {
        private abstract class InternalAL : NativeApiContainer
        {
            [NativeApi(EntryPoint = "alcGetProcAddress")]
            public abstract unsafe IntPtr GetProcAddress(Device* device, string proc);
            [NativeApi(EntryPoint = "alGetProcAddress")]
            public abstract IntPtr GetProcAddress(string proc);

            public InternalAL(ref NativeApiContext ctx) : base(ref ctx)
            {
            }
        }

        private static InternalAL _al = LibraryActivator.CreateInstance<InternalAL>
        (
            new OpenALLibraryNameContainer().GetLibraryName()
        );

        public ALContext Alc { get; internal set; }
        protected LibraryLoader UnderlyingLoader { get; } = GetPlatformDefaultLoader();
        protected override IntPtr CoreLoadNativeLibrary(string name) => UnderlyingLoader.LoadNativeLibrary(name);
        protected override void CoreFreeNativeLibrary(IntPtr handle) => UnderlyingLoader.FreeNativeLibrary(handle);

        protected override unsafe IntPtr CoreLoadFunctionPointer(IntPtr library, string symbolName)
        {
            var sym = IntPtr.Zero;
            try
            {
                sym = UnderlyingLoader.LoadFunctionPointer(library, symbolName);
            }
            catch
            {
                // do nothing
            }

            if (sym != IntPtr.Zero)
            {
                return sym;
            }

            if (Alc is null)
            {
                sym = _al.GetProcAddress(symbolName);

                if (sym != IntPtr.Zero)
                {
                    return sym;
                }
            }
            else
            {
                sym = _al.GetProcAddress(Alc.GetContextsDevice(Alc.GetCurrentContext()), symbolName);

                if (sym != IntPtr.Zero)
                {
                    return sym;
                }
            }

            throw new EntryPointNotFoundException();
        }
    }
}
