// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDWriteFontDownloadListener"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IDWriteFontDownloadListenerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDWriteFontDownloadListener"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWriteFontDownloadListener).GUID, Is.EqualTo(IID_IDWriteFontDownloadListener));
    }

    /// <summary>Validates that the <see cref = "IDWriteFontDownloadListener"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWriteFontDownloadListener>(), Is.EqualTo(sizeof(IDWriteFontDownloadListener)));
    }

    /// <summary>Validates that the <see cref = "IDWriteFontDownloadListener"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWriteFontDownloadListener).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDWriteFontDownloadListener"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWriteFontDownloadListener), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWriteFontDownloadListener), Is.EqualTo(4));
        }
    }
}