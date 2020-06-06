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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_secondary_color")]
    public unsafe partial class ExtSecondaryColor : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_secondary_color";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3bEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Flow(FlowDirection.In)] sbyte red, [Flow(FlowDirection.In)] sbyte green, [Flow(FlowDirection.In)] sbyte blue)
            => ImplSecondaryColor3(red, green, blue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3bvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3bvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3dEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Flow(FlowDirection.In)] double red, [Flow(FlowDirection.In)] double green, [Flow(FlowDirection.In)] double blue)
            => ImplSecondaryColor3(red, green, blue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] double* v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3fEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue)
            => ImplSecondaryColor3(red, green, blue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] float* v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3iEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue)
            => ImplSecondaryColor3(red, green, blue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] int* v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3sEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Flow(FlowDirection.In)] short red, [Flow(FlowDirection.In)] short green, [Flow(FlowDirection.In)] short blue)
            => ImplSecondaryColor3(red, green, blue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3svEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] short* v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3svEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3ubEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Flow(FlowDirection.In)] byte red, [Flow(FlowDirection.In)] byte green, [Flow(FlowDirection.In)] byte blue)
            => ImplSecondaryColor3(red, green, blue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] byte* v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<byte> v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3uiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Flow(FlowDirection.In)] uint red, [Flow(FlowDirection.In)] uint green, [Flow(FlowDirection.In)] uint blue)
            => ImplSecondaryColor3(red, green, blue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] uint* v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3uivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<uint> v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3usEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Flow(FlowDirection.In)] ushort red, [Flow(FlowDirection.In)] ushort green, [Flow(FlowDirection.In)] ushort blue)
            => ImplSecondaryColor3(red, green, blue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3usvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] ushort* v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3usvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<ushort> v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplSecondaryColorPointer(size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColorPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplSecondaryColorPointer<T0>(size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColor3([Flow(FlowDirection.In)] string v)
            => ImplSecondaryColor3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplSecondaryColorPointer(size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColorPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplSecondaryColorPointer<T0>(size, type, stride, pointer);

        public ExtSecondaryColor(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

