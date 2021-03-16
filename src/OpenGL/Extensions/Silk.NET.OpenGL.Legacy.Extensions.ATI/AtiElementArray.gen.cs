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
        [NativeApi(EntryPoint = "glDrawElementArrayATI")]
        public partial void DrawElementArray([Flow(FlowDirection.In)] ATI mode, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawElementArrayATI")]
        public partial void DrawElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawRangeElementArrayATI")]
        public partial void DrawRangeElementArray([Flow(FlowDirection.In)] ATI mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawRangeElementArrayATI")]
        public partial void DrawRangeElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glElementPointerATI")]
        public unsafe partial void ElementPointer([Flow(FlowDirection.In)] ATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glElementPointerATI")]
        public partial void ElementPointer<T0>([Flow(FlowDirection.In)] ATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glElementPointerATI")]
        public unsafe partial void ElementPointer([Flow(FlowDirection.In)] ElementPointerTypeATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glElementPointerATI")]
        public partial void ElementPointer<T0>([Flow(FlowDirection.In)] ElementPointerTypeATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        public AtiElementArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

