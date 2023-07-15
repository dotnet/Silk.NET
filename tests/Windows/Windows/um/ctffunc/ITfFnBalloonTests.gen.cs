// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITfFnBalloon"/> struct.</summary>
public static unsafe partial class ITfFnBalloonTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITfFnBalloon"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITfFnBalloon).GUID, Is.EqualTo(IID_ITfFnBalloon));
    }

    /// <summary>Validates that the <see cref = "ITfFnBalloon"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITfFnBalloon>(), Is.EqualTo(sizeof(ITfFnBalloon)));
    }

    /// <summary>Validates that the <see cref = "ITfFnBalloon"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfFnBalloon).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITfFnBalloon"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfFnBalloon), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfFnBalloon), Is.EqualTo(4));
        }
    }
}