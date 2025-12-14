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

namespace Silk.NET.OpenXR.Extensions.ANDROID
{
    [Extension("XR_ANDROID_anchor_sharing_export")]
    public unsafe partial class AndroidAnchorSharingExport : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ANDROID_anchor_sharing_export";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrShareAnchorANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ShareAnchor([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AnchorSharingInfoANDROID* sharingInfo, [Count(Count = 0)] AnchorSharingTokenANDROID* anchorToken);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrShareAnchorANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ShareAnchor([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AnchorSharingInfoANDROID* sharingInfo, [Count(Count = 0)] ref AnchorSharingTokenANDROID anchorToken);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrShareAnchorANDROID", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ShareAnchor([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AnchorSharingInfoANDROID sharingInfo, [Count(Count = 0)] AnchorSharingTokenANDROID* anchorToken);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrShareAnchorANDROID", Convention = CallingConvention.Winapi)]
        public partial Result ShareAnchor([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AnchorSharingInfoANDROID sharingInfo, [Count(Count = 0)] ref AnchorSharingTokenANDROID anchorToken);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnshareAnchorANDROID", Convention = CallingConvention.Winapi)]
        public partial Result UnshareAnchor([Count(Count = 0)] Session session, [Count(Count = 0)] Space anchor);

        public AndroidAnchorSharingExport(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

