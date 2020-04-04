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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_vertex_attrib_array_object")]
    public abstract unsafe partial class AtiVertexAttribArrayObject : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectfvATI")]
        public abstract unsafe void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectfvATI")]
        public abstract void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectivATI")]
        public abstract unsafe void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectivATI")]
        public abstract void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribArrayObjectATI")]
        public abstract void VertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ATI type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectfvATI")]
        public abstract unsafe void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectfvATI")]
        public abstract void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectivATI")]
        public abstract unsafe void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectivATI")]
        public abstract void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribArrayObjectATI")]
        public abstract void VertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        public AtiVertexAttribArrayObject(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

