// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='WS_DURATION_DESCRIPTION.xml' path='doc/member[@name="WS_DURATION_DESCRIPTION"]/*'/>
public unsafe partial struct WS_DURATION_DESCRIPTION
{
    /// <include file='WS_DURATION_DESCRIPTION.xml' path='doc/member[@name="WS_DURATION_DESCRIPTION.minValue"]/*'/>
    public WS_DURATION minValue;
    /// <include file='WS_DURATION_DESCRIPTION.xml' path='doc/member[@name="WS_DURATION_DESCRIPTION.maxValue"]/*'/>
    public WS_DURATION maxValue;
    /// <include file='WS_DURATION_DESCRIPTION.xml' path='doc/member[@name="WS_DURATION_DESCRIPTION.comparer"]/*'/>
    [NativeTypeName("WS_DURATION_COMPARISON_CALLBACK")]
    public delegate* unmanaged<WS_DURATION*, WS_DURATION*, int*, IntPtr, HRESULT> comparer;
}