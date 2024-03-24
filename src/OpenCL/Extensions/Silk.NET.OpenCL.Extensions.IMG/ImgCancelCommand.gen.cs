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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.IMG
{
    [Extension("IMG_cancel_command")]
    public unsafe partial class ImgCancelCommand : NativeExtension<CL>
    {
        public const string ExtensionName = "IMG_cancel_command";
        [NativeApi(EntryPoint = "clCancelCommandsIMG", Convention = CallingConvention.Winapi)]
        public unsafe partial int CancelCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* event_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint num_events_in_list);

        [NativeApi(EntryPoint = "clCancelCommandsIMG", Convention = CallingConvention.Winapi)]
        public partial int CancelCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint event_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint num_events_in_list);

        public ImgCancelCommand(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

