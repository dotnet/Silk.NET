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
        public static Allegro GetApi()
        {
             return LibraryActivator.CreateInstance<Allegro>(new AllegroLibraryNameContainer().GetLibraryName());
        }

        public override bool IsExtensionPresent(string extension) => false;
    }
}

