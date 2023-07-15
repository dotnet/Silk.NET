// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
/// <include file='XAPO_PROCESS_BUFFER_PARAMETERS.xml' path='doc/member[@name="XAPO_PROCESS_BUFFER_PARAMETERS"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct XAPO_PROCESS_BUFFER_PARAMETERS
{
    /// <include file='XAPO_PROCESS_BUFFER_PARAMETERS.xml' path='doc/member[@name="XAPO_PROCESS_BUFFER_PARAMETERS.pBuffer"]/*'/>
    public void* pBuffer;
    /// <include file='XAPO_PROCESS_BUFFER_PARAMETERS.xml' path='doc/member[@name="XAPO_PROCESS_BUFFER_PARAMETERS.BufferFlags"]/*'/>
    public XAPO_BUFFER_FLAGS BufferFlags;
    /// <include file='XAPO_PROCESS_BUFFER_PARAMETERS.xml' path='doc/member[@name="XAPO_PROCESS_BUFFER_PARAMETERS.ValidFrameCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint ValidFrameCount;
}