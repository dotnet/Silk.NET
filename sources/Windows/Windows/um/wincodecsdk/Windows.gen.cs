// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WICMatchMetadataContent"]/*'/>
    [DllImport("windowscodecs", ExactSpelling = true)]
    public static extern HRESULT WICMatchMetadataContent([NativeTypeName("const GUID &")] Guid* guidContainerFormat, [NativeTypeName("const GUID *")] Guid* pguidVendor, IStream* pIStream, Guid* pguidMetadataFormat);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WICSerializeMetadataContent"]/*'/>
    [DllImport("windowscodecs", ExactSpelling = true)]
    public static extern HRESULT WICSerializeMetadataContent([NativeTypeName("const GUID &")] Guid* guidContainerFormat, IWICMetadataWriter* pIWriter, [NativeTypeName("DWORD")] uint dwPersistOptions, IStream* pIStream);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WICGetMetadataContentSize"]/*'/>
    [DllImport("windowscodecs", ExactSpelling = true)]
    public static extern HRESULT WICGetMetadataContentSize([NativeTypeName("const GUID &")] Guid* guidContainerFormat, IWICMetadataWriter* pIWriter, ULARGE_INTEGER* pcbSize);
}