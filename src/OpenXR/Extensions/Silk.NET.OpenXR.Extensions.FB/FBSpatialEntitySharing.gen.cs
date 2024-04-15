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
    [Extension("XR_FB_spatial_entity_sharing")]
    public unsafe partial class FBSpatialEntitySharing : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_spatial_entity_sharing";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrShareSpacesFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ShareSpacesFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceShareInfoFB* info, [Count(Count = 0)] ulong* requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrShareSpacesFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ShareSpacesFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceShareInfoFB* info, [Count(Count = 0)] ref ulong requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrShareSpacesFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ShareSpacesFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpaceShareInfoFB info, [Count(Count = 0)] ulong* requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrShareSpacesFB", Convention = CallingConvention.Winapi)]
        public partial Result ShareSpacesFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpaceShareInfoFB info, [Count(Count = 0)] ref ulong requestId);

        public FBSpatialEntitySharing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

