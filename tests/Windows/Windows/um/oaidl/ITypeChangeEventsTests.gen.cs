// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITypeChangeEvents"/> struct.</summary>
public static unsafe partial class ITypeChangeEventsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITypeChangeEvents"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITypeChangeEvents).GUID, Is.EqualTo(IID_ITypeChangeEvents));
    }

    /// <summary>Validates that the <see cref = "ITypeChangeEvents"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITypeChangeEvents>(), Is.EqualTo(sizeof(ITypeChangeEvents)));
    }

    /// <summary>Validates that the <see cref = "ITypeChangeEvents"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITypeChangeEvents).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITypeChangeEvents"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITypeChangeEvents), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITypeChangeEvents), Is.EqualTo(4));
        }
    }
}