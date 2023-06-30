static class Badge
{
	public static string Print(int? id, string name, string? department)
	{
		string dep = (department ?? "OWNER").ToUpper();
		return id == null ? $"{name} - {dep}" : $"[{id}] - {name} - {dep}";
	}
}
