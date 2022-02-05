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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_shading_language_include")]
    public unsafe partial class ArbShadingLanguageInclude : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shading_language_include";
        [NativeApi(EntryPoint = "glCompileShaderIncludeARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** path, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length);

        [NativeApi(EntryPoint = "glCompileShaderIncludeARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** path, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int length);

        [NativeApi(EntryPoint = "glCompileShaderIncludeARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte* path, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length);

        [NativeApi(EntryPoint = "glCompileShaderIncludeARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte* path, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int length);

        [NativeApi(EntryPoint = "glDeleteNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glDeleteNamedStringARB", Convention = CallingConvention.Winapi)]
        public partial void DeleteNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glDeleteNamedStringARB", Convention = CallingConvention.Winapi)]
        public partial void DeleteNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string @string);

        [NativeApi(EntryPoint = "glGetNamedStringivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedStringivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedStringivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedStringivARB", Convention = CallingConvention.Winapi)]
        public partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedStringivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedStringivARB", Convention = CallingConvention.Winapi)]
        public partial void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIsNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial bool IsNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glIsNamedStringARB", Convention = CallingConvention.Winapi)]
        public partial bool IsNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glIsNamedStringARB", Convention = CallingConvention.Winapi)]
        public partial bool IsNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] byte* @string);

        [NativeApi(EntryPoint = "glNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] in byte @string);

        [NativeApi(EntryPoint = "glNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] int stringlen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string);

        [NativeApi(EntryPoint = "glNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] byte* @string);

        [NativeApi(EntryPoint = "glNamedStringARB", Convention = CallingConvention.Winapi)]
        public partial void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] in byte @string);

        [NativeApi(EntryPoint = "glNamedStringARB", Convention = CallingConvention.Winapi)]
        public partial void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] in byte name, [Flow(FlowDirection.In)] int stringlen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string);

        [NativeApi(EntryPoint = "glNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] byte* @string);

        [NativeApi(EntryPoint = "glNamedStringARB", Convention = CallingConvention.Winapi)]
        public partial void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] in byte @string);

        [NativeApi(EntryPoint = "glNamedStringARB", Convention = CallingConvention.Winapi)]
        public partial void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Flow(FlowDirection.In)] int stringlen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string);

        public unsafe void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] pathSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length)
        {
            // StringArrayOverloader
            var path = (byte**) SilkMarshal.StringArrayToPtr(pathSa);
            CompileShaderInclude(shader, count, path, length);
            SilkMarshal.CopyPtrToStringArray((nint) path, pathSa);
            SilkMarshal.Free((nint) path);
        }

        public unsafe void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] pathSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int length)
        {
            // StringArrayOverloader
            var path = (byte**) SilkMarshal.StringArrayToPtr(pathSa);
            CompileShaderInclude(shader, count, path, in length);
            SilkMarshal.CopyPtrToStringArray((nint) path, pathSa);
            SilkMarshal.Free((nint) path);
        }

        public unsafe void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** path, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> length)
        {
            // ImplicitCountSpanOverloader
            CompileShaderInclude(shader, (uint) length.Length, path, in length.GetPinnableReference());
        }

        public unsafe void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte* path, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> length)
        {
            // ImplicitCountSpanOverloader
            CompileShaderInclude(shader, (uint) length.Length, in path, in length.GetPinnableReference());
        }

        public unsafe void DeleteNamedString([Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte name)
        {
            // ArrayParameterOverloader
            DeleteNamedString(1, &name);
        }

        public unsafe void DeleteNamedString([Count(Parameter = "namelen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // ImplicitCountSpanOverloader
            DeleteNamedString((int) name.Length, in name.GetPinnableReference());
        }

        public unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> @string)
        {
            // ImplicitCountSpanOverloader
            GetNamedString(namelen, name, (uint) @string.Length, stringlen, out @string.GetPinnableReference());
        }

        public unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> @string)
        {
            // ImplicitCountSpanOverloader
            GetNamedString(namelen, name, (uint) @string.Length, stringlen, out @string.GetPinnableReference());
        }

        public unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> @string)
        {
            // ImplicitCountSpanOverloader
            GetNamedString(namelen, name, (uint) @string.Length, out stringlen, out @string.GetPinnableReference());
        }

        public unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> @string)
        {
            // ImplicitCountSpanOverloader
            GetNamedString(namelen, name, (uint) @string.Length, out stringlen, out @string.GetPinnableReference());
        }

        public unsafe void GetNamedString([Count(Parameter = "namelen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* @string)
        {
            // ImplicitCountSpanOverloader
            GetNamedString((int) name.Length, in name.GetPinnableReference(), bufSize, stringlen, @string);
        }

        public unsafe void GetNamedString([Count(Parameter = "namelen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> @string)
        {
            // ImplicitCountSpanOverloader
            GetNamedString((int) name.Length, in name.GetPinnableReference(), (uint) @string.Length, stringlen, out @string.GetPinnableReference());
        }

        public unsafe void GetNamedString([Count(Parameter = "namelen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> @string)
        {
            // ImplicitCountSpanOverloader
            GetNamedString((int) name.Length, in name.GetPinnableReference(), (uint) @string.Length, stringlen, out @string.GetPinnableReference());
        }

        public unsafe void GetNamedString([Count(Parameter = "namelen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* @string)
        {
            // ImplicitCountSpanOverloader
            GetNamedString((int) name.Length, in name.GetPinnableReference(), bufSize, out stringlen, @string);
        }

        public unsafe void GetNamedString([Count(Parameter = "namelen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> @string)
        {
            // ImplicitCountSpanOverloader
            GetNamedString((int) name.Length, in name.GetPinnableReference(), (uint) @string.Length, out stringlen, out @string.GetPinnableReference());
        }

        public unsafe void GetNamedString([Count(Parameter = "namelen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> @string)
        {
            // ImplicitCountSpanOverloader
            GetNamedString((int) name.Length, in name.GetPinnableReference(), (uint) @string.Length, out stringlen, out @string.GetPinnableReference());
        }

        public unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> @string)
        {
            // ImplicitCountSpanOverloader
            GetNamedString(namelen, name, (uint) @string.Length, stringlen, out @string.GetPinnableReference());
        }

        public unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> @string)
        {
            // ImplicitCountSpanOverloader
            GetNamedString(namelen, name, (uint) @string.Length, stringlen, out @string.GetPinnableReference());
        }

        public unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> @string)
        {
            // ImplicitCountSpanOverloader
            GetNamedString(namelen, name, (uint) @string.Length, out stringlen, out @string.GetPinnableReference());
        }

        public unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> @string)
        {
            // ImplicitCountSpanOverloader
            GetNamedString(namelen, name, (uint) @string.Length, out stringlen, out @string.GetPinnableReference());
        }

        public unsafe void GetNamedString([Count(Parameter = "namelen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
        {
            // ImplicitCountSpanOverloader
            GetNamedString((int) name.Length, in name.GetPinnableReference(), pname, @params);
        }

        public unsafe void GetNamedString([Count(Parameter = "namelen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
        {
            // ImplicitCountSpanOverloader
            GetNamedString((int) name.Length, in name.GetPinnableReference(), pname, out @params);
        }

        public unsafe bool IsNamedString([Count(Parameter = "namelen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // ImplicitCountSpanOverloader
            return IsNamedString((int) name.Length, in name.GetPinnableReference());
        }

        public unsafe void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> @string)
        {
            // ImplicitCountSpanOverloader
            NamedString(type, namelen, name, (int) @string.Length, in @string.GetPinnableReference());
        }

        public unsafe void NamedString([Flow(FlowDirection.In)] ARB type, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] byte* @string)
        {
            // ImplicitCountSpanOverloader
            NamedString(type, (int) name.Length, in name.GetPinnableReference(), stringlen, @string);
        }

        public unsafe void NamedString([Flow(FlowDirection.In)] ARB type, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> @string)
        {
            // ImplicitCountSpanOverloader
            NamedString(type, (int) name.Length, in name.GetPinnableReference(), (int) @string.Length, in @string.GetPinnableReference());
        }

        public unsafe void NamedString([Flow(FlowDirection.In)] ARB type, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(FlowDirection.In)] int stringlen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string)
        {
            // ImplicitCountSpanOverloader
            NamedString(type, (int) name.Length, in name.GetPinnableReference(), stringlen, @string);
        }

        public unsafe void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] ReadOnlySpan<byte> @string)
        {
            // ImplicitCountSpanOverloader
            NamedString(type, namelen, name, (int) @string.Length, in @string.GetPinnableReference());
        }

        public ArbShadingLanguageInclude(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

