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
    [Extension("NV_query_resource_tag")]
    public abstract unsafe partial class NVQueryResourceTag : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteQueryResourceTagNV")]
        public abstract unsafe void DeleteQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* tagIds);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteQueryResourceTagNV")]
        public abstract void DeleteQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<int> tagIds);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenQueryResourceTagNV")]
        public abstract unsafe void GenQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] int* tagIds);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenQueryResourceTagNV")]
        public abstract void GenQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<int> tagIds);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glQueryResourceTagNV")]
        public abstract unsafe void QueryResourceTag([Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] char* tagString);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glQueryResourceTagNV")]
        public abstract void QueryResourceTag([Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] Span<char> tagString);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glQueryResourceTagNV")]
        public abstract void QueryResourceTag([Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] string tagString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="tagIds">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe void DeleteQueryResourceTag([Count(Parameter = "n"), Flow(FlowDirection.In)] int tagIds)
        {
            // ArrayParameterOverloader
            DeleteQueryResourceTag(1, &tagIds);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="tagIds">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe int GenQueryResourceTag()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            int ret = default;
            GenQueryResourceTag(n, &ret);
            return ret;
        }

        public NVQueryResourceTag(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

