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
    [Extension("ATI_element_array")]
    public unsafe partial class AtiElementArray : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_element_array";
        [NativeApi(EntryPoint = "glDrawElementArrayATI", Convention = CallingConvention.Winapi)]
        public partial void DrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawElementArrayATI", Convention = CallingConvention.Winapi)]
        public partial void DrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawRangeElementArrayATI", Convention = CallingConvention.Winapi)]
        public partial void DrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawRangeElementArrayATI", Convention = CallingConvention.Winapi)]
        public partial void DrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glElementPointerATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ElementPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI type, [Count(Computed = "type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glElementPointerATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ElementPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ElementPointerTypeATI type, [Count(Computed = "type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        public AtiElementArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

