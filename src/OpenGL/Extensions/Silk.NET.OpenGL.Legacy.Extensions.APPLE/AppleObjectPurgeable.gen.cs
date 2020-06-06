// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_object_purgeable")]
    public unsafe partial class AppleObjectPurgeable : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_object_purgeable";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="objectType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectParameterivAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetObjectParameter([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetObjectParameter(objectType, name, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="objectType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectParameterivAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetObjectParameter([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetObjectParameter(objectType, name, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="objectType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="option">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glObjectPurgeableAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public APPLE ObjectPurgeable([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE option)
            => ImplObjectPurgeable(objectType, name, option);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="objectType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="option">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glObjectUnpurgeableAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public APPLE ObjectUnpurgeable([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE option)
            => ImplObjectUnpurgeable(objectType, name, option);

        public AppleObjectPurgeable(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

