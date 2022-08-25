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

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.FB
{
    public static class FBSceneOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpaceBoundary2Dfb(this FBScene thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] Span<Boundary2DFB> boundary2DOutput)
        {
            // SpanOverloader
            return thisApi.GetSpaceBoundary2Dfb(session, space, ref boundary2DOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpaceBoundingBox2Dfb(this FBScene thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] Span<Rect2Df> boundingBox2DOutput)
        {
            // SpanOverloader
            return thisApi.GetSpaceBoundingBox2Dfb(session, space, ref boundingBox2DOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpaceBoundingBox3Dfb(this FBScene thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] Span<Rect3DfFB> boundingBox3DOutput)
        {
            // SpanOverloader
            return thisApi.GetSpaceBoundingBox3Dfb(session, space, ref boundingBox3DOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpaceRoomLayoutFB(this FBScene thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] Span<RoomLayoutFB> roomLayoutOutput)
        {
            // SpanOverloader
            return thisApi.GetSpaceRoomLayoutFB(session, space, ref roomLayoutOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpaceSemanticLabelsFB(this FBScene thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] Space space, [Count(Count = 0)] Span<SemanticLabelsFB> semanticLabelsOutput)
        {
            // SpanOverloader
            return thisApi.GetSpaceSemanticLabelsFB(session, space, ref semanticLabelsOutput.GetPinnableReference());
        }

    }
}

