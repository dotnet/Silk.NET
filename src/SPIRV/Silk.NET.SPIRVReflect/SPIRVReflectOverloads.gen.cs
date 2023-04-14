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

namespace Silk.NET.SPIRVReflect
{
    public static class SPIRVReflectOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 528, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectCreateShaderModule(this SPIRVReflect thisApi, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, Span<ReflectShaderModule> p_module)
        {
            // SpanOverloader
            return thisApi.ReflectCreateShaderModule(size, p_code, ref p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 528, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectCreateShaderModule<T0>(this SPIRVReflect thisApi, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> p_code, ReflectShaderModule* p_module) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ReflectCreateShaderModule(size, in p_code.GetPinnableReference(), p_module);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 528, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectCreateShaderModule<T0>(this SPIRVReflect thisApi, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> p_code, Span<ReflectShaderModule> p_module) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ReflectCreateShaderModule(size, in p_code.GetPinnableReference(), ref p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 543, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectCreateShaderModule2(this SPIRVReflect thisApi, uint flags, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, Span<ReflectShaderModule> p_module)
        {
            // SpanOverloader
            return thisApi.ReflectCreateShaderModule2(flags, size, p_code, ref p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 543, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectCreateShaderModule2<T0>(this SPIRVReflect thisApi, uint flags, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> p_code, ReflectShaderModule* p_module) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ReflectCreateShaderModule2(flags, size, in p_code.GetPinnableReference(), p_module);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 543, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectCreateShaderModule2<T0>(this SPIRVReflect thisApi, uint flags, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> p_code, Span<ReflectShaderModule> p_module) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ReflectCreateShaderModule2(flags, size, in p_code.GetPinnableReference(), ref p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 551, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectGetShaderModule(this SPIRVReflect thisApi, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, Span<ReflectShaderModule> p_module)
        {
            // SpanOverloader
            return thisApi.ReflectGetShaderModule(size, p_code, ref p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 551, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectGetShaderModule<T0>(this SPIRVReflect thisApi, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> p_code, ReflectShaderModule* p_module) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ReflectGetShaderModule(size, in p_code.GetPinnableReference(), p_module);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 551, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectGetShaderModule<T0>(this SPIRVReflect thisApi, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> p_code, Span<ReflectShaderModule> p_module) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ReflectGetShaderModule(size, in p_code.GetPinnableReference(), ref p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 563, Column 6 in spirv_reflect.h")]
        public static unsafe void ReflectDestroyShaderModule(this SPIRVReflect thisApi, Span<ReflectShaderModule> p_module)
        {
            // SpanOverloader
            thisApi.ReflectDestroyShaderModule(ref p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 572, Column 10 in spirv_reflect.h")]
        public static unsafe uint ReflectGetCodeSize(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module)
        {
            // SpanOverloader
            return thisApi.ReflectGetCodeSize(in p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 17 in spirv_reflect.h")]
        public static unsafe uint* ReflectGetCode(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module)
        {
            // SpanOverloader
            return thisApi.ReflectGetCode(in p_module.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 29 in spirv_reflect.h")]
        public static unsafe ReflectEntryPoint* ReflectGetEntryPoint(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPoint(p_module, in entry_point.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 29 in spirv_reflect.h")]
        public static unsafe ReflectEntryPoint* ReflectGetEntryPoint(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPoint(in p_module.GetPinnableReference(), entry_point);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 29 in spirv_reflect.h")]
        public static unsafe ReflectEntryPoint* ReflectGetEntryPoint(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPoint(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 29 in spirv_reflect.h")]
        public static unsafe ReflectEntryPoint* ReflectGetEntryPoint(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPoint(in p_module.GetPinnableReference(), entry_point);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ReflectDescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateDescriptorBindings(p_module, ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref ReflectDescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateDescriptorBindings(p_module, ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ReflectDescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateDescriptorBindings(in p_module.GetPinnableReference(), p_count, pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref ReflectDescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateDescriptorBindings(in p_module.GetPinnableReference(), p_count, ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ReflectDescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateDescriptorBindings(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref ReflectDescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateDescriptorBindings(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ReflectDescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(p_module, entry_point, ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref ReflectDescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ReflectDescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(p_module, in entry_point.GetPinnableReference(), p_count, pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref ReflectDescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(p_module, in entry_point.GetPinnableReference(), p_count, ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ReflectDescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref ReflectDescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ReflectDescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(p_module, entry_point, ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref ReflectDescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectDescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, p_count, pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectDescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ReflectDescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref ReflectDescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ReflectDescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref ReflectDescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ReflectDescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref ReflectDescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectDescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, p_count, pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectDescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ReflectDescriptorBinding** pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorBindings(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref ReflectDescriptorBinding* pp_bindings)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorBindings(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_bindings);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateDescriptorSets(p_module, ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateDescriptorSets(p_module, ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateDescriptorSets(in p_module.GetPinnableReference(), p_count, pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateDescriptorSets(in p_module.GetPinnableReference(), p_count, ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateDescriptorSets(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateDescriptorSets(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(p_module, entry_point, ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(p_module, in entry_point.GetPinnableReference(), p_count, pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(p_module, in entry_point.GetPinnableReference(), p_count, ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(p_module, entry_point, ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, p_count, pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, p_count, pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ReflectDescriptorSet** pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointDescriptorSets(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref ReflectDescriptorSet* pp_sets)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointDescriptorSets(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_sets);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateInterfaceVariables(p_module, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateInterfaceVariables(p_module, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateInterfaceVariables(in p_module.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateInterfaceVariables(in p_module.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateInterfaceVariables(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateInterfaceVariables(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(p_module, entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(p_module, in entry_point.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(p_module, in entry_point.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(p_module, entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInterfaceVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInterfaceVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateInputVariables(p_module, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateInputVariables(p_module, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateInputVariables(in p_module.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateInputVariables(in p_module.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateInputVariables(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateInputVariables(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(p_module, in entry_point.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(p_module, in entry_point.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointInputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointInputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 821, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateOutputVariables(p_module, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 821, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateOutputVariables(p_module, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 821, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateOutputVariables(in p_module.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 821, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateOutputVariables(in p_module.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 821, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateOutputVariables(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 821, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateOutputVariables(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(p_module, in entry_point.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(p_module, in entry_point.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, p_count, pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ReflectInterfaceVariable** pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointOutputVariables(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref ReflectInterfaceVariable* pp_variables)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointOutputVariables(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_variables);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 874, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumeratePushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumeratePushConstantBlocks(p_module, ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 874, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumeratePushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumeratePushConstantBlocks(p_module, ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 874, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumeratePushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumeratePushConstantBlocks(in p_module.GetPinnableReference(), p_count, pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 874, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumeratePushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumeratePushConstantBlocks(in p_module.GetPinnableReference(), p_count, ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 874, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumeratePushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumeratePushConstantBlocks(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 874, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumeratePushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumeratePushConstantBlocks(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumeratePushConstants(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumeratePushConstants(p_module, ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumeratePushConstants(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, Span<uint> p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumeratePushConstants(p_module, ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumeratePushConstants(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumeratePushConstants(in p_module.GetPinnableReference(), p_count, pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumeratePushConstants(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint* p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumeratePushConstants(in p_module.GetPinnableReference(), p_count, ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumeratePushConstants(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumeratePushConstants(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumeratePushConstants(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, Span<uint> p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumeratePushConstants(in p_module.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(p_module, entry_point, ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(p_module, in entry_point.GetPinnableReference(), p_count, pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(p_module, in entry_point.GetPinnableReference(), p_count, ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(p_module, in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(p_module, entry_point, ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(p_module, entry_point, ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, p_count, pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<uint> p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint* p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_count, ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<uint> p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, p_count, pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, p_count, ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ReflectBlockVariable** pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectEnumerateEntryPointPushConstantBlocks(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<uint> p_count, ref ReflectBlockVariable* pp_blocks)
        {
            // SpanOverloader
            return thisApi.ReflectEnumerateEntryPointPushConstantBlocks(in p_module.GetPinnableReference(), entry_point, ref p_count.GetPinnableReference(), ref pp_blocks);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 936, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorBinding* ReflectGetDescriptorBinding(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint binding_number, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetDescriptorBinding(p_module, binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 936, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorBinding* ReflectGetDescriptorBinding(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint binding_number, uint set_number, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetDescriptorBinding(in p_module.GetPinnableReference(), binding_number, set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 936, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorBinding* ReflectGetDescriptorBinding(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint binding_number, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetDescriptorBinding(in p_module.GetPinnableReference(), binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint binding_number, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorBinding(p_module, entry_point, binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint binding_number, uint set_number, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorBinding(p_module, in entry_point.GetPinnableReference(), binding_number, set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint binding_number, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorBinding(p_module, in entry_point.GetPinnableReference(), binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint binding_number, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorBinding(p_module, entry_point, binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint binding_number, uint set_number, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorBinding(in p_module.GetPinnableReference(), entry_point, binding_number, set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint binding_number, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorBinding(in p_module.GetPinnableReference(), entry_point, binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint binding_number, uint set_number, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorBinding(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), binding_number, set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint binding_number, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorBinding(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint binding_number, uint set_number, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorBinding(in p_module.GetPinnableReference(), entry_point, binding_number, set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint binding_number, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorBinding(in p_module.GetPinnableReference(), entry_point, binding_number, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 993, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* ReflectGetDescriptorSet(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetDescriptorSet(p_module, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 993, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* ReflectGetDescriptorSet(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint set_number, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetDescriptorSet(in p_module.GetPinnableReference(), set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 993, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* ReflectGetDescriptorSet(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetDescriptorSet(in p_module.GetPinnableReference(), set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorSet(p_module, entry_point, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint set_number, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorSet(p_module, in entry_point.GetPinnableReference(), set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorSet(p_module, in entry_point.GetPinnableReference(), set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorSet(p_module, entry_point, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint set_number, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorSet(in p_module.GetPinnableReference(), entry_point, set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorSet(in p_module.GetPinnableReference(), entry_point, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint set_number, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorSet(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorSet(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint set_number, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorSet(in p_module.GetPinnableReference(), entry_point, set_number, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint set_number, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointDescriptorSet(in p_module.GetPinnableReference(), entry_point, set_number, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariableByLocation(p_module, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariableByLocation(in p_module.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariableByLocation(in p_module.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1050, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariable(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariable(p_module, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1050, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariable(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariable(in p_module.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1050, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariable(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariable(in p_module.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableByLocation(p_module, entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableByLocation(p_module, in entry_point.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableByLocation(p_module, in entry_point.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableByLocation(p_module, entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableByLocation(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableByLocation(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariableBySemantic(p_module, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariableBySemantic(p_module, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariableBySemantic(p_module, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariableBySemantic(p_module, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariableBySemantic(in p_module.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariableBySemantic(in p_module.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariableBySemantic(in p_module.GetPinnableReference(), in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariableBySemantic(in p_module.GetPinnableReference(), in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariableBySemantic(in p_module.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetInputVariableBySemantic(in p_module.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointInputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1160, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariableByLocation(p_module, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1160, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariableByLocation(in p_module.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1160, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariableByLocation(in p_module.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariable(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariable(p_module, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariable(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariable(in p_module.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariable(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariable(in p_module.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableByLocation(p_module, entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableByLocation(p_module, in entry_point.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableByLocation(p_module, in entry_point.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableByLocation(p_module, entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableByLocation(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableByLocation(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableByLocation(in p_module.GetPinnableReference(), entry_point, location, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariableBySemantic(p_module, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariableBySemantic(p_module, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariableBySemantic(p_module, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariableBySemantic(p_module, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariableBySemantic(in p_module.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariableBySemantic(in p_module.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariableBySemantic(in p_module.GetPinnableReference(), in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariableBySemantic(in p_module.GetPinnableReference(), in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariableBySemantic(in p_module.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetOutputVariableBySemantic(in p_module.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(p_module, in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(p_module, entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(p_module, entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, in semantic.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        public static unsafe ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointOutputVariableBySemantic(in p_module.GetPinnableReference(), entry_point, semantic, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1273, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetPushConstantBlock(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint index, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetPushConstantBlock(p_module, index, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1273, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetPushConstantBlock(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint index, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetPushConstantBlock(in p_module.GetPinnableReference(), index, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1273, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetPushConstantBlock(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint index, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetPushConstantBlock(in p_module.GetPinnableReference(), index, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1279, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetPushConstant(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint index, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetPushConstant(p_module, index, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1279, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetPushConstant(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint index, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetPushConstant(in p_module.GetPinnableReference(), index, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1279, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetPushConstant(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, uint index, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetPushConstant(in p_module.GetPinnableReference(), index, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointPushConstantBlock(p_module, entry_point, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointPushConstantBlock(p_module, in entry_point.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointPushConstantBlock(p_module, in entry_point.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointPushConstantBlock(p_module, entry_point, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointPushConstantBlock(in p_module.GetPinnableReference(), entry_point, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointPushConstantBlock(in p_module.GetPinnableReference(), entry_point, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointPushConstantBlock(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> entry_point, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointPushConstantBlock(in p_module.GetPinnableReference(), in entry_point.GetPinnableReference(), ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ReflectResult* p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointPushConstantBlock(in p_module.GetPinnableReference(), entry_point, p_result);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        public static unsafe ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Span<ReflectResult> p_result)
        {
            // SpanOverloader
            return thisApi.ReflectGetEntryPointPushConstantBlock(in p_module.GetPinnableReference(), entry_point, ref p_result.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1334, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeDescriptorBindingNumbers(this SPIRVReflect thisApi, ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectDescriptorBinding> p_binding, uint new_binding_number, uint new_set_number)
        {
            // SpanOverloader
            return thisApi.ReflectChangeDescriptorBindingNumbers(p_module, in p_binding.GetPinnableReference(), new_binding_number, new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1334, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeDescriptorBindingNumbers(this SPIRVReflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectDescriptorBinding* p_binding, uint new_binding_number, uint new_set_number)
        {
            // SpanOverloader
            return thisApi.ReflectChangeDescriptorBindingNumbers(ref p_module.GetPinnableReference(), p_binding, new_binding_number, new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1334, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeDescriptorBindingNumbers(this SPIRVReflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectDescriptorBinding> p_binding, uint new_binding_number, uint new_set_number)
        {
            // SpanOverloader
            return thisApi.ReflectChangeDescriptorBindingNumbers(ref p_module.GetPinnableReference(), in p_binding.GetPinnableReference(), new_binding_number, new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1341, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeDescriptorBindingNumber(this SPIRVReflect thisApi, ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectDescriptorBinding> p_descriptor_binding, uint new_binding_number, uint optional_new_set_number)
        {
            // SpanOverloader
            return thisApi.ReflectChangeDescriptorBindingNumber(p_module, in p_descriptor_binding.GetPinnableReference(), new_binding_number, optional_new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1341, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeDescriptorBindingNumber(this SPIRVReflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectDescriptorBinding* p_descriptor_binding, uint new_binding_number, uint optional_new_set_number)
        {
            // SpanOverloader
            return thisApi.ReflectChangeDescriptorBindingNumber(ref p_module.GetPinnableReference(), p_descriptor_binding, new_binding_number, optional_new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1341, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeDescriptorBindingNumber(this SPIRVReflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectDescriptorBinding> p_descriptor_binding, uint new_binding_number, uint optional_new_set_number)
        {
            // SpanOverloader
            return thisApi.ReflectChangeDescriptorBindingNumber(ref p_module.GetPinnableReference(), in p_descriptor_binding.GetPinnableReference(), new_binding_number, optional_new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1370, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeDescriptorSetNumber(this SPIRVReflect thisApi, ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectDescriptorSet> p_set, uint new_set_number)
        {
            // SpanOverloader
            return thisApi.ReflectChangeDescriptorSetNumber(p_module, in p_set.GetPinnableReference(), new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1370, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeDescriptorSetNumber(this SPIRVReflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectDescriptorSet* p_set, uint new_set_number)
        {
            // SpanOverloader
            return thisApi.ReflectChangeDescriptorSetNumber(ref p_module.GetPinnableReference(), p_set, new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1370, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeDescriptorSetNumber(this SPIRVReflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectDescriptorSet> p_set, uint new_set_number)
        {
            // SpanOverloader
            return thisApi.ReflectChangeDescriptorSetNumber(ref p_module.GetPinnableReference(), in p_set.GetPinnableReference(), new_set_number);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1393, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeInputVariableLocation(this SPIRVReflect thisApi, ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectInterfaceVariable> p_input_variable, uint new_location)
        {
            // SpanOverloader
            return thisApi.ReflectChangeInputVariableLocation(p_module, in p_input_variable.GetPinnableReference(), new_location);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1393, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeInputVariableLocation(this SPIRVReflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectInterfaceVariable* p_input_variable, uint new_location)
        {
            // SpanOverloader
            return thisApi.ReflectChangeInputVariableLocation(ref p_module.GetPinnableReference(), p_input_variable, new_location);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1393, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeInputVariableLocation(this SPIRVReflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectInterfaceVariable> p_input_variable, uint new_location)
        {
            // SpanOverloader
            return thisApi.ReflectChangeInputVariableLocation(ref p_module.GetPinnableReference(), in p_input_variable.GetPinnableReference(), new_location);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1417, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeOutputVariableLocation(this SPIRVReflect thisApi, ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectInterfaceVariable> p_output_variable, uint new_location)
        {
            // SpanOverloader
            return thisApi.ReflectChangeOutputVariableLocation(p_module, in p_output_variable.GetPinnableReference(), new_location);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1417, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeOutputVariableLocation(this SPIRVReflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectInterfaceVariable* p_output_variable, uint new_location)
        {
            // SpanOverloader
            return thisApi.ReflectChangeOutputVariableLocation(ref p_module.GetPinnableReference(), p_output_variable, new_location);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1417, Column 18 in spirv_reflect.h")]
        public static unsafe ReflectResult ReflectChangeOutputVariableLocation(this SPIRVReflect thisApi, Span<ReflectShaderModule> p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectInterfaceVariable> p_output_variable, uint new_location)
        {
            // SpanOverloader
            return thisApi.ReflectChangeOutputVariableLocation(ref p_module.GetPinnableReference(), in p_output_variable.GetPinnableReference(), new_location);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 13 in spirv_reflect.h")]
        public static unsafe byte* ReflectBlockVariableTypeName(this SPIRVReflect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectBlockVariable> p_var)
        {
            // SpanOverloader
            return thisApi.ReflectBlockVariableTypeName(in p_var.GetPinnableReference());
        }

    }
}

