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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_vertex_type_2_10_10_10_rev")]
    public unsafe partial class ArbVertexType2101010Rev : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_type_2_10_10_10_rev";
        [NativeApi(EntryPoint = "glVertexAttribP1ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP1ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4ui", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribP4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        public ArbVertexType2101010Rev(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

