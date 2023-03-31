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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_instruments")]
    public unsafe partial class SgixInstruments : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_instruments";
        [NativeApi(EntryPoint = "glGetInstrumentsSGIX", Convention = CallingConvention.Winapi)]
        public partial int GetInstruments();

        [NativeApi(EntryPoint = "glInstrumentsBufferSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void InstrumentsBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* buffer);

        [NativeApi(EntryPoint = "glInstrumentsBufferSGIX", Convention = CallingConvention.Winapi)]
        public partial void InstrumentsBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int buffer);

        [NativeApi(EntryPoint = "glPollInstrumentsSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial int PollInstruments([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* marker_p);

        [NativeApi(EntryPoint = "glPollInstrumentsSGIX", Convention = CallingConvention.Winapi)]
        public partial int PollInstruments([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int marker_p);

        [NativeApi(EntryPoint = "glReadInstrumentsSGIX", Convention = CallingConvention.Winapi)]
        public partial void ReadInstruments([Flow(Silk.NET.Core.Native.FlowDirection.In)] int marker);

        [NativeApi(EntryPoint = "glStartInstrumentsSGIX", Convention = CallingConvention.Winapi)]
        public partial void StartInstruments();

        [NativeApi(EntryPoint = "glStopInstrumentsSGIX", Convention = CallingConvention.Winapi)]
        public partial void StopInstruments([Flow(Silk.NET.Core.Native.FlowDirection.In)] int marker);

        public unsafe void InstrumentsBuffer([Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> buffer)
        {
            // ImplicitCountSpanOverloader
            InstrumentsBuffer((uint) buffer.Length, out buffer.GetPinnableReference());
        }

        public unsafe int InstrumentsBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size)
        {
            // NonKhrReturnTypeOverloader
            InstrumentsBuffer(size, out int silkRet);
            return silkRet;
        }

        public SgixInstruments(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

