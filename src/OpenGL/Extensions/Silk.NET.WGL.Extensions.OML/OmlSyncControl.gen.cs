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
using Silk.NET.WGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.OML
{
    [Extension("OML_sync_control")]
    public unsafe partial class OmlSyncControl : NativeExtension<WGL>
    {
        public const string ExtensionName = "OML_sync_control";
        [NativeApi(EntryPoint = "wglGetMscRateOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetMscRate([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numerator, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* denominator);

        [NativeApi(EntryPoint = "wglGetMscRateOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetMscRate([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numerator, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int denominator);

        [NativeApi(EntryPoint = "wglGetMscRateOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetMscRate([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numerator, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* denominator);

        [NativeApi(EntryPoint = "wglGetMscRateOML", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetMscRate([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int numerator, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int denominator);

        [NativeApi(EntryPoint = "wglGetSyncValuesOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetSyncValues([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc);

        [NativeApi(EntryPoint = "wglGetSyncValuesOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetSyncValues([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long sbc);

        [NativeApi(EntryPoint = "wglGetSyncValuesOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetSyncValues([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc);

        [NativeApi(EntryPoint = "wglGetSyncValuesOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetSyncValues([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long sbc);

        [NativeApi(EntryPoint = "wglGetSyncValuesOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetSyncValues([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc);

        [NativeApi(EntryPoint = "wglGetSyncValuesOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetSyncValues([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long sbc);

        [NativeApi(EntryPoint = "wglGetSyncValuesOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetSyncValues([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc);

        [NativeApi(EntryPoint = "wglGetSyncValuesOML", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetSyncValues([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long sbc);

        [NativeApi(EntryPoint = "wglSwapBuffersMscOML", Convention = CallingConvention.Winapi)]
        public partial long SwapBuffersMsc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder);

        [NativeApi(EntryPoint = "wglSwapLayerBuffersMscOML", Convention = CallingConvention.Winapi)]
        public partial long SwapLayerBuffersMsc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int fuPlanes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder);

        [NativeApi(EntryPoint = "wglWaitForMscOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 WaitForMsc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc);

        [NativeApi(EntryPoint = "wglWaitForMscOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 WaitForMsc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long sbc);

        [NativeApi(EntryPoint = "wglWaitForMscOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 WaitForMsc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc);

        [NativeApi(EntryPoint = "wglWaitForMscOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 WaitForMsc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long sbc);

        [NativeApi(EntryPoint = "wglWaitForMscOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 WaitForMsc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc);

        [NativeApi(EntryPoint = "wglWaitForMscOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 WaitForMsc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long sbc);

        [NativeApi(EntryPoint = "wglWaitForMscOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 WaitForMsc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc);

        [NativeApi(EntryPoint = "wglWaitForMscOML", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 WaitForMsc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long sbc);

        [NativeApi(EntryPoint = "wglWaitForSbcOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 WaitForSbc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc);

        [NativeApi(EntryPoint = "wglWaitForSbcOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 WaitForSbc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long sbc);

        [NativeApi(EntryPoint = "wglWaitForSbcOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 WaitForSbc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc);

        [NativeApi(EntryPoint = "wglWaitForSbcOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 WaitForSbc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long sbc);

        [NativeApi(EntryPoint = "wglWaitForSbcOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 WaitForSbc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc);

        [NativeApi(EntryPoint = "wglWaitForSbcOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 WaitForSbc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long sbc);

        [NativeApi(EntryPoint = "wglWaitForSbcOML", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 WaitForSbc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc);

        [NativeApi(EntryPoint = "wglWaitForSbcOML", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 WaitForSbc([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long sbc);

        public OmlSyncControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

