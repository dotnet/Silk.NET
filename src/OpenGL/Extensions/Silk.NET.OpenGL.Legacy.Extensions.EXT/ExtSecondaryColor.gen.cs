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
        public partial void SecondaryColor3([Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte blue);

        [NativeApi(EntryPoint = "glSecondaryColor3bvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glSecondaryColor3bvEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte v);

        [NativeApi(EntryPoint = "glSecondaryColor3dEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(Silk.NET.Core.Native.FlowDirection.In)] double red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double blue);

        [NativeApi(EntryPoint = "glSecondaryColor3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glSecondaryColor3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glSecondaryColor3fEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(Silk.NET.Core.Native.FlowDirection.In)] float red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float blue);

        [NativeApi(EntryPoint = "glSecondaryColor3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glSecondaryColor3fvEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glSecondaryColor3iEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int blue);

        [NativeApi(EntryPoint = "glSecondaryColor3ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glSecondaryColor3ivEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glSecondaryColor3sEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(Silk.NET.Core.Native.FlowDirection.In)] short red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short blue);

        [NativeApi(EntryPoint = "glSecondaryColor3svEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glSecondaryColor3svEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        [NativeApi(EntryPoint = "glSecondaryColor3ubEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte blue);

        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte v);

        [NativeApi(EntryPoint = "glSecondaryColor3ubvEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string v);

        [NativeApi(EntryPoint = "glSecondaryColor3uiEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint blue);

        [NativeApi(EntryPoint = "glSecondaryColor3uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glSecondaryColor3uivEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint v);

        [NativeApi(EntryPoint = "glSecondaryColor3usEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort blue);

        [NativeApi(EntryPoint = "glSecondaryColor3usvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glSecondaryColor3usvEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColor3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort v);

        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColorPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColorPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColorPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glSecondaryColorPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColorPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        public ExtSecondaryColor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

