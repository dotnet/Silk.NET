// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "X3DAUDIO_EMITTER"/> struct.</summary>
public static unsafe partial class X3DAUDIO_EMITTERTests
{
    /// <summary>Validates that the <see cref = "X3DAUDIO_EMITTER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<X3DAUDIO_EMITTER>(), Is.EqualTo(sizeof(X3DAUDIO_EMITTER)));
    }

    /// <summary>Validates that the <see cref = "X3DAUDIO_EMITTER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(X3DAUDIO_EMITTER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "X3DAUDIO_EMITTER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(X3DAUDIO_EMITTER), Is.EqualTo(128));
        }
        else
        {
            Assert.That(sizeof(X3DAUDIO_EMITTER), Is.EqualTo(100));
        }
    }
}