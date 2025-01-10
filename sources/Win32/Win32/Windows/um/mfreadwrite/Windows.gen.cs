// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("mfreadwrite", ExactSpelling = true)]
    public static extern HRESULT MFCreateSourceReaderFromURL(
        [NativeTypeName("LPCWSTR")] ushort* pwszURL,
        IMFAttributes pAttributes,
        IMFSourceReader* ppSourceReader
    );

    [DllImport("mfreadwrite", ExactSpelling = true)]
    public static extern HRESULT MFCreateSourceReaderFromByteStream(
        IMFByteStream pByteStream,
        IMFAttributes pAttributes,
        IMFSourceReader* ppSourceReader
    );

    [DllImport("mfreadwrite", ExactSpelling = true)]
    public static extern HRESULT MFCreateSourceReaderFromMediaSource(
        IMFMediaSource pMediaSource,
        IMFAttributes pAttributes,
        IMFSourceReader* ppSourceReader
    );

    [DllImport("mfreadwrite", ExactSpelling = true)]
    public static extern HRESULT MFCreateSinkWriterFromURL(
        [NativeTypeName("LPCWSTR")] ushort* pwszOutputURL,
        IMFByteStream pByteStream,
        IMFAttributes pAttributes,
        IMFSinkWriter* ppSinkWriter
    );

    [DllImport("mfreadwrite", ExactSpelling = true)]
    public static extern HRESULT MFCreateSinkWriterFromMediaSink(
        IMFMediaSink pMediaSink,
        IMFAttributes pAttributes,
        IMFSinkWriter* ppSinkWriter
    );
}
