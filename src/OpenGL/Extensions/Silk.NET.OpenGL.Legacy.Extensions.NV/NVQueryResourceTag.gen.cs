// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
    [Extension("NV_query_resource_tag")]
    public unsafe partial class NVQueryResourceTag : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_query_resource_tag";
        [NativeApi(EntryPoint = "glDeleteQueryResourceTagNV")]
        public unsafe partial void DeleteQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* tagIds);

        [NativeApi(EntryPoint = "glDeleteQueryResourceTagNV")]
        public partial void DeleteQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in int tagIds);

        [NativeApi(EntryPoint = "glGenQueryResourceTagNV")]
        public unsafe partial void GenQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] int* tagIds);

        [NativeApi(EntryPoint = "glGenQueryResourceTagNV")]
        public partial void GenQueryResourceTag([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out int tagIds);

        [NativeApi(EntryPoint = "glQueryResourceTagNV")]
        public unsafe partial void QueryResourceTag([Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] byte* tagString);

        [NativeApi(EntryPoint = "glQueryResourceTagNV")]
        public partial void QueryResourceTag([Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] in byte tagString);

        [NativeApi(EntryPoint = "glQueryResourceTagNV")]
        public partial void QueryResourceTag([Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] string tagString);

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

        public NVQueryResourceTag(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

