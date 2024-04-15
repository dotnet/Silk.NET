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
    public unsafe partial class Reflect : NativeAPI
    {

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule")]
        public unsafe partial Result CreateShaderModule(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, ReflectShaderModule* p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule")]
        public unsafe partial Result CreateShaderModule(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, ref ReflectShaderModule p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule")]
        public unsafe partial Result CreateShaderModule<T0>(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 p_code, ReflectShaderModule* p_module) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule")]
        public partial Result CreateShaderModule<T0>(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 p_code, ref ReflectShaderModule p_module) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule2")]
        public unsafe partial Result CreateShaderModule2(uint flags, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, ReflectShaderModule* p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule2")]
        public unsafe partial Result CreateShaderModule2(uint flags, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, ref ReflectShaderModule p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule2")]
        public unsafe partial Result CreateShaderModule2<T0>(uint flags, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 p_code, ReflectShaderModule* p_module) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectCreateShaderModule2")]
        public partial Result CreateShaderModule2<T0>(uint flags, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 p_code, ref ReflectShaderModule p_module) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 659, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetShaderModule")]
        public unsafe partial Result GetShaderModule(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, ReflectShaderModule* p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 659, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetShaderModule")]
        public unsafe partial Result GetShaderModule(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* p_code, ref ReflectShaderModule p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 659, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetShaderModule")]
        public unsafe partial Result GetShaderModule<T0>(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 p_code, ReflectShaderModule* p_module) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 659, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetShaderModule")]
        public partial Result GetShaderModule<T0>(nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 p_code, ref ReflectShaderModule p_module) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 671, Column 6 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectDestroyShaderModule")]
        public unsafe partial void DestroyShaderModule(ReflectShaderModule* p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 671, Column 6 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectDestroyShaderModule")]
        public partial void DestroyShaderModule(ref ReflectShaderModule p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 680, Column 10 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetCodeSize")]
        public unsafe partial uint GetCodeSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 680, Column 10 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetCodeSize")]
        public partial uint GetCodeSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 689, Column 17 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetCode")]
        public unsafe partial uint* GetCode([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 689, Column 17 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetCode")]
        public unsafe partial uint* GetCode([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPoint")]
        public unsafe partial EntryPoint* GetEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPoint")]
        public unsafe partial EntryPoint* GetEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPoint")]
        public unsafe partial EntryPoint* GetEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPoint")]
        public unsafe partial EntryPoint* GetEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPoint")]
        public unsafe partial EntryPoint* GetEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 698, Column 29 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPoint")]
        public unsafe partial EntryPoint* GetEntryPoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial Result EnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial Result EnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial Result EnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial Result EnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial Result EnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial Result EnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial Result EnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorBindings")]
        public unsafe partial Result EnumerateDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, DescriptorBinding** pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorBindings")]
        public unsafe partial Result EnumerateEntryPointDescriptorBindings([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref DescriptorBinding* pp_bindings);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 772, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial Result EnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 772, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial Result EnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 772, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial Result EnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 772, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial Result EnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 772, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial Result EnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 772, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial Result EnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 772, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial Result EnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 772, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateDescriptorSets")]
        public unsafe partial Result EnumerateDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ReflectDescriptorSet** pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointDescriptorSets")]
        public unsafe partial Result EnumerateEntryPointDescriptorSets([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref ReflectDescriptorSet* pp_sets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial Result EnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial Result EnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial Result EnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial Result EnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial Result EnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial Result EnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial Result EnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInterfaceVariables")]
        public unsafe partial Result EnumerateInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 850, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInterfaceVariables")]
        public unsafe partial Result EnumerateEntryPointInterfaceVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial Result EnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial Result EnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial Result EnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial Result EnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial Result EnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial Result EnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial Result EnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateInputVariables")]
        public unsafe partial Result EnumerateInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 902, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointInputVariables")]
        public unsafe partial Result EnumerateEntryPointInputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial Result EnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial Result EnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial Result EnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial Result EnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial Result EnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial Result EnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial Result EnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateOutputVariables")]
        public unsafe partial Result EnumerateOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, InterfaceVariable** pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointOutputVariables")]
        public unsafe partial Result EnumerateEntryPointOutputVariables([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref InterfaceVariable* pp_variables);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial Result EnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial Result EnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial Result EnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial Result EnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial Result EnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial Result EnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial Result EnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstantBlocks")]
        public unsafe partial Result EnumeratePushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial Result EnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial Result EnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial Result EnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial Result EnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial Result EnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial Result EnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial Result EnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumeratePushConstants")]
        public unsafe partial Result EnumeratePushConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint* p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref uint p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint* p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref uint p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint* p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, BlockVariable** pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateEntryPointPushConstantBlocks")]
        public unsafe partial Result EnumerateEntryPointPushConstantBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref uint p_count, ref BlockVariable* pp_blocks);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateSpecializationConstants")]
        public unsafe partial Result EnumerateSpecializationConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, SpecializationConstant** pp_constants);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateSpecializationConstants")]
        public unsafe partial Result EnumerateSpecializationConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint* p_count, ref SpecializationConstant* pp_constants);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateSpecializationConstants")]
        public unsafe partial Result EnumerateSpecializationConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, SpecializationConstant** pp_constants);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateSpecializationConstants")]
        public unsafe partial Result EnumerateSpecializationConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, ref uint p_count, ref SpecializationConstant* pp_constants);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateSpecializationConstants")]
        public unsafe partial Result EnumerateSpecializationConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, SpecializationConstant** pp_constants);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateSpecializationConstants")]
        public unsafe partial Result EnumerateSpecializationConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint* p_count, ref SpecializationConstant* pp_constants);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateSpecializationConstants")]
        public unsafe partial Result EnumerateSpecializationConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, SpecializationConstant** pp_constants);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectEnumerateSpecializationConstants")]
        public unsafe partial Result EnumerateSpecializationConstants([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, ref uint p_count, ref SpecializationConstant* pp_constants);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint binding_number, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint binding_number, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint binding_number, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint binding_number, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint binding_number, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint binding_number, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint binding_number, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint binding_number, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint binding_number, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint binding_number, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint binding_number, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint binding_number, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint binding_number, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint binding_number, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint binding_number, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorBinding")]
        public unsafe partial DescriptorBinding* GetEntryPointDescriptorBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint binding_number, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1120, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1120, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1120, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1120, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint set_number, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1143, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointDescriptorSet")]
        public unsafe partial ReflectDescriptorSet* GetEntryPointDescriptorSet([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint set_number, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1171, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1171, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1171, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1171, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariable")]
        public unsafe partial InterfaceVariable* GetInputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariable")]
        public unsafe partial InterfaceVariable* GetInputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariable")]
        public unsafe partial InterfaceVariable* GetInputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariable")]
        public unsafe partial InterfaceVariable* GetInputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1204, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1232, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointInputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointInputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1287, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1293, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariable")]
        public unsafe partial InterfaceVariable* GetOutputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1293, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariable")]
        public unsafe partial InterfaceVariable* GetOutputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1293, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariable")]
        public unsafe partial InterfaceVariable* GetOutputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1293, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariable")]
        public unsafe partial InterfaceVariable* GetOutputVariable([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1320, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableByLocation")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableByLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, uint location, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1348, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 36 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointOutputVariableBySemantic")]
        public unsafe partial InterfaceVariable* GetEntryPointOutputVariableBySemantic([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string semantic, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1400, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstantBlock")]
        public unsafe partial BlockVariable* GetPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint index, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1400, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstantBlock")]
        public unsafe partial BlockVariable* GetPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint index, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1400, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstantBlock")]
        public unsafe partial BlockVariable* GetPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint index, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1400, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstantBlock")]
        public unsafe partial BlockVariable* GetPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint index, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstant")]
        public unsafe partial BlockVariable* GetPushConstant([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint index, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstant")]
        public unsafe partial BlockVariable* GetPushConstant([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, uint index, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstant")]
        public unsafe partial BlockVariable* GetPushConstant([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint index, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1406, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetPushConstant")]
        public unsafe partial BlockVariable* GetPushConstant([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, uint index, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial BlockVariable* GetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial BlockVariable* GetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial BlockVariable* GetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial BlockVariable* GetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial BlockVariable* GetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial BlockVariable* GetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial BlockVariable* GetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial BlockVariable* GetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* entry_point, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial BlockVariable* GetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial BlockVariable* GetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte entry_point, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial BlockVariable* GetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, Result* p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1431, Column 32 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectGetEntryPointPushConstantBlock")]
        public unsafe partial BlockVariable* GetEntryPointPushConstantBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string entry_point, ref Result p_result);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumbers")]
        public unsafe partial Result ChangeDescriptorBindingNumbers(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorBinding* p_binding, uint new_binding_number, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumbers")]
        public unsafe partial Result ChangeDescriptorBindingNumbers(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorBinding p_binding, uint new_binding_number, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumbers")]
        public unsafe partial Result ChangeDescriptorBindingNumbers(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorBinding* p_binding, uint new_binding_number, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1461, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumbers")]
        public partial Result ChangeDescriptorBindingNumbers(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorBinding p_binding, uint new_binding_number, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumber")]
        public unsafe partial Result ChangeDescriptorBindingNumber(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorBinding* p_descriptor_binding, uint new_binding_number, uint optional_new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumber")]
        public unsafe partial Result ChangeDescriptorBindingNumber(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorBinding p_descriptor_binding, uint new_binding_number, uint optional_new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumber")]
        public unsafe partial Result ChangeDescriptorBindingNumber(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DescriptorBinding* p_descriptor_binding, uint new_binding_number, uint optional_new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1468, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorBindingNumber")]
        public partial Result ChangeDescriptorBindingNumber(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DescriptorBinding p_descriptor_binding, uint new_binding_number, uint optional_new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorSetNumber")]
        public unsafe partial Result ChangeDescriptorSetNumber(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectDescriptorSet* p_set, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorSetNumber")]
        public unsafe partial Result ChangeDescriptorSetNumber(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectDescriptorSet p_set, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorSetNumber")]
        public unsafe partial Result ChangeDescriptorSetNumber(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectDescriptorSet* p_set, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1497, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeDescriptorSetNumber")]
        public partial Result ChangeDescriptorSetNumber(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectDescriptorSet p_set, uint new_set_number);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeInputVariableLocation")]
        public unsafe partial Result ChangeInputVariableLocation(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InterfaceVariable* p_input_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeInputVariableLocation")]
        public unsafe partial Result ChangeInputVariableLocation(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InterfaceVariable p_input_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeInputVariableLocation")]
        public unsafe partial Result ChangeInputVariableLocation(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InterfaceVariable* p_input_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1520, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeInputVariableLocation")]
        public partial Result ChangeInputVariableLocation(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InterfaceVariable p_input_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeOutputVariableLocation")]
        public unsafe partial Result ChangeOutputVariableLocation(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InterfaceVariable* p_output_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeOutputVariableLocation")]
        public unsafe partial Result ChangeOutputVariableLocation(ReflectShaderModule* p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InterfaceVariable p_output_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeOutputVariableLocation")]
        public unsafe partial Result ChangeOutputVariableLocation(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InterfaceVariable* p_output_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1544, Column 18 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectChangeOutputVariableLocation")]
        public partial Result ChangeOutputVariableLocation(ref ReflectShaderModule p_module, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InterfaceVariable p_output_variable, uint new_location);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1557, Column 13 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectSourceLanguage")]
        public unsafe partial byte* SourceLanguage(Silk.NET.SPIRV.SourceLanguage source_lang);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1557, Column 13 in spirv_reflect.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvReflectSourceLanguage")]
        public partial string SourceLanguageS(Silk.NET.SPIRV.SourceLanguage source_lang);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1565, Column 13 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectBlockVariableTypeName")]
        public unsafe partial byte* BlockVariableTypeName([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlockVariable* p_var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1565, Column 13 in spirv_reflect.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvReflectBlockVariableTypeName")]
        public unsafe partial string BlockVariableTypeNameS([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlockVariable* p_var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1565, Column 13 in spirv_reflect.h")]
        [NativeApi(EntryPoint = "spvReflectBlockVariableTypeName")]
        public unsafe partial byte* BlockVariableTypeName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlockVariable p_var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1565, Column 13 in spirv_reflect.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spvReflectBlockVariableTypeName")]
        public partial string BlockVariableTypeNameS([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlockVariable p_var);


        public Reflect(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

