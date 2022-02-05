// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_opengl_es_enable")]
    public unsafe partial class KhrOpenglEsEnable : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_opengl_es_enable";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetOpenGLESGraphicsRequirementsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetOpenGlesgraphicsRequirements([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] GraphicsRequirementsOpenGLESKHR* graphicsRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetOpenGLESGraphicsRequirementsKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetOpenGlesgraphicsRequirements([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref GraphicsRequirementsOpenGLESKHR graphicsRequirements);

        public KhrOpenglEsEnable(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

