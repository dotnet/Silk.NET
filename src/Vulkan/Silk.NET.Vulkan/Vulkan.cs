using System;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public partial class Vulkan
    {
        public static Vulkan GetApi()
        {
             return LibraryLoader<Vulkan>.Load(new VulkanLibraryNameContainer());
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<Vulkan>
        {
             ext = LibraryLoader<Vulkan>.Load<T>(this);
             return ext != null;
        }

        public override bool IsExtensionPresent(string extension)
        {
            throw new NotImplementedException();
        }
    }
}

