using System.Reflection;
using AdvancedDLSupport;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Native;

namespace Silk.NET.Core.Loader
{
    public static class LibraryLoader
    {
        private const ImplementationOptions Options = ImplementationOptions.UseIndirectCalls |
                                                      ImplementationOptions.UseLazyBinding |
                                                      ImplementationOptions.SuppressSecurity |
                                                      ImplementationOptions.EnableOptimizations;

        private static NativeLibraryBuilder _builder;

        static LibraryLoader()
        {
            _builder = new NativeLibraryBuilder();
        }

        public static T1 Load<T1>(SearchPathContainer nameContainer) where T1 : NativeAPI
        {
            return _builder.ActivateClass<T1>(nameContainer.GetLibraryName());
        }

        public static T1 Load<T1, T2>(T2 baseApi) where T1 : NativeExtension<T2> where T2 : NativeAPI
        {
            return baseApi.IsExtensionPresent(GetExtensionAttribute(typeof(T1)).Name)
                ? _builder.ActivateClass<T1>(baseApi.SearchPaths.GetLibraryName())
                : null;
        }

        private static ExtensionAttribute GetExtensionAttribute(MemberInfo type)
        {
            return type.GetCustomAttribute<ExtensionAttribute>();
        }
    }
}
