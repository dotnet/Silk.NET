using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using Microsoft.Extensions.DependencyModel;
using Silk.NET.Core;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Maths;

namespace Silk.NET.OpenGLES
{
    public partial class GL
    {
        public static GL GetApi(IGLContextSource contextSource) => GetApi
        (
            contextSource.GLContext ?? throw new InvalidOperationException
                ("The given IGLContextSource is not configured with a context.")
        );

        public static GL GetApi(IGLContext ctx) => GetApi((INativeContext) ctx);
        public static GL GetApi(Func<string, nint> getProcAddress) => GetApi(new LamdaNativeContext(getProcAddress));

        public static GL GetApi(INativeContext ctx) => new GL(ctx);

        public bool TryGetExtension<T>(out T ext)
            where T : NativeExtension<GL>
        {
            ext = IsExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? (T)Activator.CreateInstance(typeof(T), Context)
                : null;
            return ext != null;
        }

        private List<string> _extensions;
        public override unsafe bool IsExtensionPresent(string extension)
        {
            int numExtensions;
            GetInteger(GLEnum.NumExtensions, &numExtensions);
            _extensions ??= Enumerable.Range(0, numExtensions)
                .Select(x => SilkMarshal.PtrToString((nint) GetString(GLEnum.Extensions, (uint) x)))
                .ToList();

            return _extensions.Contains("GL_" + (extension.StartsWith("GL_") ? extension.Substring(3) : extension));
        }
    }
}
