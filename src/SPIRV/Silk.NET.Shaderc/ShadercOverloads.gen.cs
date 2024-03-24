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

namespace Silk.NET.Shaderc
{
    public static class ShadercOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsAddMacroDefinition(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint name_length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value, nuint value_length)
        {
            // SpanOverloader
            thisApi.CompileOptionsAddMacroDefinition(options, name, name_length, in value.GetPinnableReference(), value_length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsAddMacroDefinition(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint name_length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value, nuint value_length)
        {
            // SpanOverloader
            thisApi.CompileOptionsAddMacroDefinition(options, in name.GetPinnableReference(), name_length, value, value_length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsAddMacroDefinition(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint name_length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value, nuint value_length)
        {
            // SpanOverloader
            thisApi.CompileOptionsAddMacroDefinition(options, in name.GetPinnableReference(), name_length, in value.GetPinnableReference(), value_length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsAddMacroDefinition(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint name_length, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value, nuint value_length)
        {
            // SpanOverloader
            thisApi.CompileOptionsAddMacroDefinition(options, in name.GetPinnableReference(), name_length, value, value_length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsAddMacroDefinition(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint name_length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value, nuint value_length)
        {
            // SpanOverloader
            thisApi.CompileOptionsAddMacroDefinition(options, name, name_length, in value.GetPinnableReference(), value_length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 384, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetIncludeCallbacks<T0>(this Shaderc thisApi, CompileOptions* options, PfnIncludeResolveFn resolver, PfnIncludeResultReleaseFn result_releaser, Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CompileOptionsSetIncludeCallbacks(options, resolver, result_releaser, ref user_data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, reg, set, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, reg, in set.GetPinnableReference(), binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, reg, in set.GetPinnableReference(), in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, reg, in set.GetPinnableReference(), binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, reg, set, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, in reg.GetPinnableReference(), set, binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, in reg.GetPinnableReference(), set, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, in reg.GetPinnableReference(), set, binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, in reg.GetPinnableReference(), in set.GetPinnableReference(), binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, in reg.GetPinnableReference(), in set.GetPinnableReference(), in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, in reg.GetPinnableReference(), in set.GetPinnableReference(), binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, in reg.GetPinnableReference(), set, binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, in reg.GetPinnableReference(), set, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, in reg.GetPinnableReference(), set, binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, reg, set, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, reg, in set.GetPinnableReference(), binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, reg, in set.GetPinnableReference(), in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, reg, in set.GetPinnableReference(), binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBindingForStage(this Shaderc thisApi, CompileOptions* options, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBindingForStage(options, shader_kind, reg, set, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, reg, set, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, reg, in set.GetPinnableReference(), binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, reg, in set.GetPinnableReference(), in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, reg, in set.GetPinnableReference(), binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, reg, set, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, in reg.GetPinnableReference(), set, binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, in reg.GetPinnableReference(), set, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, in reg.GetPinnableReference(), set, binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, in reg.GetPinnableReference(), in set.GetPinnableReference(), binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, in reg.GetPinnableReference(), in set.GetPinnableReference(), in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, in reg.GetPinnableReference(), in set.GetPinnableReference(), binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, in reg.GetPinnableReference(), set, binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, in reg.GetPinnableReference(), set, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, in reg.GetPinnableReference(), set, binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, reg, set, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, reg, in set.GetPinnableReference(), binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, reg, in set.GetPinnableReference(), in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> set, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, reg, in set.GetPinnableReference(), binding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 21 in shaderc.h")]
        public static unsafe void CompileOptionsSetHlslRegisterSetAndBinding(this Shaderc thisApi, CompileOptions* options, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string reg, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> binding)
        {
            // SpanOverloader
            thisApi.CompileOptionsSetHlslRegisterSetAndBinding(options, reg, set, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, source_text, source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, source_text, source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, in input_file_name.GetPinnableReference(), in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, source_text, source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 532, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpv(compiler, source_text, source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, source_text, source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, source_text, source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, in input_file_name.GetPinnableReference(), in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, source_text, source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoSpvAssembly(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoSpvAssembly(compiler, source_text, source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, source_text, source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, source_text, source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, in input_file_name.GetPinnableReference(), in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, in source_text.GetPinnableReference(), source_text_size, shader_kind, input_file_name, entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, source_text, source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, source_text, source_text_size, shader_kind, in input_file_name.GetPinnableReference(), entry_point_name, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* CompileIntoPreprocessedText(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source_text, nuint source_text_size, ShaderKind shader_kind, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string input_file_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point_name, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.CompileIntoPreprocessedText(compiler, source_text, source_text_size, shader_kind, input_file_name, in entry_point_name.GetPinnableReference(), additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 564, Column 45 in shaderc.h")]
        public static unsafe CompilationResult* AssembleIntoSpv(this Shaderc thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source_assembly, nuint source_assembly_size, CompileOptions* additional_options)
        {
            // SpanOverloader
            return thisApi.AssembleIntoSpv(compiler, in source_assembly.GetPinnableReference(), source_assembly_size, additional_options);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 21 in shaderc.h")]
        public static unsafe void GetSpvVersion(this Shaderc thisApi, uint* version, Span<uint> revision)
        {
            // SpanOverloader
            thisApi.GetSpvVersion(version, ref revision.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 21 in shaderc.h")]
        public static unsafe void GetSpvVersion(this Shaderc thisApi, Span<uint> version, uint* revision)
        {
            // SpanOverloader
            thisApi.GetSpvVersion(ref version.GetPinnableReference(), revision);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 606, Column 21 in shaderc.h")]
        public static unsafe void GetSpvVersion(this Shaderc thisApi, Span<uint> version, Span<uint> revision)
        {
            // SpanOverloader
            thisApi.GetSpvVersion(ref version.GetPinnableReference(), ref revision.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        public static unsafe Silk.NET.Core.Bool32 ParseVersionProfile(this Shaderc thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int* version, Span<Profile> profile)
        {
            // SpanOverloader
            return thisApi.ParseVersionProfile(str, version, ref profile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        public static unsafe Silk.NET.Core.Bool32 ParseVersionProfile(this Shaderc thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, Span<int> version, Profile* profile)
        {
            // SpanOverloader
            return thisApi.ParseVersionProfile(str, ref version.GetPinnableReference(), profile);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        public static unsafe Silk.NET.Core.Bool32 ParseVersionProfile(this Shaderc thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, Span<int> version, Span<Profile> profile)
        {
            // SpanOverloader
            return thisApi.ParseVersionProfile(str, ref version.GetPinnableReference(), ref profile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        public static unsafe Silk.NET.Core.Bool32 ParseVersionProfile(this Shaderc thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, int* version, Profile* profile)
        {
            // SpanOverloader
            return thisApi.ParseVersionProfile(in str.GetPinnableReference(), version, profile);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        public static unsafe Silk.NET.Core.Bool32 ParseVersionProfile(this Shaderc thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, int* version, Span<Profile> profile)
        {
            // SpanOverloader
            return thisApi.ParseVersionProfile(in str.GetPinnableReference(), version, ref profile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        public static unsafe Silk.NET.Core.Bool32 ParseVersionProfile(this Shaderc thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, Span<int> version, Profile* profile)
        {
            // SpanOverloader
            return thisApi.ParseVersionProfile(in str.GetPinnableReference(), ref version.GetPinnableReference(), profile);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        public static unsafe Silk.NET.Core.Bool32 ParseVersionProfile(this Shaderc thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, Span<int> version, Span<Profile> profile)
        {
            // SpanOverloader
            return thisApi.ParseVersionProfile(in str.GetPinnableReference(), ref version.GetPinnableReference(), ref profile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        public static unsafe Silk.NET.Core.Bool32 ParseVersionProfile(this Shaderc thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, int* version, Span<Profile> profile)
        {
            // SpanOverloader
            return thisApi.ParseVersionProfile(str, version, ref profile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        public static unsafe Silk.NET.Core.Bool32 ParseVersionProfile(this Shaderc thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, Span<int> version, Profile* profile)
        {
            // SpanOverloader
            return thisApi.ParseVersionProfile(str, ref version.GetPinnableReference(), profile);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 612, Column 21 in shaderc.h")]
        public static unsafe Silk.NET.Core.Bool32 ParseVersionProfile(this Shaderc thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, Span<int> version, Span<Profile> profile)
        {
            // SpanOverloader
            return thisApi.ParseVersionProfile(str, ref version.GetPinnableReference(), ref profile.GetPinnableReference());
        }

    }
}

