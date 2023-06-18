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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_driver_control")]
    public unsafe partial class QComDriverControl : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_driver_control";
        [NativeApi(EntryPoint = "glDisableDriverControlQCOM", Convention = CallingConvention.Winapi)]
        public partial void DisableDriverControl([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl);

        [NativeApi(EntryPoint = "glEnableDriverControlQCOM", Convention = CallingConvention.Winapi)]
        public partial void EnableDriverControl([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl);

        [NativeApi(EntryPoint = "glGetDriverControlsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDriverControl([Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* driverControls);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDriverControlString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* driverControlString);

        public QComDriverControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

