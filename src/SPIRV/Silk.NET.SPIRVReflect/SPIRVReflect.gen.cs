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
    public unsafe partial class SPIRVReflect : NativeAPI
    {

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 528, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule")]
        public unsafe partial ReflectResult ReflectCreateShaderModule(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, ReflectShaderModule* p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 528, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule")]
        public unsafe partial ReflectResult ReflectCreateShaderModule(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, ref ReflectShaderModule p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 528, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule")]
        public unsafe partial ReflectResult ReflectCreateShaderModule<T0>(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 p_code, ReflectShaderModule* p_module) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 528, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule")]
        public partial ReflectResult ReflectCreateShaderModule<T0>(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 p_code, ref ReflectShaderModule p_module) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 543, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule2")]
        public unsafe partial ReflectResult ReflectCreateShaderModule2(uint flags, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, ReflectShaderModule* p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 543, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule2")]
        public unsafe partial ReflectResult ReflectCreateShaderModule2(uint flags, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, ref ReflectShaderModule p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 543, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule2")]
        public unsafe partial ReflectResult ReflectCreateShaderModule2<T0>(uint flags, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 p_code, ReflectShaderModule* p_module) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 543, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule2")]
        public partial ReflectResult ReflectCreateShaderModule2<T0>(uint flags, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 p_code, ref ReflectShaderModule p_module) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 551, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetShaderModule")]
        public unsafe partial ReflectResult ReflectGetShaderModule(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, ReflectShaderModule* p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 551, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetShaderModule")]
        public unsafe partial ReflectResult ReflectGetShaderModule(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, ref ReflectShaderModule p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 551, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetShaderModule")]
        public unsafe partial ReflectResult ReflectGetShaderModule<T0>(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 p_code, ReflectShaderModule* p_module) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 551, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetShaderModule")]
        public partial ReflectResult ReflectGetShaderModule<T0>(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in T0 p_code, ref ReflectShaderModule p_module) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 563, Column 6 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectDestroyShaderModule")]
        public unsafe partial void ReflectDestroyShaderModule(ReflectShaderModule* p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 563, Column 6 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectDestroyShaderModule")]
        public partial void ReflectDestroyShaderModule(ref ReflectShaderModule p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 572, Column 10 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetCodeSize")]
        public unsafe partial uint ReflectGetCodeSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 572, Column 10 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetCodeSize")]
        public partial uint ReflectGetCodeSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 17 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetCode")]
        public unsafe partial uint* ReflectGetCode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 17 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetCode")]
        public unsafe partial uint* ReflectGetCode([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 29 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPoint")]
        public unsafe partial ReflectEntryPoint* ReflectGetEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 29 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPoint")]
        public unsafe partial ReflectEntryPoint* ReflectGetEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 29 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPoint")]
        public unsafe partial ReflectEntryPoint* ReflectGetEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 29 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPoint")]
        public unsafe partial ReflectEntryPoint* ReflectGetEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 29 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPoint")]
        public unsafe partial ReflectEntryPoint* ReflectGetEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 29 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPoint")]
        public unsafe partial ReflectEntryPoint* ReflectGetEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint* p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint* p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, ref uint p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 613, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, ref uint p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ReflectDescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref ReflectDescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 690, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 821, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 821, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 821, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 821, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 821, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 821, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 821, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 821, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ReflectInterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref ReflectInterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 874, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 874, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 874, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 874, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 874, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint* p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 874, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint* p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 874, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, ref uint p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 874, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, ref uint p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint* p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint* p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, ref uint p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial ReflectResult ReflectEnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, ref uint p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint* p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref uint p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ReflectBlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 906, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial ReflectResult ReflectEnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref ReflectBlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 936, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint binding_number, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 936, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint binding_number, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 936, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint binding_number, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 936, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint binding_number, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint binding_number, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint binding_number, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint binding_number, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint binding_number, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint binding_number, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint binding_number, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint binding_number, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint binding_number, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint binding_number, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint binding_number, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint binding_number, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 968, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial ReflectDescriptorBinding* ReflectGetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint binding_number, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 993, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 993, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 993, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 993, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint set_number, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1016, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* ReflectGetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint set_number, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1050, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariable")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1050, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariable")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1050, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariable")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1050, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariable")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1077, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1105, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1160, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1160, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1160, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1160, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariable")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariable")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariable")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariable")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1193, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1221, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1249, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial ReflectInterfaceVariable* ReflectGetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1273, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint index, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1273, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint index, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1273, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint index, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1273, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint index, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1279, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstant")]
        public unsafe partial ReflectBlockVariable* ReflectGetPushConstant([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint index, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1279, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstant")]
        public unsafe partial ReflectBlockVariable* ReflectGetPushConstant([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint index, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1279, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstant")]
        public unsafe partial ReflectBlockVariable* ReflectGetPushConstant([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint index, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1279, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstant")]
        public unsafe partial ReflectBlockVariable* ReflectGetPushConstant([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, uint index, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in byte entry_point, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ReflectResult* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1304, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial ReflectBlockVariable* ReflectGetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref ReflectResult p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1334, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumbers")]
        public unsafe partial ReflectResult ReflectChangeDescriptorBindingNumbers(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectDescriptorBinding* p_binding, uint new_binding_number, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1334, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumbers")]
        public unsafe partial ReflectResult ReflectChangeDescriptorBindingNumbers(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectDescriptorBinding p_binding, uint new_binding_number, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1334, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumbers")]
        public unsafe partial ReflectResult ReflectChangeDescriptorBindingNumbers(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectDescriptorBinding* p_binding, uint new_binding_number, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1334, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumbers")]
        public partial ReflectResult ReflectChangeDescriptorBindingNumbers(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectDescriptorBinding p_binding, uint new_binding_number, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1341, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumber")]
        public unsafe partial ReflectResult ReflectChangeDescriptorBindingNumber(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectDescriptorBinding* p_descriptor_binding, uint new_binding_number, uint optional_new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1341, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumber")]
        public unsafe partial ReflectResult ReflectChangeDescriptorBindingNumber(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectDescriptorBinding p_descriptor_binding, uint new_binding_number, uint optional_new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1341, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumber")]
        public unsafe partial ReflectResult ReflectChangeDescriptorBindingNumber(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectDescriptorBinding* p_descriptor_binding, uint new_binding_number, uint optional_new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1341, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumber")]
        public partial ReflectResult ReflectChangeDescriptorBindingNumber(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectDescriptorBinding p_descriptor_binding, uint new_binding_number, uint optional_new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1370, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorSetNumber")]
        public unsafe partial ReflectResult ReflectChangeDescriptorSetNumber(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectDescriptorSet* p_set, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1370, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorSetNumber")]
        public unsafe partial ReflectResult ReflectChangeDescriptorSetNumber(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectDescriptorSet p_set, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1370, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorSetNumber")]
        public unsafe partial ReflectResult ReflectChangeDescriptorSetNumber(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectDescriptorSet* p_set, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1370, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorSetNumber")]
        public partial ReflectResult ReflectChangeDescriptorSetNumber(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectDescriptorSet p_set, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1393, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeInputVariableLocation")]
        public unsafe partial ReflectResult ReflectChangeInputVariableLocation(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectInterfaceVariable* p_input_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1393, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeInputVariableLocation")]
        public unsafe partial ReflectResult ReflectChangeInputVariableLocation(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectInterfaceVariable p_input_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1393, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeInputVariableLocation")]
        public unsafe partial ReflectResult ReflectChangeInputVariableLocation(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectInterfaceVariable* p_input_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1393, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeInputVariableLocation")]
        public partial ReflectResult ReflectChangeInputVariableLocation(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectInterfaceVariable p_input_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1417, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeOutputVariableLocation")]
        public unsafe partial ReflectResult ReflectChangeOutputVariableLocation(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectInterfaceVariable* p_output_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1417, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeOutputVariableLocation")]
        public unsafe partial ReflectResult ReflectChangeOutputVariableLocation(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectInterfaceVariable p_output_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1417, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeOutputVariableLocation")]
        public unsafe partial ReflectResult ReflectChangeOutputVariableLocation(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectInterfaceVariable* p_output_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1417, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeOutputVariableLocation")]
        public partial ReflectResult ReflectChangeOutputVariableLocation(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectInterfaceVariable p_output_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1430, Column 13 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectSourceLanguage")]
        public unsafe partial byte* ReflectSourceLanguage(Silk.NET.SPIRV.SourceLanguage source_lang);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1430, Column 13 in spirv_reflect.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvReflectSourceLanguage")]
        public partial string ReflectSourceLanguageS(Silk.NET.SPIRV.SourceLanguage source_lang);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 13 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectBlockVariableTypeName")]
        public unsafe partial byte* ReflectBlockVariableTypeName([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectBlockVariable* p_var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 13 in spirv_reflect.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvReflectBlockVariableTypeName")]
        public unsafe partial string ReflectBlockVariableTypeNameS([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectBlockVariable* p_var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 13 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectBlockVariableTypeName")]
        public unsafe partial byte* ReflectBlockVariableTypeName([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectBlockVariable p_var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1438, Column 13 in spirv_reflect.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvReflectBlockVariableTypeName")]
        public partial string ReflectBlockVariableTypeNameS([Flow(Silk.NET.Core.Native.FlowDirection.In)] in ReflectBlockVariable p_var);


        public SPIRVReflect(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

