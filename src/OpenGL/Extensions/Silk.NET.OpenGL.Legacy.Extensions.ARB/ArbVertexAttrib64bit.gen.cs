// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
    [Extension("ARB_vertex_attrib_64bit")]
    public unsafe partial class ArbVertexAttrib64bit : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_attrib_64bit";
        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public unsafe partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public unsafe partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glVertexAttribL1d")]
        public partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glVertexAttribL1dv")]
        public unsafe partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL1dv")]
        public partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribL2d")]
        public partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glVertexAttribL2dv")]
        public unsafe partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL2dv")]
        public partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribL3d")]
        public partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glVertexAttribL3dv")]
        public unsafe partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL3dv")]
        public partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribL4d")]
        public partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glVertexAttribL4dv")]
        public unsafe partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL4dv")]
        public partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public unsafe partial void VertexAttribLPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public partial void VertexAttribLPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public unsafe partial void VertexAttribLPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public partial void VertexAttribLPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        public ArbVertexAttrib64bit(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

