// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IPropertyStoreCapabilities"/> struct.</summary>
public static unsafe partial class IPropertyStoreCapabilitiesTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPropertyStoreCapabilities"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPropertyStoreCapabilities).GUID, Is.EqualTo(IID_IPropertyStoreCapabilities));
    }

    /// <summary>Validates that the <see cref = "IPropertyStoreCapabilities"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPropertyStoreCapabilities>(), Is.EqualTo(sizeof(IPropertyStoreCapabilities)));
    }

    /// <summary>Validates that the <see cref = "IPropertyStoreCapabilities"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPropertyStoreCapabilities).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPropertyStoreCapabilities"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPropertyStoreCapabilities), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPropertyStoreCapabilities), Is.EqualTo(4));
        }
    }
}