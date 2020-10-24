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
    [Extension("XR_KHR_visibility_mask")]
    public unsafe partial class KhrVisibilityMask : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_visibility_mask";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVisibilityMaskKHR")]
        public unsafe partial Result GetVisibilityMask([Count(Count = 0)] Session session, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewIndex, [Count(Count = 0)] VisibilityMaskTypeKHR visibilityMaskType, [Count(Count = 0)] VisibilityMaskKHR* visibilityMask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetVisibilityMaskKHR")]
        public partial Result GetVisibilityMask([Count(Count = 0)] Session session, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewIndex, [Count(Count = 0)] VisibilityMaskTypeKHR visibilityMaskType, [Count(Count = 0)] ref VisibilityMaskKHR visibilityMask);

        public KhrVisibilityMask(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

