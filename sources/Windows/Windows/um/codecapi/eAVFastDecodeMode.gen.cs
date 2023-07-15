// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='eAVFastDecodeMode.xml' path='doc/member[@name="eAVFastDecodeMode"]/*'/>
public enum eAVFastDecodeMode
{
    /// <include file='eAVFastDecodeMode.xml' path='doc/member[@name="eAVFastDecodeMode.eVideoDecodeCompliant"]/*'/>
    eVideoDecodeCompliant = 0,
    /// <include file='eAVFastDecodeMode.xml' path='doc/member[@name="eAVFastDecodeMode.eVideoDecodeOptimalLF"]/*'/>
    eVideoDecodeOptimalLF = 1,
    /// <include file='eAVFastDecodeMode.xml' path='doc/member[@name="eAVFastDecodeMode.eVideoDecodeDisableLF"]/*'/>
    eVideoDecodeDisableLF = 2,
    /// <include file='eAVFastDecodeMode.xml' path='doc/member[@name="eAVFastDecodeMode.eVideoDecodeFastest"]/*'/>
    eVideoDecodeFastest = 32,
}