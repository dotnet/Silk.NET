using System;
using System.Diagnostics.CodeAnalysis;
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
             return new CL(CreateDefaultContext(new OpenCLLibraryNameContainer().GetLibraryNames()));
        }

#if NET5_0_OR_GREATER
        public bool TryGetExtension<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] T>(out T ext)
#else
        public bool TryGetExtension<T>(out T ext)
#endif
            where T : NativeExtension<CL>
        {
            ext = IsExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? (T)Activator.CreateInstance(typeof(T), Context)
                : null;
             return ext != null;
        }

        public override bool IsExtensionPresent(string extension)
        {
            return true; // idk opencl doesn't define a default way for extension loading,
                         // nor is one ever defined on the internet so just assume that it's all good
        }
    }
}

