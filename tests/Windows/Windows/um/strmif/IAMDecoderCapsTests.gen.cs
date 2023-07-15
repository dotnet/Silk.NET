// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IAMDecoderCaps"/> struct.</summary>
public static unsafe partial class IAMDecoderCapsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAMDecoderCaps"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAMDecoderCaps).GUID, Is.EqualTo(IID_IAMDecoderCaps));
    }

    /// <summary>Validates that the <see cref = "IAMDecoderCaps"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAMDecoderCaps>(), Is.EqualTo(sizeof(IAMDecoderCaps)));
    }

    /// <summary>Validates that the <see cref = "IAMDecoderCaps"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAMDecoderCaps).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAMDecoderCaps"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAMDecoderCaps), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAMDecoderCaps), Is.EqualTo(4));
        }
    }
}