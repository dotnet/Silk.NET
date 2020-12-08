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

namespace Silk.NET.OpenXR.Extensions.KHR
{
    public static class KhrOpenglEsEnableOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetOpenGlesgraphicsRequirements(this KhrOpenglEsEnable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] Span<GraphicsRequirementsOpenGLESKHR> graphicsRequirements)
        {
            // SpanOverloader
            return thisApi.GetOpenGlesgraphicsRequirements(instance, systemId, ref graphicsRequirements.GetPinnableReference());
        }

    }
}

