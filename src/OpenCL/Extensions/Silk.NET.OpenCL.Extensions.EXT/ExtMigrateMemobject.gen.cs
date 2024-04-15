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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [Extension("EXT_migrate_memobject")]
    public unsafe partial class ExtMigrateMemobject : NativeExtension<CL>
    {
        public const string ExtensionName = "EXT_migrate_memobject";
        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemMigrationFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* @event);

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (MemMigrationFlags). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        [NativeApi(EntryPoint = "clEnqueueMigrateMemObjectEXT", Convention = CallingConvention.Winapi)]
        public partial int EnqueueMigrateMemObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint command_queue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint mem_objects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_events_in_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_wait_list, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint @event);

        public ExtMigrateMemobject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

