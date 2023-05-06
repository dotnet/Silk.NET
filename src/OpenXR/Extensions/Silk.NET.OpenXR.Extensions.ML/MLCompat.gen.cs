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

namespace Silk.NET.OpenXR.Extensions.ML
{
    [Extension("XR_ML_compat")]
    public unsafe partial class MLCompat : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ML_compat";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpaceFromCoordinateFrameUIDML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpaceFromCoordinateFrameUidml([Count(Count = 0)] Session session, [Count(Count = 0)] CoordinateSpaceCreateInfoML createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpaceFromCoordinateFrameUIDML", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpaceFromCoordinateFrameUidml([Count(Count = 0)] Session session, [Count(Count = 0)] CoordinateSpaceCreateInfoML createInfo, [Count(Count = 0)] ref Space space);

        public MLCompat(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

