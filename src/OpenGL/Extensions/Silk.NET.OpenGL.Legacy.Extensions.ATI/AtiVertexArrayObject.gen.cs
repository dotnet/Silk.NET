// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_vertex_array_object")]
    public unsafe partial class AtiVertexArrayObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_vertex_array_object";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glArrayObjectATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ATI type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset)
            => ImplArrayObject(array, size, type, stride, buffer, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFreeObjectBufferATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FreeObjectBuffer([Flow(FlowDirection.In)] uint buffer)
            => ImplFreeObjectBuffer(buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params)
            => ImplGetArrayObject(array, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params)
            => ImplGetArrayObject(array, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params)
            => ImplGetArrayObject(array, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params)
            => ImplGetArrayObject(array, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectBufferfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params)
            => ImplGetObjectBuffer(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectBufferfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params)
            => ImplGetObjectBuffer(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectBufferivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params)
            => ImplGetObjectBuffer(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectBufferivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params)
            => ImplGetObjectBuffer(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params)
            => ImplGetVariantArrayObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params)
            => ImplGetVariantArrayObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params)
            => ImplGetVariantArrayObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params)
            => ImplGetVariantArrayObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsObjectBufferATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsObjectBuffer([Flow(FlowDirection.In)] uint buffer)
            => ImplIsObjectBuffer(buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glNewObjectBufferATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint NewObjectBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] ATI usage)
            => ImplNewObjectBuffer(size, pointer, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glNewObjectBufferATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint NewObjectBuffer<T0>([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> pointer, [Flow(FlowDirection.In)] ATI usage) where T0 : unmanaged
            => ImplNewObjectBuffer<T0>(size, pointer, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="preserve">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUpdateObjectBufferATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UpdateObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] ATI preserve)
            => ImplUpdateObjectBuffer(buffer, offset, size, pointer, preserve);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="preserve">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUpdateObjectBufferATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UpdateObjectBuffer<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> pointer, [Flow(FlowDirection.In)] ATI preserve) where T0 : unmanaged
            => ImplUpdateObjectBuffer<T0>(buffer, offset, size, pointer, preserve);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVariantArrayObjectATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset)
            => ImplVariantArrayObject(id, type, stride, buffer, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glArrayObjectATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset)
            => ImplArrayObject(array, size, type, stride, buffer, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params)
            => ImplGetArrayObject(array, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params)
            => ImplGetArrayObject(array, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params)
            => ImplGetArrayObject(array, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="array">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params)
            => ImplGetArrayObject(array, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectBufferfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params)
            => ImplGetObjectBuffer(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectBufferfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params)
            => ImplGetObjectBuffer(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectBufferivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params)
            => ImplGetObjectBuffer(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectBufferivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params)
            => ImplGetObjectBuffer(buffer, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params)
            => ImplGetVariantArrayObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params)
            => ImplGetVariantArrayObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params)
            => ImplGetVariantArrayObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params)
            => ImplGetVariantArrayObject(id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glNewObjectBufferATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint NewObjectBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] ArrayObjectUsageATI usage)
            => ImplNewObjectBuffer(size, pointer, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glNewObjectBufferATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint NewObjectBuffer<T0>([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> pointer, [Flow(FlowDirection.In)] ArrayObjectUsageATI usage) where T0 : unmanaged
            => ImplNewObjectBuffer<T0>(size, pointer, usage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="preserve">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUpdateObjectBufferATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UpdateObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] PreserveModeATI preserve)
            => ImplUpdateObjectBuffer(buffer, offset, size, pointer, preserve);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="preserve">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUpdateObjectBufferATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UpdateObjectBuffer<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> pointer, [Flow(FlowDirection.In)] PreserveModeATI preserve) where T0 : unmanaged
            => ImplUpdateObjectBuffer<T0>(buffer, offset, size, pointer, preserve);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVariantArrayObjectATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset)
            => ImplVariantArrayObject(id, type, stride, buffer, offset);

        public AtiVertexArrayObject(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

