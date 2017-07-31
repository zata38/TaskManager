using System;
namespace TaskManagerBackend
{
    [Flags]
    public enum TaskFlags
    {
		None = 0x0,
		School = 0x1,
		Work = 0x2,
		Apartment = 0x4,
		Personal = 0x8
    }
}
