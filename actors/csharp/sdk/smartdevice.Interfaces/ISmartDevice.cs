﻿using Dapr.Actors;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace smartdevice.Interfaces;
public interface ISmartDevice : IActor
{
    Task<string> SetDataAsync(SmokeDetector device);
    Task<SmokeDetector> GetDataAsync();
    Task RegisterReminder();
    Task UnregisterReminder();
    Task RegisterTimer();
    Task UnregisterTimer();
}

public class SmokeDetector
{   
    public string Name { get; set; } = default!;
    public string Status { get; set; } = default!;
    public decimal Battery { get; set; } = default!;
    public string Location { get; set; } = default!;
    public decimal FirmwareVersion { get; set; } = default!;
    public string SerialNo { get; set; } = default!;
    public string MACAddress { get; set; } = default!;
    public DateTime LastUpdate { get; set; } = default!;

    public override string ToString()
    {
        return $"Name: {this.Name}, Status: {this.Status}, Battery: {this.Battery}, Location: {this.Location}, " +
                $"FirmwareVersion: {this.FirmwareVersion}, SerialNo: {this.SerialNo}, MACAddress: {this.MACAddress}, LastUpdate: {this.LastUpdate}";
    }
}
