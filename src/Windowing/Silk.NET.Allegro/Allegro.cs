using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    public partial class Allegro
    {
        public const int Version = 5;
        public const int SubVersion = 2;
        public const int WipVersion = 6;
        public const int ReleaseNumber = 1;
        public const int VersionInt = Version << 24 | SubVersion << 16 | WipVersion << 8 | ReleaseNumber;
        public static Allegro GetApi()
        {
             return LibraryActivator.CreateInstance<Allegro>(new AllegroLibraryNameContainer().GetLibraryName());
        }

        public override bool IsExtensionPresent(string extension) => false;
        public unsafe bool Init(FuncPtr? atexit = null)
            => InstallSystem(VersionInt, (void*) atexit.GetValueOrDefault().Value);
        
    }
}

