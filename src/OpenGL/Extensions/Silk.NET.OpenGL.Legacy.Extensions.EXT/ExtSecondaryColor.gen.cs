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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_secondary_color")]
    public unsafe partial class ExtSecondaryColor : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_secondary_color";
        [NativeApi(EntryPoint = "glSecondaryColor3bEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(FlowDirection.In)] sbyte red, [Flow(FlowDirection.In)] sbyte green, [Flow(FlowDirection.In)] sbyte blue);

        [NativeApi(EntryPoint = "glSecondaryColor3bvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glSecondaryColor3bvEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] in sbyte v);

        [NativeApi(EntryPoint = "glSecondaryColor3dEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(FlowDirection.In)] double red, [Flow(FlowDirection.In)] double green, [Flow(FlowDirection.In)] double blue);

        [NativeApi(EntryPoint = "glSecondaryColor3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glSecondaryColor3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glSecondaryColor3fEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue);

        [NativeApi(EntryPoint = "glSecondaryColor3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glSecondaryColor3fvEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glSecondaryColor3iEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(FlowDirection.In)] int red, [Flow(FlowDirection.In)] int green, [Flow(FlowDirection.In)] int blue);

        [NativeApi(EntryPoint = "glSecondaryColor3ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glSecondaryColor3ivEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glSecondaryColor3sEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(FlowDirection.In)] short red, [Flow(FlowDirection.In)] short green, [Flow(FlowDirection.In)] short blue);

        [NativeApi(EntryPoint = "glSecondaryColor3svEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glSecondaryColor3svEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glSecondaryColor3ubEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(FlowDirection.In)] byte red, [Flow(FlowDirection.In)] byte green, [Flow(FlowDirection.In)] byte blue);

        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] in byte v);

        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string v);

        [NativeApi(EntryPoint = "glSecondaryColor3uiEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(FlowDirection.In)] uint red, [Flow(FlowDirection.In)] uint green, [Flow(FlowDirection.In)] uint blue);

        [NativeApi(EntryPoint = "glSecondaryColor3uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glSecondaryColor3uivEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] in uint v);

        [NativeApi(EntryPoint = "glSecondaryColor3usEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(FlowDirection.In)] ushort red, [Flow(FlowDirection.In)] ushort green, [Flow(FlowDirection.In)] ushort blue);

        [NativeApi(EntryPoint = "glSecondaryColor3usvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glSecondaryColor3usvEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(FlowDirection.In)] in ushort v);

        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        public ExtSecondaryColor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

