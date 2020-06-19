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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_occlusion_query")]
    public abstract unsafe partial class NVOcclusionQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_occlusion_query";
        [NativeApi(EntryPoint = "glBeginOcclusionQueryNV")]
        public abstract void BeginOcclusionQuery([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteOcclusionQueriesNV")]
        public abstract unsafe void DeleteOcclusionQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteOcclusionQueriesNV")]
        public abstract void DeleteOcclusionQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> ids);

        [NativeApi(EntryPoint = "glEndOcclusionQueryNV")]
        public abstract void EndOcclusionQuery();

        [NativeApi(EntryPoint = "glGenOcclusionQueriesNV")]
        public abstract unsafe void GenOcclusionQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenOcclusionQueriesNV")]
        public abstract void GenOcclusionQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glGetOcclusionQueryivNV")]
        public abstract unsafe void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetOcclusionQueryivNV")]
        public abstract void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetOcclusionQueryuivNV")]
        public abstract unsafe void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetOcclusionQueryuivNV")]
        public abstract void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsOcclusionQueryNV")]
        public abstract bool IsOcclusionQuery([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glGetOcclusionQueryivNV")]
        public abstract unsafe void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] OcclusionQueryParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetOcclusionQueryivNV")]
        public abstract void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] OcclusionQueryParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetOcclusionQueryuivNV")]
        public abstract unsafe void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] OcclusionQueryParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetOcclusionQueryuivNV")]
        public abstract void GetOcclusionQuery([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] OcclusionQueryParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        public unsafe void DeleteOcclusionQuery([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteOcclusionQueries(1, &ids);
        }

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

