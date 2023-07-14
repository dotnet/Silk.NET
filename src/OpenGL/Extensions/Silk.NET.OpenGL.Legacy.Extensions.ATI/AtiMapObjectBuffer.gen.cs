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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_map_object_buffer")]
    public unsafe partial class AtiMapObjectBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_map_object_buffer";
        [NativeApi(EntryPoint = "glMapObjectBufferATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapObjectBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glUnmapObjectBufferATI", Convention = CallingConvention.Winapi)]
        public partial void UnmapObjectBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        public AtiMapObjectBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

