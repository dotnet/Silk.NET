// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roparameterizediid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.WinRT;
public static unsafe partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoGetParameterizedTypeInstanceIID"]/*'/>
    [DllImport("api-ms-win-core-winrt-roparameterizediid-l1-1-0", ExactSpelling = true)]
    public static extern HRESULT RoGetParameterizedTypeInstanceIID([NativeTypeName("UINT32")] uint nameElementCount, [NativeTypeName("PCWSTR *")] ushort** nameElements, [NativeTypeName("const IRoMetaDataLocator &")] IRoMetaDataLocator* metaDataLocator, Guid* iid, ROPARAMIIDHANDLE* pExtra);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoFreeParameterizedTypeExtra"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    public static extern void RoFreeParameterizedTypeExtra(ROPARAMIIDHANDLE extra);
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.RoParameterizedTypeExtraGetTypeSignature"]/*'/>
    [DllImport("combase", ExactSpelling = true)]
    [return: NativeTypeName("PCSTR")]
    public static extern sbyte* RoParameterizedTypeExtraGetTypeSignature(ROPARAMIIDHANDLE extra);
}