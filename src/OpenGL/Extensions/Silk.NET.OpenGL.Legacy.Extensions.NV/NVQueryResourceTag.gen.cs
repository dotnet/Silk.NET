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
    [Extension("NV_query_resource_tag")]
    public unsafe partial class NVQueryResourceTag : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_query_resource_tag";
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
        [NativeApi(EntryPoint = "glDeleteQueryResourceTagNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* tagIds)
            => ImplDeleteQueryResourceTag(n, tagIds);

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
        [NativeApi(EntryPoint = "glDeleteQueryResourceTagNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<int> tagIds)
            => ImplDeleteQueryResourceTag(n, tagIds);

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
        [NativeApi(EntryPoint = "glGenQueryResourceTagNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] int* tagIds)
            => ImplGenQueryResourceTag(n, tagIds);

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
        [NativeApi(EntryPoint = "glGenQueryResourceTagNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<int> tagIds)
            => ImplGenQueryResourceTag(n, tagIds);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tagId">
        /// To be added.
        /// </param>
        /// <param name="tagString">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glQueryResourceTagNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void QueryResourceTag([Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] char* tagString)
            => ImplQueryResourceTag(tagId, tagString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tagId">
        /// To be added.
        /// </param>
        /// <param name="tagString">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glQueryResourceTagNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void QueryResourceTag([Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] Span<char> tagString)
            => ImplQueryResourceTag(tagId, tagString);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tagId">
        /// To be added.
        /// </param>
        /// <param name="tagString">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glQueryResourceTagNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void QueryResourceTag([Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] string tagString)
            => ImplQueryResourceTag(tagId, tagString);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GenQueryResourceTag()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            int ret = default;
            GenQueryResourceTag(n, &ret);
            return ret;
        }

        public NVQueryResourceTag(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

