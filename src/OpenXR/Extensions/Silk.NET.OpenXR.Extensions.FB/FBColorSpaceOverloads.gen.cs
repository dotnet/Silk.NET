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
    public static class FBColorSpaceOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateColorSpacesFB(this FBColorSpace thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint colorSpaceCapacityInput, [Count(Count = 0)] uint* colorSpaceCountOutput, [Count(Computed = "colorSpaceCapacityInput")] Span<ColorSpaceFB> colorSpaces)
        {
            // SpanOverloader
            return thisApi.EnumerateColorSpacesFB(session, colorSpaceCapacityInput, colorSpaceCountOutput, ref colorSpaces.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateColorSpacesFB(this FBColorSpace thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint colorSpaceCapacityInput, [Count(Count = 0)] Span<uint> colorSpaceCountOutput, [Count(Computed = "colorSpaceCapacityInput")] ColorSpaceFB* colorSpaces)
        {
            // SpanOverloader
            return thisApi.EnumerateColorSpacesFB(session, colorSpaceCapacityInput, ref colorSpaceCountOutput.GetPinnableReference(), colorSpaces);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateColorSpacesFB(this FBColorSpace thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint colorSpaceCapacityInput, [Count(Count = 0)] Span<uint> colorSpaceCountOutput, [Count(Computed = "colorSpaceCapacityInput")] Span<ColorSpaceFB> colorSpaces)
        {
            // SpanOverloader
            return thisApi.EnumerateColorSpacesFB(session, colorSpaceCapacityInput, ref colorSpaceCountOutput.GetPinnableReference(), ref colorSpaces.GetPinnableReference());
        }

    }
}

