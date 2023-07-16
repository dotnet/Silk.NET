// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TF_HALTCOND.xml' path='doc/member[@name="TF_HALTCOND"]/*'/>
public unsafe partial struct TF_HALTCOND
{
    /// <include file='TF_HALTCOND.xml' path='doc/member[@name="TF_HALTCOND.pHaltRange"]/*'/>
    public ITfRange* pHaltRange;
    /// <include file='TF_HALTCOND.xml' path='doc/member[@name="TF_HALTCOND.aHaltPos"]/*'/>
    public TfAnchor aHaltPos;
    /// <include file='TF_HALTCOND.xml' path='doc/member[@name="TF_HALTCOND.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}