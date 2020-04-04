// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_secondary_color")]
    public abstract unsafe partial class ExtSecondaryColor : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3bEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] sbyte red, [Flow(FlowDirection.In)] sbyte green, [Flow(FlowDirection.In)] sbyte blue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3bvEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3bvEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3dEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] double red, [Flow(FlowDirection.In)] double green, [Flow(FlowDirection.In)] double blue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3dvEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3dvEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3fEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3fvEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3fvEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3iEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3ivEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3ivEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3sEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] short red, [Flow(FlowDirection.In)] short green, [Flow(FlowDirection.In)] short blue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3svEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3svEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3ubEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] byte red, [Flow(FlowDirection.In)] byte green, [Flow(FlowDirection.In)] byte blue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] byte* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<byte> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3uiEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] uint red, [Flow(FlowDirection.In)] uint green, [Flow(FlowDirection.In)] uint blue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3uivEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] uint* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3uivEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<uint> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3usEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] ushort red, [Flow(FlowDirection.In)] ushort green, [Flow(FlowDirection.In)] ushort blue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3usvEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] ushort* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3usvEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<ushort> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT")]
        public abstract unsafe void SecondaryColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT")]
        public abstract void SecondaryColorPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] string v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT")]
        public abstract unsafe void SecondaryColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT")]
        public abstract void SecondaryColorPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        public ExtSecondaryColor(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

