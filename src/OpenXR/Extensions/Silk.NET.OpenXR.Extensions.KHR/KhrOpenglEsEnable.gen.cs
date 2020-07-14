// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_opengl_es_enable")]
    public abstract unsafe partial class KhrOpenglEsEnable : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_opengl_es_enable";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetOpenGLESGraphicsRequirementsKHR")]
        public abstract unsafe Result GetOpenGlesgraphicsRequirements([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] GraphicsRequirementsOpenGLESKHR* graphicsRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetOpenGLESGraphicsRequirementsKHR")]
        public abstract Result GetOpenGlesgraphicsRequirements([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref GraphicsRequirementsOpenGLESKHR graphicsRequirements);

        public KhrOpenglEsEnable(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

