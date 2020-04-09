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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_timer_query")]
    public abstract unsafe partial class ExtTimerQuery : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjecti64vEXT")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjecti64vEXT")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectui64vEXT")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectui64vEXT")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjecti64vEXT")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjecti64vEXT")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectui64vEXT")]
        public abstract unsafe void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryObjectui64vEXT")]
        public abstract void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        public ExtTimerQuery(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

