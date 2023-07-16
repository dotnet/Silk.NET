// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITfCompartmentEventSink"/> struct.</summary>
public static unsafe partial class ITfCompartmentEventSinkTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITfCompartmentEventSink"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITfCompartmentEventSink).GUID, Is.EqualTo(IID_ITfCompartmentEventSink));
    }

    /// <summary>Validates that the <see cref = "ITfCompartmentEventSink"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITfCompartmentEventSink>(), Is.EqualTo(sizeof(ITfCompartmentEventSink)));
    }

    /// <summary>Validates that the <see cref = "ITfCompartmentEventSink"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfCompartmentEventSink).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITfCompartmentEventSink"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfCompartmentEventSink), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfCompartmentEventSink), Is.EqualTo(4));
        }
    }
}