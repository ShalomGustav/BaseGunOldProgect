namespace BaseGun.Models.Common;

/// <summary>
/// Базовый класс оружия
/// Поля:
/// Name - Имя оружия
/// Description - Описание
/// </summary>
public class Gun
{
    public virtual string Name { get; set; }
    public virtual string Description { get; set; }
}