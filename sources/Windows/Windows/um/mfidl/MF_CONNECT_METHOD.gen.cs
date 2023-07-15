// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MF_CONNECT_METHOD.xml' path='doc/member[@name="MF_CONNECT_METHOD"]/*'/>
public enum MF_CONNECT_METHOD
{
    /// <include file='MF_CONNECT_METHOD.xml' path='doc/member[@name="MF_CONNECT_METHOD.MF_CONNECT_DIRECT"]/*'/>
    MF_CONNECT_DIRECT = 0,
    /// <include file='MF_CONNECT_METHOD.xml' path='doc/member[@name="MF_CONNECT_METHOD.MF_CONNECT_ALLOW_CONVERTER"]/*'/>
    MF_CONNECT_ALLOW_CONVERTER = 0x1,
    /// <include file='MF_CONNECT_METHOD.xml' path='doc/member[@name="MF_CONNECT_METHOD.MF_CONNECT_ALLOW_DECODER"]/*'/>
    MF_CONNECT_ALLOW_DECODER = 0x3,
    /// <include file='MF_CONNECT_METHOD.xml' path='doc/member[@name="MF_CONNECT_METHOD.MF_CONNECT_RESOLVE_INDEPENDENT_OUTPUTTYPES"]/*'/>
    MF_CONNECT_RESOLVE_INDEPENDENT_OUTPUTTYPES = 0x4,
    /// <include file='MF_CONNECT_METHOD.xml' path='doc/member[@name="MF_CONNECT_METHOD.MF_CONNECT_AS_OPTIONAL"]/*'/>
    MF_CONNECT_AS_OPTIONAL = 0x10000,
    /// <include file='MF_CONNECT_METHOD.xml' path='doc/member[@name="MF_CONNECT_METHOD.MF_CONNECT_AS_OPTIONAL_BRANCH"]/*'/>
    MF_CONNECT_AS_OPTIONAL_BRANCH = 0x20000,
}