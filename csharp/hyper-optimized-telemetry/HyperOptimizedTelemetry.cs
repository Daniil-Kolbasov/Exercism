using System;
using System.Collections.Generic;

public static class TelemetryBuffer
{
	public static byte[] ToBuffer(long reading)
	{
		List<byte> buffer = new();
		byte[] bytes;

		switch (reading)
		{
			// long: from -9_223_372_036_854_775_808 to -2_147_483_649
			case < int.MinValue:
				bytes = BitConverter.GetBytes(reading);
				buffer.Add((byte)(256 - bytes.Length));
				buffer.AddRange(bytes);
				break;
			// int: from -2_147_483_648 to -32_769
			case < short.MinValue:
				bytes = BitConverter.GetBytes((int)reading);
				buffer.Add((byte)(256 - bytes.Length));
				buffer.AddRange(bytes);
				break;
			// short: from -32_768 to -1
			case < 0:
				bytes = BitConverter.GetBytes((short)reading);
				buffer.Add((byte)(256 - bytes.Length));
				buffer.AddRange(bytes);
				break;
			// ushort: from 0 to 65_535
			case <= ushort.MaxValue:
				bytes = BitConverter.GetBytes((ushort)reading);
				buffer.Add((byte)bytes.Length);
				buffer.AddRange(bytes);
				break;
			// int: from 65_536 to 2_147_483_647
			case <= int.MaxValue:
				bytes = BitConverter.GetBytes((int)reading);
				buffer.Add((byte)(256 - bytes.Length));
				buffer.AddRange(bytes);
				break;
			// uint: from 2_147_483_648 to 4_294_967_295
			case <= uint.MaxValue:
				bytes = BitConverter.GetBytes((uint)reading);
				buffer.Add((byte)bytes.Length);
				buffer.AddRange(bytes);
				break;
			// log: from 4_294_967_296 to 9_223_372_036_854_775_807
			default:
				bytes = BitConverter.GetBytes(reading);
				buffer.Add((byte)(256 - bytes.Length));
				buffer.AddRange(bytes);
				break;
		}

		while (buffer.Count < 9)
		{
			buffer.Add(0);
		}

		return buffer.ToArray();
	}

	public static long FromBuffer(byte[] buffer)
	{
		int prefix = buffer[0] == 4 || buffer[0] == 2 ? buffer[0] : buffer[0] - 256;

		return (prefix) switch
		{
			-8 => BitConverter.ToInt64(buffer.AsSpan()[1..]),
			-4 => BitConverter.ToInt32(buffer.AsSpan()[1..]),
			-2 => BitConverter.ToInt16(buffer.AsSpan()[1..]),
			2 => BitConverter.ToUInt16(buffer.AsSpan()[1..]),
			4 => BitConverter.ToUInt32(buffer.AsSpan()[1..]),
			_ => 0,
		};
	}
}
