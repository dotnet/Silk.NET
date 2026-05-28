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

namespace Silk.NET.SPIRV.Cross
{
    public static class CrossOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        public static unsafe void GetVersion(this Cross thisApi, uint* major, uint* minor, Span<uint> patch)
        {
            // SpanOverloader
            thisApi.GetVersion(major, minor, ref patch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        public static unsafe void GetVersion(this Cross thisApi, uint* major, Span<uint> minor, uint* patch)
        {
            // SpanOverloader
            thisApi.GetVersion(major, ref minor.GetPinnableReference(), patch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        public static unsafe void GetVersion(this Cross thisApi, uint* major, Span<uint> minor, Span<uint> patch)
        {
            // SpanOverloader
            thisApi.GetVersion(major, ref minor.GetPinnableReference(), ref patch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        public static unsafe void GetVersion(this Cross thisApi, Span<uint> major, uint* minor, uint* patch)
        {
            // SpanOverloader
            thisApi.GetVersion(ref major.GetPinnableReference(), minor, patch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        public static unsafe void GetVersion(this Cross thisApi, Span<uint> major, uint* minor, Span<uint> patch)
        {
            // SpanOverloader
            thisApi.GetVersion(ref major.GetPinnableReference(), minor, ref patch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        public static unsafe void GetVersion(this Cross thisApi, Span<uint> major, Span<uint> minor, uint* patch)
        {
            // SpanOverloader
            thisApi.GetVersion(ref major.GetPinnableReference(), ref minor.GetPinnableReference(), patch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 22 in spirv_cross_c.h")]
        public static unsafe void GetVersion(this Cross thisApi, Span<uint> major, Span<uint> minor, Span<uint> patch)
        {
            // SpanOverloader
            thisApi.GetVersion(ref major.GetPinnableReference(), ref minor.GetPinnableReference(), ref patch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 339, Column 22 in spirv_cross_c.h")]
        public static unsafe void MslVertexAttributeInit(this Cross thisApi, Span<MslVertexAttribute> attr)
        {
            // SpanOverloader
            thisApi.MslVertexAttributeInit(ref attr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 354, Column 22 in spirv_cross_c.h")]
        public static unsafe void MslShaderInterfaceVarInit(this Cross thisApi, Span<MslShaderInterfaceVar> var)
        {
            // SpanOverloader
            thisApi.MslShaderInterfaceVarInit(ref var.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 358, Column 22 in spirv_cross_c.h")]
        public static unsafe void MslShaderInputInit(this Cross thisApi, Span<MslShaderInterfaceVar> input)
        {
            // SpanOverloader
            thisApi.MslShaderInputInit(ref input.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 383, Column 22 in spirv_cross_c.h")]
        public static unsafe void MslShaderInterfaceVarInit2(this Cross thisApi, Span<MslShaderInterfaceVar2> var)
        {
            // SpanOverloader
            thisApi.MslShaderInterfaceVarInit2(ref var.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 413, Column 22 in spirv_cross_c.h")]
        public static unsafe void MslResourceBindingInit(this Cross thisApi, Span<MslResourceBinding> binding)
        {
            // SpanOverloader
            thisApi.MslResourceBindingInit(ref binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 414, Column 22 in spirv_cross_c.h")]
        public static unsafe void MslResourceBindingInit2(this Cross thisApi, Span<MslResourceBinding2> binding)
        {
            // SpanOverloader
            thisApi.MslResourceBindingInit2(ref binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 561, Column 22 in spirv_cross_c.h")]
        public static unsafe void MslConstexprSamplerInit(this Cross thisApi, Span<MslConstexprSampler> sampler)
        {
            // SpanOverloader
            thisApi.MslConstexprSamplerInit(ref sampler.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 22 in spirv_cross_c.h")]
        public static unsafe void MslSamplerYcbcrConversionInit(this Cross thisApi, Span<MslSamplerYcbcrConversion> conv)
        {
            // SpanOverloader
            thisApi.MslSamplerYcbcrConversionInit(ref conv.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 619, Column 22 in spirv_cross_c.h")]
        public static unsafe void HlslResourceBindingInit(this Cross thisApi, Span<HlslResourceBinding> binding)
        {
            // SpanOverloader
            thisApi.HlslResourceBindingInit(ref binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 781, Column 22 in spirv_cross_c.h")]
        public static unsafe void ContextSetErrorCallback<T0>(this Cross thisApi, Context* context, PfnErrorCallback cb, Span<T0> userdata) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ContextSetErrorCallback(context, cb, ref userdata.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 784, Column 29 in spirv_cross_c.h")]
        public static unsafe Result ContextParseSpirv(this Cross thisApi, Context* context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> spirv, nuint word_count, ParsedIr** parsed_ir)
        {
            // SpanOverloader
            return thisApi.ContextParseSpirv(context, in spirv.GetPinnableReference(), word_count, parsed_ir);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 784, Column 29 in spirv_cross_c.h")]
        public static unsafe Result ContextParseSpirv(this Cross thisApi, Context* context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> spirv, nuint word_count, ref ParsedIr* parsed_ir)
        {
            // SpanOverloader
            return thisApi.ContextParseSpirv(context, in spirv.GetPinnableReference(), word_count, ref parsed_ir);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 814, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerAddHeaderLine(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> line)
        {
            // SpanOverloader
            return thisApi.CompilerAddHeaderLine(compiler, in line.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 815, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerRequireExtension(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> ext)
        {
            // SpanOverloader
            return thisApi.CompilerRequireExtension(compiler, in ext.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 830, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerHlslSetRootConstantsLayout(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HlslRootConstants> constant_info, nuint count)
        {
            // SpanOverloader
            return thisApi.CompilerHlslSetRootConstantsLayout(compiler, in constant_info.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 833, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerHlslAddVertexAttributeRemap(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HlslVertexAttributeRemap> remap, nuint remaps)
        {
            // SpanOverloader
            return thisApi.CompilerHlslAddVertexAttributeRemap(compiler, in remap.GetPinnableReference(), remaps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 841, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerHlslAddResourceBinding(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HlslResourceBinding> binding)
        {
            // SpanOverloader
            return thisApi.CompilerHlslAddResourceBinding(compiler, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 862, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslAddVertexAttribute(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslVertexAttribute> attrs)
        {
            // SpanOverloader
            return thisApi.CompilerMslAddVertexAttribute(compiler, in attrs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 865, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslAddResourceBinding(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslResourceBinding> binding)
        {
            // SpanOverloader
            return thisApi.CompilerMslAddResourceBinding(compiler, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 867, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslAddResourceBinding2(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslResourceBinding2> binding)
        {
            // SpanOverloader
            return thisApi.CompilerMslAddResourceBinding2(compiler, in binding.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslAddShaderInput(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslShaderInterfaceVar> input)
        {
            // SpanOverloader
            return thisApi.CompilerMslAddShaderInput(compiler, in input.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 872, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslAddShaderInput2(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslShaderInterfaceVar2> input)
        {
            // SpanOverloader
            return thisApi.CompilerMslAddShaderInput2(compiler, in input.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslAddShaderOutput(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslShaderInterfaceVar> output)
        {
            // SpanOverloader
            return thisApi.CompilerMslAddShaderOutput(compiler, in output.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslAddShaderOutput2(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslShaderInterfaceVar2> output)
        {
            // SpanOverloader
            return thisApi.CompilerMslAddShaderOutput2(compiler, in output.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslRemapConstexprSampler(this Cross thisApi, Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslConstexprSampler> sampler)
        {
            // SpanOverloader
            return thisApi.CompilerMslRemapConstexprSampler(compiler, id, in sampler.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 892, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslRemapConstexprSamplerByBinding(this Cross thisApi, Compiler* compiler, uint desc_set, uint binding, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslConstexprSampler> sampler)
        {
            // SpanOverloader
            return thisApi.CompilerMslRemapConstexprSamplerByBinding(compiler, desc_set, binding, in sampler.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 893, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslRemapConstexprSamplerYcbcr(this Cross thisApi, Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslConstexprSampler* sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslSamplerYcbcrConversion> conv)
        {
            // SpanOverloader
            return thisApi.CompilerMslRemapConstexprSamplerYcbcr(compiler, id, sampler, in conv.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 893, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslRemapConstexprSamplerYcbcr(this Cross thisApi, Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslConstexprSampler> sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslSamplerYcbcrConversion* conv)
        {
            // SpanOverloader
            return thisApi.CompilerMslRemapConstexprSamplerYcbcr(compiler, id, in sampler.GetPinnableReference(), conv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 893, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslRemapConstexprSamplerYcbcr(this Cross thisApi, Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslConstexprSampler> sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslSamplerYcbcrConversion> conv)
        {
            // SpanOverloader
            return thisApi.CompilerMslRemapConstexprSamplerYcbcr(compiler, id, in sampler.GetPinnableReference(), in conv.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 894, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslRemapConstexprSamplerByBindingYcbcr(this Cross thisApi, Compiler* compiler, uint desc_set, uint binding, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslConstexprSampler* sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslSamplerYcbcrConversion> conv)
        {
            // SpanOverloader
            return thisApi.CompilerMslRemapConstexprSamplerByBindingYcbcr(compiler, desc_set, binding, sampler, in conv.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 894, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslRemapConstexprSamplerByBindingYcbcr(this Cross thisApi, Compiler* compiler, uint desc_set, uint binding, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslConstexprSampler> sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MslSamplerYcbcrConversion* conv)
        {
            // SpanOverloader
            return thisApi.CompilerMslRemapConstexprSamplerByBindingYcbcr(compiler, desc_set, binding, in sampler.GetPinnableReference(), conv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 894, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslRemapConstexprSamplerByBindingYcbcr(this Cross thisApi, Compiler* compiler, uint desc_set, uint binding, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslConstexprSampler> sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MslSamplerYcbcrConversion> conv)
        {
            // SpanOverloader
            return thisApi.CompilerMslRemapConstexprSamplerByBindingYcbcr(compiler, desc_set, binding, in sampler.GetPinnableReference(), in conv.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 904, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerMslSetCombinedSamplerSuffix(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> suffix)
        {
            // SpanOverloader
            return thisApi.CompilerMslSetCombinedSamplerSuffix(compiler, in suffix.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 917, Column 29 in spirv_cross_c.h")]
        public static unsafe Result ResourcesGetResourceListForType(this Cross thisApi, Resources* resources, ResourceType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectedResource** resource_list, Span<nuint> resource_size)
        {
            // SpanOverloader
            return thisApi.ResourcesGetResourceListForType(resources, type, resource_list, ref resource_size.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 917, Column 29 in spirv_cross_c.h")]
        public static unsafe Result ResourcesGetResourceListForType(this Cross thisApi, Resources* resources, ResourceType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ReflectedResource* resource_list, Span<nuint> resource_size)
        {
            // SpanOverloader
            return thisApi.ResourcesGetResourceListForType(resources, type, in resource_list, ref resource_size.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 921, Column 29 in spirv_cross_c.h")]
        public static unsafe Result ResourcesGetBuiltinResourceListForType(this Cross thisApi, Resources* resources, BuiltinResourceType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectedBuiltinResource** resource_list, Span<nuint> resource_size)
        {
            // SpanOverloader
            return thisApi.ResourcesGetBuiltinResourceListForType(resources, type, resource_list, ref resource_size.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 921, Column 29 in spirv_cross_c.h")]
        public static unsafe Result ResourcesGetBuiltinResourceListForType(this Cross thisApi, Resources* resources, BuiltinResourceType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ReflectedBuiltinResource* resource_list, Span<nuint> resource_size)
        {
            // SpanOverloader
            return thisApi.ResourcesGetBuiltinResourceListForType(resources, type, in resource_list, ref resource_size.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 932, Column 22 in spirv_cross_c.h")]
        public static unsafe void CompilerSetDecorationString(this Cross thisApi, Compiler* compiler, uint id, Silk.NET.SPIRV.Decoration decoration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> argument)
        {
            // SpanOverloader
            thisApi.CompilerSetDecorationString(compiler, id, decoration, in argument.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 934, Column 22 in spirv_cross_c.h")]
        public static unsafe void CompilerSetName(this Cross thisApi, Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> argument)
        {
            // SpanOverloader
            thisApi.CompilerSetName(compiler, id, in argument.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 937, Column 22 in spirv_cross_c.h")]
        public static unsafe void CompilerSetMemberDecorationString(this Cross thisApi, Compiler* compiler, uint id, uint member_index, Silk.NET.SPIRV.Decoration decoration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> argument)
        {
            // SpanOverloader
            thisApi.CompilerSetMemberDecorationString(compiler, id, member_index, decoration, in argument.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 22 in spirv_cross_c.h")]
        public static unsafe void CompilerSetMemberName(this Cross thisApi, Compiler* compiler, uint id, uint member_index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> argument)
        {
            // SpanOverloader
            thisApi.CompilerSetMemberName(compiler, id, member_index, in argument.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetEntryPoints(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EntryPoint** entry_points, Span<nuint> num_entry_points)
        {
            // SpanOverloader
            return thisApi.CompilerGetEntryPoints(compiler, entry_points, ref num_entry_points.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 963, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetEntryPoints(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly EntryPoint* entry_points, Span<nuint> num_entry_points)
        {
            // SpanOverloader
            return thisApi.CompilerGetEntryPoints(compiler, in entry_points, ref num_entry_points.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 966, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerSetEntryPoint(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Silk.NET.SPIRV.ExecutionModel model)
        {
            // SpanOverloader
            return thisApi.CompilerSetEntryPoint(compiler, in name.GetPinnableReference(), model);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerRenameEntryPoint(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* old_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> new_name, Silk.NET.SPIRV.ExecutionModel model)
        {
            // SpanOverloader
            return thisApi.CompilerRenameEntryPoint(compiler, old_name, in new_name.GetPinnableReference(), model);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerRenameEntryPoint(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> old_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* new_name, Silk.NET.SPIRV.ExecutionModel model)
        {
            // SpanOverloader
            return thisApi.CompilerRenameEntryPoint(compiler, in old_name.GetPinnableReference(), new_name, model);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerRenameEntryPoint(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> old_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> new_name, Silk.NET.SPIRV.ExecutionModel model)
        {
            // SpanOverloader
            return thisApi.CompilerRenameEntryPoint(compiler, in old_name.GetPinnableReference(), in new_name.GetPinnableReference(), model);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerRenameEntryPoint(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> old_name, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string new_name, Silk.NET.SPIRV.ExecutionModel model)
        {
            // SpanOverloader
            return thisApi.CompilerRenameEntryPoint(compiler, in old_name.GetPinnableReference(), new_name, model);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerRenameEntryPoint(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string old_name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> new_name, Silk.NET.SPIRV.ExecutionModel model)
        {
            // SpanOverloader
            return thisApi.CompilerRenameEntryPoint(compiler, old_name, in new_name.GetPinnableReference(), model);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 970, Column 29 in spirv_cross_c.h")]
        public static unsafe byte* CompilerGetCleansedEntryPointName(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Silk.NET.SPIRV.ExecutionModel model)
        {
            // SpanOverloader
            return thisApi.CompilerGetCleansedEntryPointName(compiler, in name.GetPinnableReference(), model);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 976, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetExecutionModes(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.SPIRV.ExecutionMode** modes, Span<nuint> num_modes)
        {
            // SpanOverloader
            return thisApi.CompilerGetExecutionModes(compiler, modes, ref num_modes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 976, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetExecutionModes(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.SPIRV.ExecutionMode* modes, Span<nuint> num_modes)
        {
            // SpanOverloader
            return thisApi.CompilerGetExecutionModes(compiler, in modes, ref num_modes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1022, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetDeclaredStructSize(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* struct_type, Span<nuint> size)
        {
            // SpanOverloader
            return thisApi.CompilerGetDeclaredStructSize(compiler, struct_type, ref size.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetDeclaredStructSizeRuntimeArray(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* struct_type, nuint array_size, Span<nuint> size)
        {
            // SpanOverloader
            return thisApi.CompilerGetDeclaredStructSizeRuntimeArray(compiler, struct_type, array_size, ref size.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1025, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetDeclaredStructMemberSize(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint index, Span<nuint> size)
        {
            // SpanOverloader
            return thisApi.CompilerGetDeclaredStructMemberSize(compiler, type, index, ref size.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1027, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerTypeStructMemberOffset(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint index, Span<uint> offset)
        {
            // SpanOverloader
            return thisApi.CompilerTypeStructMemberOffset(compiler, type, index, ref offset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1029, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerTypeStructMemberArrayStride(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint index, Span<uint> stride)
        {
            // SpanOverloader
            return thisApi.CompilerTypeStructMemberArrayStride(compiler, type, index, ref stride.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1031, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerTypeStructMemberMatrixStride(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CrossType* type, uint index, Span<uint> stride)
        {
            // SpanOverloader
            return thisApi.CompilerTypeStructMemberMatrixStride(compiler, type, index, ref stride.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1038, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerBuildDummySamplerForCombinedImages(this Cross thisApi, Compiler* compiler, Span<uint> id)
        {
            // SpanOverloader
            return thisApi.CompilerBuildDummySamplerForCombinedImages(compiler, ref id.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetCombinedImageSamplers(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CombinedImageSampler** samplers, Span<nuint> num_samplers)
        {
            // SpanOverloader
            return thisApi.CompilerGetCombinedImageSamplers(compiler, samplers, ref num_samplers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetCombinedImageSamplers(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CombinedImageSampler* samplers, Span<nuint> num_samplers)
        {
            // SpanOverloader
            return thisApi.CompilerGetCombinedImageSamplers(compiler, in samplers, ref num_samplers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1048, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetSpecializationConstants(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpecializationConstant** constants, Span<nuint> num_constants)
        {
            // SpanOverloader
            return thisApi.CompilerGetSpecializationConstants(compiler, constants, ref num_constants.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1048, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetSpecializationConstants(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpecializationConstant* constants, Span<nuint> num_constants)
        {
            // SpanOverloader
            return thisApi.CompilerGetSpecializationConstants(compiler, in constants, ref num_constants.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1054, Column 34 in spirv_cross_c.h")]
        public static unsafe uint CompilerGetWorkGroupSizeSpecializationConstants(this Cross thisApi, Compiler* compiler, SpecializationConstant* x, SpecializationConstant* y, Span<SpecializationConstant> z)
        {
            // SpanOverloader
            return thisApi.CompilerGetWorkGroupSizeSpecializationConstants(compiler, x, y, ref z.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1054, Column 34 in spirv_cross_c.h")]
        public static unsafe uint CompilerGetWorkGroupSizeSpecializationConstants(this Cross thisApi, Compiler* compiler, SpecializationConstant* x, Span<SpecializationConstant> y, SpecializationConstant* z)
        {
            // SpanOverloader
            return thisApi.CompilerGetWorkGroupSizeSpecializationConstants(compiler, x, ref y.GetPinnableReference(), z);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1054, Column 34 in spirv_cross_c.h")]
        public static unsafe uint CompilerGetWorkGroupSizeSpecializationConstants(this Cross thisApi, Compiler* compiler, SpecializationConstant* x, Span<SpecializationConstant> y, Span<SpecializationConstant> z)
        {
            // SpanOverloader
            return thisApi.CompilerGetWorkGroupSizeSpecializationConstants(compiler, x, ref y.GetPinnableReference(), ref z.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1054, Column 34 in spirv_cross_c.h")]
        public static unsafe uint CompilerGetWorkGroupSizeSpecializationConstants(this Cross thisApi, Compiler* compiler, Span<SpecializationConstant> x, SpecializationConstant* y, SpecializationConstant* z)
        {
            // SpanOverloader
            return thisApi.CompilerGetWorkGroupSizeSpecializationConstants(compiler, ref x.GetPinnableReference(), y, z);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1054, Column 34 in spirv_cross_c.h")]
        public static unsafe uint CompilerGetWorkGroupSizeSpecializationConstants(this Cross thisApi, Compiler* compiler, Span<SpecializationConstant> x, SpecializationConstant* y, Span<SpecializationConstant> z)
        {
            // SpanOverloader
            return thisApi.CompilerGetWorkGroupSizeSpecializationConstants(compiler, ref x.GetPinnableReference(), y, ref z.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1054, Column 34 in spirv_cross_c.h")]
        public static unsafe uint CompilerGetWorkGroupSizeSpecializationConstants(this Cross thisApi, Compiler* compiler, Span<SpecializationConstant> x, Span<SpecializationConstant> y, SpecializationConstant* z)
        {
            // SpanOverloader
            return thisApi.CompilerGetWorkGroupSizeSpecializationConstants(compiler, ref x.GetPinnableReference(), ref y.GetPinnableReference(), z);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1054, Column 34 in spirv_cross_c.h")]
        public static unsafe uint CompilerGetWorkGroupSizeSpecializationConstants(this Cross thisApi, Compiler* compiler, Span<SpecializationConstant> x, Span<SpecializationConstant> y, Span<SpecializationConstant> z)
        {
            // SpanOverloader
            return thisApi.CompilerGetWorkGroupSizeSpecializationConstants(compiler, ref x.GetPinnableReference(), ref y.GetPinnableReference(), ref z.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetActiveBufferRanges(this Cross thisApi, Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferRange** ranges, Span<nuint> num_ranges)
        {
            // SpanOverloader
            return thisApi.CompilerGetActiveBufferRanges(compiler, id, ranges, ref num_ranges.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetActiveBufferRanges(this Cross thisApi, Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BufferRange* ranges, Span<nuint> num_ranges)
        {
            // SpanOverloader
            return thisApi.CompilerGetActiveBufferRanges(compiler, id, in ranges, ref num_ranges.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1083, Column 22 in spirv_cross_c.h")]
        public static unsafe void ConstantGetSubconstants(this Cross thisApi, Constant* constant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint** constituents, Span<nuint> count)
        {
            // SpanOverloader
            thisApi.ConstantGetSubconstants(constant, constituents, ref count.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1083, Column 22 in spirv_cross_c.h")]
        public static unsafe void ConstantGetSubconstants(this Cross thisApi, Constant* constant, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint* constituents, Span<nuint> count)
        {
            // SpanOverloader
            thisApi.ConstantGetSubconstants(constant, in constituents, ref count.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1107, Column 27 in spirv_cross_c.h")]
        public static unsafe byte CompilerGetBinaryOffsetForDecoration(this Cross thisApi, Compiler* compiler, uint id, Silk.NET.SPIRV.Decoration decoration, Span<uint> word_offset)
        {
            // SpanOverloader
            return thisApi.CompilerGetBinaryOffsetForDecoration(compiler, id, decoration, ref word_offset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1113, Column 27 in spirv_cross_c.h")]
        public static unsafe byte CompilerBufferGetHlslCounterBuffer(this Cross thisApi, Compiler* compiler, uint id, Span<uint> counter_id)
        {
            // SpanOverloader
            return thisApi.CompilerBufferGetHlslCounterBuffer(compiler, id, ref counter_id.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1116, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetDeclaredCapabilities(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.SPIRV.Capability** capabilities, Span<nuint> num_capabilities)
        {
            // SpanOverloader
            return thisApi.CompilerGetDeclaredCapabilities(compiler, capabilities, ref num_capabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1116, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetDeclaredCapabilities(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.SPIRV.Capability* capabilities, Span<nuint> num_capabilities)
        {
            // SpanOverloader
            return thisApi.CompilerGetDeclaredCapabilities(compiler, in capabilities, ref num_capabilities.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1119, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetDeclaredExtensions(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte*** extensions, Span<nuint> num_extensions)
        {
            // SpanOverloader
            return thisApi.CompilerGetDeclaredExtensions(compiler, extensions, ref num_extensions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1119, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetDeclaredExtensions(this Cross thisApi, Compiler* compiler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte** extensions, Span<nuint> num_extensions)
        {
            // SpanOverloader
            return thisApi.CompilerGetDeclaredExtensions(compiler, in extensions, ref num_extensions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1123, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetBufferBlockDecorations(this Cross thisApi, Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.SPIRV.Decoration** decorations, Span<nuint> num_decorations)
        {
            // SpanOverloader
            return thisApi.CompilerGetBufferBlockDecorations(compiler, id, decorations, ref num_decorations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1123, Column 29 in spirv_cross_c.h")]
        public static unsafe Result CompilerGetBufferBlockDecorations(this Cross thisApi, Compiler* compiler, uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.SPIRV.Decoration* decorations, Span<nuint> num_decorations)
        {
            // SpanOverloader
            return thisApi.CompilerGetBufferBlockDecorations(compiler, id, in decorations, ref num_decorations.GetPinnableReference());
        }

    }
}

