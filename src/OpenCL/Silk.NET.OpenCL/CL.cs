using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenCL
{
    public partial class CL
    {
        public static CL GetApi()
        {
             return LibraryActivator.CreateInstance<CL>(new OpenCLLibraryNameContainer().GetLibraryName());
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<CL>
        {
            ext = IsExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? LibraryActivator.CreateInstance<T>(Library)
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

