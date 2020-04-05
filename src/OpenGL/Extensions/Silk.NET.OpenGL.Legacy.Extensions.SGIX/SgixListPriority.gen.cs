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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_list_priority")]
    public abstract unsafe partial class SgixListPriority : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetListParameterfvSGIX")]
        public abstract unsafe void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetListParameterfvSGIX")]
        public abstract void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetListParameterivSGIX")]
        public abstract unsafe void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetListParameterivSGIX")]
        public abstract void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glListParameterfSGIX")]
        public abstract void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glListParameterfvSGIX")]
        public abstract unsafe void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glListParameterfvSGIX")]
        public abstract void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glListParameteriSGIX")]
        public abstract void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glListParameterivSGIX")]
        public abstract unsafe void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glListParameterivSGIX")]
        public abstract void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetListParameterfvSGIX")]
        public abstract unsafe void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetListParameterfvSGIX")]
        public abstract void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetListParameterivSGIX")]
        public abstract unsafe void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetListParameterivSGIX")]
        public abstract void GetListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glListParameterfSGIX")]
        public abstract void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glListParameterfvSGIX")]
        public abstract unsafe void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glListParameterfvSGIX")]
        public abstract void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glListParameteriSGIX")]
        public abstract void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glListParameterivSGIX")]
        public abstract unsafe void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glListParameterivSGIX")]
        public abstract void ListParameter([Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        public SgixListPriority(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

