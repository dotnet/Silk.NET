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
    [Extension("NV_query_resource_tag")]
    public abstract unsafe partial class NVQueryResourceTag : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_query_resource_tag";
        [NativeApi(EntryPoint = "glDeleteQueryResourceTagNV")]
        public abstract unsafe void DeleteQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* tagIds);

        [NativeApi(EntryPoint = "glDeleteQueryResourceTagNV")]
        public abstract void DeleteQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<int> tagIds);

        [NativeApi(EntryPoint = "glGenQueryResourceTagNV")]
        public abstract unsafe void GenQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] int* tagIds);

        [NativeApi(EntryPoint = "glGenQueryResourceTagNV")]
        public abstract void GenQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<int> tagIds);

        [NativeApi(EntryPoint = "glQueryResourceTagNV")]
        public abstract unsafe void QueryResourceTag([Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] byte* tagString);

        [NativeApi(EntryPoint = "glQueryResourceTagNV")]
        public abstract void QueryResourceTag([Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] Span<byte> tagString);

        [NativeApi(EntryPoint = "glQueryResourceTagNV")]
        public abstract void QueryResourceTag([Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] string tagString);

        public unsafe void DeleteQueryResourceTag([Count(Parameter = "n"), Flow(FlowDirection.In)] int tagIds)
        {
            // ArrayParameterOverloader
            DeleteQueryResourceTag(1, &tagIds);
        }

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

