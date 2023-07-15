// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.MFVideoFormat;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MFVideoFormat"/> class.</summary>
public static partial class MFVideoFormatTests
{
    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_Base"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_BaseTest()
    {
        Assert.That(MFVideoFormat_Base, Is.EqualTo(new Guid(0x00000000, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_RGB32"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_RGB32Test()
    {
        Assert.That(MFVideoFormat_RGB32, Is.EqualTo(new Guid(22, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_ARGB32"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_ARGB32Test()
    {
        Assert.That(MFVideoFormat_ARGB32, Is.EqualTo(new Guid(21, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_RGB24"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_RGB24Test()
    {
        Assert.That(MFVideoFormat_RGB24, Is.EqualTo(new Guid(20, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_RGB555"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_RGB555Test()
    {
        Assert.That(MFVideoFormat_RGB555, Is.EqualTo(new Guid(24, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_RGB565"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_RGB565Test()
    {
        Assert.That(MFVideoFormat_RGB565, Is.EqualTo(new Guid(23, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_RGB8"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_RGB8Test()
    {
        Assert.That(MFVideoFormat_RGB8, Is.EqualTo(new Guid(41, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_L8"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_L8Test()
    {
        Assert.That(MFVideoFormat_L8, Is.EqualTo(new Guid(50, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_L16"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_L16Test()
    {
        Assert.That(MFVideoFormat_L16, Is.EqualTo(new Guid(81, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_D16"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_D16Test()
    {
        Assert.That(MFVideoFormat_D16, Is.EqualTo(new Guid(80, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_AI44"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_AI44Test()
    {
        Assert.That(MFVideoFormat_AI44, Is.EqualTo(new Guid(unchecked((((uint)(0x41493434) & 0xFF) << 24) | (((uint)(0x41493434) & 0xFF00) << 8) | (((uint)(0x41493434) & 0xFF0000) >> 8) | (((uint)(0x41493434) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_AYUV"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_AYUVTest()
    {
        Assert.That(MFVideoFormat_AYUV, Is.EqualTo(new Guid(unchecked((((uint)(0x41595556) & 0xFF) << 24) | (((uint)(0x41595556) & 0xFF00) << 8) | (((uint)(0x41595556) & 0xFF0000) >> 8) | (((uint)(0x41595556) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_YUY2"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_YUY2Test()
    {
        Assert.That(MFVideoFormat_YUY2, Is.EqualTo(new Guid(unchecked((((uint)(0x59555932) & 0xFF) << 24) | (((uint)(0x59555932) & 0xFF00) << 8) | (((uint)(0x59555932) & 0xFF0000) >> 8) | (((uint)(0x59555932) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_YVYU"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_YVYUTest()
    {
        Assert.That(MFVideoFormat_YVYU, Is.EqualTo(new Guid(unchecked((((uint)(0x59565955) & 0xFF) << 24) | (((uint)(0x59565955) & 0xFF00) << 8) | (((uint)(0x59565955) & 0xFF0000) >> 8) | (((uint)(0x59565955) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_YVU9"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_YVU9Test()
    {
        Assert.That(MFVideoFormat_YVU9, Is.EqualTo(new Guid(unchecked((((uint)(0x59565539) & 0xFF) << 24) | (((uint)(0x59565539) & 0xFF00) << 8) | (((uint)(0x59565539) & 0xFF0000) >> 8) | (((uint)(0x59565539) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_UYVY"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_UYVYTest()
    {
        Assert.That(MFVideoFormat_UYVY, Is.EqualTo(new Guid(unchecked((((uint)(0x55595659) & 0xFF) << 24) | (((uint)(0x55595659) & 0xFF00) << 8) | (((uint)(0x55595659) & 0xFF0000) >> 8) | (((uint)(0x55595659) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_NV11"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_NV11Test()
    {
        Assert.That(MFVideoFormat_NV11, Is.EqualTo(new Guid(unchecked((((uint)(0x4E563131) & 0xFF) << 24) | (((uint)(0x4E563131) & 0xFF00) << 8) | (((uint)(0x4E563131) & 0xFF0000) >> 8) | (((uint)(0x4E563131) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_NV12"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_NV12Test()
    {
        Assert.That(MFVideoFormat_NV12, Is.EqualTo(new Guid(unchecked((((uint)(0x4E563132) & 0xFF) << 24) | (((uint)(0x4E563132) & 0xFF00) << 8) | (((uint)(0x4E563132) & 0xFF0000) >> 8) | (((uint)(0x4E563132) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_NV21"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_NV21Test()
    {
        Assert.That(MFVideoFormat_NV21, Is.EqualTo(new Guid(unchecked((((uint)(0x4E563231) & 0xFF) << 24) | (((uint)(0x4E563231) & 0xFF00) << 8) | (((uint)(0x4E563231) & 0xFF0000) >> 8) | (((uint)(0x4E563231) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_YV12"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_YV12Test()
    {
        Assert.That(MFVideoFormat_YV12, Is.EqualTo(new Guid(unchecked((((uint)(0x59563132) & 0xFF) << 24) | (((uint)(0x59563132) & 0xFF00) << 8) | (((uint)(0x59563132) & 0xFF0000) >> 8) | (((uint)(0x59563132) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_I420"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_I420Test()
    {
        Assert.That(MFVideoFormat_I420, Is.EqualTo(new Guid(unchecked((((uint)(0x49343230) & 0xFF) << 24) | (((uint)(0x49343230) & 0xFF00) << 8) | (((uint)(0x49343230) & 0xFF0000) >> 8) | (((uint)(0x49343230) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_IYUV"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_IYUVTest()
    {
        Assert.That(MFVideoFormat_IYUV, Is.EqualTo(new Guid(unchecked((((uint)(0x49595556) & 0xFF) << 24) | (((uint)(0x49595556) & 0xFF00) << 8) | (((uint)(0x49595556) & 0xFF0000) >> 8) | (((uint)(0x49595556) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_Y210"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_Y210Test()
    {
        Assert.That(MFVideoFormat_Y210, Is.EqualTo(new Guid(unchecked((((uint)(0x59323130) & 0xFF) << 24) | (((uint)(0x59323130) & 0xFF00) << 8) | (((uint)(0x59323130) & 0xFF0000) >> 8) | (((uint)(0x59323130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_Y216"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_Y216Test()
    {
        Assert.That(MFVideoFormat_Y216, Is.EqualTo(new Guid(unchecked((((uint)(0x59323136) & 0xFF) << 24) | (((uint)(0x59323136) & 0xFF00) << 8) | (((uint)(0x59323136) & 0xFF0000) >> 8) | (((uint)(0x59323136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_Y410"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_Y410Test()
    {
        Assert.That(MFVideoFormat_Y410, Is.EqualTo(new Guid(unchecked((((uint)(0x59343130) & 0xFF) << 24) | (((uint)(0x59343130) & 0xFF00) << 8) | (((uint)(0x59343130) & 0xFF0000) >> 8) | (((uint)(0x59343130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_Y416"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_Y416Test()
    {
        Assert.That(MFVideoFormat_Y416, Is.EqualTo(new Guid(unchecked((((uint)(0x59343136) & 0xFF) << 24) | (((uint)(0x59343136) & 0xFF00) << 8) | (((uint)(0x59343136) & 0xFF0000) >> 8) | (((uint)(0x59343136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_Y41P"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_Y41PTest()
    {
        Assert.That(MFVideoFormat_Y41P, Is.EqualTo(new Guid(unchecked((((uint)(0x59343150) & 0xFF) << 24) | (((uint)(0x59343150) & 0xFF00) << 8) | (((uint)(0x59343150) & 0xFF0000) >> 8) | (((uint)(0x59343150) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_Y41T"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_Y41TTest()
    {
        Assert.That(MFVideoFormat_Y41T, Is.EqualTo(new Guid(unchecked((((uint)(0x59343154) & 0xFF) << 24) | (((uint)(0x59343154) & 0xFF00) << 8) | (((uint)(0x59343154) & 0xFF0000) >> 8) | (((uint)(0x59343154) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_Y42T"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_Y42TTest()
    {
        Assert.That(MFVideoFormat_Y42T, Is.EqualTo(new Guid(unchecked((((uint)(0x59343254) & 0xFF) << 24) | (((uint)(0x59343254) & 0xFF00) << 8) | (((uint)(0x59343254) & 0xFF0000) >> 8) | (((uint)(0x59343254) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_P210"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_P210Test()
    {
        Assert.That(MFVideoFormat_P210, Is.EqualTo(new Guid(unchecked((((uint)(0x50323130) & 0xFF) << 24) | (((uint)(0x50323130) & 0xFF00) << 8) | (((uint)(0x50323130) & 0xFF0000) >> 8) | (((uint)(0x50323130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_P216"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_P216Test()
    {
        Assert.That(MFVideoFormat_P216, Is.EqualTo(new Guid(unchecked((((uint)(0x50323136) & 0xFF) << 24) | (((uint)(0x50323136) & 0xFF00) << 8) | (((uint)(0x50323136) & 0xFF0000) >> 8) | (((uint)(0x50323136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_P010"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_P010Test()
    {
        Assert.That(MFVideoFormat_P010, Is.EqualTo(new Guid(unchecked((((uint)(0x50303130) & 0xFF) << 24) | (((uint)(0x50303130) & 0xFF00) << 8) | (((uint)(0x50303130) & 0xFF0000) >> 8) | (((uint)(0x50303130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_P016"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_P016Test()
    {
        Assert.That(MFVideoFormat_P016, Is.EqualTo(new Guid(unchecked((((uint)(0x50303136) & 0xFF) << 24) | (((uint)(0x50303136) & 0xFF00) << 8) | (((uint)(0x50303136) & 0xFF0000) >> 8) | (((uint)(0x50303136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_v210"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_v210Test()
    {
        Assert.That(MFVideoFormat_v210, Is.EqualTo(new Guid(unchecked((((uint)(0x76323130) & 0xFF) << 24) | (((uint)(0x76323130) & 0xFF00) << 8) | (((uint)(0x76323130) & 0xFF0000) >> 8) | (((uint)(0x76323130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_v216"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_v216Test()
    {
        Assert.That(MFVideoFormat_v216, Is.EqualTo(new Guid(unchecked((((uint)(0x76323136) & 0xFF) << 24) | (((uint)(0x76323136) & 0xFF00) << 8) | (((uint)(0x76323136) & 0xFF0000) >> 8) | (((uint)(0x76323136) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_v410"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_v410Test()
    {
        Assert.That(MFVideoFormat_v410, Is.EqualTo(new Guid(unchecked((((uint)(0x76343130) & 0xFF) << 24) | (((uint)(0x76343130) & 0xFF00) << 8) | (((uint)(0x76343130) & 0xFF0000) >> 8) | (((uint)(0x76343130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_MP43"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_MP43Test()
    {
        Assert.That(MFVideoFormat_MP43, Is.EqualTo(new Guid(unchecked((((uint)(0x4D503433) & 0xFF) << 24) | (((uint)(0x4D503433) & 0xFF00) << 8) | (((uint)(0x4D503433) & 0xFF0000) >> 8) | (((uint)(0x4D503433) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_MP4S"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_MP4STest()
    {
        Assert.That(MFVideoFormat_MP4S, Is.EqualTo(new Guid(unchecked((((uint)(0x4D503453) & 0xFF) << 24) | (((uint)(0x4D503453) & 0xFF00) << 8) | (((uint)(0x4D503453) & 0xFF0000) >> 8) | (((uint)(0x4D503453) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_M4S2"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_M4S2Test()
    {
        Assert.That(MFVideoFormat_M4S2, Is.EqualTo(new Guid(unchecked((((uint)(0x4D345332) & 0xFF) << 24) | (((uint)(0x4D345332) & 0xFF00) << 8) | (((uint)(0x4D345332) & 0xFF0000) >> 8) | (((uint)(0x4D345332) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_MP4V"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_MP4VTest()
    {
        Assert.That(MFVideoFormat_MP4V, Is.EqualTo(new Guid(unchecked((((uint)(0x4D503456) & 0xFF) << 24) | (((uint)(0x4D503456) & 0xFF00) << 8) | (((uint)(0x4D503456) & 0xFF0000) >> 8) | (((uint)(0x4D503456) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_WMV1"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_WMV1Test()
    {
        Assert.That(MFVideoFormat_WMV1, Is.EqualTo(new Guid(unchecked((((uint)(0x574D5631) & 0xFF) << 24) | (((uint)(0x574D5631) & 0xFF00) << 8) | (((uint)(0x574D5631) & 0xFF0000) >> 8) | (((uint)(0x574D5631) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_WMV2"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_WMV2Test()
    {
        Assert.That(MFVideoFormat_WMV2, Is.EqualTo(new Guid(unchecked((((uint)(0x574D5632) & 0xFF) << 24) | (((uint)(0x574D5632) & 0xFF00) << 8) | (((uint)(0x574D5632) & 0xFF0000) >> 8) | (((uint)(0x574D5632) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_WMV3"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_WMV3Test()
    {
        Assert.That(MFVideoFormat_WMV3, Is.EqualTo(new Guid(unchecked((((uint)(0x574D5633) & 0xFF) << 24) | (((uint)(0x574D5633) & 0xFF00) << 8) | (((uint)(0x574D5633) & 0xFF0000) >> 8) | (((uint)(0x574D5633) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_WVC1"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_WVC1Test()
    {
        Assert.That(MFVideoFormat_WVC1, Is.EqualTo(new Guid(unchecked((((uint)(0x57564331) & 0xFF) << 24) | (((uint)(0x57564331) & 0xFF00) << 8) | (((uint)(0x57564331) & 0xFF0000) >> 8) | (((uint)(0x57564331) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_MSS1"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_MSS1Test()
    {
        Assert.That(MFVideoFormat_MSS1, Is.EqualTo(new Guid(unchecked((((uint)(0x4D535331) & 0xFF) << 24) | (((uint)(0x4D535331) & 0xFF00) << 8) | (((uint)(0x4D535331) & 0xFF0000) >> 8) | (((uint)(0x4D535331) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_MSS2"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_MSS2Test()
    {
        Assert.That(MFVideoFormat_MSS2, Is.EqualTo(new Guid(unchecked((((uint)(0x4D535332) & 0xFF) << 24) | (((uint)(0x4D535332) & 0xFF00) << 8) | (((uint)(0x4D535332) & 0xFF0000) >> 8) | (((uint)(0x4D535332) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_MPG1"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_MPG1Test()
    {
        Assert.That(MFVideoFormat_MPG1, Is.EqualTo(new Guid(unchecked((((uint)(0x4D504731) & 0xFF) << 24) | (((uint)(0x4D504731) & 0xFF00) << 8) | (((uint)(0x4D504731) & 0xFF0000) >> 8) | (((uint)(0x4D504731) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_DVSL"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_DVSLTest()
    {
        Assert.That(MFVideoFormat_DVSL, Is.EqualTo(new Guid(unchecked((((uint)(0x6476736C) & 0xFF) << 24) | (((uint)(0x6476736C) & 0xFF00) << 8) | (((uint)(0x6476736C) & 0xFF0000) >> 8) | (((uint)(0x6476736C) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_DVSD"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_DVSDTest()
    {
        Assert.That(MFVideoFormat_DVSD, Is.EqualTo(new Guid(unchecked((((uint)(0x64767364) & 0xFF) << 24) | (((uint)(0x64767364) & 0xFF00) << 8) | (((uint)(0x64767364) & 0xFF0000) >> 8) | (((uint)(0x64767364) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_DVHD"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_DVHDTest()
    {
        Assert.That(MFVideoFormat_DVHD, Is.EqualTo(new Guid(unchecked((((uint)(0x64766864) & 0xFF) << 24) | (((uint)(0x64766864) & 0xFF00) << 8) | (((uint)(0x64766864) & 0xFF0000) >> 8) | (((uint)(0x64766864) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_DV25"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_DV25Test()
    {
        Assert.That(MFVideoFormat_DV25, Is.EqualTo(new Guid(unchecked((((uint)(0x64763235) & 0xFF) << 24) | (((uint)(0x64763235) & 0xFF00) << 8) | (((uint)(0x64763235) & 0xFF0000) >> 8) | (((uint)(0x64763235) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_DV50"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_DV50Test()
    {
        Assert.That(MFVideoFormat_DV50, Is.EqualTo(new Guid(unchecked((((uint)(0x64763530) & 0xFF) << 24) | (((uint)(0x64763530) & 0xFF00) << 8) | (((uint)(0x64763530) & 0xFF0000) >> 8) | (((uint)(0x64763530) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_DVH1"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_DVH1Test()
    {
        Assert.That(MFVideoFormat_DVH1, Is.EqualTo(new Guid(unchecked((((uint)(0x64766831) & 0xFF) << 24) | (((uint)(0x64766831) & 0xFF00) << 8) | (((uint)(0x64766831) & 0xFF0000) >> 8) | (((uint)(0x64766831) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_DVC"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_DVCTest()
    {
        Assert.That(MFVideoFormat_DVC, Is.EqualTo(new Guid(unchecked((((uint)(0x64766320) & 0xFF) << 24) | (((uint)(0x64766320) & 0xFF00) << 8) | (((uint)(0x64766320) & 0xFF0000) >> 8) | (((uint)(0x64766320) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_H264"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_H264Test()
    {
        Assert.That(MFVideoFormat_H264, Is.EqualTo(new Guid(unchecked((((uint)(0x48323634) & 0xFF) << 24) | (((uint)(0x48323634) & 0xFF00) << 8) | (((uint)(0x48323634) & 0xFF0000) >> 8) | (((uint)(0x48323634) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_H265"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_H265Test()
    {
        Assert.That(MFVideoFormat_H265, Is.EqualTo(new Guid(unchecked((((uint)(0x48323635) & 0xFF) << 24) | (((uint)(0x48323635) & 0xFF00) << 8) | (((uint)(0x48323635) & 0xFF0000) >> 8) | (((uint)(0x48323635) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_MJPG"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_MJPGTest()
    {
        Assert.That(MFVideoFormat_MJPG, Is.EqualTo(new Guid(unchecked((((uint)(0x4D4A5047) & 0xFF) << 24) | (((uint)(0x4D4A5047) & 0xFF00) << 8) | (((uint)(0x4D4A5047) & 0xFF0000) >> 8) | (((uint)(0x4D4A5047) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_420O"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_420OTest()
    {
        Assert.That(MFVideoFormat_420O, Is.EqualTo(new Guid(unchecked((((uint)(0x3432304F) & 0xFF) << 24) | (((uint)(0x3432304F) & 0xFF00) << 8) | (((uint)(0x3432304F) & 0xFF0000) >> 8) | (((uint)(0x3432304F) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_HEVC"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_HEVCTest()
    {
        Assert.That(MFVideoFormat_HEVC, Is.EqualTo(new Guid(unchecked((((uint)(0x48455643) & 0xFF) << 24) | (((uint)(0x48455643) & 0xFF00) << 8) | (((uint)(0x48455643) & 0xFF0000) >> 8) | (((uint)(0x48455643) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_HEVC_ES"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_HEVC_ESTest()
    {
        Assert.That(MFVideoFormat_HEVC_ES, Is.EqualTo(new Guid(unchecked((((uint)(0x48455653) & 0xFF) << 24) | (((uint)(0x48455653) & 0xFF00) << 8) | (((uint)(0x48455653) & 0xFF0000) >> 8) | (((uint)(0x48455653) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_VP80"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_VP80Test()
    {
        Assert.That(MFVideoFormat_VP80, Is.EqualTo(new Guid(unchecked((((uint)(0x56503830) & 0xFF) << 24) | (((uint)(0x56503830) & 0xFF00) << 8) | (((uint)(0x56503830) & 0xFF0000) >> 8) | (((uint)(0x56503830) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_VP90"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_VP90Test()
    {
        Assert.That(MFVideoFormat_VP90, Is.EqualTo(new Guid(unchecked((((uint)(0x56503930) & 0xFF) << 24) | (((uint)(0x56503930) & 0xFF00) << 8) | (((uint)(0x56503930) & 0xFF0000) >> 8) | (((uint)(0x56503930) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_ORAW"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_ORAWTest()
    {
        Assert.That(MFVideoFormat_ORAW, Is.EqualTo(new Guid(unchecked((((uint)(0x4F524157) & 0xFF) << 24) | (((uint)(0x4F524157) & 0xFF00) << 8) | (((uint)(0x4F524157) & 0xFF0000) >> 8) | (((uint)(0x4F524157) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_H263"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_H263Test()
    {
        Assert.That(MFVideoFormat_H263, Is.EqualTo(new Guid(unchecked((((uint)(0x48323633) & 0xFF) << 24) | (((uint)(0x48323633) & 0xFF00) << 8) | (((uint)(0x48323633) & 0xFF0000) >> 8) | (((uint)(0x48323633) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_A2R10G10B10"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_A2R10G10B10Test()
    {
        Assert.That(MFVideoFormat_A2R10G10B10, Is.EqualTo(new Guid(31, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_A16B16G16R16F"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_A16B16G16R16FTest()
    {
        Assert.That(MFVideoFormat_A16B16G16R16F, Is.EqualTo(new Guid(113, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_VP10"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_VP10Test()
    {
        Assert.That(MFVideoFormat_VP10, Is.EqualTo(new Guid(unchecked((((uint)(0x56503130) & 0xFF) << 24) | (((uint)(0x56503130) & 0xFF00) << 8) | (((uint)(0x56503130) & 0xFF0000) >> 8) | (((uint)(0x56503130) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_AV1"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_AV1Test()
    {
        Assert.That(MFVideoFormat_AV1, Is.EqualTo(new Guid(unchecked((((uint)(0x41563031) & 0xFF) << 24) | (((uint)(0x41563031) & 0xFF00) << 8) | (((uint)(0x41563031) & 0xFF0000) >> 8) | (((uint)(0x41563031) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_Theora"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_TheoraTest()
    {
        Assert.That(MFVideoFormat_Theora, Is.EqualTo(new Guid(unchecked((((uint)(0x7468656F) & 0xFF) << 24) | (((uint)(0x7468656F) & 0xFF00) << 8) | (((uint)(0x7468656F) & 0xFF0000) >> 8) | (((uint)(0x7468656F) & 0xFF000000) >> 24)), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_H264_ES"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_H264_ESTest()
    {
        Assert.That(MFVideoFormat_H264_ES, Is.EqualTo(new Guid(0x3f40f4f0, 0x5622, 0x4ff8, 0xb6, 0xd8, 0xa1, 0x7a, 0x58, 0x4b, 0xee, 0x5e)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_MPEG2"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_MPEG2Test()
    {
        Assert.That(MFVideoFormat_MPEG2, Is.EqualTo(new Guid(0xe06d8026, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_H264_HDCP"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_H264_HDCPTest()
    {
        Assert.That(MFVideoFormat_H264_HDCP, Is.EqualTo(new Guid(0x5d0ce9dd, 0x9817, 0x49da, 0xbd, 0xfd, 0xf5, 0xf5, 0xb9, 0x8f, 0x18, 0xa6)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_HEVC_HDCP"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_HEVC_HDCPTest()
    {
        Assert.That(MFVideoFormat_HEVC_HDCP, Is.EqualTo(new Guid(0x3cfe0fe6, 0x05c4, 0x47dc, 0x9d, 0x70, 0x4b, 0xdb, 0x29, 0x59, 0x72, 0x0f)));
    }

    /// <summary>Validates that the value of the <see cref = "MFVideoFormat_Base_HDCP"/> property is correct.</summary>
    [Test]
    public static void MFVideoFormat_Base_HDCPTest()
    {
        Assert.That(MFVideoFormat_Base_HDCP, Is.EqualTo(new Guid(0xeac3b9d5, 0xbd14, 0x4237, 0x8f, 0x1f, 0xba, 0xb4, 0x28, 0xe4, 0x93, 0x12)));
    }
}