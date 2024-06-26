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
    [Extension("XR_FB_spatial_entity_storage")]
    public unsafe partial class FBSpatialEntityStorage : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_spatial_entity_storage";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEraseSpaceFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EraseSpaceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceEraseInfoFB* info, [Count(Count = 0)] ulong* requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEraseSpaceFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EraseSpaceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceEraseInfoFB* info, [Count(Count = 0)] ref ulong requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEraseSpaceFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EraseSpaceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpaceEraseInfoFB info, [Count(Count = 0)] ulong* requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEraseSpaceFB", Convention = CallingConvention.Winapi)]
        public partial Result EraseSpaceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpaceEraseInfoFB info, [Count(Count = 0)] ref ulong requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSaveSpaceFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SaveSpaceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceSaveInfoFB* info, [Count(Count = 0)] ulong* requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSaveSpaceFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SaveSpaceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceSaveInfoFB* info, [Count(Count = 0)] ref ulong requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSaveSpaceFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SaveSpaceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpaceSaveInfoFB info, [Count(Count = 0)] ulong* requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSaveSpaceFB", Convention = CallingConvention.Winapi)]
        public partial Result SaveSpaceFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpaceSaveInfoFB info, [Count(Count = 0)] ref ulong requestId);

        public FBSpatialEntityStorage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

