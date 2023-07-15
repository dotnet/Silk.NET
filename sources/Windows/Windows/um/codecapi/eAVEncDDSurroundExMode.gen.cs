// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='eAVEncDDSurroundExMode.xml' path='doc/member[@name="eAVEncDDSurroundExMode"]/*'/>
public enum eAVEncDDSurroundExMode
{
    /// <include file='eAVEncDDSurroundExMode.xml' path='doc/member[@name="eAVEncDDSurroundExMode.eAVEncDDSurroundExMode_NotIndicated"]/*'/>
    eAVEncDDSurroundExMode_NotIndicated = 0,
    /// <include file='eAVEncDDSurroundExMode.xml' path='doc/member[@name="eAVEncDDSurroundExMode.eAVEncDDSurroundExMode_No"]/*'/>
    eAVEncDDSurroundExMode_No = 1,
    /// <include file='eAVEncDDSurroundExMode.xml' path='doc/member[@name="eAVEncDDSurroundExMode.eAVEncDDSurroundExMode_Yes"]/*'/>
    eAVEncDDSurroundExMode_Yes = 2,
}