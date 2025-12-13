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

namespace Silk.NET.OpenXR.Extensions.KHR
{
    public static class KhrExtendedStructNameLengthsOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result StructureTypeToString2(this KhrExtendedStructNameLengths thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] StructureType value, [Count(Computed = "XR_MAX_STRUCTURE_NAME_SIZE_EXTENDED_KHR")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.StructureTypeToString2(instance, value, ref buffer.GetPinnableReference());
        }

    }
}

