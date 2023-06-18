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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.EXT
{
    [Extension("EXT_debug_label")]
    public unsafe partial class ExtDebugLabel : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_debug_label";
        [NativeApi(EntryPoint = "glGetObjectLabelEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectLabel([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint @object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glLabelObjectEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void LabelObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint @object, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* label);

        public ExtDebugLabel(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

