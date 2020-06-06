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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_query_resource")]
    public unsafe partial class NVQueryResource : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_query_resource";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryType">
        /// To be added.
        /// </param>
        /// <param name="tagId">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glQueryResourceNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int QueryResource([Flow(FlowDirection.In)] NV queryType, [Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* buffer)
            => ImplQueryResource(queryType, tagId, count, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryType">
        /// To be added.
        /// </param>
        /// <param name="tagId">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glQueryResourceNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int QueryResource([Flow(FlowDirection.In)] NV queryType, [Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> buffer)
            => ImplQueryResource(queryType, tagId, count, buffer);

        public NVQueryResource(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

