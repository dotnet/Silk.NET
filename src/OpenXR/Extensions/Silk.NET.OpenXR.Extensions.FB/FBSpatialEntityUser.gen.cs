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
    [Extension("XR_FB_spatial_entity_user")]
    public unsafe partial class FBSpatialEntityUser : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_spatial_entity_user";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpaceUserFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpaceUserFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceUserCreateInfoFB* info, [Count(Count = 0)] SpaceUserFB* user);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpaceUserFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpaceUserFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceUserCreateInfoFB* info, [Count(Count = 0)] ref SpaceUserFB user);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpaceUserFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpaceUserFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpaceUserCreateInfoFB info, [Count(Count = 0)] SpaceUserFB* user);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpaceUserFB", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpaceUserFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpaceUserCreateInfoFB info, [Count(Count = 0)] ref SpaceUserFB user);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySpaceUserFB", Convention = CallingConvention.Winapi)]
        public partial Result DestroySpaceUserFB([Count(Count = 0)] SpaceUserFB user);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceUserIdFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpaceUserIdFB([Count(Count = 0)] SpaceUserFB user, [Count(Count = 0)] ulong* userId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceUserIdFB", Convention = CallingConvention.Winapi)]
        public partial Result GetSpaceUserIdFB([Count(Count = 0)] SpaceUserFB user, [Count(Count = 0)] ref ulong userId);

        public FBSpatialEntityUser(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

