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

namespace Silk.NET.DirectStorage
{
    public static class DStorageOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1148, Column 16 in C:\\Users\\perks\\AppData\\Local\\Temp\\<...>\\native\\include\\dstorage.h")]
        public static unsafe int SetConfiguration(this DStorage thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Configuration> configuration)
        {
            // SpanOverloader
            return thisApi.SetConfiguration(in configuration.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1158, Column 16 in C:\\Users\\perks\\AppData\\Local\\Temp\\<...>\\native\\include\\dstorage.h")]
        public static unsafe int GetFactory(this DStorage thisApi, Span<Guid> riid, void** ppv)
        {
            // SpanOverloader
            return thisApi.GetFactory(ref riid.GetPinnableReference(), ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1158, Column 16 in C:\\Users\\perks\\AppData\\Local\\Temp\\<...>\\native\\include\\dstorage.h")]
        public static unsafe int GetFactory(this DStorage thisApi, Span<Guid> riid, ref void* ppv)
        {
            // SpanOverloader
            return thisApi.GetFactory(ref riid.GetPinnableReference(), ref ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1173, Column 16 in C:\\Users\\perks\\AppData\\Local\\Temp\\<...>\\native\\include\\dstorage.h")]
        public static unsafe int CreateCompressionCodec(this DStorage thisApi, CompressionFormat format, uint numThreads, Span<Guid> riid, void** ppv)
        {
            // SpanOverloader
            return thisApi.CreateCompressionCodec(format, numThreads, ref riid.GetPinnableReference(), ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1173, Column 16 in C:\\Users\\perks\\AppData\\Local\\Temp\\<...>\\native\\include\\dstorage.h")]
        public static unsafe int CreateCompressionCodec(this DStorage thisApi, CompressionFormat format, uint numThreads, Span<Guid> riid, ref void* ppv)
        {
            // SpanOverloader
            return thisApi.CreateCompressionCodec(format, numThreads, ref riid.GetPinnableReference(), ref ppv);
        }

    }
}

