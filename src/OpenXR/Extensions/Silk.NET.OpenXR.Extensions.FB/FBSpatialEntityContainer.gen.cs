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
    [Extension("XR_FB_spatial_entity_container")]
    public unsafe partial class FBSpatialEntityContainer : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_spatial_entity_container";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceContainerFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpaceContainerFB([Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] SpaceContainerFB* spaceContainerOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceContainerFB", Convention = CallingConvention.Winapi)]
        public partial Result GetSpaceContainerFB([Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] ref SpaceContainerFB spaceContainerOutput);

        public FBSpatialEntityContainer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

