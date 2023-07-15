// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IDiscFormat2TrackAtOnce"/> struct.</summary>
public static unsafe partial class IDiscFormat2TrackAtOnceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDiscFormat2TrackAtOnce"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDiscFormat2TrackAtOnce).GUID, Is.EqualTo(IID_IDiscFormat2TrackAtOnce));
    }

    /// <summary>Validates that the <see cref = "IDiscFormat2TrackAtOnce"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDiscFormat2TrackAtOnce>(), Is.EqualTo(sizeof(IDiscFormat2TrackAtOnce)));
    }

    /// <summary>Validates that the <see cref = "IDiscFormat2TrackAtOnce"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDiscFormat2TrackAtOnce).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDiscFormat2TrackAtOnce"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDiscFormat2TrackAtOnce), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDiscFormat2TrackAtOnce), Is.EqualTo(4));
        }
    }
}