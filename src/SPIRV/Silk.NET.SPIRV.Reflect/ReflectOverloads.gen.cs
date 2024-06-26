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

namespace Silk.NET.SPIRV.Reflect
{
    public static class ReflectOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 18 in spirv_reflect.h")]
        public static unsafe Result CreateShaderModule(this Reflect thisApi, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, Span<ReflectShaderModule> p_module)
        {
            // SpanOverloader
            return thisApi.CreateShaderModule(size, p_code, ref p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 18 in spirv_reflect.h")]
        public static unsafe Result CreateShaderModule<T0>(this Reflect thisApi, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> p_code, ReflectShaderModule* p_module) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateShaderModule(size, in p_code.GetPinnableReference(), p_module);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 18 in spirv_reflect.h")]
        public static unsafe Result CreateShaderModule<T0>(this Reflect thisApi, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> p_code, Span<ReflectShaderModule> p_module) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateShaderModule(size, in p_code.GetPinnableReference(), ref p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 18 in spirv_reflect.h")]
        public static unsafe Result CreateShaderModule2(this Reflect thisApi, uint flags, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, Span<ReflectShaderModule> p_module)
        {
            // SpanOverloader
            return thisApi.CreateShaderModule2(flags, size, p_code, ref p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 18 in spirv_reflect.h")]
        public static unsafe Result CreateShaderModule2<T0>(this Reflect thisApi, uint flags, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> p_code, ReflectShaderModule* p_module) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateShaderModule2(flags, size, in p_code.GetPinnableReference(), p_module);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 18 in spirv_reflect.h")]
        public static unsafe Result CreateShaderModule2<T0>(this Reflect thisApi, uint flags, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> p_code, Span<ReflectShaderModule> p_module) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateShaderModule2(flags, size, in p_code.GetPinnableReference(), ref p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 659, Column 18 in spirv_reflect.h")]
        public static unsafe Result GetShaderModule(this Reflect thisApi, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, Span<ReflectShaderModule> p_module)
        {
            // SpanOverloader
            return thisApi.GetShaderModule(size, p_code, ref p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 659, Column 18 in spirv_reflect.h")]
        public static unsafe Result GetShaderModule<T0>(this Reflect thisApi, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> p_code, ReflectShaderModule* p_module) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetShaderModule(size, in p_code.GetPinnableReference(), p_module);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 659, Column 18 in spirv_reflect.h")]
        public static unsafe Result GetShaderModule<T0>(this Reflect thisApi, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> p_code, Span<ReflectShaderModule> p_module) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetShaderModule(size, in p_code.GetPinnableReference(), ref p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 671, Column 6 in spirv_reflect.h")]
        public static unsafe void DestroyShaderModule(this Reflect thisApi, Span<ReflectShaderModule> p_module)
        {
            // SpanOverloader
            thisApi.DestroyShaderModule(ref p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 680, Column 10 in spirv_reflect.h")]
        public static unsafe uint GetCodeSize(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module)
        {
            // SpanOverloader
            return thisApi.GetCodeSize(in p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 689, Column 17 in spirv_reflect.h")]
        public static unsafe uint* GetCode(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module)
        {
            // SpanOverloader
            return thisApi.GetCode(in p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in spirv_reflect.h")]
        public static unsafe EntryPoint* GetEntryPoint(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point)
        {
            // SpanOverloader
            return thisApi.GetEntryPoint(p_module, in entry_point.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in spirv_reflect.h")]
        public static unsafe EntryPoint* GetEntryPoint(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point)
        {
            // SpanOverloader
            return thisApi.GetEntryPoint(in p_module.GetPinnableReference(), entry_point);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in spirv_reflect.h")]
        public static unsafe EntryPoint* GetEntryPoint(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point)
        {
            // SpanOverloader
            return thisApi.GetEntryPoint(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in spirv_reflect.h")]
        public static unsafe EntryPoint* GetEntryPoint(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point)
        {
            // SpanOverloader
            return thisApi.GetEntryPoint(in p_module.GetPinnableReference(), entry_point);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, DescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateDescriptorBindings(p_module, ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref DescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateDescriptorBindings(p_module, ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, DescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateDescriptorBindings(in p_module.GetPinnableReference(), p_count, pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref DescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateDescriptorBindings(in p_module.GetPinnableReference(), p_count, ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, DescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateDescriptorBindings(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref DescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateDescriptorBindings(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, DescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(p_module, entry_point, ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref DescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, DescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(p_module, in entry_point.GetPinnableReference(), p_count, pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref DescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(p_module, in entry_point.GetPinnableReference(), p_count, ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, DescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref DescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, DescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(p_module, entry_point, ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref DescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, DescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, p_count, pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref DescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, DescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref DescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, DescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref DescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, DescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref DescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, DescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, p_count, pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref DescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, DescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorBindings(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref DescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 772, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateDescriptorSets(p_module, ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 772, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateDescriptorSets(p_module, ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 772, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateDescriptorSets(in p_module.GetPinnableReference(), p_count, pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 772, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateDescriptorSets(in p_module.GetPinnableReference(), p_count, ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 772, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateDescriptorSets(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 772, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateDescriptorSets(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(p_module, entry_point, ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(p_module, in entry_point.GetPinnableReference(), p_count, pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(p_module, in entry_point.GetPinnableReference(), p_count, ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(p_module, entry_point, ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, p_count, pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, p_count, pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointDescriptorSets(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateInterfaceVariables(p_module, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateInterfaceVariables(p_module, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateInterfaceVariables(in p_module.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateInterfaceVariables(in p_module.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateInterfaceVariables(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateInterfaceVariables(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(p_module, entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(p_module, in entry_point.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(p_module, in entry_point.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(p_module, entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInterfaceVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateInputVariables(p_module, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateInputVariables(p_module, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateInputVariables(in p_module.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateInputVariables(in p_module.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateInputVariables(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateInputVariables(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(p_module, in entry_point.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(p_module, in entry_point.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointInputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateOutputVariables(p_module, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateOutputVariables(p_module, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateOutputVariables(in p_module.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateOutputVariables(in p_module.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateOutputVariables(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateOutputVariables(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(p_module, in entry_point.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(p_module, in entry_point.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, InterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointOutputVariables(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref InterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumeratePushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumeratePushConstantBlocks(p_module, ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumeratePushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumeratePushConstantBlocks(p_module, ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumeratePushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumeratePushConstantBlocks(in p_module.GetPinnableReference(), p_count, pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumeratePushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumeratePushConstantBlocks(in p_module.GetPinnableReference(), p_count, ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumeratePushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumeratePushConstantBlocks(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumeratePushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumeratePushConstantBlocks(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumeratePushConstants(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumeratePushConstants(p_module, ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumeratePushConstants(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumeratePushConstants(p_module, ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumeratePushConstants(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumeratePushConstants(in p_module.GetPinnableReference(), p_count, pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumeratePushConstants(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumeratePushConstants(in p_module.GetPinnableReference(), p_count, ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumeratePushConstants(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumeratePushConstants(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumeratePushConstants(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumeratePushConstants(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(p_module, entry_point, ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(p_module, in entry_point.GetPinnableReference(), p_count, pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(p_module, in entry_point.GetPinnableReference(), p_count, ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(p_module, entry_point, ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, p_count, pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, p_count, pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, BlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateEntryPointPushConstantBlocks(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref BlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.EnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateSpecializationConstants(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, SpecializationConstant** pp_constants)
        {
            // SpanOverloader
            return thisApi.EnumerateSpecializationConstants(p_module, ref p_count.GetPinnableReference(), pp_constants);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateSpecializationConstants(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref SpecializationConstant* pp_constants)
        {
            // SpanOverloader
            return thisApi.EnumerateSpecializationConstants(p_module, ref p_count.GetPinnableReference(), ref pp_constants);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateSpecializationConstants(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, SpecializationConstant** pp_constants)
        {
            // SpanOverloader
            return thisApi.EnumerateSpecializationConstants(in p_module.GetPinnableReference(), p_count, pp_constants);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateSpecializationConstants(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref SpecializationConstant* pp_constants)
        {
            // SpanOverloader
            return thisApi.EnumerateSpecializationConstants(in p_module.GetPinnableReference(), p_count, ref pp_constants);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateSpecializationConstants(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, SpecializationConstant** pp_constants)
        {
            // SpanOverloader
            return thisApi.EnumerateSpecializationConstants(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_constants);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 18 in spirv_reflect.h")]
        public static unsafe Result EnumerateSpecializationConstants(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref SpecializationConstant* pp_constants)
        {
            // SpanOverloader
            return thisApi.EnumerateSpecializationConstants(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_constants);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 36 in spirv_reflect.h")]
        public static unsafe DescriptorBinding* GetDescriptorBinding(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint binding_number, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetDescriptorBinding(p_module, binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 36 in spirv_reflect.h")]
        public static unsafe DescriptorBinding* GetDescriptorBinding(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint binding_number, uint set_number, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetDescriptorBinding(in p_module.GetPinnableReference(), binding_number, set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 36 in spirv_reflect.h")]
        public static unsafe DescriptorBinding* GetDescriptorBinding(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint binding_number, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetDescriptorBinding(in p_module.GetPinnableReference(), binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        public static unsafe DescriptorBinding* GetEntryPointDescriptorBinding(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint binding_number, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorBinding(p_module, entry_point, binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        public static unsafe DescriptorBinding* GetEntryPointDescriptorBinding(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint binding_number, uint set_number, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorBinding(p_module, in entry_point.GetPinnableReference(), binding_number, set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        public static unsafe DescriptorBinding* GetEntryPointDescriptorBinding(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint binding_number, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorBinding(p_module, in entry_point.GetPinnableReference(), binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        public static unsafe DescriptorBinding* GetEntryPointDescriptorBinding(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint binding_number, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorBinding(p_module, entry_point, binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        public static unsafe DescriptorBinding* GetEntryPointDescriptorBinding(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint binding_number, uint set_number, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorBinding(in p_module.GetPinnableReference(), entry_point, binding_number, set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        public static unsafe DescriptorBinding* GetEntryPointDescriptorBinding(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint binding_number, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorBinding(in p_module.GetPinnableReference(), entry_point, binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        public static unsafe DescriptorBinding* GetEntryPointDescriptorBinding(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint binding_number, uint set_number, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorBinding(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), binding_number, set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        public static unsafe DescriptorBinding* GetEntryPointDescriptorBinding(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint binding_number, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorBinding(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        public static unsafe DescriptorBinding* GetEntryPointDescriptorBinding(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint binding_number, uint set_number, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorBinding(in p_module.GetPinnableReference(), entry_point, binding_number, set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        public static unsafe DescriptorBinding* GetEntryPointDescriptorBinding(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint binding_number, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorBinding(in p_module.GetPinnableReference(), entry_point, binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1120, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* GetDescriptorSet(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetDescriptorSet(p_module, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1120, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* GetDescriptorSet(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint set_number, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetDescriptorSet(in p_module.GetPinnableReference(), set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1120, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* GetDescriptorSet(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetDescriptorSet(in p_module.GetPinnableReference(), set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* GetEntryPointDescriptorSet(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorSet(p_module, entry_point, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* GetEntryPointDescriptorSet(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint set_number, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorSet(p_module, in entry_point.GetPinnableReference(), set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* GetEntryPointDescriptorSet(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorSet(p_module, in entry_point.GetPinnableReference(), set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* GetEntryPointDescriptorSet(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorSet(p_module, entry_point, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* GetEntryPointDescriptorSet(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint set_number, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorSet(in p_module.GetPinnableReference(), entry_point, set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* GetEntryPointDescriptorSet(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorSet(in p_module.GetPinnableReference(), entry_point, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* GetEntryPointDescriptorSet(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint set_number, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorSet(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* GetEntryPointDescriptorSet(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorSet(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* GetEntryPointDescriptorSet(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint set_number, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorSet(in p_module.GetPinnableReference(), entry_point, set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* GetEntryPointDescriptorSet(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint set_number, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointDescriptorSet(in p_module.GetPinnableReference(), entry_point, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1171, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariableByLocation(p_module, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1171, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariableByLocation(in p_module.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1171, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariableByLocation(in p_module.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariable(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariable(p_module, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariable(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariable(in p_module.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariable(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariable(in p_module.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableByLocation(p_module, entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableByLocation(p_module, in entry_point.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableByLocation(p_module, in entry_point.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableByLocation(p_module, entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableByLocation(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableByLocation(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariableBySemantic(p_module, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariableBySemantic(p_module, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariableBySemantic(p_module, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariableBySemantic(p_module, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariableBySemantic(in p_module.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariableBySemantic(in p_module.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariableBySemantic(in p_module.GetPinnableReference(), in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariableBySemantic(in p_module.GetPinnableReference(), in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariableBySemantic(in p_module.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetInputVariableBySemantic(in p_module.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointInputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariableByLocation(p_module, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariableByLocation(in p_module.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariableByLocation(in p_module.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1293, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariable(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariable(p_module, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1293, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariable(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariable(in p_module.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1293, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariable(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariable(in p_module.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableByLocation(p_module, entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableByLocation(p_module, in entry_point.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableByLocation(p_module, in entry_point.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableByLocation(p_module, entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableByLocation(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableByLocation(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableByLocation(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariableBySemantic(p_module, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariableBySemantic(p_module, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariableBySemantic(p_module, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariableBySemantic(p_module, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariableBySemantic(in p_module.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariableBySemantic(in p_module.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariableBySemantic(in p_module.GetPinnableReference(), in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariableBySemantic(in p_module.GetPinnableReference(), in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariableBySemantic(in p_module.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetOutputVariableBySemantic(in p_module.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        public static unsafe InterfaceVariable* GetEntryPointOutputVariableBySemantic(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1400, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetPushConstantBlock(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint index, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetPushConstantBlock(p_module, index, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1400, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetPushConstantBlock(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint index, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetPushConstantBlock(in p_module.GetPinnableReference(), index, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1400, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetPushConstantBlock(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint index, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetPushConstantBlock(in p_module.GetPinnableReference(), index, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetPushConstant(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint index, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetPushConstant(p_module, index, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetPushConstant(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint index, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetPushConstant(in p_module.GetPinnableReference(), index, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetPushConstant(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint index, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetPushConstant(in p_module.GetPinnableReference(), index, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetEntryPointPushConstantBlock(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointPushConstantBlock(p_module, entry_point, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetEntryPointPushConstantBlock(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointPushConstantBlock(p_module, in entry_point.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetEntryPointPushConstantBlock(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointPushConstantBlock(p_module, in entry_point.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetEntryPointPushConstantBlock(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointPushConstantBlock(p_module, entry_point, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetEntryPointPushConstantBlock(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointPushConstantBlock(in p_module.GetPinnableReference(), entry_point, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetEntryPointPushConstantBlock(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointPushConstantBlock(in p_module.GetPinnableReference(), entry_point, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetEntryPointPushConstantBlock(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointPushConstantBlock(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetEntryPointPushConstantBlock(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointPushConstantBlock(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetEntryPointPushConstantBlock(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Result* p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointPushConstantBlock(in p_module.GetPinnableReference(), entry_point, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        public static unsafe BlockVariable* GetEntryPointPushConstantBlock(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<Result> p_result)
        {
            // SpanOverloader
            return thisApi.GetEntryPointPushConstantBlock(in p_module.GetPinnableReference(), entry_point, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeDescriptorBindingNumbers(this Reflect thisApi, ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorBinding> p_binding, uint new_binding_number, uint new_set_number)
        {
            // SpanOverloader
            return thisApi.ChangeDescriptorBindingNumbers(p_module, in p_binding.GetPinnableReference(), new_binding_number, new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeDescriptorBindingNumbers(this Reflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorBinding* p_binding, uint new_binding_number, uint new_set_number)
        {
            // SpanOverloader
            return thisApi.ChangeDescriptorBindingNumbers(ref p_module.GetPinnableReference(), p_binding, new_binding_number, new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeDescriptorBindingNumbers(this Reflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorBinding> p_binding, uint new_binding_number, uint new_set_number)
        {
            // SpanOverloader
            return thisApi.ChangeDescriptorBindingNumbers(ref p_module.GetPinnableReference(), in p_binding.GetPinnableReference(), new_binding_number, new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeDescriptorBindingNumber(this Reflect thisApi, ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorBinding> p_descriptor_binding, uint new_binding_number, uint optional_new_set_number)
        {
            // SpanOverloader
            return thisApi.ChangeDescriptorBindingNumber(p_module, in p_descriptor_binding.GetPinnableReference(), new_binding_number, optional_new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeDescriptorBindingNumber(this Reflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorBinding* p_descriptor_binding, uint new_binding_number, uint optional_new_set_number)
        {
            // SpanOverloader
            return thisApi.ChangeDescriptorBindingNumber(ref p_module.GetPinnableReference(), p_descriptor_binding, new_binding_number, optional_new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeDescriptorBindingNumber(this Reflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DescriptorBinding> p_descriptor_binding, uint new_binding_number, uint optional_new_set_number)
        {
            // SpanOverloader
            return thisApi.ChangeDescriptorBindingNumber(ref p_module.GetPinnableReference(), in p_descriptor_binding.GetPinnableReference(), new_binding_number, optional_new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeDescriptorSetNumber(this Reflect thisApi, ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectDescriptorSet> p_set, uint new_set_number)
        {
            // SpanOverloader
            return thisApi.ChangeDescriptorSetNumber(p_module, in p_set.GetPinnableReference(), new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeDescriptorSetNumber(this Reflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectDescriptorSet* p_set, uint new_set_number)
        {
            // SpanOverloader
            return thisApi.ChangeDescriptorSetNumber(ref p_module.GetPinnableReference(), p_set, new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeDescriptorSetNumber(this Reflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectDescriptorSet> p_set, uint new_set_number)
        {
            // SpanOverloader
            return thisApi.ChangeDescriptorSetNumber(ref p_module.GetPinnableReference(), in p_set.GetPinnableReference(), new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeInputVariableLocation(this Reflect thisApi, ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InterfaceVariable> p_input_variable, uint new_location)
        {
            // SpanOverloader
            return thisApi.ChangeInputVariableLocation(p_module, in p_input_variable.GetPinnableReference(), new_location);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeInputVariableLocation(this Reflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InterfaceVariable* p_input_variable, uint new_location)
        {
            // SpanOverloader
            return thisApi.ChangeInputVariableLocation(ref p_module.GetPinnableReference(), p_input_variable, new_location);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeInputVariableLocation(this Reflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InterfaceVariable> p_input_variable, uint new_location)
        {
            // SpanOverloader
            return thisApi.ChangeInputVariableLocation(ref p_module.GetPinnableReference(), in p_input_variable.GetPinnableReference(), new_location);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeOutputVariableLocation(this Reflect thisApi, ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InterfaceVariable> p_output_variable, uint new_location)
        {
            // SpanOverloader
            return thisApi.ChangeOutputVariableLocation(p_module, in p_output_variable.GetPinnableReference(), new_location);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeOutputVariableLocation(this Reflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InterfaceVariable* p_output_variable, uint new_location)
        {
            // SpanOverloader
            return thisApi.ChangeOutputVariableLocation(ref p_module.GetPinnableReference(), p_output_variable, new_location);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in spirv_reflect.h")]
        public static unsafe Result ChangeOutputVariableLocation(this Reflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<InterfaceVariable> p_output_variable, uint new_location)
        {
            // SpanOverloader
            return thisApi.ChangeOutputVariableLocation(ref p_module.GetPinnableReference(), in p_output_variable.GetPinnableReference(), new_location);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1565, Column 13 in spirv_reflect.h")]
        public static unsafe byte* BlockVariableTypeName(this Reflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BlockVariable> p_var)
        {
            // SpanOverloader
            return thisApi.BlockVariableTypeName(in p_var.GetPinnableReference());
        }

    }
}

