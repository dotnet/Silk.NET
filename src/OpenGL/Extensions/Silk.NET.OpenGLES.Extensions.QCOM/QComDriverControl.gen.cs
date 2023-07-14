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

        [NativeApi(EntryPoint = "glGetDriverControlsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDriverControl([Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint driverControls);

        [NativeApi(EntryPoint = "glGetDriverControlsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDriverControl([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* driverControls);

        [NativeApi(EntryPoint = "glGetDriverControlsQCOM", Convention = CallingConvention.Winapi)]
        public partial void GetDriverControl([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint driverControls);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDriverControlString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* driverControlString);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDriverControlString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte driverControlString);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDriverControlString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string driverControlString);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDriverControlString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* driverControlString);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM", Convention = CallingConvention.Winapi)]
        public partial void GetDriverControlString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte driverControlString);

        [NativeApi(EntryPoint = "glGetDriverControlStringQCOM", Convention = CallingConvention.Winapi)]
        public partial void GetDriverControlString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string driverControlString);

        public unsafe uint GetDriverControl([Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num)
        {
            const uint size = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GetDriverControl(num, size, &ret);
            return ret;
        }

        public unsafe void GetDriverControl([Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> driverControls)
        {
            // ImplicitCountSpanOverloader
            GetDriverControl(num, (uint) driverControls.Length, out driverControls.GetPinnableReference());
        }

        public unsafe void GetDriverControl([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> driverControls)
        {
            // ImplicitCountSpanOverloader
            GetDriverControl(out num, (uint) driverControls.Length, out driverControls.GetPinnableReference());
        }

        public unsafe void GetDriverControlString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> driverControlString)
        {
            // ImplicitCountSpanOverloader
            GetDriverControlString(driverControl, (uint) driverControlString.Length, length, out driverControlString.GetPinnableReference());
        }

        public unsafe void GetDriverControlString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> driverControlString)
        {
            // ImplicitCountSpanOverloader
            GetDriverControlString(driverControl, (uint) driverControlString.Length, length, out driverControlString.GetPinnableReference());
        }

        public unsafe void GetDriverControlString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> driverControlString)
        {
            // ImplicitCountSpanOverloader
            GetDriverControlString(driverControl, (uint) driverControlString.Length, out length, out driverControlString.GetPinnableReference());
        }

        public unsafe void GetDriverControlString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> driverControlString)
        {
            // ImplicitCountSpanOverloader
            GetDriverControlString(driverControl, (uint) driverControlString.Length, out length, out driverControlString.GetPinnableReference());
        }

        public unsafe uint GetDriverControl([Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* num, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size)
        {
            // NonKhrReturnTypeOverloader
            GetDriverControl(num, size, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetDriverControl([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int num, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size)
        {
            // NonKhrReturnTypeOverloader
            GetDriverControl(out num, size, out uint silkRet);
            return silkRet;
        }

        public unsafe byte GetDriverControlString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length)
        {
            // NonKhrReturnTypeOverloader
            GetDriverControlString(driverControl, bufSize, length, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetDriverControlString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint driverControl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length)
        {
            // NonKhrReturnTypeOverloader
            GetDriverControlString(driverControl, bufSize, out length, out byte silkRet);
            return silkRet;
        }

        public QComDriverControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

