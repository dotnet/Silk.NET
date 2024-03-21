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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbShadingLanguageIncludeOverloads
    {
        public static unsafe void CompileShaderInclude(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** path, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> length)
        {
            // SpanOverloader
            thisApi.CompileShaderInclude(shader, count, path, in length.GetPinnableReference());
        }

        public static unsafe void CompileShaderInclude(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* path, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> length)
        {
            // SpanOverloader
            thisApi.CompileShaderInclude(shader, count, in path, in length.GetPinnableReference());
        }

        public static unsafe void DeleteNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.DeleteNamedString(namelen, in name.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, name, bufSize, stringlen, out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, name, bufSize, stringlen, out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, name, bufSize, out stringlen.GetPinnableReference(), @string);
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, name, bufSize, out stringlen.GetPinnableReference(), out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, name, bufSize, out stringlen.GetPinnableReference(), out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, in name.GetPinnableReference(), bufSize, stringlen, @string);
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, in name.GetPinnableReference(), bufSize, stringlen, out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, in name.GetPinnableReference(), bufSize, stringlen, out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, in name.GetPinnableReference(), bufSize, out stringlen.GetPinnableReference(), @string);
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, in name.GetPinnableReference(), bufSize, out stringlen.GetPinnableReference(), out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, in name.GetPinnableReference(), bufSize, out stringlen.GetPinnableReference(), out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, name, bufSize, stringlen, out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, name, bufSize, stringlen, out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, name, bufSize, out stringlen.GetPinnableReference(), @string);
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, name, bufSize, out stringlen.GetPinnableReference(), out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> @string)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, name, bufSize, out stringlen.GetPinnableReference(), out @string.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, name, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, in name.GetPinnableReference(), pname, @params);
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, in name.GetPinnableReference(), pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetNamedString(namelen, name, pname, out @params.GetPinnableReference());
        }

        public static unsafe bool IsNamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.IsNamedString(namelen, in name.GetPinnableReference());
        }

        public static unsafe void NamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string)
        {
            // SpanOverloader
            thisApi.NamedString(type, namelen, name, stringlen, in @string.GetPinnableReference());
        }

        public static unsafe void NamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string)
        {
            // SpanOverloader
            thisApi.NamedString(type, namelen, in name.GetPinnableReference(), stringlen, @string);
        }

        public static unsafe void NamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string)
        {
            // SpanOverloader
            thisApi.NamedString(type, namelen, in name.GetPinnableReference(), stringlen, in @string.GetPinnableReference());
        }

        public static unsafe void NamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stringlen, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string)
        {
            // SpanOverloader
            thisApi.NamedString(type, namelen, in name.GetPinnableReference(), stringlen, @string);
        }

        public static unsafe void NamedString(this ArbShadingLanguageInclude thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> @string)
        {
            // SpanOverloader
            thisApi.NamedString(type, namelen, name, stringlen, in @string.GetPinnableReference());
        }

    }
}

