// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audioclientactivationparams.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.19043.0")]
public partial struct AUDIOCLIENT_ACTIVATION_PARAMS
{
    public AUDIOCLIENT_ACTIVATION_TYPE ActivationType;

    [NativeTypeName("__AnonymousRecord_audioclientactivationparams_L94_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS ProcessLoopbackParams
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ProcessLoopbackParams; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS ProcessLoopbackParams;
    }
}
