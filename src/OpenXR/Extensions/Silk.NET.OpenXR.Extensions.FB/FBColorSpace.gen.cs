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

namespace Silk.NET.OpenXR.Extensions.FB
{
    [Extension("XR_FB_color_space")]
    public unsafe partial class FBColorSpace : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_color_space";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateColorSpacesFB")]
        public unsafe partial Result EnumerateColorSpacesFB([Count(Count = 0)] Session session, [Count(Count = 0)] uint colorSpaceCapacityInput, [Count(Count = 0)] uint* colorSpaceCountOutput, [Count(Computed = "colorSpaceCapacityInput")] ColorSpaceFB* colorSpaces);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateColorSpacesFB")]
        public unsafe partial Result EnumerateColorSpacesFB([Count(Count = 0)] Session session, [Count(Count = 0)] uint colorSpaceCapacityInput, [Count(Count = 0)] uint* colorSpaceCountOutput, [Count(Computed = "colorSpaceCapacityInput")] ref ColorSpaceFB colorSpaces);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateColorSpacesFB")]
        public unsafe partial Result EnumerateColorSpacesFB([Count(Count = 0)] Session session, [Count(Count = 0)] uint colorSpaceCapacityInput, [Count(Count = 0)] ref uint colorSpaceCountOutput, [Count(Computed = "colorSpaceCapacityInput")] ColorSpaceFB* colorSpaces);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateColorSpacesFB")]
        public partial Result EnumerateColorSpacesFB([Count(Count = 0)] Session session, [Count(Count = 0)] uint colorSpaceCapacityInput, [Count(Count = 0)] ref uint colorSpaceCountOutput, [Count(Computed = "colorSpaceCapacityInput")] ref ColorSpaceFB colorSpaces);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetColorSpaceFB")]
        public partial Result SetColorSpaceFB([Count(Count = 0)] Session session, [Count(Count = 0)] ColorSpaceFB colorspace);

        public FBColorSpace(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

