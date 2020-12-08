// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

