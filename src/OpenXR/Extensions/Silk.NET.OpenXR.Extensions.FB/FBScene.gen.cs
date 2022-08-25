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
    [Extension("XR_FB_scene")]
    public unsafe partial class FBScene : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_scene";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceBoundary2DFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpaceBoundary2Dfb([Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] Boundary2DFB* boundary2DOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceBoundary2DFB", Convention = CallingConvention.Winapi)]
        public partial Result GetSpaceBoundary2Dfb([Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] ref Boundary2DFB boundary2DOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceBoundingBox2DFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpaceBoundingBox2Dfb([Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] Rect2Df* boundingBox2DOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceBoundingBox2DFB", Convention = CallingConvention.Winapi)]
        public partial Result GetSpaceBoundingBox2Dfb([Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] ref Rect2Df boundingBox2DOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceBoundingBox3DFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpaceBoundingBox3Dfb([Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] Rect3DfFB* boundingBox3DOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceBoundingBox3DFB", Convention = CallingConvention.Winapi)]
        public partial Result GetSpaceBoundingBox3Dfb([Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] ref Rect3DfFB boundingBox3DOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceRoomLayoutFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpaceRoomLayoutFB([Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] RoomLayoutFB* roomLayoutOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceRoomLayoutFB", Convention = CallingConvention.Winapi)]
        public partial Result GetSpaceRoomLayoutFB([Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] ref RoomLayoutFB roomLayoutOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceSemanticLabelsFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpaceSemanticLabelsFB([Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] SemanticLabelsFB* semanticLabelsOutput);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceSemanticLabelsFB", Convention = CallingConvention.Winapi)]
        public partial Result GetSpaceSemanticLabelsFB([Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] ref SemanticLabelsFB semanticLabelsOutput);

        public FBScene(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

