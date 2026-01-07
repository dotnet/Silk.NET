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

namespace Silk.NET.OpenCL.Extensions.QCOM
{
    [Extension("QCOM_perf_hint")]
    public unsafe partial class QComPerfHint : NativeExtension<CL>
    {
        public const string ExtensionName = "QCOM_perf_hint";
        [NativeApi(EntryPoint = "clSetPerfHintQCOM", Convention = CallingConvention.Winapi)]
        public partial int SetPerfHint([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PerfHint perf_hint);

        [Obsolete("The \"ungrouped\" enums (QCOM) are deprecated in favour of the \"grouped\" enums (PerfHint). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", false)]
        [NativeApi(EntryPoint = "clSetPerfHintQCOM", Convention = CallingConvention.Winapi)]
        public partial int SetPerfHint([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM perf_hint);

        public QComPerfHint(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

