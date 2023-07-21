// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='FXMASTERINGLIMITER_PARAMETERS.xml' path='doc/member[@name="FXMASTERINGLIMITER_PARAMETERS"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FXMASTERINGLIMITER_PARAMETERS
{
    /// <include file='FXMASTERINGLIMITER_PARAMETERS.xml' path='doc/member[@name="FXMASTERINGLIMITER_PARAMETERS.Release"]/*' />
    [NativeTypeName("UINT32")]
    public uint Release;

    /// <include file='FXMASTERINGLIMITER_PARAMETERS.xml' path='doc/member[@name="FXMASTERINGLIMITER_PARAMETERS.Loudness"]/*' />
    [NativeTypeName("UINT32")]
    public uint Loudness;
}
