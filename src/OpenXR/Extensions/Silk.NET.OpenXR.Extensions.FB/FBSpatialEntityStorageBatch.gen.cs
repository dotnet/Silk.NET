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
    [Extension("XR_FB_spatial_entity_storage_batch")]
    public unsafe partial class FBSpatialEntityStorageBatch : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_spatial_entity_storage_batch";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSaveSpaceListFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SaveSpaceListFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceListSaveInfoFB* info, [Count(Count = 0)] ulong* requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSaveSpaceListFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SaveSpaceListFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceListSaveInfoFB* info, [Count(Count = 0)] ref ulong requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSaveSpaceListFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SaveSpaceListFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpaceListSaveInfoFB info, [Count(Count = 0)] ulong* requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSaveSpaceListFB", Convention = CallingConvention.Winapi)]
        public partial Result SaveSpaceListFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpaceListSaveInfoFB info, [Count(Count = 0)] ref ulong requestId);

        public FBSpatialEntityStorageBatch(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

