// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IWICDdsDecoder"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IWICDdsDecoderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWICDdsDecoder"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWICDdsDecoder).GUID, Is.EqualTo(IID_IWICDdsDecoder));
    }

    /// <summary>Validates that the <see cref = "IWICDdsDecoder"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IWICDdsDecoder>(), Is.EqualTo(sizeof(IWICDdsDecoder)));
    }

    /// <summary>Validates that the <see cref = "IWICDdsDecoder"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWICDdsDecoder).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWICDdsDecoder"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWICDdsDecoder), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWICDdsDecoder), Is.EqualTo(4));
        }
    }
}