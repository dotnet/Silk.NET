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
        public partial void ArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glFreeObjectBufferATI", Convention = CallingConvention.Winapi)]
        public partial void FreeObjectBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetObjectBufferfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetObjectBufferivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVariantArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glIsObjectBufferATI", Convention = CallingConvention.Winapi)]
        public partial bool IsObjectBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glNewObjectBufferATI", Convention = CallingConvention.Winapi)]
        public unsafe partial uint NewObjectBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI usage);

        [NativeApi(EntryPoint = "glUpdateObjectBufferATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void UpdateObjectBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI preserve);

        [NativeApi(EntryPoint = "glVariantArrayObjectATI", Convention = CallingConvention.Winapi)]
        public partial void VariantArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint offset);

        public AtiVertexArrayObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

