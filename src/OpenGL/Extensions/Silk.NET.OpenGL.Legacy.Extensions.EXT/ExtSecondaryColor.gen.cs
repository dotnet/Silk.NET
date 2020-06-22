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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_secondary_color")]
    public abstract unsafe partial class ExtSecondaryColor : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_secondary_color";
        [NativeApi(EntryPoint = "glSecondaryColor3bEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] sbyte red, [Flow(FlowDirection.In)] sbyte green, [Flow(FlowDirection.In)] sbyte blue);

        [NativeApi(EntryPoint = "glSecondaryColor3bvEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glSecondaryColor3bvEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> v);

        [NativeApi(EntryPoint = "glSecondaryColor3dEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] double red, [Flow(FlowDirection.In)] double green, [Flow(FlowDirection.In)] double blue);

        [NativeApi(EntryPoint = "glSecondaryColor3dvEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glSecondaryColor3dvEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glSecondaryColor3fEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue);

        [NativeApi(EntryPoint = "glSecondaryColor3fvEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glSecondaryColor3fvEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glSecondaryColor3iEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue);

        [NativeApi(EntryPoint = "glSecondaryColor3ivEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glSecondaryColor3ivEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glSecondaryColor3sEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] short red, [Flow(FlowDirection.In)] short green, [Flow(FlowDirection.In)] short blue);

        [NativeApi(EntryPoint = "glSecondaryColor3svEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glSecondaryColor3svEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glSecondaryColor3ubEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] byte red, [Flow(FlowDirection.In)] byte green, [Flow(FlowDirection.In)] byte blue);

        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<byte> v);

        [NativeApi(EntryPoint = "glSecondaryColor3uiEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] uint red, [Flow(FlowDirection.In)] uint green, [Flow(FlowDirection.In)] uint blue);

        [NativeApi(EntryPoint = "glSecondaryColor3uivEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glSecondaryColor3uivEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glSecondaryColor3usEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] ushort red, [Flow(FlowDirection.In)] ushort green, [Flow(FlowDirection.In)] ushort blue);

        [NativeApi(EntryPoint = "glSecondaryColor3usvEXT")]
        public abstract unsafe void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glSecondaryColor3usvEXT")]
        public abstract void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] Span<ushort> v);

        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT")]
        public abstract unsafe void SecondaryColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT")]
        public abstract void SecondaryColorPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT")]
        public abstract void SecondaryColor3([Flow(FlowDirection.In)] string v);

        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT")]
        public abstract unsafe void SecondaryColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT")]
        public abstract void SecondaryColorPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        public ExtSecondaryColor(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

