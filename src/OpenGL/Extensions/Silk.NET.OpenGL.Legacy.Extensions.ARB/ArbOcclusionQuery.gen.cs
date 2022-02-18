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
    [Extension("ARB_occlusion_query")]
    public unsafe partial class ArbOcclusionQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_occlusion_query";
        [NativeApi(EntryPoint = "glBeginQueryARB", Convention = CallingConvention.Winapi)]
        public partial void BeginQuery([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBeginQueryARB", Convention = CallingConvention.Winapi)]
        public partial void BeginQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteQueriesARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteQueriesARB", Convention = CallingConvention.Winapi)]
        public partial void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint ids);

        [NativeApi(EntryPoint = "glDeleteQueriesARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Query* ids);

        [NativeApi(EntryPoint = "glDeleteQueriesARB", Convention = CallingConvention.Winapi)]
        public partial void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Query ids);

        [NativeApi(EntryPoint = "glEndQueryARB", Convention = CallingConvention.Winapi)]
        public partial void EndQuery([Flow(FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glEndQueryARB", Convention = CallingConvention.Winapi)]
        public partial void EndQuery([Flow(FlowDirection.In)] QueryTarget target);

        [NativeApi(EntryPoint = "glGenQueriesARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenQueriesARB", Convention = CallingConvention.Winapi)]
        public partial void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint ids);

        [NativeApi(EntryPoint = "glGenQueriesARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Query* ids);

        [NativeApi(EntryPoint = "glGenQueriesARB", Convention = CallingConvention.Winapi)]
        public partial void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Query ids);

        [NativeApi(EntryPoint = "glGetQueryivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQuery([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryivARB", Convention = CallingConvention.Winapi)]
        public partial void GetQuery([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQuery([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryivARB", Convention = CallingConvention.Winapi)]
        public partial void GetQuery([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryivARB", Convention = CallingConvention.Winapi)]
        public partial void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryivARB", Convention = CallingConvention.Winapi)]
        public partial void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectivARB", Convention = CallingConvention.Winapi)]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectivARB", Convention = CallingConvention.Winapi)]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuivARB", Convention = CallingConvention.Winapi)]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuivARB", Convention = CallingConvention.Winapi)]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsQueryARB", Convention = CallingConvention.Winapi)]
        public partial bool IsQuery([Flow(FlowDirection.In)] uint id);

        public unsafe void DeleteQuery([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteQueries(1, &ids);
        }

        public unsafe void DeleteQueries([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids)
        {
            // ImplicitCountSpanOverloader
            DeleteQueries((uint) ids.Length, in ids.GetPinnableReference());
        }

        public unsafe void DeleteQueries([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Query> ids)
        {
            // ImplicitCountSpanOverloader
            DeleteQueries((uint) ids.Length, in ids.GetPinnableReference());
        }

        public unsafe uint GenQuery()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenQueries(n, &ret);
            return ret;
        }

        public unsafe void GenQueries([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
        {
            // ImplicitCountSpanOverloader
            GenQueries((uint) ids.Length, out ids.GetPinnableReference());
        }

        public unsafe void GenQueries([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Query> ids)
        {
            // ImplicitCountSpanOverloader
            GenQueries((uint) ids.Length, out ids.GetPinnableReference());
        }

        public ArbOcclusionQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

