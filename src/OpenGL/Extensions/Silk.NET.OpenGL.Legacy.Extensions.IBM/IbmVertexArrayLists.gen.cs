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

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    [Extension("IBM_vertex_array_lists")]
    public unsafe partial class IbmVertexArrayLists : NativeExtension<GL>
    {
        public const string ExtensionName = "IBM_vertex_array_lists";
        [NativeApi(EntryPoint = "glColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void ColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void ColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glEdgeFlagPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void EdgeFlagPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] bool** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glEdgeFlagPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void EdgeFlagPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in bool* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glEdgeFlagPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void EdgeFlagPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glEdgeFlagPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void EdgeFlagPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glFogCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void FogCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glFogCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void FogCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glFogCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void FogCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glFogCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void FogCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glFogCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void FogCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] FogPointerTypeIBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glFogCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void FogCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] FogPointerTypeIBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glFogCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void FogCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] FogPointerTypeIBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glFogCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void FogCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] FogPointerTypeIBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glIndexPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void IndexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glIndexPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void IndexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glIndexPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void IndexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glIndexPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void IndexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glIndexPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void IndexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IndexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glIndexPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void IndexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IndexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glIndexPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void IndexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IndexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glIndexPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void IndexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IndexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glNormalPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glNormalPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glNormalPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glNormalPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void NormalPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glNormalPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] NormalPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glNormalPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] NormalPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glNormalPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] NormalPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glNormalPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void NormalPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] NormalPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SecondaryColorPointerTypeIBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SecondaryColorPointerTypeIBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void SecondaryColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SecondaryColorPointerTypeIBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColorPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SecondaryColorPointerTypeIBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glTexCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glTexCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glTexCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glTexCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void TexCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glTexCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glTexCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glTexCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glTexCoordPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void TexCoordPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glVertexPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glVertexPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glVertexPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glVertexPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void VertexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glVertexPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glVertexPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glVertexPointerListIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glVertexPointerListIBM", Convention = CallingConvention.Winapi)]
        public partial void VertexPointerList([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride);

        public IbmVertexArrayLists(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

