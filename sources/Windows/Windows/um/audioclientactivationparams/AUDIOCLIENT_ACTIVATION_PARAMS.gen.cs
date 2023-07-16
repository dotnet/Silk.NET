// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audioclientactivationparams.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='AUDIOCLIENT_ACTIVATION_PARAMS.xml' path='doc/member[@name="AUDIOCLIENT_ACTIVATION_PARAMS"]/*'/>
[SupportedOSPlatform("windows10.0.19043.0")]
public partial struct AUDIOCLIENT_ACTIVATION_PARAMS
{
    /// <include file='AUDIOCLIENT_ACTIVATION_PARAMS.xml' path='doc/member[@name="AUDIOCLIENT_ACTIVATION_PARAMS.ActivationType"]/*'/>
    public AUDIOCLIENT_ACTIVATION_TYPE ActivationType;
    /// <include file='AUDIOCLIENT_ACTIVATION_PARAMS.xml' path='doc/member[@name="AUDIOCLIENT_ACTIVATION_PARAMS.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_audioclientactivationparams_L94_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ProcessLoopbackParams"]/*'/>
    [UnscopedRef]
    public ref AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS ProcessLoopbackParams
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ProcessLoopbackParams;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ProcessLoopbackParams"]/*'/>
        [FieldOffset(0)]
        public AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS ProcessLoopbackParams;
    }
}