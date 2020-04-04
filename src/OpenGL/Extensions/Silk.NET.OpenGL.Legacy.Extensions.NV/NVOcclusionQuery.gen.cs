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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_occlusion_query")]
    public abstract unsafe partial class NVOcclusionQuery : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginOcclusionQueryNV")]
        public abstract void BeginOcclusionQuery([Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteOcclusionQueriesNV")]
        public abstract unsafe void DeleteOcclusionQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteOcclusionQueriesNV")]
        public abstract void DeleteOcclusionQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEndOcclusionQueryNV")]
        public abstract void EndOcclusionQuery();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenOcclusionQueriesNV")]
        public abstract unsafe void GenOcclusionQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenOcclusionQueriesNV")]
        public abstract void GenOcclusionQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetOcclusionQueryivNV")]
        public abstract unsafe void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetOcclusionQueryivNV")]
        public abstract void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetOcclusionQueryuivNV")]
        public abstract unsafe void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetOcclusionQueryuivNV")]
        public abstract void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsOcclusionQueryNV")]
        public abstract bool IsOcclusionQuery([Flow(FlowDirection.In)] uint id);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetOcclusionQueryivNV")]
        public abstract unsafe void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] OcclusionQueryParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetOcclusionQueryivNV")]
        public abstract void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] OcclusionQueryParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetOcclusionQueryuivNV")]
        public abstract unsafe void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] OcclusionQueryParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetOcclusionQueryuivNV")]
        public abstract void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] OcclusionQueryParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

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
        public unsafe void DeleteOcclusionQuery([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteOcclusionQueries(1, &ids);
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
        public unsafe uint GenOcclusionQuery()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenOcclusionQueries(n, &ret);
            return ret;
        }

        public NVOcclusionQuery(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

