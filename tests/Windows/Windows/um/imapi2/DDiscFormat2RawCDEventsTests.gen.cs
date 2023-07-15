// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DDiscFormat2RawCDEvents"/> struct.</summary>
public static unsafe partial class DDiscFormat2RawCDEventsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DDiscFormat2RawCDEvents"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DDiscFormat2RawCDEvents).GUID, Is.EqualTo(IID_DDiscFormat2RawCDEvents));
    }

    /// <summary>Validates that the <see cref = "DDiscFormat2RawCDEvents"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DDiscFormat2RawCDEvents>(), Is.EqualTo(sizeof(DDiscFormat2RawCDEvents)));
    }

    /// <summary>Validates that the <see cref = "DDiscFormat2RawCDEvents"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DDiscFormat2RawCDEvents).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DDiscFormat2RawCDEvents"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DDiscFormat2RawCDEvents), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DDiscFormat2RawCDEvents), Is.EqualTo(4));
        }
    }
}