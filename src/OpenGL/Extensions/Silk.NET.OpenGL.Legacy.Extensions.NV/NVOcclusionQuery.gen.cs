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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_occlusion_query")]
    public unsafe partial class NVOcclusionQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_occlusion_query";
        [NativeApi(EntryPoint = "glBeginOcclusionQueryNV", Convention = CallingConvention.Winapi)]
        public partial void BeginOcclusionQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteOcclusionQueriesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteOcclusionQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteOcclusionQueriesNV", Convention = CallingConvention.Winapi)]
        public partial void DeleteOcclusionQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint ids);

        [NativeApi(EntryPoint = "glEndOcclusionQueryNV", Convention = CallingConvention.Winapi)]
        public partial void EndOcclusionQuery();

        [NativeApi(EntryPoint = "glGenOcclusionQueriesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenOcclusionQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenOcclusionQueriesNV", Convention = CallingConvention.Winapi)]
        public partial void GenOcclusionQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids);

        [NativeApi(EntryPoint = "glGetOcclusionQueryivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetOcclusionQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetOcclusionQueryivNV", Convention = CallingConvention.Winapi)]
        public partial void GetOcclusionQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetOcclusionQueryivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetOcclusionQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OcclusionQueryParameterNameNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetOcclusionQueryivNV", Convention = CallingConvention.Winapi)]
        public partial void GetOcclusionQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OcclusionQueryParameterNameNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetOcclusionQueryuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetOcclusionQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetOcclusionQueryuivNV", Convention = CallingConvention.Winapi)]
        public partial void GetOcclusionQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetOcclusionQueryuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetOcclusionQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OcclusionQueryParameterNameNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetOcclusionQueryuivNV", Convention = CallingConvention.Winapi)]
        public partial void GetOcclusionQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OcclusionQueryParameterNameNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsOcclusionQueryNV", Convention = CallingConvention.Winapi)]
        public partial bool IsOcclusionQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        public unsafe void DeleteOcclusionQuery([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteOcclusionQueries(1, &ids);
        }

        public unsafe void DeleteOcclusionQueries([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids)
        {
            // ImplicitCountSpanOverloader
            DeleteOcclusionQueries((uint) ids.Length, in ids.GetPinnableReference());
        }

        public unsafe uint GenOcclusionQuery()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenOcclusionQueries(n, &ret);
            return ret;
        }

        public unsafe void GenOcclusionQueries([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids)
        {
            // ImplicitCountSpanOverloader
            GenOcclusionQueries((uint) ids.Length, out ids.GetPinnableReference());
        }

        public unsafe uint GenOcclusionQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            GenOcclusionQueries(n, out uint silkRet);
            return silkRet;
        }

        public unsafe int GetOcclusionQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetOcclusionQuery(id, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetOcclusionQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OcclusionQueryParameterNameNV pname)
        {
            // NonKhrReturnTypeOverloader
            GetOcclusionQuery(id, pname, out int silkRet);
            return silkRet;
        }

        public NVOcclusionQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

