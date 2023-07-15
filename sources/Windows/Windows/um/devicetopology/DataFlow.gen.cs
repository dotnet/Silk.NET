// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DataFlow.xml' path='doc/member[@name="DataFlow"]/*'/>
public enum DataFlow
{
    /// <include file='DataFlow.xml' path='doc/member[@name="DataFlow.In"]/*'/>
    In = 0,
    /// <include file='DataFlow.xml' path='doc/member[@name="DataFlow.Out"]/*'/>
    Out = (In + 1),
}