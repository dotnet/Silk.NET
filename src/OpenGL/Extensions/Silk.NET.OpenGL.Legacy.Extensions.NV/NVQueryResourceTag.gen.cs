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
    [Extension("NV_query_resource_tag")]
    public unsafe partial class NVQueryResourceTag : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_query_resource_tag";
        [NativeApi(EntryPoint = "glDeleteQueryResourceTagNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteQueryResourceTag([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* tagIds);

        [NativeApi(EntryPoint = "glGenQueryResourceTagNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenQueryResourceTag([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* tagIds);

        [NativeApi(EntryPoint = "glQueryResourceTagNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void QueryResourceTag([Flow(Silk.NET.Core.Native.FlowDirection.In)] int tagId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* tagString);

        public NVQueryResourceTag(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

