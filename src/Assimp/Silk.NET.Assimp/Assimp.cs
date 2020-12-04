using System;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    public partial class Assimp
    {
        public static Assimp GetApi()
        {
             return new Assimp(CreateDefaultContext(new AssimpLibraryNameContainer().GetLibraryName()));
        }

        public override bool IsExtensionPresent(string extension) => IsExtensionSupported(extension) == 1;
    }
}

