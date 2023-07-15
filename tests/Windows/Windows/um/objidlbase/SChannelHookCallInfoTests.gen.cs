// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SChannelHookCallInfo"/> struct.</summary>
public static unsafe partial class SChannelHookCallInfoTests
{
    /// <summary>Validates that the <see cref = "SChannelHookCallInfo"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SChannelHookCallInfo>(), Is.EqualTo(sizeof(SChannelHookCallInfo)));
    }

    /// <summary>Validates that the <see cref = "SChannelHookCallInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SChannelHookCallInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SChannelHookCallInfo"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SChannelHookCallInfo), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(SChannelHookCallInfo), Is.EqualTo(48));
        }
    }
}