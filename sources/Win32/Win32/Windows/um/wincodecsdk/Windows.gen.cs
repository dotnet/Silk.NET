// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("windowscodecs", ExactSpelling = true)]
    public static extern HRESULT WICMatchMetadataContent(
        [NativeTypeName("const GUID &")] Guid* guidContainerFormat,
        [NativeTypeName("const GUID *")] Guid* pguidVendor,
        IStream pIStream,
        Guid* pguidMetadataFormat
    );

    [DllImport("windowscodecs", ExactSpelling = true)]
    public static extern HRESULT WICSerializeMetadataContent(
        [NativeTypeName("const GUID &")] Guid* guidContainerFormat,
        IWICMetadataWriter pIWriter,
        [NativeTypeName("DWORD")] uint dwPersistOptions,
        IStream pIStream
    );

    [DllImport("windowscodecs", ExactSpelling = true)]
    public static extern HRESULT WICGetMetadataContentSize(
        [NativeTypeName("const GUID &")] Guid* guidContainerFormat,
        IWICMetadataWriter pIWriter,
        ULARGE_INTEGER* pcbSize
    );
}
