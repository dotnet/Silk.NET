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
            return LibraryLoader<CL>.Load(new OpenCLLibraryNameContainer());
=======
             return new CL(new DefaultNativeContext(new OpenCLLibraryNameContainer().GetLibraryName()));
>>>>>>> 2.0
        }

        public bool TryGetExtension<T>(out T ext)
            where T : NativeExtension<CL>
        {
<<<<<<< HEAD
            ext = LibraryLoader<CL>.Load<T>(this);
            return ext != null;
=======
            ext = IsExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? (T)Activator.CreateInstance(typeof(T), Context)
                : null;
             return ext != null;
>>>>>>> 2.0
        }

        public override bool IsExtensionPresent(string extension)
        {
            return true; // idk opencl doesn't define a default way for extension loading,
                         // nor is one ever defined on the internet so just assume that it's all good
        }
    }
}

