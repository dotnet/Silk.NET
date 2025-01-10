// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "HTTP_REQUEST_PROPERTY_STREAM_ERROR"/> struct.</summary>
public static unsafe partial class HTTP_REQUEST_PROPERTY_STREAM_ERRORTests
{
    /// <summary>Validates that the <see cref = "HTTP_REQUEST_PROPERTY_STREAM_ERROR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<HTTP_REQUEST_PROPERTY_STREAM_ERROR>(),
            Is.EqualTo(sizeof(HTTP_REQUEST_PROPERTY_STREAM_ERROR))
        );
    }

    /// <summary>Validates that the <see cref = "HTTP_REQUEST_PROPERTY_STREAM_ERROR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTTP_REQUEST_PROPERTY_STREAM_ERROR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTTP_REQUEST_PROPERTY_STREAM_ERROR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTTP_REQUEST_PROPERTY_STREAM_ERROR), Is.EqualTo(4));
    }
}
