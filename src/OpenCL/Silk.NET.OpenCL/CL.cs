using System;
using Microsoft.Extensions.DependencyModel;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenCL
{
    public partial class CL
    {
        public static CL GetApi()
        {
<<<<<<< HEAD
             return new CL(CreateDefaultContext(new OpenCLLibraryNameContainer().GetLibraryName()));
=======
            return LibraryLoader<CL>.Load(new OpenCLLibraryNameContainer());
>>>>>>> master
        }

        public bool TryGetExtension<T>(out T ext)
            where T : NativeExtension<CL>
        {
<<<<<<< HEAD
            ext = IsExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? (T)Activator.CreateInstance(typeof(T), Context)
                : null;
             return ext != null;
=======
            ext = LibraryLoader<CL>.Load<T>(this);
            return ext != null;
>>>>>>> master
        }

        public override bool IsExtensionPresent(string extension)
        {
            return true; // idk opencl doesn't define a default way for extension loading,
                         // nor is one ever defined on the internet so just assume that it's all good
        }
    }
}

