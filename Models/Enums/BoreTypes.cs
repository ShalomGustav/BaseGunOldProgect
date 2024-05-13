namespace BaseGun.Models.Enums;

/// <summary>
/// Оружие по типу канала ствола
/// 0 - Гладкоствольное оружие
/// 1 - Оружие с изменяющимся диаметром ствола
/// 2 - Гладкоствольное оружие с нарезной частью ствола
/// 3 - Нарезное оружие
/// </summary>
public enum BoreTypes
{
    SmoothboreWeapons = 0,
    WeaponWithAVariableBarrelDiameter = 1,
    SmoothboreWeaponWithARifledPartOfTheBarrel = 2,
    RifledWeapons = 3,
}