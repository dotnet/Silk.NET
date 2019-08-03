// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using AdvancedDLSupport;
using AdvancedDLSupport.Loaders;

namespace Silk.NET.OpenAL
{
    public class ALLoader : IPlatformLoader
    {
        [NativeSymbols(Prefix = "al")]
        public interface IInternalAL
        {
            IntPtr GetProcAddress(string proc);
        }

        private static IInternalAL _al = NativeLibraryBuilder.Default.ActivateInterface<IInternalAL>
        (
            new OpenALLibraryNameContainer().GetLibraryName()
        );
        
        public static ALLoader Instance { get; } = new ALLoader();
        
        public IntPtr LoadSymbol(IntPtr library, string symbolName)
        {
            return _al.GetProcAddress(symbolName);
        }

        public IntPtr LoadLibrary(string path)
        {
            return IntPtr.Zero;
        }

        public bool CloseLibrary(IntPtr library)
        {
            return true;
        }
    }
}
