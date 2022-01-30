using System;
using System.Linq;
using Silk.NET.Vulkan;
using Xunit;

namespace PrototypeStructChaining.Test;

public class TestChainMetadata
{
    [Fact]
    public void TestClrType()
    {
        Assert.Equal(typeof(DeviceCreateInfo), StructureType.DeviceCreateInfo.ClrType());
    }
    
    [Fact]
    public void TestStructureType()
    {
        Assert.Equal(StructureType.DeviceCreateInfo, typeof(DeviceCreateInfo).StructureType());
        Assert.Null(typeof(PhysicalDeviceFeatures).StructureType());
    }
    
    [Fact]
    public void TestIsChainStart()
    {
        Assert.True(StructureType.DeviceCreateInfo.IsChainStart());
        Assert.True(typeof(DeviceCreateInfo).IsChainStart());
        Assert.False(StructureType.PhysicalDeviceDescriptorIndexingFeatures.IsChainStart());
        Assert.False(typeof(PhysicalDeviceDescriptorIndexingFeatures).IsChainStart());
    }
    
    [Fact]
    public void TestIsChainable()
    {
        Assert.True(StructureType.DeviceCreateInfo.IsChainable());
        Assert.True(typeof(DeviceCreateInfo).IsChainable());
        Assert.True(StructureType.PhysicalDeviceDescriptorIndexingFeatures.IsChainable());
        Assert.True(typeof(PhysicalDeviceDescriptorIndexingFeatures).IsChainable());
    }
    
    [Fact]
    public void TestCanExtend()
    {
        Assert.True(StructureType.PhysicalDeviceFeatures2.CanExtend(StructureType.DeviceCreateInfo));
        Assert.False(StructureType.DeviceCreateInfo.CanExtend(StructureType.PhysicalDeviceFeatures2));
        Assert.True(typeof(PhysicalDeviceFeatures2).CanExtend(typeof(DeviceCreateInfo)));
        Assert.False(typeof(DeviceCreateInfo).CanExtend(typeof(PhysicalDeviceFeatures2)));
    }
    
    [Fact]
    public void TestCanBeExtendedBy()
    {
        Assert.False(StructureType.PhysicalDeviceFeatures2.CanBeExtendedBy(StructureType.DeviceCreateInfo));
        Assert.True(StructureType.DeviceCreateInfo.CanBeExtendedBy(StructureType.PhysicalDeviceFeatures2));
        Assert.False(typeof(PhysicalDeviceFeatures2).CanBeExtendedBy(typeof(DeviceCreateInfo)));
        Assert.True(typeof(DeviceCreateInfo).CanBeExtendedBy(typeof(PhysicalDeviceFeatures2)));
    }
}
