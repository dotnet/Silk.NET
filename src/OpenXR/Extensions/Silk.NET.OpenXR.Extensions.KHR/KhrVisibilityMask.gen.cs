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
    [Extension("XR_KHR_visibility_mask")]
    public unsafe partial class KhrVisibilityMask : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_visibility_mask";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVisibilityMaskKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVisibilityMask([Count(Count = 0)] Session session, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewIndex, [Count(Count = 0)] VisibilityMaskTypeKHR visibilityMaskType, [Count(Count = 0)] VisibilityMaskKHR* visibilityMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVisibilityMaskKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetVisibilityMask([Count(Count = 0)] Session session, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewIndex, [Count(Count = 0)] VisibilityMaskTypeKHR visibilityMaskType, [Count(Count = 0)] ref VisibilityMaskKHR visibilityMask);

        public KhrVisibilityMask(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

