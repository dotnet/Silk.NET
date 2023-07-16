// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IThumbnailCapture"/> struct.</summary>
public static unsafe partial class IThumbnailCaptureTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IThumbnailCapture"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IThumbnailCapture).GUID, Is.EqualTo(IID_IThumbnailCapture));
    }

    /// <summary>Validates that the <see cref = "IThumbnailCapture"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IThumbnailCapture>(), Is.EqualTo(sizeof(IThumbnailCapture)));
    }

    /// <summary>Validates that the <see cref = "IThumbnailCapture"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IThumbnailCapture).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IThumbnailCapture"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IThumbnailCapture), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IThumbnailCapture), Is.EqualTo(4));
        }
    }
}