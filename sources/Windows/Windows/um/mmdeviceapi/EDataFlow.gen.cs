// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EDataFlow.xml' path='doc/member[@name="EDataFlow"]/*'/>
public enum EDataFlow
{
    /// <include file='EDataFlow.xml' path='doc/member[@name="EDataFlow.eRender"]/*'/>
    eRender = 0,
    /// <include file='EDataFlow.xml' path='doc/member[@name="EDataFlow.eCapture"]/*'/>
    eCapture = (eRender + 1),
    /// <include file='EDataFlow.xml' path='doc/member[@name="EDataFlow.eAll"]/*'/>
    eAll = (eCapture + 1),
    /// <include file='EDataFlow.xml' path='doc/member[@name="EDataFlow.EDataFlow_enum_count"]/*'/>
    EDataFlow_enum_count = (eAll + 1),
}