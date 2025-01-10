// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CFSTR
{
    [NativeTypeName("#define CFSTR_MIME_NULL NULL")]
    public const int CFSTR_MIME_NULL = 0;

    [NativeTypeName("#define CFSTR_MIME_TEXT (TEXT(\"text/plain\"))")]
    public const string CFSTR_MIME_TEXT = ("text/plain");

    [NativeTypeName("#define CFSTR_MIME_RICHTEXT (TEXT(\"text/richtext\"))")]
    public const string CFSTR_MIME_RICHTEXT = ("text/richtext");

    [NativeTypeName("#define CFSTR_MIME_MANIFEST (TEXT(\"text/cache-manifest\"))")]
    public const string CFSTR_MIME_MANIFEST = ("text/cache-manifest");

    [NativeTypeName("#define CFSTR_MIME_WEBVTT (TEXT(\"text/vtt\"))")]
    public const string CFSTR_MIME_WEBVTT = ("text/vtt");

    [NativeTypeName("#define CFSTR_MIME_X_BITMAP (TEXT(\"image/x-xbitmap\"))")]
    public const string CFSTR_MIME_X_BITMAP = ("image/x-xbitmap");

    [NativeTypeName("#define CFSTR_MIME_POSTSCRIPT (TEXT(\"application/postscript\"))")]
    public const string CFSTR_MIME_POSTSCRIPT = ("application/postscript");

    [NativeTypeName("#define CFSTR_MIME_AIFF (TEXT(\"audio/aiff\"))")]
    public const string CFSTR_MIME_AIFF = ("audio/aiff");

    [NativeTypeName("#define CFSTR_MIME_BASICAUDIO (TEXT(\"audio/basic\"))")]
    public const string CFSTR_MIME_BASICAUDIO = ("audio/basic");

    [NativeTypeName("#define CFSTR_MIME_WAV (TEXT(\"audio/wav\"))")]
    public const string CFSTR_MIME_WAV = ("audio/wav");

    [NativeTypeName("#define CFSTR_MIME_X_WAV (TEXT(\"audio/x-wav\"))")]
    public const string CFSTR_MIME_X_WAV = ("audio/x-wav");

    [NativeTypeName("#define CFSTR_MIME_GIF (TEXT(\"image/gif\"))")]
    public const string CFSTR_MIME_GIF = ("image/gif");

    [NativeTypeName("#define CFSTR_MIME_PJPEG (TEXT(\"image/pjpeg\"))")]
    public const string CFSTR_MIME_PJPEG = ("image/pjpeg");

    [NativeTypeName("#define CFSTR_MIME_JPEG (TEXT(\"image/jpeg\"))")]
    public const string CFSTR_MIME_JPEG = ("image/jpeg");

    [NativeTypeName("#define CFSTR_MIME_TIFF (TEXT(\"image/tiff\"))")]
    public const string CFSTR_MIME_TIFF = ("image/tiff");

    [NativeTypeName("#define CFSTR_MIME_JPEG_XR (TEXT(\"image/vnd.ms-photo\"))")]
    public const string CFSTR_MIME_JPEG_XR = ("image/vnd.ms-photo");

    [NativeTypeName("#define CFSTR_MIME_PNG (TEXT(\"image/png\"))")]
    public const string CFSTR_MIME_PNG = ("image/png");

    [NativeTypeName("#define CFSTR_MIME_DDS (TEXT(\"image/vnd.ms-dds\"))")]
    public const string CFSTR_MIME_DDS = ("image/vnd.ms-dds");

    [NativeTypeName("#define CFSTR_MIME_X_PNG (TEXT(\"image/x-png\"))")]
    public const string CFSTR_MIME_X_PNG = ("image/x-png");

    [NativeTypeName("#define CFSTR_MIME_X_ICON (TEXT(\"image/x-icon\"))")]
    public const string CFSTR_MIME_X_ICON = ("image/x-icon");

    [NativeTypeName("#define CFSTR_MIME_SVG_XML (TEXT(\"image/svg+xml\"))")]
    public const string CFSTR_MIME_SVG_XML = ("image/svg+xml");

    [NativeTypeName("#define CFSTR_MIME_BMP (TEXT(\"image/bmp\"))")]
    public const string CFSTR_MIME_BMP = ("image/bmp");

    [NativeTypeName("#define CFSTR_MIME_X_EMF (TEXT(\"image/x-emf\"))")]
    public const string CFSTR_MIME_X_EMF = ("image/x-emf");

    [NativeTypeName("#define CFSTR_MIME_X_WMF (TEXT(\"image/x-wmf\"))")]
    public const string CFSTR_MIME_X_WMF = ("image/x-wmf");

    [NativeTypeName("#define CFSTR_MIME_AVI (TEXT(\"video/avi\"))")]
    public const string CFSTR_MIME_AVI = ("video/avi");

    [NativeTypeName("#define CFSTR_MIME_MPEG (TEXT(\"video/mpeg\"))")]
    public const string CFSTR_MIME_MPEG = ("video/mpeg");

    [NativeTypeName("#define CFSTR_MIME_FRACTALS (TEXT(\"application/fractals\"))")]
    public const string CFSTR_MIME_FRACTALS = ("application/fractals");

    [NativeTypeName("#define CFSTR_MIME_RAWDATA (TEXT(\"application/octet-stream\"))")]
    public const string CFSTR_MIME_RAWDATA = ("application/octet-stream");

    [NativeTypeName("#define CFSTR_MIME_RAWDATASTRM (TEXT(\"application/octet-stream\"))")]
    public const string CFSTR_MIME_RAWDATASTRM = ("application/octet-stream");

    [NativeTypeName("#define CFSTR_MIME_PDF (TEXT(\"application/pdf\"))")]
    public const string CFSTR_MIME_PDF = ("application/pdf");

    [NativeTypeName("#define CFSTR_MIME_HTA (TEXT(\"application/hta\"))")]
    public const string CFSTR_MIME_HTA = ("application/hta");

    [NativeTypeName("#define CFSTR_MIME_APP_XML (TEXT(\"application/xml\"))")]
    public const string CFSTR_MIME_APP_XML = ("application/xml");

    [NativeTypeName("#define CFSTR_MIME_XHTML (TEXT(\"application/xhtml+xml\"))")]
    public const string CFSTR_MIME_XHTML = ("application/xhtml+xml");

    [NativeTypeName("#define CFSTR_MIME_X_AIFF (TEXT(\"audio/x-aiff\"))")]
    public const string CFSTR_MIME_X_AIFF = ("audio/x-aiff");

    [NativeTypeName("#define CFSTR_MIME_X_REALAUDIO (TEXT(\"audio/x-pn-realaudio\"))")]
    public const string CFSTR_MIME_X_REALAUDIO = ("audio/x-pn-realaudio");

    [NativeTypeName("#define CFSTR_MIME_XBM (TEXT(\"image/xbm\"))")]
    public const string CFSTR_MIME_XBM = ("image/xbm");

    [NativeTypeName("#define CFSTR_MIME_QUICKTIME (TEXT(\"video/quicktime\"))")]
    public const string CFSTR_MIME_QUICKTIME = ("video/quicktime");

    [NativeTypeName("#define CFSTR_MIME_X_MSVIDEO (TEXT(\"video/x-msvideo\"))")]
    public const string CFSTR_MIME_X_MSVIDEO = ("video/x-msvideo");

    [NativeTypeName("#define CFSTR_MIME_X_SGI_MOVIE (TEXT(\"video/x-sgi-movie\"))")]
    public const string CFSTR_MIME_X_SGI_MOVIE = ("video/x-sgi-movie");

    [NativeTypeName("#define CFSTR_MIME_X_MIXED_REPLACE (TEXT(\"multipart/x-mixed-replace\"))")]
    public const string CFSTR_MIME_X_MIXED_REPLACE = ("multipart/x-mixed-replace");

    [NativeTypeName("#define CFSTR_MIME_HTML (TEXT(\"text/html\"))")]
    public const string CFSTR_MIME_HTML = ("text/html");

    [NativeTypeName("#define CFSTR_MIME_XML (TEXT(\"text/xml\"))")]
    public const string CFSTR_MIME_XML = ("text/xml");

    [NativeTypeName("#define CFSTR_MIME_TTML (TEXT(\"application/ttml+xml\"))")]
    public const string CFSTR_MIME_TTML = ("application/ttml+xml");

    [NativeTypeName("#define CFSTR_MIME_TTAF (TEXT(\"application/ttaf+xml\"))")]
    public const string CFSTR_MIME_TTAF = ("application/ttaf+xml");

    [NativeTypeName("#define CFSTR_MIME_X_JAVASCRIPT (TEXT(\"application/x-javascript\"))")]
    public const string CFSTR_MIME_X_JAVASCRIPT = ("application/x-javascript");

    [NativeTypeName("#define CFSTR_MIME_TEXT_JSON (TEXT(\"text/json\"))")]
    public const string CFSTR_MIME_TEXT_JSON = ("text/json");

    [NativeTypeName("#define CFSTR_MIME_APPLICATION_JAVASCRIPT (TEXT(\"application/javascript\"))")]
    public const string CFSTR_MIME_APPLICATION_JAVASCRIPT = ("application/javascript");
}
