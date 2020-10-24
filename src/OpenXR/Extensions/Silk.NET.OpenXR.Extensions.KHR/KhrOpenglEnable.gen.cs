// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_opengl_enable")]
    public unsafe partial class KhrOpenglEnable : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_opengl_enable";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetOpenGLGraphicsRequirementsKHR")]
        public unsafe partial Result GetOpenGlgraphicsRequirements([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] GraphicsRequirementsOpenGLKHR* graphicsRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetOpenGLGraphicsRequirementsKHR")]
        public partial Result GetOpenGlgraphicsRequirements([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref GraphicsRequirementsOpenGLKHR graphicsRequirements);

        public KhrOpenglEnable(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

