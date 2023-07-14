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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_vertex_attrib_binding")]
    public unsafe partial class ArbVertexAttribBinding : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_attrib_binding";
        [NativeApi(EntryPoint = "glBindVertexBuffer", Convention = CallingConvention.Winapi)]
        public partial void BindVertexBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribBinding", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex);

        [NativeApi(EntryPoint = "glVertexAttribFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribIFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribIFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribIFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribIFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribIType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribLFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribLFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribLFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribLFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribLType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexBindingDivisor", Convention = CallingConvention.Winapi)]
        public partial void VertexBindingDivisor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint divisor);

        public ArbVertexAttribBinding(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

