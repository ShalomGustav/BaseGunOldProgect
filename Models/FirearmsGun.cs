using BaseGun.Extensions;
using BaseGun.Models.Common;
using BaseGun.Models.Enums;

namespace BaseGun.Models;

/// <summary>
/// Базовый класс огнестрельного оружия
/// Caliber - Калибр (double)
/// GunType - Вид огнестрельного оружия
/// ExposureType - Тип оружия по способу воздействия на цель
/// AppointmentType - Типы оружия по назначению
/// BoreType - Оружие по типу канала ствола
/// CaliberType - Тип оружия по калибру
/// NumberOfCharges - Тип оружия по количеству зарядов
/// </summary>
public class FirearmsGun : Gun
{
    public virtual double Caliber { get; set; }
    public virtual GunTypes GunType { get; set; }
    public virtual ExposureTypes ExposureType { get; set; }
    public virtual AppointmentTypes AppointmentType { get; set; }
    public BoreTypes BoreType { get; set; }
    public CaliberTypes CaliberType { get; set; }
    public NumberOfChargesTypes NumberOfCharges { get; set; }
    
    public override string ToString()
    {
        var response = $"Название: {Name} \n\r"
                           + $"Описаине: {Description} \n\r"
                           + $"Калибр: {Caliber} \n\r"
                           + $"Вид оружия: {GunType} \n\r"
                           + $"Воздействие на цель: {ExposureType} \n\r"
                           + $"По назначению: {AppointmentType} \n\r"
                           + $"Канал ствола: {BoreType} \n\r"
                           + $"Тип калибра: {CaliberType} \n\r"
                           + $"Количество зарядов: {NumberOfCharges}";
        return response;
    }
}