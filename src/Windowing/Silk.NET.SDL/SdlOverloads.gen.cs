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

namespace Silk.NET.SDL
{
    public static class SdlOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 446, Column 31 in SDL_stdinc.h")]
        public static unsafe void* Realloc<T0>(this Sdl thisApi, Span<T0> mem, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Realloc(ref mem.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 30 in SDL_stdinc.h")]
        public static unsafe void Free<T0>(this Sdl thisApi, Span<T0> mem) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.Free(ref mem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, PfnMallocFunc* malloc_func, PfnCallocFunc* calloc_func, PfnReallocFunc* realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(malloc_func, calloc_func, realloc_func, ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, PfnMallocFunc* malloc_func, PfnCallocFunc* calloc_func, Span<PfnReallocFunc> realloc_func, PfnFreeFunc* free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(malloc_func, calloc_func, ref realloc_func.GetPinnableReference(), free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, PfnMallocFunc* malloc_func, PfnCallocFunc* calloc_func, Span<PfnReallocFunc> realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(malloc_func, calloc_func, ref realloc_func.GetPinnableReference(), ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, PfnMallocFunc* malloc_func, Span<PfnCallocFunc> calloc_func, PfnReallocFunc* realloc_func, PfnFreeFunc* free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(malloc_func, ref calloc_func.GetPinnableReference(), realloc_func, free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, PfnMallocFunc* malloc_func, Span<PfnCallocFunc> calloc_func, PfnReallocFunc* realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(malloc_func, ref calloc_func.GetPinnableReference(), realloc_func, ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, PfnMallocFunc* malloc_func, Span<PfnCallocFunc> calloc_func, Span<PfnReallocFunc> realloc_func, PfnFreeFunc* free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(malloc_func, ref calloc_func.GetPinnableReference(), ref realloc_func.GetPinnableReference(), free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, PfnMallocFunc* malloc_func, Span<PfnCallocFunc> calloc_func, Span<PfnReallocFunc> realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(malloc_func, ref calloc_func.GetPinnableReference(), ref realloc_func.GetPinnableReference(), ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, PfnCallocFunc* calloc_func, PfnReallocFunc* realloc_func, PfnFreeFunc* free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(ref malloc_func.GetPinnableReference(), calloc_func, realloc_func, free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, PfnCallocFunc* calloc_func, PfnReallocFunc* realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(ref malloc_func.GetPinnableReference(), calloc_func, realloc_func, ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, PfnCallocFunc* calloc_func, Span<PfnReallocFunc> realloc_func, PfnFreeFunc* free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(ref malloc_func.GetPinnableReference(), calloc_func, ref realloc_func.GetPinnableReference(), free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, PfnCallocFunc* calloc_func, Span<PfnReallocFunc> realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(ref malloc_func.GetPinnableReference(), calloc_func, ref realloc_func.GetPinnableReference(), ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, Span<PfnCallocFunc> calloc_func, PfnReallocFunc* realloc_func, PfnFreeFunc* free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(ref malloc_func.GetPinnableReference(), ref calloc_func.GetPinnableReference(), realloc_func, free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, Span<PfnCallocFunc> calloc_func, PfnReallocFunc* realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(ref malloc_func.GetPinnableReference(), ref calloc_func.GetPinnableReference(), realloc_func, ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, Span<PfnCallocFunc> calloc_func, Span<PfnReallocFunc> realloc_func, PfnFreeFunc* free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(ref malloc_func.GetPinnableReference(), ref calloc_func.GetPinnableReference(), ref realloc_func.GetPinnableReference(), free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 459, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetOriginalMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, Span<PfnCallocFunc> calloc_func, Span<PfnReallocFunc> realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetOriginalMemoryFunctions(ref malloc_func.GetPinnableReference(), ref calloc_func.GetPinnableReference(), ref realloc_func.GetPinnableReference(), ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, PfnMallocFunc* malloc_func, PfnCallocFunc* calloc_func, PfnReallocFunc* realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(malloc_func, calloc_func, realloc_func, ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, PfnMallocFunc* malloc_func, PfnCallocFunc* calloc_func, Span<PfnReallocFunc> realloc_func, PfnFreeFunc* free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(malloc_func, calloc_func, ref realloc_func.GetPinnableReference(), free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, PfnMallocFunc* malloc_func, PfnCallocFunc* calloc_func, Span<PfnReallocFunc> realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(malloc_func, calloc_func, ref realloc_func.GetPinnableReference(), ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, PfnMallocFunc* malloc_func, Span<PfnCallocFunc> calloc_func, PfnReallocFunc* realloc_func, PfnFreeFunc* free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(malloc_func, ref calloc_func.GetPinnableReference(), realloc_func, free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, PfnMallocFunc* malloc_func, Span<PfnCallocFunc> calloc_func, PfnReallocFunc* realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(malloc_func, ref calloc_func.GetPinnableReference(), realloc_func, ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, PfnMallocFunc* malloc_func, Span<PfnCallocFunc> calloc_func, Span<PfnReallocFunc> realloc_func, PfnFreeFunc* free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(malloc_func, ref calloc_func.GetPinnableReference(), ref realloc_func.GetPinnableReference(), free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, PfnMallocFunc* malloc_func, Span<PfnCallocFunc> calloc_func, Span<PfnReallocFunc> realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(malloc_func, ref calloc_func.GetPinnableReference(), ref realloc_func.GetPinnableReference(), ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, PfnCallocFunc* calloc_func, PfnReallocFunc* realloc_func, PfnFreeFunc* free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), calloc_func, realloc_func, free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, PfnCallocFunc* calloc_func, PfnReallocFunc* realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), calloc_func, realloc_func, ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, PfnCallocFunc* calloc_func, Span<PfnReallocFunc> realloc_func, PfnFreeFunc* free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), calloc_func, ref realloc_func.GetPinnableReference(), free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, PfnCallocFunc* calloc_func, Span<PfnReallocFunc> realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), calloc_func, ref realloc_func.GetPinnableReference(), ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, Span<PfnCallocFunc> calloc_func, PfnReallocFunc* realloc_func, PfnFreeFunc* free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), ref calloc_func.GetPinnableReference(), realloc_func, free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, Span<PfnCallocFunc> calloc_func, PfnReallocFunc* realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), ref calloc_func.GetPinnableReference(), realloc_func, ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, Span<PfnCallocFunc> calloc_func, Span<PfnReallocFunc> realloc_func, PfnFreeFunc* free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), ref calloc_func.GetPinnableReference(), ref realloc_func.GetPinnableReference(), free_func);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 469, Column 30 in SDL_stdinc.h")]
        public static unsafe void GetMemoryFunctions(this Sdl thisApi, Span<PfnMallocFunc> malloc_func, Span<PfnCallocFunc> calloc_func, Span<PfnReallocFunc> realloc_func, Span<PfnFreeFunc> free_func)
        {
            // SpanOverloader
            thisApi.GetMemoryFunctions(ref malloc_func.GetPinnableReference(), ref calloc_func.GetPinnableReference(), ref realloc_func.GetPinnableReference(), ref free_func.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 491, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Getenv(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.Getenv(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 29 in SDL_stdinc.h")]
        public static unsafe int Setenv(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value, int overwrite)
        {
            // SpanOverloader
            return thisApi.Setenv(name, in value.GetPinnableReference(), overwrite);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 29 in SDL_stdinc.h")]
        public static unsafe int Setenv(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value, int overwrite)
        {
            // SpanOverloader
            return thisApi.Setenv(in name.GetPinnableReference(), value, overwrite);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 29 in SDL_stdinc.h")]
        public static unsafe int Setenv(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value, int overwrite)
        {
            // SpanOverloader
            return thisApi.Setenv(in name.GetPinnableReference(), in value.GetPinnableReference(), overwrite);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 29 in SDL_stdinc.h")]
        public static unsafe int Setenv(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, int overwrite)
        {
            // SpanOverloader
            return thisApi.Setenv(in name.GetPinnableReference(), value, overwrite);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 492, Column 29 in SDL_stdinc.h")]
        public static unsafe int Setenv(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value, int overwrite)
        {
            // SpanOverloader
            return thisApi.Setenv(name, in value.GetPinnableReference(), overwrite);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 30 in SDL_stdinc.h")]
        public static unsafe void Qsort<T0>(this Sdl thisApi, Span<T0> @base, nuint nmemb, nuint size, PfnVvVvI compare) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.Qsort(ref @base.GetPinnableReference(), nmemb, size, compare);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 495, Column 32 in SDL_stdinc.h")]
        public static unsafe void* Bsearch<T0>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> @base, nuint nmemb, nuint size, PfnVvVvI compare) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Bsearch(key, in @base.GetPinnableReference(), nmemb, size, compare);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 495, Column 32 in SDL_stdinc.h")]
        public static unsafe void* Bsearch<T0>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* @base, nuint nmemb, nuint size, PfnVvVvI compare) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Bsearch(in key.GetPinnableReference(), @base, nmemb, size, compare);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 495, Column 32 in SDL_stdinc.h")]
        public static unsafe void* Bsearch<T0, T1>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> @base, nuint nmemb, nuint size, PfnVvVvI compare) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.Bsearch(in key.GetPinnableReference(), in @base.GetPinnableReference(), nmemb, size, compare);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 519, Column 32 in SDL_stdinc.h")]
        public static unsafe ushort Crc16<T0>(this Sdl thisApi, ushort crc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Crc16(crc, in data.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 520, Column 32 in SDL_stdinc.h")]
        public static unsafe uint Crc32<T0>(this Sdl thisApi, uint crc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Crc32(crc, in data.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 522, Column 31 in SDL_stdinc.h")]
        public static unsafe void* Memset<T0>(this Sdl thisApi, Span<T0> dst, int c, nuint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memset(ref dst.GetPinnableReference(), c, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 562, Column 31 in SDL_stdinc.h")]
        public static unsafe void* Memcpy<T0>(this Sdl thisApi, void* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> src, nuint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memcpy(dst, in src.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 562, Column 31 in SDL_stdinc.h")]
        public static unsafe void* Memcpy<T0>(this Sdl thisApi, Span<T0> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src, nuint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memcpy(ref dst.GetPinnableReference(), src, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 562, Column 31 in SDL_stdinc.h")]
        public static unsafe void* Memcpy<T0, T1>(this Sdl thisApi, Span<T0> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> src, nuint len) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memcpy(ref dst.GetPinnableReference(), in src.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 564, Column 31 in SDL_stdinc.h")]
        public static unsafe void* Memmove<T0>(this Sdl thisApi, void* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> src, nuint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memmove(dst, in src.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 564, Column 31 in SDL_stdinc.h")]
        public static unsafe void* Memmove<T0>(this Sdl thisApi, Span<T0> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src, nuint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memmove(ref dst.GetPinnableReference(), src, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 564, Column 31 in SDL_stdinc.h")]
        public static unsafe void* Memmove<T0, T1>(this Sdl thisApi, Span<T0> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> src, nuint len) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memmove(ref dst.GetPinnableReference(), in src.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 29 in SDL_stdinc.h")]
        public static unsafe int Memcmp<T0>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> s2, nuint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memcmp(s1, in s2.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 29 in SDL_stdinc.h")]
        public static unsafe int Memcmp<T0>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* s2, nuint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memcmp(in s1.GetPinnableReference(), s2, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 29 in SDL_stdinc.h")]
        public static unsafe int Memcmp<T0, T1>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> s2, nuint len) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.Memcmp(in s1.GetPinnableReference(), in s2.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 567, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Wcslen(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wstr)
        {
            // SpanOverloader
            return thisApi.Wcslen(in wstr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 568, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Wcslcpy(this Sdl thisApi, char* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcpy(dst, in src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 568, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Wcslcpy(this Sdl thisApi, Span<char> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcpy(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 568, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Wcslcpy(this Sdl thisApi, Span<char> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcpy(ref dst.GetPinnableReference(), in src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 568, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Wcslcpy(this Sdl thisApi, Span<char> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcpy(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 568, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Wcslcpy(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcpy(dst, in src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 569, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Wcslcat(this Sdl thisApi, char* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcat(dst, in src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 569, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Wcslcat(this Sdl thisApi, Span<char> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcat(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 569, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Wcslcat(this Sdl thisApi, Span<char> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcat(ref dst.GetPinnableReference(), in src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 569, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Wcslcat(this Sdl thisApi, Span<char> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcat(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 569, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Wcslcat(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcslcat(dst, in src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 570, Column 34 in SDL_stdinc.h")]
        public static unsafe char* Wcsdup(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wstr)
        {
            // SpanOverloader
            return thisApi.Wcsdup(in wstr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 34 in SDL_stdinc.h")]
        public static unsafe char* Wcsstr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> needle)
        {
            // SpanOverloader
            return thisApi.Wcsstr(haystack, in needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 34 in SDL_stdinc.h")]
        public static unsafe char* Wcsstr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* needle)
        {
            // SpanOverloader
            return thisApi.Wcsstr(in haystack.GetPinnableReference(), needle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 34 in SDL_stdinc.h")]
        public static unsafe char* Wcsstr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> needle)
        {
            // SpanOverloader
            return thisApi.Wcsstr(in haystack.GetPinnableReference(), in needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 34 in SDL_stdinc.h")]
        public static unsafe char* Wcsstr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string needle)
        {
            // SpanOverloader
            return thisApi.Wcsstr(in haystack.GetPinnableReference(), needle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 34 in SDL_stdinc.h")]
        public static unsafe char* Wcsstr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> needle)
        {
            // SpanOverloader
            return thisApi.Wcsstr(haystack, in needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 573, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcscmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str2)
        {
            // SpanOverloader
            return thisApi.Wcscmp(str1, in str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 573, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcscmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str2)
        {
            // SpanOverloader
            return thisApi.Wcscmp(in str1.GetPinnableReference(), str2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 573, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcscmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str2)
        {
            // SpanOverloader
            return thisApi.Wcscmp(in str1.GetPinnableReference(), in str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 573, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcscmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str2)
        {
            // SpanOverloader
            return thisApi.Wcscmp(in str1.GetPinnableReference(), str2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 573, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcscmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str2)
        {
            // SpanOverloader
            return thisApi.Wcscmp(str1, in str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 574, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcsncmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str2, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcsncmp(str1, in str2.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 574, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcsncmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str2, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcsncmp(in str1.GetPinnableReference(), str2, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 574, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcsncmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str2, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcsncmp(in str1.GetPinnableReference(), in str2.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 574, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcsncmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str2, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcsncmp(in str1.GetPinnableReference(), str2, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 574, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcsncmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str2, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Wcsncmp(str1, in str2.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 575, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcscasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str2)
        {
            // SpanOverloader
            return thisApi.Wcscasecmp(str1, in str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 575, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcscasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str2)
        {
            // SpanOverloader
            return thisApi.Wcscasecmp(in str1.GetPinnableReference(), str2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 575, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcscasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str2)
        {
            // SpanOverloader
            return thisApi.Wcscasecmp(in str1.GetPinnableReference(), in str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 575, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcscasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str2)
        {
            // SpanOverloader
            return thisApi.Wcscasecmp(in str1.GetPinnableReference(), str2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 575, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcscasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str2)
        {
            // SpanOverloader
            return thisApi.Wcscasecmp(str1, in str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 576, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcsncasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str2, nuint len)
        {
            // SpanOverloader
            return thisApi.Wcsncasecmp(str1, in str2.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 576, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcsncasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* str2, nuint len)
        {
            // SpanOverloader
            return thisApi.Wcsncasecmp(in str1.GetPinnableReference(), str2, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 576, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcsncasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str2, nuint len)
        {
            // SpanOverloader
            return thisApi.Wcsncasecmp(in str1.GetPinnableReference(), in str2.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 576, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcsncasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str2, nuint len)
        {
            // SpanOverloader
            return thisApi.Wcsncasecmp(in str1.GetPinnableReference(), str2, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 576, Column 29 in SDL_stdinc.h")]
        public static unsafe int Wcsncasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> str2, nuint len)
        {
            // SpanOverloader
            return thisApi.Wcsncasecmp(str1, in str2.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 578, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Strlen(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str)
        {
            // SpanOverloader
            return thisApi.Strlen(in str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 579, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Strlcpy(this Sdl thisApi, byte* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcpy(dst, in src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 579, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Strlcpy(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcpy(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 579, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Strlcpy(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcpy(ref dst.GetPinnableReference(), in src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 579, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Strlcpy(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcpy(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 579, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Strlcpy(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcpy(dst, in src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 580, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Utf8strlcpy(this Sdl thisApi, byte* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, nuint dst_bytes)
        {
            // SpanOverloader
            return thisApi.Utf8strlcpy(dst, in src.GetPinnableReference(), dst_bytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 580, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Utf8strlcpy(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* src, nuint dst_bytes)
        {
            // SpanOverloader
            return thisApi.Utf8strlcpy(ref dst.GetPinnableReference(), src, dst_bytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 580, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Utf8strlcpy(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, nuint dst_bytes)
        {
            // SpanOverloader
            return thisApi.Utf8strlcpy(ref dst.GetPinnableReference(), in src.GetPinnableReference(), dst_bytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 580, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Utf8strlcpy(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string src, nuint dst_bytes)
        {
            // SpanOverloader
            return thisApi.Utf8strlcpy(ref dst.GetPinnableReference(), src, dst_bytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 580, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Utf8strlcpy(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, nuint dst_bytes)
        {
            // SpanOverloader
            return thisApi.Utf8strlcpy(dst, in src.GetPinnableReference(), dst_bytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Strlcat(this Sdl thisApi, byte* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcat(dst, in src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Strlcat(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcat(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Strlcat(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcat(ref dst.GetPinnableReference(), in src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Strlcat(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcat(ref dst.GetPinnableReference(), src, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Strlcat(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strlcat(dst, in src.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 582, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strdup(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str)
        {
            // SpanOverloader
            return thisApi.Strdup(in str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 583, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strrev(this Sdl thisApi, Span<byte> str)
        {
            // SpanOverloader
            return thisApi.Strrev(ref str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 584, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strupr(this Sdl thisApi, Span<byte> str)
        {
            // SpanOverloader
            return thisApi.Strupr(ref str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 585, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strlwr(this Sdl thisApi, Span<byte> str)
        {
            // SpanOverloader
            return thisApi.Strlwr(ref str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 586, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strchr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, int c)
        {
            // SpanOverloader
            return thisApi.Strchr(in str.GetPinnableReference(), c);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 587, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strrchr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, int c)
        {
            // SpanOverloader
            return thisApi.Strrchr(in str.GetPinnableReference(), c);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 588, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strstr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> needle)
        {
            // SpanOverloader
            return thisApi.Strstr(haystack, in needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 588, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strstr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* needle)
        {
            // SpanOverloader
            return thisApi.Strstr(in haystack.GetPinnableReference(), needle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 588, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strstr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> needle)
        {
            // SpanOverloader
            return thisApi.Strstr(in haystack.GetPinnableReference(), in needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 588, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strstr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string needle)
        {
            // SpanOverloader
            return thisApi.Strstr(in haystack.GetPinnableReference(), needle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 588, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strstr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> needle)
        {
            // SpanOverloader
            return thisApi.Strstr(haystack, in needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 589, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strcasestr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> needle)
        {
            // SpanOverloader
            return thisApi.Strcasestr(haystack, in needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 589, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strcasestr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* needle)
        {
            // SpanOverloader
            return thisApi.Strcasestr(in haystack.GetPinnableReference(), needle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 589, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strcasestr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> needle)
        {
            // SpanOverloader
            return thisApi.Strcasestr(in haystack.GetPinnableReference(), in needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 589, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strcasestr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string needle)
        {
            // SpanOverloader
            return thisApi.Strcasestr(in haystack.GetPinnableReference(), needle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 589, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strcasestr(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string haystack, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> needle)
        {
            // SpanOverloader
            return thisApi.Strcasestr(haystack, in needle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, byte* s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> s2, byte** saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(s1, in s2.GetPinnableReference(), saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, byte* s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> s2, ref byte* saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(s1, in s2.GetPinnableReference(), ref saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, Span<byte> s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* s2, byte** saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(ref s1.GetPinnableReference(), s2, saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, Span<byte> s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* s2, ref byte* saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(ref s1.GetPinnableReference(), s2, ref saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, Span<byte> s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> s2, byte** saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(ref s1.GetPinnableReference(), in s2.GetPinnableReference(), saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, Span<byte> s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> s2, ref byte* saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(ref s1.GetPinnableReference(), in s2.GetPinnableReference(), ref saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, Span<byte> s1, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string s2, byte** saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(ref s1.GetPinnableReference(), s2, saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, Span<byte> s1, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string s2, ref byte* saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(ref s1.GetPinnableReference(), s2, ref saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> s2, byte** saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(s1, in s2.GetPinnableReference(), saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Strtokr(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> s2, ref byte* saveptr)
        {
            // SpanOverloader
            return thisApi.Strtokr(s1, in s2.GetPinnableReference(), ref saveptr);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 591, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Utf8strlen(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str)
        {
            // SpanOverloader
            return thisApi.Utf8strlen(in str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 592, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Utf8strnlen(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, nuint bytes)
        {
            // SpanOverloader
            return thisApi.Utf8strnlen(in str.GetPinnableReference(), bytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 594, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Itoa(this Sdl thisApi, int value, Span<byte> str, int radix)
        {
            // SpanOverloader
            return thisApi.Itoa(value, ref str.GetPinnableReference(), radix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 595, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Uitoa(this Sdl thisApi, uint value, Span<byte> str, int radix)
        {
            // SpanOverloader
            return thisApi.Uitoa(value, ref str.GetPinnableReference(), radix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 596, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Ltoa(this Sdl thisApi, int value, Span<byte> str, int radix)
        {
            // SpanOverloader
            return thisApi.Ltoa(value, ref str.GetPinnableReference(), radix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 597, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Ultoa(this Sdl thisApi, uint value, Span<byte> str, int radix)
        {
            // SpanOverloader
            return thisApi.Ultoa(value, ref str.GetPinnableReference(), radix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 598, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Lltoa(this Sdl thisApi, long value, Span<byte> str, int radix)
        {
            // SpanOverloader
            return thisApi.Lltoa(value, ref str.GetPinnableReference(), radix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 599, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* Ulltoa(this Sdl thisApi, ulong value, Span<byte> str, int radix)
        {
            // SpanOverloader
            return thisApi.Ulltoa(value, ref str.GetPinnableReference(), radix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 601, Column 29 in SDL_stdinc.h")]
        public static unsafe int Atoi(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str)
        {
            // SpanOverloader
            return thisApi.Atoi(in str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 602, Column 32 in SDL_stdinc.h")]
        public static unsafe double Atof(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str)
        {
            // SpanOverloader
            return thisApi.Atof(in str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 603, Column 30 in SDL_stdinc.h")]
        public static unsafe int Strtol(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, byte** endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtol(in str.GetPinnableReference(), endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 603, Column 30 in SDL_stdinc.h")]
        public static unsafe int Strtol(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, ref byte* endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtol(in str.GetPinnableReference(), ref endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 604, Column 39 in SDL_stdinc.h")]
        public static unsafe uint Strtoul(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, byte** endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtoul(in str.GetPinnableReference(), endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 604, Column 39 in SDL_stdinc.h")]
        public static unsafe uint Strtoul(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, ref byte* endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtoul(in str.GetPinnableReference(), ref endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 605, Column 32 in SDL_stdinc.h")]
        public static unsafe long Strtoll(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, byte** endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtoll(in str.GetPinnableReference(), endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 605, Column 32 in SDL_stdinc.h")]
        public static unsafe long Strtoll(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, ref byte* endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtoll(in str.GetPinnableReference(), ref endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 32 in SDL_stdinc.h")]
        public static unsafe ulong Strtoull(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, byte** endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtoull(in str.GetPinnableReference(), endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 32 in SDL_stdinc.h")]
        public static unsafe ulong Strtoull(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, ref byte* endp, int @base)
        {
            // SpanOverloader
            return thisApi.Strtoull(in str.GetPinnableReference(), ref endp, @base);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 32 in SDL_stdinc.h")]
        public static unsafe double Strtod(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, byte** endp)
        {
            // SpanOverloader
            return thisApi.Strtod(in str.GetPinnableReference(), endp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 32 in SDL_stdinc.h")]
        public static unsafe double Strtod(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, ref byte* endp)
        {
            // SpanOverloader
            return thisApi.Strtod(in str.GetPinnableReference(), ref endp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 609, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strcmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str2)
        {
            // SpanOverloader
            return thisApi.Strcmp(str1, in str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 609, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strcmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str2)
        {
            // SpanOverloader
            return thisApi.Strcmp(in str1.GetPinnableReference(), str2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 609, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strcmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str2)
        {
            // SpanOverloader
            return thisApi.Strcmp(in str1.GetPinnableReference(), in str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 609, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strcmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str2)
        {
            // SpanOverloader
            return thisApi.Strcmp(in str1.GetPinnableReference(), str2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 609, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strcmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str2)
        {
            // SpanOverloader
            return thisApi.Strcmp(str1, in str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 610, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strncmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str2, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strncmp(str1, in str2.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 610, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strncmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str2, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strncmp(in str1.GetPinnableReference(), str2, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 610, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strncmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str2, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strncmp(in str1.GetPinnableReference(), in str2.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 610, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strncmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str2, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strncmp(in str1.GetPinnableReference(), str2, maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 610, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strncmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str2, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.Strncmp(str1, in str2.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 611, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strcasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str2)
        {
            // SpanOverloader
            return thisApi.Strcasecmp(str1, in str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 611, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strcasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str2)
        {
            // SpanOverloader
            return thisApi.Strcasecmp(in str1.GetPinnableReference(), str2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 611, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strcasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str2)
        {
            // SpanOverloader
            return thisApi.Strcasecmp(in str1.GetPinnableReference(), in str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 611, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strcasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str2)
        {
            // SpanOverloader
            return thisApi.Strcasecmp(in str1.GetPinnableReference(), str2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 611, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strcasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str2)
        {
            // SpanOverloader
            return thisApi.Strcasecmp(str1, in str2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strncasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str2, nuint len)
        {
            // SpanOverloader
            return thisApi.Strncasecmp(str1, in str2.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strncasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str2, nuint len)
        {
            // SpanOverloader
            return thisApi.Strncasecmp(in str1.GetPinnableReference(), str2, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strncasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str2, nuint len)
        {
            // SpanOverloader
            return thisApi.Strncasecmp(in str1.GetPinnableReference(), in str2.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strncasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str1, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str2, nuint len)
        {
            // SpanOverloader
            return thisApi.Strncasecmp(in str1.GetPinnableReference(), str2, len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 29 in SDL_stdinc.h")]
        public static unsafe int Strncasecmp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str2, nuint len)
        {
            // SpanOverloader
            return thisApi.Strncasecmp(str1, in str2.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 614, Column 29 in SDL_stdinc.h")]
        public static unsafe int Sscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            return thisApi.Sscanf(text, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 614, Column 29 in SDL_stdinc.h")]
        public static unsafe int Sscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt)
        {
            // SpanOverloader
            return thisApi.Sscanf(in text.GetPinnableReference(), fmt);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 614, Column 29 in SDL_stdinc.h")]
        public static unsafe int Sscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            return thisApi.Sscanf(in text.GetPinnableReference(), in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 614, Column 29 in SDL_stdinc.h")]
        public static unsafe int Sscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt)
        {
            // SpanOverloader
            return thisApi.Sscanf(in text.GetPinnableReference(), fmt);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 614, Column 29 in SDL_stdinc.h")]
        public static unsafe int Sscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            return thisApi.Sscanf(text, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, in fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* text, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(in text.GetPinnableReference(), fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(in text.GetPinnableReference(), fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(in text.GetPinnableReference(), fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(in text.GetPinnableReference(), in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(in text.GetPinnableReference(), in fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(in text.GetPinnableReference(), in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(in text.GetPinnableReference(), fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(in text.GetPinnableReference(), fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(in text.GetPinnableReference(), fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, in fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string text, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 615, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsscanf(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string text, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsscanf(text, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 616, Column 29 in SDL_stdinc.h")]
        public static unsafe int Snprintf(this Sdl thisApi, byte* text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            return thisApi.Snprintf(text, maxlen, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 616, Column 29 in SDL_stdinc.h")]
        public static unsafe int Snprintf(this Sdl thisApi, Span<byte> text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt)
        {
            // SpanOverloader
            return thisApi.Snprintf(ref text.GetPinnableReference(), maxlen, fmt);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 616, Column 29 in SDL_stdinc.h")]
        public static unsafe int Snprintf(this Sdl thisApi, Span<byte> text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            return thisApi.Snprintf(ref text.GetPinnableReference(), maxlen, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 616, Column 29 in SDL_stdinc.h")]
        public static unsafe int Snprintf(this Sdl thisApi, Span<byte> text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt)
        {
            // SpanOverloader
            return thisApi.Snprintf(ref text.GetPinnableReference(), maxlen, fmt);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 616, Column 29 in SDL_stdinc.h")]
        public static unsafe int Snprintf(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            return thisApi.Snprintf(text, maxlen, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, byte* text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, byte* text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, byte* text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, in fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, byte* text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, byte* text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, in fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, Span<byte> text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(ref text.GetPinnableReference(), maxlen, fmt, ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, in fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vsnprintf(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string text, nuint maxlen, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vsnprintf(text, maxlen, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 618, Column 29 in SDL_stdinc.h")]
        public static unsafe int Asprintf(this Sdl thisApi, byte** strp, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            return thisApi.Asprintf(strp, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 618, Column 29 in SDL_stdinc.h")]
        public static unsafe int Asprintf(this Sdl thisApi, ref byte* strp, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            return thisApi.Asprintf(ref strp, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 619, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vasprintf(this Sdl thisApi, byte** strp, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vasprintf(strp, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 619, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vasprintf(this Sdl thisApi, byte** strp, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vasprintf(strp, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 619, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vasprintf(this Sdl thisApi, byte** strp, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vasprintf(strp, in fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 619, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vasprintf(this Sdl thisApi, byte** strp, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ap)
        {
            // SpanOverloader
            return thisApi.Vasprintf(strp, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 619, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vasprintf(this Sdl thisApi, byte** strp, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vasprintf(strp, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 619, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vasprintf(this Sdl thisApi, ref byte* strp, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vasprintf(ref strp, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 619, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vasprintf(this Sdl thisApi, ref byte* strp, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, byte* ap)
        {
            // SpanOverloader
            return thisApi.Vasprintf(ref strp, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 619, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vasprintf(this Sdl thisApi, ref byte* strp, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vasprintf(ref strp, in fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 619, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vasprintf(this Sdl thisApi, ref byte* strp, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ap)
        {
            // SpanOverloader
            return thisApi.Vasprintf(ref strp, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 619, Column 29 in SDL_stdinc.h")]
        public static unsafe int Vasprintf(this Sdl thisApi, ref byte* strp, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt, Span<byte> ap)
        {
            // SpanOverloader
            return thisApi.Vasprintf(ref strp, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 692, Column 37 in SDL_stdinc.h")]
        public static unsafe Icon* IconvOpen(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromcode)
        {
            // SpanOverloader
            return thisApi.IconvOpen(tocode, in fromcode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 692, Column 37 in SDL_stdinc.h")]
        public static unsafe Icon* IconvOpen(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromcode)
        {
            // SpanOverloader
            return thisApi.IconvOpen(in tocode.GetPinnableReference(), fromcode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 692, Column 37 in SDL_stdinc.h")]
        public static unsafe Icon* IconvOpen(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromcode)
        {
            // SpanOverloader
            return thisApi.IconvOpen(in tocode.GetPinnableReference(), in fromcode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 692, Column 37 in SDL_stdinc.h")]
        public static unsafe Icon* IconvOpen(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromcode)
        {
            // SpanOverloader
            return thisApi.IconvOpen(in tocode.GetPinnableReference(), fromcode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 692, Column 37 in SDL_stdinc.h")]
        public static unsafe Icon* IconvOpen(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromcode)
        {
            // SpanOverloader
            return thisApi.IconvOpen(tocode, in fromcode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 695, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Iconv(this Sdl thisApi, Icon* cd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** inbuf, nuint* inbytesleft, byte** outbuf, Span<nuint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, inbuf, inbytesleft, outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 695, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Iconv(this Sdl thisApi, Icon* cd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** inbuf, nuint* inbytesleft, ref byte* outbuf, Span<nuint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, inbuf, inbytesleft, ref outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 695, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Iconv(this Sdl thisApi, Icon* cd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** inbuf, Span<nuint> inbytesleft, byte** outbuf, nuint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, inbuf, ref inbytesleft.GetPinnableReference(), outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 695, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Iconv(this Sdl thisApi, Icon* cd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** inbuf, Span<nuint> inbytesleft, byte** outbuf, Span<nuint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, inbuf, ref inbytesleft.GetPinnableReference(), outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 695, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Iconv(this Sdl thisApi, Icon* cd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** inbuf, Span<nuint> inbytesleft, ref byte* outbuf, nuint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, inbuf, ref inbytesleft.GetPinnableReference(), ref outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 695, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Iconv(this Sdl thisApi, Icon* cd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** inbuf, Span<nuint> inbytesleft, ref byte* outbuf, Span<nuint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, inbuf, ref inbytesleft.GetPinnableReference(), ref outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 695, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Iconv(this Sdl thisApi, Icon* cd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* inbuf, nuint* inbytesleft, byte** outbuf, Span<nuint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, in inbuf, inbytesleft, outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 695, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Iconv(this Sdl thisApi, Icon* cd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* inbuf, nuint* inbytesleft, ref byte* outbuf, Span<nuint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, in inbuf, inbytesleft, ref outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 695, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Iconv(this Sdl thisApi, Icon* cd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* inbuf, Span<nuint> inbytesleft, byte** outbuf, nuint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, in inbuf, ref inbytesleft.GetPinnableReference(), outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 695, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Iconv(this Sdl thisApi, Icon* cd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* inbuf, Span<nuint> inbytesleft, byte** outbuf, Span<nuint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, in inbuf, ref inbytesleft.GetPinnableReference(), outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 695, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Iconv(this Sdl thisApi, Icon* cd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* inbuf, Span<nuint> inbytesleft, ref byte* outbuf, nuint* outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, in inbuf, ref inbytesleft.GetPinnableReference(), ref outbuf, outbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 695, Column 32 in SDL_stdinc.h")]
        public static unsafe nuint Iconv(this Sdl thisApi, Icon* cd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* inbuf, Span<nuint> inbytesleft, ref byte* outbuf, Span<nuint> outbytesleft)
        {
            // SpanOverloader
            return thisApi.Iconv(cd, in inbuf, ref inbytesleft.GetPinnableReference(), ref outbuf, ref outbytesleft.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, fromcode, in inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, in fromcode.GetPinnableReference(), inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, in fromcode.GetPinnableReference(), in inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, in fromcode.GetPinnableReference(), inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, fromcode, in inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(in tocode.GetPinnableReference(), fromcode, inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(in tocode.GetPinnableReference(), fromcode, in inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(in tocode.GetPinnableReference(), fromcode, inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(in tocode.GetPinnableReference(), in fromcode.GetPinnableReference(), inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(in tocode.GetPinnableReference(), in fromcode.GetPinnableReference(), in inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(in tocode.GetPinnableReference(), in fromcode.GetPinnableReference(), inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(in tocode.GetPinnableReference(), fromcode, inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(in tocode.GetPinnableReference(), fromcode, in inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(in tocode.GetPinnableReference(), fromcode, inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, fromcode, in inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, in fromcode.GetPinnableReference(), inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, in fromcode.GetPinnableReference(), in inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, in fromcode.GetPinnableReference(), inbuf, inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 31 in SDL_stdinc.h")]
        public static unsafe byte* IconvString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string tocode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fromcode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> inbuf, nuint inbytesleft)
        {
            // SpanOverloader
            return thisApi.IconvString(tocode, fromcode, in inbuf.GetPinnableReference(), inbytesleft);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, uint* Rmask, uint* Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, Rmask, Gmask, Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, uint* Rmask, uint* Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, Rmask, Gmask, ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, uint* Rmask, uint* Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, Rmask, Gmask, ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, uint* Rmask, Span<uint> Gmask, uint* Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, Rmask, ref Gmask.GetPinnableReference(), Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, uint* Rmask, Span<uint> Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, Rmask, ref Gmask.GetPinnableReference(), Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, uint* Rmask, Span<uint> Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, Rmask, ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, uint* Rmask, Span<uint> Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, Rmask, ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, uint* Gmask, uint* Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), Gmask, Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, uint* Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), Gmask, Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, uint* Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), Gmask, ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, uint* Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), Gmask, ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, Span<uint> Gmask, uint* Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, Span<uint> Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, Span<uint> Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, int* bpp, Span<uint> Rmask, Span<uint> Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, bpp, ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, uint* Gmask, uint* Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, Gmask, Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, uint* Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, Gmask, Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, uint* Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, Gmask, ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, uint* Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, Gmask, ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, Span<uint> Gmask, uint* Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, ref Gmask.GetPinnableReference(), Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, Span<uint> Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, ref Gmask.GetPinnableReference(), Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, Span<uint> Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, uint* Rmask, Span<uint> Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), Rmask, ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, uint* Gmask, uint* Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), Gmask, Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, uint* Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), Gmask, Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, uint* Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), Gmask, ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, uint* Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), Gmask, ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, Span<uint> Gmask, uint* Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, Span<uint> Gmask, uint* Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), Bmask, ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, Span<uint> Gmask, Span<uint> Bmask, uint* Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 34 in SDL_pixels.h")]
        public static unsafe SdlBool PixelFormatEnumToMasks(this Sdl thisApi, uint format, Span<int> bpp, Span<uint> Rmask, Span<uint> Gmask, Span<uint> Bmask, Span<uint> Amask)
        {
            // SpanOverloader
            return thisApi.PixelFormatEnumToMasks(format, ref bpp.GetPinnableReference(), ref Rmask.GetPinnableReference(), ref Gmask.GetPinnableReference(), ref Bmask.GetPinnableReference(), ref Amask.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 30 in SDL_pixels.h")]
        public static unsafe void FreeFormat(this Sdl thisApi, Span<PixelFormat> format)
        {
            // SpanOverloader
            thisApi.FreeFormat(ref format.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 484, Column 29 in SDL_pixels.h")]
        public static unsafe int SetPixelFormatPalette(this Sdl thisApi, PixelFormat* format, Span<Palette> palette)
        {
            // SpanOverloader
            return thisApi.SetPixelFormatPalette(format, ref palette.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 484, Column 29 in SDL_pixels.h")]
        public static unsafe int SetPixelFormatPalette(this Sdl thisApi, Span<PixelFormat> format, Palette* palette)
        {
            // SpanOverloader
            return thisApi.SetPixelFormatPalette(ref format.GetPinnableReference(), palette);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 484, Column 29 in SDL_pixels.h")]
        public static unsafe int SetPixelFormatPalette(this Sdl thisApi, Span<PixelFormat> format, Span<Palette> palette)
        {
            // SpanOverloader
            return thisApi.SetPixelFormatPalette(ref format.GetPinnableReference(), ref palette.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in SDL_pixels.h")]
        public static unsafe int SetPaletteColors(this Sdl thisApi, Palette* palette, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Color> colors, int firstcolor, int ncolors)
        {
            // SpanOverloader
            return thisApi.SetPaletteColors(palette, in colors.GetPinnableReference(), firstcolor, ncolors);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in SDL_pixels.h")]
        public static unsafe int SetPaletteColors(this Sdl thisApi, Span<Palette> palette, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Color* colors, int firstcolor, int ncolors)
        {
            // SpanOverloader
            return thisApi.SetPaletteColors(ref palette.GetPinnableReference(), colors, firstcolor, ncolors);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 29 in SDL_pixels.h")]
        public static unsafe int SetPaletteColors(this Sdl thisApi, Span<Palette> palette, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Color> colors, int firstcolor, int ncolors)
        {
            // SpanOverloader
            return thisApi.SetPaletteColors(ref palette.GetPinnableReference(), in colors.GetPinnableReference(), firstcolor, ncolors);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 515, Column 30 in SDL_pixels.h")]
        public static unsafe void FreePalette(this Sdl thisApi, Span<Palette> palette)
        {
            // SpanOverloader
            thisApi.FreePalette(ref palette.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 547, Column 32 in SDL_pixels.h")]
        public static unsafe uint MapRGB(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte r, byte g, byte b)
        {
            // SpanOverloader
            return thisApi.MapRGB(in format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 582, Column 32 in SDL_pixels.h")]
        public static unsafe uint MapRGBA(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte r, byte g, byte b, byte a)
        {
            // SpanOverloader
            return thisApi.MapRGBA(in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, byte* g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, format, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, byte* g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, byte* g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGB(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            thisApi.GetRGB(pixel, in format.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, byte* g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, Span<byte> g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, Span<byte> g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, byte* g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, byte* g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, byte* g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, Span<byte> g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, Span<byte> g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, format, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, byte* g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, byte* g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, byte* g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, Span<byte> g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, Span<byte> g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, byte* g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, byte* g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, byte* g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, Span<byte> g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, Span<byte> g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 30 in SDL_pixels.h")]
        public static unsafe void GetRGBA(this Sdl thisApi, uint pixel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> format, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            thisApi.GetRGBA(pixel, in format.GetPinnableReference(), r, g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 30 in SDL_pixels.h")]
        public static unsafe void CalculateGammaRamp(this Sdl thisApi, float gamma, Span<ushort> ramp)
        {
            // SpanOverloader
            thisApi.CalculateGammaRamp(gamma, ref ramp.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 29 in SDL_error.h")]
        public static unsafe int SetError(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            return thisApi.SetError(in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 32 in SDL_error.h")]
        public static unsafe byte* GetErrorMsg(this Sdl thisApi, Span<byte> errstr, int maxlen)
        {
            // SpanOverloader
            return thisApi.GetErrorMsg(ref errstr.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool HasIntersection(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> B)
        {
            // SpanOverloader
            return thisApi.HasIntersection(A, in B.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool HasIntersection(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* B)
        {
            // SpanOverloader
            return thisApi.HasIntersection(in A.GetPinnableReference(), B);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool HasIntersection(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> B)
        {
            // SpanOverloader
            return thisApi.HasIntersection(in A.GetPinnableReference(), in B.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.IntersectRect(A, B, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> B, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            return thisApi.IntersectRect(A, in B.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.IntersectRect(A, in B.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* B, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            return thisApi.IntersectRect(in A.GetPinnableReference(), B, result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.IntersectRect(in A.GetPinnableReference(), B, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> B, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            return thisApi.IntersectRect(in A.GetPinnableReference(), in B.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.IntersectRect(in A.GetPinnableReference(), in B.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 178, Column 30 in SDL_rect.h")]
        public static unsafe void UnionRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            thisApi.UnionRect(A, B, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 178, Column 30 in SDL_rect.h")]
        public static unsafe void UnionRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> B, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            thisApi.UnionRect(A, in B.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 178, Column 30 in SDL_rect.h")]
        public static unsafe void UnionRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            thisApi.UnionRect(A, in B.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 178, Column 30 in SDL_rect.h")]
        public static unsafe void UnionRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* B, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            thisApi.UnionRect(in A.GetPinnableReference(), B, result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 178, Column 30 in SDL_rect.h")]
        public static unsafe void UnionRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            thisApi.UnionRect(in A.GetPinnableReference(), B, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 178, Column 30 in SDL_rect.h")]
        public static unsafe void UnionRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> B, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            thisApi.UnionRect(in A.GetPinnableReference(), in B.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 178, Column 30 in SDL_rect.h")]
        public static unsafe void UnionRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> B, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            thisApi.UnionRect(in A.GetPinnableReference(), in B.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool EnclosePoints(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Point* points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* clip, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.EnclosePoints(points, count, clip, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool EnclosePoints(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Point* points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> clip, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            return thisApi.EnclosePoints(points, count, in clip.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool EnclosePoints(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Point* points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> clip, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.EnclosePoints(points, count, in clip.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool EnclosePoints(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Point> points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* clip, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            return thisApi.EnclosePoints(in points.GetPinnableReference(), count, clip, result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool EnclosePoints(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Point> points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* clip, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.EnclosePoints(in points.GetPinnableReference(), count, clip, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool EnclosePoints(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Point> points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> clip, Silk.NET.Maths.Rectangle<int>* result)
        {
            // SpanOverloader
            return thisApi.EnclosePoints(in points.GetPinnableReference(), count, in clip.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 199, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool EnclosePoints(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Point> points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> clip, Span<Silk.NET.Maths.Rectangle<int>> result)
        {
            // SpanOverloader
            return thisApi.EnclosePoints(in points.GetPinnableReference(), count, in clip.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, int* X1, int* Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, X1, Y1, X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, int* X1, int* Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, X1, Y1, ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, int* X1, int* Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, X1, Y1, ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, int* X1, Span<int> Y1, int* X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, X1, ref Y1.GetPinnableReference(), X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, int* X1, Span<int> Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, X1, ref Y1.GetPinnableReference(), X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, int* X1, Span<int> Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, X1, ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, int* X1, Span<int> Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, X1, ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, int* Y1, int* X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), Y1, X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, int* Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), Y1, X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, int* Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), Y1, ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, int* Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), Y1, ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, Span<int> Y1, int* X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, Span<int> Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, Span<int> Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, Span<int> X1, Span<int> Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(rect, ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, int* X1, int* Y1, int* X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), X1, Y1, X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, int* X1, int* Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), X1, Y1, X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, int* X1, int* Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), X1, Y1, ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, int* X1, int* Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), X1, Y1, ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, int* X1, Span<int> Y1, int* X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), X1, ref Y1.GetPinnableReference(), X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, int* X1, Span<int> Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), X1, ref Y1.GetPinnableReference(), X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, int* X1, Span<int> Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), X1, ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, int* X1, Span<int> Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), X1, ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, int* Y1, int* X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), Y1, X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, int* Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), Y1, X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, int* Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), Y1, ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, int* Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), Y1, ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, Span<int> Y1, int* X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, Span<int> Y1, int* X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, Span<int> Y1, Span<int> X2, int* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, Span<int> X1, Span<int> Y1, Span<int> X2, Span<int> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool HasIntersectionF(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> B)
        {
            // SpanOverloader
            return thisApi.HasIntersectionF(A, in B.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool HasIntersectionF(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* B)
        {
            // SpanOverloader
            return thisApi.HasIntersectionF(in A.GetPinnableReference(), B);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool HasIntersectionF(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> B)
        {
            // SpanOverloader
            return thisApi.HasIntersectionF(in A.GetPinnableReference(), in B.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* B, Span<FRect> result)
        {
            // SpanOverloader
            return thisApi.IntersectFRect(A, B, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> B, FRect* result)
        {
            // SpanOverloader
            return thisApi.IntersectFRect(A, in B.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> B, Span<FRect> result)
        {
            // SpanOverloader
            return thisApi.IntersectFRect(A, in B.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* B, FRect* result)
        {
            // SpanOverloader
            return thisApi.IntersectFRect(in A.GetPinnableReference(), B, result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* B, Span<FRect> result)
        {
            // SpanOverloader
            return thisApi.IntersectFRect(in A.GetPinnableReference(), B, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> B, FRect* result)
        {
            // SpanOverloader
            return thisApi.IntersectFRect(in A.GetPinnableReference(), in B.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> B, Span<FRect> result)
        {
            // SpanOverloader
            return thisApi.IntersectFRect(in A.GetPinnableReference(), in B.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 30 in SDL_rect.h")]
        public static unsafe void UnionFRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* B, Span<FRect> result)
        {
            // SpanOverloader
            thisApi.UnionFRect(A, B, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 30 in SDL_rect.h")]
        public static unsafe void UnionFRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> B, FRect* result)
        {
            // SpanOverloader
            thisApi.UnionFRect(A, in B.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 30 in SDL_rect.h")]
        public static unsafe void UnionFRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> B, Span<FRect> result)
        {
            // SpanOverloader
            thisApi.UnionFRect(A, in B.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 30 in SDL_rect.h")]
        public static unsafe void UnionFRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* B, FRect* result)
        {
            // SpanOverloader
            thisApi.UnionFRect(in A.GetPinnableReference(), B, result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 30 in SDL_rect.h")]
        public static unsafe void UnionFRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* B, Span<FRect> result)
        {
            // SpanOverloader
            thisApi.UnionFRect(in A.GetPinnableReference(), B, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 30 in SDL_rect.h")]
        public static unsafe void UnionFRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> B, FRect* result)
        {
            // SpanOverloader
            thisApi.UnionFRect(in A.GetPinnableReference(), in B.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 30 in SDL_rect.h")]
        public static unsafe void UnionFRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> A, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> B, Span<FRect> result)
        {
            // SpanOverloader
            thisApi.UnionFRect(in A.GetPinnableReference(), in B.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 339, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool EncloseFPoints(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FPoint* points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* clip, Span<FRect> result)
        {
            // SpanOverloader
            return thisApi.EncloseFPoints(points, count, clip, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 339, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool EncloseFPoints(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FPoint* points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> clip, FRect* result)
        {
            // SpanOverloader
            return thisApi.EncloseFPoints(points, count, in clip.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 339, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool EncloseFPoints(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FPoint* points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> clip, Span<FRect> result)
        {
            // SpanOverloader
            return thisApi.EncloseFPoints(points, count, in clip.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 339, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool EncloseFPoints(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FPoint> points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* clip, FRect* result)
        {
            // SpanOverloader
            return thisApi.EncloseFPoints(in points.GetPinnableReference(), count, clip, result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 339, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool EncloseFPoints(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FPoint> points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* clip, Span<FRect> result)
        {
            // SpanOverloader
            return thisApi.EncloseFPoints(in points.GetPinnableReference(), count, clip, ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 339, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool EncloseFPoints(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FPoint> points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> clip, FRect* result)
        {
            // SpanOverloader
            return thisApi.EncloseFPoints(in points.GetPinnableReference(), count, in clip.GetPinnableReference(), result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 339, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool EncloseFPoints(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FPoint> points, int count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> clip, Span<FRect> result)
        {
            // SpanOverloader
            return thisApi.EncloseFPoints(in points.GetPinnableReference(), count, in clip.GetPinnableReference(), ref result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, float* X1, float* Y1, float* X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, X1, Y1, X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, float* X1, float* Y1, Span<float> X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, X1, Y1, ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, float* X1, float* Y1, Span<float> X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, X1, Y1, ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, float* X1, Span<float> Y1, float* X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, X1, ref Y1.GetPinnableReference(), X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, float* X1, Span<float> Y1, float* X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, X1, ref Y1.GetPinnableReference(), X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, float* X1, Span<float> Y1, Span<float> X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, X1, ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, float* X1, Span<float> Y1, Span<float> X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, X1, ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, Span<float> X1, float* Y1, float* X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, ref X1.GetPinnableReference(), Y1, X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, Span<float> X1, float* Y1, float* X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, ref X1.GetPinnableReference(), Y1, X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, Span<float> X1, float* Y1, Span<float> X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, ref X1.GetPinnableReference(), Y1, ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, Span<float> X1, float* Y1, Span<float> X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, ref X1.GetPinnableReference(), Y1, ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, Span<float> X1, Span<float> Y1, float* X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, Span<float> X1, Span<float> Y1, float* X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, Span<float> X1, Span<float> Y1, Span<float> X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* rect, Span<float> X1, Span<float> Y1, Span<float> X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(rect, ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, float* X1, float* Y1, float* X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), X1, Y1, X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, float* X1, float* Y1, float* X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), X1, Y1, X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, float* X1, float* Y1, Span<float> X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), X1, Y1, ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, float* X1, float* Y1, Span<float> X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), X1, Y1, ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, float* X1, Span<float> Y1, float* X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), X1, ref Y1.GetPinnableReference(), X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, float* X1, Span<float> Y1, float* X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), X1, ref Y1.GetPinnableReference(), X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, float* X1, Span<float> Y1, Span<float> X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), X1, ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, float* X1, Span<float> Y1, Span<float> X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), X1, ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, Span<float> X1, float* Y1, float* X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), Y1, X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, Span<float> X1, float* Y1, float* X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), Y1, X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, Span<float> X1, float* Y1, Span<float> X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), Y1, ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, Span<float> X1, float* Y1, Span<float> X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), Y1, ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, Span<float> X1, Span<float> Y1, float* X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), X2, Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, Span<float> X1, Span<float> Y1, float* X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), X2, ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, Span<float> X1, Span<float> Y1, Span<float> X2, float* Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), Y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 34 in SDL_rect.h")]
        public static unsafe SdlBool IntersectFRectAndLine(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect, Span<float> X1, Span<float> Y1, Span<float> X2, Span<float> Y2)
        {
            // SpanOverloader
            return thisApi.IntersectFRectAndLine(in rect.GetPinnableReference(), ref X1.GetPinnableReference(), ref Y1.GetPinnableReference(), ref X2.GetPinnableReference(), ref Y2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 219, Column 38 in SDL_surface.h")]
        public static unsafe Surface* CreateRGBSurfaceFrom<T0>(this Sdl thisApi, Span<T0> pixels, int width, int height, int depth, int pitch, uint Rmask, uint Gmask, uint Bmask, uint Amask) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateRGBSurfaceFrom(ref pixels.GetPinnableReference(), width, height, depth, pitch, Rmask, Gmask, Bmask, Amask);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 38 in SDL_surface.h")]
        public static unsafe Surface* CreateRGBSurfaceWithFormatFrom<T0>(this Sdl thisApi, Span<T0> pixels, int width, int height, int depth, int pitch, uint format) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateRGBSurfaceWithFormatFrom(ref pixels.GetPinnableReference(), width, height, depth, pitch, format);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 274, Column 30 in SDL_surface.h")]
        public static unsafe void FreeSurface(this Sdl thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            thisApi.FreeSurface(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 29 in SDL_surface.h")]
        public static unsafe int SetSurfacePalette(this Sdl thisApi, Surface* surface, Span<Palette> palette)
        {
            // SpanOverloader
            return thisApi.SetSurfacePalette(surface, ref palette.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 29 in SDL_surface.h")]
        public static unsafe int SetSurfacePalette(this Sdl thisApi, Span<Surface> surface, Palette* palette)
        {
            // SpanOverloader
            return thisApi.SetSurfacePalette(ref surface.GetPinnableReference(), palette);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 29 in SDL_surface.h")]
        public static unsafe int SetSurfacePalette(this Sdl thisApi, Span<Surface> surface, Span<Palette> palette)
        {
            // SpanOverloader
            return thisApi.SetSurfacePalette(ref surface.GetPinnableReference(), ref palette.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 312, Column 29 in SDL_surface.h")]
        public static unsafe int LockSurface(this Sdl thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            return thisApi.LockSurface(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 323, Column 30 in SDL_surface.h")]
        public static unsafe void UnlockSurface(this Sdl thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            thisApi.UnlockSurface(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 347, Column 38 in SDL_surface.h")]
        public static unsafe Surface* LoadBMPRW(this Sdl thisApi, Span<RWops> src, int freesrc)
        {
            // SpanOverloader
            return thisApi.LoadBMPRW(ref src.GetPinnableReference(), freesrc);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 377, Column 29 in SDL_surface.h")]
        public static unsafe int SaveBMPRW(this Sdl thisApi, Surface* surface, Span<RWops> dst, int freedst)
        {
            // SpanOverloader
            return thisApi.SaveBMPRW(surface, ref dst.GetPinnableReference(), freedst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 377, Column 29 in SDL_surface.h")]
        public static unsafe int SaveBMPRW(this Sdl thisApi, Span<Surface> surface, RWops* dst, int freedst)
        {
            // SpanOverloader
            return thisApi.SaveBMPRW(ref surface.GetPinnableReference(), dst, freedst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 377, Column 29 in SDL_surface.h")]
        public static unsafe int SaveBMPRW(this Sdl thisApi, Span<Surface> surface, Span<RWops> dst, int freedst)
        {
            // SpanOverloader
            return thisApi.SaveBMPRW(ref surface.GetPinnableReference(), ref dst.GetPinnableReference(), freedst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 405, Column 29 in SDL_surface.h")]
        public static unsafe int SetSurfaceRLE(this Sdl thisApi, Span<Surface> surface, int flag)
        {
            // SpanOverloader
            return thisApi.SetSurfaceRLE(ref surface.GetPinnableReference(), flag);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 420, Column 34 in SDL_surface.h")]
        public static unsafe SdlBool HasSurfaceRLE(this Sdl thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            return thisApi.HasSurfaceRLE(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 446, Column 29 in SDL_surface.h")]
        public static unsafe int SetColorKey(this Sdl thisApi, Span<Surface> surface, int flag, uint key)
        {
            // SpanOverloader
            return thisApi.SetColorKey(ref surface.GetPinnableReference(), flag, key);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 34 in SDL_surface.h")]
        public static unsafe SdlBool HasColorKey(this Sdl thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            return thisApi.HasColorKey(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 482, Column 29 in SDL_surface.h")]
        public static unsafe int GetColorKey(this Sdl thisApi, Surface* surface, Span<uint> key)
        {
            // SpanOverloader
            return thisApi.GetColorKey(surface, ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 482, Column 29 in SDL_surface.h")]
        public static unsafe int GetColorKey(this Sdl thisApi, Span<Surface> surface, uint* key)
        {
            // SpanOverloader
            return thisApi.GetColorKey(ref surface.GetPinnableReference(), key);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 482, Column 29 in SDL_surface.h")]
        public static unsafe int GetColorKey(this Sdl thisApi, Span<Surface> surface, Span<uint> key)
        {
            // SpanOverloader
            return thisApi.GetColorKey(ref surface.GetPinnableReference(), ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 506, Column 29 in SDL_surface.h")]
        public static unsafe int SetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte r, byte g, byte b)
        {
            // SpanOverloader
            return thisApi.SetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, byte* r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, byte* r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, byte* r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, byte* r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, byte* g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Surface* surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(surface, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, byte* g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, byte* g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceColorMod(this Sdl thisApi, Span<Surface> surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetSurfaceColorMod(ref surface.GetPinnableReference(), r, g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 547, Column 29 in SDL_surface.h")]
        public static unsafe int SetSurfaceAlphaMod(this Sdl thisApi, Span<Surface> surface, byte alpha)
        {
            // SpanOverloader
            return thisApi.SetSurfaceAlphaMod(ref surface.GetPinnableReference(), alpha);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 563, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceAlphaMod(this Sdl thisApi, Surface* surface, Span<byte> alpha)
        {
            // SpanOverloader
            return thisApi.GetSurfaceAlphaMod(surface, ref alpha.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 563, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceAlphaMod(this Sdl thisApi, Span<Surface> surface, byte* alpha)
        {
            // SpanOverloader
            return thisApi.GetSurfaceAlphaMod(ref surface.GetPinnableReference(), alpha);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 563, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceAlphaMod(this Sdl thisApi, Span<Surface> surface, Span<byte> alpha)
        {
            // SpanOverloader
            return thisApi.GetSurfaceAlphaMod(ref surface.GetPinnableReference(), ref alpha.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 563, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceAlphaMod(this Sdl thisApi, Span<Surface> surface, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string alpha)
        {
            // SpanOverloader
            return thisApi.GetSurfaceAlphaMod(ref surface.GetPinnableReference(), alpha);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 582, Column 29 in SDL_surface.h")]
        public static unsafe int SetSurfaceBlendMode(this Sdl thisApi, Span<Surface> surface, BlendMode blendMode)
        {
            // SpanOverloader
            return thisApi.SetSurfaceBlendMode(ref surface.GetPinnableReference(), blendMode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 597, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceBlendMode(this Sdl thisApi, Surface* surface, Span<BlendMode> blendMode)
        {
            // SpanOverloader
            return thisApi.GetSurfaceBlendMode(surface, ref blendMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 597, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceBlendMode(this Sdl thisApi, Span<Surface> surface, BlendMode* blendMode)
        {
            // SpanOverloader
            return thisApi.GetSurfaceBlendMode(ref surface.GetPinnableReference(), blendMode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 597, Column 29 in SDL_surface.h")]
        public static unsafe int GetSurfaceBlendMode(this Sdl thisApi, Span<Surface> surface, Span<BlendMode> blendMode)
        {
            // SpanOverloader
            return thisApi.GetSurfaceBlendMode(ref surface.GetPinnableReference(), ref blendMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 620, Column 34 in SDL_surface.h")]
        public static unsafe SdlBool SetClipRect(this Sdl thisApi, Surface* surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.SetClipRect(surface, in rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 620, Column 34 in SDL_surface.h")]
        public static unsafe SdlBool SetClipRect(this Sdl thisApi, Span<Surface> surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect)
        {
            // SpanOverloader
            return thisApi.SetClipRect(ref surface.GetPinnableReference(), rect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 620, Column 34 in SDL_surface.h")]
        public static unsafe SdlBool SetClipRect(this Sdl thisApi, Span<Surface> surface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.SetClipRect(ref surface.GetPinnableReference(), in rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 30 in SDL_surface.h")]
        public static unsafe void GetClipRect(this Sdl thisApi, Surface* surface, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            thisApi.GetClipRect(surface, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 30 in SDL_surface.h")]
        public static unsafe void GetClipRect(this Sdl thisApi, Span<Surface> surface, Silk.NET.Maths.Rectangle<int>* rect)
        {
            // SpanOverloader
            thisApi.GetClipRect(ref surface.GetPinnableReference(), rect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 30 in SDL_surface.h")]
        public static unsafe void GetClipRect(this Sdl thisApi, Span<Surface> surface, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            thisApi.GetClipRect(ref surface.GetPinnableReference(), ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 38 in SDL_surface.h")]
        public static unsafe Surface* DuplicateSurface(this Sdl thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            return thisApi.DuplicateSurface(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 38 in SDL_surface.h")]
        public static unsafe Surface* ConvertSurface(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> fmt, uint flags)
        {
            // SpanOverloader
            return thisApi.ConvertSurface(src, in fmt.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 38 in SDL_surface.h")]
        public static unsafe Surface* ConvertSurface(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat* fmt, uint flags)
        {
            // SpanOverloader
            return thisApi.ConvertSurface(ref src.GetPinnableReference(), fmt, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 38 in SDL_surface.h")]
        public static unsafe Surface* ConvertSurface(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormat> fmt, uint flags)
        {
            // SpanOverloader
            return thisApi.ConvertSurface(ref src.GetPinnableReference(), in fmt.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 700, Column 38 in SDL_surface.h")]
        public static unsafe Surface* ConvertSurfaceFormat(this Sdl thisApi, Span<Surface> src, uint pixel_format, uint flags)
        {
            // SpanOverloader
            return thisApi.ConvertSurfaceFormat(ref src.GetPinnableReference(), pixel_format, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 719, Column 29 in SDL_surface.h")]
        public static unsafe int ConvertPixels<T0>(this Sdl thisApi, int width, int height, uint src_format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src, int src_pitch, uint dst_format, Span<T0> dst, int dst_pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ConvertPixels(width, height, src_format, src, src_pitch, dst_format, ref dst.GetPinnableReference(), dst_pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 719, Column 29 in SDL_surface.h")]
        public static unsafe int ConvertPixels<T0>(this Sdl thisApi, int width, int height, uint src_format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> src, int src_pitch, uint dst_format, void* dst, int dst_pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ConvertPixels(width, height, src_format, in src.GetPinnableReference(), src_pitch, dst_format, dst, dst_pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 719, Column 29 in SDL_surface.h")]
        public static unsafe int ConvertPixels<T0, T1>(this Sdl thisApi, int width, int height, uint src_format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> src, int src_pitch, uint dst_format, Span<T1> dst, int dst_pitch) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.ConvertPixels(width, height, src_format, in src.GetPinnableReference(), src_pitch, dst_format, ref dst.GetPinnableReference(), dst_pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 745, Column 29 in SDL_surface.h")]
        public static unsafe int PremultiplyAlpha<T0>(this Sdl thisApi, int width, int height, uint src_format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* src, int src_pitch, uint dst_format, Span<T0> dst, int dst_pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.PremultiplyAlpha(width, height, src_format, src, src_pitch, dst_format, ref dst.GetPinnableReference(), dst_pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 745, Column 29 in SDL_surface.h")]
        public static unsafe int PremultiplyAlpha<T0>(this Sdl thisApi, int width, int height, uint src_format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> src, int src_pitch, uint dst_format, void* dst, int dst_pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.PremultiplyAlpha(width, height, src_format, in src.GetPinnableReference(), src_pitch, dst_format, dst, dst_pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 745, Column 29 in SDL_surface.h")]
        public static unsafe int PremultiplyAlpha<T0, T1>(this Sdl thisApi, int width, int height, uint src_format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> src, int src_pitch, uint dst_format, Span<T1> dst, int dst_pitch) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.PremultiplyAlpha(width, height, src_format, in src.GetPinnableReference(), src_pitch, dst_format, ref dst.GetPinnableReference(), dst_pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 774, Column 29 in SDL_surface.h")]
        public static unsafe int FillRect(this Sdl thisApi, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, uint color)
        {
            // SpanOverloader
            return thisApi.FillRect(dst, in rect.GetPinnableReference(), color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 774, Column 29 in SDL_surface.h")]
        public static unsafe int FillRect(this Sdl thisApi, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, uint color)
        {
            // SpanOverloader
            return thisApi.FillRect(ref dst.GetPinnableReference(), rect, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 774, Column 29 in SDL_surface.h")]
        public static unsafe int FillRect(this Sdl thisApi, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, uint color)
        {
            // SpanOverloader
            return thisApi.FillRect(ref dst.GetPinnableReference(), in rect.GetPinnableReference(), color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 800, Column 29 in SDL_surface.h")]
        public static unsafe int FillRects(this Sdl thisApi, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rects, int count, uint color)
        {
            // SpanOverloader
            return thisApi.FillRects(dst, in rects.GetPinnableReference(), count, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 800, Column 29 in SDL_surface.h")]
        public static unsafe int FillRects(this Sdl thisApi, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rects, int count, uint color)
        {
            // SpanOverloader
            return thisApi.FillRects(ref dst.GetPinnableReference(), rects, count, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 800, Column 29 in SDL_surface.h")]
        public static unsafe int FillRects(this Sdl thisApi, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rects, int count, uint color)
        {
            // SpanOverloader
            return thisApi.FillRects(ref dst.GetPinnableReference(), in rects.GetPinnableReference(), count, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(src, srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(src, srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(src, srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(src, in srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(src, in srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(src, in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(src, in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), srcrect, dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlit(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlit(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(src, srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(src, srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(src, srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(src, ref srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(src, ref srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(src, ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(src, ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), srcrect, dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlit(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlit(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(src, srcrect, dst, in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(src, srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(src, srcrect, ref dst.GetPinnableReference(), in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(src, in srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(src, in srcrect.GetPinnableReference(), dst, in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(src, in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(src, in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), srcrect, dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), srcrect, dst, in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), dst, in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretch(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretch(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(src, srcrect, dst, in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(src, srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(src, srcrect, ref dst.GetPinnableReference(), in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(src, in srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(src, in srcrect.GetPinnableReference(), dst, in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(src, in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(src, in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(ref src.GetPinnableReference(), srcrect, dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(ref src.GetPinnableReference(), srcrect, dst, in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), dst, in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 29 in SDL_surface.h")]
        public static unsafe int SoftStretchLinear(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.SoftStretchLinear(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(src, srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(src, srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(src, srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(src, in srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(src, in srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(src, in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Surface* src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(src, in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), srcrect, dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 29 in SDL_surface.h")]
        public static unsafe int UpperBlitScaled(this Sdl thisApi, Span<Surface> src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.UpperBlitScaled(ref src.GetPinnableReference(), in srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(src, srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(src, srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Surface* src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(src, srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(src, ref srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(src, ref srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(src, ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Surface* src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(src, ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), srcrect, dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), srcrect, dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Silk.NET.Maths.Rectangle<int>* srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), srcrect, ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), dst, dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Surface* dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), dst, ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in SDL_surface.h")]
        public static unsafe int LowerBlitScaled(this Sdl thisApi, Span<Surface> src, Span<Silk.NET.Maths.Rectangle<int>> srcrect, Span<Surface> dst, Span<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.LowerBlitScaled(ref src.GetPinnableReference(), ref srcrect.GetPinnableReference(), ref dst.GetPinnableReference(), ref dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 341, Column 29 in SDL_video.h")]
        public static unsafe int VideoInit(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> driver_name)
        {
            // SpanOverloader
            return thisApi.VideoInit(in driver_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 407, Column 29 in SDL_video.h")]
        public static unsafe int GetDisplayBounds(this Sdl thisApi, int displayIndex, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.GetDisplayBounds(displayIndex, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 438, Column 29 in SDL_video.h")]
        public static unsafe int GetDisplayUsableBounds(this Sdl thisApi, int displayIndex, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.GetDisplayUsableBounds(displayIndex, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 29 in SDL_video.h")]
        public static unsafe int GetDisplayDPI(this Sdl thisApi, int displayIndex, float* ddpi, float* hdpi, Span<float> vdpi)
        {
            // SpanOverloader
            return thisApi.GetDisplayDPI(displayIndex, ddpi, hdpi, ref vdpi.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 29 in SDL_video.h")]
        public static unsafe int GetDisplayDPI(this Sdl thisApi, int displayIndex, float* ddpi, Span<float> hdpi, float* vdpi)
        {
            // SpanOverloader
            return thisApi.GetDisplayDPI(displayIndex, ddpi, ref hdpi.GetPinnableReference(), vdpi);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 29 in SDL_video.h")]
        public static unsafe int GetDisplayDPI(this Sdl thisApi, int displayIndex, float* ddpi, Span<float> hdpi, Span<float> vdpi)
        {
            // SpanOverloader
            return thisApi.GetDisplayDPI(displayIndex, ddpi, ref hdpi.GetPinnableReference(), ref vdpi.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 29 in SDL_video.h")]
        public static unsafe int GetDisplayDPI(this Sdl thisApi, int displayIndex, Span<float> ddpi, float* hdpi, float* vdpi)
        {
            // SpanOverloader
            return thisApi.GetDisplayDPI(displayIndex, ref ddpi.GetPinnableReference(), hdpi, vdpi);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 29 in SDL_video.h")]
        public static unsafe int GetDisplayDPI(this Sdl thisApi, int displayIndex, Span<float> ddpi, float* hdpi, Span<float> vdpi)
        {
            // SpanOverloader
            return thisApi.GetDisplayDPI(displayIndex, ref ddpi.GetPinnableReference(), hdpi, ref vdpi.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 29 in SDL_video.h")]
        public static unsafe int GetDisplayDPI(this Sdl thisApi, int displayIndex, Span<float> ddpi, Span<float> hdpi, float* vdpi)
        {
            // SpanOverloader
            return thisApi.GetDisplayDPI(displayIndex, ref ddpi.GetPinnableReference(), ref hdpi.GetPinnableReference(), vdpi);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 29 in SDL_video.h")]
        public static unsafe int GetDisplayDPI(this Sdl thisApi, int displayIndex, Span<float> ddpi, Span<float> hdpi, Span<float> vdpi)
        {
            // SpanOverloader
            return thisApi.GetDisplayDPI(displayIndex, ref ddpi.GetPinnableReference(), ref hdpi.GetPinnableReference(), ref vdpi.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 29 in SDL_video.h")]
        public static unsafe int GetDisplayMode(this Sdl thisApi, int displayIndex, int modeIndex, Span<DisplayMode> mode)
        {
            // SpanOverloader
            return thisApi.GetDisplayMode(displayIndex, modeIndex, ref mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 550, Column 29 in SDL_video.h")]
        public static unsafe int GetDesktopDisplayMode(this Sdl thisApi, int displayIndex, Span<DisplayMode> mode)
        {
            // SpanOverloader
            return thisApi.GetDesktopDisplayMode(displayIndex, ref mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 573, Column 29 in SDL_video.h")]
        public static unsafe int GetCurrentDisplayMode(this Sdl thisApi, int displayIndex, Span<DisplayMode> mode)
        {
            // SpanOverloader
            return thisApi.GetCurrentDisplayMode(displayIndex, ref mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 599, Column 43 in SDL_video.h")]
        public static unsafe DisplayMode* GetClosestDisplayMode(this Sdl thisApi, int displayIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DisplayMode* mode, Span<DisplayMode> closest)
        {
            // SpanOverloader
            return thisApi.GetClosestDisplayMode(displayIndex, mode, ref closest.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 599, Column 43 in SDL_video.h")]
        public static unsafe DisplayMode* GetClosestDisplayMode(this Sdl thisApi, int displayIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DisplayMode> mode, DisplayMode* closest)
        {
            // SpanOverloader
            return thisApi.GetClosestDisplayMode(displayIndex, in mode.GetPinnableReference(), closest);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 599, Column 43 in SDL_video.h")]
        public static unsafe DisplayMode* GetClosestDisplayMode(this Sdl thisApi, int displayIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DisplayMode> mode, Span<DisplayMode> closest)
        {
            // SpanOverloader
            return thisApi.GetClosestDisplayMode(displayIndex, in mode.GetPinnableReference(), ref closest.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 29 in SDL_video.h")]
        public static unsafe int GetPointDisplayIndex(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Point> point)
        {
            // SpanOverloader
            return thisApi.GetPointDisplayIndex(in point.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_video.h")]
        public static unsafe int GetRectDisplayIndex(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.GetRectDisplayIndex(in rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 29 in SDL_video.h")]
        public static unsafe int SetWindowDisplayMode(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DisplayMode> mode)
        {
            // SpanOverloader
            return thisApi.SetWindowDisplayMode(window, in mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 681, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowDisplayMode(this Sdl thisApi, Window* window, Span<DisplayMode> mode)
        {
            // SpanOverloader
            return thisApi.GetWindowDisplayMode(window, ref mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 696, Column 31 in SDL_video.h")]
        public static unsafe void* GetWindowICCProfile(this Sdl thisApi, Window* window, Span<nuint> size)
        {
            // SpanOverloader
            return thisApi.GetWindowICCProfile(window, ref size.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 781, Column 38 in SDL_video.h")]
        public static unsafe Window* CreateWindow(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> title, int x, int y, int w, int h, uint flags)
        {
            // SpanOverloader
            return thisApi.CreateWindow(in title.GetPinnableReference(), x, y, w, h, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 802, Column 38 in SDL_video.h")]
        public static unsafe Window* CreateWindowFrom<T0>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateWindowFrom(in data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 866, Column 30 in SDL_video.h")]
        public static unsafe void SetWindowTitle(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> title)
        {
            // SpanOverloader
            thisApi.SetWindowTitle(window, in title.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 890, Column 30 in SDL_video.h")]
        public static unsafe void SetWindowIcon(this Sdl thisApi, Window* window, Span<Surface> icon)
        {
            // SpanOverloader
            thisApi.SetWindowIcon(window, ref icon.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 907, Column 31 in SDL_video.h")]
        public static unsafe void* SetWindowData<T0>(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetWindowData(window, name, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 907, Column 31 in SDL_video.h")]
        public static unsafe void* SetWindowData(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, void* userdata)
        {
            // SpanOverloader
            return thisApi.SetWindowData(window, in name.GetPinnableReference(), userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 907, Column 31 in SDL_video.h")]
        public static unsafe void* SetWindowData<T0>(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetWindowData(window, in name.GetPinnableReference(), ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 907, Column 31 in SDL_video.h")]
        public static unsafe void* SetWindowData<T0>(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetWindowData(window, name, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 31 in SDL_video.h")]
        public static unsafe void* GetWindowData(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetWindowData(window, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowPosition(this Sdl thisApi, Window* window, int* x, Span<int> y)
        {
            // SpanOverloader
            thisApi.GetWindowPosition(window, x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowPosition(this Sdl thisApi, Window* window, Span<int> x, int* y)
        {
            // SpanOverloader
            thisApi.GetWindowPosition(window, ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowPosition(this Sdl thisApi, Window* window, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            thisApi.GetWindowPosition(window, ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowSize(this Sdl thisApi, Window* window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowSize(window, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowSize(this Sdl thisApi, Window* window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.GetWindowSize(window, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowSize(this Sdl thisApi, Window* window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowSize(window, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, int* top, int* left, int* bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, top, left, bottom, ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, int* top, int* left, Span<int> bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, top, left, ref bottom.GetPinnableReference(), right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, int* top, int* left, Span<int> bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, top, left, ref bottom.GetPinnableReference(), ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, int* top, Span<int> left, int* bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, top, ref left.GetPinnableReference(), bottom, right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, int* top, Span<int> left, int* bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, top, ref left.GetPinnableReference(), bottom, ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, int* top, Span<int> left, Span<int> bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, top, ref left.GetPinnableReference(), ref bottom.GetPinnableReference(), right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, int* top, Span<int> left, Span<int> bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, top, ref left.GetPinnableReference(), ref bottom.GetPinnableReference(), ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, int* left, int* bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), left, bottom, right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, int* left, int* bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), left, bottom, ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, int* left, Span<int> bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), left, ref bottom.GetPinnableReference(), right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, int* left, Span<int> bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), left, ref bottom.GetPinnableReference(), ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, Span<int> left, int* bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), ref left.GetPinnableReference(), bottom, right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, Span<int> left, int* bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), ref left.GetPinnableReference(), bottom, ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, Span<int> left, Span<int> bottom, int* right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), ref left.GetPinnableReference(), ref bottom.GetPinnableReference(), right);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowBordersSize(this Sdl thisApi, Window* window, Span<int> top, Span<int> left, Span<int> bottom, Span<int> right)
        {
            // SpanOverloader
            return thisApi.GetWindowBordersSize(window, ref top.GetPinnableReference(), ref left.GetPinnableReference(), ref bottom.GetPinnableReference(), ref right.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1068, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowSizeInPixels(this Sdl thisApi, Window* window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowSizeInPixels(window, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1068, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowSizeInPixels(this Sdl thisApi, Window* window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.GetWindowSizeInPixels(window, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1068, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowSizeInPixels(this Sdl thisApi, Window* window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowSizeInPixels(window, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1100, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowMinimumSize(this Sdl thisApi, Window* window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowMinimumSize(window, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1100, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowMinimumSize(this Sdl thisApi, Window* window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.GetWindowMinimumSize(window, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1100, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowMinimumSize(this Sdl thisApi, Window* window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowMinimumSize(window, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1132, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowMaximumSize(this Sdl thisApi, Window* window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowMaximumSize(window, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1132, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowMaximumSize(this Sdl thisApi, Window* window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.GetWindowMaximumSize(window, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1132, Column 30 in SDL_video.h")]
        public static unsafe void GetWindowMaximumSize(this Sdl thisApi, Window* window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GetWindowMaximumSize(window, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1361, Column 29 in SDL_video.h")]
        public static unsafe int UpdateWindowSurfaceRects(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rects, int numrects)
        {
            // SpanOverloader
            return thisApi.UpdateWindowSurfaceRects(window, in rects.GetPinnableReference(), numrects);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 29 in SDL_video.h")]
        public static unsafe int SetWindowMouseRect(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.SetWindowMouseRect(window, in rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1615, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowOpacity(this Sdl thisApi, Window* window, Span<float> out_opacity)
        {
            // SpanOverloader
            return thisApi.GetWindowOpacity(window, ref out_opacity.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1676, Column 29 in SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(window, red, green, in blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1676, Column 29 in SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(window, red, in green.GetPinnableReference(), blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1676, Column 29 in SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(window, red, in green.GetPinnableReference(), in blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1676, Column 29 in SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(window, in red.GetPinnableReference(), green, blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1676, Column 29 in SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(window, in red.GetPinnableReference(), green, in blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1676, Column 29 in SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(window, in red.GetPinnableReference(), in green.GetPinnableReference(), blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1676, Column 29 in SDL_video.h")]
        public static unsafe int SetWindowGammaRamp(this Sdl thisApi, Window* window, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> blue)
        {
            // SpanOverloader
            return thisApi.SetWindowGammaRamp(window, in red.GetPinnableReference(), in green.GetPinnableReference(), in blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1704, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Window* window, ushort* red, ushort* green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(window, red, green, ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1704, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Window* window, ushort* red, Span<ushort> green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(window, red, ref green.GetPinnableReference(), blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1704, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Window* window, ushort* red, Span<ushort> green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(window, red, ref green.GetPinnableReference(), ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1704, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Window* window, Span<ushort> red, ushort* green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(window, ref red.GetPinnableReference(), green, blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1704, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Window* window, Span<ushort> red, ushort* green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(window, ref red.GetPinnableReference(), green, ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1704, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Window* window, Span<ushort> red, Span<ushort> green, ushort* blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(window, ref red.GetPinnableReference(), ref green.GetPinnableReference(), blue);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1704, Column 29 in SDL_video.h")]
        public static unsafe int GetWindowGammaRamp(this Sdl thisApi, Window* window, Span<ushort> red, Span<ushort> green, Span<ushort> blue)
        {
            // SpanOverloader
            return thisApi.GetWindowGammaRamp(window, ref red.GetPinnableReference(), ref green.GetPinnableReference(), ref blue.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1782, Column 29 in SDL_video.h")]
        public static unsafe int SetWindowHitTest<T0>(this Sdl thisApi, Window* window, PfnHitTest callback, Span<T0> callback_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetWindowHitTest(window, callback, ref callback_data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1884, Column 29 in SDL_video.h")]
        public static unsafe int GLLoadLibrary(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path)
        {
            // SpanOverloader
            return thisApi.GLLoadLibrary(in path.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1937, Column 31 in SDL_video.h")]
        public static unsafe void* GLGetProcAddress(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> proc)
        {
            // SpanOverloader
            return thisApi.GLGetProcAddress(in proc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1967, Column 34 in SDL_video.h")]
        public static unsafe SdlBool GLExtensionSupported(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> extension)
        {
            // SpanOverloader
            return thisApi.GLExtensionSupported(in extension.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2013, Column 29 in SDL_video.h")]
        public static unsafe int GLGetAttribute(this Sdl thisApi, GLattr attr, Span<int> value)
        {
            // SpanOverloader
            return thisApi.GLGetAttribute(attr, ref value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2052, Column 29 in SDL_video.h")]
        public static unsafe int GLMakeCurrent<T0>(this Sdl thisApi, Window* window, Span<T0> context) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GLMakeCurrent(window, ref context.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2097, Column 30 in SDL_video.h")]
        public static unsafe void GLGetDrawableSize(this Sdl thisApi, Window* window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GLGetDrawableSize(window, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2097, Column 30 in SDL_video.h")]
        public static unsafe void GLGetDrawableSize(this Sdl thisApi, Window* window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.GLGetDrawableSize(window, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2097, Column 30 in SDL_video.h")]
        public static unsafe void GLGetDrawableSize(this Sdl thisApi, Window* window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.GLGetDrawableSize(window, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2171, Column 30 in SDL_video.h")]
        public static unsafe void GLDeleteContext<T0>(this Sdl thisApi, Span<T0> context) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.GLDeleteContext(ref context.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 109, Column 29 in SDL_vulkan.h")]
        public static unsafe int VulkanLoadLibrary(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path)
        {
            // SpanOverloader
            return thisApi.VulkanLoadLibrary(in path.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 34 in SDL_vulkan.h")]
        public static unsafe SdlBool VulkanGetInstanceExtensions(this Sdl thisApi, Window* window, Span<uint> pCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** pNames)
        {
            // SpanOverloader
            return thisApi.VulkanGetInstanceExtensions(window, ref pCount.GetPinnableReference(), pNames);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 34 in SDL_vulkan.h")]
        public static unsafe SdlBool VulkanGetInstanceExtensions(this Sdl thisApi, Window* window, Span<uint> pCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* pNames)
        {
            // SpanOverloader
            return thisApi.VulkanGetInstanceExtensions(window, ref pCount.GetPinnableReference(), in pNames);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 34 in SDL_vulkan.h")]
        public static unsafe SdlBool VulkanCreateSurface(this Sdl thisApi, Window* window, Silk.NET.Core.Native.VkHandle instance, Span<Silk.NET.Core.Native.VkNonDispatchableHandle> surface)
        {
            // SpanOverloader
            return thisApi.VulkanCreateSurface(window, instance, ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 204, Column 30 in SDL_vulkan.h")]
        public static unsafe void VulkanGetDrawableSize(this Sdl thisApi, Window* window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.VulkanGetDrawableSize(window, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 204, Column 30 in SDL_vulkan.h")]
        public static unsafe void VulkanGetDrawableSize(this Sdl thisApi, Window* window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.VulkanGetDrawableSize(window, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 204, Column 30 in SDL_vulkan.h")]
        public static unsafe void VulkanGetDrawableSize(this Sdl thisApi, Window* window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.VulkanGetDrawableSize(window, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 29 in SDL_main.h")]
        [ExcludeFromOverride(0)]
        public static unsafe int RegisterApp<T0>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, uint style, Span<T0> hInst) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterApp(name, style, ref hInst.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 29 in SDL_main.h")]
        [ExcludeFromOverride(0)]
        public static unsafe int RegisterApp(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, uint style, void* hInst)
        {
            // SpanOverloader
            return thisApi.RegisterApp(in name.GetPinnableReference(), style, hInst);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 29 in SDL_main.h")]
        [ExcludeFromOverride(0)]
        public static unsafe int RegisterApp<T0>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, uint style, Span<T0> hInst) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterApp(in name.GetPinnableReference(), style, ref hInst.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 29 in SDL_main.h")]
        [ExcludeFromOverride(0)]
        public static unsafe int RegisterApp<T0>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint style, Span<T0> hInst) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterApp(name, style, ref hInst.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 29 in SDL_main.h")]
        [ExcludeFromOverride(0)]
        public static unsafe int WinRTRunApp<T0>(this Sdl thisApi, PfnMainFunc mainFunction, Span<T0> reserved) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WinRTRunApp(mainFunction, ref reserved.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 41 in SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, AssertData* arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(arg0, arg1, in arg2.GetPinnableReference(), arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 41 in SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, AssertData* arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(arg0, in arg1.GetPinnableReference(), arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 41 in SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, AssertData* arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(arg0, in arg1.GetPinnableReference(), in arg2.GetPinnableReference(), arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 41 in SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, AssertData* arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(arg0, in arg1.GetPinnableReference(), arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 41 in SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, AssertData* arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(arg0, arg1, in arg2.GetPinnableReference(), arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 41 in SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), arg1, arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 41 in SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), arg1, in arg2.GetPinnableReference(), arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 41 in SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), arg1, arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 41 in SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), in arg1.GetPinnableReference(), arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 41 in SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), in arg1.GetPinnableReference(), in arg2.GetPinnableReference(), arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 41 in SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), in arg1.GetPinnableReference(), arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 41 in SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), arg1, arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 41 in SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), arg1, in arg2.GetPinnableReference(), arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 41 in SDL_assert.h")]
        public static unsafe AssertState ReportAssertion(this Sdl thisApi, Span<AssertData> arg0, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg1, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string arg2, int arg3)
        {
            // SpanOverloader
            return thisApi.ReportAssertion(ref arg0.GetPinnableReference(), arg1, arg2, arg3);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 222, Column 30 in SDL_assert.h")]
        public static unsafe void SetAssertionHandler<T0>(this Sdl thisApi, PfnAssertionHandler handler, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetAssertionHandler(handler, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 106, Column 34 in SDL_atomic.h")]
        public static unsafe SdlBool AtomicTryLock(this Sdl thisApi, Span<int> @lock)
        {
            // SpanOverloader
            return thisApi.AtomicTryLock(ref @lock.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 30 in SDL_atomic.h")]
        public static unsafe void AtomicLock(this Sdl thisApi, Span<int> @lock)
        {
            // SpanOverloader
            thisApi.AtomicLock(ref @lock.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 30 in SDL_atomic.h")]
        public static unsafe void AtomicUnlock(this Sdl thisApi, Span<int> @lock)
        {
            // SpanOverloader
            thisApi.AtomicUnlock(ref @lock.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 34 in SDL_atomic.h")]
        public static unsafe SdlBool AtomicCAS(this Sdl thisApi, Span<AtomicT> a, int oldval, int newval)
        {
            // SpanOverloader
            return thisApi.AtomicCAS(ref a.GetPinnableReference(), oldval, newval);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 29 in SDL_atomic.h")]
        public static unsafe int AtomicSet(this Sdl thisApi, Span<AtomicT> a, int v)
        {
            // SpanOverloader
            return thisApi.AtomicSet(ref a.GetPinnableReference(), v);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 29 in SDL_atomic.h")]
        public static unsafe int AtomicGet(this Sdl thisApi, Span<AtomicT> a)
        {
            // SpanOverloader
            return thisApi.AtomicGet(ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 29 in SDL_atomic.h")]
        public static unsafe int AtomicAdd(this Sdl thisApi, Span<AtomicT> a, int v)
        {
            // SpanOverloader
            return thisApi.AtomicAdd(ref a.GetPinnableReference(), v);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 370, Column 34 in SDL_atomic.h")]
        public static unsafe SdlBool AtomicCASPtr<T0>(this Sdl thisApi, void** a, void* oldval, Span<T0> newval) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicCASPtr(a, oldval, ref newval.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 370, Column 34 in SDL_atomic.h")]
        public static unsafe SdlBool AtomicCASPtr<T0>(this Sdl thisApi, void** a, Span<T0> oldval, void* newval) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicCASPtr(a, ref oldval.GetPinnableReference(), newval);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 370, Column 34 in SDL_atomic.h")]
        public static unsafe SdlBool AtomicCASPtr<T0, T1>(this Sdl thisApi, void** a, Span<T0> oldval, Span<T1> newval) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicCASPtr(a, ref oldval.GetPinnableReference(), ref newval.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 370, Column 34 in SDL_atomic.h")]
        public static unsafe SdlBool AtomicCASPtr<T0>(this Sdl thisApi, ref void* a, void* oldval, Span<T0> newval) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicCASPtr(ref a, oldval, ref newval.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 370, Column 34 in SDL_atomic.h")]
        public static unsafe SdlBool AtomicCASPtr<T0>(this Sdl thisApi, ref void* a, Span<T0> oldval, void* newval) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicCASPtr(ref a, ref oldval.GetPinnableReference(), newval);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 370, Column 34 in SDL_atomic.h")]
        public static unsafe SdlBool AtomicCASPtr<T0, T1>(this Sdl thisApi, ref void* a, Span<T0> oldval, Span<T1> newval) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicCASPtr(ref a, ref oldval.GetPinnableReference(), ref newval.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 387, Column 31 in SDL_atomic.h")]
        public static unsafe void* AtomicSetPtr<T0>(this Sdl thisApi, void** a, Span<T0> v) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicSetPtr(a, ref v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 387, Column 31 in SDL_atomic.h")]
        public static unsafe void* AtomicSetPtr<T0>(this Sdl thisApi, ref void* a, Span<T0> v) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AtomicSetPtr(ref a, ref v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 208, Column 1 in SDL_thread.h")]
        public static unsafe Thread* CreateThread<T0>(this Sdl thisApi, PfnThreadFunction fn, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateThread(fn, name, ref data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 208, Column 1 in SDL_thread.h")]
        public static unsafe Thread* CreateThread(this Sdl thisApi, PfnThreadFunction fn, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, void* data)
        {
            // SpanOverloader
            return thisApi.CreateThread(fn, in name.GetPinnableReference(), data);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 208, Column 1 in SDL_thread.h")]
        public static unsafe Thread* CreateThread<T0>(this Sdl thisApi, PfnThreadFunction fn, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateThread(fn, in name.GetPinnableReference(), ref data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 208, Column 1 in SDL_thread.h")]
        public static unsafe Thread* CreateThread<T0>(this Sdl thisApi, PfnThreadFunction fn, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateThread(fn, name, ref data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 1 in SDL_thread.h")]
        public static unsafe Thread* CreateThreadWithStackSize<T0>(this Sdl thisApi, PfnThreadFunction fn, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint stacksize, Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateThreadWithStackSize(fn, name, stacksize, ref data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 1 in SDL_thread.h")]
        public static unsafe Thread* CreateThreadWithStackSize(this Sdl thisApi, PfnThreadFunction fn, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint stacksize, void* data)
        {
            // SpanOverloader
            return thisApi.CreateThreadWithStackSize(fn, in name.GetPinnableReference(), stacksize, data);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 1 in SDL_thread.h")]
        public static unsafe Thread* CreateThreadWithStackSize<T0>(this Sdl thisApi, PfnThreadFunction fn, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint stacksize, Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateThreadWithStackSize(fn, in name.GetPinnableReference(), stacksize, ref data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 1 in SDL_thread.h")]
        public static unsafe Thread* CreateThreadWithStackSize<T0>(this Sdl thisApi, PfnThreadFunction fn, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint stacksize, Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateThreadWithStackSize(fn, name, stacksize, ref data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 357, Column 30 in SDL_thread.h")]
        public static unsafe void WaitThread(this Sdl thisApi, Thread* thread, Span<int> status)
        {
            // SpanOverloader
            thisApi.WaitThread(thread, ref status.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 447, Column 29 in SDL_thread.h")]
        public static unsafe int TLSSet<T0>(this Sdl thisApi, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> value, PfnFreeFunc destructor) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.TLSSet(id, in value.GetPinnableReference(), destructor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 29 in SDL_audio.h")]
        public static unsafe int AudioInit(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> driver_name)
        {
            // SpanOverloader
            return thisApi.AudioInit(in driver_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 407, Column 29 in SDL_audio.h")]
        public static unsafe int OpenAudio(this Sdl thisApi, AudioSpec* desired, Span<AudioSpec> obtained)
        {
            // SpanOverloader
            return thisApi.OpenAudio(desired, ref obtained.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 407, Column 29 in SDL_audio.h")]
        public static unsafe int OpenAudio(this Sdl thisApi, Span<AudioSpec> desired, AudioSpec* obtained)
        {
            // SpanOverloader
            return thisApi.OpenAudio(ref desired.GetPinnableReference(), obtained);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 407, Column 29 in SDL_audio.h")]
        public static unsafe int OpenAudio(this Sdl thisApi, Span<AudioSpec> desired, Span<AudioSpec> obtained)
        {
            // SpanOverloader
            return thisApi.OpenAudio(ref desired.GetPinnableReference(), ref obtained.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 518, Column 29 in SDL_audio.h")]
        public static unsafe int GetAudioDeviceSpec(this Sdl thisApi, int index, int iscapture, Span<AudioSpec> spec)
        {
            // SpanOverloader
            return thisApi.GetAudioDeviceSpec(index, iscapture, ref spec.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 553, Column 29 in SDL_audio.h")]
        public static unsafe int GetDefaultAudioInfo(this Sdl thisApi, byte** name, Span<AudioSpec> spec, int iscapture)
        {
            // SpanOverloader
            return thisApi.GetDefaultAudioInfo(name, ref spec.GetPinnableReference(), iscapture);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 553, Column 29 in SDL_audio.h")]
        public static unsafe int GetDefaultAudioInfo(this Sdl thisApi, ref byte* name, Span<AudioSpec> spec, int iscapture)
        {
            // SpanOverloader
            return thisApi.GetDefaultAudioInfo(ref name, ref spec.GetPinnableReference(), iscapture);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 43 in SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* device, int iscapture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AudioSpec* desired, Span<AudioSpec> obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(device, iscapture, desired, ref obtained.GetPinnableReference(), allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 43 in SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* device, int iscapture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AudioSpec> desired, AudioSpec* obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(device, iscapture, in desired.GetPinnableReference(), obtained, allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 43 in SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* device, int iscapture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AudioSpec> desired, Span<AudioSpec> obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(device, iscapture, in desired.GetPinnableReference(), ref obtained.GetPinnableReference(), allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 43 in SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> device, int iscapture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AudioSpec* desired, AudioSpec* obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(in device.GetPinnableReference(), iscapture, desired, obtained, allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 43 in SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> device, int iscapture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AudioSpec* desired, Span<AudioSpec> obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(in device.GetPinnableReference(), iscapture, desired, ref obtained.GetPinnableReference(), allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 43 in SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> device, int iscapture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AudioSpec> desired, AudioSpec* obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(in device.GetPinnableReference(), iscapture, in desired.GetPinnableReference(), obtained, allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 43 in SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> device, int iscapture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AudioSpec> desired, Span<AudioSpec> obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(in device.GetPinnableReference(), iscapture, in desired.GetPinnableReference(), ref obtained.GetPinnableReference(), allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 43 in SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string device, int iscapture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AudioSpec* desired, Span<AudioSpec> obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(device, iscapture, desired, ref obtained.GetPinnableReference(), allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 43 in SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string device, int iscapture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AudioSpec> desired, AudioSpec* obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(device, iscapture, in desired.GetPinnableReference(), obtained, allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 43 in SDL_audio.h")]
        public static unsafe uint OpenAudioDevice(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string device, int iscapture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AudioSpec> desired, Span<AudioSpec> obtained, int allowed_changes)
        {
            // SpanOverloader
            return thisApi.OpenAudioDevice(device, iscapture, in desired.GetPinnableReference(), ref obtained.GetPinnableReference(), allowed_changes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, RWops* src, int freesrc, AudioSpec* spec, byte** audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(src, freesrc, spec, audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, RWops* src, int freesrc, AudioSpec* spec, ref byte* audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(src, freesrc, spec, ref audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, RWops* src, int freesrc, Span<AudioSpec> spec, byte** audio_buf, uint* audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(src, freesrc, ref spec.GetPinnableReference(), audio_buf, audio_len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, RWops* src, int freesrc, Span<AudioSpec> spec, byte** audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(src, freesrc, ref spec.GetPinnableReference(), audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, RWops* src, int freesrc, Span<AudioSpec> spec, ref byte* audio_buf, uint* audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(src, freesrc, ref spec.GetPinnableReference(), ref audio_buf, audio_len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, RWops* src, int freesrc, Span<AudioSpec> spec, ref byte* audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(src, freesrc, ref spec.GetPinnableReference(), ref audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, AudioSpec* spec, byte** audio_buf, uint* audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, spec, audio_buf, audio_len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, AudioSpec* spec, byte** audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, spec, audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, AudioSpec* spec, ref byte* audio_buf, uint* audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, spec, ref audio_buf, audio_len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, AudioSpec* spec, ref byte* audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, spec, ref audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, Span<AudioSpec> spec, byte** audio_buf, uint* audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, ref spec.GetPinnableReference(), audio_buf, audio_len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, Span<AudioSpec> spec, byte** audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, ref spec.GetPinnableReference(), audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, Span<AudioSpec> spec, ref byte* audio_buf, uint* audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, ref spec.GetPinnableReference(), ref audio_buf, audio_len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 40 in SDL_audio.h")]
        public static unsafe AudioSpec* LoadWAVRW(this Sdl thisApi, Span<RWops> src, int freesrc, Span<AudioSpec> spec, ref byte* audio_buf, Span<uint> audio_len)
        {
            // SpanOverloader
            return thisApi.LoadWAVRW(ref src.GetPinnableReference(), freesrc, ref spec.GetPinnableReference(), ref audio_buf, ref audio_len.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 898, Column 30 in SDL_audio.h")]
        public static unsafe void FreeWAV(this Sdl thisApi, Span<byte> audio_buf)
        {
            // SpanOverloader
            thisApi.FreeWAV(ref audio_buf.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 932, Column 29 in SDL_audio.h")]
        public static unsafe int BuildAudioCVT(this Sdl thisApi, Span<AudioCVT> cvt, ushort src_format, byte src_channels, int src_rate, ushort dst_format, byte dst_channels, int dst_rate)
        {
            // SpanOverloader
            return thisApi.BuildAudioCVT(ref cvt.GetPinnableReference(), src_format, src_channels, src_rate, dst_format, dst_channels, dst_rate);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 978, Column 29 in SDL_audio.h")]
        public static unsafe int ConvertAudio(this Sdl thisApi, Span<AudioCVT> cvt)
        {
            // SpanOverloader
            return thisApi.ConvertAudio(ref cvt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 29 in SDL_audio.h")]
        public static unsafe int AudioStreamPut<T0>(this Sdl thisApi, AudioStream* stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> buf, int len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AudioStreamPut(stream, in buf.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1054, Column 29 in SDL_audio.h")]
        public static unsafe int AudioStreamGet<T0>(this Sdl thisApi, AudioStream* stream, Span<T0> buf, int len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AudioStreamGet(stream, ref buf.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1145, Column 30 in SDL_audio.h")]
        public static unsafe void MixAudio(this Sdl thisApi, byte* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudio(dst, in src.GetPinnableReference(), len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1145, Column 30 in SDL_audio.h")]
        public static unsafe void MixAudio(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* src, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudio(ref dst.GetPinnableReference(), src, len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1145, Column 30 in SDL_audio.h")]
        public static unsafe void MixAudio(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudio(ref dst.GetPinnableReference(), in src.GetPinnableReference(), len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1145, Column 30 in SDL_audio.h")]
        public static unsafe void MixAudio(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string src, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudio(ref dst.GetPinnableReference(), src, len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1145, Column 30 in SDL_audio.h")]
        public static unsafe void MixAudio(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudio(dst, in src.GetPinnableReference(), len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1178, Column 30 in SDL_audio.h")]
        public static unsafe void MixAudioFormat(this Sdl thisApi, byte* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, ushort format, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudioFormat(dst, in src.GetPinnableReference(), format, len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1178, Column 30 in SDL_audio.h")]
        public static unsafe void MixAudioFormat(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* src, ushort format, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudioFormat(ref dst.GetPinnableReference(), src, format, len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1178, Column 30 in SDL_audio.h")]
        public static unsafe void MixAudioFormat(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, ushort format, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudioFormat(ref dst.GetPinnableReference(), in src.GetPinnableReference(), format, len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1178, Column 30 in SDL_audio.h")]
        public static unsafe void MixAudioFormat(this Sdl thisApi, Span<byte> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string src, ushort format, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudioFormat(ref dst.GetPinnableReference(), src, format, len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1178, Column 30 in SDL_audio.h")]
        public static unsafe void MixAudioFormat(this Sdl thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> src, ushort format, uint len, int volume)
        {
            // SpanOverloader
            thisApi.MixAudioFormat(dst, in src.GetPinnableReference(), format, len, volume);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1229, Column 29 in SDL_audio.h")]
        public static unsafe int QueueAudio<T0>(this Sdl thisApi, uint dev, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, uint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueueAudio(dev, in data.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1277, Column 32 in SDL_audio.h")]
        public static unsafe uint DequeueAudio<T0>(this Sdl thisApi, uint dev, Span<T0> data, uint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.DequeueAudio(dev, ref data.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 53, Column 29 in SDL_clipboard.h")]
        public static unsafe int SetClipboardText(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text)
        {
            // SpanOverloader
            return thisApi.SetClipboardText(in text.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 97, Column 29 in SDL_clipboard.h")]
        public static unsafe int SetPrimarySelectionText(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text)
        {
            // SpanOverloader
            return thisApi.SetPrimarySelectionText(in text.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 32 in SDL_cpuinfo.h")]
        public static unsafe void* SIMDRealloc<T0>(this Sdl thisApi, Span<T0> mem, nuint len) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SIMDRealloc(ref mem.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 584, Column 30 in SDL_cpuinfo.h")]
        public static unsafe void SIMDFree<T0>(this Sdl thisApi, Span<T0> ptr) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SIMDFree(ref ptr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 38 in SDL_keyboard.h")]
        public static unsafe byte* GetKeyboardState(this Sdl thisApi, Span<int> numkeys)
        {
            // SpanOverloader
            return thisApi.GetKeyboardState(ref numkeys.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 38 in SDL_keyboard.h")]
        public static unsafe Scancode GetScancodeFromName(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetScancodeFromName(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 244, Column 37 in SDL_keyboard.h")]
        public static unsafe int GetKeyFromName(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetKeyFromName(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 320, Column 30 in SDL_keyboard.h")]
        public static unsafe void SetTextInputRect(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            thisApi.SetTextInputRect(in rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 104, Column 32 in SDL_mouse.h")]
        public static unsafe uint GetMouseState(this Sdl thisApi, int* x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.GetMouseState(x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 104, Column 32 in SDL_mouse.h")]
        public static unsafe uint GetMouseState(this Sdl thisApi, Span<int> x, int* y)
        {
            // SpanOverloader
            return thisApi.GetMouseState(ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 104, Column 32 in SDL_mouse.h")]
        public static unsafe uint GetMouseState(this Sdl thisApi, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.GetMouseState(ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 133, Column 32 in SDL_mouse.h")]
        public static unsafe uint GetGlobalMouseState(this Sdl thisApi, int* x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.GetGlobalMouseState(x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 133, Column 32 in SDL_mouse.h")]
        public static unsafe uint GetGlobalMouseState(this Sdl thisApi, Span<int> x, int* y)
        {
            // SpanOverloader
            return thisApi.GetGlobalMouseState(ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 133, Column 32 in SDL_mouse.h")]
        public static unsafe uint GetGlobalMouseState(this Sdl thisApi, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.GetGlobalMouseState(ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 152, Column 32 in SDL_mouse.h")]
        public static unsafe uint GetRelativeMouseState(this Sdl thisApi, int* x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.GetRelativeMouseState(x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 152, Column 32 in SDL_mouse.h")]
        public static unsafe uint GetRelativeMouseState(this Sdl thisApi, Span<int> x, int* y)
        {
            // SpanOverloader
            return thisApi.GetRelativeMouseState(ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 152, Column 32 in SDL_mouse.h")]
        public static unsafe uint GetRelativeMouseState(this Sdl thisApi, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.GetRelativeMouseState(ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 37 in SDL_mouse.h")]
        public static unsafe Cursor* CreateCursor(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> mask, int w, int h, int hot_x, int hot_y)
        {
            // SpanOverloader
            return thisApi.CreateCursor(data, in mask.GetPinnableReference(), w, h, hot_x, hot_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 37 in SDL_mouse.h")]
        public static unsafe Cursor* CreateCursor(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* mask, int w, int h, int hot_x, int hot_y)
        {
            // SpanOverloader
            return thisApi.CreateCursor(in data.GetPinnableReference(), mask, w, h, hot_x, hot_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 37 in SDL_mouse.h")]
        public static unsafe Cursor* CreateCursor(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> mask, int w, int h, int hot_x, int hot_y)
        {
            // SpanOverloader
            return thisApi.CreateCursor(in data.GetPinnableReference(), in mask.GetPinnableReference(), w, h, hot_x, hot_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 37 in SDL_mouse.h")]
        public static unsafe Cursor* CreateCursor(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string mask, int w, int h, int hot_x, int hot_y)
        {
            // SpanOverloader
            return thisApi.CreateCursor(in data.GetPinnableReference(), mask, w, h, hot_x, hot_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 37 in SDL_mouse.h")]
        public static unsafe Cursor* CreateCursor(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> mask, int w, int h, int hot_x, int hot_y)
        {
            // SpanOverloader
            return thisApi.CreateCursor(data, in mask.GetPinnableReference(), w, h, hot_x, hot_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 336, Column 37 in SDL_mouse.h")]
        public static unsafe Cursor* CreateColorCursor(this Sdl thisApi, Span<Surface> surface, int hot_x, int hot_y)
        {
            // SpanOverloader
            return thisApi.CreateColorCursor(ref surface.GetPinnableReference(), hot_x, hot_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 74, Column 30 in SDL_guid.h")]
        public static unsafe void GUIDToString(this Sdl thisApi, GUID guid, Span<byte> pszGUID, int cbGUID)
        {
            // SpanOverloader
            thisApi.GUIDToString(guid, ref pszGUID.GetPinnableReference(), cbGUID);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 90, Column 34 in SDL_guid.h")]
        public static unsafe GUID GUIDFromString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pchGUID)
        {
            // SpanOverloader
            return thisApi.GUIDFromString(in pchGUID.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 29 in SDL_joystick.h")]
        public static unsafe int JoystickAttachVirtualEx(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VirtualJoystickDesc> desc)
        {
            // SpanOverloader
            return thisApi.JoystickAttachVirtualEx(in desc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 640, Column 30 in SDL_joystick.h")]
        public static unsafe void JoystickGetGUIDString(this Sdl thisApi, GUID guid, Span<byte> pszGUID, int cbGUID)
        {
            // SpanOverloader
            thisApi.JoystickGetGUIDString(guid, ref pszGUID.GetPinnableReference(), cbGUID);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 656, Column 42 in SDL_joystick.h")]
        public static unsafe GUID JoystickGetGUIDFromString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pchGUID)
        {
            // SpanOverloader
            return thisApi.JoystickGetGUIDFromString(in pchGUID.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, ushort* vendor, ushort* product, ushort* version, Span<ushort> crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, vendor, product, version, ref crc16.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, ushort* vendor, ushort* product, Span<ushort> version, ushort* crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, vendor, product, ref version.GetPinnableReference(), crc16);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, ushort* vendor, ushort* product, Span<ushort> version, Span<ushort> crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, vendor, product, ref version.GetPinnableReference(), ref crc16.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, ushort* vendor, Span<ushort> product, ushort* version, ushort* crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, vendor, ref product.GetPinnableReference(), version, crc16);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, ushort* vendor, Span<ushort> product, ushort* version, Span<ushort> crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, vendor, ref product.GetPinnableReference(), version, ref crc16.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, ushort* vendor, Span<ushort> product, Span<ushort> version, ushort* crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, vendor, ref product.GetPinnableReference(), ref version.GetPinnableReference(), crc16);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, ushort* vendor, Span<ushort> product, Span<ushort> version, Span<ushort> crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, vendor, ref product.GetPinnableReference(), ref version.GetPinnableReference(), ref crc16.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, Span<ushort> vendor, ushort* product, ushort* version, ushort* crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, ref vendor.GetPinnableReference(), product, version, crc16);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, Span<ushort> vendor, ushort* product, ushort* version, Span<ushort> crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, ref vendor.GetPinnableReference(), product, version, ref crc16.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, Span<ushort> vendor, ushort* product, Span<ushort> version, ushort* crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, ref vendor.GetPinnableReference(), product, ref version.GetPinnableReference(), crc16);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, Span<ushort> vendor, ushort* product, Span<ushort> version, Span<ushort> crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, ref vendor.GetPinnableReference(), product, ref version.GetPinnableReference(), ref crc16.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, Span<ushort> vendor, Span<ushort> product, ushort* version, ushort* crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, ref vendor.GetPinnableReference(), ref product.GetPinnableReference(), version, crc16);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, Span<ushort> vendor, Span<ushort> product, ushort* version, Span<ushort> crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, ref vendor.GetPinnableReference(), ref product.GetPinnableReference(), version, ref crc16.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, Span<ushort> vendor, Span<ushort> product, Span<ushort> version, ushort* crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, ref vendor.GetPinnableReference(), ref product.GetPinnableReference(), ref version.GetPinnableReference(), crc16);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 675, Column 30 in SDL_joystick.h")]
        public static unsafe void GetJoystickGUIDInfo(this Sdl thisApi, GUID guid, Span<ushort> vendor, Span<ushort> product, Span<ushort> version, Span<ushort> crc16)
        {
            // SpanOverloader
            thisApi.GetJoystickGUIDInfo(guid, ref vendor.GetPinnableReference(), ref product.GetPinnableReference(), ref version.GetPinnableReference(), ref crc16.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 34 in SDL_joystick.h")]
        public static unsafe SdlBool JoystickGetAxisInitialState(this Sdl thisApi, Joystick* joystick, int axis, Span<short> state)
        {
            // SpanOverloader
            return thisApi.JoystickGetAxisInitialState(joystick, axis, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 916, Column 29 in SDL_joystick.h")]
        public static unsafe int JoystickGetBall(this Sdl thisApi, Joystick* joystick, int ball, int* dx, Span<int> dy)
        {
            // SpanOverloader
            return thisApi.JoystickGetBall(joystick, ball, dx, ref dy.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 916, Column 29 in SDL_joystick.h")]
        public static unsafe int JoystickGetBall(this Sdl thisApi, Joystick* joystick, int ball, Span<int> dx, int* dy)
        {
            // SpanOverloader
            return thisApi.JoystickGetBall(joystick, ball, ref dx.GetPinnableReference(), dy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 916, Column 29 in SDL_joystick.h")]
        public static unsafe int JoystickGetBall(this Sdl thisApi, Joystick* joystick, int ball, Span<int> dx, Span<int> dy)
        {
            // SpanOverloader
            return thisApi.JoystickGetBall(joystick, ball, ref dx.GetPinnableReference(), ref dy.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1042, Column 29 in SDL_joystick.h")]
        public static unsafe int JoystickSendEffect<T0>(this Sdl thisApi, Joystick* joystick, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, int size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.JoystickSendEffect(joystick, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 270, Column 29 in SDL_sensor.h")]
        public static unsafe int SensorGetData(this Sdl thisApi, Sensor* sensor, Span<float> data, int num_values)
        {
            // SpanOverloader
            return thisApi.SensorGetData(sensor, ref data.GetPinnableReference(), num_values);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 29 in SDL_sensor.h")]
        public static unsafe int SensorGetDataWithTimestamp(this Sdl thisApi, Sensor* sensor, ulong* timestamp, Span<float> data, int num_values)
        {
            // SpanOverloader
            return thisApi.SensorGetDataWithTimestamp(sensor, timestamp, ref data.GetPinnableReference(), num_values);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 29 in SDL_sensor.h")]
        public static unsafe int SensorGetDataWithTimestamp(this Sdl thisApi, Sensor* sensor, Span<ulong> timestamp, float* data, int num_values)
        {
            // SpanOverloader
            return thisApi.SensorGetDataWithTimestamp(sensor, ref timestamp.GetPinnableReference(), data, num_values);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 29 in SDL_sensor.h")]
        public static unsafe int SensorGetDataWithTimestamp(this Sdl thisApi, Sensor* sensor, Span<ulong> timestamp, Span<float> data, int num_values)
        {
            // SpanOverloader
            return thisApi.SensorGetDataWithTimestamp(sensor, ref timestamp.GetPinnableReference(), ref data.GetPinnableReference(), num_values);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 166, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerAddMappingsFromRW(this Sdl thisApi, Span<RWops> rw, int freerw)
        {
            // SpanOverloader
            return thisApi.GameControllerAddMappingsFromRW(ref rw.GetPinnableReference(), freerw);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 202, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerAddMapping(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> mappingString)
        {
            // SpanOverloader
            return thisApi.GameControllerAddMapping(in mappingString.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 652, Column 48 in SDL_gamecontroller.h")]
        public static unsafe GameControllerAxis GameControllerGetAxisFromString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str)
        {
            // SpanOverloader
            return thisApi.GameControllerGetAxisFromString(in str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 771, Column 50 in SDL_gamecontroller.h")]
        public static unsafe GameControllerButton GameControllerGetButtonFromString(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str)
        {
            // SpanOverloader
            return thisApi.GameControllerGetButtonFromString(in str.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, byte* state, float* x, float* y, Span<float> pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, state, x, y, ref pressure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, byte* state, float* x, Span<float> y, float* pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, state, x, ref y.GetPinnableReference(), pressure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, byte* state, float* x, Span<float> y, Span<float> pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, state, x, ref y.GetPinnableReference(), ref pressure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, byte* state, Span<float> x, float* y, float* pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, state, ref x.GetPinnableReference(), y, pressure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, byte* state, Span<float> x, float* y, Span<float> pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, state, ref x.GetPinnableReference(), y, ref pressure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, byte* state, Span<float> x, Span<float> y, float* pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, state, ref x.GetPinnableReference(), ref y.GetPinnableReference(), pressure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, byte* state, Span<float> x, Span<float> y, Span<float> pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, state, ref x.GetPinnableReference(), ref y.GetPinnableReference(), ref pressure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, Span<byte> state, float* x, float* y, float* pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, ref state.GetPinnableReference(), x, y, pressure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, Span<byte> state, float* x, float* y, Span<float> pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, ref state.GetPinnableReference(), x, y, ref pressure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, Span<byte> state, float* x, Span<float> y, float* pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, ref state.GetPinnableReference(), x, ref y.GetPinnableReference(), pressure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, Span<byte> state, float* x, Span<float> y, Span<float> pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, ref state.GetPinnableReference(), x, ref y.GetPinnableReference(), ref pressure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, Span<byte> state, Span<float> x, float* y, float* pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, ref state.GetPinnableReference(), ref x.GetPinnableReference(), y, pressure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, Span<byte> state, Span<float> x, float* y, Span<float> pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, ref state.GetPinnableReference(), ref x.GetPinnableReference(), y, ref pressure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, Span<byte> state, Span<float> x, Span<float> y, float* pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, ref state.GetPinnableReference(), ref x.GetPinnableReference(), ref y.GetPinnableReference(), pressure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, Span<byte> state, Span<float> x, Span<float> y, Span<float> pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, ref state.GetPinnableReference(), ref x.GetPinnableReference(), ref y.GetPinnableReference(), ref pressure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string state, float* x, float* y, Span<float> pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, state, x, y, ref pressure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string state, float* x, Span<float> y, float* pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, state, x, ref y.GetPinnableReference(), pressure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string state, float* x, Span<float> y, Span<float> pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, state, x, ref y.GetPinnableReference(), ref pressure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string state, Span<float> x, float* y, float* pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, state, ref x.GetPinnableReference(), y, pressure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string state, Span<float> x, float* y, Span<float> pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, state, ref x.GetPinnableReference(), y, ref pressure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string state, Span<float> x, Span<float> y, float* pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, state, ref x.GetPinnableReference(), ref y.GetPinnableReference(), pressure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 856, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetTouchpadFinger(this Sdl thisApi, GameController* gamecontroller, int touchpad, int finger, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string state, Span<float> x, Span<float> y, Span<float> pressure)
        {
            // SpanOverloader
            return thisApi.GameControllerGetTouchpadFinger(gamecontroller, touchpad, finger, state, ref x.GetPinnableReference(), ref y.GetPinnableReference(), ref pressure.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 918, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetSensorData(this Sdl thisApi, GameController* gamecontroller, SensorType type, Span<float> data, int num_values)
        {
            // SpanOverloader
            return thisApi.GameControllerGetSensorData(gamecontroller, type, ref data.GetPinnableReference(), num_values);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 937, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetSensorDataWithTimestamp(this Sdl thisApi, GameController* gamecontroller, SensorType type, ulong* timestamp, Span<float> data, int num_values)
        {
            // SpanOverloader
            return thisApi.GameControllerGetSensorDataWithTimestamp(gamecontroller, type, timestamp, ref data.GetPinnableReference(), num_values);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 937, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetSensorDataWithTimestamp(this Sdl thisApi, GameController* gamecontroller, SensorType type, Span<ulong> timestamp, float* data, int num_values)
        {
            // SpanOverloader
            return thisApi.GameControllerGetSensorDataWithTimestamp(gamecontroller, type, ref timestamp.GetPinnableReference(), data, num_values);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 937, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerGetSensorDataWithTimestamp(this Sdl thisApi, GameController* gamecontroller, SensorType type, Span<ulong> timestamp, Span<float> data, int num_values)
        {
            // SpanOverloader
            return thisApi.GameControllerGetSensorDataWithTimestamp(gamecontroller, type, ref timestamp.GetPinnableReference(), ref data.GetPinnableReference(), num_values);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1045, Column 29 in SDL_gamecontroller.h")]
        public static unsafe int GameControllerSendEffect<T0>(this Sdl thisApi, GameController* gamecontroller, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, int size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GameControllerSendEffect(gamecontroller, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 29 in SDL_gesture.h")]
        public static unsafe int SaveAllDollarTemplates(this Sdl thisApi, Span<RWops> dst)
        {
            // SpanOverloader
            return thisApi.SaveAllDollarTemplates(ref dst.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 91, Column 29 in SDL_gesture.h")]
        public static unsafe int SaveDollarTemplate(this Sdl thisApi, long gestureId, Span<RWops> dst)
        {
            // SpanOverloader
            return thisApi.SaveDollarTemplate(gestureId, ref dst.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 107, Column 29 in SDL_gesture.h")]
        public static unsafe int LoadDollarTemplates(this Sdl thisApi, long touchId, Span<RWops> src)
        {
            // SpanOverloader
            return thisApi.LoadDollarTemplates(touchId, ref src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 744, Column 29 in SDL_events.h")]
        public static unsafe int PeepEvents(this Sdl thisApi, Span<Event> events, int numevents, Eventaction action, uint minType, uint maxType)
        {
            // SpanOverloader
            return thisApi.PeepEvents(ref events.GetPinnableReference(), numevents, action, minType, maxType);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 876, Column 29 in SDL_events.h")]
        public static unsafe int PollEvent(this Sdl thisApi, Span<Event> @event)
        {
            // SpanOverloader
            return thisApi.PollEvent(ref @event.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 898, Column 29 in SDL_events.h")]
        public static unsafe int WaitEvent(this Sdl thisApi, Span<Event> @event)
        {
            // SpanOverloader
            return thisApi.WaitEvent(ref @event.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 924, Column 29 in SDL_events.h")]
        public static unsafe int WaitEventTimeout(this Sdl thisApi, Span<Event> @event, int timeout)
        {
            // SpanOverloader
            return thisApi.WaitEventTimeout(ref @event.GetPinnableReference(), timeout);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 29 in SDL_events.h")]
        public static unsafe int PushEvent(this Sdl thisApi, Span<Event> @event)
        {
            // SpanOverloader
            return thisApi.PushEvent(ref @event.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1017, Column 30 in SDL_events.h")]
        public static unsafe void SetEventFilter<T0>(this Sdl thisApi, PfnEventFilter filter, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetEventFilter(filter, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 34 in SDL_events.h")]
        public static unsafe SdlBool GetEventFilter(this Sdl thisApi, Span<PfnEventFilter> filter, void** userdata)
        {
            // SpanOverloader
            return thisApi.GetEventFilter(ref filter.GetPinnableReference(), userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 34 in SDL_events.h")]
        public static unsafe SdlBool GetEventFilter(this Sdl thisApi, Span<PfnEventFilter> filter, ref void* userdata)
        {
            // SpanOverloader
            return thisApi.GetEventFilter(ref filter.GetPinnableReference(), ref userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1064, Column 30 in SDL_events.h")]
        public static unsafe void AddEventWatch<T0>(this Sdl thisApi, PfnEventFilter filter, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AddEventWatch(filter, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1080, Column 30 in SDL_events.h")]
        public static unsafe void DelEventWatch<T0>(this Sdl thisApi, PfnEventFilter filter, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DelEventWatch(filter, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1099, Column 30 in SDL_events.h")]
        public static unsafe void FilterEvents<T0>(this Sdl thisApi, PfnEventFilter filter, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FilterEvents(filter, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 31 in SDL_filesystem.h")]
        public static unsafe byte* GetPrefPath(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* org, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> app)
        {
            // SpanOverloader
            return thisApi.GetPrefPath(org, in app.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 31 in SDL_filesystem.h")]
        public static unsafe byte* GetPrefPath(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> org, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* app)
        {
            // SpanOverloader
            return thisApi.GetPrefPath(in org.GetPinnableReference(), app);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 31 in SDL_filesystem.h")]
        public static unsafe byte* GetPrefPath(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> org, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> app)
        {
            // SpanOverloader
            return thisApi.GetPrefPath(in org.GetPinnableReference(), in app.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 31 in SDL_filesystem.h")]
        public static unsafe byte* GetPrefPath(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> org, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string app)
        {
            // SpanOverloader
            return thisApi.GetPrefPath(in org.GetPinnableReference(), app);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 31 in SDL_filesystem.h")]
        public static unsafe byte* GetPrefPath(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string org, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> app)
        {
            // SpanOverloader
            return thisApi.GetPrefPath(org, in app.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1058, Column 29 in SDL_haptic.h")]
        public static unsafe int HapticEffectSupported(this Sdl thisApi, Haptic* haptic, Span<HapticEffect> effect)
        {
            // SpanOverloader
            return thisApi.HapticEffectSupported(haptic, ref effect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 29 in SDL_haptic.h")]
        public static unsafe int HapticNewEffect(this Sdl thisApi, Haptic* haptic, Span<HapticEffect> effect)
        {
            // SpanOverloader
            return thisApi.HapticNewEffect(haptic, ref effect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1101, Column 29 in SDL_haptic.h")]
        public static unsafe int HapticUpdateEffect(this Sdl thisApi, Haptic* haptic, int effect, Span<HapticEffect> data)
        {
            // SpanOverloader
            return thisApi.HapticUpdateEffect(haptic, effect, ref data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 30 in SDL_hidapi.h")]
        public static unsafe void HidFreeEnumeration(this Sdl thisApi, Span<HidDeviceInfo> devs)
        {
            // SpanOverloader
            thisApi.HidFreeEnumeration(ref devs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 229, Column 42 in SDL_hidapi.h")]
        public static unsafe HidDevice* HidOpen(this Sdl thisApi, ushort vendor_id, ushort product_id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> serial_number)
        {
            // SpanOverloader
            return thisApi.HidOpen(vendor_id, product_id, in serial_number.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 243, Column 42 in SDL_hidapi.h")]
        public static unsafe HidDevice* HidOpenPath(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, int bExclusive)
        {
            // SpanOverloader
            return thisApi.HidOpenPath(in path.GetPinnableReference(), bExclusive);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 269, Column 29 in SDL_hidapi.h")]
        public static unsafe int HidWrite(this Sdl thisApi, HidDevice* dev, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, nuint length)
        {
            // SpanOverloader
            return thisApi.HidWrite(dev, in data.GetPinnableReference(), length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 29 in SDL_hidapi.h")]
        public static unsafe int HidReadTimeout(this Sdl thisApi, HidDevice* dev, Span<byte> data, nuint length, int milliseconds)
        {
            // SpanOverloader
            return thisApi.HidReadTimeout(dev, ref data.GetPinnableReference(), length, milliseconds);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 29 in SDL_hidapi.h")]
        public static unsafe int HidRead(this Sdl thisApi, HidDevice* dev, Span<byte> data, nuint length)
        {
            // SpanOverloader
            return thisApi.HidRead(dev, ref data.GetPinnableReference(), length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 29 in SDL_hidapi.h")]
        public static unsafe int HidSendFeatureReport(this Sdl thisApi, HidDevice* dev, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, nuint length)
        {
            // SpanOverloader
            return thisApi.HidSendFeatureReport(dev, in data.GetPinnableReference(), length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 29 in SDL_hidapi.h")]
        public static unsafe int HidGetFeatureReport(this Sdl thisApi, HidDevice* dev, Span<byte> data, nuint length)
        {
            // SpanOverloader
            return thisApi.HidGetFeatureReport(dev, ref data.GetPinnableReference(), length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 395, Column 29 in SDL_hidapi.h")]
        public static unsafe int HidGetManufacturerString(this Sdl thisApi, HidDevice* dev, Span<char> @string, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.HidGetManufacturerString(dev, ref @string.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 407, Column 29 in SDL_hidapi.h")]
        public static unsafe int HidGetProductString(this Sdl thisApi, HidDevice* dev, Span<char> @string, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.HidGetProductString(dev, ref @string.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 419, Column 29 in SDL_hidapi.h")]
        public static unsafe int HidGetSerialNumberString(this Sdl thisApi, HidDevice* dev, Span<char> @string, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.HidGetSerialNumberString(dev, ref @string.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 29 in SDL_hidapi.h")]
        public static unsafe int HidGetIndexedString(this Sdl thisApi, HidDevice* dev, int string_index, Span<char> @string, nuint maxlen)
        {
            // SpanOverloader
            return thisApi.HidGetIndexedString(dev, string_index, ref @string.GetPinnableReference(), maxlen);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2743, Column 34 in SDL_hints.h")]
        public static unsafe SdlBool SetHintWithPriority(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value, HintPriority priority)
        {
            // SpanOverloader
            return thisApi.SetHintWithPriority(name, in value.GetPinnableReference(), priority);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2743, Column 34 in SDL_hints.h")]
        public static unsafe SdlBool SetHintWithPriority(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value, HintPriority priority)
        {
            // SpanOverloader
            return thisApi.SetHintWithPriority(in name.GetPinnableReference(), value, priority);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2743, Column 34 in SDL_hints.h")]
        public static unsafe SdlBool SetHintWithPriority(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value, HintPriority priority)
        {
            // SpanOverloader
            return thisApi.SetHintWithPriority(in name.GetPinnableReference(), in value.GetPinnableReference(), priority);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2743, Column 34 in SDL_hints.h")]
        public static unsafe SdlBool SetHintWithPriority(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, HintPriority priority)
        {
            // SpanOverloader
            return thisApi.SetHintWithPriority(in name.GetPinnableReference(), value, priority);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2743, Column 34 in SDL_hints.h")]
        public static unsafe SdlBool SetHintWithPriority(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value, HintPriority priority)
        {
            // SpanOverloader
            return thisApi.SetHintWithPriority(name, in value.GetPinnableReference(), priority);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2763, Column 34 in SDL_hints.h")]
        public static unsafe SdlBool SetHint(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            return thisApi.SetHint(name, in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2763, Column 34 in SDL_hints.h")]
        public static unsafe SdlBool SetHint(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            // SpanOverloader
            return thisApi.SetHint(in name.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2763, Column 34 in SDL_hints.h")]
        public static unsafe SdlBool SetHint(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            return thisApi.SetHint(in name.GetPinnableReference(), in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2763, Column 34 in SDL_hints.h")]
        public static unsafe SdlBool SetHint(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            // SpanOverloader
            return thisApi.SetHint(in name.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2763, Column 34 in SDL_hints.h")]
        public static unsafe SdlBool SetHint(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            return thisApi.SetHint(name, in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2781, Column 34 in SDL_hints.h")]
        public static unsafe SdlBool ResetHint(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.ResetHint(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2809, Column 38 in SDL_hints.h")]
        public static unsafe byte* GetHint(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetHint(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2824, Column 34 in SDL_hints.h")]
        public static unsafe SdlBool GetHintBoolean(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, SdlBool default_value)
        {
            // SpanOverloader
            return thisApi.GetHintBoolean(in name.GetPinnableReference(), default_value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2848, Column 30 in SDL_hints.h")]
        public static unsafe void AddHintCallback<T0>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, PfnHintCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AddHintCallback(name, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2848, Column 30 in SDL_hints.h")]
        public static unsafe void AddHintCallback(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, PfnHintCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.AddHintCallback(in name.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2848, Column 30 in SDL_hints.h")]
        public static unsafe void AddHintCallback<T0>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, PfnHintCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AddHintCallback(in name.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2848, Column 30 in SDL_hints.h")]
        public static unsafe void AddHintCallback<T0>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PfnHintCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.AddHintCallback(name, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2864, Column 30 in SDL_hints.h")]
        public static unsafe void DelHintCallback<T0>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, PfnHintCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DelHintCallback(name, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2864, Column 30 in SDL_hints.h")]
        public static unsafe void DelHintCallback(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, PfnHintCallback callback, void* userdata)
        {
            // SpanOverloader
            thisApi.DelHintCallback(in name.GetPinnableReference(), callback, userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2864, Column 30 in SDL_hints.h")]
        public static unsafe void DelHintCallback<T0>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, PfnHintCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DelHintCallback(in name.GetPinnableReference(), callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2864, Column 30 in SDL_hints.h")]
        public static unsafe void DelHintCallback<T0>(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PfnHintCallback callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DelHintCallback(name, callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 31 in SDL_loadso.h")]
        public static unsafe void* LoadObject(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sofile)
        {
            // SpanOverloader
            return thisApi.LoadObject(in sofile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 31 in SDL_loadso.h")]
        public static unsafe void* LoadFunction(this Sdl thisApi, void* handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.LoadFunction(handle, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 31 in SDL_loadso.h")]
        public static unsafe void* LoadFunction<T0>(this Sdl thisApi, Span<T0> handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoadFunction(ref handle.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 31 in SDL_loadso.h")]
        public static unsafe void* LoadFunction<T0>(this Sdl thisApi, Span<T0> handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoadFunction(ref handle.GetPinnableReference(), in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 31 in SDL_loadso.h")]
        public static unsafe void* LoadFunction<T0>(this Sdl thisApi, Span<T0> handle, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.LoadFunction(ref handle.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 105, Column 30 in SDL_loadso.h")]
        public static unsafe void UnloadObject<T0>(this Sdl thisApi, Span<T0> handle) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UnloadObject(ref handle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 30 in SDL_log.h")]
        public static unsafe void Log(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            thisApi.Log(in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 203, Column 30 in SDL_log.h")]
        public static unsafe void LogVerbose(this Sdl thisApi, int category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            thisApi.LogVerbose(category, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 30 in SDL_log.h")]
        public static unsafe void LogDebug(this Sdl thisApi, int category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            thisApi.LogDebug(category, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 245, Column 30 in SDL_log.h")]
        public static unsafe void LogInfo(this Sdl thisApi, int category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            thisApi.LogInfo(category, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 266, Column 30 in SDL_log.h")]
        public static unsafe void LogWarn(this Sdl thisApi, int category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            thisApi.LogWarn(category, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 30 in SDL_log.h")]
        public static unsafe void LogError(this Sdl thisApi, int category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            thisApi.LogError(category, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 308, Column 30 in SDL_log.h")]
        public static unsafe void LogCritical(this Sdl thisApi, int category, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            thisApi.LogCritical(category, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 330, Column 30 in SDL_log.h")]
        public static unsafe void LogMessage(this Sdl thisApi, int category, LogPriority priority, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt)
        {
            // SpanOverloader
            thisApi.LogMessage(category, priority, in fmt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 30 in SDL_log.h")]
        public static unsafe void LogMessageV(this Sdl thisApi, int category, LogPriority priority, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* fmt, Span<byte> ap)
        {
            // SpanOverloader
            thisApi.LogMessageV(category, priority, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 30 in SDL_log.h")]
        public static unsafe void LogMessageV(this Sdl thisApi, int category, LogPriority priority, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, byte* ap)
        {
            // SpanOverloader
            thisApi.LogMessageV(category, priority, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 30 in SDL_log.h")]
        public static unsafe void LogMessageV(this Sdl thisApi, int category, LogPriority priority, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, Span<byte> ap)
        {
            // SpanOverloader
            thisApi.LogMessageV(category, priority, in fmt.GetPinnableReference(), ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 30 in SDL_log.h")]
        public static unsafe void LogMessageV(this Sdl thisApi, int category, LogPriority priority, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> fmt, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string ap)
        {
            // SpanOverloader
            thisApi.LogMessageV(category, priority, in fmt.GetPinnableReference(), ap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 30 in SDL_log.h")]
        public static unsafe void LogMessageV(this Sdl thisApi, int category, LogPriority priority, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fmt, Span<byte> ap)
        {
            // SpanOverloader
            thisApi.LogMessageV(category, priority, fmt, ref ap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 381, Column 30 in SDL_log.h")]
        public static unsafe void LogGetOutputFunction(this Sdl thisApi, Span<PfnLogOutputFunction> callback, void** userdata)
        {
            // SpanOverloader
            thisApi.LogGetOutputFunction(ref callback.GetPinnableReference(), userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 381, Column 30 in SDL_log.h")]
        public static unsafe void LogGetOutputFunction(this Sdl thisApi, Span<PfnLogOutputFunction> callback, ref void* userdata)
        {
            // SpanOverloader
            thisApi.LogGetOutputFunction(ref callback.GetPinnableReference(), ref userdata);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 393, Column 30 in SDL_log.h")]
        public static unsafe void LogSetOutputFunction<T0>(this Sdl thisApi, PfnLogOutputFunction callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogSetOutputFunction(callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 140, Column 29 in SDL_messagebox.h")]
        public static unsafe int ShowMessageBox(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MessageBoxData* messageboxdata, Span<int> buttonid)
        {
            // SpanOverloader
            return thisApi.ShowMessageBox(messageboxdata, ref buttonid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 140, Column 29 in SDL_messagebox.h")]
        public static unsafe int ShowMessageBox(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MessageBoxData> messageboxdata, int* buttonid)
        {
            // SpanOverloader
            return thisApi.ShowMessageBox(in messageboxdata.GetPinnableReference(), buttonid);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 140, Column 29 in SDL_messagebox.h")]
        public static unsafe int ShowMessageBox(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MessageBoxData> messageboxdata, Span<int> buttonid)
        {
            // SpanOverloader
            return thisApi.ShowMessageBox(in messageboxdata.GetPinnableReference(), ref buttonid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 29 in SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* title, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message, Window* window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, title, in message.GetPinnableReference(), window);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 29 in SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> title, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* message, Window* window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, in title.GetPinnableReference(), message, window);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 29 in SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> title, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message, Window* window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, in title.GetPinnableReference(), in message.GetPinnableReference(), window);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 29 in SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> title, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string message, Window* window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, in title.GetPinnableReference(), message, window);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 29 in SDL_messagebox.h")]
        public static unsafe int ShowSimpleMessageBox(this Sdl thisApi, uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string title, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message, Window* window)
        {
            // SpanOverloader
            return thisApi.ShowSimpleMessageBox(flags, title, in message.GetPinnableReference(), window);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 30 in SDL_metal.h")]
        public static unsafe void MetalDestroyView<T0>(this Sdl thisApi, Span<T0> view) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MetalDestroyView(ref view.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 31 in SDL_metal.h")]
        public static unsafe void* MetalGetLayer<T0>(this Sdl thisApi, Span<T0> view) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.MetalGetLayer(ref view.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 30 in SDL_metal.h")]
        public static unsafe void MetalGetDrawableSize(this Sdl thisApi, Window* window, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.MetalGetDrawableSize(window, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 30 in SDL_metal.h")]
        public static unsafe void MetalGetDrawableSize(this Sdl thisApi, Window* window, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.MetalGetDrawableSize(window, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 30 in SDL_metal.h")]
        public static unsafe void MetalGetDrawableSize(this Sdl thisApi, Window* window, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.MetalGetDrawableSize(window, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 40 in SDL_power.h")]
        public static unsafe PowerState GetPowerInfo(this Sdl thisApi, int* seconds, Span<int> percent)
        {
            // SpanOverloader
            return thisApi.GetPowerInfo(seconds, ref percent.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 40 in SDL_power.h")]
        public static unsafe PowerState GetPowerInfo(this Sdl thisApi, Span<int> seconds, int* percent)
        {
            // SpanOverloader
            return thisApi.GetPowerInfo(ref seconds.GetPinnableReference(), percent);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 40 in SDL_power.h")]
        public static unsafe PowerState GetPowerInfo(this Sdl thisApi, Span<int> seconds, Span<int> percent)
        {
            // SpanOverloader
            return thisApi.GetPowerInfo(ref seconds.GetPinnableReference(), ref percent.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 185, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDriverInfo(this Sdl thisApi, int index, Span<RendererInfo> info)
        {
            // SpanOverloader
            return thisApi.GetRenderDriverInfo(index, ref info.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 249, Column 40 in SDL_render.h")]
        public static unsafe Renderer* CreateSoftwareRenderer(this Sdl thisApi, Span<Surface> surface)
        {
            // SpanOverloader
            return thisApi.CreateSoftwareRenderer(ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 29 in SDL_render.h")]
        public static unsafe int GetRendererInfo(this Sdl thisApi, Renderer* renderer, Span<RendererInfo> info)
        {
            // SpanOverloader
            return thisApi.GetRendererInfo(renderer, ref info.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 308, Column 29 in SDL_render.h")]
        public static unsafe int GetRendererOutputSize(this Sdl thisApi, Renderer* renderer, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.GetRendererOutputSize(renderer, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 308, Column 29 in SDL_render.h")]
        public static unsafe int GetRendererOutputSize(this Sdl thisApi, Renderer* renderer, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.GetRendererOutputSize(renderer, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 308, Column 29 in SDL_render.h")]
        public static unsafe int GetRendererOutputSize(this Sdl thisApi, Renderer* renderer, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.GetRendererOutputSize(renderer, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 362, Column 39 in SDL_render.h")]
        public static unsafe Texture* CreateTextureFromSurface(this Sdl thisApi, Renderer* renderer, Span<Surface> surface)
        {
            // SpanOverloader
            return thisApi.CreateTextureFromSurface(renderer, ref surface.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, uint* format, int* access, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, format, access, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, uint* format, int* access, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, format, access, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, uint* format, int* access, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, format, access, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, uint* format, Span<int> access, int* w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, format, ref access.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, uint* format, Span<int> access, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, format, ref access.GetPinnableReference(), w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, uint* format, Span<int> access, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, format, ref access.GetPinnableReference(), ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, uint* format, Span<int> access, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, format, ref access.GetPinnableReference(), ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, int* access, int* w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), access, w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, int* access, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), access, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, int* access, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), access, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, int* access, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), access, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, Span<int> access, int* w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), ref access.GetPinnableReference(), w, h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, Span<int> access, int* w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), ref access.GetPinnableReference(), w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, Span<int> access, Span<int> w, int* h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), ref access.GetPinnableReference(), ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 386, Column 29 in SDL_render.h")]
        public static unsafe int QueryTexture(this Sdl thisApi, Texture* texture, Span<uint> format, Span<int> access, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            return thisApi.QueryTexture(texture, ref format.GetPinnableReference(), ref access.GetPinnableReference(), ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, byte* r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, byte* r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, byte* r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, byte* r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, byte* g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, ref r.GetPinnableReference(), g, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, byte* b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, ref g.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, ref g.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 433, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureColorMod(this Sdl thisApi, Texture* texture, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b)
        {
            // SpanOverloader
            return thisApi.GetTextureColorMod(texture, r, g, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 474, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureAlphaMod(this Sdl thisApi, Texture* texture, Span<byte> alpha)
        {
            // SpanOverloader
            return thisApi.GetTextureAlphaMod(texture, ref alpha.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureBlendMode(this Sdl thisApi, Texture* texture, Span<BlendMode> blendMode)
        {
            // SpanOverloader
            return thisApi.GetTextureBlendMode(texture, ref blendMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 538, Column 29 in SDL_render.h")]
        public static unsafe int GetTextureScaleMode(this Sdl thisApi, Texture* texture, Span<ScaleMode> scaleMode)
        {
            // SpanOverloader
            return thisApi.GetTextureScaleMode(texture, ref scaleMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 552, Column 29 in SDL_render.h")]
        public static unsafe int SetTextureUserData<T0>(this Sdl thisApi, Texture* texture, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetTextureUserData(texture, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 597, Column 29 in SDL_render.h")]
        public static unsafe int UpdateTexture<T0>(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pixels, int pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.UpdateTexture(texture, rect, in pixels.GetPinnableReference(), pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 597, Column 29 in SDL_render.h")]
        public static unsafe int UpdateTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels, int pitch)
        {
            // SpanOverloader
            return thisApi.UpdateTexture(texture, in rect.GetPinnableReference(), pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 597, Column 29 in SDL_render.h")]
        public static unsafe int UpdateTexture<T0>(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pixels, int pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.UpdateTexture(texture, in rect.GetPinnableReference(), in pixels.GetPinnableReference(), pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, Uplane, Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, in Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, in Uplane.GetPinnableReference(), Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, in Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, Uplane, Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, in Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, in Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, in Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, in Yplane.GetPinnableReference(), Ypitch, in Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, in Yplane.GetPinnableReference(), Ypitch, in Uplane.GetPinnableReference(), Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, in Yplane.GetPinnableReference(), Ypitch, in Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, in Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, in Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, in Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, Uplane, Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, in Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, in Uplane.GetPinnableReference(), Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, in Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, rect, Yplane, Ypitch, Uplane, Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, in Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, in Uplane.GetPinnableReference(), Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, in Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), in Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), in Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), in Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), in Yplane.GetPinnableReference(), Ypitch, in Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), in Yplane.GetPinnableReference(), Ypitch, in Uplane.GetPinnableReference(), Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), in Yplane.GetPinnableReference(), Ypitch, in Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), in Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), in Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), in Yplane.GetPinnableReference(), Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, in Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, in Uplane.GetPinnableReference(), Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, in Uplane.GetPinnableReference(), Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, in Vplane.GetPinnableReference(), Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 628, Column 29 in SDL_render.h")]
        public static unsafe int UpdateYUVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Uplane, int Upitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Vplane, int Vpitch)
        {
            // SpanOverloader
            return thisApi.UpdateYUVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, Uplane, Upitch, Vplane, Vpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        public static unsafe int UpdateNVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> UVplane, int UVpitch)
        {
            // SpanOverloader
            return thisApi.UpdateNVTexture(texture, rect, Yplane, Ypitch, in UVplane.GetPinnableReference(), UVpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        public static unsafe int UpdateNVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* UVplane, int UVpitch)
        {
            // SpanOverloader
            return thisApi.UpdateNVTexture(texture, rect, in Yplane.GetPinnableReference(), Ypitch, UVplane, UVpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        public static unsafe int UpdateNVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> UVplane, int UVpitch)
        {
            // SpanOverloader
            return thisApi.UpdateNVTexture(texture, rect, in Yplane.GetPinnableReference(), Ypitch, in UVplane.GetPinnableReference(), UVpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        public static unsafe int UpdateNVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string UVplane, int UVpitch)
        {
            // SpanOverloader
            return thisApi.UpdateNVTexture(texture, rect, in Yplane.GetPinnableReference(), Ypitch, UVplane, UVpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        public static unsafe int UpdateNVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> UVplane, int UVpitch)
        {
            // SpanOverloader
            return thisApi.UpdateNVTexture(texture, rect, Yplane, Ypitch, in UVplane.GetPinnableReference(), UVpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        public static unsafe int UpdateNVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* UVplane, int UVpitch)
        {
            // SpanOverloader
            return thisApi.UpdateNVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, UVplane, UVpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        public static unsafe int UpdateNVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> UVplane, int UVpitch)
        {
            // SpanOverloader
            return thisApi.UpdateNVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, in UVplane.GetPinnableReference(), UVpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        public static unsafe int UpdateNVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string UVplane, int UVpitch)
        {
            // SpanOverloader
            return thisApi.UpdateNVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, UVplane, UVpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        public static unsafe int UpdateNVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* UVplane, int UVpitch)
        {
            // SpanOverloader
            return thisApi.UpdateNVTexture(texture, in rect.GetPinnableReference(), in Yplane.GetPinnableReference(), Ypitch, UVplane, UVpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        public static unsafe int UpdateNVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> UVplane, int UVpitch)
        {
            // SpanOverloader
            return thisApi.UpdateNVTexture(texture, in rect.GetPinnableReference(), in Yplane.GetPinnableReference(), Ypitch, in UVplane.GetPinnableReference(), UVpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        public static unsafe int UpdateNVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string UVplane, int UVpitch)
        {
            // SpanOverloader
            return thisApi.UpdateNVTexture(texture, in rect.GetPinnableReference(), in Yplane.GetPinnableReference(), Ypitch, UVplane, UVpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        public static unsafe int UpdateNVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* UVplane, int UVpitch)
        {
            // SpanOverloader
            return thisApi.UpdateNVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, UVplane, UVpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        public static unsafe int UpdateNVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> UVplane, int UVpitch)
        {
            // SpanOverloader
            return thisApi.UpdateNVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, in UVplane.GetPinnableReference(), UVpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 29 in SDL_render.h")]
        public static unsafe int UpdateNVTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string Yplane, int Ypitch, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string UVplane, int UVpitch)
        {
            // SpanOverloader
            return thisApi.UpdateNVTexture(texture, in rect.GetPinnableReference(), Yplane, Ypitch, UVplane, UVpitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 686, Column 29 in SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, void** pixels, Span<int> pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(texture, rect, pixels, ref pitch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 686, Column 29 in SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, ref void* pixels, Span<int> pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(texture, rect, ref pixels, ref pitch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 686, Column 29 in SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, void** pixels, int* pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(texture, in rect.GetPinnableReference(), pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 686, Column 29 in SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, void** pixels, Span<int> pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(texture, in rect.GetPinnableReference(), pixels, ref pitch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 686, Column 29 in SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, ref void* pixels, int* pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(texture, in rect.GetPinnableReference(), ref pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 686, Column 29 in SDL_render.h")]
        public static unsafe int LockTexture(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, ref void* pixels, Span<int> pitch)
        {
            // SpanOverloader
            return thisApi.LockTexture(texture, in rect.GetPinnableReference(), ref pixels, ref pitch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 29 in SDL_render.h")]
        public static unsafe int LockTextureToSurface(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, Surface** surface)
        {
            // SpanOverloader
            return thisApi.LockTextureToSurface(texture, in rect.GetPinnableReference(), surface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 29 in SDL_render.h")]
        public static unsafe int LockTextureToSurface(this Sdl thisApi, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, ref Surface* surface)
        {
            // SpanOverloader
            return thisApi.LockTextureToSurface(texture, in rect.GetPinnableReference(), ref surface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 30 in SDL_render.h")]
        public static unsafe void RenderGetLogicalSize(this Sdl thisApi, Renderer* renderer, int* w, Span<int> h)
        {
            // SpanOverloader
            thisApi.RenderGetLogicalSize(renderer, w, ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 30 in SDL_render.h")]
        public static unsafe void RenderGetLogicalSize(this Sdl thisApi, Renderer* renderer, Span<int> w, int* h)
        {
            // SpanOverloader
            thisApi.RenderGetLogicalSize(renderer, ref w.GetPinnableReference(), h);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 30 in SDL_render.h")]
        public static unsafe void RenderGetLogicalSize(this Sdl thisApi, Renderer* renderer, Span<int> w, Span<int> h)
        {
            // SpanOverloader
            thisApi.RenderGetLogicalSize(renderer, ref w.GetPinnableReference(), ref h.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 895, Column 29 in SDL_render.h")]
        public static unsafe int RenderSetViewport(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.RenderSetViewport(renderer, in rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 908, Column 30 in SDL_render.h")]
        public static unsafe void RenderGetViewport(this Sdl thisApi, Renderer* renderer, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            thisApi.RenderGetViewport(renderer, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 926, Column 29 in SDL_render.h")]
        public static unsafe int RenderSetClipRect(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.RenderSetClipRect(renderer, in rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 942, Column 30 in SDL_render.h")]
        public static unsafe void RenderGetClipRect(this Sdl thisApi, Renderer* renderer, Span<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            thisApi.RenderGetClipRect(renderer, ref rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 30 in SDL_render.h")]
        public static unsafe void RenderGetScale(this Sdl thisApi, Renderer* renderer, float* scaleX, Span<float> scaleY)
        {
            // SpanOverloader
            thisApi.RenderGetScale(renderer, scaleX, ref scaleY.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 30 in SDL_render.h")]
        public static unsafe void RenderGetScale(this Sdl thisApi, Renderer* renderer, Span<float> scaleX, float* scaleY)
        {
            // SpanOverloader
            thisApi.RenderGetScale(renderer, ref scaleX.GetPinnableReference(), scaleY);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 30 in SDL_render.h")]
        public static unsafe void RenderGetScale(this Sdl thisApi, Renderer* renderer, Span<float> scaleX, Span<float> scaleY)
        {
            // SpanOverloader
            thisApi.RenderGetScale(renderer, ref scaleX.GetPinnableReference(), ref scaleY.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 30 in SDL_render.h")]
        public static unsafe void RenderWindowToLogical(this Sdl thisApi, Renderer* renderer, int windowX, int windowY, float* logicalX, Span<float> logicalY)
        {
            // SpanOverloader
            thisApi.RenderWindowToLogical(renderer, windowX, windowY, logicalX, ref logicalY.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 30 in SDL_render.h")]
        public static unsafe void RenderWindowToLogical(this Sdl thisApi, Renderer* renderer, int windowX, int windowY, Span<float> logicalX, float* logicalY)
        {
            // SpanOverloader
            thisApi.RenderWindowToLogical(renderer, windowX, windowY, ref logicalX.GetPinnableReference(), logicalY);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 30 in SDL_render.h")]
        public static unsafe void RenderWindowToLogical(this Sdl thisApi, Renderer* renderer, int windowX, int windowY, Span<float> logicalX, Span<float> logicalY)
        {
            // SpanOverloader
            thisApi.RenderWindowToLogical(renderer, windowX, windowY, ref logicalX.GetPinnableReference(), ref logicalY.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 30 in SDL_render.h")]
        public static unsafe void RenderLogicalToWindow(this Sdl thisApi, Renderer* renderer, float logicalX, float logicalY, int* windowX, Span<int> windowY)
        {
            // SpanOverloader
            thisApi.RenderLogicalToWindow(renderer, logicalX, logicalY, windowX, ref windowY.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 30 in SDL_render.h")]
        public static unsafe void RenderLogicalToWindow(this Sdl thisApi, Renderer* renderer, float logicalX, float logicalY, Span<int> windowX, int* windowY)
        {
            // SpanOverloader
            thisApi.RenderLogicalToWindow(renderer, logicalX, logicalY, ref windowX.GetPinnableReference(), windowY);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1046, Column 30 in SDL_render.h")]
        public static unsafe void RenderLogicalToWindow(this Sdl thisApi, Renderer* renderer, float logicalX, float logicalY, Span<int> windowX, Span<int> windowY)
        {
            // SpanOverloader
            thisApi.RenderLogicalToWindow(renderer, logicalX, logicalY, ref windowX.GetPinnableReference(), ref windowY.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, byte* g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, byte* r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, Span<byte> r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, ref r.GetPinnableReference(), g, b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, byte* g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, byte* b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, byte* b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, Span<byte> g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, ref g.GetPinnableReference(), b, a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, byte* b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, byte* a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, Span<byte> b, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, ref b.GetPinnableReference(), a);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1102, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawColor(this Sdl thisApi, Renderer* renderer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string r, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string g, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string b, Span<byte> a)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawColor(renderer, r, g, b, ref a.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 29 in SDL_render.h")]
        public static unsafe int GetRenderDrawBlendMode(this Sdl thisApi, Renderer* renderer, Span<BlendMode> blendMode)
        {
            // SpanOverloader
            return thisApi.GetRenderDrawBlendMode(renderer, ref blendMode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1213, Column 29 in SDL_render.h")]
        public static unsafe int RenderDrawPoints(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Point> points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawPoints(renderer, in points.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1270, Column 29 in SDL_render.h")]
        public static unsafe int RenderDrawLines(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Point> points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawLines(renderer, in points.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1296, Column 29 in SDL_render.h")]
        public static unsafe int RenderDrawRect(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.RenderDrawRect(renderer, in rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1322, Column 29 in SDL_render.h")]
        public static unsafe int RenderDrawRects(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawRects(renderer, in rects.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1352, Column 29 in SDL_render.h")]
        public static unsafe int RenderFillRect(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect)
        {
            // SpanOverloader
            return thisApi.RenderFillRect(renderer, in rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1377, Column 29 in SDL_render.h")]
        public static unsafe int RenderFillRects(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderFillRects(renderer, in rects.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(renderer, texture, srcrect, in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(renderer, texture, in srcrect.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1409, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopy(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopy(renderer, texture, in srcrect.GetPinnableReference(), in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, texture, srcrect, dstrect, angle, in center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, texture, srcrect, in dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, texture, srcrect, in dstrect.GetPinnableReference(), angle, in center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, texture, in srcrect.GetPinnableReference(), dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, texture, in srcrect.GetPinnableReference(), dstrect, angle, in center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Point* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, texture, in srcrect.GetPinnableReference(), in dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1453, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyEx(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Point> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyEx(renderer, texture, in srcrect.GetPinnableReference(), in dstrect.GetPinnableReference(), angle, in center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 29 in SDL_render.h")]
        public static unsafe int RenderDrawPointsF(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FPoint> points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawPointsF(renderer, in points.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 29 in SDL_render.h")]
        public static unsafe int RenderDrawLinesF(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FPoint> points, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawLinesF(renderer, in points.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1529, Column 29 in SDL_render.h")]
        public static unsafe int RenderDrawRectF(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect)
        {
            // SpanOverloader
            return thisApi.RenderDrawRectF(renderer, in rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1543, Column 29 in SDL_render.h")]
        public static unsafe int RenderDrawRectsF(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderDrawRectsF(renderer, in rects.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1558, Column 29 in SDL_render.h")]
        public static unsafe int RenderFillRectF(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rect)
        {
            // SpanOverloader
            return thisApi.RenderFillRectF(renderer, in rect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1572, Column 29 in SDL_render.h")]
        public static unsafe int RenderFillRectsF(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> rects, int count)
        {
            // SpanOverloader
            return thisApi.RenderFillRectsF(renderer, in rects.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1590, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(renderer, texture, srcrect, in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1590, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(renderer, texture, in srcrect.GetPinnableReference(), dstrect);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1590, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyF(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> dstrect)
        {
            // SpanOverloader
            return thisApi.RenderCopyF(renderer, texture, in srcrect.GetPinnableReference(), in dstrect.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, texture, srcrect, dstrect, angle, in center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, texture, srcrect, in dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, texture, srcrect, in dstrect.GetPinnableReference(), angle, in center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, texture, in srcrect.GetPinnableReference(), dstrect, angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FRect* dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, texture, in srcrect.GetPinnableReference(), dstrect, angle, in center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FPoint* center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, texture, in srcrect.GetPinnableReference(), in dstrect.GetPinnableReference(), angle, center, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1616, Column 29 in SDL_render.h")]
        public static unsafe int RenderCopyExF(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> srcrect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FRect> dstrect, double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FPoint> center, RendererFlip flip)
        {
            // SpanOverloader
            return thisApi.RenderCopyExF(renderer, texture, in srcrect.GetPinnableReference(), in dstrect.GetPinnableReference(), angle, in center.GetPinnableReference(), flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometry(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Vertex* vertices, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> indices, int num_indices)
        {
            // SpanOverloader
            return thisApi.RenderGeometry(renderer, texture, vertices, num_vertices, in indices.GetPinnableReference(), num_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometry(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Vertex> vertices, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* indices, int num_indices)
        {
            // SpanOverloader
            return thisApi.RenderGeometry(renderer, texture, in vertices.GetPinnableReference(), num_vertices, indices, num_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1644, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometry(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Vertex> vertices, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> indices, int num_indices)
        {
            // SpanOverloader
            return thisApi.RenderGeometry(renderer, texture, in vertices.GetPinnableReference(), num_vertices, in indices.GetPinnableReference(), num_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw<T0>(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Color* color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, int num_indices, int size_indices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, xy, xy_stride, color, color_stride, uv, uv_stride, num_vertices, in indices.GetPinnableReference(), num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Color* color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, int num_indices, int size_indices)
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, xy, xy_stride, color, color_stride, in uv.GetPinnableReference(), uv_stride, num_vertices, indices, num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw<T0>(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Color* color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, int num_indices, int size_indices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, xy, xy_stride, color, color_stride, in uv.GetPinnableReference(), uv_stride, num_vertices, in indices.GetPinnableReference(), num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Color> color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, int num_indices, int size_indices)
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, xy, xy_stride, in color.GetPinnableReference(), color_stride, uv, uv_stride, num_vertices, indices, num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw<T0>(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Color> color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, int num_indices, int size_indices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, xy, xy_stride, in color.GetPinnableReference(), color_stride, uv, uv_stride, num_vertices, in indices.GetPinnableReference(), num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Color> color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, int num_indices, int size_indices)
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, xy, xy_stride, in color.GetPinnableReference(), color_stride, in uv.GetPinnableReference(), uv_stride, num_vertices, indices, num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw<T0>(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Color> color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, int num_indices, int size_indices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, xy, xy_stride, in color.GetPinnableReference(), color_stride, in uv.GetPinnableReference(), uv_stride, num_vertices, in indices.GetPinnableReference(), num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Color* color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, int num_indices, int size_indices)
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, in xy.GetPinnableReference(), xy_stride, color, color_stride, uv, uv_stride, num_vertices, indices, num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw<T0>(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Color* color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, int num_indices, int size_indices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, in xy.GetPinnableReference(), xy_stride, color, color_stride, uv, uv_stride, num_vertices, in indices.GetPinnableReference(), num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Color* color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, int num_indices, int size_indices)
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, in xy.GetPinnableReference(), xy_stride, color, color_stride, in uv.GetPinnableReference(), uv_stride, num_vertices, indices, num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw<T0>(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Color* color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, int num_indices, int size_indices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, in xy.GetPinnableReference(), xy_stride, color, color_stride, in uv.GetPinnableReference(), uv_stride, num_vertices, in indices.GetPinnableReference(), num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Color> color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, int num_indices, int size_indices)
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, in xy.GetPinnableReference(), xy_stride, in color.GetPinnableReference(), color_stride, uv, uv_stride, num_vertices, indices, num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw<T0>(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Color> color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, int num_indices, int size_indices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, in xy.GetPinnableReference(), xy_stride, in color.GetPinnableReference(), color_stride, uv, uv_stride, num_vertices, in indices.GetPinnableReference(), num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Color> color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, int num_indices, int size_indices)
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, in xy.GetPinnableReference(), xy_stride, in color.GetPinnableReference(), color_stride, in uv.GetPinnableReference(), uv_stride, num_vertices, indices, num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1674, Column 29 in SDL_render.h")]
        public static unsafe int RenderGeometryRaw<T0>(this Sdl thisApi, Renderer* renderer, Texture* texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> xy, int xy_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Color> color, int color_stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> uv, int uv_stride, int num_vertices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, int num_indices, int size_indices) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RenderGeometryRaw(renderer, texture, in xy.GetPinnableReference(), xy_stride, in color.GetPinnableReference(), color_stride, in uv.GetPinnableReference(), uv_stride, num_vertices, in indices.GetPinnableReference(), num_indices, size_indices);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 29 in SDL_render.h")]
        public static unsafe int RenderReadPixels<T0>(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* rect, uint format, Span<T0> pixels, int pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RenderReadPixels(renderer, rect, format, ref pixels.GetPinnableReference(), pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 29 in SDL_render.h")]
        public static unsafe int RenderReadPixels(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, uint format, void* pixels, int pitch)
        {
            // SpanOverloader
            return thisApi.RenderReadPixels(renderer, in rect.GetPinnableReference(), format, pixels, pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1708, Column 29 in SDL_render.h")]
        public static unsafe int RenderReadPixels<T0>(this Sdl thisApi, Renderer* renderer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Rectangle<int>> rect, uint format, Span<T0> pixels, int pitch) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RenderReadPixels(renderer, in rect.GetPinnableReference(), format, ref pixels.GetPinnableReference(), pitch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1851, Column 29 in SDL_render.h")]
        public static unsafe int GLBindTexture(this Sdl thisApi, Texture* texture, float* texw, Span<float> texh)
        {
            // SpanOverloader
            return thisApi.GLBindTexture(texture, texw, ref texh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1851, Column 29 in SDL_render.h")]
        public static unsafe int GLBindTexture(this Sdl thisApi, Texture* texture, Span<float> texw, float* texh)
        {
            // SpanOverloader
            return thisApi.GLBindTexture(texture, ref texw.GetPinnableReference(), texh);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1851, Column 29 in SDL_render.h")]
        public static unsafe int GLBindTexture(this Sdl thisApi, Texture* texture, Span<float> texw, Span<float> texh)
        {
            // SpanOverloader
            return thisApi.GLBindTexture(texture, ref texw.GetPinnableReference(), ref texh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 69, Column 38 in SDL_shape.h")]
        public static unsafe Window* CreateShapedWindow(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> title, uint x, uint y, uint w, uint h, uint flags)
        {
            // SpanOverloader
            return thisApi.CreateShapedWindow(in title.GetPinnableReference(), x, y, w, h, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 29 in SDL_shape.h")]
        public static unsafe int SetWindowShape(this Sdl thisApi, Window* window, Surface* shape, Span<WindowShapeModeVal> shape_mode)
        {
            // SpanOverloader
            return thisApi.SetWindowShape(window, shape, ref shape_mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 29 in SDL_shape.h")]
        public static unsafe int SetWindowShape(this Sdl thisApi, Window* window, Span<Surface> shape, WindowShapeModeVal* shape_mode)
        {
            // SpanOverloader
            return thisApi.SetWindowShape(window, ref shape.GetPinnableReference(), shape_mode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 29 in SDL_shape.h")]
        public static unsafe int SetWindowShape(this Sdl thisApi, Window* window, Span<Surface> shape, Span<WindowShapeModeVal> shape_mode)
        {
            // SpanOverloader
            return thisApi.SetWindowShape(window, ref shape.GetPinnableReference(), ref shape_mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 147, Column 29 in SDL_shape.h")]
        public static unsafe int GetShapedWindowMode(this Sdl thisApi, Window* window, Span<WindowShapeModeVal> shape_mode)
        {
            // SpanOverloader
            return thisApi.GetShapedWindowMode(window, ref shape_mode.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 30 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        public static unsafe void SetWindowsMessageHook<T0>(this Sdl thisApi, PfnWindowsMessageHook callback, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetWindowsMessageHook(callback, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        public static unsafe SdlBool DXGIGetOutputInfo(this Sdl thisApi, int displayIndex, int* adapterIndex, Span<int> outputIndex)
        {
            // SpanOverloader
            return thisApi.DXGIGetOutputInfo(displayIndex, adapterIndex, ref outputIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        public static unsafe SdlBool DXGIGetOutputInfo(this Sdl thisApi, int displayIndex, Span<int> adapterIndex, int* outputIndex)
        {
            // SpanOverloader
            return thisApi.DXGIGetOutputInfo(displayIndex, ref adapterIndex.GetPinnableReference(), outputIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 34 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        public static unsafe SdlBool DXGIGetOutputInfo(this Sdl thisApi, int displayIndex, Span<int> adapterIndex, Span<int> outputIndex)
        {
            // SpanOverloader
            return thisApi.DXGIGetOutputInfo(displayIndex, ref adapterIndex.GetPinnableReference(), ref outputIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 225, Column 29 in SDL_system.h")]
        public static unsafe int IPhoneSetAnimationCallback<T0>(this Sdl thisApi, Window* window, int interval, PfnFreeFunc callback, Span<T0> callbackParam) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.IPhoneSetAnimationCallback(window, interval, callback, ref callbackParam.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 428, Column 34 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        public static unsafe SdlBool AndroidRequestPermission(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> permission)
        {
            // SpanOverloader
            return thisApi.AndroidRequestPermission(in permission.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 29 in SDL_system.h")]
        [ExcludeFromOverride(0)]
        public static unsafe int AndroidShowToast(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> message, int duration, int gravity, int xoffset, int yoffset)
        {
            // SpanOverloader
            return thisApi.AndroidShowToast(in message.GetPinnableReference(), duration, gravity, xoffset, yoffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 196, Column 37 in SDL_timer.h")]
        public static unsafe int AddTimer<T0>(this Sdl thisApi, uint interval, PfnTimerCallback callback, Span<T0> param) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.AddTimer(interval, callback, ref param.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 141, Column 30 in SDL_version.h")]
        public static unsafe void GetVersion(this Sdl thisApi, Span<Version> ver)
        {
            // SpanOverloader
            thisApi.GetVersion(ref ver.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 69, Column 29 in SDL_misc.h")]
        public static unsafe int OpenURL(this Sdl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> url)
        {
            // SpanOverloader
            return thisApi.OpenURL(in url.GetPinnableReference());
        }

    }
}

