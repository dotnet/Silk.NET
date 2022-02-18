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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_vertex_array_object")]
    public unsafe partial class AtiVertexArrayObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_vertex_array_object";
        [NativeApi(EntryPoint = "glArrayObjectATI", Convention = CallingConvention.Winapi)]
        public partial void ArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ATI type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glArrayObjectATI", Convention = CallingConvention.Winapi)]
        public partial void ArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glArrayObjectATI", Convention = CallingConvention.Winapi)]
        public partial void ArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ATI type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glArrayObjectATI", Convention = CallingConvention.Winapi)]
        public partial void ArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glFreeObjectBufferATI", Convention = CallingConvention.Winapi)]
        public partial void FreeObjectBuffer([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetObjectBufferfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetObjectBufferfvATI", Convention = CallingConvention.Winapi)]
        public partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetObjectBufferfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetObjectBufferfvATI", Convention = CallingConvention.Winapi)]
        public partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetObjectBufferivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetObjectBufferivATI", Convention = CallingConvention.Winapi)]
        public partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetObjectBufferivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetObjectBufferivATI", Convention = CallingConvention.Winapi)]
        public partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIsObjectBufferATI", Convention = CallingConvention.Winapi)]
        public partial bool IsObjectBuffer([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glNewObjectBufferATI", Convention = CallingConvention.Winapi)]
        public unsafe partial uint NewObjectBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] ATI usage);

        [NativeApi(EntryPoint = "glNewObjectBufferATI", Convention = CallingConvention.Winapi)]
        public partial uint NewObjectBuffer<T0>([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 pointer, [Flow(FlowDirection.In)] ATI usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNewObjectBufferATI", Convention = CallingConvention.Winapi)]
        public unsafe partial uint NewObjectBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] ArrayObjectUsageATI usage);

        [NativeApi(EntryPoint = "glNewObjectBufferATI", Convention = CallingConvention.Winapi)]
        public partial uint NewObjectBuffer<T0>([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 pointer, [Flow(FlowDirection.In)] ArrayObjectUsageATI usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glUpdateObjectBufferATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void UpdateObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] ATI preserve);

        [NativeApi(EntryPoint = "glUpdateObjectBufferATI", Convention = CallingConvention.Winapi)]
        public partial void UpdateObjectBuffer<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 pointer, [Flow(FlowDirection.In)] ATI preserve) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glUpdateObjectBufferATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void UpdateObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] PreserveModeATI preserve);

        [NativeApi(EntryPoint = "glUpdateObjectBufferATI", Convention = CallingConvention.Winapi)]
        public partial void UpdateObjectBuffer<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 pointer, [Flow(FlowDirection.In)] PreserveModeATI preserve) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVariantArrayObjectATI", Convention = CallingConvention.Winapi)]
        public partial void VariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glVariantArrayObjectATI", Convention = CallingConvention.Winapi)]
        public partial void VariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        public unsafe uint NewObjectBuffer<T0>([Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer, [Flow(FlowDirection.In)] ATI usage) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            return NewObjectBuffer((uint) (pointer.Length * Unsafe.SizeOf<T0>()), in pointer.GetPinnableReference(), usage);
        }

        public unsafe uint NewObjectBuffer<T0>([Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer, [Flow(FlowDirection.In)] ArrayObjectUsageATI usage) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            return NewObjectBuffer((uint) (pointer.Length * Unsafe.SizeOf<T0>()), in pointer.GetPinnableReference(), usage);
        }

        public unsafe void UpdateObjectBuffer<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer, [Flow(FlowDirection.In)] ATI preserve) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            UpdateObjectBuffer(buffer, offset, (uint) (pointer.Length * Unsafe.SizeOf<T0>()), in pointer.GetPinnableReference(), preserve);
        }

        public unsafe void UpdateObjectBuffer<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer, [Flow(FlowDirection.In)] PreserveModeATI preserve) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            UpdateObjectBuffer(buffer, offset, (uint) (pointer.Length * Unsafe.SizeOf<T0>()), in pointer.GetPinnableReference(), preserve);
        }

        public AtiVertexArrayObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

