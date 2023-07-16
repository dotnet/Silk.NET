// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SPWORDPRONUNCIATIONLIST"/> struct.</summary>
public static unsafe partial class SPWORDPRONUNCIATIONLISTTests
{
    /// <summary>Validates that the <see cref = "SPWORDPRONUNCIATIONLIST"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SPWORDPRONUNCIATIONLIST>(), Is.EqualTo(sizeof(SPWORDPRONUNCIATIONLIST)));
    }

    /// <summary>Validates that the <see cref = "SPWORDPRONUNCIATIONLIST"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SPWORDPRONUNCIATIONLIST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SPWORDPRONUNCIATIONLIST"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SPWORDPRONUNCIATIONLIST), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(SPWORDPRONUNCIATIONLIST), Is.EqualTo(12));
        }
    }
}