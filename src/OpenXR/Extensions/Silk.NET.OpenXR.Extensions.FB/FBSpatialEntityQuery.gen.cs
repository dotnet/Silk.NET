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
    [Extension("XR_FB_spatial_entity_query")]
    public unsafe partial class FBSpatialEntityQuery : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_spatial_entity_query";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySpacesFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySpacesFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceQueryInfoBaseHeaderFB* info, [Count(Count = 0)] ulong* requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySpacesFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySpacesFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceQueryInfoBaseHeaderFB* info, [Count(Count = 0)] ref ulong requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySpacesFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySpacesFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpaceQueryInfoBaseHeaderFB info, [Count(Count = 0)] ulong* requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySpacesFB", Convention = CallingConvention.Winapi)]
        public partial Result QuerySpacesFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpaceQueryInfoBaseHeaderFB info, [Count(Count = 0)] ref ulong requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRetrieveSpaceQueryResultsFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RetrieveSpaceQueryResultsFB([Count(Count = 0)] Session session, [Count(Count = 0)] ulong requestId, [Count(Count = 0)] SpaceQueryResultsFB* results);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRetrieveSpaceQueryResultsFB", Convention = CallingConvention.Winapi)]
        public partial Result RetrieveSpaceQueryResultsFB([Count(Count = 0)] Session session, [Count(Count = 0)] ulong requestId, [Count(Count = 0)] ref SpaceQueryResultsFB results);

        public FBSpatialEntityQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

