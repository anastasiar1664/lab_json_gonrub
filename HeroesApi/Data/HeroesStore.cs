using HeroesApi.Models;

namespace HeroesApi.Data;

public static class HeroesStore
{
    public static List<Hero> Heroes { get; } = new()
    {
        new Hero
        {
            Id = 1,
            Name = "Адидас Про",
            RealName = "Володя",
            Universe = Universe.IvanZolo2004,
            PowerLevel = 60,
            Powers = new() {"метание кроссовком", "разделить одну картошку на десятерых", "пояснить за шмот"},
            Weapon = new() {Name = "Спортивка", IsRanged = true },
            InternalNotes = "соперник иваназоло2004"
        },
        new Hero
        {
            Id = 2,
            Name = "Ш-общительная",
            RealName = "Марина",
            Universe = Universe.IvanZolo2004,
            PowerLevel = 80,
            Powers = new() {"понижает интеллект цели", "присасывается к цели", "имеет армию защитников"},
            Weapon = new() {Name = "Пикми Палка", IsRanged = false },
            InternalNotes = "союзница иваназоло2004"
        },
        new Hero
        {
            Id = 3,
            Name = "Монстр Фимоз",
            RealName = "Иван",
            Universe = Universe.IvanZolo2004,
            PowerLevel = 101,
            Powers = new() {"огненное дыхание из жопы", "очень сильный", "неуловимый", "регенерация"},
            Weapon = new() {Name = "Неизвестно", IsRanged = true },
            InternalNotes = "главный враг иваназоло2004, его вторая личность"
        },
        new Hero
        {
            Id = 4,
            Name = "Vazя",
            RealName = "Вася",
            Universe = Universe.Cats,
            PowerLevel = 99,
            Powers = new() {"очень крутой"},
            Weapon = new() {Name = "Бутылка пива", IsRanged = true },
            InternalNotes = "очень очень крутой"
        },
        new Hero
        {
            Id = 5,
            Name = "Маша",
            RealName = "Маша",
            Universe = Universe.Cats,
            PowerLevel = 0,
            Powers = new() {"очень тупая"},
            Weapon = new() {Name = "Кружки в ТГ", IsRanged = true },
            InternalNotes = "на самом деле очень умная"
        },
        new Hero
        {
            Id = 6,
            Name = "Доу Доу",
            RealName = "Доу Доу",
            Universe = Universe.Cats,
            PowerLevel = 70,
            Powers = new() {"кушать остренький снек латяо", "чилл с мандаринкой"},
            Weapon = new() {Name = "Китайский снек латяо", IsRanged = false },
            InternalNotes = "ойойой как остренько"
        },
    };
}