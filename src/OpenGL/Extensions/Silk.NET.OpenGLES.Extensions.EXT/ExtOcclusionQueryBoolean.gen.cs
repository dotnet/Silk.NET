// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_occlusion_query_boolean")]
    public abstract unsafe partial class ExtOcclusionQueryBoolean : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginQueryEXT")]
        public abstract void BeginQuery([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteQueriesEXT")]
        public abstract unsafe void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteQueriesEXT")]
        public abstract void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEndQueryEXT")]
        public abstract void EndQuery([Flow(FlowDirection.In)] EXT target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenQueriesEXT")]
        public abstract unsafe void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenQueriesEXT")]
        public abstract void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        public abstract unsafe void GetQuery([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        public abstract void GetQuery([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectuivEXT")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectuivEXT")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsQueryEXT")]
        public abstract bool IsQuery([Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginQueryEXT")]
        public abstract void BeginQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEndQueryEXT")]
        public abstract void EndQuery([Flow(FlowDirection.In)] QueryTarget target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        public abstract unsafe void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryivEXT")]
        public abstract void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectuivEXT")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectuivEXT")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteQuery([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteQueries(1, &ids);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint GenQuery()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenQueries(n, &ret);
            return ret;
        }

        public ExtOcclusionQueryBoolean(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

