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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_cull_vertex")]
    public abstract unsafe partial class ExtCullVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_cull_vertex";
        [NativeApi(EntryPoint = "glCullParameterdvEXT")]
        public abstract unsafe void CullParameter([Flow(FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glCullParameterdvEXT")]
        public abstract void CullParameter([Flow(FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        [NativeApi(EntryPoint = "glCullParameterfvEXT")]
        public abstract unsafe void CullParameter([Flow(FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glCullParameterfvEXT")]
        public abstract void CullParameter([Flow(FlowDirection.In)] EXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glCullParameterdvEXT")]
        public abstract unsafe void CullParameter([Flow(FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glCullParameterdvEXT")]
        public abstract void CullParameter([Flow(FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        [NativeApi(EntryPoint = "glCullParameterfvEXT")]
        public abstract unsafe void CullParameter([Flow(FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glCullParameterfvEXT")]
        public abstract void CullParameter([Flow(FlowDirection.In)] CullParameterEXT pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        public ExtCullVertex(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

