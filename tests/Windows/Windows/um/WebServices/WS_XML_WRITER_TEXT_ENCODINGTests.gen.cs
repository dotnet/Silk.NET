// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WS_XML_WRITER_TEXT_ENCODING"/> struct.</summary>
public static unsafe partial class WS_XML_WRITER_TEXT_ENCODINGTests
{
    /// <summary>Validates that the <see cref = "WS_XML_WRITER_TEXT_ENCODING"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WS_XML_WRITER_TEXT_ENCODING>(), Is.EqualTo(sizeof(WS_XML_WRITER_TEXT_ENCODING)));
    }

    /// <summary>Validates that the <see cref = "WS_XML_WRITER_TEXT_ENCODING"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WS_XML_WRITER_TEXT_ENCODING).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WS_XML_WRITER_TEXT_ENCODING"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WS_XML_WRITER_TEXT_ENCODING), Is.EqualTo(8));
    }
}