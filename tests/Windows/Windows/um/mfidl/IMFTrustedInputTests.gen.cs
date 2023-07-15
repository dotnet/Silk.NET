// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFTrustedInput"/> struct.</summary>
public static unsafe partial class IMFTrustedInputTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFTrustedInput"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFTrustedInput).GUID, Is.EqualTo(IID_IMFTrustedInput));
    }

    /// <summary>Validates that the <see cref = "IMFTrustedInput"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFTrustedInput>(), Is.EqualTo(sizeof(IMFTrustedInput)));
    }

    /// <summary>Validates that the <see cref = "IMFTrustedInput"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFTrustedInput).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFTrustedInput"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFTrustedInput), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFTrustedInput), Is.EqualTo(4));
        }
    }
}