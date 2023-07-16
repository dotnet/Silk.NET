// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='eAVEncInputVideoSystem.xml' path='doc/member[@name="eAVEncInputVideoSystem"]/*'/>
public enum eAVEncInputVideoSystem
{
    /// <include file='eAVEncInputVideoSystem.xml' path='doc/member[@name="eAVEncInputVideoSystem.eAVEncInputVideoSystem_Unspecified"]/*'/>
    eAVEncInputVideoSystem_Unspecified = 0,
    /// <include file='eAVEncInputVideoSystem.xml' path='doc/member[@name="eAVEncInputVideoSystem.eAVEncInputVideoSystem_PAL"]/*'/>
    eAVEncInputVideoSystem_PAL = 1,
    /// <include file='eAVEncInputVideoSystem.xml' path='doc/member[@name="eAVEncInputVideoSystem.eAVEncInputVideoSystem_NTSC"]/*'/>
    eAVEncInputVideoSystem_NTSC = 2,
    /// <include file='eAVEncInputVideoSystem.xml' path='doc/member[@name="eAVEncInputVideoSystem.eAVEncInputVideoSystem_SECAM"]/*'/>
    eAVEncInputVideoSystem_SECAM = 3,
    /// <include file='eAVEncInputVideoSystem.xml' path='doc/member[@name="eAVEncInputVideoSystem.eAVEncInputVideoSystem_MAC"]/*'/>
    eAVEncInputVideoSystem_MAC = 4,
    /// <include file='eAVEncInputVideoSystem.xml' path='doc/member[@name="eAVEncInputVideoSystem.eAVEncInputVideoSystem_HDV"]/*'/>
    eAVEncInputVideoSystem_HDV = 5,
    /// <include file='eAVEncInputVideoSystem.xml' path='doc/member[@name="eAVEncInputVideoSystem.eAVEncInputVideoSystem_Component"]/*'/>
    eAVEncInputVideoSystem_Component = 6,
}